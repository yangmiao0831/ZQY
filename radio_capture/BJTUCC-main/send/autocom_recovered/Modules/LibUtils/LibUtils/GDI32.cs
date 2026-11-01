using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class GDI32
{
	private static GDI32 hMJEuwBxkubxCac738C;

	[DllImport("Gdi32.dll")]
	public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

	[DllImport("Gdi32.dll")]
	public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

	[DllImport("Gdi32.dll")]
	public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

	[DllImport("Gdi32.dll")]
	public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

	[DllImport("Gdi32.dll")]
	public static extern int DeleteDC(IntPtr hdc);

	[DllImport("Gdi32.dll")]
	public static extern IntPtr DeleteObject(IntPtr hObject);

	[DllImport("Gdi32.dll")]
	public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GDI32()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GDI32()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				default:
					VYwiFqBoRpK1k6vMcMd();
					num2 = 1;
					if (0 == 0)
					{
						num2 = 3;
					}
					goto IL_0017;
				case 2:
					lTyGS3BdT2J2AjJlCVQ();
					num2 = 1;
					if (1 == 0)
					{
						num2 = 1;
					}
					goto IL_0017;
				case 3:
					return;
				case 1:
					break;
				}
				iAYGWrBIVvcXiA7VnOW();
				num2 = 0;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iAYGWrBIVvcXiA7VnOW()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SCXLILBCO6KboqJeK2j()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xwsY8hB3G4aps8fCGEX()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GDI32 FuTB4TBFbShs7DCoPl5()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lTyGS3BdT2J2AjJlCVQ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VYwiFqBoRpK1k6vMcMd()
	{
	}
}
