using LibUtils;

namespace LibCoord;

public enum CEStatusType
{
	[MyDescription("参数值改变", "Param value change")]
	Change,
	[MyDescription("出现指定数值", "Specified value appear")]
	DefineValue,
	[MyDescription("指定范围改变", "Change of specified range")]
	DefineRange
}
