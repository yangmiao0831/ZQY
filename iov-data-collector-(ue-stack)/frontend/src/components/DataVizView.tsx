import React, { useState, useEffect, useMemo, useRef, useCallback } from 'react';
import { AreaChart, Area, ComposedChart, BarChart, Bar, LineChart, Line, XAxis, YAxis, CartesianGrid, ResponsiveContainer, Tooltip } from 'recharts';
import { Activity, Radio, Network, BarChart2, SplitSquareHorizontal, Database, FolderOpen, Clock, CheckCircle, Settings, X, LayoutDashboard } from 'lucide-react';
import { cn } from '../lib/utils';
import type { CsvDataPoint } from '../data/csvData';

type WirelessMetric = 'rsrp_dbm' | 'sinr_db' | 'rsrq_db' | 'rssi_dbm';
type NetworkMetric = 'avg_rtt_ms' | 'jitter_ms' | 'throughput_bps' | 'loss_rate';
type ViewMode = 'timeseries' | 'distribution' | 'overview';
type SummaryDefinition = {
  key: WirelessMetric | NetworkMetric;
  name: string;
  unit: string;
  decimals: number;
  transform?: (value: number) => number;
};

const summarizeData = (data: CsvDataPoint[], definitions: SummaryDefinition[]) => definitions.map(definition => {
  const values = data
    .map(point => point[definition.key])
    .filter((value): value is number => typeof value === 'number' && Number.isFinite(value))
    .map(value => definition.transform ? definition.transform(value) : value);
  return {
    ...definition,
    maximum: values.length > 0 ? Math.max(...values) : null,
    minimum: values.length > 0 ? Math.min(...values) : null,
    average: values.length > 0 ? values.reduce((sum, value) => sum + value, 0) / values.length : null,
  };
});

const precisionForStep = (step: number) => {
    if (!Number.isFinite(step) || step <= 0) return 2;
    return Math.min(10, Math.max(2, -Math.floor(Math.log10(step)) + 1));
};

const calculateDefaults = (metric: string, data: any[]) => {
    const validData = data.filter(d => d[metric] !== null && d[metric] !== undefined && !isNaN(Number(d[metric]))).map(d => Number(d[metric]));
    if (validData.length === 0) return { min: 0, max: 100, step: 10 };
    const min = Math.min(...validData);
    const max = Math.max(...validData);
    let range = max - min;
    if (range === 0) range = 1;
    
    const roughStep = range / 20;
    const magnitude = Math.pow(10, Math.floor(Math.log10(roughStep)));
    let step = magnitude;
    const normalizedStep = roughStep / magnitude;
    if (normalizedStep > 5) step *= 10;
    else if (normalizedStep > 2) step *= 5;
    else if (normalizedStep > 1) step *= 2;
    
    step = Number(step.toPrecision(2));
    
    let niceMin = Math.floor(min / step) * step;
    let niceMax = Math.ceil(max / step) * step;
    if (niceMin === niceMax) niceMax += step;
    const precision = precisionForStep(step);

    return {
        min: Number(niceMin.toFixed(precision)),
        max: Number(niceMax.toFixed(precision)),
        step: Number(step.toFixed(precision)),
    };
};

const calculateDistributionData = (data: any[], metric: string, type: 'histogram' | 'cdf', config?: {min: number, max: number, step: number}) => {
    const validData = data.filter(d => d[metric] !== null && d[metric] !== undefined && !isNaN(Number(d[metric]))).map(d => Number(d[metric]));
    if (validData.length === 0) return [];

    if (type === 'histogram' && config) {
        const { min, max, step } = config;
        let safeStep = step <= 0 ? 1 : step;
        let binCount = Math.ceil((max - min) / safeStep);
        if (binCount <= 0) return [];
        if (binCount > 200) binCount = 200; 
        const precision = precisionForStep(safeStep);

        const bins = Array.from({ length: binCount }).map((_, i) => {
            const binStart = min + i * safeStep;
            const binEnd = min + (i + 1) * safeStep;
            return {
                binStart,
                binEnd,
                name: Number(binStart.toFixed(precision)),
                count: 0
            };
        });

        validData.forEach(val => {
            if (val >= min && val <= max) {
                let binIndex = Math.floor((val - min) / safeStep);
                if (binIndex >= binCount) binIndex = binCount - 1;
                if (binIndex < 0) binIndex = 0;
                bins[binIndex].count++;
            }
        });

        return bins.map(b => ({
            name: b.name,
            range: `${b.binStart.toFixed(precision)} - ${b.binEnd.toFixed(precision)}`,
            count: b.count,
            percentage: (b.count / validData.length * 100).toFixed(1)
        }));
    } else if (type === 'cdf') {
        const sortedData = [...validData].sort((a, b) => a - b);
        const maxPoints = 100;
        const stepSize = Math.max(1, Math.floor(sortedData.length / maxPoints));
        const cdfData = [];
        
        for (let i = 0; i < sortedData.length; i += stepSize) {
            cdfData.push({
                value: sortedData[i],
                percentile: Number(((i + 1) / sortedData.length * 100).toFixed(1))
            });
        }
        if (cdfData.length > 0 && cdfData[cdfData.length - 1].percentile !== 100) {
             cdfData.push({
                value: sortedData[sortedData.length - 1],
                percentile: 100
            });
        }
        return cdfData;
    }
    return [];
};


export function DataVizView({ isActive = true, csvData, onQueryResult, autoCsvSelection }: {
  isActive?: boolean;
  csvData: CsvDataPoint[] | null;
  onQueryResult: (data: CsvDataPoint[]) => void;
  autoCsvSelection?: { source: string; file: string; mergedAt: string } | null;
}) {
  const [viewMode, setViewMode] = useState<ViewMode>('timeseries');

  // Timeseries State
  const [currentIndex, setCurrentIndex] = useState(0);
  const [leftChartMetric, setLeftChartMetric] = useState<WirelessMetric>('rsrp_dbm');
  const [rightChartMetric, setRightChartMetric] = useState<NetworkMetric>('throughput_bps');
  const wirelessScrollRef = useRef<HTMLDivElement>(null);
  const networkScrollRef = useRef<HTMLDivElement>(null);

  // Distribution Data State
  const activeData = useMemo(() => csvData ?? [], [csvData]);
  const [sources, setSources] = useState<string[]>(['Autocom', 'BJTU']);
  const [selectedSource, setSelectedSource] = useState<string>('Autocom');
  const [availableFiles, setAvailableFiles] = useState<string[]>([]);
  const [selectedFiles, setSelectedFiles] = useState<string[]>([]);
  const [startTime, setStartTime] = useState<string>('');
  const [endTime, setEndTime] = useState<string>('');
  const [isQuerying, setIsQuerying] = useState(false);
  const [isSettingsModalOpen, setIsSettingsModalOpen] = useState(false);
  const [modalFeedback, setModalFeedback] = useState<{ type: 'info' | 'error' | 'success'; message: string } | null>(null);
  const filesRequestController = useRef<AbortController | null>(null);
  const automaticSelectionRef = useRef<{ source: string; file: string } | null>(null);

  const fetchSources = () => {
    fetch('/api/local/data/sources')
      .then(res => res.json())
      .then(data => {
        const list = Array.isArray(data.sources) && data.sources.length > 0 ? data.sources : ['Autocom', 'BJTU'];
        setSources(list);
        if (!selectedSource || !list.includes(selectedSource)) {
          setSelectedSource(list[0]);
        }
      })
      .catch((err) => {
        console.warn('Sources API fallback to Autocom & BJTU', err);
        setSources(['Autocom', 'BJTU']);
        if (!selectedSource) setSelectedSource('Autocom');
      });
  };

  useEffect(() => {
    fetchSources();
  }, []);

  const fetchAvailableFiles = useCallback(async (source: string, resetSelection = false) => {
    if (!source) return;
    if (filesRequestController.current) {
      if (!resetSelection) return;
      filesRequestController.current.abort();
    }

    const controller = new AbortController();
    filesRequestController.current = controller;
    const timeoutId = window.setTimeout(() => controller.abort(), 3000);
    try {
      const response = await fetch(
        `/api/local/data/sources/${encodeURIComponent(source)}/files`,
        { signal: controller.signal, cache: 'no-store' },
      );
      if (!response.ok) throw new Error(`HTTP ${response.status}`);
      const data = await response.json();
      const rawFiles: unknown[] = Array.isArray(data.files) ? data.files : [];
      const files = rawFiles
        .filter((file: unknown): file is string => typeof file === 'string')
        .sort((a: string, b: string) => b.localeCompare(a));

      setAvailableFiles(previousFiles => {
        setSelectedFiles(previousSelection => {
          if (resetSelection) {
            const automaticSelection = automaticSelectionRef.current;
            if (
              automaticSelection?.source === source &&
              files.includes(automaticSelection.file)
            ) {
              return [automaticSelection.file];
            }
            return files;
          }
          const retained = previousSelection.filter(file => files.includes(file));
          const newlyDiscovered = files.filter(file => !previousFiles.includes(file));
          return Array.from(new Set([...retained, ...newlyDiscovered]));
        });
        return files;
      });
    } catch (error) {
      if (!(error instanceof DOMException && error.name === 'AbortError')) {
        console.warn('Failed to refresh files for', source, error);
      }
    } finally {
      window.clearTimeout(timeoutId);
      if (filesRequestController.current === controller) {
        filesRequestController.current = null;
      }
    }
  }, []);

  useEffect(() => {
    if (isSettingsModalOpen) {
      fetchSources();
      setModalFeedback(null);
      void fetchAvailableFiles(selectedSource);
      const intervalId = window.setInterval(() => {
        void fetchAvailableFiles(selectedSource);
      }, 2000);
      return () => {
        window.clearInterval(intervalId);
        filesRequestController.current?.abort();
        filesRequestController.current = null;
      };
    }
  }, [isSettingsModalOpen, selectedSource, fetchAvailableFiles]);

  useEffect(() => {
    if (selectedSource) {
      setAvailableFiles([]);
      setSelectedFiles([]);
      void fetchAvailableFiles(selectedSource, true);
    } else {
      setAvailableFiles([]);
      setSelectedFiles([]);
    }
  }, [selectedSource, fetchAvailableFiles]);

  const handleLoadFiles = async () => {
    if (!selectedSource || selectedFiles.length === 0) return;
    setModalFeedback(null);
    try {
      const res = await fetch('/api/local/data/files/stats', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ source: selectedSource, files: selectedFiles })
      });
      const data = await res.json();
      if (data.minTime && data.maxTime) {
        setStartTime(data.minTime);
        setEndTime(data.maxTime);
        setModalFeedback({
          type: 'success',
          message: `已自动填充时间范围: ${data.minTime} 至 ${data.maxTime}`
        });
      } else {
        setModalFeedback({
          type: 'info',
          message: '未能在选中文件中获取到有效时间戳，请手动填写时间范围'
        });
      }
    } catch (err: any) {
      setModalFeedback({
        type: 'error',
        message: '加载时间范围失败: ' + (err.message || '网络连接错误')
      });
    }
  };

  const handleConfirmQuery = async () => {
    if (!selectedSource || selectedFiles.length === 0) return;
    setIsQuerying(true);
    setModalFeedback(null);
    try {
      const res = await fetch('/api/local/data/files/query', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ source: selectedSource, files: selectedFiles, startTime, endTime })
      });
      const data = await res.json();
      if (!res.ok || !Array.isArray(data.data)) {
        throw new Error(data.error || '查询响应无效');
      }
      onQueryResult(data.data);
      if (data.data.length > 0) {
        setIsSettingsModalOpen(false);
      } else {
        setModalFeedback({
          type: 'error',
          message: '该时间范围内没有查询到匹配数据，请调整时间范围后重试'
        });
      }
    } catch (err: any) {
      setModalFeedback({
        type: 'error',
        message: '查询失败: ' + (err.message || '网络连接异常')
      });
    } finally {
      setIsQuerying(false);
    }
  };

  useEffect(() => {
    if (!autoCsvSelection) return;
    automaticSelectionRef.current = {
      source: autoCsvSelection.source,
      file: autoCsvSelection.file,
    };
    setSelectedSource(autoCsvSelection.source);
    setSelectedFiles([autoCsvSelection.file]);
    setStartTime('');
    setEndTime('');

    let cancelled = false;
    const loadLatestMergedCsv = async () => {
      try {
        await fetchAvailableFiles(autoCsvSelection.source, true);
        const [statsResponse, queryResponse] = await Promise.all([
          fetch('/api/local/data/files/stats', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
              source: autoCsvSelection.source,
              files: [autoCsvSelection.file],
            }),
          }),
          fetch('/api/local/data/files/query', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
              source: autoCsvSelection.source,
              files: [autoCsvSelection.file],
              startTime: '',
              endTime: '',
            }),
          }),
        ]);
        const stats = await statsResponse.json();
        const query = await queryResponse.json();
        if (!statsResponse.ok) throw new Error(stats.error || '读取时间范围失败');
        if (!queryResponse.ok || !Array.isArray(query.data)) {
          throw new Error(query.error || '读取融合 CSV 失败');
        }
        if (cancelled) return;
        setStartTime(stats.minTime || '');
        setEndTime(stats.maxTime || '');
        setSelectedFiles([autoCsvSelection.file]);
        onQueryResult(query.data);
        setModalFeedback({
          type: query.data.length > 0 ? 'success' : 'error',
          message: query.data.length > 0
            ? `已自动加载最新融合文件: ${autoCsvSelection.file}`
            : `最新融合文件没有可展示的数据: ${autoCsvSelection.file}`,
        });
      } catch (error: any) {
        if (cancelled) return;
        setModalFeedback({
          type: 'error',
          message: `自动加载最新融合文件失败: ${error.message || error}`,
        });
      }
    };
    void loadLatestMergedCsv();
    return () => {
      cancelled = true;
    };
  }, [autoCsvSelection?.mergedAt, fetchAvailableFiles, onQueryResult]);

  // Distribution View State
  const [leftDistMetric, setLeftDistMetric] = useState<string>('rsrp_dbm');
  const [leftDistType, setLeftDistType] = useState<'histogram' | 'cdf'>('histogram');
  const [rightDistMetric, setRightDistMetric] = useState<string>('throughput_bps');
  const [rightDistType, setRightDistType] = useState<'histogram' | 'cdf'>('cdf');

  const [leftHistConfig, setLeftHistConfig] = useState({ min: '0', max: '100', step: '10' });
  const [rightHistConfig, setRightHistConfig] = useState({ min: '0', max: '100', step: '10' });

  useEffect(() => {
      const defs = calculateDefaults(leftDistMetric, activeData);
      setLeftHistConfig({ min: String(defs.min), max: String(defs.max), step: String(defs.step) });
  }, [leftDistMetric, activeData]);

  useEffect(() => {
      const defs = calculateDefaults(rightDistMetric, activeData);
      setRightHistConfig({ min: String(defs.min), max: String(defs.max), step: String(defs.step) });
  }, [rightDistMetric, activeData]);

  const parsedLeftConfig = useMemo(() => {
     const m = parseFloat(leftHistConfig.min);
     const max = parseFloat(leftHistConfig.max);
     const s = parseFloat(leftHistConfig.step);
     return { min: isNaN(m) ? 0 : m, max: isNaN(max) ? 100 : max, step: isNaN(s) || s === 0 ? 10 : s };
  }, [leftHistConfig]);

  const parsedRightConfig = useMemo(() => {
     const m = parseFloat(rightHistConfig.min);
     const max = parseFloat(rightHistConfig.max);
     const s = parseFloat(rightHistConfig.step);
     return { min: isNaN(m) ? 0 : m, max: isNaN(max) ? 100 : max, step: isNaN(s) || s === 0 ? 10 : s };
  }, [rightHistConfig]);

  const leftDistData = useMemo(() => calculateDistributionData(activeData, leftDistMetric, leftDistType, parsedLeftConfig), [activeData, leftDistMetric, leftDistType, parsedLeftConfig]);
  const rightDistData = useMemo(() => calculateDistributionData(activeData, rightDistMetric, rightDistType, parsedRightConfig), [activeData, rightDistMetric, rightDistType, parsedRightConfig]);

  useEffect(() => {
    setCurrentIndex(0);
  }, [csvData]);

  // Advance through the queried CSV at one row per second.
  useEffect(() => {
    if (!isActive || activeData.length === 0 || viewMode !== 'timeseries') return;
    
    const interval = setInterval(() => {
      setCurrentIndex(prev => {
        if (prev >= activeData.length - 1) return 0;
        return prev + 1;
      });
    }, 1000);

    return () => clearInterval(interval);
  }, [viewMode, isActive, activeData]);

  // Optionally auto-scroll the network info to top when new data arrives
  useEffect(() => {
    if (viewMode === 'timeseries') {
      if (wirelessScrollRef.current) wirelessScrollRef.current.scrollTop = 0;
      if (networkScrollRef.current) networkScrollRef.current.scrollTop = 0;
    }
  }, [currentIndex, viewMode]);

  const wirelessData = useMemo(() => {
    if (activeData.length === 0) return [];
    const startIndex = Math.max(0, currentIndex - 15);
    const points = activeData.slice(startIndex, currentIndex + 1).reverse();
    return points.flatMap(point => [
      { time: point.timestamp, type: 'RSRP', info: point.rsrp_dbm !== null ? `${point.rsrp_dbm} dBm` : '--' },
      { time: point.timestamp, type: 'SINR', info: point.sinr_db !== null ? `${point.sinr_db} dB` : '--' },
      { time: point.timestamp, type: 'RSRQ', info: point.rsrq_db !== null ? `${point.rsrq_db} dB` : '--' },
      { time: point.timestamp, type: 'RSSI', info: point.rssi_dbm !== null ? `${point.rssi_dbm} dBm` : '--' },
    ]);
  }, [activeData, currentIndex]);

  // Transform the queried CSV into the 4-row format for Network Info.
  const networkData = useMemo(() => {
    if (activeData.length === 0) return [];
    
    const startIndex = Math.max(0, currentIndex - 15);
    const points = activeData.slice(startIndex, currentIndex + 1).reverse();
    
    // For each point, create 4 rows as requested
    return points.flatMap(d => [
      { time: d.timestamp, type: 'avg_rtt_ms', info: d.avg_rtt_ms !== null ? `${d.avg_rtt_ms} ms` : '--' },
      { time: d.timestamp, type: 'jitter_ms', info: d.jitter_ms !== null ? `${d.jitter_ms} ms` : '--' },
      { time: d.timestamp, type: 'throughput_bps', info: d.throughput_bps !== null ? `${d.throughput_bps} bps` : '--' },
      { time: d.timestamp, type: 'loss_rate', info: d.loss_rate !== null ? `${d.loss_rate} %` : '--' },
    ]);
  }, [activeData, currentIndex]);

  // Prepare chart data for the last 30 points up to currentIndex
  const chartData = useMemo(() => {
    if (activeData.length === 0) return [];
    const startIndex = Math.max(0, currentIndex - 30);
    return activeData.slice(startIndex, currentIndex + 1).map(point => ({
      time: point.timestamp.split(' ')[1] || point.timestamp,
      leftValue: point[leftChartMetric],
      rightValue: point[rightChartMetric],
    }));
  }, [activeData, currentIndex, leftChartMetric, rightChartMetric]);

  const wirelessSummary = useMemo(() => summarizeData(activeData, [
    { key: 'rsrp_dbm', name: 'RSRP', unit: 'dBm', decimals: 2 },
    { key: 'sinr_db', name: 'SINR', unit: 'dB', decimals: 2 },
    { key: 'rsrq_db', name: 'RSRQ', unit: 'dB', decimals: 2 },
    { key: 'rssi_dbm', name: 'RSSI', unit: 'dBm', decimals: 2 },
  ]), [activeData]);

  const networkSummary = useMemo(() => summarizeData(activeData, [
    { key: 'avg_rtt_ms', name: 'RTT', unit: 'ms', decimals: 3 },
    { key: 'jitter_ms', name: '抖动', unit: 'ms', decimals: 3 },
    { key: 'throughput_bps', name: '吞吐', unit: 'Mbps', decimals: 2, transform: value => value / 1_000_000 },
    { key: 'loss_rate', name: '丢包率', unit: '%', decimals: 3, transform: value => value * 100 },
  ]), [activeData]);

  const formatSummaryValue = (value: number | null, decimals: number) =>
    value === null ? '--' : value.toFixed(decimals);

  const renderDistributionChart = (data: any[], type: 'histogram' | 'cdf', metric: string, color: string) => {
    if (type === 'histogram') {
      return (
        <ResponsiveContainer width="100%" height="100%">
          <ComposedChart data={data} margin={{ top: 20, right: 10, left: -20, bottom: 20 }}>
            <CartesianGrid strokeDasharray="3 3" stroke="#334155" vertical={false} />
            <XAxis dataKey="name" stroke="#64748b" fontSize={10} />
            <YAxis stroke="#64748b" fontSize={10} />
            <Tooltip 
              contentStyle={{ backgroundColor: '#0f172a', borderColor: '#334155', fontSize: '12px' }}
              itemStyle={{ color: color }}
              labelStyle={{ color: '#94a3b8', marginBottom: '4px' }}
              formatter={(value: number) => [`${value} 频次`, '数量']}
              labelFormatter={(label, payload) => payload?.[0]?.payload?.range || label}
            />
            <Bar dataKey="count" fill={color} fillOpacity={0.4} radius={[2, 2, 0, 0]} barSize={24} />
            <Line type="monotone" dataKey="count" stroke={color} strokeWidth={2} dot={{ r: 3, fill: '#1e293b', stroke: color, strokeWidth: 2 }} isAnimationActive={false} />
          </ComposedChart>
        </ResponsiveContainer>
      );
    } else {
      return (
        <ResponsiveContainer width="100%" height="100%">
          <LineChart data={data} margin={{ top: 20, right: 10, left: -20, bottom: 20 }}>
            <CartesianGrid strokeDasharray="3 3" stroke="#334155" vertical={false} />
            <XAxis dataKey="value" stroke="#64748b" fontSize={10} type="number" domain={['dataMin', 'dataMax']} tickFormatter={(v) => v.toFixed(1)} />
            <YAxis stroke="#64748b" fontSize={10} domain={[0, 100]} />
            <Tooltip 
              contentStyle={{ backgroundColor: '#0f172a', borderColor: '#334155', fontSize: '12px' }}
              itemStyle={{ color: color }}
              labelStyle={{ color: '#94a3b8', marginBottom: '4px' }}
              formatter={(value: number) => [`${value}%`, '累积占比']}
              labelFormatter={(label) => `${metric}: ${Number(label).toFixed(2)}`}
            />
            <Line type="stepAfter" dataKey="percentile" stroke={color} strokeWidth={2} dot={false} isAnimationActive={false} />
          </LineChart>
        </ResponsiveContainer>
      );
    }
  };


  return (
    <div className="h-full flex flex-col gap-4 bg-diag-bg rounded-xl overflow-hidden p-4 text-gray-200 font-sans">
      
      {/* Header with View Toggle */}
      <div className="flex justify-between items-center shrink-0">
        <h2 className="text-lg font-bold text-white tracking-wider flex items-center gap-2">
      {viewMode === 'timeseries' ? (
            <Activity className="w-5 h-5 text-diag-accent" />
          ) : viewMode === 'distribution' ? (
            <BarChart2 className="w-5 h-5 text-purple-400" />
          ) : (
            <LayoutDashboard className="w-5 h-5 text-cyan-400" />
          )}
          {viewMode === 'timeseries'
            ? '数据可视化视图'
            : viewMode === 'distribution'
              ? '长尾效应数据分布'
              : '数据总览页面'}
        </h2>
        <div className="flex bg-black/40 rounded-lg p-1 border border-white/5">
          <button
            onClick={() => setIsSettingsModalOpen(true)}
            className="px-3 py-1.5 rounded-md text-xs font-bold transition-all flex items-center gap-2 text-purple-300 hover:bg-purple-500/15 hover:text-purple-200"
          >
            <Settings className="w-3.5 h-3.5" /> 数据源设置
          </button>
          <div className="mx-1 my-1 w-px bg-white/10" />
          <button
            onClick={() => setViewMode('timeseries')}
            className={cn(
              "px-3 py-1.5 rounded-md text-xs font-bold transition-all flex items-center gap-2",
              viewMode === 'timeseries' ? "bg-diag-accent text-black shadow-md" : "text-gray-400 hover:text-white"
            )}
          >
            <SplitSquareHorizontal className="w-3.5 h-3.5" /> 时序推演
          </button>
          <button
            onClick={() => setViewMode('distribution')}
            className={cn(
              "px-3 py-1.5 rounded-md text-xs font-bold transition-all flex items-center gap-2",
              viewMode === 'distribution' ? "bg-purple-500 text-white shadow-md" : "text-gray-400 hover:text-white"
            )}
          >
            <BarChart2 className="w-3.5 h-3.5" /> 分布特征
          </button>
          <button
            onClick={() => setViewMode('overview')}
            className={cn(
              "px-3 py-1.5 rounded-md text-xs font-bold transition-all flex items-center gap-2",
              viewMode === 'overview' ? "bg-cyan-500 text-slate-950 shadow-md" : "text-gray-400 hover:text-white"
            )}
          >
            <LayoutDashboard className="w-3.5 h-3.5" /> 数据总览
          </button>
        </div>
      </div>

          {/* Settings Modal */}
      {isSettingsModalOpen && (
         <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/60 backdrop-blur-sm">
            <div className="bg-[#0f172a] border border-white/10 rounded-xl w-[550px] shadow-2xl flex flex-col max-h-[90vh]">
               <div className="flex justify-between items-center p-4 border-b border-white/10">
                   <h3 className="text-sm font-bold text-white flex items-center gap-2">
                      <Database className="w-4 h-4 text-purple-400" /> 数据源配置
                   </h3>
                   <button onClick={() => setIsSettingsModalOpen(false)} className="text-gray-400 hover:text-white">
                      <X className="w-4 h-4" />
                   </button>
               </div>
               
               <div className="p-4 flex flex-col gap-4 overflow-y-auto custom-scrollbar">
                 {modalFeedback && (
                   <div className={cn(
                     "p-3 rounded-lg text-xs border flex items-center justify-between",
                     modalFeedback.type === 'success' && "bg-green-500/10 border-green-500/30 text-green-300",
                     modalFeedback.type === 'error' && "bg-red-500/10 border-red-500/30 text-red-300",
                     modalFeedback.type === 'info' && "bg-blue-500/10 border-blue-500/30 text-blue-300"
                   )}>
                     <span>{modalFeedback.message}</span>
                     <button onClick={() => setModalFeedback(null)} className="text-gray-400 hover:text-white ml-2">×</button>
                   </div>
                 )}

                 <div className="flex items-center gap-2">
                   <span className="text-xs text-gray-400 w-16">选择设备:</span>
                   <select
                     className="flex-1 bg-black/50 border border-white/10 rounded-md px-3 py-1.5 text-xs font-medium text-white focus:outline-none focus:border-purple-400 cursor-pointer"
                     value={selectedSource}
                     onChange={e => {
                       automaticSelectionRef.current = null;
                       setSelectedSource(e.target.value);
                     }}
                   >
                     {sources.map(src => (
                       <option key={src} value={src}>{src}</option>
                     ))}
                   </select>
                 </div>
                 
                 {availableFiles.length > 0 && (
                   <div className="flex items-start gap-2">
                     <div className="w-16 mt-1 flex flex-col gap-1">
                       <span className="text-xs text-gray-400">选择文件:</span>
                       <button
                         type="button"
                         onClick={() => {
                           if (selectedFiles.length === availableFiles.length) {
                             setSelectedFiles([]);
                           } else {
                             setSelectedFiles([...availableFiles]);
                           }
                         }}
                         className="text-[10px] text-purple-400 hover:text-purple-300 text-left underline cursor-pointer"
                       >
                         {selectedFiles.length === availableFiles.length ? "取消全选" : "全选"}
                       </button>
                     </div>
                     <div className="flex-1 flex flex-col gap-2 p-2 border border-white/10 rounded-md bg-black/30 max-h-40 overflow-y-auto custom-scrollbar">
                       {availableFiles.map(file => (
                         <label key={file} className="flex items-center gap-2 text-xs text-gray-300 cursor-pointer px-2 py-1 hover:bg-white/5 rounded">
                           <input 
                             type="checkbox" 
                             className="accent-purple-500 rounded-sm cursor-pointer"
                             checked={selectedFiles.includes(file)}
                             onChange={(e) => {
                               if (e.target.checked) setSelectedFiles(prev => [...prev, file]);
                               else setSelectedFiles(prev => prev.filter(f => f !== file));
                             }}
                           />
                           <span className="truncate">{file}</span>
                         </label>
                       ))}
                     </div>
                   </div>
                 )}

                 <div className="flex justify-end">
                   <button 
                     className="bg-blue-600 hover:bg-blue-500 text-white px-4 py-1.5 rounded-md text-xs font-bold transition-all disabled:opacity-50 flex items-center gap-1 cursor-pointer"
                     onClick={handleLoadFiles}
                     disabled={!selectedSource || selectedFiles.length === 0}
                   >
                     <FolderOpen className="w-3.5 h-3.5" /> 加载时间范围
                   </button>
                 </div>

                 <div className="flex flex-col gap-3 bg-black/30 p-3 rounded-lg border border-white/5 mt-2">
                   <div className="text-xs text-gray-400 flex items-center gap-1">
                      <Clock className="w-3.5 h-3.5 text-orange-400" /> 时间范围设置
                   </div>
                   <div className="flex items-center gap-2">
                     <input 
                       type="text" 
                       className="flex-1 bg-black/50 border border-white/10 rounded px-2 py-1.5 text-xs text-white focus:border-purple-400 focus:outline-none" 
                       value={startTime}
                       onChange={e => setStartTime(e.target.value)}
                       placeholder="开始时间 YYYY-MM-DD HH:mm:ss"
                     />
                     <span className="text-gray-500 text-xs">至</span>
                     <input 
                       type="text" 
                       className="flex-1 bg-black/50 border border-white/10 rounded px-2 py-1.5 text-xs text-white focus:border-purple-400 focus:outline-none" 
                       value={endTime}
                       onChange={e => setEndTime(e.target.value)}
                       placeholder="结束时间 YYYY-MM-DD HH:mm:ss"
                     />
                   </div>
                 </div>
               </div>

               <div className="p-4 border-t border-white/10 flex justify-end gap-2 bg-[#1e293b]/30">
                   <button 
                     onClick={() => setIsSettingsModalOpen(false)} 
                     className="px-4 py-1.5 rounded-md text-xs font-bold text-gray-300 hover:text-white hover:bg-white/5 transition-all"
                   >
                     取消
                   </button>
                   <button 
                     className="bg-purple-600 hover:bg-purple-500 text-white px-4 py-1.5 rounded-md text-xs font-bold transition-all disabled:opacity-50 flex items-center gap-1"
                     onClick={handleConfirmQuery}
                     disabled={isQuerying || !selectedSource || selectedFiles.length === 0}
                   >
                     <CheckCircle className="w-3.5 h-3.5" /> {isQuerying ? '处理中...' : '确认并分析'}
                   </button>
               </div>
            </div>
         </div>
      )}


      {viewMode === 'timeseries' ? (
        <>
          {/* Top Half: Lists (Existing Layout) */}
          <div className="flex-1 min-h-0 grid grid-cols-2 gap-4">
            
            {/* Wireless Info Panel */}
            <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl overflow-hidden flex flex-col shadow-inner backdrop-blur-sm">
              <div className="h-9 bg-[#1e293b] border-b border-white/10 flex items-center px-4 shrink-0 justify-between">
                <h3 className="text-xs font-bold text-white flex items-center gap-2">
                  <Radio className="w-4 h-4 text-blue-400" /> Wireless Info
                </h3>
                <span className="text-[10px] text-blue-400 font-mono flex items-center gap-1">
                  <span className="w-2 h-2 rounded-full bg-blue-500 animate-pulse"></span>
                  Live Feed
                </span>
              </div>
              <div ref={wirelessScrollRef} className="flex-1 overflow-auto custom-scrollbar">
                <table className="w-full text-left border-collapse text-xs">
                  <thead className="sticky top-0 bg-[#0f172a] shadow">
                    <tr>
                      <th className="py-2 px-4 font-semibold text-gray-400 w-2/5">Time</th>
                      <th className="py-2 px-4 font-semibold text-gray-400 w-2/5">Type</th>
                      <th className="py-2 px-4 font-semibold text-gray-400 w-1/5">Info</th>
                    </tr>
                  </thead>
                  <tbody className="divide-y divide-white/5">
                    {wirelessData.map((row, i) => (
                      <tr key={`${row.time}-${row.type}-${i}`} className="hover:bg-white/5 transition-colors">
                        <td className="py-2 px-4 text-gray-400 font-mono">{row.time}</td>
                        <td className="py-2 px-4 text-gray-200">{row.type}</td>
                        <td className="py-2 px-4 text-blue-400 font-mono">{row.info}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </div>

            {/* Network Info Panel (Real data.csv stream) */}
            <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl overflow-hidden flex flex-col shadow-inner backdrop-blur-sm">
              <div className="h-9 bg-[#1e293b] border-b border-white/10 flex items-center px-4 shrink-0 justify-between">
                <h3 className="text-xs font-bold text-white flex items-center gap-2">
                  <Network className="w-4 h-4 text-green-400" /> Network Info
                </h3>
                <span className="text-[10px] text-green-400 font-mono flex items-center gap-1">
                  <span className="w-2 h-2 rounded-full bg-green-500 animate-pulse"></span>
                  Live Feed
                </span>
              </div>
              <div ref={networkScrollRef} className="flex-1 overflow-auto custom-scrollbar">
                <table className="w-full text-left border-collapse text-xs">
                  <thead className="sticky top-0 bg-[#0f172a] shadow">
                    <tr>
                      <th className="py-2 px-4 font-semibold text-gray-400 w-2/5">Time</th>
                      <th className="py-2 px-4 font-semibold text-gray-400 w-2/5">Type</th>
                      <th className="py-2 px-4 font-semibold text-gray-400 w-1/5">Info</th>
                    </tr>
                  </thead>
                  <tbody className="divide-y divide-white/5">
                    {networkData.map((row, i) => (
                      <tr key={`${row.time}-${row.type}-${i}`} className="hover:bg-white/5 transition-colors">
                        <td className="py-2 px-4 text-gray-400 font-mono">{row.time}</td>
                        <td className="py-2 px-4 text-gray-200">{row.type}</td>
                        <td className="py-2 px-4 text-diag-accent font-mono">{row.info}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </div>

          </div>

          {/* Bottom Half: Charts (Linked to data.csv) */}
          <div className="h-64 grid grid-cols-2 gap-4 shrink-0">
            
            {/* Left Chart */}
            <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl overflow-hidden flex flex-col shadow-inner backdrop-blur-sm">
              <div className="h-9 bg-[#1e293b] border-b border-white/10 flex items-center px-4 shrink-0 justify-between">
                <div className="flex items-center gap-2">
                  <Activity className="w-4 h-4 text-blue-400" />
                  <select 
                    className="bg-transparent text-xs font-bold text-white focus:outline-none cursor-pointer appearance-none"
                    value={leftChartMetric}
                    onChange={(e) => setLeftChartMetric(e.target.value as WirelessMetric)}
                  >
                    <option value="rsrp_dbm" className="bg-slate-800">RSRP (dBm) ▾</option>
                    <option value="sinr_db" className="bg-slate-800">SINR (dB) ▾</option>
                    <option value="rsrq_db" className="bg-slate-800">RSRQ (dB) ▾</option>
                    <option value="rssi_dbm" className="bg-slate-800">RSSI (dBm) ▾</option>
                  </select>
                </div>
              </div>
              <div className="flex-1 p-2 pt-4">
                <ResponsiveContainer width="100%" height="100%">
                  <AreaChart data={chartData} margin={{ top: 0, right: 0, left: 10, bottom: 0 }}>
                    <defs>
                      <linearGradient id="colorLeft" x1="0" y1="0" x2="0" y2="1">
                        <stop offset="5%" stopColor="#3b82f6" stopOpacity={0.5}/>
                        <stop offset="95%" stopColor="#3b82f6" stopOpacity={0}/>
                      </linearGradient>
                    </defs>
                    <CartesianGrid strokeDasharray="3 3" stroke="rgba(255,255,255,0.1)" vertical={false} />
                    <XAxis dataKey="time" tick={{fontSize: 10, fill: '#64748b'}} tickMargin={8} />
                    <YAxis tick={{fontSize: 10, fill: '#64748b'}} tickMargin={8} />
                    <Tooltip 
                      contentStyle={{ backgroundColor: '#0f172a', borderColor: '#334155', fontSize: '12px' }}
                      itemStyle={{ color: '#3b82f6' }}
                      labelStyle={{ color: '#94a3b8', marginBottom: '4px' }}
                    />
                    <Area type="monotone" dataKey="leftValue" stroke="#3b82f6" strokeWidth={2} fillOpacity={1} fill="url(#colorLeft)" isAnimationActive={false} />
                  </AreaChart>
                </ResponsiveContainer>
              </div>
            </div>

            {/* Right Chart */}
            <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl overflow-hidden flex flex-col shadow-inner backdrop-blur-sm">
              <div className="h-9 bg-[#1e293b] border-b border-white/10 flex items-center px-4 shrink-0 justify-between">
                <div className="flex items-center gap-2">
                  <Activity className="w-4 h-4 text-green-400" />
                  <select 
                    className="bg-transparent text-xs font-bold text-white focus:outline-none cursor-pointer appearance-none"
                    value={rightChartMetric}
                    onChange={(e) => setRightChartMetric(e.target.value as NetworkMetric)}
                  >
                    <option value="throughput_bps" className="bg-slate-800">throughput_bps ▾</option>
                    <option value="avg_rtt_ms" className="bg-slate-800">avg_rtt_ms ▾</option>
                    <option value="jitter_ms" className="bg-slate-800">jitter_ms ▾</option>
                    <option value="loss_rate" className="bg-slate-800">loss_rate ▾</option>
                  </select>
                </div>
              </div>
              <div className="flex-1 p-2 pt-4">
                <ResponsiveContainer width="100%" height="100%">
                  <AreaChart data={chartData} margin={{ top: 0, right: 0, left: 10, bottom: 0 }}>
                    <defs>
                      <linearGradient id="colorRight" x1="0" y1="0" x2="0" y2="1">
                        <stop offset="5%" stopColor="#22c55e" stopOpacity={0.5}/>
                        <stop offset="95%" stopColor="#22c55e" stopOpacity={0}/>
                      </linearGradient>
                    </defs>
                    <CartesianGrid strokeDasharray="3 3" stroke="rgba(255,255,255,0.1)" vertical={false} />
                    <XAxis dataKey="time" tick={{fontSize: 10, fill: '#64748b'}} tickMargin={8} />
                    <YAxis tick={{fontSize: 10, fill: '#64748b'}} tickMargin={8} />
                    <Tooltip 
                      contentStyle={{ backgroundColor: '#0f172a', borderColor: '#334155', fontSize: '12px' }}
                      itemStyle={{ color: '#22c55e' }}
                      labelStyle={{ color: '#94a3b8', marginBottom: '4px' }}
                    />
                    <Area type="monotone" dataKey="rightValue" stroke="#22c55e" strokeWidth={2} fillOpacity={1} fill="url(#colorRight)" isAnimationActive={false} />
                  </AreaChart>
                </ResponsiveContainer>
              </div>
            </div>

          </div>
        </>
      ) : viewMode === 'overview' ? (
        <div className="flex-1 flex flex-col gap-4 min-h-0">
          <div className="flex justify-between items-center bg-[#1e293b]/50 border border-white/10 rounded-xl px-4 py-2 shadow-inner backdrop-blur-sm shrink-0">
            <div className="text-sm font-bold text-white flex items-center gap-2">
              <LayoutDashboard className="w-4 h-4 text-cyan-400" /> 数据统计摘要
              <span className="text-xs text-gray-500 font-normal ml-2">当前数据量: {activeData.length} 条</span>
            </div>
            <div className="text-[11px] text-gray-500 font-mono">
              {startTime && endTime ? `${startTime} — ${endTime}` : '当前已加载数据范围'}
            </div>
          </div>

          <div className="flex-1 grid grid-cols-2 gap-4 min-h-0">
            <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl overflow-hidden flex flex-col shadow-inner backdrop-blur-sm">
              <div className="h-11 bg-[#1e293b] border-b border-white/10 flex items-center px-4 shrink-0 justify-between">
                <h3 className="text-sm font-bold text-white flex items-center gap-2">
                  <Radio className="w-4 h-4 text-blue-400" /> Wireless Info
                </h3>
                <span className="text-[10px] uppercase tracking-widest text-blue-400">Summary</span>
              </div>
              <div className="flex-1 overflow-auto custom-scrollbar">
                <table className="w-full text-left border-collapse text-xs">
                  <thead className="sticky top-0 bg-[#0f172a] shadow">
                    <tr>
                      <th className="py-3 px-4 font-semibold text-gray-400">指标</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">最大值</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">最小值</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">平均值</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">单位</th>
                    </tr>
                  </thead>
                  <tbody className="divide-y divide-white/5">
                    {wirelessSummary.map(row => (
                      <tr key={row.key} className="hover:bg-white/5 transition-colors">
                        <td className="py-4 px-4 font-semibold text-gray-200">{row.name}</td>
                        <td className="py-4 px-4 text-blue-400 font-mono">{formatSummaryValue(row.maximum, row.decimals)}</td>
                        <td className="py-4 px-4 text-blue-400 font-mono">{formatSummaryValue(row.minimum, row.decimals)}</td>
                        <td className="py-4 px-4 text-cyan-300 font-mono">{formatSummaryValue(row.average, row.decimals)}</td>
                        <td className="py-4 px-4 text-gray-500">{row.unit}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </div>

            <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl overflow-hidden flex flex-col shadow-inner backdrop-blur-sm">
              <div className="h-11 bg-[#1e293b] border-b border-white/10 flex items-center px-4 shrink-0 justify-between">
                <h3 className="text-sm font-bold text-white flex items-center gap-2">
                  <Network className="w-4 h-4 text-green-400" /> Network Info
                </h3>
                <span className="text-[10px] uppercase tracking-widest text-green-400">Summary</span>
              </div>
              <div className="flex-1 overflow-auto custom-scrollbar">
                <table className="w-full text-left border-collapse text-xs">
                  <thead className="sticky top-0 bg-[#0f172a] shadow">
                    <tr>
                      <th className="py-3 px-4 font-semibold text-gray-400">指标</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">最大值</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">最小值</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">平均值</th>
                      <th className="py-3 px-4 font-semibold text-gray-400">单位</th>
                    </tr>
                  </thead>
                  <tbody className="divide-y divide-white/5">
                    {networkSummary.map(row => (
                      <tr key={row.key} className="hover:bg-white/5 transition-colors">
                        <td className="py-4 px-4 font-semibold text-gray-200">{row.name}</td>
                        <td className="py-4 px-4 text-green-400 font-mono">{formatSummaryValue(row.maximum, row.decimals)}</td>
                        <td className="py-4 px-4 text-green-400 font-mono">{formatSummaryValue(row.minimum, row.decimals)}</td>
                        <td className="py-4 px-4 text-emerald-300 font-mono">{formatSummaryValue(row.average, row.decimals)}</td>
                        <td className="py-4 px-4 text-gray-500">{row.unit}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      ) : (
        <div className="flex-1 flex flex-col gap-4 min-h-0">
          {/* Distribution View Header */}
          <div className="flex items-center bg-[#1e293b]/50 border border-white/10 rounded-xl px-4 py-2 shadow-inner backdrop-blur-sm shrink-0">
             <div className="text-sm font-bold text-white flex items-center gap-2">
                <BarChart2 className="w-4 h-4 text-purple-400" /> 分布特征分析
                <span className="text-xs text-gray-500 font-normal ml-2">当前数据量: {activeData.length} 条</span>
             </div>
          </div>

          <div className="flex-1 grid grid-cols-2 gap-4 min-h-0">
          {/* Left Distribution Panel */}
          <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl flex flex-col p-4 shadow-inner backdrop-blur-sm">
            <div className="flex justify-between items-start mb-4">
               <h3 className="text-sm font-bold text-white flex items-center gap-2 mt-1">
                  <Radio className="w-4 h-4 text-blue-400" /> 无线侧长尾数据特征
               </h3>
               <div className="flex flex-col gap-2 items-end">
                 <div className="flex gap-2">
                   <select 
                      className="bg-black/50 border border-white/10 rounded-md px-3 py-1.5 text-xs font-medium text-white focus:outline-none focus:border-blue-400 cursor-pointer appearance-none"
                      value={leftDistMetric}
                      onChange={(e) => setLeftDistMetric(e.target.value as any)}
                    >
                      <option value="rsrp_dbm">RSRP (dBm) ▾</option>
                      <option value="sinr_db">SINR (dB) ▾</option>
                      <option value="rsrq_db">RSRQ (dB) ▾</option>
                      <option value="rssi_dbm">RSSI (dBm) ▾</option>
                    </select>
                    <select 
                      className="bg-black/50 border border-white/10 rounded-md px-3 py-1.5 text-xs font-medium text-white focus:outline-none focus:border-blue-400 cursor-pointer appearance-none"
                      value={leftDistType}
                      onChange={(e) => setLeftDistType(e.target.value as any)}
                    >
                      <option value="histogram">区间频次分布图 (柱状图) ▾</option>
                      <option value="cdf">累积分布函数图 (CFD) ▾</option>
                    </select>
                 </div>
                 {leftDistType === 'histogram' && (
                    <div className="flex gap-2 items-center text-[10px] text-gray-400">
                       <span>X轴:</span>
                       <input type="number" step="any" className="w-16 bg-black/50 border border-white/10 rounded px-1.5 py-1 text-white focus:border-blue-400 focus:outline-none" placeholder="min" value={leftHistConfig.min} onChange={e => setLeftHistConfig(prev => ({...prev, min: e.target.value}))} />
                       <span>-</span>
                       <input type="number" step="any" className="w-16 bg-black/50 border border-white/10 rounded px-1.5 py-1 text-white focus:border-blue-400 focus:outline-none" placeholder="max" value={leftHistConfig.max} onChange={e => setLeftHistConfig(prev => ({...prev, max: e.target.value}))} />
                       <span className="ml-1">Step:</span>
                       <input type="number" step="any" className="w-16 bg-black/50 border border-white/10 rounded px-1.5 py-1 text-white focus:border-blue-400 focus:outline-none" placeholder="step" value={leftHistConfig.step} onChange={e => setLeftHistConfig(prev => ({...prev, step: e.target.value}))} />
                    </div>
                 )}
               </div>
            </div>
            <div className="flex-1 min-h-0">
                {renderDistributionChart(leftDistData, leftDistType, leftDistMetric, '#3b82f6')}
            </div>
          </div>

          {/* Right Distribution Panel */}
          <div className="bg-[#1e293b]/50 border border-white/10 rounded-xl flex flex-col p-4 shadow-inner backdrop-blur-sm">
             <div className="flex justify-between items-start mb-4">
               <h3 className="text-sm font-bold text-white flex items-center gap-2 mt-1">
                  <Network className="w-4 h-4 text-green-400" /> 网络侧长尾数据特征
               </h3>
               <div className="flex flex-col gap-2 items-end">
                 <div className="flex gap-2">
                   <select 
                      className="bg-black/50 border border-white/10 rounded-md px-3 py-1.5 text-xs font-medium text-white focus:outline-none focus:border-green-400 cursor-pointer appearance-none"
                      value={rightDistMetric}
                      onChange={(e) => setRightDistMetric(e.target.value as any)}
                    >
                      <option value="throughput_bps">throughput_bps (吞吐) ▾</option>
                      <option value="avg_rtt_ms">avg_rtt_ms (延迟) ▾</option>
                      <option value="jitter_ms">jitter_ms (抖动) ▾</option>
                      <option value="loss_rate">loss_rate (丢包) ▾</option>
                    </select>
                    <select 
                      className="bg-black/50 border border-white/10 rounded-md px-3 py-1.5 text-xs font-medium text-white focus:outline-none focus:border-green-400 cursor-pointer appearance-none"
                      value={rightDistType}
                      onChange={(e) => setRightDistType(e.target.value as any)}
                    >
                      <option value="cdf">累积分布函数图 (CFD) ▾</option>
                      <option value="histogram">区间频次分布图 (柱状图) ▾</option>
                    </select>
                 </div>
                 {rightDistType === 'histogram' && (
                    <div className="flex gap-2 items-center text-[10px] text-gray-400">
                       <span>X轴:</span>
                       <input type="number" step="any" className="w-16 bg-black/50 border border-white/10 rounded px-1.5 py-1 text-white focus:border-green-400 focus:outline-none" placeholder="min" value={rightHistConfig.min} onChange={e => setRightHistConfig(prev => ({...prev, min: e.target.value}))} />
                       <span>-</span>
                       <input type="number" step="any" className="w-16 bg-black/50 border border-white/10 rounded px-1.5 py-1 text-white focus:border-green-400 focus:outline-none" placeholder="max" value={rightHistConfig.max} onChange={e => setRightHistConfig(prev => ({...prev, max: e.target.value}))} />
                       <span className="ml-1">Step:</span>
                       <input type="number" step="any" className="w-16 bg-black/50 border border-white/10 rounded px-1.5 py-1 text-white focus:border-green-400 focus:outline-none" placeholder="step" value={rightHistConfig.step} onChange={e => setRightHistConfig(prev => ({...prev, step: e.target.value}))} />
                    </div>
                 )}
               </div>
            </div>
            <div className="flex-1 min-h-0">
                {renderDistributionChart(rightDistData, rightDistType, rightDistMetric, '#22c55e')}
            </div>
          </div>
        </div>
        </div>
      )}
    </div>
  );
}
