using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SiteRecord_Old
{
	public double dx;

	public double dy;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
	public string siteName;

	public CellRecord Cell;
}
