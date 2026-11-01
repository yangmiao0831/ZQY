"""Tests for ping active probe."""

from __future__ import annotations

import subprocess
from types import SimpleNamespace

from packet_collector.probes import ping_probe
from packet_collector.probes.ping_probe import run_ping_probe


PING_STDOUT = """
4 packets transmitted, 4 received, 0% packet loss, time 3004ms
rtt min/avg/max/mdev = 1.234/2.345/3.456/0.111 ms
"""


def test_run_ping_probe_success(monkeypatch) -> None:
    """Ping parses packet loss and RTT fields."""

    def fake_run(command, capture_output, text, check):
        return SimpleNamespace(returncode=0, stdout=PING_STDOUT, stderr="")

    monkeypatch.setattr(subprocess, "run", fake_run)
    result = run_ping_probe("192.168.1.1", count=4, timeout=5)

    assert result["success"] is True
    assert result["packet_loss_percent"] == 0.0
    assert result["rtt_avg_ms"] == 2.345
    assert result["rtt_min_ms"] == 1.234
    assert result["rtt_max_ms"] == 3.456


def test_run_ping_probe_command_not_found(monkeypatch) -> None:
    """Missing ping command returns a failed result."""

    def fake_run(command, capture_output, text, check):
        raise FileNotFoundError()

    monkeypatch.setattr(ping_probe.subprocess, "run", fake_run)
    result = run_ping_probe("192.168.1.1")

    assert result["success"] is False
    assert result["error"] == "ping command not found"
