using System.ComponentModel;

namespace LibCoord;

public enum ENUM_QualcommSCSType
{
	[Description("15KHz")]
	csc15K,
	[Description("30KHz")]
	csc30K,
	[Description("60KHz")]
	csc60K,
	[Description("120KHz")]
	csc120K
}
