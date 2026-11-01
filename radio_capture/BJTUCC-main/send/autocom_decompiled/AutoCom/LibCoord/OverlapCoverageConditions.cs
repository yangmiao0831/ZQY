using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class OverlapCoverageConditions
{
	[CompilerGenerated]
	private AnalysisOverlapObjType c4cgGOPry92;

	[CompilerGenerated]
	private string Nq8gGMq4HKD;

	[CompilerGenerated]
	private int zHGgG5E12Ys;

	[CompilerGenerated]
	private int jj7gGTtCATD;

	[CompilerGenerated]
	private int AqlgGxTuXFK;

	[CompilerGenerated]
	private string nJigGqf50Dg;

	internal static OverlapCoverageConditions YY2nb3KXAr8pErqmPbZp;

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("分析对象", "Analysis object")]
	public AnalysisOverlapObjType ObjType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AnalysisOverlapObjType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("扫频仪对比文件", "Scanner Comparison logfile")]
	[Browsable(true)]
	[Editor(typeof(UTSFileNameEditor), typeof(UITypeEditor))]
	public string ScannerLogFile
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
	public int ReSampleTime
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

	[MyDisplayName("最强小区RSRP>=", "Strongest cell RSRP>=")]
	public int MaxRSRP
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

	[MyDisplayName("其他小区与最强小区RSRP差值<=", "RSRP difference between other cells and strongest cells <=")]
	public int OtherCellRSRPDiff
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
	[MyDisplayName("过滤", "Filter")]
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
	public OverlapCoverageConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OverlapCoverageConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		BQ09EqKXqblHscAQqr7i();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YArFbIKXBw1xyEDFwhAV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lVxvL3KXt5dSWSVUsocf()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OverlapCoverageConditions eOAf2hKXWaDXnyGbeanS()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BQ09EqKXqblHscAQqr7i()
	{
	}
}
