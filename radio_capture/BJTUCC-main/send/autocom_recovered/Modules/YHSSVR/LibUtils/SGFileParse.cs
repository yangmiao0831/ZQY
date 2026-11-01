using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using P8RhegOFKTh50li8vF;

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

	private static int pohfRwOW4;

	private static IntPtr LrPsdnP38;

	private static string H3Hen1djc;

	internal static SGFileParse orJBBQCI4P1ErA0x67N;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetTargetLogFormatType(int srcType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr KaWPwcTuV(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX1001")]
	private static extern int fNLTgZNhZ(string P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX01")]
	private static extern IntPtr nQCj3KHP6(int P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX02")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool aE11m98jm(IntPtr P_0, uint P_1, IntPtr P_2, int P_3);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX03")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool A1j5NbPVE(IntPtr P_0, string P_1);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX04")]
	private static extern uint Qv4RjDP7Z(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX09")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool tpEDyUPTn(IntPtr P_0, string P_1);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX0A")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool y80VIjrBD(IntPtr P_0, uint P_1);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX0B")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool na6reuGvB(IntPtr P_0, uint P_1, IntPtr P_2, int P_3);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX10")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool lljnnZesZ(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX05")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool Y6My6kvgA(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX06")]
	private static extern int UcdtaRHe4(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX06Ex")]
	private static extern long VlSmn2NjZ(IntPtr P_0);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX07")]
	private static extern int WqVUBStNm(IntPtr P_0, ref int P_1, ref long P_2, IntPtr P_3, ref int P_4);

	[DllImport("DDFPXX00.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "DDFPXX0E")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool p8bplgLrr(IntPtr P_0, int P_1, long P_2, IntPtr P_3, int P_4);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int GetOrgFileEQID(string srcFile)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static void FileConvert(FileConvertSoftCfg softCfg, string srcFile, int srcType, string desFile, int desType, int sleepInterval, UBFileParseCallbackDelegate callback)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnZHqwQdc(object P_0, IntPtr P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetKeyInfoByName(FileConvertSoftCfg softCfg, string fileName, int eqIndex, bool useCurTime)
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
		Seo3omgfrcFXY10d00.AvviRHPjVq();
		int num = 11;
		Dictionary<int, string> dictionary = default(Dictionary<int, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					dictionary.Add(10, (string)yuM4wlCR9ag20k29xA1(1260));
					num2 = 9;
					continue;
				case 8:
					FileRegFact = dictionary;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					dictionary.Add(15, (string)yuM4wlCR9ag20k29xA1(1378));
					num2 = 7;
					continue;
				case 13:
					dictionary = new Dictionary<int, string>();
					num2 = 15;
					continue;
				case 5:
					dictionary.Add(21, (string)yuM4wlCR9ag20k29xA1(1498));
					num2 = 12;
					continue;
				case 10:
					jn2XQWWolBeQyuoQd41();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					dictionary.Add(20, (string)yuM4wlCR9ag20k29xA1(1454));
					num2 = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 6:
					return;
				case 9:
					dictionary.Add(12, Seo3omgfrcFXY10d00.ryriqps1Zt(1300));
					num2 = 2;
					continue;
				default:
					pohfRwOW4 = 20971520;
					num2 = 14;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 14:
					LrPsdnP38 = IntPtr.Zero;
					num2 = 5;
					if (true)
					{
						num2 = 6;
					}
					continue;
				case 1:
					XuGqDxW5tFT21ZBU0wT();
					num2 = 13;
					if (1 == 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					Seo3omgfrcFXY10d00.Rp0iCrVYjL();
					num = 10;
					break;
				case 12:
					dictionary.Add(22, (string)yuM4wlCR9ag20k29xA1(1542));
					num2 = 8;
					continue;
				case 2:
					dictionary.Add(14, (string)yuM4wlCR9ag20k29xA1(1342));
					num2 = 0;
					if (0 == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					dictionary.Add(16, (string)yuM4wlCR9ag20k29xA1(1416));
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RGuE3fCVJX8CNptH1fC()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SGFileParse ltmG9KCTuelucWcmCAC()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr WV0a9vCqWahDSM0OisD(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yuM4wlCR9ag20k29xA1(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tKY0xNCic6Lw2YaZ6Pi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NgnfZuCmZAJYKcN6mTC(object P_0, double dProgress)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ChipType Kp8blLCBPjJeWdUfrPj(int EQID)
	{
		return (ChipType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ydtdt8CLlGrXSRuftLX(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nwECxhCz2aGEawwmV18(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K22FH0WF99cgvKEiU3v(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bP8JDSWCQHwSZyxbC9G(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double j0cddmWWEQZNKVks2PZ(object P_0, int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GrSRYUWpFSl2NQ8UBLG(object P_0, object P_1, int eqIndex, bool useCurTime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Fx1mqeW01Q7YUfVEDeb(int srcType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RUjk9AWgXdRUppAlfUi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OAjBi9WtnsFlJqyPEgH(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr aBm1KOWGNEE1OoG3yL5(object P_0, int paramKey, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double d9EnoHWH9kNyqDcnn6L(object P_0, IntPtr handle, int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long M9JF3BW1ZP3jeNLRaaZ(object P_0, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LIlRF9Wv1Ro46WNYpS4(object P_0, IntPtr handle)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q6C6VjWuDjk8daj4N3P(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jn2XQWWolBeQyuoQd41()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XuGqDxW5tFT21ZBU0wT()
	{
	}
}
