"""ICMP transport-layer summary analyzer.

This module reads packet-level JSONL records and writes a basic ICMP summary
including echo request/reply and ICMP error message counts.
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
)
from packet_collector.storage.json_writer import write_json


def _is_icmp_record(record: dict[str, object]) -> bool:
    """Return True when a mixed JSONL record belongs to ICMP."""
    return protocol_seen(record, "icmp") or any_field_non_empty(record, ["icmp_type", "icmp_code"])


def analyze_icmp_jsonl(packet_jsonl: Path, output_file: Path) -> Path:
    """Analyze ICMP packet JSONL and write `icmp_summary.json`."""
    packet_count = 0
    invalid_record_count = 0
    first_time_epoch: float | None = None
    last_time_epoch: float | None = None
    total_frame_bytes = 0
    echo_request_count = 0
    echo_reply_count = 0
    error_message_count = 0

    src_ip_counts: Counter[str] = Counter()
    dst_ip_counts: Counter[str] = Counter()
    icmp_type_counts: Counter[str] = Counter()
    icmp_code_counts: Counter[str] = Counter()

    for record, invalid in iter_jsonl_records(packet_jsonl):
        if invalid or record is None:
            invalid_record_count += 1
            continue
        if not _is_icmp_record(record):
            continue

        packet_count += 1
        time_epoch = as_float(record.get("time_epoch"))
        if time_epoch is not None:
            if first_time_epoch is None:
                first_time_epoch = time_epoch
            last_time_epoch = time_epoch

        total_frame_bytes += as_int(record.get("frame_len"))
        count_value(src_ip_counts, record.get("src_ip"))
        count_value(dst_ip_counts, record.get("dst_ip"))
        count_value(icmp_type_counts, record.get("icmp_type"))
        count_value(icmp_code_counts, record.get("icmp_code"))

        icmp_type = as_int(record.get("icmp_type"))
        if icmp_type == 8:
            echo_request_count += 1
        elif icmp_type == 0:
            echo_reply_count += 1
        else:
            error_message_count += 1

    summary: dict[str, object] = {
        "summary_type": "icmp",
        "packet_count": packet_count,
        "invalid_record_count": invalid_record_count,
        "first_time_epoch": first_time_epoch,
        "last_time_epoch": last_time_epoch,
        "duration_sec": duration(first_time_epoch, last_time_epoch),
        "total_frame_bytes": total_frame_bytes,
        "src_ip_counts": counter_dict(src_ip_counts),
        "dst_ip_counts": counter_dict(dst_ip_counts),
        "icmp_type_counts": counter_dict(icmp_type_counts),
        "icmp_code_counts": counter_dict(icmp_code_counts),
        "echo_request_count": echo_request_count,
        "echo_reply_count": echo_reply_count,
        "error_message_count": error_message_count,
    }
    return write_json(output_file, summary)


def analyze_icmp_placeholder(packet_jsonl: Path) -> dict[str, object]:
    """Backward-compatible placeholder wrapper."""
    return {"packet_jsonl": str(packet_jsonl), "implemented": True}
