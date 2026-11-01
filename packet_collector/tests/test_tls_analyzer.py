"""Tests for TLS application metadata summary analysis."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.analyzers.tls_analyzer import analyze_tls_jsonl


def test_analyze_tls_jsonl_summary(tmp_path: Path) -> None:
    """TLS analyzer counts metadata fields without decrypting HTTPS."""
    packet_jsonl = tmp_path / "packets.jsonl"
    records = [
        {
            "time_epoch": 1.0,
            "frame_len": 180,
            "src_ip": "10.0.0.1",
            "dst_ip": "93.184.216.34",
            "src_port": 51000,
            "dst_port": 443,
            "tcp_stream": 7,
            "tls_handshake_type": "1",
            "tls_sni": "example.com",
            "tls_record_version": "0x0303",
            "tls_handshake_version": "0x0303",
        },
        {
            "time_epoch": 1.1,
            "frame_len": 220,
            "src_ip": "93.184.216.34",
            "dst_ip": "10.0.0.1",
            "src_port": 443,
            "dst_port": 51000,
            "tcp_stream": 7,
            "tls_handshake_type": "2",
            "tls_record_version": "0x0303",
        },
    ]
    with packet_jsonl.open("w", encoding="utf-8") as file:
        for record in records:
            file.write(json.dumps(record) + "\n")
        file.write("{bad json\n")

    output = analyze_tls_jsonl(packet_jsonl, tmp_path / "tls_summary.json")
    summary = json.loads(output.read_text(encoding="utf-8"))

    assert summary["packet_count"] == 2
    assert summary["invalid_record_count"] == 1
    assert summary["handshake_type_counts"]["1"] == 1
    assert summary["handshake_type_counts"]["2"] == 1
    assert summary["sni_counts"]["example.com"] == 1
    assert summary["record_version_counts"]["0x0303"] == 2
    assert summary["tcp_stream_counts"]["7"] == 2
    assert "URL path" in summary["https_visibility_note"]
