"""Per-window TCP metrics for continuous session capture.

Each closed pcapng rotation file is analyzed independently. ACK/RTT samples
that cannot be matched inside that file are intentionally absent, so packets
crossing a window boundary do not carry state into the next window.
"""

from __future__ import annotations

from collections.abc import Iterable
from pathlib import Path

from packet_collector.parsers.pcap_to_json import parse_tshark_line
from packet_collector.parsers.tshark_fields import get_display_filter, get_fields_for_packet_type
from packet_collector.parsers.tshark_runner import build_tshark_fields_command, run_tshark_stream


def _number(value: object) -> float | None:
    """Convert a packet field to float when possible."""
    if value is None or value == "":
        return None
    try:
        return float(value)
    except (TypeError, ValueError):
        return None


def calculate_tcp_window_metrics(
    records: Iterable[dict[str, object]],
    index: int,
    window_seconds: float,
) -> dict[str, object]:
    """Calculate the compact metrics emitted for one independent TCP window."""
    if window_seconds <= 0:
        raise ValueError("window_seconds must be > 0")

    rtt_ms: list[float] = []
    payload_bytes = 0
    data_packet_count = 0
    retransmission_count = 0

    for record in records:
        tcp_len = _number(record.get("tcp_len"))
        if tcp_len is not None and tcp_len > 0:
            payload_bytes += int(tcp_len)
            data_packet_count += 1
            if record.get("tcp_retransmission") not in (None, "") or record.get(
                "tcp_fast_retransmission"
            ) not in (None, ""):
                retransmission_count += 1

        ack_rtt = _number(record.get("tcp_ack_rtt"))
        if ack_rtt is not None and ack_rtt >= 0:
            rtt_ms.append(ack_rtt * 1000.0)

    avg_rtt_ms = sum(rtt_ms) / len(rtt_ms) if rtt_ms else None
    jitter_ms = None
    if len(rtt_ms) >= 2:
        differences = [abs(current - previous) for previous, current in zip(rtt_ms, rtt_ms[1:])]
        jitter_ms = sum(differences) / len(differences)

    return {
        "index": index,
        "avg_rtt_ms": avg_rtt_ms,
        "jitter_ms": jitter_ms,
        "throughput_bps": payload_bytes * 8.0 / window_seconds,
        "loss_rate": retransmission_count / data_packet_count if data_packet_count else None,
    }


def analyze_tcp_window(pcap_file: Path, index: int, window_seconds: float) -> dict[str, object]:
    """Stream one pcapng through tshark and return its compact TCP metrics."""
    fields = get_fields_for_packet_type("tcp")
    command = build_tshark_fields_command(pcap_file, fields, get_display_filter("tcp"))
    records = (
        parse_tshark_line(line, fields, "tcp", pcap_file)
        for line in run_tshark_stream(command)
    )
    return calculate_tcp_window_metrics(records, index=index, window_seconds=window_seconds)


def empty_tcp_window_metrics(index: int) -> dict[str, object]:
    """Return a stable null-valued record when one window cannot be analyzed."""
    return {
        "index": index,
        "avg_rtt_ms": None,
        "jitter_ms": None,
        "throughput_bps": None,
        "loss_rate": None,
    }
