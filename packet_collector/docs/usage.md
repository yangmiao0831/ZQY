# Usage

## Config-driven capture

The normal deployment entry points read the root `config.json`. Edit that file
for peer IP, duration, Windows/Linux interface, GPS port, camera, display
export, output paths, and the bundled Wireshark directory.

```text
# Validate only; no real capture
python -m packet_collector.orchestration.configured_capture --config config.json --dry-run

# Windows CMD
scripts\capture.bat
scripts\capture_with_video.bat

# Linux
bash scripts/capture.sh
bash scripts/capture_with_video.sh
```

See `docs/configuration.md` for every field. The direct CLI examples below are
still supported for one-off and advanced workflows.

For online analysis, one `Ctrl+C` initiates graceful shutdown: capture stops
first, queued one-second windows continue through tshark, and the command exits
only after metrics CSV/JSONL and session metadata have been finalized.

Step 15 provides the full four-layer core, session capture, replay trace
generation, TCP single-flow / multi-flow replay, and UDP flow replay MVP.

## CLI Help

```bash
python3 -m packet_collector.cli --help
```

## Deployment Check

```bash
python3 -m packet_collector.cli check-env
python3 -m packet_collector.cli check-env --output deploy_check.json
```

## Raspberry Pi Smoke Test

```bash
bash scripts/pi_smoke_test.sh
```

## Capture and Parse

```bash
sudo python3 -m packet_collector.cli capture all 192.168.31.102 192.168.31.79 --direction both --duration 10 --parse
sudo python3 -m packet_collector.cli capture tcp 192.168.31.102 192.168.31.79 --direction both --duration 10 --parse
```

Use `capture all` for the normal troubleshooting flow: it captures every
protocol between the two hosts into the same pcapng task output, then parses a
single mixed `packets.jsonl`.

## Long-Running Session Capture

Use session capture for long outdoor collection runs that may rotate into many
pcapng files:

```bash
sudo python3 -m packet_collector.cli capture-session all 192.168.31.102 192.168.31.79 --direction both --duration 3600
```

Parse every session pcapng into per-file JSONL and one merged `packets.jsonl`:

```bash
python3 -m packet_collector.cli parse-session captures/session_xxx --packet-type all
```

Then reuse existing analysis and collection commands on the session directory:

```bash
python3 -m packet_collector.cli analyze-all captures/session_xxx
python3 -m packet_collector.cli collect-ip --iface wlan0 --target 192.168.31.79 --task-dir captures/session_xxx
python3 -m packet_collector.cli collect-device --task-dir captures/session_xxx
python3 -m packet_collector.cli report captures/session_xxx
```

Session layout:

```text
captures/session_xxx/
|-- session_meta.json
|-- pcaps/
|   |-- 000001.pcapng
|   `-- 000002.pcapng
|-- packets/
|   |-- 000001.jsonl
|   `-- 000002.jsonl
|-- packets.jsonl
`-- *_summary.json
```

## Experimental Replay Trace

Build `replay_trace.json` from a session-level `packets.jsonl`:

```bash
python3 -m packet_collector.cli build-replay-trace captures/session_xxx --pi-ip 192.168.31.102 --window-ms 100
```

Build from multiple per-pcap packet JSONL files:

```bash
python3 -m packet_collector.cli build-replay-trace captures/session_xxx \
  --pi-ip 192.168.31.102 \
  --input captures/session_xxx/packets/000001.jsonl \
  --input captures/session_xxx/packets/000002.jsonl \
  --output captures/session_xxx/replay_trace.json
```

`build-replay-trace` only creates a behavior trace. It does not run a replay
client or server and does not configure Mahimahi or tc/netem.

## TCP Replay

Run the replay server on the lab peer machine:

```bash
python3 -m packet_collector.cli replay-server captures/session_xxx/replay_trace.json --host 0.0.0.0 --port 9000 --role download
```

Run the replay client on the Raspberry Pi:

```bash
python3 -m packet_collector.cli replay-client captures/session_xxx/replay_trace.json --server 192.168.31.79 --port 9000 --role download
```

Run the top 3 download TCP flows concurrently:

```bash
python3 -m packet_collector.cli replay-server captures/session_xxx/replay_trace.json --host 0.0.0.0 --port 9000 --role download --max-flows 3
python3 -m packet_collector.cli replay-client captures/session_xxx/replay_trace.json --server 192.168.31.79 --port 9000 --role download --max-flows 3
```

Run all TCP flows:

```bash
python3 -m packet_collector.cli replay-server captures/session_xxx/replay_trace.json --host 0.0.0.0 --port 9000 --all-flows
python3 -m packet_collector.cli replay-client captures/session_xxx/replay_trace.json --server 192.168.31.79 --port 9000 --all-flows
```

The server writes:

```text
captures/session_xxx/replay_result_server.json
```

The client writes:

```text
captures/session_xxx/replay_result_client.json
```

TCP replay supports selected TCP flows and dummy payload only. Multi-flow
replay uses one thread and one TCP port per flow: `base_port`, `base_port + 1`,
and so on. It does not support Mahimahi, tc/netem, globally synchronized
multi-flow START, or pcap/tcpreplay original packet replay.

## UDP Replay

Run the UDP replay server on the lab peer machine:

```bash
python3 -m packet_collector.cli replay-server captures/session_xxx/replay_trace.json --host 0.0.0.0 --port 9000 --protocol udp --max-flows 3
```

Run the UDP replay client on the Raspberry Pi:

```bash
python3 -m packet_collector.cli replay-client captures/session_xxx/replay_trace.json --server 192.168.31.79 --port 9000 --protocol udp --max-flows 3
```

Use a smaller datagram chunk size if you want to avoid large UDP payloads:

```bash
python3 -m packet_collector.cli replay-client captures/session_xxx/replay_trace.json --server 192.168.31.79 --port 9000 --protocol udp --max-flows 3 --max-datagram-size 1000
```

UDP replay uses datagrams and a lightweight `HELLO` / `READY` / `START`
handshake for each flow. UDP is not reliable, so `short_read_count` may be
nonzero on lossy paths. `--protocol all` is reserved for a later combined
TCP/UDP scheduler and currently exits with a clear unsupported message.

## Mobile / Vehicle Capture

Mobile interfaces such as `wwan0` may change IPv4 addresses during a long
drive. Do not rely on the initial Pi IP as the only capture condition.

Recommended interface-wide session:

```bash
sudo python3 -m packet_collector.cli capture-session all \
  --iface wwan0 \
  --iface-only \
  --duration 3600 \
  --network-events \
  --network-events-interval 10
```

This binds dumpcap to `wwan0` without a host BPF. It captures all traffic on
the interface and therefore needs more storage.

Capture only traffic involving one stable server:

```bash
sudo python3 -m packet_collector.cli capture-session all \
  --iface wwan0 \
  --peer-only 47.93.192.193 \
  --duration 3600 \
  --network-events
```

Capture mode filters:

```text
iface-only:  ""                         (or "port 8085")
peer-only:   host 47.93.192.193         (optionally and port 8085)
two-host:    host PI_IP and host PEER_IP
```

`--direction` is still accepted and saved in metadata for iface-only and
peer-only modes, but it does not add local-IP direction clauses to their BPF.
Network events are written to `captures/session_xxx/network_events.jsonl`.

Build a trace from all IPv4 addresses observed during the session:

```bash
python3 -m packet_collector.cli build-replay-trace captures/session_xxx \
  --use-network-events \
  --window-ms 100
```

Explicit multi-IP and legacy single-IP forms:

```bash
python3 -m packet_collector.cli build-replay-trace captures/session_xxx \
  --pi-ip-list 10.233.139.93,10.73.236.21

python3 -m packet_collector.cli build-replay-trace captures/session_xxx \
  --pi-ip 10.233.139.93
```

## Lab Replay Workflow Scripts

For real lab replay, use two machines.

Lab PC starts `replay-server`:

```bash
bash scripts/lab_replay_server.sh \
  --trace replay_trace.json \
  --host 0.0.0.0 \
  --port 9000 \
  --protocol tcp \
  --max-flows 3 \
  --role download
```

Raspberry Pi starts capture first, then `replay-client`:

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

Raspberry Pi analyzes the replay capture:

```bash
bash scripts/lab_replay_analyze.sh \
  --task-dir captures/task_xxx \
  --iface wlan0 \
  --target 192.168.31.79
```

Dry run any script before running:

```bash
bash scripts/lab_replay_server.sh --trace replay_trace.json --protocol tcp --max-flows 3 --dry-run
```

Full guide:

```text
scripts/lab_replay_quickstart.md
```

The scripts do not perform automatic cross-machine control. They do not
configure Mahimahi, tc/netem, or pcap/tcpreplay.

To capture the replayed traffic on the Raspberry Pi, run a normal capture in
another terminal while the replay client/server exchange data:

```bash
sudo python3 -m packet_collector.cli capture all 192.168.31.102 192.168.31.79 --direction both --duration 60 --parse
```

## One-Command Full Task

Run capture, parse, all summaries, IP collection, device collection, and report:

```bash
bash scripts/run_full_task.sh 192.168.31.102 192.168.31.79
```

Optional overrides:

```bash
IFACE=wlan0 DURATION=20 bash scripts/run_full_task.sh 192.168.31.102 192.168.31.79
```

The script uses `sudo` by default for commands that write into the task
directory, because real capture often creates root-owned files. If dumpcap has
capabilities configured and sudo is not needed:

```bash
RUN_WITH_SUDO=0 bash scripts/run_full_task.sh 192.168.31.102 192.168.31.79
```

## Continuous TCP Window Capture

The existing session mode remains unchanged unless `--window-mode` is set.
The first windowed implementation is TCP-only.

Capture one-second pcapng windows while continuously appending compact metrics:

```bash
sudo python3 -m packet_collector.cli capture-session tcp \
  --iface eth0 --iface-only --duration 3600 \
  --window-mode online-analysis --window-seconds 1 --window-retention 100
```

Append the latest raw GPS fix to the same per-window CSV row:

```bash
sudo python3 -m packet_collector.cli capture-session tcp \
  --iface eth0 --iface-only --duration 3600 \
  --window-mode online-analysis --window-seconds 1 --window-retention 100 \
  --with-gps --gps-port /dev/ttyUSB1 --gps-baudrate 115200
```

Configured capture keeps `captures/session_xxx/window_metrics_gps.csv` local
and does not publish network-only data. After both collectors finish, run
`D:\ZQY\merge_capture_csv.bat`. It aligns the latest network and radio CSVs by
whole second, writes `network_radio_merged.csv` in the network session, copies
the merged full CSV to `datas/BJTU/`, and creates non-overlapping 60-second
files under `datas/BJTU_1min/`.

To produce the same one-second windows without online tshark analysis:

```bash
sudo python3 -m packet_collector.cli capture-session tcp \
  --iface eth0 --iface-only --duration 3600 \
  --window-mode capture-only --window-seconds 1 --window-retention 100
```

Window mode produces:

```text
captures/session_xxx/
  pcaps/                 durable merged pcapng archives
  window_pcaps/          latest 100 one-second pcapng windows
  window_metrics.jsonl   one compact result per window (online-analysis only)
  window_metrics_gps.csv compact TCP metrics plus latest GPS fix (--with-gps)
  session_meta.json
```

Each metrics line contains only `index`, `avg_rtt_ms`, `jitter_ms`,
`throughput_bps`, and `loss_rate`. RTT comes from TCP ACK RTT samples available
inside that window. Jitter is the mean absolute difference of consecutive RTT
samples. Throughput is TCP payload goodput. Loss rate is an estimate based on
retransmitted TCP data packets divided by TCP data packets; it is not a direct
link-layer packet-loss measurement. Cross-window ACK/RTT matches are discarded.

The optional GPS CSV uses:

```csv
index,timestamp,avg_rtt_ms,jitter_ms,throughput_bps,loss_rate,gcj02_latitude,gcj02_longitude
```

`timestamp` is the local time when the row is written. `gcj02_latitude` and
`gcj02_longitude` are AMap-compatible GCJ-02 coordinates calculated from the
latest valid GPS fix. If no valid GPS fix has been observed yet, those fields
are left empty. If GPS has not updated since the previous window, the latest
available fix is reused.

`Ctrl+C` stops dumpcap, processes the final closed segment, and flushes pending
windows into the durable `pcaps/` archive. The archive can later be parsed with
the normal session commands:

```bash
python3 -m packet_collector.cli parse-session captures/session_xxx --packet-type tcp
python3 -m packet_collector.cli analyze-all captures/session_xxx
```

## Analysis

```bash
python3 -m packet_collector.cli analyze-all captures/task_xxx
python3 -m packet_collector.cli analyze-tcp captures/task_xxx
python3 -m packet_collector.cli analyze-udp captures/task_xxx
python3 -m packet_collector.cli analyze-icmp captures/task_xxx
python3 -m packet_collector.cli analyze-dns captures/task_xxx
python3 -m packet_collector.cli analyze-http captures/task_xxx
python3 -m packet_collector.cli analyze-tls captures/task_xxx
```

## Active Probes

```bash
python3 -m packet_collector.cli probe ping 192.168.31.1 --count 4 --timeout 5
python3 -m packet_collector.cli probe dns example.com --timeout 5
python3 -m packet_collector.cli probe http http://example.com --timeout 10 --method GET
python3 -m packet_collector.cli probe tls example.com --port 443 --timeout 10
```

## Device Runtime Collection

```bash
python3 -m packet_collector.cli collect-device
python3 -m packet_collector.cli collect-device --output captures/task_xxx/device_metrics.json
python3 -m packet_collector.cli collect-device --task-dir captures/task_xxx
python3 -m packet_collector.cli collect-device --disk-path /
```

## IP Layer Collection

Collect local IP-layer state:

```bash
python3 -m packet_collector.cli collect-ip --iface wlan0
```

Collect with target connectivity ping:

```bash
python3 -m packet_collector.cli collect-ip --iface wlan0 --target 192.168.31.79
```

Write to an explicit JSON file:

```bash
python3 -m packet_collector.cli collect-ip --iface wlan0 --output captures/task_xxx/ip_metrics.json
```

Write to a task directory and update metadata:

```bash
python3 -m packet_collector.cli collect-ip --iface wlan0 --target 192.168.31.79 --task-dir captures/task_xxx
```

Default task output path:

```text
captures/task_xxx/ip_metrics.json
```

## Task Report

Generate the default report:

```bash
python3 -m packet_collector.cli report captures/task_xxx
```

Use a custom report path:

```bash
python3 -m packet_collector.cli report captures/task_xxx --output captures/task_xxx/my_report.json
```

Full four-layer flow example:

```bash
sudo python3 -m packet_collector.cli capture all 192.168.31.102 192.168.31.79 --direction both --duration 10 --parse
python3 -m packet_collector.cli analyze-all captures/task_xxx
python3 -m packet_collector.cli collect-ip --iface wlan0 --target 192.168.31.79 --task-dir captures/task_xxx
python3 -m packet_collector.cli collect-device --task-dir captures/task_xxx
python3 -m packet_collector.cli report captures/task_xxx
```

## Scope Notes

This project does not collect Wi-Fi access state such as SSID/BSSID/signal,
does not collect cellular metrics, and does not generate a complex diagnosis
report.
