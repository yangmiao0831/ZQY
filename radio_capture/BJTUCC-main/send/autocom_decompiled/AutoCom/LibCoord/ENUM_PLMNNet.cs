using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum ENUM_PLMNNet
{
	[MyDescription("不指定网络", "No network specified")]
	None = -1,
	[Description("GSM")]
	GSM = 0,
	[Description("WCDMA")]
	WCDMA = 2,
	[Description("LTE")]
	LTE = 7,
	[Description("NB-IoT")]
	NB = 9
}
