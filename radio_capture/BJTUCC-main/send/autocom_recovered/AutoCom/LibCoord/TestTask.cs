using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class TestTask
{
	public string TaskID;

	public string TaskName;

	public bool TaskEnable;

	[JsonConverter(typeof(StringEnumConverter))]
	public TaskType TaskType;

	public List<TestTask> MultiContents;

	[CompilerGenerated]
	private int aUng6f9tZSi;

	[CompilerGenerated]
	private bool dDjg6D0jPWJ;

	[CompilerGenerated]
	private TaskCycleMode qtEg6BSgDgE;

	[CompilerGenerated]
	private double k4Mg6S3lAHf;

	[CompilerGenerated]
	private int g5wg6mdAsYY;

	[CompilerGenerated]
	private int j2kg6IYmauB;

	[CompilerGenerated]
	private object bXUg6QLS2Zy;

	[CompilerGenerated]
	private ServiceFailure ifqg6liH8bY;

	[CompilerGenerated]
	private int IdNg6wvUKTM;

	[CompilerGenerated]
	private int YDng6p5MdHT;

	[CompilerGenerated]
	private ReconnectNetwork C7Jg6aowsSd;

	private static TestTask EV1RVdZ4KuXPohP6rrhN;

	[MyDisplayName("测试次数", "Counts")]
	[Browsable(true)]
	[ReadOnly(false)]
	public int TestTimes
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
	[MyDisplayName("无限循环", "Infinite Cycle")]
	[Browsable(false)]
	public bool InfiniteCycle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("测试方式", "Test Type")]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	public TaskCycleMode CycleMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TaskCycleMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("测试间隔(s)", "Test Interval(s)")]
	public double TestInterval
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[MyDisplayName("业务间间隔(s)", "Task Interval(s)")]
	[ReadOnly(false)]
	public int TaskInterval
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

	[MyDisplayName("周期时长(s)", "Duration(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int CyclePeriod
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

	[MyDisplayName("业务配置", "Task Config")]
	[Browsable(true)]
	[ReadOnly(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public object TestContent
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

	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("测试失败处理", "Task Failure Option")]
	public ServiceFailure ServiceFailure
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ServiceFailure)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("连续失败次数", "Failure Count")]
	public int FailureCount
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
	[MyDisplayName("失败间隔(s)", "Failure Interval(s)")]
	[Browsable(true)]
	public int FailureInterval
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

	[MyDisplayName("网络断开方式", "Network Disconnect Option")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	public ReconnectNetwork ReConnectNetwork
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ReconnectNetwork)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SerialsToObj()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConnectionSetup GetConnectionSetup()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestTask()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		daPBwTZ4eVcrpDgNjiP1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BSqrnuZ4xqIAkwgTX06E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V5oZL1Z4ZoREybE81iam()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TestTask gZ2mQQZ4oJeYYDSf0L6G()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mLIqL0Z4AfdaPAQSb8VV(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PnwuRWZ4thxX2cagk71T(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XORVIGZ4W9pfwFI0kTja(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mpuhTdZ4BdfZaJTPE0sK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X0PoGyZ4qJsH4IcGwHTv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FR4NslZ4EhY5crdmB7jY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RRCliJZ4VPXOMPJqHYvb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P2QNgCZ4TwT6kBL2EPEs(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JTSPp5Z4pPYF0prWCUGE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kn4WepZ4QDJrAsYJWdQ0(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p7oE4AZ4RHgtIgoT9Bvj(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Pqt6lYZ4G12igRTY72Qk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OAGMyLZ43PvAgnVwFrLM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rQVVMrZ4Fh4dABNJoNsr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O3owRyZ47KxyMsPliYD0(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ntJFCMZ4bRoTEXvF9pgS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DSETH7Z4gXEO37elMJfF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XalT52Z4fOfd6YbcO98S(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Io2P07Z4jLR29AJuTmDK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void daPBwTZ4eVcrpDgNjiP1()
	{
	}
}
