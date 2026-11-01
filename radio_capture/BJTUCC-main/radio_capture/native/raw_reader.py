"""Continuous QWinLog-compatible raw DIAG reader."""

from __future__ import annotations

import threading
import time
from dataclasses import dataclass
from pathlib import Path
from typing import Callable

from radio_capture.pipeline.parser import FrameParser
from radio_capture.tools.qwinlog_init import (
    QWINLOG_EMPTY_MASKS,
    RawDiagSerial,
    iter_framed_commands,
)


_ERROR_OPERATION_ABORTED = 995


@dataclass
class RawReaderStats:
    bytes_received: int = 0
    framed_packets: int = 0
    valid_frames: int = 0
    invalid_packets: int = 0
    last_error: str | None = None


class DiagFrameAssembler:
    """Turn a stream of 0x7e-terminated DIAG packets into decoder payloads."""

    _MAX_BUFFER = 4 * 1024 * 1024

    def __init__(self):
        self._buffer = bytearray()

    def feed(self, data: bytes) -> list[bytes]:
        if data:
            self._buffer.extend(data)
        output: list[bytes] = []
        while True:
            try:
                end = self._buffer.index(0x7E)
            except ValueError:
                if len(self._buffer) > self._MAX_BUFFER:
                    del self._buffer[:-64 * 1024]
                break
            packet = bytes(self._buffer[:end])
            del self._buffer[: end + 1]
            if not packet:
                continue
            payload = self._normalize(packet)
            if payload is not None:
                output.append(payload)
        return output

    @staticmethod
    def _normalize(packet: bytes) -> bytes | None:
        # QWinLog sends HDLC-escaped bytes followed by a two-byte CRC.  Some
        # high-volume QXDM records wrap the Qualcomm 0x10 log packet in a
        # small container, so search for the inner packet rather than assuming
        # the frame starts at byte zero.
        decoded = _unescape(packet)
        return _extract_log_payload(decoded)


def _extract_log_payload(decoded: bytes) -> bytes | None:
    offset = 0
    while True:
        offset = decoded.find(b"\x10", offset)
        if offset < 0 or offset + 16 > len(decoded):
            return None
        declared_length = int.from_bytes(decoded[offset + 2 : offset + 4], "little")
        repeated_length = int.from_bytes(decoded[offset + 4 : offset + 6], "little")
        if declared_length != repeated_length:
            offset += 1
            continue

        remaining = len(decoded) - offset
        if declared_length + 6 == remaining:
            payload = decoded[offset:-2]
        elif declared_length + 4 == remaining:
            # Accept an already normalized native callback payload in tests
            # and in case a serial bridge has removed the CRC.
            payload = decoded[offset : offset + declared_length + 4]
        else:
            offset += 1
            continue
        if FrameParser.extract_msg_code(payload) is not None:
            return payload
        offset += 1


def _unescape(packet: bytes) -> bytes:
    result = bytearray()
    index = 0
    while index < len(packet):
        value = packet[index]
        if value == 0x7D and index + 1 < len(packet):
            result.append(packet[index + 1] ^ 0x20)
            index += 2
        else:
            result.append(value)
            index += 1
    return bytes(result)


def _is_operation_aborted(exc: OSError) -> bool:
    return (
        getattr(exc, "winerror", None) == _ERROR_OPERATION_ABORTED
        or getattr(exc, "errno", None) == _ERROR_OPERATION_ABORTED
        or (bool(exc.args) and exc.args[0] == _ERROR_OPERATION_ABORTED)
    )


def _read_serial_once(serial: RawDiagSerial) -> bytes:
    try:
        return serial.read_once()
    except OSError as exc:
        if _is_operation_aborted(exc):
            time.sleep(0.001)
            return b""
        raise


class QWinLogRawReader:
    """Own COM6 for the entire DM session and emit decoder-ready payloads."""

    def __init__(
        self,
        port: str | int,
        baud_rate: int,
        config_file: str | Path,
        on_payload: Callable[[bytes], bool],
    ):
        self.port = port
        self.baud_rate = int(baud_rate)
        self.config_file = Path(config_file)
        self.on_payload = on_payload
        self.stats = RawReaderStats()
        self._stop = threading.Event()
        self._thread: threading.Thread | None = None

    def start(self) -> None:
        if self._thread is not None and self._thread.is_alive():
            raise RuntimeError("raw DM reader is already running")
        self._stop.clear()
        self.stats = RawReaderStats()
        self._thread = threading.Thread(
            target=self._run,
            name="qwinlog-raw-dm-reader",
            daemon=False,
        )
        self._thread.start()

    def stop(self, timeout: float = 10.0) -> None:
        self._stop.set()
        if self._thread is not None:
            self._thread.join(timeout=timeout)
            if self._thread.is_alive():
                raise TimeoutError("raw DM reader did not stop")

    @property
    def alive(self) -> bool:
        return self._thread is not None and self._thread.is_alive()

    def _run(self) -> None:
        assembler = DiagFrameAssembler()
        try:
            frames = tuple(iter_framed_commands(self.config_file.read_bytes()))
            if not frames:
                raise ValueError(f"QWinLog config contains no DIAG frames: {self.config_file}")
            with RawDiagSerial(self.port, self.baud_rate) as serial:
                serial.purge_input()
                for index, command in enumerate(frames, 1):
                    serial.write(command)
                    self._read_for(serial, assembler, 0.04)
                    if index == 1 or index == len(frames) or index % 20 == 0:
                        print(
                            f"qwinlog raw init cfg_frame={index}/{len(frames)} "
                            f"bytes={self.stats.bytes_received}"
                        )
                    if self._stop.wait(0.01):
                        break

                print(
                    f"qwinlog raw capture started port={self.port} "
                    f"config={self.config_file} frames={len(frames)}"
                )
                while not self._stop.is_set():
                    self._feed(assembler, _read_serial_once(serial))

                # Clear the four QWinLog masks before releasing COM6.  This
                # is the same verified disable sequence used at startup.
                for _name, command in QWINLOG_EMPTY_MASKS:
                    serial.write(command)
                    self._read_for(serial, assembler, 0.05)
        except Exception as exc:
            self.stats.last_error = repr(exc)
            print(f"qwinlog raw reader stopped with warning: {exc!r}")

        print(
            f"qwinlog raw capture stopped bytes={self.stats.bytes_received} "
            f"packets={self.stats.framed_packets} valid={self.stats.valid_frames} "
            f"invalid={self.stats.invalid_packets}"
        )

    def _read_for(
        self,
        serial: RawDiagSerial,
        assembler: DiagFrameAssembler,
        duration_sec: float,
    ) -> None:
        deadline = time.monotonic() + duration_sec
        while time.monotonic() < deadline and not self._stop.is_set():
            self._feed(assembler, _read_serial_once(serial))

    def _feed(self, assembler: DiagFrameAssembler, data: bytes) -> None:
        if data:
            self.stats.bytes_received += len(data)
        for payload in assembler.feed(data):
            self.stats.framed_packets += 1
            try:
                accepted = bool(self.on_payload(payload))
            except Exception as exc:
                self.stats.last_error = repr(exc)
                accepted = False
            if accepted:
                self.stats.valid_frames += 1
            else:
                self.stats.invalid_packets += 1
