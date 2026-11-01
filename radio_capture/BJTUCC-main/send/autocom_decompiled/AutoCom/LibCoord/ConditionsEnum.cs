using System.ComponentModel;

namespace LibCoord;

public enum ConditionsEnum
{
	[Description("<")]
	Small,
	[Description("<=")]
	SmallEqual,
	[Description("=")]
	Equal,
	[Description(">=")]
	BigEqual,
	[Description(">")]
	Big,
	[Description("!=")]
	NotEqual
}
