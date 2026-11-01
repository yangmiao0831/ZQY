const fs = require('fs');

const rawData = [
  // Sequence 1: 15:26:55
  { timestamp: "15:26:55.982", rtt: null, jitter: null, tp: 0.0, loss: null, lat: 39.951524, lng: 116.346085 },
  { timestamp: "15:27:04.182", rtt: 0.177, jitter: 0.118, tp: 4685032.0, loss: 0.0, lat: 39.951523, lng: 116.346085 },
  { timestamp: "15:27:26.048", rtt: 0.109, jitter: null, tp: 144.0, loss: 0.0, lat: 39.951517, lng: 116.346088 },
  { timestamp: "15:28:00.010", rtt: 2.504, jitter: 4.911, tp: 7482048.0, loss: 0.0, lat: 39.951512, lng: 116.346090 },
  { timestamp: "15:28:31.593", rtt: 0.521, jitter: 0.491, tp: 8396856.0, loss: 0.0, lat: 39.951494, lng: 116.346095 },
  { timestamp: "15:29:10.630", rtt: 0.131, jitter: 0.083, tp: 2822936.0, loss: 0.0, lat: 39.951476, lng: 116.346156 },
  { timestamp: "15:29:43.850", rtt: 0.290, jitter: 0.192, tp: 952808.0, loss: 0.0, lat: 39.951477, lng: 116.346158 },
  { timestamp: "15:30:17.166", rtt: 0.834, jitter: 1.551, tp: 8396856.0, loss: 0.0, lat: 39.951477, lng: 116.346159 },
  { timestamp: "15:30:52.546", rtt: 0.082, jitter: null, tp: 136.0, loss: 0.0, lat: 39.951981, lng: 116.346240 },
  { timestamp: "15:31:36.477", rtt: 0.221, jitter: 0.163, tp: 7249888.0, loss: 0.0, lat: 39.957343, lng: 116.346481 },
  { timestamp: "15:32:15.210", rtt: 0.172, jitter: 0.141, tp: 5165712.0, loss: 0.0, lat: 39.967394, lng: 116.352632 },
  { timestamp: "15:33:04.020", rtt: 0.110, jitter: null, tp: 136.0, loss: 0.0, lat: 39.963564, lng: 116.353210 },
  { timestamp: "15:34:25.070", rtt: 0.046, jitter: null, tp: 128.0, loss: 0.0, lat: 39.951724, lng: 116.339054 },
  { timestamp: "15:35:10.011", rtt: 0.093, jitter: null, tp: 152.0, loss: 0.0, lat: 39.951339, lng: 116.337130 },
  { timestamp: "15:36:53.454", rtt: 12.943, jitter: 26.686, tp: 921624.0, loss: 0.0, lat: 39.953739, lng: 116.335872 },

  // Sequence 2: 15:38:34
  { timestamp: "15:38:34.369", rtt: null, jitter: null, tp: 0.0, loss: null, lat: 39.957326, lng: 116.335483 },
  { timestamp: "15:39:10.746", rtt: 0.070, jitter: null, tp: 144.0, loss: 0.0, lat: 39.958327, lng: 116.335325 },
  { timestamp: "15:40:02.040", rtt: 0.405, jitter: 0.599, tp: 8396848.0, loss: 0.0, lat: 39.960428, lng: 116.335111 },
  { timestamp: "15:40:35.210", rtt: 0.078, jitter: null, tp: 136.0, loss: 0.0, lat: 39.961867, lng: 116.334992 },
  { timestamp: "15:41:20.655", rtt: 0.049, jitter: null, tp: 152.0, loss: 0.0, lat: 39.963653, lng: 116.334798 },
  { timestamp: "15:42:07.149", rtt: 52.972, jitter: 79.289, tp: 22968.0, loss: 0.0, lat: 39.965430, lng: 116.334601 },
  { timestamp: "15:43:08.975", rtt: 1.006, jitter: 1.905, tp: 4721472.0, loss: 0.0, lat: 39.967256, lng: 116.334857 },
  { timestamp: "15:44:06.489", rtt: 0.066, jitter: 0.019, tp: 280.0, loss: 0.0, lat: 39.967338, lng: 116.337732 },
  { timestamp: "15:45:00.216", rtt: 0.096, jitter: null, tp: 144.0, loss: 0.0, lat: 39.967332, lng: 116.339530 },
  { timestamp: "15:46:11.010", rtt: 0.084, jitter: null, tp: 144.0, loss: 0.0, lat: 39.967361, lng: 116.342843 },
  { timestamp: "15:47:04.109", rtt: 0.746, jitter: 1.314, tp: 5573608.0, loss: 0.0, lat: 39.967366, lng: 116.344434 },
  { timestamp: "15:48:13.228", rtt: 0.227, jitter: 0.193, tp: 8393496.0, loss: 0.0, lat: 39.967424, lng: 116.347448 },
  { timestamp: "15:48:24.215", rtt: 13.124, jitter: 27.970, tp: 43128.0, loss: 0.0, lat: 39.967410, lng: 116.347782 },

  // Sequence 3: 15:50:03
  { timestamp: "15:50:03.758", rtt: 2.723, jitter: 5.343, tp: 7388264.0, loss: 0.0, lat: 39.967403, lng: 116.351356 },
  { timestamp: "15:50:24.971", rtt: 5.539, jitter: 8.900, tp: 8447760.0, loss: 0.0, lat: 39.967404, lng: 116.352045 },
  { timestamp: "15:51:00.219", rtt: 0.393, jitter: 0.642, tp: 8396856.0, loss: 0.0, lat: 39.967408, lng: 116.352446 },
  { timestamp: "15:51:30.540", rtt: 0.057, jitter: null, tp: 136.0, loss: 0.0, lat: 39.967425, lng: 116.350746 },
  { timestamp: "15:52:03.981", rtt: 0.141, jitter: 0.104, tp: 4679712.0, loss: 0.0, lat: 39.967484, lng: 116.352032 },
  { timestamp: "15:53:06.265", rtt: 0.092, jitter: null, tp: 152.0, loss: 0.0, lat: 39.966318, lng: 116.352979 },
  { timestamp: "15:54:12.756", rtt: 0.073, jitter: null, tp: 136.0, loss: 0.0, lat: 39.966318, lng: 116.352983 },
  { timestamp: "15:55:04.243", rtt: 0.082, jitter: null, tp: 136.0, loss: 0.0, lat: 39.965327, lng: 116.353156 },
  { timestamp: "15:56:04.020", rtt: 0.110, jitter: null, tp: 136.0, loss: 0.0, lat: 39.963564, lng: 116.353210 },
  { timestamp: "15:57:04.092", rtt: 0.046, jitter: null, tp: 120.0, loss: 0.0, lat: 39.960963, lng: 116.353338 },

  // Sequence 4: 16:00:14
  { timestamp: "16:00:14.893", rtt: 0.073, jitter: null, tp: 128.0, loss: 0.0, lat: 39.958286, lng: 116.347520 },
  { timestamp: "16:01:04.805", rtt: 1.646, jitter: 3.169, tp: 8447904.0, loss: 0.0, lat: 39.958019, lng: 116.346378 },
  { timestamp: "16:02:03.950", rtt: 0.070, jitter: null, tp: 144.0, loss: 0.0, lat: 39.956035, lng: 116.346846 },
  { timestamp: "16:03:04.746", rtt: 0.067, jitter: null, tp: 136.0, loss: 0.0, lat: 39.953636, lng: 116.347546 },
  { timestamp: "16:04:02.904", rtt: 2.806, jitter: 5.042, tp: 8439808.0, loss: 0.0, lat: 39.952911, lng: 116.345190 },
  { timestamp: "16:05:01.144", rtt: 1.203, jitter: 2.256, tp: 8388648.0, loss: 0.712, lat: 39.952022, lng: 116.343855 },
  { timestamp: "16:06:01.432", rtt: 0.069, jitter: null, tp: 128.0, loss: 0.0, lat: 39.951589, lng: 116.346335 },
  { timestamp: "16:06:56.620", rtt: 0.425, jitter: 0.682, tp: 7447424.0, loss: 0.0, lat: 39.951473, lng: 116.346102 },
  { timestamp: "16:07:00.501", rtt: 9.223, jitter: 17.992, tp: 43136.0, loss: 0.0, lat: 39.951473, lng: 116.346102 }
];

let currentIndex = 0;
const processed = rawData.map(p => {
  const parts = p.timestamp.split(':');
  const msPart = parts[2].split('.');
  const timestampStr = `${parts[1]}:${msPart[0]}.${msPart[1].substring(0,1)}`;
  
  return {
    index: currentIndex++,
    timestamp: timestampStr,
    real_timestamp: "2026-08-23 " + p.timestamp,
    avg_rtt_ms: p.rtt,
    jitter_ms: p.jitter,
    throughput_bps: p.tp,
    loss_rate: p.loss,
    latitude: p.lat,
    longitude: p.lng
  };
});

const tsContent = `export interface GpsDataPoint {
  index: number;
  timestamp: string;
  real_timestamp?: string;
  avg_rtt_ms: number | null;
  jitter_ms: number | null;
  throughput_bps: number | null;
  loss_rate: number | null;
  latitude: number;
  longitude: number;
}

export const gpsData: GpsDataPoint[] = ${JSON.stringify(processed, null, 2)};
`;

fs.writeFileSync('frontend/src/data/gpsData.ts', tsContent);
console.log('Done generating downsampled gpsData.ts');
