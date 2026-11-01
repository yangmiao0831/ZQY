"""Main entry point for packet_collector.

Future responsibilities include loading configuration, creating tasks, running
capture workflows, parsing outputs, collecting metrics, and writing diagnosis
artifacts. Step 1 delegates to the CLI placeholder.
"""

from __future__ import annotations

from packet_collector.cli import main as cli_main


def main() -> None:
    """Run the top-level application placeholder."""
    cli_main()


if __name__ == "__main__":
    main()
