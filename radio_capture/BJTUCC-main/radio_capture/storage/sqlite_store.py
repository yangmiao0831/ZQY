"""SQLite persistence for sessions, raw frames, and decoded records."""

from __future__ import annotations

import json
import sqlite3
from pathlib import Path
from threading import RLock

from radio_capture.models import DecodedRecord, DeviceSessionConfig, FrameEnvelope


class SQLiteStore:
    def __init__(self, path: str | Path):
        self.path = Path(path)
        self.conn: sqlite3.Connection | None = None
        self._lock = RLock()

    def open(self) -> None:
        """创建数据库所在目录，连接 SQLite 文件"""
        with self._lock:
            self.path.parent.mkdir(parents=True, exist_ok=True)
            self.conn = sqlite3.connect(self.path, check_same_thread=False)
            self.create_schema()

    def create_schema(self) -> None:
        with self._lock:
            conn = self._conn()
            conn.executescript(
                """
            CREATE TABLE IF NOT EXISTS capture_session (
                session_id TEXT PRIMARY KEY,
                eq_id INTEGER NOT NULL,
                chip_type TEXT NOT NULL,
                controller_dll TEXT NOT NULL,
                codec_module_id INTEGER,
                started_at TEXT NOT NULL,
                stopped_at TEXT,
                status TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS raw_frame (
                session_id TEXT NOT NULL,
                sequence INTEGER NOT NULL,
                native_cur_time INTEGER NOT NULL,
                receive_time_ns INTEGER NOT NULL,
                log_type INTEGER NOT NULL,
                payload BLOB NOT NULL,
                PRIMARY KEY (session_id, sequence)
            );

            CREATE TABLE IF NOT EXISTS decoded_record (
                session_id TEXT NOT NULL,
                sequence INTEGER NOT NULL,
                module_id INTEGER,
                msg_code INTEGER,
                display_format INTEGER,
                return_code INTEGER NOT NULL,
                standard_bin BLOB,
                detail BLOB,
                normalized_json TEXT,
                error TEXT,
                PRIMARY KEY (session_id, sequence)
            );
                """
            )
            conn.commit()

    def insert_session(self, session_id: str, config: DeviceSessionConfig, status: str, started_at: str) -> None:
        with self._lock:
            conn = self._conn()
            conn.execute(
                """
            INSERT OR REPLACE INTO capture_session
            (session_id, eq_id, chip_type, controller_dll, codec_module_id, started_at, status)
            VALUES (?, ?, ?, ?, ?, ?, ?)
                """,
                (
                    session_id,
                    config.device.eq_id,
                    config.device.chip_type,
                    config.device.controller_dll,
                    config.decoder.codec_module_id,
                    started_at,
                    status,
                ),
            )
            conn.commit()

    def update_session_status(self, session_id: str, status: str, stopped_at: str | None = None) -> None:
        with self._lock:
            conn = self._conn()
            conn.execute(
                "UPDATE capture_session SET status = ?, stopped_at = COALESCE(?, stopped_at) WHERE session_id = ?",
                (status, stopped_at, session_id),
            )
            conn.commit()

    def insert_raw_frame(self, frame: FrameEnvelope) -> None:
        with self._lock:
            conn = self._conn()
            conn.execute(
                """
            INSERT OR REPLACE INTO raw_frame
            (session_id, sequence, native_cur_time, receive_time_ns, log_type, payload)
            VALUES (?, ?, ?, ?, ?, ?)
                """,
                (
                    frame.session_id,
                    frame.sequence,
                    frame.native_cur_time,
                    frame.receive_time_ns,
                    frame.log_type,
                    frame.payload,
                ),
            )

    def insert_decoded_record(self, record: DecodedRecord) -> None:
        with self._lock:
            conn = self._conn()
            conn.execute(
                """
            INSERT OR REPLACE INTO decoded_record
            (session_id, sequence, msg_code, display_format, return_code,
             standard_bin, detail, normalized_json, error)
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)
                """,
                (
                    record.session_id,
                    record.sequence,
                    record.msg_code,
                    record.display_format,
                    record.return_code,
                    record.standard_bin,
                    record.detail,
                    json.dumps(record.normalized, ensure_ascii=False) if record.normalized is not None else None,
                    record.error,
                ),
            )

    def commit(self) -> None:
        with self._lock:
            self._conn().commit()

    def close(self) -> None:
        with self._lock:
            if self.conn:
                self.conn.commit()
                self.conn.close()
                self.conn = None

    def _conn(self) -> sqlite3.Connection:
        if self.conn is None:
            raise RuntimeError("SQLiteStore is not open")
        return self.conn
