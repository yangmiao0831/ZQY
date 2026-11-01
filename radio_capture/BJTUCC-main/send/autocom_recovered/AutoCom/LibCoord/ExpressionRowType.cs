using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum ExpressionRowType
{
	[MyDescription("参数条件", "Parameter condition")]
	rtParamValue,
	[MyDescription("双参数条件", "Two Parameters condition")]
	rtTwoParamValue,
	[Description("AND")]
	rtAND,
	[Description("OR")]
	rtOR,
	[Description("XOR")]
	rtXOR,
	[Description("NOT")]
	rtNOT
}
