"""Lightweight scene context collector placeholder.

Wi-Fi Scope Step 1 only keeps an optional scene label for task metadata. GPS,
road-scene detection, and video/image recognition are intentionally excluded.
"""

from __future__ import annotations


def collect_scene_context_placeholder(scene: str | None = None) -> dict[str, object]:
    """Collect optional scene context placeholder."""
    print(f"TODO: attach optional scene label: {scene}")
    return {"scene": scene}
