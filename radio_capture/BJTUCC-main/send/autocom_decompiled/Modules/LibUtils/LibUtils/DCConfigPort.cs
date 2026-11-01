using System;
using System.Runtime.InteropServices;

namespace LibUtils;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int DCConfigPort(IntPtr DeviceHandle, IntPtr pDCInfo);
