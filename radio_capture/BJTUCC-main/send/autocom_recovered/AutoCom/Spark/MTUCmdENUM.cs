using LibUtils;

namespace Spark;

public enum MTUCmdENUM
{
	[MyDescription("上电", "Power on")]
	PowerOn = 1,
	[MyDescription("下电", "Power off")]
	PowerOff,
	[MyDescription("复位", "Reset")]
	Reset
}
