using System.Runtime.InteropServices;

namespace LibBase;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct LicContent
{
	public int LicenseVer;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public ulong[] CommonBoolSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
	public int[] CommonIntSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public long[] CommonLongSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public ulong[] UESet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public ulong[] SCSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public ulong[] TaskSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public ulong[] ReportSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public ulong[] AnalysisSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
	public ulong[] ProtocolSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
	public ulong[] BandSet;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 800)]
	public uint[] ReservedInt;
}
