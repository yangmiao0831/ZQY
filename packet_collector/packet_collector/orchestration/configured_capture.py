"""Run packet capture workflows from the root config.json file."""

from __future__ import annotations

import argparse
import _thread
import os
import signal
import subprocess
import sys
import threading
from dataclasses import replace
from pathlib import Path

from packet_collector.app_config import (
    DEFAULT_CONFIG_FILE,
    ConfigurationError,
    RuntimeSettings,
    apply_runtime_environment,
    load_runtime_settings,
)
from packet_collector.orchestration.capture_with_video import run_capture_with_video


def _start_stop_request_watcher() -> threading.Event | None:
    """Translate a dashboard stop request into one graceful KeyboardInterrupt."""
    stop_file_value = os.environ.get("COLLECTOR_STOP_FILE")
    if not stop_file_value:
        return None
    stop_file = Path(stop_file_value)
    watcher_stop = threading.Event()

    def watch() -> None:
        while not watcher_stop.wait(0.25):
            if not stop_file.exists():
                continue
            try:
                stop_file.parent.mkdir(parents=True, exist_ok=True)
                (stop_file.parent / "network.stopping").write_text("stopping", encoding="utf-8")
            finally:
                _thread.interrupt_main()
            return

    threading.Thread(target=watch, name="collector-stop-watcher", daemon=True).start()
    return watcher_stop


def _wait_for_process_interruptibly(
    process: subprocess.Popen[object], poll_interval: float = 0.2
) -> int:
    """Wait in short intervals so Windows can deliver Ctrl+C promptly."""
    while True:
        try:
            return process.wait(timeout=poll_interval)
        except subprocess.TimeoutExpired:
            continue


def build_capture_command(settings: RuntimeSettings) -> list[str]:
    """Build the existing capture-session command from validated settings."""
    command = [
        sys.executable,
        "-m",
        "packet_collector.cli",
        "capture-session",
        settings.packet_type,
        "--iface",
        settings.interface,
        "--peer-only",
        settings.peer_ip,
        "--duration",
        str(settings.duration_sec),
        "--direction",
        settings.direction,
        "--file-size-kb",
        str(settings.file_size_kb),
        "--max-files",
        str(settings.max_files),
        "--tmp-capture-dir",
        str(settings.tmp_capture_dir),
        "--final-capture-dir",
        str(settings.final_capture_dir),
    ]
    if settings.port is not None:
        command.extend(["--port", str(settings.port)])
    if settings.window_mode is not None:
        command.extend(
            [
                "--window-mode",
                settings.window_mode,
                "--window-seconds",
                str(settings.window_seconds),
                "--window-retention",
                str(settings.window_retention),
            ]
        )
    if settings.network_events:
        command.extend(
            ["--network-events", "--network-events-interval", str(settings.network_events_interval)]
        )
    if settings.gps_enabled:
        command.extend(
            [
                "--with-gps",
                "--gps-port",
                settings.gps_port,
                "--gps-baudrate",
                str(settings.gps_baudrate),
            ]
        )
    return command


def _with_capture_privileges(command: list[str]) -> list[str]:
    if os.name != "nt" and hasattr(os, "geteuid") and os.geteuid() != 0:
        return ["sudo", *command]
    return command


def run_configured_capture(settings: RuntimeSettings, *, with_video: bool) -> Path | None:
    """Run capture only or coordinated capture and video from one config."""
    apply_runtime_environment(settings)
    if with_video:
        stop_watcher = _start_stop_request_watcher()
        try:
            return run_capture_with_video(
                project_dir=settings.project_dir,
                iface=settings.interface,
                peer_ip=settings.peer_ip,
                duration=settings.duration_sec,
                camera=settings.camera,
                video_format=settings.video_format,
                gps_port=settings.gps_port,
                gps_baudrate=settings.gps_baudrate,
                with_gps=settings.gps_enabled,
                display_export=False,
                display_data_dir=settings.display_data_dir,
                display_source=settings.display_source,
                window_seconds=settings.window_seconds,
                window_retention=settings.window_retention,
                tmp_capture_dir=settings.tmp_capture_dir,
                final_capture_dir=settings.final_capture_dir,
                video_fps=settings.video_fps,
                video_width=settings.video_width,
                video_height=settings.video_height,
                network_events=settings.network_events,
                network_events_interval=settings.network_events_interval,
                file_size_kb=settings.file_size_kb,
                max_files=settings.max_files,
                port=settings.port,
                direction=settings.direction,
            )
        finally:
            if stop_watcher is not None:
                stop_watcher.set()

    command = _with_capture_privileges(build_capture_command(settings))
    print(f"Config file: {settings.config_file}")
    print("Starting packet capture:")
    print(subprocess.list2cmdline(command))
    process = subprocess.Popen(
        command,
        cwd=settings.project_dir,
        creationflags=subprocess.CREATE_NEW_PROCESS_GROUP if os.name == "nt" else 0,
        start_new_session=os.name != "nt",
    )
    stop_watcher = _start_stop_request_watcher()
    try:
        returncode = _wait_for_process_interruptibly(process)
    except KeyboardInterrupt:
        print("Stopping capture; waiting for queued analysis and CSV finalization...")
        if process.poll() is None:
            if os.name == "nt":
                process.send_signal(signal.CTRL_BREAK_EVENT)
            else:
                os.killpg(process.pid, signal.SIGINT)
        returncode = process.wait()
    finally:
        if stop_watcher is not None:
            stop_watcher.set()
    if returncode != 0:
        raise RuntimeError(f"capture-session failed with returncode {returncode}")
    return None


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(description="Run packet_collector using config.json.")
    parser.add_argument("--config", type=Path, default=DEFAULT_CONFIG_FILE)
    mode = parser.add_mutually_exclusive_group()
    mode.add_argument("--video", action="store_true", help="Force coordinated capture and video")
    mode.add_argument("--no-video", action="store_true", help="Force packet capture only")
    parser.add_argument("--iface", help="Temporary interface override")
    parser.add_argument("--peer-ip", help="Temporary peer IP override")
    parser.add_argument("--duration", type=int, help="Temporary duration override")
    parser.add_argument("--dry-run", action="store_true", help="Validate and print effective settings only")
    return parser


def main() -> int:
    args = build_parser().parse_args()
    try:
        settings = load_runtime_settings(args.config)
        if args.iface:
            settings = replace(settings, interface=args.iface)
        if args.peer_ip:
            settings = replace(settings, peer_ip=args.peer_ip)
        if args.duration is not None:
            if args.duration <= 0:
                raise ConfigurationError("--duration must be > 0")
            settings = replace(settings, duration_sec=args.duration)
        with_video = settings.video_enabled
        if args.video:
            with_video = True
        elif args.no_video:
            with_video = False

        apply_runtime_environment(settings)
        print(f"Config file: {settings.config_file}")
        print(f"Platform interface: {settings.interface}")
        print(f"Peer IP: {settings.peer_ip}")
        print(f"Duration: {settings.duration_sec}s")
        print(f"GPS enabled: {settings.gps_enabled}")
        print(f"Video enabled: {with_video}")
        print(f"Video format: {settings.video_format}")
        print(f"Merged CSV publish enabled: {settings.display_enabled}")
        if args.dry_run:
            print("Capture command:")
            print(subprocess.list2cmdline(_with_capture_privileges(build_capture_command(settings))))
            return 0
        run_configured_capture(settings, with_video=with_video)
    except (ConfigurationError, OSError, RuntimeError, ValueError) as exc:
        print(f"ERROR: {exc}", file=sys.stderr)
        return 1
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
