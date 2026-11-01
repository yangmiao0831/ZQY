"""Tests for UDP replay protocol helpers."""

from __future__ import annotations

from packet_collector.replay.replay_protocol import select_flows, split_udp_datagrams


def _trace() -> dict[str, object]:
    """Build a replay trace with TCP and UDP flows."""
    return {
        "flows": [
            {
                "flow_id": "tcp_big",
                "protocol": "tcp",
                "role": "download",
                "bytes_pi_to_peer": 10,
                "bytes_peer_to_pi": 1000,
                "events": [],
            },
            {
                "flow_id": "udp_big",
                "protocol": "udp",
                "role": "download",
                "bytes_pi_to_peer": 100,
                "bytes_peer_to_pi": 2000,
                "events": [],
            },
            {
                "flow_id": "udp_upload",
                "protocol": "udp",
                "role": "upload",
                "bytes_pi_to_peer": 1500,
                "bytes_peer_to_pi": 100,
                "events": [],
            },
            {
                "flow_id": "udp_small",
                "protocol": "udp",
                "role": "download",
                "bytes_pi_to_peer": 10,
                "bytes_peer_to_pi": 100,
                "events": [],
            },
        ]
    }


def test_select_flows_udp_only() -> None:
    """UDP selection ignores TCP flows."""
    flows = select_flows(_trace(), protocol="udp", max_flows=None)
    assert [flow["flow_id"] for flow in flows] == ["udp_big", "udp_upload", "udp_small"]


def test_select_flows_tcp_still_works() -> None:
    """TCP selection remains available through the generic selector."""
    flows = select_flows(_trace(), protocol="tcp", max_flows=None)
    assert [flow["flow_id"] for flow in flows] == ["tcp_big"]


def test_select_flows_udp_role_filter() -> None:
    """Role filtering works for UDP flows."""
    flows = select_flows(_trace(), protocol="udp", role="download", max_flows=None)
    assert [flow["flow_id"] for flow in flows] == ["udp_big", "udp_small"]


def test_select_flows_udp_max_flows_takes_largest() -> None:
    """max_flows limits UDP selection after byte sorting."""
    flows = select_flows(_trace(), protocol="udp", max_flows=2)
    assert [flow["flow_id"] for flow in flows] == ["udp_big", "udp_upload"]


def test_split_udp_datagrams() -> None:
    """UDP byte chunks stay under max_datagram_size."""
    assert split_udp_datagrams(2500, 1200) == [1200, 1200, 100]
    assert split_udp_datagrams(0, 1200) == []
