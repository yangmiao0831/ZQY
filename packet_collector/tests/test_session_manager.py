"""Tests for session directory and metadata management."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.session.session_manager import (
    create_session_dir,
    create_session_id,
    load_session_meta,
    renumber_pcap_files,
    update_session_meta,
    write_session_meta,
)


def test_create_session_id_prefix() -> None:
    """Session IDs use the expected prefix."""
    assert create_session_id().startswith("session_")


def test_create_session_dir_creates_subdirs(tmp_path: Path) -> None:
    """Session directories include pcaps and packets subdirectories."""
    session_dir = create_session_dir(tmp_path, "session_20260101_010203_123456")
    assert session_dir.exists()
    assert (session_dir / "pcaps").is_dir()
    assert (session_dir / "packets").is_dir()


def test_session_meta_write_load_update(tmp_path: Path) -> None:
    """Session metadata can be written, loaded, and updated."""
    session_dir = create_session_dir(tmp_path, "session_20260101_010203_123456")
    write_session_meta(session_dir, {"session_id": "abc", "status": "planned"})
    assert load_session_meta(session_dir)["status"] == "planned"

    update_session_meta(session_dir, {"status": "captured"})
    metadata = json.loads((session_dir / "session_meta.json").read_text(encoding="utf-8"))
    assert metadata["session_id"] == "abc"
    assert metadata["status"] == "captured"


def test_renumber_pcap_files(tmp_path: Path) -> None:
    """Source pcapng files are copied into sequential numbered files."""
    source_a = tmp_path / "b_source.pcapng"
    source_b = tmp_path / "a_source.pcapng"
    source_a.write_text("b", encoding="utf-8")
    source_b.write_text("a", encoding="utf-8")

    copied = renumber_pcap_files([source_a, source_b], tmp_path / "pcaps")

    assert [path.name for path in copied] == ["000001.pcapng", "000002.pcapng"]
    assert copied[0].read_text(encoding="utf-8") == "a"
    assert source_a.exists()
    assert source_b.exists()
