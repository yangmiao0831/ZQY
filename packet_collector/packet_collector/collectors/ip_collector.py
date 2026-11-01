"""IP-layer state collector.

This collector gathers local interface state, IP addresses, default route, DNS
servers, MTU, and optional gateway/target ping checks. It does not collect
Wi-Fi access metrics such as SSID, BSSID, signal strength, frequency, or rate.
"""

from __future__ import annotations

import json
import platform
import re
import socket
import subprocess
import time
from pathlib import Path
from typing import Any

from packet_collector.probes.ping_probe import run_ping_probe

try:
    import psutil
except ModuleNotFoundError:
    psutil = None


_DEFAULT_SYS_CLASS_NET = Path("/sys/class/net")
_IP_ADDRESS_RE = re.compile(r"(?<![0-9A-Fa-f:.])(?:\d{1,3}\.){3}\d{1,3}(?![0-9.])|(?<![0-9A-Fa-f:])(?:[0-9A-Fa-f]{0,4}:){2,}[0-9A-Fa-f:]{0,4}(?![0-9A-Fa-f:])")


def _read_text(path: Path) -> str | None:
    """Read a text file and return stripped text, or None on failure."""
    try:
        return path.read_text(encoding="utf-8").strip()
    except Exception:
        return None


def _windows_interface_state(iface: str) -> dict[str, object]:
    if psutil is None:
        return {"exists": False, "is_up": False, "operstate": None, "mac": None, "mtu": None, "error": "psutil not installed"}
    stats = psutil.net_if_stats()
    addresses = psutil.net_if_addrs()
    if iface not in stats and iface not in addresses:
        return {"exists": False, "is_up": False, "operstate": None, "mac": None, "mtu": None, "error": "interface not found"}
    stat = stats.get(iface)
    mac = None
    for address in addresses.get(iface, []):
        if address.family == getattr(psutil, "AF_LINK", object()):
            mac = address.address
            break
    is_up = bool(stat.isup) if stat is not None else None
    return {
        "exists": True,
        "is_up": is_up,
        "operstate": "up" if is_up else "down" if is_up is not None else None,
        "mac": mac,
        "mtu": int(stat.mtu) if stat is not None else None,
        "error": None,
    }


def get_interface_state(iface: str, sys_class_net_base: Path = _DEFAULT_SYS_CLASS_NET) -> dict[str, object]:
    """Collect basic interface state from sysfs."""
    if platform.system() == "Windows" and sys_class_net_base == _DEFAULT_SYS_CLASS_NET:
        return _windows_interface_state(iface)
    iface_dir = sys_class_net_base / iface
    if not iface_dir.exists():
        return {
            "exists": False,
            "is_up": False,
            "operstate": None,
            "mac": None,
            "mtu": None,
            "error": "interface not found",
        }

    operstate = _read_text(iface_dir / "operstate")
    mac = _read_text(iface_dir / "address")
    mtu_raw = _read_text(iface_dir / "mtu")
    mtu: int | None = None
    try:
        mtu = int(mtu_raw) if mtu_raw else None
    except ValueError:
        mtu = None

    return {
        "exists": True,
        "is_up": operstate == "up",
        "operstate": operstate,
        "mac": mac,
        "mtu": mtu,
        "error": None,
    }


def get_interface_addresses(iface: str) -> dict[str, object]:
    """Collect IPv4 and IPv6 addresses using `ip -j addr show dev`."""
    if platform.system() == "Windows":
        if psutil is None:
            return {"ipv4": [], "ipv6": [], "error": "psutil not installed"}
        addresses = psutil.net_if_addrs()
        if iface not in addresses:
            return {"ipv4": [], "ipv6": [], "error": "interface not found"}
        ipv4 = [item.address for item in addresses[iface] if item.family == socket.AF_INET]
        ipv6 = [item.address.split("%", 1)[0] for item in addresses[iface] if item.family == socket.AF_INET6]
        return {"ipv4": ipv4, "ipv6": ipv6, "error": None}
    try:
        completed = subprocess.run(
            ["ip", "-j", "addr", "show", "dev", iface],
            capture_output=True,
            text=True,
            check=False,
        )
    except FileNotFoundError:
        return {"ipv4": [], "ipv6": [], "error": "ip command not found"}
    except Exception as exc:
        return {"ipv4": [], "ipv6": [], "error": str(exc)}

    if completed.returncode != 0:
        return {
            "ipv4": [],
            "ipv6": [],
            "error": (completed.stderr or "").strip() or f"ip addr failed with returncode {completed.returncode}",
        }

    try:
        payload = json.loads(completed.stdout or "[]")
    except json.JSONDecodeError as exc:
        return {"ipv4": [], "ipv6": [], "error": str(exc)}

    ipv4: list[str] = []
    ipv6: list[str] = []
    for item in payload:
        for addr in item.get("addr_info", []):
            local = addr.get("local")
            if not local:
                continue
            if addr.get("family") == "inet":
                ipv4.append(local)
            elif addr.get("family") == "inet6":
                ipv6.append(local)
    return {"ipv4": ipv4, "ipv6": ipv6, "error": None}


def get_interface_mtu(iface: str, sys_class_net_base: Path = _DEFAULT_SYS_CLASS_NET) -> int | None:
    """Return interface MTU from sysfs when available."""
    state = get_interface_state(iface, sys_class_net_base=sys_class_net_base)
    mtu = state.get("mtu")
    return int(mtu) if isinstance(mtu, int) else None


def get_default_route() -> dict[str, object]:
    """Collect the first default route using `ip route show default`."""
    if platform.system() == "Windows":
        try:
            completed = subprocess.run(
                ["route", "print", "-4", "0.0.0.0"],
                capture_output=True,
                text=True,
                check=False,
            )
        except FileNotFoundError:
            return {"gateway": None, "dev": None, "raw": None, "error": "route command not found"}
        except Exception as exc:
            return {"gateway": None, "dev": None, "raw": None, "error": str(exc)}
        candidates: list[tuple[int, str, str, str]] = []
        for line in (completed.stdout or "").splitlines():
            parts = line.split()
            if len(parts) >= 5 and parts[0] == "0.0.0.0" and parts[1] == "0.0.0.0":
                try:
                    candidates.append((int(parts[4]), parts[2], parts[3], line.strip()))
                except ValueError:
                    continue
        if not candidates:
            return {"gateway": None, "dev": None, "raw": None, "error": "default route not found"}
        _, gateway, interface_ip, raw = min(candidates, key=lambda item: item[0])
        dev = None
        if psutil is not None:
            for name, entries in psutil.net_if_addrs().items():
                if any(entry.family == socket.AF_INET and entry.address == interface_ip for entry in entries):
                    dev = name
                    break
        return {"gateway": gateway, "dev": dev, "interface_ip": interface_ip, "raw": raw, "error": None}
    try:
        completed = subprocess.run(
            ["ip", "route", "show", "default"],
            capture_output=True,
            text=True,
            check=False,
        )
    except FileNotFoundError:
        return {"gateway": None, "dev": None, "raw": None, "error": "ip command not found"}
    except Exception as exc:
        return {"gateway": None, "dev": None, "raw": None, "error": str(exc)}

    if completed.returncode != 0:
        return {
            "gateway": None,
            "dev": None,
            "raw": None,
            "error": (completed.stderr or "").strip() or f"ip route failed with returncode {completed.returncode}",
        }

    raw = (completed.stdout or "").strip().splitlines()
    if not raw:
        return {"gateway": None, "dev": None, "raw": None, "error": "default route not found"}

    line = raw[0].strip()
    parts = line.split()
    gateway = parts[parts.index("via") + 1] if "via" in parts and parts.index("via") + 1 < len(parts) else None
    dev = parts[parts.index("dev") + 1] if "dev" in parts and parts.index("dev") + 1 < len(parts) else None
    return {"gateway": gateway, "dev": dev, "raw": line, "error": None}


def get_dns_servers(resolv_conf: Path = Path("/etc/resolv.conf")) -> list[str]:
    """Parse DNS servers from resolv.conf nameserver lines."""
    if platform.system() == "Windows" and resolv_conf == Path("/etc/resolv.conf"):
        try:
            completed = subprocess.run(["ipconfig", "/all"], capture_output=True, text=True, check=False)
        except Exception:
            return []
        servers: list[str] = []
        collecting = False
        for line in (completed.stdout or "").splitlines():
            lower = line.lower()
            if "dns servers" in lower or "dns 服务器" in lower or "dns server" in lower:
                collecting = True
            elif collecting and line and not line[0].isspace():
                collecting = False
            if collecting:
                for address in _IP_ADDRESS_RE.findall(line):
                    if address not in servers:
                        servers.append(address)
        return servers
    try:
        lines = resolv_conf.read_text(encoding="utf-8").splitlines()
    except Exception:
        return []

    servers: list[str] = []
    for line in lines:
        stripped = line.strip()
        if not stripped or stripped.startswith("#"):
            continue
        parts = stripped.split()
        if len(parts) >= 2 and parts[0] == "nameserver":
            servers.append(parts[1])
    return servers


def run_ping_check(target: str, count: int = 4, timeout: int = 5) -> dict[str, object]:
    """Run ping probe and return a compact IP-layer connectivity result."""
    result = run_ping_probe(target, count=count, timeout=timeout)
    return {
        "target": target,
        "success": result.get("success"),
        "packet_loss_percent": result.get("packet_loss_percent"),
        "rtt_avg_ms": result.get("rtt_avg_ms"),
        "error": result.get("error"),
    }


def collect_ip_metrics(
    iface: str = "wlan0",
    target: str | None = None,
    ping_count: int = 4,
    ping_timeout: int = 5,
) -> dict[str, object]:
    """Collect IP-layer state with graceful per-field degradation."""
    start = time.time()
    result: dict[str, object] = {
        "collector_type": "ip",
        "success": True,
        "start_time_epoch": start,
        "end_time_epoch": None,
        "duration_ms": None,
        "error": None,
        "iface": iface,
        "interface": None,
        "addresses": None,
        "default_route": None,
        "dns_servers": [],
        "gateway_ping": None,
        "target_ping": None,
    }

    try:
        interface = get_interface_state(iface)
        addresses = get_interface_addresses(iface)
        default_route = get_default_route()
        dns_servers = get_dns_servers()

        result["interface"] = interface
        result["addresses"] = addresses
        result["default_route"] = default_route
        result["dns_servers"] = dns_servers

        gateway = default_route.get("gateway") if isinstance(default_route, dict) else None
        if gateway:
            result["gateway_ping"] = run_ping_check(str(gateway), count=ping_count, timeout=ping_timeout)
        if target:
            result["target_ping"] = run_ping_check(target, count=ping_count, timeout=ping_timeout)
    except Exception as exc:
        result["success"] = False
        result["error"] = str(exc)

    end = time.time()
    result["end_time_epoch"] = end
    result["duration_ms"] = (end - start) * 1000
    return result


def collect_ip_metrics_placeholder(iface: str) -> dict[str, object]:
    """Backward-compatible wrapper."""
    return collect_ip_metrics(iface=iface)
