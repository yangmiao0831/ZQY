"""Tests for AT signal parsing and CSV fields."""

from __future__ import annotations

import csv
from unittest.mock import patch

from radio_capture.pipeline.at_sink import (
    AT_CSV_COLUMNS,
    FOUR_G_CSV_COLUMNS,
    AtSignalWriter,
    FourGMetricsCsvWriter,
    at_record_to_row,
    lte_record_to_row,
)
from radio_capture.tools.at_signal_probe import parse_signal


SERVINGCELL = (
    'AT+QENG="servingcell"\r\r\n'
    '+QENG: "servingcell","NOCONN","NR5G-SA","TDD",460,01,'
    '064B51101,555,63011,633984,78,12,-70,-10,22,1,-\r\r\n\r\nOK'
)
LTE_SERVINGCELL = (
    'AT+QENG="servingcell"\r\r\n'
    '+QENG: "servingcell","NOCONN","LTE","FDD",460,01,'
    '00ABCDEF,271,1300,3,5,20,1234,-94,-12,-60,9,5,219,-\r\r\n\r\nOK'
)
NSA_SERVINGCELL = (
    'AT+QENG="servingcell"\r\r\n'
    '+QENG: "servingcell","NOCONN"\r\n'
    '+QENG: "LTE","FDD",460,01,00ABCDEF,271,1300,3,5,20,1234,'
    '-94,-12,-60,9,5,219,-\r\n'
    '+QENG: "NR5G-NSA",460,01,822,-82,12,-11,633984,78,1\r\r\n\r\nOK'
)


def test_qeng_fields_are_exported_to_at_csv_columns(tmp_path):
    record = parse_signal(
        {
            "csq": "+CSQ: 20,99\r\nOK",
            "nwinfo": '+QNWINFO: "TDD NR5G","46001","NR5G BAND 78",633984\r\nOK',
            "servingcell": SERVINGCELL,
        }
    )

    writer = AtSignalWriter(tmp_path, "session")
    writer.open()
    try:
        writer.write(record, 1)
    finally:
        writer.close()

    with (tmp_path / "at_metrics.csv").open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))

    row = rows[0]
    assert tuple(row) == AT_CSV_COLUMNS
    assert row["MsgTime"] == row["timestamp"]
    assert row["NR Band"] == "n78"
    assert row["NR SSB ARFCN DL"] == "633984"
    assert row["NR SSB RSRQ[dB]"] == "-10"
    assert row["NR SSB RSRP[dBm]"] == "-70"
    assert row["NR SSB SINR[dB]"] == "22"
    assert row["NR SSB RSRP BestBeam[dBm]"] == ""
    assert row["NR BWP Bandwidth[MHz]"] == ""
    assert row["NR SSB RSSI[dBm]"] == "-73"


def test_qcsq_supplies_radio_measurements_when_qeng_is_partial():
    record = parse_signal(
        {
            "csq": "+CSQ: 99,99\r\nOK",
            "nwinfo": "",
            "servingcell": "",
            "qcsq": '+QCSQ: "NR5G",-48,-72,18,-9\r\nOK',
        }
    )

    serving = record["servingcell"]
    assert serving["rssi_dbm"] == -48
    assert serving["rsrp_dbm"] == -72
    assert serving["sinr_db"] == 18
    assert serving["rsrq_db"] == -9


def test_lte_qeng_fields_are_exported_to_4g_csv_columns(tmp_path):
    record = parse_signal(
        {
            "csq": "+CSQ: 20,99\r\nOK",
            "nwinfo": '+QNWINFO: "FDD LTE","46001","LTE BAND 3",1300\r\nOK',
            "servingcell": LTE_SERVINGCELL,
            "qcsq": '+QCSQ: "LTE",-60,-94,9,-12\r\nOK',
        }
    )

    serving = record["lte_servingcell"]
    assert serving["rat"] == "LTE"
    assert serving["band"] == 3
    assert serving["earfcn"] == 1300
    assert serving["pci"] == 271
    assert serving["bandwidth_dl"] == 20
    assert serving["rsrp_dbm"] == -94
    assert serving["rsrq_db"] == -12
    assert serving["rssi_dbm"] == -60
    assert serving["sinr_db"] == 9

    row = lte_record_to_row(record, "session", 1)
    assert tuple(row) == FOUR_G_CSV_COLUMNS
    assert row["LTE Band"] == "B3"
    assert row["LTE Bandwidth DL"] == 20
    assert row["LTE EARFCN DL"] == 1300
    assert row["LTE PCI"] == 271
    assert row["LTE RSRP[dBm]"] == -94
    assert row["LTE RSRQ[dB]"] == -12
    assert row["LTE RSSI[dBm]"] == -60
    assert row["LTE SINR[dB]"] == 9
    assert row["LTE BWP Active Bandwidth DL[MHz]"] == 20
    assert row["LTE BWP Bandwidth[MHz]"] == 20
    assert row["LTE RSRP BestBeam[dBm]"] == ""
    assert at_record_to_row(record, "session", 1) is None


def test_lte_qcsq_and_qnwinfo_are_used_when_qeng_is_absent():
    record = parse_signal(
        {
            "csq": "+CSQ: 99,99\r\nOK",
            "nwinfo": '+QNWINFO: "FDD LTE","46001","LTE BAND 3",1300\r\nOK',
            "servingcell": "",
            "qcsq": '+QCSQ: "LTE",-60,-94,9,-12\r\nOK',
        }
    )

    serving = record["lte_servingcell"]
    assert serving["band"] == 3
    assert serving["earfcn"] == 1300
    assert serving["rssi_dbm"] == -60
    assert serving["rsrp_dbm"] == -94
    assert serving["sinr_db"] == 9
    assert serving["rsrq_db"] == -12


def test_nsa_multiline_qeng_exports_lte_and_nr_records():
    record = parse_signal(
        {
            "csq": "+CSQ: 20,99\r\nOK",
            "nwinfo": '+QNWINFO: "FDD LTE","46001","LTE BAND 3",1300\r\nOK',
            "servingcell": NSA_SERVINGCELL,
            "qcsq": "",
        }
    )

    lte = record["lte_servingcell"]
    nr = record["servingcell"]
    assert lte["rat"] == "LTE"
    assert lte["band"] == 3
    assert lte["earfcn"] == 1300
    assert lte["pci"] == 271
    assert lte["rsrp_dbm"] == -94
    assert nr["rat"] == "NR5G-NSA"
    assert nr["band"] == 78
    assert nr["pci"] == 822

    lte_row = lte_record_to_row(record, "session", 1)
    nr_row = at_record_to_row(record, "session", 1)
    assert lte_row["LTE Band"] == "B3"
    assert lte_row["LTE EARFCN DL"] == 1300
    assert nr_row["NR Band"] == "n78"
    assert nr_row["NR PCI"] == 822


def test_at_writer_splits_nr_and_lte_csvs(tmp_path):
    lte_path = tmp_path / "4G_metrics.csv"
    writer = AtSignalWriter(tmp_path, "session", lte_csv_path=lte_path)
    writer.open()
    try:
        writer.write(
            parse_signal(
                {
                    "csq": "+CSQ: 20,99\r\nOK",
                    "nwinfo": "",
                    "servingcell": SERVINGCELL,
                }
            ),
            1,
        )
        writer.write(
            parse_signal(
                {
                    "csq": "+CSQ: 20,99\r\nOK",
                    "nwinfo": '+QNWINFO: "FDD LTE","46001","LTE BAND 3",1300\r\nOK',
                    "servingcell": LTE_SERVINGCELL,
                    "qcsq": "",
                }
            ),
            2,
        )
    finally:
        writer.close()

    with (tmp_path / "at_metrics.csv").open(encoding="utf-8-sig", newline="") as stream:
        nr_rows = list(csv.DictReader(stream))
    with lte_path.open(encoding="utf-8-sig", newline="") as stream:
        lte_rows = list(csv.DictReader(stream))

    assert len(nr_rows) == 1
    assert nr_rows[0]["NR Band"] == "n78"
    assert len(lte_rows) == 1
    assert lte_rows[0]["LTE Band"] == "B3"
    assert lte_rows[0]["LTE EARFCN DL"] == "1300"
    assert lte_rows[0]["LTE BWP Active Bandwidth DL[MHz]"] == "20"
    assert lte_rows[0]["LTE BWP Bandwidth[MHz]"] == "20"


def test_4g_writer_merges_at_base_and_dm_link_metrics(tmp_path):
    lte_path = tmp_path / "4G_metrics.csv"
    writer = FourGMetricsCsvWriter(lte_path, "session")
    writer.open()
    try:
        writer.write_at(
            parse_signal(
                {
                    "csq": "+CSQ: 20,99\r\nOK",
                    "nwinfo": '+QNWINFO: "FDD LTE","46001","LTE BAND 3",1300\r\nOK',
                    "servingcell": LTE_SERVINGCELL,
                    "qcsq": "",
                }
            ),
            1,
        )
        from radio_capture.models import DecodedRecord

        writer.write_dm(
            DecodedRecord(
                session_id="session",
                sequence=2,
                msg_code=0xB173,
                display_format=0,
                return_code=0,
                detail=(
                    b"<QualcommMessage><Header><Time>2026 09 06  10:11:12.123</Time></Header>"
                    b"<Content><Num_RBs>48</Num_RBs><CRC_Result>(1)Pass</CRC_Result>"
                    b"<MCS>17</MCS><Modulation_Type>(4)16QAM</Modulation_Type>"
                    b"</Content></QualcommMessage>"
                ),
                receive_time_ns=1_788_660_672_123_000_000,
            )
        )
    finally:
        writer.close()

    with lte_path.open(encoding="utf-8-sig", newline="") as stream:
        rows = list(csv.DictReader(stream))

    assert tuple(rows[0]) == FOUR_G_CSV_COLUMNS
    assert rows[-1]["msg_code"] == "0xB173"
    assert rows[-1]["LTE Band"] == "B3"
    assert rows[-1]["LTE EARFCN DL"] == "1300"
    assert rows[-1]["LTE PCI"] == "271"
    assert rows[-1]["LTE BWP Active Bandwidth DL[MHz]"] == "20"
    assert rows[-1]["LTE BWP Bandwidth[MHz]"] == "20"
    assert rows[-1]["LTE Modulation"] == "16QAM"
    assert rows[-1]["LTE MCS"] == "17"
    assert rows[-1]["LTE BLER[%]"] == "0"
    assert rows[-1]["LTE DL RB Count"] == "48"


def test_named_extended_qeng_metrics_are_parsed():
    response = SERVINGCELL.replace(
        "1,-",
        "1,-,NR_BANDWIDTH_DL=100,NR_BWP_ACTIVE_BANDWIDTH_DL_MHZ=80,"
        "NR_BWP_BANDWIDTH_MHZ=100,NR_SSB_ARFCN_DL=633985,NR_SSB_RSSI=-45,"
        "NR_SSB_RSRP_BEST_BEAM=-68,NR_SSB_RSRP_SECOND_BEAM=-74",
    )
    record = parse_signal(
        {
            "csq": "",
            "nwinfo": "",
            "servingcell": response,
        }
    )

    serving = record["servingcell"]
    assert serving["bandwidth_dl"] == 100
    assert serving["bwp_active_bandwidth_dl_mhz"] == 80
    assert serving["bwp_bandwidth_mhz"] == 100
    assert serving["ssb_arfcn_dl"] == 633985
    assert serving["ssb_rssi_dbm"] == -45
    assert serving["ssb_rsrp_bestbeam_dbm"] == -68
    assert serving["ssb_rsrp_secondbeam_dbm"] == -74


def test_at_csv_keeps_optional_advanced_fields_dm_owned(tmp_path):
    response = SERVINGCELL.replace(
        "1,-",
        "1,-,NR_BANDWIDTH_DL=100,NR_BWP_ACTIVE_BANDWIDTH_DL_MHZ=80,"
        "NR_BWP_BANDWIDTH_MHZ=100,NR_SSB_RSSI=-45,"
        "NR_SSB_RSRP_BEST_BEAM=-68,NR_SSB_RSRP_SECOND_BEAM=-74",
    )
    record = parse_signal({"csq": "", "nwinfo": "", "servingcell": response})

    writer = AtSignalWriter(tmp_path, "session")
    writer.open()
    try:
        writer.write(record, 1)
    finally:
        writer.close()

    with (tmp_path / "at_metrics.csv").open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))

    assert row["NR Bandwidth DL"] == "100"
    assert row["NR BWP Active Bandwidth DL[MHz]"] == ""
    assert row["NR BWP Bandwidth[MHz]"] == ""
    assert row["NR SSB RSSI[dBm]"] == "-45"
    assert row["NR SSB RSRP BestBeam[dBm]"] == ""
    assert row["NR SSB RSRP SecondBeam[dBm]"] == ""


def test_metrics_only_at_writer_does_not_create_sidecar_files(tmp_path):
    class FakeMetricsWriter:
        def __init__(self):
            self.calls = []

        def write_at(self, record, sequence, session_id):
            self.calls.append((record, sequence, session_id))

    metrics_writer = FakeMetricsWriter()
    writer = AtSignalWriter(
        tmp_path,
        "session",
        metrics_writer=metrics_writer,
        persist_jsonl=False,
        persist_csv=False,
    )
    writer.open()
    try:
        writer.write({"servingcell": {"pci": 1}}, 7)
    finally:
        writer.close()

    assert metrics_writer.calls[0][1] == 7
    assert metrics_writer.calls[0][2] == "session"
    assert not (tmp_path / "at_signal.jsonl").exists()
    assert not (tmp_path / "at_metrics.csv").exists()


def test_metrics_only_at_snapshot_is_written_to_at_metrics_csv(tmp_path):
    at_path = tmp_path / "at_metrics.csv"
    writer = AtSignalWriter(
        tmp_path,
        "session",
        persist_jsonl=False,
        persist_csv=True,
        csv_path=at_path,
    )
    writer.open()
    try:
        writer.write(
            parse_signal(
                {
                    "csq": "+CSQ: 20,99\r\nOK",
                    "nwinfo": "",
                    "servingcell": SERVINGCELL,
                }
            ),
            1,
        )
    finally:
        writer.close()

    with at_path.open(encoding="utf-8-sig", newline="") as stream:
        row = next(csv.DictReader(stream))
    assert row["session_id"] == "session"
    assert row["NR SSB RSRP[dBm]"] == "-70"
    assert row["NR SSB RSSI[dBm]"] == "-73"
    assert row["NR SSB RSRQ[dB]"] == "-10"
    assert row["NR SSB SINR[dB]"] == "22"


def test_at_writer_throttles_to_half_second_and_flushes_latest(tmp_path):
    writer = AtSignalWriter(tmp_path, "session", write_interval_sec=0.5)
    writer.open()
    record = parse_signal(
        {
            "csq": "+CSQ: 20,99\r\nOK",
            "nwinfo": "",
            "servingcell": SERVINGCELL,
        }
    )
    try:
        with patch(
            "radio_capture.pipeline.at_sink.time.monotonic",
            side_effect=(100.0, 100.1, 100.2),
        ):
            writer.write(record, 1)
            writer.write(record, 2)
    finally:
        writer.close()

    with (tmp_path / "at_metrics.csv").open(
        encoding="utf-8-sig", newline=""
    ) as stream:
        rows = list(csv.DictReader(stream))
    assert [row["sequence"] for row in rows] == ["1", "2"]
