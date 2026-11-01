import React, { useEffect, useRef, useState } from 'react';
import { Camera, Circle, LoaderCircle, VideoOff } from 'lucide-react';
import { cn } from '../lib/utils';

type CollectorPhase = 'stopped' | 'starting' | 'running' | 'stopping' | 'merging' | 'rendering' | 'error';

export function LiveCameraPreview({ phase }: { phase: CollectorPhase }) {
  const [streamAttempt, setStreamAttempt] = useState(0);
  const [cameraReady, setCameraReady] = useState(false);
  const cameraReadyRef = useRef(false);
  const retryTimer = useRef<number | null>(null);
  const isRunning = phase === 'running';

  useEffect(() => {
    if (retryTimer.current !== null) {
      window.clearTimeout(retryTimer.current);
      retryTimer.current = null;
    }
    cameraReadyRef.current = false;
    setCameraReady(false);
    if (!isRunning) return;

    let cancelled = false;
    const checkCamera = async () => {
      try {
        const response = await fetch(`/api/local/camera/health?t=${Date.now()}`, {
          cache: 'no-store',
        });
        const result = response.ok ? await response.json() : { ready: false };
        if (cancelled) return;
        const ready = result.ready === true;
        if (ready && !cameraReadyRef.current) setStreamAttempt(attempt => attempt + 1);
        cameraReadyRef.current = ready;
        setCameraReady(ready);
      } catch {
        if (!cancelled) {
          cameraReadyRef.current = false;
          setCameraReady(false);
        }
      }
    };
    void checkCamera();
    const healthTimer = window.setInterval(checkCamera, 750);
    return () => {
      cancelled = true;
      window.clearInterval(healthTimer);
      if (retryTimer.current !== null) window.clearTimeout(retryTimer.current);
    };
  }, [isRunning]);

  const retryStream = () => {
    cameraReadyRef.current = false;
    setCameraReady(false);
    if (!isRunning || retryTimer.current !== null) return;
    retryTimer.current = window.setTimeout(() => {
      retryTimer.current = null;
      setStreamAttempt(previous => previous + 1);
    }, 1000);
  };

  const statusText = phase === 'starting'
    ? '正在启动摄像头...'
    : phase === 'running'
      ? '正在连接实时画面...'
      : phase === 'stopping'
        ? '正在停止并保存录像...'
        : phase === 'merging'
          ? '录像已保存，正在融合数据...'
          : phase === 'rendering'
            ? '正在生成指标录像...'
          : phase === 'error'
            ? '录像预览不可用'
            : '等待开启采集';

  return (
    <section className="min-h-[260px] rounded-xl border border-white/10 bg-black/60 overflow-hidden flex flex-col">
      <div className="h-11 px-4 border-b border-white/10 flex items-center justify-between shrink-0">
        <div className="flex items-center gap-2 text-xs font-bold text-gray-300">
          <Camera className="w-4 h-4 text-blue-400" />
          实时录像预览
        </div>
        {isRunning && cameraReady && (
          <div className="flex items-center gap-1.5 text-[10px] font-bold tracking-widest text-red-400">
            <Circle className="w-2.5 h-2.5 fill-current animate-pulse" /> REC
          </div>
        )}
      </div>

      <div className="relative flex-1 min-h-0 flex items-center justify-center bg-black">
        {isRunning && cameraReady && (
          <img
            key={streamAttempt}
            src={`/api/local/camera/stream?v=${streamAttempt}`}
            alt="摄像头实时录像画面"
            className={cn(
              'absolute inset-0 w-full h-full object-contain transition-opacity duration-300',
              cameraReady ? 'opacity-100' : 'opacity-0',
            )}
            onError={retryStream}
          />
        )}

        {(!isRunning || !cameraReady) && (
          <div className="relative z-10 flex flex-col items-center gap-3 text-gray-500 px-6 text-center">
            {phase === 'starting' || phase === 'running' || phase === 'stopping' ? (
              <LoaderCircle className="w-8 h-8 text-blue-400 animate-spin" />
            ) : (
              <VideoOff className="w-8 h-8" />
            )}
            <span className="text-xs font-medium">{statusText}</span>
          </div>
        )}
      </div>
    </section>
  );
}
