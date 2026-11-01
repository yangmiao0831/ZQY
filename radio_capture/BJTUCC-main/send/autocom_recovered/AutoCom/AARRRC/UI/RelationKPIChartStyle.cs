using LibUtils;

namespace AARRRC.UI;

public enum RelationKPIChartStyle
{
	[MyDescription("不输出", "No chart")]
	none,
	[MyDescription("柱状图", "Histogram")]
	bar,
	[MyDescription("折线图", "Line")]
	line
}
