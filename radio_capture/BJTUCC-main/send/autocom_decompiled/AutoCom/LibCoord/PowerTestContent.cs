using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class PowerTestContent
{
	public int HoldTimeStart;

	public int HoldTimeEnd;

	public int AscendTimeStart;

	public int AscendTimeOffset;

	[CompilerGenerated]
	private ENUMPowerDeviceType axig4c3KDD8;

	[CompilerGenerated]
	private ENUMPowerOperation p9vg4LP4OGZ;

	[CompilerGenerated]
	private int TF8g4vvUJyb;

	[CompilerGenerated]
	private int vaCg4sDfAWh;

	[CompilerGenerated]
	private int FEeg46UcVWL;

	[CompilerGenerated]
	private int E4yg4hMWFr2;

	[CompilerGenerated]
	private bool CZig41QKLxf;

	[CompilerGenerated]
	private ENUMPowerHoldType sgQg4d3SMmb;

	[CompilerGenerated]
	private int kwhg4W78ikG;

	[CompilerGenerated]
	private int q8rg44SF3IN;

	[CompilerGenerated]
	private int zUOg4NH2yNc;

	[CompilerGenerated]
	private int Ju1g4iPOqdA;

	[CompilerGenerated]
	private int tQNg4FwHMJC;

	private static PowerTestContent jiytXYZdlQOKSwZN9DGt;

	[Browsable(true)]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("设备类型", "Device Type")]
	[JsonConverter(typeof(StringEnumConverter))]
	public ENUMPowerDeviceType DeviceType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPowerDeviceType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("测试类型", "Operation Type")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPowerOperation Operation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPowerOperation)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("开机保持时长(s)", "PowerOn Hold Time(s)")]
	public int HoldTime
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
	[MyDisplayName("测试间隔(s)", "Interval(s)")]
	[ReadOnly(false)]
	public int PowerOffInterval
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
	[MyDisplayName("开机超时(s)", "PowerOn Timeout(s)")]
	public int PowerOnTimeout
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
	[MyDisplayName("关机超时(s)", "PowerOff Timeout(s)")]
	[ReadOnly(false)]
	public int PowerOffTimeout
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
	[MyDisplayName("网络图标监测", "Network Detect")]
	public bool NetworkDetect
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

	[MyDisplayName("保持方式", "Hold Type")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	public ENUMPowerHoldType HoldType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPowerHoldType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("保持时长(分钟)", "Hold Time(min)")]
	[Browsable(true)]
	public int HoldTimeMin
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
	[MyDisplayName("随机时长起点(分钟)", "Hold Time Start(min)")]
	[ReadOnly(false)]
	public int HoldTimeStartMin
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

	[MyDisplayName("随机时长结束点(分钟)", "Hold Time End(min)")]
	[Browsable(true)]
	[ReadOnly(false)]
	public int HoldTimeEndMin
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

	[MyDisplayName("递增初始时长(分钟)", "Ascend Time Start(min)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int AscendTimeStartMin
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
	[MyDisplayName("逐次偏移时长(分钟)", "Ascend Time Offset(min)")]
	[ReadOnly(false)]
	public int AscendTimeOffsetMin
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
	public PowerTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PowerTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a8wr9XZd9JwJPMlfgepT()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PowerTestContent JGswtqZdkrWpYiuw0KWs()
	{
		return null;
	}
}
