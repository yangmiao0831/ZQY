using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class PenetrationConditions
{
	[XmlAttribute]
	public string roadfile;

	[CompilerGenerated]
	private List<OneKeyStr> wDagC2bqE2b;

	[CompilerGenerated]
	private List<OneKeyStr> CvNgCO3gmKB;

	[CompilerGenerated]
	private int MnlgCMLZvuD;

	private static PenetrationConditions kl3ULjKmlSuHC9Taa0Ev;

	[XmlIgnore]
	[Editor(typeof(SelectSafFileAndFolderEditor), typeof(UITypeEditor))]
	[MyDisplayName("分析数据", "Analysis Logfile")]
	public List<OneKeyStr> AnalysisLogfile
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
	[MyDisplayName("离线图层", "Mapinfo Layer")]
	[Editor(typeof(SelectTabFileAndFolderEditor), typeof(UITypeEditor))]
	public List<OneKeyStr> MapinfoLayer
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

	[MyDisplayName("重复道路系数", "Repeated road coefficient")]
	[XmlAttribute]
	public int repeatcount
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PenetrationConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PenetrationConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YNMUL6Km1I2opmxDHduT()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vu57VaKm9Jno8fcAhcZD()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PenetrationConditions aWlN1KKmkiSYqmTJsxUn()
	{
		return null;
	}
}
