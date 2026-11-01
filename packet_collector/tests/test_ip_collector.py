"""Tests for IP-layer collector."""

from __future__ import annotations

import json
from types import SimpleNamespace

import pytest

from packet_collector.collectors import ip_collector
from packet_collector.collectors.ip_collector import (
    collect_ip_metrics,
    get_default_route,
    get_dns_servers,
    get_interface_addresses,
    get_interface_state,
)


@pytest.fixture(autouse=True)
def force_linux_collector(monkeypatch) -> None:
    """Keep legacy collector tests independent from the host running pytest."""
    monkeypatch.setattr(ip_collector.platform, "system", lambda: "Linux")


def test_get_dns_servers_parses_resolv_conf(tmp_path) -> None:
    """nameserver lines are parsed from resolv.conf."""
    resolv_conf = tmp_path / "resolv.conf"
    resolv_conf.write_text(
        "# comment\nnameserver 192.168.31.1\nnameserver 8.8.8.8\nsearch local\n",
        encoding="utf-8",
    )

    assert get_dns_servers(resolv_conf) == ["192.168.31.1", "8.8.8.8"]


def test_get_interface_state_missing(tmp_path) -> None:
    """Missing interface is reported cleanly."""
    result = get_interface_state("wlan0", sys_class_net_base=tmp_path)

    assert result["exists"] is False
    assert result["is_up"] is False
    assert result["error"] == "interface not found"


def test_get_interface_state_existing(tmp_path) -> None:
    """Existing interface state reads operstate, MAC, and MTU."""
    iface_dir = tmp_path / "wlan0"
    iface_dir.mkdir()
    (iface_dir / "operstate").write_text("up\n", encoding="utf-8")
    (iface_dir / "address").write_text("aa:bb:cc:dd:ee:ff\n", encoding="utf-8")
    (iface_dir / "mtu").write_text("1500\n", encoding="utf-8")

    result = get_interface_state("wlan0", sys_class_net_base=tmp_path)

    assert result["exists"] is True
    assert result["is_up"] is True
    assert result["mac"] == "aa:bb:cc:dd:ee:ff"
    assert result["mtu"] == 1500


def test_get_interface_addresses_success(monkeypatch) -> None:
    """ip -j addr JSON is parsed into IPv4 and IPv6 lists."""
    payload = [
        {
            "addr_info": [
                {"family": "inet", "local": "192.168.31.102"},
                {"family": "inet6", "local": "fe80::1234"},
            ]
        }
    ]

    def fake_run(command, capture_output, text, check):
        return SimpleNamespace(returncode=0, stdout=json.dumps(payload), stderr="")

    monkeypatch.setattr(ip_collector.subprocess, "run", fake_run)
    result = get_interface_addresses("wlan0")

    assert result["ipv4"] == ["192.168.31.102"]
    assert result["ipv6"] == ["fe80::1234"]
    assert result["error"] is None


def test_get_interface_addresses_ip_missing(monkeypatch) -> None:
    """Missing ip command is reported without raising."""

    def fake_run(command, capture_output, text, check):
        raise FileNotFoundError()

    monkeypatch.setattr(ip_collector.subprocess, "run", fake_run)
    result = get_interface_addresses("wlan0")

    assert result["ipv4"] == []
    assert result["ipv6"] == []
    assert result["error"] == "ip command not found"


def test_get_default_route_success(monkeypatch) -> None:
    """Default route parser extracts gateway and dev."""

    def fake_run(command, capture_output, text, check):
        return SimpleNamespace(
            returncode=0,
            stdout="default via 192.168.31.1 dev wlan0 proto dhcp metric 600\n",
            stderr="",
        )

    monkeypatch.setattr(ip_collector.subprocess, "run", fake_run)
    result = get_default_route()

    assert result["gateway"] == "192.168.31.1"
    assert result["dev"] == "wlan0"
    assert "default via" in result["raw"]


def test_get_default_route_missing(monkeypatch) -> None:
    """No default route returns an error field."""

    def fake_run(command, capture_output, text, check):
        return SimpleNamespace(returncode=0, stdout="", stderr="")

    monkeypatch.setattr(ip_collector.subprocess, "run", fake_run)
    result = get_default_route()

    assert result["gateway"] is None
    assert result["error"] == "default route not found"


def test_collect_ip_metrics_full_path(monkeypatch) -> None:
    """IP collector combines interface, route, DNS, and ping checks."""
    monkeypatch.setattr(
        ip_collector,
        "get_interface_state",
        lambda iface: {"exists": True, "is_up": True, "operstate": "up", "mac": "aa", "mtu": 1500, "error": None},
    )
    monkeypatch.setattr(
        ip_collector,
        "get_interface_addresses",
        lambda iface: {"ipv4": ["192.168.31.102"], "ipv6": [], "error": None},
    )
    monkeypatch.setattr(
        ip_collector,
        "get_default_route",
        lambda: {"gateway": "192.168.31.1", "dev": "wlan0", "raw": "default via 192.168.31.1 dev wlan0", "error": None},
    )
    monkeypatch.setattr(ip_collector, "get_dns_servers", lambda: ["192.168.31.1"])
    monkeypatch.setattr(
        ip_collector,
        "run_ping_check",
        lambda target, count=4, timeout=5: {
            "target": target,
            "success": True,
            "packet_loss_percent": 0.0,
            "rtt_avg_ms": 2.1,
            "error": None,
        },
    )

    result = collect_ip_metrics(iface="wlan0", target="192.168.31.79")

    assert result["collector_type"] == "ip"
    assert result["success"] is True
    assert result["dns_servers"] == ["192.168.31.1"]
    assert result["gateway_ping"]["target"] == "192.168.31.1"
    assert result["target_ping"]["target"] == "192.168.31.79"
