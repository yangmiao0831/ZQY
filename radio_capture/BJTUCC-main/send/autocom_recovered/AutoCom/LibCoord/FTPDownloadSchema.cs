using LibUtils;

namespace LibCoord;

public enum FTPDownloadSchema
{
	[MyDescription("按时长下载", "By time")]
	time,
	[MyDescription("按文件下载", "By file")]
	file
}
