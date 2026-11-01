namespace AARRRC.UI;

public enum ParamAlgorithm
{
	[MyDescription("平均值", "Average")]
	Avg,
	[MyDescription("最小值", "Minimum")]
	Min,
	[MyDescription("最大值", "Maximum")]
	Max,
	[MyDescription("求和", "Sum")]
	Sum,
	[MyDescription("采样点数量", "Point count")]
	Count,
	[MyDescription("方差", "Variance")]
	Var,
	[MyDescription("第一个采样点", "First Point")]
	First
}
