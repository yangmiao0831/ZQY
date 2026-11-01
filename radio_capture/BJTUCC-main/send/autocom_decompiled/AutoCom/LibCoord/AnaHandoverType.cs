using LibUtils;

namespace LibCoord;

public enum AnaHandoverType
{
	[MyDescription("SA切换", "SA Handover")]
	sa,
	[MyDescription("NSA切换", "NSA Handover")]
	nsa,
	[MyDescription("LTE切换", "LTE Handover")]
	lte
}
