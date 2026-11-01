using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using LibUtils;
using NcWjuL9gZPXFsPGJXFQ;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using i7Dfwf9Sl9UfnRlyqCw;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class CWTestContent
{
	public bool UseScannerGPS;

	public int CenterFreq;

	private FreqList ecPgVVGOg6n;

	private FreqList wLZgVXCentc;

	[CompilerGenerated]
	private ENUMPCTELNetType v5wgV2U0bmh;

	[CompilerGenerated]
	private ENUMCWFreqType Qo6gVOM8WSg;

	[CompilerGenerated]
	private ENUMPCTELBandNR5G DxGgVMSut2T;

	[CompilerGenerated]
	private ENUMPCTELBandNB JtWgV5HOTFa;

	[CompilerGenerated]
	private ENUMPCTELBandLTE LyHgVTVPCvX;

	[CompilerGenerated]
	private ENUMPCTELBandWCDMA gITgVxbD2T4;

	[CompilerGenerated]
	private ENUMPCTELBandCDMA WscgVq0cBv8;

	[CompilerGenerated]
	private ENUMPCTELBandWiFi MVTgVAknMg7;

	[CompilerGenerated]
	private ENUMPCTELBandAuto STdgVYhCilc;

	[CompilerGenerated]
	private int zm3gVHWafMa;

	[CompilerGenerated]
	private ENUMOPTINetType G6ugV3HU2hr;

	[CompilerGenerated]
	private double t7SgVJVtv5x;

	[CompilerGenerated]
	private int T85gVrG6BjW;

	[CompilerGenerated]
	private int FSXgV9uZmKB;

	private static CWTestContent GPUTU3Za52weCV5LHY7I;

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("网络制式", "Net Type")]
	[Browsable(false)]
	public ENUMPCTELNetType NetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELNetType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("网络制式", "Net Type")]
	[Browsable(false)]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPCTELNetTypeCW NetTypeCW
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ENUMPCTELNetTypeCW)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("扫描方式", "Scan Mode")]
	public ENUMCWFreqType FreqType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMCWFreqType)(object)null;
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
	public ENUMPCTELBandNR5G BandNR5G
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandNR5G)(object)null;
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

	[Browsable(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描频段", "Scan Band")]
	public ENUMPCTELBandLTE BandLTE
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
	[TypeConverter(typeof(EnumConverter))]
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

	[Browsable(false)]
	[MyDisplayName("扫描频段", "Scan Band")]
	[TypeConverter(typeof(EnumConverter))]
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

	[MyDisplayName("测量周期(ms)", "Measurement cycle(ms)")]
	[Browsable(true)]
	public int RptParm
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
	[MyDisplayName("中心频率(MHz)", "Center frequency(MHz)")]
	public double PCenterFreq
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

	[MyDisplayName("网络", "NetType")]
	[Browsable(false)]
	public ENUMOPTINetType OPTINetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMOPTINetType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("频点列表", "EARFCN list")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Editor(typeof(lgBGRp9QwQJOTEFRDuE), typeof(UITypeEditor))]
	public FreqList EARFCNList
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

	[Browsable(false)]
	[Editor(typeof(jEwUZC9rjcEIpCwQQi9), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[MyDisplayName("频率列表(MHz)", "Frequency list(MHz)")]
	public FreqList FreqList
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

	[Browsable(true)]
	[MyDisplayName("分辨率带宽(KHz)", "Resolution bandwidth(KHz)")]
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

	[MyDisplayName("频率扫描步长(KHz)", "Frequency scanning step(KHz)")]
	[Browsable(true)]
	public int FreqStepSize
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
	[MyDisplayName("频率分段个数", "Number of frequency segments")]
	public int NumberOfBins
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
	public CWTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CWTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		APs1eyZHNa2p6SZTitce();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kfkUlVZHLEW61Cljepvf()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zMG31JZaiCsbs7LwOygp()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CWTestContent TKEtxkZazfenqcUGGAMK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void APs1eyZHNa2p6SZTitce()
	{
	}
}
