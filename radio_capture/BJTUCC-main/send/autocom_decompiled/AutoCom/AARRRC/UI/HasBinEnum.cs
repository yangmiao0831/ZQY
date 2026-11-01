using LibUtils;

namespace AARRRC.UI;

public enum HasBinEnum
{
	[MyDescription("False", "False")]
	False,
	[MyDescription("True, 全局栅格", "True, Global Grid")]
	TrueAndGlobal,
	[MyDescription("True, 自定义", "True, Custom")]
	True
}
