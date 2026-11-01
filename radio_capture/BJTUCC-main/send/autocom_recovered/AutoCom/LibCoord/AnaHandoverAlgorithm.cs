using LibUtils;

namespace LibCoord;

public enum AnaHandoverAlgorithm
{
	[MyDescription("里程切换比分析", "Too more Handover")]
	toomore,
	[MyDescription("切换测量分析", "N seconds no coverage before handover")]
	nocoverage
}
