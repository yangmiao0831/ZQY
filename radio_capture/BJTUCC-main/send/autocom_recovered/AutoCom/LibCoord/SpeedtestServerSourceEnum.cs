using LibUtils;

namespace LibCoord;

public enum SpeedtestServerSourceEnum
{
	[MyDescription("手动选择服务器", "Custom")]
	Custom,
	[MyDescription("自动匹配最佳服务器", "Auto")]
	Auto
}
