using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class ValidCellConditions
{
	[XmlAttribute]
	public string net;

	[XmlAttribute]
	public string dimension;

	[XmlAttribute]
	public string signal;

	[CompilerGenerated]
	private OverlapNetType DtJgGoHPbJu;

	[CompilerGenerated]
	private OverlapDimension T6JgGjoceZ8;

	[CompilerGenerated]
	private int eFRgG7J1QfE;

	[CompilerGenerated]
	private int jeogGfyHCTH;

	[CompilerGenerated]
	private string aEmgGD92gqt;

	[CompilerGenerated]
	private string z72gGBnr9UY;

	private static ValidCellConditions nMMs9wKXhdlvY1aW3kbR;

	[TypeConverter(typeof(EnumConverter))]
	[XmlIgnore]
	[MyDisplayName("网络", "NetType")]
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

	[XmlIgnore]
	[Browsable(true)]
	[MyDisplayName("分析维度", "Analysis dimension")]
	[TypeConverter(typeof(EnumConverter))]
	public OverlapDimension dimensionType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapDimension)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("RSRP>=")]
	[XmlIgnore]
	public int minsignal
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

	[XmlAttribute]
	[MyDisplayName("有效小区数<=", "Valid cell count <=")]
	[Browsable(true)]
	public int cellcount
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

	[MyDisplayName("基站数据库", "Site database")]
	[XmlAttribute]
	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
	[Browsable(true)]
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

	[MyDisplayName("过滤", "Filter")]
	[Editor(typeof(hmep5X9cAMY9t8tsFbC), typeof(UITypeEditor))]
	[XmlIgnore]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValidCellConditions()
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
	static ValidCellConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		JMi1JPKXnXjevJ6xEoRp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RoKWXFKXDj7xeNARihxS()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WvgLLWKXd0fDuUJ4dEp1(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wBxuEkKX4AmdgT11n0Yl()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ValidCellConditions hxyyuIKXrG54rKJHxPV2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IN3pqnKXC1Xry2hXFiif(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JMi1JPKXnXjevJ6xEoRp()
	{
	}
}
