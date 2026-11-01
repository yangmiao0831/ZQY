#!/usr/bin/env bash
set -euo pipefail

usage() {
  cat <<'EOF'
Usage: sudo bash scripts/lab_replay_client_capture.sh --trace PATH --pi-ip IP --server-ip IP [options]

Run on the Raspberry Pi. Starts capture in the background, then runs
packet_collector replay-client against the lab PC.

Options:
  --trace PATH          replay_trace.json path (required)
  --pi-ip IP            Raspberry Pi IP (required)
  --server-ip IP        lab PC / replay-server IP (required)
  --iface IFACE         capture interface, default: wlan0
  --duration SEC        capture duration, default: 60
  --capture-dir DIR     final capture dir, default: captures
  --port PORT           replay base port, default: 9000
  --protocol tcp|udp    replay protocol, default: tcp
  --max-flows N         select up to N flows
  --all-flows           select all matching flows
  --role ROLE           optional flow role filter
  --dry-run             print commands only
  -h, --help            show this help

Environment:
  PYTHON_BIN            Python executable, default: python3
  CAPTURE_LOG           capture log path, default: /tmp/packet_collector_lab_capture.log
  CAPTURE_START_DELAY   seconds to wait before replay-client, default: 2
EOF
}

quote_cmd() {
  printf '%q ' "$@"
  printf '\n'
}

TRACE=""
PI_IP=""
SERVER_IP=""
IFACE="wlan0"
DURATION="60"
CAPTURE_DIR="captures"
PORT="9000"
PROTOCOL="tcp"
MAX_FLOWS=""
ALL_FLOWS=0
ROLE=""
DRY_RUN=0
PYTHON_BIN="${PYTHON_BIN:-python3}"
CAPTURE_LOG="${CAPTURE_LOG:-/tmp/packet_collector_lab_capture.log}"
CAPTURE_START_DELAY="${CAPTURE_START_DELAY:-2}"

while [[ $# -gt 0 ]]; do
  case "$1" in
    --trace) TRACE="$2"; shift 2 ;;
    --pi-ip) PI_IP="$2"; shift 2 ;;
    --server-ip) SERVER_IP="$2"; shift 2 ;;
    --iface) IFACE="$2"; shift 2 ;;
    --duration) DURATION="$2"; shift 2 ;;
    --capture-dir) CAPTURE_DIR="$2"; shift 2 ;;
    --port) PORT="$2"; shift 2 ;;
    --protocol) PROTOCOL="$2"; shift 2 ;;
    --max-flows) MAX_FLOWS="$2"; shift 2 ;;
    --all-flows) ALL_FLOWS=1; shift ;;
    --role) ROLE="$2"; shift 2 ;;
    --dry-run) DRY_RUN=1; shift ;;
    -h|--help) usage; exit 0 ;;
    *) echo "ERROR: unknown argument: $1" >&2; usage; exit 2 ;;
  esac
done

if [[ -z "$TRACE" || -z "$PI_IP" || -z "$SERVER_IP" ]]; then
  echo "ERROR: --trace, --pi-ip, and --server-ip are required" >&2
  usage
  exit 2
fi

if [[ ! -f "$TRACE" ]]; then
  echo "ERROR: trace file not found: $TRACE" >&2
  exit 1
fi

if [[ "$ALL_FLOWS" == "1" && -n "$MAX_FLOWS" ]]; then
  echo "ERROR: --all-flows and --max-flows cannot be used together" >&2
  exit 2
fi

CAPTURE_CMD=(
  "$PYTHON_BIN" -m packet_collector.cli capture all "$PI_IP" "$SERVER_IP"
  --direction both
  --iface "$IFACE"
  --duration "$DURATION"
  --final-capture-dir "$CAPTURE_DIR"
  --parse
)

if [[ "$(id -u)" -ne 0 ]]; then
  CAPTURE_RUN=(sudo "${CAPTURE_CMD[@]}")
else
  CAPTURE_RUN=("${CAPTURE_CMD[@]}")
fi

CLIENT_CMD=(
  "$PYTHON_BIN" -m packet_collector.cli replay-client "$TRACE"
  --server "$SERVER_IP"
  --port "$PORT"
  --protocol "$PROTOCOL"
)

if [[ "$ALL_FLOWS" == "1" ]]; then
  CLIENT_CMD+=(--all-flows)
elif [[ -n "$MAX_FLOWS" ]]; then
  CLIENT_CMD+=(--max-flows "$MAX_FLOWS")
fi

if [[ -n "$ROLE" ]]; then
  CLIENT_CMD+=(--role "$ROLE")
fi

echo "[lab replay client/capture] capture command:"
quote_cmd "${CAPTURE_RUN[@]}"
echo "[lab replay client/capture] replay-client command:"
quote_cmd "${CLIENT_CMD[@]}"

if [[ "$DRY_RUN" == "1" ]]; then
  exit 0
fi

mkdir -p "$(dirname "$CAPTURE_LOG")"
rm -f "$CAPTURE_LOG"

echo "[1/3] Starting capture in background; log: $CAPTURE_LOG"
"${CAPTURE_RUN[@]}" >"$CAPTURE_LOG" 2>&1 &
CAPTURE_PID=$!

echo "[2/3] Waiting ${CAPTURE_START_DELAY}s before replay-client"
sleep "$CAPTURE_START_DELAY"

set +e
"${CLIENT_CMD[@]}"
CLIENT_RC=$?
wait "$CAPTURE_PID"
CAPTURE_RC=$?
set -e

echo "[3/3] Capture output:"
cat "$CAPTURE_LOG"

TASK_DIR="$(awk -F': ' '/^task_dir:/ {print $2}' "$CAPTURE_LOG" | tail -n 1 || true)"
if [[ -n "$TASK_DIR" ]]; then
  echo "Detected task_dir: $TASK_DIR"
else
  echo "Could not auto-detect task_dir. Check capture output above."
fi

if [[ "$CLIENT_RC" -ne 0 ]]; then
  echo "ERROR: replay-client failed with exit code $CLIENT_RC" >&2
  exit "$CLIENT_RC"
fi

if [[ "$CAPTURE_RC" -ne 0 ]]; then
  echo "ERROR: capture failed with exit code $CAPTURE_RC" >&2
  exit "$CAPTURE_RC"
fi
