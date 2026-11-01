using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using dxUNZOMUDbBh5fuai0V;

namespace AARRRC;

[XmlRoot("sections")]
[Description("设置该指标的统计分段")]
public class Sections : ICloneable
{
	[CompilerGenerated]
	private string BWea5CisMP;

	[CompilerGenerated]
	private string v9Qa8t4eHS;

	[CompilerGenerated]
	private string gupaRnCdS9;

	[CompilerGenerated]
	private List<Section> TB7ayIrjSw;

	[CompilerGenerated]
	private Format KiuaPrBo3B;

	internal static Sections QgcEDnr8EiMgu3812t7;

	[DisplayName("指标算法")]
	[XmlAttribute("algorithm")]
	[ReadOnly(true)]
	[Description("多个指标算法,用逗号分隔")]
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
	[XmlAttribute("ratio")]
	[DisplayName("缩放比例")]
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
		vtGQRUMm4d1W2wUluXg.oM3xgENyqS();
		DcgrBUrQ0AisVRgrDud();
		vkCgf6ryxopKAgH08lW();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NV4ZcMr9JoEjuI4MOZD()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Sections TEyOq1r6XukCRnCPMvO()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LkrYgcrFLIhHlokWOIP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nUBYWdrVmniWClmyVqr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oIq9Mkr2V5bbarhvS7w(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vn6jjWrhH2xilr80tCa(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DcgrBUrQ0AisVRgrDud()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vkCgf6ryxopKAgH08lW()
	{
	}
}
