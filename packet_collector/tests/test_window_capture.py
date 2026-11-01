"""Tests for bounded window retention and durable pcap archiving."""

from __future__ import annotations

import io
import json
import csv
from datetime import datetime
from pathlib import Path

import pytest

import packet_collector.session.window_capture as window_capture
from packet_collector.session.window_capture import WindowArchiveManager
from packet_collector.collectors.gps_collector import GpsFix


def test_window_archive_retains_latest_only_after_archive(tmp_path: Path) -> None:
    """Old windows are removed only after their packet bytes reach an archive."""
    merge_calls: list[list[str]] = []

    def fake_merge(inputs: list[Path], output: Path) -> Path:
        merge_calls.append([path.name for path in inputs])
        output.write_bytes(b"".join(path.read_bytes() for path in inputs))
        return output

    manager = WindowArchiveManager(
        window_pcaps_dir=tmp_path / "windows",
        pcaps_dir=tmp_path / "pcaps",
        retention=2,
        archive_target_bytes=10_000,
        merge_function=fake_merge,
    )
    sources: list[Path] = []
    for index in range(3):
        source = tmp_path / f"source_{index}.pcapng"
        source.write_bytes(str(index).encode())
        sources.append(source)
        manager.add_window(source, index)

    manager.flush_archive()

    assert merge_calls == [["000001.pcapng", "000002.pcapng"], ["000003.pcapng"]]
    assert [path.name for path in manager.archive_files] == ["000001.pcapng", "000002.pcapng"]
    assert [path.name for path in manager.window_files] == ["000002.pcapng", "000003.pcapng"]
    assert not (tmp_path / "windows" / "000001.pcapng").exists()
    assert (tmp_path / "pcaps" / "000001.pcapng").read_bytes() == b"01"


def test_run_windowed_capture_processes_final_segment(
    monkeypatch: pytest.MonkeyPatch, tmp_path: Path
) -> None:
    """A final closed segment is archived and analyzed without real tools."""
    temporary = tmp_path / "tmp"
    temporary.mkdir()
    (temporary / "capture_00001.pcapng").write_bytes(b"pcap")

    class FakeProcess:
        stderr = io.StringIO("")

        def poll(self) -> int:
            return 0

        def wait(self, timeout: float | None = None) -> int:
            return 0

    monkeypatch.setattr(window_capture, "start_dumpcap", lambda command: FakeProcess())

    result = window_capture.run_windowed_capture(
        command=["dumpcap"],
        tmp_capture_dir=temporary,
        tmp_output_stem="capture",
        window_pcaps_dir=tmp_path / "windows",
        pcaps_dir=tmp_path / "pcaps",
        metrics_file=tmp_path / "window_metrics.jsonl",
        window_seconds=1.0,
        retention=100,
        archive_file_size_kb=51200,
        online_analysis=True,
        analyzer=lambda path, index, seconds: {
            "index": index,
            "avg_rtt_ms": 10.0,
            "jitter_ms": None,
            "throughput_bps": 800.0,
            "loss_rate": 0.0,
        },
    )

    metric = json.loads((tmp_path / "window_metrics.jsonl").read_text(encoding="utf-8"))
    assert result.window_count == 1
    assert result.archive_files == [tmp_path / "pcaps" / "000001.pcapng"]
    assert metric["index"] == 0
    assert (tmp_path / "windows" / "000001.pcapng").exists()
    assert not list((tmp_path / "analysis_pending").glob("*.pcapng"))


def test_ordered_capture_files_does_not_stat_stale_entries(
    monkeypatch: pytest.MonkeyPatch, tmp_path: Path
) -> None:
    """Ordering remains safe if an entry disappears after directory listing."""
    stale = tmp_path / "capture_00002.pcapng"
    first = tmp_path / "capture_00001.pcapng"
    monkeypatch.setattr(
        window_capture,
        "find_matching_files",
        lambda directory, stem, suffix: [stale, first],
    )

    assert window_capture._ordered_capture_files(tmp_path, "capture") == [first, stale]


def test_online_analysis_uses_separate_pending_copy(
    monkeypatch: pytest.MonkeyPatch, tmp_path: Path
) -> None:
    """The analyzer never reads or deletes files in dumpcap's directory."""
    temporary = tmp_path / "tmp"
    temporary.mkdir()
    source = temporary / "capture_00001.pcapng"
    source.write_bytes(b"pcap")

    class FakeProcess:
        stderr = io.StringIO("")

        def poll(self) -> int:
            return 0

        def wait(self, timeout: float | None = None) -> int:
            return 0

    analyzed_paths: list[Path] = []

    def analyzer(path: Path, index: int, seconds: float) -> dict[str, object]:
        analyzed_paths.append(path)
        assert path.parent == tmp_path / "pending"
        assert path.read_bytes() == b"pcap"
        return {
            "index": index,
            "avg_rtt_ms": 1.0,
            "jitter_ms": 0.0,
            "throughput_bps": 32.0,
            "loss_rate": 0.0,
        }

    monkeypatch.setattr(window_capture, "start_dumpcap", lambda command: FakeProcess())

    window_capture.run_windowed_capture(
        command=["dumpcap"],
        tmp_capture_dir=temporary,
        tmp_output_stem="capture",
        window_pcaps_dir=tmp_path / "windows",
        pcaps_dir=tmp_path / "pcaps",
        metrics_file=tmp_path / "window_metrics.jsonl",
        window_seconds=1.0,
        retention=100,
        archive_file_size_kb=51200,
        online_analysis=True,
        analysis_pending_dir=tmp_path / "pending",
        analyzer=analyzer,
    )

    assert analyzed_paths == [tmp_path / "pending" / "000001.pcapng"]
    assert not source.exists()
    assert not list((tmp_path / "pending").iterdir())


def test_run_windowed_capture_writes_tcp_gps_csv(
    monkeypatch: pytest.MonkeyPatch, tmp_path: Path
) -> None:
    """Online analysis can append compact TCP metrics with the latest GPS fix."""
    temporary = tmp_path / "tmp"
    temporary.mkdir()
    (temporary / "capture_00001.pcapng").write_bytes(b"pcap")

    class FakeProcess:
        stderr = io.StringIO("")

        def poll(self) -> int:
            return 0

        def wait(self, timeout: float | None = None) -> int:
            return 0

    class FakeGpsProvider:
        def get_latest_fix(self) -> GpsFix:
            return GpsFix(
                timestamp="2026-01-01 00:00:00.000",
                latitude="3958.1234N",
                longitude="11620.5678E",
                gcj02_latitude=39.970123,
                gcj02_longitude=116.348765,
            )

    monkeypatch.setattr(window_capture, "start_dumpcap", lambda command: FakeProcess())

    window_capture.run_windowed_capture(
        command=["dumpcap"],
        tmp_capture_dir=temporary,
        tmp_output_stem="capture",
        window_pcaps_dir=tmp_path / "windows",
        pcaps_dir=tmp_path / "pcaps",
        metrics_file=tmp_path / "window_metrics.jsonl",
        window_seconds=1.0,
        retention=100,
        archive_file_size_kb=51200,
        online_analysis=True,
        analyzer=lambda path, index, seconds: {
            "index": index,
            "avg_rtt_ms": 10.0,
            "jitter_ms": 0.0,
            "throughput_bps": 800.0,
            "loss_rate": 0.0,
        },
        gps_provider=FakeGpsProvider(),
        metrics_csv_file=tmp_path / "window_metrics_gps.csv",
    )

    rows = (tmp_path / "window_metrics_gps.csv").read_text(encoding="utf-8").splitlines()
    assert rows[0] == (
        "index,timestamp,avg_rtt_ms,jitter_ms,throughput_bps,loss_rate,"
        "gcj02_latitude,gcj02_longitude"
    )
    assert "39.970123,116.348765" in rows[1]
    assert "3958.1234N" not in rows[1]


def test_ctrl_c_stops_capture_then_drains_analysis_queue(
    monkeypatch: pytest.MonkeyPatch, tmp_path: Path
) -> None:
    """One interrupt stops capture while every discovered window is analyzed."""
    temporary = tmp_path / "tmp"
    temporary.mkdir()
    for index in range(3):
        (temporary / f"capture_{index + 1:05d}.pcapng").write_bytes(b"p" * 2048)

    class FakeProcess:
        stderr = io.StringIO("")

        def poll(self) -> int:
            raise KeyboardInterrupt

        def terminate(self) -> None:
            return None

        def kill(self) -> None:
            return None

        def wait(self, timeout: float | None = None) -> int:
            return 0

    analyzed: list[int] = []

    def analyzer(path: Path, index: int, seconds: float) -> dict[str, object]:
        assert path.exists()
        analyzed.append(index)
        return {
            "index": index,
            "avg_rtt_ms": 1.0,
            "jitter_ms": 0.0,
            "throughput_bps": 8.0,
            "loss_rate": 0.0,
        }

    drain_states: list[tuple[bool, int]] = []
    monkeypatch.setattr(window_capture, "start_dumpcap", lambda command: FakeProcess())

    result = window_capture.run_windowed_capture(
        command=["dumpcap"],
        tmp_capture_dir=temporary,
        tmp_output_stem="capture",
        window_pcaps_dir=tmp_path / "windows",
        pcaps_dir=tmp_path / "pcaps",
        metrics_file=tmp_path / "window_metrics.jsonl",
        window_seconds=1.0,
        retention=100,
        archive_file_size_kb=1,
        online_analysis=True,
        analyzer=analyzer,
        metrics_csv_file=tmp_path / "window_metrics_gps.csv",
        logical_start_time=datetime(2026, 10, 5, 10, 0, 0, 750000),
        drain_callback=lambda interrupted, pending: drain_states.append(
            (interrupted, pending)
        ),
    )

    assert result.interrupted is True
    assert result.window_count == 3
    assert result.analysis_completed_count == 2
    assert result.pending_analysis_count == 0
    assert result.partial_window_count == 1
    assert analyzed == [0, 1]
    assert drain_states and drain_states[0][0] is True

    with (tmp_path / "window_metrics_gps.csv").open(
        newline="", encoding="utf-8"
    ) as handle:
        rows = list(csv.DictReader(handle))
    assert [row["timestamp"] for row in rows] == [
        "2026-10-05 10:00:00.750",
        "2026-10-05 10:00:01.750",
    ]

    jsonl_rows = [
        json.loads(line)
        for line in (tmp_path / "window_metrics.jsonl").read_text(encoding="utf-8").splitlines()
    ]
    assert [row["timestamp"] for row in jsonl_rows] == [
        "2026-10-05 10:00:00.750",
        "2026-10-05 10:00:01.750",
    ]
    assert not list(temporary.glob("*.pcapng"))
