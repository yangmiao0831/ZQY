"""Platform-aware runtime defaults shared by the CLI and launchers."""

from __future__ import annotations

import os
import tempfile
from pathlib import Path


IS_WINDOWS = os.name == "nt"


def default_tmp_capture_dir() -> Path:
    """Return a writable temporary capture directory for the current OS."""
    return Path(tempfile.gettempdir()) / "packet_collector" / "captures"


def default_interface() -> str:
    """Return a conservative interface default; users should verify it."""
    return "1" if IS_WINDOWS else "wlan0"


def default_gps_port() -> str:
    """Return the conventional first GPS serial port for the current OS."""
    return "COM3" if IS_WINDOWS else "/dev/ttyUSB1"


def default_disk_path() -> str:
    """Return a valid disk root for psutil on the current OS."""
    if IS_WINDOWS:
        return Path.cwd().anchor or "C:\\"
    return "/"
