using System;
using System.Runtime.InteropServices;

namespace LibUtils;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int DCConnect(IntPtr DeviceHandle, Log_CallBack CallBackFun, IntPtr pParam, uint iTimeout);
