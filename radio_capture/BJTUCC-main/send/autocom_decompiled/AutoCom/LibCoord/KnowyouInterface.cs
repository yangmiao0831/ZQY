using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using LibBase;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class KnowyouInterface
{
	public const int CISucc = 1;

	private static string ukeGAVUh0tP;

	private static string g98GAXlK4Od;

	private static int fHoGA22vdud;

	public static int FReason;

	public static int FHandle;

	public static string FDeiceID;

	private static IntPtr YP6GAOwqnQi;

	private static IntPtr NjPGAMojg9T;

	public static string TestPlanVer;

	private static KnowyouInterface ndB5v5ukMAEtjb1Nko01;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int Login()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static void DoUninit()
	{
	}

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int Init(string license_path, string log_path, ref int result, ref int reason, IntPtr pID, IntPtr pVer);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Login")]
	private static extern int oDqGAbv7QWX(int P_0, IntPtr P_1, ref int P_2);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int Logout(int handle, int cause, ref int reason);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int GetTestplan(int handle, ref int reason, IntPtr pPlan, ref int lenPlan);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr XmlToJson(IntPtr xmlstr, int ueIndex);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr GetTestplanJson(int handle, IntPtr xmlstr);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int UploadProtocolBegin(int handle, string file_name, int MSNO, ref int reason, ref uint file_size);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int UploadProtocolEOF(int handle, string file_name, uint fileSize, int MSNO, ref int reason);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int UploadDataPack(int handle, string file_name, int MSNO, int isFileHeader, uint len, byte[] data, ref int reason);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void Uninit(int handle);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "UplaodEvent")]
	public static extern int UploadEvent(int handle, int slotNo, int time, int code, int len, byte[] data, ref int reason);

	[DllImport("SSCCTLXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "UplaodStatus")]
	public static extern int UploadStatus(int handle, ushort powerType, float diskFree, float temp, uint fileCount, ref int reason);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KnowyouInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static KnowyouInterface()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					NjPGAMojg9T = Marshal.AllocHGlobal(32);
					num2 = 2;
					continue;
				case 5:
					g98GAXlK4Od = ConstBase.DebugPath;
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				default:
					fHoGA22vdud = 0;
					num2 = 4;
					continue;
				case 1:
					return;
				case 6:
					Wvx2ubukBc7iAOBr95S2();
					num2 = 9;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					YP6GAOwqnQi = OEQQFyukEsCm2PWMEwDl(32);
					num2 = 8;
					continue;
				case 9:
					ukeGAVUh0tP = ConstBase.SparkPath + (string?)ATuGrTuko9FrH4B1MgxK(127302);
					num2 = 5;
					continue;
				case 7:
					mGCEL8ukqZMOhOEujWSi();
					num = 6;
					break;
				case 4:
					FReason = 0;
					num2 = 3;
					continue;
				case 2:
					TestPlanVer = (string)ATuGrTuko9FrH4B1MgxK(64822);
					num2 = 1;
					if (false)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ATuGrTuko9FrH4B1MgxK(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VVwmiqukxKrWUCWmYI5n(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O1I5C1ukAXHFRagnXHwW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aoWEsuukt9IEfeCmUq0Q(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr a31jSiukWJfqmoYbhhwx(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YW2TnhukKMXqoD1IRZAB()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static KnowyouInterface SvLNRcukZ0o339oBJDG7()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Wvx2ubukBc7iAOBr95S2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mGCEL8ukqZMOhOEujWSi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr OEQQFyukEsCm2PWMEwDl(int P_0)
	{
		return (IntPtr)(object)null;
	}
}
