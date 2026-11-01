"""Dataclass models for packet_collector.

The models stay lightweight while documenting the data shape for capture tasks,
packet records, summaries, and future Wi-Fi scope metrics.
"""

from __future__ import annotations

from dataclasses import dataclass, field
from pathlib import Path


@dataclass
class CaptureTask:
    """Capture task metadata and Step 2 capture result."""

    task_id: str
    packet_type: str
    pi_ip: str | None
    peer_ip: str | None
    direction: str
    iface: str
    capture_filter: str
    task_dir: Path
    tmp_output_file: Path
    pcap_files: list[Path] = field(default_factory=list)
    status: str = "planned"


@dataclass
class PacketRecord:
    """Parsed packet record placeholder."""

    timestamp: float | None = None
    src_ip: str | None = None
    dst_ip: str | None = None
    protocol: str | None = None
    src_port: int | None = None
    dst_port: int | None = None


@dataclass
class TcpSummary:
    """TCP metric summary placeholder."""

    packet_count: int = 0
    byte_count: int = 0
    stream_count: int = 0
    retransmission_count: int = 0
    out_of_order_count: int = 0


@dataclass
class DeviceMetric:
    """Device health metric placeholder."""

    timestamp: float
    cpu_percent: float | None = None
    memory_percent: float | None = None
    disk_percent: float | None = None
    temperature_c: float | None = None


@dataclass
class WifiMetric:
    """Wi-Fi access metric placeholder."""

    timestamp: float
    iface: str
    ssid: str | None = None
    bssid: str | None = None
    signal_dbm: int | None = None
    frequency_mhz: int | None = None
    tx_bitrate: str | None = None


@dataclass
class IpMetric:
    """IP layer metric placeholder."""

    timestamp: float
    iface: str
    ipv4: str | None = None
    gateway: str | None = None
    dns_servers: list[str] = field(default_factory=list)
