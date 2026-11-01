"""Replay B883/B885 spool records into an isolated PUSCH BLER candidate CSV."""

from __future__ import annotations

import argparse
import csv
import json
from collections import Counter, defaultdict
from datetime import datetime, timedelta, timezone
from pathlib import Path

from radio_capture.config import load_config
from radio_capture.native.autocom_bler_process import probe_ddlcxx
from radio_capture.native.decoder import LogCodec
from radio_capture.pipeline.parser import FrameParser
from radio_capture.pipeline.pusch_bler import PUSCH_BLER_MSG_CODES, PuschBlerBucket, PuschBlerTracker
from radio_capture.tools.replay_spool_metrics import _resolve_dll_dir, iter_spool_frames


SHANGHAI_TZ = timezone(timedelta(hours=8), name="Asia/Shanghai")
CANDIDATE_COLUMNS = (
    "timestamp_second",
    "session_id",
    "last_sequence",
    "B883_messages",
    "B885_messages",
    "B885_UL_DCI_records",
    "PUSCH_TX_samples",
    "NEW_TX_count",
    "RE_TX_count",
    "unknown_TX_count",
    "B883_B885_HARQ_matches",
    "UL_BLER_Avg_candidate[%]",
    "valid_min_10_samples",
    "source_codes",
    "source_fields",
    "calculation",
    "status",
)
COMPARISON_COLUMNS = (
    "timestamp_second",
    "candidate_UL_BLER_Avg[%]",
    "autocom_UL_BLER_Avg[%]",
    "delta_percentage_points",
    "candidate_samples",
    "autocom_samples",
)


def _format_second(second_ns: int) -> str:
    value = datetime.fromtimestamp(second_ns / 1_000_000_000, tz=SHANGHAI_TZ)
    return value.strftime("%Y-%m-%d %H:%M:%S")


def _bucket_row(session_id: str, bucket: PuschBlerBucket) -> dict[str, object]:
    value = bucket.candidate_ul_bler_pct
    return {
        "timestamp_second": _format_second(bucket.second_ns),
        "session_id": session_id,
        "last_sequence": bucket.last_sequence,
        "B883_messages": bucket.b883_messages,
        "B885_messages": bucket.b885_messages,
        "B885_UL_DCI_records": bucket.b885_ul_dci_records,
        "PUSCH_TX_samples": bucket.pusch_tx_samples,
        "NEW_TX_count": bucket.new_tx_count,
        "RE_TX_count": bucket.retx_count,
        "unknown_TX_count": bucket.unknown_tx_count,
        "B883_B885_HARQ_matches": bucket.dci_match_count,
        "UL_BLER_Avg_candidate[%]": "" if value is None else round(value, 6),
        "valid_min_10_samples": int(bucket.pusch_tx_samples >= 10),
        "source_codes": "0xB883,0xB885",
        "source_fields": "B883.TX_Type;B883.HARQ_ID;B885.NDI;B885.RV;B885.HARQ_ID",
        "calculation": "RE_TX/(NEW_TX+RE_TX)*100",
        "status": "candidate_not_crc_not_production",
    }


def replay_pusch_bler(
    *,
    session_dir: Path,
    config_path: Path,
    output_path: Path,
    dll_dir: Path | None = None,
) -> dict[str, object]:
    config = load_config(config_path)
    actual_dll_dir = _resolve_dll_dir(config.runtime.dll_dir, dll_dir)
    parser = FrameParser()
    codec = LogCodec(actual_dll_dir, config.decoder.dispatcher_dll)
    codec.load()
    codec.create(int(config.decoder.codec_module_id or config.device.eq_id))
    tracker = PuschBlerTracker()
    rows: list[dict[str, object]] = []
    counts: Counter[str] = Counter()
    try:
        for frame, _offset in iter_spool_frames(session_dir):
            counts["frames"] += 1
            msg_code = parser.extract_msg_code(frame.payload)
            if msg_code not in PUSCH_BLER_MSG_CODES:
                continue
            counts[f"frames_0x{msg_code:04X}"] += 1
            detail_rc, detail = codec.get_detail(msg_code, frame.payload)
            if detail_rc != 0:
                counts["decoder_errors"] += 1
                continue
            counts["decoder_ok"] += 1
            for bucket in tracker.feed(
                msg_code=msg_code,
                detail=detail,
                receive_time_ns=frame.receive_time_ns,
                sequence=frame.sequence,
            ):
                rows.append(_bucket_row(frame.session_id, bucket))
        for bucket in tracker.finish():
            rows.append(_bucket_row(session_dir.name, bucket))
    finally:
        codec.close()

    output_path.parent.mkdir(parents=True, exist_ok=True)
    with output_path.open("w", encoding="utf-8-sig", newline="") as stream:
        writer = csv.DictWriter(stream, fieldnames=CANDIDATE_COLUMNS)
        writer.writeheader()
        writer.writerows(rows)
    counts["output_rows"] = len(rows)
    counts["rows_with_candidate"] = sum(
        1 for row in rows if row["UL_BLER_Avg_candidate[%]"] != ""
    )
    counts["valid_rows"] = sum(int(row["valid_min_10_samples"]) for row in rows)
    return dict(counts)


def compare_with_autocom(
    *,
    candidate_path: Path,
    autocom_path: Path,
    output_path: Path,
) -> dict[str, object]:
    candidates: dict[str, tuple[float, int]] = {}
    with candidate_path.open(encoding="utf-8-sig", newline="") as stream:
        for row in csv.DictReader(stream):
            raw = (row.get("UL_BLER_Avg_candidate[%]") or "").strip()
            if not raw:
                continue
            candidates[row["timestamp_second"]] = (
                float(raw),
                int(row.get("PUSCH_TX_samples") or 0),
            )

    autocom_values: dict[str, list[float]] = defaultdict(list)
    autocom_column = ""
    with autocom_path.open(encoding="utf-8-sig", errors="replace", newline="") as stream:
        reader = csv.DictReader(stream)
        fieldnames = reader.fieldnames or []
        value_column = next(
            (
                name
                for name in ("UL_BLER_Avg", "NR PUSCH BLER[%]", "PUSCH BLER[%]")
                if name in fieldnames
            ),
            None,
        )
        if value_column is None:
            raise ValueError("AutoCom CSV has no UL_BLER_Avg or NR PUSCH BLER[%] column")
        autocom_column = value_column
        time_column = "Time" if "Time" in fieldnames else "timestamp"
        if time_column not in fieldnames:
            raise ValueError("AutoCom CSV has no Time/timestamp column")
        for row in reader:
            raw_time = (row.get(time_column) or "").strip()
            raw_value = (row.get(value_column) or "").strip()
            if not raw_time or not raw_value:
                continue
            try:
                second = datetime.fromisoformat(raw_time).strftime("%Y-%m-%d %H:%M:%S")
                autocom_values[second].append(float(raw_value))
            except ValueError:
                continue

    comparison_rows: list[dict[str, object]] = []
    for second in sorted(set(candidates).intersection(autocom_values)):
        candidate, candidate_samples = candidates[second]
        values = autocom_values[second]
        # The exported CSV has no UL_BLER_Cnt weight.  Use the last nonblank
        # value in each second as the AutoCom snapshot instead of inventing an
        # unweighted replacement for AutoCom's internal weighted average.
        autocom = values[-1]
        comparison_rows.append(
            {
                "timestamp_second": second,
                "candidate_UL_BLER_Avg[%]": round(candidate, 6),
                "autocom_UL_BLER_Avg[%]": round(autocom, 6),
                "delta_percentage_points": round(candidate - autocom, 6),
                "candidate_samples": candidate_samples,
                "autocom_samples": len(values),
            }
        )

    output_path.parent.mkdir(parents=True, exist_ok=True)
    with output_path.open("w", encoding="utf-8-sig", newline="") as stream:
        writer = csv.DictWriter(stream, fieldnames=COMPARISON_COLUMNS)
        writer.writeheader()
        writer.writerows(comparison_rows)
    return {
        "candidate_seconds": len(candidates),
        "autocom_seconds": len(autocom_values),
        "overlap_seconds": len(comparison_rows),
        "comparison_status": "ready" if comparison_rows else "no_time_overlap",
        "autocom_value_column": autocom_column,
        "autocom_per_second_aggregation": "last_nonblank",
    }


def main(argv: list[str] | None = None) -> int:
    parser = argparse.ArgumentParser(
        description="Replay B883/B885 into an experimental PUSCH BLER candidate"
    )
    parser.add_argument("--session-dir", required=True, type=Path)
    parser.add_argument("--config", default="configs/config.json", type=Path)
    parser.add_argument("--output", type=Path)
    parser.add_argument("--dll-dir", type=Path)
    parser.add_argument("--autocom-csv", type=Path)
    parser.add_argument("--comparison-output", type=Path)
    parser.add_argument("--skip-ddlcxx-probe", action="store_true")
    args = parser.parse_args(argv)

    output_path = args.output or args.session_dir / "pusch_bler_autocom_candidate.csv"
    summary = replay_pusch_bler(
        session_dir=args.session_dir,
        config_path=args.config,
        output_path=output_path,
        dll_dir=args.dll_dir,
    )
    config = load_config(args.config)
    actual_dll_dir = _resolve_dll_dir(config.runtime.dll_dir, args.dll_dir)
    if not args.skip_ddlcxx_probe:
        summary["ddlcxx_probe"] = probe_ddlcxx(
            dll_dir=actual_dll_dir,
            module_id=int(config.decoder.codec_module_id or config.device.eq_id),
        )
    if args.autocom_csv:
        comparison_path = (
            args.comparison_output
            or args.session_dir / "pusch_bler_autocom_comparison.csv"
        )
        summary["comparison"] = compare_with_autocom(
            candidate_path=output_path,
            autocom_path=args.autocom_csv,
            output_path=comparison_path,
        )
        print(f"comparison_output={comparison_path}")
    # Keep CLI output safe under the default Windows GBK console even when a
    # native worker returns a replacement character in an error message.
    print("summary=" + json.dumps(summary, ensure_ascii=True, sort_keys=True))
    print(f"output={output_path}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
