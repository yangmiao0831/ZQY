#!/usr/bin/env bash
set -e

GATEWAY=${GATEWAY:-192.168.31.1}
IFACE=${IFACE:-wlan0}

echo "[1/4] Checking deployment environment"
python3 -m packet_collector.cli check-env --output deploy_check.json

echo "[2/4] Collecting device runtime metrics"
python3 -m packet_collector.cli collect-device --output device_metrics.json

echo "[3/4] Collecting IP layer metrics"
python3 -m packet_collector.cli collect-ip --iface "$IFACE" --output ip_metrics.json

echo "[4/4] Running gateway ping probe"
python3 -m packet_collector.cli probe ping "$GATEWAY" --output probe_ping.json

echo "Smoke test outputs:"
echo "  deploy_check.json"
echo "  device_metrics.json"
echo "  ip_metrics.json"
echo "  probe_ping.json"
echo
echo "Manual capture example:"
echo "  sudo python3 -m packet_collector.cli capture tcp <PI_IP> <PEER_IP> --direction both --duration 10 --parse"
