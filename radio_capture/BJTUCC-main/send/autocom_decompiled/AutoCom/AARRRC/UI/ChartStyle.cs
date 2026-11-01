using LibUtils;

namespace AARRRC.UI;

public enum ChartStyle
{
	[MyDescription("不输出", "No chart")]
	none,
	[MyDescription("柱状折线图", "Histogram and line")]
	barline,
	[MyDescription("柱状图", "Histogram")]
	bar,
	[MyDescription("PDF/CDF折线图", "PDF/CDF Line")]
	pcdfLine,
	[MyDescription("CDF折线图", "CDF Line")]
	cdfLine,
	[MyDescription("PDF折线图", "PDF Line")]
	pdfLine,
	[MyDescription("饼图", "Pie")]
	pie
}
