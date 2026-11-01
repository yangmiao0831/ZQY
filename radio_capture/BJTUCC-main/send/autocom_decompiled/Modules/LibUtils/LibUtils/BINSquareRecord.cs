using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BINSquareRecord
{
	public double x;

	public double y;

	public double x2;

	public double y2;

	public double Value;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
	public string Text;
}
