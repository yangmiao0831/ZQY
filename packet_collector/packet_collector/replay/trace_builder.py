"""Build flow-level replay traces from packet JSONL records.

This module converts packet-level JSONL records into a compact flow/event trace
for future behavior-level replay. It does not open sockets, call dumpcap,
call tshark, configure netem, or replay original pcap packets.
"""

from __future__ import annotations

import ipaddress
import json
import math
import time
from pathlib import Path
from typing import Any

from packet_collector.analyzers.common import as_float, iter_jsonl_records, non_empty, protocol_seen
from packet_collector.storage.json_writer import write_json


SUPPORTED_PROTOCOL_FILTERS = {"all", "tcp", "udp"}
BYTE_BASIS = "tcp_len_and_udp_payload_with_frame_fallback"


def _safe_int(value: object) -> int | None:
    """Convert a value to int when possible."""
    if value is None or value == "":
        return None
    try:
        return int(float(value))
    except (TypeError, ValueError):
        return None


def detect_protocol(record: dict[str, Any]) -> str | None:
    """Detect TCP or UDP from a packet record."""
    if protocol_seen(record, "tcp"):
        return "tcp"
    if protocol_seen(record, "udp"):
        return "udp"
    if any(non_empty(record.get(field)) for field in ["tcp_stream", "tcp_len", "tcp_flags"]):
        return "tcp"
    if non_empty(record.get("udp_length")):
        return "udp"
    return None


def get_direction(record: dict[str, Any], pi_ip: str | list[str] | set[str] | tuple[str, ...]) -> str | None:
    """Return packet direction relative to one or more Pi IP addresses."""
    pi_ips = {pi_ip} if isinstance(pi_ip, str) else set(pi_ip)
    if record.get("src_ip") in pi_ips:
        return "pi_to_peer"
    if record.get("dst_ip") in pi_ips:
        return "peer_to_pi"
    return None


def load_pi_ips_from_network_events(network_events_file: Path) -> list[str]:
    """Load unique IPv4 addresses observed in network_events.jsonl."""
    addresses: list[str] = []
    seen: set[str] = set()
    if not network_events_file.exists():
        raise ValueError(f"network events file not found: {network_events_file}")
    with network_events_file.open("r", encoding="utf-8") as source:
        for line in source:
            if not line.strip():
                continue
            try:
                record = json.loads(line)
            except json.JSONDecodeError:
                continue
            if not isinstance(record, dict):
                continue
            for key in ("ipv4", "new_ipv4"):
                value = record.get(key)
                if not isinstance(value, str) or value in seen:
                    continue
                try:
                    ipaddress.IPv4Address(value)
                except ipaddress.AddressValueError:
                    continue
                seen.add(value)
                addresses.append(value)
    if not addresses:
        raise ValueError("no IPv4 addresses found in network_events.jsonl; use --pi-ip or --pi-ip-list")
    return addresses


def get_payload_bytes(record: dict[str, Any], protocol: str) -> tuple[int, str | None]:
    """Return application-ish payload bytes and an optional warning."""
    if protocol == "tcp":
        tcp_len = _safe_int(record.get("tcp_len"))
        return max(tcp_len or 0, 0), None
    if protocol == "udp":
        udp_length = _safe_int(record.get("udp_length"))
        if udp_length is not None:
            return max(udp_length - 8, 0), None
        frame_len = _safe_int(record.get("frame_len"))
        return max(frame_len or 0, 0), "udp_length missing; used frame_len fallback"
    return 0, f"unsupported protocol for byte calculation: {protocol}"


def _endpoint(ip: object, port: object) -> str | None:
    """Build an endpoint string when IP and port are present."""
    numeric_port = _safe_int(port)
    if not ip or numeric_port is None:
        return None
    return f"{ip}:{numeric_port}"


def _canonical_endpoints(record: dict[str, Any]) -> tuple[str, str, str] | None:
    """Return canonical endpoint pair and its combined string."""
    src_endpoint = _endpoint(record.get("src_ip"), record.get("src_port"))
    dst_endpoint = _endpoint(record.get("dst_ip"), record.get("dst_port"))
    if src_endpoint is None or dst_endpoint is None:
        return None
    first, second = sorted([src_endpoint, dst_endpoint])
    return first, second, f"{first}-{second}"


def _new_flow(packet: dict[str, Any], instance_index: int) -> dict[str, Any]:
    """Create a flow accumulator from the first packet in a flow instance."""
    protocol = packet["protocol"]
    canonical = packet["canonical_endpoints"]
    flow_id = f"{protocol}_{canonical}_{instance_index}"
    return {
        "flow_id": flow_id,
        "protocol": protocol,
        "original_src_ip": packet["src_ip"],
        "original_dst_ip": packet["dst_ip"],
        "original_src_port": packet["src_port"],
        "original_dst_port": packet["dst_port"],
        "tcp_streams_observed": set(),
        "bytes_pi_to_peer": 0,
        "bytes_peer_to_pi": 0,
        "packet_count_pi_to_peer": 0,
        "packet_count_peer_to_pi": 0,
        "first_time_epoch": packet["time_epoch"],
        "last_time_epoch": packet["time_epoch"],
        "last_seen_time_epoch": packet["time_epoch"],
        "event_buckets": {},
    }


def _flow_role(bytes_pi_to_peer: int, bytes_peer_to_pi: int) -> str:
    """Classify flow directionality from byte counts."""
    if bytes_peer_to_pi > bytes_pi_to_peer * 2 and bytes_peer_to_pi > 0:
        return "download"
    if bytes_pi_to_peer > bytes_peer_to_pi * 2 and bytes_pi_to_peer > 0:
        return "upload"
    if bytes_pi_to_peer > 0 and bytes_peer_to_pi > 0:
        return "bidirectional"
    return "unknown"


def _finalize_flow(flow: dict[str, Any], base_time: float) -> dict[str, Any]:
    """Convert a flow accumulator to a JSON-serializable flow record."""
    events = sorted(flow["event_buckets"].values(), key=lambda event: (event["time_offset_sec"], event["direction"]))
    start_offset = flow["first_time_epoch"] - base_time
    end_offset = flow["last_time_epoch"] - base_time
    result: dict[str, Any] = {
        "flow_id": flow["flow_id"],
        "protocol": flow["protocol"],
        "original_src_ip": flow["original_src_ip"],
        "original_dst_ip": flow["original_dst_ip"],
        "original_src_port": flow["original_src_port"],
        "original_dst_port": flow["original_dst_port"],
        "role": _flow_role(flow["bytes_pi_to_peer"], flow["bytes_peer_to_pi"]),
        "start_offset_sec": round(start_offset, 6),
        "end_offset_sec": round(end_offset, 6),
        "duration_sec": round(max(end_offset - start_offset, 0.0), 6),
        "bytes_pi_to_peer": flow["bytes_pi_to_peer"],
        "bytes_peer_to_pi": flow["bytes_peer_to_pi"],
        "packet_count_pi_to_peer": flow["packet_count_pi_to_peer"],
        "packet_count_peer_to_pi": flow["packet_count_peer_to_pi"],
        "events": events,
    }
    if flow["protocol"] == "tcp":
        result["tcp_streams_observed"] = sorted(flow["tcp_streams_observed"])
    return result


def _extract_packets(
    packet_jsonl_files: list[Path],
    pi_ips: set[str],
    protocol_filter: str,
) -> tuple[list[dict[str, Any]], int, int, list[str]]:
    """Extract minimal TCP/UDP packet records for trace construction."""
    extracted: list[dict[str, Any]] = []
    invalid_record_count = 0
    skipped_record_count = 0
    warnings: list[str] = []
    warning_set: set[str] = set()

    for packet_jsonl in packet_jsonl_files:
        for record, invalid in iter_jsonl_records(packet_jsonl):
            if invalid or record is None:
                invalid_record_count += 1
                continue

            protocol = detect_protocol(record)
            if protocol is None or (protocol_filter != "all" and protocol != protocol_filter):
                skipped_record_count += 1
                continue

            direction = get_direction(record, pi_ips)
            time_epoch = as_float(record.get("time_epoch"))
            endpoints = _canonical_endpoints(record)
            if direction is None or time_epoch is None or endpoints is None:
                skipped_record_count += 1
                continue

            payload_bytes, warning = get_payload_bytes(record, protocol)
            if warning and warning not in warning_set:
                warnings.append(warning)
                warning_set.add(warning)

            _, _, canonical = endpoints
            extracted.append(
                {
                    "time_epoch": time_epoch,
                    "protocol": protocol,
                    "direction": direction,
                    "base_flow_key": f"{protocol}:{canonical}",
                    "canonical_endpoints": canonical,
                    "bytes": payload_bytes,
                    "src_ip": record.get("src_ip"),
                    "dst_ip": record.get("dst_ip"),
                    "src_port": _safe_int(record.get("src_port")),
                    "dst_port": _safe_int(record.get("dst_port")),
                    "tcp_stream": record.get("tcp_stream"),
                }
            )

    if not extracted:
        warnings.append("no tcp/udp records found")
    return extracted, invalid_record_count, skipped_record_count, warnings


def build_replay_trace(
    packet_jsonl_files: list[Path],
    output_file: Path,
    pi_ip: str | None = None,
    source_dir: Path | None = None,
    source_id: str | None = None,
    source_type: str | None = None,
    window_ms: int = 100,
    protocol_filter: str = "all",
    flow_idle_timeout_sec: float = 60.0,
    pi_ips: list[str] | None = None,
    pi_ip_source: str | None = None,
) -> Path:
    """Build replay_trace.json from one or more packet JSONL files."""
    if window_ms <= 0:
        raise ValueError("window_ms must be > 0")
    if protocol_filter not in SUPPORTED_PROTOCOL_FILTERS:
        raise ValueError(f"Unsupported protocol_filter: {protocol_filter}")

    resolved_pi_ips: list[str] = []
    for value in pi_ips or ([pi_ip] if pi_ip else []):
        if value and value not in resolved_pi_ips:
            resolved_pi_ips.append(value)
    if not resolved_pi_ips:
        raise ValueError("at least one Pi IP is required")

    packet_files = [Path(path) for path in packet_jsonl_files]
    extracted, invalid_record_count, skipped_record_count, warnings = _extract_packets(
        packet_files,
        set(resolved_pi_ips),
        protocol_filter,
    )
    extracted.sort(key=lambda packet: packet["time_epoch"])

    flows: list[dict[str, Any]] = []
    active_flows: dict[str, dict[str, Any]] = {}
    instance_counts: dict[str, int] = {}
    base_time = extracted[0]["time_epoch"] if extracted else None
    total_bytes = 0

    for packet in extracted:
        base_key = packet["base_flow_key"]
        active = active_flows.get(base_key)
        if active is None or packet["time_epoch"] - active["last_seen_time_epoch"] > flow_idle_timeout_sec:
            instance_index = instance_counts.get(base_key, 0)
            instance_counts[base_key] = instance_index + 1
            active = _new_flow(packet, instance_index)
            active_flows[base_key] = active
            flows.append(active)

        active["last_seen_time_epoch"] = packet["time_epoch"]
        active["last_time_epoch"] = packet["time_epoch"]
        if non_empty(packet.get("tcp_stream")):
            active["tcp_streams_observed"].add(str(packet["tcp_stream"]))

        direction = packet["direction"]
        payload_bytes = int(packet["bytes"])
        total_bytes += payload_bytes
        if direction == "pi_to_peer":
            active["bytes_pi_to_peer"] += payload_bytes
            active["packet_count_pi_to_peer"] += 1
        else:
            active["bytes_peer_to_pi"] += payload_bytes
            active["packet_count_peer_to_pi"] += 1

        assert base_time is not None
        time_offset_sec = packet["time_epoch"] - base_time
        window_index = math.floor((time_offset_sec * 1000) / window_ms)
        event_time = round(window_index * window_ms / 1000, 6)
        bucket_key = (event_time, direction, packet["protocol"])
        event = active["event_buckets"].setdefault(
            bucket_key,
            {
                "time_offset_sec": event_time,
                "direction": direction,
                "bytes": 0,
                "packet_count": 0,
                "original_protocol": packet["protocol"],
            },
        )
        event["bytes"] += payload_bytes
        event["packet_count"] += 1

    finalized_flows = [_finalize_flow(flow, base_time or 0.0) for flow in flows]
    duration_sec = max((flow["end_offset_sec"] for flow in finalized_flows), default=0.0)
    trace: dict[str, Any] = {
        "trace_type": "flow_replay_trace",
        "trace_version": 1,
        "source_type": source_type or "unknown",
        "source_id": source_id,
        "source_dir": str(source_dir) if source_dir is not None else None,
        "source_packets_jsonl": str(packet_files[0]) if len(packet_files) == 1 else None,
        "source_packet_jsonl_files": [str(path) for path in packet_files],
        "generated_at_epoch": time.time(),
        "pi_ip": resolved_pi_ips[0],
        "pi_ips": resolved_pi_ips,
        "pi_ip_source": pi_ip_source or ("explicit_list" if len(resolved_pi_ips) > 1 else "explicit"),
        "window_ms": window_ms,
        "protocol_filter": protocol_filter,
        "flow_idle_timeout_sec": flow_idle_timeout_sec,
        "duration_sec": duration_sec,
        "flow_count": len(finalized_flows),
        "total_bytes": total_bytes,
        "byte_basis": BYTE_BASIS,
        "invalid_record_count": invalid_record_count,
        "skipped_record_count": skipped_record_count,
        "generation_warnings": warnings,
        "flows": finalized_flows,
    }
    return write_json(output_file, trace)
