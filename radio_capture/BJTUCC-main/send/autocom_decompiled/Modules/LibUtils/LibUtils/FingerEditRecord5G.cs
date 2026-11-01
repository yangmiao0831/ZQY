using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FingerEditRecord5G
{
	public byte idx;

	public sbyte id;

	public byte colorx;

	public uint color;

	public byte fingerR1x;

	public int fingerR1;

	public byte fingerR2x;

	public int fingerR2;

	public byte fingerOR1x;

	public int fingerOR1;

	public byte fingerOR2x;

	public int fingerOR2;

	public byte fingerAx;

	public short fingerA;
}
