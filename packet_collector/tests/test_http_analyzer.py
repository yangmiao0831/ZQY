"""Tests for HTTP application summary analysis."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.analyzers.http_analyzer import analyze_http_jsonl


def test_analyze_http_jsonl_summary(tmp_path: Path) -> None:
    """HTTP analyzer counts requests, responses, methods, status, and content length."""
    packet_jsonl = tmp_path / "packets.jsonl"
    records = [
        {
            "time_epoch": 1.0,
            "frame_len": 200,
            "src_ip": "10.0.0.1",
            "dst_ip": "10.0.0.2",
            "src_port": 50000,
            "dst_port": 8080,
            "http_method": "GET",
            "http_host": "example.local",
            "http_uri": "/",
            "http_user_agent": "curl/8",
        },
        {
            "time_epoch": 1.1,
            "frame_len": 220,
            "src_ip": "10.0.0.1",
            "dst_ip": "10.0.0.2",
            "src_port": 50001,
            "dst_port": 8080,
            "http_method": "POST",
            "http_host": "example.local",
            "http_uri": "/upload",
        },
        {
            "time_epoch": 1.2,
            "frame_len": 300,
            "src_ip": "10.0.0.2",
            "dst_ip": "10.0.0.1",
            "src_port": 8080,
            "dst_port": 50000,
            "http_status_code": 200,
            "http_content_length": 123,
            "http_content_type": "text/plain",
        },
        {
            "time_epoch": 1.3,
            "frame_len": 260,
            "src_ip": "10.0.0.2",
            "dst_ip": "10.0.0.1",
            "src_port": 8080,
            "dst_port": 50001,
            "http_status_code": 404,
            "http_content_length": 10,
            "http_content_type": "text/html",
        },
    ]
    with packet_jsonl.open("w", encoding="utf-8") as file:
        for record in records:
            file.write(json.dumps(record) + "\n")
        file.write("{bad json\n")

    output = analyze_http_jsonl(packet_jsonl, tmp_path / "http_summary.json")
    summary = json.loads(output.read_text(encoding="utf-8"))

    assert summary["packet_count"] == 4
    assert summary["invalid_record_count"] == 1
    assert summary["request_count"] == 2
    assert summary["response_count"] == 2
    assert summary["method_counts"]["GET"] == 1
    assert summary["method_counts"]["POST"] == 1
    assert summary["status_code_counts"]["200"] == 1
    assert summary["status_code_counts"]["404"] == 1
    assert summary["content_length_total"] == 133
