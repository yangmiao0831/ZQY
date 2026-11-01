from __future__ import annotations

from pathlib import Path

import pytest

from radio_capture.config import parse_config
from radio_capture.errors import ConfigurationError


def _config_data() -> dict:
    return {
        "runtime": {"python_arch": "x86", "dll_dir": "."},
        "device": {"eq_id": 1},
        "logmask": {"mode": "disabled"},
        "output": {
            "raw_dir": "captures",
            "decoded_jsonl": "decoded.jsonl",
            "sqlite_file": "radio.db",
        },
    }


def test_dm_write_interval_defaults_to_one_second():
    config = parse_config(_config_data(), base_dir=Path("."))

    assert config.output.dm_write_interval_sec == 1.0


def test_dm_write_interval_is_loaded_from_output_config():
    data = _config_data()
    data["output"]["dm_write_interval_sec"] = 2.5

    config = parse_config(data, base_dir=Path("."))

    assert config.output.dm_write_interval_sec == 2.5


def test_dm_write_interval_rejects_negative_value():
    data = _config_data()
    data["output"]["dm_write_interval_sec"] = -1

    with pytest.raises(ConfigurationError, match="dm_write_interval_sec"):
        parse_config(data, base_dir=Path("."))
