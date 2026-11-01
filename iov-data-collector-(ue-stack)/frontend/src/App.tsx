import React, { useState, useEffect, useRef } from "react";
import { createPortal } from "react-dom";
import {
  Signal,
  Cpu,
  Navigation,
  Database,
  Activity,
  Wifi,
  MapPin,
  Download,
  AlertTriangle,
  Radio,
  Gauge,
  Play,
  Square,
  Video,
  CircleDot,
  Terminal,
  Zap,
  HardDrive,
  Check,
  Maximize2,
  Minimize2,
  Settings,
  Cpu as AgentIcon,
} from "lucide-react";
import { motion, AnimatePresence } from "motion/react";
import { cn } from "./lib/utils";

import { FileDownloader } from "./lib/FileDownloader";
import { AgentConsoleView } from "./AgentConsoleView";
import { AgentProxyVideoPlayer } from "./components/AgentProxyVideoPlayer";
import { GpsTrackerView } from "./components/GpsTrackerView";
import { DataVizView } from "./components/DataVizView";
import { LiveCameraPreview } from "./components/LiveCameraPreview";
import type { CsvDataPoint } from "./data/csvData";
import type { GpsDataPoint } from "./data/gpsData";

// --- Diagnostic Types ---
interface NetworkStats {
  rsrp: number; // dBm
  rsrq: number; // dB
  sinr: number; // dB
  latency: number; // ms
  jitter: number;
  packetLoss: number;
}

interface ServiceStatus {
  name: string;
  id: number;
  status: "idle" | "running" | "warning" | "error";
  lastSuccess: number; // timestamp
  latency: number;
  reqCount: number;
  enabled: boolean;
}

declare global {
  interface Window {
    _AMapSecurityConfig?: any;
    AMap?: any;
  }
}

interface LogEntry {
  id: string;
  time: string;
  module: "RADIO" | "APP" | "SYS" | "GNSS";
  level: "info" | "warn" | "error";
  msg: string;
}

interface LiveCaptureMetrics {
  sessionId: string;
  index: number | null;
  timestamp: string;
  avg_rtt_ms: number | null;
  jitter_ms: number | null;
  throughput_bps: number | null;
  loss_rate: number | null;
  gcj02_latitude: number | null;
  gcj02_longitude: number | null;
}

interface CollectorStatus {
  phase: "stopped" | "starting" | "running" | "stopping" | "merging" | "rendering" | "error";
  message: string;
  error: string | null;
  collectors: {
    radio: boolean;
    network: boolean;
  };
  latestCsv: {
    source: string;
    file: string;
    path: string;
    mergedAt: string;
  } | null;
  latestVideo: {
    file: string;
    path: string;
    renderedAt: string;
  } | null;
}

interface ArtifactResultToast {
  completionKey: string;
  csvPath: string;
  videoPath: string;
  fading: boolean;
}

export default function DiagnosticTerminal() {
  const [isCollecting, setIsCollecting] = useState(false);
  const [collectorStatus, setCollectorStatus] = useState<CollectorStatus>({
    phase: "stopped",
    message: "采集未启动",
    error: null,
    collectors: { radio: false, network: false },
    latestCsv: null,
    latestVideo: null,
  });
  const [collectorActionPending, setCollectorActionPending] = useState(false);
  const [artifactResultToast, setArtifactResultToast] = useState<ArtifactResultToast | null>(null);
  const shownArtifactCompletionRef = useRef<string | null>(null);
  const [netStats, setNetStats] = useState<NetworkStats>({
    rsrp: -85,
    rsrq: -12,
    sinr: 15,
    latency: 24,
    jitter: 3,
    packetLoss: 0,
  });
  const [services, setServices] = useState<ServiceStatus[]>([
    {
      id: 1,
      name: "车辆状态/遥测查询",
      status: "idle",
      lastSuccess: 0,
      latency: 0,
      reqCount: 0,
      enabled: true,
    },
    {
      id: 2,
      name: "MQTT 长连接与控制",
      status: "idle",
      lastSuccess: 0,
      latency: 0,
      reqCount: 0,
      enabled: true,
    },
    {
      id: 3,
      name: "地图/导航",
      status: "idle",
      lastSuccess: 0,
      latency: 0,
      reqCount: 0,
      enabled: true,
    },
    {
      id: 4,
      name: "文件下载",
      status: "idle",
      lastSuccess: 0,
      latency: 0,
      reqCount: 0,
      enabled: true,
    },
    {
      id: 5,
      name: "事件上报/安全告警",
      status: "idle",
      lastSuccess: 0,
      latency: 0,
      reqCount: 0,
      enabled: true,
    },
  ]);
  const [logs, setLogs] = useState<LogEntry[]>([]);
  const [liveCaptureMetrics, setLiveCaptureMetrics] = useState<LiveCaptureMetrics | null>(null);
  const terminalRef = useRef<HTMLDivElement>(null);
  const [showHardware, setShowHardware] = useState(false);
  const [downloadTask, setDownloadTask] = useState<{
    progress: number;
    active: boolean;
    name: string;
    downloadUrl: string;
    expanded: boolean;
    status: "downloading" | "completed" | "cancelled" | "error";
  } | null>(null);
  const isCollectingRef = useRef(false);
  const collectionRunTokenRef = useRef(0);
  const downloadAbortControllerRef = useRef<AbortController | null>(null);
  const mapContainerRef = useRef<HTMLDivElement>(null);
  const mapInstanceRef = useRef<any>(null);
  const vehicleMarkerRef = useRef<any>(null);
  const [gnssData, setGnssData] = useState({
    lat: null as number | null,
    lon: null as number | null,
    updatedAt: null as string | null,
  });
  const [mapLoaded, setMapLoaded] = useState(false);
  const [simulationActive, setSimulationActive] = useState(false);
  const [isMapFullscreen, setIsMapFullscreen] = useState(false);
  const [activeView, setActiveView] = useState<'diag' | 'gps' | 'dataviz'>('diag');
  const [userBusinessView, setUserBusinessView] = useState<'standard' | 'mqtt' | 'video'>('standard');
  const [csvData, setCsvData] = useState<CsvDataPoint[] | null>(null);
  const gpsCsvData = React.useMemo<GpsDataPoint[]>(() => (csvData ?? [])
    .filter(row => Number.isFinite(row.gcj02_latitude) && Number.isFinite(row.gcj02_longitude)
      && Math.abs(row.gcj02_latitude!) <= 90 && Math.abs(row.gcj02_longitude!) <= 180)
    .map(row => ({
      ...row,
      index: 0,
      real_timestamp: row.timestamp,
      latitude: row.gcj02_latitude!,
      longitude: row.gcj02_longitude!,
    }))
    .sort((a, b) => a.timestamp.localeCompare(b.timestamp))
    .map((row, index) => ({ ...row, index })), [csvData]);
  // Mount each page on its first visit and retain its state across navigation.
  const [visitedViews, setVisitedViews] = useState(() => new Set(['diag']));
  useEffect(() => {
    setVisitedViews(previous => previous.has(activeView)
      ? previous
      : new Set([...previous, activeView]));
  }, [activeView]);
  const [visitedBusinessViews, setVisitedBusinessViews] = useState(() => new Set(['standard']));
  useEffect(() => {
    setVisitedBusinessViews(previous => previous.has(userBusinessView)
      ? previous
      : new Set([...previous, userBusinessView]));
  }, [userBusinessView]);

  const [otaLevel, setOtaLevel] = useState("harmony6.8.1");
  const otaLevelRef = useRef(otaLevel);
  useEffect(() => {
    otaLevelRef.current = otaLevel;
  }, [otaLevel]);

  const VEHICLE_ID = "VH001";
  // 使用 Vite 环境变量，不再代码中写死 IP 以分离环境
  const BASE_URL = import.meta.env.VITE_API_BASE_URL || "";

  const getTaskDef = (id: number) => {
    switch (id) {
      case 1:
        return {
          url: `${BASE_URL}/vehicle/status?vehicleId=${VEHICLE_ID}`,
          options: { method: "GET" },
        };
      case 2:
        return {
          url: `${BASE_URL}/api/local/status`,
          options: { method: "GET" },
        };
      case 3:
        return {
          url: `${BASE_URL}/api/local/poi/search?keyword=加油站&latitude=39.9042&longitude=116.4074`,
          options: { method: "GET" },
        };
      case 4:
        return {
          url: `${BASE_URL}/api/download/${otaLevelRef.current}.zip`,
          options: { method: "HEAD" },
        };
      case 5:
        return {
          url: `${BASE_URL}/event/emergency`,
          options: {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({
              vehicleId: VEHICLE_ID,
              description: "拨测告警",
              latitude: 39.9042,
              longitude: 116.4074,
            }),
          },
        };
      default:
        return null;
    }
  };

  // Real API Fetch Logic
  useEffect(() => {
    if (!isCollecting) return;

    let isMounted = true;

    const runTasks = async () => {
      if (!isMounted || !isCollecting) return;
      const runToken = collectionRunTokenRef.current;

      const activeServices = servicesRef.current.filter((s) => s.enabled);
      if (activeServices.length === 0) return;

      const promises = activeServices.map(async (s) => {
        const task = getTaskDef(s.id);
        if (!task)
          return {
            id: s.id,
            success: false,
            latency: 0,
            errorMessage: "Unknown task",
          };

        const start = performance.now();
        let success = false;
        let errorMessage = "";
        try {
          // Send request with an abort controller to timeout requests after 15 seconds to simulate poor connections
          const controller = new AbortController();
          const timeoutId = setTimeout(() => controller.abort(), 15000);

          const res = await fetch(task.url, {
            ...task.options,
            signal: controller.signal,
          });
          clearTimeout(timeoutId);

          success = res.ok;
          if (!success) {
            errorMessage = `HTTP Error ${res.status}`;
          } else if (
            s.id === 4 &&
            isMounted &&
            isCollectingRef.current &&
            collectionRunTokenRef.current === runToken
          ) {
            let fileName = `${otaLevelRef.current}.zip`;
            let downloadUrl = `${BASE_URL}/api/download/${otaLevelRef.current}.zip`;
            
            setDownloadTask((prev) => {
              if (
                !prev ||
                !prev.active ||
                prev.status === "completed" ||
                prev.status === "cancelled" ||
                prev.status === "error"
              ) {
                setTimeout(
                  () =>
                    setDownloadTask((p) => (p ? { ...p, expanded: false } : p)),
                  3000,
                );
                return {
                  progress: 0,
                  active: true,
                  name: fileName,
                  downloadUrl,
                  expanded: true,
                  status: "downloading",
                };
              }
              return prev;
            });
          }
        } catch (err: any) {
          success = false;
          errorMessage =
            err.name === "AbortError"
              ? "请求超时 (Timeout)"
              : err.message || "网络请求失败";
        }
        const latency = performance.now() - start;

        return { id: s.id, success, latency, errorMessage };
      });

      const results = await Promise.all(promises);

      if (!isMounted) return;

      let totalLatency = 0;
      let fails = 0;

      setServices((prev) =>
        prev.map((s) => {
          const res = results.find((r) => r.id === s.id);
          if (res) {
            totalLatency += res.latency;
            if (!res.success) fails++;

            if (!res.success && res.errorMessage && Math.random() > 0.5) {
              addLog(
                "APP",
                "error",
                `服务 [${s.name}] 请求失败: ${res.errorMessage}`,
              );
            } else if (res.success && Math.random() > 0.8) {
              // Add periodic success logs
              addLog(
                "APP",
                "info",
                `服务 [${s.name}] 状态正常 (${Math.round(res.latency)}ms)`,
              );
            }

            return {
              ...s,
              status: res.success ? "running" : "error",
              latency: res.latency,
              reqCount: s.reqCount + 1,
              lastSuccess: res.success ? Date.now() : s.lastSuccess,
            };
          }
          return s; // Unselected services do not increment their counts here
        }),
      );

      const avgLatency = results.length ? totalLatency / results.length : 0;

      setNetStats((prev) => ({
        ...prev,
        latency: avgLatency,
        packetLoss: (fails / results.length) * 100,
        rsrp: -85 + (Math.random() * 5 - 2.5),
        sinr: 15 + (Math.random() * 2 - 1),
      }));

      // Simulate real-time map or download updates if those services are active
    };

    const interval = setInterval(runTasks, 3000);
    runTasks();

    return () => {
      isMounted = false;
      clearInterval(interval);
    };
  }, [isCollecting]); // Removed 'services' from deps to prevent infinite loops

  const servicesRef = useRef(services);
  useEffect(() => {
    servicesRef.current = services;
  }, [services]);

  const toggleService = (id: number, e: React.MouseEvent) => {
    e.stopPropagation();
    setServices((prev) =>
      prev.map((s) => (s.id === id ? { ...s, enabled: !s.enabled } : s)),
    );
  };

  const simulationActiveRef = useRef(simulationActive);
  useEffect(() => {
    simulationActiveRef.current = simulationActive;
  }, [simulationActive]);

  const [hasZoomedIn, setHasZoomedIn] = useState(false);

  // Real-time Mapping WebSocket implementation
  useEffect(() => {
    let ws: WebSocket | null = null;
    let reconnectTimeout: NodeJS.Timeout;

    const connectWS = () => {
      const protocol = window.location.protocol === 'https:' ? 'wss:' : 'ws:';
      const wsUrl = import.meta.env.VITE_WS_URL || `${protocol}//${window.location.host}/ws/location`;
      ws = new WebSocket(wsUrl);

      ws.onopen = () => {
        addLog("SYS", "info", "WebSocket连接成功");
      };

      ws.onmessage = (event) => {
        try {
          const data = JSON.parse(event.data);
          if (data.type !== 'capture_metrics') return;
          setLiveCaptureMetrics({
            sessionId: data.sessionId,
            index: data.index,
            timestamp: data.timestamp,
            avg_rtt_ms: data.avg_rtt_ms,
            jitter_ms: data.jitter_ms,
            throughput_bps: data.throughput_bps,
            loss_rate: data.loss_rate,
            gcj02_latitude: data.gcj02_latitude,
            gcj02_longitude: data.gcj02_longitude,
          });

          const currentLat = Number(data.position?.latitude);
          const currentLon = Number(data.position?.longitude);
          const positionUpdatedAt = data.position?.updatedAt || data.timestamp;

          if (Number.isFinite(currentLat) && Number.isFinite(currentLon)) {
            const gcj02Pos = [currentLon, currentLat];

            if (mapLoaded && mapInstanceRef.current && vehicleMarkerRef.current && window.AMap) {
              vehicleMarkerRef.current.show?.();
              vehicleMarkerRef.current.moveTo(gcj02Pos, {
                duration: 1000,
                autoRotation: false,
              });
              if (!hasZoomedIn) {
                mapInstanceRef.current.setZoomAndCenter(17, gcj02Pos);
                setHasZoomedIn(true);
              } else {
                mapInstanceRef.current.panTo(gcj02Pos);
              }
            }

            setGnssData({
              lat: currentLat,
              lon: currentLon,
              updatedAt: positionUpdatedAt,
            });

            addLog(
              "GNSS",
              "info",
              `接收到真实位置更新: [${currentLon.toFixed(5)}, ${currentLat.toFixed(5)}]`
            );
          }
        } catch (e) {
          console.error("Failed to parse WS data", e);
        }
      };

      ws.onerror = (error) => {
        // Silently handle WS errors to prevent dev-mode HMR/restart noise
        // console.warn("WebSocket连接异常 (Usually dev server restart)");
      };

      ws.onclose = () => {
        addLog("SYS", "warn", "WebSocket连接关闭, 正在尝试重新连接...");
        reconnectTimeout = setTimeout(connectWS, 3000);
      };
    };

    connectWS();

    return () => {
      clearTimeout(reconnectTimeout);
      if (ws) {
        ws.onclose = null; // Prevent reconnect loop on unmount
        ws.close();
      }
    };
  }, [mapLoaded, hasZoomedIn]);

  // Fix: Use an unlinked DOM node managed by us across the tree so React portal can render safely
  const floatingMapContainer = React.useMemo(() => {
    const div = document.createElement('div');
    div.className = "w-full h-full";
    return div;
  }, []);

  useEffect(() => {
    let timer: NodeJS.Timeout;
    
    // Move the container safely
    if (isMapFullscreen) {
      const root = document.getElementById("root") || document.body;
      root.appendChild(floatingMapContainer);
    } else {
      const placeholder = document.getElementById("map-placeholder");
      if (placeholder) {
        placeholder.appendChild(floatingMapContainer);
      }
    }

    // Resize map appropriately when container size changes
    timer = setTimeout(() => {
      if (
        mapInstanceRef.current &&
        typeof mapInstanceRef.current.resize === "function"
      ) {
        mapInstanceRef.current.resize();
        if (vehicleMarkerRef.current) {
          const currentPos = vehicleMarkerRef.current.getPosition();
          if (currentPos) {
            mapInstanceRef.current.setCenter(currentPos);
          }
        }
      }
    }, 300);

    return () => clearTimeout(timer);
  }, [isMapFullscreen, floatingMapContainer, activeView]);

  useEffect(() => {
    if (downloadTask?.active && downloadTask.status === "downloading" && downloadTask.downloadUrl) {
      if (downloadTask.progress > 0) return; // Already started downloading and making progress

      const downloader = new FileDownloader();
      const controller = new AbortController();
      downloadAbortControllerRef.current = controller;
      let isCancelled = false;

      downloader.downloadFile(downloadTask.downloadUrl, downloadTask.name, (progress) => {
        if (!isCancelled) {
          setDownloadTask((prev) => {
            if (!prev || prev.status !== "downloading") return prev;
            return { ...prev, progress: progress.percentage };
          });
        }
      }, controller.signal).then(result => {
        if (isCancelled) return;
        if (result?.success) {
          addLog("APP", "info", `文件 [${downloadTask.name}] 下载完成。`);
          setDownloadTask((prev) => {
            if (!prev) return prev;
            return { ...prev, progress: 100, status: "completed", expanded: true };
          });
          setTimeout(() => {
            setDownloadTask((p) => (p ? { ...p, expanded: false } : p));
          }, 3000);
        } else if (result?.cancelled) {
          setDownloadTask((prev) => {
            if (!prev) return prev;
            return { ...prev, status: "cancelled", expanded: true };
          });
        } else {
          addLog("APP", "error", `文件 [${downloadTask.name}] 下载失败: ${result?.message}`);
          setDownloadTask((prev) => {
             if (!prev) return prev;
             return { ...prev, status: "error" };
          });
        }
      }).catch(err => {
        if (isCancelled) return;
        addLog("APP", "error", `文件 [${downloadTask.name}] 下载出错: ${err.message}`);
        setDownloadTask((prev) => {
           if (!prev) return prev;
           return { ...prev, status: "error" };
        });
      });

      return () => {
        isCancelled = true;
        if (downloadAbortControllerRef.current === controller) {
          downloadAbortControllerRef.current = null;
        }
      };
    }
  }, [downloadTask?.active, downloadTask?.status, downloadTask?.downloadUrl, downloadTask?.name]);

  const addLog = (
    module: LogEntry["module"],
    level: LogEntry["level"],
    msg: string,
  ) => {
    setLogs((prev) => [
      {
        id: Math.random().toString(),
        time: new Date().toLocaleTimeString(),
        module,
        level,
        msg,
      },
      ...prev.slice(0, 99), // Keep last 100 logs
    ]);
  };

  const toggleCollection = () => {
    const newState = !isCollectingRef.current;
    collectionRunTokenRef.current += 1;
    isCollectingRef.current = newState;
    setIsCollecting(newState);
    if (newState) {
      setSimulationActive(true);
    } else {
      downloadAbortControllerRef.current?.abort();
      downloadAbortControllerRef.current = null;
      if (downloadTask?.status === "downloading") {
        setDownloadTask((prev) =>
          prev ? { ...prev, status: "cancelled", expanded: true } : prev,
        );
        addLog("APP", "warn", `文件 [${downloadTask.name}] 下载已取消，未保存未完成数据。`);
        setTimeout(() => {
          setDownloadTask((prev) =>
            prev?.status === "cancelled" ? { ...prev, expanded: false } : prev,
          );
        }, 3000);
      }
    }
    addLog("SYS", "info", newState ? "开启业务流：服务已就绪" : "停止业务流");
  };

  useEffect(() => {
    let mounted = true;
    const loadCollectorStatus = async () => {
      try {
        const response = await fetch(`${BASE_URL}/api/local/collectors/status`);
        const data = await response.json();
        if (mounted && response.ok) setCollectorStatus(data);
      } catch {
        // The local backend may still be starting. Keep the last known state.
      }
    };
    loadCollectorStatus();
    const timer = setInterval(loadCollectorStatus, 1500);
    return () => {
      mounted = false;
      clearInterval(timer);
    };
  }, [BASE_URL]);

  useEffect(() => {
    const completionKey = collectorStatus.latestCsv?.path && collectorStatus.latestVideo?.path
      ? `${collectorStatus.latestCsv.mergedAt}:${collectorStatus.latestVideo.renderedAt}`
      : null;
    if (collectorStatus.phase !== "stopped" || !completionKey) {
      return;
    }
    let alreadyShown = shownArtifactCompletionRef.current === completionKey;
    try {
      alreadyShown = window.localStorage.getItem("last-capture-artifact-notification-v2") === completionKey;
    } catch {
      // Fall back to the in-memory key when persistent browser storage is unavailable.
    }
    if (!alreadyShown) {
      shownArtifactCompletionRef.current = completionKey;
      try {
        window.localStorage.setItem("last-capture-artifact-notification-v2", completionKey);
      } catch {
        // The in-app browser may disable persistent storage; the in-memory key still prevents repeats.
      }
      setArtifactResultToast({
        completionKey,
        csvPath: collectorStatus.latestCsv!.path,
        videoPath: collectorStatus.latestVideo!.path,
        fading: false,
      });
    }
  }, [collectorStatus]);

  useEffect(() => {
    if (!artifactResultToast) return;
    const fadeTimer = window.setTimeout(() => {
      setArtifactResultToast(current =>
        current?.completionKey === artifactResultToast.completionKey
          ? { ...current, fading: true }
          : current,
      );
    }, 10000);
    const removeTimer = window.setTimeout(() => {
      setArtifactResultToast(current =>
        current?.completionKey === artifactResultToast.completionKey ? null : current,
      );
    }, 10500);
    return () => {
      window.clearTimeout(fadeTimer);
      window.clearTimeout(removeTimer);
    };
  }, [artifactResultToast?.completionKey]);

  const toggleCollectors = async () => {
    if (collectorActionPending || ["starting", "stopping", "merging", "rendering"].includes(collectorStatus.phase)) return;
    const hasRunningCollector =
      collectorStatus.phase === "running" ||
      collectorStatus.collectors.radio ||
      collectorStatus.collectors.network;
    const action = hasRunningCollector ? "stop" : "start";
    setCollectorActionPending(true);
    try {
      const response = await fetch(`${BASE_URL}/api/local/collectors/${action}`, { method: "POST" });
      const data = await response.json();
      setCollectorStatus(data);
      if (!response.ok) throw new Error(data.error || data.message || "操作失败");
      if (action === "start") {
        setLiveCaptureMetrics(null);
        setGnssData({ lat: null, lon: null, updatedAt: null });
        setHasZoomedIn(false);
        vehicleMarkerRef.current?.hide?.();
      }
      addLog(
        "SYS",
        "info",
        action === "start" ? "正在启动本机采集程序..." : "已发送停止信号，正在等待采集与分析完成...",
      );
    } catch (error: any) {
      addLog("SYS", "error", `采集控制失败: ${error.message || error}`);
    } finally {
      setCollectorActionPending(false);
    }
  };

  const exportLogs = () => {
    if (logs.length === 0) {
      addLog("SYS", "warn", "没有可导出的日志数据");
      return;
    }
    const logText = logs
      .map(
        (l) => `[${l.time}] [${l.module}] [${l.level.toUpperCase()}] ${l.msg}`,
      )
      .join("\n");
    const blob = new Blob([logText], { type: "text/plain" });
    const url = URL.createObjectURL(blob);
    const a = document.createElement("a");
    a.href = url;
    a.download = `iov-rpi-logs-${new Date().toISOString().replace(/:/g, "-")}.txt`;
    a.click();
    URL.revokeObjectURL(url);
    addLog("SYS", "info", `成功导出 ${logs.length} 条日志记录`);
  };

  const manuallyTriggerTest = async (
    serviceId: number,
    serviceName: string,
  ) => {
    const task = getTaskDef(serviceId);
    if (!task) return;
    const wasCollectingAtStart = isCollectingRef.current;
    const collectionRunTokenAtStart = collectionRunTokenRef.current;

    // Calculate reqCount on manual trigger
    setServices((prev) =>
      prev.map((s) =>
        s.id === serviceId ? { ...s, reqCount: s.reqCount + 1 } : s,
      ),
    );
    setSimulationActive(true);

    addLog("APP", "info", `正在手动拨测 [${serviceName}]...`);
    const start = performance.now();
    try {
      const controller = new AbortController();
      const timeoutId = setTimeout(() => controller.abort(), 15000);
      const res = await fetch(task.url, {
        ...task.options,
        signal: controller.signal,
      });
      clearTimeout(timeoutId);
      const latency = performance.now() - start;

      if (res.ok) {
        let responseSnippet = "成功";
        let parsedData = null;
        try {
          parsedData = await res.json();
          responseSnippet = JSON.stringify(parsedData).substring(0, 100);
          if (responseSnippet.length >= 100) responseSnippet += "...";
        } catch {
          /* ignore non-json */
        }
        addLog(
          "APP",
          "info",
          `[${serviceName}] 耗时 ${Math.round(latency)}ms | 响应: ${responseSnippet}`,
        );
        setServices((prev) =>
          prev.map((s) =>
            s.id === serviceId ? { ...s, status: "running", latency } : s,
          ),
        );

        if (
          serviceId === 4 &&
          (!wasCollectingAtStart ||
            (isCollectingRef.current && collectionRunTokenRef.current === collectionRunTokenAtStart))
        ) {
          let fileName = `${otaLevel}.zip`;
          let downloadUrl = `${BASE_URL}/api/download/${otaLevel}.zip`;
          
          setDownloadTask((prev) => {
            if (
              !prev ||
              !prev.active ||
              prev.status === "completed" ||
                prev.status === "cancelled" ||
              prev.status === "error"
            ) {
              setTimeout(
                () =>
                  setDownloadTask((p) => (p ? { ...p, expanded: false } : p)),
                3000,
              );
              return {
                progress: 0,
                active: true,
                name: fileName,
                downloadUrl,
                expanded: true,
                status: "downloading",
              };
            }
            return prev;
          });
        }
      } else {
        addLog("APP", "error", `[${serviceName}] 请求失败: HTTP ${res.status}`);
        setServices((prev) =>
          prev.map((s) =>
            s.id === serviceId ? { ...s, status: "error", latency } : s,
          ),
        );
      }
    } catch (err: any) {
      addLog(
        "APP",
        "error",
        `[${serviceName}] 异常: ${err.message || "网络未知错误"}`,
      );
      setServices((prev) =>
        prev.map((s) =>
          s.id === serviceId ? { ...s, status: "error", latency: 5000 } : s,
        ),
      );
    }
  };

  // Setup AMap on load
  useEffect(() => {
    const initMapInstance = () => {
      if (window.AMap && document.getElementById("amap-mount-node")) {
        try {
          if (mapInstanceRef.current) {
            mapInstanceRef.current.resize?.();
            return;
          }
          mapInstanceRef.current = new window.AMap.Map(
            document.getElementById("amap-mount-node"),
            {
              zoom: 12,
              center: [gnssData.lon ?? 116.4074, gnssData.lat ?? 39.9042],
              mapStyle: "amap://styles/dark", // Use dark theme to fit terminal
            },
          );

          // Create car icon SVG
          const carSvg = `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 64 64" width="32" height="32">
            <path d="M16 12C16 8 20 4 32 4C44 4 48 8 48 12V52C48 56 44 60 32 60C20 60 16 56 16 52V12Z" fill="#3b82f6" stroke="#ffffff" stroke-width="2"/>
            <path d="M20 24H44V40H20V24Z" fill="#1e3a8a"/>
            <path d="M22 8H42V16H22V8Z" fill="#93c5fd"/>
            <path d="M22 48H42V56H22V48Z" fill="#ef4444"/>
          </svg>`;
          const carIconUrl = `data:image/svg+xml;charset=utf-8,${encodeURIComponent(carSvg)}`;

          const marker = new window.AMap.Marker({
            position: [gnssData.lon ?? 116.4074, gnssData.lat ?? 39.9042],
            icon: carIconUrl,
            offset: new window.AMap.Pixel(-16, -16),
            autoRotation: true,
            angle: 270, // Pointing West
          });
          mapInstanceRef.current.add(marker);
          if (gnssData.lat === null || gnssData.lon === null) marker.hide?.();
          vehicleMarkerRef.current = marker;
          setMapLoaded(true);
        } catch (e) {
          addLog(
            "SYS",
            "error",
            "Map Init Failed: Please configure AMap Key",
          );
        }
      }
    };

    const initAMap = () => {
      if (!window.AMap && !document.getElementById("amap-script")) {
        window._AMapSecurityConfig = {
          securityJsCode: "7dc4def5e6ae5f116c12fef86176bc75",
        };
        const script = document.createElement("script");
        script.id = "amap-script";
        const amapKey = import.meta.env.VITE_AMAP_KEY || '2b14a767057d5161de944161a6065b9e';
        script.src = `https://webapi.amap.com/maps?v=2.0&key=${amapKey}&plugin=AMap.Marker,AMap.MoveAnimation`;
        script.async = true;
        script.onload = () => {
          initMapInstance();
        };
        script.onerror = () => {
          console.warn("Failed to load AMap CDN script, running in local simulated GNSS mode.");
        };
        document.head.appendChild(script);
      } else {
        setTimeout(initMapInstance, 100);
      }
    };

    if (activeView === 'diag' && userBusinessView === 'standard') {
      initAMap();
    }
  }, [activeView, userBusinessView]);

  const formatMetric = (value: number | null | undefined, unit: string, digits = 2) =>
    Number.isFinite(value) ? `${Number(value).toFixed(digits)} ${unit}` : "--";
  const formatThroughput = (value: number | null | undefined) => {
    if (!Number.isFinite(value)) return "--";
    const bps = Number(value);
    if (Math.abs(bps) >= 1_000_000) return `${(bps / 1_000_000).toFixed(2)} Mbps`;
    if (Math.abs(bps) >= 1_000) return `${(bps / 1_000).toFixed(2)} Kbps`;
    return `${bps.toFixed(0)} bps`;
  };

  return (
    <div className="h-screen w-screen bg-diag-bg flex flex-col p-4 gap-4 overflow-hidden select-none font-sans text-gray-200">
      {/* 1. Technical Header */}
      <header className="h-16 flex justify-between items-center bg-diag-card/50 border border-white/5 rounded-2xl px-6 shrink-0 relative overflow-hidden">
        <div className="absolute top-0 left-0 w-full h-0.5 bg-diag-accent/20 overflow-hidden">
          <motion.div
            className="h-full bg-diag-accent"
            animate={isCollecting ? { x: [-500, 1500] } : {}}
            transition={{ repeat: Infinity, duration: 3, ease: "linear" }}
          />
        </div>

        <div className="flex items-center gap-4">
          <div
            className={cn(
              "w-12 h-12 rounded-xl flex items-center justify-center border transition-all duration-500",
              isCollecting
                ? "bg-diag-accent/20 border-diag-accent shadow-[0_0_15px_rgba(59,130,246,0.3)]"
                : "bg-white/5 border-white/10",
            )}
          >
            <Database
              className={cn(
                "w-6 h-6",
                isCollecting ? "text-diag-accent" : "text-gray-500",
              )}
            />
          </div>
          <div className="flex items-center gap-4 overflow-x-auto no-scrollbar max-w-full">
            <div className="flex bg-black/40 rounded-lg p-1 border border-white/5 shrink-0">
              <button
                 onClick={() => setActiveView('diag')}
                 className={cn(
                   "px-4 py-1.5 text-xs font-bold rounded-md transition-colors whitespace-nowrap shrink-0",
                   activeView === 'diag' ? "bg-white/10 text-white" : "text-gray-500 hover:text-gray-300"
                 )}
              >
                 用户端业务
              </button>
              <button
                 onClick={() => setActiveView('gps')}
                 className={cn(
                   "px-4 py-1.5 text-xs font-bold rounded-md flex items-center gap-2 transition-colors whitespace-nowrap shrink-0",
                   activeView === 'gps' ? "bg-white/10 text-white" : "text-gray-500 hover:text-gray-300"
                 )}
              >
                  GPS 定位标记
              </button>
              <button
                 onClick={() => setActiveView('dataviz')}
                 className={cn(
                   "px-4 py-1.5 text-xs font-bold rounded-md flex items-center gap-2 transition-colors whitespace-nowrap shrink-0",
                   activeView === 'dataviz' ? "bg-white/10 text-white" : "text-gray-500 hover:text-gray-300"
                 )}
              >
                  数据可视化
              </button>
            </div>
          </div>
        </div>

        <div className="flex items-center gap-3">
          <div className="hidden md:grid grid-cols-2 gap-x-6 gap-y-1 text-right">
            <div className="text-[10px] text-gray-500 uppercase font-bold">
              UE ID
            </div>
            <div className="text-[10px] font-mono">VH001</div>
            <div className="text-[10px] text-gray-500 uppercase font-bold">
              测试场景
            </div>
            <div className="text-[10px] font-mono">Urban_V2X_2026</div>
          </div>
          <button
            onClick={() => setShowHardware(!showHardware)}
            className="text-[10px] uppercase font-bold tracking-widest border border-white/10 px-3 py-1.5 rounded-lg hover:bg-white/10 flex items-center gap-2 transition-colors text-gray-400 hover:text-white"
          >
            {showHardware ? "隐藏状态栏" : "显示状态栏"}
          </button>
          <button
            onClick={toggleCollectors}
            disabled={collectorActionPending || ["starting", "stopping", "merging", "rendering"].includes(collectorStatus.phase)}
            title={collectorStatus.error || collectorStatus.message}
            className={cn(
              "flex items-center gap-2 px-5 py-3 rounded-xl font-bold uppercase text-xs tracking-widest transition-all active:scale-95 disabled:cursor-wait disabled:opacity-80",
              collectorStatus.phase === "stopping" || collectorStatus.phase === "merging" || collectorStatus.phase === "rendering"
                ? "bg-diag-warning/10 border border-diag-warning/40 text-diag-warning"
                : collectorStatus.phase === "running" || collectorStatus.collectors.radio || collectorStatus.collectors.network
                  ? "bg-diag-danger/10 border border-diag-danger/40 text-diag-danger hover:bg-diag-danger/20"
                  : "bg-diag-accent text-white shadow-lg shadow-diag-accent/30 hover:brightness-110",
            )}
          >
            {collectorStatus.phase === "starting" ? (
              <><Play className="w-4 h-4 animate-pulse" /> 正在启动...</>
            ) : collectorStatus.phase === "stopping" ? (
              <><Square className="w-4 h-4 animate-pulse" /> 正在停止/分析...</>
            ) : collectorStatus.phase === "merging" ? (
              <><Database className="w-4 h-4 animate-pulse" /> 正在融合CSV...</>
            ) : collectorStatus.phase === "rendering" ? (
              <><Video className="w-4 h-4 animate-pulse" /> 正在生成指标录像...</>
            ) : collectorStatus.phase === "running" || collectorStatus.collectors.radio || collectorStatus.collectors.network ? (
              <><Square className="w-4 h-4" /> 停止采集</>
            ) : (
              <><Play className="w-4 h-4" /> 开启采集</>
            )}
          </button>
          <button
            onClick={toggleCollection}
            className={cn(
              "flex items-center gap-3 px-6 py-3 rounded-xl font-bold uppercase text-xs tracking-widest transition-all active:scale-95",
              isCollecting
                ? "bg-diag-danger/10 border border-diag-danger/30 text-diag-danger hover:bg-diag-danger/20"
                : "bg-diag-accent text-white shadow-lg shadow-diag-accent/30 hover:brightness-110",
            )}
          >
            {isCollecting ? (
              <>
                <Square className="w-4 h-4" /> 停止业务流
              </>
            ) : (
              <>
                <Play className="w-4 h-4" /> 开启业务流
              </>
            )}
          </button>
        </div>
      </header>

      {/* 2. User business secondary navigation */}
      {activeView === 'diag' && (
        <div className="h-12 shrink-0 bg-diag-card/50 border border-white/5 rounded-xl px-4 flex items-center justify-between">
          <div className="flex items-center gap-1 bg-black/30 rounded-lg p-1 border border-white/5">
            <button
              onClick={() => setUserBusinessView('standard')}
              className={cn(
                "px-4 py-1.5 text-xs font-bold rounded-md flex items-center gap-2 transition-colors whitespace-nowrap",
                userBusinessView === 'standard' ? "bg-white/10 text-white" : "text-gray-500 hover:text-gray-300",
              )}
            >
              <Zap className="w-3.5 h-3.5 text-diag-warning" /> 标准化业务
            </button>
            <button
              onClick={() => setUserBusinessView('mqtt')}
              className={cn(
                "px-4 py-1.5 text-xs font-bold rounded-md flex items-center gap-2 transition-colors whitespace-nowrap",
                userBusinessView === 'mqtt' ? "bg-white/10 text-white" : "text-gray-500 hover:text-gray-300",
              )}
            >
              <AgentIcon className="w-3.5 h-3.5" /> MQTT 仿真网关
            </button>
            <button
              onClick={() => setUserBusinessView('video')}
              className={cn(
                "px-4 py-1.5 text-xs font-bold rounded-md flex items-center gap-2 transition-colors whitespace-nowrap",
                userBusinessView === 'video' ? "bg-white/10 text-white" : "text-gray-500 hover:text-gray-300",
              )}
            >
              <HardDrive className="w-3.5 h-3.5" /> 视频缓存代理
            </button>
          </div>
          {userBusinessView === 'standard' && (
            <div className="text-[10px] font-bold text-blue-400 uppercase tracking-widest">
              活跃采集任务: 5
            </div>
          )}
        </div>
      )}

      {/* 3. Main content */}
        <main style={{ display: activeView === 'diag' && userBusinessView === 'standard' ? undefined : 'none' }} className="flex-1 grid grid-cols-12 gap-4 overflow-hidden relative">
        {/* Left: Radio & CPU */}
        {showHardware && (
          <div className="col-span-12 lg:col-span-3 flex flex-col gap-4 overflow-hidden">
            {/* wireless status */}
            <div className="diag-card rounded-2xl p-5 flex flex-col gap-6 flex-1">
              <div className="flex justify-between items-center">
                <h2 className="text-xs font-bold text-gray-500 uppercase tracking-widest flex items-center gap-2">
                  <Signal className="w-4 h-4 text-diag-accent" /> 无线通信状态
                </h2>
                <Activity className="w-4 h-4 text-diag-accent/30 animate-pulse" />
              </div>

              <div className="grid grid-cols-2 gap-6">
                <div>
                  <p className="text-[10px] text-gray-500 uppercase font-bold mb-1">
                    RSRP
                  </p>
                  <div className="text-2xl stat-value text-white">
                    {Math.round(netStats.rsrp)}{" "}
                    <span className="text-xs text-gray-500">dBm</span>
                  </div>
                </div>
                <div>
                  <p className="text-[10px] text-gray-500 uppercase font-bold mb-1">
                    SINR
                  </p>
                  <div className="text-2xl stat-value text-diag-accent">
                    {Math.round(netStats.sinr)}{" "}
                    <span className="text-xs text-gray-500">dB</span>
                  </div>
                </div>
                <div>
                  <p className="text-[10px] text-gray-500 uppercase font-bold mb-1">
                    接入时延 (Latency)
                  </p>
                  <div
                    className={cn(
                      "text-2xl stat-value",
                      netStats.latency > 150
                        ? "text-diag-danger"
                        : "text-diag-success",
                    )}
                  >
                    {Math.round(netStats.latency)}{" "}
                    <span className="text-xs text-gray-500">ms</span>
                  </div>
                </div>
                <div>
                  <p className="text-[10px] text-gray-500 uppercase font-bold mb-1">
                    承载层 (Bearer)
                  </p>
                  <div className="text-xs stat-value text-blue-400 mt-2">
                    QCI 1 (VoIP/C-V2X)
                  </div>
                </div>
              </div>

              <div className="mt-auto pt-6 border-t border-white/5 space-y-3">
                <div className="flex justify-between text-[10px] uppercase font-bold text-gray-500">
                  <span>空口丢包率 (Packet Loss)</span>
                  <span
                    className={
                      netStats.packetLoss > 0
                        ? "text-diag-danger"
                        : "text-diag-success"
                    }
                  >
                    {netStats.packetLoss}%
                  </span>
                </div>
                <div className="h-1 w-full bg-white/5 rounded-full overflow-hidden">
                  <motion.div
                    className="h-full bg-diag-danger"
                    animate={{ width: `${netStats.packetLoss * 10}%` }}
                  />
                </div>
              </div>
            </div>

            {/* Hardware Resources */}
            <div className="diag-card rounded-2xl p-5 h-40 shrink-0">
              <h2 className="text-xs font-bold text-gray-500 uppercase tracking-widest flex items-center gap-2 mb-4">
                <Cpu className="w-4 h-4 text-diag-accent" /> 宿主机状态 (RPi 4B)
              </h2>
              <div className="grid grid-cols-2 gap-4">
                <div className="flex flex-col">
                  <span className="text-[10px] text-gray-500 uppercase font-bold">
                    CPU 温度
                  </span>
                  <span className="text-sm font-mono text-diag-warning">
                    54.2°C
                  </span>
                </div>
                <div className="flex flex-col text-right">
                  <span className="text-[10px] text-gray-500 uppercase font-bold">
                    存储空间剩余
                  </span>
                  <span className="text-sm font-mono">14.2 GB</span>
                </div>
              </div>
              <div className="mt-4 flex items-center gap-2">
                <HardDrive className="w-3 h-3 text-diag-accent" />
                <div className="flex-1 h-1 bg-white/5 rounded-full overflow-hidden">
                  <div className="h-full w-[45%] bg-diag-accent" />
                </div>
              </div>
            </div>
          </div>
        )}

        {/* Center: Active Measurement (Application/Business Layer) */}
        <div
          className={cn(
            "col-span-12 flex flex-col gap-4 overflow-hidden transition-all duration-300",
            showHardware ? "lg:col-span-6" : "lg:col-span-9",
          )}
        >
          <div className="diag-card rounded-2xl p-6 flex flex-col gap-6 flex-1 overflow-hidden">
            <div className="grid grid-cols-1 xl:grid-cols-[minmax(0,1.65fr)_minmax(280px,1fr)] gap-4 flex-1 min-h-0">
              <div className="grid grid-cols-1 gap-3 overflow-y-auto pr-2 custom-scrollbar content-start">
                {services.map((s) => (
                <div
                  key={s.id}
                  onClick={() => manuallyTriggerTest(s.id, s.name)}
                  className="bg-white/5 border border-white/5 rounded-xl p-4 flex items-center justify-between group hover:border-diag-accent/30 transition-colors cursor-pointer active:scale-[0.99]"
                >
                  <div className="flex items-center gap-4">
                    <div
                      className="flex items-center justify-center p-2 -ml-2 rounded hover:bg-white/10 transition-colors"
                      onClick={(e) => toggleService(s.id, e)}
                    >
                      <div
                        className={cn(
                          "w-4 h-4 rounded flex items-center justify-center transition-colors border",
                          s.enabled
                            ? "bg-diag-accent border-diag-accent"
                            : "border-gray-500 bg-black/20",
                        )}
                      >
                        {s.enabled && (
                          <Check className="w-3 h-3 text-white stroke-[3px]" />
                        )}
                      </div>
                    </div>
                    <div
                      className={cn(
                        "w-10 h-10 rounded-lg flex items-center justify-center transition-colors shadow-inner",
                        s.status === "error"
                          ? "bg-diag-danger/20 text-diag-danger"
                          : s.status === "running"
                            ? "bg-diag-success/20 text-diag-success"
                            : "bg-white/5 text-gray-600",
                      )}
                    >
                      {s.id === 1 && <Gauge className="w-5 h-5" />}
                      {s.id === 2 && <Radio className="w-5 h-5" />}
                      {s.id === 3 && <Navigation className="w-5 h-5" />}
                      {s.id === 4 && <Download className="w-5 h-5" />}
                      {s.id === 5 && <AlertTriangle className="w-5 h-5" />}
                    </div>
                    <div>
                      <h3 className="text-sm font-bold uppercase tracking-tight flex items-center gap-2">
                        {s.name}
                        {s.id === 4 && (
                          <select 
                            onClick={(e) => e.stopPropagation()}
                            onChange={(e) => setOtaLevel(e.target.value)}
                            value={otaLevel}
                            className="bg-black/40 text-[10px] px-2 py-0.5 rounded border border-white/10 outline-none text-gray-300 hover:border-diag-accent/50 focus:border-diag-accent transition-colors cursor-pointer"
                          >
                            <option value="harmony6">HarmonyOS 6</option>
                            <option value="harmony6.8">HarmonyOS 6.8</option>
                            <option value="harmony6.8.1">HarmonyOS 6.8.1</option>
                          </select>
                        )}
                      </h3>
                      <div className="flex items-center gap-3 mt-1">
                        <span className="text-[10px] text-gray-500 uppercase font-bold">
                          发起次数: {s.reqCount}
                        </span>
                        <span className="text-[10px] text-gray-500 uppercase font-bold">
                          业务时延:{" "}
                          <span
                            className={cn(
                              s.latency > 150
                                ? "text-diag-danger"
                                : "text-diag-success",
                            )}
                          >
                            {Math.round(s.latency)}ms
                          </span>
                        </span>
                      </div>
                    </div>
                  </div>
                  <div className="text-right">
                    <div
                      className={cn(
                        "text-[10px] font-bold uppercase tracking-[0.2em] px-2 py-0.5 rounded",
                        s.status === "error"
                          ? "bg-diag-danger text-white animate-pulse"
                          : s.status === "running"
                            ? "bg-diag-success/20 text-diag-success"
                            : "text-gray-600",
                      )}
                    >
                      {s.status === "error"
                        ? "异常"
                        : s.status === "running"
                          ? "连通"
                          : "就绪"}
                    </div>
                  </div>
                </div>
                ))}
              </div>
              <LiveCameraPreview phase={collectorStatus.phase} />
            </div>

            {/* Latest persisted network-analysis row */}
            <div className="mt-auto pt-4 border-t border-white/5 shrink-0">
              <div className="rounded-xl border border-white/10 bg-black/35 px-5 py-4">
                <div className="flex items-center justify-between mb-3">
                  <div className="flex items-center gap-2 text-xs font-bold text-gray-400">
                    <Activity className="w-4 h-4 text-diag-accent" /> 网络侧实时解析
                  </div>
                  <div className={cn(
                    "flex items-center gap-2 text-[10px] font-bold tracking-widest",
                    liveCaptureMetrics ? "text-diag-success" : "text-gray-600",
                  )}>
                    <span className={cn(
                      "w-2 h-2 rounded-full",
                      liveCaptureMetrics ? "bg-diag-success animate-pulse" : "bg-gray-700",
                    )} />
                    {liveCaptureMetrics ? "LIVE" : "等待网络侧实时解析"}
                  </div>
                </div>
                <div className="grid grid-cols-[1.55fr_repeat(4,minmax(0,1fr))] divide-x divide-white/10">
                  {[
                    { label: "时间戳", value: liveCaptureMetrics?.timestamp || "--" },
                    { label: "RTT", value: formatMetric(liveCaptureMetrics?.avg_rtt_ms, "ms") },
                    { label: "吞吐量", value: formatThroughput(liveCaptureMetrics?.throughput_bps) },
                    { label: "抖动", value: formatMetric(liveCaptureMetrics?.jitter_ms, "ms") },
                    { label: "丢包率", value: Number.isFinite(liveCaptureMetrics?.loss_rate) ? `${(Number(liveCaptureMetrics?.loss_rate) * 100).toFixed(2)} %` : "--" },
                  ].map((metric, index) => (
                    <div key={metric.label} className={cn("min-w-0", index === 0 ? "pr-5" : "px-5")}>
                      <div className="text-[10px] text-gray-500 font-bold tracking-widest mb-1.5">{metric.label}</div>
                      <div className={cn(
                        "font-mono font-bold truncate",
                        index === 0 ? "text-base text-white" : "text-xl text-diag-accent",
                      )} title={metric.value}>
                        {metric.value}
                      </div>
                    </div>
                  ))}
                </div>
              </div>
            </div>
          </div>
        </div>

        {/* Right: Technical Logging & Sys Info & GNSS */}
        <div className="col-span-12 lg:col-span-3 flex flex-col gap-4 overflow-hidden relative">
          {/* GNSS Tracker - Now on the right */}
          <div className="diag-card rounded-2xl p-5 h-auto">
            <h2 className="text-xs font-bold text-gray-500 uppercase tracking-widest flex items-center gap-2 mb-4">
              <MapPin className="w-4 h-4 text-diag-success" /> GNSS 定位组件
            </h2>
            <div className="space-y-2 font-mono mb-4">
              <div className="flex justify-between items-center text-xs">
                <span className="text-gray-500">LAT:</span>
                <span>{gnssData.lat === null ? "--" : `${gnssData.lat.toFixed(6)}° N`}</span>
              </div>
              <div className="flex justify-between items-center text-xs">
                <span className="text-gray-500">LON:</span>
                <span>{gnssData.lon === null ? "--" : `${gnssData.lon.toFixed(6)}° E`}</span>
              </div>
              <div className="flex justify-between items-center text-xs">
                <span className="text-gray-500">UPDATED:</span>
                <span className="text-diag-success font-mono">
                  {gnssData.updatedAt ? (gnssData.updatedAt.split(" ")[1] || gnssData.updatedAt) : "等待定位"}
                </span>
              </div>
            </div>

            {/* Map View Box */}
            <div
              className={cn(
                "relative rounded-xl border border-white/10 transition-all",
                services.find((s) => s.id === 3)?.enabled
                  ? "opacity-100 bg-[#1e1e1e]"
                  : "opacity-30 grayscale bg-black",
                "w-full h-32 flex-shrink-0",
              )}
            >
              <div id="map-placeholder" className="w-full h-full relative rounded-xl transition-all" />

              {createPortal(
                <div
                  ref={mapContainerRef}
                  style={{ display: activeView === 'diag' && userBusinessView === 'standard' ? undefined : 'none' }}
                  className={cn(
                    "bg-[#1e1e1e] overflow-hidden transition-all duration-300",
                    isMapFullscreen
                      ? "fixed inset-0 z-[9999] rounded-none shadow-none"
                      : "absolute inset-0 rounded-xl",
                  )}
                >
                  {/* The actual AMap element */}
                  <div id="amap-mount-node" className="w-full h-full" />

                  <button
                    onClick={() => setIsMapFullscreen(!isMapFullscreen)}
                    className={cn(
                      "absolute z-[10000] bg-black/60 hover:bg-black/80 rounded p-1.5 backdrop-blur border border-white/10 text-white transition-all shadow-lg",
                      isMapFullscreen ? "top-6 right-6 p-3" : "top-2 right-2",
                    )}
                  >
                    {isMapFullscreen ? (
                      <Minimize2 className="w-5 h-5" />
                    ) : (
                      <Maximize2 className="w-4 h-4" />
                    )}
                  </button>
                </div>,
                floatingMapContainer
              )}
            </div>
          </div>

          {/* Terminal Logging */}
          <div className="diag-card rounded-2xl p-6 flex flex-col flex-1 overflow-hidden bg-black/80">
            <div className="flex items-center justify-between mb-4 shrink-0">
              <h2 className="text-xs font-bold text-gray-500 uppercase tracking-widest flex items-center gap-2">
                <Terminal className="w-4 h-4 text-diag-accent" /> 业务流日志
              </h2>
              <button
                onClick={exportLogs}
                className="text-[10px] uppercase font-bold tracking-widest border border-white/10 px-3 py-1.5 rounded-lg hover:bg-white/10 flex items-center gap-2 transition-colors text-gray-400 hover:text-white"
              >
                <Download className="w-3 h-3" /> 导出日志
              </button>
            </div>
            <div
              ref={terminalRef}
              className="flex-1 overflow-y-auto custom-scrollbar font-mono text-[10px] space-y-1"
            >
              <AnimatePresence initial={false}>
                {logs.map((log) => (
                  <motion.div
                    key={log.id}
                    initial={{ opacity: 0, x: -5 }}
                    animate={{ opacity: 1, x: 0 }}
                    className={cn(
                      "terminal-line",
                      log.level === "error"
                        ? "text-diag-danger border-diag-danger"
                        : log.level === "warn"
                          ? "text-diag-warning border-diag-warning"
                          : "text-gray-400 border-diag-accent/20",
                    )}
                  >
                    <span className="opacity-40">[{log.time}]</span>{" "}
                    <span className="font-bold opacity-60">[{log.module}]</span>{" "}
                    {log.msg}
                  </motion.div>
                ))}
              </AnimatePresence>
            </div>
          </div>
        </div>

        {/* Global Floating Download Task View */}
        <AnimatePresence>
          {downloadTask && downloadTask.active && (
            <motion.div
              initial={{ opacity: 0, y: 50 }}
              animate={{ opacity: 1, y: 0 }}
              exit={{ opacity: 0, scale: 0.9 }}
              className="absolute bottom-6 right-6 z-50 flex flex-col items-end"
            >
              {downloadTask.expanded ? (
                <div className="bg-[#1a1b23] border border-white/10 rounded-xl p-4 shadow-2xl w-72 flex flex-col gap-3">
                  <div
                    className="flex items-center justify-between cursor-pointer group"
                    onClick={() =>
                      setDownloadTask((p) =>
                        p ? { ...p, expanded: false } : p,
                      )
                    }
                  >
                    <div className="flex items-center gap-2">
                      <Download
                        className={cn(
                          "w-4 h-4",
                          downloadTask.status === "completed"
                            ? "text-diag-success"
                            : downloadTask.status === "cancelled"
                              ? "text-gray-400"
                              : downloadTask.status === "error"
                                ? "text-diag-danger"
                                : "text-blue-400 animate-bounce",
                        )}
                      />
                      <span className="text-xs font-bold group-hover:text-gray-300 transition-colors">
                        {downloadTask.status === "completed"
                          ? "下载已完成"
                          : downloadTask.status === "cancelled"
                            ? "下载已取消"
                            : downloadTask.status === "error"
                              ? "下载失败"
                              : "文件下载中"}
                      </span>
                    </div>
                    {downloadTask.status === "downloading" && (
                      <span className="text-[10px] font-mono text-gray-400">
                        {Math.round(downloadTask.progress)}%
                      </span>
                    )}
                  </div>
                  <div className="text-[10px] text-gray-500 truncate">
                    {downloadTask.name}
                  </div>

                  {downloadTask.status === "downloading" && (
                    <div className="h-1.5 w-full bg-white/5 rounded-full overflow-hidden">
                      <motion.div
                        className="h-full bg-blue-500"
                        animate={{ width: `${downloadTask.progress}%` }}
                        transition={{ ease: "linear", duration: 0.5 }}
                      />
                    </div>
                  )}
                  {downloadTask.status === "completed" && (
                    <div className="flex gap-2 mt-2">
                      <button
                        onClick={() => {
                          addLog(
                            "APP",
                            "info",
                            `已查看文件: ${downloadTask.name}`,
                          );
                          // Use window.open for better reliability in iframes
                          const newWindow = window.open(downloadTask.downloadUrl, "_blank", "noopener,noreferrer");
                          if (!newWindow) {
                            // Fallback if blocked by popup blocker
                            window.location.href = downloadTask.downloadUrl;
                          }
                          setDownloadTask((p) =>
                            p ? { ...p, expanded: false, active: false } : p,
                          );
                        }}
                        className="flex-1 py-1.5 text-xs bg-diag-success/20 text-diag-success border border-diag-success/30 rounded hover:bg-diag-success/30 transition-colors"
                      >
                        查看文件
                      </button>
                      <button
                        onClick={(e) => {
                          e.stopPropagation();
                          navigator.clipboard.writeText(downloadTask.downloadUrl);
                          addLog("SYS", "info", "下载链接已复制到剪贴板");
                          setDownloadTask((p) =>
                            p ? { ...p, expanded: false, active: false } : p,
                          );
                        }}
                        className="flex-1 py-1.5 text-xs bg-blue-500/20 text-blue-400 border border-blue-500/30 rounded hover:bg-blue-500/30 transition-colors"
                      >
                        复制链接
                      </button>
                    </div>
                  )}
                  {downloadTask.status === "cancelled" && (
                    <div className="text-[10px] text-gray-400 border border-white/10 bg-white/5 rounded px-3 py-2">
                      未完成的数据已丢弃，文件没有保存。
                    </div>
                  )}
                </div>
              ) : (
                <button
                  onClick={() =>
                    setDownloadTask((p) => (p ? { ...p, expanded: true } : p))
                  }
                  className="bg-[#1a1b23] border border-white/20 w-12 h-12 rounded-full shadow-lg hover:bg-white/10 transition-colors flex items-center justify-center relative"
                >
                  <Download
                    className={cn(
                      "w-5 h-5",
                      downloadTask.status === "completed"
                        ? "text-diag-success"
                        : downloadTask.status === "cancelled"
                          ? "text-gray-400"
                          : downloadTask.status === "error"
                            ? "text-diag-danger"
                            : "text-blue-400 animate-pulse",
                    )}
                  />
                  {downloadTask.status === "completed" ? (
                    <div className="absolute top-0 right-0 w-3 h-3 bg-diag-success rounded-full border-2 border-[#1a1b23]" />
                  ) : downloadTask.status === "downloading" ? (
                    <div className="absolute top-0 right-0">
                      <svg className="w-5 h-5 transform -rotate-90">
                        <circle
                          cx="10"
                          cy="10"
                          r="8"
                          stroke="currentColor"
                          strokeWidth="2"
                          fill="none"
                          className="text-transparent"
                        />
                        <circle
                          cx="10"
                          cy="10"
                          r="8"
                          stroke="currentColor"
                          strokeWidth="2"
                          fill="none"
                          className="text-blue-500"
                          strokeDasharray="50.2"
                          strokeDashoffset={
                            50.2 - (downloadTask.progress / 100) * 50.2
                          }
                        />
                      </svg>
                    </div>
                  ) : (
                    <div className="absolute top-0 right-0 w-3 h-3 bg-gray-500 rounded-full border-2 border-[#1a1b23]" />
                  )}
                </button>
              )}
            </motion.div>
          )}
        </AnimatePresence>
      </main>
      {visitedBusinessViews.has('mqtt') && (
        <main style={{ display: activeView === 'diag' && userBusinessView === 'mqtt' ? undefined : 'none' }} className="flex-1 min-h-0 overflow-hidden relative">
          <AgentConsoleView />
        </main>
      )}
      {visitedBusinessViews.has('video') && (
        <main style={{ display: activeView === 'diag' && userBusinessView === 'video' ? undefined : 'none' }} className="flex-1 min-h-0 overflow-hidden relative bg-black rounded-xl">
          <AgentProxyVideoPlayer />
        </main>
      )}
      {(activeView === 'gps' || visitedViews.has('gps')) && (
        <main style={{ display: activeView === 'gps' ? undefined : 'none' }} className="flex-1 min-h-0 overflow-hidden relative bg-black rounded-xl">
          <GpsTrackerView data={gpsCsvData} hasQuery={csvData !== null} isActive={activeView === 'gps'} />
        </main>
      )}
      {(activeView === 'dataviz' || visitedViews.has('dataviz')) && (
        <main style={{ display: activeView === 'dataviz' ? undefined : 'none' }} className="flex-1 min-h-0 overflow-hidden relative rounded-xl">
          <DataVizView
            isActive={activeView === 'dataviz'}
            csvData={csvData}
            onQueryResult={setCsvData}
            autoCsvSelection={collectorStatus.latestCsv}
          />
        </main>
      )}

        {/* Completed capture artifact paths */}
        <AnimatePresence>
          {artifactResultToast && (
            <motion.div
              key={artifactResultToast.completionKey}
              initial={{ opacity: 0, y: 24, scale: 0.98 }}
              animate={{
                opacity: artifactResultToast.fading ? 0 : 1,
                y: artifactResultToast.fading ? 12 : 0,
                scale: 1,
              }}
              exit={{ opacity: 0, y: 12, scale: 0.98 }}
              transition={{ duration: artifactResultToast.fading ? 0.5 : 0.25 }}
              className={cn(
                "fixed right-6 z-[70] w-[min(480px,calc(100vw-3rem))] rounded-xl border border-diag-success/30 bg-[#10151d]/95 p-4 shadow-2xl shadow-black/50 backdrop-blur-md",
                downloadTask?.active ? "bottom-24" : "bottom-6",
              )}
            >
              <div className="flex items-start justify-between gap-4">
                <div className="flex items-center gap-2 text-sm font-bold text-white">
                  <span className="flex h-6 w-6 items-center justify-center rounded-full bg-diag-success/15">
                    <Check className="h-4 w-4 text-diag-success" />
                  </span>
                  采集处理完成
                </div>
                <button
                  type="button"
                  onClick={() => setArtifactResultToast(null)}
                  className="flex h-6 w-6 items-center justify-center rounded text-lg leading-none text-gray-500 transition-colors hover:bg-white/10 hover:text-white"
                  aria-label="关闭结果通知"
                >
                  ×
                </button>
              </div>
              <div className="mt-3 space-y-3 text-[11px]">
                <div>
                  <div className="mb-1 font-semibold text-gray-400">融合 CSV</div>
                  <div className="select-text break-all rounded-md border border-white/5 bg-black/35 px-3 py-2 font-mono leading-5 text-blue-300">
                    {artifactResultToast.csvPath}
                  </div>
                </div>
                <div>
                  <div className="mb-1 font-semibold text-gray-400">指标录像</div>
                  <div className="select-text break-all rounded-md border border-white/5 bg-black/35 px-3 py-2 font-mono leading-5 text-emerald-300">
                    {artifactResultToast.videoPath}
                  </div>
                </div>
              </div>
            </motion.div>
          )}
        </AnimatePresence>


      {/* 3. Bottom HUD / Status Bar */}
      <footer className="h-10 bg-diag-card/50 border border-white/5 rounded-xl px-6 flex items-center justify-between shrink-0 font-mono text-[10px] text-gray-500 tracking-wider">
        <div className="flex gap-8">
          <div className="flex items-center gap-2">
            <CircleDot className="w-3 h-3 text-diag-accent" />
            <span>PROTO: MQTT/TCP/IP_V4</span>
          </div>
          <div className="flex items-center gap-2">
            <Globe className="w-3 h-3 text-diag-accent" />
            <span>ENDPOINT: test.iov-device-01.local</span>
          </div>
        </div>
        <div className="flex items-center gap-4">
          {isCollecting && (
            <span className="animate-pulse text-diag-accent font-bold uppercase">
              正在记录...
            </span>
          )}
        </div>
      </footer>

      {/* Global Style Inject for the technical feel */}
      <style>{`
        .custom-scrollbar::-webkit-scrollbar { width: 3px; }
        .custom-scrollbar::-webkit-scrollbar-track { background: transparent; }
        .custom-scrollbar::-webkit-scrollbar-thumb { background: rgba(59, 130, 246, 0.2); border-radius: 10px; }
        .stat-value { font-variant-numeric: tabular-nums; }
      `}</style>
    </div>
  );
}

// Quick component for footer icons not imported
function Globe(props: any) {
  return (
    <svg
      {...props}
      viewBox="0 0 24 24"
      fill="none"
      stroke="currentColor"
      strokeWidth="2"
      strokeLinecap="round"
      strokeLinejoin="round"
    >
      <circle cx="12" cy="12" r="10" />
      <line x1="2" y1="12" x2="22" y2="12" />
      <path d="M12 2a15.3 15.3 0 0 1 4 10 15.3 15.3 0 0 1-4 10 15.3 15.3 0 0 1-4-10 15.3 15.3 0 0 1 4-10z" />
    </svg>
  );
}
