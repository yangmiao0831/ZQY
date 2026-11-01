"""Locate bundled and system packet-capture executables."""

from __future__ import annotations

import os
import shutil
from pathlib import Path


PROJECT_DIR = Path(__file__).resolve().parents[1]


def _wireshark_directories() -> list[Path]:
    directories: list[Path] = []
    configured = os.environ.get("PACKET_COLLECTOR_WIRESHARK_DIR")
    if configured:
        directories.append(Path(configured).expanduser())
    directories.extend(
        [
            PROJECT_DIR / "Wireshark",
            PROJECT_DIR.parent / "Wireshark",
        ]
    )
    if os.name == "nt":
        for variable in ("ProgramFiles", "ProgramFiles(x86)"):
            base = os.environ.get(variable)
            if base:
                directories.append(Path(base) / "Wireshark")
    return directories


def resolve_tool(command: str) -> str | None:
    """Resolve a command, preferring a bundled Wireshark directory."""
    supplied = Path(command)
    if supplied.parent != Path(".") and supplied.is_file():
        return str(supplied.resolve())

    names = [command]
    if os.name == "nt" and not command.lower().endswith(".exe"):
        names.insert(0, f"{command}.exe")
    for directory in _wireshark_directories():
        for name in names:
            candidate = directory / name
            if candidate.is_file():
                return str(candidate.resolve())
    return shutil.which(command)


def resolve_command(command: list[str]) -> list[str]:
    """Return a copy with the executable replaced by its resolved path."""
    if not command:
        raise ValueError("command must not be empty")
    resolved = resolve_tool(command[0])
    return [resolved or command[0], *command[1:]]
