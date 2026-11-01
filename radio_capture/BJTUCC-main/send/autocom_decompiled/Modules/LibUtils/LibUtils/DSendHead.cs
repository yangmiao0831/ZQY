using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct DSendHead
{
	public ECmdType Type;

	public int DataKey;

	public int Len;
}
