using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class SpectrumPCTELTestContent
{
	public bool UseScannerGPS;

	public int StartFreq;

	public int StopFreq;

	[CompilerGenerated]
	private ENUMPCTELNetTypeSpectrum SxVgE0dgf3U;

	[CompilerGenerated]
	private ENUMPCTELBandNR5GSpectrum YYggEZ6yuaV;

	[CompilerGenerated]
	private ENUMPCTELBandNB N5mgEzCrM0l;

	[CompilerGenerated]
	private ENUMPCTELBandLTESpectrum nOFgyCbSGIx;

	[CompilerGenerated]
	private ENUMPCTELBandWCDMA BYAgyG26W2i;

	[CompilerGenerated]
	private ENUMPCTELBandCDMA JhBgyRunPmr;

	[CompilerGenerated]
	private ENUMPCTELBandWiFi yhQgynZyCFA;

	[CompilerGenerated]
	private ENUMPCTELBandGSM gHcgygknKsR;

	[CompilerGenerated]
	private ENUMPCTELBandAuto m6igye26o1U;

	[CompilerGenerated]
	private double HJOgyPG2fVt;

	[CompilerGenerated]
	private int jl5gyEk5ibt;

	private static SpectrumPCTELTestContent AIKBaqZxvEDZUa8BAKO5;

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("网络类型", "Net Type")]
	public ENUMPCTELNetTypeSpectrum NetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELNetTypeSpectrum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描频段", "Scan Band")]
	[Browsable(true)]
	public ENUMPCTELBandNR5GSpectrum BandNR5G
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandNR5GSpectrum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描频段", "Scan Band")]
	[Browsable(false)]
	public ENUMPCTELBandNB BandNB
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandNB)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("扫描频段", "Scan Band")]
	[Browsable(false)]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPCTELBandLTESpectrum BandLTE
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandLTESpectrum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描频段", "Scan Band")]
	public ENUMPCTELBandWCDMA BandWCDMA
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandWCDMA)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[MyDisplayName("扫描频段", "Scan Band")]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPCTELBandCDMA BandCDMA
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandCDMA)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描频段", "Scan Band")]
	public ENUMPCTELBandWiFi BandWiFi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandWiFi)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[MyDisplayName("扫描频段", "Scan Band")]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPCTELBandGSM BandGSM
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandGSM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描频段", "Scan Band")]
	[Browsable(false)]
	public ENUMPCTELBandAuto BandAuto
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandAuto)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("起始频率(MHz)", "Start frequency(MHz)")]
	public double PStartFreq
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MyDisplayName("终止频率(MHz)", "Stop frequency(MHz)")]
	public double PStopFreq
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MyDisplayName("分辨率带宽(KHz)", "Resolution bandwidth(KHz)")]
	[Browsable(true)]
	public double RBW
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

	[Browsable(true)]
	[MyDisplayName("每秒扫描次数", "Scan times per second")]
	public int AvergeFrames
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
	public SpectrumPCTELTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpectrumPCTELTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kyHB0KZxSw9j5fi95ReG()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SpectrumPCTELTestContent Eexp16ZxmFnPHAkoOVB1()
	{
		return null;
	}
}
