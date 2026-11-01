using LibUtils;

namespace LibCoord;

public enum OverlapScanNeighborDataType
{
	[MyDescription("UE数据", "UE Data")]
	UEData,
	[MyDescription("UE数据+扫频仪", "UE Data And Scanner")]
	ScannerAndUEData,
	[MyDescription("扫频仪+基站", "Scanner And Site")]
	ScannerAndSiteData,
	[MyDescription("UE数据+基站", "UE And Site")]
	UEAndSiteData
}
