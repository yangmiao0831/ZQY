/** Rows returned by the local CSV query API. Coordinates are already GCJ-02. */
export interface CsvDataPoint {
  timestamp: string;
  avg_rtt_ms: number | null;
  jitter_ms: number | null;
  throughput_bps: number | null;
  loss_rate: number | null;
  gcj02_latitude: number | null;
  gcj02_longitude: number | null;
  rsrp_dbm: number | null;
  sinr_db: number | null;
  rsrq_db: number | null;
  rssi_dbm: number | null;
}
