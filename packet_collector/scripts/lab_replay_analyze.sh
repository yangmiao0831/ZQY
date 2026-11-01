#!/usr/bin/env bash
set -euo pipefail

usage() {
  cat <<'EOF'
Usage: bash scripts/lab_replay_analyze.sh --task-dir DIR [options]

Run on the Raspberry Pi after lab replay capture finishes. Produces summaries,
collects optional IP/device metrics, and generates task_report.json.

Options:
  --task-dir DIR        replay capture task directory (required)
  --iface IFACE         interface for collect-ip, default: wlan0
  --target IP           target for collect-ip, usually lab PC IP
  --skip-device         skip collect-device
  --skip-ip             skip collect-ip
  --dry-run             print commands only
  -h, --help            show this help

Environment:
  PYTHON_BIN            Python executable, default: python3
EOF
}

quote_cmd() {
  printf '%q ' "$@"
  printf '\n'
}

run_or_print() {
  echo "+ $(quote_cmd "$@")"
  if [[ "$DRY_RUN" != "1" ]]; then
    "$@"
  fi
}

TASK_DIR=""
IFACE="wlan0"
TARGET=""
SKIP_DEVICE=0
SKIP_IP=0
DRY_RUN=0
PYTHON_BIN="${PYTHON_BIN:-python3}"

while [[ $# -gt 0 ]]; do
  case "$1" in
    --task-dir) TASK_DIR="$2"; shift 2 ;;
    --iface) IFACE="$2"; shift 2 ;;
    --target) TARGET="$2"; shift 2 ;;
    --skip-device) SKIP_DEVICE=1; shift ;;
    --skip-ip) SKIP_IP=1; shift ;;
    --dry-run) DRY_RUN=1; shift ;;
    -h|--help) usage; exit 0 ;;
    *) echo "ERROR: unknown argument: $1" >&2; usage; exit 2 ;;
  esac
done

if [[ -z "$TASK_DIR" ]]; then
  echo "ERROR: --task-dir is required" >&2
  usage
  exit 2
fi

if [[ ! -d "$TASK_DIR" ]]; then
  echo "ERROR: task directory not found: $TASK_DIR" >&2
  exit 1
fi

echo "[1/4] Analyze all summaries"
run_or_print "$PYTHON_BIN" -m packet_collector.cli analyze-all "$TASK_DIR"

if [[ "$SKIP_IP" != "1" ]]; then
  echo "[2/4] Collect IP layer metrics"
  IP_CMD=("$PYTHON_BIN" -m packet_collector.cli collect-ip --iface "$IFACE" --task-dir "$TASK_DIR")
  if [[ -n "$TARGET" ]]; then
    IP_CMD+=(--target "$TARGET")
  fi
  run_or_print "${IP_CMD[@]}"
else
  echo "[2/4] Skipping IP layer metrics"
fi

if [[ "$SKIP_DEVICE" != "1" ]]; then
  echo "[3/4] Collect device runtime metrics"
  run_or_print "$PYTHON_BIN" -m packet_collector.cli collect-device --task-dir "$TASK_DIR"
else
  echo "[3/4] Skipping device runtime metrics"
fi

echo "[4/4] Generate task report"
run_or_print "$PYTHON_BIN" -m packet_collector.cli report "$TASK_DIR"
