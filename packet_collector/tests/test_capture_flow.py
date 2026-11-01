"""Tests for the Step 2 capture flow without real dumpcap."""

from __future__ import annotations

import json
from pathlib import Path

import pytest

from packet_collector.capture.capture import run_capture_task


def test_run_capture_task_dry_run(tmp_path: Path) -> None:
    """Dry-run creates task metadata but does not require pcap files."""
    task = run_capture_task(
        packet_type="tcp",
        pi_ip="192.168.1.10",
        peer_ip="192.168.1.20",
        direction="both",
        iface="wlan-test0",
        final_base_dir=tmp_path / "captures",
        tmp_capture_dir=tmp_path / "tmp",
        file_size_kb=51200,
        max_files=20,
        duration=10,
        execute=False,
    )

    meta_path = task.task_dir / "task_meta.json"
    metadata = json.loads(meta_path.read_text(encoding="utf-8"))
    assert task.task_dir.exists()
    assert metadata["status"] == "planned"
    assert metadata["pcap_files"] == []
    assert task.pcap_files == []


def test_run_capture_task_execute_success(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """Successful capture copies fake pcapng files into the final task dir."""

    def fake_run_dumpcap(command: list[str]) -> int:
        output_file = Path(command[command.index("-w") + 1])
        output_file.write_bytes(b"fake pcapng")
        return 0

    monkeypatch.setattr("packet_collector.capture.capture.run_dumpcap", fake_run_dumpcap)

    task = run_capture_task(
        packet_type="tcp",
        pi_ip="192.168.1.10",
        peer_ip="192.168.1.20",
        direction="in",
        iface="wlan-test0",
        final_base_dir=tmp_path / "captures",
        tmp_capture_dir=tmp_path / "tmp",
        file_size_kb=51200,
        max_files=20,
        duration=10,
        execute=True,
    )

    metadata = json.loads((task.task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert task.status == "completed"
    assert metadata["status"] == "completed"
    assert metadata["returncode"] == 0
    assert metadata["pcap_files"]
    assert task.pcap_files
    assert task.pcap_files[0].exists()


def test_run_capture_task_execute_failure(monkeypatch: pytest.MonkeyPatch, tmp_path: Path) -> None:
    """Failed capture writes failed task metadata and re-raises the error."""

    def fake_run_dumpcap(command: list[str]) -> int:
        raise RuntimeError("mock dumpcap failed")

    monkeypatch.setattr("packet_collector.capture.capture.run_dumpcap", fake_run_dumpcap)

    with pytest.raises(RuntimeError, match="mock dumpcap failed"):
        run_capture_task(
            packet_type="tcp",
            pi_ip="192.168.1.10",
            peer_ip="192.168.1.20",
            direction="in",
            iface="wlan-test0",
            final_base_dir=tmp_path / "captures",
            tmp_capture_dir=tmp_path / "tmp",
            file_size_kb=51200,
            max_files=20,
            duration=10,
            execute=True,
        )

    task_dirs = list((tmp_path / "captures").iterdir())
    assert len(task_dirs) == 1
    metadata = json.loads((task_dirs[0] / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["status"] == "failed"
    assert metadata["error"] == "mock dumpcap failed"
