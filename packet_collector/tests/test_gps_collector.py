"""Tests for the optional GPS latest-fix reader helpers."""

from __future__ import annotations

from packet_collector.collectors.gps_collector import (
    nmea_coordinate_to_decimal,
    parse_gga_line,
    raw_nmea_to_gcj02,
)


def test_parse_gga_line_keeps_raw_coordinate_format() -> None:
    """Valid GGA fixes keep the original NMEA coordinate style."""
    fix = parse_gga_line(
        "$GPGGA,092750.000,3958.1234,N,11620.5678,E,1,08,1.0,10.0,M,0.0,M,,"
    )

    assert fix is not None
    assert fix.latitude == "3958.1234N"
    assert fix.longitude == "11620.5678E"
    assert fix.gcj02_latitude is not None
    assert fix.gcj02_longitude is not None


def test_parse_gga_line_ignores_invalid_fix() -> None:
    """GGA records without a valid fix are ignored."""
    assert (
        parse_gga_line(
            "$GPGGA,092750.000,3958.1234,N,11620.5678,E,0,08,1.0,10.0,M,0.0,M,,"
        )
        is None
    )


def test_nmea_coordinate_to_decimal_handles_direction() -> None:
    """Raw NMEA coordinates convert to WGS-84 decimal degrees."""
    assert round(nmea_coordinate_to_decimal("3958.1234N") or 0.0, 6) == 39.968723
    assert round(nmea_coordinate_to_decimal("11620.5678E") or 0.0, 6) == 116.342797


def test_raw_nmea_to_gcj02_returns_amap_coordinates() -> None:
    """Chinese WGS-84 coordinates are offset to GCJ-02 for AMap usage."""
    gcj_latitude, gcj_longitude = raw_nmea_to_gcj02("3958.1234N", "11620.5678E")

    assert gcj_latitude is not None
    assert gcj_longitude is not None
    assert gcj_latitude != nmea_coordinate_to_decimal("3958.1234N")
    assert gcj_longitude != nmea_coordinate_to_decimal("11620.5678E")
