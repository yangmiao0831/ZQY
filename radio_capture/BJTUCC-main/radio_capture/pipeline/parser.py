"""FrameParser logic for msg_code and payload extraction."""

from __future__ import annotations

from radio_capture.models import DecodeRequest, FrameEnvelope


class FrameParser:
    """Extract the Qualcomm log code from a callback payload when present."""

    def parse(self, frame: FrameEnvelope, eq_id: int, module_id: int) -> DecodeRequest:
        """从帧里提取解码需要的信息"""
        msg_code = self.extract_msg_code(frame.payload)
        return DecodeRequest(
            session_id=frame.session_id,
            sequence=frame.sequence,
            eq_id=eq_id,
            module_id=module_id,
            msg_code=msg_code,
            payload=frame.payload,
        )

    @staticmethod
    def extract_msg_code(payload: bytes) -> int | None:
        """Return the code from a Qualcomm 0x10 log packet, otherwise None."""
        if len(payload) < 16 or payload[0] != 0x10:
            return None
        declared_length = int.from_bytes(payload[2:4], "little")
        repeated_length = int.from_bytes(payload[4:6], "little")
        if declared_length + 4 != len(payload) or repeated_length != declared_length:
            return None
        return int.from_bytes(payload[6:8], "little")
