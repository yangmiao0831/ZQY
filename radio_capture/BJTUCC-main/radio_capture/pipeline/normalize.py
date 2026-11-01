"""Fixture-backed normalization of decoded records into metrics."""

from __future__ import annotations

from radio_capture.models import DecodedRecord


def normalize_record(record: DecodedRecord) -> dict | None:
    """Return normalized metrics only after fixture-backed rules are added."""

    return record.normalized

