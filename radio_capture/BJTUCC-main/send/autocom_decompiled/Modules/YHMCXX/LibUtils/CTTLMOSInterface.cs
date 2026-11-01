using System;
using System.Runtime.InteropServices;

namespace LibUtils;

public class CTTLMOSInterface
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate double FinalMosDelegate(string recFile, string srcFile, ref int RtFrameNum, ref int RtBandType, int[] RtDelay, ref int ErrType);

	public const string DLLName = "finalmos.dll";

	[DllImport("finalmos.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "_FinalMos")]
	public static extern double FinalMos(string recFile, string srcFile, ref int RtFrameNum, ref int RtBandType, int[] RtDelay, ref int ErrType);

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string path);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr lib, string funcName);

	[DllImport("kernel32.dll")]
	public static extern bool FreeLibrary(IntPtr lib);
}
