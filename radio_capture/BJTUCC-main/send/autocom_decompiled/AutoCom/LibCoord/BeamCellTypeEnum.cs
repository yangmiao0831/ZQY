using System.ComponentModel;

namespace LibCoord;

public enum BeamCellTypeEnum
{
	[Description("PCell")]
	PCell = 0,
	[Description("SCell")]
	SCell = 1,
	[Description("Neighbor Cell")]
	Neighbor = 2,
	[Description("Listed Cell")]
	Listed = 3,
	[Description("Detected Cell")]
	Detected = 4,
	[Description("All Cells")]
	All = 100
}
