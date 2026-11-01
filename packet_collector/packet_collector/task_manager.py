"""Task directory and metadata management.

This module owns task ID creation, task directory creation, writing
`task_meta.json`, and updating task metadata as capture state changes.
"""

from __future__ import annotations

import json
from datetime import datetime
from pathlib import Path


def create_task_id() -> str:
    """Create a task ID in the form `task_YYYYMMDD_HHMMSS_microseconds`."""
    return f"task_{datetime.now().strftime('%Y%m%d_%H%M%S_%f')}"


def create_task_dir(base_dir: Path, task_id: str) -> Path:
    """Create and return a task directory."""
    task_dir = base_dir / task_id
    task_dir.mkdir(parents=True, exist_ok=True)
    return task_dir


def write_task_meta(task_dir: Path, metadata: dict[str, object]) -> Path:
    """Write task metadata as JSON."""
    meta_path = task_dir / "task_meta.json"
    meta_path.write_text(json.dumps(metadata, indent=2), encoding="utf-8")
    return meta_path


def find_task_meta(task_dir: Path) -> Path:
    """Return the expected task metadata path."""
    return task_dir / "task_meta.json"


def load_task_meta(task_dir: Path) -> dict[str, object]:
    """Load task metadata from `task_meta.json`."""
    meta_path = find_task_meta(task_dir)
    return json.loads(meta_path.read_text(encoding="utf-8"))


def update_task_meta(task_dir: Path, updates: dict[str, object]) -> Path:
    """Merge updates into `task_meta.json` and write it back."""
    meta_path = find_task_meta(task_dir)
    if meta_path.exists():
        metadata = json.loads(meta_path.read_text(encoding="utf-8"))
    else:
        metadata = {}
    metadata.update(updates)
    meta_path.write_text(json.dumps(metadata, indent=2), encoding="utf-8")
    return meta_path
