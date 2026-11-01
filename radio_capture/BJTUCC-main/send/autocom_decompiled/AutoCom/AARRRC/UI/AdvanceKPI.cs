using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using Newtonsoft.Json;
using QagWeulP0Iq9QJsU9Pt;
using tcEeYRHYMSOOr5xhr11;

namespace AARRRC.UI;

[Serializable]
public class AdvanceKPI
{
	[JsonIgnore]
	[XmlIgnore]
	public OneKPI Owner;

	private HasFilterEnum VDQGnLXyoDJ;

	private HasBinEnum Yj2GnvhYLqu;

	public bool hasMultiDimensionStat;

	public DimensionCondition dimensionCondition;

	[XmlIgnore]
	public string ClassifyID;

	[CompilerGenerated]
	private bool v7JGnsu2Fu0;

	[CompilerGenerated]
	private FilterCondition b3MGn6lUdlZ;

	[CompilerGenerated]
	private bool K1OGnh0QW2e;

	[CompilerGenerated]
	private BinType pbuGn1QWl4v;

	[CompilerGenerated]
	private int AZIGnd3n2MX;

	[CompilerGenerated]
	private int IZaGnWZWYCx;

	[CompilerGenerated]
	private int s13Gn4EhTGt;

	[CompilerGenerated]
	private BinAlgorithm igZGnNJsiDH;

	internal static AdvanceKPI naUoCaYPlBlQ3PaS5xV6;

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("是否过滤", "Filter")]
	public HasFilterEnum HasFilterSelector
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (HasFilterEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Browsable(false)]
	public bool HasFilter
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

	[MyDisplayName("过滤条件", "Filter condition")]
	[Browsable(true)]
	[Editor(typeof(M0EyNRlk6CX0uEhPbp4), typeof(UITypeEditor))]
	public FilterCondition FilterCondition
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
	[MyDisplayName("是否重采样", "Bin")]
	[TypeConverter(typeof(BinEnumConverter))]
	public HasBinEnum HasBinSelector
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (HasBinEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Browsable(false)]
	public bool HasBin
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("重采样方式", "Bin")]
	[Browsable(true)]
	public BinType BinType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BinType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("栅格条件(m*m)", "Bin condition(m*m)")]
	[Browsable(true)]
	public int GridCondition
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

	[MyDisplayName("距离条件(m)", "Distance condition(m)")]
	[Browsable(true)]
	public int DistanceCondition
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
	[MyDisplayName("时长条件(s)", "Time condition(s)")]
	public int TimeCondition
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

	[MyDisplayName("取值算法", "Bin algorithm")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public BinAlgorithm BinAlgorithm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BinAlgorithm)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[MyDisplayName("多维度统计", "Multidimensional Statistics")]
	public bool HasMultiDimensionStat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[Browsable(false)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("维度", "Dimension")]
	public DimensionCondition DimensionCondition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (DimensionCondition)(object)null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AdvanceKPI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvanceKPI()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		hcey6gYPSuwfNWsL1cr8();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JNAfOTYP9ifLZJax4YlX()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AdvanceKPI nTgPQ6YPkdH1411jhv7x()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OW4dSbYP1LKIJRW9nMxp(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dxS7PvYPv9MTPys197mu(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hcey6gYPSuwfNWsL1cr8()
	{
	}
}
