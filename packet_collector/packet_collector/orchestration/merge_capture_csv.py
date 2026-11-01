"""Merge network-window metrics with radio metrics at one-second precision."""

from __future__ import annotations

import argparse
import csv
from collections import defaultdict, deque
from dataclasses import dataclass
from datetime import datetime
from pathlib import Path

from packet_collector.app_config import DEFAULT_CONFIG_FILE, load_runtime_settings
from packet_collector.session.metrics_csv_export import (
    MetricsCsvExportResult,
    export_metrics_csv_for_display,
)


RADIO_COLUMNS_TO_DROP = {"timestamp", "session_id"}


@dataclass(frozen=True)
class MergeResult:
    """Summary of one network/radio CSV merge."""

    output_file: Path
    network_row_count: int
    radio_row_count: int
    merged_row_count: int
    unmatched_network_row_count: int
    unused_radio_row_count: int
    invalid_network_timestamp_count: int
    invalid_radio_timestamp_count: int


def _second_key(value: str) -> datetime | None:
    """Normalize supported local and ISO timestamps to local second precision."""
    text = value.strip()
    if not text:
        return None
    try:
        parsed = datetime.fromisoformat(text.replace("Z", "+00:00"))
    except ValueError:
        return None
    return parsed.replace(microsecond=0, tzinfo=None)


def find_latest_csv(root: Path, filename: str) -> Path:
    """Return the newest session CSV below a capture root."""
    candidates = [path for path in root.glob(f"session_*/{filename}") if path.is_file()]
    if not candidates:
        raise FileNotFoundError(f"no {filename} found under {root}")
    return max(
        candidates,
        key=lambda path: (path.stat().st_mtime_ns, path.parent.name, path.name),
    )


def _read_csv(path: Path) -> tuple[list[str], list[list[str]]]:
    with path.open("r", newline="", encoding="utf-8-sig") as handle:
        reader = csv.reader(handle)
        try:
            header = next(reader)
        except StopIteration as exc:
            raise ValueError(f"CSV is empty: {path}") from exc
        return header, list(reader)


def merge_capture_csv(
    network_csv: Path,
    radio_csv: Path,
    output_file: Path,
) -> MergeResult:
    """Inner-join network and radio rows using timestamps truncated to seconds."""
    network_header, network_rows = _read_csv(network_csv)
    radio_header, radio_rows = _read_csv(radio_csv)
    if "timestamp" not in network_header:
        raise ValueError(f"network CSV has no timestamp column: {network_csv}")
    if "timestamp" not in radio_header:
        raise ValueError(f"radio CSV has no timestamp column: {radio_csv}")

    network_timestamp_index = network_header.index("timestamp")
    radio_timestamp_index = radio_header.index("timestamp")
    radio_keep_indices = [
        index
        for index, name in enumerate(radio_header)
        if name not in RADIO_COLUMNS_TO_DROP
    ]
    radio_keep_header = [radio_header[index] for index in radio_keep_indices]

    radio_by_second: dict[datetime, deque[list[str]]] = defaultdict(deque)
    invalid_radio_timestamp_count = 0
    for row in radio_rows:
        value = row[radio_timestamp_index] if radio_timestamp_index < len(row) else ""
        key = _second_key(value)
        if key is None:
            invalid_radio_timestamp_count += 1
            continue
        padded = row + [""] * max(0, len(radio_header) - len(row))
        radio_by_second[key].append([padded[index] for index in radio_keep_indices])

    output_file.parent.mkdir(parents=True, exist_ok=True)
    merged_row_count = 0
    unmatched_network_row_count = 0
    invalid_network_timestamp_count = 0
    with output_file.open("w", newline="", encoding="utf-8") as handle:
        writer = csv.writer(handle)
        writer.writerow([*network_header, *radio_keep_header])
        for row in network_rows:
            value = row[network_timestamp_index] if network_timestamp_index < len(row) else ""
            key = _second_key(value)
            if key is None:
                invalid_network_timestamp_count += 1
                continue
            matches = radio_by_second.get(key)
            if not matches:
                unmatched_network_row_count += 1
                continue
            padded = row + [""] * max(0, len(network_header) - len(row))
            writer.writerow([*padded[: len(network_header)], *matches.popleft()])
            merged_row_count += 1

    unused_radio_row_count = sum(len(rows) for rows in radio_by_second.values())
    return MergeResult(
        output_file=output_file,
        network_row_count=len(network_rows),
        radio_row_count=len(radio_rows),
        merged_row_count=merged_row_count,
        unmatched_network_row_count=unmatched_network_row_count,
        unused_radio_row_count=unused_radio_row_count,
        invalid_network_timestamp_count=invalid_network_timestamp_count,
        invalid_radio_timestamp_count=invalid_radio_timestamp_count,
    )


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(
        description="Merge network and radio capture CSV files by local whole second."
    )
    parser.add_argument("network_csv", nargs="?", type=Path)
    parser.add_argument("radio_csv", nargs="?", type=Path)
    parser.add_argument("output_file", nargs="?", type=Path)
    parser.add_argument("--config", type=Path, default=DEFAULT_CONFIG_FILE)
    return parser


def main() -> int:
    args = build_parser().parse_args()
    try:
        settings = load_runtime_settings(args.config)
        project_dir = settings.project_dir
        workspace_dir = project_dir.parent
        network_csv = args.network_csv or find_latest_csv(
            settings.final_capture_dir, "window_metrics_gps.csv"
        )
        radio_csv = args.radio_csv or find_latest_csv(
            workspace_dir / "radio_capture" / "BJTUCC-main" / "captures",
            "dm_metrics.csv",
        )
        output_file = args.output_file or network_csv.parent / "network_radio_merged.csv"
        result = merge_capture_csv(network_csv, radio_csv, output_file)
        display_result: MetricsCsvExportResult | None = None
        if settings.display_enabled:
            display_result = export_metrics_csv_for_display(
                source_csv=output_file,
                display_data_dir=settings.display_data_dir,
                session_id=network_csv.parent.name,
                source_name=settings.display_source,
            )
    except (FileNotFoundError, OSError, ValueError) as exc:
        print(f"ERROR: {exc}")
        return 1

    print(f"Network CSV: {network_csv}")
    print(f"Radio CSV: {radio_csv}")
    print(f"Output CSV: {result.output_file}")
    print(f"Network rows: {result.network_row_count}")
    print(f"Radio rows: {result.radio_row_count}")
    print(f"Merged intersection rows: {result.merged_row_count}")
    print(f"Unmatched network rows: {result.unmatched_network_row_count}")
    print(f"Unused radio rows: {result.unused_radio_row_count}")
    print(f"Invalid network timestamps: {result.invalid_network_timestamp_count}")
    print(f"Invalid radio timestamps: {result.invalid_radio_timestamp_count}")
    if display_result is not None:
        print(f"Display full CSV: {display_result.full_csv}")
        print(f"Display one-minute CSV files: {len(display_result.split_csv_files)}")
    else:
        print("Display publish: disabled")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
