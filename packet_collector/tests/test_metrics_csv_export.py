"""Tests for publishing completed metrics CSV files to the display project."""

from __future__ import annotations

import csv
from pathlib import Path
from types import SimpleNamespace

import pytest

from packet_collector.session.metrics_csv_export import export_metrics_csv_for_display
import packet_collector.session.session_capture as session_capture
from packet_collector.session.session_manager import load_session_meta


FIELDNAMES = [
    "index",
    "timestamp",
    "avg_rtt_ms",
    "jitter_ms",
    "throughput_bps",
    "loss_rate",
    "gcj02_latitude",
    "gcj02_longitude",
]


def _write_source(path: Path) -> None:
    rows = [
        [0, "2026-10-01 12:00:05.000", 1, 2, 100, 0, 39.1, 116.1],
        [1, "2026-10-01 12:01:04.999", 2, 3, 200, 0, 39.2, 116.2],
        [2, "2026-10-01 12:01:05.000", 3, 4, 300, 0, 39.3, 116.3],
        [3, "2026-10-01 12:02:04.999", 4, 5, 400, 0, 39.4, 116.4],
        [4, "2026-10-01 12:02:06.000", 5, 6, 500, 0, 39.5, 116.5],
        [5, "invalid", 6, 7, 600, 0, 39.6, 116.6],
    ]
    with path.open("w", newline="", encoding="utf-8") as handle:
        writer = csv.writer(handle)
        writer.writerow(FIELDNAMES)
        writer.writerows(rows)


def test_export_keeps_full_csv_and_splits_by_elapsed_minute(tmp_path: Path) -> None:
    """Minute files are non-overlapping and the final partial minute is kept."""
    source = tmp_path / "window_metrics_gps.csv"
    _write_source(source)

    result = export_metrics_csv_for_display(
        source_csv=source,
        display_data_dir=tmp_path / "datas",
        session_id="session_test",
        source_name="BJTU",
    )

    assert result.full_csv == tmp_path / "datas" / "BJTU" / "session_test_full.csv"
    assert result.full_csv.read_bytes() == source.read_bytes()
    assert [path.name for path in result.split_csv_files] == [
        "session_test_0001.csv",
        "session_test_0002.csv",
        "session_test_0003.csv",
    ]
    assert [len(path.read_text(encoding="utf-8").splitlines()) - 1 for path in result.split_csv_files] == [2, 2, 1]
    assert result.row_count == 6
    assert result.invalid_timestamp_count == 1


def test_export_rejects_nested_source_name(tmp_path: Path) -> None:
    """A display source cannot escape or nest below the datas directory."""
    source = tmp_path / "window_metrics_gps.csv"
    _write_source(source)

    try:
        export_metrics_csv_for_display(source, tmp_path / "datas", "session_test", "../BJTU")
    except ValueError as exc:
        assert "single directory" in str(exc)
    else:
        raise AssertionError("nested display source should be rejected")


def test_export_replaces_stale_split_files_for_same_session(tmp_path: Path) -> None:
    source = tmp_path / "window_metrics_gps.csv"
    _write_source(source)
    stale = tmp_path / "datas" / "BJTU_1min" / "session_test_9999.csv"
    stale.parent.mkdir(parents=True)
    stale.write_text("stale", encoding="utf-8")

    export_metrics_csv_for_display(
        source_csv=source,
        display_data_dir=tmp_path / "datas",
        session_id="session_test",
        source_name="BJTU",
    )

    assert not stale.exists()


def test_interrupted_session_still_publishes_completed_csv(
    monkeypatch: pytest.MonkeyPatch, tmp_path: Path
) -> None:
    """A Ctrl+C-style window result still runs the display export cleanup."""
    class FakeGpsReader:
        error = None

        def __init__(self, port: str, baudrate: int) -> None:
            pass

        def start(self) -> None:
            pass

        def stop(self) -> None:
            pass

    def fake_window_capture(**kwargs: object) -> SimpleNamespace:
        _write_source(Path(kwargs["metrics_csv_file"]))
        return SimpleNamespace(
            interrupted=True,
            returncode=0,
            archive_files=[],
            window_files=[],
            window_count=6,
            analysis_errors=[],
        )

    monkeypatch.setattr(session_capture, "LatestGpsReader", FakeGpsReader)
    monkeypatch.setattr(session_capture, "run_windowed_capture", fake_window_capture)

    session_dir = session_capture.run_capture_session(
        packet_type="tcp",
        pi_ip=None,
        peer_ip=None,
        direction="both",
        iface="eth0",
        final_base_dir=tmp_path / "captures",
        tmp_capture_dir=tmp_path / "tmp",
        file_size_kb=51200,
        max_files=200,
        execute=True,
        capture_mode="iface_only",
        window_mode="online-analysis",
        with_gps=True,
        display_data_dir=tmp_path / "display" / "datas",
        display_source="BJTU",
    )

    meta = load_session_meta(session_dir)
    assert meta["status"] == "interrupted"
    assert meta["display_export_status"] == "completed"
    assert Path(meta["display_full_csv"]).is_file()
    assert len(meta["display_split_csv_files"]) == 3
