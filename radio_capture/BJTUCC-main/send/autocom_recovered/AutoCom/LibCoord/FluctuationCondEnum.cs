using System.ComponentModel;

namespace LibCoord;

public enum FluctuationCondEnum
{
	[Description("<")]
	Small,
	[Description("<=")]
	SmallEqual,
	[Description(">=")]
	BiggerEqual,
	[Description(">")]
	Bigger
}
