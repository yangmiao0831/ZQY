using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SiteEditRecord_Old
{
	public int siteIndex;

	public int cellIndex;

	public int fillColor;

	public int displayStyle;

	public int cellSize;

	public int cellCoverLine;

	public int cellCoverBrush;

	public int cellCoverLineLength;

	public int cellCoverBrushLength;

	public int cellCoverLineColor;

	public int cellCoverBrushColor;
}
