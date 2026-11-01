"""Tests for task manager helpers."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.task_manager import create_task_dir, create_task_id, write_task_meta


TEST_TMP_DIR = Path("tmp") / "tests"


def test_create_task_id_starts_with_task() -> None:
    """Task IDs start with the required prefix."""
    assert create_task_id().startswith("task_")


def test_create_task_dir() -> None:
    """Task directories are created."""
    task_dir = create_task_dir(TEST_TMP_DIR, "task_20260101_010203")
    assert task_dir.exists()
    assert task_dir.is_dir()


def test_write_task_meta() -> None:
    """Task metadata is written as JSON and can be read back."""
    task_dir = create_task_dir(TEST_TMP_DIR, "task_20260101_010203")
    meta_path = write_task_meta(task_dir, {"packet_type": "tcp", "iface": "wlan0"})
    assert meta_path.name == "task_meta.json"
    assert json.loads(meta_path.read_text(encoding="utf-8")) == {
        "packet_type": "tcp",
        "iface": "wlan0",
    }
