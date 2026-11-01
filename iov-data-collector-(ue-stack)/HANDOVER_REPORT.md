# 车联网诊断平台：GPS定位表记与数据可视化模块交接报告

本文档为 **车联网智能诊断与边缘代理平台 (IoV Workspace)** 的核心业务模块——**GPS 定位表记模块** 与 **数据可视化/长尾分布分析模块** 的完整技术交接报告。包含模块架构设计、技术实现细节、数据流说明以及在其他用户本地（使用 VS Code）从零运行与调试的操作指南。

---

## 目录
1. [项目整体架构概览](#1-项目整体架构概览)
2. [GPS 定位表记模块深入解析](#2-gps-定位表记模块深入解析)
3. [数据可视化与长尾效应分析模块深入解析](#3-数据可视化与长尾效应分析模块深入解析)
4. [核心接口 (API) 与数据规范](#4-核心接口-api-与数据规范)
5. [本地运行与 VS Code 操作指南（保姆级）](#5-本地运行与-vs-code-操作指南保姆级)
6. [常见问题排查与维护建议 (FAQ)](#6-常见问题排查与维护建议-faq)

---

## 1. 项目整体架构概览

本项目采用 **Workspace Monorepo** 全栈架构，实现了车载边缘代理（后端）与诊断监控平台（前端）的同源协作与模块化管理：

```text
├── datas/                     # 本地车载实测 CSV 数据文件夹
│   ├── Autocom/               # 设备 1 实测数据目录 (包含多个 CSV)
│   └── BJTU/                  # 设备 2 实测数据目录 (包含多个 CSV)
├── frontend/                  # 前端工程 (React 19 + TypeScript + Vite + Tailwind CSS)
│   ├── src/
│   │   ├── components/
│   │   │   ├── GpsTrackerView.tsx       # 【核心】GPS定位表记与点位分析面板
│   │   │   ├── DataVizView.tsx         # 【核心】时序推演与长尾效应分布大屏
│   │   │   └── AgentProxyVideoPlayer.tsx # 视频流滑动窗口管理模块
│   │   ├── data/
│   │   │   └── gpsData.ts               # 内置标准路测点位离线数据集
│   │   ├── App.tsx                      # 系统主界面、GNSS实时追踪与WebSocket监听
│   │   └── main.tsx                     # 前端入口与全局错误防护网关
├── backend/                   # 边缘节点代理服务 (Node.js + Express + MQTT + WebSocket)
│   ├── server.ts              # 本地数据源扫描、统计查询、MQTT透传及WS实时广播
│   └── tsconfig.json
├── package.json               # 根级 Workspace 配置文件 (提供一键 dev/build/start)
└── HANDOVER_REPORT.md         # 本交接报告文档
```

---

## 2. GPS 定位表记模块深入解析

### 2.1 模块定位与职责
GPS 定位表记模块负责对车载实测过程中采集的 GNSS 定位数据以及对应通信网络质量（RTT 延迟、抖动、吞吐量、丢包率）进行**时空联合可视化**与**点位级诊断分析**。

### 2.2 核心代码与实现位置
- **主界面实时定位追踪**: `frontend/src/App.tsx`
  - 监听后端的 `/ws/location` WebSocket 长连接。
  - 获取车辆动态推演的实时坐标、车速（SPD）、航向角（Heading）。
  - 调用地图 Marker 的平滑插值移动与镜头居中聚焦 (`moveTo`, `panTo`)。
- **独立 GPS 定位表记分析视图**: `frontend/src/components/GpsTrackerView.tsx`
  - 点位轨迹散点图展示与指标染色。
  - 动态 HUD 浮层信息展示（当前点位时间戳、索引、经纬度及对应网络质量）。
  - 阈值设定弹窗（可交互调节优秀/警告阈值，即时重新染色）。

### 2.3 技术设计亮点与容灾设计
1. **高德地图 JS API 2.0 深度集成**:
   - 统一配置安全密钥 `window._AMapSecurityConfig = { securityJsCode: "..." }`，防止跨域或鉴权拦截。
   - 使用 `AMap.CircleMarker` 对大量路测数据进行轻量化矢量渲染，点击点位自动高亮并平移聚焦。
2. **高可用离线回退机制 (Offline Vector Fallback)**:
   - 若客户处于内网断网环境、高德 CDN 不可达或 Key 失效，代码中内置了 `script.onerror` 与 `mapLoadError` 监听。
   - 系统自动无缝切换至纯前端 **SVG/Canvas 高精矢量轨迹拓扑图**，坐标按经纬度自适应缩放映射，并保留完整的点位点击诊断、阈值染色与 HUD 交互，**保证 100% 不因外部服务中断而白屏**。

### 2.4 指标阈值与色彩映射规则
| 指标字段 | 业务含义 | 优秀 (绿色) 默认规则 | 警告 (黄色) 默认规则 | 较差 (红色) 默认规则 |
| :--- | :--- | :--- | :--- | :--- |
| `avg_rtt_ms` | 往返往返时延 | `<= 10 ms` | `10 ~ 50 ms` | `> 50 ms` |
| `jitter_ms` | 网络时延抖动 | `<= 5 ms` | `5 ~ 20 ms` | `> 20 ms` |
| `throughput_bps` | 实时网络吞吐 | `>= 5,000,000 bps` | `1,000,000 ~ 5,000,000 bps` | `< 1,000,000 bps` |
| `loss_rate` | 通信丢包率 | `<= 0.00%` | `0.00% ~ 5.00%` | `> 5.00%` |

---

## 3. 数据可视化与长尾效应分析模块深入解析

### 3.1 模块定位与职责
该模块用于全景式呈现车机无线网络侧（Layer 1/2）与网络应用侧（IP/传输层）的关联特征，并支持从原始海量 CSV 中进行**多维度时序推演**与**统计分布（长尾效应）建模**。

### 3.2 模式 1：时序推演视图 (Timeseries Mode)
- **上半部分：双信息流联动**
  - **Wireless Info**: 无线信令参数表（PLMN、频段 Band、小区 PCI、频率、ARFCN、SCS、RSRP、SINR、BLER、调制模式等）。
  - **Network Info**: 滚动更新的实时指标流，标明数据到达时间戳与量化指标。
- **下半部分：动态双指标面积折线图**
  - 左侧面板与右侧面板均支持独立下拉选择指标（`avg_rtt_ms` / `jitter_ms` / `throughput_bps` / `loss_rate`）。
  - 图表采用 Recharts 高性能流式平滑渲染，展示历史 30 个时间窗口的趋势演化。

### 3.3 模式 2：长尾效应数据分布视图 (Distribution Mode)
解决工业路测中常见的“长尾延迟”与“突发掉速”统计难题，支持以下核心功能：
1. **区间频次分布直方图 (Histogram)**:
   - 自动生成自适应分箱（Bin），支持自定义 X 轴最小值 (`min`)、最大值 (`max`) 以及步长 (`step`)。
   - 柱状频次与平滑折线双层叠加，直观观测高延迟异常值的离群情况。
2. **累积分布函数图 (CDF)**:
   - 准确计算数据百分位数（Percentile 0% ~ 100%）。
   - 阶梯曲线呈现，直观反映例如“95% 分位数网络延迟是否在安全阈值以内”。

### 3.4 数据源配置弹窗业务流程 (Data Source Modal Workflow)
1. **设备选择**: 下拉框动态由后台扫描 `datas/` 目录获取（如 `Autocom` 与 `BJTU`），无需人工维护硬编码。
2. **文件勾选**: 选择对应设备后，展示该文件夹下的所有 CSV 文件，支持单个勾选与 **“全选 / 取消全选”** 快捷切换。
3. **加载时间范围**: 点击 **“加载时间范围”** 按钮，后端快速读取勾选文件的起始行与终止行时间戳，计算全集区间的 `minTime` 与 `maxTime` 并自动填入输入框，同时弹出绿色反馈状态条。
4. **范围微调与确认分析**: 用户可在输入框内修改时间戳，点击 **“确认并分析”** 后，系统过滤提取符合该时间段的精确数据切片，实时重绘左右两侧的长尾特征图表。

---

## 4. 核心接口 (API) 与数据规范

后端服务提供轻量高效的本地 REST API（位于 `backend/server.ts`）：

| 接口地址 | 请求方式 | 作用说明 |
| :--- | :--- | :--- |
| `/api/local/data/sources` | `GET` | 扫描 `datas/` 目录，返回所有可用设备文件夹名称列表 |
| `/api/local/data/sources/:source/files` | `GET` | 获取指定设备目录下的所有 `.csv` 文件名列表 |
| `/api/local/data/files/stats` | `POST` | 统计所选文件的全局最早时间戳 `minTime` 与最晚时间戳 `maxTime` |
| `/api/local/data/files/query` | `POST` | 根据所选文件与自定义 `startTime` / `endTime` 提取数据记录数组 |
| `/api/local/status` | `GET` | 获取车端代理运行状态、MQTT 连接状态与最近收发日志 |
| `/ws/location` | `WebSocket` | 车辆实时遥测坐标、车速与姿态推送通道 |

### CSV 数据格式规范
位于 `datas/<设备名>/` 下的 CSV 文件格式如下：
```csv
index,timestamp,avg_rtt_ms,jitter_ms,throughput_bps,loss_rate,gcj02_latitude,gcj02_longitude
0,2026-08-23 15:26:55.982,,,0.0,,39.95152439729486,116.3460852098955
1,2026-08-23 15:26:56.621,1.251,2.354,8396848.0,0.0,39.9515243808451,116.34608532682174
```

---

## 5. 本地运行与 VS Code 操作指南（保姆级）

保证下载本工程到任何一台安装了 VS Code 的 Windows / macOS / Linux 电脑后均可一键启动：

### 5.1 前置运行环境
- **Node.js**: 推荐 **v18.x 或 v20.x LTS**（可通过 `node -v` 验证）。
- **npm**: 随 Node.js 自带（版本 9.x+ 或 10.x+）。
- **编辑器**: Visual Studio Code。

### 5.2 步骤 1：导入项目到 VS Code
1. 将下载的项目压缩包解压（例如解压到 `D:\iov-workspace` 或 `~/iov-workspace`）。
2. 打开 VS Code，点击菜单栏：**文件 (File) -> 打开文件夹 (Open Folder...)**，选中项目的根目录。

### 5.3 步骤 2：在 VS Code 终端一键安装依赖
打开 VS Code 内置终端（快捷键 `Ctrl + ~` 或 `Cmd + ~`），在根目录下输入：
```bash
npm install
```
> **提示**：根目录的 `package.json` 配置了 `postinstall` 钩子，执行此命令时会自动同时为 `frontend/` 与 `backend/` 递归安装全部依赖包，无需手动分别进入子目录。

### 5.4 步骤 3：启动本地全栈开发环境
在 VS Code 终端中直接运行：
```bash
npm run dev
```
此时系统会通过并发脚本同时拉起：
- **前端服务**：运行在 `http://localhost:3000` (基于 Vite)
- **后端代理服务**：运行在 `http://localhost:5000` (基于 tsx)
- 前端内部已配置的反向代理（`vite.config.ts`）会自动将 `/api/local` 与 `/ws/location` 请求透明转发至后端的 5000 端口。

打开浏览器访问：**`http://localhost:3000`** 即可进入系统主界面！

### 5.5 步骤 4：VS Code 调试配置 (可选但推荐)
为了更方便地在 VS Code 中调试代码，可在项目根目录下的 `.vscode/` 目录中创建两个配置文件：

#### `.vscode/launch.json`
```json
{
  "version": "0.2.0",
  "configurations": [
    {
      "name": "启动全栈开发服务 (Fullstack Dev)",
      "type": "node-terminal",
      "request": "launch",
      "command": "npm run dev"
    },
    {
      "name": "单独调试后端服务 (Backend TS)",
      "type": "node",
      "request": "launch",
      "cwd": "${workspaceFolder}/backend",
      "runtimeExecutable": "npx",
      "runtimeArgs": ["tsx", "server.ts"],
      "console": "integratedTerminal"
    }
  ]
}
```
配置后，直接在 VS Code 侧边栏的 **“运行和调试 (Run and Debug)”** 点击绿色播放按钮即可启动。

### 5.6 步骤 5：生产构建与静态融合验证 (可选)
如果需要打包为一体化生产镜像或交付部署：
```bash
# 1. 编译前后端代码
npm run build

# 2. 启动生产级服务端 (此时 Express 将直接托管前端 dist 静态文件)
npm run start
```
直接访问 `http://localhost:3000` 即可在单端口模式下运行完整系统。

---

## 6. 常见问题排查与维护建议 (FAQ)

### Q1: 启动时报端口被占用 (EADDRINUSE 3000 或 5000)
- **原因**：本地其他进程占用了 3000 (Vite) 或 5000 (Express) 端口。
- **解决方法**：
  - Windows: 运行 `netstat -ano | findstr :3000`，查到 PID 后执行 `taskkill /PID <PID> /F`。
  - Mac/Linux: 运行 `lsof -i :3000`，查到 PID 后执行 `kill -9 <PID>`。

### Q2: 数据源弹窗中点击设备无反应或找不到文件
- **原因**：检查根目录下是否存在 `datas/` 文件夹，以及里面是否有对应设备名目录（如 `datas/Autocom` 和 `datas/BJTU`）。
- **说明**：后端已实现自动适配 `process.cwd()` 与相对路径寻址，并内置了空目录防护机制。

### Q3: 离线开发时高德地图报错或无法显示底图
- **说明**：系统内部已实现静默容灾保护，即使无外网环境，系统也会自动启用内置的 **高精矢量轨迹图 (Vector Trajectory Plot)**，网络指标染色、阈值调节与点位详细诊断均 100% 正常运行。

### Q4: 如何添加新的实测设备数据？
只需在根目录的 `datas/` 文件夹下新建一个文件夹（例如 `datas/MyNewDevice`），并将测速生成的标准 `.csv` 文件复制进去即可。前端数据源配置弹窗在下次打开时会自动识别并展示 `MyNewDevice` 选项，无需修改任何代码！

---

_报告编制日期：2026-09-30_
_工程模块：车联网智能诊断平台 (IoV Diagnostics Workspace)_
