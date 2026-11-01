using System.Runtime.InteropServices;

namespace ZLGCAN;

[StructLayout(LayoutKind.Explicit)]
public struct ZCAN_CHANNEL_INIT_CONFIG
{
	[FieldOffset(0)]
	public uint can_type;

	[FieldOffset(4)]
	public ZCAN can;

	[FieldOffset(4)]
	public CANFD canfd;
}
