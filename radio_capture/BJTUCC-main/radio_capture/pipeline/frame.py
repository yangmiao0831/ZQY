"""Frame envelope helpers and raw frame utilities."""

from __future__ import annotations

import struct

from radio_capture.models import FrameEnvelope

HEADER_STRUCT = struct.Struct("<QQQiq")


def pack_frame(frame: FrameEnvelope) -> bytes:
    """把 FrameEnvelope 再打包成 header + payload 写入 frames-000001.bin,封装成落盘的二进制格式"""
    payload = frame.payload
    header = HEADER_STRUCT.pack(
        int(frame.sequence),
        int(frame.receive_time_ns),
        int(frame.native_cur_time),
        int(frame.log_type),
        int(frame.payload_length),
    )
    return header + payload


def frame_index_record(frame: FrameEnvelope, offset: int) -> dict[str, int | str]:
    return {
        "session_id": frame.session_id,
        "sequence": frame.sequence,
        "offset": offset,
        "receive_time_ns": frame.receive_time_ns,
        "native_cur_time": frame.native_cur_time,
        "log_type": frame.log_type,
        "payload_length": frame.payload_length,
    }

