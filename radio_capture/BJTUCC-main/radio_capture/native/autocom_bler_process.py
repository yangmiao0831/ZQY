"""Parent-side control for the crash-isolated AutoCom PUSCH BLER worker."""

from __future__ import annotations

import base64
import json
import os
import queue
import subprocess
import sys
import threading
from dataclasses import dataclass
from pathlib import Path

from radio_capture.models import FrameEnvelope
from radio_capture.native.autocom_bler_worker import DDLCXX_QUALCOMM_DLL


def _default_python_executable() -> Path:
    configured = os.environ.get("RADIO_CAPTURE_PYTHON32")
    if configured:
        return Path(configured)
    workspace_python = Path(__file__).resolve().parents[2] / ".venv32" / "Scripts" / "python.exe"
    if workspace_python.exists():
        return workspace_python
    return Path(sys.executable)


@dataclass(frozen=True)
class AutocomPuschBlerResult:
    bler_pct: float | None
    samples: int
    successes: int | None
    errors: int | None
    sequence: int
    receive_time_ns: int
    object_id: str
    value_field_id: str


class AutocomPuschBlerProcess:
    """Synchronous request API backed by a disposable native child process."""

    def __init__(
        self,
        *,
        dll_dir: Path,
        module_id: int,
        python_executable: Path | None = None,
        dll_name: str = DDLCXX_QUALCOMM_DLL,
        timeout_sec: float = 5.0,
    ) -> None:
        self.dll_dir = Path(dll_dir)
        self.module_id = int(module_id)
        self.python_executable = Path(python_executable or _default_python_executable())
        self.dll_name = dll_name
        self.timeout_sec = timeout_sec
        self.last_error: str | None = None
        self._process: subprocess.Popen[str] | None = None
        self._responses: queue.Queue[dict[str, object]] = queue.Queue()
        self._reader: threading.Thread | None = None
        self._lock = threading.Lock()
        self._request_id = 0

    @property
    def running(self) -> bool:
        return self._process is not None and self._process.poll() is None

    def start(self) -> bool:
        if self.running:
            return True
        if self._process is not None:
            self._close_exited_process()
        while True:
            try:
                self._responses.get_nowait()
            except queue.Empty:
                break
        command = [
            str(self.python_executable),
            "-m",
            "radio_capture.native.autocom_bler_worker",
            "--dll-dir",
            str(self.dll_dir),
            "--module-id",
            str(self.module_id),
            "--dll-name",
            self.dll_name,
            "--stream",
        ]
        try:
            self._process = subprocess.Popen(
                command,
                stdin=subprocess.PIPE,
                stdout=subprocess.PIPE,
                stderr=subprocess.STDOUT,
                text=True,
                encoding="utf-8",
                errors="replace",
                bufsize=1,
                cwd=str(Path(__file__).resolve().parents[2]),
            )
        except OSError as exc:
            self.last_error = f"could not start x86 DDLCXX worker: {exc}"
            return False
        self._reader = threading.Thread(
            target=self._read_stdout,
            name="autocom-bler-reader",
            daemon=True,
        )
        self._reader.start()
        response = self._next_response(self.timeout_sec)
        if response is None or response.get("op") != "ready" or not response.get("available"):
            self.last_error = _response_error(response, "DDLCXX worker did not become ready")
            self.close()
            return False
        self.last_error = None
        return True

    def feed(self, frame: FrameEnvelope) -> AutocomPuschBlerResult | None:
        with self._lock:
            if not self.running:
                if not self.start():
                    return None
            self._request_id += 1
            request_id = self._request_id
            request = {
                "op": "feed",
                "request_id": request_id,
                "log_type": int(frame.log_type),
                "native_cur_time": int(frame.native_cur_time),
                "receive_time_ns": int(frame.receive_time_ns),
                "payload_b64": base64.b64encode(frame.payload).decode("ascii"),
            }
            try:
                assert self._process is not None and self._process.stdin is not None
                self._process.stdin.write(json.dumps(request, separators=(",", ":")) + "\n")
                self._process.stdin.flush()
            except (BrokenPipeError, OSError) as exc:
                self.last_error = f"DDLCXX worker pipe failed: {exc}"
                return None
            response = self._next_response(self.timeout_sec)
            if response is None:
                self.last_error = "DDLCXX worker response timed out"
                return None
            if response.get("op") == "error":
                self.last_error = _response_error(response, "DDLCXX worker parse failed")
                return None
            if response.get("op") != "result" or response.get("request_id") != request_id:
                self.last_error = f"unexpected DDLCXX worker response: {response!r}"
                return None
            value = response.get("result")
            if not isinstance(value, dict):
                return None
            return AutocomPuschBlerResult(
                bler_pct=float(value["bler_pct"]) if value.get("bler_pct") is not None else None,
                samples=int(value["samples"]),
                successes=int(value["successes"]) if value.get("successes") is not None else None,
                errors=int(value["errors"]) if value.get("errors") is not None else None,
                sequence=int(frame.sequence),
                receive_time_ns=int(frame.receive_time_ns),
                object_id=str(value["object_id"]),
                value_field_id=str(value["value_field_id"]),
            )

    def close(self) -> None:
        process = self._process
        self._process = None
        if process is None:
            return
        if process.poll() is None and process.stdin is not None:
            try:
                process.stdin.write('{"op":"close"}\n')
                process.stdin.flush()
            except (BrokenPipeError, OSError):
                pass
        try:
            process.wait(timeout=2.0)
        except subprocess.TimeoutExpired:
            process.terminate()
            try:
                process.wait(timeout=2.0)
            except subprocess.TimeoutExpired:
                process.kill()
                process.wait(timeout=2.0)
        if process.stdin is not None:
            process.stdin.close()
        if process.stdout is not None:
            process.stdout.close()

    def _close_exited_process(self) -> None:
        process = self._process
        self._process = None
        if process is None:
            return
        if process.stdin is not None:
            process.stdin.close()
        if process.stdout is not None:
            process.stdout.close()

    def _read_stdout(self) -> None:
        process = self._process
        if process is None or process.stdout is None:
            return
        for line in process.stdout:
            try:
                value = json.loads(line)
            except json.JSONDecodeError:
                continue
            if isinstance(value, dict):
                self._responses.put(value)

    def _next_response(self, timeout: float) -> dict[str, object] | None:
        try:
            return self._responses.get(timeout=timeout)
        except queue.Empty:
            return None


def _response_error(response: dict[str, object] | None, fallback: str) -> str:
    if not response:
        return fallback
    detail = response.get("error")
    error_type = response.get("error_type")
    if detail and error_type:
        return f"{error_type}: {detail}"
    return str(detail or fallback)


def probe_ddlcxx(
    *,
    dll_dir: Path,
    module_id: int,
    python_executable: Path | None = None,
    dll_name: str = DDLCXX_QUALCOMM_DLL,
    timeout_sec: float = 10.0,
) -> dict[str, object]:
    executable = str(python_executable or _default_python_executable())
    command = [
        executable,
        "-m",
        "radio_capture.native.autocom_bler_worker",
        "--dll-dir",
        str(dll_dir),
        "--module-id",
        str(int(module_id)),
        "--dll-name",
        dll_name,
    ]
    try:
        completed = subprocess.run(
            command,
            capture_output=True,
            text=True,
            encoding="utf-8",
            errors="replace",
            timeout=timeout_sec,
            check=False,
            cwd=str(Path(__file__).resolve().parents[2]),
        )
    except subprocess.TimeoutExpired as exc:
        return {
            "available": False,
            "isolated": True,
            "error_type": "TimeoutExpired",
            "error": str(exc),
        }

    result: dict[str, object] | None = None
    for line in reversed(completed.stdout.splitlines()):
        try:
            candidate = json.loads(line)
        except json.JSONDecodeError:
            continue
        if isinstance(candidate, dict):
            result = candidate
            break
    if result is None:
        result = {
            "available": False,
            "error_type": "WorkerExitedWithoutResult",
            "error": completed.stderr.strip() or completed.stdout.strip(),
        }
    result["isolated"] = True
    result["worker_return_code"] = int(completed.returncode)
    result["python_executable"] = executable
    return result
