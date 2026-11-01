using System.ComponentModel;

namespace LibUtils;

public enum ATUInfoNetworkOperator
{
	[Description("")]
	none = 0,
	[Description("中国移动")]
	cm = 1,
	[Description("中国电信")]
	ct = 3,
	[Description("中国联通")]
	cu = 2
}
