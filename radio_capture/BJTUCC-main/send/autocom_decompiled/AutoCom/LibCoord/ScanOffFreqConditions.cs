using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class ScanOffFreqConditions
{
	[XmlAttribute]
	public string signal;

	[XmlAttribute]
	public string rate;

	[XmlAttribute]
	public string condition;

	[XmlAttribute]
	public string bin;

	[CompilerGenerated]
	private string ySogGaVVvSt;

	[CompilerGenerated]
	private string wwDgGkLUyuN;

	[CompilerGenerated]
	private string r7dgG0Ubt1Y;

	[CompilerGenerated]
	private int sDKgGZoMRb1;

	[CompilerGenerated]
	private double YItgGz2a7rF;

	[CompilerGenerated]
	private OffFreqParamEnum KEEgRCkM4Uq;

	[CompilerGenerated]
	private double ylUgRG6I5j7;

	[CompilerGenerated]
	private int sHjgRRe4M8R;

	[CompilerGenerated]
	private double Q1BgRncQ6jg;

	private static ScanOffFreqConditions vF1OuwKX5vfaIRDah64m;

	[MyDisplayName("扫频仪文件", "Scanner Logfile")]
	[Editor(typeof(UTSFileNameEditor), typeof(UITypeEditor))]
	[XmlAttribute]
	public string scannerfile
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

	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
	[XmlIgnore]
	[MyDisplayName("基站数据库", "Site database")]
	[Browsable(true)]
	public string SiteFile
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
	[XmlAttribute]
	[MyDisplayName("频点列表(逗号分隔)", "Frequency List")]
	public string freqlist
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

	[MyDisplayName("重采样时长(s)", "Resample time(s)")]
	[Browsable(true)]
	[XmlIgnore]
	public int BinTime
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

	[MyDisplayName("扫频仪RSRP>=", "Scanner RSRP>=")]
	[Browsable(true)]
	[XmlIgnore]
	public double RSRP
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

	[MyDisplayName("退频影响参数", "Off Freq Effected Param")]
	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public OffFreqParamEnum EffectedParam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OffFreqParamEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	[Browsable(true)]
	[MyDisplayName("退频参数取值<=", "Off Freq param<=")]
	public double ParamValue
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

	[XmlAttribute]
	[MyDisplayName("累计时长(s)", "Duration(s)")]
	public int duration
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

	[XmlIgnore]
	[MyDisplayName("满足条件占比(%)", "Conditions Ratio(%)")]
	public double Ratio
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
	public ScanOffFreqConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcParams()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScanOffFreqConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		aYMLsZKU2FTNPu6Oo1Xi();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xUW2mKKULHeDXFD26h4b()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L16miFKXik3KRoVtvA8N()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScanOffFreqConditions dwuuM3KXz8ZQAI9FWqFH()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lKRMl3KUN5HZRd9XEhBl(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UbxiGUKUYQWB5pY2IhTY(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gONnABKUuT20IOFZRK3P(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eEQHtbKUysBhTgykSMRv(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LMSpXZKU6vnL1COsi9j1(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aYMLsZKU2FTNPu6Oo1Xi()
	{
	}
}
