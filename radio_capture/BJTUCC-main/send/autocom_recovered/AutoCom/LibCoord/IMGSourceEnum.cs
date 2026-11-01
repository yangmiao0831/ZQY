using LibUtils;

namespace LibCoord;

public enum IMGSourceEnum
{
	[MyDescription("本地文件", "Local File")]
	File,
	[MyDescription("自动创建", "Create")]
	Create,
	[MyDescription("实时拍摄", "Photo Graph")]
	Photograph
}
