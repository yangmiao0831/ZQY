"""Shared helpers for JSONL analyzers.

The helpers stream JSONL records line by line and never call dumpcap or tshark.
They are intentionally small so transport and application summaries can share
parsing, counting, timing, and throughput behavior.
"""

from __future__ import annotations

import json
from collections import Counter
from collections.abc import Iterator
from pathlib import Path
from typing import Any


def iter_jsonl_records(path: Path) -> Iterator[tuple[dict[str, Any] | None, bool]]:
    """Yield parsed JSONL records and whether the line was invalid."""
    with path.open("r", encoding="utf-8") as file:
        for line in file:
            stripped = line.strip()
            if not stripped:
                continue
            try:
                record = json.loads(stripped)
            except json.JSONDecodeError:
                yield None, True
                continue
            if isinstance(record, dict):
                yield record, False
            else:
                yield None, True


def as_float(value: Any) -> float | None:
    """Convert a value to float when possible."""
    if value is None or value == "":
        return None
    try:
        return float(value)
    except (TypeError, ValueError):
        return None


def as_int(value: Any) -> int:
    """Convert a value to int when possible, otherwise return zero."""
    if value is None or value == "":
        return 0
    try:
        return int(float(value))
    except (TypeError, ValueError):
        return 0


def count_value(counter: Counter[str], value: Any) -> None:
    """Count a non-empty value with a string key."""
    if value is None or value == "":
        return
    counter[str(value)] += 1


def counter_dict(counter: Counter[str]) -> dict[str, int]:
    """Return a plain JSON-serializable counter dictionary."""
    return dict(sorted(counter.items()))


def duration(first_time: float | None, last_time: float | None) -> float | None:
    """Compute duration from first and last timestamps."""
    if first_time is None or last_time is None:
        return None
    return last_time - first_time


def throughput_bps(total_bytes: int, duration_sec: float | None) -> float | None:
    """Compute bits per second when duration is positive."""
    if duration_sec is None or duration_sec <= 0:
        return None
    return total_bytes * 8 / duration_sec


def non_empty(value: Any) -> bool:
    """Return True if a JSONL field is present and non-empty."""
    return value is not None and value != ""


def any_field_non_empty(record: dict[str, Any], fields: list[str]) -> bool:
    """Return True when any named field is present and non-empty."""
    return any(non_empty(record.get(field)) for field in fields)


def protocol_seen(record: dict[str, Any], protocol: str) -> bool:
    """Return True when frame.protocols contains a protocol name."""
    protocols = record.get("protocols")
    if not isinstance(protocols, str):
        return False
    return protocol.lower() in {part.lower() for part in protocols.split(":")}


def avg_min_max(values: list[float]) -> tuple[int, float | None, float | None, float | None]:
    """Return count, average, minimum, and maximum for numeric values."""
    if not values:
        return 0, None, None, None
    return len(values), sum(values) / len(values), min(values), max(values)
