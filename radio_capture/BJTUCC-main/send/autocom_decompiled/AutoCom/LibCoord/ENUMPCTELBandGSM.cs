using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELBandGSM
{
	[Description("850 (Cellular) DL：871–892 and 869–894 MHz")]
	DL850 = 256,
	[Description("850 (Cellular) UL：826–847 and 824–849 MHz")]
	UL850 = 257,
	[Description("1900 (PCS) DL：1930–1990 MHz")]
	DL1900 = 512,
	[Description("1900 (PCS) UL：1850–1910 MHz")]
	UL1900 = 513,
	[Description("900 (E-GSM) DL：925–960 MHz")]
	DL900 = 1536,
	[Description("900 (E-GSM) UL：880–915 MHz")]
	UL900 = 1537,
	[Description("1800 (DCS) DL：1805–1880 MHz")]
	DL1800 = 1792,
	[Description("1800 (DCS) UL：1710–1785 MHz")]
	UL1800 = 1793,
	[Description("2100 (IMT-2000) DL：2110–2170 MHz")]
	DL2100 = 768,
	[Description("2100 (IMT-2000) UL：1920–1980 MHz")]
	UL2100 = 769,
	[Description("R-GSM 900 DL：921–960 MHz")]
	B2E00 = 11776,
	[Description("R-GSM 900 UL：876–915 MHz")]
	B2E01 = 11777,
	[Description("ER-GSM 900 DL：918–960 MHz")]
	B3500 = 13568,
	[Description("ER-GSM 900 UL：873–915 MHz")]
	B3501 = 13569
}
