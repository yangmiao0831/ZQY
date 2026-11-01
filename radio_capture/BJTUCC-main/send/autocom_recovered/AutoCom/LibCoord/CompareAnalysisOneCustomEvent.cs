using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class CompareAnalysisOneCustomEvent
{
	[JsonConverter(typeof(StringEnumConverter))]
	public CustomEventType Type;

	public int EventID;

	public int ParamID;

	public string Name;

	public object Conditions;

	[JsonIgnore]
	public int PrePointIdx;

	[JsonIgnore]
	public int FirstPointIdx;

	[JsonIgnore]
	public long FirstTime;

	[JsonIgnore]
	public long PreFirstTime;

	[JsonIgnore]
	public long ChangeTime;

	[JsonIgnore]
	public int PreEventIdx;

	[JsonIgnore]
	public int PreItemIdx;

	[JsonIgnore]
	public int PreAppearCount;

	[JsonIgnore]
	public double PreValue;

	[JsonIgnore]
	public List<OneCustomEventPingPangHO> PingPangHOList;

	internal static CompareAnalysisOneCustomEvent hRy3n7tz8VSrTPQ2Pwsi;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTypeString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateToIERes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UseSuccEventName()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEventNameSucc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasFailEvent()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetFailEventID()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFailEventName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetFailEventID(int eventID)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OneCustomEvent Clone()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompareAnalysisOneCustomEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CompareAnalysisOneCustomEvent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Il8uRitz4JFVjmIFYmN6(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HPS6GotzrriuIArNWoOG(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BpyZIDtzDevAvN0403Sw(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jWRBbNtzwjegWZaZSkos()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompareAnalysisOneCustomEvent AXiu8ptzhdYveqRrBaPg()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cHw4CEtzdphQcuLrOYaG(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bBSnHGtzC55gnxAvaeEb(object P_0)
	{
		return true;
	}
}
