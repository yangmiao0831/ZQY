"""HTTP active probe.

The probe uses urllib from the Python standard library, reads at most a small
body prefix, and returns structured success or failure details.
"""

from __future__ import annotations

import time
import urllib.error
import urllib.request


def _finish(result: dict[str, object], start: float) -> dict[str, object]:
    """Fill end time and duration fields."""
    end = time.time()
    result["end_time_epoch"] = end
    result["duration_ms"] = (end - start) * 1000
    return result


def _header_int(headers: object, name: str) -> int | None:
    """Read an integer header value when possible."""
    value = headers.get(name) if hasattr(headers, "get") else None
    if value in (None, ""):
        return None
    try:
        return int(value)
    except (TypeError, ValueError):
        return None


def _header_str(headers: object, name: str) -> str | None:
    """Read a string header value when possible."""
    value = headers.get(name) if hasattr(headers, "get") else None
    return str(value) if value not in (None, "") else None


def _base_result(url: str, method: str, start: float) -> dict[str, object]:
    """Create a base HTTP probe result."""
    return {
        "probe_type": "http",
        "url": url,
        "method": method,
        "success": False,
        "start_time_epoch": start,
        "end_time_epoch": None,
        "duration_ms": None,
        "status_code": None,
        "reason": None,
        "content_type": None,
        "content_length": None,
        "bytes_read": 0,
        "error": None,
    }


def run_http_probe(url: str, timeout: float = 10.0, method: str = "GET") -> dict[str, object]:
    """Run an HTTP probe and return a structured result."""
    method = method.upper()
    start = time.time()
    result = _base_result(url, method, start)
    request = urllib.request.Request(url, method=method)

    try:
        with urllib.request.urlopen(request, timeout=timeout) as response:
            body = response.read(1024) if method != "HEAD" else b""
            status_code = int(getattr(response, "status", getattr(response, "code", 0)))
            result["status_code"] = status_code
            result["reason"] = getattr(response, "reason", None)
            result["content_type"] = _header_str(response.headers, "Content-Type")
            result["content_length"] = _header_int(response.headers, "Content-Length")
            result["bytes_read"] = len(body)
            result["success"] = 200 <= status_code < 400
            result["error"] = None if result["success"] else f"HTTP status {status_code}"
    except urllib.error.HTTPError as exc:
        result["status_code"] = exc.code
        result["reason"] = exc.reason
        result["content_type"] = _header_str(exc.headers, "Content-Type")
        result["content_length"] = _header_int(exc.headers, "Content-Length")
        result["success"] = 200 <= exc.code < 400
        result["error"] = None if result["success"] else str(exc)
    except urllib.error.URLError as exc:
        result["error"] = str(exc.reason)
    except Exception as exc:
        result["error"] = str(exc)

    return _finish(result, start)


def http_probe_placeholder(url: str) -> dict[str, object]:
    """Backward-compatible wrapper."""
    return run_http_probe(url)
