using LibUtils;

namespace LibCoord.ReportForms;

public enum ReportGroupDimensionEnmu
{
	[MyDescription("", "")]
	None,
	[MyDescription("CQT场景", "CQT Scene")]
	CQT,
	[MyDescription("按区域", "By Region")]
	Region,
	[MyDescription("省市区", "By District")]
	District
}
