"""Tests for HTTP active probe."""

from __future__ import annotations

import urllib.error
import urllib.request

from packet_collector.probes.http_probe import run_http_probe


class FakeResponse:
    """Small context-manager response for urlopen tests."""

    status = 200
    reason = "OK"
    headers = {"Content-Type": "text/plain", "Content-Length": "5"}

    def __enter__(self):
        return self

    def __exit__(self, exc_type, exc, tb):
        return False

    def read(self, size: int) -> bytes:
        return b"hello"


def test_run_http_probe_success(monkeypatch) -> None:
    """HTTP probe reads status, headers, and a small body."""

    def fake_urlopen(request, timeout):
        return FakeResponse()

    monkeypatch.setattr(urllib.request, "urlopen", fake_urlopen)
    result = run_http_probe("http://example.com", timeout=1)

    assert result["success"] is True
    assert result["status_code"] == 200
    assert result["content_type"] == "text/plain"
    assert result["content_length"] == 5
    assert result["bytes_read"] == 5


def test_run_http_probe_http_error(monkeypatch) -> None:
    """HTTPError is treated as an HTTP response."""

    def fake_urlopen(request, timeout):
        raise urllib.error.HTTPError("http://example.com", 404, "Not Found", {"Content-Type": "text/html"}, None)

    monkeypatch.setattr(urllib.request, "urlopen", fake_urlopen)
    result = run_http_probe("http://example.com")

    assert result["success"] is False
    assert result["status_code"] == 404
    assert result["content_type"] == "text/html"
    assert result["error"] is not None


def test_run_http_probe_url_error(monkeypatch) -> None:
    """URLError returns a failed result."""

    def fake_urlopen(request, timeout):
        raise urllib.error.URLError("mock network failure")

    monkeypatch.setattr(urllib.request, "urlopen", fake_urlopen)
    result = run_http_probe("http://example.com")

    assert result["success"] is False
    assert "mock network failure" in result["error"]
