using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EhWfrCHt8CgdGjRCLj3;
using LibBase;
using tcEeYRHYMSOOr5xhr11;

namespace LibUtils;

public class CTTLInterface
{
	public const int CISucc = 0;

	public static string FLicensePath;

	public static string FDebugPath;

	public static int FHandle;

	public static object UtilsObj;

	[CompilerGenerated]
	private static Action WOUGTVRL87F;

	private static CTTLInterface S2OclPuaqG61pY379mt9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckBoxIDOK(string boxID)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLicenseFile()
	{
		return null;
	}

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int Init(string license_path, string logPath);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Login")]
	private static extern int k3xGTiIQwqP(int P_0, string P_1, string P_2);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Logout")]
	private static extern int JwEGTFh3vrl(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Uninit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Logout()
	{
		return 0;
	}

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr GetTestplan(int handle, ref int result_code, IntPtr atuid_version);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr ExchangePlanJson(int handle);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr XmlToJson(IntPtr xml, int ueIndex);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr XmlToJsonV2(IntPtr xml, int ueIndex, int useXmlTaskName);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr GetTestplanJson(int handle, ref int result_code, IntPtr atuid_version);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr GetTestplanJsonV2(int handle, byte[] xml_content);

	[DllImport("SSCCTLHHXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Uninit")]
	public static extern void DoUninit(int handle);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CTTLInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static void BalGTb4I0Al()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CTTLInterface()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					UtilsObj = new object();
					num = 5;
					break;
				case 5:
					return;
				case 2:
					xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
					num2 = 1;
					if (1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					FLicensePath = (string)MFsJc5uaGLZILpvRAuwN(121768);
					num = 3;
					break;
				case 1:
					no51tBHZ35yMyaa8WrU.FTtBuvSzFjHhG();
					num2 = 4;
					continue;
				case 3:
					FDebugPath = (string)Etf7aAua3B9T55SH4f9y(ConstBase.DebugPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(122834));
					num2 = 0;
					if (1 == 0)
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
	internal static object Hb3HdFuaT4v16ec1xxoi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lHWeHAuaEPA1H4g50UuU()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CTTLInterface yh2rSVuaV2r02goRItUT()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qDDDdsuapwANr59USN80()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XKRJZouaQ8Sfg84ojsTv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wAud73uaR8nYrMgIL1sP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MFsJc5uaGLZILpvRAuwN(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Etf7aAua3B9T55SH4f9y(object P_0, object P_1)
	{
		return null;
	}
}
