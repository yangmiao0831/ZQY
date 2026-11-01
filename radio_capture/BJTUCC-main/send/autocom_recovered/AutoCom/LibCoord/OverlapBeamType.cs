using System.ComponentModel;

namespace LibCoord;

public enum OverlapBeamType
{
	[Description("serving")]
	BeamServing,
	[Description("best")]
	BeamBest
}
