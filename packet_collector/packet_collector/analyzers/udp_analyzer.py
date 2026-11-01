"""UDP transport-layer summary analyzer.

This module reads packet-level JSONL records and writes a basic UDP summary.
It does not infer UDP loss because generic UDP packet records do not contain a
reliable sequence space.
"""

from __future__ import annotations

from collections import Counter
from pathlib import Path

from packet_collector.analyzers.common import (
    any_field_non_empty,
    as_float,
    as_int,
    count_value,
    counter_dict,
    duration,
    iter_jsonl_records,
    protocol_seen,
    throughput_bps,
)
from packet_collector.storage.json_writer import write_json


def _is_udp_record(record: dict[str, object]) -> bool:
    """Return True when a mixed JSONL record belongs to UDP."""
    return protocol_seen(record, "udp") or any_field_non_empty(record, ["udp_length"])


def analyze_udp_jsonl(packet_jsonl: Path, output_file: Path) -> Path:
    """Analyze UDP packet JSONL and write `udp_summary.json`."""
    packet_count = 0
    invalid_record_count = 0
    first_time_epoch: float | None = None
    last_time_epoch: float | None = None
    total_frame_bytes = 0
    total_udp_bytes = 0

    src_ip_counts: Counter[str] = Counter()
    dst_ip_counts: Counter[str] = Counter()
    src_port_counts: Counter[str] = Counter()
    dst_port_counts: Counter[str] = Counter()

    for record, invalid in iter_jsonl_records(packet_jsonl):
        if invalid or record is None:
            invalid_record_count += 1
            continue
        if not _is_udp_record(record):
            continue

        packet_count += 1
        time_epoch = as_float(record.get("time_epoch"))
        if time_epoch is not None:
            if first_time_epoch is None:
                first_time_epoch = time_epoch
            last_time_epoch = time_epoch

        total_frame_bytes += as_int(record.get("frame_len"))
        total_udp_bytes += as_int(record.get("udp_length"))
        count_value(src_ip_counts, record.get("src_ip"))
        count_value(dst_ip_counts, record.get("dst_ip"))
        count_value(src_port_counts, record.get("src_port"))
        count_value(dst_port_counts, record.get("dst_port"))

    duration_sec = duration(first_time_epoch, last_time_epoch)
    summary: dict[str, object] = {
        "summary_type": "udp",
        "packet_count": packet_count,
        "invalid_record_count": invalid_record_count,
        "first_time_epoch": first_time_epoch,
        "last_time_epoch": last_time_epoch,
        "duration_sec": duration_sec,
        "total_frame_bytes": total_frame_bytes,
        "total_udp_bytes": total_udp_bytes,
        "throughput_bps_frame": throughput_bps(total_frame_bytes, duration_sec),
        "throughput_bps_udp": throughput_bps(total_udp_bytes, duration_sec),
        "src_ip_counts": counter_dict(src_ip_counts),
        "dst_ip_counts": counter_dict(dst_ip_counts),
        "src_port_counts": counter_dict(src_port_counts),
        "dst_port_counts": counter_dict(dst_port_counts),
    }
    return write_json(output_file, summary)


def analyze_udp_placeholder(packet_jsonl: Path) -> dict[str, object]:
    """Backward-compatible placeholder wrapper."""
    return {"packet_jsonl": str(packet_jsonl), "implemented": True}
