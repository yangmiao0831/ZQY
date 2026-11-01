using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class DualModeConditions
{
	public List<string> SAFiles;

	private string z98nzvVAYm7;

	public List<string> NSAFiles;

	private string ox8nzsD1VbE;

	[CompilerGenerated]
	private DualModeSiteAnalysis_Type RIUnz6IEg9s;

	[CompilerGenerated]
	private int bI8nzhGyI32;

	[CompilerGenerated]
	private string ffHnz1Qw3SU;

	[CompilerGenerated]
	private string pQnnzdJ5o9W;

	internal static DualModeConditions Mnhd6KKSPA9a9DdnX50O;

	[TypeConverter(typeof(EnumConverter))]
	[XmlAttribute]
	[MyDisplayName("数据类型", "DataType")]
	public DualModeSiteAnalysis_Type AnalysisType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DualModeSiteAnalysis_Type)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlAttribute]
	[MyDisplayName("SA数据", "SA Data")]
	[Browsable(true)]
	[Editor(typeof(MultiSelectFileNameEditor), typeof(UITypeEditor))]
	public string StrSAFiles
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

	[MyDisplayName("NSA数据", "NSA Data")]
	[Browsable(true)]
	[Editor(typeof(MultiSelectFileNameEditor), typeof(UITypeEditor))]
	[XmlAttribute]
	public string StrNSAFiles
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

	[XmlAttribute]
	[MyDisplayName("NR小区覆盖距离(米)", "NR cell signal cover distance")]
	[Browsable(true)]
	public int NRSignalCoverDistance
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

	[MyDisplayName("NR基站数据库", "NR Site database")]
	[XmlAttribute]
	[Browsable(true)]
	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
	public string NRSiteFile
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
	[Editor(typeof(SiteFileNameEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("LTE基站数据库", "LTE Site database")]
	public string LTESiteFile
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
	public DualModeConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DualModeConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jerPZoKSw12ZW21GalSE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MYmlWnKScUhYQBHtWwte()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DualModeConditions jmuTnMKS8LqFvbAhfXQb()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fiy97sKShJ6cN1rQxXXc(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FPXZByKS4Tt2X3O7u65e(object P_0)
	{
		return true;
	}
}
