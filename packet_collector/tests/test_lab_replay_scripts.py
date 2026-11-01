"""Static tests for lab replay operation scripts."""

from __future__ import annotations

from pathlib import Path


SCRIPTS_DIR = Path("scripts")


def _read_script(name: str) -> str:
    """Read one script as UTF-8 text."""
    return (SCRIPTS_DIR / name).read_text(encoding="utf-8")


def test_lab_replay_scripts_exist() -> None:
    """Lab replay operation scripts and quickstart docs exist."""
    assert (SCRIPTS_DIR / "lab_replay_server.sh").exists()
    assert (SCRIPTS_DIR / "lab_replay_client_capture.sh").exists()
    assert (SCRIPTS_DIR / "lab_replay_analyze.sh").exists()
    assert (SCRIPTS_DIR / "lab_replay_quickstart.md").exists()
    assert (SCRIPTS_DIR / "lab_replay_env.example").exists()


def test_lab_replay_shell_scripts_have_shebang_and_dry_run() -> None:
    """Shell scripts are bash scripts and support dry-run."""
    for name in ["lab_replay_server.sh", "lab_replay_client_capture.sh", "lab_replay_analyze.sh"]:
        text = _read_script(name)
        assert text.startswith("#!/usr/bin/env bash")
        assert "--dry-run" in text


def test_lab_replay_server_script_contains_replay_server_command() -> None:
    """Server helper wraps replay-server only."""
    text = _read_script("lab_replay_server.sh")
    assert "replay-server" in text
    assert "replay-client" not in text
    assert "capture all" not in text


def test_lab_replay_client_capture_script_contains_capture_and_client() -> None:
    """Client/capture helper starts capture and replay-client."""
    text = _read_script("lab_replay_client_capture.sh")
    assert "capture all" in text
    assert "replay-client" in text
    assert "CAPTURE_LOG" in text


def test_lab_replay_analyze_script_contains_analysis_commands() -> None:
    """Analyze helper runs analyzers, collectors, and report."""
    text = _read_script("lab_replay_analyze.sh")
    assert "analyze-all" in text
    assert "collect-ip" in text
    assert "collect-device" in text
    assert "report" in text


def test_lab_replay_quickstart_distinguishes_two_machines() -> None:
    """Quickstart clearly separates lab PC and Raspberry Pi actions."""
    text = (SCRIPTS_DIR / "lab_replay_quickstart.md").read_text(encoding="utf-8")
    assert "Lab PC" in text
    assert "Raspberry Pi" in text
    assert "replay-server" in text
    assert "replay-client" in text
    assert "not old" in text or "not pcap" in text
