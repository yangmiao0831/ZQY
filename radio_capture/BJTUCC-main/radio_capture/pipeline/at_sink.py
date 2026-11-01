"""Writers for AT-port signal snapshots."""

from __future__ import annotations

import csv
import json
import time
from pathlib import Path
from threading import RLock
from typing import TYPE_CHECKING, Mapping

from radio_capture.models import DecodedRecord
from radio_capture.pipeline.lte_metrics import LTE_DM_METRIC_MSG_CODES, extract_lte_dm_metrics
from radio_capture.pipeline.metrics_sink import (
    CSV_COLUMNS,
    format_decoder_timestamp,
    format_shanghai_timestamp,
    next_csv_timestamp,
)

if TYPE_CHECKING:
    from radio_capture.pipeline.metrics_sink import MetricsCsvWriter


AT_CSV_COLUMNS = CSV_COLUMNS
FOUR_G_CSV_COLUMNS = (
    "timestamp",
    "session_id",
    "sequence",
    "msg_code",
    "MsgTime",
    "LTE Band",
    "LTE Bandwidth DL",
    "LTE BWP Active Bandwidth DL[MHz]",
    "LTE BWP Bandwidth[MHz]",
    "LTE EARFCN DL",
    "LTE PCI",
    "LTE RSRQ[dB]",
    "LTE RSSI[dBm]",
    "LTE RSRP[dBm]",
    "LTE RSRP BestBeam[dBm]",
    "LTE RSRP SecondBeam[dBm]",
    "LTE SINR[dB]",
    "LTE Modulation",
    "LTE MCS",
    "LTE Packet Loss Rate[%]",
    "LTE BLER[%]",
    "LTE Bit Error Rate[%]",
    "LTE Retransmission Count",
    "LTE UL RB Count",
    "LTE DL RB Count",
)


class AtSignalWriter:
    """Persist parsed AT responses as JSONL and a compact NR CSV."""

    def __init__(
        self,
        session_dir: str | Path,
        session_id: str,
        *,
        metrics_writer: "MetricsCsvWriter | None" = None,
        persist_jsonl: bool = True,
        persist_csv: bool = True,
        csv_path: str | Path | None = None,
        lte_csv_path: str | Path | None = None,
        lte_metrics_writer: "FourGMetricsCsvWriter | None" = None,
        write_interval_sec: float = 0.0,
    ):
        self.session_dir = Path(session_dir)
        self.session_id = session_id
        self.metrics_writer = metrics_writer
        self.persist_jsonl = persist_jsonl
        self.persist_csv = persist_csv
        if write_interval_sec < 0:
            raise ValueError("write_interval_sec must not be negative")
        self.write_interval_sec = write_interval_sec
        self.jsonl_path = self.session_dir / "at_signal.jsonl"
        self.csv_path = Path(csv_path) if csv_path is not None else self.session_dir / "at_metrics.csv"
        self.lte_metrics_writer = lte_metrics_writer
        self.lte_csv_path = (
            Path(lte_csv_path)
            if lte_csv_path is not None
            else getattr(lte_metrics_writer, "path", None)
        )
        self._jsonl = None
        self._csv = None
        self._csv_writer = None
        self._lte_csv = None
        self._lte_csv_writer = None
        self._pending: tuple[Mapping[str, object], int] | None = None
        self._last_write_monotonic: float | None = None
        self._last_output_timestamp = None

    def open(self) -> None:
        self._last_output_timestamp = None
        self.session_dir.mkdir(parents=True, exist_ok=True)
        if self.persist_jsonl:
            self._jsonl = self.jsonl_path.open("a", encoding="utf-8")
        if self.persist_csv:
            self.csv_path.parent.mkdir(parents=True, exist_ok=True)
            self._csv = self.csv_path.open("a", encoding="utf-8-sig", newline="")
            self._csv_writer = csv.DictWriter(self._csv, fieldnames=list(AT_CSV_COLUMNS))
            if self.csv_path.stat().st_size == 0:
                self._csv_writer.writeheader()
                self._csv.flush()
        if self.lte_csv_path is not None and self.lte_metrics_writer is None:
            self.lte_csv_path.parent.mkdir(parents=True, exist_ok=True)
            self._lte_csv = self.lte_csv_path.open("a", encoding="utf-8-sig", newline="")
            self._lte_csv_writer = csv.DictWriter(
                self._lte_csv, fieldnames=list(FOUR_G_CSV_COLUMNS)
            )
            if self.lte_csv_path.stat().st_size == 0:
                self._lte_csv_writer.writeheader()
                self._lte_csv.flush()

    def write(self, record: Mapping[str, object], sequence: int) -> None:
        if (
            self.metrics_writer is None
            and self._jsonl is None
            and self._csv is None
            and self._csv_writer is None
            and self._lte_csv is None
            and self._lte_csv_writer is None
            and self.lte_metrics_writer is None
        ):
            raise RuntimeError("AtSignalWriter is not open")
        if (
            self.write_interval_sec > 0
            and self._last_write_monotonic is not None
            and time.monotonic() - self._last_write_monotonic < self.write_interval_sec
        ):
            self._pending = (dict(record), sequence)
            return
        self._write_record(record, sequence)

    def _write_record(self, record: Mapping[str, object], sequence: int) -> None:
        self._pending = None
        self._last_write_monotonic = time.monotonic()
        output_timestamp, self._last_output_timestamp = next_csv_timestamp(
            record.get("timestamp", ""),
            self._last_output_timestamp,
            self.write_interval_sec,
        )
        output_record = dict(record)
        output_record["timestamp"] = output_timestamp
        output_record["MsgTime"] = output_timestamp
        if self.metrics_writer is not None:
            self.metrics_writer.write_at(record, sequence, self.session_id)
        if self._jsonl is not None:
            self._jsonl.write(json.dumps(record, ensure_ascii=False) + "\n")
        if self._csv_writer is not None:
            row = at_record_to_row(output_record, self.session_id, sequence)
            if row is not None:
                self._csv_writer.writerow(row)
        if self._lte_csv_writer is not None:
            lte_row = lte_record_to_row(output_record, self.session_id, sequence)
            if lte_row is not None:
                self._lte_csv_writer.writerow(lte_row)
        if self.lte_metrics_writer is not None:
            self.lte_metrics_writer.write_at(record, sequence, self.session_id)
        self.flush()

    def flush(self) -> None:
        if self._jsonl is not None:
            self._jsonl.flush()
        if self._csv is not None:
            self._csv.flush()
        if self._lte_csv is not None:
            self._lte_csv.flush()
        if self.lte_metrics_writer is not None:
            self.lte_metrics_writer.flush_pending()

    def close(self) -> None:
        if self._pending is not None:
            record, sequence = self._pending
            self._write_record(record, sequence)
        self.flush()
        if self._jsonl is not None:
            self._jsonl.close()
        if self._csv is not None:
            self._csv.close()
        if self._lte_csv is not None:
            self._lte_csv.close()
        self._jsonl = None
        self._csv = None
        self._csv_writer = None
        self._lte_csv = None
        self._lte_csv_writer = None


class FourGMetricsCsvWriter:
    """Persist LTE AT snapshots and LTE DM supplements into one 4G CSV."""

    _AT_BASE_FIELDS = (
        "band",
        "bandwidth_dl",
        "earfcn_dl",
        "pci",
        "rsrq_db",
        "rssi_dbm",
        "rsrp_dbm",
        "sinr_db",
    )
    _DM_FIELDS = (
        "earfcn_dl",
        "pci",
        "modulation",
        "mcs",
        "packet_loss_rate_pct",
        "bler_pct",
        "bit_error_rate_pct",
        "retransmission_count",
        "ul_rb_count",
        "dl_rb_count",
    )

    def __init__(
        self,
        path: str | Path,
        session_id: str,
        *,
        write_interval_sec: float = 0.0,
    ):
        self.path = Path(path)
        self.session_id = session_id
        if write_interval_sec < 0:
            raise ValueError("write_interval_sec must not be negative")
        self.write_interval_sec = write_interval_sec
        self._file = None
        self._writer = None
        self._at_latest: dict[str, object] = {}
        self._dm_latest: dict[str, object] = {}
        self._pending_row: dict[str, object] | None = None
        self._last_write_monotonic: float | None = None
        self._last_output_timestamp = None
        self._state_lock = RLock()

    def open(self, reset: bool = False) -> None:
        self._at_latest.clear()
        self._dm_latest.clear()
        self._pending_row = None
        self._last_write_monotonic = None
        self._last_output_timestamp = None
        self.path.parent.mkdir(parents=True, exist_ok=True)
        mode = "w" if reset else "a"
        self._file = self.path.open(mode, encoding="utf-8-sig", newline="")
        self._writer = csv.DictWriter(self._file, fieldnames=list(FOUR_G_CSV_COLUMNS))
        if reset or self.path.stat().st_size == 0:
            self._writer.writeheader()
            self._file.flush()

    def write_at(
        self,
        record: Mapping[str, object],
        sequence: int,
        session_id: str | None = None,
    ) -> bool:
        row = lte_record_to_row(record, session_id or self.session_id, sequence)
        if row is None:
            return False
        serving = record.get("lte_servingcell")
        serving = serving if isinstance(serving, Mapping) else {}
        csq = record.get("csq")
        csq = csq if isinstance(csq, Mapping) else {}
        with self._state_lock:
            updates = {
                "band": _format_lte_band(_first_value(serving, "band")),
                "bandwidth_dl": _first_value(
                    serving, "bandwidth_dl", "lte_bandwidth_dl", "dl_bandwidth"
                ),
                "earfcn_dl": _first_value(serving, "earfcn", "channel"),
                "pci": _first_value(serving, "pci"),
                "rsrq_db": _first_value(serving, "rsrq_db"),
                "rssi_dbm": _first_value(serving, "rssi_dbm") or _first_value(csq, "rssi_dbm"),
                "rsrp_dbm": _first_value(serving, "rsrp_dbm"),
                "sinr_db": _first_value(serving, "sinr_db"),
            }
            for name, value in updates.items():
                if value not in (None, "", "-", "--"):
                    self._at_latest[name] = value
            latest = self._merged_latest()
        timestamp = str(record.get("timestamp", ""))
        return self._write_row(
            timestamp=timestamp,
            session_id=session_id or self.session_id,
            sequence=sequence,
            msg_code=None,
            latest=latest,
        )

    def write_dm(self, record: DecodedRecord) -> bool:
        if record.msg_code not in LTE_DM_METRIC_MSG_CODES:
            return False
        if record.return_code != 0 or not record.detail:
            return False
        metrics = extract_lte_dm_metrics(record.detail, record.msg_code)
        if metrics is None:
            return False
        with self._state_lock:
            for name in self._DM_FIELDS:
                value = getattr(metrics, name)
                if value not in (None, "", "-", "--"):
                    self._dm_latest[name] = value
            latest = self._merged_latest()
        timestamp = (
            format_shanghai_timestamp(record.receive_time_ns)
            or format_decoder_timestamp(metrics.timestamp)
            or ""
        )
        return self._write_row(
            timestamp=timestamp,
            session_id=record.session_id,
            sequence=record.sequence,
            msg_code=record.msg_code,
            latest=latest,
        )

    def _merged_latest(self) -> dict[str, object]:
        latest = dict(self._dm_latest)
        for name in self._AT_BASE_FIELDS:
            if name in self._at_latest:
                latest[name] = self._at_latest[name]
        return latest

    def _write_row(
        self,
        *,
        timestamp: str,
        session_id: str,
        sequence: int,
        msg_code: int | None,
        latest: Mapping[str, object],
    ) -> bool:
        if self._writer is None or self._file is None:
            raise RuntimeError("4G metrics CSV writer is not open")
        row = {
            "timestamp": timestamp,
            "session_id": session_id,
            "sequence": sequence,
            "msg_code": f"0x{msg_code:04X}" if msg_code is not None else "",
            "MsgTime": timestamp,
            "LTE Band": latest.get("band", ""),
            "LTE Bandwidth DL": _format_number(latest.get("bandwidth_dl")),
            "LTE BWP Active Bandwidth DL[MHz]": _format_number(
                latest.get("bandwidth_dl")
            ),
            "LTE BWP Bandwidth[MHz]": _format_number(latest.get("bandwidth_dl")),
            "LTE EARFCN DL": _format_number(latest.get("earfcn_dl")),
            "LTE PCI": _format_number(latest.get("pci")),
            "LTE RSRQ[dB]": _format_number(latest.get("rsrq_db")),
            "LTE RSSI[dBm]": _format_number(latest.get("rssi_dbm")),
            "LTE RSRP[dBm]": _format_number(latest.get("rsrp_dbm")),
            "LTE RSRP BestBeam[dBm]": "",
            "LTE RSRP SecondBeam[dBm]": "",
            "LTE SINR[dB]": _format_number(latest.get("sinr_db")),
            "LTE Modulation": latest.get("modulation", ""),
            "LTE MCS": _format_number(latest.get("mcs")),
            "LTE Packet Loss Rate[%]": _format_number(latest.get("packet_loss_rate_pct")),
            "LTE BLER[%]": _format_number(latest.get("bler_pct")),
            "LTE Bit Error Rate[%]": _format_number(latest.get("bit_error_rate_pct")),
            "LTE Retransmission Count": _format_number(latest.get("retransmission_count")),
            "LTE UL RB Count": _format_number(latest.get("ul_rb_count")),
            "LTE DL RB Count": _format_number(latest.get("dl_rb_count")),
        }
        with self._state_lock:
            self._pending_row = row
            now = time.monotonic()
            if (
                self.write_interval_sec > 0
                and self._last_write_monotonic is not None
                and now - self._last_write_monotonic < self.write_interval_sec
            ):
                return False
            self._write_pending_locked(now)
            return True

    def flush_pending(self) -> bool:
        with self._state_lock:
            if self._pending_row is None:
                return False
            self._write_pending_locked(time.monotonic())
            return True

    def _write_pending_locked(self, now: float) -> None:
        if self._pending_row is None:
            return
        if self._writer is None or self._file is None:
            raise RuntimeError("4G metrics CSV writer is not open")
        timestamp, self._last_output_timestamp = next_csv_timestamp(
            self._pending_row.get("timestamp", ""),
            self._last_output_timestamp,
            self.write_interval_sec,
        )
        self._pending_row["timestamp"] = timestamp
        self._pending_row["MsgTime"] = timestamp
        self._writer.writerow(self._pending_row)
        self._file.flush()
        self._pending_row = None
        self._last_write_monotonic = now

    def close(self) -> None:
        self.flush_pending()
        if self._file is not None:
            self._file.close()
        self._file = None
        self._writer = None


def at_record_to_row(
    record: Mapping[str, object], session_id: str, sequence: int
) -> dict[str, object] | None:
    """Convert one parsed AT snapshot to the stable CSV schema.

    The modem's standard ``QENG=servingcell`` response does not expose every
    QXDM-style beam/BWP metric.  Those columns intentionally remain empty
    unless the parser receives an explicit value for them.
    """
    serving = record.get("servingcell")
    serving = serving if isinstance(serving, Mapping) else {}
    if not serving and _is_lte_record(record):
        return None

    timestamp = record.get("timestamp", "")
    band = serving.get("band", "")
    if band not in (None, ""):
        band = str(band)
        if not band.lower().startswith("n"):
            band = f"n{band}" if band.isdigit() else band

    csq = record.get("csq")
    csq = csq if isinstance(csq, Mapping) else {}
    rsrp = _first_value(serving, "rsrp_dbm", "ssb_rsrp_dbm")
    rssi = _first_value(
        serving,
        "ssb_rssi_dbm",
        "rssi_dbm",
    )
    if rssi in (None, "", "-", "--"):
        rssi = _first_value(csq, "rssi_dbm")
    row: dict[str, object] = {
        "timestamp": timestamp,
        "session_id": session_id,
        "sequence": sequence,
        "msg_code": "",
        "MsgTime": _first_value(record, "MsgTime", "msg_time") or timestamp,
        "NR Band": band,
        "NR Bandwidth DL": _first_value(
            serving, "bandwidth_dl", "nr_bandwidth_dl", "dl_bandwidth"
        ),
        # BWP and beam columns remain DM-owned in the hybrid mode.  RSSI is
        # different: standard AT+CSQ supplies a general RSSI fallback, while
        # an explicit QENG SSB-RSSI field takes precedence when available.
        "NR BWP Active Bandwidth DL[MHz]": "",
        "NR BWP Bandwidth[MHz]": "",
        "NR SSB ARFCN DL": _first_value(
            serving, "ssb_arfcn_dl", "nr_ssb_arfcn_dl", "ssb_arfcn", "arfcn"
        ),
        "NR PCI": serving.get("pci", ""),
        "NR SSB RSRQ[dB]": _first_value(serving, "ssb_rsrq_db", "rsrq_db"),
        "NR SSB RSSI[dBm]": rssi,
        "NR SSB RSRP[dBm]": rsrp,
        "NR SSB RSRP BestBeam[dBm]": "",
        "NR SSB RSRP SecondBeam[dBm]": "",
        "NR SSB SINR[dB]": serving.get("sinr_db", ""),
    }
    return row


def lte_record_to_row(
    record: Mapping[str, object], session_id: str, sequence: int
) -> dict[str, object] | None:
    """Convert one parsed LTE AT snapshot to the 4G CSV schema."""
    serving = record.get("lte_servingcell")
    serving = serving if isinstance(serving, Mapping) else {}
    if not serving:
        return None

    timestamp = record.get("timestamp", "")
    csq = record.get("csq")
    csq = csq if isinstance(csq, Mapping) else {}
    rssi = _first_value(serving, "rssi_dbm")
    if rssi in (None, "", "-", "--"):
        rssi = _first_value(csq, "rssi_dbm")
    bandwidth_dl = _first_value(
        serving, "bandwidth_dl", "lte_bandwidth_dl", "dl_bandwidth"
    )
    row: dict[str, object] = {
        "timestamp": timestamp,
        "session_id": session_id,
        "sequence": sequence,
        "msg_code": "",
        "MsgTime": _first_value(record, "MsgTime", "msg_time") or timestamp,
        "LTE Band": _format_lte_band(_first_value(serving, "band")),
        "LTE Bandwidth DL": bandwidth_dl,
        "LTE BWP Active Bandwidth DL[MHz]": bandwidth_dl,
        "LTE BWP Bandwidth[MHz]": bandwidth_dl,
        "LTE EARFCN DL": _first_value(serving, "earfcn", "channel"),
        "LTE PCI": serving.get("pci", ""),
        "LTE RSRQ[dB]": _first_value(serving, "rsrq_db"),
        "LTE RSSI[dBm]": rssi,
        "LTE RSRP[dBm]": _first_value(serving, "rsrp_dbm"),
        "LTE RSRP BestBeam[dBm]": "",
        "LTE RSRP SecondBeam[dBm]": "",
        "LTE SINR[dB]": _first_value(serving, "sinr_db"),
        "LTE Modulation": _first_value(serving, "modulation"),
        "LTE MCS": _first_value(serving, "mcs"),
        "LTE Packet Loss Rate[%]": _first_value(serving, "packet_loss_rate_pct"),
        "LTE BLER[%]": _first_value(serving, "bler_pct"),
        "LTE Bit Error Rate[%]": _first_value(serving, "bit_error_rate_pct"),
        "LTE Retransmission Count": _first_value(serving, "retransmission_count"),
        "LTE UL RB Count": _first_value(serving, "ul_rb_count"),
        "LTE DL RB Count": _first_value(serving, "dl_rb_count"),
    }
    return row


def _first_value(mapping: Mapping[str, object], *names: str) -> object:
    for name in names:
        value = mapping.get(name)
        if value not in (None, "", "-", "--"):
            return value
    return ""


def _format_number(value: object) -> str:
    if value is None or value == "":
        return ""
    if isinstance(value, (int, float)):
        return f"{value:g}"
    return str(value)


def _is_lte_record(record: Mapping[str, object]) -> bool:
    serving = record.get("lte_servingcell")
    if isinstance(serving, Mapping):
        return True
    for key in ("servingcell", "qcsq", "network"):
        value = record.get(key)
        if not isinstance(value, Mapping):
            continue
        rat = str(value.get("rat", "")).upper()
        if "LTE" in rat and "NR" not in rat:
            return True
    return False


def _format_lte_band(value: object) -> object:
    if value in (None, "", "-", "--"):
        return ""
    text = str(value)
    upper = text.upper()
    if upper.startswith("LTE BAND "):
        text = text.split()[-1]
    elif upper.startswith("B") and text[1:].isdigit():
        text = text[1:]
    return f"B{text}" if text.isdigit() else text
