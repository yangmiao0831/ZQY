using LibUtils;

namespace LibCoord;

public enum TimeLimitedDateType
{
	[MyDescription("日期和星期", "Date and Week")]
	DateandWeek,
	[MyDescription("日期或星期", "Date or Week")]
	DateorWeek,
	[MyDescription("仅日期", "Date Only")]
	DateOnly,
	[MyDescription("仅星期", "Week Only")]
	WeekOnly,
	[MyDescription("任意时间", "Random Time")]
	RandomTime
}
