"""Replay a raw capture directory through the parser and native log codec."""

from __future__ import annotations

import argparse
import json
import struct
from collections import Counter
from pathlib import Path

from radio_capture.config import load_config
from radio_capture.models import DecodedRecord, FrameEnvelope
from radio_capture.native.decoder import LogCodec
from radio_capture.pipeline.parser import FrameParser
from radio_capture.pipeline.metrics_sink import MetricsCsvWriter
from radio_capture.storage.sqlite_store import SQLiteStore


HEADER_STRUCT = struct.Struct("<QQQiq")


def _iter_frames(raw_dir: Path):
    index_path = raw_dir / "frames-000001.jsonl"
    bin_path = raw_dir / "frames-000001.bin"
    data = bin_path.read_bytes()
    for line in index_path.read_text(encoding="utf-8").splitlines():
        if not line.strip():
            continue
        row = json.loads(line)
        offset = int(row["offset"])
        sequence, receive_time_ns, native_cur_time, log_type, payload_length = HEADER_STRUCT.unpack_from(
            data, offset
        )
        payload_start = offset + HEADER_STRUCT.size
        payload = data[payload_start : payload_start + payload_length]
        if len(payload) != payload_length:
            raise ValueError(f"truncated frame sequence={sequence}")
        yield FrameEnvelope(
            session_id=str(row["session_id"]),
            sequence=int(sequence),
            receive_time_ns=int(receive_time_ns),
            native_cur_time=int(native_cur_time),
            log_type=int(log_type),
            payload_length=int(payload_length),
            payload=payload,
        ), offset


def replay(
    raw_dir: Path,
    config_path: Path,
    output_path: Path,
    use_decoder: bool = True,
    metrics_csv: Path | None = None,
) -> dict[str, int]:
    config = load_config(config_path)
    parser = FrameParser()
    codec = None
    if use_decoder:
        codec = LogCodec(config.runtime.dll_dir, config.decoder.dispatcher_dll)
        codec.load()
        codec.create(int(config.decoder.codec_module_id or config.device.eq_id))
    store = SQLiteStore(config.output.sqlite_file)
    store.open()
    metrics_writer = MetricsCsvWriter(metrics_csv or raw_dir / "nr_metrics.csv")
    metrics_writer.open(reset=True)

    counts: Counter[str] = Counter()
    code_counts: Counter[int] = Counter()
    output_path.parent.mkdir(parents=True, exist_ok=True)
    try:
        with output_path.open("w", encoding="utf-8") as output:
            for frame, offset in _iter_frames(raw_dir):
                request = parser.parse(frame, config.device.eq_id, int(config.decoder.codec_module_id or config.device.eq_id))
                record = {
                    "session_id": frame.session_id,
                    "sequence": frame.sequence,
                    "offset": offset,
                    "log_type": frame.log_type,
                    "payload_length": frame.payload_length,
                    "msg_code": request.msg_code,
                    "payload_head_hex": frame.payload[:32].hex(" "),
                }
                counts["frames"] += 1
                if request.msg_code is None:
                    counts["non_log_packets"] += 1
                else:
                    counts["log_packets"] += 1
                    code_counts[request.msg_code] += 1
                    if codec is not None:
                        display_rc, display_format = codec.get_display_format(request.msg_code)
                        detail_rc, detail = codec.get_detail(request.msg_code, request.payload)
                        record.update(
                            {
                                "display_rc": display_rc,
                                "display_format": display_format,
                                "detail_rc": detail_rc,
                                "detail_length": len(detail) if detail_rc == 0 else 0,
                                "detail_head_hex": detail[:32].hex(" ") if detail_rc == 0 else "",
                                "detail_text": (
                                    detail.decode("utf-8", errors="replace")
                                    if detail_rc == 0
                                    else ""
                                ),
                            }
                        )
                        store.insert_decoded_record(
                            DecodedRecord(
                                session_id=frame.session_id,
                                sequence=frame.sequence,
                                msg_code=request.msg_code,
                                display_format=display_format if display_rc == 0 else None,
                                return_code=detail_rc,
                                detail=detail if detail_rc == 0 else None,
                                error=None if detail_rc == 0 else f"decoder return code {detail_rc}",
                                receive_time_ns=frame.receive_time_ns,
                            )
                        )
                        metrics_writer.write(
                            DecodedRecord(
                                session_id=frame.session_id,
                                sequence=frame.sequence,
                                msg_code=request.msg_code,
                                display_format=display_format if display_rc == 0 else None,
                                return_code=detail_rc,
                                detail=detail if detail_rc == 0 else None,
                                receive_time_ns=frame.receive_time_ns,
                            )
                        )
                        counts["decoder_ok" if detail_rc == 0 else "decoder_error"] += 1
                output.write(json.dumps(record, ensure_ascii=False) + "\n")
    finally:
        if codec is not None:
            codec.close()
        metrics_writer.close()
        store.commit()
        store.close()

    for code, count in code_counts.most_common(20):
        print(f"msg_code=0x{code:04X} count={count}")
    summary = {key: int(value) for key, value in counts.items()}
    print(f"parsed raw_dir={raw_dir}")
    print("summary=" + json.dumps(summary, ensure_ascii=False, sort_keys=True))
    print(f"output={output_path}")
    print(f"metrics_csv={metrics_writer.path}")
    return summary


def main(argv: list[str] | None = None) -> int:
    parser = argparse.ArgumentParser(description="Replay a raw radio capture")
    parser.add_argument("--config", required=True)
    parser.add_argument("--raw-dir", required=True, type=Path)
    parser.add_argument("--output", type=Path)
    parser.add_argument("--no-decoder", action="store_true")
    parser.add_argument("--metrics-csv", type=Path)
    args = parser.parse_args(argv)
    output = args.output or args.raw_dir / "parsed.jsonl"
    replay(
        args.raw_dir,
        Path(args.config),
        output,
        use_decoder=not args.no_decoder,
        metrics_csv=args.metrics_csv,
    )
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
