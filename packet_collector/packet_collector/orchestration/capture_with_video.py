"""Run Windows packet capture and camera recording as coordinated processes."""

from __future__ import annotations

import argparse
import os
import signal
import subprocess
import sys
import time
from pathlib import Path

from packet_collector.platform_defaults import default_gps_port, default_tmp_capture_dir


def _new_process_group_flags() -> int:
    return subprocess.CREATE_NEW_PROCESS_GROUP if os.name == "nt" else 0


def _stop_process(
    process: subprocess.Popen[object] | None,
    timeout: float | None = 15.0,
) -> None:
    if process is None or process.poll() is not None:
        return
    try:
        stop_file = os.environ.get("COLLECTOR_STOP_FILE")
        if stop_file and Path(stop_file).exists():
            try:
                process.wait(timeout=3.0)
                return
            except subprocess.TimeoutExpired:
                pass
        if os.name == "nt":
            process.send_signal(signal.CTRL_BREAK_EVENT)
        else:
            process.send_signal(signal.SIGINT)
        process.wait(timeout=timeout)
    except (OSError, subprocess.TimeoutExpired):
        process.terminate()
        try:
            process.wait(timeout=5)
        except subprocess.TimeoutExpired:
            process.kill()
            process.wait()


def _wait_for_session(captures_dir: Path, previous: set[Path], process: subprocess.Popen[object]) -> Path:
    deadline = time.monotonic() + 15.0
    while time.monotonic() < deadline:
        candidates = sorted(
            (
                path
                for path in captures_dir.glob("session_*")
                if path not in previous and (path / "session_meta.json").is_file()
            ),
            key=lambda path: path.stat().st_mtime,
        )
        if candidates:
            return candidates[-1]
        if process.poll() is not None:
            break
        time.sleep(0.2)
    raise RuntimeError("capture-session did not create a session directory; inspect the capture log")


def run_capture_with_video(
    project_dir: Path,
    iface: str,
    peer_ip: str,
    duration: int,
    camera: str = "0",
    video_format: str = "mp4",
    gps_port: str | None = None,
    gps_baudrate: int = 115200,
    with_gps: bool = True,
    display_export: bool = True,
    display_data_dir: Path | None = None,
    display_source: str = "BJTU",
    window_seconds: float = 1.0,
    window_retention: int = 100,
    tmp_capture_dir: Path | None = None,
    final_capture_dir: Path | None = None,
    video_fps: float = 20.0,
    video_width: int | None = None,
    video_height: int | None = None,
    network_events: bool = False,
    network_events_interval: float = 10.0,
    file_size_kb: int = 51200,
    max_files: int = 200,
    port: int | None = None,
    direction: str = "in",
) -> Path:
    """Coordinate capture and recording without requiring Bash or PowerShell."""
    video_format = video_format.strip().lower()
    if video_format not in {"avi", "mp4"}:
        raise ValueError("video_format must be avi or mp4")
    project_dir = project_dir.resolve()
    workspace_dir = project_dir.parent
    captures_dir = (final_capture_dir or (project_dir / "captures")).resolve()
    tmp_dir = (tmp_capture_dir or default_tmp_capture_dir()).resolve()
    display_dir = (display_data_dir or (workspace_dir / "iov-data-collector-(ue-stack)" / "datas")).resolve()
    captures_dir.mkdir(parents=True, exist_ok=True)
    previous = set(captures_dir.glob("session_*"))
    log_file = Path(os.environ.get("CAPTURE_LOG", str(Path(os.environ.get("TEMP", ".")) / "packet_collector_capture_with_video.log"))).resolve()
    log_file.parent.mkdir(parents=True, exist_ok=True)

    capture_command = [
        sys.executable,
        "-m",
        "packet_collector.cli",
        "capture-session",
        "tcp",
        "--iface",
        iface,
        "--peer-only",
        peer_ip,
        "--duration",
        str(duration),
        "--direction",
        direction,
        "--file-size-kb",
        str(file_size_kb),
        "--max-files",
        str(max_files),
        "--window-mode",
        "online-analysis",
        "--window-seconds",
        str(window_seconds),
        "--window-retention",
        str(window_retention),
        "--tmp-capture-dir",
        str(tmp_dir),
        "--final-capture-dir",
        str(captures_dir),
    ]
    if port is not None:
        capture_command.extend(["--port", str(port)])
    if network_events:
        capture_command.extend(
            ["--network-events", "--network-events-interval", str(network_events_interval)]
        )
    if with_gps:
        capture_command.extend(["--with-gps", "--gps-port", gps_port or default_gps_port(), "--gps-baudrate", str(gps_baudrate)])
    if display_export:
        if not with_gps:
            raise ValueError("display export requires GPS CSV output; enable with_gps")
        capture_command.extend(["--display-data-dir", str(display_dir), "--display-source", display_source])
    if os.name != "nt" and hasattr(os, "geteuid") and os.geteuid() != 0:
        capture_command.insert(0, "sudo")

    print("Starting packet capture:")
    print(subprocess.list2cmdline(capture_command))
    capture_process: subprocess.Popen[object] | None = None
    video_process: subprocess.Popen[object] | None = None
    session_dir: Path | None = None
    with log_file.open("w", encoding="utf-8") as capture_log:
        try:
            capture_process = subprocess.Popen(
                capture_command,
                cwd=project_dir,
                stdout=capture_log,
                stderr=subprocess.STDOUT,
                creationflags=_new_process_group_flags(),
            )
            session_dir = _wait_for_session(captures_dir, previous, capture_process)
            if os.name != "nt" and hasattr(os, "getuid"):
                subprocess.run(
                    ["sudo", "chown", f"{os.getuid()}:{os.getgid()}", str(session_dir)],
                    check=True,
                )
            video_output = session_dir / f"camera_recording.{video_format}"
            video_timestamps = session_dir / "camera_frame_timestamps.csv"
            video_command = [
                sys.executable,
                str(project_dir / "video" / "record_camera.py"),
                "--camera",
                camera,
                "--duration",
                str(duration),
                "--fps",
                str(video_fps),
                "--output",
                str(video_output),
                "--timestamps-file",
                str(video_timestamps),
                "--no-window",
                "--no-overlay",
                "--preview-host",
                "127.0.0.1",
                "--preview-port",
                "8765",
                "--preview-fps",
                "10",
            ]
            if video_width is not None:
                video_command.extend(["--width", str(video_width)])
            if video_height is not None:
                video_command.extend(["--height", str(video_height)])
            print(f"Session directory: {session_dir}")
            print("Starting camera:")
            print(subprocess.list2cmdline(video_command))
            video_process = subprocess.Popen(
                video_command,
                cwd=project_dir,
                creationflags=_new_process_group_flags(),
            )
            while capture_process.poll() is None and video_process.poll() is None:
                time.sleep(0.25)
        except KeyboardInterrupt:
            print("Stopping capture and camera; waiting for CSV finalization...")
        finally:
            _stop_process(video_process)
            print("Waiting for packet analysis and CSV finalization...")
            _stop_process(capture_process, timeout=None)

    if session_dir is None:
        raise RuntimeError(f"capture failed before creating a session; see {log_file}")
    capture_returncode = capture_process.returncode if capture_process is not None else None
    video_returncode = video_process.returncode if video_process is not None else None
    if capture_returncode not in (0, None):
        raise RuntimeError(f"capture process failed with returncode {capture_returncode}; see {log_file}")
    if video_returncode not in (0, None):
        raise RuntimeError(f"camera process failed with returncode {video_returncode}")
    print(f"Capture log: {log_file}")
    print(f"Session directory: {session_dir}")
    if display_export:
        print(f"Display full CSV directory: {display_dir / display_source}")
        print(f"Display one-minute CSV directory: {display_dir / (display_source + '_1min')}")
    return session_dir


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(description="Run Windows packet capture and camera recording together.")
    parser.add_argument("--iface", required=True, help="dumpcap interface number, name, or NPF device")
    parser.add_argument("--peer-ip", required=True)
    parser.add_argument("--duration", type=int, default=60)
    parser.add_argument("--camera", default="0")
    parser.add_argument("--video-format", choices=("avi", "mp4"), default="mp4")
    parser.add_argument("--gps-port", default=default_gps_port())
    parser.add_argument("--gps-baudrate", type=int, default=115200)
    parser.add_argument("--no-gps", action="store_true")
    parser.add_argument("--no-display-export", action="store_true")
    parser.add_argument("--display-data-dir", type=Path)
    parser.add_argument("--display-source", default="BJTU")
    parser.add_argument("--window-seconds", type=float, default=1.0)
    parser.add_argument("--window-retention", type=int, default=100)
    parser.add_argument("--tmp-capture-dir", type=Path)
    parser.add_argument("--final-capture-dir", type=Path)
    parser.add_argument("--project-dir", type=Path, default=Path(__file__).resolve().parents[2])
    return parser


def main() -> int:
    args = build_parser().parse_args()
    try:
        run_capture_with_video(
            project_dir=args.project_dir,
            iface=args.iface,
            peer_ip=args.peer_ip,
            duration=args.duration,
            camera=args.camera,
            video_format=args.video_format,
            gps_port=args.gps_port,
            gps_baudrate=args.gps_baudrate,
            with_gps=not args.no_gps,
            display_export=not args.no_display_export,
            display_data_dir=args.display_data_dir,
            display_source=args.display_source,
            window_seconds=args.window_seconds,
            window_retention=args.window_retention,
            tmp_capture_dir=args.tmp_capture_dir,
            final_capture_dir=args.final_capture_dir,
        )
    except (RuntimeError, ValueError) as exc:
        print(f"ERROR: {exc}", file=sys.stderr)
        return 1
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
