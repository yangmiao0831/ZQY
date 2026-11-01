"""Device runtime collector.

This collector gathers local device runtime metrics for the four-layer scope.
It does not collect IP-layer state, Wi-Fi access state, cellular metrics, or
diagnosis output.
"""

from __future__ import annotations

import os
import platform
import re
import subprocess
import time
from pathlib import Path

from packet_collector.platform_defaults import default_disk_path

try:
    import psutil
except ModuleNotFoundError:
    psutil = None


def get_cpu_percent() -> float | None:
    """Return CPU utilization percentage when available."""
    if psutil is None:
        return None
    try:
        return float(psutil.cpu_percent(interval=None))
    except Exception:
        return None


def get_memory_percent() -> float | None:
    """Return memory utilization percentage when available."""
    if psutil is None:
        return None
    try:
        return float(psutil.virtual_memory().percent)
    except Exception:
        return None


def get_disk_percent(path: str = "/") -> float | None:
    """Return disk utilization percentage for a path when available."""
    if psutil is None:
        return None
    try:
        return float(psutil.disk_usage(path).percent)
    except Exception:
        return None


def get_load_average() -> dict[str, object]:
    """Return system load average, or an unavailable status on unsupported systems."""
    try:
        one, five, fifteen = os.getloadavg()
    except Exception as exc:
        return {
            "available": False,
            "1min": None,
            "5min": None,
            "15min": None,
            "error": str(exc),
        }
    return {
        "available": True,
        "1min": float(one),
        "5min": float(five),
        "15min": float(fifteen),
        "error": None,
    }


def _parse_vcgencmd_temperature(output: str) -> float | None:
    """Parse `vcgencmd measure_temp` output."""
    match = re.search(r"temp=([+-]?\d+(?:\.\d+)?)", output)
    if not match:
        return None
    return float(match.group(1))


def get_temperature_c(thermal_path: Path = Path("/sys/class/thermal/thermal_zone0/temp")) -> float | None:
    """Return Raspberry Pi CPU temperature in Celsius when available."""
    try:
        if thermal_path.exists():
            raw = thermal_path.read_text(encoding="utf-8").strip()
            return float(raw) / 1000.0
    except Exception:
        return None

    try:
        completed = subprocess.run(
            ["vcgencmd", "measure_temp"],
            capture_output=True,
            text=True,
            check=False,
        )
    except FileNotFoundError:
        return None
    except Exception:
        return None

    if completed.returncode != 0:
        return None
    return _parse_vcgencmd_temperature(completed.stdout or "")


def get_time_sync_status() -> dict[str, object]:
    """Return timedatectl NTP synchronization status when available."""
    if platform.system() == "Windows":
        try:
            completed = subprocess.run(
                ["w32tm", "/query", "/status"],
                capture_output=True,
                text=True,
                check=False,
            )
        except FileNotFoundError:
            return {"available": False, "synchronized": None, "raw": None, "error": "w32tm not found"}
        except Exception as exc:
            return {"available": False, "synchronized": None, "raw": None, "error": str(exc)}
        raw = (completed.stdout or "").strip()
        return {
            "available": completed.returncode == 0,
            "synchronized": completed.returncode == 0,
            "raw": raw or None,
            "error": None if completed.returncode == 0 else ((completed.stderr or "").strip() or f"w32tm failed with returncode {completed.returncode}"),
        }
    try:
        completed = subprocess.run(
            ["timedatectl", "show", "-p", "NTPSynchronized", "--value"],
            capture_output=True,
            text=True,
            check=False,
        )
    except FileNotFoundError:
        return {
            "available": False,
            "synchronized": None,
            "raw": None,
            "error": "timedatectl not found",
        }
    except Exception as exc:
        return {
            "available": False,
            "synchronized": None,
            "raw": None,
            "error": str(exc),
        }

    raw = (completed.stdout or "").strip()
    if completed.returncode != 0:
        return {
            "available": False,
            "synchronized": None,
            "raw": raw or None,
            "error": (completed.stderr or "").strip() or f"timedatectl failed with returncode {completed.returncode}",
        }
    return {
        "available": True,
        "synchronized": raw.lower() == "yes",
        "raw": raw,
        "error": None,
    }


def get_uptime_seconds() -> float | None:
    """Return system uptime in seconds when available."""
    if psutil is None:
        return None
    try:
        return time.time() - float(psutil.boot_time())
    except Exception:
        return None


def collect_device_metrics(disk_path: str | None = None) -> dict[str, object]:
    """Collect device runtime metrics with graceful per-field degradation."""
    disk_path = disk_path or default_disk_path()
    start = time.time()
    result: dict[str, object] = {
        "collector_type": "device",
        "success": True,
        "start_time_epoch": start,
        "end_time_epoch": None,
        "duration_ms": None,
        "error": None,
        "cpu_percent": None,
        "memory_percent": None,
        "disk_percent": None,
        "load_average": None,
        "temperature_c": None,
        "time_sync": None,
        "uptime_seconds": None,
    }

    try:
        result["cpu_percent"] = get_cpu_percent()
        result["memory_percent"] = get_memory_percent()
        result["disk_percent"] = get_disk_percent(disk_path)
        result["load_average"] = get_load_average()
        result["temperature_c"] = get_temperature_c()
        result["time_sync"] = get_time_sync_status()
        result["uptime_seconds"] = get_uptime_seconds()
    except Exception as exc:
        result["success"] = False
        result["error"] = str(exc)

    end = time.time()
    result["end_time_epoch"] = end
    result["duration_ms"] = (end - start) * 1000
    return result


def collect_device_metrics_placeholder() -> dict[str, object]:
    """Backward-compatible wrapper."""
    return collect_device_metrics()
