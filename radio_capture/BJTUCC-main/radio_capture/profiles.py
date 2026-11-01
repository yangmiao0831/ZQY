"""Device profile resolution for controller, ports, and codec settings."""

from __future__ import annotations

from dataclasses import dataclass
from enum import IntEnum

from radio_capture.models import DeviceSessionConfig


def _port_payload(port: int | str) -> bytes:
    if isinstance(port, int):
        return int(port).to_bytes(4, "little")
    text = str(port)
    if text.upper().startswith("COM"):
        return text.encode("utf-8") + b"\0"
    return int(text).to_bytes(4, "little")


class ConnectInfoType(IntEnum):
    TRACE_PORT = 1
    AT_PORT = 2
    NET_ADAPTER = 3
    MODEM_PORT = 4
    ADB = 5
    TRACE_ASSISTANT = 6
    UE_IP = 7
    PC_IP = 8
    BAUD_RATE = 9
    JSON_CONFIG = 999


@dataclass(frozen=True)
class DeviceProfile:
    name: str
    controller_dll: str
    decoder_dispatcher_dll: str
    expected_plugin: str
    codec_module_id: int
    chip_info_stage: str = "disabled"


class ProfileResolver:
    """Resolve profile details without duplicating native DLL routing logic."""

    def resolve(self, config: DeviceSessionConfig) -> DeviceProfile:
        """把原始配置整理成当前设备运行方案。它决定当前采集任务要用哪个控制 DLL、
        哪个解码 DLL、哪个插件，以及这个设备 profile 的名字"""
        eq_id = config.device.eq_id
        return DeviceProfile(
            name=f"{config.device.chip_type}/{config.device.eq_type}/{eq_id}",
            controller_dll=config.device.controller_dll,
            decoder_dispatcher_dll=config.decoder.dispatcher_dll,
            expected_plugin=config.decoder.expected_plugin,
            codec_module_id=config.decoder.codec_module_id or eq_id,
            chip_info_stage=config.device.chip_info_stage,
        )

    def iter_port_payloads(self, config: DeviceSessionConfig):
        """负责把 Python 配置对象里的端口参数翻译成
        原生控制 DLL 的 configure_port(type_id, payload) 所需格式"""
        ports = config.ports
        if ports.trace_port is not None:
            yield ConnectInfoType.TRACE_PORT, _port_payload(ports.trace_port)
        if ports.trace_nr_port is not None:
            yield ConnectInfoType.TRACE_ASSISTANT, _port_payload(ports.trace_nr_port)
        if ports.at_port is not None:
            yield ConnectInfoType.AT_PORT, _port_payload(ports.at_port)
        if ports.modem_port is not None:
            yield ConnectInfoType.MODEM_PORT, _port_payload(ports.modem_port)
        if ports.net_adapter:
            yield ConnectInfoType.NET_ADAPTER, ports.net_adapter.encode("utf-8")
        if ports.adb_port is not None:
            if isinstance(ports.adb_port, int):
                payload = int(ports.adb_port).to_bytes(4, "little")
            else:
                payload = str(ports.adb_port).encode("utf-8")
            yield ConnectInfoType.ADB, payload
        if ports.ue_ip:
            yield ConnectInfoType.UE_IP, ports.ue_ip.encode("utf-8")
        if ports.pc_ip:
            yield ConnectInfoType.PC_IP, ports.pc_ip.encode("utf-8")
        if ports.baud_rate is not None:
            yield ConnectInfoType.BAUD_RATE, int(ports.baud_rate).to_bytes(4, "little")
        if ports.json_config:
            yield ConnectInfoType.JSON_CONFIG, ports.json_config.encode("utf-8")
