#!/usr/bin/env bash
set -euo pipefail

usage() {
  echo "Usage: $0 <PI_IP> <PEER_IP>"
  echo
  echo "Environment overrides:"
  echo "  IFACE=wlan0"
  echo "  DURATION=10"
  echo "  DIRECTION=both"
  echo "  PYTHON_BIN=/path/to/python3"
  echo "  RUN_WITH_SUDO=1"
  echo "  TMP_CAPTURE_DIR=/tmp/packet_collector/captures"
  echo "  FINAL_CAPTURE_DIR=captures"
}

if [[ $# -lt 2 ]]; then
  usage
  exit 2
fi

PI_IP="$1"
PEER_IP="$2"
IFACE="${IFACE:-wlan0}"
DURATION="${DURATION:-10}"
DIRECTION="${DIRECTION:-both}"
PYTHON_BIN="${PYTHON_BIN:-$(command -v python3)}"
RUN_WITH_SUDO="${RUN_WITH_SUDO:-1}"
TMP_CAPTURE_DIR="${TMP_CAPTURE_DIR:-/tmp/packet_collector/captures}"
FINAL_CAPTURE_DIR="${FINAL_CAPTURE_DIR:-captures}"

SUDO_PREFIX=()
if [[ "$RUN_WITH_SUDO" != "0" && "$(id -u)" -ne 0 ]]; then
  SUDO_PREFIX=(sudo)
fi

run_cli() {
  "${SUDO_PREFIX[@]}" "$PYTHON_BIN" -m packet_collector.cli "$@"
}

echo "[1/5] Capture all traffic between $PI_IP and $PEER_IP"
capture_output="$(
  run_cli capture all "$PI_IP" "$PEER_IP" \
    --iface "$IFACE" \
    --direction "$DIRECTION" \
    --duration "$DURATION" \
    --tmp-capture-dir "$TMP_CAPTURE_DIR" \
    --final-capture-dir "$FINAL_CAPTURE_DIR" \
    --parse
)"
echo "$capture_output"

task_dir="$(echo "$capture_output" | awk -F': ' '/^task_dir:/ {print $2}' | tail -n 1)"
if [[ -z "$task_dir" ]]; then
  echo "ERROR: could not find task_dir in capture output" >&2
  exit 1
fi

echo "[2/5] Analyze all transport and application summaries"
run_cli analyze-all "$task_dir"

echo "[3/5] Collect IP layer metrics"
run_cli collect-ip --iface "$IFACE" --target "$PEER_IP" --task-dir "$task_dir"

echo "[4/5] Collect device runtime metrics"
run_cli collect-device --task-dir "$task_dir"

echo "[5/5] Generate task report"
run_cli report "$task_dir"

echo
echo "Full task completed:"
echo "  task_dir: $task_dir"
echo "  packets:  $task_dir/packets.jsonl"
echo "  report:   $task_dir/task_report.json"
