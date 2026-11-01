"""Tests for the background frame consumer lifecycle."""

from __future__ import annotations

import sqlite3
import time
import queue as queue_module
from contextlib import closing
from dataclasses import replace

from radio_capture.errors import CaptureWorkerError
from radio_capture.models import (
    DecoderConfig,
    DeviceConfig,
    DeviceSessionConfig,
    FrameEnvelope,
    LogmaskConfig,
    OutputConfig,
    PortsConfig,
    RuntimeConfig,
)
from radio_capture.pipeline.queue import DiskSpoolFrameQueue
from radio_capture.session.manager import CaptureSession
from radio_capture.session.state import CaptureState


def _config(tmp_path) -> DeviceSessionConfig:
    return DeviceSessionConfig(
        runtime=RuntimeConfig("x86", tmp_path, callback_queue_size=8),
        device=DeviceConfig(eq_id=1, chip_type="qualcomm", eq_type="ue"),
        ports=PortsConfig(),
        logmask=LogmaskConfig(),
        decoder=DecoderConfig(codec_module_id=1),
        output=OutputConfig(
            raw_dir=tmp_path / "raw",
            decoded_jsonl=tmp_path / "decoded.jsonl",
            sqlite_file=tmp_path / "capture.sqlite3",
        ),
    )


def _payload(msg_code: int) -> bytes:
    declared_length = 16
    return (
        b"\x10\x00"
        + declared_length.to_bytes(2, "little")
        + declared_length.to_bytes(2, "little")
        + msg_code.to_bytes(2, "little")
        + b"\x00" * 12
    )


def _frame(session_id: str, sequence: int, msg_code: int) -> FrameEnvelope:
    payload = _payload(msg_code)
    return FrameEnvelope(
        session_id,
        sequence,
        time.time_ns(),
        0,
        1,
        len(payload),
        payload,
    )


def test_worker_consumes_and_persists_frames(tmp_path):
    session = CaptureSession(_config(tmp_path))
    session.sqlite_store.open()
    session.raw_writer.open()
    session.state = CaptureState.PORTS_CONFIGURED
    session.start_workers()

    frame = FrameEnvelope(session.context.session_id, 1, 2, 3, 4, 3, b"abc")
    assert session.frame_queue.put_nowait(frame)

    deadline = time.monotonic() + 2.0
    while session.frame_queue.stats.dequeued < 1 and time.monotonic() < deadline:
        time.sleep(0.01)

    session.stop()

    assert session.frame_queue.stats.dequeued == 1
    assert session.raw_writer.bin_path.read_bytes().endswith(b"abc")
    with closing(sqlite3.connect(session.sqlite_store.path)) as conn:
        row = conn.execute("SELECT payload FROM raw_frame WHERE sequence = 1").fetchone()
    assert row == (b"abc",)


def test_session_wires_separate_dm_and_at_metric_csvs(tmp_path):
    config = _config(tmp_path)
    config = replace(
        config,
        ports=PortsConfig(trace_port=6, at_port=3),
        output=replace(config.output, metrics_only=True),
    )
    session = CaptureSession(config)

    assert session.dm_metrics_path.name == "dm_metrics.csv"
    assert session.at_metrics_path.name == "at_metrics.csv"
    assert session.merged_metrics_path is None
    assert session.four_g_metrics_path is None
    assert session.at_writer.metrics_writer is None
    assert session.at_writer.persist_csv is True
    assert session.at_writer.lte_csv_path is None


def test_session_uses_configured_dm_write_interval(tmp_path):
    config = _config(tmp_path)
    config = replace(
        config,
        output=replace(config.output, dm_write_interval_sec=2.5),
    )

    session = CaptureSession(config)

    assert session.metrics_writer.write_interval_sec == 2.5
    assert session.at_writer.write_interval_sec == 0.5


def test_session_wires_optional_4g_metric_csv(tmp_path):
    config = _config(tmp_path)
    config = replace(
        config,
        ports=PortsConfig(trace_port=6, at_port=3),
        output=replace(
            config.output,
            metrics_only=True,
            four_g_metrics_csv=tmp_path / "raw" / "{session_id}" / "4G_metrics.csv",
        ),
    )
    session = CaptureSession(config)

    assert session.four_g_metrics_path.name == "4G_metrics.csv"
    assert session.four_g_metrics_writer is not None
    assert session.router.lte_metrics_writer is session.four_g_metrics_writer
    assert session.at_writer.lte_csv_path == session.four_g_metrics_path


def test_session_wires_optional_live_merged_metric_csv(tmp_path):
    config = _config(tmp_path)
    config = replace(
        config,
        ports=PortsConfig(trace_port=6, at_port=3),
        output=replace(
            config.output,
            metrics_only=True,
            merged_metrics_csv=tmp_path / "raw" / "{session_id}" / "merged_metrics.csv",
        ),
    )
    session = CaptureSession(config)

    assert session.dm_metrics_path.name == "dm_metrics.csv"
    assert session.at_metrics_path.name == "at_metrics.csv"
    assert session.merged_metrics_path.name == "merged_metrics.csv"
    assert session.merged_metrics_writer is not None
    assert session.at_writer.metrics_writer is session.merged_metrics_writer
    assert session.router_metrics_writer is not session.metrics_writer


def test_metrics_only_queue_prioritizes_nr_rrc_ota(tmp_path):
    queue = DiskSpoolFrameQueue(
        tmp_path / "spool",
        "session",
        priority_msg_codes={0xB821},
    )
    try:
        assert queue.put_nowait(_frame("session", 1, 0xB8C9))
        assert queue.put_nowait(_frame("session", 2, 0xB821))

        assert queue.get(timeout=0).sequence == 2
        assert queue.get(timeout=0).sequence == 1
        try:
            queue.get(timeout=0)
        except queue_module.Empty:
            pass
        else:
            raise AssertionError("priority frame was returned twice")
        assert queue.stats.dequeued == 2
    finally:
        queue.close()


def test_metrics_only_priority_queue_does_not_starve_fifo_frames(tmp_path):
    queue = DiskSpoolFrameQueue(
        tmp_path / "spool",
        "session",
        priority_msg_codes={0xB821},
    )
    try:
        assert queue.put_nowait(_frame("session", 1, 0xB883))
        for sequence in range(2, 11):
            assert queue.put_nowait(_frame("session", sequence, 0xB821))

        assert [queue.get(timeout=0).sequence for _ in range(9)] == [
            2, 3, 4, 5, 6, 7, 8, 9, 1
        ]
        assert queue.get(timeout=0).sequence == 10
    finally:
        queue.close()


def test_metrics_only_session_enables_nr_rrc_ota_priority(tmp_path):
    config = replace(_config(tmp_path), output=replace(_config(tmp_path).output, metrics_only=True))
    session = CaptureSession(config)

    assert session.frame_queue.put_nowait(_frame(session.context.session_id, 1, 0xB8C9))
    assert session.frame_queue.put_nowait(_frame(session.context.session_id, 2, 0xB821))

    try:
        assert session.frame_queue.get(timeout=0).sequence == 2
    finally:
        session.frame_queue.close()


def test_metrics_only_stop_does_not_drain_backlog(tmp_path):
    config = replace(_config(tmp_path), output=replace(_config(tmp_path).output, metrics_only=True))
    session = CaptureSession(config)
    session.state = CaptureState.PORTS_CONFIGURED

    def slow_process(*_args):
        time.sleep(0.05)

    session.router.process_frame = slow_process
    session.start_workers()
    session.state = CaptureState.CAPTURING
    for sequence in range(1, 30):
        frame = FrameEnvelope(
            session.context.session_id,
            sequence,
            time.time_ns(),
            0,
            1,
            3,
            b"abc",
        )
        assert session.frame_queue.put_nowait(frame)

    session.stop(timeout=0.5)

    assert session.state == CaptureState.CLOSED
    assert session.frame_queue.stats.dequeued < 29


def test_worker_failure_is_reported_to_foreground(tmp_path):
    session = CaptureSession(_config(tmp_path))
    session.sqlite_store.open()
    session.raw_writer.open()
    session.state = CaptureState.PORTS_CONFIGURED

    def fail(*_args):
        raise OSError("storage failed")

    session.router.process_frame = fail
    session.start_workers()
    session.state = CaptureState.CAPTURING
    frame = FrameEnvelope(session.context.session_id, 1, 2, 3, 4, 3, b"abc")
    assert session.frame_queue.put_nowait(frame)

    try:
        session.wait(poll_interval=0.01)
    except CaptureWorkerError as exc:
        assert isinstance(exc.__cause__, OSError)
    else:
        raise AssertionError("worker failure was not reported")
    finally:
        session.stop()
