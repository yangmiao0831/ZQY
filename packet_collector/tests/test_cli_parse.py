"""Tests for CLI parse command helpers without real tshark."""

from __future__ import annotations

import argparse
import json
from pathlib import Path

import packet_collector.cli as cli


def test_cli_parse_updates_task_meta(monkeypatch, tmp_path: Path) -> None:
    """CLI parse helper updates task metadata after mocked parsing."""
    task_dir = tmp_path / "task_20260101_010203"
    task_dir.mkdir(parents=True)
    pcap_file = task_dir / "capture.pcapng"
    pcap_file.write_bytes(b"")
    (task_dir / "task_meta.json").write_text(
        json.dumps({"pcap_files": [str(pcap_file)]}),
        encoding="utf-8",
    )

    def fake_parse_pcap_files_to_jsonl(pcap_files: list[Path], output_file: Path, packet_type: str) -> Path:
        output_file.write_text('{"packet_type":"tcp"}\n', encoding="utf-8")
        return output_file

    monkeypatch.setattr(cli, "parse_pcap_files_to_jsonl", fake_parse_pcap_files_to_jsonl)

    args = argparse.Namespace(task_dir=str(task_dir), packet_type="tcp", output=None)
    cli._run_parse_command(args)

    metadata = json.loads((task_dir / "task_meta.json").read_text(encoding="utf-8"))
    assert metadata["parse_status"] == "completed"
    assert metadata["parse_error"] is None
    assert metadata["packets_jsonl"].endswith("packets.jsonl")
