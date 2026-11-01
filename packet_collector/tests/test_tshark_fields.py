"""Tests for tshark field mapping."""

from __future__ import annotations

from packet_collector.parsers.tshark_fields import get_display_filter, get_fields_for_packet_type


def _tshark_fields(packet_type: str) -> list[str]:
    """Return tshark field names for assertions."""
    return [field for _, field in get_fields_for_packet_type(packet_type)]


def test_tcp_fields_include_stream() -> None:
    """TCP fields include stream ID."""
    assert "tcp.stream" in _tshark_fields("tcp")


def test_http_fields_include_method() -> None:
    """HTTP fields include request method."""
    assert "http.request.method" in _tshark_fields("http")


def test_dns_fields_include_query_name() -> None:
    """DNS fields include query name."""
    assert "dns.qry.name" in _tshark_fields("dns")


def test_https_fields_include_sni() -> None:
    """HTTPS fields include TLS SNI."""
    assert "tls.handshake.extensions_server_name" in _tshark_fields("https")


def test_all_fields_include_four_layer_packet_fields() -> None:
    """All-mode parsing includes transport and application metadata fields."""
    fields = _tshark_fields("all")
    assert "tcp.stream" in fields
    assert "udp.length" in fields
    assert "icmp.type" in fields
    assert "dns.qry.name" in fields
    assert "http.request.method" in fields
    assert "tls.handshake.extensions_server_name" in fields


def test_unsupported_packet_type_raises() -> None:
    """Unsupported packet types raise ValueError."""
    try:
        get_fields_for_packet_type("ftp")
    except ValueError:
        return
    raise AssertionError("Expected ValueError")


def test_display_filter_values() -> None:
    """Display filters are mapped by packet type."""
    assert get_display_filter("tcp") == "tcp"
    assert get_display_filter("udp") == "udp"
    assert get_display_filter("icmp") == "icmp"
    assert get_display_filter("http") == "http"
    assert get_display_filter("https") == "tls or tcp"
    assert get_display_filter("dns") == "dns"
    assert get_display_filter("all") == ""
