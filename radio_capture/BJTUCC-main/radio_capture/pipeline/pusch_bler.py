"""Experimental PUSCH BLER evidence extracted only from NR B883/B885 logs.

The Qualcomm records available to the main decoder expose transmission type,
HARQ id, NDI and RV, but no UL-SCH CRC PASS/FAIL result.  Consequently this
module deliberately reports a retransmission-ratio candidate.  It must not be
promoted to the production ``NR PUSCH BLER[%]`` field until it has been
validated against AutoCom's proprietary UL_BLER_Avg result on the same trace.
"""

from __future__ import annotations

import re
import xml.etree.ElementTree as ET
from dataclasses import dataclass


PUSCH_BLER_MSG_CODES = frozenset({0xB883, 0xB885})


def _text(node: ET.Element, name: str) -> str | None:
    child = node.find(f"./{name}")
    if child is None or child.text is None:
        return None
    value = child.text.strip()
    return value or None


def _integer(node: ET.Element, name: str) -> int | None:
    value = _text(node, name)
    if value is None:
        return None
    match = re.search(r"-?\d+", value)
    return int(match.group(0)) if match else None


def _xml_root(detail: bytes | str) -> ET.Element | None:
    if isinstance(detail, bytes):
        text = detail.decode("utf-8", errors="replace")
    else:
        text = detail
    try:
        return ET.fromstring(text)
    except ET.ParseError:
        return None


@dataclass(frozen=True)
class UlDciContext:
    harq_id: int
    ndi: int | None
    rv: int | None
    frame: int | None
    slot: int | None
    sequence: int


@dataclass
class PuschBlerBucket:
    second_ns: int
    last_sequence: int = 0
    b883_messages: int = 0
    b885_messages: int = 0
    b885_ul_dci_records: int = 0
    pusch_tx_samples: int = 0
    new_tx_count: int = 0
    retx_count: int = 0
    unknown_tx_count: int = 0
    dci_match_count: int = 0

    @property
    def candidate_ul_bler_pct(self) -> float | None:
        """Return RE_TX / (NEW_TX + RE_TX), not a CRC-derived BLER."""

        denominator = self.new_tx_count + self.retx_count
        if denominator == 0:
            return None
        return self.retx_count * 100.0 / denominator


class PuschBlerTracker:
    """Aggregate B883 transmission evidence and B885 DCI context per second."""

    def __init__(self) -> None:
        self._bucket: PuschBlerBucket | None = None
        self._dci_by_harq: dict[int, UlDciContext] = {}

    def reset(self) -> None:
        self._bucket = None
        self._dci_by_harq.clear()

    def feed(
        self,
        *,
        msg_code: int,
        detail: bytes | str,
        receive_time_ns: int,
        sequence: int,
    ) -> list[PuschBlerBucket]:
        if msg_code not in PUSCH_BLER_MSG_CODES:
            return []
        second_ns = (int(receive_time_ns) // 1_000_000_000) * 1_000_000_000
        completed: list[PuschBlerBucket] = []
        if self._bucket is None:
            self._bucket = PuschBlerBucket(second_ns=second_ns)
        elif second_ns != self._bucket.second_ns:
            if second_ns < self._bucket.second_ns:
                # A replay discontinuity must not leak HARQ state forward.
                self._dci_by_harq.clear()
            completed.append(self._bucket)
            self._bucket = PuschBlerBucket(second_ns=second_ns)

        bucket = self._bucket
        bucket.last_sequence = max(bucket.last_sequence, int(sequence))
        root = _xml_root(detail)
        if root is None:
            return completed

        if msg_code == 0xB885:
            bucket.b885_messages += 1
            for context in self._iter_ul_dci(root, sequence):
                bucket.b885_ul_dci_records += 1
                self._dci_by_harq[context.harq_id] = context
            return completed

        bucket.b883_messages += 1
        for record in root.findall(".//Table/Record"):
            marker = (_text(record, "Phychan_Bit_Mask") or "").upper()
            if "PUSCH" not in marker:
                continue
            tx_type = (_text(record, "TX_Type") or "").upper()
            tx_type = re.sub(r"^\(\d+\)\s*", "", tx_type)
            harq_id = _integer(record, "HARQ_ID")
            bucket.pusch_tx_samples += 1
            if tx_type == "NEW_TX":
                bucket.new_tx_count += 1
            elif tx_type == "RE_TX":
                bucket.retx_count += 1
            else:
                bucket.unknown_tx_count += 1
            if harq_id is not None and harq_id in self._dci_by_harq:
                bucket.dci_match_count += 1
        return completed

    def finish(self) -> list[PuschBlerBucket]:
        if self._bucket is None:
            return []
        completed = [self._bucket]
        self._bucket = None
        return completed

    @staticmethod
    def _iter_ul_dci(root: ET.Element, sequence: int):
        for group in root.findall("./Content/Record"):
            frame = _integer(group, "Frame")
            slot = _integer(group, "Slot")
            for record in group.findall("./Record"):
                dci_format = (_text(record, "DCI_Format") or "").upper()
                if "UL_0_" not in dci_format:
                    continue
                harq_id = _integer(record, "HARQ_ID")
                if harq_id is None:
                    continue
                yield UlDciContext(
                    harq_id=harq_id,
                    ndi=_integer(record, "NDI"),
                    rv=_integer(record, "RV"),
                    frame=frame,
                    slot=slot,
                    sequence=int(sequence),
                )
