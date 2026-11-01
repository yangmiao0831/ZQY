using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using tcEeYRHYMSOOr5xhr11;

namespace Spark.Utils;

public class AttenuatorInterface
{
	public const int NetType_NR = 0;

	public const int NetType_LTE = 1;

	public const int CISucc = 0;

	public const int CIFail = -1;

	public const int CIHandleZero = -2;

	public const int CIConnectFail = -3;

	public const int CITimeout = -4;

	public const int CISendFail = -5;

	public const int CIRecvFail = -6;

	public const int CIAckFail = -7;

	public const int CIParamOutOfRange = -8;

	public const int CIReadConfigFileFail = -9;

	public const int CINotExistCellGroup = -10;

	public const int CISocketError = -11;

	public const int CISocketCreateFail = -12;

	public static IntPtr Handle;

	internal static AttenuatorInterface gMq2mutcY7bDckAy5tWw;

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int Connect(ref IntPtr handle, int max_timeout);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void Free(ref IntPtr handle);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetDeviceInfo(IntPtr handle, ref DeviceInfo info);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetCellInfoGroupCount(IntPtr handle, ref ushort count);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetAttenuationbyCell(IntPtr handle, ref CellInfo info, bool bOffset);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetAttenuationbyCell(IntPtr handle, ushort group_index, ref CellInfo info);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetDefaultbyCell(IntPtr handle, ref CellInfo info, bool hasDeviation);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetDefaultbyAll(IntPtr handle, bool hasDeviation);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetCellInfo(IntPtr handle, ref CellInfo info);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetDeviation(IntPtr handle, int CellNum, int UENum, int NetType, int Port, double value);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetChanneCount(IntPtr handle, ref int chNum);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetChanneAtt(IntPtr handle, int chNum, double value);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetChanneAtt(IntPtr handle, int chNum, ref double value);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int SetChanneDeviation(IntPtr handle, int chNum, double value);

	[DllImport("libAMTU.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetChanneDeviation(IntPtr handle, int chNum, ref double value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AttenuatorInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttenuatorInterface()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				case 3:
					return;
				case 2:
					break;
				default:
					BqTReLtc2DdrAjkSrXEr();
					num2 = 2;
					if (true)
					{
						num2 = 2;
					}
					goto IL_0017;
				case 1:
					BWFV0ttc6P6xhR6td2Ct();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					goto IL_0017;
				}
				Handle = IntPtr.Zero;
				num2 = 3;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wv30A4tcuaIQnxeOsouM()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AttenuatorInterface lYGt2btcypug1Sxh6dx4()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BWFV0ttc6P6xhR6td2Ct()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BqTReLtc2DdrAjkSrXEr()
	{
	}
}
