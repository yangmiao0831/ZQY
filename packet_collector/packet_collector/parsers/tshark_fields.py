"""tshark field definitions for packet JSONL records.

The parser uses tshark `-T fields` output and maps tshark field names to stable
JSON keys. Field selection is scoped by packet type and remains limited to raw
packet records in Step 3; no summaries are computed here.
"""

from __future__ import annotations


FieldSpec = tuple[str, str]


COMMON_FIELDS: list[FieldSpec] = [
    ("time_epoch", "frame.time_epoch"),
    ("frame_len", "frame.len"),
    ("src_ip", "ip.src"),
    ("dst_ip", "ip.dst"),
    ("protocols", "frame.protocols"),
]

TCP_FIELDS: list[FieldSpec] = [
    ("src_port", "tcp.srcport"),
    ("dst_port", "tcp.dstport"),
    ("tcp_len", "tcp.len"),
    ("tcp_flags", "tcp.flags"),
    ("tcp_stream", "tcp.stream"),
    ("tcp_retransmission", "tcp.analysis.retransmission"),
    ("tcp_fast_retransmission", "tcp.analysis.fast_retransmission"),
    ("tcp_out_of_order", "tcp.analysis.out_of_order"),
    ("tcp_ack_rtt", "tcp.analysis.ack_rtt"),
]

UDP_FIELDS: list[FieldSpec] = [
    ("src_port", "udp.srcport"),
    ("dst_port", "udp.dstport"),
    ("udp_length", "udp.length"),
]

ICMP_FIELDS: list[FieldSpec] = [
    ("icmp_type", "icmp.type"),
    ("icmp_code", "icmp.code"),
]

HTTP_EXTRA_FIELDS: list[FieldSpec] = [
    ("http_method", "http.request.method"),
    ("http_host", "http.host"),
    ("http_uri", "http.request.uri"),
    ("http_user_agent", "http.user_agent"),
    ("http_status_code", "http.response.code"),
    ("http_content_length", "http.content_length"),
    ("http_content_type", "http.content_type"),
]

DNS_EXTRA_FIELDS: list[FieldSpec] = [
    ("dns_query_name", "dns.qry.name"),
    ("dns_query_type", "dns.qry.type"),
    ("dns_response_code", "dns.flags.rcode"),
    ("dns_answer_ipv4", "dns.a"),
    ("dns_answer_ipv6", "dns.aaaa"),
]

TLS_EXTRA_FIELDS: list[FieldSpec] = [
    ("tls_handshake_type", "tls.handshake.type"),
    ("tls_sni", "tls.handshake.extensions_server_name"),
    ("tls_record_version", "tls.record.version"),
    ("tls_handshake_version", "tls.handshake.version"),
]

HTTP_FIELDS: list[FieldSpec] = TCP_FIELDS + HTTP_EXTRA_FIELDS
DNS_FIELDS: list[FieldSpec] = UDP_FIELDS + DNS_EXTRA_FIELDS
TLS_FIELDS: list[FieldSpec] = TCP_FIELDS + TLS_EXTRA_FIELDS
ALL_FIELDS: list[FieldSpec] = (
    TCP_FIELDS
    + UDP_FIELDS
    + ICMP_FIELDS
    + HTTP_EXTRA_FIELDS
    + DNS_EXTRA_FIELDS
    + TLS_EXTRA_FIELDS
)


def get_fields_for_packet_type(packet_type: str) -> list[FieldSpec]:
    """Return JSON key and tshark field pairs for a packet type."""
    packet_type = packet_type.lower()
    fields_by_type: dict[str, list[FieldSpec]] = {
        "tcp": TCP_FIELDS,
        "udp": UDP_FIELDS,
        "icmp": ICMP_FIELDS,
        "http": HTTP_FIELDS,
        "https": TLS_FIELDS,
        "dns": DNS_FIELDS,
        "all": ALL_FIELDS,
    }
    if packet_type not in fields_by_type:
        raise ValueError(f"Unsupported packet_type: {packet_type}")
    return COMMON_FIELDS + fields_by_type[packet_type]


def get_display_filter(packet_type: str) -> str:
    """Return a tshark display filter for a packet type."""
    packet_type = packet_type.lower()
    filters = {
        "tcp": "tcp",
        "udp": "udp",
        "icmp": "icmp",
        "http": "http",
        "https": "tls or tcp",
        "dns": "dns",
        "all": "",
    }
    if packet_type not in filters:
        raise ValueError(f"Unsupported packet_type: {packet_type}")
    return filters[packet_type]


def get_fields_for_protocol(protocol: str) -> list[str]:
    """Backward-compatible helper returning only tshark field names."""
    return [field for _, field in get_fields_for_packet_type(protocol)]
