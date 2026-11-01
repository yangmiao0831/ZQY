"""Tests for mobile-friendly capture modes."""

from __future__ import annotations

import json
from pathlib import Path

import packet_collector.cli as cli
from packet_collector.capture.capture import run_capture_task
from packet_collector.capture.dumpcap_runner import build_dumpcap_command
from packet_collector.capture.filters import build_capture_filter
from packet_collector.session.session_capture import run_capture_session


def test_iface_only_filters_all_or_port() -> None:
    """Iface-only all capture has no host filter and can restrict a port."""
    assert build_capture_filter("all", None, None, capture_mode="iface_only") == ""
    assert build_capture_filter("all", None, None, port=8085, capture_mode="iface_only") == "port 8085"


def test_peer_only_filters_peer_or_peer_port() -> None:
    """Peer-only capture does not depend on a local Pi IP."""
    assert build_capture_filter("all", None, "47.93.192.193", capture_mode="peer_only") == "host 47.93.192.193"
    assert (
        build_capture_filter("all", None, "47.93.192.193", port=8085, capture_mode="peer_only")
        == "host 47.93.192.193 and port 8085"
    )


def test_two_host_filter_is_unchanged() -> None:
    """Legacy two-host capture keeps its original BPF behavior."""
    assert (
        build_capture_filter("all", "10.233.139.93", "47.93.192.193", direction="both")
        == "host 10.233.139.93 and host 47.93.192.193"
    )


def test_empty_filter_is_omitted_from_dumpcap_command() -> None:
    """Dumpcap receives no -f option for interface-wide capture."""
    command = build_dumpcap_command("wwan0", "", Path("capture.pcapng"), 51200, 20)
    assert "-f" not in command
    assert command[0:3] == ["dumpcap", "-i", "wwan0"]


def test_capture_cli_parses_all_three_modes() -> None:
    """CLI accepts iface-only, peer-only, and legacy positional IPs."""
    parser = cli.build_parser()
    iface_args = parser.parse_args(["capture", "all", "--iface", "wwan0", "--iface-only"])
    peer_args = parser.parse_args(["capture", "all", "--iface", "wwan0", "--peer-only", "47.93.192.193"])
    two_host_args = parser.parse_args(["capture", "all", "10.0.0.1", "10.0.0.2"])
    assert cli._resolve_capture_mode(iface_args) == ("iface_only", None, None)
    assert cli._resolve_capture_mode(peer_args) == ("peer_only", None, "47.93.192.193")
    assert cli._resolve_capture_mode(two_host_args) == ("two_host", "10.0.0.1", "10.0.0.2")


def test_capture_session_cli_parses_mobile_options() -> None:
    """Session CLI accepts peer-only and network event options."""
    args = cli.build_parser().parse_args(
        [
            "capture-session",
            "all",
            "--iface",
            "wwan0",
            "--peer-only",
            "47.93.192.193",
            "--network-events",
            "--network-events-interval",
            "5",
        ]
    )
    assert cli._resolve_capture_mode(args) == ("peer_only", None, "47.93.192.193")
    assert args.network_events is True
    assert args.network_events_interval == 5.0


def test_capture_task_meta_records_iface_only(tmp_path: Path) -> None:
    """Task metadata records interface-only mode and nullable hosts."""
    task = run_capture_task(
        packet_type="all",
        pi_ip=None,
        peer_ip=None,
        direction="both",
        iface="wwan0",
        final_base_dir=tmp_path / "captures",
        tmp_capture_dir=tmp_path / "tmp",
        file_size_kb=51200,
        max_files=20,
        execute=False,
        capture_mode="iface_only",
    )
    metadata = json.loads((task.task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["capture_mode"] == "iface_only"
    assert metadata["pi_ip"] is None
    assert metadata["peer_ip"] is None
    assert metadata["capture_filter"] == ""


def test_capture_session_meta_records_peer_only(tmp_path: Path) -> None:
    """Session metadata records peer-only mode and network event settings."""
    session_dir = run_capture_session(
        packet_type="all",
        pi_ip=None,
        peer_ip="47.93.192.193",
        direction="both",
        iface="wwan0",
        final_base_dir=tmp_path / "captures",
        tmp_capture_dir=tmp_path / "tmp",
        file_size_kb=51200,
        max_files=200,
        execute=False,
        capture_mode="peer_only",
        network_events=True,
        network_events_interval=5.0,
    )
    metadata = json.loads((session_dir / "session_meta.json").read_text(encoding="utf-8"))
    assert metadata["capture_mode"] == "peer_only"
    assert metadata["pi_ip"] is None
    assert metadata["peer_ip"] == "47.93.192.193"
    assert metadata["capture_filter"] == "host 47.93.192.193"
    assert metadata["network_events_enabled"] is True
    assert metadata["network_events_file"].endswith("network_events.jsonl")
