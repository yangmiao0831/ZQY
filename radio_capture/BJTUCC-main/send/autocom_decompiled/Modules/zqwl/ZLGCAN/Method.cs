using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using x0ySPWcDaHGm9KllEq;

namespace ZLGCAN;

public class Method
{
	private static Method dL2SYsVtTZijxE7SnKX;

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern IntPtr ZCAN_OpenDevice(uint device_type, uint device_index, uint reserved);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_CloseDevice(IntPtr device_handle);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern IntPtr ZCAN_InitCAN(IntPtr device_handle, uint can_index, IntPtr pInitConfig);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_IsDeviceOnLine(IntPtr device_handle);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_SetValue(IntPtr device_handle, string path, byte[] value);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_SetValue(IntPtr device_handle, string path, IntPtr value);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_StartCAN(IntPtr channel_handle);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_ResetCAN(IntPtr channel_handle);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_Transmit(IntPtr channel_handle, IntPtr pTransmit, uint len);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_TransmitFD(IntPtr channel_handle, IntPtr pTransmit, uint len);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_GetReceiveNum(IntPtr channel_handle, byte type);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_Receive(IntPtr channel_handle, IntPtr data, uint len, int wait_time = -1);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_ReceiveFD(IntPtr channel_handle, IntPtr data, uint len, int wait_time = -1);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern uint ZCAN_ReadChannelErrInfo(IntPtr channel_handle, IntPtr pErrInfo);

	[DllImport("zlgcan.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern IntPtr GetIProperty(IntPtr device_handle);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Method()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Method()
	{
		AcTdiBLdlb18yJoT0j.AQxlVHxgb9();
		yb54o8VUjf1u6M3TDqn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void txB1XpVZD3kk651lTLe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool II9HVfVQbvdg9SXlgrK()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Method Ruxi7FV8HkJ19tXl2oG()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yb54o8VUjf1u6M3TDqn()
	{
	}
}
