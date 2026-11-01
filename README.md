# 车联网多源数据采集与可视化平台

本文档面向第一次拿到项目的开发和测试成员，说明项目组成、新电脑环境准备、硬件配置、启动方法、页面操作、数据输出以及常见问题。

请按照本文档从上到下操作。当前项目目录固定为：

```text
D:\ZQY\
```

如果项目没有放在该目录，部分部署命令需要对应修改。项目程序大多使用相对路径，但为了与当前测试环境保持一致，建议首次部署先保持上述路径。

---

## 1. 项目用途

本项目用于车联网道路测试场景，同时采集并展示以下数据：

- 无线侧指标：RSRP、RSRQ、SINR、BLER、频段、带宽等。
- 网络侧指标：RTT、吞吐量、抖动、丢包率等。
- GNSS定位：经纬度、地图位置和历史轨迹。
- 摄像头录像：实时预览、原始录像和逐帧真实时间戳。
- 用户端业务：标准化业务、MQTT仿真网关和视频缓存代理。

采集停止后，系统会自动：

1. 等待网络侧完成剩余窗口解析。
2. 将网络侧CSV与无线侧CSV进行时间对齐和融合。
3. 自动选择最新融合CSV供前端分析。
4. 按照帧时间戳将网络指标叠加到录像中。
5. 在页面右下角显示最终CSV和录像的保存路径。

项目技术路线见：

[技术路线框图](iov-data-collector-(ue-stack)/TECHNICAL_ROUTE.md)

---

## 2. 项目目录

```text
D:\ZQY\
├─ iov-data-collector-(ue-stack)\   前端、后端和数据可视化平台
│  ├─ frontend\                     React前端
│  ├─ backend\                      Node.js后端
│  └─ datas\                        融合后供前端分析的CSV
│
├─ packet_collector\                网络、GNSS和摄像头采集程序
│  ├─ packet_collector\             Python网络采集源码
│  ├─ video\                        录像和指标视频生成程序
│  ├─ Wireshark\                    dumpcap、tshark等工具
│  └─ captures\                     网络侧采集结果
│
├─ radio_capture\BJTUCC-main\       无线侧采集程序
│  ├─ radio_capture\                Python无线采集源码
│  ├─ configs\                      无线侧配置
│  ├─ send\                         厂商运行文件
│  ├─ Qwinlog\                      QWinLog配置
│  └─ captures\                     无线侧采集结果
│
├─ zqy\                             网络侧Python 3.12虚拟环境
├─ start_all_collectors.bat         手动启动采集脚本
└─ merge_capture_csv.bat            手动融合CSV脚本
```

日常运行主要使用网页上的“开启采集”和“停止采集”按钮。根目录批处理文件主要用于手动调试和故障排查。

---

## 3. 新电脑需要准备什么

即使整个 `D:\ZQY` 文件夹已经完整复制到新电脑，下面的软件和驱动仍需要在新电脑重新安装。

### 3.1 基础软件

需要安装：

1. Node.js 22 x64，包含npm。
2. Python 3.12 x64，用于网络、GNSS、录像和CSV处理。
3. Python 3.10 x86（32位），用于无线侧厂商DLL。
4. Npcap，用于Windows网络抓包。
5. GNSS设备驱动。
6. 无线模组的Trace、AT和相关USB驱动。
7. 摄像头驱动。

安装完成后打开CMD检查：

```bat
node -v
npm -v
py -0p
```

`py -0p` 中应同时存在：

- Python 3.12 64-bit
- Python 3.10 32-bit

### 3.2 安装Npcap

项目当前包含Npcap安装程序：

```text
D:\ZQY\packet_collector\Wireshark\npcap-1.86.exe
```

安装后检查服务：

```bat
sc query npcap
```

如果抓包提示权限不足，请以管理员身份运行后端或CMD。

---

## 4. 重新创建运行环境

### 4.1 为什么不能直接使用复制过来的虚拟环境

Python虚拟环境会记录原电脑上的Python安装位置和用户目录。即使项目路径仍然是 `D:\ZQY`，复制过来的 `zqy` 和 `.venv32` 也可能无法正常运行。

因此建议在新电脑删除复制过来的以下两个目录后重新创建：

```text
D:\ZQY\zqy\
D:\ZQY\radio_capture\BJTUCC-main\.venv32\
```

### 4.2 创建网络侧Python环境

在CMD中执行：

```bat
py -3.12 -m venv D:\ZQY\zqy

D:\ZQY\zqy\Scripts\python.exe -m pip install --upgrade pip

D:\ZQY\zqy\Scripts\python.exe -m pip install -r D:\ZQY\packet_collector\requirements.txt

D:\ZQY\zqy\Scripts\python.exe -m pip install -r D:\ZQY\packet_collector\requirements-windows.txt
```

检查：

```bat
D:\ZQY\zqy\Scripts\python.exe --version
```

### 4.3 创建无线侧32位Python环境

在CMD中执行：

```bat
cd /d D:\ZQY\radio_capture\BJTUCC-main

py -3.10-32 -m venv .venv32

.venv32\Scripts\python.exe -c "import struct; print(str(struct.calcsize('P')*8) + '-bit Python')"
```

最后必须显示：

```text
32-bit Python
```

无线侧程序当前没有需要额外安装的第三方Python包。

如果需要运行无线侧单元测试，再安装：

```bat
.venv32\Scripts\python.exe -m pip install pytest
```

### 4.4 安装前端和后端依赖

复制过来的 `node_modules` 也不建议继续使用。在CMD中执行：

```bat
cd /d D:\ZQY\iov-data-collector-(ue-stack)

npm install
```

根目录安装命令会自动安装前端和后端依赖。普通的 `deprecated` 提示通常不影响运行，只要没有 `npm error` 即可。

---

## 5. 连接硬件

建议在修改配置前连接：

- 无线模组或车载UE。
- 模组Trace/DM串口。
- 模组AT串口。
- GNSS NMEA串口。
- 摄像头。
- 实际承载被测业务流量的网络接口。

打开Windows设备管理器，记录各设备对应的COM端口。

不同电脑即使连接同一台设备，COM端口和网卡编号也可能不同。

---

## 6. 配置网络、GNSS和摄像头

配置文件：

```text
D:\ZQY\packet_collector\config.json
```

当前重点配置如下：

```json
{
  "capture": {
    "peer_ip": "测试服务器IP",
    "window_seconds": 0.4
  },
  "gps": {
    "enabled": true,
    "baudrate": 115200
  },
  "video": {
    "enabled": true,
    "format": "mp4",
    "fps": 20
  },
  "platform": {
    "windows": {
      "interface": "6",
      "gps_port": "COM4",
      "camera": "0"
    }
  }
}
```

### 6.1 查找抓包接口

执行：

```bat
cd /d D:\ZQY\packet_collector

Wireshark\dumpcap.exe -D
```

找到实际收发被测业务数据的网络接口，将前面的编号填写到：

```json
"interface": "接口编号"
```

接口编号不能直接照搬其他电脑。

### 6.2 设置GNSS串口

在设备管理器中找到NMEA端口，例如：

```json
"gps_port": "COM4"
```

如果不采集GNSS，可以设置：

```json
"gps": {
  "enabled": false
}
```

### 6.3 设置摄像头

内置摄像头通常为：

```json
"camera": "0"
```

如果预览打不开，可以依次尝试 `1`、`2`。

当前完整的停止、录像后处理和成果弹窗流程按照启用录像设计，正式测试建议保持：

```json
"video": {
  "enabled": true
}
```

---

## 7. 配置无线侧采集

配置文件：

```text
D:\ZQY\radio_capture\BJTUCC-main\configs\config.json
```

重点检查：

```json
{
  "runtime": {
    "python_arch": "x86",
    "dll_dir": ".\\send\\autocom_extracted\\Bin"
  },
  "ports": {
    "trace_port": 3,
    "at_port": 5
  },
  "output": {
    "dm_write_interval_sec": 0.4,
    "metrics_only": true
  }
}
```

端口填写规则：

- `trace_port: 3` 表示 `COM3`。
- `at_port: 5` 表示 `COM5`。
- 不使用某个端口时可以填写 `null`。

厂商DLL、QWinLog配置和相关运行文件必须保持完整。不要随意移动 `send`、`Qwinlog` 或厂商DLL目录。

---

## 8. 前端、后端和外部服务配置

平台包含三类连接：

1. 本地前端与本地Node.js后端。
2. MQTT Broker。
3. 远端业务和文件服务。

默认配置可以直接运行当前环境。如果需要更换服务器、MQTT账号或地图服务，可以参考：

```text
D:\ZQY\iov-data-collector-(ue-stack)\.env.example
```

前端Vite环境变量建议放在：

```text
D:\ZQY\iov-data-collector-(ue-stack)\frontend\.env.local
```

例如：

```env
VITE_API_TARGET=http://业务服务器IP:端口
VITE_AMAP_KEY=自己的高德地图WebKey
```

后端MQTT和远端服务变量可以在启动后端前通过CMD设置，或者配置成Windows系统环境变量。

不要把账号密码、Token、地图Key和安全码上传到GitHub。

---

## 9. 启动前先检查

### 9.1 检查网络侧

```bat
cd /d D:\ZQY\packet_collector

D:\ZQY\zqy\Scripts\python.exe -m packet_collector.orchestration.configured_capture --config config.json --dry-run
```

该命令只检查配置、工具和最终启动参数，不会开始真实采集。

### 9.2 检查无线侧

```bat
cd /d D:\ZQY\radio_capture\BJTUCC-main

.venv32\Scripts\python.exe -m radio_capture.cli --config configs\config.json --dry-run
```

成功时应看到：

```text
dry-run ok
```

`dry-run` 成功只表示Python位数、配置和文件检查通过。真实采集仍取决于设备驱动、串口和硬件连接。

---

## 10. 正常启动项目

项目开发模式需要两个CMD窗口。

### 10.1 启动后端

第一个CMD执行：

```bat
cd /d D:\ZQY\iov-data-collector-(ue-stack)\backend

npm run dev
```

开发后端默认监听：

```text
http://127.0.0.1:5000
```

### 10.2 启动前端

第二个CMD执行：

```bat
cd /d D:\ZQY\iov-data-collector-(ue-stack)\frontend

npm run dev
```

浏览器打开：

```text
http://127.0.0.1:3000/
```

前端使用Vite热更新。修改前端源码并保存后，浏览器通常会自动刷新。

后端使用 `tsx watch`。修改 `backend/server.ts` 后，后端通常会自动重启。

---

## 11. 页面使用方法

### 11.1 “开启采集”按钮

点击右上角“开启采集”后，本地后端会隐藏启动：

- 无线侧采集进程。
- 网络、GNSS和摄像头采集进程。

页面会显示：

- 摄像头实时录像预览。
- 网络侧实时RTT、吞吐量、抖动和丢包率。
- GNSS经纬度和地图位置。
- 无线侧实时指标。
- 采集状态和业务日志。

### 11.2 “停止采集”按钮

点击“停止采集”后不要立即关闭浏览器或后端。系统会依次进入：

```text
停止采集
→ 等待网络侧解析
→ 融合CSV
→ 生成指标录像
→ 自动加载最新CSV
→ 显示成果路径
```

等待按钮重新变成“开启采集”，并确认右下角出现最终CSV和录像路径后，本轮流程才算全部完成。

### 11.3 “开启业务流”按钮

“开启业务流”与“开启采集”是两个不同概念：

- 开启采集：启动无线、网络、GNSS和录像采集。
- 开启业务流：启动页面中的车辆状态、MQTT、地图导航、文件下载、事件上报等业务任务。

可以先开启采集，再开启业务流，使业务产生的网络流量被采集和分析。

### 11.4 数据可视化

数据源设置控制以下三个页面使用的CSV：

- 时序推演。
- 分布特征。
- 数据总览。

GPS定位页面也使用所选CSV中的经纬度数据。采集流程成功结束后，系统会自动选择本轮最新生成的融合CSV并执行分析。

---

## 12. 数据输出位置

### 12.1 网络、GNSS和录像

```text
D:\ZQY\packet_collector\captures\session_时间\
```

主要文件：

```text
window_metrics_gps.csv          网络指标与GNSS
camera_recording.mp4            原始录像
camera_frame_timestamps.csv     每一帧真实时间戳
camera_recording_metrics.mp4    叠加网络指标后的最终录像
```

### 12.2 无线侧数据

```text
D:\ZQY\radio_capture\BJTUCC-main\captures\session_时间\
```

主要文件：

```text
dm_metrics.csv
at_metrics.csv
4G_metrics.csv
merged_metrics.csv
```

### 12.3 前端分析数据

```text
D:\ZQY\iov-data-collector-(ue-stack)\datas\BJTU\
```

主要文件：

```text
session_时间_full.csv
```

### 12.4 采集日志

```text
D:\ZQY\.collector-control\logs\network.log
D:\ZQY\.collector-control\logs\radio.log
```

---

## 13. 手动运行和故障排查

### 13.1 手动启动两个采集程序

正常使用建议通过网页按钮启动。如果需要查看两个采集程序的独立CMD输出，可以执行：

```bat
cd /d D:\ZQY

start_all_collectors.bat
```

该脚本用于人工排查，运行方式可能与网页隐藏启动略有不同。

### 13.2 手动融合最新CSV

```bat
cd /d D:\ZQY

merge_capture_csv.bat
```

也可以明确指定网络侧和无线侧CSV：

```bat
merge_capture_csv.bat "网络侧CSV完整路径" "无线侧CSV完整路径"
```

### 13.3 前端打不开

检查：

- 前端CMD是否仍在运行。
- 3000端口是否被占用。
- 地址是否为 `http://127.0.0.1:3000/`。

### 13.4 点击开启采集没有反应

检查：

- 后端CMD是否仍在运行。
- 后端是否监听5000端口。
- Python虚拟环境是否重新创建。
- `.collector-control/logs` 中的错误日志。

### 13.5 网络指标一直为空

重新执行：

```bat
D:\ZQY\packet_collector\Wireshark\dumpcap.exe -D
```

确认 `packet_collector/config.json` 中的 `interface` 仍然对应实际业务网卡，并确认 `peer_ip` 与被测服务器一致。

### 13.6 GNSS一直等待定位

检查：

- NMEA串口是否正确。
- 串口是否被其他程序占用。
- 波特率是否为115200。
- GNSS是否已开启并且能够搜星。

### 13.7 摄像头预览一直转圈

检查：

- 摄像头是否被会议软件、浏览器或其他程序占用。
- `camera` 编号是否正确。
- 8765端口是否被占用。
- 网络采集日志中是否存在摄像头启动错误。

### 13.8 无线侧没有数据

检查：

- 是否使用32位Python。
- 厂商DLL是否完整。
- Trace/AT串口是否正确。
- 串口是否被其他工具占用。
- QWinLog配置是否与设备匹配。
- 无线侧日志中是否存在DLL加载或解码错误。

### 13.9 停止采集后长时间没有完成

网络侧停止后仍需要处理已经进入队列的抓包窗口，录像还需要执行指标叠加。采集时间越长，停止后的处理时间可能越长。

请先查看页面当前状态和后端CMD日志，不要直接结束后端进程，否则融合CSV和最终录像可能无法生成。

---

## 14. 修改代码后的检查

### 14.1 前端和后端构建

```bat
cd /d D:\ZQY\iov-data-collector-(ue-stack)

npm run build
```

### 14.2 网络侧测试

```bat
cd /d D:\ZQY\packet_collector

D:\ZQY\zqy\Scripts\python.exe -m pytest tests
```

### 14.3 无线侧测试

```bat
cd /d D:\ZQY\radio_capture\BJTUCC-main

.venv32\Scripts\python.exe -m pytest radio_capture\tests
```

真实串口、抓包、GNSS和摄像头功能仍需要使用实际硬件验证。

---

## 15. 团队协作注意事项

不要提交或公开以下内容：

- `node_modules` 和Python虚拟环境。
- PCAP、录像、真实车辆轨迹和未脱敏CSV。
- `.env`、地图Key、账号密码和Token。
- 本机端口配置和设备唯一标识。
- 没有确认再分发授权的厂商DLL、EXE、APK和反编译代码。

建议提交：

- 自研源代码。
- `package-lock.json` 和Python依赖文件。
- 配置模板，例如 `config.example.json`。
- 脱敏后的少量示例数据。
- README、部署文档和技术路线。

项目交给新成员后，第一次运行最重要的检查顺序是：

```text
安装软件和驱动
→ 重建两个Python环境
→ npm install
→ 检查网卡和COM端口
→ 执行两个dry-run
→ 启动后端
→ 启动前端
→ 进行一次短采集
→ 检查融合CSV和最终录像
```

