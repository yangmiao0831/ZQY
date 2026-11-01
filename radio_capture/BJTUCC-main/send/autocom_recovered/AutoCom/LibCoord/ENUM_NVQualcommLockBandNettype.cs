using LibUtils;

namespace LibCoord;

public enum ENUM_NVQualcommLockBandNettype
{
	[MyDescription("SA", "SA")]
	sa,
	[MyDescription("NSA", "NSA")]
	nsa,
	[MyDescription("LTE", "LTE")]
	lte,
	[MyDescription("SA+LTE混合", "SA+LTE")]
	salte,
	[MyDescription("NSA+LTE混合", "NSA+LTE")]
	nsalte
}
