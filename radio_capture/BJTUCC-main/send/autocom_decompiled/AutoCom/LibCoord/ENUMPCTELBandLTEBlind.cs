using System.ComponentModel;

namespace LibCoord;

public enum ENUMPCTELBandLTEBlind
{
	[Description("Band1（2110-2170）MHz")]
	B1 = 768,
	[Description("Band3（1805-1880）MHz")]
	B3 = 1792,
	[Description("Band5（869-894）MHz")]
	B5 = 256,
	[Description("Band7（2620-2690）MHz")]
	B7 = 4608,
	[Description("Band8（925-960）MHz")]
	B8 = 1536,
	[Description("Band34（2010-2025）MHz")]
	B34 = 9987,
	[Description("Band38（2570-2620）MHz")]
	B38 = 7171,
	[Description("Band39（1880-1920）MHz")]
	B39 = 7939,
	[Description("Band40（2300-2400）MHz")]
	B40 = 7427,
	[Description("Band41（2496-2690）MHz")]
	B41 = 7683,
	[Description("TDD 1.8GHz Proprietary（1785-1805）MHz")]
	TDD3F03 = 16131
}
