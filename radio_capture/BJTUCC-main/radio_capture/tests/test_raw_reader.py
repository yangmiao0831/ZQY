"""Tests for the continuous raw DIAG stream adapter."""

from radio_capture.native.raw_reader import DiagFrameAssembler
from radio_capture.tools.qwinlog_init import (
    QWINLOG_EMPTY_MASKS,
    QWINLOG_PRE_CONFIG,
    _diag_frame,
    send_qwinlog_pre_config,
)


def _native_payload() -> bytes:
    return b"\x10\x00\x10\x00\x10\x00\x83\xb8" + b"\x00" * 8 + b"\x01\x02\x03\x04"


def test_assembler_strips_raw_diag_trailer():
    payload = _native_payload()
    raw_packet = payload + b"\xaa\xbb\x7e"

    assert DiagFrameAssembler().feed(raw_packet) == [payload]


def test_assembler_extracts_qwinlog_wrapped_log_packet():
    payload = _native_payload()
    wrapped_packet = b"\x98\x01\x00\x00\x01\x00\x00\x00" + payload + b"\xaa\xbb\x7e"

    assert DiagFrameAssembler().feed(wrapped_packet) == [payload]


def test_assembler_handles_packet_split_across_reads():
    payload = _native_payload()
    assembler = DiagFrameAssembler()

    assert assembler.feed(payload[:7]) == []
    assert assembler.feed(payload[7:] + b"\x00\x00\x7e") == [payload]


def test_assembler_ignores_non_log_packets():
    assert DiagFrameAssembler().feed(b"\x60\x0e\x00\xc3\x68\x7e") == []


def test_qwinlog_pre_config_contains_framed_control_messages():
    names = [name for name, _payload in QWINLOG_PRE_CONFIG]
    assert names[:2] == [
        "query_diag_id",
        "list_diag_file",
    ]
    assert names[2:6] == [
        "qdss_query",
        "etr_out_mode",
        "qdss_feature_mask",
        "qdss_enable",
    ]
    assert all(payload.endswith(b"\x7e") for _name, payload in QWINLOG_PRE_CONFIG)
    assert all(len(payload) >= 5 for _name, payload in QWINLOG_PRE_CONFIG)


def test_qwinlog_pre_config_uses_qwinlog_diag_payloads():
    frames = dict(QWINLOG_PRE_CONFIG)
    # Remove CRC/HDLC escaping only for the command-prefix assertion.
    def unframe(frame):
        data = frame[:-1]
        unescaped = bytearray()
        index = 0
        while index < len(data):
            if data[index] == 0x7D:
                index += 1
                unescaped.append(data[index] ^ 0x20)
            else:
                unescaped.append(data[index])
            index += 1
        return bytes(unescaped[:-2])

    assert unframe(frames["list_diag_file"]) == bytes.fromhex(
        "80 12 16 08 01 00 00 00"
    )
    assert unframe(frames["etr_out_mode"]) == bytes.fromhex("4B 5A 01 01 03")
    assert unframe(frames["qdss_enable"]) == bytes.fromhex("4B 5A 03 01 03")
    assert unframe(frames["qdss_tracer"]) == bytes.fromhex("4B 5A 08 02 03 0D")
    assert unframe(frames["qdss_transport"]) == bytes.fromhex("4B 5A 06 02 03")
    assert unframe(frames["diag_transport"]) == bytes.fromhex("4B 12 14 02 01 03")


def test_diag_frame_crc_matches_installed_qwinlog():
    assert _diag_frame(bytes.fromhex("73 00 00 00 00 00 00 00")) == QWINLOG_EMPTY_MASKS[0][1]


def test_qwinlog_pre_config_waits_for_diag_file_readiness():
    class FakeSerial:
        def __init__(self):
            self.writes = []

        def write(self, payload):
            self.writes.append(payload)

        def drain(self, _duration_sec):
            return b"response"

    serial = FakeSerial()
    response_bytes = send_qwinlog_pre_config(
        serial,
        drain_sec=0,
        diag_file_retries=3,
        diag_file_retry_delay_sec=0,
    )

    expected_counts = {
        payload: (3 if name == "list_diag_file" else 1)
        for name, payload in QWINLOG_PRE_CONFIG
    }
    assert response_bytes == sum(expected_counts[payload] * len(b"response") for payload in expected_counts)
    assert len(serial.writes) == len(QWINLOG_PRE_CONFIG) + 2
    assert serial.writes.count(dict(QWINLOG_PRE_CONFIG)["list_diag_file"]) == 3
    assert serial.writes.count(dict(QWINLOG_PRE_CONFIG)["query_diag_id"]) == 1
