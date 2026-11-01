using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using LibBase;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class ATUByZMQInterface
{
	public const int CISucc = 0;

	public static string FLicensePath;

	public static string FDebugPath;

	public static int FHandle;

	[CompilerGenerated]
	private static Action lYOwHG97f;

	private static ATUByZMQInterface LJUq1nJoEJU11pIUcnL;

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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int Login(string BoxID, string software_version)
	{
		return 0;
	}

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int Init(string license_path, string logPath);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Login")]
	private static extern int WdOvwvMUo(int P_0, string P_1, string P_2);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Logout")]
	private static extern int zVFG05NBa(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Uninit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Logout()
	{
		return 0;
	}

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr GetTestplan(int handle, ref int result_code, IntPtr atuid_version);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr ExchangePlanJson(int handle);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr XmlToJson(IntPtr xml, int ueIndex);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr XmlToJsonV2(IntPtr xml, int ueIndex, int useXmlTaskName);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr GetTestplanJson(int handle, ref int result_code, IntPtr atuid_version);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr GetTestplanJsonV2(int handle, byte[] xml_content);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int UploadProtocolBegin(int handle, ref uint file_size, ref uint file_id, string file_name, bool retransmit, uint module);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int UploadProtocolEOF(int handle, string file_name, uint file_id, uint packet_count, uint total_size, uint moudle, string md5);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int UploadDataPack(int handle, uint file_id, uint packet_no, byte[] data, uint data_len);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "Uninit")]
	public static extern void DoUninit(int handle);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int AddState(int handle, int type, string jsonStr);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int AddState(int handle, int type, byte[] jsonStr);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int DoUploadState(int handle);

	[DllImport("SSATUSSXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int UploadModuleConfig(int handle, uint module_num, AMTP_MODULE_TYPE_ENUM module_type, AMTP_CHIP_MANUFACTURER_ENUM chip_manufacturer, string chip_type, string icd_version, string imei, string imsi, string module_system, string module_factory, string phone_number, string network_operator);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ATUByZMQInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static void U2EHIn2Re()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ATUByZMQInterface()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 5;
					continue;
				case 4:
					FLicensePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstBase.SparkPath, (string)xh8AysJKYxLDKB5WdL0(4856), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					FDebugPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstBase.DebugPath, (string)xh8AysJKYxLDKB5WdL0(4934), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 3;
					continue;
				default:
					p3dTBvJSN1QB9C2JhY7();
					num2 = 2;
					continue;
				case 3:
					return;
				case 5:
					Icjw5fJH8awf02gMBFu();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					dwElbeJgvxroXxvM7bX();
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xh8AysJKYxLDKB5WdL0(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DF5WvJJiOqxqhvJ1QFq()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ATUByZMQInterface SAT56mJrI1B5SProZkl()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fiYmKxJn0p3AnF8XOOR()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EaTn43JWgAcM9ba13ph()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jrLkwiJj297FqJ1tCsp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ECjdrEJMyXIep8ou68b(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c17BYkJYB1VcIQiXS4L()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dwElbeJgvxroXxvM7bX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Icjw5fJH8awf02gMBFu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p3dTBvJSN1QB9C2JhY7()
	{
	}
}
