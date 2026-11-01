"""Tests for pipeline routing policy."""

from __future__ import annotations

from unittest.mock import Mock

from radio_capture.models import FrameEnvelope
from radio_capture.pipeline.parser import FrameParser
from radio_capture.pipeline.router import PipelineRouter


def _payload(msg_code: int) -> bytes:
    declared_length = 16
    return (
        b"\x10\x00"
        + declared_length.to_bytes(2, "little")
        + declared_length.to_bytes(2, "little")
        + msg_code.to_bytes(2, "little")
        + b"\x00" * 12
    )


def _frame(msg_code: int) -> FrameEnvelope:
    payload = _payload(msg_code)
    return FrameEnvelope("session", 1, 2, 3, 4, len(payload), payload)


def test_metrics_only_skips_non_metric_msg_codes_before_decoding():
    codec = Mock()
    router = PipelineRouter(
        raw_writer=Mock(),
        parser=FrameParser(),
        codec=codec,
        metrics_writer=Mock(),
        metrics_only=True,
    )

    assert router.process_frame(_frame(0x1C6E), eq_id=1, module_id=1) is None
    codec.get_display_format.assert_not_called()
    codec.get_detail.assert_not_called()


def test_metrics_only_decodes_metric_msg_codes():
    codec = Mock()
    codec.get_display_format.return_value = (0, 0)
    codec.get_detail.return_value = (
        0,
        b"<QualcommMessage><Header /><Content><MCS>24</MCS></Content></QualcommMessage>",
    )
    metrics_writer = Mock()
    router = PipelineRouter(
        raw_writer=Mock(),
        parser=FrameParser(),
        codec=codec,
        metrics_writer=metrics_writer,
        metrics_only=True,
    )

    record = router.process_frame(_frame(0xB883), eq_id=1, module_id=1)

    assert record is not None
    assert record.msg_code == 0xB883
    codec.get_detail.assert_called_once()
    metrics_writer.write.assert_called_once_with(record)


def test_metrics_only_decodes_nr_rrc_ota_for_bwp_state():
    codec = Mock()
    codec.get_display_format.return_value = (0, 0)
    codec.get_detail.return_value = (
        0,
        b"<QualcommMessage><Header /><Content /></QualcommMessage>",
    )
    metrics_writer = Mock()
    router = PipelineRouter(
        raw_writer=Mock(),
        parser=FrameParser(),
        codec=codec,
        metrics_writer=metrics_writer,
        metrics_only=True,
    )

    record = router.process_frame(_frame(0xB821), eq_id=1, module_id=1)

    assert record is not None
    assert record.msg_code == 0xB821
    codec.get_detail.assert_called_once()
    metrics_writer.write.assert_called_once_with(record)


def test_metrics_only_decodes_lte_metric_codes_when_4g_writer_is_configured():
    codec = Mock()
    codec.get_display_format.return_value = (0, 0)
    codec.get_detail.return_value = (
        0,
        b"<QualcommMessage><Content><MCS_Index>17</MCS_Index></Content></QualcommMessage>",
    )
    lte_metrics_writer = Mock()
    router = PipelineRouter(
        raw_writer=Mock(),
        parser=FrameParser(),
        codec=codec,
        lte_metrics_writer=lte_metrics_writer,
        metrics_only=True,
    )

    record = router.process_frame(_frame(0xB16D), eq_id=1, module_id=1)

    assert record is not None
    assert record.msg_code == 0xB16D
    codec.get_detail.assert_called_once()
    lte_metrics_writer.write_dm.assert_called_once_with(record)
