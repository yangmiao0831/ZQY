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
public class HTTPTestContent
{
	private ConnectionSetup iFJgdRFBHVe;

	[CompilerGenerated]
	private HTTPModeEnum VCigdnChwDa;

	[CompilerGenerated]
	private string JDTgdgL6Bcn;

	[CompilerGenerated]
	private HTTPWebAddressList<HTTPWebAddress> fOFgdeMmTYs;

	[CompilerGenerated]
	private HTTPRandomAddressList<HTTPRandomAddress> LIrgdPSfW2T;

	[CompilerGenerated]
	private int B9PgdExVNwc;

	[CompilerGenerated]
	private int fqtgdytd19j;

	[CompilerGenerated]
	private int Kgagdc94jys;

	[CompilerGenerated]
	private int oojgdLsXdFj;

	[CompilerGenerated]
	private int DwNgdvO1s8f;

	[CompilerGenerated]
	private BrowserTypeEnum XbLgdsvbk4K;

	[CompilerGenerated]
	private HTTPUATypeEnum p2Igd6MPd4X;

	[CompilerGenerated]
	private int S3TgdhniUY8;

	[CompilerGenerated]
	private bool bgfgd1J4ZoJ;

	[CompilerGenerated]
	private DataTestMode yGxgddvBOnF;

	[CompilerGenerated]
	private int WyLgdWqvlvr;

	internal static HTTPTestContent l0OU6uZDcPbtlvfn1VDG;

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
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(false)]
	[MyDisplayName("测试方式", "Test Type")]
	public HTTPModeEnum HTTPMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HTTPModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("网页地址", "URL")]
	[ReadOnly(false)]
	[Browsable(false)]
	public string WebAddress
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

	[Editor(typeof(HTTPWebAddressEditor), typeof(UITypeEditor))]
	[MyDisplayName("Web网址列表", "Web Address List")]
	[ReadOnly(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public HTTPWebAddressList<HTTPWebAddress> WebAddressList
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
	[Browsable(false)]
	public HTTPRandomAddressList<HTTPRandomAddress> RandomAddressList
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

	[MyDisplayName("接入超时(s)", "Connection Timeout(s)")]
	[ReadOnly(false)]
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

	[MyDisplayName("主资源加载时长(s)", "MainResource Load Timeout(s)")]
	[ReadOnly(false)]
	public int MainResourceTimeout
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

	[MyDisplayName("网页总加载时长(s)", "Total Load Timeout(s)")]
	[ReadOnly(false)]
	public int TotalPageTimeout
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

	[MyDisplayName("线程数量", "Thread Count")]
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

	[MyDisplayName("浏览器类型", "Browser Type")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	public BrowserTypeEnum BrowserType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BrowserTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("浏览器标识", "UA Type")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	public HTTPUATypeEnum UAType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HTTPUATypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("浏览间隔(s)", "Refresh Interval(s)")]
	[ReadOnly(false)]
	public int RefreshInterval
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

	[MyDisplayName("显示网页", "Show Content")]
	[ReadOnly(false)]
	public bool ShowBrowser
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

	[MyDisplayName("保存路径", "Save Path")]
	[Browsable(false)]
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

	[MyDisplayName("测试模式", "Test type")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
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
	public HTTPTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HTTPTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		vxSitRZD4fWlmrCPIJ8f();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UIGNwAZDh5w3mrNawypu(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ff3ahaZD8Mnt5flUNRdO()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HTTPTestContent sKZSB6ZDwUkq0S72ir6y()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vxSitRZD4fWlmrCPIJ8f()
	{
	}
}
