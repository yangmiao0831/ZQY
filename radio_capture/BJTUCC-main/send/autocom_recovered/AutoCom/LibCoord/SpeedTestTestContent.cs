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
public class SpeedTestTestContent
{
	private ConnectionSetup hRYgWDx1V9H;

	public string ServerInfo;

	[CompilerGenerated]
	private SpeedtestServerTypeEnum sQRgWBCKx3f;

	[CompilerGenerated]
	private SpeedtestServerSourceEnum dTggWSgrOyF;

	[CompilerGenerated]
	private OneSpeedTestServer Me3gWmodM73;

	[CompilerGenerated]
	private List<string> A09gWITdI71;

	[CompilerGenerated]
	private bool PIDgWQe7kTg;

	[CompilerGenerated]
	private SpeedtestModeEnum GwggWlAQ18d;

	[CompilerGenerated]
	private SpeedTestTimeModeEnum M7LgWwb8KaY;

	[CompilerGenerated]
	private int uWZgWpMhDkb;

	[CompilerGenerated]
	private int yXygWaMhcu5;

	[CompilerGenerated]
	private int Ia7gWkEkvGc;

	[CompilerGenerated]
	private SpeedTestOperatorEnum P5lgW0GhwXW;

	[CompilerGenerated]
	private string daugWZGxlFW;

	[CompilerGenerated]
	private SpeedTestBandwidthModeEnum c9XgWzPMOpf;

	[CompilerGenerated]
	private SpeedTestBandwidthTypeEnum sp8g4CiDiDB;

	[CompilerGenerated]
	private DataTestMode hiag4GXxIN5;

	[CompilerGenerated]
	private int r8Yg4R0ptuv;

	private static SpeedTestTestContent RRXqB6Zdjfn8iBYi9Y6i;

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
	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("服务器类型", "Server Type")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public SpeedtestServerTypeEnum ServerType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SpeedtestServerTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("服务器来源", "Server Source")]
	[TypeConverter(typeof(EnumConverter))]
	public SpeedtestServerSourceEnum ServerSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SpeedtestServerSourceEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Editor(typeof(SpeedTestServerEditor), typeof(UITypeEditor))]
	[MyDisplayName("服务器", "Server")]
	[ReadOnly(false)]
	[Browsable(true)]
	public OneSpeedTestServer ServerCfg
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
	[Editor(typeof(SpeedTestServerListEditor), typeof(UITypeEditor))]
	[MyDisplayName("服务器", "ServerList")]
	[Browsable(true)]
	public List<string> ServerList
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

	[MyDisplayName("服务器设置", "Ping Test")]
	[ReadOnly(false)]
	[Browsable(true)]
	public bool PingEnable
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
	[MyDisplayName("测试方向", "Test type")]
	[TypeConverter(typeof(SpeedtestModeEnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	public SpeedtestModeEnum SpeedtestMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SpeedtestModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("时长方式", "Time Mode")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[ReadOnly(false)]
	public SpeedTestTimeModeEnum TimeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SpeedTestTimeModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("下载时长(s)", "Download Time(s)")]
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

	[Browsable(true)]
	[MyDisplayName("上传时长(s)", "Upload Time(s)")]
	[ReadOnly(false)]
	public int UploadTime
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
	[MyDisplayName("线程数", "Thread Count")]
	public int ThreadCount
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
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("运营商", "Operator")]
	public SpeedTestOperatorEnum Operator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SpeedTestOperatorEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("省份", "Province")]
	public string Province
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
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("带宽模式", "Bandwidth Mode")]
	[JsonConverter(typeof(StringEnumConverter))]
	public SpeedTestBandwidthModeEnum BandwidthMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SpeedTestBandwidthModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("带宽类型", "Bandwidth Type")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	public SpeedTestBandwidthTypeEnum BandwidthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SpeedTestBandwidthTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("测试模式", "Test type")]
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
	public SpeedTestTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpeedTestTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void unkL5gZdPta3jhvr4lgi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mncuBuZdcSHK7ggPP9qy(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool acJdYcZdepHidNjwH2XE()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SpeedTestTestContent BXCVmoZd0nXa699780wb()
	{
		return null;
	}
}
