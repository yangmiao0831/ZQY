"""Bundled Wireshark executable discovery tests."""

import os
from pathlib import Path

from packet_collector import tool_paths


def test_resolve_tool_prefers_configured_wireshark_dir(monkeypatch, tmp_path: Path) -> None:
    executable = tmp_path / ("dumpcap.exe" if os.name == "nt" else "dumpcap")
    executable.write_bytes(b"fake")
    monkeypatch.setenv("PACKET_COLLECTOR_WIRESHARK_DIR", str(tmp_path))

    assert tool_paths.resolve_tool("dumpcap") == str(executable.resolve())


def test_resolve_command_keeps_arguments(monkeypatch) -> None:
    monkeypatch.setattr(tool_paths, "resolve_tool", lambda command: "C:/tools/tshark.exe")
    assert tool_paths.resolve_command(["tshark", "--version"]) == ["C:/tools/tshark.exe", "--version"]
