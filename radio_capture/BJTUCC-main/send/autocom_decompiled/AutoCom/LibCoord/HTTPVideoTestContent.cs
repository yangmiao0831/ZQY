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
public class HTTPVideoTestContent
{
	private ConnectionSetup uqNgNiM3JDr;

	[CompilerGenerated]
	private HVURLType oYDgNF8YqIF;

	[CompilerGenerated]
	private VideoAPPType ttHgNbOptdu;

	[CompilerGenerated]
	private string n2XgNVhZ9Yn;

	[CompilerGenerated]
	private string pK7gNXJ7R1X;

	[CompilerGenerated]
	private HVResolution SJlgN2FdFcf;

	[CompilerGenerated]
	private HVPlaySchema T56gNO92aMj;

	[CompilerGenerated]
	private int ItZgNMnD0R1;

	[CompilerGenerated]
	private VMOSENUM gGpgN5ADGxe;

	[CompilerGenerated]
	private int SeygNTkWmMY;

	[CompilerGenerated]
	private int P1agNxniXb3;

	[CompilerGenerated]
	private int JOOgNqLByAx;

	[CompilerGenerated]
	private int tbBgNA3dudT;

	[CompilerGenerated]
	private int rkrgNYGITo0;

	[CompilerGenerated]
	private int D9DgNHXULq3;

	[CompilerGenerated]
	private int DAjgN3gMwxP;

	[CompilerGenerated]
	private DataTestMode hnwgNJ9ZJ9x;

	[CompilerGenerated]
	private int nrlgNrBNiUO;

	internal static HTTPVideoTestContent XQmcCbZC8Kl8Y2ajGsX5;

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

	[MyDisplayName("地址类型", "URL Type")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	public HVURLType URLType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HVURLType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("视频APP", "Video APP")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public VideoAPPType VideoAPP
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VideoAPPType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("视频关键字", "Video Keyword")]
	[Browsable(true)]
	[ReadOnly(false)]
	public string VideoKeyword
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

	[Editor(typeof(HTTPVideoURLHistoryEditor), typeof(UITypeEditor))]
	[Browsable(true)]
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

	[MyDisplayName("分辨率", "Resolution")]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	public HVResolution Resolution
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HVResolution)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("播放模式", "Play Schema")]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
	public HVPlaySchema PlaySchema
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HVPlaySchema)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("播放时长(s)", "Play Duration(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int PlayDuration
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
	[MyDisplayName("VMOS", "VMOS")]
	[Browsable(false)]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	public VMOSENUM VMOS
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VMOSENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("播放超时(s)", "Play Timeout(s)")]
	public int PlayTimeout
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
	[MyDisplayName("连接超时(s)", "Connect Timeout(s)")]
	[Browsable(true)]
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

	[MyDisplayName("初始缓冲门限(s)", "Init Buffer Threshold(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int InitBufferThreshold
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
	[MyDisplayName("播放缓冲门限(s)", "Play Buffer Threshold(s)")]
	[Browsable(true)]
	public int PlayBufferThreshold
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
	[MyDisplayName("单次缓冲超时(s)", "NoFlow Timeout(s)")]
	public int BufferTimeout
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
	[MyDisplayName("总缓冲超时(s)", "Total Buffer Timeout(s)")]
	public int TotalBufferTimeout
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
	[MyDisplayName("最大缓冲次数", "Max Buffer Count")]
	[ReadOnly(false)]
	public int MaxBufferCount
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
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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
	[Browsable(true)]
	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
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
	public HTTPVideoTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HTTPVideoTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		VZ5pWWZCrD3VdJXGLN6c();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void esg8GeZC4QONBmbLHyLC(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OHgyosZCwadg2Ct6MK8p()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HTTPVideoTestContent Gvt5j1ZChgX0Dh3nb6wl()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VZ5pWWZCrD3VdJXGLN6c()
	{
	}
}
