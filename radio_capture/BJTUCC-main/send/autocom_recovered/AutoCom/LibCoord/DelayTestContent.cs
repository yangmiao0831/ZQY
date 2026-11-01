using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class DelayTestContent
{
	public const int CICommandCount = 1;

	private ConnectionSetup XBBgdxk1pYD;

	[CompilerGenerated]
	private List<DelayServer> ihZgdqq5lfj;

	[CompilerGenerated]
	private int IM3gdAjKiu3;

	[CompilerGenerated]
	private int J56gdYtV7EB;

	[CompilerGenerated]
	private DataTestMode PDngdHehRFs;

	private static DelayTestContent IcTdlvZD1PC4MNSFfvbX;

	[ReadOnly(false)]
	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public ConnectionSetup ConnectionSetup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MyDisplayName("服务器设置", "ServerList")]
	[Editor(typeof(DelayServerEditor), typeof(UITypeEditor))]
	[ReadOnly(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public List<DelayServer> ServerList
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

	[Browsable(true)]
	[MyDisplayName("测试时长(s)", "TestTime(s)")]
	[ReadOnly(false)]
	public int TestTime
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

	[MyDisplayName("无流量超时(s)", "NoFlowTimeout(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int NoFlowTimeout
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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("测试模式", "Test type")]
	[Browsable(true)]
	[ReadOnly(false)]
	public DataTestMode TestMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DataTestMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DelayTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DelayTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		sR7NltZDX0bBEOYIRKCx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hLdGKGZDmapFgaRH2SJO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M3gDKPZDIhgkIdbmewRc(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fYR0aKZDvs9FmBbMeCsa()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DelayTestContent dMgJgpZDSh9yPlTS4OXZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sR7NltZDX0bBEOYIRKCx()
	{
	}
}
