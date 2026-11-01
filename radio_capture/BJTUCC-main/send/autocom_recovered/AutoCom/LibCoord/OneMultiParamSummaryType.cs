using LibUtils;

namespace LibCoord;

public enum OneMultiParamSummaryType
{
	[MyDescription("-", "-")]
	None,
	[MyDescription("平均值", "Avg")]
	Avg,
	[MyDescription("求和", "Sum")]
	Sum
}
