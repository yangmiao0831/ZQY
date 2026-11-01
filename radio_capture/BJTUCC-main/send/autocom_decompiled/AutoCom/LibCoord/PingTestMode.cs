using LibUtils;

namespace LibCoord;

public enum PingTestMode
{
	[MyDescription("普通Ping", "Normal Ping")]
	NormalPing,
	[MyDescription("RRC Idle Ping", "RRC Idle Ping")]
	IdlePing,
	[MyDescription("RRC Inactive Ping", "RRC Inactive Ping")]
	Inactive,
	[MyDescription("仅5G", "5G Only")]
	NR5G,
	[MyDescription("仅LTE", "LTE Only")]
	LTE
}
