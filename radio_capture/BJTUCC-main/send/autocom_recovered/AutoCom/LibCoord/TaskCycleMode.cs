using LibUtils;

namespace LibCoord;

public enum TaskCycleMode
{
	[MyDescription("按间隔循环", "By Interval")]
	Interval,
	[MyDescription("按周期循环", "By Duration")]
	Period
}
