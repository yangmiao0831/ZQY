using LibUtils;

namespace LibCoord;

public enum DonaTopNScanMode
{
	[MyDescription("盲扫模式", "Scan band")]
	BlindScan = 1,
	[MyDescription("频段扫描", "Scan band")]
	ScanBand,
	[MyDescription("频率扫描", "Scan frequency")]
	ScanFrequency
}
