"""Tests for pcapng to JSONL conversion without real tshark."""

from __future__ import annotations

import json
from pathlib import Path

import pytest

from packet_collector.parsers import pcap_to_json
from packet_collector.parsers.pcap_to_json import (
    convert_value,
    parse_pcap_files_to_jsonl,
    parse_pcap_to_jsonl,
    parse_tshark_line,
)
from packet_collector.parsers.tshark_fields import get_fields_for_packet_type


TCP_LINE = "1710000000.123|128|192.168.1.20|192.168.1.10|eth:ip:tcp|443|50000|42|0x0018|1|True||False|0.012"


def test_convert_value() -> None:
    """String values are converted to JSON-friendly scalar types."""
    assert convert_value("") is None
    assert convert_value("42") == 42
    assert convert_value("0.125") == 0.125
    assert convert_value("true") is True
    assert convert_value("False") is False
    assert convert_value("192.168.1.1") == "192.168.1.1"


def test_parse_tshark_line() -> None:
    """One tshark fields line becomes one packet record."""
    fields = get_fields_for_packet_type("tcp")
    record = parse_tshark_line(TCP_LINE, fields, "tcp", Path("a.pcapng"))
    assert record["packet_type"] == "tcp"
    assert record["pcap_file"] == "a.pcapng"
    assert record["time_epoch"] == 1710000000.123
    assert record["frame_len"] == 128
    assert record["src_port"] == 443
    assert record["tcp_retransmission"] is True
    assert record["tcp_fast_retransmission"] is None
    assert record["tcp_out_of_order"] is False


def test_parse_tshark_line_coalesces_duplicate_json_fields() -> None:
    """All-mode field lists may ask tshark for TCP and UDP ports under one key."""
    fields = [("src_port", "tcp.srcport"), ("src_port", "udp.srcport")]
    record = parse_tshark_line("|53", fields, "all", Path("a.pcapng"))
    assert record["src_port"] == 53


def test_parse_pcap_to_jsonl(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """Parsing one pcap streams fake tshark lines into JSONL."""

    def fake_run_tshark_stream(command: list[str]) -> list[str]:
        return [TCP_LINE, TCP_LINE]

    monkeypatch.setattr(pcap_to_json, "run_tshark_stream", fake_run_tshark_stream)

    output = parse_pcap_to_jsonl(tmp_path / "one.pcapng", tmp_path / "packets.jsonl", "tcp")
    records = [json.loads(line) for line in output.read_text(encoding="utf-8").splitlines()]
    assert len(records) == 2
    assert records[0]["src_ip"] == "192.168.1.20"


def test_parse_pcap_files_to_jsonl(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """Parsing multiple pcaps writes one JSONL file with per-record pcap_file."""

    def fake_run_tshark_stream(command: list[str]) -> list[str]:
        return [TCP_LINE]

    monkeypatch.setattr(pcap_to_json, "run_tshark_stream", fake_run_tshark_stream)

    pcap_files = [tmp_path / "one.pcapng", tmp_path / "two.pcapng"]
    output = parse_pcap_files_to_jsonl(pcap_files, tmp_path / "packets.jsonl", "tcp")
    records = [json.loads(line) for line in output.read_text(encoding="utf-8").splitlines()]
    assert len(records) == 2
    assert records[0]["pcap_file"].endswith("one.pcapng")
    assert records[1]["pcap_file"].endswith("two.pcapng")
