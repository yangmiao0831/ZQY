"""DNS application-layer summary analyzer.

This module reads packet-level JSONL records and writes a DNS metadata summary.
It does not call tshark and does not attempt transaction-level latency matching.
"""

from __future__ import annotations

from collections import Counter
from pathlib import Path

from packet_collector.analyzers.common import (
    any_field_non_empty,
    as_float,
    as_int,
    avg_min_max,
    count_value,
    counter_dict,
    duration,
    iter_jsonl_records,
    non_empty,
    protocol_seen,
)
from packet_collector.storage.json_writer import write_json


def _is_dns_record(record: dict[str, object]) -> bool:
    """Return True when a mixed JSONL record belongs to DNS."""
    return protocol_seen(record, "dns") or any_field_non_empty(
        record,
        ["dns_query_name", "dns_query_type", "dns_response_code", "dns_answer_ipv4", "dns_answer_ipv6"],
    )


def analyze_dns_jsonl(packet_jsonl: Path, output_file: Path) -> Path:
    """Analyze DNS packet JSONL and write `dns_summary.json`."""
    packet_count = 0
    invalid_record_count = 0
    first_time_epoch: float | None = None
    last_time_epoch: float | None = None
    total_frame_bytes = 0
    query_count = 0
    response_count = 0
    latencies: list[float] = []

    query_name_counts: Counter[str] = Counter()
    query_type_counts: Counter[str] = Counter()
    response_code_counts: Counter[str] = Counter()
    answer_ipv4_counts: Counter[str] = Counter()
    answer_ipv6_counts: Counter[str] = Counter()
    src_ip_counts: Counter[str] = Counter()
    dst_ip_counts: Counter[str] = Counter()
    src_port_counts: Counter[str] = Counter()
    dst_port_counts: Counter[str] = Counter()

    for record, invalid in iter_jsonl_records(packet_jsonl):
        if invalid or record is None:
            invalid_record_count += 1
            continue
        if not _is_dns_record(record):
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
        count_value(src_port_counts, record.get("src_port"))
        count_value(dst_port_counts, record.get("dst_port"))
        count_value(query_name_counts, record.get("dns_query_name"))
        count_value(query_type_counts, record.get("dns_query_type"))
        count_value(response_code_counts, record.get("dns_response_code"))
        count_value(answer_ipv4_counts, record.get("dns_answer_ipv4"))
        count_value(answer_ipv6_counts, record.get("dns_answer_ipv6"))

        if non_empty(record.get("dns_query_name")):
            query_count += 1
        if (
            non_empty(record.get("dns_response_code"))
            or non_empty(record.get("dns_answer_ipv4"))
            or non_empty(record.get("dns_answer_ipv6"))
        ):
            response_count += 1

        dns_latency = as_float(record.get("dns_latency"))
        if dns_latency is not None:
            latencies.append(dns_latency)

    latency_count, latency_avg, latency_min, latency_max = avg_min_max(latencies)
    summary: dict[str, object] = {
        "summary_type": "dns",
        "packet_count": packet_count,
        "invalid_record_count": invalid_record_count,
        "first_time_epoch": first_time_epoch,
        "last_time_epoch": last_time_epoch,
        "duration_sec": duration(first_time_epoch, last_time_epoch),
        "total_frame_bytes": total_frame_bytes,
        "query_count": query_count,
        "unique_query_count": len(query_name_counts),
        "query_name_counts": counter_dict(query_name_counts),
        "query_type_counts": counter_dict(query_type_counts),
        "response_count": response_count,
        "response_code_counts": counter_dict(response_code_counts),
        "answer_ipv4_counts": counter_dict(answer_ipv4_counts),
        "answer_ipv6_counts": counter_dict(answer_ipv6_counts),
        "src_ip_counts": counter_dict(src_ip_counts),
        "dst_ip_counts": counter_dict(dst_ip_counts),
        "src_port_counts": counter_dict(src_port_counts),
        "dst_port_counts": counter_dict(dst_port_counts),
        "dns_latency_count": latency_count,
        "dns_latency_avg": latency_avg,
        "dns_latency_min": latency_min,
        "dns_latency_max": latency_max,
    }
    return write_json(output_file, summary)


def analyze_dns_placeholder(packet_jsonl: Path) -> dict[str, object]:
    """Backward-compatible placeholder wrapper."""
    return {"packet_jsonl": str(packet_jsonl), "implemented": True}
