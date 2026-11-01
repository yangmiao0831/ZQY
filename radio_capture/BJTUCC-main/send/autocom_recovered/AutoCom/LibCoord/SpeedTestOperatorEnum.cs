using LibUtils;

namespace LibCoord;

public enum SpeedTestOperatorEnum
{
	[MyDescription("移动", "China Mobile")]
	cm = 1,
	[MyDescription("联通", "China Unicom")]
	cu,
	[MyDescription("电信", "China Telecom")]
	ct,
	[MyDescription("广电", "China Broadcasting")]
	cb
}
