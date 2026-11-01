# 车联网数据采集与可视化平台技术路线

## 总体技术路线框图

```mermaid
flowchart LR
    subgraph UI["前端展示层  React + TypeScript"]
        FRONT["采集控制与业务操作"]
        LIVE["实时监控\n网络指标 / GNSS / 录像预览"]
        ANALYSIS["数据分析\n时序 / 分布 / 总览 / 轨迹"]
    end

    subgraph SERVER["平台控制层  Node.js"]
        CONTROL["REST API 与采集进程编排"]
        REALTIME["WebSocket 实时推送\nMJPEG 录像代理"]
        BUSINESS["MQTT 与用户端业务服务"]
    end

    subgraph SOURCE["数据源"]
        UE["车载 UE / 5G 模组"]
        NET["业务网络"]
        GPSCAM["GNSS + 摄像头"]
    end

    subgraph COLLECT["双侧同步采集与解析"]
        RADIO["无线侧\n模组日志采集与无线指标解析"]
        NETWORK["网络侧\n抓包、0.4 秒窗口分析、定位和录像"]
    end

    subgraph RESULT["数据处理与成果输出"]
        RADIO_CSV["无线侧 CSV"]
        NET_CSV["网络指标与 GNSS CSV"]
        VIDEO["原始录像与帧时间戳"]
        MERGE["时间戳对齐与数据融合"]
        FINAL["融合 CSV + 指标录像"]
    end

    FRONT --> CONTROL
    FRONT --> BUSINESS
    BUSINESS <--> UE
    BUSINESS <--> NET
    CONTROL --> RADIO
    CONTROL --> NETWORK

    UE --> RADIO --> RADIO_CSV
    NET --> NETWORK
    GPSCAM --> NETWORK
    NETWORK --> NET_CSV
    NETWORK --> VIDEO

    NET_CSV --> REALTIME --> LIVE
    VIDEO --> REALTIME

    RADIO_CSV --> MERGE
    NET_CSV --> MERGE
    VIDEO --> MERGE
    MERGE --> FINAL --> ANALYSIS
    FINAL -.完成路径通知.-> FRONT

    classDef ui fill:#13233d,stroke:#4c9aff,color:#ffffff,stroke-width:2px;
    classDef backend fill:#172033,stroke:#8b5cf6,color:#ffffff,stroke-width:2px;
    classDef radio fill:#26351f,stroke:#84cc16,color:#ffffff,stroke-width:2px;
    classDef network fill:#12352f,stroke:#10b981,color:#ffffff,stroke-width:2px;
    classDef post fill:#3b2612,stroke:#f59e0b,color:#ffffff,stroke-width:2px;
    classDef external fill:#2b2f38,stroke:#94a3b8,color:#ffffff;

    class FRONT,LIVE,ANALYSIS ui;
    class CONTROL,REALTIME,BUSINESS backend;
    class RADIO,RADIO_CSV radio;
    class NETWORK,NET_CSV,VIDEO network;
    class MERGE,FINAL post;
    class UE,NET,GPSCAM external;
```

## 一次完整采集的状态路线

```mermaid
flowchart LR
    READY["待机"] -->|"点击开启采集"| STARTING["启动中"]
    STARTING --> RUNNING["采集中"]
    RUNNING -->|"点击停止采集"| STOPPING["停止采集进程"]
    STOPPING --> DRAINING["等待网络解析和文件落盘"]
    DRAINING --> MERGING["融合无线侧与网络侧 CSV"]
    MERGING --> RENDERING["生成带网络指标的最终录像"]
    RENDERING --> DONE["完成并自动加载最新 CSV"]
    DONE --> TOAST["右下角显示成果绝对路径"]
    TOAST --> READY

    STARTING -.异常.-> ERROR["错误状态与日志"]
    STOPPING -.异常.-> ERROR
    MERGING -.异常.-> ERROR
    RENDERING -.异常.-> ERROR
```

## 关键技术点

| 环节 | 当前技术方案 | 主要输出 |
|---|---|---|
| 前端交互 | React、TypeScript、Vite、Recharts、高德地图 | 采集控制、实时展示、轨迹与统计分析 |
| 平台后端 | Node.js、Express、WebSocket、MQTT.js | REST 接口、采集进程编排、实时推送、数据查询 |
| 无线侧采集 | 32 位 Python、串口、QWinLog、厂商控制与解码 DLL | `dm_metrics.csv`、`at_metrics.csv`、`merged_metrics.csv` |
| 网络侧采集 | Python、Npcap、dumpcap、TCP 窗口分析 | PCAP、RTT、吞吐量、抖动、丢包率 |
| 定位采集 | NMEA 串口解析、经纬度坐标转换 | 与网络指标共用的 `window_metrics_gps.csv` |
| 视频采集 | OpenCV、MP4、逐帧真实时间戳、MJPEG | 原始录像、帧时间文件、浏览器实时预览 |
| 多源融合 | Python CSV 时间戳对齐 | 前端统一分析数据源 `session_*_full.csv` |
| 视频后处理 | 按视频帧时间匹配网络指标并叠加 | `camera_recording_metrics.mp4` |
| 停止控制 | 后端生成停止文件，采集进程监听并有序退出 | 统一停止、等待解析、融合和录像后处理 |

## 数据输出位置

```text
D:\ZQY\packet_collector\captures\session_*\
    ├─ window_metrics_gps.csv
    ├─ camera_recording.mp4
    ├─ camera_frame_timestamps.csv
    └─ camera_recording_metrics.mp4

D:\ZQY\radio_capture\BJTUCC-main\captures\session_*\
    ├─ dm_metrics.csv
    ├─ at_metrics.csv
    └─ merged_metrics.csv

D:\ZQY\iov-data-collector-(ue-stack)\datas\BJTU\
    └─ session_*_full.csv
```

> 当前实际的前端“开启采集”由 Node.js 后端直接隐藏启动两个 Python 进程。根目录的 `start_all_collectors.bat` 主要用于定位工作区和手动启动，不代表网页按钮的全部运行逻辑。
