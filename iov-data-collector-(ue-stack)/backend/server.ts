import fs from "fs";
import path from "path";
import mqtt from "mqtt";
import express from "express";
import cors from "cors";
import { v4 as uuidv4 } from "uuid";
import http from "http";
import { execFile, spawn } from "child_process";

// 1. 加载配置 (使用环境变量)
const config = {
  device: {
    device_id: process.env.MQTT_DEVICE_ID || "rpi-001",
    session_id: process.env.MQTT_SESSION_ID || "roadtest-2026-001"
  },
  mqtt: {
    broker_url: process.env.MQTT_BROKER_URL || "mqtt://broker.emqx.io:1883",
    client_id: process.env.MQTT_CLIENT_ID || "rpi-agent-core-001-xyz-12345",
    username: process.env.MQTT_USERNAME || "",
    password: process.env.MQTT_PASSWORD || "",
    keepalive_sec: parseInt(process.env.MQTT_KEEPALIVE_SEC || "30", 10),
    clean_session: process.env.MQTT_CLEAN_SESSION !== "false"
  },
  topics: {
    heartbeat: "vehicle/{device_id}/heartbeat",
    telemetry: "vehicle/{device_id}/telemetry",
    event: "vehicle/{device_id}/event",
    measurement: "vehicle/{device_id}/measurement",
    status: "vehicle/{device_id}/status",
    cmd: "vehicle/{device_id}/cmd",
    cmd_ack: "vehicle/{device_id}/cmd_ack"
  },
  publish: {
    heartbeat_interval_sec: parseInt(process.env.MQTT_HEARTBEAT_INTERVAL || "10", 10),
    telemetry_interval_sec: parseInt(process.env.MQTT_TELEMETRY_INTERVAL || "10", 10),
    measurement_interval_sec: parseInt(process.env.MQTT_MEASUREMENT_INTERVAL || "30", 10)
  }
};

console.log("[AGENT] 环境变量配置加载成功: ", config.device.device_id);

const getTopic = (topicName: string) => {
  return (config.topics as any)[topicName].replace("{device_id}", config.device.device_id);
};

// 2. 状态维护
const state = {
  connected: false,
  reconnectCount: 0,
  publishSuccess: 0,
  publishFailed: 0,
  latestCommand: null,
  logs: [] as any[]
};

const addLog = (level: string, message: string) => {
  const ts = new Date().toISOString();
  console.log(`[${ts}] [${level}] ${message}`);
  state.logs.unshift({ ts, level, message });
  if (state.logs.length > 50) state.logs.pop();
};

// 3. MQTT 初始化
const clientId = `${config.mqtt.client_id}-${Math.floor(Math.random() * 1000000)}`;
const brokerUrl = config.mqtt.broker_url;

addLog("INFO", `正在连接 MQTT Broker: ${brokerUrl} (Client ID: ${clientId})`);
const clientOptions: mqtt.IClientOptions = {
  clientId,
  protocolVersion: 5, // 开启 MQTT 5.0，以便支持 nl (No Local) 特性
  clean: config.mqtt.clean_session,
  keepalive: config.mqtt.keepalive_sec,
  // 设置遗嘱消息 (Last Will and Testament)
  will: {
    topic: getTopic("status"),
    payload: Buffer.from(JSON.stringify({
      messageId: uuidv4(),
      sessionId: config.device.session_id,
      deviceId: config.device.device_id,
      type: "status",
      timestamp: new Date().toISOString(),
      status: "offline",
      reason: "unexpected_disconnect"
    })),
    qos: 1 as 0|1|2,
    retain: true
  }
};

if (config.mqtt.username) clientOptions.username = config.mqtt.username;
if (config.mqtt.password) clientOptions.password = config.mqtt.password;

const client = mqtt.connect(brokerUrl, clientOptions);

client.on("connect", () => {
  state.connected = true;
  addLog("SUCCESS", "MQTT Broker 连接成功");
  
  // 订阅云端命令、云端响应（包含在 /response/ 路径）
  const cmdTopic = getTopic("cmd");
  const heartbeatRespTopic = `vehicle/${config.device.device_id}/response/heartbeat`;
  const telemetryRespTopic = `vehicle/${config.device.device_id}/response/telemetry`;
  
  client.subscribe(cmdTopic, { qos: 1, nl: true });
  client.subscribe(heartbeatRespTopic, { qos: 1, nl: true });
  client.subscribe(telemetryRespTopic, { qos: 1, nl: true });
  addLog("INFO", `已订阅 Topic: cmd, response/heartbeat, response/telemetry`);

  // 发布上线状态
  const statusPayload = {
    messageId: uuidv4(),
    sessionId: config.device.session_id,
    deviceId: config.device.device_id,
    type: "status",
    timestamp: new Date().toISOString(),
    status: "online",
    reason: "normal_startup"
  };
  client.publish(getTopic("status"), JSON.stringify(statusPayload), { qos: 1, retain: true });
});

client.on("reconnect", () => {
  state.reconnectCount++;
  addLog("WARN", "MQTT 正在尝试重新连接...");
});

client.on("close", () => {
  state.connected = false;
  addLog("WARN", "MQTT 连接已断开");
});

client.on("error", (err) => {
  addLog("ERROR", `MQTT 客户端发生错误: ${err.message}`);
});

client.on("message", (topic, message) => {
  const payloadStr = message.toString();
  addLog("INFO", `📥 收到消息 [${topic}]: ${payloadStr}`);
  
  try {
    const data = JSON.parse(payloadStr);
    
    // 如果是命令消息，自动响应 ACK
    if (topic === getTopic("cmd")) {
      state.latestCommand = data;
      const ackPayload = {
        cmdId: data.cmdId,
        deviceId: config.device.device_id,
        status: "success",
        result: "ok",
        timestamp: new Date().toISOString()
      };
      client.publish(getTopic("cmd_ack"), JSON.stringify(ackPayload), { qos: 1 });
      addLog("SUCCESS", `✅ 已自动回复命令 ACK: ${data.cmdId}`);
    }
  } catch (e) {
    addLog("ERROR", `解析接收消息失败: ${e}`);
  }
});

// 4. 定时服务 (心跳、遥测、测量)
let seq = 0;
const startupTime = Date.now();

// GPS state is updated from the network collector's persisted live CSV rows.
export const gpsState = {
  latitude: 0,
  longitude: 0,
  speed: 0,
  heading: 0
};

// --- 心跳任务 ---
setInterval(() => {
  if (state.connected) {
    seq++;
    const hbPayload = {
      messageId: uuidv4(),
      sessionId: config.device.session_id,
      deviceId: config.device.device_id,
      type: "heartbeat",
      timestamp: new Date().toISOString(),
      uptimeMs: Date.now() - startupTime,
      version: "1.0.0"
    };
    client.publish(getTopic("heartbeat"), JSON.stringify(hbPayload), { qos: 0 }, (err) => {
      if (err) {
        state.publishFailed++;
        addLog("ERROR", "❌ 心跳发送失败");
      } else {
        state.publishSuccess++;
        addLog("INFO", `💓 心跳发送成功 (uptime: ${Math.floor(hbPayload.uptimeMs/1000)}s)`);
      }
    });
  }
}, config.publish.heartbeat_interval_sec * 1000);

// --- 遥测任务 ---
setInterval(() => {
  if (state.connected) {
    const telemetryPayload = {
      messageId: uuidv4(),
      sessionId: config.device.session_id,
      deviceId: config.device.device_id,
      type: "telemetry",
      timestamp: new Date().toISOString(),
      latitude: gpsState.latitude,
      longitude: gpsState.longitude,
      speed: gpsState.speed,
      heading: gpsState.heading,
      altitude: 50.0,
      batteryLevel: Math.floor(Math.random() * 100),
      engineTemp: 90.0 + (Math.random() - 0.5) * 10,
      fuelLevel: 75.5,
      rpm: 2000 + Math.floor((Math.random() - 0.5) * 500),
      customFields: {}
    };
    client.publish(getTopic("telemetry"), JSON.stringify(telemetryPayload), { qos: 0 }, (err) => {
        if (err) {
          state.publishFailed++;
        } else {
          state.publishSuccess++;
        }
    });
  }
}, config.publish.telemetry_interval_sec * 1000);

// --- 测量任务 ---
setInterval(() => {
    if (state.connected) {
      const measurementPayload = {
        messageId: uuidv4(),
        sessionId: config.device.session_id,
        deviceId: config.device.device_id,
        type: "measurement",
        timestamp: new Date().toISOString(),
        windowSec: config.publish.measurement_interval_sec,
        metrics: {
          mqttReconnectCount: state.reconnectCount,
          mqttPublishSuccess: state.publishSuccess,
          mqttPublishFailed: state.publishFailed,
          rttAvgMs: 45.3 + (Math.random() * 10),
          packetLossRate: 0.02,
          httpSuccessRate: 0.99,
          custom: {}
        }
      };
      client.publish(getTopic("measurement"), JSON.stringify(measurementPayload), { qos: 0 });
    }
  }, config.publish.measurement_interval_sec * 1000);



// 5. 本地 REST API 服务 (供车机前端/本地工具调用)
const app = express();
app.use(cors());
app.use(express.json());

// --- Custom Data Source API ---
const findDatasDir = () => {
  const candidates = [
    path.resolve(__dirname, '../datas'),
    path.resolve(__dirname, '../../datas'),
    path.resolve(process.cwd(), 'datas'),
    path.resolve(process.cwd(), '../datas'),
    '/datas'
  ];
  for (const dir of candidates) {
    if (fs.existsSync(dir)) return dir;
  }
  return path.resolve(process.cwd(), 'datas');
};

const parseCsvLine = (line: string): string[] => {
  const values: string[] = [];
  let value = '';
  let quoted = false;
  for (let index = 0; index < line.length; index++) {
    const char = line[index];
    if (char === '"') {
      if (quoted && line[index + 1] === '"') {
        value += '"';
        index++;
      } else {
        quoted = !quoted;
      }
    } else if (char === ',' && !quoted) {
      values.push(value);
      value = '';
    } else {
      value += char;
    }
  }
  values.push(value);
  return values;
};

const csvNumber = (parts: string[], columnIndex: number): number | null => {
  if (columnIndex < 0 || columnIndex >= parts.length) return null;
  const value = parts[columnIndex]?.trim();
  if (!value) return null;
  const parsed = Number.parseFloat(value);
  return Number.isFinite(parsed) ? parsed : null;
};

app.get("/api/local/data/sources", (req, res) => {
  try {
    const dir = findDatasDir();
    if (!fs.existsSync(dir)) {
      return res.json({ sources: ["Autocom", "BJTU"] });
    }
    const sources = fs.readdirSync(dir).filter(f => {
      try {
        return fs.statSync(path.join(dir, f)).isDirectory();
      } catch {
        return false;
      }
    });
    res.json({ sources: sources.length > 0 ? sources : ["Autocom", "BJTU"] });
  } catch (error: any) {
    res.json({ sources: ["Autocom", "BJTU"] });
  }
});

app.get("/api/local/data/sources/:source/files", (req, res) => {
  try {
    const dir = findDatasDir();
    const sourcePath = path.join(dir, req.params.source);
    if (!fs.existsSync(sourcePath)) {
      return res.json({ files: [] });
    }
    const files = fs.readdirSync(sourcePath).filter(f => f.endsWith('.csv'));
    res.json({ files });
  } catch (error: any) {
    res.status(500).json({ error: error.message, files: [] });
  }
});

app.post("/api/local/data/files/stats", (req, res) => {
  try {
    const dir = findDatasDir();
    const { source, files } = req.body;
    let minTime: Date | null = null;
    let maxTime: Date | null = null;

    if (Array.isArray(files)) {
      for (const file of files) {
        const filePath = path.join(dir, source, file);
        if (fs.existsSync(filePath)) {
          const content = fs.readFileSync(filePath, 'utf-8');
          const lines = content.split('\n');
          for (let i = 1; i < lines.length; i++) {
            const line = lines[i].trim();
            if (!line) continue;
            const parts = line.split(',');
            if (parts.length > 1 && parts[1]) {
              const rawDateStr = parts[1].trim();
              const dateStr = rawDateStr.replace(' ', 'T');
              const t = new Date(dateStr);
              if (!isNaN(t.getTime())) {
                if (!minTime || t < minTime) minTime = t;
                if (!maxTime || t > maxTime) maxTime = t;
              }
            }
          }
        }
      }
    }
    const formatTime = (d: Date | null) => {
      if (!d) return null;
      const pad = (n: number) => String(n).padStart(2, '0');
      return `${d.getFullYear()}-${pad(d.getMonth() + 1)}-${pad(d.getDate())} ${pad(d.getHours())}:${pad(d.getMinutes())}:${pad(d.getSeconds())}`;
    };
    res.json({ 
      minTime: formatTime(minTime), 
      maxTime: formatTime(maxTime) 
    });
  } catch (error: any) {
    res.status(500).json({ error: error.message });
  }
});

app.post("/api/local/data/files/query", (req, res) => {
  try {
    const dir = findDatasDir();
    const { source, files, startTime, endTime } = req.body;
    const start = startTime ? new Date(startTime.replace(' ', 'T')).getTime() : 0;
    const end = endTime ? new Date(endTime.replace(' ', 'T')).getTime() : Infinity;
    
    const results: any[] = [];
    
    if (Array.isArray(files)) {
      for (const file of files) {
        const filePath = path.join(dir, source, file);
        if (fs.existsSync(filePath)) {
          const content = fs.readFileSync(filePath, 'utf-8');
          const lines = content.split('\n');
          const headers = parseCsvLine(lines[0] || '').map((name, index) =>
            index === 0 ? name.replace(/^\uFEFF/, '') : name
          );
          const column = (name: string, fallback: number) => {
            const index = headers.indexOf(name);
            return index >= 0 ? index : fallback;
          };
          const timestampIndex = column('timestamp', 1);
          const avgRttIndex = column('avg_rtt_ms', 2);
          const jitterIndex = column('jitter_ms', 3);
          const throughputIndex = column('throughput_bps', 4);
          const lossRateIndex = column('loss_rate', 5);
          const latitudeIndex = column('gcj02_latitude', 6);
          const longitudeIndex = column('gcj02_longitude', 7);
          const rsrpIndex = headers.indexOf('NR SSB RSRP[dBm]');
          const sinrIndex = headers.indexOf('NR SSB SINR[dB]');
          const rsrqIndex = headers.indexOf('NR SSB RSRQ[dB]');
          const rssiIndex = headers.indexOf('NR SSB RSSI[dBm]');
          for (let i = 1; i < lines.length; i++) {
            const line = lines[i].trim();
            if (!line) continue;
            const parts = parseCsvLine(line);
            if (parts.length >= 8) {
              const tStr = parts[timestampIndex]?.trim();
              if (tStr) {
                const t = new Date(tStr.replace(' ', 'T')).getTime();
                if (!isNaN(t) && t >= start && t <= end) {
                  results.push({
                    timestamp: tStr,
                    avg_rtt_ms: csvNumber(parts, avgRttIndex),
                    jitter_ms: csvNumber(parts, jitterIndex),
                    throughput_bps: csvNumber(parts, throughputIndex),
                    loss_rate: csvNumber(parts, lossRateIndex),
                    gcj02_latitude: csvNumber(parts, latitudeIndex),
                    gcj02_longitude: csvNumber(parts, longitudeIndex),
                    rsrp_dbm: csvNumber(parts, rsrpIndex),
                    sinr_db: csvNumber(parts, sinrIndex),
                    rsrq_db: csvNumber(parts, rsrqIndex),
                    rssi_dbm: csvNumber(parts, rssiIndex),
                  });
                }
              }
            }
          }
        }
      }
    }
    res.json({ data: results });
  } catch (error: any) {
    res.status(500).json({ error: error.message });
  }
});

// 获取 Agent 状态
app.get("/api/local/status", (req, res) => {
  res.json({
    device: config.device,
    broker: brokerUrl,
    state
  });
});

app.get("/api/local/poi/search", (req, res) => {
  res.json({
    code: 200,
    message: "success",
    data: [
      {
        id: "poi_001",
        name: "测试加油站",
        latitude: 39.9042,
        longitude: 116.4074
      }
    ]
  });
});

// 手动触发一个车端事件报文发往云端
app.post("/api/local/event", (req, res) => {
  if (!state.connected) {
    res.status(400).json({ error: "Agent NOT connected to MQTT Broker." });
    return;
  }
  const { eventType, description } = req.body;
  const eventPayload = {
    messageId: uuidv4(),
    sessionId: config.device.session_id,
    deviceId: config.device.device_id,
    type: "event",
    timestamp: new Date().toISOString(),
    eventType: eventType || "obstacle_detected",
    description: description || "前方障碍物",
    latitude: 39.9042,
    longitude: 116.4074,
    severity: 2,
    source: "camera"
  };

  client.publish(getTopic("event"), JSON.stringify(eventPayload), { qos: 1 }, (err) => {
    if (err) {
      addLog("ERROR", `❌ 事件发送失败: ${err.message}`);
      res.status(500).json({ success: false, error: err.message });
    } else {
      addLog("SUCCESS", `🚀 事件发送成功: ${eventPayload.eventType}`);
      res.json({ success: true, messageId: eventPayload.messageId });
    }
  });
});

const REMOTE_BACKEND_HOST = process.env.REMOTE_BACKEND_HOST || '10.126.18.57';
const REMOTE_BACKEND_PORT = parseInt(process.env.REMOTE_BACKEND_PORT || '8085', 10);

// --- VIDEO AGENT PROXY DEMO ---
app.get("/api/video/local/list", (req, res) => {
  console.log(`[API] 收到前端请求获取视频列表`);
  const options = {
    hostname: REMOTE_BACKEND_HOST,
    port: REMOTE_BACKEND_PORT,
    path: '/api/video/local/list',
    method: 'GET'
  };
  console.log(`[API] 正在向真正的后端 (${options.hostname}:${options.port}) 请求并获取列表...`);

  const proxyReq = http.request(options, (proxyRes) => {
    let rawData = '';
    
    console.log(`[API] 后端响应状态码: ${proxyRes.statusCode}`);
    
    proxyRes.setEncoding('utf8');
    proxyRes.on('data', (chunk) => { rawData += chunk; });
    proxyRes.on('end', () => {
      try {
        console.log(`[API] 接收到后端响应数据: ${rawData}`);
        const parsedData = JSON.parse(rawData);
        console.log(`[API] 成功解析后端视频列表, 代理发送给前端`);
        res.json(parsedData);
      } catch (e: any) {
        console.error("[API] 解析视频列表出错:", e.message, "获取到的报文:", rawData);
        res.status(500).json({ code: 500, message: "解析视频列表出错", error: e.message });
      }
    });
  });

  proxyReq.on('error', (e: any) => {
    console.log(`[API] Not using remote backend, falling back to mock data (${e.message})`);
    // res.status(500).json({ code: 500, message: "获取后端视频列表失败", error: e.message });
    // FALLBACK TO MOCK DATA for local testing
    res.json({
      code: 200,
      message: "Success (Mock Data)",
      data: [
        {
          fileName: "mock_video_1.mp4",
          fileSize: 1024 * 1024 * 5,
          downloadUrl: "https://www.w3schools.com/html/mov_bbb.mp4",
          lastModified: new Date().toISOString()
        },
        {
          fileName: "mock_video_2.mp4",
          fileSize: 1024 * 1024 * 10,
          downloadUrl: "https://www.w3schools.com/html/mov_bbb.mp4",
          lastModified: new Date().toISOString()
        }
      ]
    });
  });

  proxyReq.setTimeout(5000, () => {
    console.log("[API] 请求后端视频列表超时, will fallback to mock.");
    proxyReq.destroy();
  });

  proxyReq.end();
});

app.get("/api/video/local/download/:fileName", (req, res) => {
  const fileName = encodeURIComponent(req.params.fileName);
  console.log(`[API] 收到前端请求下载视频: ${req.params.fileName}`);
  const options = {
    hostname: REMOTE_BACKEND_HOST,
    port: REMOTE_BACKEND_PORT,
    path: `/api/video/local/download/${fileName}`,
    method: 'GET',
    headers: { ...req.headers }
  };
  
  options.headers['host'] = `${REMOTE_BACKEND_HOST}:${REMOTE_BACKEND_PORT}`;
  console.log(`[API] 正在向真正后端代理视频流: GET ${options.path}`);

  const proxyReq = http.request(options, (proxyRes) => {
    console.log(`[API] 视频流响应状态码: ${proxyRes.statusCode}`);
    res.writeHead(proxyRes.statusCode || 200, proxyRes.headers);
    proxyRes.pipe(res, { end: true });
    
    proxyRes.on('end', () => {
      console.log(`[API] 视频流传输完成: ${req.params.fileName}`);
    });
  });

  proxyReq.on('error', (e: any) => {
    console.log(`[API] 视频下载代理请求问题: ${e.message}`);
    if (!res.headersSent) {
      res.status(500).send("Proxy error");
    }
  });

  req.pipe(proxyReq, { end: true });
});

// --- LOCAL WINDOWS COLLECTOR PROCESS CONTROL ---
type CollectorPhase = "stopped" | "starting" | "running" | "stopping" | "merging" | "rendering" | "error";
type CollectorKind = "radio" | "network";
type CollectorProcess = { kind: CollectorKind; pythonPid: number; cmdPid: number | null };
type CaptureCsvBaseline = { network: Set<string>; radio: Set<string> };
type LiveCaptureMetrics = {
  sessionId: string;
  index: number | null;
  timestamp: string;
  avg_rtt_ms: number | null;
  jitter_ms: number | null;
  throughput_bps: number | null;
  loss_rate: number | null;
  gcj02_latitude: number | null;
  gcj02_longitude: number | null;
};
type LivePosition = { latitude: number; longitude: number; updatedAt: string };

let activeCaptureCsvBaseline: CaptureCsvBaseline | null = null;
let liveCaptureMetrics: LiveCaptureMetrics | null = null;
let latestValidPosition: LivePosition | null = null;
let activeMetricsCsvFile: string | null = null;
let metricsCsvOffset = 0;
let metricsCsvBuffer = "";
let metricsCsvHeader: string[] | null = null;

const collectorControl = {
  phase: "stopped" as CollectorPhase,
  message: "采集未启动",
  error: null as string | null,
  processes: [] as CollectorProcess[],
  latestCsv: null as { source: string; file: string; path: string; mergedAt: string } | null,
  latestVideo: null as { file: string; path: string; renderedAt: string } | null,
  updatedAt: new Date().toISOString()
};

const updateCollectorControl = (
  phase: CollectorPhase,
  message: string,
  error: string | null = null,
  processes: CollectorProcess[] = collectorControl.processes
) => {
  collectorControl.phase = phase;
  collectorControl.message = message;
  collectorControl.error = error;
  collectorControl.processes = processes;
  collectorControl.updatedAt = new Date().toISOString();
};

const isLocalRequest = (req: express.Request) => {
  const ip = req.ip || req.socket.remoteAddress || "";
  return ip === "127.0.0.1" || ip === "::1" || ip === "::ffff:127.0.0.1";
};

const requireLocalCollectorControl = (
  req: express.Request,
  res: express.Response,
  next: express.NextFunction
) => {
  if (!isLocalRequest(req)) {
    res.status(403).json({ error: "采集进程只能从本机控制" });
    return;
  }
  next();
};

const CAMERA_PREVIEW_HOST = "127.0.0.1";
const CAMERA_PREVIEW_PORT = 8765;

app.get("/api/local/camera/health", requireLocalCollectorControl, (_req, res) => {
  const healthRequest = http.request(
    {
      hostname: CAMERA_PREVIEW_HOST,
      port: CAMERA_PREVIEW_PORT,
      path: "/health",
      method: "GET"
    },
    healthResponse => {
      let body = "";
      healthResponse.setEncoding("utf8");
      healthResponse.on("data", chunk => { body += chunk; });
      healthResponse.on("end", () => {
        if (healthResponse.statusCode !== 200) {
          res.status(503).json({ ready: false });
          return;
        }
        try {
          res.json(JSON.parse(body));
        } catch {
          res.status(503).json({ ready: false });
        }
      });
    }
  );
  healthRequest.setTimeout(1000, () => healthRequest.destroy(new Error("摄像头状态检查超时")));
  healthRequest.on("error", () => {
    if (!res.headersSent) res.status(503).json({ ready: false });
  });
  healthRequest.end();
});

app.get("/api/local/camera/stream", requireLocalCollectorControl, (_req, res) => {
  const previewRequest = http.request(
    {
      hostname: CAMERA_PREVIEW_HOST,
      port: CAMERA_PREVIEW_PORT,
      path: "/stream.mjpg",
      method: "GET"
    },
    previewResponse => {
      if (previewResponse.statusCode !== 200) {
        previewResponse.resume();
        if (!res.headersSent) res.status(503).send("摄像头预览尚未就绪");
        return;
      }
      res.writeHead(200, {
        "Content-Type": previewResponse.headers["content-type"] || "multipart/x-mixed-replace; boundary=frame",
        "Cache-Control": "no-store, no-cache, must-revalidate",
        "Pragma": "no-cache",
        "X-Accel-Buffering": "no",
        "Connection": "close"
      });
      previewResponse.pipe(res);
      res.on("close", () => previewResponse.destroy());
    }
  );
  previewRequest.setTimeout(3000, () => previewRequest.destroy(new Error("摄像头预览连接超时")));
  previewRequest.on("error", error => {
    if (!res.headersSent) {
      res.status(503).json({ error: error.message });
    } else {
      res.end();
    }
  });
  previewRequest.end();
});

const runPowerShell = (script: string) => new Promise<string>((resolve, reject) => {
  execFile(
    "powershell.exe",
    ["-NoProfile", "-NonInteractive", "-ExecutionPolicy", "Bypass", "-Command", script],
    { windowsHide: true, maxBuffer: 1024 * 1024 },
    (error, stdout, stderr) => {
      if (error) {
        reject(new Error((stderr || error.message).trim()));
        return;
      }
      resolve(stdout.trim());
    }
  );
});

const discoverCollectorProcesses = async (): Promise<CollectorProcess[]> => {
  if (process.platform !== "win32") return [];
  const output = await runPowerShell(`
$allProcesses = @(Get-CimInstance Win32_Process)
$items = $allProcesses | Where-Object {
  $_.Name -match '^python(w)?\\.exe$' -and (
    $_.CommandLine -like '*-m radio_capture.cli*' -or
    $_.CommandLine -like '*-m packet_collector.orchestration.configured_capture*'
  )
} | ForEach-Object {
  $pythonProcess = $_
  $parent = $allProcesses | Where-Object { $_.ProcessId -eq $pythonProcess.ParentProcessId } | Select-Object -First 1
  $kind = if ($pythonProcess.CommandLine -like '*-m radio_capture.cli*') { 'radio' } else { 'network' }
  [PSCustomObject]@{
    kind = $kind
    pythonPid = [int]$pythonProcess.ProcessId
    cmdPid = if ($null -ne $parent -and $parent.Name -eq 'cmd.exe') { [int]$parent.ProcessId } else { $null }
  }
}
ConvertTo-Json -InputObject @($items) -Compress
  `);
  if (!output) return [];
  const parsed = JSON.parse(output);
  return (Array.isArray(parsed) ? parsed : [parsed]).filter((item: any) =>
    (item.kind === "radio" || item.kind === "network") &&
    Number.isInteger(item.pythonPid) && (item.cmdPid === null || Number.isInteger(item.cmdPid))
  );
};

const collectorStatusPayload = () => ({
  phase: collectorControl.phase,
  message: collectorControl.message,
  error: collectorControl.error,
  updatedAt: collectorControl.updatedAt,
  latestCsv: collectorControl.latestCsv,
  latestVideo: collectorControl.latestVideo,
  collectors: {
    radio: collectorControl.processes.some(p => p.kind === "radio"),
    network: collectorControl.processes.some(p => p.kind === "network")
  }
});

const delay = (ms: number) => new Promise(resolve => setTimeout(resolve, ms));

const collectorBatCandidates = [
  process.env.COLLECTORS_START_BAT,
  path.resolve(process.cwd(), "../start_all_collectors.bat"),
  path.resolve(process.cwd(), "../../start_all_collectors.bat"),
  path.resolve(__dirname, "../../start_all_collectors.bat"),
  path.resolve(__dirname, "../../../start_all_collectors.bat")
].filter((candidate): candidate is string => Boolean(candidate));

const findCollectorBat = () => collectorBatCandidates.find(candidate => fs.existsSync(candidate));

const listSessionCsvFiles = (root: string, filename: string) => {
  if (!fs.existsSync(root)) return [];
  return fs.readdirSync(root, { withFileTypes: true })
    .filter(entry => entry.isDirectory() && entry.name.startsWith("session_"))
    .map(entry => path.join(root, entry.name, filename))
    .filter(candidate => fs.existsSync(candidate));
};

const getCaptureCsvLocations = () => {
  const startBat = findCollectorBat();
  if (!startBat) throw new Error("找不到 start_all_collectors.bat");
  const workspaceDir = path.dirname(startBat);
  return {
    networkRoot: path.join(workspaceDir, "packet_collector", "captures"),
    radioRoot: path.join(workspaceDir, "radio_capture", "BJTUCC-main", "captures"),
    mergeBat: path.join(workspaceDir, "merge_capture_csv.bat")
  };
};

const resetLiveCaptureFeed = () => {
  liveCaptureMetrics = null;
  latestValidPosition = null;
  activeMetricsCsvFile = null;
  metricsCsvOffset = 0;
  metricsCsvBuffer = "";
  metricsCsvHeader = null;
};

const optionalCsvNumber = (value: string | undefined) => {
  if (!value?.trim()) return null;
  const parsed = Number.parseFloat(value);
  return Number.isFinite(parsed) ? parsed : null;
};

const pollLiveCaptureMetrics = () => {
  if (!["starting", "running", "stopping", "merging", "rendering"].includes(collectorControl.phase)) return;
  try {
    if (!activeMetricsCsvFile || !fs.existsSync(activeMetricsCsvFile)) {
      const locations = getCaptureCsvLocations();
      const allFiles = listSessionCsvFiles(locations.networkRoot, "window_metrics_gps.csv");
      const currentRunFiles = activeCaptureCsvBaseline
        ? allFiles.filter(candidate => !activeCaptureCsvBaseline!.network.has(candidate))
        : allFiles;
      activeMetricsCsvFile = newestFile(currentRunFiles);
      metricsCsvOffset = 0;
      metricsCsvBuffer = "";
      metricsCsvHeader = null;
    }
    if (!activeMetricsCsvFile) return;

    const content = fs.readFileSync(activeMetricsCsvFile, "utf-8");
    if (content.length < metricsCsvOffset) {
      metricsCsvOffset = 0;
      metricsCsvBuffer = "";
      metricsCsvHeader = null;
    }
    if (content.length === metricsCsvOffset) return;
    metricsCsvBuffer += content.slice(metricsCsvOffset);
    metricsCsvOffset = content.length;
    const lines = metricsCsvBuffer.split(/\r?\n/);
    metricsCsvBuffer = lines.pop() || "";

    for (const rawLine of lines) {
      if (!rawLine.trim()) continue;
      if (!metricsCsvHeader) {
        metricsCsvHeader = parseCsvLine(rawLine).map((name, index) =>
          index === 0 ? name.replace(/^\uFEFF/, "") : name
        );
        continue;
      }
      const values = parseCsvLine(rawLine);
      const value = (name: string) => values[metricsCsvHeader!.indexOf(name)];
      const latitude = optionalCsvNumber(value("gcj02_latitude"));
      const longitude = optionalCsvNumber(value("gcj02_longitude"));
      liveCaptureMetrics = {
        sessionId: path.basename(path.dirname(activeMetricsCsvFile)),
        index: optionalCsvNumber(value("index")),
        timestamp: value("timestamp")?.trim() || "",
        avg_rtt_ms: optionalCsvNumber(value("avg_rtt_ms")),
        jitter_ms: optionalCsvNumber(value("jitter_ms")),
        throughput_bps: optionalCsvNumber(value("throughput_bps")),
        loss_rate: optionalCsvNumber(value("loss_rate")),
        gcj02_latitude: latitude,
        gcj02_longitude: longitude
      };
      if (
        latitude !== null && longitude !== null &&
        Math.abs(latitude) <= 90 && Math.abs(longitude) <= 180
      ) {
        latestValidPosition = {
          latitude,
          longitude,
          updatedAt: liveCaptureMetrics.timestamp
        };
        gpsState.latitude = latitude;
        gpsState.longitude = longitude;
      }
    }
  } catch (error: any) {
    addLog("WARN", `读取网络侧实时解析数据失败: ${error.message || error}`);
  }
};

setInterval(pollLiveCaptureMetrics, 500);

const snapshotCaptureCsvFiles = (): CaptureCsvBaseline => {
  const locations = getCaptureCsvLocations();
  return {
    network: new Set(listSessionCsvFiles(locations.networkRoot, "window_metrics_gps.csv")),
    radio: new Set(listSessionCsvFiles(locations.radioRoot, "dm_metrics.csv"))
  };
};

const newestFile = (files: string[]) => {
  if (files.length === 0) return null;
  return files.reduce((latest, candidate) =>
    fs.statSync(candidate).mtimeMs > fs.statSync(latest).mtimeMs ? candidate : latest
  );
};

const resolveCaptureCsvInputs = (baseline: CaptureCsvBaseline | null) => {
  const locations = getCaptureCsvLocations();
  const allNetwork = listSessionCsvFiles(locations.networkRoot, "window_metrics_gps.csv");
  const allRadio = listSessionCsvFiles(locations.radioRoot, "dm_metrics.csv");
  const networkCandidates = baseline
    ? allNetwork.filter(candidate => !baseline.network.has(candidate))
    : allNetwork;
  const radioCandidates = baseline
    ? allRadio.filter(candidate => !baseline.radio.has(candidate))
    : allRadio;
  const networkCsv = newestFile(networkCandidates);
  const radioCsv = newestFile(radioCandidates);
  if (!networkCsv || !radioCsv) {
    throw new Error("找不到本轮采集生成的网络侧或无线侧 CSV");
  }
  if (!fs.existsSync(locations.mergeBat)) {
    throw new Error("找不到 merge_capture_csv.bat");
  }
  return { networkCsv, radioCsv, mergeBat: locations.mergeBat };
};

const runCaptureCsvMerge = (
  mergeBat: string,
  networkCsv: string,
  radioCsv: string
) => new Promise<{ output: string; displayFullCsv: string | null }>((resolve, reject) => {
  execFile(
    "cmd.exe",
    ["/d", "/c", "call", mergeBat, networkCsv, radioCsv],
    {
      cwd: path.dirname(mergeBat),
      windowsHide: true,
      timeout: 30 * 60 * 1000,
      maxBuffer: 10 * 1024 * 1024
    },
    (error, stdout, stderr) => {
      const output = [stdout, stderr].filter(Boolean).join("\n").trim();
      if (error) {
        reject(new Error(output || error.message));
        return;
      }
      const mergedRows = output.match(/Merged intersection rows:\s*(\d+)/i);
      if (mergedRows && Number(mergedRows[1]) === 0) {
        reject(new Error("两份 CSV 没有可按时间对齐的数据，请检查采集时间"));
        return;
      }
      const displayFullCsv = output.match(/^Display full CSV:\s*(.+)$/mi)?.[1]?.trim() || null;
      resolve({ output, displayFullCsv });
    }
  );
});

const renderCaptureMetricsVideo = (networkCsv: string) => new Promise<{ output: string; video: string }>((resolve, reject) => {
  const startBat = findCollectorBat();
  if (!startBat) {
    reject(new Error("找不到 start_all_collectors.bat"));
    return;
  }
  const workspaceDir = path.dirname(startBat);
  const networkProject = path.join(workspaceDir, "packet_collector");
  const python = path.join(workspaceDir, "zqy", "Scripts", "python.exe");
  const script = path.join(networkProject, "video", "overlay_network_metrics.py");
  const sessionDir = path.dirname(networkCsv);
  const inputVideo = path.join(sessionDir, "camera_recording.mp4");
  const frameTimestamps = path.join(sessionDir, "camera_frame_timestamps.csv");
  const outputVideo = path.join(sessionDir, "camera_recording_metrics.mp4");
  for (const requiredPath of [python, script, inputVideo, frameTimestamps, networkCsv]) {
    if (!fs.existsSync(requiredPath)) {
      reject(new Error(`生成指标录像所需文件不存在: ${requiredPath}`));
      return;
    }
  }
  execFile(
    python,
    [
      script,
      "--video", inputVideo,
      "--frame-timestamps", frameTimestamps,
      "--network-csv", networkCsv,
      "--output", outputVideo
    ],
    {
      cwd: networkProject,
      windowsHide: true,
      timeout: 30 * 60 * 1000,
      maxBuffer: 10 * 1024 * 1024
    },
    (error, stdout, stderr) => {
      const output = [stdout, stderr].filter(Boolean).join("\n").trim();
      if (error) {
        reject(new Error(output || error.message));
        return;
      }
      if (!fs.existsSync(outputVideo)) {
        reject(new Error("指标录像处理已结束，但没有生成输出文件"));
        return;
      }
      resolve({ output, video: outputVideo });
    }
  );
});

const getCollectorControlDir = () => {
  const batPath = findCollectorBat();
  if (!batPath) throw new Error("找不到 start_all_collectors.bat");
  return path.join(path.dirname(batPath), ".collector-control");
};

const spawnHiddenCollector = (
  executable: string,
  args: string[],
  cwd: string,
  logFile: string,
  env: NodeJS.ProcessEnv
) => new Promise<number>((resolve, reject) => {
  const logFd = fs.openSync(logFile, "a");
  let logClosed = false;
  const closeLogFd = () => {
    if (logClosed) return;
    logClosed = true;
    fs.closeSync(logFd);
  };
  const child = spawn(executable, args, {
    cwd,
    env,
    windowsHide: true,
    stdio: ["ignore", logFd, logFd]
  });
  child.once("error", error => {
    closeLogFd();
    reject(error);
  });
  child.once("spawn", () => {
    closeLogFd();
    child.unref();
    if (!child.pid) {
      reject(new Error(`无法启动 ${path.basename(executable)}`));
      return;
    }
    resolve(child.pid);
  });
});

const launchCollectors = async () => {
  try {
    if (process.platform !== "win32") {
      throw new Error("采集启动仅支持 Windows");
    }
    const startBatPath = findCollectorBat();
    if (!startBatPath) {
      throw new Error("找不到 start_all_collectors.bat");
    }
    const workspaceDir = path.dirname(startBatPath);
    const controlDir = path.join(workspaceDir, ".collector-control");
    const stopFile = path.join(controlDir, "stop.request");
    const radioPython = path.join(workspaceDir, "radio_capture", "BJTUCC-main", ".venv32", "Scripts", "python.exe");
    const networkPython = path.join(workspaceDir, "zqy", "Scripts", "python.exe");
    const radioCwd = path.join(workspaceDir, "radio_capture", "BJTUCC-main");
    const networkCwd = path.join(workspaceDir, "packet_collector");
    for (const requiredPath of [radioPython, networkPython, radioCwd, networkCwd]) {
      if (!fs.existsSync(requiredPath)) throw new Error(`采集程序路径不存在: ${requiredPath}`);
    }
    fs.mkdirSync(controlDir, { recursive: true });
    const logsDir = path.join(controlDir, "logs");
    fs.mkdirSync(logsDir, { recursive: true });
    for (const controlFile of [
      stopFile,
      path.join(controlDir, "radio.stopping"),
      path.join(controlDir, "network.stopping")
    ]) {
      try { fs.unlinkSync(controlFile); } catch (error: any) {
        if (error?.code !== "ENOENT") throw error;
      }
    }
    const collectorEnv: NodeJS.ProcessEnv = {
      ...process.env,
      PYTHONUNBUFFERED: "1",
      COLLECTOR_CONTROL_DIR: controlDir,
      COLLECTOR_STOP_FILE: stopFile
    };
    await Promise.all([
      spawnHiddenCollector(
        radioPython,
        ["-m", "radio_capture.cli", "--config", "configs\\config.json"],
        radioCwd,
        path.join(logsDir, "radio.log"),
        collectorEnv
      ),
      spawnHiddenCollector(
        networkPython,
        ["-m", "packet_collector.orchestration.configured_capture", "--config", "config.json"],
        networkCwd,
        path.join(logsDir, "network.log"),
        collectorEnv
      )
    ]);

    const deadline = Date.now() + 20000;
    while (Date.now() < deadline) {
      const processes = await discoverCollectorProcesses();
      const radio = processes.find(p => p.kind === "radio");
      const network = processes.find(p => p.kind === "network");
      if (radio && network) {
        updateCollectorControl("running", "两个采集器均已启动", null, [radio, network]);
        addLog("SUCCESS", "采集器已启动：无线侧、网络侧");
        return;
      }
      await delay(500);
    }
    const partial = await discoverCollectorProcesses();
    throw new Error(
      partial.length > 0
        ? "仅部分采集器启动成功，请检查采集日志"
        : "采集器启动超时，请检查 Python 环境和配置"
    );
  } catch (error: any) {
    activeCaptureCsvBaseline = null;
    updateCollectorControl("error", "采集启动失败", error.message || String(error));
    addLog("ERROR", `采集器启动失败: ${error.message || error}`);
  }
};

const processIsRunning = (pid: number) => {
  try {
    process.kill(pid, 0);
    return true;
  } catch {
    return false;
  }
};

const sendConsoleCtrlC = (cmdPid: number) => new Promise<void>((resolve, reject) => {
  const helperCandidates = [
    path.resolve(__dirname, "scripts/send-console-ctrl-c.ps1"),
    path.resolve(__dirname, "../scripts/send-console-ctrl-c.ps1")
  ];
  const helperPath = helperCandidates.find(candidate => fs.existsSync(candidate));
  if (!helperPath) {
    reject(new Error("找不到 Windows 控制台中断辅助脚本"));
    return;
  }
  execFile(
    "powershell.exe",
    ["-NoProfile", "-NonInteractive", "-ExecutionPolicy", "Bypass", "-File", helperPath, "-ProcessId", String(cmdPid)],
    { windowsHide: true, timeout: 10000 },
    (error, _stdout, stderr) => {
      if (error) {
        reject(new Error((stderr || error.message).trim()));
        return;
      }
      resolve();
    }
  );
});

const closeCommandWindow = (cmdPid: number) => new Promise<void>((resolve) => {
  if (!processIsRunning(cmdPid)) {
    resolve();
    return;
  }
  execFile("taskkill.exe", ["/PID", String(cmdPid), "/F"], { windowsHide: true }, () => resolve());
});

const stopCollectorsGracefully = async (processes: CollectorProcess[]) => {
  try {
    const controlDir = getCollectorControlDir();
    fs.mkdirSync(controlDir, { recursive: true });
    const stopFile = path.join(controlDir, "stop.request");
    const ackFiles: Record<CollectorKind, string> = {
      radio: path.join(controlDir, "radio.stopping"),
      network: path.join(controlDir, "network.stopping")
    };
    for (const ackFile of Object.values(ackFiles)) {
      try { fs.unlinkSync(ackFile); } catch (error: any) {
        if (error?.code !== "ENOENT") throw error;
      }
    }
    fs.writeFileSync(stopFile, new Date().toISOString(), "utf-8");

    // New collector entry points acknowledge the stop file before following
    // their normal KeyboardInterrupt cleanup path. Older processes fall back
    // to one console Ctrl+C event after a short acknowledgement window.
    const ackDeadline = Date.now() + 2500;
    while (Date.now() < ackDeadline) {
      const allAcknowledged = processes.every(item =>
        !processIsRunning(item.pythonPid) || fs.existsSync(ackFiles[item.kind])
      );
      if (allAcknowledged) break;
      await delay(100);
    }
    const fallbackCmdPids = [...new Set(
      processes
        .filter(item => processIsRunning(item.pythonPid) && !fs.existsSync(ackFiles[item.kind]) && item.cmdPid !== null)
        .map(item => item.cmdPid as number)
    )];
    const unacknowledgedHiddenProcesses = processes.filter(item =>
      processIsRunning(item.pythonPid) &&
      !fs.existsSync(ackFiles[item.kind]) &&
      item.cmdPid === null
    );
    if (unacknowledgedHiddenProcesses.length > 0) {
      throw new Error("一个或多个隐藏采集进程未响应停止请求，请检查采集日志");
    }
    const signals = await Promise.allSettled(fallbackCmdPids.map(sendConsoleCtrlC));
    const failedSignals = signals.filter(result => result.status === "rejected");
    if (failedSignals.length > 0) {
      const stillRunning = processes.filter(item => processIsRunning(item.pythonPid));
      if (stillRunning.length > 0) {
        throw new Error("无法向一个或多个采集窗口发送 Ctrl+C");
      }
    }

    const pending = new Map(processes.map(item => [item.pythonPid, item]));
    const deadline = Date.now() + 30 * 60 * 1000;
    while (pending.size > 0 && Date.now() < deadline) {
      for (const [pythonPid, item] of pending) {
        if (!processIsRunning(pythonPid)) {
          if (item.cmdPid !== null) await closeCommandWindow(item.cmdPid);
          pending.delete(pythonPid);
        }
      }
      if (pending.size > 0) {
        const waitingForNetwork = [...pending.values()].some(item => item.kind === "network");
        updateCollectorControl(
          "stopping",
          waitingForNetwork ? "正在停止采集并等待网络侧分析完成..." : "正在等待采集器完成清理...",
          null,
          processes
        );
        await delay(1000);
      }
    }

    if (pending.size > 0) {
      throw new Error("等待采集器正常退出超时，请检查采集日志");
    }
    for (const controlFile of [stopFile, ...Object.values(ackFiles)]) {
      try { fs.unlinkSync(controlFile); } catch (error: any) {
        if (error?.code !== "ENOENT") addLog("WARN", `清理采集控制文件失败: ${error.message}`);
      }
    }
    addLog("SUCCESS", "两个隐藏采集进程已正常退出");
    updateCollectorControl("merging", "采集进程已退出，等待融合 CSV...", null, []);
    await delay(1000);
    updateCollectorControl("merging", "正在融合网络侧与无线侧 CSV...", null, []);
    const mergeInputs = resolveCaptureCsvInputs(activeCaptureCsvBaseline);
    const mergeResult = await runCaptureCsvMerge(
      mergeInputs.mergeBat,
      mergeInputs.networkCsv,
      mergeInputs.radioCsv
    );
    if (!mergeResult.displayFullCsv) {
      throw new Error("CSV 已融合，但没有找到发布到数据源目录的完整文件");
    }
    collectorControl.latestCsv = {
      source: path.basename(path.dirname(mergeResult.displayFullCsv)),
      file: path.basename(mergeResult.displayFullCsv),
      path: mergeResult.displayFullCsv,
      mergedAt: new Date().toISOString()
    };
    updateCollectorControl("rendering", "CSV 融合完成，正在生成指标录像...", null, []);
    const videoResult = await renderCaptureMetricsVideo(mergeInputs.networkCsv);
    collectorControl.latestVideo = {
      file: path.basename(videoResult.video),
      path: videoResult.video,
      renderedAt: new Date().toISOString()
    };
    activeCaptureCsvBaseline = null;
    updateCollectorControl("stopped", "采集已停止，CSV 与指标录像均已生成", null, []);
    addLog("SUCCESS", `指标录像已生成: ${videoResult.video}`);
    if (mergeResult.output) console.log(`[COLLECTOR MERGE]\n${mergeResult.output}`);
    if (videoResult.output) console.log(`[METRICS VIDEO]\n${videoResult.output}`);
  } catch (error: any) {
    const remaining = processes.filter(item => processIsRunning(item.pythonPid));
    const failedDuringMerge = remaining.length === 0 && collectorControl.phase === "merging";
    const failedDuringRendering = remaining.length === 0 && collectorControl.phase === "rendering";
    activeCaptureCsvBaseline = null;
    updateCollectorControl(
      "error",
      failedDuringRendering
        ? "CSV 融合完成，但指标录像生成失败"
        : failedDuringMerge
          ? "采集已停止，但 CSV 融合失败"
          : "停止采集时发生错误",
      error.message || String(error),
      remaining
    );
    addLog("ERROR", `${failedDuringRendering ? "指标录像生成失败" : failedDuringMerge ? "CSV 融合失败" : "停止采集失败"}: ${error.message || error}`);
  }
};

app.get("/api/local/collectors/status", requireLocalCollectorControl, async (_req, res) => {
  try {
    if (collectorControl.phase === "stopped" || collectorControl.phase === "running" || collectorControl.phase === "error") {
      const processes = await discoverCollectorProcesses();
      const radio = processes.find(item => item.kind === "radio");
      const network = processes.find(item => item.kind === "network");
      if (radio && network) {
        updateCollectorControl("running", "两个采集器均在运行", null, [radio, network]);
      } else if (processes.length === 0 && collectorControl.phase === "running") {
        updateCollectorControl("stopped", "采集程序已退出", null, []);
      } else if (processes.length > 0) {
        updateCollectorControl("error", "检测到部分采集器仍在运行", "请检查采集终端", processes);
      }
    }
    res.json(collectorStatusPayload());
  } catch (error: any) {
    res.status(500).json({ ...collectorStatusPayload(), error: error.message || String(error) });
  }
});

app.post("/api/local/collectors/start", requireLocalCollectorControl, async (_req, res) => {
  if (["starting", "stopping", "merging", "rendering"].includes(collectorControl.phase)) {
    res.status(409).json(collectorStatusPayload());
    return;
  }
  try {
    const existing = await discoverCollectorProcesses();
    if (existing.length > 0) {
      const radio = existing.find(item => item.kind === "radio");
      const network = existing.find(item => item.kind === "network");
      updateCollectorControl(
        radio && network ? "running" : "error",
        radio && network ? "采集器已经在运行" : "检测到部分采集器已经在运行",
        radio && network ? null : "请先处理已有采集进程",
        existing
      );
      res.status(radio && network ? 200 : 409).json(collectorStatusPayload());
      return;
    }
    resetLiveCaptureFeed();
    activeCaptureCsvBaseline = snapshotCaptureCsvFiles();
    updateCollectorControl("starting", "正在启动两个采集器...", null, []);
    res.status(202).json(collectorStatusPayload());
    void launchCollectors();
  } catch (error: any) {
    updateCollectorControl("error", "无法检查采集器状态", error.message || String(error));
    res.status(500).json(collectorStatusPayload());
  }
});

app.post("/api/local/collectors/stop", requireLocalCollectorControl, async (_req, res) => {
  if (["starting", "stopping", "merging", "rendering"].includes(collectorControl.phase)) {
    res.status(409).json(collectorStatusPayload());
    return;
  }
  try {
    const processes = await discoverCollectorProcesses();
    if (processes.length === 0) {
      updateCollectorControl("stopped", "采集未启动", null, []);
      res.json(collectorStatusPayload());
      return;
    }
    updateCollectorControl("stopping", "正在发送停止信号...", null, processes);
    res.status(202).json(collectorStatusPayload());
    void stopCollectorsGracefully(processes);
  } catch (error: any) {
    updateCollectorControl("error", "无法停止采集器", error.message || String(error));
    res.status(500).json(collectorStatusPayload());
  }
});

import { WebSocketServer } from 'ws';

const API_PORT = process.env.NODE_ENV === 'production' ? 3000 : 5000;
const server = http.createServer(app);

// Serve static frontend files in production
if (process.env.NODE_ENV === 'production') {
  const candidatePaths = [
    path.resolve(__dirname, '../../frontend/dist'),
    path.resolve(__dirname, '../frontend/dist'),
    path.resolve(process.cwd(), 'frontend/dist'),
    path.resolve(process.cwd(), '../frontend/dist')
  ];
  const frontendDistPath = candidatePaths.find(p => fs.existsSync(p)) || candidatePaths[0];
  app.use(express.static(frontendDistPath));
  app.get('*', (req, res) => {
    res.sendFile(path.join(frontendDistPath, 'index.html'));
  });
}

const wss = new WebSocketServer({ server, path: '/ws/location' });

wss.on('connection', (ws) => {
  console.log('[API] Frontend connected to /ws/location');
  let lastMetricsKey = "";

  // Publish each newly persisted network-analysis row once.
  const interval = setInterval(() => {
    if (ws.readyState !== ws.OPEN || !liveCaptureMetrics) return;
    const metricsKey = `${liveCaptureMetrics.sessionId}:${liveCaptureMetrics.index}:${liveCaptureMetrics.timestamp}`;
    if (metricsKey === lastMetricsKey) return;
    lastMetricsKey = metricsKey;
    ws.send(JSON.stringify({
      type: "capture_metrics",
      ...liveCaptureMetrics,
      position: latestValidPosition
    }));
  }, 250);

  ws.on('close', () => {
    clearInterval(interval);
    console.log('[API] Frontend /ws/location disconnected');
  });
});

server.listen(API_PORT, "0.0.0.0", () => {
  addLog("SUCCESS", `✨ RPi Local Service API + WS 监听在 http://localhost:${API_PORT}`);
  addLog("INFO", `供本地前端 (IPC / HTTP / WS) 通信使用`);
});
