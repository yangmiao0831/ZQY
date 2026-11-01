"""ctypes ABI definitions for the DDDIXX log codec dispatcher."""

from __future__ import annotations

import ctypes as C

CDECL = C.CFUNCTYPE

CREATE_CODEC = CDECL(C.c_void_p, C.c_int32)
CONFIG_CODEC = CDECL(C.c_int32, C.c_void_p, C.c_int32, C.c_void_p, C.c_int32)
GET_DETAIL = CDECL(
    C.c_int32,
    C.c_void_p,
    C.c_uint32,
    C.c_int32,
    C.POINTER(C.c_ubyte),
    C.POINTER(C.c_int32),
    C.POINTER(C.c_ubyte),
)
GET_DISPLAY_FORMAT = CDECL(C.c_int32, C.c_void_p, C.c_uint32, C.POINTER(C.c_int32))
FREE_CODEC = CDECL(C.c_int32, C.c_void_p)
GET_STANDARD_BIN = GET_DETAIL

DECODER_EXPORTS = {
    "DDDIXX01": CREATE_CODEC,
    "DDDIXX02": CONFIG_CODEC,
    "DDDIXX03": GET_DETAIL,
    "DDDIXX04": GET_DISPLAY_FORMAT,
    "DDDIXX05": FREE_CODEC,
    "DDDIXX06": GET_STANDARD_BIN,
}

