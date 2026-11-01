# Windows 无线数据采集工具

本项目用于 Windows 下采集和分析 Qualcomm/Quectel 设备的无线日志，包含原生 DLL 控制器接口、日志帧处理、DM/AT 指标 CSV 输出和离线回放工具。

> 仓库包含当前配置使用的核心 x86 DLL（`vendor_runtime/Bin/`）、QWinLog 安装程序和配置文件。设备驱动与采集硬件须在目标电脑上单独准备。使用这些第三方运行文件前，请确认你有相应使用授权。仓库不包含设备采集数据。

## 快速启动

### 1. 准备环境

需要 Windows 和 **32 位 CPython**。当前原生 DLL 是 x86，即使电脑是 64 位 Windows，也要安装 32 位 Python。示例使用 Python 3.10 x86；可以用 `py -0p` 查看 Python Launcher 已识别的版本。

在 PowerShell 中，从项目根目录执行：

```powershell
Set-Location E:\radio_capture
py -3.10-32 -m venv .venv32
.\.venv32\Scripts\python.exe -c "import struct; print(str(struct.calcsize('P') * 8) + '-bit Python')"
Copy-Item .\configs\config.example.json .\configs\config.json
notepad .\configs\config.json
```

位数检查应输出 `32-bit Python`。运行程序不需要额外安装 Python 包；命令从项目根目录执行，以便 Python 找到 `radio_capture` 包。

### 2. 准备授权运行文件

项目所需的核心 DLL 已打包在 `vendor_runtime\Bin\`，示例配置已指向此目录。QWinLog 配置模板位于 `Qwinlog\conf\qual\`；若它与设备不匹配，请更换为授权方提供的配置。当前配置需要以下核心文件：

- `DDDCXX01.dll`：控制器
- `DDDIXX00.dll`：解码分派 DLL
- `DDDIXXS0.dll`：解码插件
- `DDLCXX01.dll`：PUSCH BLER 辅助解码（该辅助进程不可用时，主采集仍可运行）
- `msvcp120.dll`、`msvcr120.dll`、`msvcp140.dll`、`vcruntime140.dll`：VC 运行库

配置中的 `DDDCXX01.dll` 在当前 QWinLog 采集模式下不是必需项，但已一并提供以支持其他控制器模式。不要从其他机器复制 Python 虚拟环境；在本机重新创建 `.venv32`。

### 3. 修改本机配置

编辑 `configs\config.json`，按实际设备修改：

| 配置项 | 要填写的值 |
|---|---|
| `runtime.dll_dir` | 默认使用仓库内 `.\vendor_runtime\Bin`；移动 DLL 目录后再修改 |
| `device.eq_id`、`device.chip_type`、`device.eq_type` | 与设备及授权运行库对应的设备参数 |
| `ports.trace_port` | 设备管理器中实际 DM/Trace 串口号，例如 `6` 表示 `COM6` |
| `ports.at_port` | AT 串口号；不采集 AT 指标时可保持 `null` |
| `logmask.file` | 已随仓库提供的 `Qwinlog\conf\qual\5GNR_LTE_CN_V9.cfg`，或本机授权 `.cfg` 文件完整路径 |
| `output.dm_write_interval_sec` | DM 指标 CSV 写入间隔，单位为秒，默认 `1.0` |

路径请使用 JSON 格式，例如 `"D:\\QualcommRuntime\\Bin"`。不要把实际设备配置、端口信息或采集文件提交到 GitHub。

### 4. 先检查，再启动采集

先检查配置、Python 位数和所需 DLL 文件是否齐全：

```powershell
.\.venv32\Scripts\python.exe -m radio_capture.cli --config .\configs\config.json --dry-run
```

成功时会显示 `dry-run ok`。该检查只确认 x86 环境和所需文件存在，不会连接设备，也不能证明 DLL、驱动或串口能够完成实际采集。

检查通过后启动：

```powershell
.\.venv32\Scripts\python.exe -m radio_capture.cli --config .\configs\config.json
```

开始采集后，按 `Ctrl+C` 正常停止。

## 默认输出

示例配置启用了 `output.metrics_only`，会以指标 CSV 模式运行，不保存原始帧、JSONL 和 SQLite。每次采集的输出默认位于项目根目录的 `captures\session_YYYYMMDD_HHMMSS\` 下。

如需保存完整原始帧、解码 JSONL 和 SQLite，将 `configs\config.json` 中的 `output.metrics_only` 改为 `false` 后启动。AT 端口未配置时，不会产生 AT 指标。

## 常见问题

- **提示使用 32 位 CPython：** 检查当前虚拟环境是否由 32 位 Python 创建；必要时删除本地 `.venv32` 后用 x86 Python 重建。
- **提示缺少 DLL：** 确认 `runtime.dll_dir` 指向正确目录，并检查控制器、分派 DLL、插件 DLL 和运行包中的依赖文件。
- **提示找不到 `radio_capture`：** 先 `Set-Location E:\radio_capture`，再运行上面的模块命令。
- **dry-run 成功但没有采集数据：** 继续检查设备驱动、实际 Trace/AT 串口、QWinLog 配置和设备连接状态。

## 目录

- `radio_capture/`：程序源码、工具和测试
- `configs/config.example.json`：不含本机端口和路径的配置模板
- `docs/`：项目开发说明
