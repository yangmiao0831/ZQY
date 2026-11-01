"""Tests for the foreground capture lifetime."""

from __future__ import annotations

from types import SimpleNamespace
from unittest.mock import patch

from radio_capture.main import main


def test_main_waits_after_connect_before_stopping():
    events: list[str] = []

    class FakeSession:
        def __init__(self, _config):
            self.context = SimpleNamespace(session_id="session-1")
            self.connect_return_code = None
            self.frame_queue = SimpleNamespace(
                stats=SimpleNamespace(enqueued=1, dequeued=1, dropped=0)
            )
            self.raw_writer = SimpleNamespace(session_dir="raw/session-1")

        def open(self):
            events.append("open")

        def configure_ports(self):
            events.append("configure_ports")

        def start_workers(self):
            events.append("start_workers")

        def connect(self):
            events.append("connect")
            self.connect_return_code = 0

        def wait(self):
            events.append("wait")
            raise KeyboardInterrupt

        def stop(self):
            events.append("stop")

    with (
        patch("radio_capture.main.load_config", return_value=object()),
        patch("radio_capture.main.ProfileResolver") as resolver,
        patch("radio_capture.main.CaptureSession", FakeSession),
    ):
        resolver.return_value.resolve.return_value = SimpleNamespace()
        assert main(["--config", "unused.json"]) == 0

    assert events == ["open", "configure_ports", "start_workers", "connect", "wait", "stop"]
