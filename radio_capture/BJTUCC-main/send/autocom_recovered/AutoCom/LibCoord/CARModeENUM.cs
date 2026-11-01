using LibUtils;

namespace LibCoord;

public enum CARModeENUM
{
	[MyDescription("串口模式", "Serial Port Mode")]
	com,
	[MyDescription("ADB模式", "ADB Mode")]
	adb,
	[MyDescription("网口模式", "IP Mode")]
	ip
}
