using System.Runtime.InteropServices;

namespace Spark.Utils;

public struct DeviceInfo
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
	public string Model;

	public int Extend;

	public int In;

	public int Out;

	public int UECount;

	public int CellCount;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
	public string Version;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
	public string SN;
}
