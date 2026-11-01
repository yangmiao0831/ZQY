using System.ComponentModel;

namespace LibCoord;

public enum ENUM_ZTEME3612_LockNetMode
{
	[Description("eMTC Only")]
	GeMTCAndNBOnly = 1,
	[Description("NB-IoT Only")]
	GSMOnly,
	[Description("eMTC and NB-IoT")]
	eMTCAndNBOnly
}
