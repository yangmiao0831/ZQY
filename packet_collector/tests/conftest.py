"""Pytest fixtures for sandbox-friendly local paths."""

from __future__ import annotations

import re
from pathlib import Path
from uuid import uuid4

import pytest


@pytest.fixture
def tmp_path(request: pytest.FixtureRequest) -> Path:
    """Provide a project-local temporary path.

    The execution sandbox used during development may deny access to the system
    temp directory. Keeping temporary test files under the ignored project
    `tmp/` directory makes the tests hardware-independent and sandbox-friendly.
    """
    name = re.sub(r"[^A-Za-z0-9_.-]+", "_", request.node.name)
    path = Path("tmp") / "pytest_paths" / f"{name}_{uuid4().hex}"
    path.mkdir(parents=True, exist_ok=True)
    return path
