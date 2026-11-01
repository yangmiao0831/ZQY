using LibUtils;

namespace LibCoord;

public enum CloudUploadSchema
{
	[MyDescription("按时长上传", "By time")]
	time,
	[MyDescription("按大小上传", "By size")]
	size
}
