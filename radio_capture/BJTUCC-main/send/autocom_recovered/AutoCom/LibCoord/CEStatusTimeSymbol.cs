using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum CEStatusTimeSymbol
{
	[MyDescription("无", "None")]
	None,
	[Description(">=")]
	BiggerEqual,
	[Description(">")]
	Bigger
}
