using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UBTLV_STRINGTYPE
{
	public int FieldKey;

	public int Length;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
	public string value;
}
