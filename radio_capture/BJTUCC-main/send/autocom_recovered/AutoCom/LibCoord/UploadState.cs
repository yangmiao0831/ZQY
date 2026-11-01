using LibUtils;

namespace LibCoord;

public enum UploadState
{
	[MyDescription("", "")]
	None,
	[MyDescription("上传中", "Uploading")]
	Uploading,
	[MyDescription("上传失败", "Upload Fail")]
	UploadFail,
	[MyDescription("已完成", "Completed")]
	Completed
}
