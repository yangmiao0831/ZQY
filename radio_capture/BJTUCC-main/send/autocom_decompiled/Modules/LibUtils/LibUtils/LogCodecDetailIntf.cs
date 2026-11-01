using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class LogCodecDetailIntf
{
	private static LogCodecDetailIntf VjstGm6qU2xZkdZUoGK;

	[DllImport("DDDIXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DDDIXX01")]
	public static extern IntPtr CreateLogcodecInstance(int moduleId);

	[DllImport("DDDIXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DDDIXX02")]
	public static extern int DoConfigLogCodecInstance(IntPtr handle, int configId, IntPtr configInfo, int length);

	[DllImport("DDDIXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DDDIXX03")]
	public static extern int DoGetDetailInfo(IntPtr handle, uint msgCode, int srcLen, byte[] srcBytes, ref int desLen, byte[] desBytes);

	[DllImport("DDDIXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DDDIXX04")]
	public static extern int DoGetDetailDisplayFormat(IntPtr handle, uint msgCode, ref int iTableDisplayFormat);

	[DllImport("DDDIXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DDDIXX05")]
	public static extern int FreeLogCodecInstance(IntPtr handle);

	[DllImport("DDDIXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DDDIXX06")]
	public static extern int GetStandardBinBuffer(IntPtr handle, uint LogCode, int HexLen, byte[] pHexBuffer, ref int iPaseredLen, byte[] pParseredBuffer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogCodecDetailIntf()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LogCodecDetailIntf()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				case 1:
					jtkQxT6u1VFVLJmAOwI();
					num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					goto IL_0017;
				default:
					CQNqpT6Vi87McdS2K1f();
					num2 = 3;
					goto IL_0017;
				case 2:
					break;
				case 3:
					return;
				}
				tU5Tbm6lqQV7GW9kFFe();
				num2 = 1;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jtkQxT6u1VFVLJmAOwI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool itTKWX6PrTvlR6ZIFBu()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LogCodecDetailIntf kZ8NYW60Jy9s7hcA4Jp()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tU5Tbm6lqQV7GW9kFFe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CQNqpT6Vi87McdS2K1f()
	{
	}
}
