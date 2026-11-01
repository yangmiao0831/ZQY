"""Start-log and logmask control over the native TDCCommandInfo API."""

from __future__ import annotations

from dataclasses import dataclass
from pathlib import Path

from radio_capture.models import LogmaskConfig, ShutdownCommandConfig, ShutdownConfig


def _decode_hex(value: str, field_name: str = "logmask.payload_hex") -> bytes:
    text = value.strip().replace("0x", "").replace("0X", "")
    text = text.replace(",", " ").replace("_", " ")
    try:
        return bytes.fromhex(text)
    except ValueError as exc:
        raise ValueError(f"{field_name} is not valid hexadecimal") from exc


@dataclass(frozen=True)
class LogmaskCommand:
    type_id: int
    payload: bytes


class StartLogController:
    """Apply the configured logmask and expose a resend operation.

    The reference application's StartLog implementation is protected in the
    recovered source.  Therefore the native command type and payload remain
    explicit configuration instead of being guessed here.
    """

    def __init__(
        self,
        controller,
        config: LogmaskConfig,
        shutdown: ShutdownConfig | None = None,
    ):
        self.controller = controller
        self.config = config
        self.shutdown = shutdown or ShutdownConfig()
        self._command: LogmaskCommand | None = None
        self._prepared = False

    def prepare(self) -> None:
        if self._prepared:
            return
        mode = self.config.mode.lower()
        if mode == "file":
            path = self.config.file
            if path is None:
                raise ValueError("logmask.file is required for file mode")
            payload = Path(path).read_bytes()
            if not payload:
                raise ValueError(f"logmask file is empty: {path}")
            if self.config.command_type is None:
                raise ValueError("logmask.command_type is required for file mode")
            self._command = LogmaskCommand(self.config.command_type, payload)
        elif mode == "command":
            if self.config.command_type is None or not self.config.payload_hex:
                raise ValueError("command mode requires command_type and payload_hex")
            self._command = LogmaskCommand(
                self.config.command_type,
                _decode_hex(self.config.payload_hex, "logmask.payload_hex"),
            )
        elif mode in {"default", "native", "disabled", "qwinlog"}:
            self._command = None
        else:
            raise ValueError(f"unsupported logmask mode: {self.config.mode}")
        self._prepared = True

    @property
    def configured(self) -> bool:
        self.prepare()
        return self._command is not None

    def start(self) -> int | None:
        self.prepare()
        if self._command is None:
            if self.config.mode.lower() in {"default", "native"}:
                rc = int(self.controller.send_chip_info())
                print(
                    f"start_log built_in_default chip_info rc={rc} "
                    f"rc_hex=0x{rc & 0xFFFFFFFF:08X}"
                )
                return rc
            return None
        rc = int(self.controller.send_command(self._command.type_id, self._command.payload))
        print(
            f"start_log logmask type={self._command.type_id} length={len(self._command.payload)} "
            f"rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}"
        )
        return rc

    def resend(self) -> int | None:
        """Re-send the exact same mask after a no-data interval."""
        if self.config.mode.lower() in {"default", "native"}:
            return self.start()
        if not self.configured:
            return None
        return self.start()

    @staticmethod
    def _shutdown_command(command: ShutdownCommandConfig | None, name: str, controller) -> int | None:
        if command is None:
            print(f"shutdown {name}=not_configured")
            return None
        payload = _decode_hex(command.payload_hex, f"shutdown.{name}.payload_hex")
        rc = int(controller.send_command(command.type_id, payload))
        print(
            f"shutdown {name} type={command.type_id} length={len(payload)} "
            f"rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}"
        )
        return rc

    def stop_log(self) -> int | None:
        """Send a verified StopLog command, if one is configured."""
        return self._shutdown_command(self.shutdown.stop_log, "stop_log", self.controller)

    def restore_logmask(self) -> int | None:
        """Restore a verified pre-capture mask, if one is configured."""
        return self._shutdown_command(
            self.shutdown.restore_logmask,
            "restore_logmask",
            self.controller,
        )

    def device_reset(self) -> int | None:
        """Send a verified device-reset command, if one is configured."""
        return self._shutdown_command(
            self.shutdown.device_reset,
            "device_reset",
            self.controller,
        )
