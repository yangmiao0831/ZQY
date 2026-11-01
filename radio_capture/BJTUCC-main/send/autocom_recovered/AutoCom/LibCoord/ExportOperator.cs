using LibUtils;

namespace LibCoord;

public enum ExportOperator
{
	[MyDescription("移动", "Mobile")]
	Mobile,
	[MyDescription("电信", "Telecom")]
	Telecom,
	[MyDescription("联通", "Unicom")]
	Unicom,
	[MyDescription("广电", "Broadcast")]
	Broadcast,
	[MyDescription("", "")]
	Undefined
}
