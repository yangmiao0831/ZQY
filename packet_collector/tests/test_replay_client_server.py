"""Localhost integration test for TCP single-flow replay client/server."""

from __future__ import annotations

import json
import socket
import threading
import time
from pathlib import Path

from packet_collector.replay.replay_client import run_replay_client
from packet_collector.replay.replay_server import run_replay_server


def _free_port() -> int:
    """Return a currently free localhost port."""
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
        sock.bind(("127.0.0.1", 0))
        return int(sock.getsockname()[1])


def _write_trace(path: Path) -> Path:
    """Write a small TCP single-flow replay trace."""
    trace = {
        "trace_type": "flow_replay_trace",
        "flows": [
            {
                "flow_id": "tcp_test_0",
                "protocol": "tcp",
                "role": "download",
                "bytes_pi_to_peer": 50,
                "bytes_peer_to_pi": 300,
                "events": [
                    {"time_offset_sec": 0.0, "direction": "peer_to_pi", "bytes": 100, "packet_count": 1, "original_protocol": "tcp"},
                    {"time_offset_sec": 0.01, "direction": "pi_to_peer", "bytes": 50, "packet_count": 1, "original_protocol": "tcp"},
                    {"time_offset_sec": 0.02, "direction": "peer_to_pi", "bytes": 200, "packet_count": 1, "original_protocol": "tcp"},
                ],
            }
        ],
    }
    path.write_text(json.dumps(trace), encoding="utf-8")
    return path


def test_replay_client_server_localhost(tmp_path: Path) -> None:
    """Server and client exchange bytes according to one TCP replay flow."""
    trace_file = _write_trace(tmp_path / "replay_trace.json")
    port = _free_port()
    server_output = tmp_path / "replay_result_server.json"
    client_output = tmp_path / "replay_result_client.json"

    server_thread = threading.Thread(
        target=run_replay_server,
        kwargs={
            "trace_file": trace_file,
            "host": "127.0.0.1",
            "port": port,
            "role": "download",
            "output_file": server_output,
            "timeout": 5.0,
        },
        daemon=True,
    )
    server_thread.start()
    time.sleep(0.05)

    run_replay_client(
        trace_file=trace_file,
        server="127.0.0.1",
        port=port,
        role="download",
        output_file=client_output,
        timeout=5.0,
    )
    server_thread.join(timeout=5.0)

    server_result = json.loads(server_output.read_text(encoding="utf-8"))
    client_result = json.loads(client_output.read_text(encoding="utf-8"))
    assert server_result["success"] is True
    assert client_result["success"] is True
    assert server_result["bytes_sent"] == client_result["bytes_received"] == 300
    assert client_result["bytes_sent"] == server_result["bytes_received"] == 50
    assert server_result["short_read_count"] == 0
    assert client_result["short_read_count"] == 0
