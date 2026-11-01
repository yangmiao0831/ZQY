"""Tests for tshark command construction."""

from __future__ import annotations

from pathlib import Path

from packet_collector.parsers.tshark_runner import build_tshark_fields_command


FIELDS = [
    ("time_epoch", "frame.time_epoch"),
    ("src_ip", "ip.src"),
    ("dst_ip", "ip.dst"),
]


def test_build_tshark_fields_command_basic() -> None:
    """Build tshark fields command without executing tshark."""
    command = build_tshark_fields_command(Path("input.pcapng"), FIELDS)
    assert command[:3] == ["tshark", "-r", "input.pcapng"]
    assert ["-T", "fields"] == command[3:5]
    assert "-Y" not in command


def test_build_tshark_fields_command_with_display_filter() -> None:
    """Display filter is included when provided."""
    command = build_tshark_fields_command(Path("input.pcapng"), FIELDS, "tcp")
    assert command[:5] == ["tshark", "-r", "input.pcapng", "-Y", "tcp"]


def test_build_tshark_fields_command_field_count() -> None:
    """Each requested field adds one -e argument."""
    command = build_tshark_fields_command(Path("input.pcapng"), FIELDS, "tcp")
    assert command.count("-e") == len(FIELDS)
