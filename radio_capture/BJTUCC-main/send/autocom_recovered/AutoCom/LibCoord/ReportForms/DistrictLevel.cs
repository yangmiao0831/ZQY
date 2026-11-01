using LibUtils;

namespace LibCoord.ReportForms;

public enum DistrictLevel
{
	[MyDescription("", "")]
	None,
	[MyDescription("按省份", "By Province")]
	prov,
	[MyDescription("按城市", "By City")]
	city,
	[MyDescription("按区县", "By District")]
	district
}
