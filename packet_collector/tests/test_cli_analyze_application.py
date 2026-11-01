"""Tests for application analysis CLI handlers."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli


def test_cli_analyze_dns_updates_meta(tmp_path: Path) -> None:
    """analyze-dns writes a summary and updates task metadata."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir(parents=True)
    (task_dir / "task_meta.json").write_text("{}", encoding="utf-8")
    (task_dir / "packets.jsonl").write_text(
        json.dumps(
            {
                "time_epoch": 1.0,
                "frame_len": 80,
                "src_ip": "10.0.0.1",
                "dst_ip": "8.8.8.8",
                "src_port": 53000,
                "dst_port": 53,
                "dns_query_name": "example.com",
                "dns_query_type": "A",
            }
        )
        + "\n",
        encoding="utf-8",
    )

    args = argparse.Namespace(task_dir=str(task_dir), input=None, output=None)
    cli._run_analyze_command(args, "dns")

    assert (task_dir / "dns_summary.json").exists()
    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["dns_analysis_status"] == "completed"
    assert metadata["dns_analysis_error"] is None
    assert metadata["dns_summary"].endswith("dns_summary.json")
