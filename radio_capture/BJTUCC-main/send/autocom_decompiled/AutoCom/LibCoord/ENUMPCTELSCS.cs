using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELSCS
{
	[Description("5KHz")]
	SCS1 = 1,
	[Description("10KHz")]
	SCS2,
	[Description("15KHz")]
	SCS3,
	[Description("20KHz")]
	SCS4,
	[Description("30KHz")]
	SCS5,
	[Description("50KHz")]
	SCS6,
	[Description("60KHz")]
	SCS7,
	[Description("100KHz")]
	SCS8,
	[Description("120KHz")]
	SCS9,
	[Description("200KHz")]
	SCS10,
	[Description("240KHz")]
	SCS11,
	[Description("300KHz")]
	SCS12
}
