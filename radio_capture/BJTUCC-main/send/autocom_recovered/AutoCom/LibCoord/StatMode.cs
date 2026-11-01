using LibUtils;

namespace LibCoord;

public enum StatMode
{
	[MyDescription("当前时刻向前", "Pre-Time")]
	PreTime,
	[MyDescription("当前时刻向后", "After Time")]
	PostTime,
	[MyDescription("当前时刻前后", "Around")]
	Around,
	[MyDescription("整个数据统计", "Whole")]
	Whole
}
