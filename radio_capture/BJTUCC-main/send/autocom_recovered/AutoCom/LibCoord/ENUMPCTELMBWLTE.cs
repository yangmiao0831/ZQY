using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELMBWLTE
{
	[Description("20MHz")]
	MHz20 = 1,
	[Description("15MHz")]
	MHz15,
	[Description("10MHz")]
	MHz10,
	[Description("5MHz")]
	MHz5,
	[Description("3MHz")]
	MHz3,
	[Description("1.4MHz")]
	MHz1Dot4
}
