using LibUtils;

namespace LibCoord;

public enum ENUM_NVLockNetType
{
	[MyDescription("自由模式", "Auto")]
	Auto = 1,
	[MyDescription("仅5G", "5G Only")]
	Only5G,
	[MyDescription("仅4G", "4G Only")]
	OnlyLTE,
	[MyDescription("4G+5G", "4G+5G")]
	NRLTE
}
