using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class NoServingCellConditions
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
	private OverlapNetType nVqnzWJpOrL;

	[CompilerGenerated]
	private OverlapDimension QnHnz4nMc2b;

	[CompilerGenerated]
	private OverlapBig mj4nzNtBc9d;

	[CompilerGenerated]
	private int IgDnzii9YTA;

	[CompilerGenerated]
	private int FPKnzFGwj6f;

	[CompilerGenerated]
	private int dMfnzbNOTdT;

	[CompilerGenerated]
	private continues oJFnzVI5xpo;

	[CompilerGenerated]
	private string qbsnzXTHMjh;

	[CompilerGenerated]
	private string Gcenz2U0CPU;

	internal static NoServingCellConditions WpwvCiKSrc9HrOomfcfV;

	[MyDisplayName("网络", "NetType")]
	[TypeConverter(typeof(EnumConverter))]
	[XmlIgnore]
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
	[MyDisplayName("分析维度", "Analysis dimension")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("所有信号RSRP", "all RSRP")]
	[XmlIgnore]
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

	[Browsable(true)]
	[DisplayName(" ")]
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
	[MyDisplayName("与最强RSRP差值<=", "difference between RSRP and the strongest <=")]
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

	[MyDisplayName("小区数量>=", "Cell count >=")]
	[XmlAttribute]
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

	[MyDisplayName("持续条件", "Continuous condition")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public continues continues
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

	[XmlAttribute]
	[MyDisplayName("基站数据库", "Site database")]
	[Browsable(true)]
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
	public NoServingCellConditions()
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
	static NoServingCellConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		CpoarcKSskmNB4P8eknF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bDCfsnKSCd2634nk82mA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mESQqjKSnFlKMn96bktU(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n5E4i9KSauVkcna8FW6g(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool klEJ1dKSDWaS4OVwcRN0()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NoServingCellConditions bXUknSKSdZGj415LGm4x()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W0EWQmKSHY7LRrMdE0Hf(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CpoarcKSskmNB4P8eknF()
	{
	}
}
