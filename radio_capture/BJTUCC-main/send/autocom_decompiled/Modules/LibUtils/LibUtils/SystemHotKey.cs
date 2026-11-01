using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class SystemHotKey
{
	[Flags]
	public enum KeyModifiers
	{
		None = 0,
		Alt = 1,
		Ctrl = 2,
		CtrlAndAlt = 3,
		Shift = 4,
		CtrlAndShift = 6,
		WindowsKey = 8
	}

	public const int CIBookMarkHotKey = 100;

	public const int CISave3MinLogHotKey = 101;

	public const int CIScreenShotHotKey = 102;

	public const int CIRafDevicePauseHotKey = 103;

	internal static SystemHotKey dTPs04LuD3omnXo2TMm;

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegHotKey(IntPtr hwnd, int hotKeyId, KeyModifiers keyModifiers, Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnRegHotKey(IntPtr hwnd, int hotKeyId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SystemHotKey()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemHotKey()
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
				case 2:
					b99vLwQv4vNmPibnHM.nIIRTpIJS2();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 1:
					vnj3h6Ls9ZZRKRpdvHn();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					ps4McLL8AR5BESmeVlG();
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object luCnJ3LXfTuofOCRDLO(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a7gKe8Llo02OOK7oh0i()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SystemHotKey Did2LeLVuRAayjQNhjH()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pbmmcTLw4vklxwH5akU()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L2PqApLemNiedtLsC1p()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ps4McLL8AR5BESmeVlG()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vnj3h6Ls9ZZRKRpdvHn()
	{
	}
}
