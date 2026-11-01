using LibUtils;

namespace LibCoord;

public enum SpeedtestModeEnum
{
	[MyDescription("仅下载", "Download Only")]
	DLOnly,
	[MyDescription("仅上传", "Upload Only")]
	ULOnly,
	[MyDescription("下载上传串行", "Download Upload One by One")]
	DLtoUL
}
