using System.Runtime.InteropServices;

namespace LibCoord;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UBTLV_INTTYPE
{
	public int FieldKey;

	public int Length;

	public int value;
}
