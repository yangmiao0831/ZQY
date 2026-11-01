"""Tests for compact per-window TCP metrics."""

from __future__ import annotations

import pytest

from packet_collector.analyzers.tcp_window_analyzer import calculate_tcp_window_metrics


def test_calculate_tcp_window_metrics() -> None:
    """RTT, jitter, goodput, and retransmission ratio use the agreed fields."""
    records = [
        {"tcp_len": 100, "tcp_ack_rtt": 0.010, "tcp_retransmission": None},
        {"tcp_len": 200, "tcp_ack_rtt": 0.030, "tcp_retransmission": True},
        {"tcp_len": 0, "tcp_ack_rtt": None, "tcp_retransmission": True},
    ]
    result = calculate_tcp_window_metrics(records, index=7, window_seconds=1.0)

    assert result["index"] == 7
    assert result["avg_rtt_ms"] == pytest.approx(20.0)
    assert result["jitter_ms"] == pytest.approx(20.0)
    assert result["throughput_bps"] == pytest.approx(2400.0)
    assert result["loss_rate"] == pytest.approx(0.5)


def test_calculate_tcp_window_metrics_without_samples() -> None:
    """Empty windows preserve the stable five-field schema."""
    result = calculate_tcp_window_metrics([], index=0, window_seconds=1.0)
    assert result == {
        "index": 0,
        "avg_rtt_ms": None,
        "jitter_ms": None,
        "throughput_bps": 0.0,
        "loss_rate": None,
    }
