from pathlib import Path

from radio_capture.models import LogmaskConfig, ShutdownCommandConfig, ShutdownConfig
from radio_capture.session.log_control import StartLogController


class FakeController:
    def __init__(self):
        self.commands = []
        self.chip_info_calls = 0

    def send_command(self, type_id, payload):
        self.commands.append((type_id, payload))
        return 0

    def send_chip_info(self):
        self.chip_info_calls += 1
        return 0


def test_command_logmask_is_sent_and_can_be_resent():
    controller = FakeController()
    start_log = StartLogController(
        controller,
        LogmaskConfig(mode="command", command_type=7, payload_hex="0x01 02 0a"),
    )

    assert start_log.start() == 0
    assert start_log.resend() == 0
    assert controller.commands == [(7, b"\x01\x02\x0a"), (7, b"\x01\x02\x0a")]


def test_file_logmask_is_loaded_once(tmp_path: Path):
    mask = tmp_path / "mask.bin"
    mask.write_bytes(b"mask")
    controller = FakeController()
    start_log = StartLogController(
        controller,
        LogmaskConfig(mode="file", file=mask, command_type=9),
    )

    assert start_log.start() == 0
    assert start_log.configured
    assert controller.commands == [(9, b"mask")]


def test_default_logmask_uses_native_builtin_start():
    controller = FakeController()
    start_log = StartLogController(controller, LogmaskConfig(mode="default"))

    assert start_log.start() == 0
    assert controller.commands == []
    assert controller.chip_info_calls == 1


def test_native_start_log_uses_controller_chip_info_entry():
    controller = FakeController()
    start_log = StartLogController(controller, LogmaskConfig(mode="native"))

    assert start_log.start() == 0
    assert start_log.resend() == 0
    assert controller.chip_info_calls == 2


def test_verified_shutdown_commands_are_sent_in_order():
    controller = FakeController()
    start_log = StartLogController(
        controller,
        LogmaskConfig(mode="disabled"),
        ShutdownConfig(
            stop_log=ShutdownCommandConfig(1, "01"),
            restore_logmask=ShutdownCommandConfig(2, "02 03"),
            device_reset=ShutdownCommandConfig(3, "04"),
        ),
    )

    assert start_log.stop_log() == 0
    assert start_log.restore_logmask() == 0
    assert start_log.device_reset() == 0
    assert controller.commands == [
        (1, b"\x01"),
        (2, b"\x02\x03"),
        (3, b"\x04"),
    ]
