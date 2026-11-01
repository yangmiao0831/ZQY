"""ctypes ABI definitions for the device controller DLL."""

from __future__ import annotations

import ctypes as C
from dataclasses import dataclass
import struct

from radio_capture.native.buffers import OwnedBytes

CDECL = C.CFUNCTYPE

LOG_CALLBACK = C.WINFUNCTYPE(
    None,
    C.c_void_p,
    C.c_int32,
    C.c_void_p,
    C.c_uint32,
    C.c_uint64,
)


class DCInfoPointerLayout(C.Structure):
    """First MVP layout hypothesis: header plus pointer to owned payload."""

    _pack_ = 1
    _fields_ = [
        ("type", C.c_uint32),
        ("length", C.c_uint32),
        ("value", C.c_void_p),
    ]


@dataclass
class OwnedInlineDCInfo:
    """Own a TDC info record whose variable value starts at byte offset 8."""

    type_id: int
    payload: bytes

    def __post_init__(self) -> None:
        raw = struct.pack("<II", int(self.type_id), len(self.payload)) + bytes(self.payload)
        self.buffer = C.create_string_buffer(raw, len(raw))

    @property
    def ptr(self):
        return C.cast(self.buffer, C.c_void_p)


@dataclass
class OwnedDCInfo:
    type_id: int
    payload: bytes
    inline: bool = False

    def __post_init__(self) -> None:
        if self.inline:
            self.inline_info = OwnedInlineDCInfo(self.type_id, self.payload)
            self.owned_payload = None
            self.header = None
        else:
            self.inline_info = None
            self.owned_payload = OwnedBytes(self.payload)
            self.header = DCInfoPointerLayout(
                C.c_uint32(self.type_id),
                C.c_uint32(self.owned_payload.length),
                self.owned_payload.ptr,
            )

    @property
    def ptr(self):
        if self.inline_info is not None:
            return self.inline_info.ptr
        return C.byref(self.header)


CREATE_CONTROLLER = CDECL(C.c_void_p, C.c_int32)
CONFIG_PORT = CDECL(C.c_int32, C.c_void_p, C.c_void_p)
CONNECT = CDECL(C.c_int32, C.c_void_p, LOG_CALLBACK, C.c_void_p, C.c_uint32)
RECOVER = CDECL(C.c_int32, C.c_void_p)
SEND_CHIP_INFO = CDECL(C.c_int32, C.c_void_p)
SEND_COMMAND = CDECL(C.c_int32, C.c_void_p, C.c_void_p)
DISCONNECT = CDECL(C.c_int32, C.c_void_p, C.c_uint32)
FREE_CONTROLLER = CDECL(C.c_int32, C.c_void_p)


CONTROLLER_EXPORTS = {
    "DDDCXX01": CREATE_CONTROLLER,
    "DDDCXX04": CONFIG_PORT,
    # The reference DC_CommonSocket.dll exposes the callback-based connect
    # entry point as DDDCXX06. DDDCXX05 is the preceding recovery/config slot.
    "DDDCXX05": RECOVER,
    "DDDCXX06": CONNECT,
    "DDDCXX07": SEND_CHIP_INFO,
    "DDDCXX08": SEND_COMMAND,
    "DDDCXX09": DISCONNECT,
    "DDDCXX0A": FREE_CONTROLLER,
}


# DDDCXX01.dll is the Qualcomm trace controller shipped with send. Its
# numbering differs from DC_CommonSocket.dll.
QUALCOMM_CONTROLLER_EXPORTS = {
    "DDDCXX01": CREATE_CONTROLLER,
    "DDDCXX04": CONFIG_PORT,
    "DDDCXX05": CONNECT,
    "DDDCXX06": RECOVER,
    "DDDCXX07": SEND_COMMAND,
    "DDDCXX08": SEND_CHIP_INFO,
    "DDDCXX09": DISCONNECT,
    "DDDCXX0A": FREE_CONTROLLER,
}
