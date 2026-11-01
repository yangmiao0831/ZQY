"""Tests for session CLI helpers."""

from __future__ import annotations

import argparse
from pathlib import Path

import pytest

import packet_collector.cli as cli
from packet_collector.session.session_manager import create_session_dir, load_session_meta, update_session_meta, write_session_meta


def test_cli_capture_session_dry_run_creates_session(tmp_path: Path) -> None:
    """capture-session dry-run creates a session directory and metadata."""
    args = argparse.Namespace(
        packet_type="all",
        pi_ip="192.168.1.10",
        peer_ip="192.168.1.20",
        direction="both",
        port=None,
        iface="wlan0",
        duration=60,
        file_size_kb=51200,
        max_files=200,
        dry_run=True,
        tmp_capture_dir=str(tmp_path / "tmp"),
        final_capture_dir=str(tmp_path / "captures"),
    )

    cli._run_capture_session_command(args)

    sessions = list((tmp_path / "captures").glob("session_*"))
    assert len(sessions) == 1
    metadata = load_session_meta(sessions[0])
    assert metadata["status"] == "planned"
    assert metadata["parse_status"] == "not_started"
    assert metadata["capture_filter"] == "host 192.168.1.10 and host 192.168.1.20"


def test_cli_parse_session_uses_session_meta_packet_type(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """parse-session can read packet_type from session metadata."""
    session_dir = create_session_dir(tmp_path, "session_20260101_010203_123456")
    write_session_meta(
        session_dir,
        {
            "session_id": "session_20260101_010203_123456",
            "packet_type": "all",
            "pcap_files": ["one.pcapng"],
            "packet_jsonl_files": [],
            "parse_status": "not_started",
        },
    )
    calls: dict[str, object] = {}

    def fake_parse_session(target_session_dir: Path, packet_type: str, force: bool = False) -> Path:
        calls["session_dir"] = target_session_dir
        calls["packet_type"] = packet_type
        calls["force"] = force
        update_session_meta(
            target_session_dir,
            {
                "parse_status": "completed",
                "packet_jsonl_files": [str(target_session_dir / "packets" / "000001.jsonl")],
                "merged_packets_jsonl": str(target_session_dir / "packets.jsonl"),
            },
        )
        return target_session_dir / "packets.jsonl"

    monkeypatch.setattr(cli, "parse_session", fake_parse_session)
    args = argparse.Namespace(session_dir=str(session_dir), packet_type=None, force=False)

    cli._run_parse_session_command(args)

    assert calls == {"session_dir": session_dir, "packet_type": "all", "force": False}
    assert load_session_meta(session_dir)["parse_status"] == "completed"
