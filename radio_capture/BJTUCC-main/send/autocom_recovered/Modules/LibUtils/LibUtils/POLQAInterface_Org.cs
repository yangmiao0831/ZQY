using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class POLQAInterface_Org
{
	internal static POLQAInterface_Org tQHqWlk62BGllKv7hDP;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr InitPOLQA(string licenseFile, POLQASWBENUM polqaSWB)
	{
		return (IntPtr)(object)null;
	}

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int PolqaLibInit(ref IntPtr PolqaHandle, string LicenseFilename, uint ulMode);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int PolqaLibRun(IntPtr PolqaHandle, int mRefSamples, ref float RefData, uint ulRefSampleRate, int mDegSamples, ref float DegData, uint ulDegSampleRate);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr PolqaLibGetResultsPointer(IntPtr PolqaHandle);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern double PolqaLibGetSecondsToWait(IntPtr PolqaHandle);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int PolqaLibFree(ref IntPtr PolqaHandle);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public POLQAInterface_Org()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static POLQAInterface_Org()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					s9dgwokTVKPES25pHFX();
					num2 = 3;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 1;
					if (false)
					{
						num2 = 0;
					}
					continue;
				case 3:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UGwgttkkrodH1yY5A8A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static POLQAInterface_Org HPZOHqkpgHouvx0af9M()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qqcAKsk4UecMQFcdMcl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s9dgwokTVKPES25pHFX()
	{
	}
}
