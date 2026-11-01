using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class TopNTranscomTestContent
{
	public bool UseScannerGPS;

	private PCTELMultiCheckList MejgyX6iZ8C;

	private PCTELMultiCheckList Bc1gy2WBICy;

	[CompilerGenerated]
	private ENUMTranscomNetType Q8igyOujbw6;

	[CompilerGenerated]
	private ENUMTranscomScanMode RdsgyMDhoDN;

	[CompilerGenerated]
	private ENUMTranscomBandNR5G tuVgy5IdEhB;

	[CompilerGenerated]
	private ENUMPCTELBandLTE IZPgyT1Di5I;

	[CompilerGenerated]
	private string GcSgyxjRj5c;

	[CompilerGenerated]
	private enumNRBandWidth Ur8gyql9Ujk;

	[CompilerGenerated]
	private enumLTEPilotScanMeasureBandwidth VBbgyA7Jy90;

	[CompilerGenerated]
	private enumNRSubcarrierSpacing dPUgyYVvgGp;

	[CompilerGenerated]
	private int JqAgyH9E4lk;

	[CompilerGenerated]
	private int oOBgy3PhDaZ;

	[CompilerGenerated]
	private enumNRPilotScanSortType nELgyJQeGIN;

	[CompilerGenerated]
	private enumLTEPilotScanSortType wQPgyreB9yf;

	[CompilerGenerated]
	private bool MQQgy9TYvTJ;

	[CompilerGenerated]
	private bool FLggy8NneDn;

	[CompilerGenerated]
	private int jkJgyUsgjj0;

	[CompilerGenerated]
	private double G2mgyKij6xa;

	private static TopNTranscomTestContent USsQ3xZtWTF9d0gdEuaG;

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("网络制式", "Net Type")]
	public ENUMTranscomNetType NetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMTranscomNetType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描模式", "Scan Mode")]
	public ENUMTranscomScanMode ScanMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMTranscomScanMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("扫描频段", "Scan Band")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public ENUMTranscomBandNR5G ScanBandNR
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMTranscomBandNR5G)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("扫描频段", "Scan Band")]
	public ENUMPCTELBandLTE ScanBandLte
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandLTE)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[Editor(typeof(BandListNR5GEditor), typeof(UITypeEditor))]
	[MyDisplayName("频段列表", "Band List")]
	public PCTELMultiCheckList BandListNR5G
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

	[MyDisplayName("频段列表", "Band List")]
	[Browsable(true)]
	[Editor(typeof(BandListNR5GEditor), typeof(UITypeEditor))]
	public PCTELMultiCheckList BandListLte
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

	[MyDisplayName("频点信息", "Frequency Info")]
	[Browsable(true)]
	public string FrequencyInfo
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
	[MyDisplayName("测量带宽(MBW)", "Measure bandwidth(MBW)")]
	[TypeConverter(typeof(EnumConverter))]
	public enumNRBandWidth MBWNR
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (enumNRBandWidth)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("测量带宽(MBW)", "Measure bandwidth(MBW)")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public enumLTEPilotScanMeasureBandwidth MBWLTE
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (enumLTEPilotScanMeasureBandwidth)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("子载波间隔(SCS)", "Subcarrier spacing(SCS)")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	public enumNRSubcarrierSpacing SCSNR5G
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (enumNRSubcarrierSpacing)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("上报小区数", "Report cell count")]
	[Browsable(true)]
	public int TOPN
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

	[MyDisplayName("RP门限(dBm)", "RP Threshold(dBm)")]
	[Browsable(true)]
	public int RPTNR
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

	[MyDisplayName("排序字段", "Sort Parameter")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public enumNRPilotScanSortType SortTypeNR
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (enumNRPilotScanSortType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("排序字段", "Sort Parameter")]
	[TypeConverter(typeof(EnumConverter))]
	public enumLTEPilotScanSortType SortTypeLte
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (enumLTEPilotScanSortType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("采集层三信令", "Layer3 Message")]
	public bool Layer3
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
	[MyDisplayName("指定扫频区间", "Specified Frequency Range")]
	public bool bFrequencyRange
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
	[MyDisplayName("中心频率(MHz)", "Center Frequency(MHz)")]
	public int CenterFrequencyInMHz
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
	[MyDisplayName("采样频率(Hz)", "Measure Rate(Hz)")]
	public double MeasRate
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TopNTranscomTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TopNTranscomTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		Al7bYrZtVaAUfsL99xA7();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SgvPGqZtEhaAo1V69dwj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qNPJMYZtBtbetEA8YkEe()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TopNTranscomTestContent TF99BiZtqAyeoWBdpAZs()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Al7bYrZtVaAUfsL99xA7()
	{
	}
}
