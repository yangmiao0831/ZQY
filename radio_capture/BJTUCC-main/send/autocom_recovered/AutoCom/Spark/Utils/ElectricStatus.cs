using LibUtils;

namespace Spark.Utils;

public enum ElectricStatus
{
	[MyDescription("上电", "")]
	dev_power_on = 1,
	[MyDescription("下电", "")]
	dev_power_off,
	[MyDescription("初始状态", "")]
	dev_non_existent
}
