using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibCoord.ReportForms;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class PoorCoverageConditions
{
	public List<string> AnalysisLogfiles;

	private string NxxgCcEa7Tk;

	[XmlAttribute]
	public string net;

	[XmlAttribute]
	public string bycell;

	[XmlAttribute]
	public int key;

	[XmlAttribute]
	public string descrip;

	[XmlAttribute]
	public int type;

	[XmlAttribute]
	public string lambda;

	[XmlAttribute]
	public double rate;

	[XmlElement("sections")]
	[JsonIgnore]
	public Sections Sections;

	[CompilerGenerated]
	private OverlapNetType FxdgCLVKC74;

	[CompilerGenerated]
	private OverlapRSRP RCWgCvUMJyB;

	[CompilerGenerated]
	private OverlapSmall hWPgCs8CI8F;

	[CompilerGenerated]
	private OverlapBig J6hgC6Eh2UZ;

	[CompilerGenerated]
	private int bjYgChoduOS;

	[CompilerGenerated]
	private int PpsgC16kkYy;

	[CompilerGenerated]
	private int f9fgCdlq4Wo;

	[CompilerGenerated]
	private PoorCoverageType eDRgCWisbEC;

	[CompilerGenerated]
	private int yVVgC40dASL;

	[CompilerGenerated]
	private double J2wgCNbCf5o;

	[CompilerGenerated]
	private string WPQgCi8cq9t;

	[CompilerGenerated]
	private string I91gCFLNQi2;

	[CompilerGenerated]
	private string vfBgCbFVSGX;

	[CompilerGenerated]
	private string aoDgCVJBP8u;

	[CompilerGenerated]
	private DistrictLevel slMgCXbtIOA;

	private static PoorCoverageConditions mTqkadKmwDxrOiCl54Rd;

	[Editor(typeof(MultiSelectFileNameEditor), typeof(UITypeEditor))]
	[XmlIgnore]
	[Browsable(true)]
	[MyDisplayName("分析数据", "Analysis Logfiles")]
	public string StrAnalysisLogfiles
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

	[XmlIgnore]
	[MyDisplayName("网络", "NetType")]
	[TypeConverter(typeof(EnumConverter))]
	public OverlapNetType netType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapNetType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("分析参数", "Analysis parameter")]
	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public OverlapRSRP nr5gRSRP
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapRSRP)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[DisplayName("RSRP")]
	public OverlapSmall nr5gRSRPSmall
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapSmall)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
	[DisplayName("RSRP")]
	[Browsable(true)]
	public OverlapBig nr5gRSRPBig
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapBig)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	[DisplayName(" ")]
	[Browsable(true)]
	public int signal
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
	[DisplayName("RSRP>=")]
	[Browsable(true)]
	public int interferenceRSRP
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
	[XmlIgnore]
	[DisplayName("SINR<=")]
	public int sinr
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
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("持续条件", "Continuous condition")]
	public PoorCoverageType PoorType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (PoorCoverageType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("持续时间(s)", "Duration(s)")]
	[Browsable(true)]
	[XmlIgnore]
	public int Duration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("持续距离(m)", "Distance(m)")]
	[XmlIgnore]
	public int Distance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[XmlAttribute]
	[Browsable(false)]
	public int value
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
	[Browsable(true)]
	[MyDisplayName("满足条件占比(%)", "Proportion of satisfied conditions (%)")]
	public double ratio
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

	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
	[MyDisplayName("基站数据库", "Site database")]
	[Browsable(true)]
	[XmlAttribute]
	public string siteFile
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

	[Editor(typeof(hmep5X9cAMY9t8tsFbC), typeof(UITypeEditor))]
	[XmlIgnore]
	[MyDisplayName("过滤", "Filter")]
	public string FilterName
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

	[XmlIgnore]
	[MyDisplayName("频点", "ARFCN")]
	[Browsable(false)]
	public string ARFCN
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

	[XmlIgnore]
	[MyDisplayName("PCI", "PCI")]
	[Browsable(false)]
	public string PCI
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

	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("汇总维度", "Summary Level")]
	public DistrictLevel DistrictLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DistrictLevel)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PoorCoverageConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PoorCoverageConditions(AnalysisType anaType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcParams(AnalysisType anaType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoorCoverageConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		WilHNEKmsLrXZxNiLiuc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NRsK96Kmh4gXDWdkF2td()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PoorCoverageConditions xX5BKrKm4arLFKYn8PRD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g49VJDKmrvPHijqflB7b(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AG0CTHKmDw8cb0XRMrEh(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FUhin9Kmdjxs9sZaZU5g(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NHBrdyKmCgQ3Jri10ylh(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RGOaQRKmnAV40Tnyw1TQ(NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NAGnmKKmauUqT6NeXQnw(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dQhJksKmHd2WNwfgykoR(NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WilHNEKmsLrXZxNiLiuc()
	{
	}
}
