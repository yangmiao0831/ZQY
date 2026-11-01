"""Import tests for Step 1 package modules."""

from __future__ import annotations

import importlib


def test_core_modules_import() -> None:
    """Main modules can be imported without Raspberry Pi hardware."""
    modules = [
        "packet_collector.cli",
        "packet_collector.task_manager",
        "packet_collector.capture.filters",
        "packet_collector.capture.dumpcap_runner",
        "packet_collector.parsers.pcap_to_json",
        "packet_collector.parsers.tshark_fields",
        "packet_collector.parsers.tshark_runner",
        "packet_collector.analyzers.tcp_analyzer",
        "packet_collector.analyzers.udp_analyzer",
        "packet_collector.analyzers.icmp_analyzer",
        "packet_collector.analyzers.http_analyzer",
        "packet_collector.analyzers.dns_analyzer",
        "packet_collector.analyzers.tls_analyzer",
        "packet_collector.collectors.device_collector",
        "packet_collector.collectors.ip_collector",
        "packet_collector.collectors.wifi_collector",
        "packet_collector.storage.file_manager",
        "packet_collector.probes.ping_probe",
        "packet_collector.probes.dns_probe",
        "packet_collector.probes.http_probe",
        "packet_collector.probes.tls_probe",
    ]
    for module in modules:
        assert importlib.import_module(module)
