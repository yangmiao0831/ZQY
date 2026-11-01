# Metrics Plan

The four-layer core is implemented: IP, transport, application, and device
runtime. Step 9 added `task_report.json` aggregation. Step 10 adds deployment
environment checks as engineering readiness checks, not a new metric layer.
Step 11 adds long-running session capture as a data organization workflow, not
a new metric layer. Step 12 adds experimental replay trace generation, also not
a new metric layer. Steps 13 and 14 add TCP replay MVP capabilities, and Step
15 adds UDP flow replay. These are experimental traffic generation features,
not metric layers. Step 16 adds lab replay operation scripts and documentation,
also not a metric layer.

## 1. IP Layer

Implemented:

- Interface state.
- Local IPv4 and IPv6 addresses.
- MTU.
- Default route.
- Gateway.
- DNS servers.
- Gateway ping.
- Target ping.

Optional future work:

- tracepath/traceroute.

## 2. Transport Layer

Implemented:

- TCP packet count, frame bytes, TCP payload bytes.
- TCP stream summaries.
- TCP retransmissions, fast retransmissions, and out-of-order count.
- TCP ACK RTT stats.
- TCP throughput estimates.
- UDP packet count, frame bytes, UDP bytes, endpoint counters, and throughput estimates.
- ICMP packet count, endpoint counters, type/code counters, echo request/reply counts, and error message count.

## 3. Application Layer

Implemented:

- DNS query counts, unique query counts, query types, response codes, answer counters, endpoint counters, and optional latency fields when present.
- HTTP request/response counts, methods, hosts, URIs, user agents, status codes, content types, content length total, endpoint counters, and optional latency fields when present.
- TLS handshake types, SNI, record versions, handshake versions, endpoint counters, and TCP stream counters.
- Active DNS/HTTP/TLS probes as auxiliary application-layer checks.
- TLS/HTTPS content is not decrypted; URL paths, headers, and bodies are not visible.

## 4. Device Runtime Layer

Implemented:

- CPU usage.
- Memory usage.
- Disk usage.
- System load average.
- Temperature.
- Time synchronization.
- Uptime.

## Out Of Scope

- Wi-Fi access metrics.
- Cellular metrics.
- RRC/Attach/TAU/PDU Session/APN/5QI.
- GPS, road scene, and video/image recognition.
- Complex dashboard.
- Complex diagnosis system.

## Task Report

Implemented:

- Reads existing JSON artifacts from a task directory.
- Aggregates IP, transport, application, active probe, and device runtime sections.
- Handles missing or invalid JSON files without failing the whole report.
- Produces `task_report.json`.
- Adds a small high-level status summary without generating a complex diagnosis.

## Deployment Check

Implemented engineering checks:

- Python version.
- `dumpcap`, `tshark`, `ping`, and `ip` command availability.
- `psutil` and `yaml` import availability.
- Temporary capture directory write access.
- Final capture directory write access.
- Output file: `deploy_check.json`.

## Session Capture

Implemented engineering workflow:

- `capture-session` creates `captures/session_xxx/`.
- Rotated pcapng files are copied into `pcaps/000001.pcapng`,
  `pcaps/000002.pcapng`, and so on.
- `parse-session` creates per-pcap JSONL files under `packets/`.
- `parse-session` merges per-pcap JSONL files into session-level
  `packets.jsonl`.
- Existing analyzers can read the session-level `packets.jsonl`.
- Optional TCP window mode rotates pcapng files by time while dumpcap continues
  capturing.
- `capture-only` keeps the latest bounded window files and durable full-session
  archives without online analysis.
- `online-analysis` appends per-window RTT, RTT jitter, TCP payload goodput, and
  retransmission-ratio estimates to `window_metrics.jsonl`.
- Window pcap retention defaults to 100; durable archives under `pcaps/` are
  preserved for later `parse-session` and full analysis.

Session capture prepares data for future flow-level replay research. It does
not implement replay traces, replay clients or servers, Mahimahi integration,
tc/netem control, or original-pcap replay.

## Experimental Replay Extension

Implemented preparation step:

- `build-replay-trace` reads task or session `packets.jsonl`.
- TCP/UDP records are grouped into flow-level behavior traces.
- Events are aggregated by configurable time windows.
- Output file: `replay_trace.json`.
- `replay-server` and `replay-client` can generate legal TCP traffic from one
  selected TCP flow or from multiple selected TCP flows in `replay_trace.json`.
- `replay-server` and `replay-client` can generate UDP datagram traffic from
  selected UDP flows in `replay_trace.json`.
- Multi-flow replay uses one thread and one port per selected flow.
- Replay results are written to `replay_result_server.json` and
  `replay_result_client.json`.

Not implemented in this step:

- Combined `--protocol all` TCP/UDP scheduler.
- Globally synchronized multi-flow START.
- Mahimahi integration.
- Linux tc/netem control.
- Original pcap/tcpreplay packet replay.
- Original payload replay.

Replay remains an experimental extension outside the four-layer core. Future
work can add a combined TCP/UDP replay scheduler, tighter multi-flow
synchronization, and optional network impairment wrappers, then feed generated
traffic back through capture, parse, analyze, and report.

## Lab Replay Scripts

Implemented operational helpers:

- `scripts/lab_replay_server.sh` runs replay-server on the lab PC.
- `scripts/lab_replay_client_capture.sh` starts capture and replay-client on
  the Raspberry Pi.
- `scripts/lab_replay_analyze.sh` runs analysis, collectors, and report on the
  Raspberry Pi.
- `scripts/lab_replay_quickstart.md` documents the two-machine workflow.

These scripts do not introduce a new metric layer and do not configure
Mahimahi, Linux tc/netem, pcap/tcpreplay, or remote machine control.
