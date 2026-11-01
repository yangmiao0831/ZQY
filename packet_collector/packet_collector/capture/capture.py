"""High-level packet capture workflow.

Step 2 implements the real capture loop: create a task directory, build a BPF
filter, build and optionally execute dumpcap, copy pcapng artifacts into the
final task directory, and update `task_meta.json`. This module does not call
tshark, create JSONL, or analyze packets.
"""

from __future__ import annotations

import re
from pathlib import Path

from packet_collector.capture.dumpcap_runner import (
    build_dumpcap_command,
    ensure_tmp_capture_dir,
    run_dumpcap,
)
from packet_collector.capture.filters import build_capture_filter
from packet_collector.models import CaptureTask
from packet_collector.storage.file_manager import copy_files_to_dir, find_matching_files
from packet_collector.task_manager import create_task_dir, create_task_id, update_task_meta, write_task_meta
from packet_collector.utils import utc_timestamp


def _safe_name(value: str) -> str:
    """Return a filesystem-friendly name fragment."""
    return re.sub(r"[^A-Za-z0-9_.-]+", "_", value).replace(".", "_")


def _build_capture_filename(
    task_id: str,
    packet_type: str,
    direction: str,
    pi_ip: str | None,
    peer_ip: str | None,
    capture_mode: str,
) -> str:
    """Build the planned temporary capture filename."""
    if capture_mode == "iface_only":
        return f"{task_id}_{packet_type}_iface_only.pcapng"
    if capture_mode == "peer_only":
        return f"{task_id}_{packet_type}_peer_only_{_safe_name(peer_ip or 'unknown')}.pcapng"
    pi_safe = _safe_name(pi_ip or "unknown")
    peer_safe = _safe_name(peer_ip or "unknown")
    if direction == "in":
        flow = f"{peer_safe}_to_{pi_safe}"
    elif direction == "out":
        flow = f"{pi_safe}_to_{peer_safe}"
    else:
        flow = f"{pi_safe}_{peer_safe}"
    return f"{task_id}_{packet_type}_{direction}_{flow}.pcapng"


def _path_list(paths: list[Path]) -> list[str]:
    """Convert paths to strings for JSON metadata."""
    return [str(path) for path in paths]


def run_capture_task(
    packet_type: str,
    pi_ip: str | None,
    peer_ip: str | None,
    direction: str,
    iface: str,
    final_base_dir: Path,
    tmp_capture_dir: Path,
    file_size_kb: int,
    max_files: int,
    port: int | None = None,
    duration: int | None = None,
    scene: str | None = None,
    execute: bool = True,
    capture_mode: str = "two_host",
) -> CaptureTask:
    """Run or plan one packet capture task."""
    capture_filter = build_capture_filter(
        packet_type=packet_type,
        pi_ip=pi_ip,
        peer_ip=peer_ip,
        direction=direction,
        port=port,
        capture_mode=capture_mode,
    )
    task_id = create_task_id()
    task_dir = create_task_dir(final_base_dir, task_id)

    tmp_output_file = tmp_capture_dir / _build_capture_filename(
        task_id,
        packet_type,
        direction,
        pi_ip,
        peer_ip,
        capture_mode,
    )
    command = build_dumpcap_command(
        iface=iface,
        capture_filter=capture_filter,
        output_file=tmp_output_file,
        file_size_kb=file_size_kb,
        max_files=max_files,
        duration=duration,
    )

    start_time = utc_timestamp()
    initial_status = "running" if execute else "planned"
    metadata: dict[str, object] = {
        "task_id": task_id,
        "packet_type": packet_type,
        "capture_mode": capture_mode,
        "pi_ip": pi_ip,
        "peer_ip": peer_ip,
        "direction": direction,
        "iface": iface,
        "port": port,
        "duration": duration,
        "scene": scene,
        "capture_filter": capture_filter,
        "tmp_capture_dir": str(tmp_capture_dir),
        "final_task_dir": str(task_dir),
        "tmp_output_file": str(tmp_output_file),
        "file_size_kb": file_size_kb,
        "max_files": max_files,
        "dumpcap_command": command,
        "status": initial_status,
        "start_time": start_time,
        "end_time": None,
        "returncode": None,
        "pcap_files": [],
        "tmp_pcap_files": [],
    }
    write_task_meta(task_dir, metadata)

    task = CaptureTask(
        task_id=task_id,
        packet_type=packet_type,
        pi_ip=pi_ip,
        peer_ip=peer_ip,
        direction=direction,
        iface=iface,
        capture_filter=capture_filter,
        task_dir=task_dir,
        tmp_output_file=tmp_output_file,
        pcap_files=[],
        status=initial_status,
    )

    if not execute:
        return task

    ensure_tmp_capture_dir(tmp_capture_dir)
    try:
        returncode = run_dumpcap(command)
    except RuntimeError as exc:
        update_task_meta(
            task_dir,
            {
                "status": "failed",
                "end_time": utc_timestamp(),
                "error": str(exc),
            },
        )
        task.status = "failed"
        raise

    tmp_pcap_files = find_matching_files(tmp_capture_dir, tmp_output_file.stem, ".pcapng")
    final_pcap_files = copy_files_to_dir(tmp_pcap_files, task_dir)
    update_task_meta(
        task_dir,
        {
            "status": "completed",
            "end_time": utc_timestamp(),
            "returncode": returncode,
            "pcap_files": _path_list(final_pcap_files),
            "tmp_pcap_files": _path_list(tmp_pcap_files),
        },
    )

    task.status = "completed"
    task.pcap_files = final_pcap_files
    return task
