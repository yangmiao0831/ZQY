using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum enumNRSubcarrierSpacing
{
	[MyDescription("自动检测", "Auto Detect")]
	NR_Autodetect = 0,
	[Description("15KHz")]
	NR_15KHz = 15,
	[Description("30KHz")]
	NR_30KHz = 30,
	[Description("120KHz")]
	NR_120KHz = 120,
	[Description("240KHz")]
	NR_240KHz = 240
}
