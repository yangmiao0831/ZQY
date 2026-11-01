using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELBandWCDMA
{
	[Description("B5-850 (Cellular) DL：871–892 and 869–894 MHz")]
	B0100 = 256,
	[Description("B5-850 (Cellular) UL：826–847 and 824–849 MHz")]
	B0101 = 257,
	[Description("B2-1900 (PCS) DL：1932–1988 and 1930–1990 MHz")]
	B0200 = 512,
	[Description("B2-1900 (PCS) UL：1852–1908 and 1850–1910 MHz")]
	B0201 = 513,
	[Description("B1-2100 (IMT-2000) DL：2112–2168 and 2110–2170 MHz")]
	B0300 = 768,
	[Description("B1-2100 (IMT-2000) UL：1922–1978 and 1920–1980 MHz")]
	B0301 = 769,
	[Description("B8-900 DL：927–958 and 925–960 MHz")]
	B0600 = 1536,
	[Description("B8-900 UL：882–913 and 880–915 MHz")]
	B0601 = 1537,
	[Description("B3-1800 (DCS) DL：1807–1878 and 1805–1880 MHz")]
	B0700 = 1792,
	[Description("B3-1800 (DCS) UL：1712–1783 and 1710–1785 MHz")]
	B0701 = 1793
}
