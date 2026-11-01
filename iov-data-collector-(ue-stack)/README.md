# 车联网智能诊断与边缘代理平台 (IoV Workspace)

本项目是一个集成车载/边缘节点协议仿真、业务遥测数据可视化监控以及实时控制台的诊断监控系统。平台采用 Workspace Monorepo 统一管理的 React 前端与 Node.js 后端全栈隔离、打包融合架构。

采集程序完成或中断 session 后，可以将展示副本发布到：

```text
datas/BJTU/       完整 CSV，用于任意起止时间查询
datas/BJTU_1min/  按采集起始时间每 60 秒切分的 CSV
```

完整文件和一分钟分片必须使用不同数据源目录，避免前端全选文件时重复
统计相同记录。新增 CSV 不需要重新构建前端，刷新数据源列表即可读取。

## 1. 系统架构

- **全栈 Workspace (`/package.json`)**: 包含 `frontend` 与 `backend`，通过 npm scripts 统一管理依赖和构建流程。
- **前端模块 (`frontend/`)**: 基于 React + Vite 构建的静态单页应用。通过可视化面板和内置高德地图进行实时 GNSS 跟踪、通信状态监控(RSRP/SINR 等)以及日志聚合。
- **后端进程 (`backend/`)**: 基于 Node.js + Express + MQTT 构建的仿真车机端代理程序 (`rpi-agent`)。向中心云或网关推送 telemetry 遥测数据、上传拨测测速，同时提供针对第三方服务的资源透传代理并暴露 WebSocket (`/ws/location`) 给前端页面进行实时推送。在 `NODE_ENV=production` 模式下，后端服务会自动承载前端编译好的静态页面，无需额外配置 Web 服务器托管。

## 2. 部署方案指南 (快速环境搭建)

由于架构已升级，您现在可以直接使用纯 Node.js 环境（配合 PM2 进程守护）一键拉起包括前后端在内的整个系统平台。建议服务器系统版本：**Ubuntu 22.04 LTS 或 24.04 LTS**。

### 2.1 依赖安装与前置组件

首先，确保您的操作系统上已经安装了 Node.js（推荐使用 Node.js LTS 20.x，并附带 npm）。

```bash
# 1. 配置并安装 Node.js LTS 仓库及运行时环境
curl -fsSL https://deb.nodesource.com/setup_lts.x | sudo -E bash -
sudo apt install -y nodejs git

# 2. 从 Github 或者 Gitlab 仓库拉取本项目源码
git clone <repository_url> iov-workspace
cd iov-workspace

# 3. 安装针对前端和后端依赖的所有工程模块包
#（注：根级会利用 postinstall 自动进入子模块执行 install，无需手动分别处理）
npm install

# 4. 全局安装后端服务守护管理器 PM2
sudo npm install -g pm2
```

### 2.2 配置核心环境变量

系统依赖根目录或对应环境提供关键变量，包含与通信基座、视频下载主机的相关连接密钥配置。请拷贝模板。

```bash
cp .env.example .env
```

您可以使用 `vim .env` 编辑器写入或修改配置参数：

```env
# ==== [Backend] 视频代理拉取的目标宿主机配置 ====
REMOTE_BACKEND_HOST="10.126.18.57"
REMOTE_BACKEND_PORT="8085"

# ==== [Backend] MQTT 车队云平台/Broker节点配置 ====
MQTT_BROKER_URL="mqtt://broker.emqx.io:1883"
MQTT_DEVICE_ID="VH001"
MQTT_CLIENT_ID="iov-agent-vh001"

# ==== [Frontend] 前端组件配置 ====
# 若采用本机的 PM2 在生产环境跑全栈，前后端同源，可以保持相对路径或不设置；
# 若想支持外部直接独立调试或配置为对应网关，则填入该网关 IP 及映射端口。
# VITE_API_BASE_URL="http://IP:PORT"
```

_(注：前端构建时，Vite 会自动从根项目的同级作用域或子模块级中提取前缀包含了 `VITE_` 的系统环境变量并编译进去)_

### 2.3 工作流全栈打包并上线

此项目无需人工单独切分支执行 `tsc` 或分别拷贝。在项目根目录下通过执行一次 `build` 来统一生成前后端压缩包对象：

```bash
# 同步开启前后端的 Typescript 与 Vite 打包压缩流水线
npm run build
```

应用层生产态会产出如下结构：

1. `backend/dist/server.js` (后端微服务文件)
2. `frontend/dist/*` (包含了 `index.html` 以及压缩静态 js 片段的前端产出物)

### 2.4 利用 PM2 启动生产级服务端

本架构最大的演进特点就是无需单独部署 Nginx，在 `production` 下，Express Server 后端可自带反向挂载服务！

```bash
# 启动 PM2 的内置生产环境注入环境变量
NODE_ENV=production pm2 start npm --name "iov-agent-platform" -- run start

# 保存守护进程列表至系统自启动进程项 (可选)
pm2 startup
pm2 save
```

此时，业务和前端访问节点已经稳定部署完毕。您可以直接通过 `http://<您的服务器IP>:3000/` 进行外网或内网映射访问。

### 2.5 可选进阶部署：映射 80 端口代理 (Nginx)

如遇生产或专网限制使得无法分配 `3000` 端口直接通信，您可以使用 Nginx 进行映射降级并同时保护 Websocket。

```bash
sudo apt install nginx -y
```

向 `/etc/nginx/sites-available/default` 覆盖内容并重启：

```nginx
server {
    listen 80;
    server_name your-domain.com; # 或使用 _

    location / {
        proxy_pass http://127.0.0.1:3000;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
    }

    # 单独对基于 /ws/location 的长连接实施双向桥接升级
    location /ws/ {
        proxy_pass http://127.0.0.1:3000;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection "upgrade";
        proxy_set_header Host $host;
    }
}
```

保存配置后用 `sudo systemctl restart nginx` 激活。访问您的域名或 `80` 端口 IP 即可享受平台。

---

_Generated based on the latest architecture state tracking changes up to current standard iteration._
