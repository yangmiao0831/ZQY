using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class IPerfTestContent
{
	private ConnectionSetup YrxgW5ujwTu;

	[CompilerGenerated]
	private IperfProtocol SFCgWTPHAdA;

	[CompilerGenerated]
	private IperfProtocolVer ygSgWxhWNgI;

	[CompilerGenerated]
	private IperfTestType YSdgWqSrTG9;

	[CompilerGenerated]
	private string TOygWAPpN0j;

	[CompilerGenerated]
	private int uFRgWYVJ0nh;

	[CompilerGenerated]
	private int RcHgWHGO1Te;

	[CompilerGenerated]
	private int SwEgW36X5XD;

	[CompilerGenerated]
	private int niGgWJJZwTj;

	[CompilerGenerated]
	private int ViIgWrFh6HD;

	[CompilerGenerated]
	private int qWlgW9XtssZ;

	[CompilerGenerated]
	private int C9XgW88TFpa;

	[CompilerGenerated]
	private int vQxgWUujyeJ;

	[CompilerGenerated]
	private int zKrgWK5AcIs;

	[CompilerGenerated]
	private int soXgWtcKCOH;

	[CompilerGenerated]
	private bool PEjgWulyD6D;

	[CompilerGenerated]
	private bool FlVgWo7Y1MP;

	[CompilerGenerated]
	private int Fq7gWjLbmsO;

	[CompilerGenerated]
	private DataTestMode lFAgW7lvx6Y;

	[CompilerGenerated]
	private int CqfgWfcnJyI;

	private static IPerfTestContent llMRYBZd78yTHuGIO5md;

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

	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("协议类型", "Protocol")]
	[JsonConverter(typeof(StringEnumConverter))]
	public IperfProtocol Protocol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IperfProtocol)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("协议版本", "Protocol Version")]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(false)]
	public IperfProtocolVer ProtocolVer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IperfProtocolVer)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("测试类型", "Test Type")]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	public IperfTestType TestType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IperfTestType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Editor(typeof(IPerfIPHistoryEditor), typeof(UITypeEditor))]
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

	[ReadOnly(false)]
	[MyDisplayName("测试时长(s)", "Duration(s)")]
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

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("带宽(kbps)", "UDP Bandwidth(kbps)")]
	public int UDPBandwidth
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

	[MyDisplayName("缓冲区大小(KB)", "UDP Buffer Size(KB)")]
	[Browsable(true)]
	[ReadOnly(false)]
	public int UDPBufferSize
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

	[MyDisplayName("发包大小(Byte)", "UDP Send Packet size(Byte)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int UDPPacketSize
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

	[MyDisplayName("线程数量", "Thread Counts")]
	[ReadOnly(false)]
	public int Thread
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

	[MyDisplayName("TCP缓冲区总大小(KB)", "TCP Windows Size(KB)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int TCPWindowsSize
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

	[MyDisplayName("TCP缓冲区读写大小(KB)", "TCP Buffer Size(KB)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int TCPBufferLength
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
	[MyDisplayName("TCP最高限速(kbps)", "TCP Limited Rate(kbps)")]
	public int TCPLimitedRate
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

	[MyDisplayName("TCP最大分段(Byte)", "TCP Max Segment Size(Byte)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int MaxSegmentSize
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

	[DisplayName("TCP No Delay")]
	[ReadOnly(false)]
	[Browsable(true)]
	public bool TCPNoDelay
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

	[Browsable(false)]
	[DisplayName("IPv6")]
	[ReadOnly(false)]
	public bool IPV6
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

	[MyDisplayName("测试模式", "Test type")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IPerfTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IPerfTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FiiEx2ZdfpQ0mpEA5Mil()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xNwo5cZdbB4uMqXsVajw()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IPerfTestContent dUYfM0ZdgdAl6vUVKq2t()
	{
		return null;
	}
}
