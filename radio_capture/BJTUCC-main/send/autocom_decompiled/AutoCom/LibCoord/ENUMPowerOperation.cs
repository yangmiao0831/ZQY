using LibUtils;

namespace LibCoord;

public enum ENUMPowerOperation
{
	[MyDescription("开机", "PowerOn")]
	PowerOn,
	[MyDescription("关机", "PowerOff")]
	PowerOff,
	[MyDescription("循环开关机", "Loop")]
	Loop
}
