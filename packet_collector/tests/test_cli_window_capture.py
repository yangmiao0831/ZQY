"""CLI tests for continuous TCP window capture configuration."""

from __future__ import annotations

from pathlib import Path

import pytest

import packet_collector.cli as cli
from packet_collector.session.session_capture import run_capture_session
from packet_collector.session.session_manager import load_session_meta


def test_capture_session_online_analysis_dry_run(tmp_path: Path) -> None:
    """Dry-run records rotation and online-analysis settings without dumpcap."""
    args = cli.build_parser().parse_args(
        [
            "capture-session",
            "tcp",
            "192.168.1.10",
            "192.168.1.20",
            "--direction",
            "both",
            "--window-mode",
            "online-analysis",
            "--window-seconds",
            "1",
            "--window-retention",
            "100",
            "--tmp-capture-dir",
            str(tmp_path / "tmp"),
            "--final-capture-dir",
            str(tmp_path / "captures"),
            "--dry-run",
        ]
    )
    cli._run_capture_session_command(args)

    session_dir = next((tmp_path / "captures").glob("session_*"))
    meta = load_session_meta(session_dir)
    assert meta["window_mode"] == "online-analysis"
    assert meta["window_retention"] == 100
    assert "duration:1" in meta["dumpcap_command"]
    assert (session_dir / "window_pcaps").is_dir()


def test_capture_session_with_gps_dry_run_records_csv_settings(tmp_path: Path) -> None:
    """GPS CSV settings are recorded without opening a real serial port."""
    args = cli.build_parser().parse_args(
        [
            "capture-session",
            "tcp",
            "--iface-only",
            "--window-mode",
            "online-analysis",
            "--with-gps",
            "--gps-port",
            "/dev/ttyUSB1",
            "--gps-baudrate",
            "115200",
            "--tmp-capture-dir",
            str(tmp_path / "tmp"),
            "--final-capture-dir",
            str(tmp_path / "captures"),
            "--dry-run",
        ]
    )
    cli._run_capture_session_command(args)

    session_dir = next((tmp_path / "captures").glob("session_*"))
    meta = load_session_meta(session_dir)
    assert meta["gps_enabled"] is True
    assert meta["gps_port"] == "/dev/ttyUSB1"
    assert meta["gps_baudrate"] == 115200
    assert meta["window_metrics_csv_file"].endswith("window_metrics_gps.csv")


def test_capture_session_display_export_dry_run_records_settings(tmp_path: Path) -> None:
    """Display export keeps full and one-minute destinations in session metadata."""
    display_dir = tmp_path / "display" / "datas"
    args = cli.build_parser().parse_args(
        [
            "capture-session",
            "tcp",
            "--iface-only",
            "--window-mode",
            "online-analysis",
            "--with-gps",
            "--display-data-dir",
            str(display_dir),
            "--display-source",
            "BJTU",
            "--tmp-capture-dir",
            str(tmp_path / "tmp"),
            "--final-capture-dir",
            str(tmp_path / "captures"),
            "--dry-run",
        ]
    )
    cli._run_capture_session_command(args)

    session_dir = next((tmp_path / "captures").glob("session_*"))
    meta = load_session_meta(session_dir)
    assert meta["display_export_enabled"] is True
    assert meta["display_data_dir"] == str(display_dir)
    assert meta["display_source"] == "BJTU"
    assert meta["display_split_seconds"] == 60
    assert meta["display_export_status"] == "not_started"


def test_window_mode_rejects_non_tcp(tmp_path: Path) -> None:
    """The first online implementation is deliberately TCP-only."""
    with pytest.raises(ValueError, match="packet_type=tcp"):
        run_capture_session(
            packet_type="all",
            pi_ip="192.168.1.10",
            peer_ip="192.168.1.20",
            direction="both",
            iface="eth0",
            final_base_dir=tmp_path / "captures",
            tmp_capture_dir=tmp_path / "tmp",
            file_size_kb=51200,
            max_files=200,
            execute=False,
            window_mode="online-analysis",
        )


def test_with_gps_requires_online_analysis(tmp_path: Path) -> None:
    """GPS CSV rows are only meaningful for online window analysis."""
    with pytest.raises(ValueError, match="online-analysis"):
        run_capture_session(
            packet_type="tcp",
            pi_ip=None,
            peer_ip=None,
            direction="both",
            iface="eth0",
            final_base_dir=tmp_path / "captures",
            tmp_capture_dir=tmp_path / "tmp",
            file_size_kb=51200,
            max_files=200,
            execute=False,
            capture_mode="iface_only",
            window_mode="capture-only",
            with_gps=True,
        )
