from __future__ import annotations

import csv
from pathlib import Path

from radio_capture.pipeline.pusch_bler import PuschBlerTracker
from radio_capture.tools.replay_pusch_bler import compare_with_autocom


def _b883(*tx_types: str) -> str:
    records = "".join(
        "<Record><Phychan_Bit_Mask>PUSCH</Phychan_Bit_Mask>"
        f"<TX_Type>(0){tx_type}</TX_Type><HARQ_ID>{index}</HARQ_ID>"
        "<RV_Index>0</RV_Index></Record>"
        for index, tx_type in enumerate(tx_types)
    )
    return f"<QualcommMessage><Content><Table>{records}</Table></Content></QualcommMessage>"


def _b885() -> str:
    return (
        "<QualcommMessage><Content><Record><Frame>10</Frame><Slot>2</Slot>"
        "<Record><DCI_Format>(1)UL_0_1</DCI_Format><NDI>1</NDI>"
        "<RV>0</RV><HARQ_ID>0</HARQ_ID></Record></Record></Content></QualcommMessage>"
    )


def test_tracker_counts_only_b883_b885_and_keeps_candidate_separate():
    tracker = PuschBlerTracker()
    assert tracker.feed(msg_code=0xB887, detail="<x/>", receive_time_ns=1, sequence=1) == []
    tracker.feed(msg_code=0xB885, detail=_b885(), receive_time_ns=1_000_000_000, sequence=2)
    tracker.feed(
        msg_code=0xB883,
        detail=_b883("NEW_TX", "RE_TX", "NEW_TX"),
        receive_time_ns=1_100_000_000,
        sequence=3,
    )
    bucket = tracker.finish()[0]
    assert bucket.b885_ul_dci_records == 1
    assert bucket.pusch_tx_samples == 3
    assert bucket.new_tx_count == 2
    assert bucket.retx_count == 1
    assert bucket.dci_match_count == 1
    assert round(bucket.candidate_ul_bler_pct or 0, 2) == 33.33


def test_tracker_flushes_at_second_boundary():
    tracker = PuschBlerTracker()
    tracker.feed(
        msg_code=0xB883,
        detail=_b883("NEW_TX"),
        receive_time_ns=1_100_000_000,
        sequence=1,
    )
    completed = tracker.feed(
        msg_code=0xB883,
        detail=_b883("RE_TX"),
        receive_time_ns=2_100_000_000,
        sequence=2,
    )
    assert len(completed) == 1
    assert completed[0].candidate_ul_bler_pct == 0.0
    assert tracker.finish()[0].candidate_ul_bler_pct == 100.0


def test_comparison_reports_no_time_overlap(tmp_path: Path):
    candidate = tmp_path / "candidate.csv"
    autocom = tmp_path / "autocom.csv"
    output = tmp_path / "comparison.csv"
    with candidate.open("w", encoding="utf-8-sig", newline="") as stream:
        writer = csv.DictWriter(
            stream,
            fieldnames=["timestamp_second", "UL_BLER_Avg_candidate[%]", "PUSCH_TX_samples"],
        )
        writer.writeheader()
        writer.writerow(
            {
                "timestamp_second": "2026-10-01 21:15:34",
                "UL_BLER_Avg_candidate[%]": "10",
                "PUSCH_TX_samples": "20",
            }
        )
    with autocom.open("w", encoding="utf-8-sig", newline="") as stream:
        writer = csv.DictWriter(stream, fieldnames=["Time", "NR PUSCH BLER[%]"])
        writer.writeheader()
        writer.writerow(
            {"Time": "2026-10-01 20:09:38.130", "NR PUSCH BLER[%]": "13.64"}
        )
    summary = compare_with_autocom(
        candidate_path=candidate,
        autocom_path=autocom,
        output_path=output,
    )
    assert summary["overlap_seconds"] == 0
    assert summary["comparison_status"] == "no_time_overlap"
    assert len(output.read_text(encoding="utf-8-sig").splitlines()) == 1


def test_comparison_uses_last_autocom_value_per_second(tmp_path: Path):
    candidate = tmp_path / "candidate.csv"
    autocom = tmp_path / "autocom.csv"
    output = tmp_path / "comparison.csv"
    with candidate.open("w", encoding="utf-8-sig", newline="") as stream:
        writer = csv.DictWriter(
            stream,
            fieldnames=["timestamp_second", "UL_BLER_Avg_candidate[%]", "PUSCH_TX_samples"],
        )
        writer.writeheader()
        writer.writerow(
            {
                "timestamp_second": "2026-10-01 20:09:38",
                "UL_BLER_Avg_candidate[%]": "10",
                "PUSCH_TX_samples": "20",
            }
        )
    with autocom.open("w", encoding="utf-8-sig", newline="") as stream:
        writer = csv.DictWriter(stream, fieldnames=["Time", "UL_BLER_Avg"])
        writer.writeheader()
        writer.writerow({"Time": "2026-10-01 20:09:38.100", "UL_BLER_Avg": "12"})
        writer.writerow({"Time": "2026-10-01 20:09:38.900", "UL_BLER_Avg": "14"})
    summary = compare_with_autocom(
        candidate_path=candidate,
        autocom_path=autocom,
        output_path=output,
    )
    rows = list(csv.DictReader(output.open(encoding="utf-8-sig", newline="")))
    assert summary["overlap_seconds"] == 1
    assert summary["autocom_per_second_aggregation"] == "last_nonblank"
    assert rows[0]["autocom_UL_BLER_Avg[%]"] == "14.0"
    assert rows[0]["delta_percentage_points"] == "-4.0"
