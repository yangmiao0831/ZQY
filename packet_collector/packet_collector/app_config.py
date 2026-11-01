"""Central JSON configuration for packet_collector launchers."""

from __future__ import annotations

import copy
import json
import os
import platform
from dataclasses import dataclass
from pathlib import Path
from typing import Any

from packet_collector.platform_defaults import default_tmp_capture_dir


PROJECT_DIR = Path(__file__).resolve().parents[1]
DEFAULT_CONFIG_FILE = PROJECT_DIR / "config.json"


class ConfigurationError(ValueError):
    """Raised when config.json is missing or contains invalid values."""


DEFAULT_CONFIG: dict[str, Any] = {
    "config_version": 1,
    "capture": {
        "packet_type": "tcp",
        "peer_ip": "47.93.192.193",
        "duration_sec": 60,
        "direction": "in",
        "port": None,
        "window_mode": "online-analysis",
        "window_seconds": 1.0,
        "window_retention": 100,
        "file_size_kb": 51200,
        "max_files": 200,
        "network_events": False,
        "network_events_interval": 10.0,
        "tmp_capture_dir": None,
        "final_capture_dir": "captures",
    },
    "gps": {"enabled": True, "baudrate": 115200},
    "video": {
        "enabled": True,
        "format": "mp4",
        "fps": 20.0,
        "width": None,
        "height": None,
    },
    "display": {
        "enabled": True,
        "data_dir": "../iov-data-collector-(ue-stack)/datas",
        "source": "BJTU",
    },
    "tools": {"wireshark_dir": "Wireshark"},
    "platform": {
        "windows": {"interface": "1", "gps_port": "COM3", "camera": "0"},
        "linux": {
            "interface": "wwan0",
            "gps_port": "/dev/ttyUSB1",
            "camera": "/dev/video0",
        },
    },
}


@dataclass(frozen=True)
class RuntimeSettings:
    """Validated settings used by the configured capture launchers."""

    config_file: Path
    project_dir: Path
    packet_type: str
    interface: str
    peer_ip: str
    duration_sec: int
    direction: str
    port: int | None
    window_mode: str | None
    window_seconds: float
    window_retention: int
    file_size_kb: int
    max_files: int
    network_events: bool
    network_events_interval: float
    tmp_capture_dir: Path
    final_capture_dir: Path
    gps_enabled: bool
    gps_port: str
    gps_baudrate: int
    video_enabled: bool
    camera: str
    video_format: str
    video_fps: float
    video_width: int | None
    video_height: int | None
    display_enabled: bool
    display_data_dir: Path
    display_source: str
    wireshark_dir: Path


def _deep_merge(base: dict[str, Any], override: dict[str, Any]) -> dict[str, Any]:
    result = copy.deepcopy(base)
    for key, value in override.items():
        if isinstance(value, dict) and isinstance(result.get(key), dict):
            result[key] = _deep_merge(result[key], value)
        else:
            result[key] = copy.deepcopy(value)
    return result


def _mapping(data: dict[str, Any], key: str) -> dict[str, Any]:
    value = data.get(key)
    if not isinstance(value, dict):
        raise ConfigurationError(f"{key} must be a JSON object")
    return value


def _resolve_path(base_dir: Path, value: str | Path | None, fallback: Path) -> Path:
    if value in (None, ""):
        return fallback.resolve()
    path = Path(value).expanduser()
    return (path if path.is_absolute() else base_dir / path).resolve()


def _positive_int(value: Any, name: str) -> int:
    try:
        result = int(value)
    except (TypeError, ValueError) as exc:
        raise ConfigurationError(f"{name} must be an integer") from exc
    if result <= 0:
        raise ConfigurationError(f"{name} must be > 0")
    return result


def _positive_float(value: Any, name: str) -> float:
    try:
        result = float(value)
    except (TypeError, ValueError) as exc:
        raise ConfigurationError(f"{name} must be a number") from exc
    if result <= 0:
        raise ConfigurationError(f"{name} must be > 0")
    return result


def current_platform_key(system_name: str | None = None) -> str:
    name = (system_name or platform.system()).lower()
    if name.startswith("win"):
        return "windows"
    if name == "linux":
        return "linux"
    raise ConfigurationError(f"unsupported platform: {system_name or platform.system()}")


def load_config_data(config_file: str | Path = DEFAULT_CONFIG_FILE) -> dict[str, Any]:
    """Load config JSON and merge omitted fields with stable defaults."""
    path = Path(config_file).expanduser().resolve()
    if not path.is_file():
        raise ConfigurationError(f"config file does not exist: {path}")
    try:
        raw = json.loads(path.read_text(encoding="utf-8"))
    except json.JSONDecodeError as exc:
        raise ConfigurationError(f"invalid JSON in {path}: {exc}") from exc
    if not isinstance(raw, dict):
        raise ConfigurationError("config root must be a JSON object")
    return _deep_merge(DEFAULT_CONFIG, raw)


def load_runtime_settings(
    config_file: str | Path = DEFAULT_CONFIG_FILE,
    *,
    system_name: str | None = None,
) -> RuntimeSettings:
    """Load and validate the effective settings for the current platform."""
    config_path = Path(config_file).expanduser().resolve()
    data = load_config_data(config_path)
    base_dir = config_path.parent
    capture = _mapping(data, "capture")
    gps = _mapping(data, "gps")
    video = _mapping(data, "video")
    display = _mapping(data, "display")
    tools = _mapping(data, "tools")
    platforms = _mapping(data, "platform")
    platform_key = current_platform_key(system_name)
    platform_config = platforms.get(platform_key)
    if not isinstance(platform_config, dict):
        raise ConfigurationError(f"platform.{platform_key} must be a JSON object")

    packet_type = str(capture.get("packet_type", "tcp")).lower()
    if packet_type != "tcp":
        raise ConfigurationError("configured online analysis currently requires capture.packet_type=tcp")
    interface = str(platform_config.get("interface") or "").strip()
    peer_ip = str(capture.get("peer_ip") or "").strip()
    gps_port = str(platform_config.get("gps_port") or "").strip()
    camera = str(platform_config.get("camera") or "").strip()
    if not interface:
        raise ConfigurationError(f"platform.{platform_key}.interface must not be empty")
    if not peer_ip:
        raise ConfigurationError("capture.peer_ip must not be empty")

    direction = str(capture.get("direction", "in"))
    if direction not in {"in", "out", "both"}:
        raise ConfigurationError("capture.direction must be in, out, or both")
    window_mode_value = capture.get("window_mode")
    window_mode = None if window_mode_value in (None, "") else str(window_mode_value)
    if window_mode not in {None, "capture-only", "online-analysis"}:
        raise ConfigurationError("capture.window_mode must be capture-only, online-analysis, or null")

    gps_enabled = bool(gps.get("enabled", True))
    video_enabled = bool(video.get("enabled", True))
    video_format = str(video.get("format", "mp4")).strip().lower()
    display_enabled = bool(display.get("enabled", True))
    if gps_enabled and not gps_port:
        raise ConfigurationError(f"platform.{platform_key}.gps_port is required when GPS is enabled")
    if video_enabled and not camera:
        raise ConfigurationError(f"platform.{platform_key}.camera is required when video is enabled")
    if video_format not in {"avi", "mp4"}:
        raise ConfigurationError("video.format must be avi or mp4")
    if display_enabled and not gps_enabled:
        raise ConfigurationError("display.enabled requires gps.enabled=true")
    if gps_enabled and window_mode != "online-analysis":
        raise ConfigurationError("gps.enabled requires capture.window_mode=online-analysis")

    source = str(display.get("source") or "").strip()
    if not source or Path(source).name != source:
        raise ConfigurationError("display.source must be one directory name")
    port_value = capture.get("port")
    port = None if port_value in (None, "") else _positive_int(port_value, "capture.port")

    settings = RuntimeSettings(
        config_file=config_path,
        project_dir=base_dir,
        packet_type=packet_type,
        interface=interface,
        peer_ip=peer_ip,
        duration_sec=_positive_int(capture.get("duration_sec"), "capture.duration_sec"),
        direction=direction,
        port=port,
        window_mode=window_mode,
        window_seconds=_positive_float(capture.get("window_seconds"), "capture.window_seconds"),
        window_retention=_positive_int(capture.get("window_retention"), "capture.window_retention"),
        file_size_kb=_positive_int(capture.get("file_size_kb"), "capture.file_size_kb"),
        max_files=_positive_int(capture.get("max_files"), "capture.max_files"),
        network_events=bool(capture.get("network_events", False)),
        network_events_interval=_positive_float(
            capture.get("network_events_interval"), "capture.network_events_interval"
        ),
        tmp_capture_dir=_resolve_path(
            base_dir, capture.get("tmp_capture_dir"), default_tmp_capture_dir()
        ),
        final_capture_dir=_resolve_path(
            base_dir, capture.get("final_capture_dir"), base_dir / "captures"
        ),
        gps_enabled=gps_enabled,
        gps_port=gps_port,
        gps_baudrate=_positive_int(gps.get("baudrate"), "gps.baudrate"),
        video_enabled=video_enabled,
        camera=camera,
        video_format=video_format,
        video_fps=_positive_float(video.get("fps"), "video.fps"),
        video_width=(
            None if video.get("width") in (None, "") else _positive_int(video["width"], "video.width")
        ),
        video_height=(
            None if video.get("height") in (None, "") else _positive_int(video["height"], "video.height")
        ),
        display_enabled=display_enabled,
        display_data_dir=_resolve_path(
            base_dir, display.get("data_dir"), base_dir.parent / "iov-data-collector-(ue-stack)" / "datas"
        ),
        display_source=source,
        wireshark_dir=_resolve_path(base_dir, tools.get("wireshark_dir"), base_dir / "Wireshark"),
    )
    return settings


def apply_runtime_environment(settings: RuntimeSettings) -> None:
    """Expose configured tool paths to existing subprocess helpers."""
    os.environ["PACKET_COLLECTOR_WIRESHARK_DIR"] = str(settings.wireshark_dir)

