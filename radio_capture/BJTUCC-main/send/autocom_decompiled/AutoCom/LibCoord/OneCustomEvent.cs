using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class OneCustomEvent
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

	private static OneCustomEvent oWrP9bK5dnBnIug1DR0o;

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
	public OneCustomEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OneCustomEvent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		HOKJpOK5kVcfWECEn74m();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T9rZG5K5amRZHL9SWKXs(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tagqZBK5CbW8lW5sBK4E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OneCustomEvent MxfAKvK5n1bWB7r0eKLG()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NfVdVXK5Hp1EC2YLReBh(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pG2JXoK5stGn4Z7RMWK1(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S8pqIjK5lqWs9ewgxa0v(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CWDjCdK59WyAbFrbuT6B()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HOKJpOK5kVcfWECEn74m()
	{
	}
}
