"""Tests for NR metric extraction and CSV persistence."""

from __future__ import annotations

import csv
from unittest.mock import patch

from radio_capture.models import DecodedRecord
from radio_capture.pipeline.bwp import (
    RrcBwpTracker,
    bwp_bandwidth_mhz,
    decode_location_and_bandwidth,
)
from radio_capture.pipeline.metrics import (
    extract_decoded_timestamp,
    extract_decoded_content,
    extract_nr_metrics,
    nr_band_from_arfcn,
)
from radio_capture.pipeline.metrics_sink import (
    CSV_COLUMNS,
    MetricsCsvWriter,
    MetricsWriterFanout,
    format_decoder_timestamp,
    format_shanghai_timestamp,
    merge_metrics_csvs,
)


DETAIL = """<QualcommMessage><Header><Time>2026 08 27  02:18:59.968</Time></Header>
<Content><Layer><Raster_ARFCN>627264</Raster_ARFCN><Serving_Cell_PCI>298</Serving_Cell_PCI>
<Serving_SSB>4</Serving_SSB><Cell><PCI>297</PCI><CellQualityRSRP>-66.78</CellQualityRSRP></Cell>
<Cell><PCI>298</PCI><CellQualityRSRP>-67.68</CellQualityRSRP><beam><SSB_Index>4</SSB_Index>
<Nr2NrFilterTxBeamRSRP>-67.68</Nr2NrFilterTxBeamRSRP></beam></Cell></Layer></Content>
</QualcommMessage>"""

CONFIG_DETAIL = """<QualcommMessage><Header><Time>2026 08 27  02:18:59.900</Time></Header>
<Content><Band_Number>78</Band_Number><DL_Arfcn>636664</DL_Arfcn>
<SSB_Arfcn>633984</SSB_Arfcn><DL_Carrier_Bandwidth>(14)100MHZ</DL_Carrier_Bandwidth>
<Active_DL_BWP_Bandwidth>80MHZ</Active_DL_BWP_Bandwidth>
<BWP_Bandwidth>100MHZ</BWP_Bandwidth></Content></QualcommMessage>"""

RSSI_DETAIL = """<QualcommMessage><Header><Time>2026 08 27  02:18:59.950</Time></Header>
<Content><fRssi>-256.00</fRssi><fRssi>-34.50</fRssi><fRssi>-48.75</fRssi></Content>
</QualcommMessage>"""

LINK_PERFORMANCE_DETAIL = """<QualcommMessage><Header><Time>2026 08 27  02:19:00.000</Time></Header>
<Content><DL_Modulation>256 QAM</DL_Modulation><MCS_Index>27</MCS_Index>
<Packet_Loss_Rate>1.25</Packet_Loss_Rate><Block_Error_Rate>3.5</Block_Error_Rate>
<Bit_Error_Rate>0.04</Bit_Error_Rate><HARQ_Retransmission_Count>6</HARQ_Retransmission_Count>
<UL_Resource_Block_Count>24</UL_Resource_Block_Count>
<DL_Resource_Block_Count>96</DL_Resource_Block_Count></Content></QualcommMessage>"""

QWINLOG_UL_PHY_DETAIL = """<QualcommMessage><Header><Time>2026 09 03  14:03:41.100</Time></Header>
<Content><Phychan_Bit_Mask>PUSCH</Phychan_Bit_Mask><PUSCH>--</PUSCH>
<HARQ_ID>0</HARQ_ID><RV_Index>0</RV_Index><MCS>25</MCS>
<RB_Start>4</RB_Start><Num_RBs>4</Num_RBs><MCS_Table>(1)256QAM</MCS_Table>
<Modulation_Order>(4)256QAM</Modulation_Order></Content></QualcommMessage>"""

QWINLOG_DL_PHY_DETAIL = """<QualcommMessage><Header><Time>2026 09 03  14:03:42.100</Time></Header>
<Content><Num_PDSCH_Status>1</Num_PDSCH_Status><MCS>0</MCS><NumRbs>16</NumRbs>
<Harq_Id>15</Harq_Id><CRC_status>(1)CRC_PASS</CRC_status><Num_ReTx>0</Num_ReTx>
<Mod_Type>(0)QPSK</Mod_Type><InsyncFilteredBLER>0.00</InsyncFilteredBLER>
</Content></QualcommMessage>"""

QWINLOG_PDCP_DETAIL = """<QualcommMessage><Header><Time>2026 09 03  14:03:43.100</Time></Header>
<Content><Num_RB_Logged>4</Num_RB_Logged><Total_Num_Discard_Packets>2</Total_Num_Discard_Packets>
<Num_RX_Packets>198</Num_RX_Packets></Content></QualcommMessage>"""

QWINLOG_RLC_ERROR_COUNTER_DETAIL = """<QualcommMessage><Header><Time>2026 09 03  14:03:44.100</Time></Header>
<Content><Num_RB>4</Num_RB><Dropped_PDU_Bytes>0</Dropped_PDU_Bytes>
<NumIPPacketError>0</NumIPPacketError><NumPacketLengthError>0</NumPacketLengthError>
</Content></QualcommMessage>"""

RRC_BWP_CONFIG_DETAIL = """<QualcommMessage><Header><Time>2026 09 04  08:11:34.980</Time></Header>
<Content><L3MessageContent><DL-DCCH-Message><message><c1><rrcReconfiguration>
<criticalExtensions><rrcReconfiguration><nonCriticalExtension>
<masterCellGroup>00</masterCellGroup></nonCriticalExtension></rrcReconfiguration>
</criticalExtensions></rrcReconfiguration></c1></message></DL-DCCH-Message></L3MessageContent>
<CellGroupConfig><cellGroupId>0</cellGroupId><spCellConfig><spCellConfigDedicated>
<firstActiveDownlinkBWP-Id>1</firstActiveDownlinkBWP-Id>
<defaultDownlinkBWP-Id>2</defaultDownlinkBWP-Id>
<downlinkBWP-ToAddModList>
<BWP-Downlink><bwp-Id>1</bwp-Id><bwp-Common><genericParameters>
<locationAndBandwidth>16499</locationAndBandwidth>
<subcarrierSpacing><kHz30 /></subcarrierSpacing>
</genericParameters></bwp-Common></BWP-Downlink>
<BWP-Downlink><bwp-Id>2</bwp-Id><bwp-Common><genericParameters>
<locationAndBandwidth>1099</locationAndBandwidth>
<subcarrierSpacing><kHz30 /></subcarrierSpacing>
</genericParameters></bwp-Common></BWP-Downlink>
</downlinkBWP-ToAddModList>
</spCellConfigDedicated></spCellConfig></CellGroupConfig></Content></QualcommMessage>"""


def test_extracts_serving_nr_metrics():
    metrics = extract_nr_metrics(DETAIL)
    assert metrics is not None
    assert metrics.band == "n78"
    assert metrics.pci == 298
    assert metrics.ssb_rsrp_dbm == -67.68
    assert metrics.ssb_sinr_db is None
    assert metrics.timestamp == "2026 08 27  02:18:59.968"


def test_maps_current_nr_arfcn_to_n78():
    assert nr_band_from_arfcn(627264) == "n78"


def test_maps_nr_arfcn_after_first_band_range_without_crashing():
    assert nr_band_from_arfcn(693334) == "n79"


def test_extracts_timestamp_from_header_only_dm():
    detail = (
        "<QualcommMessage><Header><Time>2026 08 31 07:42:50.109</Time>"
        "</Header><Content /></QualcommMessage>"
    )
    assert extract_decoded_timestamp(detail) == "2026 08 31 07:42:50.109"


def test_extracts_real_decoder_content_xml():
    content = extract_decoded_content(DETAIL)
    assert content is not None
    assert content.startswith("<Content>")
    assert "<Serving_Cell_PCI>298</Serving_Cell_PCI>" in content
    assert "<Nr2NrFilterTxBeamRSRP>-67.68</Nr2NrFilterTxBeamRSRP>" in content


def test_writes_csv_with_empty_missing_sinr(tmp_path):
    path = tmp_path / "nr_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert writer.write(
            DecodedRecord("session", 1, 0xB97F, 0, 0, detail=DETAIL.encode("utf-8"))
        )
    finally:
        writer.close()
    with path.open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))
    assert tuple(rows[0].keys()) == CSV_COLUMNS
    assert rows[0]["NR Band"] == "n78"
    assert rows[0]["NR PCI"] == "298"
    assert rows[0]["NR SSB RSRP[dBm]"] == "-67.68"
    assert rows[0]["NR SSB RSRP BestBeam[dBm]"] == "-67.68"
    assert rows[0]["NR SSB SINR[dB]"] == ""


def test_merges_dm_configuration_rssi_and_beam_metrics(tmp_path):
    path = tmp_path / "nr_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert not writer.write(
            DecodedRecord("session", 1, 0xB825, 0, 0, detail=CONFIG_DETAIL.encode())
        )
        assert not writer.write(
            DecodedRecord("session", 2, 0xB8C9, 0, 0, detail=RSSI_DETAIL.encode())
        )
        assert writer.write(
            DecodedRecord("session", 3, 0xB97F, 0, 0, detail=DETAIL.encode())
        )
    finally:
        writer.close()

    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["MsgTime"] == "2026-08-27T02:18:59.968000+08:00"
    assert row["NR Band"] == "n78"
    assert row["NR Bandwidth DL"] == "100"
    assert row["NR BWP Active Bandwidth DL[MHz]"] == "80"
    assert row["NR BWP Bandwidth[MHz]"] == "100"
    assert row["NR SSB ARFCN DL"] == "627264"
    assert row["NR PCI"] == "298"
    assert row["NR SSB RSRQ[dB]"] == ""
    assert row["NR SSB RSSI[dBm]"] == "-34.5"
    assert row["NR SSB RSRP[dBm]"] == "-67.68"
    assert row["NR SSB RSRP BestBeam[dBm]"] == "-67.68"
    assert row["NR SSB RSRP SecondBeam[dBm]"] == ""


def test_normalizes_bandwidth_units_to_mhz_in_dm_metrics(tmp_path):
    detail = """<QualcommMessage><Header><Time>2026 09 04  10:00:00.000</Time></Header>
    <Content><Band_Number>78</Band_Number><DL_Bandwidth>100000000Hz</DL_Bandwidth>
    <Active_DL_BWP_Bandwidth>100000kHz</Active_DL_BWP_Bandwidth>
    <BWP_Bandwidth>0.1GHz</BWP_Bandwidth></Content></QualcommMessage>"""
    metrics = extract_nr_metrics(detail, 0xB825)
    assert metrics is not None
    assert metrics.bandwidth_dl == 100
    assert metrics.bwp_active_bandwidth_dl_mhz == 100
    assert metrics.bwp_bandwidth_mhz == 100

    path = tmp_path / "dm_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert not writer.write(
            DecodedRecord("session", 1, 0xB825, 0, 0, detail=detail.encode())
        )
        assert writer.write(
            DecodedRecord("session", 2, 0xB97F, 0, 0, detail=DETAIL.encode())
        )
    finally:
        writer.close()

    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["NR Bandwidth DL"] == "100"
    assert row["NR BWP Active Bandwidth DL[MHz]"] == "100"
    assert row["NR BWP Bandwidth[MHz]"] == "100"


def test_decodes_rrc_location_and_bandwidth_to_nominal_bwp_bandwidth():
    assert decode_location_and_bandwidth(16499) == (0, 217)
    assert bwp_bandwidth_mhz(217, 30) == 80
    assert decode_location_and_bandwidth(1099) == (0, 273)
    assert bwp_bandwidth_mhz(273, 30) == 100


def test_rrc_bwp_tracker_updates_active_bwp_from_b821_and_runtime_bwp_id():
    tracker = RrcBwpTracker()

    update = tracker.update(RRC_BWP_CONFIG_DETAIL, 0xB821)

    assert update is not None
    assert update.bwp_active_bandwidth_dl_mhz == 80
    assert update.bwp_bandwidth_mhz == 80

    switch = tracker.update(
        "<QualcommMessage><Header /><Content><BWP_Id>2</BWP_Id></Content></QualcommMessage>",
        0xB887,
    )

    assert switch is not None
    assert switch.bwp_active_bandwidth_dl_mhz == 100
    assert switch.bwp_bandwidth_mhz == 100


def test_rrc_bwp_tracker_does_not_treat_config_bwp_id_as_runtime_switch():
    tracker = RrcBwpTracker()
    detail = RRC_BWP_CONFIG_DETAIL.replace(
        "<firstActiveDownlinkBWP-Id>1</firstActiveDownlinkBWP-Id>",
        "<firstActiveDownlinkBWP-Id>2</firstActiveDownlinkBWP-Id>",
    )

    update = tracker.update(detail, 0xB821)

    assert update is not None
    assert update.bwp_active_bandwidth_dl_mhz == 100
    assert update.bwp_bandwidth_mhz == 100


def test_writer_carries_rrc_bwp_state_into_next_dm_measurement_row(tmp_path):
    path = tmp_path / "dm_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert not writer.write(
            DecodedRecord("session", 1, 0xB821, 0, 0, detail=RRC_BWP_CONFIG_DETAIL.encode())
        )
        assert writer.write(
            DecodedRecord("session", 2, 0xB97F, 0, 0, detail=DETAIL.encode())
        )
    finally:
        writer.close()

    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["NR BWP Active Bandwidth DL[MHz]"] == "80"
    assert row["NR BWP Bandwidth[MHz]"] == "80"


def test_extracts_all_four_radio_measurements_from_dm_serving_xml(tmp_path):
    detail = """<QualcommMessage><Header><Time>2026 08 27  02:18:59.968</Time></Header>
    <Content><Layer><Raster_ARFCN>627264</Raster_ARFCN><Serving_Cell_PCI>298</Serving_Cell_PCI>
    <Serving_SSB>4</Serving_SSB><Cell><PCI>298</PCI><CellQualityRSRP>-67.68</CellQualityRSRP>
    <CellQualityRSRQ>-10.5</CellQualityRSRQ><CellQualityRSSI>-48</CellQualityRSSI>
    <beam><SSB_Index>4</SSB_Index><Nr2NrFilterTxBeamRSRP>-67.68</Nr2NrFilterTxBeamRSRP>
    <Nr2NrFilterTxBeamRSRQ>-10.5</Nr2NrFilterTxBeamRSRQ>
    <Nr2NrFilterTxBeamRSSI>-48</Nr2NrFilterTxBeamRSSI>
    <Nr2NrFilterTxBeamSINR>18.25</Nr2NrFilterTxBeamSINR></beam></Cell></Layer></Content>
    </QualcommMessage>"""
    metrics = extract_nr_metrics(detail, 0xB97F)
    assert metrics is not None
    assert metrics.ssb_rsrp_dbm == -67.68
    assert metrics.ssb_rsrq_db == -10.5
    assert metrics.ssb_rssi_dbm == -48
    assert metrics.ssb_sinr_db == 18.25

    path = tmp_path / "nr_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        writer.write(DecodedRecord("session", 1, 0xB97F, 0, 0, detail=detail.encode()))
    finally:
        writer.close()
    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["NR SSB RSRP[dBm]"] == "-67.68"
    assert row["NR SSB RSRQ[dB]"] == "-10.5"
    assert row["NR SSB RSSI[dBm]"] == "-48"
    assert row["NR SSB SINR[dB]"] == "18.25"


def test_positive_rsrp_index_is_omitted_instead_of_converted(tmp_path):
    detail = """<QualcommMessage><Header><Time>2026 10 02  09:00:00.000</Time></Header>
    <Content><Layer><Raster_ARFCN>627264</Raster_ARFCN><Serving_Cell_PCI>297</Serving_Cell_PCI>
    <Serving_SSB>2</Serving_SSB><Cell><PCI>297</PCI><CellQualityRSRP>93</CellQualityRSRP>
    <beam><SSB_Index>2</SSB_Index><Nr2NrFilterTxBeamRSRP>93</Nr2NrFilterTxBeamRSRP></beam>
    <beam><SSB_Index>3</SSB_Index><Nr2NrFilterTxBeamRSRP>90</Nr2NrFilterTxBeamRSRP></beam>
    </Cell><ServingBMRSRP4RR2ndPair0>92</ServingBMRSRP4RR2ndPair0>
    <ServingBMRSRP4RR2ndPair1>88</ServingBMRSRP4RR2ndPair1></Layer></Content>
    </QualcommMessage>"""

    metrics = extract_nr_metrics(detail, 0xB97F)
    assert metrics is not None
    assert metrics.ssb_rsrp_dbm is None
    assert metrics.ssb_rsrp_bestbeam_dbm is None
    assert metrics.ssb_rsrp_secondbeam_dbm is None

    path = tmp_path / "dm_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert writer.write(
            DecodedRecord("session", 0, 0xB97F, 0, 0, detail=DETAIL.encode())
        )
        assert writer.write(
            DecodedRecord("session", 1, 0xB97F, 0, 0, detail=detail.encode())
        )
    finally:
        writer.close()
    with path.open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))
    assert rows[0]["NR SSB RSRP[dBm]"] == "-67.68"
    row = rows[1]
    assert row["NR SSB RSRP[dBm]"] == ""
    assert row["NR SSB RSRP BestBeam[dBm]"] == ""
    assert row["NR SSB RSRP SecondBeam[dBm]"] == ""


def test_extracts_dm_link_performance_metrics_and_writes_csv(tmp_path):
    metrics = extract_nr_metrics(LINK_PERFORMANCE_DETAIL, 0x1234)
    assert metrics is not None
    assert metrics.modulation == "256QAM"
    assert metrics.mcs == 27
    assert metrics.packet_loss_rate_pct == 1.25
    assert metrics.bler_pct == 3.5
    assert metrics.bit_error_rate_pct == 0.04
    assert metrics.retransmission_count == 6
    assert metrics.ul_rb_count == 24
    assert metrics.dl_rb_count == 96

    path = tmp_path / "dm_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert writer.write(
            DecodedRecord(
                "session", 9, 0x1234, 0, 0,
                detail=LINK_PERFORMANCE_DETAIL.encode(),
            )
        )
    finally:
        writer.close()
    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["NR Modulation"] == "256QAM"
    assert row["NR MCS"] == "27"
    assert row["NR Packet Loss Rate[%]"] == "1.25"
    assert row["NR BLER[%]"] == "3.5"
    assert row["NR Bit Error Rate[%]"] == "0.04"
    assert row["NR Retransmission Count"] == "6"
    assert row["NR UL RB Count"] == "24"
    assert row["NR DL RB Count"] == "96"


def test_extracts_real_qwinlog_phy_field_names():
    ul = extract_nr_metrics(QWINLOG_UL_PHY_DETAIL, 0xB883)
    assert ul is not None
    assert ul.modulation == "256QAM"
    assert ul.mcs == 25
    assert ul.ul_rb_count == 4
    assert ul.dl_rb_count is None

    dl = extract_nr_metrics(QWINLOG_DL_PHY_DETAIL, 0xB887)
    assert dl is not None
    assert dl.modulation == "QPSK"
    assert dl.mcs == 0
    assert dl.dl_rb_count == 16
    assert dl.ul_rb_count is None
    assert dl.retransmission_count == 0
    assert dl.bler_pct == 0
    assert dl.bit_error_rate_pct == 0

    pdcp = extract_nr_metrics(QWINLOG_PDCP_DETAIL, 0xB860)
    assert pdcp is not None
    assert pdcp.ul_rb_count == 4
    assert pdcp.dl_rb_count == 4
    assert pdcp.packet_loss_rate_pct == 1


def test_writes_zero_bit_error_rate_from_explicit_no_error_fields(tmp_path):
    rlc = extract_nr_metrics(QWINLOG_RLC_ERROR_COUNTER_DETAIL, 0xB842)
    assert rlc is not None
    assert rlc.bit_error_rate_pct == 0

    path = tmp_path / "dm_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert writer.write(
            DecodedRecord("session", 1, 0xB887, 0, 0, detail=QWINLOG_DL_PHY_DETAIL.encode())
        )
    finally:
        writer.close()

    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["NR Bit Error Rate[%]"] == "0"


def test_writes_at_row_without_any_dm_row(tmp_path):
    path = tmp_path / "nr_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert writer.write_at(
            {
                "timestamp": "2026-08-28T18:00:00+08:00",
                "servingcell": {
                    "band": 78,
                    "pci": 555,
                    "arfcn": 633984,
                    "rsrp_dbm": -70,
                    "rsrq_db": -10,
                    "sinr_db": 22,
                },
            },
            1,
            "session",
        )
    finally:
        writer.close()

    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["session_id"] == "session"
    assert row["msg_code"] == ""
    assert row["NR Band"] == "n78"
    assert row["NR PCI"] == "555"
    assert row["NR SSB RSRP[dBm]"] == "-70"


def test_live_merged_writer_uses_at_sinr_without_changing_dm_csv(tmp_path):
    dm_path = tmp_path / "dm_metrics.csv"
    merged_path = tmp_path / "merged_metrics.csv"
    dm_writer = MetricsCsvWriter(dm_path)
    merged_writer = MetricsCsvWriter(merged_path)
    fanout = MetricsWriterFanout(dm_writer, merged_writer)
    at_record = {
        "timestamp": "2026-09-04T15:23:45.536386+08:00",
        "servingcell": {
            "band": 78,
            "pci": 555,
            "arfcn": 633984,
            "rsrp_dbm": -70,
            "rsrq_db": -10,
            "sinr_db": 22,
        },
    }

    dm_writer.open(reset=True)
    merged_writer.open(reset=True)
    try:
        assert merged_writer.write_at(at_record, 1, "session")
        assert fanout.write(
            DecodedRecord("session", 2, 0xB97F, 0, 0, detail=DETAIL.encode("utf-8"))
        )
    finally:
        dm_writer.close()
        merged_writer.close()

    with dm_path.open(encoding="utf-8-sig", newline="") as stream:
        dm_row = next(csv.DictReader(stream))
    with merged_path.open(encoding="utf-8-sig", newline="") as stream:
        merged_rows = list(csv.DictReader(stream))
    merged_dm_row = merged_rows[-1]

    assert dm_row["NR PCI"] == "298"
    assert dm_row["NR SSB SINR[dB]"] == ""
    assert merged_dm_row["msg_code"] == "0xB97F"
    assert merged_dm_row["NR PCI"] == "555"
    assert merged_dm_row["NR SSB RSRP[dBm]"] == "-70"
    assert merged_dm_row["NR SSB SINR[dB]"] == "22"
    assert merged_dm_row["NR SSB RSRP BestBeam[dBm]"] == "-67.68"


def test_skips_header_only_decoded_dm_in_metrics_csv(tmp_path):
    path = tmp_path / "nr_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    try:
        assert not writer.write(
            DecodedRecord(
                "session",
                7,
                0x1C6E,
                0,
                0,
                detail=(
                    "<QualcommMessage><Header>"
                    "<Time>2026 08 31 07:42:50.109</Time>"
                    "</Header><Content /></QualcommMessage>"
                ).encode(),
            )
        )
    finally:
        writer.close()
    with path.open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))
    assert rows == []


def test_dm_writer_throttles_rows_to_configured_interval_and_keeps_latest(tmp_path):
    path = tmp_path / "nr_metrics.csv"
    writer = MetricsCsvWriter(path, write_interval_sec=0.1)
    writer.open(reset=True)
    try:
        detail = DETAIL.encode()
        with patch(
            "radio_capture.pipeline.metrics_sink.time.monotonic",
            side_effect=(100.0, 100.05, 100.11),
        ):
            assert writer.write(
                DecodedRecord("session", 1, 0xB97F, 0, 0, detail=detail)
            )
            assert not writer.write(
                DecodedRecord("session", 2, 0xB97F, 0, 0, detail=detail)
            )
            assert writer.write(
                DecodedRecord("session", 3, 0xB97F, 0, 0, detail=detail)
            )
    finally:
        writer.close()

    with path.open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))
    assert [row["sequence"] for row in rows] == ["1", "3"]


def test_throttled_dm_timestamps_advance_by_fixed_interval(tmp_path):
    path = tmp_path / "dm_metrics.csv"
    writer = MetricsCsvWriter(path, write_interval_sec=0.5)
    writer.open(reset=True)
    try:
        detail = DETAIL.encode()
        with patch(
            "radio_capture.pipeline.metrics_sink.time.monotonic",
            side_effect=(100.0, 100.6),
        ):
            assert writer.write(
                DecodedRecord("session", 1, 0xB97F, 0, 0, detail=detail)
            )
            assert writer.write(
                DecodedRecord("session", 2, 0xB97F, 0, 0, detail=detail)
            )
    finally:
        writer.close()

    with path.open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))
    assert [row["timestamp"] for row in rows] == [
        "2026-08-27T02:18:59.968000+08:00",
        "2026-08-27T02:19:00.468000+08:00",
    ]
    assert [row["MsgTime"] for row in rows] == [row["timestamp"] for row in rows]


def test_dm_timestamp_uses_capture_time_in_shanghai(tmp_path):
    path = tmp_path / "dm_metrics.csv"
    writer = MetricsCsvWriter(path)
    writer.open(reset=True)
    receive_time_ns = 1_700_000_000_000_000_000
    try:
        assert writer.write(
            DecodedRecord(
                "session",
                8,
                0xB883,
                0,
                0,
                detail=(
                    "<QualcommMessage><Header>"
                    "<Time>1980 01 06  00:45:37.585</Time>"
                    "</Header><Content><MCS>24</MCS></Content></QualcommMessage>"
                ).encode(),
                receive_time_ns=receive_time_ns,
            )
        )
    finally:
        writer.close()
    with path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    expected = format_shanghai_timestamp(receive_time_ns)
    assert row["timestamp"] == expected
    assert row["MsgTime"] == expected
    assert row["timestamp"].endswith("+08:00")
    assert not row["timestamp"].startswith("1980")


def test_format_decoder_timestamp_adds_shanghai_offset():
    assert (
        format_decoder_timestamp("2026 08 31 07:42:50.109")
        == "2026-08-31T07:42:50.109000+08:00"
    )


def test_merges_dm_and_at_csvs_by_timestamp(tmp_path):
    dm_path = tmp_path / "dm_metrics.csv"
    at_path = tmp_path / "at_metrics.csv"
    merged_path = tmp_path / "nr_metrics.csv"
    for path, row in (
        (
            dm_path,
            {
                "timestamp": "2026 08 31 07:00:00.000",
                "session_id": "s",
                "sequence": "2",
                "msg_code": "0x1C6E",
                "MsgTime": "2026 08 31 07:00:00.000",
            },
        ),
        (
            at_path,
            {
                "timestamp": "2026-08-31T15:00:00+08:00",
                "session_id": "s",
                "sequence": "1",
                "msg_code": "",
                "MsgTime": "2026-08-31T15:00:00+08:00",
            },
        ),
    ):
        with path.open("w", encoding="utf-8-sig", newline="") as stream:
            writer = csv.DictWriter(stream, fieldnames=list(CSV_COLUMNS))
            writer.writeheader()
            writer.writerow({column: row.get(column, "") for column in CSV_COLUMNS})

    assert merge_metrics_csvs(dm_path, at_path, merged_path) == 2
    with merged_path.open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))
    assert tuple(rows[0].keys()) == CSV_COLUMNS
    assert [row["msg_code"] for row in rows] == ["0x1C6E", ""]
