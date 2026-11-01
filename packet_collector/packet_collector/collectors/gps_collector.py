"""Optional GPS serial reader used by per-window capture CSV output.

The reader keeps only the latest valid GPGGA/GNGGA fix. It is intentionally
best-effort: serial import/open/read errors are recorded but do not interrupt
packet capture.
"""

from __future__ import annotations

import math
import threading
from dataclasses import dataclass
from datetime import datetime

from packet_collector.platform_defaults import default_gps_port


PI = math.pi
A = 6378245.0
EE = 0.00669342162296594323


@dataclass(frozen=True)
class GpsFix:
    """Latest raw NMEA latitude/longitude fix."""

    timestamp: str
    latitude: str
    longitude: str
    gcj02_latitude: float | None = None
    gcj02_longitude: float | None = None


def nmea_coordinate_to_decimal(value: str) -> float | None:
    """Convert raw NMEA coordinate such as 3958.1234N to decimal degrees."""
    if not value:
        return None
    direction = value[-1].upper()
    numeric_text = value[:-1] if direction in {"N", "S", "E", "W"} else value
    try:
        degrees_minutes = float(numeric_text)
    except ValueError:
        return None
    degrees = math.floor(degrees_minutes / 100)
    minutes = degrees_minutes - degrees * 100
    decimal = degrees + minutes / 60.0
    if direction in {"S", "W"}:
        decimal = -decimal
    return decimal


def out_of_china(latitude: float, longitude: float) -> bool:
    """Return True when GCJ-02 offset should not be applied."""
    return not (
        72.004 <= longitude <= 137.8347
        and 0.8293 <= latitude <= 55.8271
    )


def _transform_latitude(x: float, y: float) -> float:
    ret = -100.0 + 2.0 * x + 3.0 * y + 0.2 * y * y + 0.1 * x * y
    ret += 0.2 * math.sqrt(abs(x))
    ret += (20.0 * math.sin(6.0 * x * PI) + 20.0 * math.sin(2.0 * x * PI)) * 2.0 / 3.0
    ret += (20.0 * math.sin(y * PI) + 40.0 * math.sin(y / 3.0 * PI)) * 2.0 / 3.0
    ret += (
        160.0 * math.sin(y / 12.0 * PI)
        + 320.0 * math.sin(y * PI / 30.0)
    ) * 2.0 / 3.0
    return ret


def _transform_longitude(x: float, y: float) -> float:
    ret = 300.0 + x + 2.0 * y + 0.1 * x * x + 0.1 * x * y
    ret += 0.1 * math.sqrt(abs(x))
    ret += (20.0 * math.sin(6.0 * x * PI) + 20.0 * math.sin(2.0 * x * PI)) * 2.0 / 3.0
    ret += (20.0 * math.sin(x * PI) + 40.0 * math.sin(x / 3.0 * PI)) * 2.0 / 3.0
    ret += (
        150.0 * math.sin(x / 12.0 * PI)
        + 300.0 * math.sin(x / 30.0 * PI)
    ) * 2.0 / 3.0
    return ret


def wgs84_to_gcj02(latitude: float, longitude: float) -> tuple[float, float]:
    """Convert WGS-84 decimal degrees to GCJ-02 coordinates."""
    if out_of_china(latitude, longitude):
        return latitude, longitude
    dlat = _transform_latitude(longitude - 105.0, latitude - 35.0)
    dlng = _transform_longitude(longitude - 105.0, latitude - 35.0)
    radlat = latitude / 180.0 * PI
    magic = math.sin(radlat)
    magic = 1.0 - EE * magic * magic
    sqrtmagic = math.sqrt(magic)
    dlat_final = (dlat * 180.0) / ((A * (1.0 - EE)) / (magic * sqrtmagic) * PI)
    dlng_final = (dlng * 180.0) / (A / sqrtmagic * math.cos(radlat) * PI)
    return latitude + dlat_final, longitude + dlng_final


def raw_nmea_to_gcj02(latitude: str, longitude: str) -> tuple[float | None, float | None]:
    """Convert raw NMEA latitude/longitude strings to GCJ-02 when possible."""
    wgs_latitude = nmea_coordinate_to_decimal(latitude)
    wgs_longitude = nmea_coordinate_to_decimal(longitude)
    if wgs_latitude is None or wgs_longitude is None:
        return None, None
    return wgs84_to_gcj02(wgs_latitude, wgs_longitude)


def parse_gga_line(line: str) -> GpsFix | None:
    """Parse one GPGGA/GNGGA NMEA line and keep raw coordinate format."""
    if not (line.startswith("$GPGGA") or line.startswith("$GNGGA")):
        return None
    parts = line.split(",")
    if len(parts) < 7:
        return None
    if parts[6] == "0":
        return None
    if not parts[2] or not parts[3] or not parts[4] or not parts[5]:
        return None
    latitude = f"{parts[2]}{parts[3]}"
    longitude = f"{parts[4]}{parts[5]}"
    gcj02_latitude, gcj02_longitude = raw_nmea_to_gcj02(latitude, longitude)
    return GpsFix(
        timestamp=datetime.now().strftime("%Y-%m-%d %H:%M:%S.%f")[:-3],
        latitude=latitude,
        longitude=longitude,
        gcj02_latitude=gcj02_latitude,
        gcj02_longitude=gcj02_longitude,
    )


class LatestGpsReader:
    """Background serial reader that stores the latest valid GPS fix."""

    def __init__(self, port: str | None = None, baudrate: int = 115200) -> None:
        self.port = port or default_gps_port()
        self.baudrate = baudrate
        self._stop_event = threading.Event()
        self._lock = threading.Lock()
        self._latest_fix: GpsFix | None = None
        self._thread: threading.Thread | None = None
        self.error: str | None = None

    def start(self) -> None:
        """Start the reader thread if it is not already running."""
        if self._thread is not None and self._thread.is_alive():
            return
        self._stop_event.clear()
        self._thread = threading.Thread(target=self._run, name="gps-reader", daemon=True)
        self._thread.start()

    def stop(self) -> None:
        """Request reader shutdown and wait briefly for the serial read loop."""
        self._stop_event.set()
        if self._thread is not None:
            self._thread.join(timeout=2.0)

    def get_latest_fix(self) -> GpsFix | None:
        """Return the latest valid fix, or None when GPS has not fixed yet."""
        with self._lock:
            return self._latest_fix

    def _set_latest_fix(self, fix: GpsFix) -> None:
        with self._lock:
            self._latest_fix = fix

    def _run(self) -> None:
        try:
            import serial  # type: ignore[import-not-found]
        except Exception as exc:
            self.error = f"pyserial unavailable: {exc}"
            return

        ser = None
        try:
            ser = serial.Serial(self.port, self.baudrate, timeout=1)
            while not self._stop_event.is_set():
                line = ser.readline().decode(errors="ignore").strip()
                if not line:
                    continue
                fix = parse_gga_line(line)
                if fix is not None:
                    self._set_latest_fix(fix)
        except Exception as exc:
            self.error = str(exc)
        finally:
            if ser is not None:
                try:
                    ser.close()
                except Exception:
                    pass
