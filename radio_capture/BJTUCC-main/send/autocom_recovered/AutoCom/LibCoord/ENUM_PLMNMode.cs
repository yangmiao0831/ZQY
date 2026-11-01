using LibUtils;

namespace LibCoord;

public enum ENUM_PLMNMode
{
	[MyDescription("自动注册", "Automatic register")]
	Auto,
	[MyDescription("手动注册", "Manual register")]
	Manual,
	[MyDescription("强制注销", "Compulsory unregister")]
	Force
}
