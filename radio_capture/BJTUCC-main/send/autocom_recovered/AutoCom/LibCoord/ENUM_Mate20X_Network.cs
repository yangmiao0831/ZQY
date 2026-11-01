using System.ComponentModel;

namespace LibCoord;

public enum ENUM_Mate20X_Network
{
	[Description("5G NSA")]
	NWAuto = 0,
	[Description("5G SA")]
	NW8 = 8,
	[Description("4G")]
	NW3 = 3,
	[Description("3G")]
	NW2 = 2,
	[Description("2G")]
	NW1 = 1,
	[Description("5G SA + LTE")]
	NW11 = 11
}
