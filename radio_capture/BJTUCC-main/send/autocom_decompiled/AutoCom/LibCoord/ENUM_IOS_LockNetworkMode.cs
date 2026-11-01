using System.ComponentModel;

namespace LibCoord;

public enum ENUM_IOS_LockNetworkMode
{
	[Description("GSM")]
	GSM = 0,
	[Description("UMTS")]
	UMTS = 1,
	[Description("CDMA 1x")]
	CDMA1x = 3,
	[Description("LTE")]
	LTE = 6,
	[Description("Automatic")]
	Automatic = 7,
	[Description("SA Stand Alone")]
	SAStandAlone = 9,
	[Description("NSA Stand Alone")]
	NSAStandAlone = 10,
	[Description("NR")]
	NR = 11
}
