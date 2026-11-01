using System;
using System.Runtime.InteropServices;

namespace LibUtils;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int DCDisconnect(IntPtr DeviceHandle, uint iTimeout);
