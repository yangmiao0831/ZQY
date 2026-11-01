from __future__ import annotations

from datetime import datetime

from video.overlay_network_metrics import MetricTimeline, NetworkMetric, _display_lines


def metric(timestamp: str, *, rtt: float = 1.0) -> NetworkMetric:
    return NetworkMetric(
        timestamp=datetime.fromisoformat(timestamp),
        avg_rtt_ms=rtt,
        jitter_ms=0.5,
        throughput_bps=125_000_000,
        loss_rate=0.0125,
    )


def test_timeline_uses_latest_metric_at_or_before_frame_time() -> None:
    first = metric("2026-10-07 16:13:40.991", rtt=1.0)
    second = metric("2026-10-07 16:13:41.991", rtt=2.0)
    timeline = MetricTimeline([first, second])

    assert timeline.at(datetime.fromisoformat("2026-10-07 16:13:41.500")) == first
    assert timeline.at(datetime.fromisoformat("2026-10-07 16:13:41.991")) == second


def test_timeline_does_not_hold_stale_metrics_across_a_gap() -> None:
    timeline = MetricTimeline([metric("2026-10-07 16:13:40.000")], max_age_seconds=2.0)

    assert timeline.at(datetime.fromisoformat("2026-10-07 16:13:42.001")) is None


def test_display_converts_bps_and_loss_ratio() -> None:
    lines = _display_lines(
        datetime.fromisoformat("2026-10-07 16:13:41.123"),
        metric("2026-10-07 16:13:41.000"),
    )

    assert lines[0] == "2026-10-07 16:13:41.123"
    assert "125.00 Mbps" in lines[2]
    assert "1.250 %" in lines[4]
