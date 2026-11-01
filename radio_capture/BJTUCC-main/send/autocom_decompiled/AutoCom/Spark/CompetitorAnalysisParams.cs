using System.ComponentModel;

namespace Spark;

public enum CompetitorAnalysisParams
{
	[Description("SSB RSRP[dBm]")]
	RSRP,
	[Description("SSB SINR[dB]")]
	SINR,
	[Description("FTP DL Thr.[Mbps]")]
	FTPDownload,
	[Description("FTP UL Thr.[Mbps]")]
	FTPUpload,
	[Description("MAC DL Thr.[Mbps]")]
	MACDL,
	[Description("MAC UL Thr.[Mbps]")]
	MACUL
}
