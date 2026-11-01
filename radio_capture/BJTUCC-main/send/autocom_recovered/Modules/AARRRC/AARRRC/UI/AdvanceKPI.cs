using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using MfFkViPNWPXCGx8MhRG;
using s2FmbJbfsurLE2IsMMY;

namespace AARRRC.UI;

[Serializable]
public class AdvanceKPI
{
	[XmlIgnore]
	public OneKPI Owner;

	private HasFilterEnum VLbXJcTu1a;

	[CompilerGenerated]
	private bool VZNXyHO8OR;

	[CompilerGenerated]
	private FilterCondition vt2XjmKqDB;

	private HasBinEnum NWIXZDCgMg;

	public bool hasBin;

	[CompilerGenerated]
	private BinType hv5XmxjLZT;

	[CompilerGenerated]
	private int S8IXsebx70;

	[CompilerGenerated]
	private int q4HXciQxcI;

	[CompilerGenerated]
	private int mxeXg2RcyP;

	[CompilerGenerated]
	private BinAlgorithm K3kXMeIAgP;

	public bool hasMultiDimensionStat;

	public DimensionCondition dimensionCondition;

	[XmlIgnore]
	public string ClassifyID;

	internal static AdvanceKPI CkT6P2JTQYMRqdBDAsU;

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("是否过滤", "Filter")]
	[Browsable(true)]
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

	[Editor(typeof(NJGaG9PESQ4DfI0n9wZ), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("过滤条件", "Filter condition")]
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("是否重采样", "Bin")]
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
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MyDisplayName("重采样方式", "Bin")]
	[TypeConverter(typeof(EnumConverter))]
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

	[Browsable(true)]
	[MyDisplayName("取值算法", "Bin algorithm")]
	[TypeConverter(typeof(EnumConverter))]
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

	[MyDisplayName("多维度统计", "Multidimensional Statistics")]
	[Browsable(false)]
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
		sXe9tIbR1fUoYIaU9vk.PxtsPXOw24();
		QZFJE6JN7KKCCcL1a32();
		pG8P1fJ1kpDLdVpyWgu();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vhg78UJlUZaFqXWrpUd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xQ1MR8JJZtSTipT0L3v()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AdvanceKPI nQGT6gJtGIBRTQKljhg()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lnpFOLJ2GRlEdq2E7v5(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NjI10qJoMVqbTTOMlOr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QZFJE6JN7KKCCcL1a32()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pG8P1fJ1kpDLdVpyWgu()
	{
	}
}
