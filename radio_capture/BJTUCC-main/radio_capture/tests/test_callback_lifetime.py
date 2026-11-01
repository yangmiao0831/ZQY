"""Tests for callback ownership and payload lifetime rules."""

import ctypes as C

from radio_capture.models import (
    DecoderConfig,
    DeviceConfig,
    DeviceSessionConfig,
    FrameEnvelope,
    LogmaskConfig,
    OutputConfig,
    PortsConfig,
    RuntimeConfig,
    SessionContext,
)
from radio_capture.native.callbacks import CallbackDispatcher
from radio_capture.pipeline.queue import BoundedFrameQueue
from radio_capture.pipeline.parser import FrameParser


def test_bounded_queue_accepts_frame():
    queue = BoundedFrameQueue(1)
    frame = FrameEnvelope("s", 1, 2, 3, 4, 3, b"abc")
    assert queue.put_nowait(frame)
    assert queue.get(timeout=0).payload == b"abc"


def test_parser_extracts_qualcomm_log_code():
    payload = b"\x10\x00\x10\x00\x10\x00\x83\xb8" + b"\x00" * 8 + b"\x01\x02\x03\x04"
    assert FrameParser.extract_msg_code(payload) == 0xB883


def test_parser_skips_non_log_dm_packets():
    assert FrameParser.extract_msg_code(b"\x60\x0e\x00\xc3\x68" + b"\x00" * 12) is None


def test_callback_rejects_oversize_length_without_ctypes_error(tmp_path):
    config = DeviceSessionConfig(
        runtime=RuntimeConfig("x86", tmp_path),
        device=DeviceConfig(eq_id=1, chip_type="qualcomm", eq_type="ue"),
        ports=PortsConfig(),
        logmask=LogmaskConfig(),
        decoder=DecoderConfig(),
        output=OutputConfig(
            tmp_path / "raw",
            tmp_path / "decoded.jsonl",
            tmp_path / "radio.db",
        ),
    )
    context = SessionContext(config)
    dispatcher = CallbackDispatcher(context, BoundedFrameQueue(1))
    data = C.create_string_buffer(b"valid")

    dispatcher._on_log(None, 1, C.cast(data, C.c_void_p), 0xFFFFFFFF, 0)

    assert dispatcher.stats.callback_calls == 1
    assert dispatcher.stats.invalid_frames == 1
    assert dispatcher.stats.oversize_frames == 1
    assert "exceeds limit" in (dispatcher.stats.last_error or "")
