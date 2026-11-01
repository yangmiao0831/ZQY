"""Capture session state machine definitions."""

from __future__ import annotations

from enum import Enum

from radio_capture.errors import SessionStateError


class CaptureState(str, Enum):
    NEW = "NEW"
    CONFIG_LOADED = "CONFIG_LOADED"
    DLL_LOADED = "DLL_LOADED"
    INSTANCE_CREATED = "INSTANCE_CREATED"
    PORTS_CONFIGURED = "PORTS_CONFIGURED"
    CONNECTED = "CONNECTED"
    CAPTURING = "CAPTURING"
    STOPPING = "STOPPING"
    CLOSED = "CLOSED"
    ERROR = "ERROR"


ALLOWED_TRANSITIONS = {
    CaptureState.NEW: {CaptureState.CONFIG_LOADED, CaptureState.ERROR},
    CaptureState.CONFIG_LOADED: {CaptureState.DLL_LOADED, CaptureState.ERROR},
    CaptureState.DLL_LOADED: {CaptureState.INSTANCE_CREATED, CaptureState.ERROR},
    CaptureState.INSTANCE_CREATED: {CaptureState.PORTS_CONFIGURED, CaptureState.STOPPING, CaptureState.ERROR},
    CaptureState.PORTS_CONFIGURED: {CaptureState.CONNECTED, CaptureState.STOPPING, CaptureState.ERROR},
    CaptureState.CONNECTED: {CaptureState.CAPTURING, CaptureState.STOPPING, CaptureState.ERROR},
    CaptureState.CAPTURING: {CaptureState.STOPPING, CaptureState.ERROR},
    CaptureState.STOPPING: {CaptureState.CLOSED, CaptureState.ERROR},
    CaptureState.CLOSED: set(),
    CaptureState.ERROR: {CaptureState.STOPPING, CaptureState.CLOSED},
}


def ensure_transition(current: CaptureState, target: CaptureState) -> None:
    if target not in ALLOWED_TRANSITIONS[current]:
        raise SessionStateError(f"illegal transition: {current.value} -> {target.value}")

