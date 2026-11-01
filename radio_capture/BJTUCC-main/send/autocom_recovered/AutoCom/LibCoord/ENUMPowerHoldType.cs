using LibUtils;

namespace LibCoord;

public enum ENUMPowerHoldType
{
	[MyDescription("随机时长", "Random")]
	Random,
	[MyDescription("固定时长", "Fixed")]
	Fixed,
	[MyDescription("递增时长", "Ascend")]
	Ascend
}
