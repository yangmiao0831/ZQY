"""Tests for TCP transport summary analysis."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.analyzers.tcp_analyzer import analyze_tcp_jsonl


def _write_jsonl(path: Path, records: list[dict[str, object]], bad_line: bool = False) -> Path:
    """Write fake JSONL records for analyzer tests."""
    with path.open("w", encoding="utf-8") as file:
        for record in records:
            file.write(json.dumps(record) + "\n")
        if bad_line:
            file.write("{bad json\n")
    return path


def test_analyze_tcp_jsonl_summary(tmp_path: Path) -> None:
    """TCP analyzer computes stream, retransmission, RTT, and throughput metrics."""
    packet_jsonl = _write_jsonl(
        tmp_path / "packets.jsonl",
        [
            {
                "time_epoch": 1.0,
                "frame_len": 100,
                "src_ip": "10.0.0.1",
                "dst_ip": "10.0.0.2",
                "src_port": 10000,
                "dst_port": 443,
                "tcp_len": 40,
                "tcp_stream": 1,
                "tcp_flags": "0x0018",
                "tcp_ack_rtt": 0.01,
            },
            {
                "time_epoch": 2.0,
                "frame_len": 120,
                "src_ip": "10.0.0.2",
                "dst_ip": "10.0.0.1",
                "src_port": 443,
                "dst_port": 10000,
                "tcp_len": 50,
                "tcp_stream": 1,
                "tcp_flags": "0x0010",
                "tcp_retransmission": True,
                "tcp_ack_rtt": 0.03,
            },
            {
                "time_epoch": 3.0,
                "frame_len": 80,
                "src_ip": "10.0.0.1",
                "dst_ip": "10.0.0.3",
                "src_port": 10001,
                "dst_port": 80,
                "tcp_len": 20,
                "tcp_stream": 2,
                "tcp_flags": "0x0002",
            },
        ],
        bad_line=True,
    )

    output = analyze_tcp_jsonl(packet_jsonl, tmp_path / "tcp_summary.json")
    summary = json.loads(output.read_text(encoding="utf-8"))

    assert summary["packet_count"] == 3
    assert summary["invalid_record_count"] == 1
    assert summary["stream_count"] == 2
    assert summary["retransmission_count"] == 1
    assert summary["ack_rtt_avg"] == 0.02
    assert summary["ack_rtt_min"] == 0.01
    assert summary["ack_rtt_max"] == 0.03
    assert summary["throughput_bps_frame"] is not None
    assert summary["throughput_bps_tcp_payload"] is not None
    assert summary["streams"]["1"]["packet_count"] == 2
    assert summary["dst_port_counts"]["443"] == 1
