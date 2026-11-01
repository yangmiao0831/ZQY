using LibUtils;

namespace LibCoord;

public enum ENUM_Mate20X_Operation
{
	[MyDescription("解锁", "Unlock")]
	close,
	[MyDescription("锁定频点", "Lock EARFCN")]
	freq,
	[MyDescription("锁定小区", "Lock Cell")]
	cell,
	[MyDescription("锁定频段", "Lock Band")]
	band
}
