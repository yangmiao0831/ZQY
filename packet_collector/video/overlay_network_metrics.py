#!/usr/bin/env python3
"""Render timestamp-aligned network metrics onto a recorded camera video."""

from __future__ import annotations

import argparse
from bisect import bisect_right
import csv
from dataclasses import dataclass
from datetime import datetime
from pathlib import Path
from typing import Any


@dataclass(frozen=True)
class NetworkMetric:
    timestamp: datetime
    avg_rtt_ms: float | None
    jitter_ms: float | None
    throughput_bps: float | None
    loss_rate: float | None


def parse_local_timestamp(value: str) -> datetime:
    """Parse the local timestamps emitted by the camera and network collector."""
    text = value.strip()
    if text.endswith("Z"):
        text = f"{text[:-1]}+00:00"
    parsed = datetime.fromisoformat(text)
    if parsed.tzinfo is not None:
        parsed = parsed.astimezone().replace(tzinfo=None)
    return parsed


def optional_float(value: str | None) -> float | None:
    if value is None or not value.strip():
        return None
    try:
        return float(value)
    except ValueError:
        return None


def load_frame_timestamps(csv_file: Path) -> list[datetime]:
    with csv_file.open("r", encoding="utf-8-sig", newline="") as handle:
        reader = csv.DictReader(handle)
        if not reader.fieldnames or "timestamp" not in reader.fieldnames:
            raise RuntimeError(f"frame timestamp CSV has no timestamp column: {csv_file}")
        timestamps = [
            parse_local_timestamp(row["timestamp"])
            for row in reader
            if (row.get("timestamp") or "").strip()
        ]
    if not timestamps:
        raise RuntimeError(f"frame timestamp CSV is empty: {csv_file}")
    return timestamps


def load_network_metrics(csv_file: Path) -> list[NetworkMetric]:
    with csv_file.open("r", encoding="utf-8-sig", newline="") as handle:
        reader = csv.DictReader(handle)
        required = {"timestamp", "avg_rtt_ms", "jitter_ms", "throughput_bps", "loss_rate"}
        if not reader.fieldnames or not required.issubset(reader.fieldnames):
            missing = ", ".join(sorted(required.difference(reader.fieldnames or [])))
            raise RuntimeError(f"network metrics CSV is missing columns: {missing}")
        metrics = [
            NetworkMetric(
                timestamp=parse_local_timestamp(row["timestamp"]),
                avg_rtt_ms=optional_float(row.get("avg_rtt_ms")),
                jitter_ms=optional_float(row.get("jitter_ms")),
                throughput_bps=optional_float(row.get("throughput_bps")),
                loss_rate=optional_float(row.get("loss_rate")),
            )
            for row in reader
            if (row.get("timestamp") or "").strip()
        ]
    metrics.sort(key=lambda item: item.timestamp)
    if not metrics:
        raise RuntimeError(f"network metrics CSV has no valid rows: {csv_file}")
    return metrics


class MetricTimeline:
    def __init__(self, metrics: list[NetworkMetric], max_age_seconds: float = 2.0) -> None:
        self.metrics = metrics
        self.timestamps = [item.timestamp for item in metrics]
        self.max_age_seconds = max_age_seconds

    def at(self, frame_time: datetime) -> NetworkMetric | None:
        index = bisect_right(self.timestamps, frame_time) - 1
        if index < 0:
            return None
        metric = self.metrics[index]
        age = (frame_time - metric.timestamp).total_seconds()
        if age < 0 or age > self.max_age_seconds:
            return None
        return metric


def _load_cv2() -> Any:
    try:
        import cv2
    except ImportError as exc:
        raise RuntimeError("OpenCV is required to render the metrics video") from exc
    return cv2


def _display_lines(frame_time: datetime, metric: NetworkMetric | None) -> list[str]:
    def number(value: float | None, decimals: int) -> str:
        return "--" if value is None else f"{value:.{decimals}f}"

    throughput = None if metric is None or metric.throughput_bps is None else metric.throughput_bps / 1_000_000
    loss = None if metric is None or metric.loss_rate is None else metric.loss_rate * 100
    return [
        frame_time.strftime("%Y-%m-%d %H:%M:%S.%f")[:-3],
        f"RTT          {number(None if metric is None else metric.avg_rtt_ms, 3)} ms",
        f"THROUGHPUT   {number(throughput, 2)} Mbps",
        f"JITTER       {number(None if metric is None else metric.jitter_ms, 3)} ms",
        f"LOSS         {number(loss, 3)} %",
    ]


def _draw_overlay(frame: Any, lines: list[str], cv2: Any) -> Any:
    height, width = frame.shape[:2]
    font = cv2.FONT_HERSHEY_SIMPLEX
    scale = max(0.46, min(0.72, width / 1200.0))
    thickness = 1 if width < 1280 else 2
    padding = max(10, width // 80)
    line_gap = max(7, height // 80)
    sizes = [cv2.getTextSize(line, font, scale, thickness)[0] for line in lines]
    text_width = max(size[0] for size in sizes)
    text_height = max(size[1] for size in sizes)
    line_height = text_height + line_gap
    box_width = text_width + padding * 2
    box_height = line_height * len(lines) + padding * 2 - line_gap
    left = max(0, width - box_width - padding)
    top = padding
    right = min(width - 1, left + box_width)
    bottom = min(height - 1, top + box_height)

    shaded = frame.copy()
    cv2.rectangle(shaded, (left, top), (right, bottom), (0, 0, 0), cv2.FILLED)
    cv2.addWeighted(shaded, 0.72, frame, 0.28, 0, frame)
    for index, line in enumerate(lines):
        color = (255, 255, 255) if index == 0 else (80, 220, 255)
        cv2.putText(
            frame,
            line,
            (left + padding, top + padding + text_height + index * line_height),
            font,
            scale,
            color,
            thickness,
            cv2.LINE_AA,
        )
    return frame


def render_metrics_video(
    input_video: Path,
    frame_timestamps_csv: Path,
    network_metrics_csv: Path,
    output_video: Path,
    max_metric_age: float = 2.0,
) -> int:
    cv2 = _load_cv2()
    frame_timestamps = load_frame_timestamps(frame_timestamps_csv)
    timeline = MetricTimeline(load_network_metrics(network_metrics_csv), max_metric_age)
    capture = cv2.VideoCapture(str(input_video))
    if not capture.isOpened():
        raise RuntimeError(f"unable to open input video: {input_video}")

    fps = float(capture.get(cv2.CAP_PROP_FPS))
    width = int(capture.get(cv2.CAP_PROP_FRAME_WIDTH))
    height = int(capture.get(cv2.CAP_PROP_FRAME_HEIGHT))
    if fps <= 0 or width <= 0 or height <= 0:
        capture.release()
        raise RuntimeError("input video reports invalid FPS or frame size")

    output_video.parent.mkdir(parents=True, exist_ok=True)
    temporary = output_video.with_name(f"{output_video.stem}.tmp{output_video.suffix}")
    writer = cv2.VideoWriter(
        str(temporary),
        cv2.VideoWriter_fourcc(*"mp4v"),
        fps,
        (width, height),
    )
    if not writer.isOpened():
        capture.release()
        raise RuntimeError(f"unable to open output video: {temporary}")

    frame_index = 0
    try:
        while True:
            ok, frame = capture.read()
            if not ok:
                break
            if frame_index >= len(frame_timestamps):
                raise RuntimeError("video contains more frames than the frame timestamp CSV")
            frame_time = frame_timestamps[frame_index]
            writer.write(_draw_overlay(frame, _display_lines(frame_time, timeline.at(frame_time)), cv2))
            frame_index += 1
    finally:
        capture.release()
        writer.release()

    if frame_index == 0:
        temporary.unlink(missing_ok=True)
        raise RuntimeError("input video contains no frames")
    if frame_index != len(frame_timestamps):
        temporary.unlink(missing_ok=True)
        raise RuntimeError(
            f"frame count mismatch: video={frame_index}, timestamps={len(frame_timestamps)}"
        )
    temporary.replace(output_video)
    return frame_index


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(description="Overlay timestamp-aligned network metrics on a video")
    parser.add_argument("--video", type=Path, required=True)
    parser.add_argument("--frame-timestamps", type=Path, required=True)
    parser.add_argument("--network-csv", type=Path, required=True)
    parser.add_argument("--output", type=Path, required=True)
    parser.add_argument("--max-metric-age", type=float, default=2.0)
    return parser


def main() -> int:
    args = build_parser().parse_args()
    try:
        frame_count = render_metrics_video(
            args.video,
            args.frame_timestamps,
            args.network_csv,
            args.output,
            args.max_metric_age,
        )
    except (OSError, RuntimeError, ValueError) as exc:
        print(f"ERROR: {exc}")
        return 1
    print(f"Annotated video: {args.output}")
    print(f"Rendered frames: {frame_count}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
