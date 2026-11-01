using LibUtils;

namespace LibCoord;

public enum LogTestMode
{
	[MyDescription("常规模式", "Normal Mode")]
	Normal,
	[MyDescription("单站模式", "SingleSite Mode")]
	SingleSite,
	[MyDescription("室内模式", "Indoor Mode")]
	Indoor,
	[MyDescription("高铁模式", "HighSpeed Rail")]
	HighSpeedRail,
	[MyDescription("地铁模式", "Metro")]
	Metro,
	[MyDescription("室外步测", "Outdoor Walking Test")]
	OutdoorCQT
}
