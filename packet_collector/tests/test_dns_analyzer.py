"""Tests for DNS application summary analysis."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.analyzers.dns_analyzer import analyze_dns_jsonl


def test_analyze_dns_jsonl_summary(tmp_path: Path) -> None:
    """DNS analyzer counts queries, responses, answers, and invalid lines."""
    packet_jsonl = tmp_path / "packets.jsonl"
    records = [
        {
            "time_epoch": 1.0,
            "frame_len": 80,
            "src_ip": "10.0.0.1",
            "dst_ip": "8.8.8.8",
            "src_port": 53000,
            "dst_port": 53,
            "dns_query_name": "example.com",
            "dns_query_type": "A",
        },
        {
            "time_epoch": 1.1,
            "frame_len": 120,
            "src_ip": "8.8.8.8",
            "dst_ip": "10.0.0.1",
            "src_port": 53,
            "dst_port": 53000,
            "dns_query_name": "example.com",
            "dns_query_type": "A",
            "dns_response_code": "0",
            "dns_answer_ipv4": "93.184.216.34",
        },
    ]
    with packet_jsonl.open("w", encoding="utf-8") as file:
        for record in records:
            file.write(json.dumps(record) + "\n")
        file.write("{bad json\n")

    output = analyze_dns_jsonl(packet_jsonl, tmp_path / "dns_summary.json")
    summary = json.loads(output.read_text(encoding="utf-8"))

    assert summary["packet_count"] == 2
    assert summary["invalid_record_count"] == 1
    assert summary["query_count"] == 2
    assert summary["response_count"] == 1
    assert summary["query_name_counts"]["example.com"] == 2
    assert summary["response_code_counts"]["0"] == 1
    assert summary["answer_ipv4_counts"]["93.184.216.34"] == 1
