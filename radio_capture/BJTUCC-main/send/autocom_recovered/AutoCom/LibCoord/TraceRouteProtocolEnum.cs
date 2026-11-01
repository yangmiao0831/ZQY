using System.ComponentModel;

namespace LibCoord;

public enum TraceRouteProtocolEnum
{
	[Description("UDP")]
	UDP,
	[Description("ICMP")]
	ICMP,
	[Description("TCP")]
	TCP
}
