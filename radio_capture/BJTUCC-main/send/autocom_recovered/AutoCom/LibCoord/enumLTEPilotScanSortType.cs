using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum enumLTEPilotScanSortType
{
	[MyDescription("默认", "Default")]
	Unsort,
	[Description("PSS RSSI(dBm)")]
	PSS_RSSI,
	[Description("PSS RP(dBm)")]
	PSS_RP,
	[Description("PSS RQ(dBm)")]
	PSS_RQ,
	[Description("PSS Timing")]
	PSS_Timing,
	[Description("PSS CINR(dB)")]
	PSS_SINR,
	[Description("SSS RSSI(dBm)")]
	SSS_RSSI,
	[Description("SSS RP(dBm)")]
	SSS_RP,
	[Description("SSS RQ(dB)")]
	SSS_RQ,
	[Description("SSS Timing")]
	SSS_Timing,
	[Description("SSS CINR(dB)")]
	SSS_SINR,
	[Description("RS RSSI(dBm)")]
	RS_RSSI,
	[Description("RS RP(dBm)")]
	RS_RP,
	[Description("RS RQ(dBm)")]
	RS_RQ,
	[Description("RS Timing")]
	RS_Timing,
	[Description("RS CINR(dB)")]
	RS_CINR
}
