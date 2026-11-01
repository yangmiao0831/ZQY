"""Tests for ICMP transport summary analysis."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.analyzers.icmp_analyzer import analyze_icmp_jsonl


def test_analyze_icmp_jsonl_summary(tmp_path: Path) -> None:
    """ICMP analyzer counts echo and error message types."""
    packet_jsonl = tmp_path / "packets.jsonl"
    records = [
        {
            "time_epoch": 1.0,
            "frame_len": 84,
            "src_ip": "10.0.0.1",
            "dst_ip": "10.0.0.2",
            "icmp_type": 8,
            "icmp_code": 0,
        },
        {
            "time_epoch": 1.1,
            "frame_len": 84,
            "src_ip": "10.0.0.2",
            "dst_ip": "10.0.0.1",
            "icmp_type": 0,
            "icmp_code": 0,
        },
        {
            "time_epoch": 1.2,
            "frame_len": 70,
            "src_ip": "10.0.0.254",
            "dst_ip": "10.0.0.1",
            "icmp_type": 3,
            "icmp_code": 1,
        },
    ]
    packet_jsonl.write_text("\n".join(json.dumps(record) for record in records) + "\n", encoding="utf-8")

    output = analyze_icmp_jsonl(packet_jsonl, tmp_path / "icmp_summary.json")
    summary = json.loads(output.read_text(encoding="utf-8"))

    assert summary["packet_count"] == 3
    assert summary["echo_request_count"] == 1
    assert summary["echo_reply_count"] == 1
    assert summary["error_message_count"] == 1
    assert summary["icmp_type_counts"]["8"] == 1
    assert summary["icmp_type_counts"]["0"] == 1
    assert summary["icmp_type_counts"]["3"] == 1
