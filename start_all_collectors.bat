@echo off
setlocal

set "ROOT=%~dp0"
set "COLLECTOR_CONTROL_DIR=%ROOT%.collector-control"
set "COLLECTOR_STOP_FILE=%COLLECTOR_CONTROL_DIR%\stop.request"

if not exist "%COLLECTOR_CONTROL_DIR%" mkdir "%COLLECTOR_CONTROL_DIR%"
del /q "%COLLECTOR_STOP_FILE%" "%COLLECTOR_CONTROL_DIR%\radio.stopping" "%COLLECTOR_CONTROL_DIR%\network.stopping" 2>nul

echo Starting radio_capture...
start "Wireless Radio Capture" /D "%ROOT%radio_capture\BJTUCC-main" cmd /k ^
  ".venv32\Scripts\python.exe -m radio_capture.cli --config configs\config.json"


echo Starting packet_collector...
start "Network GPS Video Capture" /D "%ROOT%packet_collector" cmd /k ^
  "..\zqy\Scripts\python.exe -m packet_collector.orchestration.configured_capture --config config.json --no-video"

echo.
echo Both collectors have been started.
echo Check the two CMD windows for logs.
endlocal
