using LibUtils;

namespace LibCoord;

public enum ENUM_ADBCommonLockSA
{
	[MyDescription("自由模式", "Free Schema")]
	nsa,
	[MyDescription("NSA模式", "NSA Mode")]
	sa,
	[MyDescription("SA+NSA模式", "SA+NSA Mode")]
	nsasa
}
