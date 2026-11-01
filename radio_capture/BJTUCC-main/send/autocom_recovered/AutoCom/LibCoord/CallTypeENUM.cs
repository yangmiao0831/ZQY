using LibUtils;

namespace LibCoord;

public enum CallTypeENUM
{
	[MyDescription("仅做主叫", "MOC Only")]
	MOC,
	[MyDescription("仅做被叫", "MTC Only")]
	MTC,
	[MyDescription("互拨-主叫", "Dial-MOC")]
	UnionMOC,
	[MyDescription("互拨-被叫", "Dial-MTC")]
	UnionMTC,
	[MyDescription("轮循-先拨", "Cycle-First")]
	CycleFirst,
	[MyDescription("轮循-后拨", "Cycle-Last")]
	CycleLast
}
