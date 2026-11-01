using LibUtils;

namespace LibCoord;

public enum HVPlaySchema
{
	[MyDescription("播放指定时长", "By time")]
	time,
	[MyDescription("播放整个文件", "By file")]
	file
}
