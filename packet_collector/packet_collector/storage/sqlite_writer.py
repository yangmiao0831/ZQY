"""SQLite storage writer placeholder.

Future implementation will persist tasks, packet summaries, active probe
results, and device metrics into a lightweight SQLite database.
"""

from __future__ import annotations

from pathlib import Path


def init_sqlite_placeholder(db_path: Path) -> Path:
    """Initialize a SQLite database placeholder."""
    print(f"TODO: initialize SQLite database at {db_path}")
    return db_path
