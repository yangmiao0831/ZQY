"""Tests for controller ABI layouts and exported signatures."""

import ctypes as C

from radio_capture.native.controller_abi import (
    CONTROLLER_EXPORTS,
    DCInfoPointerLayout,
    OwnedDCInfo,
    QUALCOMM_CONTROLLER_EXPORTS,
)


def test_controller_exports_are_declared():
    assert set(CONTROLLER_EXPORTS) == {
        "DDDCXX01",
        "DDDCXX04",
        "DDDCXX05",
        "DDDCXX06",
        "DDDCXX07",
        "DDDCXX08",
        "DDDCXX09",
        "DDDCXX0A",
    }


def test_owned_dc_info_keeps_payload_alive():
    info = OwnedDCInfo(1, b"\x07\x00\x00\x00")
    assert C.sizeof(DCInfoPointerLayout) >= 12
    assert info.header.length == 4
    assert info.header.value


def test_qualcomm_info_is_inline_after_the_header():
    info = OwnedDCInfo(1, b"\x04\x00\x00\x00", inline=True)
    assert info.header is None
    assert C.string_at(info.ptr, 12) == b"\x01\x00\x00\x00\x04\x00\x00\x00\x04\x00\x00\x00"
    assert set(QUALCOMM_CONTROLLER_EXPORTS) == set(CONTROLLER_EXPORTS)
