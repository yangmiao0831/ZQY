using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class SpectrumTestContent
{
	public bool UseScannerGPS;

	public int StartFreq;

	public int StopFreq;

	[CompilerGenerated]
	private ENUMPCTELNetTypeSpectrum g0TgV87Igl5;

	[CompilerGenerated]
	private ENUMPCTELBandNR5GSpectrum x6UgVUsjJ41;

	[CompilerGenerated]
	private ENUMPCTELBandNB hNjgVKOBFL1;

	[CompilerGenerated]
	private ENUMPCTELBandLTESpectrum rjPgVtBWxnV;

	[CompilerGenerated]
	private ENUMPCTELBandWCDMA b89gVuYfyUu;

	[CompilerGenerated]
	private ENUMPCTELBandCDMA YEXgVouIETm;

	[CompilerGenerated]
	private ENUMPCTELBandWiFi I5tgVj7xepE;

	[CompilerGenerated]
	private ENUMPCTELBandGSM ludgV7Ttrd9;

	[CompilerGenerated]
	private ENUMPCTELBandAuto RV4gVfQSLLg;

	[CompilerGenerated]
	private int jbVgVDrhQvi;

	[CompilerGenerated]
	private int vQ8gVB7Iwh4;

	private static SpectrumTestContent DHPRoHZHYx6bCcqgaXel;

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

	[Browsable(false)]
	[MyDisplayName("扫描频段", "Scan Band")]
	[TypeConverter(typeof(EnumConverter))]
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
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(false)]
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(false)]
	[MyDisplayName("扫描频段", "Scan Band")]
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描频段", "Scan Band")]
	[Browsable(false)]
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(false)]
	[MyDisplayName("扫描频段", "Scan Band")]
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

	[MyDisplayName("扫描频段", "Scan Band")]
	[Browsable(false)]
	[TypeConverter(typeof(EnumConverter))]
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
	public int RBW
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
	public SpectrumTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpectrumTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		coE3EQZH2tfBZMwor6hW();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yqoH3JZHuiIdEw8aPkbn()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SpectrumTestContent GGhGPMZHyK1uG3kS4dir()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nOsqoHZH6T4k2xis5vi8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void coE3EQZH2tfBZMwor6hW()
	{
	}
}
