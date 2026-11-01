using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SiteEditRecord5G
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

	public int cellCoverBrushLengthO;

	public int cellCoverBrushColorO;

	public int fingerCount;

	public int fingerShowId;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public FingerEditRecord5G[] fingers;
}
