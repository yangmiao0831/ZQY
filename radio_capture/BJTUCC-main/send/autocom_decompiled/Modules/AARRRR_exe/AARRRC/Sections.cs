using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using oCybKoWDu9IHQoL5yD1;

namespace AARRRC;

[XmlRoot("sections")]
[Description("设置该指标的统计分段")]
public class Sections : ICloneable
{
	[CompilerGenerated]
	private string ercHZY04xk;

	[CompilerGenerated]
	private string IZbHlpEyfx;

	[CompilerGenerated]
	private string ke3HbpQm64;

	[CompilerGenerated]
	private List<Section> Jp3HX7Zr4b;

	[CompilerGenerated]
	private Format jwrHvYyQYL;

	internal static Sections pj33Ixh6cwHb3oW0pFR;

	[XmlAttribute("algorithm")]
	[Description("多个指标算法,用逗号分隔")]
	[ReadOnly(true)]
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

	[XmlAttribute("ratio")]
	[DisplayName("缩放比例")]
	[Description("最终输出为结果乘系数,针对每个指标均可设置,用逗号分隔")]
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
	internal static bool WmnRjBhfCfrBKxxY5GP()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Sections p6bMeJhtpVYUuFFn5SH()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PGrVBAhqwjqd75iWAGX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vkXtVAhvY6kobTC71qK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wJGWnchE8GmEnYp8aAX(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZaG8rh7dBWD6oGjueC()
	{
	}

	static Sections()
	{
		ELS6x2WnjimODHR4fav.Vr5s9aKKNq();
	}
}
