"""Windows x86 DLL loading, export binding, and dependency checks."""

from __future__ import annotations

import ctypes as C
import os
import platform
import struct
import sys
from pathlib import Path

from radio_capture.errors import PlatformError


class Win32NativeLoader:
    """Small wrapper around Windows DLL loading and static MVP checks."""

    def __init__(self, dll_dir: str | Path):
        self.dll_dir = Path(dll_dir)
        self._libraries: list[C.CDLL] = []
        self._dll_directory_handle = None
        if platform.system() == "Windows":
            self._register_dll_search_path()
            self._ensure_native_cache_dir()

    def _ensure_native_cache_dir(self) -> None:
        """Create the cache location used by the Qualcomm native DLLs."""
        roots = {Path(sys.executable).resolve().parent}
        base_prefix = getattr(sys, "base_prefix", "")
        if base_prefix:
            roots.add(Path(base_prefix).resolve())
        for root in roots:
            cache_dir = root / "System" / "Cache"
            try:
                cache_dir.mkdir(parents=True, exist_ok=True)
            except OSError as exc:
                print(f"native cache directory unavailable: {cache_dir} ({exc})")

    def _register_dll_search_path(self) -> None:
        """Make same-directory plugins visible to native LoadLibrary calls."""
        if not self.dll_dir.exists():
            return
        directory = str(self.dll_dir.resolve())
        add_dll_directory = getattr(os, "add_dll_directory", None)
        if add_dll_directory is not None:
            self._dll_directory_handle = add_dll_directory(directory)
        current_path = os.environ.get("PATH", "")
        if directory.lower() not in {item.lower() for item in current_path.split(os.pathsep) if item}:
            os.environ["PATH"] = directory + os.pathsep + current_path

    def assert_x86_process(self) -> None:
        if platform.system() != "Windows":
            raise PlatformError("native capture requires Windows")
        if struct.calcsize("P") * 8 != 32:
            raise PlatformError("current DLLs are PE32; use 32-bit CPython")
        if C.sizeof(C.c_void_p) != 4:
            raise PlatformError("ctypes pointer size is not 32-bit")

    def validate_required_files(self, names: list[str]) -> None:
        missing = [name for name in names if not (self.dll_dir / name).exists()]
        if missing:
            raise PlatformError(f"missing DLL files in {self.dll_dir}: {', '.join(missing)}")

    def load(self, name: str) -> C.CDLL:
        path = self.dll_dir / name
        if not path.exists():
            raise PlatformError(f"DLL does not exist: {path}")
        lib = C.CDLL(str(path))
        self._libraries.append(lib)
        return lib

    def bind_exports(self, lib: C.CDLL, exports: dict[str, object]) -> dict[str, object]:
        """查找并绑定 DLL 函数地址"""
        bound: dict[str, object] = {}
        for export_name, prototype in exports.items():
            try:
                raw = getattr(lib, export_name)
            except AttributeError as exc:
                raise PlatformError(f"missing export {export_name}") from exc
            address = C.cast(raw, C.c_void_p).value
            if not address:
                raise PlatformError(f"export has null address: {export_name}")
            bound[export_name] = prototype(address)
        return bound
