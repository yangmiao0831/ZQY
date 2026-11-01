"""Raw binary and JSONL index writers."""

from __future__ import annotations

import json
from pathlib import Path

from radio_capture.models import FrameEnvelope
from radio_capture.pipeline.frame import frame_index_record, pack_frame


class RawWriter:
    def __init__(self, raw_dir: str | Path, session_id: str):
        self.session_dir = Path(raw_dir) / session_id
        self.session_dir.mkdir(parents=True, exist_ok=True)
        self.bin_path = self.session_dir / "frames-000001.bin"
        self.index_path = self.session_dir / "frames-000001.jsonl"
        self._bin = None
        self._index = None

    def open(self) -> None:
        self._bin = self.bin_path.open("ab")
        self._index = self.index_path.open("a", encoding="utf-8")

    def write(self, frame: FrameEnvelope) -> None:
        if self._bin is None or self._index is None:
            raise RuntimeError("RawWriter is not open")
        offset = self._bin.tell()
        self._bin.write(pack_frame(frame))
        self._index.write(json.dumps(frame_index_record(frame, offset), ensure_ascii=False) + "\n")

    def flush(self) -> None:
        """缓冲区里的内容强制刷到文件对象"""
        if self._bin:
            self._bin.flush()
        if self._index:
            self._index.flush()

    def close(self) -> None:
        self.flush()
        if self._bin:
            self._bin.close()
            self._bin = None
        if self._index:
            self._index.close()
            self._index = None

