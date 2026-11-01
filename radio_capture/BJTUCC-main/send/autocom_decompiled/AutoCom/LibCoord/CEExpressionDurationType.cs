using LibUtils;

namespace LibCoord;

public enum CEExpressionDurationType
{
	[MyDescription("按里程(m)", "By Distance(m)")]
	byDistance,
	[MyDescription("按时长(s)", "By Duration(s)")]
	byDuration,
	[MyDescription("无持续条件", "None")]
	byNone
}
