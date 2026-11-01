using System.ComponentModel;

namespace LibCoord;

public enum ENUM_Mate20X_LockNetwork
{
	[Description("GSM")]
	GSM = 1,
	[Description("WCDMA")]
	WCDMA,
	[Description("TD-SCDMA")]
	TD,
	[Description("LTE")]
	LTE
}
