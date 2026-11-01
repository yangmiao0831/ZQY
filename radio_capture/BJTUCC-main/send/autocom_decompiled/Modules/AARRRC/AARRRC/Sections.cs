using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using s2FmbJbfsurLE2IsMMY;

namespace AARRRC;

[Description("设置该指标的统计分段")]
[XmlRoot("sections")]
public class Sections : ICloneable
{
	[CompilerGenerated]
	private string PEMDQx3DuJ;

	[CompilerGenerated]
	private string FZrDedXH0N;

	[CompilerGenerated]
	private string QydDkoe266;

	[CompilerGenerated]
	private List<Section> CxYDwDrdks;

	[CompilerGenerated]
	private Format UlsD8Z2Gbx;

	private static Sections TOh0xAL3ObwBYNKYonH;

	[Description("多个指标算法,用逗号分隔")]
	[ReadOnly(true)]
	[XmlAttribute("algorithm")]
	[DisplayName("指标算法")]
	public string Algorithm
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

	[Browsable(false)]
	[XmlAttribute("discrete")]
	public string Discrete
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

	[Description("最终输出为结果乘系数,针对每个指标均可设置,用逗号分隔")]
	[DisplayName("缩放比例")]
	[XmlAttribute("ratio")]
	public string Ratio
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

	[XmlElement("section")]
	[DisplayName("分段阈值")]
	public List<Section> SectionList
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

	[XmlElement("format")]
	public Format Format
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
	object ICloneable.Clone()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sections DeepClone()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyList(Sections src)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sections()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Sections()
	{
		sXe9tIbR1fUoYIaU9vk.PxtsPXOw24();
		XOSLSILJpjYw1JmYwfx();
		ebI4IoLlbvX9tY75wSx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iiWG4NLCcS7l9QuoSiY()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Sections fg4QoALpCbxIexBCMjf()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lnnvpWLjd0wLcay81b5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IfbMZRLT3k4P18sRmdT(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XOSLSILJpjYw1JmYwfx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RVyb7jLtmDdcMCbR2xR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ebI4IoLlbvX9tY75wSx()
	{
	}
}
