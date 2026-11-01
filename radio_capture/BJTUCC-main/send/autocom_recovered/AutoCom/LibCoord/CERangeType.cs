using LibUtils;

namespace LibCoord;

public enum CERangeType
{
	[MyDescription("起止时延", "Start stop delay")]
	Delay,
	[MyDescription("出现频率", "Frequency of occurrence")]
	Frequency,
	[MyDescription("乒乓切换", "PingPang Handover")]
	PingPang
}
