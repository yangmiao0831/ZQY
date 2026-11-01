"""Tests for build-replay-trace CLI handler."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli


def _write_packet_jsonl(path: Path) -> Path:
    """Write one minimal TCP packet JSONL file."""
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(
        json.dumps(
            {
                "time_epoch": 1.0,
                "protocols": "eth:ip:tcp",
                "src_ip": "10.0.0.1",
                "dst_ip": "10.0.0.2",
                "src_port": 50000,
                "dst_port": 443,
                "tcp_len": 100,
            }
        )
        + "\n",
        encoding="utf-8",
    )
    return path


def test_cli_build_replay_trace_updates_session_meta(tmp_path: Path) -> None:
    """Session source creates replay_trace.json and updates session_meta.json."""
    session_dir = tmp_path / "session_20260101_010203_123456"
    session_dir.mkdir()
    (session_dir / "session_meta.json").write_text(json.dumps({"session_id": "session_20260101_010203_123456"}), encoding="utf-8")
    _write_packet_jsonl(session_dir / "packets.jsonl")

    args = argparse.Namespace(
        source_dir=str(session_dir),
        pi_ip="10.0.0.1",
        input=[],
        input_glob=None,
        output=None,
        window_ms=100,
        protocol_filter="all",
        flow_idle_timeout_sec=60.0,
    )
    cli._run_build_replay_trace_command(args)

    assert (session_dir / "replay_trace.json").exists()
    metadata = json.loads((session_dir / "session_meta.json").read_text(encoding="utf-8"))
    assert metadata["replay"]["trace_status"] == "completed"
    assert metadata["replay"]["trace"].endswith("replay_trace.json")


def test_cli_build_replay_trace_updates_task_meta(tmp_path: Path) -> None:
    """Task source updates task_meta.json."""
    task_dir = tmp_path / "task_20260101_010203_123456"
    task_dir.mkdir()
    (task_dir / "task_meta.json").write_text(json.dumps({"task_id": "task_20260101_010203_123456"}), encoding="utf-8")
    _write_packet_jsonl(task_dir / "packets.jsonl")

    args = argparse.Namespace(
        source_dir=str(task_dir),
        pi_ip="10.0.0.1",
        input=[],
        input_glob=None,
        output=None,
        window_ms=50,
        protocol_filter="tcp",
        flow_idle_timeout_sec=30.0,
    )
    cli._run_build_replay_trace_command(args)

    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["replay"]["trace_status"] == "completed"
    assert metadata["replay"]["window_ms"] == 50
    assert metadata["replay"]["protocol_filter"] == "tcp"


def test_cli_build_replay_trace_uses_multiple_inputs(tmp_path: Path) -> None:
    """Explicit --input paths are passed into trace generation."""
    source_dir = tmp_path / "session_20260101_010203_123456"
    source_dir.mkdir()
    (source_dir / "session_meta.json").write_text(json.dumps({"session_id": "session_20260101_010203_123456"}), encoding="utf-8")
    one = _write_packet_jsonl(source_dir / "packets" / "000001.jsonl")
    two = _write_packet_jsonl(source_dir / "packets" / "000002.jsonl")

    args = argparse.Namespace(
        source_dir=str(source_dir),
        pi_ip="10.0.0.1",
        input=[str(one), str(two)],
        input_glob=None,
        output=str(source_dir / "custom_trace.json"),
        window_ms=100,
        protocol_filter="all",
        flow_idle_timeout_sec=60.0,
    )
    cli._run_build_replay_trace_command(args)

    trace = json.loads((source_dir / "custom_trace.json").read_text(encoding="utf-8"))
    assert len(trace["source_packet_jsonl_files"]) == 2


def test_cli_build_replay_trace_uses_input_glob(tmp_path: Path) -> None:
    """--input-glob expands and sorts JSONL files."""
    source_dir = tmp_path / "session_20260101_010203_123456"
    source_dir.mkdir()
    (source_dir / "session_meta.json").write_text(json.dumps({"session_id": "session_20260101_010203_123456"}), encoding="utf-8")
    _write_packet_jsonl(source_dir / "packets" / "b.jsonl")
    _write_packet_jsonl(source_dir / "packets" / "a.jsonl")

    args = argparse.Namespace(
        source_dir=str(source_dir),
        pi_ip="10.0.0.1",
        input=[],
        input_glob=str(source_dir / "packets" / "*.jsonl"),
        output=None,
        window_ms=100,
        protocol_filter="all",
        flow_idle_timeout_sec=60.0,
    )
    cli._run_build_replay_trace_command(args)

    trace = json.loads((source_dir / "replay_trace.json").read_text(encoding="utf-8"))
    assert trace["source_packet_jsonl_files"][0].endswith("a.jsonl")
    assert trace["source_packet_jsonl_files"][1].endswith("b.jsonl")
