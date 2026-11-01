"""HTTP application-layer summary analyzer.

This module summarizes cleartext HTTP metadata from packet JSONL records.
HTTPS content is not visible here; TLS metadata is handled by tls_analyzer.
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


def _is_http_record(record: dict[str, object]) -> bool:
    """Return True when a mixed JSONL record belongs to cleartext HTTP."""
    return protocol_seen(record, "http") or any_field_non_empty(
        record,
        [
            "http_method",
            "http_host",
            "http_uri",
            "http_user_agent",
            "http_status_code",
            "http_content_length",
            "http_content_type",
        ],
    )


def analyze_http_jsonl(packet_jsonl: Path, output_file: Path) -> Path:
    """Analyze HTTP packet JSONL and write `http_summary.json`."""
    packet_count = 0
    invalid_record_count = 0
    first_time_epoch: float | None = None
    last_time_epoch: float | None = None
    total_frame_bytes = 0
    request_count = 0
    response_count = 0
    content_length_total = 0
    latencies: list[float] = []

    method_counts: Counter[str] = Counter()
    host_counts: Counter[str] = Counter()
    uri_counts: Counter[str] = Counter()
    user_agent_counts: Counter[str] = Counter()
    status_code_counts: Counter[str] = Counter()
    content_type_counts: Counter[str] = Counter()
    src_ip_counts: Counter[str] = Counter()
    dst_ip_counts: Counter[str] = Counter()
    src_port_counts: Counter[str] = Counter()
    dst_port_counts: Counter[str] = Counter()

    for record, invalid in iter_jsonl_records(packet_jsonl):
        if invalid or record is None:
            invalid_record_count += 1
            continue
        if not _is_http_record(record):
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
        count_value(method_counts, record.get("http_method"))
        count_value(host_counts, record.get("http_host"))
        count_value(uri_counts, record.get("http_uri"))
        count_value(user_agent_counts, record.get("http_user_agent"))
        count_value(status_code_counts, record.get("http_status_code"))
        count_value(content_type_counts, record.get("http_content_type"))

        if non_empty(record.get("http_method")):
            request_count += 1
        if non_empty(record.get("http_status_code")):
            response_count += 1
        content_length_total += as_int(record.get("http_content_length"))

        http_latency = as_float(record.get("http_latency"))
        if http_latency is not None:
            latencies.append(http_latency)

    latency_count, latency_avg, latency_min, latency_max = avg_min_max(latencies)
    summary: dict[str, object] = {
        "summary_type": "http",
        "packet_count": packet_count,
        "invalid_record_count": invalid_record_count,
        "first_time_epoch": first_time_epoch,
        "last_time_epoch": last_time_epoch,
        "duration_sec": duration(first_time_epoch, last_time_epoch),
        "total_frame_bytes": total_frame_bytes,
        "request_count": request_count,
        "method_counts": counter_dict(method_counts),
        "host_counts": counter_dict(host_counts),
        "uri_counts": counter_dict(uri_counts),
        "user_agent_counts": counter_dict(user_agent_counts),
        "response_count": response_count,
        "status_code_counts": counter_dict(status_code_counts),
        "content_type_counts": counter_dict(content_type_counts),
        "content_length_total": content_length_total,
        "src_ip_counts": counter_dict(src_ip_counts),
        "dst_ip_counts": counter_dict(dst_ip_counts),
        "src_port_counts": counter_dict(src_port_counts),
        "dst_port_counts": counter_dict(dst_port_counts),
        "http_latency_count": latency_count,
        "http_latency_avg": latency_avg,
        "http_latency_min": latency_min,
        "http_latency_max": latency_max,
    }
    return write_json(output_file, summary)


def analyze_http_placeholder(packet_jsonl: Path) -> dict[str, object]:
    """Backward-compatible placeholder wrapper."""
    return {"packet_jsonl": str(packet_jsonl), "implemented": True}
