using System;
using System.Runtime.InteropServices;

namespace LibUtils;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr CreateDeviceControllerInstance(int ModuleID);
