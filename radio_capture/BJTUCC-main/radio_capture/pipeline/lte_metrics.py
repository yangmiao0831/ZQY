"""LTE metric extraction from decoded Qualcomm DM XML."""

from __future__ import annotations

import re
import xml.etree.ElementTree as ET
from dataclasses import dataclass


LTE_DM_METRIC_MSG_CODES = frozenset(
    {
        0xB0B4,  # LTE RLC statistics
        0xB0C0,  # LTE serving/physical channel identity
        0xB16C,  # LTE uplink grant/PUSCH detail
        0xB16D,  # LTE uplink grant/PUSCH detail
        0xB16E,  # LTE uplink RB allocation detail
        0xB172,  # LTE uplink HARQ/CRC detail
        0xB173,  # LTE downlink PDSCH/HARQ detail
    }
)


@dataclass(frozen=True)
class LteDmMetrics:
    timestamp: str | None = None
    earfcn_dl: float | None = None
    pci: float | None = None
    modulation: str | None = None
    mcs: float | None = None
    packet_loss_rate_pct: float | None = None
    bler_pct: float | None = None
    bit_error_rate_pct: float | None = None
    retransmission_count: float | None = None
    ul_rb_count: float | None = None
    dl_rb_count: float | None = None


def extract_lte_dm_metrics(
    detail: bytes | str | None, msg_code: int | None = None
) -> LteDmMetrics | None:
    """Extract LTE-only fields from one decoded DM XML payload.

    The extractor is intentionally conservative: CRC/HARQ fields are mapped to
    BLER/retransmission metrics, while BER stays empty unless the decoder XML
    exposes an explicit BER-like tag.
    """
    if not detail:
        return None
    try:
        text = detail.decode("utf-8", errors="replace") if isinstance(detail, bytes) else detail
        root = ET.fromstring(text)
    except ET.ParseError:
        return None

    explicit_ber = _first_number(
        root,
        "BER",
        "Bit_Error_Rate",
        "BitErrorRate",
        "Bit_Error_Rate_Pct",
    )
    metrics = LteDmMetrics(
        timestamp=_first_text(root, "Time"),
        earfcn_dl=_first_number(root, "EARFCN", "DL_EARFCN", "E-ARFCN"),
        pci=_first_number(root, "PCI", "Physical_Cell_ID", "Serving_Cell_ID"),
        modulation=_first_modulation(root),
        mcs=_first_number(root, "MCS", "MCS_Index", "MCSIndex"),
        packet_loss_rate_pct=_packet_loss_rate(root),
        bler_pct=_bler_pct(root),
        bit_error_rate_pct=explicit_ber
        if explicit_ber is not None
        else _bit_error_rate_pct(root),
        retransmission_count=_retransmission_count(root),
        ul_rb_count=_rb_count(root, msg_code, uplink=True),
        dl_rb_count=_rb_count(root, msg_code, uplink=False),
    )
    if any(value is not None for name, value in vars(metrics).items() if name != "timestamp"):
        return metrics
    return None


def _first_text(root: ET.Element, *names: str) -> str | None:
    for value in _iter_values(root, *names):
        text = value.strip()
        if text:
            return text
    return None


def _first_number(root: ET.Element, *names: str) -> float | None:
    for value in _iter_values(root, *names):
        number = _number(value)
        if number is not None:
            return number
    return None


def _numbers(root: ET.Element, *names: str) -> list[float]:
    values: list[float] = []
    for value in _iter_values(root, *names):
        number = _number(value)
        if number is not None:
            values.append(number)
    return values


def _iter_values(root: ET.Element, *names: str):
    wanted = {_normal_name(name) for name in names}
    for element in root.iter():
        if _normal_name(element.tag) in wanted and element.text is not None:
            yield element.text


def _normal_name(value: str) -> str:
    local = value.rsplit("}", 1)[-1]
    return re.sub(r"[^a-z0-9]", "", local.lower())


def _number(value: str) -> float | None:
    match = re.search(r"[-+]?\d+(?:\.\d+)?", value)
    if not match:
        return None
    number = float(match.group(0))
    return int(number) if number.is_integer() else number


def _first_modulation(root: ET.Element) -> str | None:
    text = _first_text(root, "Modulation_Type", "Modulation", "ModulationType")
    if not text:
        return None
    text = re.sub(r"^\s*\(\d+\)\s*", "", text).strip()
    text = text.replace("_", "")
    return text or None


def _packet_loss_rate(root: ET.Element) -> float | None:
    explicit = _first_number(root, "Packet_Loss_Rate", "PacketLossRate", "Packet_Loss_Rate_Pct")
    if explicit is not None:
        return explicit
    discarded = sum(_numbers(root, "Num_Discard_SDU", "Discarded_SDU", "Discard_SDU"))
    delivered = sum(_numbers(root, "Num_Data_Pdu", "Data_Pdu", "DataPdu"))
    total = discarded + delivered
    if total <= 0:
        return None
    return discarded * 100.0 / total


def _bit_error_rate_pct(root: ET.Element) -> float | None:
    errors = sum(_numbers(root, "Num_Error", "NumErrors", "Bit_Errors", "BitErrors"))
    payload_bytes = sum(_numbers(root, "Data_Pdu_Bytes", "DataPduBytes", "Payload_Bytes"))
    payload_bits = payload_bytes * 8
    if errors < 0 or payload_bits <= 0:
        return None
    return errors * 100.0 / payload_bits


def _bler_pct(root: ET.Element) -> float | None:
    crc_values = list(_iter_values(root, "CRC_Result", "CRCResult"))
    if crc_values:
        failures = sum(1 for value in crc_values if _is_crc_failure(value))
        return failures * 100.0 / len(crc_values)

    corrupt_values = list(_iter_values(root, "Corrupt_CRC", "CorruptCRC"))
    if corrupt_values:
        failures = sum(1 for value in corrupt_values if _is_true_text(value))
        return failures * 100.0 / len(corrupt_values)
    return None


def _is_crc_failure(value: str) -> bool:
    text = value.strip().lower()
    if "pass" in text or text in {"0", "(0)pass"}:
        return False
    if "fail" in text or "error" in text:
        return True
    number = _number(text)
    return bool(number and number != 1)


def _is_true_text(value: str) -> bool:
    text = value.strip().lower()
    return text.startswith("(1)") or text in {"1", "yes", "true"} or "yes" in text


def _retransmission_count(root: ET.Element) -> float | None:
    count = 0.0
    for value in _iter_values(root, "Tx_Type", "TxType"):
        if "retx" in value.lower() or "re-tx" in value.lower():
            count += 1
    for value in _numbers(root, "Retransmission_Index", "RetransmissionIndex"):
        if value > 0:
            count += 1
    count += sum(_numbers(root, "Num_PDU_HO_ReTx", "Num_Pdu_Ho_ReTx", "PDU_HO_ReTx"))
    for value in _iter_values(root, "Discarded_ReTx", "DiscardedReTx"):
        text = value.strip().lower()
        if text and "no_discard" not in text and text not in {"0", "(0)no"}:
            count += 1
    return count if count else None


def _rb_count(root: ET.Element, msg_code: int | None, *, uplink: bool) -> float | None:
    if uplink and msg_code not in {0xB16C, 0xB16D, 0xB16E}:
        return None
    if not uplink and msg_code != 0xB173:
        return None
    values = [
        value
        for value in _numbers(
            root,
            "Num_RBs",
            "NumRBs",
            "Num_RB",
            "Number_of_Resource_Blocks",
            "NumberOfResourceBlocks",
        )
        if value >= 0
    ]
    return max(values) if values else None
