using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class DouYinTestContent
{
	private ConnectionSetup am9gikgH3R8;

	[CompilerGenerated]
	private ShortVideoAPPTypeEnum WXSgi05Y2ZX;

	[CompilerGenerated]
	private bool JRsgiZ2vpgd;

	[CompilerGenerated]
	private int HYdgizLCUWu;

	[CompilerGenerated]
	private int chDgFC2OyRd;

	[CompilerGenerated]
	private int jUPgFG3fVdF;

	[CompilerGenerated]
	private VideoSlideModeEnum B1LgFRCbi3P;

	[CompilerGenerated]
	private bool AvcgFncvRBv;

	[CompilerGenerated]
	private int ogBgFgpp2ou;

	[CompilerGenerated]
	private int Yg8gFeZmmXm;

	[CompilerGenerated]
	private int jHegFPUpUiH;

	[CompilerGenerated]
	private int MyDgFER5TOt;

	[CompilerGenerated]
	private int NVagFyfp8Rh;

	[CompilerGenerated]
	private int nA0gFchwkE2;

	[CompilerGenerated]
	private DataTestMode zvrgFLmhIip;

	internal static DouYinTestContent rNJKN1ZnZTwE5RrIQgZU;

	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[ReadOnly(false)]
	[Browsable(true)]
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
	[MyDisplayName("APP类型", "APP Type")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public ShortVideoAPPTypeEnum APPType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ShortVideoAPPTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[ReadOnly(false)]
	[MyDisplayName("刷新同城视频列表", "Refresh City video list")]
	public bool RefreshLocalVideoList
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

	[MyDisplayName("列表刷新次数", "List refresh times")]
	[Browsable(true)]
	[ReadOnly(false)]
	public int ListRefreshCount
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
	[MyDisplayName("列表刷新间隔(s)", "List refresh interval(s)")]
	public int ListRefreshInterval
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

	[MyDisplayName("列表刷新超时(s)", "List refresh timeout(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int ListRefreshTimeout
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

	[MyDisplayName("视频切换模式", "Video switching mode")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	public VideoSlideModeEnum VideoSlideMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VideoSlideModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("刷新推荐视频", "Refresh recommended videos")]
	[ReadOnly(false)]
	[Browsable(true)]
	public bool RefreshRecommendVideo
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
	[ReadOnly(false)]
	[MyDisplayName("视频刷新次数", "Video refresh times")]
	public int VideoRefreshCount
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
	[MyDisplayName("视频播放时长(s)", "Video play timel(s)")]
	public int VideoPlayTime
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
	[MyDisplayName("视频刷新间隔(s)", "Video refresh interval(s)")]
	public int VideoRefreshInterval
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
	[MyDisplayName("视频刷新超时(s)", "Video refresh timeout(s)")]
	public int VideoRefreshTimeout
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
	[MyDisplayName("单次缓冲超时(s)", "Single buffer timeout(s)")]
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
	[MyDisplayName("最大缓冲次数", "Maximum buffer times")]
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

	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("测试模式", "Test Mode")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
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
	public DouYinTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DouYinTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KGmbibZno4r59e21nQjY()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DouYinTestContent n0FemkZnxtiBZW3bWOna()
	{
		return null;
	}
}
