"""Pipeline routing between raw storage, parser, decoder, and result store."""

from __future__ import annotations

from radio_capture.models import DecodedRecord, FrameEnvelope
from radio_capture.native.autocom_bler_process import AutocomPuschBlerProcess
from radio_capture.native.decoder import LogCodec
from radio_capture.pipeline.lte_metrics import LTE_DM_METRIC_MSG_CODES
from radio_capture.pipeline.metrics import NR_METRIC_MSG_CODES
from radio_capture.pipeline.pusch_bler import PUSCH_BLER_MSG_CODES
from radio_capture.pipeline.parser import FrameParser
from radio_capture.pipeline.raw_sink import RawWriter
from radio_capture.pipeline.metrics_sink import MetricsCsvWriter
from radio_capture.pipeline.decoded_sink import DecodedJsonlWriter
from radio_capture.storage.sqlite_store import SQLiteStore


class PipelineRouter:
    def __init__(
        self,
        raw_writer: RawWriter,
        parser: FrameParser,
        store: SQLiteStore | None = None,
        codec: LogCodec | None = None,
        metrics_writer: MetricsCsvWriter | None = None,
        lte_metrics_writer=None,
        decoded_writer: DecodedJsonlWriter | None = None,
        pusch_bler_process: AutocomPuschBlerProcess | None = None,
        metrics_only: bool = False,
    ):
        self.raw_writer = raw_writer
        self.parser = parser
        self.store = store
        self.codec = codec
        self.metrics_writer = metrics_writer
        self.lte_metrics_writer = lte_metrics_writer
        self.decoded_writer = decoded_writer
        self.pusch_bler_process = pusch_bler_process
        self.metrics_only = metrics_only

    def process_frame(self, frame: FrameEnvelope, eq_id: int, module_id: int) -> DecodedRecord | None:
        if not self.metrics_only:
            self.raw_writer.write(frame)
        if self.store and not self.metrics_only:
            self.store.insert_raw_frame(frame)

        request = self.parser.parse(frame, eq_id, module_id)
        if request.msg_code is None:
            return None
        if (
            self.pusch_bler_process is not None
            and request.msg_code in PUSCH_BLER_MSG_CODES
        ):
            result = self.pusch_bler_process.feed(frame)
            if result is not None and self.metrics_writer is not None:
                self.metrics_writer.update_pusch_bler(result)
        if self.codec is None:
            return None
        if self.metrics_only and not self._should_decode_metrics_only(request.msg_code):
            return None

        display_rc, display_format = self.codec.get_display_format(request.msg_code)
        rc, detail = self.codec.get_detail(request.msg_code, request.payload)
        record = DecodedRecord(
            session_id=frame.session_id,
            sequence=frame.sequence,
            msg_code=request.msg_code,
            display_format=display_format if display_rc == 0 else None,
            return_code=rc,
            detail=detail if rc == 0 else None,
            error=None if rc == 0 else f"decoder return code {rc}",
            receive_time_ns=frame.receive_time_ns,
        )
        if self.store and not self.metrics_only:
            self.store.insert_decoded_record(record)
        if self.metrics_writer is not None:
            self.metrics_writer.write(record)
        if self.lte_metrics_writer is not None:
            self.lte_metrics_writer.write_dm(record)
        if self.decoded_writer is not None and not self.metrics_only:
            self.decoded_writer.write(record)
        return record

    def _should_decode_metrics_only(self, msg_code: int) -> bool:
        if self.metrics_writer is not None and msg_code in NR_METRIC_MSG_CODES:
            return True
        return (
            self.lte_metrics_writer is not None
            and msg_code in LTE_DM_METRIC_MSG_CODES
        )
