const fs = require('fs');

const points = [];
let index = 0;
let baseTime = new Date('2026-08-22T03:22:00Z').getTime();

function addSegment(start, end, numPoints) {
    for(let i = 0; i < numPoints; i++) {
        const t = i / numPoints;
        const lng = start[0] + (end[0] - start[0]) * t;
        const lat = start[1] + (end[1] - start[1]) * t;
        
        // Add tiny random noise to make the path look realistic (not perfectly straight)
        const noisyLng = lng + (Math.random() - 0.5) * 0.00003;
        const noisyLat = lat + (Math.random() - 0.5) * 0.00003;

        const date = new Date(baseTime);
        const m = String(date.getMinutes()).padStart(2, '0');
        const s = String(date.getSeconds()).padStart(2, '0');
        const ms = Math.floor(date.getMilliseconds() / 100);

        points.push({
            index: index++,
            timestamp: `${m}:${s}.${ms}`,
            avg_rtt_ms: parseFloat((Math.random() * 20 + 2).toFixed(2)),
            jitter_ms: parseFloat((Math.random() * 10).toFixed(2)),
            throughput_bps: Math.floor(Math.random() * 5000000) + 100000,
            loss_rate: Math.random() < 0.1 ? parseFloat((Math.random() * 0.5).toFixed(3)) : 0,
            latitude: noisyLat,
            longitude: noisyLng
        });
        
        // Advance time by ~1.2 seconds per point
        baseTime += 1200; 
    }
}

// BJTU Loop Coordinates based on map orientation
const start = [116.3435, 39.9516]; // Mid Yinxing
const nw = [116.3415, 39.9513];    // Yinxing & Fanghua
const sw = [116.3420, 39.9485];    // Fanghua & Tianyou
const se = [116.3460, 39.9492];    // Tianyou & Keyuan
const ne = [116.3455, 39.9519];    // Keyuan & Yinxing

// Counter-clockwise
addSegment(start, nw, 10);
addSegment(nw, sw, 25);
addSegment(sw, se, 25);
addSegment(se, ne, 25);
addSegment(ne, start, 10);

// Ensure the last point connects nicely
const date = new Date(baseTime);
points.push({
    index: index++,
    timestamp: `${String(date.getMinutes()).padStart(2, '0')}:${String(date.getSeconds()).padStart(2, '0')}.0`,
    avg_rtt_ms: 2.5,
    jitter_ms: 1.2,
    throughput_bps: 1200000,
    loss_rate: 0,
    latitude: start[1],
    longitude: start[0]
});

const tsContent = `export interface GpsDataPoint {
  index: number;
  timestamp: string;
  avg_rtt_ms: number | null;
  jitter_ms: number | null;
  throughput_bps: number | null;
  loss_rate: number | null;
  latitude: number;
  longitude: number;
}

export const gpsData: GpsDataPoint[] = ${JSON.stringify(points, null, 2)};
`;

fs.writeFileSync('frontend/src/data/gpsData.ts', tsContent);
console.log("Successfully generated realistic campus route data.");
