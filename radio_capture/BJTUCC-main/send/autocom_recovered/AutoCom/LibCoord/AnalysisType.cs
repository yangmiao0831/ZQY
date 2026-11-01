using LibUtils;

namespace LibCoord;

public enum AnalysisType
{
	[MyDescription("无主服务小区分析", "Non-serving cell Analysis")]
	NoServingCell = 0,
	[MyDescription("有效小区分析", "Effective Cell Analysis")]
	ValidCell = 1,
	[MyDescription("越区覆盖分析", "Overlay Analysis")]
	Overlay = 2,
	[MyDescription("超远覆盖分析", "TooFar Analysis")]
	TooFar = 3,
	[MyDescription("超角度覆盖分析", "OverAngle Analysis")]
	OverAngle = 4,
	[MyDescription("天馈接反分析", "Antenna Reverse Analysis")]
	AntennaReverse = 5,
	[MyDescription("覆盖率分析", "Coverage Ratio Analysis")]
	CoverageRatio = 6,
	[MyDescription("重叠覆盖分析", "Overlap Analysis")]
	Overlap = 7,
	[MyDescription("导频污染分析", "Pilot Pollution Analysis")]
	PilotPollution = 8,
	[MyDescription("弱覆盖分析", "Poor Coverage Analysis")]
	PoorCoverage = 9,
	[MyDescription("室分泄漏", "Indoor Leakage")]
	IndoorLeakage = 10,
	[MyDescription("干扰分析", "Interference Analysis")]
	Interference = 11,
	[MyDescription("渗透率分析", "Road Penetration Analysis")]
	Penetration = 12,
	[MyDescription("ModX分析", "ModX Analysis")]
	Mod3 = 13,
	[MyDescription("优化前后分析", "Difference Analysis")]
	Difference = 14,
	[MyDescription("分组数据对比", "Data Compare by Group")]
	Compare = 15,
	[MyDescription("竞对专项分析", "Analysis after competitor")]
	CompetitorCompare = 16,
	[MyDescription("参数四象限分析", "Param Quadrant Analysis")]
	ParamQuadrant = 17,
	[MyDescription("小区配置参数分析", "Cell Param Analysis")]
	CellParam = 18,
	[MyDescription("小区测量和统计分析", "Cell Measure and Stat Analysis")]
	CellMeasureAndStat = 19,
	[MyDescription("时延分析", "Delay Analysis")]
	Delay = 20,
	[MyDescription("5G-4G互操作分析", "Interop 5G-4G Analysis")]
	Interop = 21,
	[MyDescription("综合数据分析", "Event Session Analysis")]
	EventSession = 22,
	[MyDescription("切换分析", "Handover Analysis")]
	Handover = 23,
	[MyDescription("共建共享专题分析", "Build Shared Analysis")]
	BuildShared = 24,
	[MyDescription("智能分析", "Intelligent Analysis")]
	Intelligent = 25,
	[MyDescription("基站距离分析", "Site Distance Analysis")]
	SiteDistance = 26,
	[MyDescription("邻区漏配分析", "Leakage Cell by Scanner Analysis")]
	LeakageCellByScan = 27,
	[MyDescription("邻区分析", "Scanner Neighbor Analysis")]
	ScanNeighbor = 28,
	[MyDescription("扰码分析", "Scrambling Code Analysis")]
	Scrambling = 29,
	[MyDescription("自定义分析", "Custom Analysis")]
	Custom = 30,
	[MyDescription("SA/NSA双模站点分析", "SA/NSA Dual Mode Analysis")]
	DualMode = 31,
	[MyDescription("扫频仪差值分析", "Scanner RSRP Diff Analysis")]
	ScanRSRPDiff = 100,
	[MyDescription("扫频仪差值分析", "Scanner SINR Diff Analysis")]
	ScanSINRDiff = 101,
	[MyDescription("扫频仪重叠覆盖度分析", "Scanner Overlap Analysis")]
	ScanOverlap = 102,
	[MyDescription("扫频仪PCI排名分析", "Scanner PCI Order Analysis")]
	ScanPCISort = 103,
	[MyDescription("扫频仪导频污染分析", "Scanner Pilot pollution Analysis")]
	ScanPilotPollution = 104,
	[MyDescription("扫频仪清频分析", "Scanner Frequency Clear Analysis")]
	ScanFrequencyClear = 105,
	[MyDescription("扫频仪LTE退频分析", "Scanner LTE Off Frequency Analysis")]
	ScanOffFrequency = 106,
	[MyDescription("TopN小区分析", "TopN Cell Analysis")]
	TopNCell = 107
}
