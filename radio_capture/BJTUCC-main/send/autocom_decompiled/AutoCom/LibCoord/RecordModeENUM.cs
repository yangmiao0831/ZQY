using LibUtils;

namespace LibCoord;

public enum RecordModeENUM
{
	[MyDescription("主被叫轮循", "MOC and MTC Circulation")]
	MOCMTC,
	[MyDescription("仅主叫录音", "MOC Recording Only")]
	MOC,
	[MyDescription("仅被叫录音", "MTC recording Only")]
	MTC,
	[MyDescription("主被叫并发", "MOC and MTC Concurrent")]
	MOCMTCALL
}
