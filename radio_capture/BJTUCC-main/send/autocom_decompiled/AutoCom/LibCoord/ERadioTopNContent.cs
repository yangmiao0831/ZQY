using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class ERadioTopNContent
{
	[CompilerGenerated]
	private EradioTopNScanMode fZqgXRl9VqF;

	[CompilerGenerated]
	private EradioBandLimited HTkgXnjLH7n;

	[CompilerGenerated]
	private List<EradioNetwork> uMbgXg4sVwl;

	[CompilerGenerated]
	private double DHMgXei1xZI;

	[CompilerGenerated]
	private double ksKgXPwGt7E;

	[CompilerGenerated]
	private double eWdgXExhK1H;

	[CompilerGenerated]
	private EradioSpectrumModeEnum vSFgXyh3wuD;

	internal static ERadioTopNContent V5qTkZZHwun48Rb1Yvn7;

	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描模式", "Scan Mode")]
	public EradioTopNScanMode ScanMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EradioTopNScanMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("频段范围", "Band limit")]
	[TypeConverter(typeof(EnumConverter))]
	public EradioBandLimited BandLimited
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EradioBandLimited)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("网络制式", "Network deploy")]
	[TypeConverter(typeof(ERadioDeployStringConverter))]
	[ReadOnly(false)]
	[Editor(typeof(MutliNetworkDeployEditor), typeof(UITypeEditor))]
	[JsonConverter(typeof(ERadioDeployJsonConverter))]
	public List<EradioNetwork> NetworkDeploy
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

	[MyDisplayName("频率(MHz)", "Frequency(MHz)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public double CenterFrequency
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("增益(dB)", "Gain(dB)")]
	[ReadOnly(false)]
	public double Gain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("扫描周期(ms)", "Cycle period(ms)")]
	public double CyclePeriod
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("当前频谱节点", "Spectrum Node")]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	public EradioSpectrumModeEnum SpectrumMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EradioSpectrumModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ERadioTopNContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ERadioTopNContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E21cufZHrWj7h8WSG0Ve()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Pi11c6ZHhCgTyDOw9eyC()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ERadioTopNContent SYnNEKZH4dZ20FqMJXm8()
	{
		return null;
	}
}
