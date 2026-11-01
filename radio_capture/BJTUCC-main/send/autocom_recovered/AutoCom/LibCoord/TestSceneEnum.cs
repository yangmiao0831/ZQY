using LibUtils;

namespace LibCoord;

public enum TestSceneEnum
{
	[MyDescription("道路测试", "DT")]
	DT = 1,
	[MyDescription("定点测试", "CQT")]
	CQT,
	[MyDescription("室分测试", "Indoor Test")]
	Indoor,
	[MyDescription("单站验证", "Single Site")]
	SSV,
	[MyDescription("室外步行测试", "Outdoor Walking Test")]
	WT
}
