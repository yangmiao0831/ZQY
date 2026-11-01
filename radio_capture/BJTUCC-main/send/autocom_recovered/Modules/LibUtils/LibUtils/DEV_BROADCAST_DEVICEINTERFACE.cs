using System.Runtime.InteropServices;

namespace LibUtils;

public struct DEV_BROADCAST_DEVICEINTERFACE
{
	public uint dbcc_size;

	public uint dbcc_devicetype;

	public uint dbcc_reserved;

	public GUID dbcc_classguid;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
	public string dbcc_name;
}
