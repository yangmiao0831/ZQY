"""Replay a metrics-only spool into a rebuilt DM metrics CSV."""

from __future__ import annotations

import argparse
import csv
import json
from collections import Counter
from pathlib import Path
from typing import Iterator

from radio_capture.config import load_config
from radio_capture.models import DecodedRecord, FrameEnvelope
from radio_capture.native.decoder import LogCodec
from radio_capture.pipeline.metrics import NR_METRIC_MSG_CODES
from radio_capture.pipeline.metrics_sink import MetricsCsvWriter
from radio_capture.pipeline.parser import FrameParser
from radio_capture.pipeline.queue import DiskSpoolFrameQueue


DEFAULT_REPLAY_CODES = frozenset({0xB821, 0xB97F})
BWP_COLUMNS = (
    "NR BWP Active Bandwidth DL[MHz]",
    "NR BWP Bandwidth[MHz]",
)


def parse_codes(value: str) -> set[int]:
    text = value.strip()
    if text.lower() == "all-metric":
        return set(NR_METRIC_MSG_CODES)
    if not text:
        return set(DEFAULT_REPLAY_CODES)
    codes: set[int] = set()
    for part in text.split(","):
        item = part.strip()
        if not item:
            continue
        codes.add(int(item, 0))
    return codes


def iter_spool_frames(session_dir: Path) -> Iterator[tuple[FrameEnvelope, int]]:
    spool_dir = session_dir / "spool"
    spool_paths = sorted(spool_dir.glob("spool-*.bin"))
    if not spool_paths:
        raise FileNotFoundError(f"no spool files found under {spool_dir}")

    session_id = session_dir.name
    header_struct = DiskSpoolFrameQueue._HEADER
    for spool_path in spool_paths:
        offset = 0
        with spool_path.open("rb") as stream:
            while True:
                header = stream.read(header_struct.size)
                if not header:
                    break
                if len(header) != header_struct.size:
                    raise RuntimeError(f"incomplete spool header at {spool_path}:{offset}")
                (
                    magic,
                    version,
                    sequence,
                    receive_time_ns,
                    native_cur_time,
                    log_type,
                    payload_length,
                ) = header_struct.unpack(header)
                if magic != DiskSpoolFrameQueue._MAGIC or version != 1:
                    raise RuntimeError(f"invalid spool record at {spool_path}:{offset}")
                payload = stream.read(payload_length)
                if len(payload) != payload_length:
                    raise RuntimeError(f"incomplete spool payload at {spool_path}:{offset}")
                yield (
                    FrameEnvelope(
                        session_id=session_id,
                        sequence=int(sequence),
                        receive_time_ns=int(receive_time_ns),
                        native_cur_time=int(native_cur_time),
                        log_type=int(log_type),
                        payload_length=int(payload_length),
                        payload=payload,
                    ),
                    offset,
                )
                offset += header_struct.size + payload_length


def replay_spool_metrics(
    *,
    session_dir: Path,
    config_path: Path,
    output_path: Path,
    dll_dir: Path | None = None,
    codes: set[int] | None = None,
) -> dict[str, int]:
    config = load_config(config_path)
    actual_dll_dir = _resolve_dll_dir(config.runtime.dll_dir, dll_dir)
    selected_codes = set(codes or DEFAULT_REPLAY_CODES)
    parser = FrameParser()
    codec = LogCodec(actual_dll_dir, config.decoder.dispatcher_dll)
    codec.load()
    codec.create(int(config.decoder.codec_module_id or config.device.eq_id))
    writer = MetricsCsvWriter(output_path, session_dir.name, write_interval_sec=0.0)
    writer.open(reset=True)

    counts: Counter[str] = Counter()
    code_counts: Counter[int] = Counter()
    try:
        for frame, _offset in iter_spool_frames(session_dir):
            counts["frames"] += 1
            msg_code = parser.extract_msg_code(frame.payload)
            if msg_code is None:
                counts["non_log_packets"] += 1
                continue
            code_counts[msg_code] += 1
            if msg_code not in selected_codes:
                continue
            counts["selected_frames"] += 1
            display_rc, display_format = codec.get_display_format(msg_code)
            detail_rc, detail = codec.get_detail(msg_code, frame.payload)
            if detail_rc != 0:
                counts["decoder_error"] += 1
                continue
            counts["decoder_ok"] += 1
            record = DecodedRecord(
                session_id=frame.session_id,
                sequence=frame.sequence,
                msg_code=msg_code,
                display_format=display_format if display_rc == 0 else None,
                return_code=detail_rc,
                detail=detail,
                receive_time_ns=frame.receive_time_ns,
            )
            if writer.write(record):
                counts["written_rows"] += 1
    finally:
        codec.close()
        writer.close()

    csv_summary = summarize_csv(output_path)
    counts.update(csv_summary)
    counts["distinct_msg_codes"] = len(code_counts)
    counts["b821_frames"] = code_counts.get(0xB821, 0)
    counts["b97f_frames"] = code_counts.get(0xB97F, 0)
    return {key: int(value) for key, value in counts.items()}


def summarize_csv(path: Path) -> dict[str, int]:
    rows = 0
    rows_with_bwp = 0
    if not path.exists():
        return {"csv_rows": 0, "rows_with_bwp": 0}
    with path.open(encoding="utf-8-sig", newline="") as stream:
        reader = csv.DictReader(stream)
        for row in reader:
            rows += 1
            if any((row.get(column) or "").strip() for column in BWP_COLUMNS):
                rows_with_bwp += 1
    return {"csv_rows": rows, "rows_with_bwp": rows_with_bwp}


def _resolve_dll_dir(config_dll_dir: Path, explicit_dll_dir: Path | None) -> Path:
    candidates = []
    if explicit_dll_dir is not None:
        candidates.append(explicit_dll_dir)
    candidates.append(config_dll_dir)
    candidates.append(Path.cwd() / "send" / "send" / "autocom_extracted" / "Bin")
    for candidate in candidates:
        path = Path(candidate)
        if path.exists():
            return path
    raise FileNotFoundError(
        "decoder DLL directory was not found; pass --dll-dir explicitly"
    )


def main(argv: list[str] | None = None) -> int:
    parser = argparse.ArgumentParser(
        description="Replay a metrics-only spool into a rebuilt DM metrics CSV"
    )
    parser.add_argument("--session-dir", required=True, type=Path)
    parser.add_argument("--config", default="configs/config.json", type=Path)
    parser.add_argument("--output", type=Path)
    parser.add_argument("--dll-dir", type=Path)
    parser.add_argument(
        "--codes",
        default="0xB821,0xB97F",
        help='comma-separated log codes, or "all-metric"',
    )
    args = parser.parse_args(argv)

    output_path = args.output or args.session_dir / "dm_metrics_bwp_replay.csv"
    summary = replay_spool_metrics(
        session_dir=args.session_dir,
        config_path=args.config,
        output_path=output_path,
        dll_dir=args.dll_dir,
        codes=parse_codes(args.codes),
    )
    print("summary=" + json.dumps(summary, ensure_ascii=False, sort_keys=True))
    print(f"output={output_path}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
