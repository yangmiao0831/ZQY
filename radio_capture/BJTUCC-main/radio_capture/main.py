"""Command-line entry points for radio capture."""

from __future__ import annotations

import argparse
import _thread
import os
import sys
import threading
from pathlib import Path

from radio_capture.config import load_config
from radio_capture.native.win32_loader import Win32NativeLoader
from radio_capture.profiles import ProfileResolver
from radio_capture.session.manager import CaptureSession


def _start_stop_request_watcher() -> threading.Event | None:
    """Translate the dashboard stop request into the normal Ctrl+C path."""
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
                (stop_file.parent / "radio.stopping").write_text("stopping", encoding="utf-8")
            finally:
                _thread.interrupt_main()
            return

    threading.Thread(target=watch, name="collector-stop-watcher", daemon=True).start()
    return watcher_stop


def build_parser() -> argparse.ArgumentParser:
    #创建一个命令行参数解析器
    parser = argparse.ArgumentParser(description="Windows x86 radio capture")
    parser.add_argument("--config", required=True, help="Path to JSON config file.")
    parser.add_argument(
        "--metrics-only",
        action="store_true",
        help="Decode DM frames and write only the consolidated metrics CSV.",
    )
    #开关参数
    parser.add_argument("--dry-run", action="store_true", help="Validate config and DLL exports only.")
    return parser


def main(argv: list[str] | None = None) -> int:
    args = build_parser().parse_args(argv)
    config = load_config(args.config)
    profile = ProfileResolver().resolve(config)

    if args.dry_run:
        loader = Win32NativeLoader(config.runtime.dll_dir)
        loader.assert_x86_process()
        loader.validate_required_files([profile.controller_dll, profile.decoder_dispatcher_dll, profile.expected_plugin])
        print("dry-run ok")
        print(f"profile={profile.name}")
        print(f"dll_dir={config.runtime.dll_dir}")
        return 0

    session = CaptureSession(config)
    stop_watcher = _start_stop_request_watcher()
    if args.metrics_only:
        setter = getattr(session, "set_metrics_only", None)
        if setter is not None:
            setter()
    try:
        session.open()
        session.configure_ports()
        session.start_workers()
        session.connect()
        print(
            f"capturing session={session.context.session_id} "
            f"connect_rc={session.connect_return_code}; press Ctrl+C to stop"
        )
        session.wait()
    except KeyboardInterrupt:
        print("stopping capture")
    finally:
        if stop_watcher is not None:
            stop_watcher.set()
        session.stop()
        stats = session.frame_queue.stats
        callback_dispatcher = getattr(session, "callback_dispatcher", None)
        callback_stats = callback_dispatcher.stats if callback_dispatcher else None
        callback_desc = ""
        if callback_stats is not None:
            callback_desc = (
                f" callback_calls={callback_stats.callback_calls}"
                f" callback_received={callback_stats.received_frames}"
                f" callback_invalid={callback_stats.invalid_frames}"
                f" callback_empty={callback_stats.empty_callbacks}"
                f" callback_oversize={callback_stats.oversize_frames}"
                f" callback_dropped={callback_stats.dropped_frames}"
            )
            if callback_stats.last_error:
                callback_desc += f" callback_error={callback_stats.last_error}"
            if callback_stats.last_callback_args:
                callback_desc += f" last_callback={callback_stats.last_callback_args}"
        raw_reader = getattr(session, "raw_dm_reader", None)
        if raw_reader is not None:
            raw_stats = raw_reader.stats
            callback_desc += (
                f" dm_source=qwinlog_raw"
                f" raw_bytes={raw_stats.bytes_received}"
                f" raw_packets={raw_stats.framed_packets}"
                f" raw_valid={raw_stats.valid_frames}"
                f" raw_invalid={raw_stats.invalid_packets}"
            )
            if raw_stats.last_error:
                callback_desc += f" raw_error={raw_stats.last_error}"
        print(
            f"capture stopped enqueued={stats.enqueued} "
            f"persisted={stats.dequeued} dropped={stats.dropped} "
            f"raw_dir={session.raw_writer.session_dir}{callback_desc}"
        )
        ports = getattr(config, "ports", None)
        if ports is not None and getattr(ports, "at_port", None) is not None:
            metrics_only = getattr(session, "metrics_only", False)
            metrics_writer = getattr(session, "metrics_writer", None)
            if metrics_only and metrics_writer is not None:
                at_desc = (
                    f"AT capture records={session.at_records} "
                    f"csv={session.at_writer.csv_path}"
                )
                if session.at_writer.lte_csv_path is not None:
                    at_desc += f" lte_csv={session.at_writer.lte_csv_path}"
                if session.at_error is not None:
                    at_desc += f" at_error={session.at_error!r}"
                print(at_desc)
            elif not metrics_only:
                at_desc = (
                    f"AT capture records={session.at_records} "
                    f"jsonl={session.at_writer.jsonl_path} "
                    f"csv={session.at_writer.csv_path}"
                )
                if session.at_writer.lte_csv_path is not None:
                    at_desc += f" lte_csv={session.at_writer.lte_csv_path}"
                if session.at_error is not None:
                    at_desc += f" at_error={session.at_error!r}"
                print(at_desc)
        if getattr(session, "metrics_only", False):
            metrics_writer = getattr(session, "metrics_writer", None)
            if metrics_writer is not None:
                print(f"DM metrics csv={metrics_writer.path}")
        merged_path = getattr(session, "merged_metrics_path", None)
        if merged_path is not None:
            print(f"merged metrics csv={merged_path}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main(sys.argv[1:]))
    #raise SystemExit(...) 的作用是退出程序，
    # 并把 main() 的返回值作为进程退出码。
