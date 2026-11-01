using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class DeviceController
{
	private IntPtr LjlTLmvTrW;

	public int DLLState;

	public CreateDeviceControllerInstance pCreateDeviceControllerInstance;

	public FreeDeviceControllerInstance pFreeDeviceControllerInstance;

	public DCConfigPort pDCConfigPort;

	public DCConnect pDCConnect;

	public DCRecover pDCRecover;

	public DCSendChipInfo pDCSendChipInfo;

	public DCSendCommand pDCSendCommand;

	public DCDisconnect pDCDisconnect;

	private static DeviceController TXw5q7fEttc9Dp94dBB;

	[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
	private static extern IntPtr CcTT9uWuur(string P_0);

	[DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
	private static extern IntPtr hYPT7AVAsg(IntPtr P_0, string P_1);

	[DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool pDDTqeWpUA(IntPtr P_0);

	[DllImport("kernel32.dll", EntryPoint = "GetLastError")]
	private static extern int P1ATTTn93t();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeviceController(string lpFileName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool upwTZ77K14()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Delegate Invoke(string lpProcName, Type t)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FreeDeviceController()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeviceController()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				VrFw9MftR4S0lCDSiF9();
				num2 = 0;
				if (true)
				{
					num2 = 0;
				}
				break;
			case 2:
				b99vLwQv4vNmPibnHM.CO84lAqjUl();
				num2 = 1;
				if (false)
				{
					num2 = 1;
				}
				break;
			default:
				uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
				num2 = 3;
				if (0 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lKUa9cfQxvEHLVLXdCl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OVC65kffdkst6C8caRR(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k4Qdi2fcuDo2rxZ4j1O()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeviceController fPXriEfbtWQcc5FoKb7()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VrFw9MftR4S0lCDSiF9()
	{
	}
}
