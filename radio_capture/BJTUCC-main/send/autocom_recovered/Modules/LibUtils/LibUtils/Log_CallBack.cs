using System;
using System.Runtime.InteropServices;

namespace LibUtils;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public delegate void Log_CallBack(IntPtr pParam, int LogType, IntPtr LogBuffer, uint LogLen, ulong CurTime);
