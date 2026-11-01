using System.ComponentModel;

namespace LibCoord;

public enum MapSiteCoverNRBeamServingType
{
	[Description("Serving Beam")]
	ServingBeam,
	[Description("Serving Cell")]
	ServingCell,
	[Description("Neighbor Cell")]
	NeighborCell,
	[Description("Serving+Neighbor Cell")]
	ServingAndNeighborCell
}
