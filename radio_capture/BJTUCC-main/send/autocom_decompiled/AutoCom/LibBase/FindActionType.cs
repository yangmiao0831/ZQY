using System.ComponentModel;
using LibUtils;

namespace LibBase;

public enum FindActionType
{
	[Description(">")]
	Greater,
	[Description(">=")]
	GreaterEqual,
	[Description("=")]
	Equal,
	[Description("<")]
	Less,
	[Description("<=")]
	LessEqual,
	[Description("!=")]
	NoEqual,
	[MyDescription("范围('最大值,最小值')", "Range('max, min')")]
	Range
}
