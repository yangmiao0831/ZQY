using System.Runtime.InteropServices;

namespace ZLGCAN;

public struct ZCLOUD_USER_DATA
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] username;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] mobile;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public char[] dllVer;

	public uint devCnt;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
	public ZCLOUD_DEVINFO[] devices;
}
