"""Tests for DNS active probe."""

from __future__ import annotations

import socket

from packet_collector.probes.dns_probe import run_dns_probe


def test_run_dns_probe_success(monkeypatch) -> None:
    """DNS probe extracts IPv4 and IPv6 addresses."""

    def fake_getaddrinfo(domain, port):
        return [
            (socket.AF_INET, None, None, None, ("93.184.216.34", 0)),
            (socket.AF_INET6, None, None, None, ("2606:2800:220:1:248:1893:25c8:1946", 0)),
        ]

    monkeypatch.setattr(socket, "getaddrinfo", fake_getaddrinfo)
    result = run_dns_probe("example.com", dns_server="8.8.8.8")

    assert result["success"] is True
    assert result["address_count"] == 2
    assert "93.184.216.34" in result["addresses"]
    assert result["dns_server_used"] is False


def test_run_dns_probe_failure(monkeypatch) -> None:
    """DNS resolver errors return a failed result."""

    def fake_getaddrinfo(domain, port):
        raise socket.gaierror("mock DNS failure")

    monkeypatch.setattr(socket, "getaddrinfo", fake_getaddrinfo)
    result = run_dns_probe("bad.example")

    assert result["success"] is False
    assert "mock DNS failure" in result["error"]
