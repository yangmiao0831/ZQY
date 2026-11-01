"""Tests for task report generation."""

from __future__ import annotations

import json
from pathlib import Path

from packet_collector.reports.task_report import generate_task_report


def _write_json(path: Path, data: dict[str, object]) -> None:
    """Write JSON helper for report tests."""
    path.write_text(json.dumps(data), encoding="utf-8")


def test_generate_task_report_complete_task(tmp_path: Path) -> None:
    """Complete task artifacts are aggregated into task_report.json."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir()
    _write_json(task_dir / "task_meta.json", {"task_id": "task_20260101_010203"})
    _write_json(
        task_dir / "ip_metrics.json",
        {
            "success": True,
            "gateway_ping": {"success": True},
            "target_ping": {"success": True},
        },
    )
    _write_json(task_dir / "tcp_summary.json", {"retransmission_count": 2})
    _write_json(task_dir / "dns_summary.json", {"response_count": 1, "response_code_counts": {"0": 1}})
    _write_json(task_dir / "http_summary.json", {"response_count": 1, "status_code_counts": {"200": 1}})
    _write_json(task_dir / "tls_summary.json", {"sni_counts": {"example.com": 1}})
    _write_json(task_dir / "device_metrics.json", {"success": True})
    _write_json(task_dir / "probe_ping.json", {"success": True})

    output = generate_task_report(task_dir)
    report = json.loads(output.read_text(encoding="utf-8"))

    assert output.exists()
    assert report["available_sections"]["task_meta"] is True
    assert report["available_sections"]["ip_layer"] is True
    assert report["available_sections"]["transport_layer"] is True
    assert report["available_sections"]["application_layer"] is True
    assert report["available_sections"]["active_probes"] is True
    assert report["available_sections"]["device_runtime_layer"] is True
    assert report["high_level_status"]["ip_success"] is True
    assert report["high_level_status"]["device_success"] is True
    assert report["high_level_status"]["ping_gateway_success"] is True
    assert report["high_level_status"]["http_success_observed"] is True
    assert report["high_level_status"]["dns_success_observed"] is True
    assert report["high_level_status"]["tls_sni_observed"] is True
    assert report["high_level_status"]["tcp_retransmission_count"] == 2


def test_generate_task_report_missing_files(tmp_path: Path) -> None:
    """Missing artifacts do not prevent report generation."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir()
    _write_json(task_dir / "task_meta.json", {"task_id": "task_20260101_010203"})

    output = generate_task_report(task_dir)
    report = json.loads(output.read_text(encoding="utf-8"))

    assert report["available_sections"]["task_meta"] is True
    assert report["available_sections"]["ip_layer"] is False
    assert report["high_level_status"]["ip_success"] is None
    assert report["high_level_status"]["http_success_observed"] is None
    assert report["missing_or_invalid_files"]


def test_generate_task_report_bad_json(tmp_path: Path) -> None:
    """Invalid JSON artifacts are recorded and skipped."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir()
    _write_json(task_dir / "task_meta.json", {"task_id": "task_20260101_010203"})
    (task_dir / "http_summary.json").write_text("{bad json", encoding="utf-8")

    output = generate_task_report(task_dir)
    report = json.loads(output.read_text(encoding="utf-8"))

    invalid_files = {item["file"] for item in report["missing_or_invalid_files"]}
    assert "http_summary.json" in invalid_files
    assert report["application_layer"]["http_summary"] == {}
