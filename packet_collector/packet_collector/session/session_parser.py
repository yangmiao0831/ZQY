"""Session pcapng parsing and JSONL merge workflow.

This module parses `session_dir/pcaps/*.pcapng` into per-file JSONL outputs
under `session_dir/packets`, then streams those files into a merged
`session_dir/packets.jsonl`. It does not analyze packets or implement replay.
"""

from __future__ import annotations

from pathlib import Path

from packet_collector.parsers.pcap_to_json import parse_pcap_to_jsonl
from packet_collector.session.session_manager import load_session_meta, update_session_meta


def merge_jsonl_files(jsonl_files: list[Path], output_file: Path) -> Path:
    """Merge JSONL files into one output without loading them into memory."""
    output_file.parent.mkdir(parents=True, exist_ok=True)
    with output_file.open("w", encoding="utf-8") as output:
        for jsonl_file in sorted(jsonl_files):
            with jsonl_file.open("r", encoding="utf-8") as source:
                for line in source:
                    stripped = line.strip()
                    if not stripped:
                        continue
                    output.write(stripped + "\n")
    return output_file


def parse_session(session_dir: Path, packet_type: str, force: bool = False) -> Path:
    """Parse all session pcapng files and create a merged packets.jsonl."""
    meta = load_session_meta(session_dir)
    pcaps_dir = Path(str(meta.get("pcaps_dir") or session_dir / "pcaps"))
    packets_dir = Path(str(meta.get("packets_dir") or session_dir / "packets"))
    merged_packets_jsonl = Path(str(meta.get("merged_packets_jsonl") or session_dir / "packets.jsonl"))
    pcaps = sorted(pcaps_dir.glob("*.pcapng"))
    packets_dir.mkdir(parents=True, exist_ok=True)
    jsonl_files: list[Path] = []

    try:
        for pcap_file in pcaps:
            output_file = packets_dir / f"{pcap_file.stem}.jsonl"
            if output_file.exists() and not force:
                jsonl_files.append(output_file)
                continue
            parse_pcap_to_jsonl(pcap_file, output_file, packet_type)
            jsonl_files.append(output_file)

        merge_jsonl_files(jsonl_files, merged_packets_jsonl)
    except Exception as exc:
        update_session_meta(
            session_dir,
            {
                "parse_status": "failed",
                "parse_error": str(exc),
            },
        )
        raise

    update_session_meta(
        session_dir,
        {
            "parse_status": "completed",
            "packet_type": packet_type,
            "pcap_files": [str(path) for path in pcaps],
            "packet_jsonl_files": [str(path) for path in sorted(jsonl_files)],
            "merged_packets_jsonl": str(merged_packets_jsonl),
            "parse_error": None,
        },
    )
    return merged_packets_jsonl
