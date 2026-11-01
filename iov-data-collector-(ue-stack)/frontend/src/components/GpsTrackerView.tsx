import React, { useEffect, useRef, useState } from 'react';
import type { GpsDataPoint } from '../data/gpsData';
import { Map, Settings2, X, MousePointer2 } from 'lucide-react';
import { cn } from '../lib/utils';

type MetricType = 'avg_rtt_ms' | 'jitter_ms' | 'throughput_bps' | 'loss_rate';

export function GpsTrackerView({ data: localData, hasQuery, isActive }: {
  data: GpsDataPoint[];
  hasQuery: boolean;
  isActive: boolean;
}) {
  const mapContainerRef = useRef<HTMLDivElement>(null);
  const mapInstanceRef = useRef<any>(null);
  const dotsRef = useRef<any[]>([]);
  const fittedDataRef = useRef<GpsDataPoint[] | null>(null);
  
  const [selectedPoint, setSelectedPoint] = useState<GpsDataPoint | null>(null);
  useEffect(() => { setSelectedPoint(null); }, [localData]);

  // Settings State
  const [showSettings, setShowSettings] = useState(false);
  const [activeMetric, setActiveMetric] = useState<MetricType>('avg_rtt_ms');
  const [thresholds, setThresholds] = useState({
    avg_rtt_ms: { good: 10, warning: 50 },
    jitter_ms: { good: 5, warning: 20 },
    throughput_bps: { good: 5000000, warning: 1000000 },
    loss_rate: { good: 0, warning: 0.05 },
  });

  const getDotColor = (point: GpsDataPoint, metric: MetricType, thresh: typeof thresholds) => {
    const value = point[metric];
    if (value === null || value === undefined) return '#9ca3af'; // Gray for null/invalid

    const t = thresh[metric];
    
    if (metric === 'throughput_bps') {
      if (value >= t.good) return '#22c55e'; // Green
      if (value >= t.warning) return '#eab308'; // Yellow
      return '#ef4444'; // Red
    } else {
      if (value <= t.good) return '#22c55e'; // Green
      if (value <= t.warning) return '#eab308'; // Yellow
      return '#ef4444'; // Red
    }
  };

  const [mapInitialized, setMapInitialized] = useState(false);
  const [mapLoadError, setMapLoadError] = useState(false);

  useEffect(() => {
    let isMounted = true;

    const initMap = () => {
      if (!isMounted) return;
      if (!window.AMap || !mapContainerRef.current) {
        setMapLoadError(true);
        return;
      }
      
      try {
        const center = localData.length > 0 ? [localData[0].longitude, localData[0].latitude] : [116.397428, 39.90923];
        
        const map = new window.AMap.Map(mapContainerRef.current, {
          zoom: 16,
          center: center,
          mapStyle: "amap://styles/dark",
        });
        mapInstanceRef.current = map;
        setMapInitialized(true);
      } catch (err) {
        console.warn("Failed to instantiate AMap:", err);
        setMapLoadError(true);
      }
    };

    if (window.AMap) {
      initMap();
    } else {
      window._AMapSecurityConfig = {
        securityJsCode: "7dc4def5e6ae5f116c12fef86176bc75",
      };
      const existingScript = document.getElementById('amap-script');
      if (!existingScript) {
        const script = document.createElement('script');
        script.id = 'amap-script';
        const amapKey = import.meta.env.VITE_AMAP_KEY || '2b14a767057d5161de944161a6065b9e';
        script.src = `https://webapi.amap.com/maps?v=2.0&key=${amapKey}&plugin=AMap.Marker,AMap.MoveAnimation`;
        script.async = true;
        script.onload = () => {
          setTimeout(initMap, 50);
        };
        script.onerror = () => {
          console.warn("AMap CDN script load failed. Using built-in vector plot fallback.");
          if (isMounted) setMapLoadError(true);
        };
        document.head.appendChild(script);
      } else {
        const timer = setTimeout(initMap, 200);
        return () => clearTimeout(timer);
      }
    }

    return () => {
      isMounted = false;
      if (mapInstanceRef.current && typeof mapInstanceRef.current.destroy === 'function') {
        try {
          mapInstanceRef.current.destroy();
        } catch {
          // ignore
        }
      }
    };
  }, []);

  // Plot all dots
  useEffect(() => {
    if (!mapInitialized || !mapInstanceRef.current || !isActive) return;
    const map = mapInstanceRef.current;
    map.resize?.();

    // Clear existing dots
    if (dotsRef.current.length > 0) {
      mapInstanceRef.current.remove(dotsRef.current);
      dotsRef.current = [];
    }

    localData.forEach((point) => {
      const color = getDotColor(point, activeMetric, thresholds);
      const dot = new window.AMap.CircleMarker({
        center: [point.longitude, point.latitude],
        radius: 4, 
        fillColor: color,
        fillOpacity: 0.8,
        strokeColor: "#ffffff",
        strokeWeight: 1,
        zIndex: 10,
        cursor: 'pointer',
        extData: point
      });
      
      dot.on('click', (e: any) => {
        setSelectedPoint(e.target.getExtData());
        mapInstanceRef.current.panTo([point.longitude, point.latitude]);
      });

      dot.setMap(mapInstanceRef.current);
      dotsRef.current.push(dot);
    });

    // Fit new query results without resetting the viewport on navigation.
    const timer = setTimeout(() => {
      if (localData.length > 0 && fittedDataRef.current !== localData) {
        map.setFitView();
        fittedDataRef.current = localData;
      }
    }, 500);
    return () => clearTimeout(timer);

  }, [localData, activeMetric, thresholds, mapInitialized, isActive]);

  const currentMetricValue = selectedPoint?.[activeMetric];

  const coordsBounds = React.useMemo(() => {
    if (localData.length === 0) return { minLat: 39.9, maxLat: 40.0, minLon: 116.3, maxLon: 116.4 };
    let minLat = Infinity, maxLat = -Infinity, minLon = Infinity, maxLon = -Infinity;
    localData.forEach(d => {
      if (d.latitude < minLat) minLat = d.latitude;
      if (d.latitude > maxLat) maxLat = d.latitude;
      if (d.longitude < minLon) minLon = d.longitude;
      if (d.longitude > maxLon) maxLon = d.longitude;
    });
    const padLat = Math.max((maxLat - minLat) * 0.1, 0.001);
    const padLon = Math.max((maxLon - minLon) * 0.1, 0.001);
    return { minLat: minLat - padLat, maxLat: maxLat + padLat, minLon: minLon - padLon, maxLon: maxLon + padLon };
  }, [localData]);

  return (
    <div className="h-full flex flex-col relative bg-black rounded-xl overflow-hidden shadow-inner border border-white/5">
      {/* HUD Layer */}
      <div className="absolute top-4 left-4 z-10 flex flex-col gap-4 w-72">
        <div className="bg-black/60 backdrop-blur border border-white/10 p-4 rounded-xl shadow-lg transition-all">
          <div className="flex items-center justify-between mb-4">
            <h3 className="text-sm font-bold flex items-center gap-2 text-white uppercase tracking-wider">
              <Map className="w-4 h-4 text-diag-accent" /> 定位数据分析
            </h3>
            <span className="text-xs text-gray-400 font-mono">共 {localData.length} 个点位</span>
          </div>
          {localData.length === 0 && (
            <p className="text-xs text-gray-400 mb-3">
              {hasQuery ? '所选 CSV 和时间范围内没有有效定位点，请调整数据选择。' : '请先在数据可视化中选择 CSV 和时间范围，点击“确认并分析”。'}
            </p>
          )}
          
          {selectedPoint ? (
            <div className="grid grid-cols-2 gap-4 mb-2">
              <div>
                <div className="text-[10px] text-gray-400 font-bold uppercase mb-1">时间戳</div>
                <div className="text-sm font-mono text-diag-accent truncate" title={selectedPoint.timestamp}>{selectedPoint.timestamp}</div>
              </div>
              <div>
                <div className="text-[10px] text-gray-400 font-bold uppercase mb-1">索引</div>
                <div className="text-sm font-mono text-white">
                  #{selectedPoint.index}
                </div>
              </div>
              <div>
                <div className="text-[10px] text-gray-400 font-bold uppercase mb-1">经度</div>
                <div className="text-xs font-mono text-white">{selectedPoint.longitude.toFixed(6)}</div>
              </div>
              <div>
                <div className="text-[10px] text-gray-400 font-bold uppercase mb-1">纬度</div>
                <div className="text-xs font-mono text-white">{selectedPoint.latitude.toFixed(6)}</div>
              </div>
              <div className="col-span-2 bg-white/5 p-2 rounded border border-white/5 mt-2">
                <div className="text-[10px] text-gray-400 font-bold uppercase mb-1 flex items-center justify-between">
                  <span>检测值 ({activeMetric})</span>
                  <div 
                    className="w-2 h-2 rounded-full shadow-[0_0_8px_rgba(255,255,255,0.5)]" 
                    style={{ backgroundColor: getDotColor(selectedPoint, activeMetric, thresholds) }}
                  />
                </div>
                <div className="text-xl font-mono font-bold text-white flex items-end gap-2">
                  {currentMetricValue !== null && currentMetricValue !== undefined 
                    ? Number(currentMetricValue).toLocaleString() 
                    : '--'}
                  <span className="text-[10px] text-gray-500 font-normal pb-1 tracking-widest uppercase">
                    {activeMetric.split('_')[1] === 'ms' ? 'ms' : activeMetric.split('_')[1] === 'bps' ? 'bps' : '%'}
                  </span>
                </div>
              </div>
            </div>
          ) : (
            <div className="h-40 flex flex-col items-center justify-center text-gray-500 gap-3 border border-dashed border-white/10 rounded-lg bg-white/5">
              <MousePointer2 className="w-6 h-6 opacity-50" />
              <p className="text-xs">点击地图上的标记点查看详情</p>
            </div>
          )}
        </div>
      </div>

      {/* Settings Toggle */}
      <button 
         onClick={() => setShowSettings(!showSettings)}
        className="absolute top-4 right-4 z-20 bg-black/60 backdrop-blur border border-white/10 p-2 rounded-lg shadow-lg text-gray-400 hover:text-white transition-colors"
      >
        <Settings2 className="w-5 h-5" />
      </button>

      {/* Settings Panel */}
      {showSettings && (
        <div className="absolute top-16 right-4 z-20 bg-black/80 backdrop-blur border border-white/10 p-5 rounded-xl shadow-xl w-80 text-gray-200">
            <div className="flex justify-between items-center mb-4">
               <h3 className="text-sm font-bold uppercase tracking-wider text-white">颜色标记设置</h3>
               <button onClick={() => setShowSettings(false)} className="text-gray-400 hover:text-white"><X className="w-4 h-4" /></button>
            </div>
            
            <div className="space-y-4">
              <div>
                 <label className="text-xs text-gray-400 mb-2 block">数据依据 (Metric)</label>
                 <select 
                   value={activeMetric}
                   onChange={(e) => setActiveMetric(e.target.value as MetricType)}
                   className="w-full bg-white/10 border border-white/10 rounded-lg px-3 py-2 text-sm text-white focus:outline-none focus:border-diag-accent appearance-none cursor-pointer"
                 >
                   <option value="avg_rtt_ms" className="bg-gray-900">平均延迟 (RTT)</option>
                   <option value="jitter_ms" className="bg-gray-900">抖动 (Jitter)</option>
                   <option value="throughput_bps" className="bg-gray-900">吞吐量 (Throughput)</option>
                   <option value="loss_rate" className="bg-gray-900">丢包率 (Loss Rate)</option>
                 </select>
              </div>
              
              <div className="p-3 bg-white/5 rounded-lg border border-white/5 space-y-3">
                 <h4 className="text-xs font-bold text-gray-300">数据范围阈值</h4>
                 
                 <div className="flex items-center gap-3">
                    <div className="w-3 h-3 rounded-full bg-green-500 shrink-0 shadow-[0_0_8px_rgba(34,197,94,0.6)]"></div>
                    <span className="text-xs flex-1 text-gray-400 font-mono">良好 {activeMetric === 'throughput_bps' ? '>=' : '<='}</span>
                    <input 
                      type="number"
                      value={thresholds[activeMetric].good}
                      onChange={(e) => setThresholds(prev => ({ ...prev, [activeMetric]: { ...prev[activeMetric], good: Number(e.target.value) } }))}
                      className="w-24 bg-black/50 border border-white/10 rounded px-2 py-1 text-xs text-white text-right focus:outline-none focus:border-diag-accent"
                    />
                 </div>
                 
                 <div className="flex items-center gap-3">
                    <div className="w-3 h-3 rounded-full bg-yellow-500 shrink-0 shadow-[0_0_8px_rgba(234,179,8,0.6)]"></div>
                    <span className="text-xs flex-1 text-gray-400 font-mono">警告阈值</span>
                    <input 
                      type="number"
                      value={thresholds[activeMetric].warning}
                      onChange={(e) => setThresholds(prev => ({ ...prev, [activeMetric]: { ...prev[activeMetric], warning: Number(e.target.value) } }))}
                      className="w-24 bg-black/50 border border-white/10 rounded px-2 py-1 text-xs text-white text-right focus:outline-none focus:border-diag-accent"
                    />
                 </div>
                 
                 <div className="flex items-center gap-3">
                    <div className="w-3 h-3 rounded-full bg-red-500 shrink-0 shadow-[0_0_8px_rgba(239,68,68,0.6)]"></div>
                    <span className="text-xs flex-1 text-gray-400 font-mono">较差 {activeMetric === 'throughput_bps' ? '<' : '>'} 警告</span>
                    <div className="w-24 text-right px-2 py-1 text-xs text-gray-600 font-mono">
                      自动计算
                    </div>
                 </div>
              </div>
            </div>
        </div>
      )}

      <div ref={mapContainerRef} className={cn("w-full h-full", mapLoadError ? "hidden" : "block")} />

      {mapLoadError && (
        <div className="w-full h-full flex flex-col items-center justify-center p-8 bg-[#090d16] relative select-none">
          <div className="absolute top-4 right-4 z-10 px-3 py-1 bg-yellow-500/10 border border-yellow-500/20 text-yellow-400 text-xs rounded-full flex items-center gap-1.5 font-mono">
            <span className="w-2 h-2 rounded-full bg-yellow-400 animate-pulse" />
            离线高精轨迹视图 (高德地图外部服务不可用时自动启用)
          </div>

          <svg className="w-full h-full" viewBox="0 0 1000 600" preserveAspectRatio="xMidYMid meet">
            <defs>
              <pattern id="grid" width="40" height="40" patternUnits="userSpaceOnUse">
                <path d="M 40 0 L 0 0 0 40" fill="none" stroke="rgba(255,255,255,0.05)" strokeWidth="1" />
              </pattern>
            </defs>
            <rect width="1000" height="600" fill="url(#grid)" />

            {/* Connecting line between consecutive points */}
            {localData.length > 1 && (
              <polyline
                fill="none"
                stroke="rgba(59,130,246,0.3)"
                strokeWidth="2"
                strokeDasharray="4 2"
                points={localData.map(p => {
                  const x = 50 + ((p.longitude - coordsBounds.minLon) / (coordsBounds.maxLon - coordsBounds.minLon || 1)) * 900;
                  const y = 550 - ((p.latitude - coordsBounds.minLat) / (coordsBounds.maxLat - coordsBounds.minLat || 1)) * 500;
                  return `${x},${y}`;
                }).join(' ')}
              />
            )}

            {/* Trajectory dots */}
            {localData.map((point) => {
              const x = 50 + ((point.longitude - coordsBounds.minLon) / (coordsBounds.maxLon - coordsBounds.minLon || 1)) * 900;
              const y = 550 - ((point.latitude - coordsBounds.minLat) / (coordsBounds.maxLat - coordsBounds.minLat || 1)) * 500;
              const color = getDotColor(point, activeMetric, thresholds);
              const isSelected = selectedPoint?.index === point.index;

              return (
                <g key={point.index} onClick={() => setSelectedPoint(point)} className="cursor-pointer group">
                  {isSelected && (
                    <circle cx={x} cy={y} r={10} fill="none" stroke="#60a5fa" strokeWidth={2} className="animate-ping" opacity={0.7} />
                  )}
                  <circle
                    cx={x}
                    cy={y}
                    r={isSelected ? 6 : 4}
                    fill={color}
                    stroke="#ffffff"
                    strokeWidth={isSelected ? 2 : 1}
                    className="transition-all hover:r-6"
                  />
                </g>
              );
            })}
          </svg>
        </div>
      )}
    </div>
  );
}
