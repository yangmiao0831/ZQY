using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UBTLV_HEAD
{
	public int WriteType;

	public int Length;
}
