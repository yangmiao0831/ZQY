"""CaptureSession orchestration, startup, shutdown, and cleanup."""

from __future__ import annotations

import queue as queue_module
import threading
import time
from datetime import datetime, timezone
from pathlib import Path

from radio_capture.errors import CaptureWorkerError, QueueOverflowError, SessionStateError
from radio_capture.models import DeviceSessionConfig, SessionContext, create_session_id
from radio_capture.native.callbacks import CallbackDispatcher
from radio_capture.native.controller import DeviceController
from radio_capture.native.decoder import LogCodec
from radio_capture.native.autocom_bler_process import AutocomPuschBlerProcess
from radio_capture.native.raw_reader import QWinLogRawReader
from radio_capture.native.win32_loader import Win32NativeLoader
from radio_capture.pipeline.parser import FrameParser
from radio_capture.pipeline.queue import DiskSpoolFrameQueue
from radio_capture.pipeline.raw_sink import RawWriter
from radio_capture.pipeline.metrics_sink import MetricsCsvWriter, MetricsWriterFanout
from radio_capture.pipeline.at_sink import AtSignalWriter, FourGMetricsCsvWriter
from radio_capture.pipeline.decoded_sink import DecodedJsonlWriter
from radio_capture.pipeline.router import PipelineRouter
from radio_capture.profiles import ProfileResolver
from radio_capture.session.state import CaptureState, ensure_transition
from radio_capture.session.log_control import StartLogController
from radio_capture.storage.sqlite_store import SQLiteStore


class CaptureSession:
    _FLUSH_FRAME_BATCH = 128
    _FLUSH_INTERVAL_SEC = 1.0
    _AT_CSV_WRITE_INTERVAL_SEC = 0.5
    _METRICS_ONLY_PRIORITY_MSG_CODES = {0xB821}

    def __init__(self, config: DeviceSessionConfig):
        self.config = config
        self.metrics_only = bool(config.output.metrics_only)
        self.profile = ProfileResolver().resolve(config)
        self.context = SessionContext(
            config,
            session_id=create_session_id(config.output.raw_dir),
        )
        self.state = CaptureState.NEW
        self.loader = Win32NativeLoader(config.runtime.dll_dir)
        self.controller: DeviceController | None = None
        self.codec: LogCodec | None = None
        self.connect_return_code: int | None = None
        self.port_config_return_codes: list[tuple[int, int]] = []
        self.callback_dispatcher: CallbackDispatcher | None = None
        self.raw_writer = RawWriter(config.output.raw_dir, self.context.session_id)
        self.frame_queue = DiskSpoolFrameQueue(
            self.raw_writer.session_dir / "spool",
            self.context.session_id,
            priority_msg_codes=(
                self._METRICS_ONLY_PRIORITY_MSG_CODES if self.metrics_only else None
            ),
        )
        self.sqlite_store = SQLiteStore(config.output.sqlite_file)
        session_dir = self.raw_writer.session_dir
        dm_path = config.output.dm_metrics_csv
        if dm_path is None:
            dm_path = session_dir / "dm_metrics.csv"
        else:
            dm_path = Path(str(dm_path).replace("{session_id}", self.context.session_id))
        at_path = config.output.at_metrics_csv
        if at_path is None:
            at_path = session_dir / "at_metrics.csv"
        else:
            at_path = Path(str(at_path).replace("{session_id}", self.context.session_id))
        four_g_path = config.output.four_g_metrics_csv
        if four_g_path is not None:
            four_g_path = Path(
                str(four_g_path).replace("{session_id}", self.context.session_id)
            )
        # DM and AT are intentionally kept as separate artifacts.  A merged
        # CSV is only produced when the caller explicitly configures one.
        merged_path = config.output.merged_metrics_csv
        if merged_path is not None:
            merged_path = Path(
                str(merged_path).replace("{session_id}", self.context.session_id)
            )
        self.dm_metrics_path = dm_path
        self.at_metrics_path = at_path
        self.four_g_metrics_path = four_g_path
        self.merged_metrics_path = merged_path
        self.metrics_writer = MetricsCsvWriter(
            dm_path,
            self.context.session_id,
            write_interval_sec=config.output.dm_write_interval_sec,
        )
        self.merged_metrics_writer = (
            MetricsCsvWriter(
                merged_path,
                self.context.session_id,
                write_interval_sec=config.output.dm_write_interval_sec,
            )
            if merged_path is not None
            else None
        )
        self.router_metrics_writer = (
            MetricsWriterFanout(self.metrics_writer, self.merged_metrics_writer)
            if self.merged_metrics_writer is not None
            else self.metrics_writer
        )
        self.four_g_metrics_writer = (
            FourGMetricsCsvWriter(
                four_g_path,
                self.context.session_id,
                write_interval_sec=config.output.dm_write_interval_sec,
            )
            if four_g_path is not None
            else None
        )
        self.at_writer = AtSignalWriter(
            self.raw_writer.session_dir,
            self.context.session_id,
            metrics_writer=self.merged_metrics_writer,
            persist_jsonl=not self.metrics_only,
            persist_csv=True,
            csv_path=at_path,
            lte_metrics_writer=self.four_g_metrics_writer,
            write_interval_sec=self._AT_CSV_WRITE_INTERVAL_SEC,
        )
        self.decoded_writer = DecodedJsonlWriter(
            config.output.decoded_jsonl,
            self.context.session_id,
        )
        self.router = PipelineRouter(
            self.raw_writer,
            FrameParser(),
            self.sqlite_store,
            lte_metrics_writer=self.four_g_metrics_writer,
            metrics_only=self.metrics_only,
        )
        self._worker_stop = threading.Event()
        self._worker: threading.Thread | None = None
        self._worker_error: Exception | None = None
        self._worker_error_lock = threading.Lock()
        self._native_lock = threading.RLock()
        self._monitor_stop = threading.Event()
        self._monitor: threading.Thread | None = None
        self._at_stop = threading.Event()
        self._at_worker: threading.Thread | None = None
        self._at_error: Exception | None = None
        self._at_records = 0
        self._reconnect_attempts = 0
        self.log_controller: StartLogController | None = None
        self.raw_dm_reader: QWinLogRawReader | None = None
        self.pusch_bler_process = AutocomPuschBlerProcess(
            dll_dir=config.runtime.dll_dir,
            module_id=int(self.profile.codec_module_id),
        )
        self.router.pusch_bler_process = self.pusch_bler_process

    @property
    def uses_raw_dm_reader(self) -> bool:
        return self.config.logmask.mode.lower() == "qwinlog"

    def open(self) -> None:
        self._transition(CaptureState.CONFIG_LOADED)
        self.loader.assert_x86_process()
        required_files = [self.profile.decoder_dispatcher_dll, self.profile.expected_plugin]
        if not self.uses_raw_dm_reader:
            required_files.insert(0, self.profile.controller_dll)
        self.loader.validate_required_files(required_files)
        self._transition(CaptureState.DLL_LOADED)

        if not self.metrics_only:
            self.sqlite_store.open()
            self.sqlite_store.insert_session(
                self.context.session_id,
                self.config,
                self.state.value,
                datetime.now(timezone.utc).isoformat(),
            )
            self.raw_writer.open()
        if self.config.ports.at_port is not None:
            self.at_writer.open()
        if self.four_g_metrics_writer is not None:
            self.four_g_metrics_writer.open()
        if self.metrics_writer is not None:
            self.metrics_writer.open()
        if self.merged_metrics_writer is not None:
            self.merged_metrics_writer.open()
        if self.router_metrics_writer is not None:
            self.router.metrics_writer = self.router_metrics_writer
        if not self.metrics_only:
            self.decoded_writer.open()
            self.router.decoded_writer = self.decoded_writer
        if not self.uses_raw_dm_reader:
            self.controller = DeviceController(self.config.runtime.dll_dir, self.profile.controller_dll)
            self.controller.load()
        #拿到采集函数
            self.controller.create(self.profile.codec_module_id)
        self.codec = LogCodec(
            self.config.runtime.dll_dir,
            self.profile.decoder_dispatcher_dll,
        )
        self.codec.load()
        self.codec.create(self.profile.codec_module_id)
        self.router.codec = self.codec
        if self.pusch_bler_process.start():
            print(
                "PUSCH BLER worker ready "
                "dll=DDLCXX01.dll config_id=2 object=0x139F field=0x139F0005"
            )
        else:
            print(
                "PUSCH BLER worker unavailable; capture continues without it: "
                f"{self.pusch_bler_process.last_error}"
            )
        if self.controller is not None:
            self.log_controller = StartLogController(
                self.controller,
                self.config.logmask,
                self.config.shutdown,
            )
        self._transition(CaptureState.INSTANCE_CREATED)

    def configure_ports(self) -> None:
        if self.uses_raw_dm_reader:
            print(
                f"configured raw_dm_port trace={self.config.ports.trace_port} "
                f"baud={self.config.ports.baud_rate or 115200}"
            )
            self._transition(CaptureState.PORTS_CONFIGURED)
            return
        if self.controller is None:
            raise RuntimeError("session is not open")
        resolver = ProfileResolver()
        for type_id, payload in resolver.iter_port_payloads(self.config):
            rc = self.controller.configure_port(int(type_id), payload)
            self.port_config_return_codes.append((int(type_id), rc))
            if len(payload) == 4:
                payload_desc = f"value={int.from_bytes(payload, 'little')}"
            else:
                payload_desc = f"bytes={payload!r}"
            print(
                f"configured connect_info type={int(type_id)} {payload_desc} "
                f"rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}"
            )
            #这一步不明确
        self._transition(CaptureState.PORTS_CONFIGURED)

    def start_workers(self) -> None:
        if self.state != CaptureState.PORTS_CONFIGURED:
            raise SessionStateError(f"cannot start workers while session is {self.state.value}")
        if self._worker is not None and self._worker.is_alive():
            raise SessionStateError("capture worker is already running")

        self.context.stopping = False
        self._worker_stop.clear()
        with self._worker_error_lock:
            self._worker_error = None
        self._worker = threading.Thread(
            target=self._consume_frames,
            name=f"capture-consumer-{self.context.session_id[:8]}",
            daemon=False,
        )
        self._worker.start()

    def set_metrics_only(self, enabled: bool = True) -> None:
        if self.state != CaptureState.NEW:
            raise SessionStateError("metrics-only mode must be set before opening the session")
        self.metrics_only = enabled
        self.router.metrics_only = enabled
        self.frame_queue.set_priority_msg_codes(
            self._METRICS_ONLY_PRIORITY_MSG_CODES if enabled else None
        )

    def connect(self) -> None:
        if self._worker is None or not self._worker.is_alive():
            raise SessionStateError("capture worker must be running before connect")
        self.callback_dispatcher = CallbackDispatcher(self.context, self.frame_queue)
        if self.uses_raw_dm_reader:
            if self.config.ports.trace_port is None or self.config.logmask.file is None:
                raise RuntimeError("raw DM mode requires trace_port and logmask.file")
            self.raw_dm_reader = QWinLogRawReader(
                self.config.ports.trace_port,
                self.config.ports.baud_rate or 115200,
                self.config.logmask.file,
                self.callback_dispatcher.dispatch_payload,
            )
            self.raw_dm_reader.start()
            self.connect_return_code = 0
            print(
                f"raw DM reader started port={self.config.ports.trace_port} "
                "connect_rc=0 rc_hex=0x00000000"
            )
            self._transition(CaptureState.CONNECTED)
            self._transition(CaptureState.CAPTURING)
            self._start_at_capture()
            self._start_no_data_monitor()
            return
        if self.controller is None:
            raise RuntimeError("session is not open")
        if self.profile.chip_info_stage == "before_connect":
            rc = self.controller.send_chip_info()
            print(f"send_chip_info rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}")
        self.connect_return_code = self._connect_native()
        self._transition(CaptureState.CONNECTED)
        if self.profile.chip_info_stage == "after_connect":
            rc = self.controller.send_chip_info()
            print(f"send_chip_info rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}")
        self._transition(CaptureState.CAPTURING)
        if self.config.device.start_log and self.log_controller is not None:
            self.log_controller.start()
        self._start_at_capture()
        self._start_no_data_monitor()

    @property
    def at_error(self) -> Exception | None:
        return self._at_error

    @property
    def at_records(self) -> int:
        return self._at_records

    def _start_at_capture(self) -> None:
        if self.config.ports.at_port is None:
            return
        if self._at_worker is not None and self._at_worker.is_alive():
            return
        self._at_stop.clear()
        self._at_error = None
        self._at_worker = threading.Thread(
            target=self._capture_at_signals,
            name=f"at-capture-{self.context.session_id[:8]}",
            daemon=False,
        )
        self._at_worker.start()

    def _capture_at_signals(self) -> None:
        # Import lazily: the probe binds Win32 kernel32 and is only needed on
        # Windows when an AT port is actually configured.
        from radio_capture.tools.at_signal_probe import WinSerial, parse_signal

        port = str(self.config.ports.at_port)
        if port.isdigit():
            port = f"COM{port}"
        baud_rate = self.config.ports.baud_rate or 115200
        sequence = 0
        next_poll = time.monotonic()
        try:
            with WinSerial(port, baud_rate) as serial:
                while not self._at_stop.is_set():
                    responses = {
                        "csq": serial.query("AT+CSQ"),
                        "nwinfo": serial.query("AT+QNWINFO"),
                        "servingcell": serial.query('AT+QENG="servingcell"'),
                        "qcsq": serial.query("AT+QCSQ"),
                    }
                    record = parse_signal(responses)
                    sequence += 1
                    self.at_writer.write(record, sequence)
                    self._at_records = sequence
                    next_poll += self._AT_CSV_WRITE_INTERVAL_SEC
                    delay = max(0.0, next_poll - time.monotonic())
                    if self._at_stop.wait(delay):
                        break
                    if delay == 0.0:
                        next_poll = time.monotonic()
        except Exception as exc:
            self._at_error = exc
            print(f"AT capture stopped with warning: {exc!r}")

    def _connect_native(self) -> int:
        if self.controller is None or self.callback_dispatcher is None:
            raise RuntimeError("controller and callback must be initialized")
        with self._native_lock:
            rc = self.controller.connect(
                self.callback_dispatcher.callback,
                self.callback_dispatcher.user_param,
                self.config.device.connect_timeout_ms,
            )
        print(f"connect return rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}")
        return rc

    def _start_no_data_monitor(self) -> None:
        timeout = self.config.device.no_data_timeout_sec
        if timeout is None or timeout <= 0:
            return
        self._monitor_stop.clear()
        self._monitor = threading.Thread(
            target=self._monitor_no_data,
            name=f"capture-monitor-{self.context.session_id[:8]}",
            daemon=False,
        )
        self._monitor.start()

    def _monitor_no_data(self) -> None:
        timeout = float(self.config.device.no_data_timeout_sec or 0)
        poll = min(max(timeout / 4.0, 0.25), 5.0)
        last_activity = time.monotonic()
        last_received = 0
        while not self._monitor_stop.wait(poll):
            dispatcher = self.callback_dispatcher
            if dispatcher is None:
                continue
            received = dispatcher.stats.received_frames
            now = time.monotonic()
            if received != last_received:
                last_received = received
                last_activity = now
                self._reconnect_attempts = 0
            if now - last_activity < timeout:
                continue
            if self._reconnect_attempts >= self.config.device.max_reconnect_attempts:
                print(
                    "no DM data: maximum reconnect attempts reached "
                    f"({self._reconnect_attempts})"
                )
                return
            self._reconnect_attempts += 1
            self._recover_no_data(self._reconnect_attempts)
            last_activity = time.monotonic()

    def _recover_no_data(self, attempt: int) -> None:
        print(f"no DM data detected; recovery attempt={attempt}")
        if self.controller is None or self.callback_dispatcher is None:
            return
        try:
            with self._native_lock:
                if self.log_controller is not None:
                    self.log_controller.resend()
                if not self.config.device.reconnect:
                    return
                rc = self.controller.disconnect(self.config.device.connect_timeout_ms)
                print(f"recovery disconnect rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}")
                if self._monitor_stop.wait(self.config.device.reconnect_backoff_sec):
                    return
                rc = self.controller.recover()
                print(f"recovery native rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}")
                rc = self.controller.connect(
                    self.callback_dispatcher.callback,
                    self.callback_dispatcher.user_param,
                    self.config.device.connect_timeout_ms,
                )
                print(f"recovery connect rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}")
                if rc != 0:
                    return
                if self.profile.chip_info_stage == "after_connect":
                    chip_rc = self.controller.send_chip_info()
                    print(
                        f"recovery send_chip_info rc={chip_rc} "
                        f"rc_hex=0x{chip_rc & 0xFFFFFFFF:08X}"
                    )
                if self.config.device.start_log and self.log_controller is not None:
                    self.log_controller.start()
        except Exception as exc:
            print(f"recovery failed attempt={attempt}: {exc!r}")

    def wait(self, poll_interval: float = 0.25) -> None:
        """让主线程停在这里，保持采集程序继续运行，同时定期检查后台消费线程有没有出错、队列有没有溢出"""
        if self.state != CaptureState.CAPTURING:
            raise SessionStateError(f"cannot wait while session is {self.state.value}")
        while not self._worker_stop.wait(poll_interval):
            self._raise_worker_error()
            self._raise_queue_overflow()
            self._raise_raw_reader_error()
        self._raise_worker_error()
        self._raise_queue_overflow()
        self._raise_raw_reader_error()

    def _raise_raw_reader_error(self) -> None:
        if self.raw_dm_reader is None or self.raw_dm_reader.stats.last_error is None:
            return
        raise CaptureWorkerError(
            f"raw DM reader failed: {self.raw_dm_reader.stats.last_error}"
        )

    def drain_once(self, timeout: float | None = None) -> bool:
        frame = self.frame_queue.get(timeout=timeout)
        try:
            self.router.process_frame(frame, self.config.device.eq_id, self.profile.codec_module_id)
            return True
        finally:
            self.frame_queue.task_done()

    def drain_all(self) -> None:
        """把当前回调队列 frame_queue 里还没处理的所有帧全部处理完，
        然后把原始文件写入缓冲刷到磁盘"""
        while not self.frame_queue.empty():
            self.drain_once(timeout=0)
        self._flush_outputs()

    def _consume_frames(self) -> None:
        """是一个后台消费者循环，负责从帧队列中持续取帧处理，并根据“帧数批次”或“时间间隔”批量刷新输出；
        停止时会尽量处理完队列剩余数据，异常时会记录错误并触发会话停止。"""
        pending_frames = 0
        last_flush = time.monotonic()
        try:
            while not self._worker_stop.is_set() or (
                not self.metrics_only and not self.frame_queue.empty()
            ):
                #只要后台线程还没被要求停止，或者队列里还有没处理完的帧，就继续运行
                try:
                    self.drain_once(timeout=0.2)
                    pending_frames += 1
                except queue_module.Empty:
                    pass

                now = time.monotonic()
                if pending_frames >= self._FLUSH_FRAME_BATCH or (
                    pending_frames and now - last_flush >= self._FLUSH_INTERVAL_SEC
                ):
                    self._flush_outputs()
                    pending_frames = 0
                    last_flush = now
            if pending_frames:
                self._flush_outputs()
        except Exception as exc:
            with self._worker_error_lock:
                self._worker_error = exc
            self.context.stopping = True
            self._worker_stop.set()

    def _flush_outputs(self) -> None:
        if not self.metrics_only:
            self.raw_writer.flush()
        if not self.metrics_only and self.sqlite_store.conn is not None:
            self.sqlite_store.commit()

    def _raise_worker_error(self) -> None:
        with self._worker_error_lock:
            error = self._worker_error
        if error is not None:
            raise CaptureWorkerError("capture frame consumer failed") from error

    def _raise_queue_overflow(self) -> None:
        dropped = self.frame_queue.stats.dropped
        if dropped:
            raise QueueOverflowError(f"capture queue overflowed; dropped_frames={dropped}")

    def stop(self, timeout: float = 10.0) -> None:
        if self.state == CaptureState.CLOSED:
            return
        cleanup_error: Exception | None = None

        def cleanup(action) -> None:
            nonlocal cleanup_error
            try:
                action()
            except Exception as exc:
                if cleanup_error is None:
                    cleanup_error = exc

        if self.state != CaptureState.STOPPING:
            try:
                self._transition(CaptureState.STOPPING)
            except Exception:
                self.state = CaptureState.STOPPING
        self.context.stopping = True
        self._at_stop.set()
        if self.metrics_only:
            self._worker_stop.set()
        if self._at_worker is not None:
            self._at_worker.join(timeout=timeout)
            if self._at_worker.is_alive() and cleanup_error is None:
                cleanup_error = CaptureWorkerError(
                    f"AT capture worker did not stop within {timeout:.1f} seconds"
                )
        self._monitor_stop.set()
        if self._monitor is not None:
            self._monitor.join(timeout=timeout)
            if self._monitor.is_alive() and cleanup_error is None:
                cleanup_error = CaptureWorkerError(
                    f"capture monitor did not stop within {timeout:.1f} seconds"
                )

        if self.raw_dm_reader is not None:
            cleanup(lambda: self.raw_dm_reader.stop(timeout=timeout))

        # The controller must remain alive while the verified shutdown
        # commands are sent.  Disconnect before stopping the consumer so no
        # callback can keep producing frames while the queue is being drained.
        if self.controller:
            with self._native_lock:
                if self.log_controller is not None:
                    cleanup(self.log_controller.stop_log)
                    cleanup(self.log_controller.restore_logmask)
                    cleanup(self.log_controller.device_reset)
                cleanup(lambda: self.controller.disconnect(int(timeout * 1000)))

        self._worker_stop.set()
        if self._worker is not None:
            self._worker.join(timeout=timeout)
            if self._worker.is_alive():
                if cleanup_error is None:
                    cleanup_error = CaptureWorkerError(
                        f"capture worker did not stop within {timeout:.1f} seconds"
                    )
        else:
            cleanup(self.drain_all)

        # Release native objects only after the consumer has stopped using the
        # decoder/controller.  If it is still alive, leave the handles intact
        # and report the lifecycle failure instead of racing a close call.
        worker_stopped = self._worker is None or not self._worker.is_alive()
        if worker_stopped:
            cleanup(self.pusch_bler_process.close)
            if self.codec:
                cleanup(self.codec.close)
            if self.controller:
                cleanup(self.controller.close)

        cleanup(self.frame_queue.close)

        if worker_stopped:
            if not self.metrics_only:
                cleanup(self.raw_writer.close)
            if self.config.ports.at_port is not None:
                cleanup(self.at_writer.close)
            if self.four_g_metrics_writer is not None:
                cleanup(self.four_g_metrics_writer.close)
            if self.metrics_writer is not None:
                cleanup(self.metrics_writer.close)
            if self.merged_metrics_writer is not None:
                cleanup(self.merged_metrics_writer.close)
            if not self.metrics_only:
                cleanup(self.decoded_writer.close)
            if not self.metrics_only and self.sqlite_store.conn is not None:
                cleanup(
                    lambda: self.sqlite_store.update_session_status(
                        self.context.session_id,
                        CaptureState.CLOSED.value,
                        datetime.now(timezone.utc).isoformat(),
                    )
                )
                cleanup(self.sqlite_store.close)
            cleanup(lambda: self._transition(CaptureState.CLOSED))

        if cleanup_error is not None:
            raise cleanup_error

    def recover(self) -> int:
        if self.controller is None:
            return 0
        return self.controller.recover()

    def close(self) -> None:
        self.stop()

    def _transition(self, target: CaptureState) -> None:
        """检验流程顺序是否正确，然后更新当前状态"""
        ensure_transition(self.state, target)
        self.state = target
        if self.sqlite_store.conn is not None:
            self.sqlite_store.update_session_status(self.context.session_id, target.value)
