using System.Runtime.InteropServices;

namespace LibUtils;

public struct DEV_BROADCAST_PORT
{
	public uint dbcp_size;

	public uint dbcp_devicetype;

	public uint dbcp_reserved;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
	public string dbcp_name;
}
