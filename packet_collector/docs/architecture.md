# Architecture

## Configuration entry point

`config.json` is loaded by `packet_collector.app_config`. It deep-merges stable
defaults, selects `platform.windows` or `platform.linux`, validates values, and
resolves relative paths from the config file directory. The
`packet_collector.orchestration.configured_capture` entry point then invokes
the existing `capture-session` workflow, optionally coordinated with camera
recording. This configuration layer does not replace or remove the lower-level
CLI.

`packet_collector` is a command-line four-layer network quality collection and analysis system for Raspberry Pi 5. The implemented target layers are IP, transport, application, and device runtime.

## Responsibilities

- `dumpcap` is responsible for packet capture.
- `tshark` is responsible for parsing `.pcapng` files.
- Python is responsible for scheduling, task management, file management, JSONL generation, summaries, active probes, IP-layer collection, device runtime collection, reports, and deployment checks.

The system does not depend on Wireshark GUI or any graphical desktop component.

## Planned Capture Flow

1. CLI receives packet type, Pi IP, peer IP, direction, port, interface, duration, and file rotation options.
2. Task manager creates `task_xxx/` and writes `task_meta.json`.
3. Capture module builds a BPF filter.
4. `dumpcap` writes `.pcapng` into `/tmp/packet_collector/captures`.
5. Python copies completed artifacts into `captures/task_xxx/`.
6. `tshark` parsing streams packet data into `packets.jsonl`.
7. Analyzers generate transport and application summaries.
8. Active probes, IP collectors, and device collectors write JSON outputs and update task metadata when requested.
9. The report generator aggregates existing JSON artifacts into `task_report.json`.
10. The deploy checker verifies command/package/path readiness and writes `deploy_check.json` when requested.

## Long Capture Session Flow

Long-running outdoor collection uses `captures/session_xxx/` instead of many
short independent task directories:

```text
capture-session
  -> /tmp/packet_collector/captures/session_xxx_*.pcapng
  -> captures/session_xxx/pcaps/000001.pcapng ...
parse-session
  -> captures/session_xxx/packets/000001.jsonl ...
merge
  -> captures/session_xxx/packets.jsonl
analyze-all
  -> tcp/udp/icmp/dns/http/tls_summary.json
build-replay-trace
  -> replay_trace.json
future replay-client/server
  -> regenerated legal TCP/UDP traffic
```

Session capture is an organization layer for long pcapng runs and future
flow-level replay. It does not replay traffic, call Mahimahi, configure
tc/netem, or add a new metric layer.

## Continuous TCP Window Flow

Window mode uses one dumpcap process. Capture never waits for tshark analysis:

```text
dumpcap -b duration:1
  -> closed temporary pcapng window
  -> window_pcaps/ (latest N retained)
  -> optional tshark TCP window analysis
  -> window_metrics.jsonl (append-only)
  -> mergecap batches
  -> pcaps/000001.pcapng ... (durable full-session archive)
```

A window file is eligible for retention cleanup only after it has been copied
into a durable archive. Existing `parse-session` reads only `pcaps/`, avoiding
duplicate packet records from `window_pcaps/`.

## Experimental Replay Trace Flow

`build-replay-trace` reads one or more packet JSONL files, filters TCP/UDP
records, groups them into canonical endpoint-pair flows, aggregates events by
time window, and writes `replay_trace.json`.

```text
packets.jsonl
  -> TCP/UDP flow extraction
  -> time-window event aggregation
  -> replay_trace.json
```

The trace stores flow direction, payload byte counts, packet counts, timing,
and coarse role classification such as upload, download, or bidirectional.
It does not contain original payload bytes and does not replay traffic.

## Replay MVP

The experimental replay MVP uses `replay_trace.json` to create new legal TCP or
UDP traffic between a lab peer and the Raspberry Pi:

```text
replay_trace.json
  -> select one or more TCP/UDP flows
  -> replay-server opens base_port + N on lab peer
  -> replay-client connects to base_port + N from Raspberry Pi
  -> new TCP connections or UDP datagrams with dummy bytes
  -> replay_result_server.json / replay_result_client.json
```

`peer_to_pi` events are sent by the server and received by the client.
`pi_to_peer` events are sent by the client and received by the server. A small
handshake aligns the replay start time; TCP uses a line-based socket handshake,
and UDP uses datagram `HELLO` / `READY` / `START`. Both sides then schedule
events with local monotonic clocks. Multi-flow replay uses one thread per flow
and one port per flow. The first multi-flow implementation does not enforce one
global START barrier across every flow, so inter-flow timing is approximate.

UDP replay is datagram based and may report short reads if datagrams are lost.
This MVP does not support `--protocol all`, Mahimahi, Linux tc/netem,
pcap/tcpreplay original packet replay, or original payload replay.

## Lab Replay Operation

The lab workflow is intentionally split across two machines:

```text
Lab PC:
  lab_replay_server.sh
  -> packet_collector replay-server

Raspberry Pi:
  lab_replay_client_capture.sh
  -> packet_collector capture all PI_IP LAB_PC_IP --parse
  -> packet_collector replay-client

Raspberry Pi:
  lab_replay_analyze.sh
  -> analyze-all
  -> collect-ip / collect-device
  -> report
```

Traffic path:

```text
Lab PC replay-server
  <---- new TCP/UDP dummy traffic ---->
Raspberry Pi replay-client

Raspberry Pi packet_collector capture observes the same host-pair traffic.
```

The scripts are operation wrappers only. They do not add protocols, configure
network impairment, run pcap/tcpreplay, or remotely control the other machine.

## Raspberry Pi 5 Notes

- Capture may require `sudo` or dumpcap capabilities.
- Missing `dumpcap`, missing `tshark`, permission denied, and interface-not-found errors should be explicit.
- Large pcapng files should not be loaded fully into memory.
- JSONL is preferred over a single large JSON array.
- `check-env` does not run capture or pcap parsing; it only checks readiness.
