using LibUtils;

namespace LibCoord;

public enum ENUMTranscomScanMode
{
	[MyDescription("按频段", "Scan Band")]
	ScanBand = 1,
	[MyDescription("按频点", "Scan Frequency")]
	ScanFreqGroup
}
