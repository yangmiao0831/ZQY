"""Tests for centralized cross-platform JSON configuration."""

from __future__ import annotations

import json
from pathlib import Path

import pytest

from packet_collector.app_config import ConfigurationError, load_runtime_settings
from packet_collector.orchestration.configured_capture import build_capture_command


def _write_config(path: Path, data: dict[str, object]) -> Path:
    path.write_text(json.dumps(data), encoding="utf-8")
    return path


def test_windows_platform_values_and_relative_paths(tmp_path: Path) -> None:
    config_file = _write_config(
        tmp_path / "config.json",
        {
            "capture": {"peer_ip": "10.0.0.8", "final_capture_dir": "output"},
            "video": {"format": "avi"},
            "display": {"data_dir": "../ui/datas"},
            "tools": {"wireshark_dir": "tools/Wireshark"},
            "platform": {
                "windows": {"interface": "7", "gps_port": "COM8", "camera": "1"}
            },
        },
    )

    settings = load_runtime_settings(config_file, system_name="Windows")

    assert settings.interface == "7"
    assert settings.gps_port == "COM8"
    assert settings.camera == "1"
    assert settings.video_format == "avi"
    assert settings.peer_ip == "10.0.0.8"
    assert settings.final_capture_dir == (tmp_path / "output").resolve()
    assert settings.display_data_dir == (tmp_path / "../ui/datas").resolve()
    assert settings.wireshark_dir == (tmp_path / "tools/Wireshark").resolve()


def test_video_format_defaults_to_mp4(tmp_path: Path) -> None:
    config_file = _write_config(tmp_path / "config.json", {})

    settings = load_runtime_settings(config_file, system_name="Windows")

    assert settings.video_format == "mp4"


def test_invalid_video_format_is_rejected(tmp_path: Path) -> None:
    config_file = _write_config(
        tmp_path / "config.json",
        {"video": {"format": "mkv"}},
    )

    with pytest.raises(ConfigurationError, match="video.format"):
        load_runtime_settings(config_file, system_name="Windows")


def test_linux_platform_values(tmp_path: Path) -> None:
    config_file = _write_config(
        tmp_path / "config.json",
        {
            "platform": {
                "linux": {
                    "interface": "eth0",
                    "gps_port": "/dev/ttyUSB2",
                    "camera": "/dev/video2",
                }
            }
        },
    )

    settings = load_runtime_settings(config_file, system_name="Linux")

    assert settings.interface == "eth0"
    assert settings.gps_port == "/dev/ttyUSB2"
    assert settings.camera == "/dev/video2"


def test_invalid_display_without_gps_is_rejected(tmp_path: Path) -> None:
    config_file = _write_config(
        tmp_path / "config.json",
        {"gps": {"enabled": False}, "display": {"enabled": True}},
    )

    with pytest.raises(ConfigurationError, match="display.enabled"):
        load_runtime_settings(config_file, system_name="Windows")


def test_capture_command_contains_effective_config(tmp_path: Path) -> None:
    config_file = _write_config(
        tmp_path / "config.json",
        {
            "capture": {"peer_ip": "192.0.2.8", "duration_sec": 90},
            "gps": {"enabled": False},
            "display": {"enabled": False},
            "platform": {"windows": {"interface": "6", "camera": "0"}},
        },
    )
    settings = load_runtime_settings(config_file, system_name="Windows")

    command = build_capture_command(settings)

    assert command[1:5] == ["-m", "packet_collector.cli", "capture-session", "tcp"]
    assert command[command.index("--iface") + 1] == "6"
    assert command[command.index("--peer-only") + 1] == "192.0.2.8"
    assert command[command.index("--duration") + 1] == "90"
    assert "--with-gps" not in command
    assert "--display-data-dir" not in command


def test_configured_capture_defers_display_export_until_csv_merge(
    tmp_path: Path,
) -> None:
    config_file = _write_config(
        tmp_path / "config.json",
        {
            "capture": {"peer_ip": "192.0.2.8"},
            "display": {"enabled": True, "data_dir": "../ui/datas"},
            "platform": {
                "windows": {"interface": "6", "gps_port": "COM4", "camera": "0"}
            },
        },
    )
    settings = load_runtime_settings(config_file, system_name="Windows")

    command = build_capture_command(settings)

    assert "--with-gps" in command
    assert "--display-data-dir" not in command
    assert "--display-source" not in command
