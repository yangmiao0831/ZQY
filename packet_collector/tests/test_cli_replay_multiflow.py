"""Tests for TCP multi-flow replay CLI arguments."""

from __future__ import annotations

import argparse
from pathlib import Path

import pytest

import packet_collector.cli as cli


def test_cli_replay_server_passes_max_flows(monkeypatch, tmp_path: Path) -> None:
    """replay-server passes --max-flows to the runner."""
    calls = {}

    def fake_run_replay_server(**kwargs):
        calls.update(kwargs)
        return tmp_path / "server.json"

    monkeypatch.setattr(cli, "run_replay_server", fake_run_replay_server)
    args = argparse.Namespace(
        trace_file=str(tmp_path / "replay_trace.json"),
        host="127.0.0.1",
        port=9000,
        protocol="tcp",
        flow_id=None,
        role="download",
        max_flows=3,
        all_flows=False,
        max_datagram_size=1200,
        output=None,
        timeout=5.0,
    )

    cli._run_replay_server_command(args)

    assert calls["max_flows"] == 3


def test_cli_replay_client_all_flows_maps_to_none(monkeypatch, tmp_path: Path) -> None:
    """replay-client maps --all-flows to max_flows=None."""
    calls = {}

    def fake_run_replay_client(**kwargs):
        calls.update(kwargs)
        return tmp_path / "client.json"

    monkeypatch.setattr(cli, "run_replay_client", fake_run_replay_client)
    args = argparse.Namespace(
        trace_file=str(tmp_path / "replay_trace.json"),
        server="127.0.0.1",
        port=9000,
        protocol="tcp",
        flow_id=None,
        role=None,
        max_flows=1,
        all_flows=True,
        max_datagram_size=1200,
        output=None,
        timeout=5.0,
    )

    cli._run_replay_client_command(args)

    assert calls["max_flows"] is None


def test_cli_replay_parser_rejects_max_flows_with_all_flows() -> None:
    """The parser rejects mutually exclusive flow selection options."""
    parser = cli.build_parser()
    with pytest.raises(SystemExit):
        parser.parse_args(
            [
                "replay-server",
                "replay_trace.json",
                "--max-flows",
                "2",
                "--all-flows",
            ]
        )
