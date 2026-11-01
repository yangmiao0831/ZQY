"""Tests for UDP transport summary analysis."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.analyzers.udp_analyzer import analyze_udp_jsonl


def test_analyze_udp_jsonl_summary(tmp_path: Path) -> None:
    """UDP analyzer computes byte, port, and throughput metrics."""
    packet_jsonl = tmp_path / "packets.jsonl"
    records = [
        {
            "time_epoch": 1.0,
            "frame_len": 100,
            "udp_length": 60,
            "src_ip": "10.0.0.1",
            "dst_ip": "8.8.8.8",
            "src_port": 50000,
            "dst_port": 53,
        },
        {
            "time_epoch": 2.0,
            "frame_len": 140,
            "udp_length": 90,
            "src_ip": "8.8.8.8",
            "dst_ip": "10.0.0.1",
            "src_port": 53,
            "dst_port": 50000,
        },
    ]
    packet_jsonl.write_text("\n".join(json.dumps(record) for record in records) + "\n", encoding="utf-8")

    output = analyze_udp_jsonl(packet_jsonl, tmp_path / "udp_summary.json")
    summary = json.loads(output.read_text(encoding="utf-8"))

    assert summary["packet_count"] == 2
    assert summary["total_udp_bytes"] == 150
    assert summary["dst_port_counts"]["53"] == 1
    assert summary["throughput_bps_udp"] == 1200.0
    assert summary["throughput_bps_frame"] == 1920.0
