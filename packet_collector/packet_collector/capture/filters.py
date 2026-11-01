"""BPF capture filter generation.

This module converts packet type, IP addresses, direction, and port into
dumpcap-compatible BPF filters. It is pure Python and safe to test without
Raspberry Pi hardware.
"""

from __future__ import annotations


def _build_direction_filter(pi_ip: str, peer_ip: str, direction: str) -> str:
    """Build the host part of a BPF filter."""
    if direction == "in":
        return f"src host {peer_ip} and dst host {pi_ip}"
    if direction == "out":
        return f"src host {pi_ip} and dst host {peer_ip}"
    if direction == "both":
        return f"host {pi_ip} and host {peer_ip}"
    raise ValueError(f"Unsupported direction: {direction}")


def _build_packet_type_filter(packet_type: str, port: int | None = None) -> str:
    """Build the packet type part of a BPF filter."""
    packet_type = packet_type.lower()
    if packet_type == "all":
        return ""
    if packet_type in {"tcp", "udp", "icmp"}:
        return packet_type

    default_ports = {
        "http": 80,
        "https": 443,
        "dns": 53,
    }
    if packet_type not in default_ports:
        raise ValueError(f"Unsupported packet_type: {packet_type}")

    selected_port = port if port is not None else default_ports[packet_type]
    protocol_map = {
        "http": "tcp",
        "https": "tcp",
        "dns": "udp",
    }
    return f"{protocol_map[packet_type]} and port {selected_port}"


def build_capture_filter(
    packet_type: str,
    pi_ip: str | None,
    peer_ip: str | None,
    direction: str = "in",
    port: int | None = None,
    capture_mode: str = "two_host",
) -> str:
    """Build a BPF capture filter string.

    Raises:
        ValueError: If `packet_type` or `direction` is unsupported.
    """
    if capture_mode == "iface_only":
        if packet_type.lower() == "all":
            return f"port {port}" if port is not None else ""
        packet_part = _build_packet_type_filter(packet_type=packet_type, port=port)
        if port is not None and "port " not in packet_part and packet_type.lower() in {"tcp", "udp"}:
            return f"{packet_part} and port {port}"
        return packet_part

    if capture_mode == "peer_only":
        if not peer_ip:
            raise ValueError("peer_ip is required for peer_only capture mode")
        host_part = f"host {peer_ip}"
        if packet_type.lower() == "all":
            return f"{host_part} and port {port}" if port is not None else host_part
        packet_part = _build_packet_type_filter(packet_type=packet_type, port=port)
        if port is not None and "port " not in packet_part and packet_type.lower() in {"tcp", "udp"}:
            packet_part = f"{packet_part} and port {port}"
        return f"{host_part} and {packet_part}"

    if capture_mode != "two_host":
        raise ValueError(f"Unsupported capture_mode: {capture_mode}")
    if not pi_ip or not peer_ip:
        raise ValueError("pi_ip and peer_ip are required for two_host capture mode")
    direction_part = _build_direction_filter(pi_ip=pi_ip, peer_ip=peer_ip, direction=direction)
    packet_part = _build_packet_type_filter(packet_type=packet_type, port=port)
    if not packet_part:
        return direction_part
    return f"{direction_part} and {packet_part}"


def build_bpf_filter(
    protocol: str,
    pi_ip: str,
    peer_ip: str,
    port: int | None = None,
    direction: str = "in",
) -> str:
    """Backward-compatible alias for older placeholders."""
    return build_capture_filter(protocol, pi_ip, peer_ip, direction=direction, port=port)
