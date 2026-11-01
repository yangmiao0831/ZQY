using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class PilotPollutionConditions
{
	[XmlAttribute]
	public bool isscanner;

	[XmlAttribute]
	public string net;

	[XmlAttribute]
	public string signal;

	[XmlAttribute]
	public int type;

	[XmlAttribute]
	public string bin;

	[JsonIgnore]
	[XmlElement("sections")]
	public Sections Sections;

	[CompilerGenerated]
	private OverlapNetType w9EnzZQTgi7;

	[CompilerGenerated]
	private OverlapNetTypeScan TLcnzzfoqwW;

	[CompilerGenerated]
	private OverlapScanDataType PkxgCCsjI1Z;

	[CompilerGenerated]
	private string tYEgCG26KKB;

	[CompilerGenerated]
	private string Rj3gCRByQkW;

	[CompilerGenerated]
	private int u5lgCnaDA8P;

	[CompilerGenerated]
	private int aSNgCg1WiUG;

	[CompilerGenerated]
	private int vFUgCeGtGci;

	[CompilerGenerated]
	private int GyFgCPdyZf8;

	[CompilerGenerated]
	private continues NVEgCEWOWPr;

	[CompilerGenerated]
	private string A5ygCyf0tgN;

	internal static PilotPollutionConditions vdZsRvKmfrhCB1Ywbny8;

	[TypeConverter(typeof(EnumConverter))]
	[XmlIgnore]
	[MyDisplayName("网络", "NetType")]
	[Browsable(true)]
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
	[MyDisplayName("网络", "NetType")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public OverlapNetTypeScan netTypeScan
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
	[XmlIgnore]
	[Browsable(true)]
	[MyDisplayName("数据类型", "DataType")]
	public OverlapScanDataType dataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OverlapScanDataType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Editor(typeof(UTSFileNameEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("扫频仪文件", "Scanner logfile")]
	[XmlAttribute]
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

	[XmlIgnore]
	[XmlAttribute]
	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
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

	[MyDisplayName("所有信号RSRP>=", "All RSRP >=")]
	[XmlIgnore]
	[XmlAttribute]
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

	[MyDisplayName("与最强小区RSRP差值<=", "Difference between RSRP and the strongest cell <=")]
	[XmlAttribute]
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

	[MyDisplayName("重采样时长(s)", "Resample time(s)")]
	[XmlIgnore]
	[Browsable(true)]
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

	[MyDisplayName("满足条件小区个数>=", "Number of satisfied cells >=")]
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

	[TypeConverter(typeof(ExpandableObjectConverter))]
	[MyDisplayName("持续时长(s)", "Duration(s)")]
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
	public PilotPollutionConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PilotPollutionConditions(AnalysisType anaType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcParams(AnalysisType anaType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PilotPollutionConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		q8ROj7Km8DuyrV5fW4wT();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool N4WkSMKmjXrtUb8GnaeE()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PilotPollutionConditions BTmCbSKme8eM2rEBLERD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uMOOXrKm0Ru4jVIRvx57(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e3NH5oKmPyw0boairlBX(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kTp2OrKmcNg0da5mlWu5(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q8ROj7Km8DuyrV5fW4wT()
	{
	}
}
