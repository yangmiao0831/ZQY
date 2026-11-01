#!/usr/bin/env bash
set -euo pipefail

usage() {
  cat <<'EOF'
Usage: bash scripts/lab_replay_server.sh --trace PATH [options]

Run on the lab PC. Starts packet_collector replay-server.

Options:
  --trace PATH          replay_trace.json path (required)
  --host HOST           listen host, default: 0.0.0.0
  --port PORT           base port, default: 9000
  --protocol tcp|udp    replay protocol, default: tcp
  --max-flows N         select up to N flows
  --all-flows           select all matching flows
  --role ROLE           optional flow role filter
  --output PATH         optional replay_result_server.json path
  --dry-run             print command only
  -h, --help            show this help

Environment:
  PYTHON_BIN            Python executable, default: python3
EOF
}

quote_cmd() {
  printf '%q ' "$@"
  printf '\n'
}

TRACE=""
HOST="0.0.0.0"
PORT="9000"
PROTOCOL="tcp"
MAX_FLOWS=""
ALL_FLOWS=0
ROLE=""
OUTPUT=""
DRY_RUN=0
PYTHON_BIN="${PYTHON_BIN:-python3}"

while [[ $# -gt 0 ]]; do
  case "$1" in
    --trace) TRACE="$2"; shift 2 ;;
    --host) HOST="$2"; shift 2 ;;
    --port) PORT="$2"; shift 2 ;;
    --protocol) PROTOCOL="$2"; shift 2 ;;
    --max-flows) MAX_FLOWS="$2"; shift 2 ;;
    --all-flows) ALL_FLOWS=1; shift ;;
    --role) ROLE="$2"; shift 2 ;;
    --output) OUTPUT="$2"; shift 2 ;;
    --dry-run) DRY_RUN=1; shift ;;
    -h|--help) usage; exit 0 ;;
    *) echo "ERROR: unknown argument: $1" >&2; usage; exit 2 ;;
  esac
done

if [[ -z "$TRACE" ]]; then
  echo "ERROR: --trace is required" >&2
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

CMD=(
  "$PYTHON_BIN" -m packet_collector.cli replay-server "$TRACE"
  --host "$HOST"
  --port "$PORT"
  --protocol "$PROTOCOL"
)

if [[ "$ALL_FLOWS" == "1" ]]; then
  CMD+=(--all-flows)
elif [[ -n "$MAX_FLOWS" ]]; then
  CMD+=(--max-flows "$MAX_FLOWS")
fi

if [[ -n "$ROLE" ]]; then
  CMD+=(--role "$ROLE")
fi

if [[ -n "$OUTPUT" ]]; then
  CMD+=(--output "$OUTPUT")
fi

echo "[lab replay server] command:"
quote_cmd "${CMD[@]}"

if [[ "$DRY_RUN" == "1" ]]; then
  exit 0
fi

exec "${CMD[@]}"
