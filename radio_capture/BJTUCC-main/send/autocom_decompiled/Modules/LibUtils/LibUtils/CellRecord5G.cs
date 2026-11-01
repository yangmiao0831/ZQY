using System;
using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct CellRecord5G
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
	public string cellName;

	public double startAngle;

	public double sweepAngle;

	public int fillColor;

	public int displayStyle;

	public int cellSize;

	public byte cellCoverLine;

	public byte cellCoverBrush;

	public int cellCoverLineLength;

	public int cellCoverBrushLength;

	public int cellCoverLineColor;

	public int cellCoverBrushColor;

	public IntPtr Extra;
}
