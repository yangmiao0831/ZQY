using LibUtils;

namespace LibCoord;

public enum ENUM_TraceCommon_LockNetwork
{
	[MyDescription("自动", "Auto")]
	Auto = 1,
	[MyDescription("仅2G", "2G Only")]
	Only2G,
	[MyDescription("仅3G", "3G Only")]
	Only3G,
	[MyDescription("仅4G", "4G Only")]
	Only4G,
	[MyDescription("仅5G", "5G Only")]
	Only5G
}
