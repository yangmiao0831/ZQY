using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SiteHead
{
	public byte cellCoverLine;

	public byte cellCoverBrush;

	public int cellCoverLineLength;

	public int cellCoverBrushLength;

	public uint cellCoverLineColor;

	public uint cellCoverBrushColor;
}
