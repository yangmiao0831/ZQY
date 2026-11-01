"""Tests for replay client/server CLI handlers."""

from __future__ import annotations

import argparse
from pathlib import Path

import packet_collector.cli as cli


def test_cli_replay_server_passes_arguments(monkeypatch, tmp_path: Path) -> None:
    """CLI replay-server passes arguments to runner."""
    calls = {}

    def fake_run_replay_server(**kwargs):
        calls.update(kwargs)
        return tmp_path / "server.json"

    monkeypatch.setattr(cli, "run_replay_server", fake_run_replay_server)
    args = argparse.Namespace(
        trace_file=str(tmp_path / "replay_trace.json"),
        host="127.0.0.1",
        port=9001,
        protocol="tcp",
        flow_id="flow-a",
        role="download",
        max_flows=1,
        all_flows=False,
        max_datagram_size=1200,
        output=str(tmp_path / "out_server.json"),
        timeout=3.0,
    )

    cli._run_replay_server_command(args)

    assert calls["trace_file"] == tmp_path / "replay_trace.json"
    assert calls["host"] == "127.0.0.1"
    assert calls["port"] == 9001
    assert calls["protocol"] == "tcp"
    assert calls["flow_id"] == "flow-a"
    assert calls["role"] == "download"
    assert calls["max_flows"] == 1
    assert calls["output_file"] == tmp_path / "out_server.json"
    assert calls["timeout"] == 3.0


def test_cli_replay_client_passes_arguments(monkeypatch, tmp_path: Path) -> None:
    """CLI replay-client passes arguments to runner."""
    calls = {}

    def fake_run_replay_client(**kwargs):
        calls.update(kwargs)
        return tmp_path / "client.json"

    monkeypatch.setattr(cli, "run_replay_client", fake_run_replay_client)
    args = argparse.Namespace(
        trace_file=str(tmp_path / "replay_trace.json"),
        server="192.168.31.79",
        port=9002,
        protocol="tcp",
        flow_id=None,
        role="download",
        max_flows=1,
        all_flows=False,
        max_datagram_size=1200,
        output=str(tmp_path / "out_client.json"),
        timeout=4.0,
    )

    cli._run_replay_client_command(args)

    assert calls["trace_file"] == tmp_path / "replay_trace.json"
    assert calls["server"] == "192.168.31.79"
    assert calls["port"] == 9002
    assert calls["protocol"] == "tcp"
    assert calls["flow_id"] is None
    assert calls["role"] == "download"
    assert calls["max_flows"] == 1
    assert calls["output_file"] == tmp_path / "out_client.json"
    assert calls["timeout"] == 4.0
