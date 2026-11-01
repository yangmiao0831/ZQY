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
public class WeChatCallTestContent
{
	private ConnectionSetup wRIgFUlwcv3;

	public string MOSSamplePath;

	[CompilerGenerated]
	private CallTypeENUM GDrgFKfUJVi;

	[CompilerGenerated]
	private int pECgFtVQVuO;

	[CompilerGenerated]
	private CallUEENUM us6gFumrMvM;

	[CompilerGenerated]
	private string PL1gFoLPjmd;

	[CompilerGenerated]
	private string Dn5gFj6rS1h;

	[CompilerGenerated]
	private int KOdgF7P8dYf;

	[CompilerGenerated]
	private int LHUgFfr1ZBP;

	[CompilerGenerated]
	private MOSENUM VgIgFDxIl8d;

	[CompilerGenerated]
	private VideoMOSENUM tpPgFB2nmnF;

	[CompilerGenerated]
	private MOSCalcEnvironmentEnum jtUgFSn0gwh;

	[CompilerGenerated]
	private POLQAVerENUM nM8gFma4YxK;

	[CompilerGenerated]
	private POLQASWBENUM XUagFIhZH3m;

	[CompilerGenerated]
	private MOSSampleRateENUM IZWgFQmFM6J;

	[CompilerGenerated]
	private PESQMOSSampleRateENUM PtHgFlG2bT5;

	[CompilerGenerated]
	private MOSDeviceTypeENUM oxGgFwyxj84;

	[CompilerGenerated]
	private MOSChannelENUM AH3gFpBHSUo;

	[CompilerGenerated]
	private MOSChannelENUM CY3gFabfTmp;

	[CompilerGenerated]
	private int JKygFkgQdYH;

	[CompilerGenerated]
	private int hsWgF0cSrys;

	[CompilerGenerated]
	private RecordModeENUM kp5gFZNF4T0;

	[CompilerGenerated]
	private MOSSampleTypeENUM TjNgFz6ZRCF;

	[CompilerGenerated]
	private MOSPlayModeENUM uJQgbCRZs44;

	[CompilerGenerated]
	private int QNMgbGCdJax;

	[CompilerGenerated]
	private MOSCustomSampleConfig nF0gbRjGSrT;

	[CompilerGenerated]
	private WeChatCallModeENUM kmsgbnPvPyX;

	[CompilerGenerated]
	private bool hSIgbghyEXe;

	[CompilerGenerated]
	private int sOogbeEEKsW;

	[CompilerGenerated]
	private DataTestMode A9YgbPdaDh0;

	private static WeChatCallTestContent WwT28QZneVDV5h4urrRI;

	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[ReadOnly(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Browsable(false)]
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

	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("拨打方式", "Dial Type")]
	public CallTypeENUM CallType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CallTypeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("轮循切换次数", "Switch Times")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int SwitchTimes
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
	[MyDisplayName("被叫手机", "Called UE")]
	[Browsable(true)]
	[ReadOnly(false)]
	public CallUEENUM CallUE
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CallUEENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("被叫用户名", "Called User")]
	[ReadOnly(false)]
	public string CallUser
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
	[MyDisplayName("本机用户名", "Calling User")]
	[Browsable(true)]
	public string CallingUser
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
	[ReadOnly(false)]
	[MyDisplayName("通话时长(s)", "Duration(s)")]
	public int CallTime
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
	[MyDisplayName("接入时长(s)", "Access Time(s)")]
	public int ConnectTime
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

	[MyDisplayName("测试MOS", "MOS test")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public MOSENUM MOS
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("视频MOS", "Video MOS")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[ReadOnly(false)]
	public VideoMOSENUM VideoMOS
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VideoMOSENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("MOS算分环境", "MOS Calc Environment")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	public MOSCalcEnvironmentEnum MOSCalcEnvironment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSCalcEnvironmentEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("POLQA版本", "POLQA Version")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	public POLQAVerENUM MOSAlgoVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (POLQAVerENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[MyDisplayName("POLQA算法", "POLQA Type")]
	[TypeConverter(typeof(EnumConverter))]
	public POLQASWBENUM POLQASWB
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (POLQASWBENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("采样率", "Sampling Frequency")]
	[ReadOnly(false)]
	[Browsable(true)]
	public MOSSampleRateENUM MOSSampleRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSSampleRateENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("采样率", "Sampling Frequency")]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[ReadOnly(false)]
	public PESQMOSSampleRateENUM PESQMOSSampleRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (PESQMOSSampleRateENUM)(object)null;
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
	[MyDisplayName("MOS设备类型", "MOS Device Type")]
	[ReadOnly(false)]
	public MOSDeviceTypeENUM MOSDeviceType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSDeviceTypeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("主叫音频通道", "MOC Channel")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	public MOSChannelENUM MOChannel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSChannelENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("被叫音频通道", "MTC Channel")]
	public MOSChannelENUM MTChannel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSChannelENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(true)]
	[Browsable(false)]
	[MyDisplayName("主叫音频端口", "MOC Port")]
	[Editor(typeof(MOSSerialPortEditor), typeof(UITypeEditor))]
	public int MOPort
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
	[Editor(typeof(MOSSerialPortEditor), typeof(UITypeEditor))]
	[Browsable(false)]
	[MyDisplayName("被叫音频端口", "MTC Port")]
	public int MTPort
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
	[Browsable(true)]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("录音方式", "Record Mode")]
	public RecordModeENUM RecordMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RecordModeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("语料类型", "MOS File")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	public MOSSampleTypeENUM SampleType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSSampleTypeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("语料播录", "MOS Play Mode")]
	[ReadOnly(false)]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	public MOSPlayModeENUM MOSPlayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MOSPlayModeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("语料播放延时(s)", "MOS Play Delay(s)")]
	[Browsable(true)]
	public int MOSPlayDelay
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

	[MyDisplayName("多语料", "Multi MOS Files")]
	[Editor(typeof(SelectMOSFileEditor), typeof(UITypeEditor))]
	[ReadOnly(false)]
	[Browsable(true)]
	public MOSCustomSampleConfig MOSMultiFiles
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

	[MyDisplayName("语音类型", "Voice Mode")]
	[Browsable(true)]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	public WeChatCallModeENUM VoiceMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WeChatCallModeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("是否转换音视频", "Convert audio and video")]
	public bool VASwitchEnable
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
	[Browsable(true)]
	[MyDisplayName("音视频转换延迟(s)", "Switching audio and video delay(s)")]
	public int VASwitchDelay
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
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WeChatCallTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WeChatCallTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uIqYlhZncy44BlL7k0vT()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YL8dwVZn0PFMgWObN3tX()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WeChatCallTestContent CW1YJCZnPAc6eCdoIlYW()
	{
		return null;
	}
}
