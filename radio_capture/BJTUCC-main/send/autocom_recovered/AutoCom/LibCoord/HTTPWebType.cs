using LibUtils;

namespace LibCoord;

public enum HTTPWebType
{
	[MyDescription("用户自定义网址", "Custom Web")]
	custom,
	[MyDescription("软件随机选择网址", "Random Web")]
	random,
	[MyDescription("用户选择固定网址", "Fix Web")]
	fix
}
