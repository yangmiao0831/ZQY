using LibUtils;

namespace AARRRC.UI;

public enum HasFilterEnum
{
	[MyDescription("False", "False")]
	False,
	[MyDescription("True, 参数条件", "True, Parameters")]
	TrueAndParam,
	[MyDescription("True, 业务范围", "True, Sessions")]
	TrueAndSession,
	[MyDescription("True, 多条件", "True Multi conditions")]
	TrueAndMulti
}
