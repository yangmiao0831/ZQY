using LibUtils;

namespace LibCoord;

public enum ENUM_YY_Method
{
	[MyDescription("重启后生效", "Effective after restart")]
	AfterRestart,
	[MyDescription("立即生效", "Effective immediately")]
	Immediately
}
