"""Passively probe a Windows serial port for Qualcomm DM/DIAG bytes.

This tool deliberately does not import the native controller, load any DLL,
send commands, or start the normal radio_capture session.  It only opens the
selected COM port, reads bytes, saves them verbatim, and prints lightweight
format indicators for deciding whether the port is emitting DM data.
"""

from __future__ import annotations

import argparse
import ctypes as C
import time
from pathlib import Path


kernel32 = C.WinDLL("kernel32", use_last_error=True)

GENERIC_READ = 0x80000000
GENERIC_WRITE = 0x40000000
OPEN_EXISTING = 3
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
kernel32.GetCommState.argtypes = [C.c_void_p, C.POINTER(DCB)]
kernel32.GetCommState.restype = C.c_int
kernel32.SetCommState.argtypes = [C.c_void_p, C.POINTER(DCB)]
kernel32.SetCommState.restype = C.c_int
kernel32.SetCommTimeouts.argtypes = [C.c_void_p, C.POINTER(COMMTIMEOUTS)]
kernel32.SetCommTimeouts.restype = C.c_int
kernel32.ReadFile.argtypes = [
    C.c_void_p,
    C.c_void_p,
    C.c_uint32,
    C.POINTER(C.c_uint32),
    C.c_void_p,
]
kernel32.ReadFile.restype = C.c_int


def _device_path(port: str) -> str:
    text = str(port).strip().upper()
    if text.isdigit():
        text = f"COM{text}"
    if not text.startswith("COM"):
        raise ValueError(f"invalid serial port: {port!r}")
    return rf"\\.\{text}"


class PassiveSerialReader:
    """Read-only-at-the-protocol-level serial reader using kernel32."""

    def __init__(self, port: str, baud_rate: int):
        self.port = _device_path(port)
        self.baud_rate = int(baud_rate)
        self.handle: C.c_void_p | None = None

    def __enter__(self) -> "PassiveSerialReader":
        # Share mode 0 is intentional: two readers must not split one DM
        # stream between them and produce incomplete frames.
        self.handle = kernel32.CreateFileW(
            self.port,
            GENERIC_READ | GENERIC_WRITE,
            0,
            None,
            OPEN_EXISTING,
            0,
            None,
        )
        if self.handle in (None, INVALID_HANDLE_VALUE):
            error = C.get_last_error()
            raise OSError(error, f"cannot open {self.port}; it may be busy")

        dcb = DCB()
        dcb.DCBlength = C.sizeof(DCB)
        if not kernel32.GetCommState(self.handle, C.byref(dcb)):
            raise self._last_error("GetCommState failed")
        dcb.BaudRate = self.baud_rate
        dcb.ByteSize = 8
        dcb.Parity = 0
        dcb.StopBits = 0
        if not kernel32.SetCommState(self.handle, C.byref(dcb)):
            raise self._last_error("SetCommState failed")

        # ReadFile returns periodically even when no byte is available.
        timeouts = COMMTIMEOUTS(20, 0, 200, 0, 200)
        if not kernel32.SetCommTimeouts(self.handle, C.byref(timeouts)):
            raise self._last_error("SetCommTimeouts failed")
        return self

    def __exit__(self, *_exc) -> None:
        if self.handle not in (None, INVALID_HANDLE_VALUE):
            kernel32.CloseHandle(self.handle)
        self.handle = None

    def read(self, size: int = 4096) -> bytes:
        if self.handle is None:
            raise RuntimeError("serial reader is not open")
        buffer = C.create_string_buffer(size)
        count = C.c_uint32()
        if not kernel32.ReadFile(
            self.handle,
            buffer,
            size,
            C.byref(count),
            None,
        ):
            raise self._last_error("ReadFile failed")
        return buffer.raw[: count.value]

    def _last_error(self, message: str) -> OSError:
        return OSError(C.get_last_error(), f"{message}: {self.port}")


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(
        description="Passively read a COM port and probe for DM/DIAG bytes."
    )
    parser.add_argument("--port", default="COM4", help="Port to read, default COM4.")
    parser.add_argument("--baud-rate", type=int, default=115200)
    parser.add_argument("--duration-sec", type=float, default=10.0)
    parser.add_argument(
        "--output",
        type=Path,
        default=Path("configs/data/dm-com4-raw.bin"),
        help="Verbatim binary output path.",
    )
    return parser


def _format_head(data: bytes, limit: int = 64) -> str:
    return " ".join(f"{value:02X}" for value in data[:limit])


def main(argv: list[str] | None = None) -> int:
    args = build_parser().parse_args(argv)
    if args.duration_sec <= 0:
        raise SystemExit("--duration-sec must be positive")

    args.output.parent.mkdir(parents=True, exist_ok=True)
    total_bytes = 0
    read_calls = 0
    nonzero_reads = 0
    delimiter_count = 0
    length_header_count = 0
    nmea_count = 0
    first_bytes = bytearray()
    deadline = time.monotonic() + args.duration_sec

    print(
        f"opening {args.port} for passive read; duration={args.duration_sec:g}s "
        f"output={args.output}"
    )
    try:
        with PassiveSerialReader(args.port, args.baud_rate) as reader:
            with args.output.open("wb") as output:
                while time.monotonic() < deadline:
                    chunk = reader.read()
                    read_calls += 1
                    if not chunk:
                        continue
                    output.write(chunk)
                    output.flush()
                    total_bytes += len(chunk)
                    nonzero_reads += 1
                    delimiter_count += chunk.count(b"\x7e")
                    length_header_count += chunk.count(b"\x10\x00")
                    nmea_count += chunk.count(b"$GPGGA")
                    if len(first_bytes) < 64:
                        first_bytes.extend(chunk[: 64 - len(first_bytes)])
    except KeyboardInterrupt:
        print("interrupted")
    except OSError as exc:
        print(f"open/read failed: {exc}")
        return 2

    print(f"bytes_read={total_bytes}")
    print(f"read_calls={read_calls} nonzero_reads={nonzero_reads}")
    print(f"0x7E_count={delimiter_count} 0x10_00_count={length_header_count}")
    print(f"$GPGGA_count={nmea_count}")
    print(f"first_bytes={_format_head(bytes(first_bytes)) or '<none>'}")
    print(f"raw_output={args.output.resolve()}")
    if total_bytes == 0:
        print("result=NO_BYTES; check port ownership, DM enablement, and port mapping")
    elif nmea_count:
        print("result=BYTES_BUT_NMEA_SIGNATURE; this is likely not a DM stream")
    elif delimiter_count or length_header_count:
        print("result=BYTES_WITH_DM_DIAG_SIGNATURE; inspect the saved binary next")
    else:
        print("result=BYTES_WITHOUT_KNOWN_SIGNATURE; keep the raw file for analysis")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
