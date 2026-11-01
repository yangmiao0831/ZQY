using LibUtils;

namespace AARRRC.UI;

public enum StatAlgorithm
{
	[MyDescription("平均值", "Average")]
	avg,
	[MyDescription("最大值", "Maximum")]
	max,
	[MyDescription("最小值", "Minimum")]
	min,
	[MyDescription("百分比", "PDF")]
	pdf,
	[MyDescription("边缘值", "Edge")]
	edge,
	[MyDescription("参数分段", "Section")]
	section,
	[MyDescription("覆盖图", "Map")]
	map,
	[MyDescription("求和", "Sum")]
	sum,
	[MyDescription("采样点数量", "Point count")]
	count,
	[MyDescription("方差", "Variance")]
	var,
	[MyDescription("时长", "Duration")]
	duration,
	[MyDescription("距离", "Distance")]
	mileage,
	[MyDescription("分类名称", "Group")]
	group
}
