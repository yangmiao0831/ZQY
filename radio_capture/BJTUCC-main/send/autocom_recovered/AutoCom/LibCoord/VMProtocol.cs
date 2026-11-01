using LibUtils;

namespace LibCoord;

public enum VMProtocol
{
	[MyDescription("TCP", "TCP")]
	TCP,
	[MyDescription("UDP", "UDP")]
	UDP,
	[MyDescription("Auto", "Auto")]
	AUTO
}
