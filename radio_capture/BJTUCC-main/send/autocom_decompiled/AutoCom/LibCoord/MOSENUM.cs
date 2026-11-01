using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum MOSENUM
{
	[MyDescription("不做MOS", "No MOS")]
	none,
	[Description("POLQA MOS")]
	POLQA,
	[Description("PESQ MOS")]
	PESQ,
	[Description("CMRI MOS")]
	CMRIMOS,
	[Description("CTTL MOS")]
	CTTLMOS,
	[Description("MuPQA MOS")]
	MUPQA,
	[MyDescription("电信云MOS", "ChinaTelecom MOS")]
	CTMOS
}
