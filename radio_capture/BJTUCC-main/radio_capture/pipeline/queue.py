"""Memory and disk-backed queues for callback frames."""

from __future__ import annotations

import queue as queue_module
import struct
import threading
import time
from collections import deque
from dataclasses import dataclass
from pathlib import Path

from radio_capture.models import FrameEnvelope


@dataclass
class QueueStats:
    enqueued: int = 0
    dequeued: int = 0
    dropped: int = 0


class BoundedFrameQueue:
    def __init__(self, maxsize: int):
        self._queue: queue_module.Queue[FrameEnvelope] = queue_module.Queue(maxsize=maxsize)
        self.stats = QueueStats()

    def put_nowait(self, frame: FrameEnvelope) -> bool:
        try:
            self._queue.put_nowait(frame)
        except queue_module.Full:
            self.stats.dropped += 1
            return False
        self.stats.enqueued += 1
        return True

    def get(self, timeout: float | None = None) -> FrameEnvelope:
        frame = self._queue.get(timeout=timeout)
        self.stats.dequeued += 1
        return frame

    def task_done(self) -> None:
        self._queue.task_done()

    def empty(self) -> bool:
        return self._queue.empty()


def _extract_msg_code(payload: bytes) -> int | None:
    """Return the Qualcomm log code without importing the parser module."""
    if len(payload) < 16 or payload[0] != 0x10:
        return None
    declared_length = int.from_bytes(payload[2:4], "little")
    repeated_length = int.from_bytes(payload[4:6], "little")
    if declared_length + 4 != len(payload) or repeated_length != declared_length:
        return None
    return int.from_bytes(payload[6:8], "little")


class DiskSpoolFrameQueue:
    """FIFO frame queue that persists each payload before acknowledgement."""

    _MAGIC = b"DMQ1"
    _HEADER = struct.Struct("<4sIQQIIQ")
    _MAX_PRIORITY_BURST = 8

    def __init__(
        self,
        spool_dir: str | Path,
        session_id: str,
        priority_msg_codes: set[int] | None = None,
    ):
        self.spool_dir = Path(spool_dir)
        self.spool_path = self.spool_dir / "spool-000001.bin"
        self.session_id = session_id
        self.stats = QueueStats()
        self._priority_msg_codes = set(priority_msg_codes or ())
        self._priority_frames: deque[FrameEnvelope] = deque()
        self._priority_returned_sequences: set[int] = set()
        self._priority_burst_count = 0
        self._condition = threading.Condition()
        self._write_file = None
        self._read_file = None
        self._write_offset = 0
        self._read_offset = 0
        self._closed = False

    def _ensure_open(self) -> None:
        if self._write_file is not None and self._read_file is not None:
            return
        self.spool_dir.mkdir(parents=True, exist_ok=True)
        self._write_file = self.spool_path.open("ab", buffering=0)
        self._read_file = self.spool_path.open("rb", buffering=0)
        self._write_offset = self.spool_path.stat().st_size
        self._read_offset = 0

    def put_nowait(self, frame: FrameEnvelope) -> bool:
        """Write a complete record to disk; disk capacity replaces queue size."""
        payload = bytes(frame.payload)
        header = self._HEADER.pack(
            self._MAGIC,
            1,
            int(frame.sequence),
            int(frame.receive_time_ns),
            int(frame.native_cur_time),
            int(frame.log_type),
            len(payload),
        )
        with self._condition:
            if self._closed:
                raise RuntimeError("DiskSpoolFrameQueue is closed")
            self._ensure_open()
            self._write_file.write(header)
            self._write_file.write(payload)
            self._write_file.flush()
            self._write_offset += len(header) + len(payload)
            self.stats.enqueued += 1
            if _extract_msg_code(payload) in self._priority_msg_codes:
                self._priority_frames.append(frame)
            self._condition.notify()
        return True

    def get(self, timeout: float | None = None) -> FrameEnvelope:
        deadline = None if timeout is None else time.monotonic() + timeout
        with self._condition:
            self._ensure_open()
            frame = self._pop_priority_frame()
            if frame is not None:
                return frame
            while self._read_offset >= self._write_offset:
                if self._closed:
                    raise queue_module.Empty
                if deadline is None:
                    self._condition.wait()
                else:
                    remaining = deadline - time.monotonic()
                    if remaining <= 0:
                        raise queue_module.Empty
                    self._condition.wait(remaining)
                frame = self._pop_priority_frame()
                if frame is not None:
                    return frame

            while True:
                frame = self._read_next_frame_locked()
                if frame.sequence not in self._priority_returned_sequences:
                    if _extract_msg_code(frame.payload) in self._priority_msg_codes:
                        self._priority_returned_sequences.add(frame.sequence)
                        self._priority_burst_count += 1
                    else:
                        # One ordinary FIFO frame breaks the priority burst.
                        self._priority_burst_count = 0
                    self.stats.dequeued += 1
                    return frame
                if self._read_offset >= self._write_offset:
                    raise queue_module.Empty

    def set_priority_msg_codes(self, priority_msg_codes: set[int] | None) -> None:
        with self._condition:
            self._priority_msg_codes = set(priority_msg_codes or ())
            self._priority_burst_count = 0

    def _pop_priority_frame(self) -> FrameEnvelope | None:
        if self._priority_burst_count >= self._MAX_PRIORITY_BURST:
            return None
        while self._priority_frames:
            frame = self._priority_frames.popleft()
            if frame.sequence in self._priority_returned_sequences:
                continue
            self._priority_returned_sequences.add(frame.sequence)
            self._priority_burst_count += 1
            self.stats.dequeued += 1
            return frame
        return None

    def _read_next_frame_locked(self) -> FrameEnvelope:
        self._read_file.seek(self._read_offset)
        header = self._read_file.read(self._HEADER.size)
        if len(header) != self._HEADER.size:
            raise RuntimeError("incomplete spool record header")
        magic, version, sequence, receive_time_ns, native_cur_time, log_type, payload_length = self._HEADER.unpack(header)
        if magic != self._MAGIC or version != 1:
            raise RuntimeError("invalid disk spool record")
        payload = self._read_file.read(payload_length)
        if len(payload) != payload_length:
            raise RuntimeError("incomplete spool record payload")
        self._read_offset += self._HEADER.size + payload_length
        return FrameEnvelope(
            session_id=self.session_id,
            sequence=sequence,
            receive_time_ns=receive_time_ns,
            native_cur_time=native_cur_time,
            log_type=log_type,
            payload_length=payload_length,
            payload=payload,
        )

    def task_done(self) -> None:
        """Keep the same interface as ``queue.Queue``."""

    def empty(self) -> bool:
        with self._condition:
            return not self._priority_frames and self._read_offset >= self._write_offset

    def close(self) -> None:
        with self._condition:
            self._closed = True
            if self._write_file is not None:
                self._write_file.flush()
                self._write_file.close()
                self._write_file = None
            if self._read_file is not None:
                self._read_file.close()
                self._read_file = None
            self._condition.notify_all()

