@echo off
setlocal
set "PROJECT_DIR=%~dp0.."
for %%I in ("%PROJECT_DIR%") do set "PROJECT_DIR=%%~fI"
set "WORKSPACE_DIR=%PROJECT_DIR%\.."
if exist "%PROJECT_DIR%\Wireshark\dumpcap.exe" set "PATH=%PROJECT_DIR%\Wireshark;%PATH%"
if exist "%ProgramFiles%\Wireshark\dumpcap.exe" set "PATH=%ProgramFiles%\Wireshark;%PATH%"
if exist "%WORKSPACE_DIR%\zqy\Scripts\python.exe" (
  set "PYTHON_BIN=%WORKSPACE_DIR%\zqy\Scripts\python.exe"
) else (
  set "PYTHON_BIN=python"
)
pushd "%PROJECT_DIR%"
"%PYTHON_BIN%" -m packet_collector.cli check-env --output deploy_check.json
set "EXIT_CODE=%ERRORLEVEL%"
popd
exit /b %EXIT_CODE%
