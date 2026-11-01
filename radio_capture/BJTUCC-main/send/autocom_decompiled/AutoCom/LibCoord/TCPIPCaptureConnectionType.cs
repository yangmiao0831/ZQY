using LibUtils;

namespace LibCoord;

public enum TCPIPCaptureConnectionType
{
	[MyDescription("手机网络", "Phone Network")]
	APPnoROOT,
	[MyDescription("当前网络", "Current Network")]
	Current,
	[MyDescription("虚拟网卡", "RNDIS")]
	RNDIS,
	[MyDescription("PPP连接", "PPP")]
	PPP
}
