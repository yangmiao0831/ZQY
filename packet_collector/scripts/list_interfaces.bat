@echo off
setlocal
if exist "%~dp0..\Wireshark\dumpcap.exe" set "PATH=%~dp0..\Wireshark;%PATH%"
if exist "%ProgramFiles%\Wireshark\dumpcap.exe" set "PATH=%ProgramFiles%\Wireshark;%PATH%"
where dumpcap >nul 2>nul
if errorlevel 1 (
  echo ERROR: dumpcap was not found. Install Wireshark with Npcap and add Wireshark to PATH.
  exit /b 1
)
echo Available capture interfaces:
dumpcap -D
endlocal
