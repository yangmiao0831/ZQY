using LibUtils;

namespace LibCoord;

public enum CustomParamType
{
	[MyDescription("BOOL型", "Bool")]
	Bool,
	[MyDescription("数值型", "Number")]
	Number,
	[MyDescription("重采样", "Resampling")]
	Bin,
	[MyDescription("信令参数", "Message Parameter")]
	MsgDetail
}
