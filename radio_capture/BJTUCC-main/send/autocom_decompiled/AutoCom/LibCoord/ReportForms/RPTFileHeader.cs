using System.Runtime.InteropServices;

namespace LibCoord.ReportForms;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct RPTFileHeader
{
	public int Flag;

	public int Version;

	public int RptdSize;

	public int RptmSize;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
	public string RptmExt;

	public int RptmType;

	public long TimeStamp;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 500)]
	public string Reserved;
}
