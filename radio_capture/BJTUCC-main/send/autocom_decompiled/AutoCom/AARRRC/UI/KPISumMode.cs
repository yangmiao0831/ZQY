using LibUtils;

namespace AARRRC.UI;

public enum KPISumMode
{
	[MyDescription("仅输出汇总结果", "Output summary results only")]
	sum,
	[MyDescription("仅输出单文件结果", "Output only single file results")]
	log,
	[MyDescription("输出汇总结果和单文件结果", "Output summary and single file results")]
	all
}
