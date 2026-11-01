using LibUtils;

namespace AARRRC.UI;

public enum FilterSessionType
{
	[MyDescription("FTP下载", "FTP Download")]
	FTPDown,
	[MyDescription("FTP上传", "FTP Upload")]
	FTPUp,
	[MyDescription("主叫", "MO")]
	MO,
	[MyDescription("被叫", "MT")]
	MT,
	[MyDescription("BWT下行灌包", "BWT DL")]
	BWTDL,
	[MyDescription("BWT上行灌包", "BWT UL")]
	BWTUL,
	[MyDescription("NSA网络状态", "NSA Network State")]
	NSANetworkState
}
