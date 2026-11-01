using LibUtils;

namespace LibCoord;

public enum MOSCalcEnvironmentEnum
{
	[MyDescription("实时算分", "Real time Calc")]
	Local,
	[MyDescription("批量算分", "Batch Calc")]
	Server
}
