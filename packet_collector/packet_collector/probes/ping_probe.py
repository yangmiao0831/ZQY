"""Ping active probe.

The probe uses the system `ping` command and returns a structured result
instead of raising network or subprocess exceptions to callers.
"""

from __future__ import annotations

import re
import platform
import subprocess
import time


_LOSS_RE = re.compile(r"(?P<loss>\d+(?:\.\d+)?)%\s+packet loss")
_RTT_RE = re.compile(
    r"(?:rtt|round-trip).*?=\s*"
    r"(?P<min>\d+(?:\.\d+)?)/(?P<avg>\d+(?:\.\d+)?)/"
    r"(?P<max>\d+(?:\.\d+)?)/(?P<mdev>\d+(?:\.\d+)?)\s*ms"
)
_WINDOWS_LOSS_RE = re.compile(r"\((?P<loss>\d+(?:\.\d+)?)%[^)]*\)")
_WINDOWS_TIME_RE = re.compile(r"(?:time|时间)[=<]\s*(?P<time>\d+(?:\.\d+)?)\s*ms", re.IGNORECASE)
_WINDOWS_MIN_RE = re.compile(r"(?:Minimum|最短)\s*=\s*(?P<value>\d+(?:\.\d+)?)\s*ms", re.IGNORECASE)
_WINDOWS_MAX_RE = re.compile(r"(?:Maximum|最长)\s*=\s*(?P<value>\d+(?:\.\d+)?)\s*ms", re.IGNORECASE)
_WINDOWS_AVG_RE = re.compile(r"(?:Average|平均)\s*=\s*(?P<value>\d+(?:\.\d+)?)\s*ms", re.IGNORECASE)


def _base_result(target: str, count: int, timeout: int, start: float) -> dict[str, object]:
    """Create a base ping result."""
    return {
        "probe_type": "ping",
        "target": target,
        "success": False,
        "start_time_epoch": start,
        "end_time_epoch": None,
        "duration_ms": None,
        "count": count,
        "timeout": timeout,
        "packet_loss_percent": None,
        "rtt_min_ms": None,
        "rtt_avg_ms": None,
        "rtt_max_ms": None,
        "rtt_mdev_ms": None,
        "returncode": None,
        "stdout": "",
        "stderr": "",
        "error": None,
    }


def _finish(result: dict[str, object], start: float) -> dict[str, object]:
    """Fill end time and duration fields."""
    end = time.time()
    result["end_time_epoch"] = end
    result["duration_ms"] = (end - start) * 1000
    return result


def _parse_ping_output(result: dict[str, object], stdout: str) -> None:
    """Parse packet loss and RTT details from Linux or Windows ping output."""
    loss_match = _LOSS_RE.search(stdout)
    if loss_match:
        result["packet_loss_percent"] = float(loss_match.group("loss"))

    rtt_match = _RTT_RE.search(stdout)
    if rtt_match:
        result["rtt_min_ms"] = float(rtt_match.group("min"))
        result["rtt_avg_ms"] = float(rtt_match.group("avg"))
        result["rtt_max_ms"] = float(rtt_match.group("max"))
        result["rtt_mdev_ms"] = float(rtt_match.group("mdev"))
        return

    windows_loss = _WINDOWS_LOSS_RE.search(stdout)
    if windows_loss and result["packet_loss_percent"] is None:
        result["packet_loss_percent"] = float(windows_loss.group("loss"))

    reply_times = [float(match.group("time")) for match in _WINDOWS_TIME_RE.finditer(stdout)]
    minimum = _WINDOWS_MIN_RE.search(stdout)
    maximum = _WINDOWS_MAX_RE.search(stdout)
    average = _WINDOWS_AVG_RE.search(stdout)
    if minimum:
        result["rtt_min_ms"] = float(minimum.group("value"))
    elif reply_times:
        result["rtt_min_ms"] = min(reply_times)
    if maximum:
        result["rtt_max_ms"] = float(maximum.group("value"))
    elif reply_times:
        result["rtt_max_ms"] = max(reply_times)
    if average:
        result["rtt_avg_ms"] = float(average.group("value"))
    elif reply_times:
        result["rtt_avg_ms"] = sum(reply_times) / len(reply_times)


def run_ping_probe(target: str, count: int = 4, timeout: int = 5) -> dict[str, object]:
    """Run a ping probe and return a structured result."""
    start = time.time()
    result = _base_result(target, count, timeout, start)
    if platform.system() == "Windows":
        command = ["ping", "-n", str(count), "-w", str(max(1, timeout) * 1000), target]
    else:
        command = ["ping", "-c", str(count), "-W", str(timeout), target]

    try:
        completed = subprocess.run(command, capture_output=True, text=True, check=False)
    except FileNotFoundError:
        result["error"] = "ping command not found"
        return _finish(result, start)
    except Exception as exc:
        result["error"] = str(exc)
        return _finish(result, start)

    stdout = completed.stdout or ""
    stderr = completed.stderr or ""
    result["stdout"] = stdout
    result["stderr"] = stderr
    result["returncode"] = completed.returncode
    _parse_ping_output(result, stdout)
    result["success"] = completed.returncode == 0
    result["error"] = None if result["success"] else (stderr.strip() or f"ping failed with returncode {completed.returncode}")
    return _finish(result, start)


def ping_probe_placeholder(target: str) -> dict[str, object]:
    """Backward-compatible wrapper."""
    return run_ping_probe(target)
