using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SiteRecordAll
{
	public double dx;

	public double dy;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
	public string siteName;

	public byte cellCoverLine;

	public byte cellCoverBrush;

	public int cellCoverLineLength;

	public int cellCoverBrushLength;

	public uint cellCoverLineColor;

	public uint cellCoverBrushColor;

	public int cellCount;

	public CellRecord Cell0;

	public CellRecord Cell1;

	public CellRecord Cell2;
}
