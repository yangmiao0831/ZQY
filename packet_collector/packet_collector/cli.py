"""Command-line interface for packet_collector.

The capture command now drives the Step 2 dumpcap capture loop. Parsing,
JSONL parsing, summary commands, and active probes are available. Collectors
and diagnosis remain placeholders.
"""

from __future__ import annotations

import argparse
import glob
import json
import os
import signal
from pathlib import Path

from config.default_config import (
    DEFAULT_DIRECTION,
    DEFAULT_FILE_SIZE_KB,
    FINAL_CAPTURE_DIR,
    DEFAULT_IFACE,
    DEFAULT_MAX_FILES,
    TMP_CAPTURE_DIR,
)
from packet_collector.analyzers.icmp_analyzer import analyze_icmp_jsonl
from packet_collector.analyzers.dns_analyzer import analyze_dns_jsonl
from packet_collector.analyzers.http_analyzer import analyze_http_jsonl
from packet_collector.analyzers.tcp_analyzer import analyze_tcp_jsonl
from packet_collector.analyzers.tls_analyzer import analyze_tls_jsonl
from packet_collector.analyzers.udp_analyzer import analyze_udp_jsonl
from packet_collector.capture.capture import run_capture_task
from packet_collector.collectors.device_collector import collect_device_metrics
from packet_collector.collectors.ip_collector import collect_ip_metrics
from packet_collector.deploy.env_check import run_env_check
from packet_collector.parsers.pcap_to_json import parse_pcap_files_to_jsonl
from packet_collector.platform_defaults import default_disk_path, default_gps_port
from packet_collector.probes.dns_probe import run_dns_probe
from packet_collector.probes.http_probe import run_http_probe
from packet_collector.probes.ping_probe import run_ping_probe
from packet_collector.probes.tls_probe import run_tls_probe
from packet_collector.replay.replay_client import run_replay_client
from packet_collector.replay.replay_server import run_replay_server
from packet_collector.replay.trace_builder import build_replay_trace, load_pi_ips_from_network_events
from packet_collector.reports.task_report import generate_task_report
from packet_collector.session.session_capture import run_capture_session
from packet_collector.session.session_manager import load_session_meta, update_session_meta
from packet_collector.session.session_parser import parse_session
from packet_collector.storage.json_writer import write_json
from packet_collector.task_manager import find_task_meta, load_task_meta, update_task_meta


SUPPORTED_PACKET_TYPES = ["tcp", "udp", "icmp", "http", "https", "dns", "all"]
ANALYZE_ALL_PROTOCOLS = ["tcp", "udp", "icmp", "dns", "http", "tls"]


def _raise_keyboard_interrupt(signum: int, frame: object) -> None:
    """Convert a Windows console break event into normal graceful shutdown."""
    raise KeyboardInterrupt


def _install_windows_break_handler(command: str) -> None:
    """Let parent launchers interrupt capture subprocesses without killing them."""
    if (
        os.name == "nt"
        and command in {"capture", "capture-session"}
        and hasattr(signal, "SIGBREAK")
    ):
        signal.signal(signal.SIGBREAK, _raise_keyboard_interrupt)


def build_parser() -> argparse.ArgumentParser:
    """Build the CLI argument parser."""
    parser = argparse.ArgumentParser(prog="packet_collector")
    subparsers = parser.add_subparsers(dest="command", required=True)

    capture_parser = subparsers.add_parser("capture", help="Build a capture task placeholder")
    capture_parser.add_argument("packet_type", choices=SUPPORTED_PACKET_TYPES)
    capture_parser.add_argument("pi_ip", nargs="?")
    capture_parser.add_argument("peer_ip", nargs="?")
    capture_mode_group = capture_parser.add_mutually_exclusive_group()
    capture_mode_group.add_argument("--iface-only", action="store_true")
    capture_mode_group.add_argument("--peer-only", metavar="PEER_IP")
    capture_parser.add_argument("--direction", choices=["in", "out", "both"], default=DEFAULT_DIRECTION)
    capture_parser.add_argument("--port", type=int, default=None)
    capture_parser.add_argument("--iface", default=DEFAULT_IFACE)
    capture_parser.add_argument("--duration", type=int, default=None)
    capture_parser.add_argument("--file-size-kb", type=int, default=DEFAULT_FILE_SIZE_KB)
    capture_parser.add_argument("--max-files", type=int, default=DEFAULT_MAX_FILES)
    capture_parser.add_argument("--scene", default=None)
    capture_parser.add_argument("--dry-run", action="store_true", help="Create task metadata without running dumpcap")
    capture_parser.add_argument("--tmp-capture-dir", default=TMP_CAPTURE_DIR)
    capture_parser.add_argument("--final-capture-dir", default=FINAL_CAPTURE_DIR)
    capture_parser.add_argument("--parse", action="store_true", help="Parse completed pcapng files to packets.jsonl")

    capture_session_parser = subparsers.add_parser("capture-session", help="Capture a long-running pcapng session")
    capture_session_parser.add_argument("packet_type", choices=SUPPORTED_PACKET_TYPES)
    capture_session_parser.add_argument("pi_ip", nargs="?")
    capture_session_parser.add_argument("peer_ip", nargs="?")
    session_capture_mode_group = capture_session_parser.add_mutually_exclusive_group()
    session_capture_mode_group.add_argument("--iface-only", action="store_true")
    session_capture_mode_group.add_argument("--peer-only", metavar="PEER_IP")
    capture_session_parser.add_argument("--direction", choices=["in", "out", "both"], default=DEFAULT_DIRECTION)
    capture_session_parser.add_argument("--port", type=int, default=None)
    capture_session_parser.add_argument("--iface", default=DEFAULT_IFACE)
    capture_session_parser.add_argument("--duration", type=int, default=None)
    capture_session_parser.add_argument("--file-size-kb", type=int, default=DEFAULT_FILE_SIZE_KB)
    capture_session_parser.add_argument("--max-files", type=int, default=200)
    capture_session_parser.add_argument("--dry-run", action="store_true", help="Create session metadata without running dumpcap")
    capture_session_parser.add_argument("--tmp-capture-dir", default=TMP_CAPTURE_DIR)
    capture_session_parser.add_argument("--final-capture-dir", default=FINAL_CAPTURE_DIR)
    capture_session_parser.add_argument("--network-events", action="store_true")
    capture_session_parser.add_argument("--network-events-interval", type=float, default=10.0)
    capture_session_parser.add_argument(
        "--window-mode",
        choices=["capture-only", "online-analysis"],
        default=None,
        help="Rotate TCP capture by time, optionally analyze each closed window",
    )
    capture_session_parser.add_argument("--window-seconds", type=float, default=1.0)
    capture_session_parser.add_argument("--window-retention", type=int, default=100)
    capture_session_parser.add_argument("--with-gps", action="store_true")
    capture_session_parser.add_argument("--gps-port", default=default_gps_port())
    capture_session_parser.add_argument("--gps-baudrate", type=int, default=115200)
    capture_session_parser.add_argument(
        "--display-data-dir",
        default=None,
        help="After capture, publish full and one-minute metrics CSV files here",
    )
    capture_session_parser.add_argument("--display-source", default="BJTU")

    parse_parser = subparsers.add_parser("parse", help="Parse task pcapng files into packets.jsonl")
    parse_parser.add_argument("task_dir")
    parse_parser.add_argument("--packet-type", choices=SUPPORTED_PACKET_TYPES, required=True)
    parse_parser.add_argument("--output", default=None)

    parse_session_parser = subparsers.add_parser("parse-session", help="Parse a session pcaps directory into JSONL")
    parse_session_parser.add_argument("session_dir")
    parse_session_parser.add_argument("--packet-type", choices=SUPPORTED_PACKET_TYPES, default=None)
    parse_session_parser.add_argument("--force", action="store_true")

    replay_trace_parser = subparsers.add_parser("build-replay-trace", help="Build replay_trace.json from packets.jsonl")
    replay_trace_parser.add_argument("source_dir")
    replay_trace_pi_group = replay_trace_parser.add_mutually_exclusive_group()
    replay_trace_pi_group.add_argument("--pi-ip")
    replay_trace_pi_group.add_argument("--pi-ip-list")
    replay_trace_parser.add_argument("--use-network-events", action="store_true")
    replay_trace_parser.add_argument("--input", action="append", default=[])
    replay_trace_parser.add_argument("--input-glob", default=None)
    replay_trace_parser.add_argument("--output", default=None)
    replay_trace_parser.add_argument("--window-ms", type=int, default=100)
    replay_trace_parser.add_argument("--protocol-filter", choices=["all", "tcp", "udp"], default="all")
    replay_trace_parser.add_argument("--flow-idle-timeout-sec", type=float, default=60.0)

    replay_server_parser = subparsers.add_parser("replay-server", help="Run TCP replay server")
    replay_server_parser.add_argument("trace_file")
    replay_server_parser.add_argument("--host", default="0.0.0.0")
    replay_server_parser.add_argument("--port", type=int, default=9000)
    replay_server_parser.add_argument("--protocol", choices=["tcp", "udp", "all"], default="tcp")
    replay_server_parser.add_argument("--flow-id", default=None)
    replay_server_parser.add_argument("--role", default=None)
    replay_server_flow_group = replay_server_parser.add_mutually_exclusive_group()
    replay_server_flow_group.add_argument("--max-flows", type=int, default=1)
    replay_server_flow_group.add_argument("--all-flows", action="store_true")
    replay_server_parser.add_argument("--max-datagram-size", type=int, default=1200)
    replay_server_parser.add_argument("--output", default=None)
    replay_server_parser.add_argument("--timeout", type=float, default=30.0)

    replay_client_parser = subparsers.add_parser("replay-client", help="Run TCP replay client")
    replay_client_parser.add_argument("trace_file")
    replay_client_parser.add_argument("--server", required=True)
    replay_client_parser.add_argument("--port", type=int, default=9000)
    replay_client_parser.add_argument("--protocol", choices=["tcp", "udp", "all"], default="tcp")
    replay_client_parser.add_argument("--flow-id", default=None)
    replay_client_parser.add_argument("--role", default=None)
    replay_client_flow_group = replay_client_parser.add_mutually_exclusive_group()
    replay_client_flow_group.add_argument("--max-flows", type=int, default=1)
    replay_client_flow_group.add_argument("--all-flows", action="store_true")
    replay_client_parser.add_argument("--max-datagram-size", type=int, default=1200)
    replay_client_parser.add_argument("--output", default=None)
    replay_client_parser.add_argument("--timeout", type=float, default=30.0)

    analyze_tcp_parser = subparsers.add_parser("analyze-tcp", help="Analyze TCP packets.jsonl")
    analyze_tcp_parser.add_argument("task_dir")
    analyze_tcp_parser.add_argument("--input", default=None)
    analyze_tcp_parser.add_argument("--output", default=None)

    analyze_udp_parser = subparsers.add_parser("analyze-udp", help="Analyze UDP packets.jsonl")
    analyze_udp_parser.add_argument("task_dir")
    analyze_udp_parser.add_argument("--input", default=None)
    analyze_udp_parser.add_argument("--output", default=None)

    analyze_icmp_parser = subparsers.add_parser("analyze-icmp", help="Analyze ICMP packets.jsonl")
    analyze_icmp_parser.add_argument("task_dir")
    analyze_icmp_parser.add_argument("--input", default=None)
    analyze_icmp_parser.add_argument("--output", default=None)

    analyze_dns_parser = subparsers.add_parser("analyze-dns", help="Analyze DNS packets.jsonl")
    analyze_dns_parser.add_argument("task_dir")
    analyze_dns_parser.add_argument("--input", default=None)
    analyze_dns_parser.add_argument("--output", default=None)

    analyze_http_parser = subparsers.add_parser("analyze-http", help="Analyze HTTP packets.jsonl")
    analyze_http_parser.add_argument("task_dir")
    analyze_http_parser.add_argument("--input", default=None)
    analyze_http_parser.add_argument("--output", default=None)

    analyze_tls_parser = subparsers.add_parser("analyze-tls", help="Analyze TLS packets.jsonl")
    analyze_tls_parser.add_argument("task_dir")
    analyze_tls_parser.add_argument("--input", default=None)
    analyze_tls_parser.add_argument("--output", default=None)

    analyze_all_parser = subparsers.add_parser("analyze-all", help="Run all transport and application analyzers")
    analyze_all_parser.add_argument("task_dir")
    analyze_all_parser.add_argument("--input", default=None)

    collect_device_parser = subparsers.add_parser("collect-device", help="Collect device runtime metrics")
    collect_device_parser.add_argument("--output", default=None)
    collect_device_parser.add_argument("--task-dir", default=None)
    collect_device_parser.add_argument("--disk-path", default=default_disk_path())

    collect_ip_parser = subparsers.add_parser("collect-ip", help="Collect IP layer metrics")
    collect_ip_parser.add_argument("--iface", default=DEFAULT_IFACE)
    collect_ip_parser.add_argument("--target", default=None)
    collect_ip_parser.add_argument("--ping-count", type=int, default=4)
    collect_ip_parser.add_argument("--ping-timeout", type=int, default=5)
    collect_ip_parser.add_argument("--output", default=None)
    collect_ip_parser.add_argument("--task-dir", default=None)

    report_parser = subparsers.add_parser("report", help="Generate task_report.json from task artifacts")
    report_parser.add_argument("task_dir")
    report_parser.add_argument("--output", default=None)

    check_env_parser = subparsers.add_parser("check-env", help="Check Linux or Windows deployment environment")
    check_env_parser.add_argument("--output", default=None)
    check_env_parser.add_argument("--tmp-capture-dir", default=TMP_CAPTURE_DIR)
    check_env_parser.add_argument("--final-capture-dir", default=FINAL_CAPTURE_DIR)

    probe_parser = subparsers.add_parser("probe", help="Run active probe placeholder")
    probe_parser.add_argument("probe_type", choices=["ping", "dns", "http", "tls"])
    probe_parser.add_argument("target")
    probe_parser.add_argument("--port", type=int, default=443)
    probe_parser.add_argument("--count", type=int, default=4)
    probe_parser.add_argument("--timeout", type=float, default=None)
    probe_parser.add_argument("--method", choices=["GET", "HEAD"], default="GET")
    probe_parser.add_argument("--dns-server", default=None)
    probe_parser.add_argument("--server-hostname", default=None)
    probe_parser.add_argument("--output", default=None)
    probe_parser.add_argument("--task-dir", default=None)

    return parser


def _resolve_capture_mode(args: argparse.Namespace) -> tuple[str, str | None, str | None]:
    """Resolve compatible two-host, peer-only, and iface-only CLI inputs."""
    iface_only = bool(getattr(args, "iface_only", False))
    peer_only = getattr(args, "peer_only", None)
    positional_pi = getattr(args, "pi_ip", None)
    positional_peer = getattr(args, "peer_ip", None)

    if iface_only:
        if positional_pi is not None or positional_peer is not None:
            raise SystemExit("pi_ip/peer_ip must be omitted when --iface-only is used")
        return "iface_only", None, None
    if peer_only is not None:
        if positional_pi is not None or positional_peer is not None:
            raise SystemExit("positional pi_ip/peer_ip must be omitted when --peer-only is used")
        return "peer_only", None, str(peer_only)
    if not positional_pi or not positional_peer:
        raise SystemExit("two-host capture requires pi_ip and peer_ip; use --iface-only or --peer-only for mobile capture")
    return "two_host", str(positional_pi), str(positional_peer)


def _run_capture_command(args: argparse.Namespace) -> None:
    """Run the capture command and print a compact result."""
    capture_mode, pi_ip, peer_ip = _resolve_capture_mode(args)
    task = run_capture_task(
        packet_type=args.packet_type,
        pi_ip=pi_ip,
        peer_ip=peer_ip,
        direction=args.direction,
        iface=args.iface,
        final_base_dir=Path(args.final_capture_dir),
        tmp_capture_dir=Path(args.tmp_capture_dir),
        file_size_kb=args.file_size_kb,
        max_files=args.max_files,
        port=args.port,
        duration=args.duration,
        scene=args.scene,
        execute=not args.dry_run,
        capture_mode=capture_mode,
    )
    print(f"task_id: {task.task_id}")
    print(f"status: {task.status}")
    print(f"task_dir: {task.task_dir}")
    print(f"capture_filter: {task.capture_filter}")
    print(f"pcap_files: {[str(path) for path in task.pcap_files]}")
    if args.parse and args.dry_run:
        print("parse_skipped: dry-run")
    elif args.parse:
        output_file = task.task_dir / "packets.jsonl"
        _parse_task_dir(task.task_dir, args.packet_type, output_file)
        print(f"packets_jsonl: {output_file}")


def _run_capture_session_command(args: argparse.Namespace) -> None:
    """Run the long-running session capture command."""
    capture_mode, pi_ip, peer_ip = _resolve_capture_mode(args)
    session_dir = run_capture_session(
        packet_type=args.packet_type,
        pi_ip=pi_ip,
        peer_ip=peer_ip,
        direction=args.direction,
        iface=args.iface,
        final_base_dir=Path(args.final_capture_dir),
        tmp_capture_dir=Path(args.tmp_capture_dir),
        file_size_kb=args.file_size_kb,
        max_files=args.max_files,
        port=args.port,
        duration=args.duration,
        execute=not args.dry_run,
        capture_mode=capture_mode,
        network_events=bool(getattr(args, "network_events", False)),
        network_events_interval=float(getattr(args, "network_events_interval", 10.0)),
        window_mode=getattr(args, "window_mode", None),
        window_seconds=float(getattr(args, "window_seconds", 1.0)),
        window_retention=int(getattr(args, "window_retention", 100)),
        with_gps=bool(getattr(args, "with_gps", False)),
        gps_port=str(getattr(args, "gps_port", default_gps_port())),
        gps_baudrate=int(getattr(args, "gps_baudrate", 115200)),
        display_data_dir=(
            Path(args.display_data_dir)
            if getattr(args, "display_data_dir", None)
            else None
        ),
        display_source=str(getattr(args, "display_source", "BJTU")),
    )
    meta = load_session_meta(session_dir)
    print(f"session_id: {meta.get('session_id')}")
    print(f"session_dir: {session_dir}")
    print(f"capture_filter: {meta.get('capture_filter')}")
    print(f"status: {meta.get('status')}")
    pcap_files = meta.get("pcap_files", [])
    print(f"pcap_files_count: {len(pcap_files) if isinstance(pcap_files, list) else 0}")
    if meta.get("window_mode"):
        print(f"window_count: {meta.get('window_count', 0)}")
        print(f"window_metrics_file: {meta.get('window_metrics_file')}")
        if meta.get("gps_enabled"):
            print(f"window_metrics_csv_file: {meta.get('window_metrics_csv_file')}")
            if meta.get("gps_error"):
                print(f"gps_error: {meta.get('gps_error')}")
        if meta.get("display_export_enabled"):
            print(f"display_export_status: {meta.get('display_export_status')}")
            print(f"display_full_csv: {meta.get('display_full_csv')}")
            split_files = meta.get("display_split_csv_files", [])
            print(
                "display_split_csv_files_count: "
                f"{len(split_files) if isinstance(split_files, list) else 0}"
            )
            if meta.get("display_export_error"):
                print(f"display_export_error: {meta.get('display_export_error')}")


def _get_task_pcap_files(task_dir: Path) -> list[Path]:
    """Get pcap files from task metadata or scan the task directory."""
    meta_path = find_task_meta(task_dir)
    if meta_path.exists():
        metadata = load_task_meta(task_dir)
        pcap_files = metadata.get("pcap_files", [])
        if isinstance(pcap_files, list) and pcap_files:
            return [Path(str(path)) for path in pcap_files]
    return sorted(task_dir.glob("*.pcapng"))


def _parse_task_dir(task_dir: Path, packet_type: str, output_file: Path | None = None) -> Path:
    """Parse pcapng files in a task directory and update task metadata."""
    output = output_file or (task_dir / "packets.jsonl")
    pcap_files = _get_task_pcap_files(task_dir)
    try:
        parse_pcap_files_to_jsonl(pcap_files, output, packet_type)
    except RuntimeError as exc:
        update_task_meta(
            task_dir,
            {
                "packets_jsonl": str(output),
                "parse_status": "failed",
                "parse_error": str(exc),
            },
        )
        raise

    update_task_meta(
        task_dir,
        {
            "packets_jsonl": str(output),
            "parse_status": "completed",
            "parse_error": None,
        },
    )
    return output


def _run_parse_command(args: argparse.Namespace) -> None:
    """Run standalone parse command and print a compact result."""
    task_dir = Path(args.task_dir)
    output_file = Path(args.output) if args.output else task_dir / "packets.jsonl"
    pcap_files = _get_task_pcap_files(task_dir)
    try:
        output = _parse_task_dir(task_dir, args.packet_type, output_file)
    except RuntimeError as exc:
        raise SystemExit(str(exc)) from exc

    print(f"task_dir: {task_dir}")
    print(f"packet_type: {args.packet_type}")
    print(f"pcap_files_count: {len(pcap_files)}")
    print(f"output_file: {output}")


def _run_parse_session_command(args: argparse.Namespace) -> None:
    """Run standalone session parse command and print a compact result."""
    session_dir = Path(args.session_dir)
    meta = load_session_meta(session_dir)
    packet_type = args.packet_type or str(meta.get("packet_type") or "all")
    try:
        output = parse_session(session_dir, packet_type, force=args.force)
    except Exception as exc:
        raise SystemExit(str(exc)) from exc

    updated_meta = load_session_meta(session_dir)
    pcap_files = sorted((session_dir / "pcaps").glob("*.pcapng"))
    jsonl_files = updated_meta.get("packet_jsonl_files", [])
    print(f"session_dir: {session_dir}")
    print(f"packet_type: {packet_type}")
    print(f"pcaps_count: {len(pcap_files)}")
    print(f"packet_jsonl_files_count: {len(jsonl_files) if isinstance(jsonl_files, list) else 0}")
    print(f"merged_packets_jsonl: {output}")
    print(f"status: {updated_meta.get('parse_status')}")


def _load_source_meta(source_dir: Path) -> tuple[str, str | None, dict[str, object]]:
    """Detect source type and metadata for task/session/unknown directories."""
    session_meta = source_dir / "session_meta.json"
    task_meta = source_dir / "task_meta.json"
    if session_meta.exists():
        metadata = load_session_meta(source_dir)
        return "session", str(metadata.get("session_id") or ""), metadata
    if task_meta.exists():
        metadata = load_task_meta(source_dir)
        return "task", str(metadata.get("task_id") or ""), metadata
    return "unknown", None, {}


def _resolve_replay_trace_inputs(args: argparse.Namespace, source_dir: Path) -> list[Path]:
    """Resolve packet JSONL inputs for build-replay-trace."""
    if args.input:
        return [Path(path) for path in args.input]
    if args.input_glob:
        return [Path(path) for path in sorted(glob.glob(args.input_glob))]
    default_packets = source_dir / "packets.jsonl"
    if default_packets.exists():
        return [default_packets]
    packets_dir_files = sorted((source_dir / "packets").glob("*.jsonl"))
    if packets_dir_files:
        return packets_dir_files
    return []


def _update_replay_meta(source_dir: Path, source_type: str, replay_updates: dict[str, object]) -> None:
    """Update replay metadata for task or session sources."""
    if source_type == "session":
        metadata = load_session_meta(source_dir)
        replay = metadata.get("replay", {})
        if not isinstance(replay, dict):
            replay = {}
        replay.update(replay_updates)
        update_session_meta(source_dir, {"replay": replay})
    elif source_type == "task":
        metadata = load_task_meta(source_dir)
        replay = metadata.get("replay", {})
        if not isinstance(replay, dict):
            replay = {}
        replay.update(replay_updates)
        update_task_meta(source_dir, {"replay": replay})


def _resolve_replay_pi_ips(args: argparse.Namespace, source_dir: Path) -> tuple[list[str], str, str | None]:
    """Resolve Pi IP addresses from explicit arguments or network events."""
    pi_ip_list = getattr(args, "pi_ip_list", None)
    pi_ip = getattr(args, "pi_ip", None)
    use_network_events = bool(getattr(args, "use_network_events", False))
    warning: str | None = None

    if pi_ip_list:
        pi_ips = list(dict.fromkeys(value.strip() for value in str(pi_ip_list).split(",") if value.strip()))
        if not pi_ips:
            raise SystemExit("--pi-ip-list did not contain any IP addresses")
        if use_network_events:
            warning = "--pi-ip-list takes precedence over --use-network-events"
        return pi_ips, "explicit_list", warning
    if pi_ip:
        if use_network_events:
            warning = "--pi-ip takes precedence over --use-network-events"
        return [str(pi_ip)], "explicit", warning
    if use_network_events:
        try:
            return load_pi_ips_from_network_events(source_dir / "network_events.jsonl"), "network_events", None
        except ValueError as exc:
            raise SystemExit(str(exc)) from exc
    raise SystemExit("one of --pi-ip, --pi-ip-list, or --use-network-events is required")


def _run_build_replay_trace_command(args: argparse.Namespace) -> None:
    """Build replay_trace.json and update source metadata when available."""
    source_dir = Path(args.source_dir)
    source_type, source_id, _ = _load_source_meta(source_dir)
    input_files = _resolve_replay_trace_inputs(args, source_dir)
    output_file = Path(args.output) if args.output else source_dir / "replay_trace.json"
    if not input_files:
        raise SystemExit("no packets.jsonl input files found")
    pi_ips, pi_ip_source, selection_warning = _resolve_replay_pi_ips(args, source_dir)

    try:
        output = build_replay_trace(
            packet_jsonl_files=input_files,
            output_file=output_file,
            pi_ip=pi_ips[0],
            pi_ips=pi_ips,
            pi_ip_source=pi_ip_source,
            source_dir=source_dir,
            source_id=source_id,
            source_type=source_type,
            window_ms=args.window_ms,
            protocol_filter=args.protocol_filter,
            flow_idle_timeout_sec=args.flow_idle_timeout_sec,
        )
    except Exception as exc:
        _update_replay_meta(
            source_dir,
            source_type,
            {
                "trace_status": "failed",
                "trace_error": str(exc),
            },
        )
        raise SystemExit(str(exc)) from exc

    _update_replay_meta(
        source_dir,
        source_type,
        {
            "trace": str(output),
            "trace_status": "completed",
            "trace_error": None,
            "window_ms": args.window_ms,
            "protocol_filter": args.protocol_filter,
            "flow_idle_timeout_sec": args.flow_idle_timeout_sec,
            "pi_ips": pi_ips,
            "pi_ip_source": pi_ip_source,
            "pi_ip_selection_warning": selection_warning,
        },
    )
    print(f"source_dir: {source_dir}")
    print(f"source_type: {source_type}")
    print(f"input_files_count: {len(input_files)}")
    print(f"output: {output}")
    print(f"pi_ips: {pi_ips}")
    print(f"pi_ip_source: {pi_ip_source}")
    print(f"window_ms: {args.window_ms}")
    print(f"protocol_filter: {args.protocol_filter}")
    print("status: completed")
    if selection_warning:
        print(f"warning: {selection_warning}")
    if source_type == "unknown":
        print("warning: source metadata not found; replay trace generated without meta update")


def _run_replay_server_command(args: argparse.Namespace) -> None:
    """Run TCP replay server."""
    if args.protocol == "all":
        raise SystemExit("protocol=all is not implemented yet")
    output_file = Path(args.output) if args.output else None
    max_flows = None if args.all_flows else args.max_flows
    output = run_replay_server(
        trace_file=Path(args.trace_file),
        host=args.host,
        port=args.port,
        protocol=args.protocol,
        flow_id=args.flow_id,
        role=args.role,
        max_flows=max_flows,
        max_datagram_size=args.max_datagram_size,
        output_file=output_file,
        timeout=args.timeout,
    )
    print(f"trace_file: {args.trace_file}")
    print(f"output: {output}")
    print(f"host: {args.host}")
    print(f"port: {args.port}")
    print(f"protocol: {args.protocol}")
    print(f"max_flows: {max_flows}")
    print("status: completed")


def _run_replay_client_command(args: argparse.Namespace) -> None:
    """Run TCP replay client."""
    if args.protocol == "all":
        raise SystemExit("protocol=all is not implemented yet")
    output_file = Path(args.output) if args.output else None
    max_flows = None if args.all_flows else args.max_flows
    output = run_replay_client(
        trace_file=Path(args.trace_file),
        server=args.server,
        port=args.port,
        protocol=args.protocol,
        flow_id=args.flow_id,
        role=args.role,
        max_flows=max_flows,
        max_datagram_size=args.max_datagram_size,
        output_file=output_file,
        timeout=args.timeout,
    )
    print(f"trace_file: {args.trace_file}")
    print(f"output: {output}")
    print(f"server: {args.server}")
    print(f"port: {args.port}")
    print(f"protocol: {args.protocol}")
    print(f"max_flows: {max_flows}")
    print("status: completed")


def _update_analysis_meta(task_dir: Path, updates: dict[str, object]) -> None:
    """Update task metadata when possible."""
    if (task_dir / "session_meta.json").exists():
        update_session_meta(task_dir, updates)
    else:
        update_task_meta(task_dir, updates)


def _run_transport_analyze_command(
    task_dir: Path,
    input_file: Path,
    output_file: Path,
    analyzer,
    summary_key: str,
    status_key: str,
    error_key: str,
) -> None:
    """Run one transport analyzer and update task metadata."""
    try:
        output = analyzer(input_file, output_file)
    except Exception as exc:
        _update_analysis_meta(
            task_dir,
            {
                summary_key: str(output_file),
                status_key: "failed",
                error_key: str(exc),
            },
        )
        raise SystemExit(str(exc)) from exc

    _update_analysis_meta(
        task_dir,
        {
            summary_key: str(output),
            status_key: "completed",
            error_key: None,
        },
    )
    print(f"task_dir: {task_dir}")
    print(f"input: {input_file}")
    print(f"output: {output}")
    print("status: completed")


def _run_analyze_command(args: argparse.Namespace, protocol: str) -> None:
    """Resolve default paths and dispatch to an analyzer."""
    task_dir = Path(args.task_dir)
    input_file = Path(args.input) if args.input else task_dir / "packets.jsonl"
    output_file = Path(args.output) if args.output else task_dir / f"{protocol}_summary.json"
    analyzers = {
        "tcp": (analyze_tcp_jsonl, "tcp_summary", "tcp_analysis_status", "tcp_analysis_error"),
        "udp": (analyze_udp_jsonl, "udp_summary", "udp_analysis_status", "udp_analysis_error"),
        "icmp": (analyze_icmp_jsonl, "icmp_summary", "icmp_analysis_status", "icmp_analysis_error"),
        "dns": (analyze_dns_jsonl, "dns_summary", "dns_analysis_status", "dns_analysis_error"),
        "http": (analyze_http_jsonl, "http_summary", "http_analysis_status", "http_analysis_error"),
        "tls": (analyze_tls_jsonl, "tls_summary", "tls_analysis_status", "tls_analysis_error"),
    }
    analyzer, summary_key, status_key, error_key = analyzers[protocol]
    _run_transport_analyze_command(
        task_dir=task_dir,
        input_file=input_file,
        output_file=output_file,
        analyzer=analyzer,
        summary_key=summary_key,
        status_key=status_key,
        error_key=error_key,
    )


def _run_analyze_all_command(args: argparse.Namespace) -> None:
    """Run every summary analyzer against one packets.jsonl file."""
    task_dir = Path(args.task_dir)
    input_file = Path(args.input) if args.input else task_dir / "packets.jsonl"
    outputs: dict[str, str] = {}
    for protocol in ANALYZE_ALL_PROTOCOLS:
        protocol_args = argparse.Namespace(task_dir=str(task_dir), input=str(input_file), output=None)
        _run_analyze_command(protocol_args, protocol)
        outputs[protocol] = str(task_dir / f"{protocol}_summary.json")
    print(json.dumps({"task_dir": str(task_dir), "input": str(input_file), "outputs": outputs, "status": "completed"}, ensure_ascii=False))


def _update_probe_meta(task_dir: Path, probe_type: str, output_file: Path | None, result: dict[str, object]) -> None:
    """Update task metadata with one probe result reference."""
    is_session = (task_dir / "session_meta.json").exists()
    metadata = load_session_meta(task_dir) if is_session else (load_task_meta(task_dir) if find_task_meta(task_dir).exists() else {})
    probes = metadata.get("probes", {})
    if not isinstance(probes, dict):
        probes = {}
    probes[probe_type] = {
        "output": str(output_file) if output_file else None,
        "status": "completed" if result.get("success") else "failed",
        "error": result.get("error"),
    }
    if is_session:
        update_session_meta(task_dir, {"probes": probes})
    else:
        update_task_meta(task_dir, {"probes": probes})


def _run_probe_command(args: argparse.Namespace) -> None:
    """Run an active probe, optionally write JSON, and update task metadata."""
    timeout = args.timeout
    if args.probe_type == "ping":
        result = run_ping_probe(args.target, count=args.count, timeout=int(timeout if timeout is not None else 5))
    elif args.probe_type == "dns":
        result = run_dns_probe(args.target, dns_server=args.dns_server, timeout=float(timeout if timeout is not None else 5.0))
    elif args.probe_type == "http":
        result = run_http_probe(args.target, timeout=float(timeout if timeout is not None else 10.0), method=args.method)
    elif args.probe_type == "tls":
        result = run_tls_probe(
            args.target,
            port=args.port,
            timeout=float(timeout if timeout is not None else 10.0),
            server_hostname=args.server_hostname,
        )
    else:
        raise SystemExit(f"unsupported probe_type: {args.probe_type}")

    task_dir = Path(args.task_dir) if args.task_dir else None
    output_file = Path(args.output) if args.output else None
    if task_dir and output_file is None:
        output_file = task_dir / f"probe_{args.probe_type}.json"
    if output_file is not None:
        write_json(output_file, result)
    if task_dir is not None:
        _update_probe_meta(task_dir, args.probe_type, output_file, result)

    print(json.dumps({"success": result.get("success"), "duration_ms": result.get("duration_ms"), "output": str(output_file) if output_file else None}, ensure_ascii=False))


def _update_collector_meta(task_dir: Path, collector_type: str, output_file: Path | None, result: dict[str, object]) -> None:
    """Update task metadata with one collector result reference."""
    is_session = (task_dir / "session_meta.json").exists()
    metadata = load_session_meta(task_dir) if is_session else (load_task_meta(task_dir) if find_task_meta(task_dir).exists() else {})
    collectors = metadata.get("collectors", {})
    if not isinstance(collectors, dict):
        collectors = {}
    collectors[collector_type] = {
        "output": str(output_file) if output_file else None,
        "status": "completed" if result.get("success") else "failed",
        "error": result.get("error"),
    }
    if is_session:
        update_session_meta(task_dir, {"collectors": collectors})
    else:
        update_task_meta(task_dir, {"collectors": collectors})


def _run_collect_device_command(args: argparse.Namespace) -> None:
    """Collect device runtime metrics, optionally write JSON, and update task metadata."""
    result = collect_device_metrics(disk_path=args.disk_path)
    task_dir = Path(args.task_dir) if args.task_dir else None
    output_file = Path(args.output) if args.output else None
    if task_dir and output_file is None:
        output_file = task_dir / "device_metrics.json"
    if output_file is not None:
        write_json(output_file, result)
    if task_dir is not None:
        _update_collector_meta(task_dir, "device", output_file, result)

    print(json.dumps({"success": result.get("success"), "duration_ms": result.get("duration_ms"), "output": str(output_file) if output_file else None}, ensure_ascii=False))


def _run_collect_ip_command(args: argparse.Namespace) -> None:
    """Collect IP-layer metrics, optionally write JSON, and update task metadata."""
    result = collect_ip_metrics(
        iface=args.iface,
        target=args.target,
        ping_count=args.ping_count,
        ping_timeout=args.ping_timeout,
    )
    task_dir = Path(args.task_dir) if args.task_dir else None
    output_file = Path(args.output) if args.output else None
    if task_dir and output_file is None:
        output_file = task_dir / "ip_metrics.json"
    if output_file is not None:
        write_json(output_file, result)
    if task_dir is not None:
        _update_collector_meta(task_dir, "ip", output_file, result)

    print(
        json.dumps(
            {
                "success": result.get("success"),
                "duration_ms": result.get("duration_ms"),
                "iface": result.get("iface"),
                "output": str(output_file) if output_file else None,
            },
            ensure_ascii=False,
        )
    )


def _run_report_command(args: argparse.Namespace) -> None:
    """Generate a task report and update task metadata when possible."""
    task_dir = Path(args.task_dir)
    output_file = Path(args.output) if args.output else task_dir / "task_report.json"
    is_session = (task_dir / "session_meta.json").exists()
    try:
        output = generate_task_report(task_dir, output_file)
    except Exception as exc:
        try:
            updates = {"report": {"output": str(output_file), "status": "failed", "error": str(exc)}}
            if is_session:
                update_session_meta(task_dir, updates)
            else:
                update_task_meta(task_dir, updates)
        except Exception:
            pass
        raise SystemExit(str(exc)) from exc

    try:
        updates = {"report": {"output": str(output), "status": "completed", "error": None}}
        if is_session:
            update_session_meta(task_dir, updates)
        else:
            update_task_meta(task_dir, updates)
    except Exception:
        pass

    print(f"task_dir: {task_dir}")
    print(f"output: {output}")
    print("status: completed")


def _run_check_env_command(args: argparse.Namespace) -> None:
    """Run deployment environment checks."""
    result = run_env_check(
        tmp_capture_dir=Path(args.tmp_capture_dir),
        final_capture_dir=Path(args.final_capture_dir),
    )
    output_file = Path(args.output) if args.output else None
    if output_file is not None:
        write_json(output_file, result)

    print(f"success: {result.get('success')}")
    print(f"python: {result['python']['version']}")
    print(f"dumpcap_available: {result['commands']['dumpcap']['available']}")
    print(f"tshark_available: {result['commands']['tshark']['available']}")
    if "mergecap" in result["commands"]:
        print(f"mergecap_available: {result['commands']['mergecap']['available']}")
    if "npcap" in result["commands"]:
        print(f"npcap_running: {result['commands']['npcap'].get('running')}")
    packages = result.get("python_packages", {})
    for package_name in ("psutil", "yaml", "serial", "cv2"):
        package = packages.get(package_name) if isinstance(packages, dict) else None
        if package is not None:
            print(f"{package_name}_available: {package['available']}")
    print(f"tmp_writable: {result['paths']['tmp_capture_dir']['writable']}")
    print(f"final_writable: {result['paths']['final_capture_dir']['writable']}")
    print(f"output: {output_file}")


def main() -> None:
    """Parse arguments and dispatch to placeholder workflows."""
    parser = build_parser()
    args = parser.parse_args()
    _install_windows_break_handler(args.command)

    if args.command == "capture":
        try:
            _run_capture_command(args)
        except RuntimeError as exc:
            raise SystemExit(str(exc)) from exc
    elif args.command == "capture-session":
        try:
            _run_capture_session_command(args)
        except (RuntimeError, ValueError) as exc:
            raise SystemExit(str(exc)) from exc
    elif args.command == "parse":
        _run_parse_command(args)
    elif args.command == "parse-session":
        _run_parse_session_command(args)
    elif args.command == "build-replay-trace":
        _run_build_replay_trace_command(args)
    elif args.command == "replay-server":
        _run_replay_server_command(args)
    elif args.command == "replay-client":
        _run_replay_client_command(args)
    elif args.command == "analyze-tcp":
        _run_analyze_command(args, "tcp")
    elif args.command == "analyze-udp":
        _run_analyze_command(args, "udp")
    elif args.command == "analyze-icmp":
        _run_analyze_command(args, "icmp")
    elif args.command == "analyze-dns":
        _run_analyze_command(args, "dns")
    elif args.command == "analyze-http":
        _run_analyze_command(args, "http")
    elif args.command == "analyze-tls":
        _run_analyze_command(args, "tls")
    elif args.command == "analyze-all":
        _run_analyze_all_command(args)
    elif args.command == "collect-device":
        _run_collect_device_command(args)
    elif args.command == "collect-ip":
        _run_collect_ip_command(args)
    elif args.command == "report":
        _run_report_command(args)
    elif args.command == "check-env":
        _run_check_env_command(args)
    elif args.command == "probe":
        _run_probe_command(args)


if __name__ == "__main__":
    main()
