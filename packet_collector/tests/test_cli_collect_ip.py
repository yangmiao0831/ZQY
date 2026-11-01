"""Tests for collect-ip CLI helper."""

from __future__ import annotations

import argparse
import json

import packet_collector.cli as cli


def test_cli_collect_ip_writes_output_and_updates_meta(monkeypatch, tmp_path) -> None:
    """collect-ip writes JSON and updates task metadata."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir(parents=True)
    (task_dir / "task_meta.json").write_text("{}", encoding="utf-8")

    def fake_collect_ip_metrics(iface: str, target: str | None = None, ping_count: int = 4, ping_timeout: int = 5):
        return {
            "collector_type": "ip",
            "success": True,
            "start_time_epoch": 1.0,
            "end_time_epoch": 1.1,
            "duration_ms": 100.0,
            "error": None,
            "iface": iface,
            "target_ping": {"target": target, "success": True},
        }

    monkeypatch.setattr(cli, "collect_ip_metrics", fake_collect_ip_metrics)
    args = argparse.Namespace(
        iface="wlan0",
        target="192.168.31.79",
        ping_count=4,
        ping_timeout=5,
        output=None,
        task_dir=str(task_dir),
    )

    cli._run_collect_ip_command(args)

    output = task_dir / "ip_metrics.json"
    assert output.exists()
    result = json.loads(output.read_text(encoding="utf-8"))
    assert result["collector_type"] == "ip"

    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["collectors"]["ip"]["status"] == "completed"
    assert metadata["collectors"]["ip"]["output"].endswith("ip_metrics.json")
