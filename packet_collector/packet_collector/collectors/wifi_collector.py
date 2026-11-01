"""Wi-Fi access metric collector.

Future implementation will collect SSID, BSSID, RSSI, link rate, frequency,
channel, noise, retries, and roaming-related signals.
"""

from __future__ import annotations


def collect_wifi_metrics_placeholder(iface: str) -> dict[str, object]:
    """Collect Wi-Fi access metrics placeholder."""
    print(f"TODO: collect SSID, BSSID, signal, rate, and frequency metrics on {iface}")
    return {"iface": iface}
