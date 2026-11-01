using System.ComponentModel;

namespace LibCoord;

public enum OffFreqParamEnum
{
	[Description("UL MAC Thr[Mbps]")]
	UL_MAC_InstThr = 334430213,
	[Description("DL MAC Thr[Mbps]")]
	DL_MAC_InstThr = 334364677,
	[Description("FTP Download Thr.[Mbps]")]
	DL_FTP_InstThr = 66912263,
	[Description("FTP Upload Thr.[Mbps]")]
	UL_FTP_InstThr = 67239943
}
