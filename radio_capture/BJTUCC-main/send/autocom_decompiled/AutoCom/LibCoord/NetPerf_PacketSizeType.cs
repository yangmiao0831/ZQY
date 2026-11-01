using LibUtils;

namespace LibCoord;

public enum NetPerf_PacketSizeType
{
	[MyDescription("固定大小", "Fixed")]
	Fixed,
	[MyDescription("随机大小", "Random")]
	Random,
	[MyDescription("动态大小", "Polling")]
	Polling
}
