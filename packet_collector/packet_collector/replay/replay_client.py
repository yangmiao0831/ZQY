"""TCP/UDP flow replay client.

The client runs on the Raspberry Pi side. It connects or sends to one server
port per selected flow and exchanges dummy bytes according to replay_trace.json.
"""

from __future__ import annotations

import socket
import threading
import time
from pathlib import Path
from typing import Any

from packet_collector.replay.replay_protocol import (
    assign_flow_ports,
    compute_event_lag_ms,
    load_replay_trace,
    normalize_flow_events,
    recv_exact,
    recv_line,
    recv_udp_bytes,
    select_flows,
    send_exact,
    send_line,
    send_udp_bytes,
    summarize_flow_results,
    summarize_replay_events,
)
from packet_collector.storage.json_writer import write_json


def _execute_client_events(sock: socket.socket, events: list[dict[str, Any]], start_monotonic: float) -> list[dict[str, Any]]:
    """Execute client-side send/receive actions for replay events."""
    results: list[dict[str, Any]] = []
    for event in events:
        target_time = start_monotonic + float(event.get("time_offset_sec") or 0.0)
        now = time.monotonic()
        if now < target_time:
            time.sleep(target_time - now)
        actual_time = time.monotonic()
        expected_bytes = int(event.get("bytes") or 0)
        direction = str(event.get("direction"))
        sent = 0
        received = 0
        if expected_bytes > 0 and direction == "pi_to_peer":
            sent = send_exact(sock, expected_bytes)
        elif expected_bytes > 0 and direction == "peer_to_pi":
            received = recv_exact(sock, expected_bytes)
        results.append(
            {
                "time_offset_sec": event.get("time_offset_sec"),
                "direction": direction,
                "expected_bytes": expected_bytes,
                "bytes_sent": sent,
                "bytes_received": received,
                "lag_ms": compute_event_lag_ms(target_time, actual_time),
                "short_read": direction == "peer_to_pi" and received < expected_bytes,
            }
        )
    return results


def _execute_udp_client_events(
    sock: socket.socket,
    server_addr: tuple[str, int],
    events: list[dict[str, Any]],
    start_monotonic: float,
    timeout: float,
    max_datagram_size: int,
) -> list[dict[str, Any]]:
    """Execute client-side UDP send/receive actions for replay events."""
    results: list[dict[str, Any]] = []
    for event in events:
        target_time = start_monotonic + float(event.get("time_offset_sec") or 0.0)
        now = time.monotonic()
        if now < target_time:
            time.sleep(target_time - now)
        actual_time = time.monotonic()
        expected_bytes = int(event.get("bytes") or 0)
        direction = str(event.get("direction"))
        sent = 0
        received = 0
        if expected_bytes > 0 and direction == "pi_to_peer":
            sent = send_udp_bytes(sock, server_addr, expected_bytes, max_datagram_size=max_datagram_size)
        elif expected_bytes > 0 and direction == "peer_to_pi":
            received = recv_udp_bytes(sock, expected_bytes, timeout=timeout)
        results.append(
            {
                "time_offset_sec": event.get("time_offset_sec"),
                "direction": direction,
                "expected_bytes": expected_bytes,
                "bytes_sent": sent,
                "bytes_received": received,
                "lag_ms": compute_event_lag_ms(target_time, actual_time),
                "short_read": direction == "peer_to_pi" and received < expected_bytes,
            }
        )
    return results


def _connect_with_retry(server: str, port: int, timeout: float) -> socket.socket:
    """Connect to a server port, retrying briefly while server threads start."""
    deadline = time.monotonic() + timeout
    last_error: OSError | None = None
    while time.monotonic() < deadline:
        sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        sock.settimeout(timeout)
        try:
            sock.connect((server, port))
            return sock
        except OSError as exc:
            last_error = exc
            sock.close()
            time.sleep(0.02)
    raise RuntimeError(f"failed to connect to {server}:{port}: {last_error}")


def client_handle_flow(flow: dict[str, Any], server: str, port: int, timeout: float) -> dict[str, Any]:
    """Connect to and execute one TCP replay flow."""
    start_epoch = time.time()
    result: dict[str, Any] = {
        "flow_id": flow.get("flow_id"),
        "protocol": "tcp",
        "port": port,
        "role": flow.get("role"),
        "success": False,
        "event_count": 0,
        "late_event_count": 0,
        "max_lag_ms": 0.0,
        "avg_lag_ms": 0.0,
        "bytes_sent": 0,
        "bytes_received": 0,
        "short_read_count": 0,
        "start_time_epoch": start_epoch,
        "end_time_epoch": None,
        "duration_ms": None,
        "error": None,
    }
    sock: socket.socket | None = None
    try:
        events = normalize_flow_events(flow)
        sock = _connect_with_retry(server, port, timeout)
        send_line(sock, f"HELLO {flow.get('flow_id')}")
        ready = recv_line(sock)
        expected_ready = f"READY {flow.get('flow_id')}"
        if ready != expected_ready:
            raise RuntimeError(f"unexpected server ready: {ready}")
        send_line(sock, "START")

        result.update(summarize_replay_events(_execute_client_events(sock, events, time.monotonic())))
        result["success"] = True
    except KeyboardInterrupt:
        raise
    except Exception as exc:
        result["error"] = str(exc)
    finally:
        if sock is not None:
            sock.close()
        end_epoch = time.time()
        result["end_time_epoch"] = end_epoch
        result["duration_ms"] = (end_epoch - start_epoch) * 1000.0
    return result


def client_handle_udp_flow(
    flow: dict[str, Any],
    server: str,
    port: int,
    timeout: float,
    max_datagram_size: int = 1200,
) -> dict[str, Any]:
    """Execute one UDP replay flow from the client side."""
    start_epoch = time.time()
    result: dict[str, Any] = {
        "flow_id": flow.get("flow_id"),
        "protocol": "udp",
        "port": port,
        "role": flow.get("role"),
        "success": False,
        "event_count": 0,
        "late_event_count": 0,
        "max_lag_ms": 0.0,
        "avg_lag_ms": 0.0,
        "bytes_sent": 0,
        "bytes_received": 0,
        "short_read_count": 0,
        "start_time_epoch": start_epoch,
        "end_time_epoch": None,
        "duration_ms": None,
        "error": None,
    }
    sock: socket.socket | None = None
    try:
        events = normalize_flow_events(flow, protocol="udp")
        server_addr = (server, port)
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        sock.settimeout(timeout)
        sock.sendto(f"HELLO {flow.get('flow_id')}\n".encode("utf-8"), server_addr)
        ready_bytes, ready_addr = sock.recvfrom(4096)
        if ready_addr[0] != server:
            raise RuntimeError("unexpected UDP READY sender")
        ready = ready_bytes.decode("utf-8").strip()
        expected_ready = f"READY {flow.get('flow_id')}"
        if ready != expected_ready:
            raise RuntimeError(f"unexpected server ready: {ready}")
        sock.sendto(b"START\n", server_addr)

        result.update(
            summarize_replay_events(
                _execute_udp_client_events(
                    sock,
                    server_addr,
                    events,
                    time.monotonic(),
                    timeout=timeout,
                    max_datagram_size=max_datagram_size,
                )
            )
        )
        result["success"] = True
    except KeyboardInterrupt:
        raise
    except Exception as exc:
        result["error"] = str(exc)
    finally:
        if sock is not None:
            sock.close()
        end_epoch = time.time()
        result["end_time_epoch"] = end_epoch
        result["duration_ms"] = (end_epoch - start_epoch) * 1000.0
    return result


def _run_flow_threads(flows: list[dict[str, Any]], server: str, ports: dict[str, int], timeout: float) -> list[dict[str, Any]]:
    """Start one client thread per flow and return flow results."""
    results: list[dict[str, Any]] = []
    lock = threading.Lock()

    def worker(flow: dict[str, Any]) -> None:
        flow_result = client_handle_flow(flow, server, ports[str(flow.get("flow_id"))], timeout)
        with lock:
            results.append(flow_result)

    threads = [threading.Thread(target=worker, args=(flow,), daemon=True) for flow in flows]
    for thread in threads:
        thread.start()
    for thread in threads:
        thread.join()
    return sorted(results, key=lambda result: int(result.get("port") or 0))


def _run_udp_flow_threads(
    flows: list[dict[str, Any]],
    server: str,
    ports: dict[str, int],
    timeout: float,
    max_datagram_size: int,
) -> list[dict[str, Any]]:
    """Start one UDP client thread per flow and return flow results."""
    results: list[dict[str, Any]] = []
    lock = threading.Lock()

    def worker(flow: dict[str, Any]) -> None:
        flow_result = client_handle_udp_flow(
            flow,
            server,
            ports[str(flow.get("flow_id"))],
            timeout,
            max_datagram_size=max_datagram_size,
        )
        with lock:
            results.append(flow_result)

    threads = [threading.Thread(target=worker, args=(flow,), daemon=True) for flow in flows]
    for thread in threads:
        thread.start()
    for thread in threads:
        thread.join()
    return sorted(results, key=lambda result: int(result.get("port") or 0))


def run_replay_client(
    trace_file: Path,
    server: str,
    port: int = 9000,
    flow_id: str | None = None,
    role: str | None = None,
    max_flows: int | None = 1,
    protocol: str = "tcp",
    max_datagram_size: int = 1200,
    output_file: Path | None = None,
    timeout: float = 30.0,
) -> Path:
    """Run TCP or UDP replay client for one or more selected flows."""
    output = output_file or trace_file.parent / "replay_result_client.json"
    start_epoch = time.time()
    result: dict[str, Any] = {
        "replay_type": f"{protocol}_multi_flow_client",
        "success": False,
        "trace_file": str(trace_file),
        "protocol": protocol,
        "server": server,
        "base_port": port,
        "port": port,
        "max_flows": max_flows,
        "max_datagram_size": max_datagram_size if protocol == "udp" else None,
        "selected_flow_count": 0,
        "start_time_epoch": start_epoch,
        "end_time_epoch": None,
        "duration_ms": None,
        "summary": {},
        "flows": [],
        "event_count": 0,
        "late_event_count": 0,
        "max_lag_ms": 0.0,
        "avg_lag_ms": 0.0,
        "bytes_sent": 0,
        "bytes_received": 0,
        "short_read_count": 0,
        "error": None,
    }
    try:
        if protocol == "all":
            raise NotImplementedError("protocol=all is not implemented yet")
        if protocol not in {"tcp", "udp"}:
            raise ValueError(f"unsupported replay protocol: {protocol}")
        trace = load_replay_trace(trace_file)
        flows = select_flows(trace, protocol=protocol, flow_id=flow_id, role=role, max_flows=max_flows)
        ports = assign_flow_ports(flows, port)
        if protocol == "udp":
            flow_results = _run_udp_flow_threads(flows, server, ports, timeout, max_datagram_size)
        else:
            flow_results = _run_flow_threads(flows, server, ports, timeout)
        summary = summarize_flow_results(flow_results)
        result.update(
            {
                "selected_flow_count": len(flows),
                "summary": summary,
                "flows": flow_results,
                "success": summary["failed_flow_count"] == 0,
                "event_count": summary["event_count"],
                "late_event_count": summary["late_event_count"],
                "max_lag_ms": summary["max_lag_ms"],
                "avg_lag_ms": summary["avg_lag_ms"],
                "bytes_sent": summary["bytes_sent"],
                "bytes_received": summary["bytes_received"],
                "short_read_count": summary["short_read_count"],
            }
        )
    except KeyboardInterrupt:
        raise
    except Exception as exc:
        result["error"] = str(exc)
    finally:
        end_epoch = time.time()
        result["end_time_epoch"] = end_epoch
        result["duration_ms"] = (end_epoch - start_epoch) * 1000.0
        write_json(output, result)
    return output
