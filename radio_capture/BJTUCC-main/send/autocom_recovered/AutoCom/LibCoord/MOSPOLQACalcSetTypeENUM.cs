using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum MOSPOLQACalcSetTypeENUM
{
	[MyDescription("没有算分权限", "No License")]
	NoLicense,
	[MyDescription("POLQA(实时算分)", "POLQA(Real time Calc)")]
	POLQALocal,
	[MyDescription("POLQA(批量算分)", "POLQA(Batch Calc)")]
	POLQACloud,
	[Description("CTTL MOS")]
	CTTLMOS,
	[Description("MuPQA MOS")]
	MUPQA,
	[MyDescription("电信MOS", "ChinaTelecom MOS")]
	CTMOS
}
