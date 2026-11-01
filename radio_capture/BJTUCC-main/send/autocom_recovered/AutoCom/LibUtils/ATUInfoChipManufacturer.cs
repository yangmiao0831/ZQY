using System.ComponentModel;

namespace LibUtils;

public enum ATUInfoChipManufacturer
{
	[Description("高通")]
	Qualcomm = 0,
	[Description("海思")]
	Hisilicon = 1,
	[Description("其他")]
	other = 255
}
