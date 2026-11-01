"""Collect and parse Quectel signal metrics through the AT serial port."""

from __future__ import annotations

import argparse
import csv
import ctypes as C
import json
import time
from datetime import datetime, timedelta, timezone
from pathlib import Path

from radio_capture.pipeline.at_sink import (
    AT_CSV_COLUMNS,
    FOUR_G_CSV_COLUMNS,
    at_record_to_row,
    lte_record_to_row,
)


SHANGHAI_TZ = timezone(timedelta(hours=8), name="Asia/Shanghai")


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


kernel32.CreateFileW.argtypes = [C.c_wchar_p, C.c_uint32, C.c_uint32, C.c_void_p, C.c_uint32, C.c_uint32, C.c_void_p]
kernel32.CreateFileW.restype = C.c_void_p
kernel32.CloseHandle.argtypes = [C.c_void_p]
kernel32.GetCommState.argtypes = [C.c_void_p, C.POINTER(DCB)]
kernel32.SetCommState.argtypes = [C.c_void_p, C.POINTER(DCB)]
kernel32.SetCommTimeouts.argtypes = [C.c_void_p, C.POINTER(COMMTIMEOUTS)]
kernel32.PurgeComm.argtypes = [C.c_void_p, C.c_uint32]
kernel32.ReadFile.argtypes = [C.c_void_p, C.c_void_p, C.c_uint32, C.POINTER(C.c_uint32), C.c_void_p]
kernel32.WriteFile.argtypes = [C.c_void_p, C.c_void_p, C.c_uint32, C.POINTER(C.c_uint32), C.c_void_p]


class WinSerial:
    def __init__(self, port: str, baud_rate: int):
        device_prefix = r"\\." + "\\"
        self.port = port if port.upper().startswith(device_prefix) else device_prefix + port
        self.baud_rate = baud_rate
        self.handle = None

    def __enter__(self):
        self.handle = kernel32.CreateFileW(self.port, GENERIC_READ | GENERIC_WRITE, 0, None, OPEN_EXISTING, 0, None)
        if self.handle in (None, INVALID_HANDLE_VALUE):
            raise OSError(C.get_last_error(), f"cannot open {self.port}")
        dcb = DCB()
        dcb.DCBlength = C.sizeof(DCB)
        if not kernel32.GetCommState(self.handle, C.byref(dcb)):
            raise OSError(C.get_last_error(), "GetCommState failed")
        dcb.BaudRate = self.baud_rate
        dcb.ByteSize = 8
        dcb.Parity = 0
        dcb.StopBits = 0
        if not kernel32.SetCommState(self.handle, C.byref(dcb)):
            raise OSError(C.get_last_error(), "SetCommState failed")
        timeouts = COMMTIMEOUTS(20, 0, 200, 0, 200)
        if not kernel32.SetCommTimeouts(self.handle, C.byref(timeouts)):
            raise OSError(C.get_last_error(), "SetCommTimeouts failed")
        return self

    def __exit__(self, *_exc):
        if self.handle:
            kernel32.CloseHandle(self.handle)
            self.handle = None

    def _purge(self):
        kernel32.PurgeComm(self.handle, 0x0008 | 0x0004)

    def query(self, command: str, timeout_sec: float = 2.5) -> str:
        self._purge()
        data = (command + "\r").encode("ascii")
        written = C.c_uint32()
        if not kernel32.WriteFile(self.handle, data, len(data), C.byref(written), None):
            raise OSError(C.get_last_error(), f"write failed: {command}")
        chunks: list[bytes] = []
        deadline = time.monotonic() + timeout_sec
        while time.monotonic() < deadline:
            buffer = C.create_string_buffer(4096)
            count = C.c_uint32()
            if not kernel32.ReadFile(self.handle, buffer, len(buffer), C.byref(count), None):
                raise OSError(C.get_last_error(), f"read failed: {command}")
            if count.value:
                chunks.append(buffer.raw[: count.value])
                if b"\r\nOK\r\n" in chunks[-1] or b"\r\nERROR\r\n" in chunks[-1]:
                    break
            elif chunks:
                time.sleep(0.05)
        return b"".join(chunks).decode("ascii", errors="replace")


def _response_line(response: str, prefix: str) -> str | None:
    for line in response.replace("\r", "").splitlines():
        if line.startswith(prefix):
            return line
    return None


def _response_lines(response: str, prefix: str) -> list[str]:
    return [
        line
        for line in response.replace("\r", "").splitlines()
        if line.startswith(prefix)
    ]


def parse_signal(responses: dict[str, str]) -> dict[str, object]:
    result: dict[str, object] = {
        "timestamp": datetime.now(SHANGHAI_TZ).isoformat(),
        "raw": {key: value.strip() for key, value in responses.items()},
    }
    csq = _response_line(responses.get("csq", ""), "+CSQ:")
    if csq:
        values = [value.strip() for value in csq.split(":", 1)[1].split(",")]
        if len(values) >= 2:
            rssi = _int_or_text(values[0])
            result["csq"] = {
                "rssi": rssi,
                "rssi_dbm": _csq_rssi_dbm(rssi),
                "ber": _int_or_text(values[1]),
            }

    nwinfo = _response_line(responses.get("nwinfo", ""), "+QNWINFO:")
    if nwinfo:
        values = next(csv.reader([nwinfo.split(":", 1)[1].strip()]))
        if len(values) >= 4:
            result["network"] = {
                "rat": values[0],
                "operator": values[1],
                "band": values[2],
                "channel": _int_or_text(values[3]),
            }

    qeng_lines = _response_lines(responses.get("servingcell", ""), '+QENG:')
    for line in qeng_lines:
        parsed = _parse_qeng_servingcell(line)
        if parsed is None:
            continue
        fields, serving = parsed
        if serving["rat"] == "LTE":
            result["lte_servingcell_fields"] = fields
            result["lte_servingcell"] = serving
        elif str(serving["rat"]).startswith("NR"):
            result["servingcell_fields"] = fields
            result["servingcell"] = serving
    qcsq = _response_line(responses.get("qcsq", ""), "+QCSQ:")
    if qcsq:
        values = next(csv.reader([qcsq.split(":", 1)[1].strip()]))
        if len(values) >= 2:
            signal = {
                "rat": values[0].strip().strip('"'),
                "rssi_dbm": _number_or_none(values[1]),
                "rsrp_dbm": _number_or_none(values[2]) if len(values) >= 3 else None,
                "sinr_db": _number_or_none(values[3]) if len(values) >= 4 else None,
                "rsrq_db": _number_or_none(values[4]) if len(values) >= 5 else None,
            }
            result["qcsq"] = signal
            serving_record = result.get("servingcell")
            if str(signal.get("rat", "")).upper() == "LTE":
                lte_serving = result.get("lte_servingcell")
                if not isinstance(lte_serving, dict):
                    lte_serving = {"rat": signal["rat"]}
                    result["lte_servingcell"] = lte_serving
                for name in ("rssi_dbm", "rsrp_dbm", "sinr_db", "rsrq_db"):
                    if lte_serving.get(name) in (None, "", "-", "--"):
                        if signal[name] is not None:
                            lte_serving[name] = signal[name]
            elif isinstance(serving_record, dict):
                # QENG is preferred for NR serving-cell fields; QCSQ fills
                # only fields absent from that response.
                for name in ("rssi_dbm", "rsrp_dbm", "sinr_db", "rsrq_db"):
                    if serving_record.get(name) in (None, "", "-", "--"):
                        if signal[name] is not None:
                            serving_record[name] = signal[name]
            else:
                result["servingcell"] = {
                    name: value
                    for name, value in signal.items()
                    if name != "rat" or value
                }
    network = result.get("network")
    lte_serving = result.get("lte_servingcell")
    if isinstance(network, dict) and _is_lte_rat(network.get("rat")):
        if not isinstance(lte_serving, dict):
            lte_serving = {"rat": "LTE"}
            result["lte_servingcell"] = lte_serving
        if lte_serving.get("band") in (None, "", "-", "--"):
            band = _parse_lte_band(network.get("band"))
            if band not in (None, "", "-", "--"):
                lte_serving["band"] = band
        if lte_serving.get("earfcn") in (None, "", "-", "--"):
            channel = network.get("channel")
            if channel not in (None, "", "-", "--"):
                lte_serving["earfcn"] = channel
    return result


def _int_or_text(value: str) -> int | str:
    try:
        return int(value)
    except (TypeError, ValueError):
        return value


def _number_or_text(value: str) -> float | int | str:
    try:
        number = float(value)
    except (TypeError, ValueError):
        return value
    return int(number) if number.is_integer() else number


def _number_or_none(value: str) -> float | int | None:
    parsed = _number_or_text(value)
    return parsed if isinstance(parsed, (int, float)) else None


def _parse_qeng_servingcell(
    line: str,
) -> tuple[list[str], dict[str, object]] | None:
    if not line.startswith("+QENG:"):
        return None
    values = next(csv.reader([line.split(":", 1)[1].strip()]))
    if not values:
        return None
    tag = values[0].strip().strip('"')
    fields = values[1:] if tag.lower() == "servingcell" else values
    if not fields:
        return None

    # SA style: +QENG: "servingcell","NOCONN","NR5G-SA",...
    if len(fields) >= 14 and str(fields[1]).startswith("NR"):
        serving = {
            "state": fields[0],
            "rat": fields[1],
            "duplex": fields[2],
            "mcc": fields[3],
            "mnc": fields[4],
            "cell_id": fields[5],
            "pci": _int_or_text(fields[6]),
            "tac": fields[7],
            "arfcn": _int_or_text(fields[8]),
            "band": _int_or_text(fields[9]),
            "bandwidth_dl": _number_or_text(fields[10]),
            "rsrp_dbm": _number_or_text(fields[11]),
            "rsrq_db": _number_or_text(fields[12]),
            "sinr_db": _number_or_text(fields[13]),
        }
        if len(fields) >= 15:
            serving["scs"] = _int_or_text(fields[14])
        serving.update(_parse_named_metrics(fields[14:]))
        return fields, serving

    # LTE-only style: +QENG: "servingcell","NOCONN","LTE",...
    if len(fields) >= 16 and str(fields[1]).upper() == "LTE":
        serving = _parse_lte_qeng_fields(fields, has_state=True)
        if serving is not None:
            return fields, serving

    # NSA LTE style: +QENG: "LTE","FDD",...
    if len(fields) >= 15 and str(fields[0]).upper() == "LTE":
        serving = _parse_lte_qeng_fields(fields, has_state=False)
        if serving is not None:
            return fields, serving

    # NSA NR style: +QENG: "NR5G-NSA",<MCC>,<MNC>,<PCI>,<RSRP>,<SINR>,<RSRQ>,...
    if len(fields) >= 8 and str(fields[0]).startswith("NR"):
        serving = {
            "rat": fields[0],
            "mcc": fields[1],
            "mnc": fields[2],
            "pci": _int_or_text(fields[3]),
            "rsrp_dbm": _number_or_text(fields[4]),
            "sinr_db": _number_or_text(fields[5]),
            "rsrq_db": _number_or_text(fields[6]),
            "arfcn": _int_or_text(fields[7]),
            "band": _int_or_text(fields[8]) if len(fields) >= 9 else "",
        }
        serving.update(_parse_named_metrics(fields[9:]))
        return fields, serving

    return None


def _parse_lte_qeng_fields(
    fields: list[str], *, has_state: bool
) -> dict[str, object] | None:
    offset = 1 if has_state else 0
    if len(fields) < offset + 15:
        return None
    serving = {
        "rat": "LTE",
        "duplex": fields[offset + 1],
        "mcc": fields[offset + 2],
        "mnc": fields[offset + 3],
        "cell_id": fields[offset + 4],
        "pci": _int_or_text(fields[offset + 5]),
        "earfcn": _int_or_text(fields[offset + 6]),
        "band": _int_or_text(fields[offset + 7]),
        "ul_bandwidth": _number_or_text(fields[offset + 8]),
        "bandwidth_dl": _number_or_text(fields[offset + 9]),
        "tac": fields[offset + 10],
        "rsrp_dbm": _number_or_text(fields[offset + 11]),
        "rsrq_db": _number_or_text(fields[offset + 12]),
        "rssi_dbm": _number_or_text(fields[offset + 13]),
        "sinr_db": _number_or_text(fields[offset + 14]),
    }
    if has_state:
        serving["state"] = fields[0]
    serving.update(_parse_named_metrics(fields[offset + 15 :]))
    return serving


def _parse_named_metrics(values: list[str]) -> dict[str, object]:
    """Parse optional ``name=value``/``name:value`` fields from QENG output."""
    aliases = {
        "NRBANDWIDTHDL": "bandwidth_dl",
        "BANDWIDTHDL": "bandwidth_dl",
        "DLBANDWIDTH": "bandwidth_dl",
        "NRBWPACTIVEBANDWIDTHDLMHZ": "bwp_active_bandwidth_dl_mhz",
        "NRBWPACTIVEBANDWIDTHDL": "bwp_active_bandwidth_dl_mhz",
        "BWPACTIVEBWDLMHZ": "bwp_active_bandwidth_dl_mhz",
        "BWPACTIVEBANDWIDTHDLMHZ": "bwp_active_bandwidth_dl_mhz",
        "NRBWPBANDWIDTHMHZ": "bwp_bandwidth_mhz",
        "NRBWPBANDWIDTH": "bwp_bandwidth_mhz",
        "BWPBWMHZ": "bwp_bandwidth_mhz",
        "BWPBANDWIDTHMHZ": "bwp_bandwidth_mhz",
        "NRSSBARFCNDL": "ssb_arfcn_dl",
        "SSBARFCNDL": "ssb_arfcn_dl",
        "SSBARFCN": "ssb_arfcn_dl",
        "NRSSBRSRQ": "ssb_rsrq_db",
        "SSBRSRQ": "ssb_rsrq_db",
        "NRRSSI": "ssb_rssi_dbm",
        "RSSI": "ssb_rssi_dbm",
        "NRSSBRSSI": "ssb_rssi_dbm",
        "SSBRSSI": "ssb_rssi_dbm",
        "NRSSBRSRPBESTBEAM": "ssb_rsrp_bestbeam_dbm",
        "SSBRSRPBESTBEAM": "ssb_rsrp_bestbeam_dbm",
        "NRSSBRSRPSECONDBEAM": "ssb_rsrp_secondbeam_dbm",
        "SSBRSRPSECONDBEAM": "ssb_rsrp_secondbeam_dbm",
        "LTEBANDWIDTHDL": "bandwidth_dl",
        "LTEBWDL": "bandwidth_dl",
        "LTEEARFCNDL": "earfcn",
        "LTEEARFCN": "earfcn",
        "EARFCNDL": "earfcn",
        "EARFCN": "earfcn",
        "LTEPCI": "pci",
        "PCI": "pci",
        "LTERSRP": "rsrp_dbm",
        "RSRP": "rsrp_dbm",
        "LTERSRQ": "rsrq_db",
        "RSRQ": "rsrq_db",
        "LTESINR": "sinr_db",
        "SINR": "sinr_db",
    }
    parsed: dict[str, object] = {}
    for item in values:
        for separator in ("=", ":"):
            if separator not in item:
                continue
            raw_name, raw_value = item.split(separator, 1)
            name = "".join(ch for ch in raw_name.upper() if ch.isalnum())
            key = aliases.get(name)
            if key is not None:
                parsed[key] = _number_or_text(raw_value.strip())
            break
    return parsed


def _is_lte_rat(value: object) -> bool:
    text = str(value or "").upper()
    return "LTE" in text and "NR" not in text


def _parse_lte_band(value: object) -> object:
    text = str(value or "").strip()
    if not text:
        return ""
    upper = text.upper()
    if "LTE BAND" in upper:
        tail = upper.rsplit("LTE BAND", 1)[1].strip()
        return _int_or_text(tail.split()[0]) if tail else text
    if upper.startswith("B") and upper[1:].isdigit():
        return int(upper[1:])
    return _int_or_text(text)


def _csq_rssi_dbm(value: object) -> int | None:
    """Convert the 3GPP ``+CSQ`` RSSI code to dBm.

    ``99`` means unknown.  The value is a general modem RSSI measurement, so
    it is used as the AT fallback when QENG does not expose a dedicated NR
    SSB-RSSI field.
    """
    if not isinstance(value, int) or not 0 <= value <= 31:
        return None
    return -113 + 2 * value


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(description="Collect RM520N signal metrics through an AT COM port")
    parser.add_argument("--at", required=True, help="AT port, for example COM3")
    parser.add_argument("--baud-rate", type=int, default=115200)
    parser.add_argument("--interval-sec", type=float, default=2.0)
    parser.add_argument("--duration-sec", type=float, default=10.0)
    parser.add_argument(
        "--session-dir",
        type=Path,
        help="DM session directory in which to save AT JSONL/CSV outputs.",
    )
    parser.add_argument("--output", type=Path, help="AT JSONL output path.")
    parser.add_argument(
        "--csv-output",
        type=Path,
        help="Optional CSV with the parsed NR serving-cell and beam/BWP fields.",
    )
    parser.add_argument(
        "--lte-csv-output",
        type=Path,
        help="Optional CSV with parsed LTE/4G serving-cell fields.",
    )
    return parser


def main(argv: list[str] | None = None) -> int:
    args = build_parser().parse_args(argv)
    output_path = args.output
    if output_path is None:
        output_path = (
            args.session_dir / "at_signal.jsonl"
            if args.session_dir is not None
            else Path("configs/data/at_signal.jsonl")
        )
    csv_output = args.csv_output
    if csv_output is None and args.session_dir is not None:
        csv_output = args.session_dir / "at_metrics.csv"
    lte_csv_output = args.lte_csv_output
    if lte_csv_output is None and args.session_dir is not None:
        lte_csv_output = args.session_dir / "4G_metrics.csv"

    output_path.parent.mkdir(parents=True, exist_ok=True)
    deadline = time.monotonic() + args.duration_sec
    csv_stream = None
    csv_writer = None
    lte_csv_stream = None
    lte_csv_writer = None
    if csv_output is not None:
        csv_output.parent.mkdir(parents=True, exist_ok=True)
        csv_stream = csv_output.open("w", encoding="utf-8-sig", newline="")
        csv_writer = csv.DictWriter(csv_stream, fieldnames=list(AT_CSV_COLUMNS))
        csv_writer.writeheader()
    if lte_csv_output is not None:
        lte_csv_output.parent.mkdir(parents=True, exist_ok=True)
        lte_csv_stream = lte_csv_output.open("w", encoding="utf-8-sig", newline="")
        lte_csv_writer = csv.DictWriter(
            lte_csv_stream, fieldnames=list(FOUR_G_CSV_COLUMNS)
        )
        lte_csv_writer.writeheader()
    try:
        with WinSerial(args.at, args.baud_rate) as serial, output_path.open("a", encoding="utf-8") as output:
            sequence = 0
            while time.monotonic() < deadline:
                responses = {
                    "csq": serial.query("AT+CSQ"),
                    "nwinfo": serial.query("AT+QNWINFO"),
                    "servingcell": serial.query('AT+QENG="servingcell"'),
                    # Optional on some RM520N firmware; parse it when
                    # available and tolerate ERROR when it is unsupported.
                    "qcsq": serial.query("AT+QCSQ"),
                }
                record = parse_signal(responses)
                sequence += 1
                output.write(json.dumps(record, ensure_ascii=False) + "\n")
                output.flush()
                if csv_writer is not None:
                    row = at_record_to_row(record, "AT", sequence)
                    if row is not None:
                        csv_writer.writerow(row)
                        csv_stream.flush()
                if lte_csv_writer is not None:
                    lte_row = lte_record_to_row(record, "AT", sequence)
                    if lte_row is not None:
                        lte_csv_writer.writerow(lte_row)
                        lte_csv_stream.flush()
                print(json.dumps({key: value for key, value in record.items() if key != "raw"}, ensure_ascii=False))
                remaining = deadline - time.monotonic()
                if remaining > 0:
                    time.sleep(min(args.interval_sec, remaining))
    finally:
        if csv_stream is not None:
            csv_stream.close()
        if lte_csv_stream is not None:
            lte_csv_stream.close()
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
