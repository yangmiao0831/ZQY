using System.ComponentModel;

namespace LibCoord;

public enum ENUM_SCSType
{
	[Description("15KHz")]
	csc15K,
	[Description("30KHz")]
	csc30K,
	[Description("60KHz")]
	csc60K,
	[Description("120KHz")]
	csc120K,
	[Description("240KHz")]
	csc240K
}
