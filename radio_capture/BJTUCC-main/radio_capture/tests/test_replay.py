"""Tests for replaying raw frames through the pipeline."""

from radio_capture.models import FrameEnvelope
from radio_capture.pipeline.frame import pack_frame


def test_pack_frame_contains_payload():
    frame = FrameEnvelope("s", 1, 2, 3, 4, 3, b"abc")
    assert pack_frame(frame).endswith(b"abc")

