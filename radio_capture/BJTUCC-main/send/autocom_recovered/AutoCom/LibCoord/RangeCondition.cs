using LibUtils;

namespace LibCoord;

public enum RangeCondition
{
	[MyDescription("事件", "Event")]
	rcEvent,
	[MyDescription("信令", "Message")]
	rcMsg,
	[MyDescription("参数", "Param")]
	rcParam,
	[MyDescription("时间", "Time")]
	rcTime
}
