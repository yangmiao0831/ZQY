"""JSON storage writer."""

from __future__ import annotations

import json
from pathlib import Path


def write_json(path: Path, data: dict[str, object] | list[object]) -> Path:
    """Write JSON data using UTF-8 and stable formatting."""
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(json.dumps(data, ensure_ascii=False, indent=2), encoding="utf-8")
    return path
