using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class SGFileParse
{
	public delegate int UBFileParseCallbackDelegate(double dProgress);

	public const int FileTypeUTS = 1;

	public const int FileTypeUBO = 2;

	public const int FileTypeMDM = 3;

	public const int FileTypeDlf = 1003;

	public const int FileTypeDTLog = 4;

	public const int FileTypeECTI = 5;

	public const int FileTypeHaiSi = 6;

	public const int FileTypeASPS = 7;

	public const int FileTypeCU = 8;

	public const int FileTypeGesf = 10;

	public const int FileTypeNewDTLog = 11;

	public const int FileTypeQmdl = 12;

	public const int FileTypeTlf = 13;

	public const int FileTypeNIO = 14;

	public const int FileTypeCPF = 15;

	public const int FileTypeBTF = 16;

	public const int FileTypeHDF = 17;

	public const int FileTypeUX = 18;

	public const int FileTypeMuxraw = 20;

	public const int FileTypeCPFOrgData = 21;

	public const int FileTypeZD = 22;

	public const int FileTypeTfi = 1008;

	public static Dictionary<int, string> FileRegFact;

	private static int xXBZrwgDDu;

	private static IntPtr wYxZfk4upL;

	private static string rhXZFgF7X3;

	private static SGFileParse VXWHDYpZ6ZSOTMiGxNF;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetTargetLogFormatType(int srcType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr fveZBRc69x(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX1001")]
	private static extern int BTDZ6IGNQ7(string P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX01")]
	private static extern IntPtr X9pZJR4U0N(int P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX02")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool Li0ZU06MDH(IntPtr P_0, uint P_1, IntPtr P_2, int P_3);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX03")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool jmrZIYRfZR(IntPtr P_0, string P_1);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX04")]
	private static extern uint AJXZyQEyX6(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX09")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool LFfZeC2LuG(IntPtr P_0, string P_1);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX0A")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool z6KZAd27C8(IntPtr P_0, uint P_1);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX0B")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool O51ZP5OtQk(IntPtr P_0, uint P_1, IntPtr P_2, int P_3);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX10")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool f9xZpH3vOG(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX05")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool rqNZ07VdEk(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX06")]
	private static extern int OUsZvVlCix(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX06Ex")]
	private static extern long WXOZGiDIwk(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX07")]
	private static extern int RPpZHioIFq(IntPtr P_0, ref int P_1, ref long P_2, IntPtr P_3, ref int P_4);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX0E")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool vv3ZwhrhMP(IntPtr P_0, int P_1, long P_2, IntPtr P_3, int P_4);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int GetOrgFileEQID(string srcFile)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static void FileConvert(string srcFile, int srcType, string desFile, int desType, UBFileParseCallbackDelegate callback)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetKeyInfoByName(string fileName, int eqIndex, bool useCurTime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCUOperatorByName(string fileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SGFileParse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SGFileParse()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 7;
		Dictionary<int, string> dictionary = default(Dictionary<int, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					wYxZfk4upL = IntPtr.Zero;
					num2 = 10;
					continue;
				case 11:
					dictionary.Add(15, b99vLwQv4vNmPibnHM.iaWRZZUjVH(13304));
					num2 = 8;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 8:
					dictionary.Add(16, b99vLwQv4vNmPibnHM.iaWRZZUjVH(13342));
					num2 = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					dictionary = new Dictionary<int, string>();
					num2 = 12;
					continue;
				case 2:
					xXBZrwgDDu = 20971520;
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 10:
					return;
				case 12:
					dictionary.Add(10, (string)gtmK1vpFQA09xG4tdBn(13186));
					num2 = 13;
					continue;
				case 6:
					Ojl3qtpSLs7yZP1n5PF();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					dictionary.Add(14, (string)gtmK1vpFQA09xG4tdBn(13268));
					num2 = 11;
					continue;
				default:
					w6gqAkpD2PjRDq82CwB();
					num2 = 4;
					if (false)
					{
						num2 = 1;
					}
					continue;
				case 5:
					FileRegFact = dictionary;
					num2 = 2;
					continue;
				case 7:
					J1LO1gpHy1s6EnfXLUu();
					num = 6;
					break;
				case 4:
					F5bhJjpgmbAYdEABXXX();
					num2 = 3;
					continue;
				case 13:
					dictionary.Add(12, (string)gtmK1vpFQA09xG4tdBn(13226));
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KD06aGp7bOrqU894cYY()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SGFileParse gb8kwYpxL2Oj7ruYrXj()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr eRWmG4p37LrmtM45f1f(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gtmK1vpFQA09xG4tdBn(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ChipType tN0GoRpIx4dpU7lqb48(int EQID)
	{
		return (ChipType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o4c8sFpCMSfiYHjjn8n(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oWodSppdkAfoQsZSXd0(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tMeAo9poARqLlPjYlB5(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ewLaS3piqYkC3eUBO7h(object P_0, int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DDCkPhprtrhWc1vHYib(object P_0, int eqIndex, bool useCurTime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YXJjYLpKvl2cK3DGGru(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UTlBhfpnVpewvNSr5Qr(int srcType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FSwVIypWhXy1KE8WjwB(object P_0, bool ignoreNull)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mxuwwTpjmTJ9Nncxg6f(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OK2u5PpMtUjb2vU7qpm(object P_0, double dProgress)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool faserxpYuuCrfH0lRCY(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F5bhJjpgmbAYdEABXXX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J1LO1gpHy1s6EnfXLUu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ojl3qtpSLs7yZP1n5PF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w6gqAkpD2PjRDq82CwB()
	{
	}
}
