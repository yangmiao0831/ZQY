# Central Configuration

The root `config.json` is the normal place to change capture deployment
settings. Both Windows CMD launchers and Linux shell launchers read this file.

## Common capture settings

| Field | Meaning |
|---|---|
| `capture.peer_ip` | Remote cloud or peer IP used by the capture filter |
| `capture.duration_sec` | Planned capture duration in seconds |
| `capture.window_seconds` | Online TCP analysis window length |
| `capture.window_retention` | Number of recent per-window pcap files retained |
| `capture.final_capture_dir` | Session output directory |
| `capture.tmp_capture_dir` | Temporary pcap directory; `null` selects the OS temp directory |
| `capture.network_events` | Enable periodic interface event snapshots |

The current configured workflow intentionally uses `packet_type=tcp`, a
peer-only capture filter, and online analysis. The lower-level CLI still
supports its existing packet types and capture modes when invoked manually.

Keep `capture.window_seconds` at `1` for complete one-second metrics. dumpcap
continues capturing while a non-daemon background worker analyzes previously
closed windows, so analysis does not require a capture gap. CSV and JSONL
timestamps are logical window timestamps (`actual start + index * window_seconds`),
not the later wall-clock time at which tshark finishes.

Pressing `Ctrl+C` once stops creation of new capture windows. The process then
drains every queued window, writes JSONL and CSV rows in index order, archives
pcap files, updates `session_meta.json`, and exits automatically. The combined
video launcher waits for this finalization without imposing a fixed timeout.
If interruption leaves one final window shorter than a full second, that pcap
segment is still archived but is not emitted as a one-second metrics row;
`session_meta.json` records it in `partial_window_count`.

## Device settings

`platform.windows` and `platform.linux` keep operating-system-specific device
names separate. The loader automatically selects the current operating system.

Windows example:

```json
"windows": {
  "interface": "6",
  "gps_port": "COM3",
  "camera": "0"
}
```

Use `scripts\list_interfaces.bat` to find the dumpcap interface number. Use
Windows Device Manager to find the GPS COM port.

Linux example:

```json
"linux": {
  "interface": "wwan0",
  "gps_port": "/dev/ttyUSB1",
  "camera": "/dev/video0"
}
```

## GPS, video, and display export

- `gps.enabled` controls serial GPS collection.
- `video.enabled` is the default used when the Python entry point is called
  without `--video` or `--no-video`.
- `video.fps`, `video.width`, and `video.height` configure recording. Keep
  width and height as `null` to use the camera's default resolution.
- `display.enabled` controls publishing the merged network/radio CSV to the
  display project's data directory when `merge_capture_csv.bat` runs.
- `display.data_dir` defaults to the sibling frontend/backend project.
- `display.source` controls the source directory name such as `BJTU`.

Configured capture always keeps its authoritative network CSV in the session
directory. It does not publish network-only rows to the display directory.
Display publishing happens only after the separate CSV merge succeeds.

## Paths and tools

Relative paths are resolved against the directory containing `config.json`,
not the terminal's current directory. This keeps the whole workspace movable.
`tools.wireshark_dir` points to the bundled Wireshark directory and is passed
to the existing dumpcap, tshark, and mergecap discovery code.

## Launch and validate

Windows CMD:

```bat
scripts\capture.bat
scripts\capture_with_video.bat
```

Linux:

```bash
bash scripts/capture.sh
bash scripts/capture_with_video.sh
```

Validate and print the effective capture command without running it:

```text
python -m packet_collector.orchestration.configured_capture --config config.json --dry-run
```

Temporary overrides are available for quick tests and do not modify JSON:

```text
python -m packet_collector.orchestration.configured_capture --config config.json --no-video --iface 7 --peer-ip 192.0.2.10 --duration 30
```
