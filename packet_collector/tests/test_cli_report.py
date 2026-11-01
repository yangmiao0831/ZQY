"""Tests for report CLI helper."""

from __future__ import annotations

import argparse
import json

import packet_collector.cli as cli


def test_cli_report_generates_report_and_updates_meta(tmp_path) -> None:
    """CLI report handler writes task_report.json and updates task_meta.json."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir()
    (task_dir / "task_meta.json").write_text("{}", encoding="utf-8")
    (task_dir / "device_metrics.json").write_text(json.dumps({"success": True}), encoding="utf-8")

    args = argparse.Namespace(task_dir=str(task_dir), output=None)
    cli._run_report_command(args)

    assert (task_dir / "task_report.json").exists()
    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["report"]["status"] == "completed"
    assert metadata["report"]["output"].endswith("task_report.json")
