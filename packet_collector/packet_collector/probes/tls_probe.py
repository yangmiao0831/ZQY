"""TLS active probe.

The probe performs a TCP connection and TLS handshake using the Python standard
library, then returns TLS version, cipher, and basic certificate metadata.
"""

from __future__ import annotations

import socket
import ssl
import time
from typing import Any


def _finish(result: dict[str, object], start: float) -> dict[str, object]:
    """Fill end time and duration fields."""
    end = time.time()
    result["end_time_epoch"] = end
    result["duration_ms"] = (end - start) * 1000
    return result


def _flatten_cert_name(value: Any) -> str | None:
    """Convert a certificate subject/issuer tuple into a readable string."""
    if not value:
        return None
    parts: list[str] = []
    for group in value:
        for key, item in group:
            parts.append(f"{key}={item}")
    return ", ".join(parts) if parts else None


def run_tls_probe(
    host: str,
    port: int = 443,
    timeout: float = 10.0,
    server_hostname: str | None = None,
) -> dict[str, object]:
    """Run a TLS handshake probe and return a structured result."""
    start = time.time()
    hostname = server_hostname or host
    result: dict[str, object] = {
        "probe_type": "tls",
        "host": host,
        "port": port,
        "server_hostname": hostname,
        "success": False,
        "start_time_epoch": start,
        "end_time_epoch": None,
        "duration_ms": None,
        "tls_version": None,
        "cipher": None,
        "cert_subject": None,
        "cert_issuer": None,
        "cert_not_before": None,
        "cert_not_after": None,
        "error": None,
    }

    try:
        context = ssl.create_default_context()
        with socket.create_connection((host, port), timeout=timeout) as sock:
            with context.wrap_socket(sock, server_hostname=hostname) as ssock:
                cert = ssock.getpeercert() or {}
                result["tls_version"] = ssock.version()
                cipher = ssock.cipher()
                result["cipher"] = cipher[0] if isinstance(cipher, tuple) and cipher else cipher
                result["cert_subject"] = _flatten_cert_name(cert.get("subject"))
                result["cert_issuer"] = _flatten_cert_name(cert.get("issuer"))
                result["cert_not_before"] = cert.get("notBefore")
                result["cert_not_after"] = cert.get("notAfter")
                result["success"] = True
                result["error"] = None
    except Exception as exc:
        result["error"] = str(exc)

    return _finish(result, start)


def tls_probe_placeholder(host: str, port: int = 443) -> dict[str, object]:
    """Backward-compatible wrapper."""
    return run_tls_probe(host, port=port)
