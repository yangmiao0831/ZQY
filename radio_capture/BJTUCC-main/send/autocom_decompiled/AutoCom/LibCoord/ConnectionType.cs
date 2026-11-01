using LibUtils;

namespace LibCoord;

public enum ConnectionType
{
	[MyDescription("APP测试", "APP Test")]
	app,
	[MyDescription("当前网络", "Current network")]
	current,
	[MyDescription("虚拟网卡", "RNDIS")]
	virtualnetwork,
	[MyDescription("AT网络连接", "AT")]
	atipcall,
	[MyDescription("AT NDIS连接", "NDIS AT")]
	ndis,
	[MyDescription("PPP拨号", "PPP")]
	createppp
}
