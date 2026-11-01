using LibUtils;

namespace LibCoord;

public enum VoiceSourceEnum
{
	[MyDescription("本地文件", "Local File")]
	File,
	[MyDescription("实时录制", "Real recording")]
	Record
}
