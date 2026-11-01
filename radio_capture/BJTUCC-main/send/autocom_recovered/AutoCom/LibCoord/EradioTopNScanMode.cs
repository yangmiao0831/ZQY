using LibUtils;

namespace LibCoord;

public enum EradioTopNScanMode
{
	[MyDescription("全频段扫描", "Scan band")]
	ScanBand,
	[MyDescription("指定频率扫描", "Scan frequency")]
	ScanFrequency
}
