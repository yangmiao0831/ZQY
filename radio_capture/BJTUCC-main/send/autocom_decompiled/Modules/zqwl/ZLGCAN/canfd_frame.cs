using System.Runtime.InteropServices;

namespace ZLGCAN;

public struct canfd_frame
{
	public uint can_id;

	public byte len;

	public byte flags;

	public byte __res0;

	public byte __res1;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public byte[] data;
}
