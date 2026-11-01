"""Tests for session parsing and JSONL merge workflow."""

from __future__ import annotations

from pathlib import Path

import pytest

from packet_collector.session import session_parser
from packet_collector.session.session_manager import create_session_dir, load_session_meta, write_session_meta


def _make_session(tmp_path: Path) -> Path:
    """Create a minimal session with two fake pcapng files."""
    session_dir = create_session_dir(tmp_path, "session_20260101_010203_123456")
    write_session_meta(
        session_dir,
        {
            "session_id": "session_20260101_010203_123456",
            "packet_type": "all",
            "pcaps_dir": str(session_dir / "pcaps"),
            "packets_dir": str(session_dir / "packets"),
            "merged_packets_jsonl": str(session_dir / "packets.jsonl"),
            "pcap_files": [str(session_dir / "pcaps" / "000001.pcapng"), str(session_dir / "pcaps" / "000002.pcapng")],
            "parse_status": "not_started",
        },
    )
    (session_dir / "pcaps" / "000001.pcapng").write_text("pcap1", encoding="utf-8")
    (session_dir / "pcaps" / "000002.pcapng").write_text("pcap2", encoding="utf-8")
    return session_dir


def test_merge_jsonl_files(tmp_path: Path) -> None:
    """JSONL files are merged line by line and empty lines are skipped."""
    one = tmp_path / "one.jsonl"
    two = tmp_path / "two.jsonl"
    one.write_text('{"a": 1}\n\n', encoding="utf-8")
    two.write_text('{"b": 2}', encoding="utf-8")

    output = session_parser.merge_jsonl_files([one, two], tmp_path / "packets.jsonl")

    assert output.read_text(encoding="utf-8") == '{"a": 1}\n{"b": 2}\n'


def test_parse_session_creates_per_pcap_and_merged_jsonl(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """Session parsing creates per-pcap JSONL files and a merged packets.jsonl."""
    session_dir = _make_session(tmp_path)

    def fake_parse_pcap_to_jsonl(pcap_file: Path, output_file: Path, packet_type: str) -> Path:
        output_file.write_text(f'{{"pcap": "{pcap_file.name}", "packet_type": "{packet_type}"}}\n', encoding="utf-8")
        return output_file

    monkeypatch.setattr(session_parser, "parse_pcap_to_jsonl", fake_parse_pcap_to_jsonl)

    output = session_parser.parse_session(session_dir, "all")

    assert (session_dir / "packets" / "000001.jsonl").exists()
    assert (session_dir / "packets" / "000002.jsonl").exists()
    assert output == session_dir / "packets.jsonl"
    assert len(output.read_text(encoding="utf-8").splitlines()) == 2
    metadata = load_session_meta(session_dir)
    assert metadata["parse_status"] == "completed"
    assert len(metadata["packet_jsonl_files"]) == 2


def test_parse_session_skips_existing_jsonl_without_force(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """Existing per-pcap JSONL files are reused when force is false."""
    session_dir = _make_session(tmp_path)
    existing = session_dir / "packets" / "000001.jsonl"
    existing.write_text('{"existing": true}\n', encoding="utf-8")
    calls: list[str] = []

    def fake_parse_pcap_to_jsonl(pcap_file: Path, output_file: Path, packet_type: str) -> Path:
        calls.append(pcap_file.name)
        output_file.write_text(f'{{"generated": "{pcap_file.name}"}}\n', encoding="utf-8")
        return output_file

    monkeypatch.setattr(session_parser, "parse_pcap_to_jsonl", fake_parse_pcap_to_jsonl)

    session_parser.parse_session(session_dir, "all", force=False)

    assert calls == ["000002.pcapng"]
    assert '{"existing": true}' in (session_dir / "packets.jsonl").read_text(encoding="utf-8")


def test_parse_session_failure_updates_meta(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """A parse failure is recorded in session metadata."""
    session_dir = _make_session(tmp_path)

    def fake_parse_pcap_to_jsonl(pcap_file: Path, output_file: Path, packet_type: str) -> Path:
        raise RuntimeError("mock parse failed")

    monkeypatch.setattr(session_parser, "parse_pcap_to_jsonl", fake_parse_pcap_to_jsonl)

    with pytest.raises(RuntimeError):
        session_parser.parse_session(session_dir, "all")

    metadata = load_session_meta(session_dir)
    assert metadata["parse_status"] == "failed"
    assert "mock parse failed" in metadata["parse_error"]
