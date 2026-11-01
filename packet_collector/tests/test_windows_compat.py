"""Windows compatibility tests without real adapters, capture, or CMD calls."""

from __future__ import annotations

import socket
from pathlib import Path
from types import SimpleNamespace

from packet_collector.collectors import device_collector, ip_collector
from packet_collector.deploy import env_check
from packet_collector.probes import ping_probe


class FakePsutil:
    AF_LINK = -1

    @staticmethod
    def net_if_stats():
        return {"Mobile": SimpleNamespace(isup=True, mtu=1500)}

    @staticmethod
    def net_if_addrs():
        return {
            "Mobile": [
                SimpleNamespace(family=FakePsutil.AF_LINK, address="aa-bb-cc-dd-ee-ff"),
                SimpleNamespace(family=socket.AF_INET, address="10.20.30.40"),
                SimpleNamespace(family=socket.AF_INET6, address="fe80::1%7"),
            ]
        }


def test_windows_interface_state_and_addresses(monkeypatch) -> None:
    monkeypatch.setattr(ip_collector.platform, "system", lambda: "Windows")
    monkeypatch.setattr(ip_collector, "psutil", FakePsutil)

    state = ip_collector.get_interface_state("Mobile")
    addresses = ip_collector.get_interface_addresses("Mobile")

    assert state["is_up"] is True
    assert state["mtu"] == 1500
    assert addresses["ipv4"] == ["10.20.30.40"]
    assert addresses["ipv6"] == ["fe80::1"]


def test_windows_default_route(monkeypatch) -> None:
    monkeypatch.setattr(ip_collector.platform, "system", lambda: "Windows")
    monkeypatch.setattr(ip_collector, "psutil", FakePsutil)
    output = """
          0.0.0.0          0.0.0.0       10.20.30.1      10.20.30.40     25
          0.0.0.0          0.0.0.0       192.168.1.1     192.168.1.2    100
    """
    monkeypatch.setattr(
        ip_collector.subprocess,
        "run",
        lambda *args, **kwargs: SimpleNamespace(returncode=0, stdout=output, stderr=""),
    )

    result = ip_collector.get_default_route()

    assert result["gateway"] == "10.20.30.1"
    assert result["dev"] == "Mobile"


def test_windows_dns_servers(monkeypatch) -> None:
    monkeypatch.setattr(ip_collector.platform, "system", lambda: "Windows")
    output = "   DNS Servers . . . . . . . . . . . : 8.8.8.8\n                                       1.1.1.1\n"
    monkeypatch.setattr(
        ip_collector.subprocess,
        "run",
        lambda *args, **kwargs: SimpleNamespace(returncode=0, stdout=output, stderr=""),
    )
    assert ip_collector.get_dns_servers() == ["8.8.8.8", "1.1.1.1"]


def test_windows_ping_command_and_output(monkeypatch) -> None:
    monkeypatch.setattr(ping_probe.platform, "system", lambda: "Windows")
    seen: list[str] = []
    output = """
Reply from 192.168.1.1: bytes=32 time=2ms TTL=64
Reply from 192.168.1.1: bytes=32 time=4ms TTL=64
    Packets: Sent = 2, Received = 2, Lost = 0 (0% loss),
Minimum = 2ms, Maximum = 4ms, Average = 3ms
"""

    def fake_run(command, capture_output, text, check):
        seen.extend(command)
        return SimpleNamespace(returncode=0, stdout=output, stderr="")

    monkeypatch.setattr(ping_probe.subprocess, "run", fake_run)
    result = ping_probe.run_ping_probe("192.168.1.1", count=2, timeout=5)

    assert seen == ["ping", "-n", "2", "-w", "5000", "192.168.1.1"]
    assert result["packet_loss_percent"] == 0.0
    assert result["rtt_avg_ms"] == 3.0


def test_windows_time_sync_uses_w32tm(monkeypatch) -> None:
    monkeypatch.setattr(device_collector.platform, "system", lambda: "Windows")
    seen: list[str] = []

    def fake_run(command, capture_output, text, check):
        seen.extend(command)
        return SimpleNamespace(returncode=0, stdout="Source: time.windows.com", stderr="")

    monkeypatch.setattr(device_collector.subprocess, "run", fake_run)
    result = device_collector.get_time_sync_status()
    assert seen == ["w32tm", "/query", "/status"]
    assert result["synchronized"] is True


def test_windows_env_check_uses_ipconfig(monkeypatch, tmp_path: Path) -> None:
    monkeypatch.setattr(env_check.platform, "system", lambda: "Windows")
    commands: list[str] = []

    def fake_check(command, version_args=None):
        commands.append(command)
        return {"available": True, "path": command, "version": None, "error": None}

    monkeypatch.setattr(env_check, "check_command", fake_check)
    monkeypatch.setattr(env_check, "check_python_package", lambda name: {"available": True, "version": None, "error": None})
    monkeypatch.setattr(env_check, "check_npcap", lambda: {"available": True, "running": True, "path": None, "version": None, "error": None})
    result = env_check.run_env_check(tmp_path / "tmp", tmp_path / "captures")

    assert "ipconfig" in commands
    assert result["success"] is True


def test_cmd_launchers_exist() -> None:
    scripts = Path(__file__).resolve().parents[1] / "scripts"
    capture = (scripts / "capture.bat").read_text(encoding="utf-8")
    combined = (scripts / "capture_with_video.bat").read_text(encoding="utf-8")
    assert "packet_collector.orchestration.configured_capture" in capture
    assert "--no-video" in capture
    assert "packet_collector.orchestration.configured_capture" in combined
    assert "--video" in combined
    assert "config.json" in capture
    assert "config.json" in combined
    assert "powershell" not in capture.lower()
    assert "powershell" not in combined.lower()
