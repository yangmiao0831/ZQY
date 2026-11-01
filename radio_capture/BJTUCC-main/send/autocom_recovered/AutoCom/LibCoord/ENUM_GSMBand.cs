using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum ENUM_GSMBand
{
	[MyDescription("解锁", "UnLock")]
	UnLock = 0,
	[Description("G1800")]
	GSM1800 = 8,
	[Description("E-G900")]
	EGSM900 = 9,
	[Description("P-G900")]
	PGSM900 = 10,
	[Description("G850")]
	GSM850 = 20,
	[Description("G1900")]
	GSM1900 = 22
}
