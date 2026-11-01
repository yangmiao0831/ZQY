using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class AttachTestContent
{
	[CompilerGenerated]
	private int ABpg4n2q8wa;

	[CompilerGenerated]
	private int VVqg4g2IArr;

	[CompilerGenerated]
	private ENUMCMDType GuVg4eAO74i;

	[CompilerGenerated]
	private AttachAdvance Lkog4PGxmbh;

	private static AttachTestContent FRURgnZd8r2HCJ3byLPH;

	[ReadOnly(false)]
	[MyDisplayName("Attach保持时长(s)", "Attach Hold Time(s)")]
	public int HoldTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("测试间隔(s)", "Interval(s)")]
	public int DetachInterval
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("指令类型", "Command type")]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	public ENUMCMDType CMDType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMCMDType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	[MyDisplayName("高级", "Advance")]
	[ReadOnly(false)]
	[Browsable(true)]
	public AttachAdvance AttachAdvance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	public int AttachTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Browsable(false)]
	public int DetachTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AttachTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttachTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		T4Dv60ZddKrT6k0IrKSd();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IEFT3BZdwsTb3UIhk3kF()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AttachTestContent TUoN7OZdhSWBeUSY8gsV()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int L2g5CrZd49hNfR1gbvNw(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ymuAuvZdrK7UZ01U0C3h(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oi3UX5ZdDZ1hQUC2nqUE(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T4Dv60ZddKrT6k0IrKSd()
	{
	}
}
