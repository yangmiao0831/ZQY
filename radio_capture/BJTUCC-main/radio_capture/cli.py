"""Executable module for ``python -m radio_capture.cli``."""

from __future__ import annotations

import sys

from radio_capture.main import main


if __name__ == "__main__":
    raise SystemExit(main(sys.argv[1:]))
