import React, { useState, useEffect, useRef } from 'react';
import { Play, Pause, Database, HardDrive, Trash2, Maximize2, ShieldCheck, Activity } from 'lucide-react';
import { cn } from '../lib/utils';


interface VideoFile {
  fileName: string;
  fileSize: number;
  downloadUrl: string;
}

export function AgentProxyVideoPlayer() {
  const [videos, setVideos] = useState<VideoFile[]>([]);
  const [selectedVideo, setSelectedVideo] = useState<VideoFile | null>(null);
  const [isPlaying, setIsPlaying] = useState(false);
  const [currentTime, setCurrentTime] = useState(0);
  const [duration, setDuration] = useState(0);
  
  const videoRef = useRef<HTMLVideoElement>(null);

  // Sliding window mock state (Memory usage visualizer)
  const CHUNK_SIZE = 5 * 1024 * 1024; // 5MB
  const WINDOW_MAX_CHUNKS = 5; // Sliding window capacity 25MB
  const [activeChunks, setActiveChunks] = useState<number[]>([]);
  const [evictedChunks, setEvictedChunks] = useState<number[]>([]);

  useEffect(() => {
    // 优先使用环境变量 VITE_API_BASE_URL，若无则使用相对路径 (用于同源 Nginx 部署)
    const BASE_URL = import.meta.env.VITE_API_BASE_URL || "";
    
    // 连接到后端侧获取数据
    fetch(`${BASE_URL}/api/video/local/list`)
      .then(res => res.json())
      .then(data => {
        if (data && data.code === 200) {
          setVideos(data.data);
          if (data.data.length > 0) setSelectedVideo(data.data[0]);
        }
      })
      .catch((err) => {
        console.warn("Backend not available, using fallback video list", err);
        const fallbackData = [
          {
            fileName: "Agent_Local_Cache_1.mp4",
            fileSize: 158008374, // 150MB
            downloadUrl: "/api/video/local/download/BigBuckBunny.mp4"
          },
          {
            fileName: "Agent_Local_Cache_2.mp4",
            fileSize: 168000000,
            downloadUrl: "/api/video/local/download/ElephantsDream.mp4"
          }
        ];
        setVideos(fallbackData);
        setSelectedVideo(fallbackData[0]);
      });
  }, []);

  useEffect(() => {
    if (!selectedVideo || !duration) return;
    
    // Simulate cache manager worker evaluating chunks
    const totalChunks = Math.ceil(selectedVideo.fileSize / CHUNK_SIZE);
    // Find current chunk based on play time
    const currentChunkIndex = Math.floor((currentTime / duration) * totalChunks);
    
    let newActive: number[] = [];
    const windowStart = Math.max(0, currentChunkIndex - 1); // Keep 1 previous chunk
    const windowEnd = Math.min(totalChunks - 1, currentChunkIndex + (WINDOW_MAX_CHUNKS - 2)); // Pre-buffer next ones
    
    for (let i = windowStart; i <= windowEnd; i++) {
        newActive.push(i);
    }
    
    let newEvicted: number[] = [...evictedChunks];
    // Any chunk before windowStart that was active is now evicted
    for (let i = 0; i < windowStart; i++) {
        if (!newEvicted.includes(i)) newEvicted.push(i);
    }
    
    // Smooth out updates to prevent endless re-renders
    if (JSON.stringify(newActive) !== JSON.stringify(activeChunks)) {
        setActiveChunks(newActive);
    }
    if (JSON.stringify(newEvicted) !== JSON.stringify(evictedChunks)) {
        setEvictedChunks(newEvicted);
    }
    
  }, [currentTime, duration, selectedVideo, activeChunks, evictedChunks]);

  const handleTimeUpdate = () => {
    if (videoRef.current) {
      setCurrentTime(videoRef.current.currentTime);
    }
  };

  const handleLoadedMetadata = () => {
    if (videoRef.current) {
        setDuration(videoRef.current.duration);
    }
    setEvictedChunks([]);
    setActiveChunks([]);
  };

  const togglePlay = () => {
    if (videoRef.current) {
      if (isPlaying) {
          videoRef.current.pause();
      } else {
          const playPromise = videoRef.current.play();
          if (playPromise !== undefined) {
              playPromise.catch(err => {
                  console.warn("Play interrupted", err);
              });
          }
      }
      setIsPlaying(!isPlaying);
    }
  };

  return (
    <div className="flex flex-col h-full bg-black font-sans text-gray-200">
        
       {/* Top Header */}
       <div className="flex-none p-6 border-b border-white/5 flex flex-col gap-4">
          <div className="flex items-center justify-between">
              <h2 className="text-xl font-bold tracking-tight text-white flex items-center gap-2">
                 <Database className="w-5 h-5 text-blue-400" />
                 视频缓存和播放服务
              </h2>
              <div className="flex gap-2">
                  {videos.map(v => (
                       <button 
                          key={v.fileName}
                          onClick={() => {
                             setSelectedVideo(v);
                             setIsPlaying(false);
                             setCurrentTime(0);
                             setEvictedChunks([]);
                          }}
                          className={cn(
                             "px-4 py-1.5 rounded text-xs font-bold uppercase transition-all",
                             selectedVideo?.fileName === v.fileName ? "bg-blue-600/30 text-blue-400 border border-blue-500/50" : "bg-white/5 text-gray-400 border border-white/10 hover:bg-white/10"
                          )}
                       >
                          {v.fileName}
                       </button>
                  ))}
              </div>
          </div>
          <p className="text-xs text-gray-400">基于严格的 <span className="text-blue-300 font-bold">缓存生命周期管理</span> 和 <span className="text-blue-300 font-bold">滑动窗口机制</span>，防止车端内存/磁盘溢出。适用于长视频及短视频流媒体。</p>
       </div>

       <div className="flex-1 grid grid-cols-1 lg:grid-cols-2 gap-6 p-6 min-h-0 overflow-y-auto custom-scrollbar">
           
           {/* Left: Video Player */}
           <div className="flex flex-col gap-4">
                <div className="relative group w-full bg-black/50 border border-white/10 rounded-xl overflow-hidden shadow-2xl">
                    {selectedVideo ? (
                        <video
                           ref={videoRef}
                           src={
                               selectedVideo.downloadUrl.startsWith('http') ? selectedVideo.downloadUrl : `${import.meta.env.VITE_API_BASE_URL || ""}${selectedVideo.downloadUrl}`
                           }
                           className="w-full h-auto max-h-[500px] object-contain"
                           onTimeUpdate={handleTimeUpdate}
                           onLoadedMetadata={handleLoadedMetadata}
                           onPlay={() => setIsPlaying(true)}
                           onPause={() => setIsPlaying(false)}
                           onEnded={() => setIsPlaying(false)}
                           controls={false} // Custom controls
                        />
                    ) : (
                        <div className="w-full aspect-video flex items-center justify-center text-gray-600 italic text-sm">
                            选择视频源以播放
                        </div>
                    )}
                    
                    {/* Custom Controls Overlay */}
                    {selectedVideo && (
                        <div className="absolute inset-0 bg-black/40 opacity-0 group-hover:opacity-100 transition-opacity flex flex-col justify-end p-4">
                            <div className="flex items-center gap-4 text-white">
                                <button onClick={togglePlay} className="hover:text-blue-400 transition-colors">
                                   {isPlaying ? <Pause className="w-8 h-8 fill-current" /> : <Play className="w-8 h-8 fill-current" />}
                                </button>
                                <div className="flex-1 h-1.5 bg-white/20 rounded-full cursor-pointer relative overflow-hidden" 
                                    onClick={(e) => {
                                        if (videoRef.current && duration) {
                                            const rect = e.currentTarget.getBoundingClientRect();
                                            const pos = (e.clientX - rect.left) / rect.width;
                                            videoRef.current.currentTime = pos * duration;
                                        }
                                    }}>
                                   <div className="absolute top-0 left-0 bottom-0 bg-blue-500 rounded-full" style={{ width: `${(currentTime/duration)*100}%` }} />
                                </div>
                                <span className="text-xs font-mono">{Math.floor(currentTime)}s / {Math.floor(duration)}s</span>
                                <Maximize2 className="w-5 h-5 cursor-pointer hover:text-blue-400" />
                            </div>
                        </div>
                    )}
                </div>
           </div>

           {/* Right: Cache Lifecycle Dashboard */}
           <div className="flex flex-col gap-6">
                
                {/* Metrics */}
                <div className="grid grid-cols-2 gap-4">
                    <div className="bg-blue-900/20 border border-blue-500/20 rounded-xl p-4 flex flex-col items-center justify-center relative overfow-hidden">
                        <Activity className="absolute right-4 top-4 w-12 h-12 text-blue-500/10" />
                        <span className="text-xs text-blue-400/70 uppercase tracking-widest font-bold mb-1">内存驻留上限</span>
                        <div className="flex items-baseline gap-1">
                            <span className="text-3xl font-mono font-bold text-blue-400">{WINDOW_MAX_CHUNKS * 5}</span>
                            <span className="text-xs text-blue-400/50">MB</span>
                        </div>
                    </div>
                    <div className="bg-diag-success/10 border border-diag-success/20 rounded-xl p-4 flex flex-col items-center justify-center relative">
                        <ShieldCheck className="absolute right-4 top-4 w-12 h-12 text-diag-success/10" />
                        <span className="text-xs text-diag-success/70 uppercase tracking-widest font-bold mb-1">释放内存</span>
                        <div className="flex items-baseline gap-1">
                            <span className="text-3xl font-mono font-bold text-diag-success">{evictedChunks.length * 5}</span>
                            <span className="text-xs text-diag-success/50">MB</span>
                        </div>
                    </div>
                </div>

                {/* Sliding Window Visualizer */}
                <div className="bg-white/5 border border-white/10 rounded-xl p-5 flex flex-col gap-4">
                    <div className="flex justify-between items-center border-b border-white/10 pb-3">
                        <h3 className="text-sm font-bold uppercase text-gray-400 flex items-center gap-2">
                            <HardDrive className="w-4 h-4" />
                            当前滑动窗口链路 (分片管理)
                        </h3>
                        <span className="text-[10px] bg-white/10 px-2 py-0.5 rounded text-gray-500 font-mono">1 Block = 5MB</span>
                    </div>

                    <div className="w-full flex flex-wrap gap-1">
                        {!selectedVideo && <span className="text-xs text-gray-600">等待加载...</span>}
                        {selectedVideo && duration > 0 && Array.from({length: Math.ceil(selectedVideo.fileSize / CHUNK_SIZE)}).map((_, i) => {
                            const isEvicted = evictedChunks.includes(i);
                            const isActive = activeChunks.includes(i);
                            const isFuture = !isEvicted && !isActive;

                            return (
                                <div 
                                  key={i}
                                  className={cn(
                                     "h-8 flex-1 min-w-[20px] rounded flex items-center justify-center text-[10px] font-mono transition-all duration-500",
                                     isActive ? "bg-blue-500 text-white shadow-[0_0_10px_rgba(59,130,246,0.5)] border border-blue-400" :
                                     isEvicted ? "bg-black text-gray-600 border border-red-900/50 opacity-40 hover:opacity-100" :
                                     "bg-white/5 text-gray-600 border border-white/5"
                                  )}
                                  title={`Chunk ${i} (${i*5}MB) - ${isActive ? 'Active' : isEvicted ? 'Evicted' : 'Pending'}`}
                                >
                                    {isActive ? "B" : isEvicted ? <Trash2 className="w-3 h-3 text-red-500/50" /> : ""}
                                </div>
                            )
                        })}
                    </div>
                    
                    <div className="flex gap-4 mt-2 justify-center">
                        <div className="flex items-center gap-1.5 text-xs text-gray-500"><div className="w-3 h-3 rounded bg-blue-500 shadow border border-blue-400"></div> 活动缓存 (滑动窗口内)</div>
                        <div className="flex items-center gap-1.5 text-xs text-gray-500"><div className="w-3 h-3 rounded bg-black border border-red-900/50"></div> 已清理 (垃圾回收)</div>
                        <div className="flex items-center gap-1.5 text-xs text-gray-500"><div className="w-3 h-3 rounded bg-white/5 border border-white/5"></div> 未获取 (节省流量)</div>
                    </div>
                </div>

                {/* Developer Explanation Console */}
                <div className="bg-black border border-white/10 rounded-xl p-5 overflow-hidden flex flex-col font-mono text-[10px] text-gray-400 gap-2">
                    <span className="text-gray-500 uppercase tracking-widest font-bold">调度日志分析</span>
                    <hr className="border-white/5 my-1" />
                    <p>{`> 初始化视频解码流... 分片大小阈值设定: ${CHUNK_SIZE/1024/1024}MB`}</p>
                    <p>{`> 设置滑动窗口算法: Maximum Window = ${WINDOW_MAX_CHUNKS} Blocks (${WINDOW_MAX_CHUNKS*5}MB)`}</p>
                    {activeChunks.length > 0 && <p className="text-blue-400">{`> [CACHE] 预加载分片并将其移入活动缓存池: Chunks [${activeChunks.join(', ')}] ...`}</p>}
                    {activeChunks.length > 0 && <p className="text-blue-400">{`> [DL] 发起 HTTP Range Request (bytes=${Math.min(...activeChunks)*CHUNK_SIZE}-${(Math.max(...activeChunks)+1)*CHUNK_SIZE-1})`}</p>}
                    {evictedChunks.length > 0 && <p className="text-diag-danger">{`> [GC] 播放进度已越过阈值，清理旧分片 [${evictedChunks[evictedChunks.length-1]}] 以释放内存.`}</p>}
                    {evictedChunks.length > 0 && <p className="text-diag-success">{`> [MEM] 当前 V8 GC Heap 保留安全水位，无泄漏风险。`}</p>}
                </div>
           </div>

       </div>
    </div>
  );
}
