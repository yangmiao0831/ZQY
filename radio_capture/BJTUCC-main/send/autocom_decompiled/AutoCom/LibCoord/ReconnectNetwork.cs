using LibUtils;

namespace LibCoord;

public enum ReconnectNetwork
{
	[MyDescription("测试完成后断开", "By Task")]
	afterfinish,
	[MyDescription("每次测试断开", "By Loop")]
	everytime,
	[MyDescription("永不断开连接", "Never")]
	never
}
