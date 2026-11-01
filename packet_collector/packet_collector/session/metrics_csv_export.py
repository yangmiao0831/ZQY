"""Publish completed session metrics for the local display application."""

from __future__ import annotations

import csv
import shutil
from dataclasses import dataclass
from datetime import datetime
from pathlib import Path
from typing import TextIO


DISPLAY_SPLIT_SECONDS = 60


@dataclass(frozen=True)
class MetricsCsvExportResult:
    """Files produced from one authoritative session metrics CSV."""

    full_csv: Path
    split_csv_files: list[Path]
    row_count: int
    invalid_timestamp_count: int


def _parse_timestamp(value: str) -> datetime:
    """Parse the local millisecond timestamp written by window capture."""
    return datetime.fromisoformat(value.strip())


def export_metrics_csv_for_display(
    source_csv: Path,
    display_data_dir: Path,
    session_id: str,
    source_name: str = "BJTU",
) -> MetricsCsvExportResult:
    """Copy the full CSV and create non-overlapping one-minute CSV files."""
    if not source_csv.is_file():
        raise FileNotFoundError(f"metrics CSV not found: {source_csv}")
    if not source_name or Path(source_name).name != source_name:
        raise ValueError("display source must be a single directory name")

    full_dir = display_data_dir / source_name
    split_dir = display_data_dir / f"{source_name}_1min"
    full_dir.mkdir(parents=True, exist_ok=True)
    split_dir.mkdir(parents=True, exist_ok=True)

    full_csv = full_dir / f"{session_id}_full.csv"
    shutil.copy2(source_csv, full_csv)
    for stale_file in split_dir.glob(f"{session_id}_*.csv"):
        stale_file.unlink()

    handles: dict[int, TextIO] = {}
    writers: dict[int, csv.DictWriter] = {}
    split_files: dict[int, Path] = {}
    base_time: datetime | None = None
    row_count = 0
    invalid_timestamp_count = 0

    try:
        with source_csv.open("r", newline="", encoding="utf-8-sig") as source_handle:
            reader = csv.DictReader(source_handle)
            if not reader.fieldnames or "timestamp" not in reader.fieldnames:
                raise ValueError("metrics CSV must contain a timestamp column")

            for row in reader:
                row_count += 1
                try:
                    timestamp = _parse_timestamp(row.get("timestamp", ""))
                except (TypeError, ValueError):
                    invalid_timestamp_count += 1
                    continue
                if base_time is None:
                    base_time = timestamp
                elapsed_seconds = max(0.0, (timestamp - base_time).total_seconds())
                window_index = int(elapsed_seconds // DISPLAY_SPLIT_SECONDS)

                if window_index not in writers:
                    output_file = split_dir / f"{session_id}_{window_index + 1:04d}.csv"
                    output_handle = output_file.open("w", newline="", encoding="utf-8")
                    writer = csv.DictWriter(output_handle, fieldnames=reader.fieldnames)
                    writer.writeheader()
                    handles[window_index] = output_handle
                    writers[window_index] = writer
                    split_files[window_index] = output_file
                writers[window_index].writerow(row)
    finally:
        for handle in handles.values():
            handle.close()

    return MetricsCsvExportResult(
        full_csv=full_csv,
        split_csv_files=[split_files[index] for index in sorted(split_files)],
        row_count=row_count,
        invalid_timestamp_count=invalid_timestamp_count,
    )
