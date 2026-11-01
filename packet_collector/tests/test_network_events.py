"""Tests for non-blocking session network event recording."""

from __future__ import annotations

import json
import threading
from pathlib import Path

from packet_collector.collectors.network_events import record_network_events


def _read_jsonl(path: Path) -> list[dict[str, object]]:
    """Read a small test JSONL file."""
    return [json.loads(line) for line in path.read_text(encoding="utf-8").splitlines() if line]


def test_network_events_records_snapshot_and_changes(tmp_path: Path) -> None:
    """IPv4 and interface transitions emit dedicated events."""
    stop_event = threading.Event()
    snapshots = [
        {"time_epoch": 1.0, "time_iso": "one", "iface": "wwan0", "ipv4": "10.1.1.1", "ipv6": None, "is_up": True, "event": "snapshot", "warning": None},
        {"time_epoch": 2.0, "time_iso": "two", "iface": "wwan0", "ipv4": "10.2.2.2", "ipv6": None, "is_up": False, "event": "snapshot", "warning": None},
    ]

    def provider(iface: str) -> dict[str, object]:
        snapshot = snapshots.pop(0)
        if not snapshots:
            stop_event.set()
        return snapshot

    output = tmp_path / "network_events.jsonl"
    record_network_events("wwan0", output, 0.001, stop_event, snapshot_provider=provider)
    records = _read_jsonl(output)
    assert [record["event"] for record in records].count("snapshot") == 2
    changed = next(record for record in records if record["event"] == "ip_changed")
    assert changed["old_ipv4"] == "10.1.1.1"
    assert changed["new_ipv4"] == "10.2.2.2"
    assert any(record["event"] == "iface_down" for record in records)


def test_network_events_failure_becomes_warning(tmp_path: Path) -> None:
    """Snapshot failures are written and do not escape the recorder."""
    stop_event = threading.Event()

    def provider(iface: str) -> dict[str, object]:
        stop_event.set()
        raise RuntimeError("mock address read failed")

    output = tmp_path / "network_events.jsonl"
    record_network_events("wwan0", output, 0.001, stop_event, snapshot_provider=provider)
    records = _read_jsonl(output)
    assert records[0]["event"] == "warning"
    assert "mock address read failed" in str(records[0]["warning"])
