using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class OverlapConditions
{
	[XmlAttribute]
	public string net;

	[XmlAttribute]
	public string dimension;

	[XmlAttribute]
	public string signal;

	[XmlElement("sections")]
	[JsonIgnore]
	public Sections Sections;

	[CompilerGenerated]
	private OverlapNetType baCnzmLDgMe;

	[CompilerGenerated]
	private OverlapDimension NK7nzIj7v7N;

	[CompilerGenerated]
	private OverlapBig a5unzQySBkt;

	[CompilerGenerated]
	private int W4inzlFCt9f;

	[CompilerGenerated]
	private int nkOnzwILyq7;

	[CompilerGenerated]
	private int YAcnzpsTT5T;

	[CompilerGenerated]
	private continuesEx PbQnzaQerX7;

	[CompilerGenerated]
	private string qnjnzk4ObLv;

	[CompilerGenerated]
	private string QsQnz05WkHZ;

	internal static OverlapConditions d7N7BHKmQaZFmW2vvfTW;

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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[XmlIgnore]
	[MyDisplayName("分析维度", "Analysis dimension")]
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

	[Browsable(true)]
	[MyDisplayName("最强RSRP", "Strongest RSRP")]
	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
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
	[Browsable(true)]
	[DisplayName(" ")]
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
	[MyDisplayName("与最强RSRP差值<=", "Difference between RSRP and the strongest <=")]
	public int diff
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

	[MyDisplayName("重叠覆盖度>=", "Overlapping coverage>=")]
	[XmlAttribute]
	public int degree
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

	[MyDisplayName("持续条件", "Continuous condition")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public continuesEx continues
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
	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
	[XmlAttribute]
	[MyDisplayName("基站数据库", "Site database")]
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
	[XmlIgnore]
	[Editor(typeof(hmep5X9cAMY9t8tsFbC), typeof(UITypeEditor))]
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
	public OverlapConditions()
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
	static OverlapConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		lI5SbXKmgN3bRU6VI4rD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hk04NRKm3JdNT7u0cED2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t0AaJcKmF9ZJekQUeCLs(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool egcksAKmRnE0VLeyQZvA()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OverlapConditions zUlWlaKmGYjykLiT2CBL()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kcLVjKKm7w4uoCCa0B1n(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tBypDdKmbZ6w3q25YJM9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lI5SbXKmgN3bRU6VI4rD()
	{
	}
}
