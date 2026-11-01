using System.Runtime.InteropServices;

namespace SenseShield;

public struct ST_INIT_PARAM
{
	public uint version;

	public uint flag;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public callback pfn;

	public uint timeout;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public byte[] password;
}
