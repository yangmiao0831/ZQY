using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using FI7vimPDF95x6M7yQsS;
using I1FfyGPt8uNMV9Ht927;
using JVTWaBPo3XJq5udDlio;
using M7yyJ5PU0yjGluuUF7Y;
using s2FmbJbfsurLE2IsMMY;

namespace AARRRC.UI;

[Serializable]
public class OneSessionParam
{
	public string SQLStr;

	public SessionParamSelfCategory SelfCategory;

	[CompilerGenerated]
	private string pv5XaToxll;

	[CompilerGenerated]
	private SessionParamType RZyXYhwgGj;

	[CompilerGenerated]
	private OneStrStr f98XQ2JnqW;

	[CompilerGenerated]
	private SessionValueType xOGXe3SrcO;

	[CompilerGenerated]
	private OneKeyStr XZfXkA9E4N;

	[NonSerialized]
	public List<OneKeyStr> StatParamList;

	[CompilerGenerated]
	private ParamAlgorithm tE6XwWEoHj;

	[CompilerGenerated]
	private OneKeyStr PU4X8NJbfc;

	[CompilerGenerated]
	private OneKeyStr zGXXhkpE9w;

	[CompilerGenerated]
	private SessionValueType NTdXuKBU51;

	[CompilerGenerated]
	private OneKeyStr q2SXG3t3AE;

	[CompilerGenerated]
	private OneKeyStr WFeXHFhG81;

	[CompilerGenerated]
	private OneKeyStr SLAXqZ166h;

	[CompilerGenerated]
	private SessionValueType yCwXOYl64U;

	[CompilerGenerated]
	private OneKeyStr BSnXFy7nSQ;

	[CompilerGenerated]
	private OneKeyStr mVtX9NeRlj;

	[CompilerGenerated]
	private OneKeyStr EknXBXTHls;

	[CompilerGenerated]
	private FindScopePoint AmwX3WJspQ;

	[CompilerGenerated]
	private int SNVXzBGekb;

	[CompilerGenerated]
	private int G88UWYjgod;

	[CompilerGenerated]
	private int BMTUP1InpB;

	[CompilerGenerated]
	private FindScopePoint C12UDgMDpP;

	[CompilerGenerated]
	private int CmuUbZukgS;

	[CompilerGenerated]
	private int dDQUpxt0RU;

	[CompilerGenerated]
	private int unrUxatTDU;

	[CompilerGenerated]
	private TimeType n3eUV41r1O;

	[CompilerGenerated]
	private int CKkUXkk7tM;

	[CompilerGenerated]
	private double yMaUU9wEuG;

	[CompilerGenerated]
	private AdvanceDetail HT1UdFUmil;

	private static OneSessionParam gxZXhRtFb2fjTI0SOJQ;

	[MyDisplayName("参数名称", "Param Caption")]
	public string ParamCaption
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("参数类型", "Param Type")]
	public SessionParamType SessionParamType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SessionParamType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Editor(typeof(sRbsmCP7hIYQqPYpKWd), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("业务属性", "Session Property")]
	public OneStrStr SessionProperty
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
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("取值类型", "Value Type")]
	public SessionValueType TimeValueType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SessionValueType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("取值参数", "Parameter")]
	[Editor(typeof(fPttnePPaOMXb1E5t0c), typeof(UITypeEditor))]
	[Browsable(true)]
	public OneKeyStr StatParam
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("参数算法", "Param algorithm")]
	[Browsable(true)]
	public ParamAlgorithm ParamAlgorithm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ParamAlgorithm)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("取值事件", "Select Event")]
	[Browsable(true)]
	[Editor(typeof(qCBpDVPX8C1R0VrXK3g), typeof(UITypeEditor))]
	public OneKeyStr SelectEvent
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

	[MyDisplayName("取值信令", "Select Message")]
	[Browsable(true)]
	[Editor(typeof(miTKiuPfchdt8dC1Vk0), typeof(UITypeEditor))]
	public OneKeyStr SelectMsg
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

	[MyDisplayName("时延计算起点类型", "Delay Start Point Type")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	public SessionValueType DelayStartValueType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SessionValueType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[Editor(typeof(qCBpDVPX8C1R0VrXK3g), typeof(UITypeEditor))]
	[MyDisplayName("时延计算起点", "Delay Start Point")]
	public OneKeyStr DelayStartEvent
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
	[Editor(typeof(miTKiuPfchdt8dC1Vk0), typeof(UITypeEditor))]
	[MyDisplayName("时延计算起点", "Delay Start Point")]
	public OneKeyStr DelayStartMsg
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

	[Editor(typeof(fPttnePPaOMXb1E5t0c), typeof(UITypeEditor))]
	[MyDisplayName("时延计算起点", "Delay Start Point")]
	[Browsable(true)]
	public OneKeyStr DelayStartParam
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

	[MyDisplayName("时延计算终点类型", "Delay End Point Type")]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public SessionValueType DelayEndValueType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SessionValueType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[Editor(typeof(qCBpDVPX8C1R0VrXK3g), typeof(UITypeEditor))]
	[MyDisplayName("时延计算终点", "Delay End Point")]
	public OneKeyStr DelayEndEvent
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
	[Editor(typeof(miTKiuPfchdt8dC1Vk0), typeof(UITypeEditor))]
	[MyDisplayName("时延计算终点", "Delay End Point")]
	public OneKeyStr DelayEndMsg
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

	[MyDisplayName("时延计算终点", "Delay End Point")]
	[Editor(typeof(fPttnePPaOMXb1E5t0c), typeof(UITypeEditor))]
	[Browsable(true)]
	public OneKeyStr DelayEndParam
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

	[MyDisplayName("查找范围起点", "Find the Start Point of Scope")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	public FindScopePoint FindScopeStartPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FindScopePoint)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("采样点偏移量", "Point Offset")]
	public int StartPointOffset
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

	[MyDisplayName("下一次业务超限时长(s)", "Next session timeout(s)")]
	[Browsable(true)]
	public int StartNextSessionTimeout
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

	[Browsable(true)]
	[MyDisplayName("上一次业务超限时长(s)", "Previous session timeout(s)")]
	public int StartEndSessionTimeout
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

	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("查找范围终点", "Find the End Point of Scope")]
	public FindScopePoint FindScopeEndPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FindScopePoint)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("采样点偏移量", "Point Offset")]
	public int EndPointOffset
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

	[Browsable(true)]
	[MyDisplayName("下一次业务超限时长(s)", "Next session timeout(s)")]
	public int EndNextSessionTimeout
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

	[Browsable(true)]
	[MyDisplayName("上一次业务超限时长(s)", "Previous session timeout(s)")]
	public int EndEndSessionTimeout
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("时间类型", "Time Type")]
	public TimeType TimeType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TimeType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("时延限制时长(ms)", "Delay Limited Time(ms)")]
	[Browsable(true)]
	public int DelayLimitedTime
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

	[MyDisplayName("放大比例", "Ratio")]
	[Browsable(true)]
	public double Ratio
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

	[Browsable(true)]
	[MyDisplayName("高级算法", "Advance")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public AdvanceDetail AdvanceDetail
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
	public OneSessionParam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OneSessionParam()
	{
		sXe9tIbR1fUoYIaU9vk.PxtsPXOw24();
		k26QoHtcHUcBT5sVyXW();
		QnsnSWtmEULlP9nkQMc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k26QoHtcHUcBT5sVyXW()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IEqO2FtM7N6myvI0Yit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EwiOEjt7RIcjViEoduy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OneSessionParam S7dcgOtno9PvacEI1la()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QnsnSWtmEULlP9nkQMc()
	{
	}
}
