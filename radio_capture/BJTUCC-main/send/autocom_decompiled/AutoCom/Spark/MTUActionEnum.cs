using LibUtils;

namespace Spark;

public enum MTUActionEnum
{
	[MyDescription("上电", "Power on")]
	PowerOn,
	[MyDescription("下电", "Power off")]
	PowerOff,
	[MyDescription("复位", "Reset")]
	Reset,
	[MyDescription("时间同步", "Time Synchronize")]
	TimeSync
}
