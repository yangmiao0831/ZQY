"""Tests for device runtime collector."""

from __future__ import annotations

from types import SimpleNamespace

import pytest

from packet_collector.collectors import device_collector
from packet_collector.collectors.device_collector import (
    collect_device_metrics,
    get_load_average,
    get_temperature_c,
    get_time_sync_status,
)


def test_collect_device_metrics_success(monkeypatch) -> None:
    """Device collector returns controlled psutil and helper values."""
    monkeypatch.setattr(
        device_collector,
        "psutil",
        SimpleNamespace(
            cpu_percent=lambda interval=None: 12.3,
            virtual_memory=lambda: SimpleNamespace(percent=45.6),
            disk_usage=lambda path: SimpleNamespace(percent=70.1),
            boot_time=lambda: 1000.0,
        ),
    )
    monkeypatch.setattr(device_collector.time, "time", lambda: 2000.0)
    monkeypatch.setattr(device_collector.os, "getloadavg", lambda: (0.12, 0.20, 0.18), raising=False)
    monkeypatch.setattr(device_collector, "get_temperature_c", lambda: 52.1)
    monkeypatch.setattr(
        device_collector,
        "get_time_sync_status",
        lambda: {"available": True, "synchronized": True, "raw": "yes", "error": None},
    )

    result = collect_device_metrics(disk_path="/")

    assert result["collector_type"] == "device"
    assert result["success"] is True
    assert result["cpu_percent"] == 12.3
    assert result["memory_percent"] == 45.6
    assert result["disk_percent"] == 70.1
    assert result["load_average"]["available"] is True
    assert result["temperature_c"] == 52.1
    assert result["time_sync"]["synchronized"] is True
    assert result["uptime_seconds"] == 1000.0


def test_temperature_from_thermal_file(tmp_path) -> None:
    """Thermal sysfs value is millidegrees Celsius."""
    thermal_path = tmp_path / "temp"
    thermal_path.write_text("52000\n", encoding="utf-8")

    assert get_temperature_c(thermal_path) == 52.0


def test_temperature_from_vcgencmd(monkeypatch, tmp_path) -> None:
    """vcgencmd temperature output is parsed when thermal file is absent."""

    def fake_run(command, capture_output, text, check):
        return SimpleNamespace(returncode=0, stdout="temp=52.1'C\n", stderr="")

    monkeypatch.setattr(device_collector.subprocess, "run", fake_run)
    assert get_temperature_c(tmp_path / "missing") == 52.1


def test_temperature_unavailable(monkeypatch, tmp_path) -> None:
    """Missing thermal file and vcgencmd returns None."""

    def fake_run(command, capture_output, text, check):
        raise FileNotFoundError()

    monkeypatch.setattr(device_collector.subprocess, "run", fake_run)
    assert get_temperature_c(tmp_path / "missing") is None


@pytest.mark.parametrize(
    ("raw", "expected"),
    [
        ("yes\n", True),
        ("no\n", False),
    ],
)
def test_time_sync_status(monkeypatch, raw: str, expected: bool) -> None:
    """timedatectl yes/no is converted to a bool."""
    monkeypatch.setattr(device_collector.platform, "system", lambda: "Linux")

    def fake_run(command, capture_output, text, check):
        return SimpleNamespace(returncode=0, stdout=raw, stderr="")

    monkeypatch.setattr(device_collector.subprocess, "run", fake_run)
    result = get_time_sync_status()

    assert result["available"] is True
    assert result["synchronized"] is expected


def test_time_sync_unavailable(monkeypatch) -> None:
    """Missing timedatectl is reported as unavailable."""

    def fake_run(command, capture_output, text, check):
        raise FileNotFoundError()

    monkeypatch.setattr(device_collector.subprocess, "run", fake_run)
    result = get_time_sync_status()

    assert result["available"] is False
    assert result["synchronized"] is None


def test_load_average_unavailable(monkeypatch) -> None:
    """Unsupported load average returns available=false."""

    def fake_getloadavg():
        raise OSError("not supported")

    monkeypatch.setattr(device_collector.os, "getloadavg", fake_getloadavg, raising=False)
    result = get_load_average()

    assert result["available"] is False
    assert result["1min"] is None
