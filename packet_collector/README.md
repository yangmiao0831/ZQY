一、云端服务器启动操作：
打开一个终端
cd iov-data-collector-ue-stack-3
'''
可选 如有修改再运行这个
rm -rf node_modules frontend/node_modules backend/node_modules
rm -rf frontend/dist backend/dist
'''
npm install
npm run build

NODE_ENV=production npm run start

然后浏览器打开http://树莓派IP:3000

项目脚本不依赖固定安装目录。只要 `packet_collector`、
`iov-data-collector-(ue-stack)` 和可选虚拟环境 `zqy` 保持为同级目录，
整个上级目录可以移动到任意位置；脚本会根据自身位置自动计算路径。

## 统一配置文件

日常采集参数统一放在项目根目录的 `config.json`。通常只需要修改：

- `capture.peer_ip`、`capture.duration_sec`
- `platform.windows.interface` 或 `platform.linux.interface`
- `platform.windows.gps_port` 或 `platform.linux.gps_port`
- `platform.*.camera`
- `gps.enabled`、`video.enabled`、`video.format`、`display.enabled`

所有相对路径均以 `config.json` 所在目录为基准，因此项目整体移动后不需要
修改绝对路径。Windows 和 Linux 的设备配置分开保存，程序会自动选择当前系统。
`video.format` 支持 `mp4` 和 `avi`；默认 `mp4` 使用 `mp4v` 编码。

仅检查配置和最终命令，不启动真实采集：

```text
python -m packet_collector.orchestration.configured_capture --config config.json --dry-run
```

启动脚本：

```text
Windows CMD: scripts\capture.bat 或 scripts\capture_with_video.bat
Linux:       bash scripts/capture.sh 或 bash scripts/capture_with_video.sh
```

在线分析采用连续的一秒抓包窗口和后台分析队列。按一次 `Ctrl+C` 后仅停止
继续抓包，已经关闭的窗口会继续完成分析、CSV/JSONL 写入和 pcap 归档，随后
程序自动退出。指标时间戳使用逻辑窗口时间，不再使用 tshark 分析完成时间。
中断产生的最后一个不足一秒窗口仍会归档，但不作为完整一秒指标写入 CSV。

## Windows 电脑替代树莓派

项目现在支持 Windows 原生 CMD 入口，不依赖 PowerShell。Windows 电脑必须
是实际收发被测流量的终端。项目会自动使用 `packet_collector\Wireshark`
中的便携版命令；仍需安装 Npcap 驱动和 Python 3.10+。

首次准备：

```bat
cd D:\ZQY
python -m venv zqy
call zqy\Scripts\activate.bat
python -m pip install -r packet_collector\requirements-windows.txt
cd packet_collector
scripts\check_windows_env.bat
scripts\list_interfaces.bat
```

先在 `config.json` 中填写 `platform.windows.interface`、GPS 串口等参数，
然后在 CMD 中运行联动采集与录像：

```bat
scripts\capture_with_video.bat
```

配置中的网卡编号和 `COM3` 只是示例，应以本机实际结果为准。
完整说明见 `docs/windows_cmd.md`。

如果想后台运行则:
sudo npm install -g pm2

NODE_ENV=production pm2 start npm --name iov-agent-platform -- run start
pm2 logs iov-agent-platform

二、采集信息操作
打开一个终端
cd /path/to/ZQY
source ./zqy/bin/activate
cd ./packet_collector

采集网口的所有流量信息：
sudo python3 -m packet_collector.cli capture-session all --iface wwan0 --iface-only --duration 3600 --network-events

采集云服务器与网口的流量信息：
sudo python3 -m packet_collector.cli capture-session all --iface wwan0 --peer-only 47.93.192.193 --duration 3600 --network-events


sudo python3 -m packet_collector.cli capture-session tcp \
  --iface wwan0 \
  --peer-only 47.93.192.193 \
  --duration 60 \
  --window-mode online-analysis \
  --window-seconds 1 \
  --window-retention 100 \
  --with-gps \
  --gps-port /dev/ttyUSB1 \
  --gps-baudrate 115200

采集正常结束或按 Ctrl+C 中断后，网络侧原始 CSV 只保存在 session 目录中。
网络侧和无线侧采集均结束后，在 Windows CMD 运行：

```bat
cd /d D:\ZQY
merge_capture_csv.bat
```

脚本按整秒融合最新的 `window_metrics_gps.csv` 和 `dm_metrics.csv`，并生成：

```text
iov-data-collector-(ue-stack)/datas/BJTU/session_xxx_full.csv
iov-data-collector-(ue-stack)/datas/BJTU_1min/session_xxx_0001.csv
```

要删除采集信息先进行操作：
sudo chown -R "$(id -u):$(id -g)" ./captures

分析：
sudo python3 -m packet_collector.cli parse-session captures/session_xxx --packet-type all
sudo python3 -m packet_collector.cli analyze-all captures/session_xxx
python3 -m packet_collector.cli collect-device --task-dir captures/session_xxx
sudo python3 -m packet_collector.cli collect-ip --iface wwan0 --task-dir captures/session_xxx
sudo python3 -m packet_collector.cli report captures/session_xxx

三、进行GNSS定位
sudo minicom -D /dev/ttyUSB2 -b 115200

'''
退出操作：
Ctrl + A
再按 X
选择 Yes
'''
ATE1

AT+QGPS?

+QGPS: 0说明 GPS 没开。
AT+QGPS=1

AT+QGPSLOC=0



用python查看数据
查找NMEA口
sudo cat /dev/ttyUSB1
sudo cat /dev/ttyUSB2
sudo cat /dev/ttyUSB3

pip install pyserial
nano read_gps.py

import serial
port = "/dev/ttyUSB1"   # 改成你的 NMEA 口
baudrate = 115200
ser = serial.Serial(port, baudrate, timeout=1)
print(f"Reading GPS NMEA from {port}...")
while True:
    line = ser.readline().decode(errors="ignore").strip()
    if line:
        print(line)

python3 read_gps.py
$GNRMC,083559.00,A,3912.3456,N,11612.3456,E,...就是对的A变成V就是错的






联动录像（参数读取根目录 `config.json`）：

```bash
bash scripts/capture_with_video.sh
```

联动脚本默认按照 `display` 配置发布完整 CSV 和一分钟分片。将
`display.enabled` 改为 `false` 可关闭，数据目录和来源名称分别由
`display.data_dir`、`display.source` 设置。

独立测试csv文件
python3 video/record_camera.py \
  --camera /dev/video0 \
  --gps-csv captures/session_xxx/window_metrics_gps.csv \
  --output video/recordings/test.mp4


  PREVIEW_WIDTH=960 \
CAMERA=/dev/video0 \
IFACE=wwan0 \
PEER_IP=47.93.192.193 \
DURATION=60 \
bash scripts/capture_with_video.sh
