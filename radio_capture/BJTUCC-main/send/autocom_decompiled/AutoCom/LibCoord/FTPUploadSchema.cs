using LibUtils;

namespace LibCoord;

public enum FTPUploadSchema
{
	[MyDescription("按时长上传", "By time")]
	time,
	[MyDescription("按文件上传", "By file")]
	file,
	[MyDescription("按大小上传", "By size")]
	size
}
