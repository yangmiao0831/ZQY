using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using Bo9yADzh1aAs7qp8Ya;
using DIB0ublJbyjEC3qMVIV;
using LibUtils;
using nB1SiYl7AeVj00yr3Si;
using s7swmEl0yIarwjpKbZX;
using tcEeYRHYMSOOr5xhr11;

namespace AARRRC.UI;

[Serializable]
public class OneSessionParam
{
	public string SQLStr;

	public SessionParamSelfCategory SelfCategory;

	[NonSerialized]
	public List<OneKeyStr> StatParamList;

	[CompilerGenerated]
	private string hUQGnAShUwj;

	[CompilerGenerated]
	private SessionParamType btKGnYEMhhH;

	[CompilerGenerated]
	private OneStrStr B0CGnHdCHTi;

	[CompilerGenerated]
	private SessionValueType rGbGn3o34g4;

	[CompilerGenerated]
	private OneKeyStr GiIGnJaUycy;

	[CompilerGenerated]
	private ParamAlgorithm Lr8Gnrv8rfi;

	[CompilerGenerated]
	private OneKeyStr F8YGn92JeZX;

	[CompilerGenerated]
	private OneKeyStr L1QGn8rgl1M;

	[CompilerGenerated]
	private SessionValueType c6dGnUDXcno;

	[CompilerGenerated]
	private OneKeyStr WTTGnKpPtXW;

	[CompilerGenerated]
	private OneKeyStr xZFGntukBkS;

	[CompilerGenerated]
	private OneKeyStr V2aGnuFvrRR;

	[CompilerGenerated]
	private SessionValueType Rc3Gno1LQLp;

	[CompilerGenerated]
	private OneKeyStr s8AGnjerLFg;

	[CompilerGenerated]
	private OneKeyStr FX9Gn7h6sBx;

	[CompilerGenerated]
	private OneKeyStr MWHGnf7jZ8H;

	[CompilerGenerated]
	private FindScopePoint irlGnD48OTa;

	[CompilerGenerated]
	private int s5bGnBug1Zo;

	[CompilerGenerated]
	private int Xh2GnSITiME;

	[CompilerGenerated]
	private int MHcGnm3JYky;

	[CompilerGenerated]
	private FindScopePoint DvgGnIPkrE6;

	[CompilerGenerated]
	private int oHyGnQiBd5N;

	[CompilerGenerated]
	private int dIcGnl6L18B;

	[CompilerGenerated]
	private int vKfGnw8UZnr;

	[CompilerGenerated]
	private TimeType sAxGnpC99Dl;

	[CompilerGenerated]
	private int fL0GnaPu1CR;

	[CompilerGenerated]
	private double qVAGnkEyRIN;

	[CompilerGenerated]
	private AdvanceDetail EM5Gn05Cfbd;

	internal static OneSessionParam Hnx7MBY8cXLPSJ3BBCN8;

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

	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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

	[Browsable(true)]
	[Editor(typeof(j7yIhvlxsL7M8hSfepy), typeof(UITypeEditor))]
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("取值类型", "Value Type")]
	[Browsable(true)]
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
	[Editor(typeof(HDFX5KCTID81CneDFB), typeof(UITypeEditor))]
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

	[MyDisplayName("参数算法", "Param algorithm")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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
	[Editor(typeof(UyGpXBlWMNYgsJZ3AW0), typeof(UITypeEditor))]
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
	[Editor(typeof(x7nOgglKcm27hWNitEX), typeof(UITypeEditor))]
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("时延计算起点类型", "Delay Start Point Type")]
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

	[Editor(typeof(UyGpXBlWMNYgsJZ3AW0), typeof(UITypeEditor))]
	[MyDisplayName("时延计算起点", "Delay Start Point")]
	[Browsable(true)]
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

	[Editor(typeof(x7nOgglKcm27hWNitEX), typeof(UITypeEditor))]
	[Browsable(true)]
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

	[Editor(typeof(HDFX5KCTID81CneDFB), typeof(UITypeEditor))]
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
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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

	[Editor(typeof(UyGpXBlWMNYgsJZ3AW0), typeof(UITypeEditor))]
	[MyDisplayName("时延计算终点", "Delay End Point")]
	[Browsable(true)]
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

	[Editor(typeof(x7nOgglKcm27hWNitEX), typeof(UITypeEditor))]
	[MyDisplayName("时延计算终点", "Delay End Point")]
	[Browsable(true)]
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

	[Editor(typeof(HDFX5KCTID81CneDFB), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("时延计算终点", "Delay End Point")]
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("查找范围起点", "Find the Start Point of Scope")]
	[Browsable(true)]
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

	[Browsable(true)]
	[MyDisplayName("下一次业务超限时长(s)", "Next session timeout(s)")]
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

	[MyDisplayName("上一次业务超限时长(s)", "Previous session timeout(s)")]
	[Browsable(true)]
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

	[MyDisplayName("查找范围终点", "Find the End Point of Scope")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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

	[MyDisplayName("上一次业务超限时长(s)", "Previous session timeout(s)")]
	[Browsable(true)]
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

	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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

	[Browsable(true)]
	[MyDisplayName("放大比例", "Ratio")]
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
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[MyDisplayName("高级算法", "Advance")]
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
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		eRP0wLY8hOdfnXwvLM05();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FwGlyCY88NdQmotUIXTJ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OneSessionParam NpGyfCY8wpMW0hQjtEf4()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eRP0wLY8hOdfnXwvLM05()
	{
	}
}
