"""Tests for collect-device CLI helper."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli


def test_cli_collect_device_writes_output_and_updates_meta(monkeypatch, tmp_path: Path) -> None:
    """collect-device writes JSON and updates task metadata."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir(parents=True)
    (task_dir / "task_meta.json").write_text("{}", encoding="utf-8")

    def fake_collect_device_metrics(disk_path: str = "/") -> dict[str, object]:
        return {
            "collector_type": "device",
            "success": True,
            "start_time_epoch": 1.0,
            "end_time_epoch": 1.1,
            "duration_ms": 100.0,
            "error": None,
            "cpu_percent": 12.3,
        }

    monkeypatch.setattr(cli, "collect_device_metrics", fake_collect_device_metrics)
    args = argparse.Namespace(output=None, task_dir=str(task_dir), disk_path="/")

    cli._run_collect_device_command(args)

    output = task_dir / "device_metrics.json"
    assert output.exists()
    result = json.loads(output.read_text(encoding="utf-8"))
    assert result["collector_type"] == "device"

    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["collectors"]["device"]["status"] == "completed"
    assert metadata["collectors"]["device"]["output"].endswith("device_metrics.json")
