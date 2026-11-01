using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using M1MKcg9ocwsPuLNWOAM;
using Newtonsoft.Json;
using VEcWZs9H5rSBmQZo5yC;
using hc5Ise9T3cImZd296H2;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class DifferenceConditions
{
	public const int TotalTimeID = 1;

	public const int TotalDistanceID = 2;

	public const int CoverRatioID = 999;

	[XmlAttribute]
	public string net;

	[XmlAttribute]
	public string basefile;

	[XmlAttribute]
	public int key;

	[XmlIgnore]
	public string binexpression;

	[XmlAttribute]
	public string bin;

	[JsonIgnore]
	[XmlElement("sections")]
	public Sections Sections;

	[XmlElement("fielditem")]
	public List<DiffrenceFieldItem> fielditem;

	[CompilerGenerated]
	private string B9AgCJx8iNT;

	[CompilerGenerated]
	private SelectedParamList IxvgCr0bPG8;

	[CompilerGenerated]
	private int z0agC9K6kxs;

	[CompilerGenerated]
	private string zkngC8e3Onj;

	[CompilerGenerated]
	private string JqygCUHPRXV;

	[CompilerGenerated]
	private OneKeyStr MxugCK8Hlmt;

	[CompilerGenerated]
	private ConditionsEnum vrVgCtVKqPq;

	[CompilerGenerated]
	private double thwgCu8THyE;

	[CompilerGenerated]
	private RelationshipEnum fASgCoiblDg;

	[CompilerGenerated]
	private OneKeyStr YyXgCjseoVv;

	[CompilerGenerated]
	private ConditionsEnum SvGgC7xMu2D;

	[CompilerGenerated]
	private double YjbgCfIs56N;

	private static DifferenceConditions lYexO7KmObAmBGNmkI5M;

	[MyDisplayName("优化前文件", "Comparison document")]
	[Editor(typeof(UTSFileNameEditor), typeof(UITypeEditor))]
	[XmlIgnore]
	public string beforefile
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

	[XmlIgnore]
	[Editor(typeof(UTSFileNameEditor), typeof(UITypeEditor))]
	[MyDisplayName("优化后文件", "Comparison document")]
	public string afterfile
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
	[Editor(typeof(J4Xb8n9wqLISvQ5AFRV), typeof(UITypeEditor))]
	[MyDisplayName("对比参数", "Contrast parameter")]
	public SelectedParamList Param
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
	[MyDisplayName("栅格大小(m)", "Bin size (m)")]
	public int binsize
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

	[XmlIgnore]
	[MyDisplayName("自定义参数名", "Custom parameter Name")]
	public string CustomParamName
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
	[Editor(typeof(RHhxJG98flxLxdCo6tN), typeof(UITypeEditor))]
	[MyDisplayName("参数1", "parameter1")]
	public OneKeyStr Param1
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

	[MyDisplayName(" ", " ")]
	[TypeConverter(typeof(EnumConverter))]
	[XmlIgnore]
	public ConditionsEnum Symbol1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ConditionsEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	[MyDisplayName("值1", "Value1")]
	public double Value1
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

	[MyDisplayName("关系", "Relationship")]
	[XmlIgnore]
	[TypeConverter(typeof(EnumConverter))]
	public RelationshipEnum Relationship
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RelationshipEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("参数2", "parameter2")]
	[XmlIgnore]
	[Editor(typeof(RHhxJG98flxLxdCo6tN), typeof(UITypeEditor))]
	public OneKeyStr Param2
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
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName(" ", " ")]
	public ConditionsEnum Symbol2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ConditionsEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlIgnore]
	[MyDisplayName("值2", "Value2")]
	public double Value2
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DifferenceConditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuildParamList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DifferenceConditions()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		EsQw7VKIZDVcDGsZ1woq();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RT8BpXKmzTZlcUGHFhj6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fxD3niKILFUJcnKkDgw3(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qhZxcJKINCuutHot5KXA(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lk7lmAKm5jJnROVQerAk()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DifferenceConditions PkjDZ4KminkJygFLh0VK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uSORR9KIYQ3FNWgAkFfB(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Py7oXcKIuqbwZMTQBZOZ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ak23RyKIyE4eaM3HE7pZ(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void COKs3iKI6Fj8MasWjc2f(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xUnWIAKI2wKiUZgTHueP(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bmQMsRKIJLNyI47H7rZZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pKXPKPKIMEU5blxK2K4x(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CcAN7MKIK5MsLcYuUCXC(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EsQw7VKIZDVcDGsZ1woq()
	{
	}
}
