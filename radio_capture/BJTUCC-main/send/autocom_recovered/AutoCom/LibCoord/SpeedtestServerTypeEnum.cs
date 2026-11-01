using LibUtils;

namespace LibCoord;

public enum SpeedtestServerTypeEnum
{
	[MyDescription("Speedtest", "Speedtest")]
	Speedtest,
	[MyDescription("泰尔网测", "CTTL Test")]
	CAICT,
	[MyDescription("泰尔测速服务", "CTTL SpeedTest")]
	CAICTSDK
}
