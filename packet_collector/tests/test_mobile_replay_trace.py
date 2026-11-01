"""Tests for replay traces built across changing Pi IPv4 addresses."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli
from packet_collector.replay.trace_builder import build_replay_trace, load_pi_ips_from_network_events


def _write_packets(path: Path) -> Path:
    """Write packets using two historical Pi IP addresses."""
    records = [
        {"time_epoch": 1.0, "protocols": "eth:ip:tcp", "src_ip": "10.1.1.1", "dst_ip": "47.93.192.193", "src_port": 50000, "dst_port": 443, "tcp_len": 100},
        {"time_epoch": 2.0, "protocols": "eth:ip:tcp", "src_ip": "47.93.192.193", "dst_ip": "10.2.2.2", "src_port": 443, "dst_port": 51000, "tcp_len": 200},
    ]
    path.write_text("\n".join(json.dumps(record) for record in records) + "\n", encoding="utf-8")
    return path


def _write_events(path: Path) -> Path:
    """Write network events containing old and new IPv4 addresses."""
    records = [
        {"event": "snapshot", "ipv4": "10.1.1.1"},
        {"event": "ip_changed", "old_ipv4": "10.1.1.1", "new_ipv4": "10.2.2.2"},
        {"event": "snapshot", "ipv4": "10.2.2.2"},
    ]
    path.write_text("\n".join(json.dumps(record) for record in records) + "\n", encoding="utf-8")
    return path


def test_build_replay_trace_accepts_multiple_pi_ips(tmp_path: Path) -> None:
    """Packets using either historical Pi IP get a direction."""
    packets = _write_packets(tmp_path / "packets.jsonl")
    output = build_replay_trace(
        [packets],
        tmp_path / "replay_trace.json",
        pi_ips=["10.1.1.1", "10.2.2.2"],
        pi_ip_source="explicit_list",
    )
    trace = json.loads(output.read_text(encoding="utf-8"))
    assert trace["pi_ips"] == ["10.1.1.1", "10.2.2.2"]
    assert trace["pi_ip_source"] == "explicit_list"
    assert trace["flow_count"] == 2
    directions = {flow["events"][0]["direction"] for flow in trace["flows"]}
    assert directions == {"pi_to_peer", "peer_to_pi"}


def test_load_pi_ips_from_network_events(tmp_path: Path) -> None:
    """Network event snapshots and changes produce a de-duplicated IP list."""
    events = _write_events(tmp_path / "network_events.jsonl")
    assert load_pi_ips_from_network_events(events) == ["10.1.1.1", "10.2.2.2"]


def test_cli_build_replay_trace_uses_network_events(tmp_path: Path) -> None:
    """CLI can derive Pi IPs from session network events."""
    session_dir = tmp_path / "session_test"
    session_dir.mkdir()
    (session_dir / "session_meta.json").write_text(json.dumps({"session_id": "session_test"}), encoding="utf-8")
    _write_packets(session_dir / "packets.jsonl")
    _write_events(session_dir / "network_events.jsonl")
    args = argparse.Namespace(
        source_dir=str(session_dir),
        pi_ip=None,
        pi_ip_list=None,
        use_network_events=True,
        input=[],
        input_glob=None,
        output=None,
        window_ms=100,
        protocol_filter="all",
        flow_idle_timeout_sec=60.0,
    )
    cli._run_build_replay_trace_command(args)
    trace = json.loads((session_dir / "replay_trace.json").read_text(encoding="utf-8"))
    metadata = json.loads((session_dir / "session_meta.json").read_text(encoding="utf-8"))
    assert trace["pi_ips"] == ["10.1.1.1", "10.2.2.2"]
    assert trace["pi_ip_source"] == "network_events"
    assert metadata["replay"]["pi_ip_source"] == "network_events"
