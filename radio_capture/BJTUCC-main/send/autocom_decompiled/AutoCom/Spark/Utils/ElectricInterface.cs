using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using tcEeYRHYMSOOr5xhr11;

namespace Spark.Utils;

public class ElectricInterface
{
	internal static ElectricInterface XkgGL7WyQvCxaCXlVq9y;

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int Connect(ref IntPtr handle);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void Close(IntPtr handle);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetDeviceUEStateInfo(IntPtr handle, int ue_num, ref int ue_state);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetDeviceConfigInfo(IntPtr handle, int hardware_num, StringBuilder hardware_info);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetCurTemperature(IntPtr handle, ref int ATemperature);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern bool GetConnectState(IntPtr handle);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetDeviceUEPowerOff(IntPtr handle, int ue_num);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetDeviceUEPowerOn(IntPtr handle, int ue_num);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void UpdataDeviceState(IntPtr handle);

	[DllImport("SerialComm.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetDeviceUECount(IntPtr handle, ref int ue_count);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ElectricInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ElectricInterface()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		DHv3SjWyFkh8BmyHHlWq();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ta0u3GWy3CgjfrfkwSs8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zwyAA3WyR1wYIsPgIng8()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ElectricInterface Hg508YWyGS0STr6UbnXA()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DHv3SjWyFkh8BmyHHlWq()
	{
	}
}
