using LibUtils;

namespace LibCoord;

public enum SessionStatisticsType
{
	[MyDescription("整个业务过程", "Whole session process")]
	totalsession,
	[MyDescription("从First Packet到Last Packet/Drop", "First Packet to Last Packet/Drop")]
	firsttolast
}
