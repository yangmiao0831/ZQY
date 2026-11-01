"""Tests for responsive configured-capture process waiting."""

from __future__ import annotations

import subprocess

import pytest

from packet_collector.cli import _raise_keyboard_interrupt
from packet_collector.orchestration.configured_capture import (
    _wait_for_process_interruptibly,
)


def test_wait_for_process_uses_short_timeouts() -> None:
    """The Windows-facing wait loop never blocks indefinitely."""
    timeouts: list[float | None] = []

    class FakeProcess:
        def wait(self, timeout: float | None = None) -> int:
            timeouts.append(timeout)
            if len(timeouts) == 1:
                raise subprocess.TimeoutExpired("capture", timeout)
            return 0

    assert _wait_for_process_interruptibly(FakeProcess(), poll_interval=0.05) == 0  # type: ignore[arg-type]
    assert timeouts == [0.05, 0.05]


def test_wait_for_process_propagates_keyboard_interrupt() -> None:
    """Ctrl+C reaches the orchestration handler immediately."""

    class FakeProcess:
        def wait(self, timeout: float | None = None) -> int:
            raise KeyboardInterrupt

    try:
        _wait_for_process_interruptibly(FakeProcess())  # type: ignore[arg-type]
    except KeyboardInterrupt:
        pass
    else:
        raise AssertionError("KeyboardInterrupt was swallowed")


def test_windows_break_handler_raises_keyboard_interrupt() -> None:
    """A forwarded CTRL_BREAK follows the capture graceful-stop path."""
    with pytest.raises(KeyboardInterrupt):
        _raise_keyboard_interrupt(0, None)
