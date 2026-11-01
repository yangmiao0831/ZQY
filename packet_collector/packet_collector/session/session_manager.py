"""Session directory and metadata management.

Sessions are long-running capture containers used to keep multiple pcapng
rotation files, per-file JSONL outputs, and a merged packets.jsonl together.
They are preparation for future flow-level replay, but do not implement replay.
"""

from __future__ import annotations

import json
import shutil
from datetime import datetime
from pathlib import Path


def create_session_id() -> str:
    """Create a session ID in the form `session_YYYYMMDD_HHMMSS_microseconds`."""
    return f"session_{datetime.now().strftime('%Y%m%d_%H%M%S_%f')}"


def create_session_dir(base_dir: Path, session_id: str) -> Path:
    """Create a session directory with pcaps and packets subdirectories."""
    session_dir = base_dir / session_id
    (session_dir / "pcaps").mkdir(parents=True, exist_ok=True)
    (session_dir / "packets").mkdir(parents=True, exist_ok=True)
    return session_dir


def write_session_meta(session_dir: Path, meta: dict[str, object]) -> Path:
    """Write session metadata as JSON."""
    meta_path = session_dir / "session_meta.json"
    meta_path.write_text(json.dumps(meta, indent=2), encoding="utf-8")
    return meta_path


def load_session_meta(session_dir: Path) -> dict[str, object]:
    """Load metadata from `session_meta.json`."""
    meta_path = session_dir / "session_meta.json"
    return json.loads(meta_path.read_text(encoding="utf-8"))


def update_session_meta(session_dir: Path, updates: dict[str, object]) -> Path:
    """Merge updates into `session_meta.json` and write it back."""
    meta_path = session_dir / "session_meta.json"
    if meta_path.exists():
        meta = json.loads(meta_path.read_text(encoding="utf-8"))
    else:
        meta = {}
    meta.update(updates)
    meta_path.write_text(json.dumps(meta, indent=2), encoding="utf-8")
    return meta_path


def renumber_pcap_files(source_files: list[Path], pcaps_dir: Path) -> list[Path]:
    """Copy pcapng files into pcaps_dir as 000001.pcapng, 000002.pcapng, etc."""
    pcaps_dir.mkdir(parents=True, exist_ok=True)
    copied: list[Path] = []
    for index, source in enumerate(sorted(source_files), start=1):
        destination = pcaps_dir / f"{index:06d}.pcapng"
        shutil.copy2(source, destination)
        copied.append(destination)
    return copied
