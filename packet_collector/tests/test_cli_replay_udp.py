"""Tests for UDP replay CLI arguments."""

from __future__ import annotations

import argparse
from pathlib import Path

import pytest

import packet_collector.cli as cli


def test_cli_replay_server_passes_udp_arguments(monkeypatch, tmp_path: Path) -> None:
    """replay-server passes UDP protocol options to the runner."""
    calls = {}

    def fake_run_replay_server(**kwargs):
        calls.update(kwargs)
        return tmp_path / "server.json"

    monkeypatch.setattr(cli, "run_replay_server", fake_run_replay_server)
    args = argparse.Namespace(
        trace_file=str(tmp_path / "replay_trace.json"),
        host="127.0.0.1",
        port=9000,
        protocol="udp",
        flow_id=None,
        role=None,
        max_flows=2,
        all_flows=False,
        max_datagram_size=1000,
        output=None,
        timeout=5.0,
    )

    cli._run_replay_server_command(args)

    assert calls["protocol"] == "udp"
    assert calls["max_flows"] == 2
    assert calls["max_datagram_size"] == 1000


def test_cli_replay_client_passes_udp_arguments(monkeypatch, tmp_path: Path) -> None:
    """replay-client passes UDP protocol options to the runner."""
    calls = {}

    def fake_run_replay_client(**kwargs):
        calls.update(kwargs)
        return tmp_path / "client.json"

    monkeypatch.setattr(cli, "run_replay_client", fake_run_replay_client)
    args = argparse.Namespace(
        trace_file=str(tmp_path / "replay_trace.json"),
        server="127.0.0.1",
        port=9000,
        protocol="udp",
        flow_id=None,
        role="download",
        max_flows=3,
        all_flows=False,
        max_datagram_size=900,
        output=None,
        timeout=5.0,
    )

    cli._run_replay_client_command(args)

    assert calls["protocol"] == "udp"
    assert calls["role"] == "download"
    assert calls["max_flows"] == 3
    assert calls["max_datagram_size"] == 900


def test_cli_replay_protocol_all_is_explicitly_rejected(tmp_path: Path) -> None:
    """protocol=all is reserved for a later replay scheduler."""
    args = argparse.Namespace(
        trace_file=str(tmp_path / "replay_trace.json"),
        host="127.0.0.1",
        port=9000,
        protocol="all",
        flow_id=None,
        role=None,
        max_flows=1,
        all_flows=False,
        max_datagram_size=1200,
        output=None,
        timeout=5.0,
    )
    with pytest.raises(SystemExit):
        cli._run_replay_server_command(args)
