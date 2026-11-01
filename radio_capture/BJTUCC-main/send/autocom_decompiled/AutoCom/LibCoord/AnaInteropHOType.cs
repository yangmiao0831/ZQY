using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum AnaInteropHOType
{
	[MyDescription("汇总", "Total")]
	Total,
	[Description("4G-5G HO")]
	HO4G5G,
	[Description("5G-4G HO")]
	HO5G4G,
	[Description("4G-5G CSEL")]
	CSEL4G5G,
	[Description("5G-4G CSEL")]
	CSEL5G4G,
	[Description("4G-5G Redir")]
	Redir4G5G,
	[Description("5G-4G Redir")]
	Redir5G4G
}
