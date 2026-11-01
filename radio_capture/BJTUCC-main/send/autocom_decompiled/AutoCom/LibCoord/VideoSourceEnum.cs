using LibUtils;

namespace LibCoord;

public enum VideoSourceEnum
{
	[MyDescription("本地文件", "Local File")]
	File,
	[MyDescription("实时录制", "Real recording")]
	Record,
	[MyDescription("自动创建", "Create")]
	Create
}
