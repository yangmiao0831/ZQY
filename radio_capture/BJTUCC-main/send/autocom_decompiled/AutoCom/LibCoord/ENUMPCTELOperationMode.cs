using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELOperationMode
{
	[Description("Stand alone")]
	StandAlone,
	[Description("In band")]
	InBand,
	[Description("Guard band")]
	GuardBand
}
