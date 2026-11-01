"""Continuous one-second capture processing and bounded window retention.

dumpcap remains the only capture process. Closed rotation files are copied to
`window_pcaps` and, when online analysis is enabled, to a separate
`analysis_pending` directory. The capture loop owns temporary dumpcap files;
the analyzer owns only the pending copies it receives.
"""

from __future__ import annotations

import subprocess
import threading
import time
import csv
import queue
from dataclasses import dataclass
from datetime import datetime, timedelta
from pathlib import Path
from typing import Callable, Protocol

from packet_collector.analyzers.tcp_window_analyzer import (
    analyze_tcp_window,
    empty_tcp_window_metrics,
)
from packet_collector.capture.dumpcap_runner import merge_pcap_files, start_dumpcap
from packet_collector.storage.file_manager import copy_file, find_matching_files
from packet_collector.storage.jsonl_writer import append_jsonl_record


WindowAnalyzer = Callable[[Path, int, float], dict[str, object]]
MergeFunction = Callable[[list[Path], Path], Path]
DrainCallback = Callable[[bool, int], None]


class GpsProvider(Protocol):
    """Protocol for optional latest GPS fix providers."""

    def get_latest_fix(self) -> object | None:
        """Return the latest fix object, or None when unavailable."""
        ...


@dataclass
class WindowCaptureResult:
    """Artifacts and process state returned by one windowed capture."""

    returncode: int
    archive_files: list[Path]
    window_files: list[Path]
    window_count: int
    analysis_errors: list[str]
    interrupted: bool = False
    analysis_completed_count: int = 0
    pending_analysis_count: int = 0
    partial_window_count: int = 0


@dataclass(frozen=True)
class WindowAnalysisTask:
    """One closed capture window waiting for ordered analysis."""

    source_file: Path
    index: int
    timestamp: datetime
    gps_fix: object | None


class WindowArchiveManager:
    """Archive closed windows and keep only the newest retained copies."""

    def __init__(
        self,
        window_pcaps_dir: Path,
        pcaps_dir: Path,
        retention: int,
        archive_target_bytes: int,
        merge_function: MergeFunction = merge_pcap_files,
    ) -> None:
        if retention <= 0:
            raise ValueError("retention must be > 0")
        if archive_target_bytes <= 0:
            raise ValueError("archive_target_bytes must be > 0")
        self.window_pcaps_dir = window_pcaps_dir
        self.pcaps_dir = pcaps_dir
        self.retention = retention
        self.archive_target_bytes = archive_target_bytes
        self.merge_function = merge_function
        self.window_pcaps_dir.mkdir(parents=True, exist_ok=True)
        self.pcaps_dir.mkdir(parents=True, exist_ok=True)
        self.pending: list[Path] = []
        self.archived: set[Path] = set()
        self.archive_files: list[Path] = []
        self.window_files: list[Path] = []

    def add_window(self, source_file: Path, index: int) -> Path:
        """Copy a closed rotation file into the bounded window directory."""
        destination = self.window_pcaps_dir / f"{index + 1:06d}.pcapng"
        copy_file(source_file, destination)
        self.pending.append(destination)
        self.window_files.append(destination)
        pending_bytes = sum(path.stat().st_size for path in self.pending)
        if pending_bytes >= self.archive_target_bytes or len(self.pending) >= self.retention:
            self.flush_archive()
        self.cleanup_retained_windows()
        return destination

    def flush_archive(self) -> Path | None:
        """Merge pending windows into the next durable archive pcapng."""
        if not self.pending:
            return None
        output_file = self.pcaps_dir / f"{len(self.archive_files) + 1:06d}.pcapng"
        self.merge_function(list(self.pending), output_file)
        self.archive_files.append(output_file)
        self.archived.update(self.pending)
        self.pending.clear()
        self.cleanup_retained_windows()
        return output_file

    def cleanup_retained_windows(self) -> None:
        """Delete old windows only after their contents have been archived."""
        while len(self.window_files) > self.retention:
            oldest = self.window_files[0]
            if oldest not in self.archived:
                return
            oldest.unlink(missing_ok=True)
            self.window_files.pop(0)


def _ordered_capture_files(directory: Path, stem: str) -> list[Path]:
    """Return dumpcap rotation files in dumpcap sequence-name order."""
    files = find_matching_files(directory, stem, ".pcapng")
    return sorted(files, key=lambda path: path.name)


def _stage_analysis_file(source_file: Path, pending_dir: Path, index: int) -> Path:
    """Copy one closed capture into analyzer-owned storage atomically."""
    pending_dir.mkdir(parents=True, exist_ok=True)
    destination = pending_dir / f"{index + 1:06d}.pcapng"
    partial = destination.with_suffix(".pcapng.partial")
    try:
        copy_file(source_file, partial)
        partial.replace(destination)
    finally:
        partial.unlink(missing_ok=True)
    return destination


def _append_metrics_csv_record(
    csv_file: Path,
    metrics: dict[str, object],
    timestamp: datetime,
    gps_fix: object | None,
) -> None:
    """Append one compact TCP+GPS metrics row to CSV."""
    csv_file.parent.mkdir(parents=True, exist_ok=True)
    file_exists = csv_file.exists() and csv_file.stat().st_size > 0
    row = {
        "index": metrics.get("index"),
        "timestamp": timestamp.strftime("%Y-%m-%d %H:%M:%S.%f")[:-3],
        "avg_rtt_ms": metrics.get("avg_rtt_ms"),
        "jitter_ms": metrics.get("jitter_ms"),
        "throughput_bps": metrics.get("throughput_bps"),
        "loss_rate": metrics.get("loss_rate"),
        "gcj02_latitude": getattr(gps_fix, "gcj02_latitude", "") if gps_fix is not None else "",
        "gcj02_longitude": getattr(gps_fix, "gcj02_longitude", "") if gps_fix is not None else "",
    }
    fieldnames = [
        "index",
        "timestamp",
        "avg_rtt_ms",
        "jitter_ms",
        "throughput_bps",
        "loss_rate",
        "gcj02_latitude",
        "gcj02_longitude",
    ]
    with csv_file.open("a", newline="", encoding="utf-8") as handle:
        writer = csv.DictWriter(handle, fieldnames=fieldnames)
        if not file_exists:
            writer.writeheader()
        writer.writerow(row)


def run_windowed_capture(
    command: list[str],
    tmp_capture_dir: Path,
    tmp_output_stem: str,
    window_pcaps_dir: Path,
    pcaps_dir: Path,
    metrics_file: Path,
    window_seconds: float,
    retention: int,
    archive_file_size_kb: int,
    online_analysis: bool,
    analysis_pending_dir: Path | None = None,
    analyzer: WindowAnalyzer = analyze_tcp_window,
    gps_provider: GpsProvider | None = None,
    metrics_csv_file: Path | None = None,
    poll_interval: float = 0.1,
    logical_start_time: datetime | None = None,
    drain_callback: DrainCallback | None = None,
) -> WindowCaptureResult:
    """Capture continuously and analyze closed windows on an ordered worker."""
    if analysis_pending_dir is None:
        analysis_pending_dir = metrics_file.parent / "analysis_pending"
    if online_analysis:
        analysis_pending_dir.mkdir(parents=True, exist_ok=True)
    manager = WindowArchiveManager(
        window_pcaps_dir=window_pcaps_dir,
        pcaps_dir=pcaps_dir,
        retention=retention,
        archive_target_bytes=archive_file_size_kb * 1024,
    )
    process = start_dumpcap(command)
    logical_start = logical_start_time or datetime.now()
    stderr_lines: list[str] = []

    def drain_stderr() -> None:
        if process.stderr is not None:
            stderr_lines.extend(process.stderr)

    stderr_thread = threading.Thread(target=drain_stderr, name="dumpcap-stderr", daemon=True)
    stderr_thread.start()
    processed: set[Path] = set()
    analysis_errors: list[str] = []
    index = 0
    interrupted = False
    analysis_completed_count = 0
    analysis_scheduled_count = 0
    partial_window_count = 0
    analysis_queue: queue.Queue[WindowAnalysisTask | None] = queue.Queue()

    def enqueue_closed(source_file: Path, *, analyze_window: bool = True) -> None:
        nonlocal index, analysis_scheduled_count, partial_window_count
        manager.add_window(source_file, index)
        timestamp = logical_start + timedelta(seconds=index * window_seconds)
        gps_fix = gps_provider.get_latest_fix() if gps_provider is not None else None
        if online_analysis and analyze_window:
            analysis_file = _stage_analysis_file(source_file, analysis_pending_dir, index)
            processed.add(source_file)
            source_file.unlink(missing_ok=True)
            analysis_queue.put(
                WindowAnalysisTask(
                    source_file=analysis_file,
                    index=index,
                    timestamp=timestamp,
                    gps_fix=gps_fix,
                )
            )
            analysis_scheduled_count += 1
        else:
            if online_analysis:
                partial_window_count += 1
            processed.add(source_file)
            source_file.unlink(missing_ok=True)
        index += 1

    def analyze_queued_windows() -> None:
        nonlocal analysis_completed_count
        while True:
            task = analysis_queue.get()
            if task is None:
                analysis_queue.task_done()
                return
            try:
                metrics = dict(analyzer(task.source_file, task.index, window_seconds))
            except Exception as exc:
                analysis_errors.append(f"window {task.index}: {exc}")
                metrics = empty_tcp_window_metrics(task.index)
            try:
                metrics["timestamp"] = task.timestamp.strftime("%Y-%m-%d %H:%M:%S.%f")[:-3]
                append_jsonl_record(metrics_file, metrics)
                if metrics_csv_file is not None:
                    _append_metrics_csv_record(
                        metrics_csv_file,
                        metrics,
                        task.timestamp,
                        task.gps_fix,
                    )
                analysis_completed_count += 1
            except Exception as exc:
                analysis_errors.append(f"window {task.index} output: {exc}")
            finally:
                task.source_file.unlink(missing_ok=True)
                analysis_queue.task_done()

    analysis_thread: threading.Thread | None = None
    if online_analysis:
        analysis_thread = threading.Thread(
            target=analyze_queued_windows,
            name="tcp-window-analyzer",
            daemon=False,
        )
        analysis_thread.start()

    try:
        while process.poll() is None:
            candidates = [path for path in _ordered_capture_files(tmp_capture_dir, tmp_output_stem) if path not in processed]
            for closed_file in candidates[:-1]:
                enqueue_closed(closed_file)
            time.sleep(poll_interval)
    except KeyboardInterrupt:
        interrupted = True
        print("Ctrl+C received. Stopping packet capture; pending windows will still be analyzed...")
        try:
            process.terminate()
        except OSError:
            pass
        try:
            process.wait(timeout=5)
        except subprocess.TimeoutExpired:
            process.kill()
            process.wait()
    except Exception:
        process.terminate()
        try:
            process.wait(timeout=5)
        except subprocess.TimeoutExpired:
            process.kill()
            process.wait()
        if online_analysis:
            analysis_queue.put(None)
            analysis_queue.join()
            if analysis_thread is not None:
                analysis_thread.join()
        stderr_thread.join(timeout=1)
        raise

    returncode = process.wait()
    remaining_files = [
        source_file
        for source_file in _ordered_capture_files(tmp_capture_dir, tmp_output_stem)
        if source_file not in processed
    ]
    for remaining_index, source_file in enumerate(remaining_files):
        is_interrupted_tail = interrupted and remaining_index == len(remaining_files) - 1
        enqueue_closed(source_file, analyze_window=not is_interrupted_tail)
    pending_analysis_count = (
        max(0, analysis_scheduled_count - analysis_completed_count)
        if online_analysis
        else 0
    )
    if drain_callback is not None:
        drain_callback(interrupted, pending_analysis_count)
    if online_analysis:
        print(f"Capture stopped. Finishing {pending_analysis_count} queued analysis window(s)...")
        analysis_queue.put(None)
        analysis_queue.join()
        if analysis_thread is not None:
            analysis_thread.join()
        print(f"Analysis completed: {analysis_completed_count} window(s).")
    manager.flush_archive()
    manager.cleanup_retained_windows()

    stderr_thread.join(timeout=1)
    stderr = "".join(stderr_lines)
    if returncode != 0 and not interrupted:
        message = f"dumpcap failed with returncode {returncode}"
        if stderr:
            message = f"{message}: {stderr.strip()}"
        raise RuntimeError(message)

    return WindowCaptureResult(
        returncode=returncode,
        archive_files=list(manager.archive_files),
        window_files=list(manager.window_files),
        window_count=index,
        analysis_errors=analysis_errors,
        interrupted=interrupted,
        analysis_completed_count=analysis_completed_count,
        pending_analysis_count=0,
        partial_window_count=partial_window_count,
    )
