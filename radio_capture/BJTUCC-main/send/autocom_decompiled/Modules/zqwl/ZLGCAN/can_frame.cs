using System.Runtime.InteropServices;

namespace ZLGCAN;

public struct can_frame
{
	public uint can_id;

	public byte can_dlc;

	public byte __pad;

	public byte __res0;

	public byte __res1;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public byte[] data;
}
