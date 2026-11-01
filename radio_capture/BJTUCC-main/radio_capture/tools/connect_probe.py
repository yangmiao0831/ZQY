"""Probe native controller connection variants without waiting for capture."""

from __future__ import annotations

import argparse
from dataclasses import replace

from radio_capture.config import load_config
from radio_capture.models import DeviceSessionConfig, PortsConfig
from radio_capture.session.manager import CaptureSession


MODULE_CANDIDATES = [
    ("qualcomm_nr5g_10010150", 0x10010150),
    ("qualcomm_x75_10010a0e", 0x10010A0E),
    ("qualcomm_x85_10010a11", 0x10010A11),
]


def build_parser() -> argparse.ArgumentParser:
    parser = argparse.ArgumentParser(description="Probe DC_CommonSocket connection variants.")
    parser.add_argument("--config", required=True, help="Base JSON config.")
    parser.add_argument("--dm", default="COM5", help="DM/trace port, for example COM5 or 5.")
    parser.add_argument("--at", default="COM3", help="AT port, for example COM3 or 3.")
    parser.add_argument("--timeout-ms", type=int, default=5000)
    return parser


def main(argv: list[str] | None = None) -> int:
    args = build_parser().parse_args(argv)
    base = load_config(args.config)

    variants = [
        ("trace_only_str", PortsConfig(trace_port=args.dm)),
        ("trace_at_str", PortsConfig(trace_port=args.dm, at_port=args.at)),
        ("modem_only_str", PortsConfig(modem_port=args.dm)),
        ("assistant_only_str", PortsConfig(trace_nr_port=args.dm)),
        ("trace_only_int", PortsConfig(trace_port=_port_number(args.dm))),
        ("trace_at_int", PortsConfig(trace_port=_port_number(args.dm), at_port=_port_number(args.at))),
    ]

    for module_name, module_id in MODULE_CANDIDATES:
        for ports_name, ports in variants:
            for chip_stage in ("disabled", "before_connect"):
                cfg = _config_variant(base, module_id, ports, chip_stage, args.timeout_ms)
                label = f"module={module_name}/0x{module_id:08X} ports={ports_name} chip={chip_stage}"
                print(f"\n=== {label} ===")
                session = CaptureSession(cfg)
                try:
                    session.open()
                    session.configure_ports()
                    session.start_workers()
                    session.connect()
                    rc = session.connect_return_code
                    print(f"RESULT connect_rc={rc} rc_hex=0x{rc & 0xFFFFFFFF:08X}")
                except Exception as exc:
                    print(f"RESULT exception={type(exc).__name__}: {exc}")
                finally:
                    try:
                        session.stop(timeout=2.0)
                    except Exception as exc:
                        print(f"STOP exception={type(exc).__name__}: {exc}")
    return 0


def _config_variant(
    base: DeviceSessionConfig,
    module_id: int,
    ports: PortsConfig,
    chip_stage: str,
    timeout_ms: int,
) -> DeviceSessionConfig:
    device = replace(base.device, eq_id=module_id, connect_timeout_ms=timeout_ms, chip_info_stage=chip_stage)
    decoder = replace(base.decoder, codec_module_id=module_id)
    return replace(base, device=device, decoder=decoder, ports=ports)


def _port_number(value: str) -> int:
    text = str(value).upper()
    if text.startswith("COM"):
        text = text[3:]
    return int(text)


if __name__ == "__main__":
    raise SystemExit(main())
