"""Log_CallBack creation, payload copying, and frame dispatch."""

from __future__ import annotations

import ctypes as C
import time
from dataclasses import dataclass

from radio_capture.models import FrameEnvelope, SessionContext
from radio_capture.native.controller_abi import LOG_CALLBACK


MAX_CALLBACK_PAYLOAD = 16 * 1024 * 1024


@dataclass
class CallbackStats:
    callback_calls: int = 0
    received_frames: int = 0
    dropped_frames: int = 0
    invalid_frames: int = 0
    empty_callbacks: int = 0
    oversize_frames: int = 0
    last_error: str | None = None
    last_callback_args: str | None = None
    last_frame_monotonic: float | None = None


class CallbackDispatcher:
    """Owns callback and context references for the native capture lifetime."""

    def __init__(self, context: SessionContext, frame_queue):
        self.context = context
        self.frame_queue = frame_queue
        self.stats = CallbackStats()
        self._context_ref = C.py_object(context)
        self.user_param = C.cast(C.pointer(self._context_ref), C.c_void_p)
        self.callback = LOG_CALLBACK(self._on_log)

    def _on_log(self, p_param, log_type, log_buffer, log_len, cur_time) -> None:
        self.stats.callback_calls += 1
        try:
            if self.context.stopping:
                return
            buffer_address = int(C.cast(log_buffer, C.c_void_p).value or 0)
            payload_length = int(log_len)
            self.stats.last_callback_args = (
                f"param=0x{int(C.cast(p_param, C.c_void_p).value or 0):08X} "
                f"type={int(log_type)} buffer=0x{buffer_address:08X} "
                f"len={payload_length} cur_time={int(cur_time)}"
            )
            if buffer_address == 0 or payload_length <= 0:
                self.stats.invalid_frames += 1
                if buffer_address == 0 and payload_length == 0:
                    self.stats.empty_callbacks += 1
                else:
                    self.stats.last_error = "invalid callback buffer or length"
                return
            if payload_length > MAX_CALLBACK_PAYLOAD:
                self.stats.invalid_frames += 1
                self.stats.oversize_frames += 1
                self.stats.last_error = (
                    f"callback payload length {payload_length} exceeds "
                    f"limit {MAX_CALLBACK_PAYLOAD}"
                )
                return
            payload = C.string_at(buffer_address, payload_length)
            self.dispatch_payload(payload, int(log_type), int(cur_time))
        except Exception as exc:  # callback must not raise into native code
            self.stats.last_error = repr(exc)

    def dispatch_payload(self, payload: bytes, log_type: int = 1, native_cur_time: int = 0) -> bool:
        """Copy a decoder-ready payload into the same queue as native callbacks."""
        if self.context.stopping or not payload:
            return False
        frame = FrameEnvelope(
            session_id=self.context.session_id,
            sequence=self.context.next_sequence(),
            receive_time_ns=time.time_ns(),
            native_cur_time=int(native_cur_time),
            log_type=int(log_type),
            payload_length=len(payload),
            payload=bytes(payload),
        )
        accepted = self.frame_queue.put_nowait(frame)
        self.stats.last_frame_monotonic = time.monotonic()
        if accepted:
            self.stats.received_frames += 1
        else:
            self.stats.dropped_frames += 1
        return accepted
