using System.Runtime.InteropServices;

namespace ZLGCAN;

public struct ZCAN_CHANNEL_ERROR_INFO
{
	public uint error_code;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public byte[] passive_ErrData;

	public byte arLost_ErrData;
}
