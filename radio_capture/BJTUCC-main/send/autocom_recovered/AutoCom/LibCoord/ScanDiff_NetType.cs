using System.ComponentModel;

namespace LibCoord;

public enum ScanDiff_NetType
{
	[Description("NR5G")]
	NR5G = 11,
	[Description("LTE")]
	LTE = 1,
	[Description("NB-IoT")]
	NB = 10
}
