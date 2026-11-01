using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[XmlRoot("sections")]
public class Sections : ICloneable
{
	[CompilerGenerated]
	private string Cj4Ry7YlUZN;

	[CompilerGenerated]
	private string hEMRyf6yMi7;

	[CompilerGenerated]
	private string aW6RyDo9Off;

	[CompilerGenerated]
	private List<Section> OhmRyBV1Iyc;

	[CompilerGenerated]
	private Format YIVRySYKPrw;

	internal static Sections l57xLR62zZEUvG2fHPrj;

	[ReadOnly(true)]
	[DisplayName("指标算法")]
	[Description("多个指标算法,用逗号分隔")]
	[XmlAttribute("algorithm")]
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

	[XmlAttribute("discrete")]
	[Browsable(false)]
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

	[DisplayName("分段阈值")]
	[XmlElement("section")]
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
	public Sections()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Sections()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dXQCyZ6JLXluvAhVye0J()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Sections bE0nm36JNffk5sxLaUZ1()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dfSfmF6JY8iSwbNDsRiQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ESRr4n6Ju2YWgSKuljdd(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EcAkd16JyVLDdpqvft6X()
	{
	}
}
