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
public class PingTestContent
{
	public const int CICommandCount = 1;

	private ConnectionSetup fYogWNK6naf;

	[CompilerGenerated]
	private string Fu9gWi0ysh7;

	[CompilerGenerated]
	private int D7PgWFc0NfZ;

	[CompilerGenerated]
	private int GI1gWbpsbnn;

	[CompilerGenerated]
	private int c3pgWVd7T3p;

	[CompilerGenerated]
	private int sYlgWXcQOlC;

	[CompilerGenerated]
	private PingTestMode WmFgW2WGc1b;

	[CompilerGenerated]
	private int o7IgWOO13pY;

	[CompilerGenerated]
	private List<RetestPingAddress> EcFgWMaEr0k;

	internal static PingTestContent eN90V8ZdpfGnVexLQOU2;

	[TypeConverter(typeof(ExpandableObjectConverter))]
	[ReadOnly(false)]
	[MyDisplayName("网络连接配置", "Network Connection Config")]
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

	[ReadOnly(false)]
	[Editor(typeof(PingIPHistoryEditor), typeof(UITypeEditor))]
	[MyDisplayName("测试地址", "Host")]
	public string Address
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

	[ReadOnly(false)]
	[MyDisplayName("包大小(Byte)", "Packet size")]
	public int PacketSize_B
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

	[MyDisplayName("探测超时(s)", "Timeout(s)")]
	[ReadOnly(false)]
	public int MaxResponseTime
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

	[DisplayName("TTL")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int TTL
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

	[MyDisplayName("命令数量", "Command Count")]
	[Browsable(false)]
	[ReadOnly(false)]
	public int CommandCount
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
	[ReadOnly(false)]
	[Browsable(true)]
	public PingTestMode TestMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (PingTestMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
	[Browsable(true)]
	public int PauseHysteresis
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

	[Editor(typeof(RetestAddressEditor), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[ReadOnly(false)]
	[MyDisplayName("重测备选地址", "Retest backup address")]
	[Browsable(true)]
	public List<RetestPingAddress> RetestPingList
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PingTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PingTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		o8LJnsZdF7QLpbTAMwDO();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XQgS3BZdGG8MBvj1t4Py()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void erLVAwZd3NGDO4WmVnUF(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v0iy84ZdQqW1u2Kee3pL()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PingTestContent odv3ROZdRMJPrYi9GLo9()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o8LJnsZdF7QLpbTAMwDO()
	{
	}
}
