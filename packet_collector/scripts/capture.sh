#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd -P)"
PROJECT_DIR="$(cd -- "$SCRIPT_DIR/.." && pwd -P)"
WORKSPACE_DIR="$(cd -- "$PROJECT_DIR/.." && pwd -P)"
CONFIG_FILE="${CONFIG_FILE:-$PROJECT_DIR/config.json}"
VENV_DIR="${VENV_DIR:-$WORKSPACE_DIR/zqy}"

cd "$PROJECT_DIR"
if [[ -f "$VENV_DIR/bin/activate" ]]; then
  # shellcheck disable=SC1091
  source "$VENV_DIR/bin/activate"
fi

exec python3 -m packet_collector.orchestration.configured_capture \
  --config "$CONFIG_FILE" --no-video "$@"

