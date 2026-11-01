using System.Runtime.InteropServices;

namespace SenseShield;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ST_LOGIN_PARAM
{
	public uint size;

	public uint license_id;

	public uint timeout;

	public uint login_mode;

	public uint login_flag;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public byte[] sn;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	public char[] server;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] access_token;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
	public char[] cloud_server;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	public byte[] snippet_seed;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
	public byte[] user_guid;
}
