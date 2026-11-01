# Windows CMD Deployment

Windows can replace the Raspberry Pi when the Windows computer is the endpoint
that sends and receives the measured traffic. These instructions use CMD, not
PowerShell.

## 1. Install prerequisites

Install Python 3.10 or newer. This project may carry a portable Wireshark copy
at `packet_collector\Wireshark`; the Python core and CMD scripts detect that
directory automatically. Npcap is still a Windows kernel driver and must be
installed. Run `Wireshark\npcap-1.86.exe` if the Npcap service is absent. If
packet capture is denied, enable non-administrator capture in Npcap or open CMD
as Administrator.

When the bundled directory is not present, make a system Wireshark installation
available in the current CMD session:

```bat
set "PATH=C:\Program Files\Wireshark;%PATH%"
```

From the directory containing `packet_collector`:

```bat
python -m venv zqy
call zqy\Scripts\activate.bat
python -m pip install -r packet_collector\requirements-windows.txt
```

Keep these directories next to each other if automatic CSV export is wanted:

```text
ZQY\
|-- packet_collector\
|   `-- Wireshark\
|-- iov-data-collector-(ue-stack)\
`-- zqy\
```

## 2. Check the environment and interface

```bat
cd packet_collector
scripts\check_windows_env.bat
scripts\list_interfaces.bat
```

Use the interface number printed by `dumpcap -D`. Windows does not use names
such as `wwan0`, `eth0`, or `wlan0`.

## 3. Configure capture

Edit `packet_collector\config.json`. The most commonly changed Windows fields
are:

```json
{
  "capture": {
    "peer_ip": "47.93.192.193",
    "duration_sec": 600
  },
  "platform": {
    "windows": {
      "interface": "6",
      "gps_port": "COM3",
      "camera": "0"
    }
  }
}
```

The repository contains the complete JSON object; the snippet above only shows
the fields changed most often. Relative paths are resolved from the directory
containing `config.json`.

Validate and print the effective command without capturing:

```bat
python -m packet_collector.orchestration.configured_capture --config config.json --dry-run
```

## 4. Capture with GPS and video

```bat
scripts\capture_with_video.bat
```

The configured interface and `COM3` are examples. Obtain the interface from
`dumpcap -D` and the COM port from Windows Device Manager.

Press `Ctrl+C` in CMD to stop early. The Python launcher asks both child
processes to stop and waits for session CSV finalization.

Outputs remain under:

```text
packet_collector\captures\session_xxx\
```

Display copies default to:

```text
iov-data-collector-(ue-stack)\datas\BJTU\
iov-data-collector-(ue-stack)\datas\BJTU_1min\
```

## 5. Capture without video

```bat
scripts\capture.bat
```

`capture.bat` always suppresses video but reads all other settings from
`config.json`. To disable GPS, set `gps.enabled` to `false`. For a one-off
override without editing JSON:

```bat
scripts\capture.bat --iface 7 --duration 120
```

## 6. Existing analysis commands

The parsing, analyzers and report generator are shared by Linux and Windows:

```bat
python -m packet_collector.cli parse-session captures\session_xxx --packet-type tcp
python -m packet_collector.cli analyze-all captures\session_xxx
python -m packet_collector.cli collect-device --task-dir captures\session_xxx
python -m packet_collector.cli collect-ip --iface "Mobile" --task-dir captures\session_xxx
python -m packet_collector.cli report captures\session_xxx
```

For `collect-ip`, use the Windows adapter name shown by `ipconfig /all` or
`python -c "import psutil; print(*psutil.net_if_stats(), sep='\n')"`. This name
may differ from the numeric `dumpcap` capture interface.

## Limits

- The Windows computer must carry the traffic being measured. It cannot see
  another endpoint's switched traffic without mirroring, bridging, or a TAP.
- Raspberry Pi temperature and Linux load-average fields may be unavailable on
  Windows. CPU, memory, disk and uptime still use `psutil`.
- Windows camera input uses a numeric index such as `0`; GPS uses a COM port.
- The CMD launchers do not require PowerShell.
