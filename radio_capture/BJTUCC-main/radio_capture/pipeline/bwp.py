"""Track NR downlink BWP bandwidth from decoded RRC and PHY/MAC XML."""

from __future__ import annotations

import re
import xml.etree.ElementTree as ET
from dataclasses import dataclass


MAX_LOCATION_AND_BANDWIDTH_RBS = 275

_NUMBER_RE = re.compile(r"[-+]?\d+")
_SCS_RE = re.compile(r"(\d+)\s*KHZ", re.IGNORECASE)

# TS 38.104 NRB table values commonly emitted by Qualcomm/QXDM as nominal MHz.
_NOMINAL_BANDWIDTH_BY_SCS_AND_RBS = {
    15: {
        25: 5,
        52: 10,
        79: 15,
        106: 20,
        133: 25,
        160: 30,
        216: 40,
        270: 50,
    },
    30: {
        11: 5,
        24: 10,
        38: 15,
        51: 20,
        65: 25,
        78: 30,
        106: 40,
        133: 50,
        162: 60,
        189: 70,
        217: 80,
        245: 90,
        273: 100,
    },
    60: {
        11: 10,
        18: 15,
        24: 20,
        31: 25,
        38: 30,
        51: 40,
        65: 50,
        66: 50,
        79: 60,
        93: 70,
        107: 80,
        121: 90,
        132: 100,
        135: 100,
        264: 200,
    },
    120: {
        32: 50,
        66: 100,
        132: 200,
        264: 400,
    },
}


@dataclass(frozen=True)
class BwpConfig:
    bwp_id: int
    location_and_bandwidth: int
    scs_khz: int
    rb_start: int
    rb_count: int
    bandwidth_mhz: float


@dataclass(frozen=True)
class BwpMetricsUpdate:
    bwp_active_bandwidth_dl_mhz: float | None = None
    bwp_bandwidth_mhz: float | None = None


class RrcBwpTracker:
    """Maintain the current downlink BWP bandwidth from decoded Qualcomm XML.

    ``0xB821`` provides RRC configuration.  PHY/MAC logs can later expose the
    active BWP ID, so the same tracker consumes those records too when present.
    """

    def __init__(self) -> None:
        self._downlink_bwps: dict[int, BwpConfig] = {}
        self._active_downlink_bwp_id: int | None = None
        self._default_downlink_bwp_id: int | None = None

    def reset(self) -> None:
        self._downlink_bwps.clear()
        self._active_downlink_bwp_id = None
        self._default_downlink_bwp_id = None

    def update(self, detail: bytes | str, msg_code: int | None = None) -> BwpMetricsUpdate | None:
        if not detail:
            return None
        text = detail.decode("utf-8", errors="replace") if isinstance(detail, bytes) else detail
        try:
            root = ET.fromstring(text)
        except ET.ParseError:
            return None

        changed = False
        if msg_code == 0xB821:
            changed = self._update_from_rrc(root)

        switched = False if msg_code == 0xB821 else self._update_active_id_from_runtime_log(root)
        current = self._current_config()
        if current is None:
            return None
        if changed or switched:
            return BwpMetricsUpdate(
                bwp_active_bandwidth_dl_mhz=current.bandwidth_mhz,
                bwp_bandwidth_mhz=current.bandwidth_mhz,
            )
        return None

    def _update_from_rrc(self, root: ET.Element) -> bool:
        changed = False
        for node in root.iter():
            tag = _tag_name(node)
            if tag == "firstActiveDownlinkBWP-Id":
                active_id = _int_text(node)
                if active_id is not None:
                    self._active_downlink_bwp_id = active_id
                    changed = True
            elif tag == "defaultDownlinkBWP-Id":
                default_id = _int_text(node)
                if default_id is not None:
                    self._default_downlink_bwp_id = default_id
                    changed = True

            config = _bwp_config_from_node(node)
            if config is None:
                continue
            self._downlink_bwps[config.bwp_id] = config
            changed = True

        if self._active_downlink_bwp_id is None:
            if self._default_downlink_bwp_id in self._downlink_bwps:
                self._active_downlink_bwp_id = self._default_downlink_bwp_id
                changed = True
            elif 0 in self._downlink_bwps:
                self._active_downlink_bwp_id = 0
                changed = True
            elif len(self._downlink_bwps) == 1:
                self._active_downlink_bwp_id = next(iter(self._downlink_bwps))
                changed = True
        return changed

    def _update_active_id_from_runtime_log(self, root: ET.Element) -> bool:
        active_id = _first_descendant_int(root, "BWP_Id", "BWP_ID")
        if active_id is None:
            indicator = _first_descendant_int(root, "BWP_Ind")
            if indicator in self._downlink_bwps:
                active_id = indicator
        if active_id is None or active_id not in self._downlink_bwps:
            return False
        if active_id == self._active_downlink_bwp_id:
            return False
        self._active_downlink_bwp_id = active_id
        return True

    def _current_config(self) -> BwpConfig | None:
        if self._active_downlink_bwp_id in self._downlink_bwps:
            return self._downlink_bwps[self._active_downlink_bwp_id]
        if self._default_downlink_bwp_id in self._downlink_bwps:
            return self._downlink_bwps[self._default_downlink_bwp_id]
        if len(self._downlink_bwps) == 1:
            return next(iter(self._downlink_bwps.values()))
        return None


def decode_location_and_bandwidth(
    riv: int, n_rbs: int = MAX_LOCATION_AND_BANDWIDTH_RBS
) -> tuple[int, int] | None:
    """Decode the RIV-style ``locationAndBandwidth`` field."""
    if riv < 0 or n_rbs <= 0:
        return None
    rb_start = riv % n_rbs
    length = riv // n_rbs + 1
    if length <= n_rbs - rb_start:
        return rb_start, length

    rb_start = n_rbs - 1 - rb_start
    length = n_rbs - (riv // n_rbs) + 1
    if length <= 0 or rb_start < 0 or rb_start + length > n_rbs:
        return None
    return rb_start, length


def bwp_bandwidth_mhz(rb_count: int, scs_khz: int) -> float:
    nominal = _NOMINAL_BANDWIDTH_BY_SCS_AND_RBS.get(scs_khz, {}).get(rb_count)
    if nominal is not None:
        return nominal
    mhz = rb_count * 12 * scs_khz / 1000.0
    return int(mhz) if mhz.is_integer() else mhz


def _bwp_config_from_node(node: ET.Element) -> BwpConfig | None:
    tag = _tag_name(node)
    if tag not in {"BWP-Downlink", "BWP-DownlinkCommon", "initialDownlinkBWP"}:
        return None

    location = _first_descendant_int(node, "locationAndBandwidth")
    scs_khz = _first_scs_khz(node)
    if location is None or scs_khz is None:
        return None
    decoded = decode_location_and_bandwidth(location)
    if decoded is None:
        return None
    rb_start, rb_count = decoded

    bwp_id = _first_descendant_int(node, "bwp-Id")
    if bwp_id is None:
        bwp_id = 0 if tag == "initialDownlinkBWP" else None
    if bwp_id is None:
        return None

    return BwpConfig(
        bwp_id=bwp_id,
        location_and_bandwidth=location,
        scs_khz=scs_khz,
        rb_start=rb_start,
        rb_count=rb_count,
        bandwidth_mhz=bwp_bandwidth_mhz(rb_count, scs_khz),
    )


def _first_scs_khz(element: ET.Element) -> int | None:
    for node in element.iter():
        tag = _tag_name(node)
        match = re.fullmatch(r"kHz(\d+)", tag)
        if match:
            return int(match.group(1))
        if tag in {"subcarrierSpacing", "SCS", "Numerology", "Num"}:
            text = _clean(node.text)
            if text:
                text_match = _SCS_RE.search(text)
                if text_match:
                    return int(text_match.group(1))
    return None


def _first_descendant_int(element: ET.Element, *names: str) -> int | None:
    wanted = {_normalize_tag(name) for name in names}
    for node in element.iter():
        if _normalize_tag(_tag_name(node)) not in wanted:
            continue
        value = _int_text(node)
        if value is not None:
            return value
    return None


def _int_text(node: ET.Element) -> int | None:
    text = _clean(node.text)
    if text is None:
        return None
    match = _NUMBER_RE.search(text)
    return int(match.group(0)) if match else None


def _clean(value: str | None) -> str | None:
    if value is None:
        return None
    text = value.strip()
    return text or None


def _tag_name(node: ET.Element) -> str:
    tag = node.tag
    if "}" in tag:
        return tag.rsplit("}", 1)[1]
    return tag


def _normalize_tag(tag: str) -> str:
    return tag.replace("-", "").replace("_", "").lower()
