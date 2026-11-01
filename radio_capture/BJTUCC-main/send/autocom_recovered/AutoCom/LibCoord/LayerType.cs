using LibUtils;

namespace LibCoord;

public enum LayerType
{
	[MyDescription("数据", "Logfile")]
	ltLogfile,
	[MyDescription("参数", "Param")]
	ltParam,
	[MyDescription("事件", "Event")]
	ltEvent,
	[MyDescription("基站", "Site")]
	ltSite,
	[MyDescription("地图", "Map")]
	ltMap,
	[MyDescription("分析项", "Analysis")]
	ltAnalysis,
	[MyDescription("过滤", "Filter")]
	ltFilter,
	[MyDescription("重采样", "Bin")]
	ltBin,
	[MyDescription("地图", "OnlineMap")]
	ltOnlineMap
}
