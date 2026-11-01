"""Tests for deployment environment checks."""

from __future__ import annotations

from types import SimpleNamespace

from packet_collector.deploy import env_check
from packet_collector.deploy.env_check import (
    check_command,
    check_path_writable,
    check_python_package,
    run_env_check,
)


def test_check_python_package_success(monkeypatch) -> None:
    """Package check reports available modules."""
    monkeypatch.setattr(env_check.importlib, "import_module", lambda name: SimpleNamespace(__version__="1.2.3"))
    result = check_python_package("fake")

    assert result["available"] is True
    assert result["version"] == "1.2.3"


def test_check_python_package_failure(monkeypatch) -> None:
    """Package check reports import failures."""

    def fake_import(name):
        raise ImportError("missing")

    monkeypatch.setattr(env_check.importlib, "import_module", fake_import)
    result = check_python_package("fake")

    assert result["available"] is False
    assert "missing" in result["error"]


def test_check_command_missing(monkeypatch) -> None:
    """Missing command reports available=false."""
    monkeypatch.setattr(env_check, "resolve_tool", lambda command: None)

    result = check_command("dumpcap")

    assert result["available"] is False
    assert result["error"] == "command not found"


def test_check_command_version_success(monkeypatch) -> None:
    """Command version output is captured."""
    monkeypatch.setattr(env_check, "resolve_tool", lambda command: "/usr/bin/fake")

    def fake_run(command, capture_output, text, check, timeout):
        return SimpleNamespace(returncode=0, stdout="fake version 1\nmore", stderr="")

    monkeypatch.setattr(env_check.subprocess, "run", fake_run)
    result = check_command("fake", ["--version"])

    assert result["available"] is True
    assert result["version"] == "fake version 1"


def test_check_path_writable_success(tmp_path) -> None:
    """Writable path check creates and removes a test file."""
    result = check_path_writable(tmp_path / "captures")

    assert result["creatable"] is True
    assert result["writable"] is True


def test_run_env_check_success(monkeypatch, tmp_path) -> None:
    """All critical checks passing yields success=true."""
    monkeypatch.setattr(env_check, "check_command", lambda command, version_args=None: {"available": True, "path": command, "version": "v", "error": None})
    monkeypatch.setattr(env_check, "check_python_package", lambda name: {"available": True, "version": "v", "error": None})
    monkeypatch.setattr(env_check, "check_npcap", lambda: {"available": True, "running": True, "path": None, "version": None, "error": None})

    result = run_env_check(tmp_capture_dir=tmp_path / "tmpcap", final_capture_dir=tmp_path / "captures")

    assert result["success"] is True


def test_run_env_check_failure(monkeypatch, tmp_path) -> None:
    """A missing critical command yields success=false."""

    def fake_check_command(command, version_args=None):
        if command == "dumpcap":
            return {"available": False, "path": None, "version": None, "error": "command not found"}
        return {"available": True, "path": command, "version": "v", "error": None}

    monkeypatch.setattr(env_check, "check_command", fake_check_command)
    monkeypatch.setattr(env_check, "check_python_package", lambda name: {"available": True, "version": "v", "error": None})
    monkeypatch.setattr(env_check, "check_npcap", lambda: {"available": True, "running": True, "path": None, "version": None, "error": None})

    result = run_env_check(tmp_capture_dir=tmp_path / "tmpcap", final_capture_dir=tmp_path / "captures")

    assert result["success"] is False
    assert result["commands"]["dumpcap"]["available"] is False
