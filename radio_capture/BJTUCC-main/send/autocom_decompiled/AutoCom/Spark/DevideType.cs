using LibUtils;

namespace Spark;

public enum DevideType
{
	[MyDescription("按时间", "By Time")]
	Time,
	[MyDescription("按日期时间", "By DateTime")]
	DateTime,
	[MyDescription("按区域", "By Zone")]
	Zone,
	[MyDescription("过滤器", "By Filter")]
	Filter,
	[MyDescription("剔除时间", "By Eliminate Time")]
	EliminateTime,
	[MyDescription("剔除区域", "By Eliminate Zone")]
	EliminateZone
}
