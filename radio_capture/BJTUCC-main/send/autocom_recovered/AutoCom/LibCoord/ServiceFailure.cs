using LibUtils;

namespace LibCoord;

public enum ServiceFailure
{
	[MyDescription("继续测试", "Continue after failure")]
	continuetest,
	[MyDescription("结束当前外循环", "Stop after failure")]
	terminatetest,
	[MyDescription("连续失败重测", "Continue after series failure")]
	retest
}
