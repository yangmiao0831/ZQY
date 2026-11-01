using System.ComponentModel;

namespace LibCoord;

public enum ENUM_ZTEME3612_LockNetwork
{
	[Description("GSM eMTC and NB-IoT Only")]
	GeMTCAndNBOnly = 0,
	[Description("GSM Only")]
	GSMOnly = 1,
	[Description("eMTC and NB-IoT Only")]
	eMTCAndNBOnly = 6
}
