using LibUtils;

namespace LibCoord;

public enum DelayTestDirection
{
	[MyDescription("上行", "Uplink")]
	UL,
	[MyDescription("下行", "Downlink")]
	DL,
	[MyDescription("双向并行", "Bidirectional parallel")]
	Bidirectional
}
