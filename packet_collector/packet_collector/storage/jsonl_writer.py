"""JSONL storage writer.

JSONL output is one JSON object per line, which keeps packet parsing friendly
to Raspberry Pi memory limits and avoids storing large JSON arrays.
"""

from __future__ import annotations

import json
from collections.abc import Iterable
from pathlib import Path


def append_jsonl_record(path: Path, record: dict[str, object]) -> Path:
    """Append one JSONL record."""
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("a", encoding="utf-8") as file:
        file.write(json.dumps(record, ensure_ascii=False) + "\n")
    return path


def write_jsonl_records(path: Path, records: Iterable[dict[str, object]]) -> Path:
    """Write JSONL records from an iterable."""
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("w", encoding="utf-8") as file:
        for record in records:
            file.write(json.dumps(record, ensure_ascii=False) + "\n")
    return path


def write_jsonl(path: Path, records: list[dict[str, object]]) -> Path:
    """Backward-compatible wrapper for writing JSONL records."""
    return write_jsonl_records(path, records)
