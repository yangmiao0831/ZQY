using System.Runtime.InteropServices;

namespace ZLGCAN;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int SetValueFunc(string path, byte[] value);
