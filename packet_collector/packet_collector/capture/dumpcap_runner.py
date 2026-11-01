"""dumpcap command builder and runner.

Step 2 uses this module to build and execute dumpcap commands. Parsing remains
out of scope, and this module never calls tshark.
"""

from __future__ import annotations

import subprocess
import shutil
from pathlib import Path

from packet_collector.tool_paths import resolve_command


def build_dumpcap_command(
    iface: str,
    capture_filter: str | None,
    output_file: Path,
    file_size_kb: int | None,
    max_files: int | None,
    duration: int | None = None,
    rotation_duration: float | None = None,
) -> list[str]:
    """Build a dumpcap command without executing it."""
    command = [
        "dumpcap",
        "-i",
        iface,
    ]
    if capture_filter:
        command.extend(["-f", capture_filter])
    if file_size_kb is not None:
        command.extend(["-b", f"filesize:{file_size_kb}"])
    if max_files is not None:
        command.extend(["-b", f"files:{max_files}"])
    if rotation_duration is not None:
        command.extend(["-b", f"duration:{rotation_duration:g}"])
    command.extend(["-w", str(output_file)])
    if duration is not None:
        command.extend(["-a", f"duration:{duration}"])
    return command


def start_dumpcap(command: list[str]) -> subprocess.Popen[str]:
    """Start dumpcap without waiting so closed rotation files can be consumed."""
    try:
        return subprocess.Popen(
            resolve_command(command),
            stdout=subprocess.DEVNULL,
            stderr=subprocess.PIPE,
            text=True,
        )
    except FileNotFoundError as exc:
        raise RuntimeError("dumpcap not found. Please install tshark/wireshark-common.") from exc
    except PermissionError as exc:
        raise RuntimeError(
            "dumpcap permission denied. Run with sudo or configure dumpcap capabilities."
        ) from exc


def merge_pcap_files(input_files: list[Path], output_file: Path) -> Path:
    """Merge closed pcapng segments into one archive pcapng file."""
    if not input_files:
        raise ValueError("input_files must not be empty")
    output_file.parent.mkdir(parents=True, exist_ok=True)
    if len(input_files) == 1:
        shutil.copy2(input_files[0], output_file)
        return output_file

    command = resolve_command(["mergecap", "-w", str(output_file), *(str(path) for path in input_files)])
    try:
        result = subprocess.run(command, check=False, capture_output=True, text=True)
    except FileNotFoundError as exc:
        raise RuntimeError("mergecap not found. Please install tshark/wireshark-common.") from exc
    except PermissionError as exc:
        raise RuntimeError("mergecap permission denied.") from exc
    if result.returncode != 0:
        message = f"mergecap failed with returncode {result.returncode}"
        if result.stderr:
            message = f"{message}: {result.stderr.strip()}"
        raise RuntimeError(message)
    return output_file


def run_dumpcap(command: list[str], timeout: int | None = None) -> int:
    """Run dumpcap and return its process return code."""
    try:
        result = subprocess.run(
            resolve_command(command),
            check=False,
            capture_output=True,
            text=True,
            timeout=timeout,
        )
    except FileNotFoundError as exc:
        raise RuntimeError("dumpcap not found. Please install tshark/wireshark-common.") from exc
    except PermissionError as exc:
        raise RuntimeError(
            "dumpcap permission denied. Run with sudo or configure dumpcap capabilities."
        ) from exc

    if result.returncode != 0:
        message = f"dumpcap failed with returncode {result.returncode}"
        if result.stderr:
            message = f"{message}: {result.stderr.strip()}"
        raise RuntimeError(message)
    return result.returncode


def ensure_tmp_capture_dir(tmp_dir: Path) -> Path:
    """Create the temporary capture directory and relax permissions if possible."""
    tmp_dir.mkdir(parents=True, exist_ok=True)
    try:
        tmp_dir.chmod(0o777)
    except PermissionError:
        pass
    return tmp_dir
