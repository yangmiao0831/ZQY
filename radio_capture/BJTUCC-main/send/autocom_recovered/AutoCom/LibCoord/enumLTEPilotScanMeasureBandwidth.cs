using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum enumLTEPilotScanMeasureBandwidth
{
	[Description("20MHz")]
	BW_20MHz,
	[Description("15MHz")]
	BW_15MHz,
	[Description("10MHz")]
	BW_10MHz,
	[Description("5MHz")]
	BW_5MHz,
	[Description("3MHz")]
	BW_3MHz,
	[Description("1.4MHz")]
	BW_1400KHz,
	[MyDescription("自动检测", "Auto Detect")]
	BW_AutoDetected
}
