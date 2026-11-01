using System.ComponentModel;

namespace LibCoord;

public enum MapSiteCoverLTEServingType
{
	[Description("Serving Cell")]
	ServingCell,
	[Description("Neighbor Cell")]
	NeighborCell,
	[Description("Serving+Neighbor Cell")]
	ServingAndNeighborCell
}
