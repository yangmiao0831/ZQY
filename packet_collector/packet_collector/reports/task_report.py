"""Task report generator.

This module builds `task_report.json` from existing task JSON artifacts. It
does not read pcapng or JSONL files, call dumpcap/tshark, or access the network.
"""

from __future__ import annotations

import json
import time
from pathlib import Path
from typing import Any

from packet_collector.storage.json_writer import write_json


ARTIFACTS = {
    "task_meta": ("task_meta.json", "task_meta"),
    "ip_metrics": ("ip_metrics.json", "ip_layer"),
    "tcp_summary": ("tcp_summary.json", "transport_layer"),
    "udp_summary": ("udp_summary.json", "transport_layer"),
    "icmp_summary": ("icmp_summary.json", "transport_layer"),
    "dns_summary": ("dns_summary.json", "application_layer"),
    "http_summary": ("http_summary.json", "application_layer"),
    "tls_summary": ("tls_summary.json", "application_layer"),
    "probe_ping": ("probe_ping.json", "active_probes"),
    "probe_dns": ("probe_dns.json", "active_probes"),
    "probe_http": ("probe_http.json", "active_probes"),
    "probe_tls": ("probe_tls.json", "active_probes"),
    "device_metrics": ("device_metrics.json", "device_runtime_layer"),
    "replay_trace": ("replay_trace.json", "experimental_replay"),
    "replay_result_server": ("replay_result_server.json", "experimental_replay"),
    "replay_result_client": ("replay_result_client.json", "experimental_replay"),
}


def load_json_file(path: Path) -> tuple[dict[str, Any] | None, str | None]:
    """Load a JSON object file, returning data or an error string."""
    try:
        data = json.loads(path.read_text(encoding="utf-8"))
    except FileNotFoundError:
        return None, "file not found"
    except json.JSONDecodeError as exc:
        return None, f"invalid JSON: {exc}"
    except Exception as exc:
        return None, str(exc)
    if not isinstance(data, dict):
        return None, "JSON root is not an object"
    return data, None


def _has_any(section: dict[str, object]) -> bool:
    """Return whether a report section contains any loaded artifact data."""
    return any(bool(value) for value in section.values())


def _http_success_observed(http_summary: dict[str, Any] | None) -> bool | None:
    """Return whether HTTP 2xx/3xx responses were observed."""
    if http_summary is None:
        return None
    status_counts = http_summary.get("status_code_counts", {})
    if not isinstance(status_counts, dict):
        return False
    for status in status_counts:
        try:
            code = int(status)
        except (TypeError, ValueError):
            continue
        if 200 <= code < 400:
            return True
    return False


def _dns_success_observed(dns_summary: dict[str, Any] | None) -> bool | None:
    """Return whether DNS rcode 0 responses were observed."""
    if dns_summary is None:
        return None
    response_counts = dns_summary.get("response_code_counts", {})
    if not isinstance(response_counts, dict):
        return False
    return "0" in response_counts or 0 in response_counts


def _tls_sni_observed(tls_summary: dict[str, Any] | None) -> bool | None:
    """Return whether TLS SNI values were observed."""
    if tls_summary is None:
        return None
    sni_counts = tls_summary.get("sni_counts", {})
    return bool(sni_counts) if isinstance(sni_counts, dict) else False


def build_high_level_status(report: dict[str, Any]) -> dict[str, object]:
    """Build a compact non-diagnostic status summary from report data."""
    ip_metrics = report["ip_layer"].get("ip_metrics") or None
    device_metrics = report["device_runtime_layer"].get("device_metrics") or None
    tcp_summary = report["transport_layer"].get("tcp_summary") or None
    dns_summary = report["application_layer"].get("dns_summary") or None
    http_summary = report["application_layer"].get("http_summary") or None
    tls_summary = report["application_layer"].get("tls_summary") or None

    gateway_ping = ip_metrics.get("gateway_ping") if isinstance(ip_metrics, dict) else None
    target_ping = ip_metrics.get("target_ping") if isinstance(ip_metrics, dict) else None
    return {
        "ip_success": ip_metrics.get("success") if isinstance(ip_metrics, dict) else None,
        "device_success": device_metrics.get("success") if isinstance(device_metrics, dict) else None,
        "ping_gateway_success": gateway_ping.get("success") if isinstance(gateway_ping, dict) else None,
        "ping_target_success": target_ping.get("success") if isinstance(target_ping, dict) else None,
        "http_success_observed": _http_success_observed(http_summary if isinstance(http_summary, dict) else None),
        "dns_success_observed": _dns_success_observed(dns_summary if isinstance(dns_summary, dict) else None),
        "tls_sni_observed": _tls_sni_observed(tls_summary if isinstance(tls_summary, dict) else None),
        "tcp_retransmission_count": tcp_summary.get("retransmission_count") if isinstance(tcp_summary, dict) else None,
    }


def generate_task_report(task_dir: Path, output_file: Path | None = None) -> Path:
    """Generate `task_report.json` from existing task JSON artifacts."""
    output = output_file or task_dir / "task_report.json"
    missing_or_invalid_files: list[dict[str, str]] = []
    report: dict[str, Any] = {
        "report_type": "task_report",
        "task_dir": str(task_dir),
        "generated_at_epoch": time.time(),
        "available_sections": {},
        "missing_or_invalid_files": missing_or_invalid_files,
        "task_meta": {},
        "session_meta": {},
        "ip_layer": {"ip_metrics": {}},
        "transport_layer": {"tcp_summary": {}, "udp_summary": {}, "icmp_summary": {}},
        "application_layer": {"dns_summary": {}, "http_summary": {}, "tls_summary": {}},
        "active_probes": {"probe_ping": {}, "probe_dns": {}, "probe_http": {}, "probe_tls": {}},
        "device_runtime_layer": {"device_metrics": {}},
        "experimental_replay": {"replay_trace": {}, "replay_result_server": {}, "replay_result_client": {}},
        "high_level_status": {},
    }

    for artifact_key, (filename, section_name) in ARTIFACTS.items():
        data, error = load_json_file(task_dir / filename)
        if error is not None:
            missing_or_invalid_files.append({"file": filename, "error": error})
            continue
        if section_name == "task_meta":
            report["task_meta"] = data
        else:
            report[section_name][artifact_key] = data

    session_meta_path = task_dir / "session_meta.json"
    if session_meta_path.exists():
        data, error = load_json_file(session_meta_path)
        if error is not None:
            missing_or_invalid_files.append({"file": "session_meta.json", "error": error})
        else:
            report["session_meta"] = data

    report["available_sections"] = {
        "task_meta": bool(report["task_meta"]),
        "session_meta": bool(report["session_meta"]),
        "ip_layer": _has_any(report["ip_layer"]),
        "transport_layer": _has_any(report["transport_layer"]),
        "application_layer": _has_any(report["application_layer"]),
        "active_probes": _has_any(report["active_probes"]),
        "device_runtime_layer": _has_any(report["device_runtime_layer"]),
        "experimental_replay": _has_any(report["experimental_replay"]),
    }
    report["high_level_status"] = build_high_level_status(report)
    return write_json(output, report)
