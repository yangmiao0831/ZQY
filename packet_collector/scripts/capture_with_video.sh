#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd -P)"
PROJECT_DIR="$(cd -- "$SCRIPT_DIR/.." && pwd -P)"
WORKSPACE_DIR="$(cd -- "$PROJECT_DIR/.." && pwd -P)"
CONFIG_FILE="${CONFIG_FILE:-$PROJECT_DIR/config.json}"
VENV_DIR="${VENV_DIR:-$WORKSPACE_DIR/zqy}"

if [[ "$(id -u)" -eq 0 ]]; then
  echo "ERROR: run this script as the desktop user, without sudo." >&2
  echo "The Python launcher applies sudo only to packet capture." >&2
  exit 1
fi

cd "$PROJECT_DIR"
if [[ -f "$VENV_DIR/bin/activate" ]]; then
  # shellcheck disable=SC1091
  source "$VENV_DIR/bin/activate"
fi

exec python3 -m packet_collector.orchestration.configured_capture \
  --config "$CONFIG_FILE" --video "$@"

