using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PointRecord
{
	public double x;

	public double y;

	public double Value;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
	public string Text;
}
