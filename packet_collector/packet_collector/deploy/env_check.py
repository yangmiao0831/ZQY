"""Raspberry Pi deployment environment checks.

The checks verify command availability, Python package availability, Python
version, platform information, and write access to capture directories. They do
not run packet capture or pcap parsing.
"""

from __future__ import annotations

import importlib
import platform
import subprocess
import sys
import time
from pathlib import Path

from packet_collector.platform_defaults import default_tmp_capture_dir
from packet_collector.tool_paths import resolve_tool


def check_command(command: str, version_args: list[str] | None = None) -> dict[str, object]:
    """Check whether a command exists and optionally collect its version line."""
    path = resolve_tool(command)
    if path is None:
        return {"available": False, "path": None, "version": None, "error": "command not found"}

    result: dict[str, object] = {"available": True, "path": path, "version": None, "error": None}
    if version_args is None:
        return result

    try:
        completed = subprocess.run(
            [path] + version_args,
            capture_output=True,
            text=True,
            check=False,
            timeout=5,
        )
    except Exception as exc:
        result["error"] = str(exc)
        return result

    output = (completed.stdout or completed.stderr or "").strip()
    if output:
        result["version"] = output.splitlines()[0]
    if completed.returncode != 0:
        result["error"] = f"version command failed with returncode {completed.returncode}"
    return result


def check_npcap() -> dict[str, object]:
    """Check the Windows Npcap kernel driver without using PowerShell."""
    if platform.system() != "Windows":
        return {"available": True, "running": None, "path": None, "version": None, "error": None}
    try:
        completed = subprocess.run(
            ["sc.exe", "query", "npcap"],
            capture_output=True,
            text=True,
            check=False,
            timeout=5,
        )
    except Exception as exc:
        return {"available": False, "running": False, "path": None, "version": None, "error": str(exc)}
    output = f"{completed.stdout or ''}\n{completed.stderr or ''}"
    running = completed.returncode == 0 and "RUNNING" in output.upper()
    return {
        "available": completed.returncode == 0,
        "running": running,
        "path": "Windows service: npcap",
        "version": None,
        "error": None if running else "Npcap service is not running",
    }


def check_python_package(import_name: str) -> dict[str, object]:
    """Check whether a Python package can be imported."""
    try:
        module = importlib.import_module(import_name)
    except Exception as exc:
        return {"available": False, "version": None, "error": str(exc)}
    version = getattr(module, "__version__", None)
    return {"available": True, "version": str(version) if version is not None else None, "error": None}


def check_path_writable(path: Path) -> dict[str, object]:
    """Check whether a directory can be created and written."""
    result: dict[str, object] = {
        "path": str(path),
        "creatable": False,
        "writable": False,
        "error": None,
    }
    try:
        path.mkdir(parents=True, exist_ok=True)
        result["creatable"] = True
        test_file = path / ".write_test"
        test_file.write_text("ok", encoding="utf-8")
        test_file.unlink()
        result["writable"] = True
    except Exception as exc:
        result["error"] = str(exc)
    return result


def _all_critical_ok(result: dict[str, object]) -> bool:
    """Return whether all critical deployment checks passed."""
    python_info = result["python"]
    commands = result["commands"]
    packages = result["python_packages"]
    paths = result["paths"]
    return bool(
        python_info["version_ok"]
        and commands["dumpcap"]["available"]
        and commands["tshark"]["available"]
        and commands["ping"]["available"]
        and commands["ip"]["available"]
        and commands["npcap"]["available"]
        and commands["npcap"]["running"] is not False
        and packages["psutil"]["available"]
        and packages["yaml"]["available"]
        and paths["tmp_capture_dir"]["writable"]
        and paths["final_capture_dir"]["writable"]
    )


def run_env_check(
    tmp_capture_dir: Path | None = None,
    final_capture_dir: Path = Path("captures"),
) -> dict[str, object]:
    """Run deployment environment checks and return a structured result."""
    tmp_capture_dir = tmp_capture_dir or default_tmp_capture_dir()
    start = time.time()
    version = platform.python_version()
    is_windows = platform.system() == "Windows"
    network_command = "ipconfig" if is_windows else "ip"
    network_version_args = None if is_windows else ["-V"]
    result: dict[str, object] = {
        "check_type": "deploy_env",
        "success": False,
        "start_time_epoch": start,
        "end_time_epoch": None,
        "duration_ms": None,
        "error": None,
        "platform": {
            "system": platform.system(),
            "machine": platform.machine(),
            "python_version": version,
        },
        "python": {
            "version_ok": sys.version_info >= (3, 10),
            "version": version,
        },
        "commands": {
            "dumpcap": check_command("dumpcap", ["--version"]),
            "tshark": check_command("tshark", ["--version"]),
            "ping": check_command("ping"),
            "ip": check_command(network_command, network_version_args),
            "mergecap": check_command("mergecap", ["--version"]),
            "npcap": check_npcap(),
        },
        "python_packages": {
            "psutil": check_python_package("psutil"),
            "yaml": check_python_package("yaml"),
            "serial": check_python_package("serial"),
            "cv2": check_python_package("cv2"),
        },
        "paths": {
            "tmp_capture_dir": check_path_writable(tmp_capture_dir),
            "final_capture_dir": check_path_writable(final_capture_dir),
        },
        "notes": [
            (
                "Install Wireshark with Npcap; run CMD as Administrator if packet capture is not permitted."
                if is_windows
                else "Real capture may require sudo or dumpcap capabilities."
            ),
            "check-env does not run packet capture or tshark parsing.",
            f"Network configuration command: {network_command}",
        ],
    }

    result["success"] = _all_critical_ok(result)
    end = time.time()
    result["end_time_epoch"] = end
    result["duration_ms"] = (end - start) * 1000
    if not result["success"]:
        result["error"] = "one or more deployment checks failed"
    return result
