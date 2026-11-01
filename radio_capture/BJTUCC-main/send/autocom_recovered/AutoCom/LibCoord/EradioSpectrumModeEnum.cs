using LibUtils;

namespace LibCoord;

public enum EradioSpectrumModeEnum
{
	[MyDescription("下行频谱", "Downlink spectrum")]
	Down = 0,
	[MyDescription("上行频谱", "Uplink spectrum")]
	Up = 1,
	[MyDescription("GP频谱", "GP spectrum")]
	GP = 2,
	[MyDescription("不输出", "None")]
	None = 255
}
