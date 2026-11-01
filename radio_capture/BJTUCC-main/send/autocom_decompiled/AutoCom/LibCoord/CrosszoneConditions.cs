using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class CrosszoneConditions
{
	[XmlAttribute]
	[TypeConverter(typeof(EnumConverter))]
	public OverlapDimension dimension;

	private OverlapRSRP o3onz9JJuJG;

	[NonSerialized]
	private AnalysisType LGSnz89IJri;

	[XmlAttribute]
	public string signal;

	private double UUXnzUPjUok;

	[XmlAttribute]
	public string sinr;

	[XmlAttribute]
	public bool bycell;

	[XmlAttribute]
	public string distance;

	[XmlElement("bycell")]
	public ByCellValue ByCell;

	[XmlAttribute]
	public double rate;

	[CompilerGenerated]
	private CrosszoneNetType jGbnzKs3vk9;

	[CompilerGenerated]
	private int pE1nztQrMqE;

	[CompilerGenerated]
	private double BbwnzuuMUfV;

	[CompilerGenerated]
	private int LuwnzoGWMEp;

	[CompilerGenerated]
	private int nMqnzjj9AYM;

	[CompilerGenerated]
	private string u90nz7dafti;

	private static CrosszoneConditions mlXtEKKSOO0DxQ0uYsjG;

	[TypeConverter(typeof(EnumConverter))]
	[XmlAttribute]
	[MyDisplayName("网络", "NetType")]
	public CrosszoneNetType net
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CrosszoneNetType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("分析参数", "Analysis parameter")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[XmlIgnore]
	public OverlapRSRP DimensionRSRP
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (OverlapRSRP)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Browsable(false)]
	[XmlIgnore]
	public AnalysisType analysisType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (AnalysisType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[DisplayName("RSRP>=")]
	[XmlIgnore]
	public double SignalValue
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

	[XmlIgnore]
	[Browsable(false)]
	[MyDisplayName("过覆盖累计里程(m)", "Overlay distance(m)")]
	public int DistanceOverlay
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

	[MyDisplayName("站间距系数", "Station spacing coefficient")]
	[XmlIgnore]
	[Browsable(false)]
	public double RatioOverlay
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

	[MyDisplayName("超远覆盖累计里程(m)", "TooFar distance(m)")]
	[XmlIgnore]
	[Browsable(false)]
	public int DistanceTooFar
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
	[MyDisplayName("服务小区覆盖距离 >= (m)", "Station spacing coefficient")]
	[Browsable(false)]
	public int SiteDistanceTooFar
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
	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
	[MyDisplayName("基站数据库", "Site database")]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrosszoneConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrosszoneConditions(AnalysisType type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcParam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CrosszoneConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		iFKCPVKm67l5XO76A5DY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void esQmRMKSzl6IWPFJqUvn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qc9GgsKmLxSHWJYq13JQ(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BCsh6CKS5CTKftB1bV9y()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CrosszoneConditions fJ4YqiKSisEmQ6IPDYdR()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object akpJf3KmN4lhsmFSoVix()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t0ujIEKmYueBc371dsHD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pEhsl4KmuCH5dxmT5I55(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ABYbKIKmyO0SR6hYhkTr(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iFKCPVKm67l5XO76A5DY()
	{
	}
}
