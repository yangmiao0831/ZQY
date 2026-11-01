using LibUtils;

namespace LibCoord;

public enum RangeType
{
	[MyDescription("单一条件", "Single condition")]
	singletrigger,
	[MyDescription("起止范围", "Start stop range")]
	rangetrigger,
	[MyDescription("频率触发", "Frequency trigger")]
	frequencytrigger
}
