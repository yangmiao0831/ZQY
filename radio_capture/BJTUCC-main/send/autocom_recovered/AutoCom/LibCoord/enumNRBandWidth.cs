using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum enumNRBandWidth
{
	[MyDescription("自动检测", "Auto Detect")]
	Autodetect = 0,
	[Description("5MHz")]
	NR_5MHz = 5,
	[Description("10MHz")]
	NR_10MHz = 10,
	[Description("15MHz")]
	NR_15MHz = 15,
	[Description("20MHz")]
	NR_20MHz = 20,
	[Description("25MHz")]
	NR_25MHz = 25,
	[Description("30MHz")]
	NR_30MHz = 30,
	[Description("40MHz")]
	NR_40MHz = 40,
	[Description("50MHz")]
	NR_50MHz = 50,
	[Description("60MHz")]
	NR_60MHz = 60,
	[Description("70MHz")]
	NR_70MHz = 70,
	[Description("80MHz")]
	NR_80MHz = 80,
	[Description("90MHz")]
	NR_90MHz = 90,
	[Description("100MHz")]
	NR_100MHz = 100
}
