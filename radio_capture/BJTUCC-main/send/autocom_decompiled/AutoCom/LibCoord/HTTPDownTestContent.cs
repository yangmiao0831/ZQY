using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class HTTPDownTestContent
{
	private ConnectionSetup VrDgd4LdeoW;

	[CompilerGenerated]
	private FTPDownloadSchema i2NgdNL0B6H;

	[CompilerGenerated]
	private int nAxgdiKka5Z;

	[CompilerGenerated]
	private int P7WgdFtDNNQ;

	[CompilerGenerated]
	private int Cc3gdbLkO59;

	[CompilerGenerated]
	private int YQQgdVYrhJi;

	[CompilerGenerated]
	private string oeEgdXe17G3;

	[CompilerGenerated]
	private int CP9gd2E2hTo;

	[CompilerGenerated]
	private int FXPgdOQJiRZ;

	[CompilerGenerated]
	private bool h3DgdM5oCI2;

	[CompilerGenerated]
	private DataTestMode Q5ogd5bDBCi;

	[CompilerGenerated]
	private int st3gdTVaqWr;

	private static HTTPDownTestContent w4fq0tZDrTDVjE1CobVw;

	[ReadOnly(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("下载模式", "Download Mode")]
	public FTPDownloadSchema DownloadSchema
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FTPDownloadSchema)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("下载时长(s)", "Duration(s)")]
	public int DownloadTime
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

	[MyDisplayName("测试超时(s)", "Timeout(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int DownloadTimeout
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

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("线程数量", "Thread Count")]
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

	[ReadOnly(false)]
	[MyDisplayName("URL地址", "URL")]
	public string URLAddress
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
	[MyDisplayName("连接超时(s)", "Connect Timeout(s)")]
	public int ConnectTimeout
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

	[Browsable(false)]
	[MyDisplayName("保存路径", "Save Path")]
	[ReadOnly(false)]
	public string SavePath
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
	[Browsable(false)]
	[MyDisplayName("下载最高限速(kbps)", "Rate-Limited(kbps)")]
	public int RateLimited
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

	[MyDisplayName("是否限速下载", "Rate-Limited")]
	[ReadOnly(false)]
	[Browsable(true)]
	public bool LimitSwitch
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

	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("测试模式", "Test type")]
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
	public HTTPDownTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HTTPDownTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		DRUbbTZDaJMUVLrUgkYK();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void COiEoaZDCUa9P58qkVpx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ejfXQSZDnfUUhhUJZD5d(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k6WC2cZDDVws1R4v30lo()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HTTPDownTestContent bp8QD9ZDdxcIerVyjKSq()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DRUbbTZDaJMUVLrUgkYK()
	{
	}
}
