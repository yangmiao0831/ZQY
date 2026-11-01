#!/usr/bin/env python3
"""Show a live camera preview and save the same timestamped frames to a video.

The script is intentionally independent from packet_collector. It works with
OpenCV camera indexes on Windows and device paths such as /dev/video0 on Linux.
"""

from __future__ import annotations

import argparse
import _thread
import csv
from datetime import datetime
from http.server import BaseHTTPRequestHandler, ThreadingHTTPServer
import json
import os
from pathlib import Path
import threading
import time
from typing import Any


DEFAULT_OUTPUT_DIR = Path(__file__).resolve().parent / "recordings"
DEFAULT_WINDOW_NAME = "Camera Recording"
DEFAULT_PREVIEW_HOST = "127.0.0.1"
DEFAULT_PREVIEW_PORT = 8765


class LatestPreviewFrame:
    """Share only the newest JPEG frame with browser preview clients."""

    def __init__(self) -> None:
        self._condition = threading.Condition()
        self._sequence = 0
        self._jpeg: bytes | None = None
        self._published_at: float | None = None

    def publish(self, jpeg: bytes) -> None:
        with self._condition:
            self._jpeg = jpeg
            self._sequence += 1
            self._published_at = time.monotonic()
            self._condition.notify_all()

    def wait_for_frame(self, after_sequence: int, timeout: float = 1.0) -> tuple[int, bytes | None]:
        with self._condition:
            if self._sequence <= after_sequence:
                self._condition.wait(timeout)
            return self._sequence, self._jpeg

    def status(self) -> tuple[int, float | None]:
        with self._condition:
            age = None if self._published_at is None else time.monotonic() - self._published_at
            return self._sequence, age


class MjpegPreviewServer:
    """Expose the recorder's latest frame as a local MJPEG stream."""

    def __init__(self, host: str, port: int, frames: LatestPreviewFrame) -> None:
        frame_store = frames

        class PreviewHandler(BaseHTTPRequestHandler):
            def do_GET(self) -> None:  # noqa: N802 - BaseHTTPRequestHandler API
                if self.path.split("?", 1)[0] == "/health":
                    sequence, age = frame_store.status()
                    payload = json.dumps(
                        {
                            "ready": sequence > 0 and age is not None and age < 2.0,
                            "sequence": sequence,
                            "frameAgeMs": None if age is None else round(age * 1000),
                        }
                    ).encode("utf-8")
                    self.send_response(200)
                    self.send_header("Content-Type", "application/json")
                    self.send_header("Content-Length", str(len(payload)))
                    self.end_headers()
                    self.wfile.write(payload)
                    return
                if self.path.split("?", 1)[0] != "/stream.mjpg":
                    self.send_error(404)
                    return
                self.send_response(200)
                self.send_header("Cache-Control", "no-store, no-cache, must-revalidate")
                self.send_header("Pragma", "no-cache")
                self.send_header("Content-Type", "multipart/x-mixed-replace; boundary=frame")
                self.end_headers()
                sequence = 0
                try:
                    while True:
                        next_sequence, jpeg = frame_store.wait_for_frame(sequence)
                        if jpeg is None or next_sequence == sequence:
                            continue
                        sequence = next_sequence
                        self.wfile.write(b"--frame\r\n")
                        self.wfile.write(b"Content-Type: image/jpeg\r\n")
                        self.wfile.write(f"Content-Length: {len(jpeg)}\r\n\r\n".encode("ascii"))
                        self.wfile.write(jpeg)
                        self.wfile.write(b"\r\n")
                        self.wfile.flush()
                except (BrokenPipeError, ConnectionResetError, ConnectionAbortedError):
                    return

            def log_message(self, _format: str, *_args: object) -> None:
                return

        self._server = ThreadingHTTPServer((host, port), PreviewHandler)
        self._server.daemon_threads = True
        self._thread = threading.Thread(
            target=self._server.serve_forever,
            name="camera-mjpeg-preview",
            daemon=True,
        )

    def start(self) -> None:
        self._thread.start()

    def stop(self) -> None:
        self._server.shutdown()
        self._server.server_close()
        self._thread.join(timeout=2.0)


def _start_stop_request_watcher() -> threading.Event | None:
    """Let the dashboard stop request finalize the video writer normally."""
    stop_file_value = os.environ.get("COLLECTOR_STOP_FILE")
    if not stop_file_value:
        return None
    stop_file = Path(stop_file_value)
    watcher_stop = threading.Event()

    def watch() -> None:
        while not watcher_stop.wait(0.25):
            if stop_file.exists():
                _thread.interrupt_main()
                return

    threading.Thread(target=watch, name="camera-stop-watcher", daemon=True).start()
    return watcher_stop


def parse_camera_source(value: str) -> int | str:
    """Convert a numeric camera argument to an index, keeping paths as paths."""

    try:
        return int(value)
    except ValueError:
        return value


def timestamp_text(now: datetime | None = None) -> str:
    """Return the overlay timestamp with seconds as the smallest unit."""

    return (now or datetime.now()).strftime("%Y-%m-%d %H:%M:%S")


def default_output_file(output_dir: Path, now: datetime | None = None) -> Path:
    """Build a timestamped MP4 output path."""

    stamp = (now or datetime.now()).strftime("%Y%m%d_%H%M%S")
    return output_dir / f"recording_{stamp}.mp4"


def _load_cv2() -> Any:
    try:
        import cv2
    except ImportError as exc:
        raise RuntimeError(
            "OpenCV is required. Install it with 'python -m pip install opencv-python' "
            "or, on Ubuntu, 'sudo apt install python3-opencv'."
        ) from exc
    return cv2


def _overlay_lines(frame: Any, lines: list[str], cv2: Any) -> Any:
    """Draw timestamp and optional GPS lines in the top-right corner."""

    height, width = frame.shape[:2]
    font = cv2.FONT_HERSHEY_SIMPLEX
    font_scale = max(0.4, min(0.65, width / 2400.0))
    thickness = 1 if width < 1600 else 2
    padding = max(7, int(width / 180.0))
    sizes = [cv2.getTextSize(line, font, font_scale, thickness) for line in lines]
    text_width = max((size[0][0] for size in sizes), default=0)
    text_height = max((size[0][1] for size in sizes), default=0)
    baseline = max((size[1] for size in sizes), default=0)
    line_height = text_height + baseline + max(2, padding // 3)

    x = max(padding, width - text_width - padding)
    y = padding + text_height
    cv2.rectangle(
        frame,
        (x - padding // 2, padding // 2),
        (
            min(width - 1, x + text_width + padding // 2),
            y + line_height * max(0, len(lines) - 1) + baseline + padding // 2,
        ),
        (0, 0, 0),
        cv2.FILLED,
    )
    for index, line in enumerate(lines):
        cv2.putText(
            frame,
            line,
            (x, y + index * line_height),
            font,
            font_scale,
            (255, 255, 255),
            thickness,
            cv2.LINE_AA,
        )
    return frame


def _overlay_timestamp(frame: Any, text: str, cv2: Any) -> Any:
    """Draw one timestamp line; retained for simple callers and tests."""

    return _overlay_lines(frame, [text], cv2)


class LatestGpsCsvReader:
    """Keep the latest valid metrics row from an appended CSV file."""

    def __init__(self, csv_file: Path, poll_interval: float = 0.5) -> None:
        self.csv_file = Path(csv_file)
        self.poll_interval = poll_interval
        self._stop_event = threading.Event()
        self._thread: threading.Thread | None = None
        self._lock = threading.Lock()
        self._offset = 0
        self._buffer = ""
        self._fieldnames: list[str] | None = None
        self._latest_row: dict[str, str] = {}

    def start(self) -> None:
        if self._thread is None:
            self._thread = threading.Thread(target=self._run, name="gps-csv-reader", daemon=True)
            self._thread.start()

    def stop(self) -> None:
        self._stop_event.set()
        if self._thread is not None:
            self._thread.join(timeout=max(1.0, self.poll_interval + 0.5))

    def get_latest_row(self) -> dict[str, str]:
        with self._lock:
            return dict(self._latest_row)

    def display_lines(self) -> list[str]:
        """Return all supported CSV metrics as compact overlay lines."""
        row = self.get_latest_row()

        def value(name: str, suffix: str = "", decimals: int | None = None) -> str:
            raw = (row.get(name) or "").strip()
            if not raw:
                return "--"
            if decimals is not None:
                try:
                    return f"{float(raw):.{decimals}f}{suffix}"
                except ValueError:
                    pass
            return f"{raw}{suffix}"

        latitude = (row.get("gcj02_latitude") or "").strip()
        longitude = (row.get("gcj02_longitude") or "").strip()
        if latitude and longitude:
            try:
                gps = f"{float(latitude):.6f}, {float(longitude):.6f}"
            except ValueError:
                gps = f"{latitude}, {longitude}"
        else:
            gps = "--"
        metric_time = (row.get("timestamp") or "").strip()
        if len(metric_time) >= 8:
            metric_time = metric_time[-12:].split(".", 1)[0]
        return [
            f"Index: {value('index')}",
            f"CSV time: {metric_time or '--'}",
            f"Avg RTT: {value('avg_rtt_ms', ' ms', 3)}",
            f"Jitter: {value('jitter_ms', ' ms', 3)}",
            f"Throughput: {value('throughput_bps', ' bps', 0)}",
            f"Loss: {value('loss_rate', '', 4)}",
            f"GCJ-02: {gps}",
        ]

    def _run(self) -> None:
        while not self._stop_event.is_set():
            try:
                self._read_new_rows()
            except (OSError, UnicodeError, csv.Error):
                # The collector may be creating or replacing the CSV. Keep the
                # previous fix and retry on the next poll.
                pass
            self._stop_event.wait(self.poll_interval)

    def _read_new_rows(self) -> None:
        if not self.csv_file.exists():
            return
        if self.csv_file.stat().st_size < self._offset:
            self._offset = 0
            self._buffer = ""
            self._fieldnames = None

        with self.csv_file.open("r", encoding="utf-8", newline="") as handle:
            handle.seek(self._offset)
            self._buffer += handle.read()
            self._offset = handle.tell()

        lines = self._buffer.splitlines(keepends=True)
        if lines and not lines[-1].endswith(("\n", "\r")):
            self._buffer = lines.pop()
        else:
            self._buffer = ""

        for line in lines:
            line = line.strip()
            if not line:
                continue
            if self._fieldnames is None:
                self._fieldnames = next(csv.reader([line]))
                continue
            row = next(csv.DictReader([line], fieldnames=self._fieldnames))
            with self._lock:
                self._latest_row = {
                    str(key): str(value or "") for key, value in row.items() if key is not None
                }


def _open_camera(source: int | str, cv2: Any) -> Any:
    """Prefer the native camera backend, then fall back to OpenCV defaults."""

    if os.name == "nt" and isinstance(source, int):
        # Media Foundation is more reliable for the integrated camera on this
        # Windows host. DirectShow can report an open device while returning
        # intermittent or black frames, so retain it only as a fallback.
        for backend_name in ("CAP_MSMF", "CAP_DSHOW"):
            if not hasattr(cv2, backend_name):
                continue
            capture = cv2.VideoCapture(source, getattr(cv2, backend_name))
            if capture.isOpened():
                return capture
            capture.release()
    if os.name != "nt" and hasattr(cv2, "CAP_V4L2"):
        capture = cv2.VideoCapture(source, cv2.CAP_V4L2)
        if capture.isOpened():
            return capture
        capture.release()
    return cv2.VideoCapture(source)


def _open_writer(
    output_path: Path,
    cv2: Any,
    fps: float,
    frame_size: tuple[int, int],
) -> Any:
    """Open a writer suitable for the output container."""

    suffix = output_path.suffix.lower()
    if suffix == ".mp4":
        codecs = ("mp4v",)
    elif suffix == ".avi":
        codecs = ("MJPG", "XVID")
    else:
        raise RuntimeError("Video output extension must be .mp4 or .avi")
    api_preferences = []
    if hasattr(cv2, "CAP_FFMPEG"):
        api_preferences.append(cv2.CAP_FFMPEG)
    api_preferences.append(cv2.CAP_ANY)

    for codec in codecs:
        fourcc = cv2.VideoWriter_fourcc(*codec)
        for api_preference in api_preferences:
            writer = cv2.VideoWriter()
            writer.open(
                str(output_path),
                api_preference,
                fourcc,
                fps,
                frame_size,
            )
            if writer.isOpened():
                return writer
            writer.release()

    raise RuntimeError(
        "Unable to open video output. OpenCV needs a video writer backend "
        f"(preferably FFmpeg) for {suffix} files."
    )


def record_video(
    camera: int | str = 0,
    output_file: Path | None = None,
    duration: float | None = None,
    fps: float = 20.0,
    width: int | None = None,
    height: int | None = None,
    window_name: str = DEFAULT_WINDOW_NAME,
    gps_csv: Path | None = None,
    show_window: bool = True,
    overlay_metrics: bool = True,
    preview_host: str = DEFAULT_PREVIEW_HOST,
    preview_port: int | None = DEFAULT_PREVIEW_PORT,
    preview_fps: float = 10.0,
    preview_quality: int = 75,
    timestamps_file: Path | None = None,
) -> Path:
    """Record timestamped camera frames until the user stops the preview."""

    cv2 = _load_cv2()
    source = parse_camera_source(str(camera)) if isinstance(camera, str) else camera
    output_path = Path(output_file) if output_file else default_output_file(DEFAULT_OUTPUT_DIR)
    output_path.parent.mkdir(parents=True, exist_ok=True)

    capture = _open_camera(source, cv2)
    gps_reader = LatestGpsCsvReader(Path(gps_csv)) if gps_csv is not None else None
    if gps_reader is not None:
        gps_reader.start()
    writer = None
    timestamps_handle = None
    timestamps_writer = None
    preview_frames = LatestPreviewFrame()
    preview_server: MjpegPreviewServer | None = None
    frame_count = 0
    consecutive_read_failures = 0
    started = time.monotonic()
    next_record_at = started
    last_preview_at = 0.0

    try:
        if not capture.isOpened():
            raise RuntimeError(f"Unable to open camera source: {camera}")

        if width is not None:
            capture.set(cv2.CAP_PROP_FRAME_WIDTH, width)
        if height is not None:
            capture.set(cv2.CAP_PROP_FRAME_HEIGHT, height)

        actual_width = int(capture.get(cv2.CAP_PROP_FRAME_WIDTH))
        actual_height = int(capture.get(cv2.CAP_PROP_FRAME_HEIGHT))
        if actual_width <= 0 or actual_height <= 0:
            raise RuntimeError("Camera returned an invalid frame size")

        actual_fps = float(capture.get(cv2.CAP_PROP_FPS))
        writer_fps = fps if fps > 0 else actual_fps
        if writer_fps <= 0 or writer_fps != writer_fps:
            writer_fps = 20.0
        if actual_fps > 0 and actual_fps == actual_fps:
            writer_fps = min(writer_fps, actual_fps)
        record_interval = 1.0 / writer_fps

        writer = _open_writer(
            output_path,
            cv2,
            writer_fps,
            (actual_width, actual_height),
        )
        if timestamps_file is not None:
            timestamps_path = Path(timestamps_file)
            timestamps_path.parent.mkdir(parents=True, exist_ok=True)
            timestamps_handle = timestamps_path.open("w", encoding="utf-8", newline="", buffering=1)
            timestamps_writer = csv.writer(timestamps_handle)
            timestamps_writer.writerow(["frame_index", "timestamp"])

        if preview_port is not None and preview_port > 0:
            preview_server = MjpegPreviewServer(preview_host, preview_port, preview_frames)
            preview_server.start()
            print(f"Browser preview: http://{preview_host}:{preview_port}/stream.mjpg")
        if show_window:
            cv2.namedWindow(window_name, cv2.WINDOW_NORMAL)
        print(f"Recording camera {camera} to {output_path}")
        print("Press Ctrl+C to stop recording.")

        while True:
            ok, frame = capture.read()
            if not ok:
                consecutive_read_failures += 1
                if consecutive_read_failures >= 30:
                    raise RuntimeError("Unable to read frames from the camera for an extended period")
                time.sleep(0.05)
                continue
            consecutive_read_failures = 0

            captured_at = time.monotonic()
            frame_time = datetime.now()
            output_frame = frame
            if overlay_metrics:
                overlay_lines = [timestamp_text()]
                if gps_reader is not None:
                    overlay_lines.extend(gps_reader.display_lines())
                output_frame = _overlay_lines(frame, overlay_lines, cv2)
            if captured_at >= next_record_at:
                writer.write(output_frame)
                if timestamps_writer is not None:
                    timestamps_writer.writerow(
                        [frame_count, frame_time.strftime("%Y-%m-%d %H:%M:%S.%f")[:-3]]
                    )
                frame_count += 1
                next_record_at += record_interval
                if next_record_at <= captured_at:
                    next_record_at = captured_at + record_interval

            now = time.monotonic()
            if preview_server is not None and (
                preview_fps <= 0 or now - last_preview_at >= 1.0 / preview_fps
            ):
                encoded, jpeg = cv2.imencode(
                    ".jpg",
                    output_frame,
                    [int(cv2.IMWRITE_JPEG_QUALITY), max(1, min(100, preview_quality))],
                )
                if encoded:
                    preview_frames.publish(jpeg.tobytes())
                    last_preview_at = now

            if show_window:
                cv2.imshow(window_name, output_frame)
                key = cv2.waitKey(1) & 0xFF
                if key in (ord("q"), 27):
                    break
                try:
                    if cv2.getWindowProperty(window_name, cv2.WND_PROP_VISIBLE) < 1:
                        break
                except cv2.error:
                    break

            if duration is not None and time.monotonic() - started >= duration:
                break
    except KeyboardInterrupt:
        print("Stopping recording...")
    finally:
        capture.release()
        if writer is not None:
            writer.release()
        if timestamps_handle is not None:
            timestamps_handle.close()
        if gps_reader is not None:
            gps_reader.stop()
        if preview_server is not None:
            preview_server.stop()
        if show_window:
            try:
                cv2.destroyWindow(window_name)
            except cv2.error:
                cv2.destroyAllWindows()

    print(f"Saved {frame_count} frames to {output_path}")
    return output_path


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(
        description="Preview and record a camera stream with a second-resolution timestamp."
    )
    parser.add_argument(
        "--camera",
        default="0",
        help="Camera index (for example 0 or 1) or device path (for example /dev/video0).",
    )
    parser.add_argument(
        "--output",
        type=Path,
        help="Output video path. Defaults to video/recordings/recording_YYYYMMDD_HHMMSS.mp4.",
    )
    parser.add_argument(
        "--duration",
        type=float,
        help="Optional recording duration in seconds. Without it, record until stopped.",
    )
    parser.add_argument(
        "--fps",
        type=float,
        default=20.0,
        help="Output FPS (default: 20).",
    )
    parser.add_argument("--width", type=int, help="Optional requested camera width.")
    parser.add_argument("--height", type=int, help="Optional requested camera height.")
    parser.add_argument(
        "--gps-csv",
        "--metrics-csv",
        dest="gps_csv",
        type=Path,
        help="Optional appended metrics CSV; latest metrics and GCJ-02 coordinates are overlaid.",
    )
    parser.add_argument("--no-window", action="store_true", help="Disable the native OpenCV preview window.")
    parser.add_argument("--no-overlay", action="store_true", help="Record and preview the plain camera image.")
    parser.add_argument("--preview-host", default=DEFAULT_PREVIEW_HOST)
    parser.add_argument("--preview-port", type=int, default=DEFAULT_PREVIEW_PORT)
    parser.add_argument("--preview-fps", type=float, default=10.0)
    parser.add_argument("--preview-quality", type=int, default=75)
    parser.add_argument(
        "--timestamps-file",
        type=Path,
        help="Optional CSV path for recording the wall-clock timestamp of every written frame.",
    )
    return parser


def main() -> int:
    args = build_parser().parse_args()
    stop_watcher = _start_stop_request_watcher()
    try:
        record_video(
            camera=args.camera,
            output_file=args.output,
            duration=args.duration,
            fps=args.fps,
            width=args.width,
            height=args.height,
            gps_csv=args.gps_csv,
            show_window=not args.no_window,
            overlay_metrics=not args.no_overlay,
            preview_host=args.preview_host,
            preview_port=args.preview_port,
            preview_fps=args.preview_fps,
            preview_quality=args.preview_quality,
            timestamps_file=args.timestamps_file,
        )
    except RuntimeError as exc:
        print(f"Error: {exc}")
        return 1
    finally:
        if stop_watcher is not None:
            stop_watcher.set()
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
