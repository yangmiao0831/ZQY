using System.Runtime.InteropServices;

namespace LibCoord;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UBTLV_HEAD
{
	public int WriteType;

	public int Length;
}
