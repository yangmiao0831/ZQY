using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELBandCDMA
{
	[Description("BC0-850 (Cellular) DL：869–894 and 860–894 MHz")]
	B0100 = 256,
	[Description("BC0-850 (Cellular) UL：824–849 and 815–849 MHz")]
	B0101 = 257,
	[Description("BC1-1900 (PCS) DL：1930–1990 MHz")]
	B0200 = 512,
	[Description("BC1-1900 (PCS) UL：1850–1910 MHz")]
	B0201 = 513,
	[Description("BC5-450 DL：420–494 MHz")]
	B2F00 = 12032,
	[Description("BC5-450 UL：410–484 MHz")]
	B2F01 = 12033
}
