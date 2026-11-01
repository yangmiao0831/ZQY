# Windows 部署说明

本文档用于在另一台 Windows 电脑上恢复当前项目的运行环境。项目路径固定为：

```text
D:\ZQY\
```

## 1. 准备完整目录

把旧电脑上的项目复制到新电脑，并保持下面的结构：

```text
D:\ZQY\
├─ iov-data-collector-(ue-stack)\
├─ packet_collector\
├─ radio_capture\
│  └─ BJTUCC-main\
├─ start_all_collectors.bat
└─ merge_capture_csv.bat
```

必须保持这几个项目处于同一个 `D:\ZQY\` 目录中，否则前端后端、采集程序和融合程序会找不到彼此。

以下目录不要从旧电脑复制，在新电脑上重新安装：

```text
D:\ZQY\zqy\
D:\ZQY\radio_capture\BJTUCC-main\.venv32\
D:\ZQY\iov-data-collector-(ue-stack)\node_modules\
D:\ZQY\iov-data-collector-(ue-stack)\frontend\node_modules\
D:\ZQY\iov-data-collector-(ue-stack)\backend\node_modules\
D:\ZQY\.collector-control\
```

如果需要保留旧采集记录，可以复制 `captures` 和 `datas` 目录。

## 2. 安装基础软件

新电脑需要安装：

1. Node.js 22 x64，安装时同时安装 npm。
2. Python 3.12 x64，用于网络、GPS、视频和CSV处理。
3. Python 3.10 x86（32位），用于无线侧采集。
4. Npcap，用于网络抓包。
5. 无线模组、GPS串口和摄像头对应的Windows驱动。

安装Python时勾选 Python Launcher。安装完成后打开CMD检查：

```bat
node -v
npm -v
py -0p
```

`py -0p` 中应同时存在64位Python 3.12和32位Python 3.10。

## 3. 安装前端和后端依赖

打开CMD并执行：

```bat
cd /d D:\ZQY\iov-data-collector-(ue-stack)
npm install
```

根目录命令会自动安装前端和后端依赖。出现普通的 `deprecated` 提示不影响运行，只要没有 `npm error` 即可。

## 4. 创建网络侧Python环境

在CMD中执行：

```bat
py -3.12 -m venv D:\ZQY\zqy
D:\ZQY\zqy\Scripts\python.exe -m pip install --upgrade pip
D:\ZQY\zqy\Scripts\python.exe -m pip install -r D:\ZQY\packet_collector\requirements.txt
D:\ZQY\zqy\Scripts\python.exe -m pip install -r D:\ZQY\packet_collector\requirements-windows.txt
```

检查环境：

```bat
D:\ZQY\zqy\Scripts\python.exe --version
```

## 5. 创建无线侧32位Python环境

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

无线侧运行程序当前不需要另外安装Python包。

## 6. 安装Npcap

运行项目自带的安装程序：

```text
D:\ZQY\packet_collector\Wireshark\npcap-1.86.exe
```

安装完成后在CMD中检查：

```bat
sc query npcap
```

如果抓包提示权限不足，以管理员身份运行CMD。

## 7. 检查采集配置

### 7.1 网络、GPS和摄像头

配置文件：

```text
D:\ZQY\packet_collector\config.json
```

需要根据新电脑检查以下内容：

```json
"platform": {
  "windows": {
    "interface": "6",
    "gps_port": "COM4",
    "camera": "0"
  }
}
```

- `interface`：当前网络接口编号。
- `gps_port`：GPS设备的串口号。
- `camera`：摄像头编号，一般为 `0`。

网络接口编号不能直接照搬旧电脑。执行下面的命令，找到“手机网络”对应的编号：

```bat
cd /d D:\ZQY\packet_collector
Wireshark\dumpcap.exe -D
```

然后把编号填写到 `config.json` 的 `interface` 中。

GPS串口可以在Windows设备管理器的“端口”中查看。当前使用的是Quectel USB NMEA Port。

### 7.2 无线侧串口

配置文件：

```text
D:\ZQY\radio_capture\BJTUCC-main\configs\config.json
```

重点检查：

```json
"ports": {
  "trace_port": 3,
  "at_port": 5
}
```

- `trace_port: 3` 表示 `COM3`。
- `at_port: 5` 表示 `COM5`。

根据新电脑设备管理器中的实际端口修改。项目内的DLL和QWinLog配置保持原位置即可。

## 8. 运行部署检查

检查网络侧：

```bat
cd /d D:\ZQY\packet_collector
D:\ZQY\zqy\Scripts\python.exe -m packet_collector.orchestration.configured_capture --config config.json --dry-run
```

检查无线侧：

```bat
cd /d D:\ZQY\radio_capture\BJTUCC-main
.venv32\Scripts\python.exe -m radio_capture.cli --config configs\config.json --dry-run
```

无线侧检查成功时应看到：

```text
dry-run ok
```

## 9. 启动项目

需要打开两个CMD窗口。

第一个CMD启动后端：

```bat
cd /d D:\ZQY\iov-data-collector-(ue-stack)\backend
npm run dev
```

第二个CMD启动前端：

```bat
cd /d D:\ZQY\iov-data-collector-(ue-stack)\frontend
npm run dev
```

浏览器打开：

```text
http://127.0.0.1:3000/
```

页面打开后，通过右上角的“开启采集”和“停止采集”控制无线侧、网络侧、GPS和录像。采集程序由后端隐藏启动，不需要手动打开采集CMD窗口。

## 10. 输出位置

网络侧CSV、抓包和录像：

```text
D:\ZQY\packet_collector\captures\session_时间\
```

无线侧CSV：

```text
D:\ZQY\radio_capture\BJTUCC-main\captures\session_时间\
```

融合后供前端分析的CSV：

```text
D:\ZQY\iov-data-collector-(ue-stack)\datas\BJTU\
```

最终指标录像：

```text
D:\ZQY\packet_collector\captures\session_时间\camera_recording_metrics.mp4
```

采集日志：

```text
D:\ZQY\.collector-control\logs\network.log
D:\ZQY\.collector-control\logs\radio.log
```

## 11. 最终检查

部署完成后进行一次短时间采集，确认：

- 页面可以正常打开。
- 点击“开启采集”后无线侧和网络侧都能启动。
- 摄像头预览正常。
- GNSS显示真实经纬度。
- 网络实时指标有数据。
- 点击“停止采集”后能够正常结束。
- 自动生成融合CSV。
- 自动生成 `camera_recording_metrics.mp4`。
- 右下角弹窗显示最终CSV和录像路径。

如果网络指标一直为空，首先重新执行：

```bat
D:\ZQY\packet_collector\Wireshark\dumpcap.exe -D
```

确认 `config.json` 中的接口编号仍然对应“手机网络”。Windows中的抓包接口编号可能发生变化。
