using System.ComponentModel;

namespace LibCoord;

public enum DualModeSiteAnalysis_Type
{
	[Description("数据+基站")]
	HasSites,
	[Description("纯NR数据")]
	NoSites
}
