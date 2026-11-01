using System;
using System.Runtime.InteropServices;

namespace LibUtils;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int DCSendCommand(IntPtr DeviceHandle, IntPtr pDCInfo);
