"""Shared exception and error-result models."""

from __future__ import annotations

from dataclasses import dataclass
from pathlib import Path


class RadioCaptureError(Exception):
    """Base class for capture errors."""


class ConfigurationError(RadioCaptureError):
    """Raised when user configuration is invalid."""


class PlatformError(RadioCaptureError):
    """Raised when the current process cannot load the target native DLLs."""


class SessionStateError(RadioCaptureError):
    """Raised on illegal capture session state transitions."""


class QueueOverflowError(RadioCaptureError):
    """Raised when callback backpressure policy requires stopping capture."""


class CaptureWorkerError(RadioCaptureError):
    """Raised when the background frame consumer stops unexpectedly."""


class DecodeError(RadioCaptureError):
    """Raised for codec calls that cannot be represented as a decoded record."""


@dataclass
class NativeCallError(RadioCaptureError):
    dll_path: Path | None
    export_name: str
    calling_convention: str
    state: str
    input_summary: str
    return_code: int | None = None
    win32_last_error: int | None = None
    session_id: str | None = None

    def __str__(self) -> str:
        return (
            f"{self.export_name} failed"
            f" state={self.state}"
            f" return_code={self.return_code}"
            f" last_error={self.win32_last_error}"
            f" dll={self.dll_path}"
            f" input={self.input_summary}"
        )
