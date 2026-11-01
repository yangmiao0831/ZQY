"""CSV sink for normalized NR radio metrics."""

from __future__ import annotations

import csv
import time
from collections import deque
from datetime import datetime, timedelta, timezone
from pathlib import Path
from threading import RLock
from typing import Mapping

from radio_capture.models import DecodedRecord
from radio_capture.native.autocom_bler_process import AutocomPuschBlerResult
from radio_capture.pipeline.bwp import RrcBwpTracker
from radio_capture.pipeline.metrics import (
    NR_METRIC_COLUMNS,
    extract_nr_metrics,
    has_link_metric_values,
)


CSV_COLUMNS = ("timestamp", "session_id", "sequence", "msg_code", *NR_METRIC_COLUMNS)
SHANGHAI_TZ = timezone(timedelta(hours=8), name="Asia/Shanghai")

# Source ownership for the hybrid capture contract.  AT is the authoritative
# source for serving-cell values that are available from QENG.  DM is reserved
# for fields that require Qualcomm log detail, such as BWP and beam metrics.
AT_BASE_FIELDS = (
    "band",
    "bandwidth_dl",
    "ssb_arfcn_dl",
    "pci",
    "ssb_rsrp_dbm",
    "ssb_rsrq_db",
    "ssb_sinr_db",
)
DM_ADVANCED_FIELDS = (
    "bwp_active_bandwidth_dl_mhz",
    "bwp_bandwidth_mhz",
    "ssb_rssi_dbm",
    "ssb_rsrp_bestbeam_dbm",
    "ssb_rsrp_secondbeam_dbm",
    "modulation",
    "mcs",
    "packet_loss_rate_pct",
    "bler_pct",
    "pdsch_bler_pct",
    "pusch_bler_pct",
    "unclassified_bler_pct",
    "rlf_insync_filtered_bler_pct",
    "rlf_outsync_filtered_bler_pct",
    "rlf_bler_sample_count",
    "rlf_bler_sfn_start",
    "rlf_bler_sfn_end",
    "rlf_bler_purpose",
    "rlf_bler_window",
    "rlf_bler_source_field",
    "bler_source_code",
    "bler_source_field",
    "bler_purpose",
    "bler_window",
    "pdsch_crc_status",
    "pdsch_harq_id",
    "pdsch_ndi",
    "pdsch_rv",
    "pdsch_tx_type",
    "pdsch_retransmission_count",
    "pdsch_crc_record_count",
    "pdsch_crc_record_index",
    "pusch_tx_type",
    "pusch_new_tb",
    "pusch_harq_id",
    "pusch_rv_index",
    "pusch_frame",
    "pusch_slot",
    "pusch_dci_ndi",
    "pusch_dci_rv",
    "pusch_dci_harq_id",
    "pusch_dci_frame",
    "pusch_dci_slot",
    "pusch_harq_ack_bits",
    "pusch_harq_nack_bits",
    "pusch_uci_harq_value",
    "pusch_uci_harq_id",
    "pusch_uci_crc_status_raw",
    "pusch_uci_crc_valid",
    "pusch_uci_crc_late",
    "pusch_uci_pdsch_valid",
    "bit_error_rate_pct",
    "retransmission_count",
    "ul_rb_count",
    "dl_rb_count",
)


class MetricsCsvWriter:
    def __init__(
        self,
        path: str | Path,
        fallback_suffix: str | None = None,
        *,
        write_interval_sec: float = 0.0,
    ):
        self.path = Path(path)
        self.fallback_suffix = fallback_suffix
        if write_interval_sec < 0:
            raise ValueError("write_interval_sec must not be negative")
        self.write_interval_sec = write_interval_sec
        self._file = None
        self._writer = None
        self._at_latest: dict[str, object] = {}
        self._dm_latest: dict[str, object] = {}
        self._bwp_tracker = RrcBwpTracker()
        self._pending_row: dict[str, object] | None = None
        self._last_write_monotonic: float | None = None
        self._last_output_timestamp: datetime | None = None
        self._state_lock = RLock()
        self._pdsch_crc_window: deque[tuple[int, int, int, int]] = deque()
        self._pdsch_crc_window_sec = 1.0
        self._pdsch_crc_window_stable_sec = 10.0
        self._pdsch_bler_min_samples = 10
        self._pdsch_crc_window_start_ns: int | None = None
        self._pdsch_crc_window_end_ns: int | None = None
        self._pdsch_crc_window_sequence: int | None = None

    def open(self, reset: bool = False) -> None:
        self._at_latest.clear()
        self._dm_latest.clear()
        self._bwp_tracker.reset()
        self._pending_row = None
        self._last_write_monotonic = None
        self._last_output_timestamp = None
        self._pdsch_crc_window.clear()
        self._pdsch_crc_window_start_ns = None
        self._pdsch_crc_window_end_ns = None
        self._pdsch_crc_window_sequence = None
        self.path.parent.mkdir(parents=True, exist_ok=True)
        mode = "w" if reset else "a"
        try:
            self._file = self.path.open(mode, encoding="utf-8-sig", newline="")
        except PermissionError:
            if not self.fallback_suffix:
                raise
            self.path = self.path.with_name(
                f"{self.path.stem}-{self.fallback_suffix}{self.path.suffix}"
            )
            print(f"metrics CSV is locked; using fallback={self.path}")
            self._file = self.path.open(mode, encoding="utf-8-sig", newline="")
        self._writer = csv.DictWriter(self._file, fieldnames=list(CSV_COLUMNS))
        if reset or self.path.stat().st_size == 0:
            self._writer.writeheader()
            self._file.flush()

    def write(self, record: DecodedRecord) -> bool:
        if self._writer is None or self._file is None:
            raise RuntimeError("metrics CSV writer is not open")
        if record.return_code != 0 or not record.detail:
            return False
        # Prefer the capture receive time.  The decoder Header/Time is not
        # reliable for every QWinLog message definition (some use 1980/epoch
        # values), while FrameEnvelope.receive_time_ns is the actual arrival
        # time of the DM packet on COM6.
        capture_timestamp = format_shanghai_timestamp(record.receive_time_ns)
        bwp_update = self._bwp_tracker.update(record.detail, record.msg_code)
        metrics = extract_nr_metrics(record.detail, record.msg_code)
        if metrics is None and bwp_update is None:
            return False
        capture_time_ns = record.receive_time_ns or time.time_ns()
        bler_window_now_ns = capture_time_ns

        # Keep decoded DM values in this writer's cache.  When the same writer
        # also receives AT snapshots, _merged_latest overlays AT-owned base
        # fields on top of the DM-owned advanced fields.
        with self._state_lock:
            if bwp_update is not None:
                for name in (
                    "bwp_active_bandwidth_dl_mhz",
                    "bwp_bandwidth_mhz",
                ):
                    value = getattr(bwp_update, name)
                    if value is not None:
                        self._dm_latest[name] = value
            if metrics is not None:
                for name in (*AT_BASE_FIELDS, *DM_ADVANCED_FIELDS):
                    value = getattr(metrics, name)
                    if value is not None:
                        self._dm_latest[name] = value
                if record.msg_code == 0xB97F:
                    # B97F is the serving-cell/beam measurement snapshot.
                    # Refresh its RSRP columns as a group so an invalid
                    # positive index is emitted as blank, not as a stale
                    # value retained from an earlier measurement.
                    for name in (
                        "ssb_rsrp_dbm",
                        "ssb_rsrp_bestbeam_dbm",
                        "ssb_rsrp_secondbeam_dbm",
                    ):
                        self._dm_latest[name] = getattr(metrics, name)
                if metrics.bler_source_code is not None:
                    for name in (
                        "bler_source_code",
                        "bler_source_field",
                        "bler_purpose",
                        "bler_window",
                    ):
                        self._dm_latest[name] = getattr(metrics, name)
                    self._dm_latest["bler_source_sequence"] = record.sequence
                if metrics.unclassified_bler_pct is not None:
                    self._dm_latest["unclassified_bler_source_code"] = (
                        metrics.bler_source_code or ""
                    )
                    self._dm_latest["unclassified_bler_source_field"] = (
                        metrics.bler_source_field or ""
                    )
                    self._dm_latest["unclassified_bler_source_sequence"] = record.sequence
                if metrics.rlf_bler_sample_count is not None:
                    self._dm_latest["rlf_bler_source_code"] = (
                        f"0x{record.msg_code:04X}"
                        if record.msg_code is not None
                        else ""
                    )
                    self._dm_latest["rlf_bler_source_sequence"] = record.sequence
                if metrics.pdsch_bler_pct is not None:
                    self._dm_latest["pdsch_bler_reported_pct"] = metrics.pdsch_bler_pct
                    self._dm_latest["pdsch_bler_reported_sequence"] = record.sequence
                    self._dm_latest["pdsch_bler_reported_field"] = (
                        metrics.bler_source_field or "decoder PDSCH BLER field"
                    )
                    self._dm_latest["pdsch_bler_source_code"] = metrics.bler_source_code
                    self._dm_latest["pdsch_bler_source_field"] = metrics.bler_source_field
                    self._dm_latest["pdsch_bler_calculated"] = False
                if metrics.pusch_bler_pct is not None:
                    self._dm_latest["pusch_bler_source_sequence"] = record.sequence
                    self._dm_latest["pusch_bler_source_code"] = metrics.bler_source_code
                    self._dm_latest["pusch_bler_source_field"] = metrics.bler_source_field
                if any(
                    getattr(metrics, name) is not None
                    for name in (
                        "pusch_tx_type",
                        "pusch_new_tb",
                        "pusch_harq_id",
                        "pusch_rv_index",
                    )
                ):
                    self._dm_latest["pusch_tx_source_sequence"] = record.sequence
                if any(
                    getattr(metrics, name) is not None
                    for name in (
                        "pusch_dci_ndi",
                        "pusch_dci_rv",
                        "pusch_dci_harq_id",
                    )
                ):
                    self._dm_latest["pusch_dci_source_sequence"] = record.sequence
                if any(
                    getattr(metrics, name) is not None
                    for name in (
                        "pusch_harq_ack_bits",
                        "pusch_harq_nack_bits",
                        "pusch_uci_harq_value",
                        "pusch_uci_harq_id",
                        "pusch_uci_crc_status_raw",
                        "pusch_uci_crc_valid",
                        "pusch_uci_crc_late",
                        "pusch_uci_pdsch_valid",
                    )
                ):
                    self._dm_latest["pusch_uci_source_sequence"] = record.sequence

                for event in metrics.bler_events:
                    if (
                        event.direction != "DL"
                        or event.channel != "PDSCH"
                        or event.crc_status not in {"PASS", "FAIL"}
                    ):
                        continue
                    self._dm_latest["pdsch_event_source_sequence"] = record.sequence
                    self._dm_latest["pdsch_bler_source_code"] = event.source_code
                    self._dm_latest["pdsch_bler_source_field"] = event.source_field
                    self._dm_latest["pdsch_bler_source_record_index"] = (
                        event.record_index
                    )
                    event_time_ns = _bler_event_timestamp_ns(
                        event.timestamp, capture_time_ns
                    )
                    bler_window_now_ns = event_time_ns
                    if event.tx_type != "NEW_TX":
                        continue
                    status_error = int(event.crc_status == "FAIL")
                    self._pdsch_crc_window.append(
                        (
                            event_time_ns,
                            status_error,
                            record.sequence,
                            event.record_index,
                        )
                    )
                    if self._pdsch_crc_window_start_ns is None:
                        self._pdsch_crc_window_start_ns = event_time_ns
                    self._pdsch_crc_window_end_ns = event_time_ns
                    self._pdsch_crc_window_sequence = record.sequence

            if record.msg_code is not None:
                cutoff_ns = bler_window_now_ns - int(
                    self._pdsch_crc_window_stable_sec * 1_000_000_000
                )
                while self._pdsch_crc_window and self._pdsch_crc_window[0][0] < cutoff_ns:
                    self._pdsch_crc_window.popleft()
                if not self._pdsch_crc_window:
                    self._pdsch_crc_window_start_ns = None
                    self._pdsch_crc_window_end_ns = None
                    self._pdsch_crc_window_sequence = None
                else:
                    self._pdsch_crc_window_start_ns = self._pdsch_crc_window[0][0]
                    self._pdsch_crc_window_end_ns = self._pdsch_crc_window[-1][0]

            cutoff_1s = bler_window_now_ns - int(self._pdsch_crc_window_sec * 1_000_000_000)
            events_1s = [event for event in self._pdsch_crc_window if event[0] >= cutoff_1s]
            cutoff_5s = bler_window_now_ns - 5_000_000_000
            events_5s = [event for event in self._pdsch_crc_window if event[0] >= cutoff_5s]
            events_10s = list(self._pdsch_crc_window)
            samples_1s = len(events_1s)
            errors_1s = sum(error for _, error, _, _ in events_1s)
            samples_5s = len(events_5s)
            errors_5s = sum(error for _, error, _, _ in events_5s)
            samples_10s = len(events_10s)
            errors_10s = sum(error for _, error, _, _ in events_10s)
            initial_bler_1s = errors_1s * 100.0 / samples_1s if samples_1s else None
            initial_bler_5s = errors_5s * 100.0 / samples_5s if samples_5s else None
            initial_bler_10s = errors_10s * 100.0 / samples_10s if samples_10s else None
            self._dm_latest["pdsch_initial_bler_1s_pct"] = initial_bler_1s
            self._dm_latest["pdsch_initial_bler_1s_valid"] = int(
                samples_1s >= self._pdsch_bler_min_samples
            )
            self._dm_latest["pdsch_initial_bler_1s_samples"] = samples_1s
            self._dm_latest["pdsch_initial_bler_1s_errors"] = errors_1s
            self._dm_latest["pdsch_initial_bler_1s_source_sequence"] = (
                events_1s[-1][2] if events_1s else None
            )
            self._dm_latest["pdsch_initial_bler_5s_pct"] = initial_bler_5s
            self._dm_latest["pdsch_initial_bler_5s_samples"] = samples_5s
            self._dm_latest["pdsch_initial_bler_5s_errors"] = errors_5s
            self._dm_latest["pdsch_initial_bler_5s_valid"] = int(
                samples_5s >= self._pdsch_bler_min_samples
            )
            self._dm_latest["pdsch_initial_bler_5s_source_sequence"] = (
                events_5s[-1][2] if events_5s else None
            )
            self._dm_latest["pdsch_initial_bler_10s_pct"] = initial_bler_10s
            self._dm_latest["pdsch_initial_bler_10s_samples"] = samples_10s
            self._dm_latest["pdsch_initial_bler_10s_errors"] = errors_10s
            self._dm_latest["pdsch_initial_bler_10s_valid"] = int(
                samples_10s >= self._pdsch_bler_min_samples
            )
            self._dm_latest["pdsch_initial_bler_10s_source_sequence"] = (
                events_10s[-1][2] if events_10s else None
            )
            self._dm_latest["pdsch_bler_min_samples"] = self._pdsch_bler_min_samples
            self._dm_latest["pdsch_bler_calculated"] = bool(
                samples_1s or samples_5s or samples_10s
            )
            self._dm_latest["pdsch_bler_residual_status"] = (
                "not calculated: captured log has no terminal HARQ outcome marker"
            )
            self._dm_latest["pdsch_bler_window_samples"] = samples_1s
            self._dm_latest["pdsch_bler_window_errors"] = errors_1s
            self._dm_latest["pdsch_bler_window_sec"] = self._pdsch_crc_window_sec
            self._dm_latest["pdsch_bler_basis"] = (
                "initial TB; NewTxFlag=1; CRC_status PASS/FAIL; rolling window"
            )
            if events_1s:
                self._dm_latest["pdsch_bler_pct"] = initial_bler_1s
                self._dm_latest["pdsch_bler_source_sequence"] = events_1s[-1][2]
                self._dm_latest["pdsch_bler_source_record_index"] = events_1s[-1][3]
                self._dm_latest["pdsch_bler_source_code"] = "0xB887"
                self._dm_latest["pdsch_bler_source_field"] = "CRC_status"
            elif self._dm_latest.get("pdsch_bler_reported_pct") is not None:
                self._dm_latest["pdsch_bler_pct"] = self._dm_latest[
                    "pdsch_bler_reported_pct"
                ]
                self._dm_latest["pdsch_bler_window_sec"] = None
                self._dm_latest["pdsch_bler_calculated"] = False
                self._dm_latest["pdsch_bler_basis"] = (
                    f"{self._dm_latest.get('pdsch_bler_reported_field', 'decoder PDSCH BLER field')}; "
                    "averaging window not reported"
                )
                self._dm_latest["pdsch_bler_source_sequence"] = self._dm_latest.get(
                    "pdsch_bler_reported_sequence"
                )
                self._dm_latest["pdsch_bler_source_record_index"] = None
                self._dm_latest["pdsch_bler_window_start_ns"] = None
                self._dm_latest["pdsch_bler_window_end_ns"] = None
            else:
                self._dm_latest["pdsch_bler_pct"] = None
                self._dm_latest["pdsch_bler_source_sequence"] = None
                self._dm_latest["pdsch_bler_source_record_index"] = None
                self._dm_latest["pdsch_bler_source_code"] = None
                self._dm_latest["pdsch_bler_source_field"] = None
                self._dm_latest["pdsch_bler_basis"] = (
                    "no eligible initial-transmission CRC samples in 1s"
                    if samples_10s
                    else ""
                )
            latest = self._merged_latest()

        if metrics is None:
            return False

        # Configuration/measurement messages update the cache.  Emit one
        # consolidated row for the serving-cell/beam measurement (0xB97F).
        if (
            record.msg_code not in (None, 0xB97F)
            and metrics.ssb_rsrp_dbm is None
            and not has_link_metric_values(metrics)
        ):
            return False

        return self._write_row(
            timestamp=capture_timestamp or format_decoder_timestamp(metrics.timestamp) or "",
            session_id=record.session_id,
            sequence=record.sequence,
            msg_code=record.msg_code,
            latest=latest,
        )

    def write_at(
        self,
        record: Mapping[str, object],
        sequence: int,
        session_id: str = "AT",
    ) -> bool:
        """Write one AT snapshot using only the AT-owned base fields."""
        serving = record.get("servingcell")
        if not isinstance(serving, Mapping):
            return False

        # AT owns the standard serving-cell fields.  Optional QENG key/value
        # fields for BWP or beam metrics are intentionally ignored here; those
        # columns remain DM-owned even when a modem happens to expose them.
        with self._state_lock:
            band = serving.get("band")
            if band not in (None, ""):
                band_text = str(band)
                self._at_latest["band"] = (
                    band_text if band_text.lower().startswith("n") else f"n{band_text}"
                )
            updates = {
                "bandwidth_dl": serving.get(
                    "bandwidth_dl", serving.get("nr_bandwidth_dl", serving.get("dl_bandwidth"))
                ),
                "ssb_arfcn_dl": serving.get("ssb_arfcn_dl", serving.get("arfcn")),
                "pci": serving.get("pci"),
                "ssb_rsrp_dbm": serving.get("ssb_rsrp_dbm", serving.get("rsrp_dbm")),
                "ssb_rsrq_db": serving.get("ssb_rsrq_db", serving.get("rsrq_db")),
                "ssb_sinr_db": serving.get("ssb_sinr_db", serving.get("sinr_db")),
                "ssb_rssi_dbm": serving.get(
                    "ssb_rssi_dbm", serving.get("rssi_dbm")
                ),
            }
            csq = record.get("csq")
            if (
                isinstance(csq, Mapping)
                and updates["ssb_rssi_dbm"] in (None, "", "-", "--")
            ):
                updates["ssb_rssi_dbm"] = csq.get("rssi_dbm")
            for name, value in updates.items():
                if value not in (None, "", "-", "--"):
                    self._at_latest[name] = value
            latest = self._merged_latest()

        timestamp = record.get("timestamp", "")
        return self._write_row(
            timestamp=str(timestamp),
            session_id=session_id,
            sequence=sequence,
            msg_code=None,
            latest=latest,
        )

    def update_pusch_bler(self, result: AutocomPuschBlerResult) -> None:
        """Cache one real AutoCom/DDLCXX NR5gPUSCHBLER interval result."""
        with self._state_lock:
            self._dm_latest["pusch_bler_window_samples"] = result.samples
            self._dm_latest["pusch_bler_window_successes"] = result.successes
            self._dm_latest["pusch_bler_window_errors"] = result.errors
            self._dm_latest["pusch_bler_window"] = "DDLCXX internal interval (~1s)"
            self._dm_latest["pusch_bler_valid"] = int(result.samples >= 10)
            self._dm_latest["pusch_bler_calculated"] = True
            self._dm_latest["pusch_bler_source_sequence"] = result.sequence
            self._dm_latest["pusch_bler_source_code"] = (
                f"DDLCXX01:{result.object_id}"
            )
            self._dm_latest["pusch_bler_source_field"] = (
                f"NR5gPUSCHBLER.BLER ({result.value_field_id})"
            )
            # A zero-sample interval omits field 5. Do not turn that absence
            # into a fabricated 0% or carry a stale value into a new window.
            self._dm_latest["pusch_bler_pct"] = (
                result.bler_pct if result.samples > 0 else None
            )


    def _merged_latest(self) -> dict[str, object]:
        """Return DM values with the latest valid AT serving-cell fallback."""
        latest = dict(self._dm_latest)
        for name in AT_BASE_FIELDS:
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
            raise RuntimeError("metrics CSV writer is not open")
        row = {
            "timestamp": timestamp,
            "session_id": session_id,
            "sequence": sequence,
            "msg_code": f"0x{msg_code:04X}" if msg_code is not None else "",
            "MsgTime": timestamp,
            "NR Band": latest.get("band", ""),
            "NR Bandwidth DL": _format_number(latest.get("bandwidth_dl")),
            "NR BWP Active Bandwidth DL[MHz]": _format_number(
                latest.get("bwp_active_bandwidth_dl_mhz")
            ),
            "NR BWP Bandwidth[MHz]": _format_number(
                latest.get("bwp_bandwidth_mhz")
            ),
            "NR SSB ARFCN DL": latest.get("ssb_arfcn_dl", ""),
            "NR PCI": latest.get("pci", ""),
            "NR SSB RSRQ[dB]": _format_number(latest.get("ssb_rsrq_db")),
            "NR SSB RSSI[dBm]": _format_number(latest.get("ssb_rssi_dbm")),
            "NR SSB RSRP[dBm]": _format_number(latest.get("ssb_rsrp_dbm")),
            "NR SSB RSRP BestBeam[dBm]": _format_number(
                latest.get("ssb_rsrp_bestbeam_dbm")
            ),
            "NR SSB RSRP SecondBeam[dBm]": _format_number(
                latest.get("ssb_rsrp_secondbeam_dbm")
            ),
            "NR SSB SINR[dB]": _format_number(latest.get("ssb_sinr_db")),
            "NR Modulation": latest.get("modulation", ""),
            "NR MCS": _format_number(latest.get("mcs")),
            "NR Packet Loss Rate[%]": _format_number(
                latest.get("packet_loss_rate_pct")
            ),
            # Kept as a blank compatibility column; directionless BLER is not
            # exported as a numeric metric anymore.
            "NR BLER[%]": "",
            "NR PDSCH BLER[%]": _format_number(latest.get("pdsch_bler_pct")),
            "NR PUSCH BLER[%]": _format_number(latest.get("pusch_bler_pct")),
            "NR BLER (direction unknown)[%]": _format_number(
                latest.get("unclassified_bler_pct")
            ),
            "NR BLER Direction Unknown Source Code": latest.get(
                "unclassified_bler_source_code", ""
            ),
            "NR BLER Direction Unknown Source Field": latest.get(
                "unclassified_bler_source_field", ""
            ),
            "NR BLER Direction Unknown Source Sequence": _format_number(
                latest.get("unclassified_bler_source_sequence")
            ),
            "NR RLF InSync Filtered BLER[%]": _format_number(
                latest.get("rlf_insync_filtered_bler_pct")
            ),
            "NR RLF OutSync Filtered BLER[%]": _format_number(
                latest.get("rlf_outsync_filtered_bler_pct")
            ),
            "NR RLF BLER Sample Count": _format_number(
                latest.get("rlf_bler_sample_count")
            ),
            "NR RLF BLER SFN Start": _format_number(latest.get("rlf_bler_sfn_start")),
            "NR RLF BLER SFN End": _format_number(latest.get("rlf_bler_sfn_end")),
            "NR BLER Source Code": "",
            "NR BLER Source Field": "",
            "NR BLER Purpose": "",
            "NR BLER Window": "",
            "NR BLER Source Sequence": "",
            "NR PDSCH CRC Status": latest.get("pdsch_crc_status", ""),
            "NR PDSCH HARQ ID": _format_number(latest.get("pdsch_harq_id")),
            "NR PDSCH NDI": _format_number(latest.get("pdsch_ndi")),
            "NR PDSCH RV": _format_number(latest.get("pdsch_rv")),
            "NR PDSCH TX Type": latest.get("pdsch_tx_type", ""),
            "NR PDSCH Retransmission Count": _format_number(
                latest.get("pdsch_retransmission_count")
            ),
            "NR PDSCH CRC Records In Message": _format_number(
                latest.get("pdsch_crc_record_count")
            ),
            "NR PDSCH CRC Record Index": _format_number(
                latest.get("pdsch_crc_record_index")
            ),
            "NR PDSCH Event Source Sequence": _format_number(
                latest.get("pdsch_event_source_sequence")
            ),
            "NR PDSCH BLER Basis": latest.get("pdsch_bler_basis", ""),
            "NR PDSCH BLER Window[sec]": _format_number(
                latest.get("pdsch_bler_window_sec")
            ),
            "NR PDSCH CRC Window Samples": _format_number(
                latest.get("pdsch_bler_window_samples")
            ),
            "NR PDSCH CRC Window Errors": _format_number(
                latest.get("pdsch_bler_window_errors")
            ),
            "NR PDSCH Initial BLER 1s[%]": _format_number(
                latest.get("pdsch_initial_bler_1s_pct")
            ),
            "NR PDSCH Initial BLER 1s Sample Count": _format_number(
                latest.get("pdsch_initial_bler_1s_samples")
            ),
            "NR PDSCH Initial BLER 1s Errors": _format_number(
                latest.get("pdsch_initial_bler_1s_errors")
            ),
            "NR PDSCH Initial BLER 1s Valid": _format_number(
                latest.get("pdsch_initial_bler_1s_valid")
            ),
            "NR PDSCH Initial BLER 1s Source Sequence": _format_number(
                latest.get("pdsch_initial_bler_1s_source_sequence")
            ),
            "NR PDSCH Initial BLER 5s[%]": _format_number(
                latest.get("pdsch_initial_bler_5s_pct")
            ),
            "NR PDSCH Initial BLER 5s Sample Count": _format_number(
                latest.get("pdsch_initial_bler_5s_samples")
            ),
            "NR PDSCH Initial BLER 5s Errors": _format_number(
                latest.get("pdsch_initial_bler_5s_errors")
            ),
            "NR PDSCH Initial BLER 5s Valid": _format_number(
                latest.get("pdsch_initial_bler_5s_valid")
            ),
            "NR PDSCH Initial BLER 5s Source Sequence": _format_number(
                latest.get("pdsch_initial_bler_5s_source_sequence")
            ),
            "NR PDSCH Initial BLER 10s[%]": _format_number(
                latest.get("pdsch_initial_bler_10s_pct")
            ),
            "NR PDSCH Initial BLER 10s Sample Count": _format_number(
                latest.get("pdsch_initial_bler_10s_samples")
            ),
            "NR PDSCH Initial BLER 10s Errors": _format_number(
                latest.get("pdsch_initial_bler_10s_errors")
            ),
            "NR PDSCH Initial BLER 10s Valid": _format_number(
                latest.get("pdsch_initial_bler_10s_valid")
            ),
            "NR PDSCH Initial BLER 10s Source Sequence": _format_number(
                latest.get("pdsch_initial_bler_10s_source_sequence")
            ),
            "NR PDSCH BLER Minimum Samples": _format_number(
                latest.get("pdsch_bler_min_samples")
            ),
            "NR PDSCH BLER Calculated": _format_number(
                int(bool(latest.get("pdsch_bler_calculated")))
            ),
            "NR PDSCH BLER Source Code": latest.get("pdsch_bler_source_code", ""),
            "NR PDSCH BLER Source Field": latest.get("pdsch_bler_source_field", ""),
            "NR PDSCH BLER Source Sequence": _format_number(
                latest.get("pdsch_bler_source_sequence")
            ),
            "NR PDSCH BLER Source Record Index": _format_number(
                latest.get("pdsch_bler_source_record_index")
            ),
            "NR PDSCH Residual BLER Status": latest.get(
                "pdsch_bler_residual_status", ""
            ),
            "NR RLF BLER Source Code": latest.get("rlf_bler_source_code", ""),
            "NR RLF BLER Source Field": latest.get("rlf_bler_source_field", ""),
            "NR RLF BLER Purpose": latest.get("rlf_bler_purpose", ""),
            "NR RLF BLER Window": latest.get("rlf_bler_window", ""),
            "NR RLF BLER Source Sequence": _format_number(
                latest.get("rlf_bler_source_sequence")
            ),
            "NR PUSCH TX Type": latest.get("pusch_tx_type", ""),
            "NR PUSCH New TB": _format_number(latest.get("pusch_new_tb")),
            "NR PUSCH HARQ ID": _format_number(latest.get("pusch_harq_id")),
            "NR PUSCH RV Index": _format_number(latest.get("pusch_rv_index")),
            "NR PUSCH Frame": _format_number(latest.get("pusch_frame")),
            "NR PUSCH Slot": _format_number(latest.get("pusch_slot")),
            "NR PUSCH TX Source Sequence": _format_number(
                latest.get("pusch_tx_source_sequence")
            ),
            "NR PUSCH DCI NDI": _format_number(latest.get("pusch_dci_ndi")),
            "NR PUSCH DCI RV": _format_number(latest.get("pusch_dci_rv")),
            "NR PUSCH DCI HARQ ID": _format_number(
                latest.get("pusch_dci_harq_id")
            ),
            "NR PUSCH DCI Frame": _format_number(latest.get("pusch_dci_frame")),
            "NR PUSCH DCI Slot": _format_number(latest.get("pusch_dci_slot")),
            "NR PUSCH DCI Source Sequence": _format_number(
                latest.get("pusch_dci_source_sequence")
            ),
            "NR PUSCH UCI HARQ ACK Bits": _format_number(
                latest.get("pusch_harq_ack_bits")
            ),
            "NR PUSCH UCI HARQ NACK Bits": _format_number(
                latest.get("pusch_harq_nack_bits")
            ),
            "NR PUSCH UCI HARQ Value": latest.get("pusch_uci_harq_value", ""),
            "NR PUSCH UCI HARQ ID": _format_number(latest.get("pusch_uci_harq_id")),
            "NR PUSCH UCI CRC Status Raw": latest.get(
                "pusch_uci_crc_status_raw", ""
            ),
            "NR PUSCH UCI CRC Valid": _format_number(
                latest.get("pusch_uci_crc_valid")
            ),
            "NR PUSCH UCI CRC Late": _format_number(
                latest.get("pusch_uci_crc_late")
            ),
            "NR PUSCH UCI PDSCH Valid": _format_number(
                latest.get("pusch_uci_pdsch_valid")
            ),
            "NR PUSCH UCI Source Sequence": _format_number(
                latest.get("pusch_uci_source_sequence")
            ),
            "NR PUSCH BLER Source Code": latest.get("pusch_bler_source_code", ""),
            "NR PUSCH BLER Source Field": latest.get("pusch_bler_source_field", ""),
            "NR PUSCH BLER Source Sequence": _format_number(
                latest.get("pusch_bler_source_sequence")
            ),
            "NR PUSCH BLER Window Samples": _format_number(
                latest.get("pusch_bler_window_samples")
            ),
            "NR PUSCH BLER Window Successes": _format_number(
                latest.get("pusch_bler_window_successes")
            ),
            "NR PUSCH BLER Window Errors": _format_number(
                latest.get("pusch_bler_window_errors")
            ),
            "NR PUSCH BLER Window": latest.get("pusch_bler_window", ""),
            "NR PUSCH BLER Valid": _format_number(
                latest.get("pusch_bler_valid")
            ),
            "NR PUSCH BLER Calculated": _format_number(
                int(bool(latest.get("pusch_bler_calculated")))
            ),
            "NR Bit Error Rate[%]": _format_number(
                latest.get("bit_error_rate_pct")
            ),
            "NR Retransmission Count": _format_number(
                latest.get("retransmission_count")
            ),
            "NR UL RB Count": _format_number(latest.get("ul_rb_count")),
            "NR DL RB Count": _format_number(latest.get("dl_rb_count")),
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
        """Write the newest throttled row immediately, if one is pending."""
        with self._state_lock:
            if self._pending_row is None:
                return False
            self._write_pending_locked(time.monotonic())
            return True

    def _write_pending_locked(self, now: float) -> None:
        if self._pending_row is None:
            return
        if self._writer is None or self._file is None:
            raise RuntimeError("metrics CSV writer is not open")
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


class MetricsWriterFanout:
    """Forward decoded DM metric records to multiple CSV writers."""

    def __init__(self, *writers: MetricsCsvWriter):
        self.writers = tuple(writer for writer in writers if writer is not None)

    def write(self, record: DecodedRecord) -> bool:
        wrote = False
        for writer in self.writers:
            wrote = writer.write(record) or wrote
        return wrote

    def update_pusch_bler(self, result: AutocomPuschBlerResult) -> None:
        for writer in self.writers:
            writer.update_pusch_bler(result)


def _format_number(value: object) -> str:
    if value is None or value == "":
        return ""
    if isinstance(value, (int, float)):
        return f"{value:g}"
    return str(value)


def _bler_event_timestamp_ns(value: str | None, receive_time_ns: int) -> int:
    """Prefer a plausible modem event timestamp; otherwise use packet arrival."""
    if not value:
        return receive_time_ns
    text = value.strip()
    parsed: datetime | None = None
    for candidate in (text.replace("Z", "+00:00"), text):
        try:
            parsed = datetime.fromisoformat(candidate)
            break
        except ValueError:
            pass
    if parsed is None:
        for fmt in ("%Y %m %d  %H:%M:%S.%f", "%Y %m %d %H:%M:%S.%f"):
            try:
                parsed = datetime.strptime(text, fmt)
                break
            except ValueError:
                pass
    if parsed is None:
        return receive_time_ns
    if parsed.tzinfo is None:
        # Qualcomm modem message timestamps in the captured spool are UTC.
        parsed = parsed.replace(tzinfo=timezone.utc)
    event_time_ns = int(parsed.timestamp() * 1_000_000_000)
    # Some decoder schemas emit placeholder/stale times. Do not let those
    # timestamps corrupt a rolling window; packet arrival is the safe fallback.
    if abs(event_time_ns - receive_time_ns) > 60 * 1_000_000_000:
        return receive_time_ns
    return event_time_ns


def format_shanghai_timestamp(receive_time_ns: int | None) -> str | None:
    """Format a capture receive time as an ISO-8601 Shanghai timestamp."""
    if receive_time_ns is None or receive_time_ns <= 0:
        return None
    timestamp = datetime.fromtimestamp(receive_time_ns / 1_000_000_000, tz=SHANGHAI_TZ)
    return timestamp.isoformat(timespec="microseconds")


def format_decoder_timestamp(value: str | None) -> str | None:
    """Normalize a decoder timestamp to ISO-8601 with the Shanghai offset.

    Decoder XML commonly uses ``YYYY MM DD  HH:MM:SS.fff`` without a zone.
    When a capture receive time is unavailable (for example, replaying an
    older decoded record), that legacy value is treated as Shanghai local
    time instead of being emitted as an ambiguous naive timestamp.
    """
    if not value:
        return None
    text = value.strip()
    parsed: datetime | None = None
    for candidate in (text.replace("Z", "+00:00"), text):
        try:
            parsed = datetime.fromisoformat(candidate)
            break
        except ValueError:
            pass
    if parsed is None:
        for fmt in ("%Y %m %d  %H:%M:%S.%f", "%Y %m %d %H:%M:%S.%f"):
            try:
                parsed = datetime.strptime(text, fmt)
                break
            except ValueError:
                pass
    if parsed is None:
        return text
    if parsed.tzinfo is None:
        parsed = parsed.replace(tzinfo=SHANGHAI_TZ)
    else:
        parsed = parsed.astimezone(SHANGHAI_TZ)
    return parsed.isoformat(timespec="microseconds")


def next_csv_timestamp(
    source_timestamp: object,
    previous: datetime | None,
    interval_sec: float,
) -> tuple[str, datetime | None]:
    """Return a source timestamp or a fixed-step output timestamp.

    Throttled metric CSVs use a logical output clock so a burst of queued DM
    frames cannot make all rows appear at the beginning of the capture.
    Unthrottled writers retain the original source timestamp.
    """
    source_text = str(source_timestamp or "")
    if interval_sec <= 0:
        return source_text, previous

    if previous is None:
        parsed = _parse_csv_timestamp(source_text) or datetime.now(SHANGHAI_TZ)
    else:
        parsed = previous + timedelta(seconds=interval_sec)
    return parsed.isoformat(timespec="microseconds"), parsed


def _parse_csv_timestamp(value: str) -> datetime | None:
    text = value.strip()
    if not text:
        return None
    for candidate in (text.replace("Z", "+00:00"), text):
        try:
            parsed = datetime.fromisoformat(candidate)
        except ValueError:
            continue
        return parsed if parsed.tzinfo is not None else parsed.replace(tzinfo=SHANGHAI_TZ)
    return None


def merge_metrics_csvs(
    dm_path: str | Path,
    at_path: str | Path,
    output_path: str | Path,
) -> int:
    """Merge DM and AT metric CSVs into one timestamp-ordered CSV."""
    rows: list[tuple[tuple[object, ...], dict[str, str]]] = []
    for source_index, source_path in enumerate((Path(dm_path), Path(at_path))):
        if not source_path.exists():
            continue
        with source_path.open(encoding="utf-8-sig", newline="") as stream:
            for ordinal, row in enumerate(csv.DictReader(stream)):
                normalized = {column: row.get(column, "") or "" for column in CSV_COLUMNS}
                rows.append((_timestamp_sort_key(normalized, source_index, ordinal), normalized))

    rows.sort(key=lambda item: item[0])
    destination = Path(output_path)
    destination.parent.mkdir(parents=True, exist_ok=True)
    with destination.open("w", encoding="utf-8-sig", newline="") as stream:
        writer = csv.DictWriter(stream, fieldnames=list(CSV_COLUMNS))
        writer.writeheader()
        writer.writerows(row for _key, row in rows)
    return len(rows)


def _timestamp_sort_key(
    row: Mapping[str, str], source_index: int, ordinal: int
) -> tuple[object, ...]:
    text = (row.get("timestamp") or row.get("MsgTime") or "").strip()
    parsed: datetime | None = None
    if text:
        candidates = (text.replace("Z", "+00:00"), text)
        for candidate in candidates:
            try:
                parsed = datetime.fromisoformat(candidate)
                break
            except ValueError:
                pass
        if parsed is None:
            for fmt in ("%Y %m %d  %H:%M:%S.%f", "%Y %m %d %H:%M:%S.%f"):
                try:
                    parsed = datetime.strptime(text, fmt)
                    break
                except ValueError:
                    pass
    if parsed is not None:
        if parsed.tzinfo is None:
            parsed = parsed.replace(tzinfo=SHANGHAI_TZ)
        return (0, parsed.timestamp(), source_index, ordinal)
    return (1, text, source_index, ordinal)
