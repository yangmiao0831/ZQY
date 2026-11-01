using System.Runtime.InteropServices;

namespace ZLGCAN;

public struct ZCLOUD_DEVINFO
{
	public int devIndex;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] type;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] id;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] name;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] owner;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] model;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public char[] fwVer;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public char[] hwVer;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
	public char[] serial;

	public int status;

	public byte bGpsUploads;

	public byte channelCnt;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public ZCLOUD_CHNINFO[] channels;
}
