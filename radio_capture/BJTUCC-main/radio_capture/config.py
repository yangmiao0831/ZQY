"""Configuration loading and validation for capture sessions."""

from __future__ import annotations

import json
from pathlib import Path
from typing import Any

from radio_capture.errors import ConfigurationError
from radio_capture.models import (
    DecoderConfig,
    DeviceConfig,
    DeviceSessionConfig,
    LogmaskConfig,
    OutputConfig,
    PortsConfig,
    RuntimeConfig,
    ShutdownCommandConfig,
    ShutdownConfig,
)


def _path_or_none(value: str | None, base_dir: Path) -> Path | None:
    if not value:
        return None
    path = Path(value)
    return path if path.is_absolute() else base_dir / path


def load_config(path: str | Path) -> DeviceSessionConfig:
    config_path = Path(path) #得到当前路径对象s
    if not config_path.exists():
        raise ConfigurationError(f"config file does not exist: {config_path}")
    if config_path.suffix.lower() != ".json":
        raise ConfigurationError("first MVP only supports JSON config files")
    data = json.loads(config_path.read_text(encoding="utf-8")) #得到配置文件字典
    return parse_config(data, base_dir=config_path.parent)


def parse_config(data: dict[str, Any], base_dir: Path | None = None) -> DeviceSessionConfig:
    """配置转换器，负责把 JSON 里的原始配置，
    变成后面采集程序能直接使用的 Python 配置对象"""
    base_dir = base_dir or Path.cwd()
    runtime = data.get("runtime", {})
    device = data.get("device", {})
    ports = data.get("ports", {})
    logmask = data.get("logmask", {})
    decoder = data.get("decoder", {})
    output = data.get("output", {})
    shutdown = data.get("shutdown", {})
    four_g_metrics_csv = _first_present(
        output,
        "4g_metrics_csv",
        "four_g_metrics_csv",
        "lte_metrics_csv",
    )

    cfg = DeviceSessionConfig(
        runtime=RuntimeConfig(
            python_arch=str(runtime.get("python_arch", "x86")),
            dll_dir=Path(runtime["dll_dir"]),
            callback_queue_size=int(runtime.get("callback_queue_size", 8192)),
        ),
        device=DeviceConfig(
            eq_id=int(device["eq_id"]),
            chip_type=str(device.get("chip_type", "qualcomm")),
            eq_type=str(device.get("eq_type", "ue")),
            ue_index=int(device.get("ue_index", 0)),
            controller_dll=str(device.get("controller_dll", "DC_CommonSocket.dll")),
            connect_timeout_ms=int(device.get("connect_timeout_ms", 30000)),
            reconnect=bool(device.get("reconnect", True)),
            heartbeat_sec=device.get("heartbeat_sec"),
            chip_info_stage=str(device.get("chip_info_stage", "disabled")),
            start_log=bool(device.get("start_log", True)),
            no_data_timeout_sec=(
                float(device["no_data_timeout_sec"])
                if device.get("no_data_timeout_sec") is not None
                else None
            ),
            reconnect_backoff_sec=float(device.get("reconnect_backoff_sec", 2.0)),
            max_reconnect_attempts=int(device.get("max_reconnect_attempts", 3)),
        ),
        ports=PortsConfig(**ports),
        logmask=LogmaskConfig(
            mode=str(logmask.get("mode", "default")),
            file=_path_or_none(logmask.get("file"), base_dir),
            extend_nr=tuple(logmask.get("extend_nr", [])),
            extend_lte=tuple(logmask.get("extend_lte", [])),
            command_type=(
                int(logmask["command_type"])
                if logmask.get("command_type") is not None
                else None
            ),
            payload_hex=logmask.get("payload_hex"),
        ),
        decoder=DecoderConfig(
            dispatcher_dll=str(decoder.get("dispatcher_dll", "DDDIXX00.dll")),
            expected_plugin=str(decoder.get("expected_plugin", "DDDIXXS0.dll")),
            codec_module_id=decoder.get("codec_module_id"),
            config_id=decoder.get("config_id"),
        ),
        output=OutputConfig(
            raw_dir=_resolve_output(base_dir, output["raw_dir"]),
            decoded_jsonl=_resolve_output(base_dir, output["decoded_jsonl"]),
            sqlite_file=_resolve_output(base_dir, output["sqlite_file"]),
            nr_metrics_csv=(
                _resolve_output(
                    base_dir,
                    output.get("nr_metrics_csv", str(Path(output["decoded_jsonl"]).with_name("nr_metrics.csv"))),
                )
                if output.get("nr_metrics_csv", True) is not None
                else None
            ),
            dm_metrics_csv=(
                _resolve_output(base_dir, output["dm_metrics_csv"])
                if output.get("dm_metrics_csv") is not None
                else None
            ),
            at_metrics_csv=(
                _resolve_output(base_dir, output["at_metrics_csv"])
                if output.get("at_metrics_csv") is not None
                else None
            ),
            four_g_metrics_csv=(
                _resolve_output(base_dir, four_g_metrics_csv)
                if four_g_metrics_csv is not None
                else None
            ),
            merged_metrics_csv=(
                _resolve_output(base_dir, output["merged_metrics_csv"])
                if output.get("merged_metrics_csv") is not None
                else None
            ),
            save_ubo=bool(output.get("save_ubo", False)),
            save_dtlog=bool(output.get("save_dtlog", False)),
            save_qmdl=bool(output.get("save_qmdl", False)),
            metrics_only=bool(output.get("metrics_only", False)),
            dm_write_interval_sec=float(output.get("dm_write_interval_sec", 1.0)),
        ),
        shutdown=ShutdownConfig(
            stop_log=_parse_shutdown_command(shutdown.get("stop_log"), "shutdown.stop_log"),
            restore_logmask=_parse_shutdown_command(
                shutdown.get("restore_logmask"), "shutdown.restore_logmask"
            ),
            device_reset=_parse_shutdown_command(
                shutdown.get("device_reset"), "shutdown.device_reset"
            ),
        ),
    )
    validate_config(cfg)
    return cfg


def _first_present(mapping: dict[str, Any], *names: str) -> Any:
    for name in names:
        if name in mapping:
            return mapping[name]
    return None


def _resolve_output(base_dir: Path, value: str) -> Path:
    path = Path(value)
    return path if path.is_absolute() else base_dir / path


def _parse_shutdown_command(value: Any, name: str) -> ShutdownCommandConfig | None:
    if value is None:
        return None
    if not isinstance(value, dict):
        raise ConfigurationError(f"{name} must be an object or null")
    if value.get("type_id") is None or not value.get("payload_hex"):
        raise ConfigurationError(f"{name} requires type_id and payload_hex")
    return ShutdownCommandConfig(
        type_id=int(value["type_id"]),
        payload_hex=str(value["payload_hex"]),
    )


def validate_config(config: DeviceSessionConfig) -> None:
    """采集前确认配置里的关键字段是合理的"""
    if config.runtime.python_arch.lower() != "x86":
        raise ConfigurationError("runtime.python_arch must be x86 for current PE32 DLLs")
    if config.runtime.callback_queue_size <= 0:
        raise ConfigurationError("runtime.callback_queue_size must be positive")
    if config.device.eq_id <= 0:
        raise ConfigurationError("device.eq_id must be positive")
    if not config.device.controller_dll.lower().endswith(".dll"):
        raise ConfigurationError("device.controller_dll must be a DLL filename")
    if config.device.no_data_timeout_sec is not None and config.device.no_data_timeout_sec <= 0:
        raise ConfigurationError("device.no_data_timeout_sec must be positive or null")
    if config.device.reconnect_backoff_sec < 0:
        raise ConfigurationError("device.reconnect_backoff_sec must not be negative")
    if config.device.max_reconnect_attempts < 0:
        raise ConfigurationError("device.max_reconnect_attempts must not be negative")
    if config.output.dm_write_interval_sec < 0:
        raise ConfigurationError("output.dm_write_interval_sec must not be negative")
    if config.logmask.mode not in {"disabled", "default", "native", "file", "command", "qwinlog"}:
        raise ConfigurationError(
            "logmask.mode must be disabled, default, native, file, command, or qwinlog"
        )
    if config.logmask.mode == "qwinlog" and config.logmask.file is None:
        raise ConfigurationError("logmask.file is required when logmask.mode=qwinlog")
    if config.logmask.mode == "file" and config.logmask.file is None:
        raise ConfigurationError("logmask.file is required when logmask.mode=file")
    if config.logmask.mode == "file" and config.logmask.command_type is None:
        raise ConfigurationError("logmask.command_type is required when logmask.mode=file")
    if config.logmask.mode == "command":
        if config.logmask.command_type is None or not config.logmask.payload_hex:
            raise ConfigurationError(
                "logmask.command_type and logmask.payload_hex are required when logmask.mode=command"
            )
