"""Core data models for capture, parse, decode, and storage stages."""

from __future__ import annotations

from dataclasses import dataclass, field
from datetime import datetime
from pathlib import Path
from threading import Lock
from typing import Any


def create_session_id(raw_dir: str | Path | None = None, now: datetime | None = None) -> str:
    """Create a readable, collision-safe capture session directory name."""
    timestamp = now or datetime.now()
    base_name = timestamp.strftime("session_%Y%m%d_%H%M%S")
    if raw_dir is None:
        return base_name

    root = Path(raw_dir)
    candidate = base_name
    suffix = 2
    while (root / candidate).exists():
        candidate = f"{base_name}_{suffix}"
        suffix += 1
    return candidate


@dataclass(frozen=True)
class RuntimeConfig:
    python_arch: str
    dll_dir: Path
    callback_queue_size: int = 8192


@dataclass(frozen=True)
class DeviceConfig:
    eq_id: int
    chip_type: str
    eq_type: str
    ue_index: int = 0
    controller_dll: str = "DC_CommonSocket.dll"
    connect_timeout_ms: int = 30000
    reconnect: bool = True
    heartbeat_sec: int | None = None
    chip_info_stage: str = "disabled"
    start_log: bool = True
    no_data_timeout_sec: float | None = 30.0
    reconnect_backoff_sec: float = 2.0
    max_reconnect_attempts: int = 3


@dataclass(frozen=True)
class PortsConfig:
    trace_port: int | str | None = None
    trace_nr_port: int | str | None = None
    at_port: int | str | None = None
    modem_port: int | str | None = None
    net_adapter: str | None = None
    adb_port: int | str | None = None
    ue_ip: str | None = None
    pc_ip: str | None = None
    baud_rate: int | None = None
    json_config: str | None = None


@dataclass(frozen=True)
class LogmaskConfig:
    mode: str = "default"
    file: Path | None = None
    extend_nr: tuple[str, ...] = ()
    extend_lte: tuple[str, ...] = ()
    command_type: int | None = None
    payload_hex: str | None = None


@dataclass(frozen=True)
class ShutdownCommandConfig:
    """A vendor command that is safe to send only when explicitly verified."""

    type_id: int
    payload_hex: str


@dataclass(frozen=True)
class ShutdownConfig:
    """Optional, explicitly verified commands used when a DM session ends.

    The native DLL does not expose these operations as named exports.  Keep
    them disabled unless the command type and payload have been verified for
    the connected modem.
    """

    stop_log: ShutdownCommandConfig | None = None
    restore_logmask: ShutdownCommandConfig | None = None
    device_reset: ShutdownCommandConfig | None = None


@dataclass(frozen=True)
class DecoderConfig:
    dispatcher_dll: str = "DDDIXX00.dll"
    expected_plugin: str = "DDDIXXS0.dll"
    codec_module_id: int | None = None
    config_id: int | None = None


@dataclass(frozen=True)
class OutputConfig:
    raw_dir: Path
    decoded_jsonl: Path
    sqlite_file: Path
    nr_metrics_csv: Path | None = None
    dm_metrics_csv: Path | None = None
    at_metrics_csv: Path | None = None
    four_g_metrics_csv: Path | None = None
    merged_metrics_csv: Path | None = None
    save_ubo: bool = False
    save_dtlog: bool = False
    save_qmdl: bool = False
    metrics_only: bool = False
    dm_write_interval_sec: float = 1.0


@dataclass(frozen=True)
class DeviceSessionConfig:
    runtime: RuntimeConfig
    device: DeviceConfig
    ports: PortsConfig
    logmask: LogmaskConfig
    decoder: DecoderConfig
    output: OutputConfig
    shutdown: ShutdownConfig = field(default_factory=ShutdownConfig)


@dataclass
class SessionContext:
    """会话状态容器,负责保存当前会话的配置、ID、
    停止状态，并提供一个线程安全的递增序号生成方法"""
    config: DeviceSessionConfig
    session_id: str = field(default_factory=create_session_id)
    sequence: int = 0 #会话内的序号计数器
    stopping: bool = False #表示当前会话是否正在停止
    _sequence_lock: Lock = field(default_factory=Lock, init=False, repr=False) #用于保护 sequence 的线程锁

    def next_sequence(self) -> int:
        with self._sequence_lock:
            self.sequence += 1
            return self.sequence


@dataclass(frozen=True)
class FrameEnvelope:
    session_id: str
    sequence: int
    receive_time_ns: int
    native_cur_time: int
    log_type: int
    payload_length: int
    payload: bytes


@dataclass(frozen=True)
class DecodeRequest:
    session_id: str
    sequence: int
    eq_id: int
    module_id: int
    msg_code: int | None
    payload: bytes


@dataclass(frozen=True)
class DecodedRecord:
    session_id: str
    sequence: int
    msg_code: int | None
    display_format: int | None
    return_code: int
    standard_bin: bytes | None = None
    detail: bytes | None = None
    normalized: dict[str, Any] | None = None
    error: str | None = None
    # Wall-clock time when the raw frame entered the capture pipeline.  This
    # is kept separately from the decoder Header/Time because some Qualcomm
    # log definitions return an epoch/1980 timestamp.
    receive_time_ns: int | None = None
