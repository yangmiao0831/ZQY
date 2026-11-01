"""DNS active probe.

This probe uses Python's socket resolver. A custom DNS server can be recorded
in the result, but the standard library resolver does not let us select it.
"""

from __future__ import annotations

import socket
import time


def _finish(result: dict[str, object], start: float) -> dict[str, object]:
    """Fill end time and duration fields."""
    end = time.time()
    result["end_time_epoch"] = end
    result["duration_ms"] = (end - start) * 1000
    return result


def run_dns_probe(domain: str, dns_server: str | None = None, timeout: float = 5.0) -> dict[str, object]:
    """Resolve a domain with the system resolver and return a structured result."""
    start = time.time()
    result: dict[str, object] = {
        "probe_type": "dns",
        "domain": domain,
        "dns_server": dns_server,
        "dns_server_used": False,
        "success": False,
        "start_time_epoch": start,
        "end_time_epoch": None,
        "duration_ms": None,
        "addresses": [],
        "address_count": 0,
        "error": None,
    }
    if dns_server is not None:
        result["note"] = "custom dns_server is recorded but not directly used by socket.getaddrinfo"

    old_timeout = socket.getdefaulttimeout()
    try:
        socket.setdefaulttimeout(timeout)
        infos = socket.getaddrinfo(domain, None)
        addresses = sorted({info[4][0] for info in infos if info and info[4]})
        result["addresses"] = addresses
        result["address_count"] = len(addresses)
        result["success"] = bool(addresses)
        result["error"] = None if addresses else "no addresses returned"
    except Exception as exc:
        result["error"] = str(exc)
    finally:
        socket.setdefaulttimeout(old_timeout)

    return _finish(result, start)


def dns_probe_placeholder(domain: str) -> dict[str, object]:
    """Backward-compatible wrapper."""
    return run_dns_probe(domain)
