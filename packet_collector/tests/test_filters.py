"""Tests for BPF capture filter generation."""

from __future__ import annotations

from packet_collector.capture.filters import build_capture_filter


def test_tcp_in_filter() -> None:
    """TCP inbound filter uses peer as source and Pi as destination."""
    result = build_capture_filter("tcp", "192.168.1.10", "192.168.1.20", "in")
    assert result == "src host 192.168.1.20 and dst host 192.168.1.10 and tcp"


def test_tcp_out_filter() -> None:
    """TCP outbound filter uses Pi as source and peer as destination."""
    result = build_capture_filter("tcp", "192.168.1.10", "192.168.1.20", "out")
    assert result == "src host 192.168.1.10 and dst host 192.168.1.20 and tcp"


def test_tcp_both_filter() -> None:
    """TCP bidirectional filter uses both hosts."""
    result = build_capture_filter("tcp", "192.168.1.10", "192.168.1.20", "both")
    assert result == "host 192.168.1.10 and host 192.168.1.20 and tcp"


def test_http_default_port() -> None:
    """HTTP defaults to TCP port 80."""
    result = build_capture_filter("http", "192.168.1.10", "192.168.1.20", "in")
    assert result == "src host 192.168.1.20 and dst host 192.168.1.10 and tcp and port 80"


def test_http_custom_port() -> None:
    """HTTP accepts a custom port."""
    result = build_capture_filter("http", "192.168.1.10", "192.168.1.20", "in", port=8080)
    assert result == "src host 192.168.1.20 and dst host 192.168.1.10 and tcp and port 8080"


def test_https_default_port() -> None:
    """HTTPS defaults to TCP port 443."""
    result = build_capture_filter("https", "192.168.1.10", "192.168.1.20", "in")
    assert result == "src host 192.168.1.20 and dst host 192.168.1.10 and tcp and port 443"


def test_dns_default_port() -> None:
    """DNS defaults to UDP port 53."""
    result = build_capture_filter("dns", "192.168.1.10", "192.168.1.20", "in")
    assert result == "src host 192.168.1.20 and dst host 192.168.1.10 and udp and port 53"


def test_all_both_filter_has_no_protocol_limit() -> None:
    """All-mode capture only limits the two hosts and keeps every protocol."""
    result = build_capture_filter("all", "192.168.1.10", "192.168.1.20", "both")
    assert result == "host 192.168.1.10 and host 192.168.1.20"


def test_unsupported_packet_type() -> None:
    """Unsupported packet types raise ValueError."""
    try:
        build_capture_filter("ftp", "192.168.1.10", "192.168.1.20")
    except ValueError:
        return
    raise AssertionError("Expected ValueError for unsupported packet_type")


def test_unsupported_direction() -> None:
    """Unsupported directions raise ValueError."""
    try:
        build_capture_filter("tcp", "192.168.1.10", "192.168.1.20", "sideways")
    except ValueError:
        return
    raise AssertionError("Expected ValueError for unsupported direction")
