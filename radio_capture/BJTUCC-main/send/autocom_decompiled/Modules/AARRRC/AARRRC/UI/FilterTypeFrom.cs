namespace AARRRC.UI;

public enum FilterTypeFrom
{
	[MyDescription("显示全部指标", "Display all indicators")]
	ftfFromAll,
	[MyDescription("仅显示报表中指标", "Show only in report")]
	ftfFromReport,
	[MyDescription("仅显示指标库中指标", "Show only in module")]
	ftfFromModule
}
