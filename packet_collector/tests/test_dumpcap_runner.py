"""Tests for dumpcap command construction helpers."""

from __future__ import annotations

from pathlib import Path

from packet_collector.capture.dumpcap_runner import build_dumpcap_command, ensure_tmp_capture_dir


def test_build_dumpcap_command_without_duration() -> None:
    """Build a dumpcap command without executing it."""
    command = build_dumpcap_command(
        iface="wlan0",
        capture_filter="host 192.168.1.10 and host 192.168.1.20 and tcp",
        output_file=Path("capture.pcapng"),
        file_size_kb=51200,
        max_files=20,
    )
    assert command == [
        "dumpcap",
        "-i",
        "wlan0",
        "-f",
        "host 192.168.1.10 and host 192.168.1.20 and tcp",
        "-b",
        "filesize:51200",
        "-b",
        "files:20",
        "-w",
        "capture.pcapng",
    ]


def test_build_dumpcap_command_with_duration() -> None:
    """Duration adds a dumpcap autostop option."""
    command = build_dumpcap_command(
        iface="wlan0",
        capture_filter="tcp",
        output_file=Path("capture.pcapng"),
        file_size_kb=1024,
        max_files=3,
        duration=10,
    )
    assert command[-2:] == ["-a", "duration:10"]


def test_build_dumpcap_command_with_time_rotation() -> None:
    """Window capture uses duration rotation without dumpcap file deletion."""
    command = build_dumpcap_command(
        iface="eth0",
        capture_filter="tcp",
        output_file=Path("window.pcapng"),
        file_size_kb=None,
        max_files=None,
        duration=60,
        rotation_duration=1.0,
    )
    assert ["-b", "duration:1"] == command[command.index("-b") : command.index("-b") + 2]
    assert "filesize:51200" not in command
    assert not any(value.startswith("files:") for value in command)


def test_ensure_tmp_capture_dir_creates_directory(tmp_path: Path) -> None:
    """Temporary capture directory creation is hardware-independent."""
    tmp_capture_dir = ensure_tmp_capture_dir(tmp_path / "captures")
    assert tmp_capture_dir.exists()
    assert tmp_capture_dir.is_dir()
