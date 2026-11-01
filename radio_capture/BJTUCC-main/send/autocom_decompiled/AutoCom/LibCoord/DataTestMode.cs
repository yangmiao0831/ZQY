using LibUtils;

namespace LibCoord;

public enum DataTestMode
{
	[MyDescription("普通", "Normal")]
	Normal,
	[MyDescription("RRC Idle", "RRC Idle")]
	Idle,
	[MyDescription("RRC Inactive", "RRC Inactive")]
	Inactive,
	[MyDescription("仅5G", "5G Only")]
	NR5G,
	[MyDescription("仅LTE", "LTE Only")]
	LTE
}
