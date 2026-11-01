using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum ENUM_LTEBand
{
	[MyDescription("解锁", "UnLock")]
	UnLock = 0,
	[Description("LTE B1")]
	LTEBC1 = 1,
	[Description("LTE B3")]
	LTEBC3 = 3,
	[Description("LTE B5")]
	LTEBC5 = 5,
	[Description("LTE B8")]
	LTEBC8 = 8
}
