using System.ComponentModel;

namespace LibCoord;

public enum RealTimeOperatorDataType
{
	[Description("DTLog")]
	DTLog,
	[Description("nCTI")]
	nCTI,
	[Description("CU")]
	CU,
	[Description("gesf")]
	gesf,
	[Description("CPF")]
	cpf
}
