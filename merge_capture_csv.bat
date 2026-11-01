@echo off
setlocal

set "ROOT=%~dp0"
set "PYTHON=%ROOT%zqy\Scripts\python.exe"

if not exist "%PYTHON%" (
  echo ERROR: Python executable not found: %PYTHON%
  exit /b 1
)

pushd "%ROOT%packet_collector" || exit /b 1
"%PYTHON%" -m packet_collector.orchestration.merge_capture_csv --config "%ROOT%packet_collector\config.json" %*
set "EXIT_CODE=%ERRORLEVEL%"
popd

if not "%EXIT_CODE%"=="0" (
  echo CSV merge failed.
  exit /b %EXIT_CODE%
)

echo CSV merge completed.
endlocal
