"""TLS application-layer metadata summary analyzer.

TLS summary is metadata-only. It does not decrypt HTTPS and cannot expose URL
paths, headers, or body contents.
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


def _is_tls_record(record: dict[str, object]) -> bool:
    """Return True when a mixed JSONL record belongs to TLS/HTTPS metadata."""
    return protocol_seen(record, "tls") or protocol_seen(record, "ssl") or any_field_non_empty(
        record,
        ["tls_handshake_type", "tls_sni", "tls_record_version", "tls_handshake_version"],
    )


def analyze_tls_jsonl(packet_jsonl: Path, output_file: Path) -> Path:
    """Analyze TLS packet JSONL and write `tls_summary.json`."""
    packet_count = 0
    invalid_record_count = 0
    first_time_epoch: float | None = None
    last_time_epoch: float | None = None
    total_frame_bytes = 0

    handshake_type_counts: Counter[str] = Counter()
    sni_counts: Counter[str] = Counter()
    record_version_counts: Counter[str] = Counter()
    handshake_version_counts: Counter[str] = Counter()
    src_ip_counts: Counter[str] = Counter()
    dst_ip_counts: Counter[str] = Counter()
    src_port_counts: Counter[str] = Counter()
    dst_port_counts: Counter[str] = Counter()
    tcp_stream_counts: Counter[str] = Counter()

    for record, invalid in iter_jsonl_records(packet_jsonl):
        if invalid or record is None:
            invalid_record_count += 1
            continue
        if not _is_tls_record(record):
            continue

        packet_count += 1
        time_epoch = as_float(record.get("time_epoch"))
        if time_epoch is not None:
            if first_time_epoch is None:
                first_time_epoch = time_epoch
            last_time_epoch = time_epoch
        total_frame_bytes += as_int(record.get("frame_len"))

        count_value(handshake_type_counts, record.get("tls_handshake_type"))
        count_value(sni_counts, record.get("tls_sni"))
        count_value(record_version_counts, record.get("tls_record_version"))
        count_value(handshake_version_counts, record.get("tls_handshake_version"))
        count_value(src_ip_counts, record.get("src_ip"))
        count_value(dst_ip_counts, record.get("dst_ip"))
        count_value(src_port_counts, record.get("src_port"))
        count_value(dst_port_counts, record.get("dst_port"))
        count_value(tcp_stream_counts, record.get("tcp_stream"))

    summary: dict[str, object] = {
        "summary_type": "tls",
        "packet_count": packet_count,
        "invalid_record_count": invalid_record_count,
        "first_time_epoch": first_time_epoch,
        "last_time_epoch": last_time_epoch,
        "duration_sec": duration(first_time_epoch, last_time_epoch),
        "total_frame_bytes": total_frame_bytes,
        "handshake_type_counts": counter_dict(handshake_type_counts),
        "sni_counts": counter_dict(sni_counts),
        "record_version_counts": counter_dict(record_version_counts),
        "handshake_version_counts": counter_dict(handshake_version_counts),
        "src_ip_counts": counter_dict(src_ip_counts),
        "dst_ip_counts": counter_dict(dst_ip_counts),
        "src_port_counts": counter_dict(src_port_counts),
        "dst_port_counts": counter_dict(dst_port_counts),
        "tcp_stream_counts": counter_dict(tcp_stream_counts),
        "https_visibility_note": "TLS metadata only; URL path, headers, and body are not visible without decryption.",
    }
    return write_json(output_file, summary)


def analyze_tls_placeholder(packet_jsonl: Path) -> dict[str, object]:
    """Backward-compatible placeholder wrapper."""
    return {"packet_jsonl": str(packet_jsonl), "implemented": True}
