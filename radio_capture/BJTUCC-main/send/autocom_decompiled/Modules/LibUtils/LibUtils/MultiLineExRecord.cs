using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct MultiLineExRecord
{
	public double x;

	public double y;

	public double x2;

	public double y2;

	public int color;

	public byte size;

	public byte style;
}
