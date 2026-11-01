using LibUtils;

namespace LibCoord;

public enum EradioBandLimited
{
	[MyDescription("中国频段", "Chinese Band")]
	ChineseBand = 0,
	[MyDescription("全球频段", "Global Band")]
	GlobalBand = 1,
	[MyDescription("中国移动", "China Mobile")]
	ChinaMobile = 10,
	[MyDescription("中国电信", "China Telecom")]
	ChinaTelecom = 11,
	[MyDescription("中国联通", "China Unicom")]
	ChinaUnicom = 12,
	[MyDescription("中国广电", "China Broadcast")]
	ChinaBroadcast = 13
}
