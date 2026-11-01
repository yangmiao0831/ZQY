"""Fixture tests for decoder calls and output handling."""

from radio_capture.models import DecodedRecord
from radio_capture.pipeline.normalize import normalize_record


def test_normalize_keeps_none_until_fixture_rules_exist():
    record = DecodedRecord("s", 1, None, None, 0)
    assert normalize_record(record) is None

