using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct UBTLV_CustomParamRecord
{
	public UBTLV_HEAD Header;

	public UBTLV_INTTYPE PointIndex;

	public UBTLV_DOUBLETYPE Value;

	public UBTLV_INTTYPE ID;
}
