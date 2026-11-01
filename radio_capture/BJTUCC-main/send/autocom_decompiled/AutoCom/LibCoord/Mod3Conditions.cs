using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class Mod3Conditions
{
	[XmlAttribute]
	public bool isscanner;

	[XmlAttribute]
	public string net;

	[CompilerGenerated]
	private OverlapNetType NkfgC56sok2;

	[CompilerGenerated]
	private AnaLogfileType oOsgCT904ID;

	[CompilerGenerated]
	private double qMFgCxAIa2F;

	[CompilerGenerated]
	private int vr7gCqw9Kac;

	[CompilerGenerated]
	private double U1pgCAsGEbB;

	[CompilerGenerated]
	private continuesEx ucWgCYK4LL8;

	[CompilerGenerated]
	private string hUJgCHSnh6N;

	[CompilerGenerated]
	private string n5tgC3OWooa;

	private static Mod3Conditions PmJD9pKmveHqE0VJyNgu;

	[XmlAttribute]
	[TypeConverter(typeof(EnumConverter))]
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

	[XmlAttribute]
	[MyDisplayName("数据类型", "Logfile Type")]
	[TypeConverter(typeof(EnumConverter))]
	public AnaLogfileType LogfileType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AnaLogfileType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("RSRP>=")]
	[XmlAttribute]
	public double minsignal
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

	[XmlAttribute]
	[DisplayName("MOD")]
	public int mode
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
	[MyDisplayName("与服务小区RSRP差值<=", "Difference between RSRP and service cell <=")]
	public double diff
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

	[MyDisplayName("持续条件", "Continuous condition")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
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
	public Mod3Conditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcParams()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Mod3Conditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		MqrkAAKmUOCYIpnp14YW();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nQtvHAKmIkTO0lbLxLtO(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DHJsfdKmSHnH8g9IcPs3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Mod3Conditions vc1kuhKmmiJ3ahtFTwBT()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KE7Q0yKmXtvFAjjna9ha(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MqrkAAKmUOCYIpnp14YW()
	{
	}
}
