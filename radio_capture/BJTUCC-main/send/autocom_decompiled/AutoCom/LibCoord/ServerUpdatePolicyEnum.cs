using LibUtils;

namespace LibCoord;

public enum ServerUpdatePolicyEnum
{
	[MyDescription("定时更新", "UpdateByTime")]
	Time,
	[MyDescription("定次更新", "UpdateByCount")]
	Count
}
