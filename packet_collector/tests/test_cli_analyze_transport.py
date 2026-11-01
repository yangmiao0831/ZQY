"""Tests for transport analysis CLI handlers."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli


def test_cli_analyze_tcp_updates_meta(tmp_path: Path) -> None:
    """analyze-tcp writes a summary and updates task metadata."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir(parents=True)
    (task_dir / "task_meta.json").write_text("{}", encoding="utf-8")
    (task_dir / "packets.jsonl").write_text(
        json.dumps(
            {
                "time_epoch": 1.0,
                "frame_len": 100,
                "tcp_len": 20,
                "tcp_stream": 1,
                "src_ip": "10.0.0.1",
                "dst_ip": "10.0.0.2",
                "src_port": 10000,
                "dst_port": 443,
            }
        )
        + "\n",
        encoding="utf-8",
    )

    args = argparse.Namespace(task_dir=str(task_dir), input=None, output=None)
    cli._run_analyze_command(args, "tcp")

    assert (task_dir / "tcp_summary.json").exists()
    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["tcp_analysis_status"] == "completed"
    assert metadata["tcp_analysis_error"] is None
    assert metadata["tcp_summary"].endswith("tcp_summary.json")
