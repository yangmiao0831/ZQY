"""Apply the QWinLog DIAG initialization sequence before native capture.

This module owns COM6 only during initialization.  It closes the raw serial
handle before the normal native controller connects, so it never competes
with the DM callback or the independent AT worker on COM3.
"""

from __future__ import annotations

import ctypes as C
import argparse
import time
from pathlib import Path


kernel32 = C.WinDLL("kernel32", use_last_error=True)

GENERIC_READ = 0x80000000
GENERIC_WRITE = 0x40000000
OPEN_EXISTING = 3
FILE_ATTRIBUTE_NORMAL = 0x00000080
FILE_FLAG_OVERLAPPED = 0x40000000
ERROR_IO_PENDING = 997
WAIT_OBJECT_0 = 0
WAIT_TIMEOUT = 258
INVALID_HANDLE_VALUE = C.c_void_p(-1).value


class DCB(C.Structure):
    _fields_ = [
        ("DCBlength", C.c_uint32),
        ("BaudRate", C.c_uint32),
        ("Flags", C.c_uint32),
        ("wReserved", C.c_uint16),
        ("XonLim", C.c_uint16),
        ("XoffLim", C.c_uint16),
        ("ByteSize", C.c_ubyte),
        ("Parity", C.c_ubyte),
        ("StopBits", C.c_ubyte),
        ("XonChar", C.c_char),
        ("XoffChar", C.c_char),
        ("ErrorChar", C.c_char),
        ("EofChar", C.c_char),
        ("EvtChar", C.c_char),
        ("wReserved1", C.c_uint16),
    ]


class COMMTIMEOUTS(C.Structure):
    _fields_ = [
        ("ReadIntervalTimeout", C.c_uint32),
        ("ReadTotalTimeoutMultiplier", C.c_uint32),
        ("ReadTotalTimeoutConstant", C.c_uint32),
        ("WriteTotalTimeoutMultiplier", C.c_uint32),
        ("WriteTotalTimeoutConstant", C.c_uint32),
    ]


class OVERLAPPED(C.Structure):
    _fields_ = [
        ("Internal", C.c_void_p),
        ("InternalHigh", C.c_void_p),
        ("Offset", C.c_uint32),
        ("OffsetHigh", C.c_uint32),
        ("hEvent", C.c_void_p),
    ]


kernel32.CreateFileW.argtypes = [
    C.c_wchar_p,
    C.c_uint32,
    C.c_uint32,
    C.c_void_p,
    C.c_uint32,
    C.c_uint32,
    C.c_void_p,
]
kernel32.CreateFileW.restype = C.c_void_p
kernel32.CloseHandle.argtypes = [C.c_void_p]
kernel32.CloseHandle.restype = C.c_int
kernel32.CreateEventW.argtypes = [C.c_void_p, C.c_int, C.c_int, C.c_wchar_p]
kernel32.CreateEventW.restype = C.c_void_p
kernel32.ResetEvent.argtypes = [C.c_void_p]
kernel32.ResetEvent.restype = C.c_int
kernel32.WaitForSingleObject.argtypes = [C.c_void_p, C.c_uint32]
kernel32.WaitForSingleObject.restype = C.c_uint32
kernel32.GetOverlappedResult.argtypes = [C.c_void_p, C.POINTER(OVERLAPPED), C.POINTER(C.c_uint32), C.c_int]
kernel32.GetOverlappedResult.restype = C.c_int
kernel32.CancelIo.argtypes = [C.c_void_p]
kernel32.CancelIo.restype = C.c_int
kernel32.GetCommState.argtypes = [C.c_void_p, C.POINTER(DCB)]
kernel32.GetCommState.restype = C.c_int
kernel32.SetCommState.argtypes = [C.c_void_p, C.POINTER(DCB)]
kernel32.SetCommState.restype = C.c_int
kernel32.SetCommTimeouts.argtypes = [C.c_void_p, C.POINTER(COMMTIMEOUTS)]
kernel32.SetCommTimeouts.restype = C.c_int
kernel32.SetCommMask.argtypes = [C.c_void_p, C.c_uint32]
kernel32.SetCommMask.restype = C.c_int
kernel32.SetupComm.argtypes = [C.c_void_p, C.c_uint32, C.c_uint32]
kernel32.SetupComm.restype = C.c_int
kernel32.PurgeComm.argtypes = [C.c_void_p, C.c_uint32]
kernel32.PurgeComm.restype = C.c_int
kernel32.WriteFile.argtypes = [
    C.c_void_p,
    C.c_void_p,
    C.c_uint32,
    C.POINTER(C.c_uint32),
    C.c_void_p,
]
kernel32.WriteFile.restype = C.c_int
kernel32.ReadFile.argtypes = [
    C.c_void_p,
    C.c_void_p,
    C.c_uint32,
    C.POINTER(C.c_uint32),
    C.c_void_p,
]
kernel32.ReadFile.restype = C.c_int


# These are the four empty-mask frames used by QWinLog's
# CQualcommSerial::SerialSendEmptyMask.  They include their DIAG frame
# delimiter and CRC bytes.  They were recovered from the installed QWinLog
# binary, not guessed from the TDCCommandInfo API.
QWINLOG_EMPTY_MASKS: tuple[tuple[str, bytes], ...] = (
    ("log", bytes.fromhex("73 00 00 00 00 00 00 00 DA 81 7E")),
    ("msg", bytes.fromhex("7D 5D 05 00 00 00 00 00 00 74 41 7E")),
    ("event", bytes.fromhex("60 00 12 6A 7E")),
    ("qtrace", bytes.fromhex("4B 04 0E 00 0D D3 7E")),
)


def _diag_frame(payload: bytes) -> bytes:
    """Build one CRC/HDLC frame from QWinLog's unframed control payload."""
    crc = 0xFFFF
    for value in payload:
        crc ^= value
        for _ in range(8):
            crc = (crc >> 1) ^ 0x8408 if crc & 1 else crc >> 1
    # QWinLog's CRC helper returns the one's complement of the running
    # Qualcomm DIAG CRC (the final NOT is present in its 0x460080 routine).
    data = payload + ((~crc) & 0xFFFF).to_bytes(2, "little")
    framed = bytearray()
    for value in data:
        if value in (0x7D, 0x7E):
            framed.extend((0x7D, value ^ 0x20))
        else:
            framed.append(value)
    framed.append(0x7E)
    return bytes(framed)


# These are the control messages sent by QWinLog between EmptyMask and
# delivery of 5GNR_LTE_CN_V9.cfg.  Sending the cfg frames alone only enables
# the small 0x1Cxx status messages on this modem; the QWinLog handshake is what
# makes the field-bearing log stream available.
QWINLOG_PRE_CONFIG: tuple[tuple[str, bytes], ...] = (
    ("query_diag_id", _diag_frame(bytes.fromhex("4B 12 22 02 01"))),
    # QWinLog's TDC_DIAG_FILE_LIST request is exactly eight payload bytes;
    # the response parser, not the request constructor, carries the
    # diagnostic-file/peripheral fields at later offsets.
    ("list_diag_file", _diag_frame(bytes.fromhex("80 12 16 08 01 00 00 00"))),
    ("qdss_query", _diag_frame(bytes.fromhex("4B 12 25 02 01"))),
    ("etr_out_mode", _diag_frame(bytes.fromhex("4B 5A 01 01 03"))),
    ("qdss_feature_mask", _diag_frame(bytes.fromhex("4B 12 24 02 02 00 00 00 01"))),
    ("qdss_enable", _diag_frame(bytes.fromhex("4B 5A 03 01 03"))),
    # These payloads are the exact constructors recovered from QWinLog's
    # QDSS setup routine.  Its initialized QDSS target parameter is 3.  In
    # particular, diag_transport is a 4B 12 command, not a 4B 5A command.
    ("qdss_tracer", _diag_frame(bytes.fromhex("4B 5A 08 02 03 0D"))),
    ("qdss_transport", _diag_frame(bytes.fromhex("4B 5A 06 02 03"))),
    ("diag_transport", _diag_frame(bytes.fromhex("4B 12 14 02 01 03"))),
)

# QWinLog retries the diagnostic-file request while the modem brings up the
# QDSS/QDB path.  Skipping this wait produces valid header-only 0x1Cxx frames
# even though the cfg file itself was accepted.
QWINLOG_DIAG_FILE_RETRIES = 100
QWINLOG_DIAG_FILE_RETRY_DELAY_SEC = 0.06


def _device_path(port: str | int) -> str:
    text = str(port).strip().upper()
    if text.isdigit():
        text = f"COM{text}"
    if not text.startswith("COM"):
        raise ValueError(f"invalid serial port: {port!r}")
    return rf"\\.\{text}"


class RawDiagSerial:
    def __init__(self, port: str | int, baud_rate: int):
        self.port = _device_path(port)
        self.baud_rate = int(baud_rate)
        self.handle: C.c_void_p | None = None

    def __enter__(self) -> "RawDiagSerial":
        self.handle = kernel32.CreateFileW(
            self.port,
            GENERIC_READ | GENERIC_WRITE,
            0,
            None,
            OPEN_EXISTING,
            FILE_ATTRIBUTE_NORMAL | FILE_FLAG_OVERLAPPED,
            None,
        )
        if self.handle in (None, INVALID_HANDLE_VALUE):
            raise OSError(C.get_last_error(), f"cannot open {self.port}")

        dcb = DCB()
        dcb.DCBlength = C.sizeof(DCB)
        if not kernel32.GetCommState(self.handle, C.byref(dcb)):
            raise self._last_error("GetCommState failed")
        dcb.BaudRate = self.baud_rate
        # Match QWinLog's CQualcommSerial initialization.  In particular,
        # preserving stale XON/XOFF or CTS/DSR settings can make DIAG writes
        # appear successful while the modem never answers.
        dcb.Flags |= 0x00000001  # fBinary
        dcb.Flags &= ~0x00000002  # fParity
        dcb.Flags &= ~0x00000004  # fOutxCtsFlow
        dcb.Flags &= ~0x00000008  # fOutxDsrFlow
        dcb.Flags = (dcb.Flags & ~0x00000030) | 0x00000010  # DTR enabled
        dcb.Flags &= ~0x00000040  # fDsrSensitivity
        dcb.Flags |= 0x00000080  # fTXContinueOnXoff
        dcb.Flags &= ~0x00000100  # fOutX
        dcb.Flags &= ~0x00000200  # fInX
        dcb.Flags &= ~0x00000400  # fErrorChar
        dcb.Flags &= ~0x00000800  # fNull
        dcb.Flags = (dcb.Flags & ~0x00003000) | 0x00001000  # RTS enabled
        dcb.Flags &= ~0x00004000  # fAbortOnError
        dcb.ByteSize = 8
        dcb.Parity = 0
        dcb.StopBits = 0
        if not kernel32.SetCommState(self.handle, C.byref(dcb)):
            raise self._last_error("SetCommState failed")

        if not kernel32.SetCommMask(self.handle, 0xC1):
            raise self._last_error("SetCommMask failed")
        if not kernel32.SetupComm(self.handle, 0x06400000, 0x00010000):
            raise self._last_error("SetupComm failed")
        # QWinLog purges after configuring the queue and before applying its
        # read timeout.  Keep that ordering because a stale aborted read can
        # otherwise survive into the first mask command.
        self.purge_input()
        # QWinLog uses an immediate read timeout and drains through its own
        # polling/overlapped loop.  Keep synchronous ReadFile non-blocking;
        # drain() supplies the bounded polling window.
        timeouts = COMMTIMEOUTS(0xFFFFFFFF, 0, 0, 50, 2000)
        if not kernel32.SetCommTimeouts(self.handle, C.byref(timeouts)):
            raise self._last_error("SetCommTimeouts failed")
        self._event = kernel32.CreateEventW(None, 1, 0, None)
        if self._event in (None, INVALID_HANDLE_VALUE):
            raise self._last_error("CreateEvent failed")
        return self

    def __exit__(self, *_exc) -> None:
        if self.handle not in (None, INVALID_HANDLE_VALUE):
            if getattr(self, "_event", None) not in (None, INVALID_HANDLE_VALUE):
                kernel32.CloseHandle(self._event)
            kernel32.CloseHandle(self.handle)
        self.handle = None
        self._event = None

    def purge_input(self) -> None:
        if self.handle is not None:
            # QWinLog uses PURGE_RXABORT | PURGE_RXCLEAR |
            # PURGE_TXABORT | PURGE_TXCLEAR.
            if not kernel32.PurgeComm(self.handle, 0x0001 | 0x0002 | 0x0004 | 0x0008):
                raise self._last_error("PurgeComm failed")

    def write(self, payload: bytes) -> None:
        if self.handle is None:
            raise RuntimeError("raw DIAG serial is not open")
        if not payload:
            return
        buffer = C.create_string_buffer(payload, len(payload))
        written = C.c_uint32()
        overlapped = self._new_overlapped()
        if not kernel32.WriteFile(
            self.handle,
            buffer,
            len(payload),
            C.byref(written),
            C.byref(overlapped),
        ):
            error = C.get_last_error()
            if error != ERROR_IO_PENDING:
                raise OSError(error, f"WriteFile failed: {self.port}")
            if kernel32.WaitForSingleObject(self._event, 2500) != WAIT_OBJECT_0:
                kernel32.CancelIo(self.handle)
                raise TimeoutError(f"DIAG write timed out: {self.port}")
            if not kernel32.GetOverlappedResult(
                self.handle, C.byref(overlapped), C.byref(written), 0
            ):
                raise self._last_error("GetOverlappedResult(write) failed")
        if written.value != len(payload):
            raise OSError(f"short DIAG write: {written.value}/{len(payload)}")

    def drain(self, duration_sec: float = 0.12) -> bytes:
        if self.handle is None:
            raise RuntimeError("raw DIAG serial is not open")
        deadline = time.monotonic() + duration_sec
        result = bytearray()
        while time.monotonic() < deadline:
            buffer = C.create_string_buffer(4096)
            count = C.c_uint32()
            overlapped = self._new_overlapped()
            if not kernel32.ReadFile(
                self.handle,
                buffer,
                len(buffer),
                C.byref(count),
                C.byref(overlapped),
            ):
                error = C.get_last_error()
                if error != ERROR_IO_PENDING:
                    raise OSError(error, f"ReadFile failed: {self.port}")
                wait_result = kernel32.WaitForSingleObject(self._event, 100)
                if wait_result == WAIT_OBJECT_0:
                    if not kernel32.GetOverlappedResult(
                        self.handle, C.byref(overlapped), C.byref(count), 0
                    ):
                        raise self._last_error("GetOverlappedResult(read) failed")
                else:
                    kernel32.CancelIo(self.handle)
                    # Do not reuse/reset the event while the cancelled
                    # request is still pending.
                    kernel32.WaitForSingleObject(self._event, 100)
                    count.value = 0
            if count.value:
                result.extend(buffer.raw[: count.value])
                deadline = time.monotonic() + 0.04
            else:
                time.sleep(0.001)
        return bytes(result)

    def read_once(self) -> bytes:
        if self.handle is None:
            raise RuntimeError("raw DIAG serial is not open")
        buffer = C.create_string_buffer(16384)
        count = C.c_uint32()
        overlapped = self._new_overlapped()
        if not kernel32.ReadFile(
            self.handle,
            buffer,
            len(buffer),
            C.byref(count),
            C.byref(overlapped),
        ):
            error = C.get_last_error()
            if error != ERROR_IO_PENDING:
                raise OSError(error, f"ReadFile failed: {self.port}")
            wait_result = kernel32.WaitForSingleObject(self._event, 100)
            if wait_result != WAIT_OBJECT_0:
                kernel32.CancelIo(self.handle)
                kernel32.WaitForSingleObject(self._event, 100)
                return b""
            if not kernel32.GetOverlappedResult(
                self.handle, C.byref(overlapped), C.byref(count), 0
            ):
                raise self._last_error("GetOverlappedResult(read) failed")
        return buffer.raw[: count.value]

    def _new_overlapped(self) -> OVERLAPPED:
        if getattr(self, "_event", None) in (None, INVALID_HANDLE_VALUE):
            raise RuntimeError("raw DIAG overlapped event is not open")
        if not kernel32.ResetEvent(self._event):
            raise self._last_error("ResetEvent failed")
        overlapped = OVERLAPPED()
        overlapped.hEvent = self._event
        return overlapped

    def _last_error(self, message: str) -> OSError:
        return OSError(C.get_last_error(), f"{message}: {self.port}")


def iter_framed_commands(data: bytes):
    """Yield each 0x7E-terminated frame from a QWinLog cfg file."""
    frame = bytearray()
    for value in data:
        frame.append(value)
        if value != 0x7E:
            continue
        if len(frame) > 1:
            yield bytes(frame)
        frame.clear()
    if frame:
        raise ValueError("QWinLog cfg has an unterminated DIAG frame")


def send_qwinlog_pre_config(
    serial: RawDiagSerial,
    *,
    drain_sec: float = 0.20,
    diag_file_retries: int = QWINLOG_DIAG_FILE_RETRIES,
    diag_file_retry_delay_sec: float = QWINLOG_DIAG_FILE_RETRY_DELAY_SEC,
) -> int:
    """Run the QWinLog control handshake before delivering the cfg file.

    The installed QWinLog repeats ``list_diag_file`` about 100 times before
    sending the cfg frames.  This is a readiness wait for the modem's QDSS
    path, not an attempt to discover a usable QDB file; the observed response
    can continue to report a zero-sized file during the whole wait.
    """
    if diag_file_retries <= 0:
        raise ValueError("diag_file_retries must be positive")
    if diag_file_retry_delay_sec < 0:
        raise ValueError("diag_file_retry_delay_sec must not be negative")
    response_bytes = 0
    for name, payload in QWINLOG_PRE_CONFIG:
        if name == "list_diag_file":
            # QWinLog queries the diagnostic IDs once, then repeats only the
            # file-list request.  Re-querying on every round changes the
            # timing and can keep the USB DM endpoint in its discovery state.
            for attempt in range(1, diag_file_retries + 1):
                serial.write(payload)
                response = serial.drain(drain_sec)
                response_bytes += len(response)
                if attempt == 1 or attempt == diag_file_retries or attempt % 10 == 0:
                    print(
                        f"qwinlog init {name} attempt={attempt}/{diag_file_retries} "
                        f"sent={len(payload)} response={len(response)}"
                    )
                if attempt < diag_file_retries and diag_file_retry_delay_sec:
                    time.sleep(diag_file_retry_delay_sec)
            continue

        serial.write(payload)
        response = serial.drain(drain_sec)
        response_bytes += len(response)
        print(
            f"qwinlog init {name} sent={len(payload)} "
            f"response={len(response)}"
        )
    return response_bytes


def apply_qwinlog_config(
    port: str | int,
    baud_rate: int,
    config_file: str | Path,
    *,
    inter_frame_delay_sec: float = 0.01,
) -> dict[str, int]:
    """Send the QWinLog cfg frames, then close the port."""
    path = Path(config_file)
    data = path.read_bytes()
    frames = tuple(iter_framed_commands(data))
    if not frames:
        raise ValueError(f"QWinLog config contains no DIAG frames: {path}")

    response_bytes = 0
    with RawDiagSerial(port, baud_rate) as serial:
        serial.purge_input()
        for index, payload in enumerate(frames, 1):
            serial.write(payload)
            response = serial.drain(0.04)
            response_bytes += len(response)
            if inter_frame_delay_sec:
                time.sleep(inter_frame_delay_sec)
            if index == 1 or index == len(frames) or index % 20 == 0:
                print(
                    f"qwinlog init cfg_frame={index}/{len(frames)} "
                    f"sent={len(payload)} response={len(response)}"
                )

    print(
        f"qwinlog init complete port={port} config={path} "
        f"frames={len(frames)} response_bytes={response_bytes}"
    )
    return {"frames": len(frames), "response_bytes": response_bytes}


def capture_qwinlog(
    port: str | int,
    baud_rate: int,
    config_file: str | Path,
    output_file: str | Path,
    duration_sec: float,
) -> dict[str, int]:
    """Send QWinLog cfg frames and keep COM6 open while saving raw DM bytes."""
    if duration_sec <= 0:
        raise ValueError("duration_sec must be positive")
    path = Path(config_file)
    frames = tuple(iter_framed_commands(path.read_bytes()))
    output_path = Path(output_file)
    output_path.parent.mkdir(parents=True, exist_ok=True)
    total = 0
    with RawDiagSerial(port, baud_rate) as serial, output_path.open("wb") as output:
        serial.purge_input()

        def save(data: bytes) -> None:
            nonlocal total
            if data:
                output.write(data)
                output.flush()
                total += len(data)

        for index, payload in enumerate(frames, 1):
            serial.write(payload)
            save(serial.drain(0.04))
            if index == 1 or index == len(frames) or index % 20 == 0:
                print(f"qwinlog capture cfg_frame={index}/{len(frames)}")

        deadline = time.monotonic() + duration_sec
        while time.monotonic() < deadline:
            save(serial.read_once())

    print(
        f"qwinlog capture complete port={port} duration={duration_sec:g}s "
        f"bytes={total} output={output_path.resolve()}"
    )
    return {"frames": len(frames), "bytes": total}


def main(argv: list[str] | None = None) -> int:
    parser = argparse.ArgumentParser(description="Configure and capture raw QWinLog DIAG data")
    parser.add_argument("--port", default="COM6")
    parser.add_argument("--baud-rate", type=int, default=115200)
    parser.add_argument("--config", required=True, type=Path)
    parser.add_argument("--output", required=True, type=Path)
    parser.add_argument("--duration-sec", type=float, default=10.0)
    args = parser.parse_args(argv)
    capture_qwinlog(
        args.port,
        args.baud_rate,
        args.config,
        args.output,
        args.duration_sec,
    )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
