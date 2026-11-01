using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

[Serializable]
public class AutoTestCmd
{
	[JsonConverter(typeof(StringEnumConverter))]
	public AutoTestCmdEnum CMD;

	public long? Tick;

	public string ReqTime;

	public int? EQIndex;

	public int[] EQIndexList;

	public int[] BandList;

	public object Param;

	[JsonIgnore]
	public IntPtr SocketHandle;

	private static AutoTestCmd Uo1FmIt9KpZosjEgjZ1Q;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoTestCmd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AutoTestCmd()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		Uih21Et9x4MGKsyHAbwe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bvC3XGt9ZI3GIljBpPQQ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AutoTestCmd wsOkh8t9ocO7CPt3amWb()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Uih21Et9x4MGKsyHAbwe()
	{
	}
}
