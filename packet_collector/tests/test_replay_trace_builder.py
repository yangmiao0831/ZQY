"""Tests for replay trace construction from packet JSONL."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.replay.trace_builder import build_replay_trace


def _write_jsonl(path: Path, records: list[dict[str, object] | str]) -> Path:
    """Write mixed valid and invalid JSONL records."""
    lines: list[str] = []
    for record in records:
        lines.append(record if isinstance(record, str) else json.dumps(record))
    path.write_text("\n".join(lines) + "\n", encoding="utf-8")
    return path


def _load(path: Path) -> dict[str, object]:
    """Load a JSON file."""
    return json.loads(path.read_text(encoding="utf-8"))


def test_tcp_download_flow(tmp_path: Path) -> None:
    """TCP download flow is detected from peer-to-Pi byte dominance."""
    packets = _write_jsonl(
        tmp_path / "packets.jsonl",
        [
            {"time_epoch": 1.0, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 100, "tcp_stream": 0},
            {"time_epoch": 1.1, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.2", "dst_ip": "10.0.0.1", "src_port": 443, "dst_port": 50000, "tcp_len": 1000, "tcp_stream": 0},
            {"time_epoch": 1.2, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.2", "dst_ip": "10.0.0.1", "src_port": 443, "dst_port": 50000, "tcp_len": 1000, "tcp_stream": 0},
        ],
    )

    output = build_replay_trace([packets], tmp_path / "replay_trace.json", pi_ip="10.0.0.1")
    trace = _load(output)
    flow = trace["flows"][0]

    assert trace["flow_count"] == 1
    assert flow["role"] == "download"
    assert flow["bytes_pi_to_peer"] == 100
    assert flow["bytes_peer_to_pi"] == 2000
    assert flow["events"]
    assert {event["direction"] for event in flow["events"]} == {"pi_to_peer", "peer_to_pi"}


def test_udp_bidirectional_flow_uses_payload_length(tmp_path: Path) -> None:
    """UDP payload bytes use udp_length minus the UDP header."""
    packets = _write_jsonl(
        tmp_path / "packets.jsonl",
        [
            {"time_epoch": 1.0, "protocols": "eth:ip:udp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 53000, "dst_port": 53, "udp_length": 108},
            {"time_epoch": 1.1, "protocols": "eth:ip:udp", "src_ip": "10.0.0.2", "dst_ip": "10.0.0.1", "src_port": 53, "dst_port": 53000, "udp_length": 108},
        ],
    )

    trace = _load(build_replay_trace([packets], tmp_path / "replay_trace.json", pi_ip="10.0.0.1"))
    flow = trace["flows"][0]

    assert flow["protocol"] == "udp"
    assert flow["role"] == "bidirectional"
    assert flow["bytes_pi_to_peer"] == 100
    assert flow["bytes_peer_to_pi"] == 100


def test_window_aggregation(tmp_path: Path) -> None:
    """Packets inside one time window are aggregated into one event."""
    packets = _write_jsonl(
        tmp_path / "packets.jsonl",
        [
            {"time_epoch": 1.00, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 100},
            {"time_epoch": 1.05, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 200},
            {"time_epoch": 1.09, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 300},
        ],
    )

    trace = _load(build_replay_trace([packets], tmp_path / "replay_trace.json", pi_ip="10.0.0.1", window_ms=100))
    events = trace["flows"][0]["events"]

    assert len(events) == 1
    assert events[0]["bytes"] == 600
    assert events[0]["packet_count"] == 3


def test_bad_json_and_unrelated_protocol_are_counted(tmp_path: Path) -> None:
    """Invalid JSON and skipped non-TCP/UDP records are tracked."""
    packets = _write_jsonl(
        tmp_path / "packets.jsonl",
        [
            "{bad json",
            {"time_epoch": 1.0, "protocols": "eth:ip:icmp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "icmp_type": 8},
        ],
    )

    trace = _load(build_replay_trace([packets], tmp_path / "replay_trace.json", pi_ip="10.0.0.1"))

    assert trace["invalid_record_count"] == 1
    assert trace["skipped_record_count"] == 1
    assert trace["flow_count"] == 0
    assert trace["generation_warnings"]


def test_protocol_filter(tmp_path: Path) -> None:
    """Protocol filters keep only requested protocol records."""
    packets = _write_jsonl(
        tmp_path / "packets.jsonl",
        [
            {"time_epoch": 1.0, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 100},
            {"time_epoch": 1.1, "protocols": "eth:ip:udp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.3", "src_port": 53000, "dst_port": 53, "udp_length": 108},
        ],
    )

    tcp_trace = _load(build_replay_trace([packets], tmp_path / "tcp_trace.json", pi_ip="10.0.0.1", protocol_filter="tcp"))
    udp_trace = _load(build_replay_trace([packets], tmp_path / "udp_trace.json", pi_ip="10.0.0.1", protocol_filter="udp"))

    assert tcp_trace["flow_count"] == 1
    assert tcp_trace["flows"][0]["protocol"] == "tcp"
    assert udp_trace["flow_count"] == 1
    assert udp_trace["flows"][0]["protocol"] == "udp"


def test_multi_input_uses_global_base_time_and_merges_flow(tmp_path: Path) -> None:
    """Multiple JSONL inputs share one base time and can merge into one flow."""
    one = _write_jsonl(
        tmp_path / "one.jsonl",
        [{"time_epoch": 2.0, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 100}],
    )
    two = _write_jsonl(
        tmp_path / "two.jsonl",
        [{"time_epoch": 1.0, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.2", "dst_ip": "10.0.0.1", "src_port": 443, "dst_port": 50000, "tcp_len": 200}],
    )

    trace = _load(build_replay_trace([one, two], tmp_path / "replay_trace.json", pi_ip="10.0.0.1"))
    flow = trace["flows"][0]

    assert trace["flow_count"] == 1
    assert flow["start_offset_sec"] == 0.0
    assert flow["end_offset_sec"] == 1.0
    assert trace["duration_sec"] == 1.0


def test_flow_idle_timeout_splits_flow(tmp_path: Path) -> None:
    """Long idle gaps split reused endpoint pairs into separate flow instances."""
    packets = _write_jsonl(
        tmp_path / "packets.jsonl",
        [
            {"time_epoch": 1.0, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 100},
            {"time_epoch": 70.0, "protocols": "eth:ip:tcp", "src_ip": "10.0.0.1", "dst_ip": "10.0.0.2", "src_port": 50000, "dst_port": 443, "tcp_len": 100},
        ],
    )

    trace = _load(build_replay_trace([packets], tmp_path / "replay_trace.json", pi_ip="10.0.0.1", flow_idle_timeout_sec=60.0))

    assert trace["flow_count"] == 2
    assert trace["flows"][0]["flow_id"].endswith("_0")
    assert trace["flows"][1]["flow_id"].endswith("_1")


def test_empty_trace_is_valid(tmp_path: Path) -> None:
    """No TCP/UDP records still produces a valid empty replay trace."""
    packets = _write_jsonl(tmp_path / "packets.jsonl", [{"time_epoch": 1.0, "protocols": "eth:ip:icmp"}])

    trace = _load(build_replay_trace([packets], tmp_path / "replay_trace.json", pi_ip="10.0.0.1"))

    assert trace["flow_count"] == 0
    assert trace["flows"] == []
    assert trace["duration_sec"] == 0.0
