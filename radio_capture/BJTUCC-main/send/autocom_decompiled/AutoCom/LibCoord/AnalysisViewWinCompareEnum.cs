using LibUtils;

namespace LibCoord;

public enum AnalysisViewWinCompareEnum
{
	[MyDescription("", "")]
	None,
	[MyDescription("大于等于", "Greater than or equal to")]
	Greater_Equal,
	[MyDescription("大于", "Greater than")]
	Greater,
	[MyDescription("小于等于", "Less than or equal to")]
	Less_Equal,
	[MyDescription("小于", "Less than")]
	Less,
	[MyDescription("等于", "Equal")]
	Equal,
	[MyDescription("不等于", "Not equal to")]
	Not_Equal
}
