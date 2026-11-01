using LibUtils;

namespace LibCoord;

public enum IperfProtocolVer
{
	[MyDescription("iPerf2", "iPerf2")]
	iPerf2 = 3,
	[MyDescription("iPerf3", "iPerf3")]
	iPerf3 = 4,
	[MyDescription("BWT协议", "BWT Protocol")]
	VerServer = 2,
	[MyDescription("AT灌包_NB-IoT", "AT Pack NB-IoT")]
	VerNBIoT = 0,
	[MyDescription("灌包_单机模式", "Pack-Single Machine Mode")]
	VerSingle = 1
}
