using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class POLQAInterface
{
	private static POLQAInterface V1Zxq2kEmVMLHFnTBXP;

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	public static extern IntPtr InitPOLQA(int polqaType, string licenseFile);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "InitPOLQAEx")]
	private static extern IntPtr vF4Tw67Vp6(int P_0, string P_1, int P_2);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	public static extern IntPtr InitPOLQAAll(int polqaType, string licenseFile, int polqaVer);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr CalcPOLQA(IntPtr PolqaHandle, string srcFile, string destFile);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr CalcPOLQAEx(IntPtr PolqaHandle, string srcFile, string destFile, ref bool needWait, ref int waitTimeS);

	[DllImport("POLQACalc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern uint UnInitPOLQA(IntPtr PolqaHandle);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr InitPOLQAEx(int polqaType, string licenseFile, int polqaVer)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public POLQAInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static POLQAInterface()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					EXBxNaktSyKKFWUWiJG();
					num2 = 3;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					return;
				default:
					Ym0NqikQAHE9mcR0R5i();
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Bkyl4Jkct8F53aM0wYp()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static POLQAInterface n4tGwukbH9C6H3UVtPt()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ym0NqikQAHE9mcR0R5i()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void afYeMykf5A5uJjaWdyV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EXBxNaktSyKKFWUWiJG()
	{
	}
}
