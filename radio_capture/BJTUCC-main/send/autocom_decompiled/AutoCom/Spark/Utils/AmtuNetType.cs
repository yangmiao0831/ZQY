using LibUtils;

namespace Spark.Utils;

public enum AmtuNetType
{
	[MyDescription("NR", "NR")]
	NetType_NR,
	[MyDescription("LTE", "LTE")]
	NetType_LTE,
	[MyDescription("All", "All")]
	NetType_All
}
