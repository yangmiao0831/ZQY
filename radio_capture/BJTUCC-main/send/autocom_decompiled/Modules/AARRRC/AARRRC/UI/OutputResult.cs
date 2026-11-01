namespace AARRRC.UI;

public enum OutputResult
{
	[MyDescription("分段序号", "Index")]
	index,
	[MyDescription("分段阈值", "Threshold")]
	condition,
	[MyDescription("采样数量", "Sampling Quantity")]
	count,
	[MyDescription("分段比例", "PDF")]
	pdf,
	[MyDescription("累积比例", "CDF")]
	cdf,
	[MyDescription("分段均值", "Mean")]
	avg,
	[MyDescription("分段最大值", "Maximum")]
	max,
	[MyDescription("分段最小值", "Minimum")]
	min,
	[MyDescription("分段求和", "Summation")]
	sum
}
