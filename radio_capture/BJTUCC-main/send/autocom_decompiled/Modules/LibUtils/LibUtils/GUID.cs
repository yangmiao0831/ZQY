using System.Runtime.InteropServices;

namespace LibUtils;

public struct GUID
{
	public uint Data1;

	public ushort Data2;

	public ushort Data3;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
	public string Data4;
}
