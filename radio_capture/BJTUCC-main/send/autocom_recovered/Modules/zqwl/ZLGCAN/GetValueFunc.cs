using System;
using System.Runtime.InteropServices;

namespace ZLGCAN;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GetValueFunc(string path);
