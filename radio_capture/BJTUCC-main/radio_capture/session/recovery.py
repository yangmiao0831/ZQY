"""Disconnect, reconnect, timeout, and recovery policies."""

from __future__ import annotations

from dataclasses import dataclass


@dataclass(frozen=True)
class RecoveryPolicy:
    reconnect: bool
    heartbeat_sec: int | None
    disconnect_timeout_ms: int = 10000

