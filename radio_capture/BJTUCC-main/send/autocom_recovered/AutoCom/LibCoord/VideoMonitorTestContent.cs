using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class VideoMonitorTestContent
{
	private ConnectionSetup rfugFb3Iuhi;

	[CompilerGenerated]
	private VMDeviceType JthgFV6Uo8N;

	[CompilerGenerated]
	private string mvEgFXY28Tq;

	[CompilerGenerated]
	private string XEagF2FZ3mb;

	[CompilerGenerated]
	private string bIMgFOm81Aa;

	[CompilerGenerated]
	private string M3YgFM88MiS;

	[CompilerGenerated]
	private int dsJgF5ZlOkK;

	[CompilerGenerated]
	private string QVEgFTCib10;

	[CompilerGenerated]
	private string ffFgFxTankm;

	[CompilerGenerated]
	private int jSugFqyMH3b;

	[CompilerGenerated]
	private VMProtocol FfDgFA97lUC;

	[CompilerGenerated]
	private int nrjgFYNsMbA;

	[CompilerGenerated]
	private bool tsFgFHyA3VZ;

	[CompilerGenerated]
	private bool BJ7gF3IV06K;

	[CompilerGenerated]
	private long e7IgFJs4hhV;

	[CompilerGenerated]
	private int yd7gFr84TrE;

	[CompilerGenerated]
	private int cRrgF97XiRl;

	[CompilerGenerated]
	private DataTestMode BGXgF86dj0w;

	internal static VideoMonitorTestContent rBMLQpZnFwEpAp2JeqjM;

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

	[MyDisplayName("设备类型", "Device Type")]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	public VMDeviceType DeviceType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VMDeviceType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("设备组名称", "Device Group Name")]
	public string DeviceGroupName
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

	[MyDisplayName("摄像机名称", "Camera Name")]
	[ReadOnly(false)]
	public string CameraName
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
	[MyDisplayName("设备名称", "Device Name")]
	public string DeviceName
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
	[MyDisplayName("摄像机IP", "Camera IP")]
	public string MediaServerIP
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
	[MyDisplayName("摄像机Port", "Camera Port")]
	public int MediaServerPort
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

	[MyDisplayName("用户名", "User Name")]
	[ReadOnly(false)]
	public string Username
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
	[MyDisplayName("密码", "Password")]
	public string Password
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

	[MyDisplayName("延迟(ms)", "Latency(ms)")]
	[ReadOnly(false)]
	public int Latency
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
	[MyDisplayName("协议", "Protocol")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	public VMProtocol Protocol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VMProtocol)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("TCP接收窗长", "TCP Recv Win Size")]
	public int TCPRecvWinSize
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

	[MyDisplayName("时钟同步", "Sync")]
	[ReadOnly(false)]
	public bool Sync
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

	[MyDisplayName("限制缓存区", "Limit Lateness")]
	[ReadOnly(false)]
	public bool LimitLateness
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
	[MyDisplayName("缓冲区在被丢弃之前可以延迟的最大纳秒数", "Max lateness")]
	[ReadOnly(false)]
	public long Max_lateness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("监控时长(s)", "Play Duration(s)")]
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

	[MyDisplayName("测试模式", "Test type")]
	[TypeConverter(typeof(EnumConverter))]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoMonitorTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VideoMonitorTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		R58NkbZnjgKuIebMd0h9();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OpFsioZngpSMXFnu9oMV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T0HMaBZnfLT8JQUIbW7J(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QT02c8Zn73w45IbRo209()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VideoMonitorTestContent sFxavWZnbIAljI9inBUG()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R58NkbZnjgKuIebMd0h9()
	{
	}
}
