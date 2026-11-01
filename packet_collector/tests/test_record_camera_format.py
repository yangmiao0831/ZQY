from __future__ import annotations

from datetime import datetime
from pathlib import Path

import pytest

from video.record_camera import LatestPreviewFrame, _open_writer, default_output_file


class _Writer:
    def __init__(self) -> None:
        self.open_args = None

    def open(self, *args) -> None:
        self.open_args = args

    def isOpened(self) -> bool:
        return True

    def release(self) -> None:
        pass


class _Cv2:
    CAP_FFMPEG = 1900
    CAP_ANY = 0

    def __init__(self) -> None:
        self.fourcc_values: list[str] = []
        self.writer = _Writer()

    def VideoWriter_fourcc(self, *characters: str) -> str:
        value = "".join(characters)
        self.fourcc_values.append(value)
        return value

    def VideoWriter(self) -> _Writer:
        return self.writer


def test_default_output_is_mp4(tmp_path: Path) -> None:
    output = default_output_file(tmp_path, datetime(2026, 10, 7, 8, 9, 10))

    assert output == tmp_path / "recording_20261007_080910.mp4"


def test_mp4_output_uses_mp4v_codec(tmp_path: Path) -> None:
    cv2 = _Cv2()

    _open_writer(tmp_path / "recording.mp4", cv2, 20.0, (640, 480))

    assert cv2.fourcc_values == ["mp4v"]


def test_unsupported_video_extension_is_rejected(tmp_path: Path) -> None:
    with pytest.raises(RuntimeError, match="extension"):
        _open_writer(tmp_path / "recording.mkv", _Cv2(), 20.0, (640, 480))


def test_preview_health_requires_a_published_frame() -> None:
    frames = LatestPreviewFrame()

    assert frames.status() == (0, None)
    frames.publish(b"jpeg")
    sequence, age = frames.status()

    assert sequence == 1
    assert age is not None
    assert 0 <= age < 1
