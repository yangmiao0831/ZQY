using LibUtils;

namespace LibCoord;

public enum CustomEventType
{
	[MyDescription("参数型", "Param")]
	Param,
	[MyDescription("事件型", "Event")]
	Event,
	[MyDescription("状态型", "Status")]
	Status,
	[MyDescription("累计型", "Cumulative")]
	Cumulative
}
