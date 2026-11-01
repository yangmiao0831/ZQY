using LibUtils;

namespace LibCoord;

public enum ENUMPCTELScanMode
{
	[MyDescription("扫描频段(全频点)", "Scan Band(All Frequency)")]
	ScanBand = 1,
	[MyDescription("扫描频点组", "Scan Frequency Group")]
	ScanFreqGroup,
	[MyDescription("连续频点扫描", "Continuous Frequency Scan")]
	ScanContinuousFreq,
	[MyDescription("分频点扫描", "Division Frequency Scan")]
	ScanDivisionFreq
}
