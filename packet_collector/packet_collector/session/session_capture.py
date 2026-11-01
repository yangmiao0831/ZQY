"""Long-running session capture workflow.

This module captures one long session with dumpcap file rotation, then copies
and renumbers generated pcapng files into `session_dir/pcaps`. It does not call
tshark, analyze packets, or create replay artifacts.
"""

from __future__ import annotations

import re
import threading
from pathlib import Path

from packet_collector.capture.dumpcap_runner import build_dumpcap_command, ensure_tmp_capture_dir, run_dumpcap
from packet_collector.capture.filters import build_capture_filter
from packet_collector.collectors.gps_collector import LatestGpsReader
from packet_collector.collectors.network_events import record_network_events
from packet_collector.session.session_manager import (
    create_session_dir,
    create_session_id,
    renumber_pcap_files,
    update_session_meta,
    write_session_meta,
)
from packet_collector.session.metrics_csv_export import (
    DISPLAY_SPLIT_SECONDS,
    export_metrics_csv_for_display,
)
from packet_collector.session.window_capture import run_windowed_capture
from packet_collector.platform_defaults import default_gps_port
from packet_collector.storage.file_manager import find_matching_files
from packet_collector.utils import utc_timestamp


def _safe_name(value: str) -> str:
    """Return a filesystem-friendly name fragment."""
    return re.sub(r"[^A-Za-z0-9_.-]+", "_", value).replace(".", "_")


def _build_session_capture_filename(
    session_id: str,
    packet_type: str,
    direction: str,
    pi_ip: str | None,
    peer_ip: str | None,
    capture_mode: str,
) -> str:
    """Build the planned temporary session pcapng filename."""
    if capture_mode == "iface_only":
        return f"{session_id}_{packet_type}_iface_only.pcapng"
    if capture_mode == "peer_only":
        return f"{session_id}_{packet_type}_peer_only_{_safe_name(peer_ip or 'unknown')}.pcapng"
    return f"{session_id}_{packet_type}_{direction}_{_safe_name(pi_ip or 'unknown')}_{_safe_name(peer_ip or 'unknown')}.pcapng"


def _path_list(paths: list[Path]) -> list[str]:
    """Convert paths to strings for JSON metadata."""
    return [str(path) for path in paths]


def run_capture_session(
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
    execute: bool = True,
    capture_mode: str = "two_host",
    network_events: bool = False,
    network_events_interval: float = 10.0,
    window_mode: str | None = None,
    window_seconds: float = 1.0,
    window_retention: int = 100,
    with_gps: bool = False,
    gps_port: str | None = None,
    gps_baudrate: int = 115200,
    display_data_dir: Path | None = None,
    display_source: str = "BJTU",
) -> Path:
    """Run or plan one long-running capture session."""
    gps_port = gps_port or default_gps_port()
    if network_events_interval <= 0:
        raise ValueError("network_events_interval must be > 0")
    if window_mode not in (None, "capture-only", "online-analysis"):
        raise ValueError("window_mode must be capture-only or online-analysis")
    if window_mode is not None and packet_type != "tcp":
        raise ValueError("window capture mode currently supports packet_type=tcp only")
    if with_gps and window_mode != "online-analysis":
        raise ValueError("--with-gps requires --window-mode online-analysis")
    if display_data_dir is not None and not with_gps:
        raise ValueError("--display-data-dir requires --with-gps")
    if display_data_dir is not None and (
        not display_source or Path(display_source).name != display_source
    ):
        raise ValueError("display_source must be a single directory name")
    if window_seconds <= 0:
        raise ValueError("window_seconds must be > 0")
    if window_retention <= 0:
        raise ValueError("window_retention must be > 0")
    session_id = create_session_id()
    session_dir = create_session_dir(final_base_dir, session_id)
    pcaps_dir = session_dir / "pcaps"
    packets_dir = session_dir / "packets"
    merged_packets_jsonl = session_dir / "packets.jsonl"
    network_events_file = session_dir / "network_events.jsonl"
    window_pcaps_dir = session_dir / "window_pcaps"
    analysis_pending_dir = session_dir / "analysis_pending"
    window_metrics_file = session_dir / "window_metrics.jsonl"
    window_metrics_csv_file = session_dir / "window_metrics_gps.csv"
    if window_mode is not None:
        window_pcaps_dir.mkdir(parents=True, exist_ok=True)
    capture_filter = build_capture_filter(
        packet_type,
        pi_ip,
        peer_ip,
        direction=direction,
        port=port,
        capture_mode=capture_mode,
    )
    tmp_output_file = tmp_capture_dir / _build_session_capture_filename(
        session_id,
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
        file_size_kb=None if window_mode is not None else file_size_kb,
        max_files=None if window_mode is not None else max_files,
        duration=duration,
        rotation_duration=window_seconds if window_mode is not None else None,
    )

    start_time = utc_timestamp() if execute else None
    meta: dict[str, object] = {
        "session_id": session_id,
        "packet_type": packet_type,
        "capture_mode": capture_mode,
        "pi_ip": pi_ip,
        "peer_ip": peer_ip,
        "direction": direction,
        "iface": iface,
        "port": port,
        "duration": duration,
        "capture_filter": capture_filter,
        "tmp_capture_dir": str(tmp_capture_dir),
        "session_dir": str(session_dir),
        "pcaps_dir": str(pcaps_dir),
        "packets_dir": str(packets_dir),
        "merged_packets_jsonl": str(merged_packets_jsonl),
        "file_size_kb": file_size_kb,
        "max_files": max_files,
        "dumpcap_command": command,
        "status": "running" if execute else "planned",
        "parse_status": "not_started",
        "start_time": start_time,
        "end_time": None,
        "returncode": None,
        "pcap_files": [],
        "packet_jsonl_files": [],
        "parse_error": None,
        "error": None,
        "network_events_enabled": network_events,
        "network_events_interval": network_events_interval,
        "network_events_file": network_events_file.name if network_events else None,
        "window_mode": window_mode,
        "window_seconds": window_seconds if window_mode is not None else None,
        "window_retention": window_retention if window_mode is not None else None,
        "window_pcaps_dir": str(window_pcaps_dir) if window_mode is not None else None,
        "analysis_pending_dir": str(analysis_pending_dir)
        if window_mode == "online-analysis"
        else None,
        "window_metrics_file": str(window_metrics_file) if window_mode == "online-analysis" else None,
        "window_metrics_csv_file": str(window_metrics_csv_file) if with_gps else None,
        "window_count": 0,
        "window_analysis_status": "not_started" if window_mode == "online-analysis" else None,
        "window_analysis_completed_count": 0,
        "pending_window_count": 0,
        "partial_window_count": 0,
        "window_analysis_errors": [],
        "gps_enabled": with_gps,
        "gps_port": gps_port if with_gps else None,
        "gps_baudrate": gps_baudrate if with_gps else None,
        "gps_error": None,
        "display_export_enabled": display_data_dir is not None,
        "display_data_dir": str(display_data_dir) if display_data_dir is not None else None,
        "display_source": display_source if display_data_dir is not None else None,
        "display_split_seconds": DISPLAY_SPLIT_SECONDS if display_data_dir is not None else None,
        "display_export_status": "not_started" if display_data_dir is not None else None,
        "display_full_csv": None,
        "display_split_csv_files": [],
        "display_export_error": None,
    }
    write_session_meta(session_dir, meta)

    if not execute:
        return session_dir

    ensure_tmp_capture_dir(tmp_capture_dir)
    network_stop = threading.Event()
    network_thread: threading.Thread | None = None
    gps_reader: LatestGpsReader | None = None
    if network_events:
        network_thread = threading.Thread(
            target=record_network_events,
            args=(iface, network_events_file, network_events_interval, network_stop),
            name=f"network-events-{session_id}",
            daemon=True,
        )
        network_thread.start()
    if with_gps:
        gps_reader = LatestGpsReader(port=gps_port, baudrate=gps_baudrate)
        gps_reader.start()
    try:
        if window_mode is not None:
            def update_drain_status(interrupted: bool, pending_count: int) -> None:
                update_session_meta(
                    session_dir,
                    {
                        "status": "interrupted" if interrupted else "running",
                        "window_analysis_status": "draining"
                        if window_mode == "online-analysis"
                        else None,
                        "pending_window_count": pending_count,
                    },
                )

            result = run_windowed_capture(
                command=command,
                tmp_capture_dir=tmp_capture_dir,
                tmp_output_stem=tmp_output_file.stem,
                window_pcaps_dir=window_pcaps_dir,
                pcaps_dir=pcaps_dir,
                metrics_file=window_metrics_file,
                window_seconds=window_seconds,
                retention=window_retention,
                archive_file_size_kb=file_size_kb,
                online_analysis=window_mode == "online-analysis",
                analysis_pending_dir=analysis_pending_dir,
                gps_provider=gps_reader,
                metrics_csv_file=window_metrics_csv_file if with_gps else None,
                drain_callback=update_drain_status,
            )
            update_session_meta(
                session_dir,
                {
                    "status": "interrupted" if result.interrupted else "captured",
                    "end_time": utc_timestamp(),
                    "returncode": result.returncode,
                    "pcap_files": _path_list(result.archive_files),
                    "window_pcap_files": _path_list(result.window_files),
                    "window_count": result.window_count,
                    "window_analysis_completed_count": getattr(
                        result, "analysis_completed_count", result.window_count
                    ),
                    "pending_window_count": getattr(result, "pending_analysis_count", 0),
                    "partial_window_count": getattr(result, "partial_window_count", 0),
                    "window_analysis_status": (
                        "completed_with_errors"
                        if result.analysis_errors
                        else "completed"
                    )
                    if window_mode == "online-analysis"
                    else None,
                    "window_analysis_errors": result.analysis_errors,
                    "gps_error": gps_reader.error if gps_reader is not None else None,
                    "error": None,
                },
            )
            if display_data_dir is not None:
                try:
                    export_result = export_metrics_csv_for_display(
                        source_csv=window_metrics_csv_file,
                        display_data_dir=display_data_dir,
                        session_id=session_id,
                        source_name=display_source,
                    )
                    update_session_meta(
                        session_dir,
                        {
                            "display_export_status": "completed",
                            "display_full_csv": str(export_result.full_csv),
                            "display_split_csv_files": _path_list(export_result.split_csv_files),
                            "display_export_row_count": export_result.row_count,
                            "display_export_invalid_timestamp_count": export_result.invalid_timestamp_count,
                            "display_export_error": None,
                        },
                    )
                except Exception as exc:
                    update_session_meta(
                        session_dir,
                        {
                            "display_export_status": "failed",
                            "display_export_error": str(exc),
                        },
                    )
            return session_dir
        returncode = run_dumpcap(command)
    except RuntimeError as exc:
        update_session_meta(
            session_dir,
            {
                "status": "failed",
                "end_time": utc_timestamp(),
                "error": str(exc),
            },
        )
        raise
    finally:
        network_stop.set()
        if network_thread is not None:
            network_thread.join(timeout=max(network_events_interval, 1.0) + 1.0)
        if gps_reader is not None:
            gps_reader.stop()
            if gps_reader.error:
                try:
                    update_session_meta(session_dir, {"gps_error": gps_reader.error})
                except Exception:
                    pass

    source_files = find_matching_files(tmp_capture_dir, tmp_output_file.stem, ".pcapng")
    pcap_files = renumber_pcap_files(source_files, pcaps_dir)
    update_session_meta(
        session_dir,
        {
            "status": "captured",
            "end_time": utc_timestamp(),
            "returncode": returncode,
            "pcap_files": _path_list(pcap_files),
            "error": None,
        },
    )
    return session_dir
