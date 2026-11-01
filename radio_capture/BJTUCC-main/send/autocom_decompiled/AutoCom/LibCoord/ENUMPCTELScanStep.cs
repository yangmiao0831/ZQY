using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELScanStep
{
	[Description("5KHz")]
	ScanStep5 = 5,
	[Description("10KHz")]
	ScanStep10 = 10,
	[Description("15KHz")]
	ScanStep15 = 15,
	[Description("20KHz")]
	ScanStep20 = 20,
	[Description("30KHz")]
	ScanStep30 = 30,
	[Description("50KHz")]
	ScanStep50 = 50,
	[Description("100KHz")]
	ScanStep100 = 100,
	[Description("200KHz")]
	ScanStep200 = 200,
	[Description("300KHz")]
	ScanStep300 = 300
}
