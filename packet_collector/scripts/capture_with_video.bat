@echo off
setlocal
set "PROJECT_DIR=%~dp0.."
for %%I in ("%PROJECT_DIR%") do set "PROJECT_DIR=%%~fI"
set "WORKSPACE_DIR=%PROJECT_DIR%\.."
set "CONFIG_FILE=%PROJECT_DIR%\config.json"

if exist "%WORKSPACE_DIR%\zqy\Scripts\python.exe" (
  set "PYTHON_BIN=%WORKSPACE_DIR%\zqy\Scripts\python.exe"
) else (
  set "PYTHON_BIN=python"
)

pushd "%PROJECT_DIR%"
echo Starting packet capture and camera from config.json...
"%PYTHON_BIN%" -m packet_collector.orchestration.configured_capture --config "%CONFIG_FILE%" --video %*
set "EXIT_CODE=%ERRORLEVEL%"
popd
exit /b %EXIT_CODE%

