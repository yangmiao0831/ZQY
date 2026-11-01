# Lab Replay Quickstart

This guide describes the two-machine lab workflow for behavior-level replay.

- Lab PC: runs `replay-server` and acts like the original cloud/peer.
- Raspberry Pi: runs packet capture, runs `replay-client`, then analyzes the captured replay traffic.

Replay generates new legal TCP/UDP traffic with dummy payload. It is not old
pcap packet replay.

## 1. Prepare The Trace

After outdoor collection, you should already have a session directory:

```text
captures/session_xxx/
|-- session_meta.json
|-- pcaps/
|-- packets/
`-- packets.jsonl
```

Build the replay trace from the session:

```bash
python3 -m packet_collector.cli build-replay-trace captures/session_xxx --pi-ip 192.168.31.102 --window-ms 100
```

Expected output:

```text
captures/session_xxx/replay_trace.json
```

## 2. Copy replay_trace.json

Both machines need access to the same `replay_trace.json`.

Example:

```bash
scp captures/session_xxx/replay_trace.json user@LAB_PC:/path/to/replay_trace.json
```

You can also use a shared directory, as long as both sides use the same trace.

## 3. Start Server On The Lab PC

TCP example:

```bash
bash scripts/lab_replay_server.sh \
  --trace replay_trace.json \
  --host 0.0.0.0 \
  --port 9000 \
  --protocol tcp \
  --max-flows 3 \
  --role download
```

Dry run first if you want to inspect the command:

```bash
bash scripts/lab_replay_server.sh --trace replay_trace.json --protocol tcp --max-flows 3 --dry-run
```

## 4. Start Capture And Client On The Raspberry Pi

Run this on the Raspberry Pi. Capture usually needs `sudo` or dumpcap capabilities:

```bash
sudo bash scripts/lab_replay_client_capture.sh \
  --trace replay_trace.json \
  --pi-ip 192.168.31.102 \
  --server-ip 192.168.31.79 \
  --iface wlan0 \
  --duration 60 \
  --protocol tcp \
  --max-flows 3 \
  --role download
```

The script starts:

```text
packet_collector capture all PI_IP LAB_PC_IP --direction both --parse
packet_collector replay-client replay_trace.json --server LAB_PC_IP
```

The capture output includes a new task directory such as:

```text
captures/task_xxx
```

## 5. Analyze On The Raspberry Pi

After capture finishes:

```bash
bash scripts/lab_replay_analyze.sh \
  --task-dir captures/task_xxx \
  --iface wlan0 \
  --target 192.168.31.79
```

This runs:

```text
analyze-all
collect-ip
collect-device
report
```

## 6. View Results

The replay capture task contains:

```text
captures/task_xxx/
|-- *.pcapng
|-- packets.jsonl
|-- tcp_summary.json / udp_summary.json / icmp_summary.json
|-- dns_summary.json / http_summary.json / tls_summary.json
|-- ip_metrics.json
|-- device_metrics.json
`-- task_report.json
```

The original trace directory contains replay-side results when server/client
write into the trace directory:

```text
captures/session_xxx/
|-- replay_trace.json
|-- replay_result_server.json
`-- replay_result_client.json
```

## 7. UDP Replay Example

Lab PC:

```bash
bash scripts/lab_replay_server.sh --trace replay_trace.json --host 0.0.0.0 --port 9000 --protocol udp --max-flows 3
```

Raspberry Pi:

```bash
sudo bash scripts/lab_replay_client_capture.sh \
  --trace replay_trace.json \
  --pi-ip 192.168.31.102 \
  --server-ip 192.168.31.79 \
  --iface wlan0 \
  --duration 60 \
  --protocol udp \
  --max-flows 3
```

UDP is datagram based. On lossy paths, `short_read_count` may be nonzero.

## 8. Notes And Safety

- Capture only observes traffic. It does not participate in communication.
- `replay-client` must run on the Raspberry Pi side.
- `replay-server` must run on the lab PC side.
- The Raspberry Pi captures new traffic between `PI_IP` and `LAB_PC_IP`.
- Replay uses dummy payload, not the original TCP/TLS/HTTP bytes.
- HTTPS payload cannot be recreated or decrypted.
- `replay-server` and `replay-client` do not need sudo.
- Capture may need sudo or dumpcap capabilities.
- If `sudo` cannot find the project or virtual environment, try `sudo -E python3 -m packet_collector.cli ...` or install the package into the environment used by sudo.
- This workflow does not configure Mahimahi or Linux tc/netem.
- This workflow does not use pcap/tcpreplay original packet replay.
- There is no automatic cross-machine remote control; start the lab PC server and Raspberry Pi client/capture separately.
