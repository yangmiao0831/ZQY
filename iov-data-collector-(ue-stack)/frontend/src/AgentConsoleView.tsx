import React, { useState, useEffect } from "react";
import { Cpu, Activity, Plug, Radio, AlertTriangle, Terminal, Play, Server, ServerCrash } from "lucide-react";
import { cn } from "./lib/utils";


interface AgentState {
  connected: boolean;
  reconnectCount: number;
  publishSuccess: number;
  publishFailed: number;
  latestCommand: any;
  logs: Array<{ ts: string; level: string; message: string }>;
}

interface LocalStatus {
  device: {
    device_id: string;
    session_id: string;
  };
  broker: string;
  state: AgentState;
}

export function AgentConsoleView() {
  const [status, setStatus] = useState<LocalStatus | null>(null);
  const [errorCode, setErrorCode] = useState<string | null>(null);
  const [eventType, setEventType] = useState("manual_test");
  const [eventDesc, setEventDesc] = useState("UI 触发的手动测试报文");
  const [triggerMsg, setTriggerMsg] = useState<{ success: boolean; text: string } | null>(null);

  // poll local agent API
  useEffect(() => {
    let timer = setInterval(async () => {
      try {
        const BASE_URL = import.meta.env.VITE_API_BASE_URL || "";
        const res = await fetch(`${BASE_URL}/api/local/status`);
        if (res.ok) {
          const data = await res.json();
          setStatus(data);
          setErrorCode(null);
        } else {
          setErrorCode("HTTP_ERROR_" + res.status);
        }
      } catch (err: any) {
        setErrorCode(err.message || "NETWORK_ERROR");
      }
    }, 2000);
    return () => clearInterval(timer);
  }, []);

  const triggerEvent = async () => {
    try {
      setTriggerMsg(null);
      const BASE_URL = import.meta.env.VITE_API_BASE_URL || "";
      const res = await fetch(`${BASE_URL}/api/local/event`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ eventType, description: eventDesc })
      });
      if (!res.ok) {
        setTriggerMsg({ success: false, text: "发送失败: HTTP " + res.status });
      } else {
        setTriggerMsg({ success: true, text: "事件报文已成功发送至云端" });
      }
    } catch (e: any) {
      setTriggerMsg({ success: false, text: "发送失败: " + e.message });
    }
  };

  return (
    <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6 p-6 h-full overflow-y-auto w-full font-sans text-gray-200">
      
      {/* 状态监控 */}
      <div className="diag-card rounded-2xl p-6 bg-black/60 border border-white/5 flex flex-col gap-4">
        <h2 className="text-sm font-bold text-gray-500 uppercase flex items-center gap-2 border-b border-white/10 pb-2">
           <Cpu className="w-4 h-4 text-diag-accent" /> 运行状态
        </h2>
        {errorCode ? (
          <div className="flex flex-col items-center justify-center h-40 text-diag-danger opacity-80">
            <ServerCrash className="w-10 h-10 mb-2" />
            <p className="text-sm font-bold uppercase">无法连接到本地服务</p>
            <p className="text-[10px] mt-1">{errorCode}</p>
            <p className="text-[10px] mt-4 text-gray-500">请确保 RPi 服务 (port 5000) 正在运行</p>
          </div>
        ) : !status ? (
          <div className="flex items-center gap-2 h-40 text-gray-500 text-sm">
             <Activity className="w-4 h-4 animate-spin" /> 正在加载状态...
          </div>
        ) : (
          <div className="space-y-3 font-mono text-xs text-gray-300">
             <div className="flex justify-between border-b border-white/5 pb-1">
                <span>设备 ID</span>
                <span className="text-gray-400">{status.device.device_id}</span>
             </div>
             <div className="flex justify-between border-b border-white/5 pb-1">
                <span>MQTT Broker</span>
                <span className="text-gray-400 max-w-[150px] truncate">{status.broker}</span>
             </div>
             <div className="flex justify-between border-b border-white/5 pb-1">
                <span>MQTT 连接状态</span>
                <span className={cn("font-bold uppercase tracking-wider", status.state.connected ? "text-diag-success" : "text-diag-danger animate-pulse")}>
                  {status.state.connected ? "ONLINE" : "OFFLINE"}
                </span>
             </div>
             <div className="flex justify-between border-b border-white/5 pb-1 line-clamp-1">
                <span>会话 ID</span>
                <span className="text-gray-400 truncate max-w-[150px]">{status.device.session_id}</span>
             </div>
             
             <div className="mt-4 pt-4 border-t border-white/10 space-y-2">
                 <div className="flex items-center justify-between">
                     <span className="text-gray-500">重连次数</span>
                     <span className="text-diag-warning font-bold">{status.state.reconnectCount}</span>
                 </div>
             </div>
          </div>
        )}
      </div>

      {/* 遥测监控 */}
      <div className="diag-card rounded-2xl p-6 bg-black/60 border border-white/5 flex flex-col gap-4">
        <h2 className="text-sm font-bold text-gray-500 uppercase flex items-center gap-2 border-b border-white/10 pb-2">
           <Radio className="w-4 h-4 text-diag-success" /> 遥测链路状况
        </h2>
        <div className="flex gap-4">
           <div className="flex-1 bg-black/40 rounded border border-white/5 p-4 flex flex-col items-center justify-center">
              <span className="text-[10px] text-gray-500 uppercase">QoS 0 发布成功</span>
              <span className="text-3xl font-bold text-diag-success font-mono mt-2">{status?.state.publishSuccess || 0}</span>
           </div>
           <div className="flex-1 bg-black/40 rounded border border-white/5 p-4 flex flex-col items-center justify-center">
              <span className="text-[10px] text-gray-500 uppercase">QoS 0 发布失败</span>
              <span className="text-3xl font-bold text-diag-danger font-mono mt-2">{status?.state.publishFailed || 0}</span>
           </div>
        </div>
        <div className="text-[10px] text-gray-500 mt-2 italic text-center">定期发送心跳和自动 ACK 计算在内</div>
      </div>
      
      {/* 云端命令 */}
      <div className="diag-card rounded-2xl p-6 bg-black/60 border border-white/5 flex flex-col gap-4">
         <h2 className="text-sm font-bold text-gray-500 uppercase flex items-center gap-2 border-b border-white/10 pb-2">
             <AlertTriangle className="w-4 h-4 text-diag-warning" /> 来自云端的下行命令
         </h2>
         <div className="bg-black/80 p-3 rounded border border-white/10 flex-1 overflow-auto font-mono text-[10px] text-gray-300 custom-scrollbar whitespace-pre-wrap">
            {status?.state.latestCommand ? JSON.stringify(status.state.latestCommand, null, 2) : "等待接收命令..."}
         </div>
      </div>

       {/* 手动事件触发 */}
       <div className="diag-card rounded-2xl p-6 bg-black/60 border border-white/5 flex flex-col gap-4 col-span-1 md:col-span-2 lg:col-span-1">
         <h2 className="text-sm font-bold text-gray-500 uppercase flex items-center gap-2 border-b border-white/10 pb-2">
            <Plug className="w-4 h-4 text-blue-400" /> API: 发送事件报文到云端
         </h2>
         <div className="flex flex-col gap-3 font-mono text-xs">
            <label className="text-gray-500 mt-2">EventType</label>
            <input 
               type="text" value={eventType} onChange={e => setEventType(e.target.value)}
               className="bg-black/50 border border-white/10 p-2 rounded outline-none focus:border-blue-400 transition-colors"
            />
            <label className="text-gray-500 mt-2">Description</label>
            <input 
               type="text" value={eventDesc} onChange={e => setEventDesc(e.target.value)}
               className="bg-black/50 border border-white/10 p-2 rounded outline-none focus:border-blue-400 transition-colors"
            />
            {triggerMsg && (
               <div className={cn(
                  "p-2 rounded text-[11px]",
                  triggerMsg.success ? "bg-green-500/20 text-green-300 border border-green-500/30" : "bg-red-500/20 text-red-300 border border-red-500/30"
               )}>
                  {triggerMsg.text}
               </div>
            )}
            <button 
               onClick={triggerEvent}
               disabled={!status?.state.connected}
               className="mt-4 bg-blue-500/20 text-blue-400 border border-blue-500/30 rounded py-2.5 font-bold uppercase tracking-wider hover:bg-blue-500/30 transition-all active:scale-95 disabled:opacity-50 disabled:cursor-not-allowed flex items-center justify-center gap-2"
            >
               <Play className="w-4 h-4"/> 模拟触发
            </button>
         </div>
       </div>

      {/* RPi Service Logs */}
      <div className="diag-card rounded-2xl p-6 bg-black/60 border border-white/5 flex flex-col gap-4 col-span-1 md:col-span-2 lg:col-span-2">
         <div className="flex justify-between items-center border-b border-white/10 pb-2">
            <h2 className="text-sm font-bold text-gray-500 uppercase flex items-center gap-2">
               <Terminal className="w-4 h-4 text-diag-accent" /> 本地日志 (localhost:5000)
            </h2>
         </div>
         <div className="bg-black/80 rounded p-3 overflow-y-auto h-56 custom-scrollbar space-y-1 text-[10px] font-mono select-text">
            {!status || status.state.logs.length === 0 ? (
               <div className="text-gray-600 italic">等待日志...</div>
            ) : (
               status.state.logs.map((log, i) => (
                 <div key={i} className={cn(
                    "break-all",
                    log.level === 'ERROR' ? "text-diag-danger" :
                    log.level === 'SUCCESS' ? "text-diag-success" :
                    log.level === 'WARN' ? "text-diag-warning" : "text-gray-400"
                 )}>
                    <span className="opacity-50">[{new Date(log.ts).toLocaleTimeString()}]</span> <span className="font-bold opacity-60">[{log.level}]</span> {log.message}
                 </div>
               ))
            )}
         </div>
      </div>
    </div>
  );
}
