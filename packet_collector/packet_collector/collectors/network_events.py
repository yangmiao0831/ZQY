"""Lightweight network state event recording for long capture sessions.

The recorder periodically snapshots one interface and emits extra events when
its IPv4 address or up/down state changes. Failures are recorded as warnings
and never propagated into the capture workflow.
"""

from __future__ import annotations

import threading
import time
from collections.abc import Callable
from datetime import datetime
from pathlib import Path

from packet_collector.collectors.ip_collector import get_interface_addresses, get_interface_state
from packet_collector.storage.jsonl_writer import append_jsonl_record


def _event_time() -> tuple[float, str]:
    """Return matching epoch and local timezone-aware ISO timestamps."""
    now = datetime.now().astimezone()
    return now.timestamp(), now.isoformat()


def collect_network_snapshot(iface: str) -> dict[str, object]:
    """Collect one best-effort interface snapshot without raising."""
    time_epoch, time_iso = _event_time()
    try:
        state = get_interface_state(iface)
    except Exception as exc:
        state = {"is_up": None, "error": str(exc)}
    try:
        addresses = get_interface_addresses(iface)
    except Exception as exc:
        addresses = {"ipv4": [], "ipv6": [], "error": str(exc)}

    ipv4_values = addresses.get("ipv4", [])
    ipv6_values = addresses.get("ipv6", [])
    ipv4 = ipv4_values[0] if isinstance(ipv4_values, list) and ipv4_values else None
    ipv6 = ipv6_values[0] if isinstance(ipv6_values, list) and ipv6_values else None
    errors = [str(value) for value in [state.get("error"), addresses.get("error")] if value]
    return {
        "time_epoch": time_epoch,
        "time_iso": time_iso,
        "iface": iface,
        "ipv4": ipv4,
        "ipv6": ipv6,
        "is_up": state.get("is_up"),
        "event": "snapshot",
        "warning": "; ".join(errors) if errors else None,
    }


def _change_event(iface: str, event: str, **values: object) -> dict[str, object]:
    """Build a timestamped network change event."""
    time_epoch, time_iso = _event_time()
    return {
        "time_epoch": time_epoch,
        "time_iso": time_iso,
        "iface": iface,
        "event": event,
        **values,
    }


def record_network_events(
    iface: str,
    output_file: Path,
    interval: float,
    stop_event: threading.Event,
    snapshot_provider: Callable[[str], dict[str, object]] = collect_network_snapshot,
) -> None:
    """Record snapshots and change events until stop_event is set."""
    previous: dict[str, object] | None = None
    while not stop_event.is_set():
        try:
            snapshot = snapshot_provider(iface)
            append_jsonl_record(output_file, snapshot)
            if previous is not None and not snapshot.get("warning") and not previous.get("warning"):
                old_ipv4 = previous.get("ipv4")
                new_ipv4 = snapshot.get("ipv4")
                if old_ipv4 != new_ipv4:
                    append_jsonl_record(
                        output_file,
                        _change_event(iface, "ip_changed", old_ipv4=old_ipv4, new_ipv4=new_ipv4),
                    )
                old_is_up = previous.get("is_up")
                new_is_up = snapshot.get("is_up")
                if old_is_up != new_is_up and isinstance(new_is_up, bool):
                    append_jsonl_record(
                        output_file,
                        _change_event(iface, "iface_up" if new_is_up else "iface_down", is_up=new_is_up),
                    )
            previous = snapshot
        except Exception as exc:
            append_jsonl_record(output_file, _change_event(iface, "warning", warning=str(exc)))
        if stop_event.wait(interval):
            break
