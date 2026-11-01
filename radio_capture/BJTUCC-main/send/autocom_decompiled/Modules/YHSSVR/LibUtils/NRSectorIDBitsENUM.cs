using System.ComponentModel;

namespace LibUtils;

public enum NRSectorIDBitsENUM
{
	[Description("eNodeBID(24bit)_CellID(12bit)")]
	SectorID12 = 12,
	[Description("eNodeBID(22bit)_CellID(14bit)")]
	SectorID14 = 14
}
