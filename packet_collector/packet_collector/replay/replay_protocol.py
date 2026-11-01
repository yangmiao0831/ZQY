"""Shared helpers for TCP/UDP flow replay.

These helpers are intentionally small and testable. They do not open sockets
except where called by replay client/server modules.
"""

from __future__ import annotations

import json
import socket
import time
from pathlib import Path
from typing import Any


def load_replay_trace(trace_file: Path) -> dict[str, Any]:
    """Load a replay trace JSON object."""
    data = json.loads(trace_file.read_text(encoding="utf-8"))
    if not isinstance(data, dict):
        raise ValueError("replay trace root must be an object")
    return data


def _flow_total_bytes(flow: dict[str, Any]) -> int:
    """Return total directional bytes for a flow."""
    return int(flow.get("bytes_pi_to_peer") or 0) + int(flow.get("bytes_peer_to_pi") or 0)


def select_flows(
    trace: dict[str, Any],
    protocol: str = "tcp",
    flow_id: str | None = None,
    role: str | None = None,
    max_flows: int | None = 1,
) -> list[dict[str, Any]]:
    """Select one or more flows for one replay protocol."""
    if protocol not in {"tcp", "udp"}:
        raise ValueError(f"unsupported replay protocol: {protocol}")
    flows = [flow for flow in trace.get("flows", []) if isinstance(flow, dict) and flow.get("protocol") == protocol]
    if flow_id is not None:
        for flow in flows:
            if flow.get("flow_id") == flow_id:
                return [flow]
        raise ValueError(f"{protocol.upper()} flow not found: {flow_id}")
    if role is not None:
        flows = [flow for flow in flows if flow.get("role") == role]
    if not flows:
        raise ValueError(f"no {protocol.upper()} flow found in replay trace")
    flows = sorted(flows, key=_flow_total_bytes, reverse=True)
    if max_flows is not None:
        if max_flows <= 0:
            raise ValueError("max_flows must be positive or None")
        flows = flows[:max_flows]
    return flows


def select_tcp_flows(
    trace: dict[str, Any],
    flow_id: str | None = None,
    role: str | None = None,
    max_flows: int | None = None,
) -> list[dict[str, Any]]:
    """Select one or more TCP flows from a replay trace."""
    return select_flows(trace, protocol="tcp", flow_id=flow_id, role=role, max_flows=max_flows)


def select_tcp_flow(trace: dict[str, Any], flow_id: str | None = None, role: str | None = None) -> dict[str, Any]:
    """Select one TCP flow from a replay trace."""
    return select_tcp_flows(trace, flow_id=flow_id, role=role, max_flows=1)[0]


def assign_flow_ports(flows: list[dict[str, Any]], base_port: int) -> dict[str, int]:
    """Assign one TCP port per flow in the provided order."""
    ports: dict[str, int] = {}
    for index, flow in enumerate(flows):
        flow_id = str(flow.get("flow_id"))
        ports[flow_id] = base_port + index
    return ports


def normalize_flow_events(flow: dict[str, Any], protocol: str = "tcp") -> list[dict[str, Any]]:
    """Return protocol-specific events sorted by time offset."""
    events = []
    for event in flow.get("events", []):
        if not isinstance(event, dict):
            continue
        if event.get("original_protocol") != protocol:
            continue
        events.append(dict(event))
    return sorted(events, key=lambda event: float(event.get("time_offset_sec") or 0.0))


def make_dummy_payload(size: int) -> bytes:
    """Return a fixed dummy payload of the requested size."""
    if size <= 0:
        return b""
    return b"X" * size


def split_udp_datagrams(total_bytes: int, max_datagram_size: int = 1200) -> list[int]:
    """Split UDP payload bytes into datagram sizes below the requested limit."""
    if total_bytes <= 0:
        return []
    if max_datagram_size <= 0:
        raise ValueError("max_datagram_size must be positive")
    sizes: list[int] = []
    remaining = total_bytes
    while remaining > 0:
        datagram_size = min(remaining, max_datagram_size)
        sizes.append(datagram_size)
        remaining -= datagram_size
    return sizes


def compute_event_lag_ms(target_time: float, actual_time: float) -> float:
    """Return positive scheduling lag in milliseconds."""
    return max(0.0, actual_time - target_time) * 1000.0


def summarize_replay_events(results: list[dict[str, Any]]) -> dict[str, object]:
    """Summarize replay event execution results."""
    lag_values = [float(result.get("lag_ms") or 0.0) for result in results]
    late_values = [lag for lag in lag_values if lag > 0.0]
    bytes_sent = sum(int(result.get("bytes_sent") or 0) for result in results)
    bytes_received = sum(int(result.get("bytes_received") or 0) for result in results)
    short_read_count = sum(1 for result in results if result.get("short_read"))
    return {
        "event_count": len(results),
        "late_event_count": len(late_values),
        "max_lag_ms": max(lag_values) if lag_values else 0.0,
        "avg_lag_ms": sum(lag_values) / len(lag_values) if lag_values else 0.0,
        "bytes_sent": bytes_sent,
        "bytes_received": bytes_received,
        "short_read_count": short_read_count,
    }


def summarize_flow_results(flow_results: list[dict[str, Any]]) -> dict[str, object]:
    """Summarize per-flow replay results."""
    success_flow_count = sum(1 for result in flow_results if result.get("success"))
    failed_flow_count = len(flow_results) - success_flow_count
    event_count = sum(int(result.get("event_count") or 0) for result in flow_results)
    late_event_count = sum(int(result.get("late_event_count") or 0) for result in flow_results)
    max_lag_ms = max((float(result.get("max_lag_ms") or 0.0) for result in flow_results), default=0.0)
    bytes_sent = sum(int(result.get("bytes_sent") or 0) for result in flow_results)
    bytes_received = sum(int(result.get("bytes_received") or 0) for result in flow_results)
    short_read_count = sum(int(result.get("short_read_count") or 0) for result in flow_results)
    errors = [str(result.get("error")) for result in flow_results if result.get("error")]
    weighted_lag_total = sum(float(result.get("avg_lag_ms") or 0.0) * int(result.get("event_count") or 0) for result in flow_results)
    avg_lag_ms = weighted_lag_total / event_count if event_count else 0.0
    return {
        "flow_count": len(flow_results),
        "success_flow_count": success_flow_count,
        "failed_flow_count": failed_flow_count,
        "event_count": event_count,
        "late_event_count": late_event_count,
        "max_lag_ms": max_lag_ms,
        "avg_lag_ms": avg_lag_ms,
        "bytes_sent": bytes_sent,
        "bytes_received": bytes_received,
        "short_read_count": short_read_count,
        "errors": errors,
    }


def send_exact(sock: socket.socket, total_bytes: int, chunk_size: int = 65536) -> int:
    """Send exactly total_bytes dummy bytes unless socket errors occur."""
    remaining = max(total_bytes, 0)
    sent = 0
    while remaining > 0:
        chunk_len = min(remaining, chunk_size)
        sock.sendall(make_dummy_payload(chunk_len))
        sent += chunk_len
        remaining -= chunk_len
    return sent


def recv_exact(sock: socket.socket, total_bytes: int, chunk_size: int = 65536) -> int:
    """Receive up to total_bytes bytes, stopping if the connection closes."""
    remaining = max(total_bytes, 0)
    received = 0
    while remaining > 0:
        chunk = sock.recv(min(remaining, chunk_size))
        if not chunk:
            break
        received += len(chunk)
        remaining -= len(chunk)
    return received


def send_udp_bytes(
    sock: socket.socket,
    addr: tuple[str, int],
    total_bytes: int,
    max_datagram_size: int = 1200,
) -> int:
    """Send UDP dummy bytes as one or more datagrams."""
    sent = 0
    for size in split_udp_datagrams(total_bytes, max_datagram_size=max_datagram_size):
        sent += sock.sendto(make_dummy_payload(size), addr)
    return sent


def recv_udp_bytes(sock: socket.socket, total_bytes: int, timeout: float) -> int:
    """Receive UDP datagrams until enough bytes arrive or timeout expires."""
    if total_bytes <= 0:
        return 0
    end_time = time.monotonic() + timeout
    received = 0
    while received < total_bytes:
        remaining_time = end_time - time.monotonic()
        if remaining_time <= 0:
            break
        sock.settimeout(remaining_time)
        try:
            data, _ = sock.recvfrom(min(max(total_bytes - received, 1), 65535))
        except socket.timeout:
            break
        if not data:
            break
        received += len(data)
    return received


def recv_line(sock: socket.socket) -> str:
    """Receive one newline-terminated UTF-8 control line."""
    chunks: list[bytes] = []
    while True:
        chunk = sock.recv(1)
        if not chunk:
            break
        if chunk == b"\n":
            break
        chunks.append(chunk)
    return b"".join(chunks).decode("utf-8")


def send_line(sock: socket.socket, line: str) -> None:
    """Send one newline-terminated UTF-8 control line."""
    sock.sendall((line.rstrip("\n") + "\n").encode("utf-8"))
