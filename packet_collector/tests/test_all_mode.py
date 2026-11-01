"""Tests for full-packet capture parse and analyze workflow helpers."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli
from packet_collector.analyzers.dns_analyzer import analyze_dns_jsonl
from packet_collector.analyzers.tcp_analyzer import analyze_tcp_jsonl


def test_mixed_jsonl_analyzers_skip_unrelated_records(tmp_path: Path) -> None:
    """Protocol analyzers should only count their own records in all-mode JSONL."""
    packets = tmp_path / "packets.jsonl"
    packets.write_text(
        "\n".join(
            [
                json.dumps(
                    {
                        "packet_type": "all",
                        "time_epoch": 1.0,
                        "frame_len": 100,
                        "protocols": "eth:ip:tcp",
                        "src_ip": "10.0.0.1",
                        "dst_ip": "10.0.0.2",
                        "src_port": 50000,
                        "dst_port": 443,
                        "tcp_len": 20,
                        "tcp_stream": 1,
                    }
                ),
                json.dumps(
                    {
                        "packet_type": "all",
                        "time_epoch": 2.0,
                        "frame_len": 80,
                        "protocols": "eth:ip:udp:dns",
                        "src_ip": "10.0.0.1",
                        "dst_ip": "8.8.8.8",
                        "src_port": 53000,
                        "dst_port": 53,
                        "udp_length": 40,
                        "dns_query_name": "example.com",
                        "dns_query_type": "A",
                    }
                ),
            ]
        )
        + "\n",
        encoding="utf-8",
    )

    tcp_output = analyze_tcp_jsonl(packets, tmp_path / "tcp_summary.json")
    dns_output = analyze_dns_jsonl(packets, tmp_path / "dns_summary.json")

    tcp_summary = json.loads(tcp_output.read_text(encoding="utf-8"))
    dns_summary = json.loads(dns_output.read_text(encoding="utf-8"))
    assert tcp_summary["packet_count"] == 1
    assert dns_summary["packet_count"] == 1
    assert dns_summary["query_count"] == 1


def test_cli_analyze_all_generates_all_summaries(tmp_path: Path) -> None:
    """analyze-all creates every transport and application summary file."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir(parents=True)
    (task_dir / "task_meta.json").write_text("{}", encoding="utf-8")
    (task_dir / "packets.jsonl").write_text(
        json.dumps(
            {
                "packet_type": "all",
                "time_epoch": 1.0,
                "frame_len": 100,
                "protocols": "eth:ip:tcp:tls",
                "src_ip": "10.0.0.1",
                "dst_ip": "10.0.0.2",
                "src_port": 50000,
                "dst_port": 443,
                "tcp_len": 20,
                "tcp_stream": 1,
                "tls_sni": "example.com",
            }
        )
        + "\n",
        encoding="utf-8",
    )

    args = argparse.Namespace(task_dir=str(task_dir), input=None)
    cli._run_analyze_all_command(args)

    for protocol in ["tcp", "udp", "icmp", "dns", "http", "tls"]:
        assert (task_dir / f"{protocol}_summary.json").exists()

    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["tcp_analysis_status"] == "completed"
    assert metadata["tls_analysis_status"] == "completed"
