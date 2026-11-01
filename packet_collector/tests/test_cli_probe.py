"""Tests for probe CLI helper."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli


def test_cli_probe_writes_output_and_updates_meta(monkeypatch, tmp_path: Path) -> None:
    """Probe CLI writes JSON and updates task metadata."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir(parents=True)
    (task_dir / "task_meta.json").write_text("{}", encoding="utf-8")

    def fake_run_ping_probe(target: str, count: int = 4, timeout: int = 5) -> dict[str, object]:
        return {
            "probe_type": "ping",
            "target": target,
            "success": True,
            "start_time_epoch": 1.0,
            "end_time_epoch": 1.1,
            "duration_ms": 100.0,
            "error": None,
        }

    monkeypatch.setattr(cli, "run_ping_probe", fake_run_ping_probe)
    args = argparse.Namespace(
        probe_type="ping",
        target="192.168.1.1",
        port=443,
        count=4,
        timeout=5,
        method="GET",
        dns_server=None,
        server_hostname=None,
        output=None,
        task_dir=str(task_dir),
    )

    cli._run_probe_command(args)

    output = task_dir / "probe_ping.json"
    assert output.exists()
    result = json.loads(output.read_text(encoding="utf-8"))
    assert result["success"] is True

    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["probes"]["ping"]["status"] == "completed"
    assert metadata["probes"]["ping"]["output"].endswith("probe_ping.json")
