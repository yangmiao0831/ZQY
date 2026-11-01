"""Log codec wrapper for detail, display-format, and standard-bin calls."""

from __future__ import annotations

import ctypes as C
from pathlib import Path

from radio_capture.errors import NativeCallError
from radio_capture.native.buffers import output_buffer
from radio_capture.native.decoder_abi import DECODER_EXPORTS
from radio_capture.native.win32_loader import Win32NativeLoader


class LogCodec:
    def __init__(self, dll_dir: str | Path, dll_name: str = "DDDIXX00.dll"):
        self.dll_dir = Path(dll_dir)
        self.dll_name = dll_name
        self.dll_path = self.dll_dir / dll_name
        self.loader = Win32NativeLoader(self.dll_dir)
        self.lib = None
        self.exports: dict[str, object] = {}
        self.handle = None

    def load(self) -> None:
        self.lib = self.loader.load(self.dll_name)
        self.exports = self.loader.bind_exports(self.lib, DECODER_EXPORTS)

    def create(self, module_id: int) -> None:
        handle = self.exports["DDDIXX01"](int(module_id))
        if not handle:
            raise NativeCallError(self.dll_path, "DDDIXX01", "cdecl", "codec_create", f"module_id={module_id}")
        self.handle = C.c_void_p(handle)

    def configure(self, config_id: int, payload: bytes) -> int:
        self._require_handle("configure")
        buf = C.create_string_buffer(payload, len(payload))
        return int(self.exports["DDDIXX02"](self.handle, int(config_id), C.cast(buf, C.c_void_p), len(payload)))

    def get_display_format(self, msg_code: int) -> tuple[int, int]:
        self._require_handle("display_format")
        display_format = C.c_int32(0)
        rc = int(self.exports["DDDIXX04"](self.handle, C.c_uint32(msg_code), C.byref(display_format)))
        return rc, int(display_format.value)

    def get_detail(self, msg_code: int, payload: bytes, initial_size: int = 64 * 1024) -> tuple[int, bytes]:
        if msg_code == 0xB821 and initial_size == 64 * 1024:
            initial_size = 1024 * 1024
        return self._call_decode("DDDIXX03", msg_code, payload, initial_size)

    def get_standard_bin(self, msg_code: int, payload: bytes, initial_size: int = 64 * 1024) -> tuple[int, bytes]:
        return self._call_decode("DDDIXX06", msg_code, payload, initial_size)

    def close(self) -> int:
        if not self.handle:
            return 0
        rc = int(self.exports["DDDIXX05"](self.handle))
        self.handle = None
        return rc

    def _call_decode(self, export_name: str, msg_code: int, payload: bytes, initial_size: int) -> tuple[int, bytes]:
        self._require_handle(export_name)
        src = (C.c_ubyte * len(payload)).from_buffer_copy(payload)
        size = initial_size
        last_rc = 0
        for _ in range(4):
            out = output_buffer(size)
            out_len = C.c_int32(size)
            last_rc = int(self.exports[export_name](self.handle, C.c_uint32(msg_code), len(payload), src, C.byref(out_len), out))
            used = max(0, min(int(out_len.value), size))
            data = bytes(out[:used])
            if used < size:
                return last_rc, data
            size *= 2
        return last_rc, data

    def _require_handle(self, state: str) -> None:
        if not self.handle:
            raise NativeCallError(self.dll_path, "codec", "cdecl", state, "handle is null")
