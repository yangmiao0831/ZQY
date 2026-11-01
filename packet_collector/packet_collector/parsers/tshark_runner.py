"""tshark command builder and streaming runner.

Step 3 uses tshark `-T fields` output and streams stdout line by line so large
pcapng files do not need to be loaded into memory.
"""

from __future__ import annotations

import subprocess
from collections.abc import Iterator
from pathlib import Path

from packet_collector.parsers.tshark_fields import FieldSpec
from packet_collector.tool_paths import resolve_command


def build_tshark_fields_command(
    pcap_file: Path,
    fields: list[FieldSpec],
    display_filter: str | None = None,
) -> list[str]:
    """Build a tshark `-T fields` command without executing it."""
    command = ["tshark", "-r", str(pcap_file)]
    if display_filter:
        command.extend(["-Y", display_filter])
    command.extend(["-T", "fields", "-E", "separator=|", "-E", "occurrence=f"])
    for _, tshark_field in fields:
        command.extend(["-e", tshark_field])
    return command


def run_tshark_stream(command: list[str]) -> Iterator[str]:
    """Run tshark and yield stdout lines as they arrive."""
    try:
        process = subprocess.Popen(
            resolve_command(command),
            stdout=subprocess.PIPE,
            stderr=subprocess.PIPE,
            text=True,
        )
    except FileNotFoundError as exc:
        raise RuntimeError("tshark not found. Please install tshark.") from exc

    assert process.stdout is not None
    for line in process.stdout:
        yield line.rstrip("\n")

    stderr = ""
    if process.stderr is not None:
        stderr = process.stderr.read()
    returncode = process.wait()
    if returncode != 0:
        message = f"tshark failed with returncode {returncode}"
        if stderr:
            message = f"{message}: {stderr.strip()}"
        raise RuntimeError(message)


def build_tshark_command(pcap_file: Path, fields: list[str], output_format: str = "json") -> list[str]:
    """Backward-compatible Step 1 command builder."""
    command = ["tshark", "-r", str(pcap_file), "-T", output_format]
    for field in fields:
        command.extend(["-e", field])
    return command
