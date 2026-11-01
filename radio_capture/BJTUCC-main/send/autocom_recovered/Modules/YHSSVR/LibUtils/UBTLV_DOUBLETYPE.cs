using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UBTLV_DOUBLETYPE
{
	public int FieldKey;

	public int Length;

	public float value;
}
