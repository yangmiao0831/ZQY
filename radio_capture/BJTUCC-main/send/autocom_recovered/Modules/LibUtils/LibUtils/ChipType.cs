using System.ComponentModel;

namespace LibUtils;

public enum ChipType
{
	[Description("Others")]
	ctUnknown = 0,
	[Description("Qualcomm")]
	ctQualcomm = 1,
	[Description("Hisi")]
	ctHisi = 13
}
