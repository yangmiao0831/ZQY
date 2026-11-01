param(
  [Parameter(Mandatory = $true)]
  [int]$ProcessId
)

$source = @"
using System;
using System.Runtime.InteropServices;

public static class ConsoleControl {
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool FreeConsole();

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool AttachConsole(uint processId);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool GenerateConsoleCtrlEvent(uint ctrlEvent, uint processGroupId);
}
"@

Add-Type -TypeDefinition $source
[ConsoleControl]::FreeConsole() | Out-Null
[ConsoleControl]::SetConsoleCtrlHandler([IntPtr]::Zero, $true) | Out-Null

if (-not [ConsoleControl]::AttachConsole([uint32]$ProcessId)) {
  throw "Unable to attach to console for PID $ProcessId"
}

# CTRL_C_EVENT = 0. Sending to group 0 reaches the attached console, including
# the foreground Python collector, and follows the same graceful path as Ctrl+C.
if (-not [ConsoleControl]::GenerateConsoleCtrlEvent(0, 0)) {
  $errorCode = [Runtime.InteropServices.Marshal]::GetLastWin32Error()
  [ConsoleControl]::FreeConsole() | Out-Null
  throw "Unable to send Ctrl+C to PID $ProcessId (Win32 error $errorCode)"
}

Start-Sleep -Milliseconds 500
[ConsoleControl]::FreeConsole() | Out-Null
