"""Tests for TCP replay protocol helpers."""

from __future__ import annotations

import json
from pathlib import Path

import pytest

from packet_collector.replay.replay_protocol import (
    compute_event_lag_ms,
    load_replay_trace,
    make_dummy_payload,
    normalize_flow_events,
    select_tcp_flow,
    summarize_replay_events,
)


def _trace() -> dict[str, object]:
    """Build a small replay trace fixture."""
    return {
        "flows": [
            {"flow_id": "udp_1", "protocol": "udp", "role": "download", "bytes_pi_to_peer": 1, "bytes_peer_to_pi": 999, "events": []},
            {
                "flow_id": "tcp_small",
                "protocol": "tcp",
                "role": "upload",
                "bytes_pi_to_peer": 100,
                "bytes_peer_to_pi": 10,
                "events": [],
            },
            {
                "flow_id": "tcp_big",
                "protocol": "tcp",
                "role": "download",
                "bytes_pi_to_peer": 50,
                "bytes_peer_to_pi": 1000,
                "events": [
                    {"time_offset_sec": 0.2, "direction": "peer_to_pi", "bytes": 20, "packet_count": 1, "original_protocol": "tcp"},
                    {"time_offset_sec": 0.1, "direction": "pi_to_peer", "bytes": 10, "packet_count": 1, "original_protocol": "tcp"},
                    {"time_offset_sec": 0.0, "direction": "peer_to_pi", "bytes": 1, "packet_count": 1, "original_protocol": "udp"},
                ],
            },
        ]
    }


def test_load_replay_trace(tmp_path: Path) -> None:
    """Replay trace JSON can be loaded from disk."""
    trace_file = tmp_path / "replay_trace.json"
    trace_file.write_text(json.dumps(_trace()), encoding="utf-8")
    assert load_replay_trace(trace_file)["flows"]


def test_select_tcp_flow_defaults_to_largest_tcp_flow() -> None:
    """Default selection chooses the TCP flow with most bytes."""
    assert select_tcp_flow(_trace())["flow_id"] == "tcp_big"


def test_select_tcp_flow_by_flow_id() -> None:
    """Flow ID selection is supported."""
    assert select_tcp_flow(_trace(), flow_id="tcp_small")["flow_id"] == "tcp_small"


def test_select_tcp_flow_by_role() -> None:
    """Role selection is supported."""
    assert select_tcp_flow(_trace(), role="upload")["flow_id"] == "tcp_small"


def test_select_tcp_flow_without_tcp_raises() -> None:
    """A trace without TCP flows is rejected."""
    with pytest.raises(ValueError):
        select_tcp_flow({"flows": [{"flow_id": "udp", "protocol": "udp"}]})


def test_normalize_flow_events_filters_and_sorts_tcp_events() -> None:
    """Only TCP events are returned in time order."""
    events = normalize_flow_events(select_tcp_flow(_trace(), flow_id="tcp_big"))
    assert [event["time_offset_sec"] for event in events] == [0.1, 0.2]


def test_make_dummy_payload() -> None:
    """Dummy payload uses the requested length."""
    assert make_dummy_payload(0) == b""
    assert make_dummy_payload(3) == b"XXX"


def test_compute_event_lag_ms() -> None:
    """Lag is positive lateness only."""
    assert compute_event_lag_ms(10.0, 9.0) == 0.0
    assert compute_event_lag_ms(10.0, 10.25) == 250.0


def test_summarize_replay_events() -> None:
    """Replay event summaries include bytes and lag stats."""
    summary = summarize_replay_events(
        [
            {"bytes_sent": 10, "bytes_received": 0, "lag_ms": 0.0, "short_read": False},
            {"bytes_sent": 0, "bytes_received": 20, "lag_ms": 5.0, "short_read": True},
        ]
    )
    assert summary["event_count"] == 2
    assert summary["late_event_count"] == 1
    assert summary["max_lag_ms"] == 5.0
    assert summary["bytes_sent"] == 10
    assert summary["bytes_received"] == 20
    assert summary["short_read_count"] == 1
