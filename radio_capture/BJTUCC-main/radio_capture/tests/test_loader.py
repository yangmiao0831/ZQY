"""Tests for DLL loader checks and export binding."""

from pathlib import Path

from radio_capture.native.win32_loader import Win32NativeLoader


def test_validate_required_files(tmp_path: Path):
    dll = tmp_path / "demo.dll"
    dll.write_bytes(b"")
    loader = Win32NativeLoader(tmp_path)
    loader.validate_required_files(["demo.dll"])

