"""Streaming JSONL sink for decoded Qualcomm records."""

from __future__ import annotations

import json
from pathlib import Path

from radio_capture.models import DecodedRecord


class DecodedJsonlWriter:
    def __init__(self, path: str | Path, fallback_suffix: str | None = None):
        self.path = Path(path)
        self.fallback_suffix = fallback_suffix
        self._file = None

    def open(self) -> None:
        self.path.parent.mkdir(parents=True, exist_ok=True)
        try:
            self._file = self.path.open("a", encoding="utf-8")
        except PermissionError:
            if not self.fallback_suffix:
                raise
            self.path = self.path.with_name(
                f"{self.path.stem}-{self.fallback_suffix}{self.path.suffix}"
            )
            print(f"decoded JSONL is locked; using fallback={self.path}")
            self._file = self.path.open("a", encoding="utf-8")

    def write(self, record: DecodedRecord) -> None:
        if self._file is None:
            raise RuntimeError("decoded JSONL writer is not open")
        row = {
            "session_id": record.session_id,
            "sequence": record.sequence,
            "msg_code": record.msg_code,
            "display_format": record.display_format,
            "return_code": record.return_code,
            "detail_length": len(record.detail) if record.detail else 0,
            "detail_text": (
                record.detail.decode("utf-8", errors="replace")
                if record.detail and record.return_code == 0
                else ""
            ),
            "error": record.error,
        }
        self._file.write(json.dumps(row, ensure_ascii=False) + "\n")
        self._file.flush()

    def close(self) -> None:
        if self._file is not None:
            self._file.close()
        self._file = None
