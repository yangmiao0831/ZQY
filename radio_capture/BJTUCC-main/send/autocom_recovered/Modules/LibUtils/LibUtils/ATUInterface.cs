using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class ATUInterface
{
	private delegate void oY3Oaq7u8OEExrD6E9(uint cmd, IntPtr cmd_s, IntPtr reserve);

	private static oY3Oaq7u8OEExrD6E9 nR9qDD2qmj;

	private static bool TCUqihkTlM;

	public static ATUProcessResult HasLogin;

	private static ATUInterface YV5VCCbjWDFRE8YFgOO;

	[DllImport("Amtpca.dll", CharSet = CharSet.Ansi, EntryPoint = "amtpca_version")]
	private static extern IntPtr evuqgMRhTP();

	[DllImport("Amtpca.dll", EntryPoint = "amtpca_init")]
	private static extern int y5dqjZ6dwd(string P_0, string P_1, oY3Oaq7u8OEExrD6E9 P_2);

	[DllImport("Amtpca.dll", EntryPoint = "amtpca_release")]
	private static extern void QxYqKM1unI();

	[DllImport("Amtpca.dll", EntryPoint = "amtpca_sendcmd")]
	private static extern void mohqWQc8Uc(uint P_0, IntPtr P_1, bool P_2, uint P_3);

	[DllImport("Amtpca.dll", EntryPoint = "amtpca_waitforcmd")]
	private static extern int emuq3iQaLj(uint P_0, IntPtr P_1, uint P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ATUInit(string licenseFile, string logPath = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void lhvqnPuZxN(uint P_0, IntPtr P_1, IntPtr P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ATUUnInit()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ATULoginByThread()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ATULogin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ATULogoutByThread()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ATULogout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ATUInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ATUInterface()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 3;
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
					HasLogin = ATUProcessResult.None;
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 5:
					TCUqihkTlM = false;
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 4:
					NY6AUrbmj7U6f8C8xmF();
					num2 = 5;
					continue;
				case 3:
					ueqBL1bUcVUf2vuvJNC();
					num = 2;
					break;
				case 2:
					LoIdQtb5vx7ZtiZW2Uo();
					num2 = 0;
					if (true)
					{
						num2 = 6;
					}
					continue;
				case 6:
					bPbLTJbNIYwFUb0IUrX();
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J89hxRbM7K7uZNYrlTS()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ATUInterface HI7d3kbYY5rNvjUS7Xf()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f20mhlbg797iLQhCuKD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint KhgIO6bH9hmfWgLtNUk(object P_0)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr ESt4HGbSur4qVrGiiA5(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr uZUiOFbD1f2nrvHFttg(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr bl5bLCbRHBMBjksKYvl(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NY6AUrbmj7U6f8C8xmF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ueqBL1bUcVUf2vuvJNC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoIdQtb5vx7ZtiZW2Uo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bPbLTJbNIYwFUb0IUrX()
	{
	}
}
