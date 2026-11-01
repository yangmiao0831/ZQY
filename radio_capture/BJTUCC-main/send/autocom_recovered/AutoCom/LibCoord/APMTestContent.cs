using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class APMTestContent
{
	private ConnectionSetup zMCgNPAN0tf;

	[CompilerGenerated]
	private string ymPgNEO1kcg;

	[CompilerGenerated]
	private int f1bgNyMrsKc;

	[CompilerGenerated]
	private APMDirection vU4gNcpPjCm;

	[CompilerGenerated]
	private int n1XgNLpQLd4;

	[CompilerGenerated]
	private int fGUgNv4lS2E;

	[CompilerGenerated]
	private int pZKgNsGOAyc;

	[CompilerGenerated]
	private APMDebugSwitch sr6gN6VnfmJ;

	[CompilerGenerated]
	private int XFlgNhSO8KT;

	[CompilerGenerated]
	private int MaPgN1qqaQg;

	[CompilerGenerated]
	private int TwcgNdTrBWm;

	[CompilerGenerated]
	private int NmvgNWFqQ6o;

	[CompilerGenerated]
	private DataTestMode xr3gN4aH5pI;

	[CompilerGenerated]
	private int jL4gNNYLLM9;

	internal static APMTestContent TnKFchZCjJ2auPeqmD4T;

	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[ReadOnly(false)]
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

	[ReadOnly(false)]
	[MyDisplayName("服务器地址", "Host")]
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

	[MyDisplayName("服务器端口", "Port")]
	[ReadOnly(false)]
	public int Port
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

	[MyDisplayName("测试方式", "Test Type")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	public APMDirection Direction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (APMDirection)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("测试时长(s)", "Duration(s)")]
	public int TestDuration
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
	[MyDisplayName("采样周期(s)", "Sample Interval(s)")]
	public int SampleDuration
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

	[MyDisplayName("无流量时长(s)", "No Data Timeout(s)")]
	[ReadOnly(false)]
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("发包模式", "Send Mode")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	public APMDebugSwitch DebugSwitch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (APMDebugSwitch)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("发包大小(B)", "Send Packet Size(B)")]
	public int SendPacketSize
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
	[Browsable(true)]
	[MyDisplayName("上行发包比例(%)", "Upload Send Ratio(%)")]
	public int ULSendRatio
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

	[MyDisplayName("下行发包比例(%)", "Download Send Ratio(%)")]
	[Browsable(true)]
	[ReadOnly(false)]
	public int DLSendRatio
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
	[MyDisplayName("TCP窗长(KB)", "TCP Buffer Size(KB)")]
	[Browsable(true)]
	public int TCPBufferSize
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
	[MyDisplayName("测试模式", "Test type")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[Browsable(true)]
	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
	[ReadOnly(false)]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public APMTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static APMTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BKpTmXZCPoc1mv4ZVIQV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eExNQFZCcrGDSaRd9cG4(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DIfWsjZCehBDPwaQ4P4O()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static APMTestContent OT866HZC0JKi1xA1Gutb()
	{
		return null;
	}
}
