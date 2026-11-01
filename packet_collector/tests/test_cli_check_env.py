"""Tests for check-env CLI helper."""

from __future__ import annotations

import argparse
import json

import packet_collector.cli as cli


def test_cli_check_env_writes_output(monkeypatch, tmp_path) -> None:
    """check-env writes deploy_check.json when --output is provided."""

    def fake_run_env_check(tmp_capture_dir, final_capture_dir):
        return {
            "check_type": "deploy_env",
            "success": True,
            "python": {"version": "3.11.0"},
            "commands": {
                "dumpcap": {"available": True},
                "tshark": {"available": True},
            },
            "paths": {
                "tmp_capture_dir": {"writable": True},
                "final_capture_dir": {"writable": True},
            },
        }

    monkeypatch.setattr(cli, "run_env_check", fake_run_env_check)
    output = tmp_path / "deploy_check.json"
    args = argparse.Namespace(output=str(output), tmp_capture_dir=str(tmp_path / "tmpcap"), final_capture_dir=str(tmp_path / "captures"))

    cli._run_check_env_command(args)

    assert output.exists()
    result = json.loads(output.read_text(encoding="utf-8"))
    assert result["success"] is True
