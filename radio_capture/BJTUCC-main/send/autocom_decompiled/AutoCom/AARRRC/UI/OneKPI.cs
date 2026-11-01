using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Bo9yADzh1aAs7qp8Ya;
using BxXgGglndXknnRKjop1;
using LibCoord;
using LibUtils;
using MCEio5llPl0T40D36fu;
using XguwIblEVAqjQrbjRhW;
using nB1SiYl7AeVj00yr3Si;
using s7swmEl0yIarwjpKbZX;
using tcEeYRHYMSOOr5xhr11;

namespace AARRRC.UI;

[Serializable]
public class OneKPI
{
	public string CurSMode;

	public string CurBelongType;

	public string CurNetwork;

	public string CurGroup;

	public bool CurDisabled;

	public bool CurVisible;

	public KPIType KPIType;

	[XmlIgnore]
	public Tag CurTag;

	private OneKeyStr VHpGRIRFDmn;

	private StatAlgorithmList Yf7GRQATkEb;

	public string Name;

	[NonSerialized]
	public List<OneKeyStr> StatParamList;

	private AdvanceKPI cS8GRlwPAol;

	public RelationKPI RelationKPI;

	public KPIDetail KPIDetail;

	public string SQL;

	[CompilerGenerated]
	private string gFCGRwbHxjB;

	[CompilerGenerated]
	private OneKeyStr eDyGRp5qKFi;

	[CompilerGenerated]
	private OneKeyStr H5AGRapi3iJ;

	[CompilerGenerated]
	private ParamExpression enwGRky5mZ4;

	[CompilerGenerated]
	private ParamThresholds gpUGR0sRcdi;

	[CompilerGenerated]
	private MapCoverEventList MX1GRZc3cCH;

	[CompilerGenerated]
	private OutputResultList rV9GRzhm8cP;

	[CompilerGenerated]
	private ChartStyle EkOGnCPVTDp;

	[CompilerGenerated]
	private Border Ga9GnGukHlS;

	[CompilerGenerated]
	private ParamExpression SNhGnRkABUy;

	[CompilerGenerated]
	private ParamExpression mV1GnnBOtgh;

	[CompilerGenerated]
	private double LCcGngk8v3H;

	[CompilerGenerated]
	private double bf0GneG8mGD;

	[CompilerGenerated]
	private string zDwGnP2Lrwi;

	[CompilerGenerated]
	private static Predicate<string> yxjGnEgFw2N;

	private static OneKPI Q7sjRbY0CvH5nRQJWWNh;

	[MyDisplayName("指标名称", "KPI Name")]
	[Browsable(true)]
	public string Caption
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

	[Editor(typeof(HDFX5KCTID81CneDFB), typeof(UITypeEditor))]
	[MyDisplayName("统计参数", "Stat. parameter")]
	[Browsable(false)]
	public OneKeyStr StatParam
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

	[Browsable(true)]
	[MyDisplayName("统计算法", "Stat. algorithm")]
	[Editor(typeof(StatAlgorithmEditor), typeof(UITypeEditor))]
	public StatAlgorithmList StatAlgorithmList
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

	[Editor(typeof(UyGpXBlWMNYgsJZ3AW0), typeof(UITypeEditor))]
	[MyDisplayName("统计事件", "Statistics Event")]
	[Browsable(true)]
	public OneKeyStr StatParamEvent
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

	[Editor(typeof(x7nOgglKcm27hWNitEX), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("统计信令", "Statistics Message")]
	public OneKeyStr StatParamMsg
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

	[MyDisplayName("限制条件", "Limitations")]
	[Editor(typeof(mGAwjtlpWwOgWFkyv65), typeof(UITypeEditor))]
	[Browsable(false)]
	public ParamExpression Limitations
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

	[MyDisplayName("分段阈值", "Threshold")]
	[Editor(typeof(dsLe0el9feJen16vCHZ), typeof(UITypeEditor))]
	[Browsable(true)]
	public ParamThresholds Threshold
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

	[Editor(typeof(QxOF9LluIiGA2J6etif), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("覆盖事件", "Cover Event")]
	public MapCoverEventList EventList
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

	[MyDisplayName("分段输出结果", "Segmented output results")]
	[Editor(typeof(OutputResultEditorEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public OutputResultList OutputResultList
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

	[MyDisplayName("分段图表样式", "Chart style")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public ChartStyle ChartStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ChartStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("输出大小", "Size")]
	[Browsable(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public Border Border
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
	[Editor(typeof(mGAwjtlpWwOgWFkyv65), typeof(UITypeEditor))]
	[MyDisplayName("占比条件", "Numerator conditions")]
	public ParamExpression Numerator
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

	[MyDisplayName("分母条件", "Denominator condition")]
	[Editor(typeof(mGAwjtlpWwOgWFkyv65), typeof(UITypeEditor))]
	[Browsable(false)]
	public ParamExpression Denominator
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
	[MyDisplayName("边缘值(%)", "Edge value")]
	public double EdgeValue
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

	[Browsable(false)]
	[MyDisplayName("已有分组", "Group")]
	[XmlIgnore]
	public string StatGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[Browsable(true)]
	[TypeConverter(typeof(RatioDoubleConverter))]
	[MyDisplayName("指标放大比例", "Ratio")]
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

	[MyDisplayName("指标定义", "KPI Definition")]
	[Browsable(true)]
	public string ReMark
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

	[MyDisplayName("高级算法", "Advance")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Browsable(true)]
	public AdvanceKPI AdvanceKPI
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OneKPI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGroup(string sGroup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDescrip()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCaption(bool useAlgos = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAlogsString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFilterString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetBinString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetMultidimensionalString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetBelongType()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSMode()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsGroup(string group)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ParseFilterCondition(ref Restricts filter, ref bool isDescrip)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool vR0GRmKOZkN(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OneKPI()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		v9M2ftYP7MYkQwIFBR56();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UBecUhY0Hewr6H9lWu0G()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tJwh6yY0sd6uHsqZ4Rqw(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rolf8rY0nYFSHv4PSHGS()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OneKPI vJV2CoY0a4ZF8ygoW0WQ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VM7U17Y0ldUOXOdNyp3P(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FXPCe4Y09RdDncUssU04(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rVuen3Y0k9LZAQZ8f1NW(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hy4eVeY01ZMThxHkgDIn(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DyDYcLY0vIkQby9fbf2b(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ev9HpPY0SQwsgY8rCcFR(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I3Ie4mY0mCxYhXagPJOV(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hLkFKmY0ITEcwacTAr7P(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cgbVNZY0XgqdspJ7D6iW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xnH1LRY0U8sVOB2b46xy(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RBYKGqY0OU9DOQYe9M3A(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zotHfeY05VvCaIV0CSur(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UkBPaBY0iGYdZYxXjuCK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fJrCeLY0zXLOuQI1AFxb(int P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xZABbdYPLDEYpyut62Rq(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xlig7uYPN5uOguv6YVCl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HasBinEnum aDAYcMYPY4UlDIon2pDG(object P_0)
	{
		return (HasBinEnum)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BinType tZpYmaYPuHdIE87LmBxO(object P_0)
	{
		return (BinType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BinAlgorithm X6R2dZYPyobV7ehjS87k(object P_0)
	{
		return (BinAlgorithm)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pGQuTiYP6X3O8qJ9Qy5B(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int T8qGpKYP2puKO8WinXlT(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gGcfXoYPJ3pR0MdE10Fe(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DimensionCondition Yndn0ZYPMMAdUsjRKiN8(object P_0)
	{
		return (DimensionCondition)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yWOEpAYPK0c2s2PobHeu(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle qsMjdwYPZwqWFlSEONO7(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type pcDsmUYPoBKSI0PbNZRf(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TbPyebYPxIlm7c3xwITk(Type P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ypprASYPAK0x76SqLrtq(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oqwKTGYPtTpK6iUMXpT9(Type P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RDfqdWYPWtGfGWgFJ9ep(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PdBt3eYPBb8fvZHb5Ond(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RVJgeHYPqJ6GJCnZtgkt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m0xSK7YPEdJyvKplki58(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c0eofPYPVImcirtUMNMs(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QTJ5KcYPTiIN6kw22TTh(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w7x2lmYPp8kG0W2qGOJy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wyClMqYPQ66mJCjGkmoU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wAstmyYPRBAFP9XZS0GP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MEMFoGYPGZPFeMF8B7DA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XtQCS4YP30KPPDfiZKF4(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v3vppTYPF85OIqUOaq4x(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v9M2ftYP7MYkQwIFBR56()
	{
	}
}
