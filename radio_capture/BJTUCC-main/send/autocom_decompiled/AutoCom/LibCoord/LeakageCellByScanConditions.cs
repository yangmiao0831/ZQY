using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class LeakageCellByScanConditions
{
	[XmlAttribute]
	public bool isscanner;

	[XmlAttribute]
	public string net;

	[XmlAttribute]
	public string signal;

	[XmlAttribute]
	public string sinr;

	[XmlAttribute]
	public string bin;

	[CompilerGenerated]
	private OverlapNetTypeScan dhrgGJ9v2XR;

	[CompilerGenerated]
	private OverlapScanNeighborDataType u20gGrWeKFr;

	[CompilerGenerated]
	private string n6QgG9DMkKl;

	[CompilerGenerated]
	private string alkgG8gmVEm;

	[CompilerGenerated]
	private int MXXgGU5OLdU;

	[CompilerGenerated]
	private int i86gGKxq3Sf;

	[CompilerGenerated]
	private int f33gGtTBpvb;

	[CompilerGenerated]
	private string LFfgGuatT2h;

	private static LeakageCellByScanConditions i1AAhMKXjpecKOLWTwQp;

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("网络", "NetType")]
	[XmlIgnore]
	public OverlapNetTypeScan netType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapNetTypeScan)(object)null;
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
	[MyDisplayName("数据类型", "DataType")]
	public OverlapScanNeighborDataType dataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapScanNeighborDataType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlAttribute]
	[Editor(typeof(UTSFileNameEditor), typeof(UITypeEditor))]
	[MyDisplayName("扫频仪文件", "Scanner logfile")]
	[Browsable(true)]
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

	[Browsable(true)]
	[XmlIgnore]
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

	[Browsable(true)]
	[XmlIgnore]
	[DisplayName("RSRP>=")]
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

	[DisplayName("SINR>=")]
	[XmlAttribute]
	[Browsable(true)]
	[XmlIgnore]
	public int minsinr
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

	[MyDisplayName("重采样时长(s)", "Resample time(s)")]
	[Browsable(true)]
	[XmlIgnore]
	public int bintime
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
	public LeakageCellByScanConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeakageCellByScanConditions(AnalysisType anaType)
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
	static LeakageCellByScanConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W4IeL5KXPnk7yXX187sy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iScXR2KXeDb9X40M7SFt()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LeakageCellByScanConditions WP8KsnKX0p0ohVdRvGK2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EtPwGvKXcjNMHJ1kwTWZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MhydZAKX8yP2INO4bwp9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object llYKapKXwnlLnFQLAJya(object P_0, object P_1)
	{
		return null;
	}
}
