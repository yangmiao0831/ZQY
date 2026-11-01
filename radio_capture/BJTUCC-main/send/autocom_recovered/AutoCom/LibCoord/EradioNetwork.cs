using LibUtils;

namespace LibCoord;

public enum EradioNetwork
{
	[MyDescription("GSM", "GSM")]
	GSM,
	[MyDescription("CDMA", "CDMA")]
	CDMA1x,
	[MyDescription("CDMA2000", "CDMA2000")]
	EVDO,
	[MyDescription("WCDMA", "WCDMA")]
	WCDMA,
	[MyDescription("TD-SCDMA", "TD-SCDMA")]
	TDSCDMA,
	[MyDescription("TD-LTE", "TD-LTE")]
	TDLTE,
	[MyDescription("LTE FDD", "LTE FDD")]
	LTEFDD,
	[MyDescription("5G NR", "5G NR")]
	NR5G
}
