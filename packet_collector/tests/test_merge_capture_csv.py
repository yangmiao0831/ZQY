"""Tests for second-aligned network/radio CSV merging."""

from __future__ import annotations

import csv
from pathlib import Path

from packet_collector.orchestration.merge_capture_csv import (
    find_latest_csv,
    merge_capture_csv,
)


def _write_rows(path: Path, rows: list[list[str]]) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("w", newline="", encoding="utf-8") as handle:
        csv.writer(handle).writerows(rows)


def test_merge_uses_network_timestamp_and_strict_second_intersection(
    tmp_path: Path,
) -> None:
    network_csv = tmp_path / "network.csv"
    radio_csv = tmp_path / "radio.csv"
    output = tmp_path / "merged.csv"
    _write_rows(
        network_csv,
        [
            ["index", "timestamp", "avg_rtt_ms"],
            ["0", "2026-10-05 13:32:18.039", "1.0"],
            ["1", "2026-10-05 13:32:19.039", "2.0"],
            ["2", "2026-10-05 13:32:20.039", "3.0"],
        ],
    )
    _write_rows(
        radio_csv,
        [
            ["timestamp", "session_id", "sequence", "NR PCI"],
            ["2026-10-05T13:32:17.851700+08:00", "radio", "10", "100"],
            ["2026-10-05T13:32:19.851700+08:00", "radio", "11", "101"],
            ["2026-10-05T13:32:20.851700+08:00", "radio", "12", "102"],
            ["2026-10-05T13:32:21.851700+08:00", "radio", "13", "103"],
        ],
    )

    result = merge_capture_csv(network_csv, radio_csv, output)

    with output.open(newline="", encoding="utf-8-sig") as handle:
        rows = list(csv.reader(handle))
    assert rows == [
        ["index", "timestamp", "avg_rtt_ms", "sequence", "NR PCI"],
        ["1", "2026-10-05 13:32:19.039", "2.0", "11", "101"],
        ["2", "2026-10-05 13:32:20.039", "3.0", "12", "102"],
    ]
    assert result.network_row_count == 3
    assert result.radio_row_count == 4
    assert result.merged_row_count == 2
    assert result.unmatched_network_row_count == 1
    assert result.unused_radio_row_count == 2


def test_same_second_rows_are_consumed_one_to_one(tmp_path: Path) -> None:
    network_csv = tmp_path / "network.csv"
    radio_csv = tmp_path / "radio.csv"
    output = tmp_path / "merged.csv"
    _write_rows(
        network_csv,
        [
            ["timestamp", "value"],
            ["2026-10-05 13:32:19.100", "a"],
            ["2026-10-05 13:32:19.900", "b"],
        ],
    )
    _write_rows(
        radio_csv,
        [
            ["timestamp", "session_id", "radio_value"],
            ["2026-10-05T13:32:19.500+08:00", "radio", "x"],
        ],
    )

    result = merge_capture_csv(network_csv, radio_csv, output)

    assert result.merged_row_count == 1
    assert result.unmatched_network_row_count == 1


def test_find_latest_csv(tmp_path: Path) -> None:
    older = tmp_path / "session_1" / "dm_metrics.csv"
    newer = tmp_path / "session_2" / "dm_metrics.csv"
    _write_rows(older, [["timestamp"]])
    _write_rows(newer, [["timestamp"]])
    older.touch()
    newer.touch()

    assert find_latest_csv(tmp_path, "dm_metrics.csv") == newer
