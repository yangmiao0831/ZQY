using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class EQAtCmd
{
	public int EQId;

	public List<AtCmd> Cmds;

	public int LoopTimes;

	public int LoopInterval;

	[JsonIgnore]
	public bool LoopRunning;

	[JsonIgnore]
	public EQObj CurEQ;

	[JsonIgnore]
	public CancellationTokenSource EQCts;

	[JsonIgnore]
	public List<int> UEIndexList;

	private static EQAtCmd e6bJJhKRPvFGKtRleAYD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EQAtCmd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EQAtCmd()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E5pWeyKRwIRqSUyuUW14()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AZsfF2KRck3V9r7EPcbo()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EQAtCmd N3SKJBKR8EvdWGHeVhqA()
	{
		return null;
	}
}
