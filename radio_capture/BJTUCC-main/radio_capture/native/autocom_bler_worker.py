"""Crash-isolated x86 worker for AutoCom's Qualcomm PUSCH BLER codec.

AutoCom loads the Qualcomm codec plugin directly (``DDLCXX01.dll``), configures
it with configuration id 2, and submits DDDI packets with their original log
type. The plugin emits ``NR5gPUSCHBLER`` as UBO/TLV object ``0x139F``.
"""

from __future__ import annotations

import argparse
import base64
import ctypes as C
import json
import platform
import struct
import sys
from pathlib import Path

from radio_capture.native.win32_loader import Win32NativeLoader


DDLCXX_QUALCOMM_DLL = "DDLCXX01.dll"
DDLCXX_PLUGIN_NAME_CONFIG_ID = 2
NR5G_PUSCH_BLER_OBJECT_ID = 0x139F
NR5G_PUSCH_BLER_SAMPLES_FIELD = 2
NR5G_PUSCH_BLER_SUCCESSES_FIELD = 3
NR5G_PUSCH_BLER_ERRORS_FIELD = 4
NR5G_PUSCH_BLER_VALUE_FIELD = 5


class _DdlcxxCodec:
    """Small typed wrapper around the eight DDLCXX plugin exports."""

    def __init__(self, dll_dir: Path, module_id: int, dll_name: str) -> None:
        loader = Win32NativeLoader(dll_dir)
        loader.assert_x86_process()
        self.lib = loader.load(dll_name)
        self.dll_name = dll_name
        self.handle: int | None = None

        self.lib.DDLCXX01.argtypes = [C.c_int32]
        self.lib.DDLCXX01.restype = C.c_void_p
        self.lib.DDLCXX02.argtypes = [C.c_void_p, C.c_int32, C.c_void_p, C.c_int32]
        self.lib.DDLCXX02.restype = C.c_ubyte
        self.lib.DDLCXX04.argtypes = [
            C.c_void_p,
            C.c_int32,
            C.c_int32,
            C.c_void_p,
            C.c_int32,
            C.c_uint32,
            C.c_uint32,
        ]
        self.lib.DDLCXX04.restype = C.c_ubyte
        self.lib.DDLCXX05.argtypes = [C.c_void_p]
        self.lib.DDLCXX05.restype = C.c_int32
        self.lib.DDLCXX06.argtypes = [C.c_void_p, C.c_int32]
        self.lib.DDLCXX06.restype = C.c_void_p
        self.lib.DDLCXX07.argtypes = [C.c_void_p]
        self.lib.DDLCXX07.restype = C.c_int32
        self.lib.DDLCXX08.argtypes = [C.c_void_p]
        self.lib.DDLCXX08.restype = C.c_ubyte

        handle = self.lib.DDLCXX01(int(module_id))
        if not handle:
            raise RuntimeError("DDLCXX01 returned a null handle")
        self.handle = int(handle)

        # AutoCom's DDFP loader applies configuration id 2 immediately after
        # create. Qualcomm must use the direct plugin name, not DDLCXX00.
        plugin_name = C.create_string_buffer(dll_name.encode("ascii"))
        configured = self.lib.DDLCXX02(
            C.c_void_p(self.handle),
            DDLCXX_PLUGIN_NAME_CONFIG_ID,
            plugin_name,
            len(plugin_name.value),
        )
        if not configured:
            self.close()
            raise RuntimeError("DDLCXX02 configuration id 2 was rejected")

    def parse(
        self,
        *,
        payload: bytes,
        log_type: int,
        native_cur_time: int,
        receive_time_ns: int,
    ) -> dict[str, object] | None:
        if self.handle is None:
            raise RuntimeError("DDLCXX codec is closed")
        source = C.create_string_buffer(payload)
        timestamp = int(receive_time_ns) & 0xFFFFFFFFFFFFFFFF
        accepted = self.lib.DDLCXX04(
            C.c_void_p(self.handle),
            int(log_type),
            int(native_cur_time),
            source,
            len(payload),
            timestamp & 0xFFFFFFFF,
            (timestamp >> 32) & 0xFFFFFFFF,
        )
        if not accepted:
            raise RuntimeError("DDLCXX04 rejected the input packet")

        latest: dict[str, object] | None = None
        try:
            count = self.lib.DDLCXX05(C.c_void_p(self.handle))
            if count < 0 or count > 10000:
                raise RuntimeError(f"invalid DDLCXX05 record count: {count}")
            for index in range(count):
                item = self.lib.DDLCXX06(C.c_void_p(self.handle), index)
                candidate = _decode_pusch_bler_item(item)
                if candidate is not None:
                    latest = candidate
        finally:
            self.lib.DDLCXX07(C.c_void_p(self.handle))
        return latest

    def close(self) -> None:
        if self.handle is None:
            return
        self.lib.DDLCXX08(C.c_void_p(self.handle))
        self.handle = None


def _decode_pusch_bler_item(item: int | None) -> dict[str, object] | None:
    if not item:
        return None
    # DDLCXX06 returns a packed 11-byte holder:
    # uint8 kind; uint16 object_id; uint32 length; void *data.
    wrapper = C.string_at(item, 11)
    kind = wrapper[0]
    object_id = struct.unpack_from("<H", wrapper, 1)[0]
    length = struct.unpack_from("<I", wrapper, 3)[0]
    data_pointer = struct.unpack_from("<I", wrapper, 7)[0]
    if (
        kind != 0x80
        or object_id != NR5G_PUSCH_BLER_OBJECT_ID
        or length < 20
        or length > 1_048_576
        or not data_pointer
    ):
        return None
    fields = _decode_tlv_fields(C.string_at(data_pointer, length), object_id)
    samples = _uint32(fields.get(NR5G_PUSCH_BLER_SAMPLES_FIELD))
    successes = _uint32(fields.get(NR5G_PUSCH_BLER_SUCCESSES_FIELD))
    errors = _uint32(fields.get(NR5G_PUSCH_BLER_ERRORS_FIELD))
    bler = _float32(fields.get(NR5G_PUSCH_BLER_VALUE_FIELD))
    if samples is None:
        return None
    return {
        "bler_pct": bler,
        "samples": samples,
        "successes": successes,
        "errors": errors,
        "object_id": f"0x{object_id:04X}",
        "value_field_id": f"0x{object_id:04X}{NR5G_PUSCH_BLER_VALUE_FIELD:04X}",
    }


def _decode_tlv_fields(data: bytes, object_id: int) -> dict[int, bytes]:
    if len(data) < 8:
        return {}
    fields: dict[int, bytes] = {}
    position = 8
    while position + 8 <= len(data):
        key, size = struct.unpack_from("<II", data, position)
        position += 8
        if size > len(data) - position:
            break
        value = data[position : position + size]
        position += size
        if key >> 16 == object_id:
            fields[key & 0xFFFF] = value
    return fields


def _uint32(value: bytes | None) -> int | None:
    return struct.unpack("<I", value)[0] if value is not None and len(value) == 4 else None


def _float32(value: bytes | None) -> float | None:
    return struct.unpack("<f", value)[0] if value is not None and len(value) == 4 else None


def probe(
    dll_dir: Path,
    module_id: int,
    dll_name: str = DDLCXX_QUALCOMM_DLL,
) -> dict[str, object]:
    result: dict[str, object] = {
        "available": False,
        "dll": str(dll_dir / dll_name),
        "dll_name": dll_name,
        "module_id": int(module_id),
        "config_id": DDLCXX_PLUGIN_NAME_CONFIG_ID,
        "python_bits": struct.calcsize("P") * 8,
        "platform": platform.system(),
    }
    codec: _DdlcxxCodec | None = None
    try:
        codec = _DdlcxxCodec(dll_dir, module_id, dll_name)
        result["library_base"] = f"0x{int(codec.lib._handle):08X}"
        result["handle_created"] = True
        result["configured"] = True
        result["available"] = True
    except BaseException as exc:
        result["error_type"] = type(exc).__name__
        result["error"] = str(exc)
    finally:
        if codec is not None:
            codec.close()
    return result


def _emit(value: dict[str, object]) -> None:
    print(json.dumps(value, ensure_ascii=True, sort_keys=True), flush=True)


def _stream(dll_dir: Path, module_id: int, dll_name: str) -> int:
    codec: _DdlcxxCodec | None = None
    try:
        codec = _DdlcxxCodec(dll_dir, module_id, dll_name)
        _emit(
            {
                "op": "ready",
                "available": True,
                "dll_name": dll_name,
                "module_id": int(module_id),
                "config_id": DDLCXX_PLUGIN_NAME_CONFIG_ID,
            }
        )
        for line in sys.stdin:
            request: object = None
            try:
                request = json.loads(line)
                if not isinstance(request, dict):
                    raise ValueError("request must be a JSON object")
                operation = request.get("op")
                if operation == "close":
                    _emit({"op": "closed"})
                    return 0
                if operation != "feed":
                    raise ValueError(f"unsupported operation: {operation!r}")
                payload = base64.b64decode(request["payload_b64"], validate=True)
                result = codec.parse(
                    payload=payload,
                    log_type=int(request["log_type"]),
                    native_cur_time=int(request.get("native_cur_time", 0)),
                    receive_time_ns=int(request["receive_time_ns"]),
                )
                _emit({"op": "result", "request_id": request.get("request_id"), "result": result})
            except BaseException as exc:
                _emit(
                    {
                        "op": "error",
                        "request_id": request.get("request_id") if isinstance(request, dict) else None,
                        "error_type": type(exc).__name__,
                        "error": str(exc),
                    }
                )
    except BaseException as exc:
        _emit(
            {
                "op": "ready",
                "available": False,
                "error_type": type(exc).__name__,
                "error": str(exc),
            }
        )
        return 2
    finally:
        if codec is not None:
            codec.close()
    return 0


def main(argv: list[str] | None = None) -> int:
    parser = argparse.ArgumentParser(description="Run DDLCXX in an isolated x86 process")
    parser.add_argument("--dll-dir", required=True, type=Path)
    parser.add_argument("--module-id", required=True, type=int)
    parser.add_argument("--dll-name", default=DDLCXX_QUALCOMM_DLL)
    parser.add_argument("--stream", action="store_true")
    args = parser.parse_args(argv)
    if args.stream:
        return _stream(args.dll_dir, args.module_id, args.dll_name)
    result = probe(args.dll_dir, args.module_id, args.dll_name)
    _emit(result)
    return 0 if result.get("available") else 2


if __name__ == "__main__":
    raise SystemExit(main())
