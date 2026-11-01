"""Shared utility placeholders for packet_collector.

Step 1 keeps utilities hardware-independent. Command helpers return a planned
command structure and do not execute system commands.
"""

from __future__ import annotations

import time
from pathlib import Path


def utc_timestamp() -> float:
    """Return the current Unix timestamp in UTC seconds."""
    return time.time()


def ensure_dir(path: Path) -> Path:
    """Create a directory if needed and return it."""
    path.mkdir(parents=True, exist_ok=True)
    return path


def run_command_placeholder(command: list[str]) -> dict[str, object]:
    """Return a placeholder command result without executing anything."""
    return {
        "command": command,
        "executed": False,
        "returncode": None,
        "stdout": "",
        "stderr": "TODO: command execution is disabled in Step 1",
    }
