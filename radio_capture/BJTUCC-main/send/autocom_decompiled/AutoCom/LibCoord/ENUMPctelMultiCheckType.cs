using System.ComponentModel;

namespace LibCoord;

public enum ENUMPctelMultiCheckType
{
	[Description("BandListNR5G")]
	BandListNR5G = 1,
	[Description("BandListLte")]
	BandListLte,
	[Description("ESPTS")]
	EPSTS,
	[Description("SubFrame")]
	SubFrame,
	[Description("Symbol")]
	Symbol,
	[Description("BandListNB")]
	BandListNB,
	[Description("GSM")]
	BandListGSM,
	[Description("WCDMA")]
	BandListWCDMA,
	[Description("CDMA")]
	BandListCDMA,
	[Description("WiFi")]
	BandListWiFi
}
