using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELNetTypeCW
{
	[Description("NB-IoT")]
	NB = 10,
	[Description("NR5G")]
	NR5G = 11,
	[Description("LTE")]
	LTE = 1,
	[Description("WCDMA")]
	WCDMA = 2,
	[Description("CDMA/EVDO")]
	CDMA = 5,
	[Description("WiFi")]
	WiFi = 12,
	[Description("Auto")]
	Auto = 254
}
