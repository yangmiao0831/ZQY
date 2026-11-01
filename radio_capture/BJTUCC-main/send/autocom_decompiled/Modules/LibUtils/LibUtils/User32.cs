using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class User32
{
	internal static User32 nJ96vXBiudkSAGanuba;

	[DllImport("user32.dll")]
	public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr hwnd);

	[DllImport("user32.dll")]
	public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[DllImport("user32.dll")]
	public static extern IntPtr GetDC(IntPtr ptr);

	[DllImport("user32.dll")]
	public static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern int IhIa9qGkVl(IntPtr P_0, int P_1, uint P_2, uint P_3);

	[DllImport("User32.dll ")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public User32()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static User32()
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
				case 2:
					b99vLwQv4vNmPibnHM.nIIRTpIJS2();
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				default:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					return;
				case 3:
					et3PtjBWw80ejKmikwO();
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C0ajJPBn1aBHWGvM06c()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LQOXrZBr30G68ayS8F9()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static User32 WRCxbKBKAc4fnXBeGf4()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void et3PtjBWw80ejKmikwO()
	{
	}
}
