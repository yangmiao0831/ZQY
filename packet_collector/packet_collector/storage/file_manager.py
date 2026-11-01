"""File management helpers.

These helpers copy pcapng files from the temporary dumpcap directory into the
final task directory without reading capture contents into memory.
"""

from __future__ import annotations

import shutil
from pathlib import Path


def ensure_dir(path: Path) -> Path:
    """Create a directory if needed and return it."""
    path.mkdir(parents=True, exist_ok=True)
    return path


def copy_file(src: Path, dst: Path) -> Path:
    """Copy a file to an explicit destination path."""
    dst.parent.mkdir(parents=True, exist_ok=True)
    shutil.copy2(src, dst)
    return dst


def find_matching_files(directory: Path, stem: str, suffix: str = ".pcapng") -> list[Path]:
    """Find files whose names start with `stem` and end with `suffix`."""
    return sorted(directory.glob(f"{stem}*{suffix}"))


def copy_files_to_dir(files: list[Path], target_dir: Path) -> list[Path]:
    """Copy files into a target directory and return destination paths."""
    ensure_dir(target_dir)
    return [copy_file(src, target_dir / src.name) for src in files]


def cleanup_tmp_placeholder(tmp_dir: Path) -> None:
    """Placeholder for future temporary capture cleanup."""
    print(f"TODO: clean temporary capture directory after review: {tmp_dir}")
