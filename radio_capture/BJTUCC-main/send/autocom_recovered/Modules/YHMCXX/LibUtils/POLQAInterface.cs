using System;
using System.Runtime.InteropServices;

namespace LibUtils;

public class POLQAInterface
{
	private const string DLLName = "POLQACalc.dll";

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	public static extern uint InitPOLQA(int polqaType, string licenseFile);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	public static extern uint InitPOLQAEx(int polqaType, string licenseFile, int polqaVer);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr CalcPOLQA(uint PolqaHandle, string srcFile, string destFile);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern uint UnInitPOLQA(uint PolqaHandle);
}
