"""Tests for TLS active probe."""

from __future__ import annotations

import socket
import ssl

from packet_collector.probes.tls_probe import run_tls_probe


class FakeSocket:
    """Fake TCP socket context manager."""

    def __enter__(self):
        return self

    def __exit__(self, exc_type, exc, tb):
        return False


class FakeSSLSocket:
    """Fake SSL socket context manager."""

    def __enter__(self):
        return self

    def __exit__(self, exc_type, exc, tb):
        return False

    def version(self) -> str:
        return "TLSv1.3"

    def cipher(self):
        return ("TLS_AES_256_GCM_SHA384", "TLSv1.3", 256)

    def getpeercert(self):
        return {
            "subject": ((("commonName", "example.com"),),),
            "issuer": ((("commonName", "Example CA"),),),
            "notBefore": "Jan  1 00:00:00 2026 GMT",
            "notAfter": "Jan  1 00:00:00 2027 GMT",
        }


class FakeContext:
    """Fake SSL context."""

    def wrap_socket(self, sock, server_hostname):
        return FakeSSLSocket()


def test_run_tls_probe_success(monkeypatch) -> None:
    """TLS probe records version, cipher, and certificate metadata."""
    monkeypatch.setattr(socket, "create_connection", lambda address, timeout: FakeSocket())
    monkeypatch.setattr(ssl, "create_default_context", lambda: FakeContext())

    result = run_tls_probe("example.com", port=443)

    assert result["success"] is True
    assert result["tls_version"] == "TLSv1.3"
    assert result["cipher"] == "TLS_AES_256_GCM_SHA384"
    assert result["cert_subject"] == "commonName=example.com"
    assert result["cert_issuer"] == "commonName=Example CA"


def test_run_tls_probe_failure(monkeypatch) -> None:
    """TLS probe exceptions return a failed result."""

    def fake_create_connection(address, timeout):
        raise OSError("mock connect failure")

    monkeypatch.setattr(ssl, "create_default_context", lambda: FakeContext())
    monkeypatch.setattr(socket, "create_connection", fake_create_connection)
    result = run_tls_probe("example.com")

    assert result["success"] is False
    assert "mock connect failure" in result["error"]
