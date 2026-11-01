using System.Runtime.InteropServices;

namespace Spark.Utils;

public struct CellInfo
{
	public int CellNum;

	public int UENum;

	public int NetType;

	public double Value;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public SPortInfo[] SPortInfo;
}
