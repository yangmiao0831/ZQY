"""Tests for LTE DM metric extraction."""

from __future__ import annotations

from radio_capture.pipeline.lte_metrics import extract_lte_dm_metrics


def test_extract_lte_dl_harq_metrics_from_dm_xml():
    metrics = extract_lte_dm_metrics(
        b"""
        <QualcommMessage>
          <Header><Time>2026 09 06  10:11:12.123</Time></Header>
          <Content>
            <Num_RBs>25</Num_RBs>
            <CRC_Result>(1)Pass</CRC_Result>
            <CRC_Result>(0)Fail</CRC_Result>
            <MCS>12</MCS>
            <Modulation_Type>(4)16_QAM</Modulation_Type>
            <ACK_NACK_Decision>(1)ACK</ACK_NACK_Decision>
          </Content>
        </QualcommMessage>
        """,
        0xB173,
    )

    assert metrics is not None
    assert metrics.timestamp == "2026 09 06  10:11:12.123"
    assert metrics.dl_rb_count == 25
    assert metrics.mcs == 12
    assert metrics.modulation == "16QAM"
    assert metrics.bler_pct == 50
    assert metrics.bit_error_rate_pct is None


def test_extract_lte_ul_retransmission_metrics_from_dm_xml():
    metrics = extract_lte_dm_metrics(
        b"""
        <QualcommMessage>
          <Content>
            <MCS_Index>17</MCS_Index>
            <Modulation_Type>(2)16_QAM</Modulation_Type>
            <Retransmission_Index>2</Retransmission_Index>
            <Tx_Type>(1)ReTx</Tx_Type>
          </Content>
        </QualcommMessage>
        """,
        0xB16D,
    )

    assert metrics is not None
    assert metrics.mcs == 17
    assert metrics.modulation == "16QAM"
    assert metrics.retransmission_count == 2


def test_extract_lte_rlc_packet_loss_from_dm_xml():
    metrics = extract_lte_dm_metrics(
        b"""
        <QualcommMessage>
          <Content>
            <Num_Data_Pdu>98</Num_Data_Pdu>
            <Data_Pdu_Bytes>12500</Data_Pdu_Bytes>
            <Num_Error>10</Num_Error>
            <Num_Discard_SDU>2</Num_Discard_SDU>
            <Num_PDU_HO_ReTx>3</Num_PDU_HO_ReTx>
          </Content>
        </QualcommMessage>
        """,
        0xB0B4,
    )

    assert metrics is not None
    assert metrics.packet_loss_rate_pct == 2
    assert metrics.bit_error_rate_pct == 0.01
    assert metrics.retransmission_count == 3
