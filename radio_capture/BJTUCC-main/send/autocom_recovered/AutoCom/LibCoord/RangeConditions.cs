using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class RangeConditions
{
	[JsonConverter(typeof(StringEnumConverter))]
	public RangeType ConditionType;

	public string Condition;

	public string DelaySymbol;

	public int Delay;

	public int BackwardOffset;

	public int ForwardOffset;

	public OffSetType StartOffsetType;

	public int StartOffsetValue;

	public OffSetType EndOffsetType;

	public int EndOffsetValue;

	public int ConditionCode;

	public ExpressionRow ConditionRow;

	public string ConditionStr;

	public string StartCondition;

	public string EndCondition;

	public int StartConditionCode;

	public ExpressionRow StartConditionRow;

	public int EndConditionCode;

	public ExpressionRow EndConditionRow;

	public int Duration;

	public int Count;

	internal static RangeConditions HdrJkWKzUQsyyW8GPo0i;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetConditionShowStr(string Condition, int ConditionCode, ExpressionRow ConditionRow)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RangeCondition ParseCondition(string sCondition)
	{
		return (RangeCondition)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RangeConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RangeConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		VOSetpZLyDvHUk7wWZOD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nWVxobKziJ9JWpRbbs2O(int P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hLNj2KKzzKlpVdg0vQ6n(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int n8bhr5ZLLK8sjlJyDpId(object P_0, object P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object segSDvZLN8LZfVP3pwFG(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VWYTpuKzOViw04HZbMyU()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RangeConditions FMOIAYKz5Ct95FNxFPAB()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iHZsxoZLYuw90L4N32I3(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EZ6ad6ZLuvulvYu40dUV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VOSetpZLyDvHUk7wWZOD()
	{
	}
}
