using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FingerRecord5G
{
	public sbyte id;

	public uint color;

	public int fingerR1;

	public int fingerR2;

	public int fingerOR1;

	public int fingerOR2;

	public short fingerA;
}
