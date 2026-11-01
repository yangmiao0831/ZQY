using LibUtils;

namespace LibCoord;

public enum CAContinueType
{
	[MyDescription("持续时间(s)", "Continue Time(s)")]
	Time = 1,
	[MyDescription("持续距离(m)", "Continue Distance(m)")]
	Distance,
	[MyDescription("持续个数", "Continue Number")]
	Number
}
