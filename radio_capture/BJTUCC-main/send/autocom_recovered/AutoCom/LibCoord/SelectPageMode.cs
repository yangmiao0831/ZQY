using LibUtils;

namespace LibCoord;

public enum SelectPageMode
{
	[MyDescription("数据联合", "Data Union")]
	UnionAnalysis,
	[MyDescription("数据对比", "Data Compare")]
	CompareAnalysis,
	[MyDescription("saf", "")]
	SingleSaf
}
