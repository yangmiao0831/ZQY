using LibUtils;

namespace AARRRC.UI;

public enum BinAlgorithm
{
	[MyDescription("平均值", "Average")]
	avg = 1,
	[MyDescription("最大值", "Maximum")]
	max = 2,
	[MyDescription("最小值", "Minimum")]
	min = 3,
	[MyDescription("采样点数", "Point Count")]
	pointCount = 4,
	[MyDescription("求和", "Sum")]
	sum = 5,
	[MyDescription("方差", "Variance")]
	variance = 6,
	[MyDescription("第一个采样点", "First point")]
	firstPoint = 7,
	[MyDescription("最后一个采样点", "Last point")]
	lastPoint = 8,
	[MyDescription("最大比例值", "Max ratio")]
	maxRatio = 9,
	[MyDescription("最差5%", "Worst 5%")]
	worst5 = 105
}
