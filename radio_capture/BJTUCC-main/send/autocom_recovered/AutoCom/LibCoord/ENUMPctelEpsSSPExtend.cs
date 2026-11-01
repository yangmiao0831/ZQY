using System.ComponentModel;

namespace LibCoord;

public enum ENUMPctelEpsSSPExtend
{
	[Description("0（3:8:1）")]
	SSPExtend0 = 1,
	[Description("1（8:3:1）")]
	SSPExtend1,
	[Description("2（9:2:1）")]
	SSPExtend2,
	[Description("3（10:2:1）")]
	SSPExtend3,
	[Description("4（3:7:2）")]
	SSPExtend4,
	[Description("5（8:2:2）")]
	SSPExtend5,
	[Description("6（9:1:2）")]
	SSPExtend6
}
