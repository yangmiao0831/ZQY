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
public class CallTestContent
{
	public ConnectionSetup ConnectionSetup;

	public string MOSSamplePath;

	[CompilerGenerated]
	private CallTypeENUM m0HghLdRbuU;

	[CompilerGenerated]
	private int Xuoghv1lxNh;

	[CompilerGenerated]
	private CallUEENUM Fpwghsoq6cO;

	[CompilerGenerated]
	private string sI6gh6Mf0x3;

	[CompilerGenerated]
	private string QmGghhjhsm2;

	[CompilerGenerated]
	private int AT3gh1e3IgA;

	[CompilerGenerated]
	private int nBvghdIiFiL;

	[CompilerGenerated]
	private MOSENUM gQgghW3ahId;

	[CompilerGenerated]
	private VideoMOSENUM ai5gh4YYHpN;

	[CompilerGenerated]
	private MOSCalcEnvironmentEnum RoCghNnbM7s;

	[CompilerGenerated]
	private POLQAVerENUM gdZghiUT99S;

	[CompilerGenerated]
	private POLQASWBENUM WlqghFlq3uZ;

	[CompilerGenerated]
	private MOSSampleRateENUM P9lghbLPo0H;

	[CompilerGenerated]
	private PESQMOSSampleRateENUM f2SghVkyNQm;

	[CompilerGenerated]
	private MOSDeviceTypeENUM UDJghXWp2l5;

	[CompilerGenerated]
	private MOSChannelENUM gMYgh2POP9e;

	[CompilerGenerated]
	private MOSChannelENUM HjlghO6BmyN;

	[CompilerGenerated]
	private int sKIghMQPPm4;

	[CompilerGenerated]
	private int Lfugh5yaEGD;

	[CompilerGenerated]
	private RecordModeENUM sw6ghT9T5qZ;

	[CompilerGenerated]
	private MOSSampleTypeENUM zrkghxDmGiR;

	[CompilerGenerated]
	private MOSPlayModeENUM BJlghqQ46nT;

	[CompilerGenerated]
	private int xGJghAEGhEJ;

	[CompilerGenerated]
	private MOSCustomSampleConfig hn5ghYyAMwC;

	[CompilerGenerated]
	private VoiceModeENUM sNdghHX8OhM;

	[CompilerGenerated]
	private int kAQgh3pCGEZ;

	[CompilerGenerated]
	private bool FBVghJhuvkq;

	[CompilerGenerated]
	private int P3aghrXHkUY;

	[CompilerGenerated]
	private bool Ei6gh9wS70E;

	[CompilerGenerated]
	private DataTestMode scggh8FMynY;

	[CompilerGenerated]
	private int UjUghUr6rCg;

	internal static CallTestContent Jy4cHZZ4zPgVMAETcLDY;

	[MyDisplayName("通话方式", "Dial Type")]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[Browsable(true)]
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

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("轮循切换次数", "Switch Times")]
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
	[Browsable(true)]
	[MyDisplayName("被叫手机", "Dialed UE")]
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

	[MyDisplayName("被叫号码", "Dialed Number")]
	[Browsable(true)]
	[ReadOnly(false)]
	public string CallNumber
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
	[MyDisplayName("本机号码", "Calling Number")]
	[ReadOnly(false)]
	public string CallingNumber
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

	[MyDisplayName("通话时长(s)", "Duration(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
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

	[MyDisplayName("接入时长(s)", "Access Time(s)")]
	[Browsable(true)]
	[ReadOnly(false)]
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

	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[MyDisplayName("测试MOS", "MOS test")]
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

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("视频MOS", "Video MOS")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("MOS算分环境", "MOS Calc Environment")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
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

	[MyDisplayName("POLQA版本", "POLQA Version")]
	[ReadOnly(false)]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
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

	[MyDisplayName("POLQA算法", "POLQA Type")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[Browsable(true)]
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

	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[MyDisplayName("采样率", "Sampling Frequency")]
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

	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("采样率", "Sampling Frequency")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[JsonConverter(typeof(MyStringEnumConverter))]
	[MyDisplayName("MOS设备类型", "MOS Device Type")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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

	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(MyStringEnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("主叫音频通道", "MOC Channel")]
	[Browsable(true)]
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("被叫音频通道", "MTC Channel")]
	[ReadOnly(false)]
	[JsonConverter(typeof(MyStringEnumConverter))]
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

	[Editor(typeof(MOSSerialPortEditor), typeof(UITypeEditor))]
	[ReadOnly(true)]
	[Browsable(false)]
	[MyDisplayName("主叫音频端口", "MOC Port")]
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
	[MyDisplayName("被叫音频端口", "MTC Port")]
	[Editor(typeof(MOSSerialPortEditor), typeof(UITypeEditor))]
	[Browsable(false)]
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
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("录音方式", "Record Mode")]
	[ReadOnly(false)]
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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("语料类型", "MOS File")]
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
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
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

	[MyDisplayName("语料播放延时(s)", "MOS Play Delay(s)")]
	[Browsable(true)]
	[ReadOnly(false)]
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

	[Browsable(true)]
	[MyDisplayName("多语料", "Multi MOS Files")]
	[ReadOnly(false)]
	[Editor(typeof(SelectMOSFileEditor), typeof(UITypeEditor))]
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

	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[MyDisplayName("语音类型", "Voice Mode")]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	public VoiceModeENUM VoiceMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VoiceModeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("彩铃播放时长(s)", "Video Ring Duration(s)")]
	public int VideoRingDuration
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
	[MyDisplayName("是否转换音视频", "Convert audio and video")]
	[ReadOnly(false)]
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

	[MyDisplayName("音视频转换延迟(s)", "Switching audio and video delay(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
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

	[MyDisplayName("音视频是否循环转换", "Whether audio and video are circularly converted")]
	[ReadOnly(false)]
	[Browsable(true)]
	public bool VASwitchCycleEnable
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

	[MyDisplayName("测试模式", "Test type")]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
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

	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
	[Browsable(true)]
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
	public CallTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JiEDgjZrYhk6wcxSDfN9()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EadoN9ZrLqWfAw0xXOXh()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CallTestContent Qc1VrQZrNbHPf25PfSrf()
	{
		return null;
	}
}
