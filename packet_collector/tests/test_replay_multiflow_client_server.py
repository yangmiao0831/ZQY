"""Localhost integration test for TCP multi-flow replay client/server."""

from __future__ import annotations

import json
import socket
import threading
import time
from pathlib import Path

from packet_collector.replay.replay_client import run_replay_client
from packet_collector.replay.replay_server import run_replay_server


def _free_base_port() -> int:
    """Return a base port where base and base+1 are currently available."""
    for _ in range(50):
        with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as first:
            first.bind(("127.0.0.1", 0))
            base_port = int(first.getsockname()[1])
        if base_port >= 65000:
            continue
        with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as second:
            try:
                second.bind(("127.0.0.1", base_port + 1))
            except OSError:
                continue
        return base_port
    raise RuntimeError("could not find two adjacent free ports")


def _write_trace(path: Path) -> Path:
    """Write a two-flow TCP replay trace."""
    trace = {
        "trace_type": "flow_replay_trace",
        "flows": [
            {
                "flow_id": "tcp_flow_download",
                "protocol": "tcp",
                "role": "download",
                "bytes_pi_to_peer": 50,
                "bytes_peer_to_pi": 100,
                "events": [
                    {"time_offset_sec": 0.0, "direction": "peer_to_pi", "bytes": 100, "packet_count": 1, "original_protocol": "tcp"},
                    {"time_offset_sec": 0.01, "direction": "pi_to_peer", "bytes": 50, "packet_count": 1, "original_protocol": "tcp"},
                ],
            },
            {
                "flow_id": "tcp_flow_bidirectional",
                "protocol": "tcp",
                "role": "bidirectional",
                "bytes_pi_to_peer": 20,
                "bytes_peer_to_pi": 120,
                "events": [
                    {"time_offset_sec": 0.0, "direction": "peer_to_pi", "bytes": 80, "packet_count": 1, "original_protocol": "tcp"},
                    {"time_offset_sec": 0.01, "direction": "pi_to_peer", "bytes": 20, "packet_count": 1, "original_protocol": "tcp"},
                    {"time_offset_sec": 0.02, "direction": "peer_to_pi", "bytes": 40, "packet_count": 1, "original_protocol": "tcp"},
                ],
            },
        ],
    }
    path.write_text(json.dumps(trace), encoding="utf-8")
    return path


def test_replay_multiflow_client_server_localhost(tmp_path: Path) -> None:
    """Server and client exchange bytes across two TCP flows."""
    trace_file = _write_trace(tmp_path / "replay_trace.json")
    base_port = _free_base_port()
    server_output = tmp_path / "replay_result_server.json"
    client_output = tmp_path / "replay_result_client.json"

    server_thread = threading.Thread(
        target=run_replay_server,
        kwargs={
            "trace_file": trace_file,
            "host": "127.0.0.1",
            "port": base_port,
            "max_flows": 2,
            "output_file": server_output,
            "timeout": 5.0,
        },
        daemon=True,
    )
    server_thread.start()
    time.sleep(0.1)

    run_replay_client(
        trace_file=trace_file,
        server="127.0.0.1",
        port=base_port,
        max_flows=2,
        output_file=client_output,
        timeout=5.0,
    )
    server_thread.join(timeout=5.0)

    server_result = json.loads(server_output.read_text(encoding="utf-8"))
    client_result = json.loads(client_output.read_text(encoding="utf-8"))
    assert server_result["success"] is True
    assert client_result["success"] is True
    assert server_result["selected_flow_count"] == 2
    assert client_result["selected_flow_count"] == 2
    assert server_result["summary"]["success_flow_count"] == 2
    assert client_result["summary"]["success_flow_count"] == 2
    assert server_result["summary"]["bytes_sent"] == client_result["summary"]["bytes_received"] == 220
    assert client_result["summary"]["bytes_sent"] == server_result["summary"]["bytes_received"] == 70
