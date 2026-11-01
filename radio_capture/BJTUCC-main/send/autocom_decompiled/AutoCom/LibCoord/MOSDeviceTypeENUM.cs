using LibUtils;

namespace LibCoord;

public enum MOSDeviceTypeENUM
{
	[MyDescription("手机内置MOS", "Internal MOS")]
	InternalMOS,
	[MyDescription("多路MOS盒", "Multi MOS")]
	MultiMOS,
	MixDevice,
	MuxMOS
}
