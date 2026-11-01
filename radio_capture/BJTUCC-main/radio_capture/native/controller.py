"""Device controller wrapper around DDDCXX native exports."""

from __future__ import annotations

import ctypes as C
from pathlib import Path

from radio_capture.errors import NativeCallError
from radio_capture.native.controller_abi import (
    CONTROLLER_EXPORTS,
    QUALCOMM_CONTROLLER_EXPORTS,
    OwnedDCInfo,
)
from radio_capture.native.win32_loader import Win32NativeLoader


class DeviceController:
    def __init__(self, dll_dir: str | Path, dll_name: str):
        """是对原生控制 DLL 的 Python 封装"""
        #它不直接采集数据，而是通过 ctypes 调用 DLL 导出的 DDDCXXxx 函数，
        # 完成设备实例创建、端口配置、连接、断开和释放。
        self.dll_dir = Path(dll_dir)
        self.dll_name = dll_name
        self.dll_path = self.dll_dir / dll_name
        self.loader = Win32NativeLoader(self.dll_dir)
        self.lib = None
        self.exports: dict[str, object] = {}
        self.handle = None
        self._owned_infos: list[OwnedDCInfo] = []
        self._inline_info = self.dll_name.upper() == "DDDCXX01.DLL"
        if self._inline_info:
            self._connect_export = "DDDCXX05"
            self._recover_export = "DDDCXX06"
            self._chip_info_export = "DDDCXX08"
            self._command_export = "DDDCXX07"
        else:
            self._connect_export = "DDDCXX06"
            self._recover_export = "DDDCXX05"
            self._chip_info_export = "DDDCXX07"
            self._command_export = "DDDCXX08"

    def load(self) -> None:
        """加载控制 DLL，并按 CONTROLLER_EXPORTS 绑定原生函数签名"""
        self.lib = self.loader.load(self.dll_name)
        export_map = (
            QUALCOMM_CONTROLLER_EXPORTS
            if self.dll_name.upper() == "DDDCXX01.DLL"
            else CONTROLLER_EXPORTS
        )
        self.exports = self.loader.bind_exports(self.lib, export_map)

    def create(self, module_id: int) -> None:
        """创建控制器实例。成功后保存返回的原生 handle"""
        handle = self.exports["DDDCXX01"](int(module_id))
        #这个handle有什么用？
        if not handle:
            raise NativeCallError(self.dll_path, "DDDCXX01", "cdecl", "create", f"module_id={module_id}")
        self.handle = C.c_void_p(handle)

    def configure_port(self, type_id: int, payload: bytes) -> int:
        self._require_handle("configure_port")
        info = OwnedDCInfo(type_id, payload, inline=self._inline_info)
        self._owned_infos.append(info)
        return int(self.exports["DDDCXX04"](self.handle, info.ptr))

    def send_chip_info(self) -> int:
        self._require_handle("send_chip_info")
        return int(self.exports[self._chip_info_export](self.handle))

    def send_command(self, type_id: int, payload: bytes) -> int:
        self._require_handle("send_command")
        info = OwnedDCInfo(type_id, payload, inline=self._inline_info)
        self._owned_infos.append(info)
        return int(self.exports[self._command_export](self.handle, info.ptr))

    def connect(self, callback, user_param, timeout_ms: int) -> int:
        self._require_handle("connect")
        return int(self.exports[self._connect_export](self.handle, callback, user_param, int(timeout_ms)))

    def recover(self) -> int:
        self._require_handle("recover")
        return int(self.exports[self._recover_export](self.handle))

    def disconnect(self, timeout_ms: int) -> int:
        if not self.handle:
            return 0
        return int(self.exports["DDDCXX09"](self.handle, int(timeout_ms)))

    def close(self) -> int:
        if not self.handle:
            return 0
        rc = int(self.exports["DDDCXX0A"](self.handle))
        self.handle = None
        self._owned_infos.clear()
        return rc

    def _require_handle(self, state: str) -> None:
        """校验控制器实例是否存在"""
        if not self.handle:
            raise NativeCallError(self.dll_path, "controller", "cdecl", state, "handle is null")
