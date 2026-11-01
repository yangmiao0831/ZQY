using LibUtils;

namespace LibCoord;

public enum NetPerf_ControlMode
{
	[MyDescription("匀速通信", "Stream")]
	Stream,
	[MyDescription("周期通信", "Trigger")]
	Trigger
}
