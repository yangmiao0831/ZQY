using System.ComponentModel;

namespace LibCoord;

public enum ENUM_IPType
{
	[Description("IPv4")]
	IPv4 = 1,
	[Description("IPv6")]
	IPv6,
	[Description("IPv4IPv6")]
	IPv4v6
}
