using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum enumNRPilotScanSortType
{
	[MyDescription("默认", "Default")]
	NR_Unsort,
	[Description("PSS RP(dBm)")]
	NR_PSS_RP,
	[Description("PSS RQ(dB)")]
	NR_PSS_RQ,
	[Description("PSS CINR(dB)")]
	NR_PSS_CINR,
	[Description("SSS RP(dBm)")]
	NR_SSS_RP,
	[Description("SSS RQ(dB)")]
	NR_SSS_RQ,
	[Description("SSS CINR(dB)")]
	NR_SSS_CINR,
	[Description("DMRS RP(dBm)")]
	NR_DMRS_RP,
	[Description("DMRS RQ(dB)")]
	NR_DMRS_RQ,
	[Description("DMRS CINR(dB)")]
	NR_DMRS_CINR,
	[Description("SSB RP(dBm)")]
	NR_SSB_RP,
	[Description("SSB RQ(dB)")]
	NR_SSB_RQ,
	[Description("SSB CINR(dB)")]
	NR_SSB_CINR
}
