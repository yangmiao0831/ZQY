using System;
using System.Runtime.InteropServices;

namespace ZLGCAN;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GetPropertysFunc(string path, string value);
