using System.ComponentModel;

namespace LibCoord;

public enum ENUM_NetMode
{
	[Description("eMTC Band Perf")]
	eMTC = 1,
	[Description("NB Band Perf")]
	NBBand,
	[Description("eMTC&NB Band Perf")]
	eMTCandNBBand
}
