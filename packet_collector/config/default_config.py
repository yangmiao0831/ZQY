"""Default configuration constants for packet_collector.

These values mirror `config/config.yaml` and describe the default Wi-Fi scope
runtime assumptions for Raspberry Pi 5 deployments.
"""

from __future__ import annotations

from packet_collector.platform_defaults import default_interface, default_tmp_capture_dir


DEFAULT_IFACE = default_interface()
TMP_CAPTURE_DIR = str(default_tmp_capture_dir())
FINAL_CAPTURE_DIR = "captures"
DEFAULT_FILE_SIZE_KB = 51200
DEFAULT_MAX_FILES = 20
DEFAULT_DIRECTION = "in"
DEFAULT_OUTPUT_FORMAT = "jsonl"


def get_default_config() -> dict[str, object]:
    """Return a copy of the default configuration."""
    return {
        "iface": DEFAULT_IFACE,
        "tmp_capture_dir": TMP_CAPTURE_DIR,
        "final_capture_dir": FINAL_CAPTURE_DIR,
        "default_file_size_kb": DEFAULT_FILE_SIZE_KB,
        "default_max_files": DEFAULT_MAX_FILES,
        "default_direction": DEFAULT_DIRECTION,
        "default_output_format": DEFAULT_OUTPUT_FORMAT,
    }
