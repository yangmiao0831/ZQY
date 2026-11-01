using System.ComponentModel;

namespace LibUtils;

public enum NetType
{
	[Description("LTE")]
	LTE = 1,
	[Description("WCDMA")]
	WCDMA = 2,
	[Description("TD")]
	TD = 3,
	[Description("GSM")]
	GSM = 4,
	[Description("CDMA")]
	CDMA = 5,
	[Description("eMTC")]
	eMTC = 9,
	[Description("NB-IoT")]
	NB = 10,
	[Description("NR5G")]
	NR5G = 11,
	[Description("NR NSA")]
	NRNSA = 13,
	[Description("NR DC")]
	NRDC = 14,
	[Description("NR RedCap")]
	NRRedCap = 15,
	[Description("Scanner")]
	Scanner = 101,
	[Description("Unknown")]
	Unknown = 254,
	[Description("NoService")]
	NoService = 255,
	[Description("CustomParam")]
	CustomParam = 16801,
	[Description("NullValue")]
	NullValue = -16777215
}
