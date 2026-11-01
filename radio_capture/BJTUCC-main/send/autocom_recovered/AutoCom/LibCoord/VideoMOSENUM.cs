using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum VideoMOSENUM
{
	[MyDescription("不做VMOS", "No VMOS")]
	none,
	[MyDescription("CTTL VMOS", "CTTL VMOS")]
	CTTLVMOS,
	[Description("MuPQA VMOS")]
	MUPQAVMOS,
	[MyDescription("常规VMOS", "SS VMOS")]
	SSVMOS
}
