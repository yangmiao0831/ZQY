using System.ComponentModel;

namespace LibCoord;

public enum ENUM_YY_LockGSMBand
{
	[Description("No Change")]
	V_0,
	[Description("EGSM900")]
	V_0x1,
	[Description("DCS1800")]
	V_0x2,
	[Description("GSM850")]
	V_0x4,
	[Description("PCS1900")]
	V_0x8,
	[Description("All Bands")]
	V_0xF
}
