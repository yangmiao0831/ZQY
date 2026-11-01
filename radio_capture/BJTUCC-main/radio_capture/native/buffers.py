"""Owned native buffer helpers and lifetime utilities."""

from __future__ import annotations

import ctypes as C
from dataclasses import dataclass


@dataclass
class OwnedBytes:
    """ctypes byte buffer with explicit Python ownership."""

    data: bytes

    def __post_init__(self) -> None:
        self.buffer = C.create_string_buffer(self.data, len(self.data))

    @property
    def ptr(self):
        return C.cast(self.buffer, C.c_void_p)

    @property
    def length(self) -> int:
        return len(self.data)


def output_buffer(size: int = 64 * 1024):
    return (C.c_ubyte * size)()

