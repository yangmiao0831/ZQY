"""Extract NR serving-cell metrics from Qualcomm decoder XML."""

from __future__ import annotations

import re
import xml.etree.ElementTree as ET
from dataclasses import dataclass


NR_METRIC_COLUMNS = (
    "MsgTime",
    "NR Band",
    "NR Bandwidth DL",
    "NR BWP Active Bandwidth DL[MHz]",
    "NR BWP Bandwidth[MHz]",
    "NR SSB ARFCN DL",
    "NR PCI",
    "NR SSB RSRQ[dB]",
    "NR SSB RSSI[dBm]",
    "NR SSB RSRP[dBm]",
    "NR SSB RSRP BestBeam[dBm]",
    "NR SSB RSRP SecondBeam[dBm]",
    "NR SSB SINR[dB]",
    "NR Modulation",
    "NR MCS",
    "NR Packet Loss Rate[%]",
    "NR BLER[%]",
    "NR PDSCH BLER[%]",
    "NR PUSCH BLER[%]",
    "NR BLER (direction unknown)[%]",
    "NR BLER Direction Unknown Source Code",
    "NR BLER Direction Unknown Source Field",
    "NR BLER Direction Unknown Source Sequence",
    "NR RLF InSync Filtered BLER[%]",
    "NR RLF OutSync Filtered BLER[%]",
    "NR RLF BLER Sample Count",
    "NR RLF BLER SFN Start",
    "NR RLF BLER SFN End",
    "NR BLER Source Code",
    "NR BLER Source Field",
    "NR BLER Purpose",
    "NR BLER Window",
    "NR BLER Source Sequence",
    "NR PDSCH CRC Status",
    "NR PDSCH HARQ ID",
    "NR PDSCH NDI",
    "NR PDSCH RV",
    "NR PDSCH TX Type",
    "NR PDSCH Retransmission Count",
    "NR PDSCH CRC Records In Message",
    "NR PDSCH CRC Record Index",
    "NR PDSCH Event Source Sequence",
    "NR PDSCH BLER Basis",
    "NR PDSCH BLER Window[sec]",
    "NR PDSCH CRC Window Samples",
    "NR PDSCH CRC Window Errors",
    "NR PDSCH Initial BLER 1s[%]",
    "NR PDSCH Initial BLER 1s Sample Count",
    "NR PDSCH Initial BLER 1s Errors",
    "NR PDSCH Initial BLER 1s Valid",
    "NR PDSCH Initial BLER 1s Source Sequence",
    "NR PDSCH Initial BLER 5s[%]",
    "NR PDSCH Initial BLER 5s Sample Count",
    "NR PDSCH Initial BLER 5s Errors",
    "NR PDSCH Initial BLER 5s Valid",
    "NR PDSCH Initial BLER 5s Source Sequence",
    "NR PDSCH Initial BLER 10s[%]",
    "NR PDSCH Initial BLER 10s Sample Count",
    "NR PDSCH Initial BLER 10s Errors",
    "NR PDSCH Initial BLER 10s Valid",
    "NR PDSCH Initial BLER 10s Source Sequence",
    "NR PDSCH BLER Minimum Samples",
    "NR PDSCH BLER Calculated",
    "NR PDSCH BLER Source Code",
    "NR PDSCH BLER Source Field",
    "NR PDSCH BLER Source Sequence",
    "NR PDSCH BLER Source Record Index",
    "NR PDSCH Residual BLER Status",
    "NR RLF BLER Source Code",
    "NR RLF BLER Source Field",
    "NR RLF BLER Purpose",
    "NR RLF BLER Window",
    "NR RLF BLER Source Sequence",
    "NR PUSCH TX Type",
    "NR PUSCH New TB",
    "NR PUSCH HARQ ID",
    "NR PUSCH RV Index",
    "NR PUSCH Frame",
    "NR PUSCH Slot",
    "NR PUSCH TX Source Sequence",
    "NR PUSCH DCI NDI",
    "NR PUSCH DCI RV",
    "NR PUSCH DCI HARQ ID",
    "NR PUSCH DCI Frame",
    "NR PUSCH DCI Slot",
    "NR PUSCH DCI Source Sequence",
    "NR PUSCH UCI HARQ ACK Bits",
    "NR PUSCH UCI HARQ NACK Bits",
    "NR PUSCH UCI HARQ Value",
    "NR PUSCH UCI HARQ ID",
    "NR PUSCH UCI CRC Status Raw",
    "NR PUSCH UCI CRC Valid",
    "NR PUSCH UCI CRC Late",
    "NR PUSCH UCI PDSCH Valid",
    "NR PUSCH UCI Source Sequence",
    "NR PUSCH BLER Source Code",
    "NR PUSCH BLER Source Field",
    "NR PUSCH BLER Source Sequence",
    "NR PUSCH BLER Window Samples",
    "NR PUSCH BLER Window Successes",
    "NR PUSCH BLER Window Errors",
    "NR PUSCH BLER Window",
    "NR PUSCH BLER Valid",
    "NR PUSCH BLER Calculated",
    "NR Bit Error Rate[%]",
    "NR Retransmission Count",
    "NR UL RB Count",
    "NR DL RB Count",
)

# Qualcomm NR log codes that have proven useful for the metrics-only CSV path.
# In metrics-only mode, the router uses this set as a decode allowlist to avoid
# spending most of the stop/drain time on verbose, non-metric QWinLog messages.
NR_METRIC_MSG_CODES = frozenset(
    {
        0xB821,  # NR RRC OTA, used for RRC BWP configuration state
        0xB825,  # NR5G RRC serving/configuration, band/BWP/bandwidth/RB config
        0xB842,  # NR5G RLC DL statistics, RB/drop/error counters
        0xB84D,  # NR5G RLC UL statistics, RB/reTx/drop counters
        0xB860,  # NR5G PDCP DL statistics, discard/RX counters
        0xB868,  # NR5G PDCP UL statistics, reTx/NACK counters
        0xB883,  # NR5G PUSCH detail, modulation/MCS/UL RB
        0xB885,  # NR5G DCI details, including UL HARQ/NDI/RV scheduling fields
        0xB887,  # NR5G PDSCH status, modulation/MCS/DL RB/BLER/reTx
        0xB89B,  # NR5G UCI/HARQ feedback details, not a UL-SCH CRC result
        0xB8C9,  # NR5G RSSI measurements
        0xB959,  # NR5G BLER measurements
        0xB97F,  # NR5G serving cell/beam RSRP/RSRQ/RSSI/SINR
        0xB9A7,  # NR5G ML1 serving/configuration, band/bandwidth state
    }
)

_NUMBER_RE = re.compile(r"[-+]?\d+(?:\.\d+)?")
_MISSING = {"", "NA", "N/A", "NULL", "NONE", "--", "-"}


@dataclass(frozen=True)
class BlerEvent:
    """One transport-block BLER outcome decoded from a single source record."""

    timestamp: str | None
    direction: str
    channel: str
    harq_id: int | None
    ndi: int | None
    rv: int | None
    tx_type: str | None
    crc_status: str | None
    source_code: str
    source_field: str
    record_index: int


@dataclass(frozen=True)
class NrMetrics:
    band: str | None
    pci: int | None
    ssb_rsrp_dbm: float | None
    ssb_sinr_db: float | None
    timestamp: str | None = None
    bandwidth_dl: float | None = None
    bwp_active_bandwidth_dl_mhz: float | None = None
    bwp_bandwidth_mhz: float | None = None
    ssb_arfcn_dl: int | None = None
    ssb_rsrq_db: float | None = None
    ssb_rssi_dbm: float | None = None
    ssb_rsrp_bestbeam_dbm: float | None = None
    ssb_rsrp_secondbeam_dbm: float | None = None
    modulation: str | None = None
    mcs: int | None = None
    packet_loss_rate_pct: float | None = None
    bler_pct: float | None = None
    pdsch_bler_pct: float | None = None
    pusch_bler_pct: float | None = None
    unclassified_bler_pct: float | None = None
    rlf_insync_filtered_bler_pct: float | None = None
    rlf_outsync_filtered_bler_pct: float | None = None
    rlf_bler_sample_count: int | None = None
    rlf_bler_sfn_start: int | None = None
    rlf_bler_sfn_end: int | None = None
    rlf_bler_purpose: str | None = None
    rlf_bler_window: str | None = None
    rlf_bler_source_field: str | None = None
    bler_source_code: str | None = None
    bler_source_field: str | None = None
    bler_purpose: str | None = None
    bler_window: str | None = None
    pdsch_crc_status: str | None = None
    pdsch_harq_id: int | None = None
    pdsch_ndi: int | None = None
    pdsch_rv: int | None = None
    pdsch_tx_type: str | None = None
    pdsch_retransmission_count: int | None = None
    pdsch_crc_record_count: int | None = None
    pdsch_crc_record_index: int | None = None
    bler_events: tuple[BlerEvent, ...] = ()
    pusch_tx_type: str | None = None
    pusch_new_tb: int | None = None
    pusch_harq_id: int | None = None
    pusch_rv_index: int | None = None
    pusch_frame: int | None = None
    pusch_slot: int | None = None
    pusch_dci_ndi: int | None = None
    pusch_dci_rv: int | None = None
    pusch_dci_harq_id: int | None = None
    pusch_dci_frame: int | None = None
    pusch_dci_slot: int | None = None
    pusch_harq_ack_bits: int | None = None
    pusch_harq_nack_bits: int | None = None
    pusch_uci_harq_value: str | None = None
    pusch_uci_harq_id: int | None = None
    pusch_uci_crc_status_raw: str | None = None
    pusch_uci_crc_valid: int | None = None
    pusch_uci_crc_late: int | None = None
    pusch_uci_pdsch_valid: int | None = None
    bit_error_rate_pct: float | None = None
    retransmission_count: int | None = None
    ul_rb_count: int | None = None
    dl_rb_count: int | None = None


def extract_nr_metrics(
    detail: bytes | str, msg_code: int | None = None
) -> NrMetrics | None:
    """Extract one serving-cell row from a decoder XML detail payload.

    The current Qualcomm log uses ``0xB97F`` with Layer/Cell/beam nodes.  Band
    is not emitted as a named field, so it is derived from the NR raster ARFCN.
    SINR is read only from explicit SINR fields; unrelated SNR fields are not
    treated as SSB SINR.
    """
    if not detail:
        return None
    text = detail.decode("utf-8", errors="replace") if isinstance(detail, bytes) else detail
    try:
        root = ET.fromstring(text)
    except ET.ParseError:
        return None

    timestamp = _clean(root.findtext("./Header/Time"))
    layer = _find_serving_layer(root)
    if layer is not None:
        return _extract_serving_metrics(root, layer, timestamp, msg_code)

    return _extract_configuration_metrics(root, timestamp, msg_code)


def extract_decoded_timestamp(detail: bytes | str) -> str | None:
    """Return the decoder timestamp for a valid DM XML record."""
    if not detail:
        return None
    text = detail.decode("utf-8", errors="replace") if isinstance(detail, bytes) else detail
    try:
        root = ET.fromstring(text)
    except ET.ParseError:
        return None
    return _clean(root.findtext("./Header/Time"))


def extract_decoded_content(detail: bytes | str) -> str | None:
    """Return the decoder's real ``<Content>`` XML subtree.

    Keeping this separate from metric extraction is intentional: a message
    may have useful decoder content even when it does not contain one of the
    serving-cell fields.  The returned value includes the ``<Content>`` tag
    so CSV/JSON consumers can distinguish it from a flattened metric.
    """
    if not detail:
        return None
    text = detail.decode("utf-8", errors="replace") if isinstance(detail, bytes) else detail
    try:
        root = ET.fromstring(text)
    except ET.ParseError:
        return None
    content = root.find("./Content")
    if content is None:
        return None
    return ET.tostring(content, encoding="unicode", short_empty_elements=True)


def _extract_serving_metrics(
    root: ET.Element,
    layer: ET.Element,
    timestamp: str | None,
    msg_code: int | None,
) -> NrMetrics | None:

    serving_pci = _int_value(_first_text(layer, "Serving_Cell_PCI"))
    serving_ssb = _int_value(_first_text(layer, "Serving_SSB"))
    arfcn = _int_value(_first_text(layer, "Raster_ARFCN", "EARFCN"))

    cell = _find_cell(layer, serving_pci)
    if cell is None:
        cell = layer.find(".//Cell")
    pci = serving_pci if serving_pci is not None else _int_value(_first_text(cell, "PCI"))

    beam = _find_beam(cell, serving_ssb)
    rsrp = _first_metric_number(
        beam,
        "Nr2NrFilterTxBeamRSRP",
        "SSB_RSRP",
        "RSRP1",
        metric="rsrp",
    )
    if rsrp is None:
        rsrp = _first_metric_number(
            cell, "CellQualityRSRP", "SSB_RSRP", "RSRP", metric="rsrp"
        )

    sinr = _first_metric_number(
        beam,
        "SSB_SINR",
        "SSB_SINR_dB",
        "Nr2NrFilterTxBeamSINR",
        "SINR",
        "CellQualitySINR",
        metric="sinr",
    )
    if sinr is None:
        sinr = _first_metric_number(
            cell,
            "SSB_SINR",
            "SSB_SINR_dB",
            "SINR",
            "CellQualitySINR",
            metric="sinr",
        )
    if sinr is None:
        sinr = _first_metric_number(
            root, "SSB_SINR", "SSB_SINR_dB", metric="sinr"
        )

    rsrq = _first_metric_number(
        beam, "Nr2NrFilterTxBeamRSRQ", "SSB_RSRQ", "RSRQ", metric="rsrq"
    )
    if rsrq is None:
        rsrq = _first_metric_number(
            cell, "CellQualityRSRQ", "SSB_RSRQ", "RSRQ", metric="rsrq"
        )
    rssi = _first_number(
        beam,
        "Nr2NrFilterTxBeamRSSI",
        "SSB_RSSI",
        "RSSI",
    )
    if rssi is None:
        rssi = _first_number(cell, "CellQualityRSSI", "SSB_RSSI", "RSSI")
    if rssi is None:
        rssi = _first_number(root, "SSB_RSSI", "NR_SSB_RSSI", "RSSI")
    if rssi is None:
        rssi_values = [value for value in _all_numbers(root, "fRssi") if value > -255]
        rssi = max(rssi_values) if rssi_values else None

    beam_rsrps = [
        value
        for beam_node in (cell.findall("./beam") if cell is not None else [])
        for value in [
            _first_metric_number(
                beam_node,
                "Nr2NrFilterTxBeamRSRP",
                "SSB_RSRP",
                "RSRP1",
                metric="rsrp",
            )
        ]
        if value is not None
    ]
    beam_rsrps.sort(reverse=True)
    best_beam = beam_rsrps[0] if beam_rsrps else rsrp
    second_beam = beam_rsrps[1] if len(beam_rsrps) > 1 else None

    # Some decoder versions expose the selected pair directly at Layer level.
    pair0 = _first_metric_number(root, "ServingBMRSRP4RR2ndPair0", metric="rsrp")
    pair1 = _first_metric_number(root, "ServingBMRSRP4RR2ndPair1", metric="rsrp")
    if pair0 is not None:
        best_beam = pair0
    if pair1 is not None:
        second_beam = pair1

    band = _format_band(_first_text(layer, "NR_Band", "NRBand", "Band", "BandName"))
    if band is None and arfcn is not None:
        band = nr_band_from_arfcn(arfcn)

    if band is None and pci is None and rsrp is None and sinr is None:
        if not _has_link_metrics(root, msg_code):
            return None
    return NrMetrics(
        band=band,
        pci=pci,
        ssb_rsrp_dbm=rsrp,
        ssb_sinr_db=sinr,
        timestamp=timestamp,
        ssb_arfcn_dl=arfcn,
        ssb_rsrq_db=rsrq,
        ssb_rssi_dbm=rssi,
        ssb_rsrp_bestbeam_dbm=best_beam,
        ssb_rsrp_secondbeam_dbm=second_beam,
        **_extract_link_metrics(root, msg_code),
    )


def _extract_bler_metrics(
    root: ET.Element, msg_code: int | None
) -> dict[str, object]:
    """Keep directional BLER separate from Qualcomm's unclassified RLF data.

    0xB959 carries per-SFN InSync/OutSync filtered BLER rows with Purpose=RLF,
    but no PDSCH/PUSCH label and no time duration.  Such values are retained
    in dedicated columns and never promoted to the generic BLER column.
    """
    pdsch_value, pdsch_field = _first_named_number(
        root, "PDSCH_BLER", "PDSCH_BLER_pct", "PDSCHBlockErrorRate", "DL_BLER"
    )
    pusch_value, pusch_field = _first_named_number(
        root, "PUSCH_BLER", "PUSCH_BLER_pct", "PUSCHBlockErrorRate", "UL_BLER"
    )
    generic_value, generic_field = _first_named_number(
        root, "BLER", "BlockErrorRate", "Block_Error_Rate"
    )

    purpose = _first_descendant_text(root, "Purpose")
    if purpose is not None:
        purpose = re.sub(r"^\(\d+\)\s*", "", purpose).strip()
    is_rlf_table = msg_code == 0xB959 or (purpose or "").upper() == "RLF"

    if generic_value is not None and not is_rlf_table:
        if msg_code == 0xB887 and pdsch_value is None:
            pdsch_value, pdsch_field = generic_value, generic_field
        elif msg_code == 0xB883 and pusch_value is None:
            pusch_value, pusch_field = generic_value, generic_field

    in_sync_values = _all_descendant_numbers(root, "InsyncFilteredBLER")
    out_sync_values = _all_descendant_numbers(root, "OutsyncFilteredBLER")
    sfn_values = _all_descendant_numbers(root, "SFN")
    in_sync_mean = sum(in_sync_values) / len(in_sync_values) if in_sync_values else None
    out_sync_mean = sum(out_sync_values) / len(out_sync_values) if out_sync_values else None

    if is_rlf_table:
        # Generic RLF values are not directional BLER.
        generic_value = None
        generic_field = None
    rlf_in_sync = in_sync_mean if is_rlf_table else None
    rlf_out_sync = out_sync_mean if is_rlf_table else None
    if in_sync_values or out_sync_values:
        filtered_value = in_sync_mean if in_sync_mean is not None else out_sync_mean
        filtered_field = (
            "InsyncFilteredBLER" if in_sync_mean is not None else "OutsyncFilteredBLER"
        )
        if msg_code == 0xB887 and not is_rlf_table and pdsch_value is None:
            pdsch_value, pdsch_field = filtered_value, filtered_field
        elif not is_rlf_table and pdsch_value is None and pusch_value is None:
            generic_value, generic_field = filtered_value, filtered_field

    unknown_value = generic_value if pdsch_value is None and pusch_value is None else None
    legacy_value = (
        pdsch_value
        if pdsch_value is not None and pusch_value is None
        else pusch_value
        if pusch_value is not None and pdsch_value is None
        else unknown_value
    )

    source_fields = [
        field
        for field in (pdsch_field, pusch_field, generic_field if unknown_value is not None else None)
        if field is not None
    ]
    source_code = f"0x{msg_code:04X}" if msg_code is not None else None

    pdsch_crc_status = None
    pdsch_harq_id = None
    pdsch_ndi = None
    pdsch_rv = None
    pdsch_tx_type = None
    pdsch_retransmissions = None
    pdsch_crc_events: list[BlerEvent] = []
    pusch_ack_bits = None
    pusch_nack_bits = None
    pusch_tx_type = None
    pusch_new_tb = None
    pusch_harq_id = None
    pusch_rv_index = None
    pusch_frame = None
    pusch_slot = None
    pusch_uci_harq_value = None
    pusch_uci_harq_id = None
    pusch_uci_crc_status_raw = None
    pusch_uci_crc_valid = None
    pusch_uci_crc_late = None
    pusch_uci_pdsch_valid = None
    pusch_dci_ndi = None
    pusch_dci_rv = None
    pusch_dci_harq_id = None
    pusch_dci_frame = None
    pusch_dci_slot = None
    if msg_code == 0xB887:
        records = [
            record
            for record in root.findall(".//Table/Record")
            if _first_descendant_text(record, "CRC_status", "CRCStatus")
            is not None
        ]
        # Older decoder variants may flatten a single record directly under
        # Content. Preserve support for that shape while expanding Table rows.
        if not records and _first_descendant_text(
            root, "CRC_status", "CRCStatus"
        ) is not None:
            records = [root]

        event_time = _clean(root.findtext("./Header/Time"))
        source_code_text = f"0x{msg_code:04X}"
        for record_index, record in enumerate(records, start=1):
            raw_crc_status = _first_descendant_text(
                record, "CRC_status", "CRCStatus"
            )
            normalized_crc = re.sub(
                r"^\(\d+\)\s*", "", raw_crc_status or ""
            ).strip().upper()
            crc_status = (
                "PASS"
                if "PASS" in normalized_crc
                else "FAIL"
                if "FAIL" in normalized_crc
                else None
            )
            harq_id = _first_descendant_int(
                record, "Harq_Id", "HARQ_ID", "HARQId"
            )
            ndi = _first_descendant_int(record, "NDI")
            rv = _first_descendant_int(record, "RV")
            retransmissions = _first_descendant_int(
                record, "Num_ReTx", "Num_ReTX", "Retx_Count", "Num_Retransmissions"
            )
            new_tx_flag = _first_descendant_int(record, "NewTxFlag")
            if new_tx_flag == 1:
                tx_type = "NEW_TX"
            elif (
                new_tx_flag is None
                and retransmissions == 0
                and rv == 0
            ):
                # Some older decoder schemas omit NewTxFlag; only use the
                # conservative RV/Num_ReTx fallback when both are explicit.
                tx_type = "NEW_TX"
            elif new_tx_flag == 0 or (retransmissions or 0) > 0 or (rv or 0) != 0:
                tx_type = "RE_TX"
            else:
                tx_type = None
            pdsch_crc_events.append(
                BlerEvent(
                    timestamp=event_time,
                    direction="DL",
                    channel="PDSCH",
                    harq_id=harq_id,
                    ndi=ndi,
                    rv=rv,
                    tx_type=tx_type,
                    crc_status=crc_status,
                    source_code=source_code_text,
                    source_field="CRC_status",
                    record_index=record_index,
                )
            )

        if pdsch_crc_events:
            first_event = pdsch_crc_events[0]
            pdsch_crc_status = first_event.crc_status
            pdsch_harq_id = first_event.harq_id
            pdsch_ndi = first_event.ndi
            pdsch_rv = first_event.rv
            pdsch_tx_type = first_event.tx_type
            pdsch_retransmissions = _first_descendant_int(
                records[0], "Num_ReTx", "Num_ReTX", "Retx_Count", "Num_Retransmissions"
            )
    elif msg_code == 0xB883:
        pusch_tx_type = _first_descendant_text(root, "TX_Type")
        if pusch_tx_type is not None:
            pusch_tx_type = re.sub(r"^\(\d+\)\s*", "", pusch_tx_type).strip()
        pusch_new_tb = _first_descendant_int(root, "L2_new_TB")
        pusch_harq_id = _first_descendant_int(root, "HARQ_ID", "Harq_ID")
        pusch_rv_index = _first_descendant_int(root, "RV_Index")
        pusch_frame = _first_descendant_int(root, "Frame")
        pusch_slot = _first_descendant_int(root, "Slot")
        pusch_ack_bits = _first_descendant_int(
            root, "Num_HARQ_ACK_Bits", "HARQ_ACK_Bits", "Num_ACK_Bits"
        )
        pusch_nack_bits = _first_descendant_int(
            root, "Num_HARQ_NACK_Bits", "HARQ_NACK_Bits", "Num_NACK_Bits"
        )
    elif msg_code == 0xB89B:
        uci_record = next(
            (
                record
                for record in root.findall(".//Table/Record")
                if (_first_descendant_text(record, "Channel") or "").upper() == "PUSCH"
            ),
            None,
        )
        if uci_record is not None:
            pusch_ack_bits = _first_descendant_int(
                uci_record, "Total_HARQ_ACKBits"
            )
            pusch_uci_harq_value = _first_descendant_text(uci_record, "HARQ")
            pusch_uci_harq_id = _first_descendant_int(uci_record, "HARQ_id")
            pusch_uci_crc_status_raw = _first_descendant_text(
                uci_record, "CRC_Status"
            )
            pusch_uci_crc_valid = _first_descendant_int(
                uci_record, "Is_CRC_Valid"
            )
            pusch_uci_crc_late = _first_descendant_int(
                uci_record, "Is_CRC_Late"
            )
            pusch_uci_pdsch_valid = _first_descendant_int(
                uci_record, "Is_PDSCH_Valid"
            )
    elif msg_code == 0xB885:
        ul_dci = next(
            (
                node
                for node in root.iter()
                if (node.findtext("DCI_Format") or "").upper().find("UL") >= 0
            ),
            None,
        )
        if ul_dci is not None:
            pusch_dci_ndi = _first_descendant_int(ul_dci, "NDI")
            pusch_dci_rv = _first_descendant_int(ul_dci, "RV")
            pusch_dci_harq_id = _first_descendant_int(ul_dci, "HARQ_ID")
            pusch_dci_frame = _first_descendant_int(root, "Frame")
            pusch_dci_slot = _first_descendant_int(root, "Slot")

    has_directional_bler = any(
        value is not None
        for value in (pdsch_value, pusch_value, unknown_value)
    )

    if has_directional_bler:
        window = "decoder BLER field; averaging window not reported"
    else:
        window = None
    rlf_window = (
        f"mean over per-SFN table ({len(sfn_values)} rows); temporal duration not reported"
        if is_rlf_table and (in_sync_values or out_sync_values)
        else None
    )
    rlf_source_fields = []
    if is_rlf_table and in_sync_values:
        rlf_source_fields.append("InsyncFilteredBLER")
    if is_rlf_table and out_sync_values:
        rlf_source_fields.append("OutsyncFilteredBLER")

    return {
        "bler_pct": legacy_value,
        "pdsch_bler_pct": pdsch_value,
        "pusch_bler_pct": pusch_value,
        "unclassified_bler_pct": unknown_value,
        "rlf_insync_filtered_bler_pct": rlf_in_sync,
        "rlf_outsync_filtered_bler_pct": rlf_out_sync,
        "rlf_bler_sample_count": len(sfn_values) if is_rlf_table and sfn_values else None,
        "rlf_bler_sfn_start": int(sfn_values[0]) if is_rlf_table and sfn_values else None,
        "rlf_bler_sfn_end": int(sfn_values[-1]) if is_rlf_table and sfn_values else None,
        "bler_source_code": source_code if has_directional_bler else None,
        "bler_source_field": ";".join(dict.fromkeys(source_fields)) or None,
        "bler_purpose": purpose if has_directional_bler else None,
        "bler_window": window,
        "rlf_bler_purpose": purpose if is_rlf_table and (in_sync_values or out_sync_values) else None,
        "rlf_bler_window": rlf_window,
        "rlf_bler_source_field": ";".join(rlf_source_fields) or None,
        "pdsch_crc_status": pdsch_crc_status,
        "pdsch_harq_id": pdsch_harq_id,
        "pdsch_ndi": pdsch_ndi,
        "pdsch_rv": pdsch_rv,
        "pdsch_tx_type": pdsch_tx_type,
        "pdsch_retransmission_count": pdsch_retransmissions,
        "pdsch_crc_record_count": len(pdsch_crc_events) or None,
        "pdsch_crc_record_index": (
            pdsch_crc_events[0].record_index if pdsch_crc_events else None
        ),
        "bler_events": tuple(pdsch_crc_events),
        "pusch_tx_type": pusch_tx_type,
        "pusch_new_tb": pusch_new_tb,
        "pusch_harq_id": pusch_harq_id,
        "pusch_rv_index": pusch_rv_index,
        "pusch_frame": pusch_frame,
        "pusch_slot": pusch_slot,
        "pusch_dci_ndi": pusch_dci_ndi,
        "pusch_dci_rv": pusch_dci_rv,
        "pusch_dci_harq_id": pusch_dci_harq_id,
        "pusch_dci_frame": pusch_dci_frame,
        "pusch_dci_slot": pusch_dci_slot,
        "pusch_harq_ack_bits": pusch_ack_bits,
        "pusch_harq_nack_bits": pusch_nack_bits,
        "pusch_uci_harq_value": pusch_uci_harq_value,
        "pusch_uci_harq_id": pusch_uci_harq_id,
        "pusch_uci_crc_status_raw": pusch_uci_crc_status_raw,
        "pusch_uci_crc_valid": pusch_uci_crc_valid,
        "pusch_uci_crc_late": pusch_uci_crc_late,
        "pusch_uci_pdsch_valid": pusch_uci_pdsch_valid,
    }


def _first_named_number(
    element: ET.Element, *names: str
) -> tuple[float | None, str | None]:
    wanted = {_normalize_tag(name) for name in names}
    for node in element.iter():
        tag = _tag_name(node)
        if _normalize_tag(tag) not in wanted:
            continue
        match = _NUMBER_RE.search(_clean(node.text) or "")
        if match:
            return float(match.group(0)), tag
    return None, None


def _extract_link_metrics(
    root: ET.Element, msg_code: int | None = None
) -> dict[str, object]:
    """Extract PHY/MAC performance fields using common Qualcomm XML names.

    Different DM log definitions use direction prefixes and slightly
    different spellings.  Keep the aliases here so the CSV contract remains
    stable when the decoder DLL changes its field labels.
    """
    modulation = _format_modulation(
        _first_descendant_text(
            root,
            "Modulation",
            "ModulationType",
            "Modulation_Type",
            "DL_Modulation",
            "UL_Modulation",
            "MCS_Modulation",
            "Modulation_Order",
            "MCS_Table",
            "Mod_Type",
        )
    )
    mcs = _first_descendant_int(
        root,
        "MCS",
        "MCS_Index",
        "MCSIndex",
        "DL_MCS",
        "UL_MCS",
    )
    packet_loss_rate = _first_descendant_number(
        root,
        "PacketLossRate",
        "Packet_Loss_Rate",
        "PacketLoss_Rate",
        "PacketLoss",
        "LostPacketRate",
        "Packet_Error_Rate",
    )
    bler_metrics = _extract_bler_metrics(root, msg_code)
    bit_error_rate = _first_descendant_number(
        root,
        "BER",
        "BitErrorRate",
        "Bit_Error_Rate",
        "BitError_Rate",
        "DL_BER",
        "UL_BER",
    )
    if bit_error_rate is None:
        bit_error_rate = _inferred_zero_bit_error_rate(root)
    retransmissions = _first_descendant_int(
        root,
        "RetransmissionCount",
        "Retransmission_Count",
        "HARQ_Retransmission_Count",
        "HARQ_Retransmissions",
        "Num_Retransmissions",
        "ReTxCount",
        "Retx_Count",
        "Num_ReTx",
        "Num_ReTX_PDU",
        "Total_ReTx_PDUs",
    )
    ul_rb = _first_descendant_int(
        root,
        "UL_RB_Count",
        "UL_RB_Number",
        "UL_Num_RB",
        "UL_Resource_Blocks",
        "UL_Resource_Block_Count",
        "Num_UL_RB",
        "PUSCH_RB",
    )
    if ul_rb is None and _has_direction_marker(root, "PUSCH"):
        ul_rb = _first_descendant_int(root, "Num_RBs", "NumRbs", "Num_RB")
    dl_rb = _first_descendant_int(
        root,
        "DL_RB_Count",
        "DL_RB_Number",
        "DL_Num_RB",
        "DL_Resource_Blocks",
        "DL_Resource_Block_Count",
        "Num_DL_RB",
        "PDSCH_RB",
    )
    if dl_rb is None and (
        _has_direction_marker(root, "PDSCH")
        or _first_descendant_text(root, "Num_PDSCH_Status", "Is_PDSCH_Valid") is not None
    ):
        dl_rb = _first_descendant_int(root, "Num_RBs", "NumRbs", "Num_RB")
    if ul_rb is None and dl_rb is None:
        rb_count = _first_descendant_int(root, "Num_RB_Logged", "Num_Active_RB")
        if rb_count is not None:
            ul_rb = rb_count
            dl_rb = rb_count
    if packet_loss_rate is None:
        packet_loss_rate = _computed_packet_loss_rate(root)
    return {
        "modulation": modulation,
        "mcs": mcs,
        "packet_loss_rate_pct": packet_loss_rate,
        **bler_metrics,
        "bit_error_rate_pct": bit_error_rate,
        "retransmission_count": retransmissions,
        "ul_rb_count": ul_rb,
        "dl_rb_count": dl_rb,
    }


def _has_link_metrics(root: ET.Element, msg_code: int | None = None) -> bool:
    return any(
        value is not None for value in _extract_link_metrics(root, msg_code).values()
    )


def has_link_metric_values(metrics: NrMetrics) -> bool:
    return any(
        getattr(metrics, name) is not None
        for name in (
            "modulation",
            "mcs",
            "packet_loss_rate_pct",
            "bler_pct",
            "pdsch_bler_pct",
            "pusch_bler_pct",
            "unclassified_bler_pct",
            "rlf_insync_filtered_bler_pct",
            "rlf_outsync_filtered_bler_pct",
            "pdsch_crc_status",
            "pdsch_ndi",
            "pdsch_rv",
            "pdsch_crc_record_count",
            "pusch_harq_ack_bits",
            "pusch_harq_nack_bits",
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
    )


def _format_modulation(value: str | None) -> str | None:
    if value is None:
        return None
    text = re.sub(r"^\(\d+\)", "", value.strip()).strip()
    match = re.search(r"(64|256)\s*QAM", text, flags=re.IGNORECASE)
    if match:
        return f"{match.group(1)}QAM"
    if text in {"64", "256"}:
        return f"{text}QAM"
    return text


def _has_direction_marker(root: ET.Element, direction: str) -> bool:
    expected = direction.upper()
    for node in root.iter():
        tag = node.tag.upper()
        text = (node.text or "").upper()
        if expected in tag or expected in text:
            return True
    return False


def _computed_packet_loss_rate(root: ET.Element) -> float | None:
    dropped = _sum_descendant_numbers(
        root,
        "Total_Num_Discard_Packets",
        "Num_Discard_Packets",
        "WM_Dropped_Packets",
        "Current_WM_Drop_Packets",
    )
    received = _sum_descendant_numbers(root, "Num_RX_Packets")
    if dropped is None or received is None:
        return None
    total = dropped + received
    if total <= 0:
        return None
    return dropped * 100.0 / total


def _inferred_zero_bit_error_rate(root: ET.Element) -> float | None:
    """Infer a zero BER only from explicit no-error decoder evidence."""

    error_counts = _all_descendant_numbers(
        root,
        "NumIPPacketError",
        "NumPacketLengthError",
        "BitErrorCount",
        "Bit_Error_Count",
        "Num_Bit_Errors",
        "NumBitErrors",
    )
    if error_counts and all(value == 0 for value in error_counts):
        return 0.0

    crc_statuses = [
        value.upper()
        for value in _all_descendant_text(root, "CRC_status", "CRCStatus")
        if value
    ]
    if crc_statuses and all("PASS" in value for value in crc_statuses):
        return 0.0

    return None


def _sum_descendant_numbers(element: ET.Element | None, *names: str) -> float | None:
    if element is None:
        return None
    expected = {_normalize_tag(name) for name in names}
    values = []
    for node in element.iter():
        if _normalize_tag(node.tag) not in expected:
            continue
        match = _NUMBER_RE.search(_clean(node.text) or "")
        if match:
            values.append(float(match.group(0)))
    return sum(values) if values else None


def _all_descendant_numbers(element: ET.Element | None, *names: str) -> list[float]:
    if element is None:
        return []
    expected = {_normalize_tag(name) for name in names}
    values: list[float] = []
    for node in element.iter():
        if _normalize_tag(_tag_name(node)) not in expected:
            continue
        match = _NUMBER_RE.search(_clean(node.text) or "")
        if match:
            values.append(float(match.group(0)))
    return values


def _all_descendant_text(element: ET.Element | None, *names: str) -> list[str]:
    if element is None:
        return []
    expected = {_normalize_tag(name) for name in names}
    values: list[str] = []
    for node in element.iter():
        if _normalize_tag(_tag_name(node)) not in expected:
            continue
        value = _clean(node.text)
        if value is not None:
            values.append(value)
    return values


def _first_descendant_int(element: ET.Element | None, *names: str) -> int | None:
    value = _first_descendant_text(element, *names)
    if value is None:
        return None
    match = re.search(r"[-+]?\d+", value)
    return int(match.group(0)) if match else None


def _extract_configuration_metrics(
    root: ET.Element, timestamp: str | None, msg_code: int | None
) -> NrMetrics | None:
    """Extract fields carried by NR configuration/measurement log messages."""
    band = _first_descendant_text(root, "Band_Number", "NR_Band", "NRBand", "Band")
    band = _format_band(band)
    bandwidth = _bandwidth_mhz(
        _first_descendant_text(root, "DL_Bandwith", "DL_Bandwidth", "DL_Carrier_Bandwidth")
    )
    ssb_arfcn = _int_value(
        _first_descendant_text(root, "SSB_Arfcn", "SSB_ARFCN", "NR_SSB_ARFCN_DL")
    )
    active_bwp = _explicit_bandwidth_mhz(
        root,
        "Active_DL_BWP_Bandwidth",
        "Active_DL_BWP_BW",
        "Active_Downlink_BWP_Bandwidth",
        "DL_BWP_Active_Bandwidth",
    )
    bwp_bandwidth = _explicit_bandwidth_mhz(
        root,
        "DL_BWP_Bandwidth",
        "Downlink_BWP_Bandwidth",
        "BWP_Bandwidth",
        "BWP_BW",
    )
    rssi_values = [
        value
        for value in _all_numbers(root, "fRssi", "SSB_RSSI", "NR_SSB_RSSI")
        if value > -255
    ]
    rssi = max(rssi_values) if rssi_values else None
    pci = _int_value(_first_descendant_text(root, "Serving_Cell_PCI", "PCI"))
    rsrp = _first_metric_number(
        root, "SSB_RSRP", "NR_SSB_RSRP", "RSRP", metric="rsrp"
    )
    rsrq = _first_metric_number(
        root, "SSB_RSRQ", "NR_SSB_RSRQ", "RSRQ", metric="rsrq"
    )
    sinr = _first_metric_number(
        root, "SSB_SINR", "SSB_SINR_dB", "NR_SSB_SINR", "SINR", metric="sinr"
    )
    link_metrics = _extract_link_metrics(root, msg_code)

    if all(
        value is None
        for value in (
            band,
            bandwidth,
            ssb_arfcn,
            active_bwp,
            bwp_bandwidth,
            pci,
            rsrp,
            rsrq,
            sinr,
            rssi,
            *link_metrics.values(),
        )
    ):
        return None
    return NrMetrics(
        band=band,
        pci=pci,
        ssb_rsrp_dbm=rsrp,
        ssb_sinr_db=sinr,
        timestamp=timestamp,
        bandwidth_dl=bandwidth,
        bwp_active_bandwidth_dl_mhz=active_bwp,
        bwp_bandwidth_mhz=bwp_bandwidth,
        ssb_arfcn_dl=ssb_arfcn,
        ssb_rsrq_db=rsrq,
        ssb_rssi_dbm=rssi,
        **link_metrics,
    )


def nr_band_from_arfcn(arfcn: int) -> str | None:
    """Return the common NR band for an NR-ARFCN.

    ARFCN ranges can overlap between 3GPP bands.  The frequency-based mapping
    covers common deployments and resolves the 3300-3800 MHz range as n78,
    which is the band represented by the current device capture.
    """
    if 0 <= arfcn <= 599999:
        frequency_mhz = arfcn * 0.005
    elif 600000 <= arfcn <= 2016666:
        frequency_mhz = 3000.0 + (arfcn - 600000) * 0.015
    elif 2016667 <= arfcn <= 3279165:
        frequency_mhz = 24250.08 + (arfcn - 2016667) * 0.06
    else:
        return None

    ranges = (
        (3300.0, 3800.0, "n78"),
        (3300.0, 4200.0, "n77"),
        (4400.0, 5000.0, "n79"),
        (2496.0, 2690.0, "n41"),
        (2300.0, 2400.0, "n40"),
        (2570.0, 2620.0, "n38"),
        (2110.0, 2200.0, "n66"),
        (2110.0, 2170.0, "n1"),
        (1805.0, 1880.0, "n3"),
        (869.0, 894.0, "n5"),
        (925.0, 960.0, "n8"),
        (791.0, 821.0, "n20"),
        (758.0, 803.0, "n28"),
        (617.0, 652.0, "n71"),
    )
    for low, high, band in ranges:
        if low <= frequency_mhz <= high:
            return band
    return None


def _find_serving_layer(root: ET.Element) -> ET.Element | None:
    for layer in root.iter("Layer"):
        if layer.find(".//Cell") is not None and (
            layer.find("Serving_Cell_PCI") is not None
            or layer.find("Raster_ARFCN") is not None
            or layer.find("EARFCN") is not None
        ):
            return layer
    return None


def _find_cell(layer: ET.Element, pci: int | None) -> ET.Element | None:
    cells = layer.findall("./Cell")
    if pci is None:
        return cells[0] if cells else None
    for cell in cells:
        if _int_value(_first_text(cell, "PCI")) == pci:
            return cell
    return None


def _find_beam(cell: ET.Element | None, ssb: int | None) -> ET.Element | None:
    if cell is None:
        return None
    beams = cell.findall("./beam")
    if ssb is None:
        return beams[0] if beams else None
    for beam in beams:
        if _int_value(_first_text(beam, "SSB_Index")) == ssb:
            return beam
    return None


def _first_text(element: ET.Element | None, *names: str) -> str | None:
    if element is None:
        return None
    for name in names:
        value = _clean(element.findtext(name))
        if value is not None:
            return value
    return None


def _first_number(element: ET.Element | None, *names: str) -> float | None:
    value = _first_text(element, *names)
    if value is None:
        return None
    match = _NUMBER_RE.search(value)
    return float(match.group(0)) if match else None


def _first_metric_number(
    element: ET.Element | None, *names: str, metric: str
) -> float | None:
    """Read one radio metric and normalize supported 3GPP report indices.

    DM XML mixes already-scaled values with report indices.  Negative values
    and values inside the physical reporting range are treated as engineering
    values. Positive RSRP values are invalid and are not converted. RSRQ/SINR
    report indices remain supported.
    """
    if element is None:
        return None
    wanted = [_normalize_tag(name) for name in names]
    for name in wanted:
        for node in element.iter():
            tag = _normalize_tag(_tag_name(node))
            has_index_suffix = any(
                tag == name + suffix
                for suffix in ("index", "range", "reportedvalue")
            )
            if tag != name and not has_index_suffix:
                continue
            text = _clean(node.text)
            if text is None:
                continue
            match = _NUMBER_RE.search(text)
            if match is None:
                continue
            value = float(match.group(0))
            explicitly_indexed = (
                has_index_suffix
                or "index" in tag
                or "range" in tag
                or "reportedvalue" in tag
            )
            normalized = _normalize_reported_measurement(
                value,
                metric,
                explicitly_indexed=explicitly_indexed,
                explicit_unit=tag.endswith("dbm") or tag.endswith("db"),
            )
            if normalized is not None:
                return normalized
    return None


def _normalize_reported_measurement(
    value: float,
    metric: str,
    *,
    explicitly_indexed: bool = False,
    explicit_unit: bool = False,
) -> float | None:
    """Validate engineering values and convert supported RSRQ/SINR indices.

    For report indices, the standard describes quantization intervals.  The
    returned scalar uses the conventional interval representative used by
    this capture's CSV contract: RSRQ=index/2-43 dB and SINR=index/2-23 dB.
    Positive RSRP values, including index-like values, are treated as invalid
    and omitted instead of being converted to negative dBm.
    """
    limits = {
        "rsrp": (-156.0, -31.0),
        "rsrq": (-43.0, 20.0),
        "sinr": (-23.0, 40.0),
    }
    bounds = limits.get(metric)
    if bounds is None:
        return value
    low, high = bounds

    if metric == "rsrp" and value > 0:
        return None

    if explicit_unit:
        return value if low <= value <= high else None

    is_report_index = explicitly_indexed or value > high
    if is_report_index:
        if not value.is_integer() or not 0 <= value <= 127:
            return None
        index = int(value)
        if metric == "rsrp":
            # RSRP index-to-dBm conversion is intentionally disabled. Treat
            # index-like inputs as anomalous and leave the CSV field blank.
            return None
        if metric == "rsrq":
            return -43.0 if index == 0 else min(index * 0.5 - 43.0, 20.0)
        return -23.0 if index == 0 else min(index * 0.5 - 23.0, 40.0)

    # A value below the standardized floor cannot be a valid engineering
    # measurement; do not turn it into a plausible-looking index conversion.
    if value < low:
        return None
    return value


def _first_descendant_text(element: ET.Element | None, *names: str) -> str | None:
    if element is None:
        return None
    wanted = {_normalize_tag(name) for name in names}
    for node in element.iter():
        if _normalize_tag(_tag_name(node)) in wanted:
            value = _clean(node.text)
            if value is not None:
                return value
    return None


def _first_descendant_number(element: ET.Element | None, *names: str) -> float | None:
    value = _first_descendant_text(element, *names)
    if value is None:
        return None
    match = _NUMBER_RE.search(value)
    return float(match.group(0)) if match else None


def _all_numbers(element: ET.Element | None, *names: str) -> list[float]:
    if element is None:
        return []
    wanted = set(names)
    values: list[float] = []
    for node in element.iter():
        if _tag_name(node) not in wanted:
            continue
        match = _NUMBER_RE.search(_clean(node.text) or "")
        if match:
            values.append(float(match.group(0)))
    return values


def _explicit_bandwidth_mhz(element: ET.Element, *names: str) -> float | None:
    wanted = set(names)
    for node in element.iter():
        if _tag_name(node) in wanted:
            value = _bandwidth_mhz(_clean(node.text))
            if value is not None:
                return value
    return None


def _bandwidth_mhz(value: str | None) -> float | None:
    if value is None:
        return None
    matches = re.findall(
        r"([-+]?\d+(?:\.\d+)?)\s*(GHZ|MHZ|KHZ|HZ)",
        value,
        flags=re.IGNORECASE,
    )
    if matches:
        number_text, unit = matches[-1]
        number = float(number_text)
        unit = unit.upper()
        if unit == "GHZ":
            number *= 1000.0
        elif unit == "KHZ":
            number /= 1000.0
        elif unit == "HZ":
            number /= 1_000_000.0
        return int(number) if number.is_integer() else number

    # Some decoder versions emit a numeric bandwidth without a unit.  Keep a
    # conservative fallback so large raw-Hz values are not silently dropped,
    # while small values like ``100`` remain interpreted as MHz.
    matches = _NUMBER_RE.findall(value)
    if not matches:
        return None
    number = float(matches[-1])
    if abs(number) >= 1_000_000:
        number /= 1_000_000.0
    elif abs(number) >= 1_000:
        number /= 1000.0
    return int(number) if number.is_integer() else number


def _format_band(value: str | None) -> str | None:
    if value is None:
        return None
    match = re.search(r"(?:N|NR5G\s*BAND\s*)?(\d+)", value, flags=re.IGNORECASE)
    if match is None:
        return value
    return f"n{match.group(1)}"


def _tag_name(element: ET.Element) -> str:
    return element.tag.rsplit("}", 1)[-1]


def _normalize_tag(value: str) -> str:
    """Compare decoder field names independent of case/separators."""
    return re.sub(r"[^a-z0-9]", "", value.lower())


def _int_value(value: str | None) -> int | None:
    if value is None:
        return None
    match = _NUMBER_RE.search(value)
    return int(match.group(0)) if match else None


def _clean(value: str | None) -> str | None:
    if value is None:
        return None
    value = value.strip()
    return None if value.upper() in _MISSING else value


# Kept as a named tuple to make the 3300-3800 priority explicit and readable.
n78 = (3300.0, 3800.0)
