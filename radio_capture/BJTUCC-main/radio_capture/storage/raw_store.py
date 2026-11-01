"""Raw file layout, session directories, and replay access."""

from __future__ import annotations

from pathlib import Path


class RawStore:
    def __init__(self, root: str | Path):
        self.root = Path(root)

    def session_dir(self, session_id: str) -> Path:
        return self.root / session_id

