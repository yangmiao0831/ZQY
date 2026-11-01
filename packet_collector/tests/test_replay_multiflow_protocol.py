"""Tests for TCP multi-flow replay protocol helpers."""

from __future__ import annotations

import pytest

from packet_collector.replay.replay_protocol import (
    assign_flow_ports,
    select_tcp_flows,
    summarize_flow_results,
)


def _trace() -> dict[str, object]:
    """Build a small multi-flow trace fixture."""
    return {
        "flows": [
            {
                "flow_id": "tcp_download_big",
                "protocol": "tcp",
                "role": "download",
                "bytes_pi_to_peer": 100,
                "bytes_peer_to_pi": 2000,
                "events": [],
            },
            {
                "flow_id": "tcp_upload",
                "protocol": "tcp",
                "role": "upload",
                "bytes_pi_to_peer": 1500,
                "bytes_peer_to_pi": 100,
                "events": [],
            },
            {
                "flow_id": "tcp_download_small",
                "protocol": "tcp",
                "role": "download",
                "bytes_pi_to_peer": 50,
                "bytes_peer_to_pi": 500,
                "events": [],
            },
            {
                "flow_id": "udp_ignored",
                "protocol": "udp",
                "role": "download",
                "bytes_pi_to_peer": 1,
                "bytes_peer_to_pi": 99999,
                "events": [],
            },
        ]
    }


def test_select_tcp_flows_defaults_to_all_tcp_sorted_by_bytes() -> None:
    """Default multi-flow selection returns all TCP flows by byte volume."""
    flows = select_tcp_flows(_trace())
    assert [flow["flow_id"] for flow in flows] == ["tcp_download_big", "tcp_upload", "tcp_download_small"]


def test_select_tcp_flows_filters_by_role() -> None:
    """Role filtering keeps only matching TCP flows."""
    flows = select_tcp_flows(_trace(), role="download")
    assert [flow["flow_id"] for flow in flows] == ["tcp_download_big", "tcp_download_small"]


def test_select_tcp_flows_max_flows_takes_largest() -> None:
    """max_flows limits selection after byte-volume sorting."""
    flows = select_tcp_flows(_trace(), max_flows=2)
    assert [flow["flow_id"] for flow in flows] == ["tcp_download_big", "tcp_upload"]


def test_select_tcp_flows_by_flow_id_returns_single_flow() -> None:
    """Explicit flow_id selection returns one exact flow."""
    flows = select_tcp_flows(_trace(), flow_id="tcp_upload", max_flows=3)
    assert len(flows) == 1
    assert flows[0]["flow_id"] == "tcp_upload"


def test_select_tcp_flows_invalid_max_flows_raises() -> None:
    """Non-positive max_flows values are rejected."""
    with pytest.raises(ValueError):
        select_tcp_flows(_trace(), max_flows=0)


def test_assign_flow_ports_increments_from_base_port() -> None:
    """Ports are assigned in flow order."""
    flows = select_tcp_flows(_trace(), max_flows=2)
    assert assign_flow_ports(flows, 9000) == {
        "tcp_download_big": 9000,
        "tcp_upload": 9001,
    }


def test_summarize_flow_results_aggregates_per_flow_stats() -> None:
    """Per-flow results are summarized into a stable multi-flow summary."""
    summary = summarize_flow_results(
        [
            {
                "success": True,
                "event_count": 2,
                "late_event_count": 1,
                "max_lag_ms": 5.0,
                "avg_lag_ms": 2.0,
                "bytes_sent": 100,
                "bytes_received": 50,
                "short_read_count": 0,
                "error": None,
            },
            {
                "success": False,
                "event_count": 1,
                "late_event_count": 1,
                "max_lag_ms": 10.0,
                "avg_lag_ms": 10.0,
                "bytes_sent": 0,
                "bytes_received": 20,
                "short_read_count": 1,
                "error": "mock failure",
            },
        ]
    )
    assert summary["flow_count"] == 2
    assert summary["success_flow_count"] == 1
    assert summary["failed_flow_count"] == 1
    assert summary["event_count"] == 3
    assert summary["late_event_count"] == 2
    assert summary["max_lag_ms"] == 10.0
    assert summary["bytes_sent"] == 100
    assert summary["bytes_received"] == 70
    assert summary["short_read_count"] == 1
    assert summary["errors"] == ["mock failure"]
