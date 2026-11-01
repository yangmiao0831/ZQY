"""pcapng to JSONL packet record conversion.

This module converts tshark `-T fields` lines into normalized JSONL packet
records. It streams records to disk and does not compute protocol summaries.
"""

from __future__ import annotations

import json
import re
from collections.abc import Iterator
from pathlib import Path

from packet_collector.parsers.tshark_fields import FieldSpec, get_display_filter, get_fields_for_packet_type
from packet_collector.parsers.tshark_runner import build_tshark_fields_command, run_tshark_stream


_INT_RE = re.compile(r"^[+-]?\d+$")
_FLOAT_RE = re.compile(r"^[+-]?(?:\d+\.\d*|\.\d+|\d+\.)(?:[eE][+-]?\d+)?$|^[+-]?\d+[eE][+-]?\d+$")


def convert_value(value: str) -> object:
    """Convert a tshark field string into a JSON-friendly value."""
    if value == "":
        return None
    if value.lower() == "true":
        return True
    if value.lower() == "false":
        return False
    if _INT_RE.fullmatch(value):
        return int(value)
    if _FLOAT_RE.fullmatch(value):
        return float(value)
    return value


def parse_tshark_line(line: str, fields: list[FieldSpec], packet_type: str, pcap_file: Path) -> dict[str, object]:
    """Parse one tshark `-T fields` output line into a packet record."""
    values = line.rstrip("\n").split("|")
    if len(values) < len(fields):
        values.extend([""] * (len(fields) - len(values)))

    record: dict[str, object] = {
        "packet_type": packet_type,
        "pcap_file": str(pcap_file),
    }
    for (json_name, _), value in zip(fields, values):
        converted = convert_value(value)
        if json_name in record and record[json_name] is not None and converted is None:
            continue
        record[json_name] = converted
    return record


def _iter_pcap_records(pcap_file: Path, packet_type: str) -> Iterator[dict[str, object]]:
    """Yield packet records parsed from one pcapng file."""
    fields = get_fields_for_packet_type(packet_type)
    display_filter = get_display_filter(packet_type)
    command = build_tshark_fields_command(pcap_file, fields, display_filter)
    for line in run_tshark_stream(command):
        yield parse_tshark_line(line, fields, packet_type, pcap_file)


def parse_pcap_to_jsonl(pcap_file: Path, output_file: Path, packet_type: str) -> Path:
    """Parse one pcapng file into JSONL packet records."""
    return parse_pcap_files_to_jsonl([pcap_file], output_file, packet_type)


def parse_pcap_files_to_jsonl(pcap_files: list[Path], output_file: Path, packet_type: str) -> Path:
    """Parse multiple pcapng files into one JSONL output file."""
    output_file.parent.mkdir(parents=True, exist_ok=True)
    with output_file.open("w", encoding="utf-8") as file:
        for pcap_file in pcap_files:
            for record in _iter_pcap_records(pcap_file, packet_type):
                file.write(json.dumps(record, ensure_ascii=False) + "\n")
    return output_file


def parse_pcap_to_jsonl_placeholder(pcap_file: Path, output_file: Path, packet_type: str) -> Path:
    """Backward-compatible wrapper for Step 1 placeholder callers."""
    return parse_pcap_to_jsonl(pcap_file, output_file, packet_type)
