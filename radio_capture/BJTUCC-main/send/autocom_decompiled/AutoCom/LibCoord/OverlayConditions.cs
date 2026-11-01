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

public class OverlayConditions
{
	public List<string> AnalysisLogfiles;

	private string YErnzOJPXiI;

	[XmlAttribute]
	public string net;

	[XmlAttribute]
	public string beam;

	[XmlAttribute]
	public string signal;

	[XmlAttribute]
	public string sinr;

	[XmlAttribute]
	public string distance;

	[XmlAttribute]
	public string angle;

	[XmlAttribute]
	public string disdiff;

	[XmlAttribute]
	public bool bycell;

	[XmlElement("sections")]
	[JsonIgnore]
	public Sections Sections;

	[CompilerGenerated]
	private OverlapNetType kQBnzMeI6lF;

	[CompilerGenerated]
	private OverlapRSRP y4snz5AuMCV;

	[CompilerGenerated]
	private int idKnzTWTaNI;

	[CompilerGenerated]
	private int psQnzxaSIHm;

	[CompilerGenerated]
	private int aDbnzqrJBva;

	[CompilerGenerated]
	private int nRdnzA29bRJ;

	[CompilerGenerated]
	private int mGTnzYRYNlS;

	[CompilerGenerated]
	private continuesEx IfWnzHOSGIl;

	[CompilerGenerated]
	private string daunz357R7Q;

	[CompilerGenerated]
	private string neinzJlkiPG;

	[CompilerGenerated]
	private DistrictLevel lunnzr2FTv1;

	private static OverlayConditions VinCx8KSlpdX4eUQ7OZf;

	[XmlIgnore]
	[Editor(typeof(MultiSelectFileNameEditor), typeof(UITypeEditor))]
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
	[MyDisplayName("网络类型", "NetType")]
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
	[Browsable(true)]
	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
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

	[DisplayName("RSRP>=")]
	[XmlIgnore]
	[Browsable(true)]
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
	[XmlIgnore]
	[Browsable(true)]
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

	[Browsable(true)]
	[XmlIgnore]
	[MyDisplayName("服务小区连线距离>=", "Service cell Distance >=")]
	public int mindistance
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
	[MyDisplayName("服务小区连线距离与所有邻区连线距离的差值>=", "Difference between Service cell distance and neighbor cell distance>=")]
	public int minDiff
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
	[MyDisplayName("覆盖角度偏移度>=", "Coverage angle offset >=")]
	public int minangle
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

	[TypeConverter(typeof(ExpandableObjectConverter))]
	[MyDisplayName("持续条件", "Continuous condition")]
	[Browsable(true)]
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
	[MyDisplayName("基站数据库", "Site database")]
	[XmlAttribute]
	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
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

	[Browsable(true)]
	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
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
	public OverlayConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OverlayConditions(AnalysisType anaType)
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
	static OverlayConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		cNB160KSUhoaW5diGkZH();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oToyA2KS1cbQMwhEuBMh()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gbo5XAKS9mXaHYGe3eUn()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OverlayConditions nKvJa7KSksSHDXBO85VX()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QnLRDjKSv9HZOJQC0wEV(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GLkpZAKSSrY5MlKW19Dc(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SE7AYJKSm388fvdMlvql(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dCMXI6KSIKEl1XA8rFfb(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SXNgbNKSXC9UZUye1BLX(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cNB160KSUhoaW5diGkZH()
	{
	}
}
