using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct TabShapeRecord
{
	public int shpIndex;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
	public string color;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
	public string width;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
	public string pattern;
}
