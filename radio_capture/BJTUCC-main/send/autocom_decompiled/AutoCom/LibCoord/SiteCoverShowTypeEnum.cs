using LibUtils;

namespace LibCoord;

public enum SiteCoverShowTypeEnum
{
	[MyDescription("与服务小区颜色一致", "Same Color as Serving Cell Color")]
	ServingCellColor,
	[MyDescription("按参数分段显示颜色", "Display Parameter Threshold Color")]
	ThresholdColor
}
