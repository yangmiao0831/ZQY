using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UBTLV_INTTYPE
{
	public int FieldKey;

	public int Length;

	public int value;
}
