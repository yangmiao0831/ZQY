using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevExpress.XtraBars;
using LibBase;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class StaticticsWin : CoordinateWin
{
	protected FastObjectListView lvItem;

	protected StaticticsType CurStaticticsType;

	protected int CurParamKey;

	public ParamKPIDetail ParamKPIWin;

	protected List<StatParamResult> StatParamResults;

	protected List<double> WorestValueList;

	protected TimeSpan LogfileTimeSpan;

	protected StatParamKPIConfig StatParamConfig;

	protected StatEventKPIConfig StatEventConfig;

	protected StatMsgKPIConfig StatMsgConfig;

	protected StatSessionKPIConfig StatSessionConfig;

	protected bool EventBeforeAfterMeasMode;

	protected int EventBeforePointIdx;

	protected int EventAfterPointIdx;

	protected int EventCurPointIdx;

	protected string StartTimeCondition;

	protected string StopTimeCondition;

	private int mAOgs5Jicqr;

	private int nIhgsTVXSt9;

	private bool LiQgsxHSBIW;

	private bool HKmgsqiwZDa;

	private List<Logfile> UyqgsA3LJ2Z;

	private IContainer N8hgsY2oRXW;

	private FlatButton nyPgsH8Ma5U;

	private FlatButton u0hgs3hYrb0;

	private FlatButton QOcgsJqobsU;

	private Panel xdAgsrWqJjP;

	private FlatButton Dkogs9jqnv2;

	private FlatButton YvTgs8IfoUA;

	private FlatButton Gr7gsU12Rvj;

	private FlatButton m9xgsKplvbQ;

	private PopupMenu Ghmgstbrpay;

	private BarButtonItem ir1gsuIaU4M;

	private BarButtonItem hbhgso3ehg9;

	private BarManager iUIgsjuXJy1;

	private BarDockControl tmIgs7WnHtb;

	private BarDockControl C5ggsfM7seT;

	private BarDockControl v88gsDMq0KN;

	private BarDockControl eZ1gsBt9Pem;

	protected BarCheckItem bciShowBeforeAfterCol;

	private BarButtonItem iyOgsSAHTc5;

	private BarButtonItem H9IgsmvWPsJ;

	private Panel Yy9gsI7gQWt;

	private FlatButton lllgsQYgMQm;

	private Label edmgslQwUPv;

	private FlatButton U1TgswZnsGy;

	protected Timer timerRefresh;

	public FlatTabControl tcStatType;

	private BarSubItem LiNgspSqCt2;

	private BarButtonItem qlHgsakCl1v;

	[CompilerGenerated]
	private static Comparison<double> jBhgskGsldC;

	[CompilerGenerated]
	private static AspectGetterDelegate SsOgs0pwyvo;

	[CompilerGenerated]
	private static AspectGetterDelegate DoggsZfPvYH;

	private static StaticticsWin K3MCcpZe05HaujON31Am;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StaticticsWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void scjgvH231JP()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void p8Qgv3S721p(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void LoadWinKeyStrFile(string sFile = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStatType(StaticticsType type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshParamKPIDetailAfterThresholdChange()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEventBeforeAfterMeasMode(int beforePointIdx, int afterPointIdx, int eventPointIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitVarsEvent(string sFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitVarsMsg(string sFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitVarsParam(string sFile, bool forceLoadFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hutgvJeLJtS(string P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitVars(string sFile = "", bool forceLoadFile = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BkqgvrDKssd(OneFilter P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Y8ugv9WHjHl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool lJFgv8mGFFY(OneBin P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Win_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCloseClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClosed(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KsUgvUyf9mm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void X8MgvKCnyeN(object P_0, OlvDropEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VuJgvtWca7n(object P_0, OlvDropEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vFmgvusacf1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cJ0gvoVuqpG(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoStatParam(int paramCode, bool forceStat = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void r5EgvjXwPsB(OneStatSessionDB P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gv7gv7EGZOC(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HZwgvfNL7Tp(int P_0, bool P_1 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qVLgvDoO4DZ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uFHgvBu6B7D(List<int> P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aI2gvSg2sIC(List<int> P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoLoadIEsParam(List<OneKeyStr> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void awdgvmRSuXM(List<OneKeyStr> P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAfterSelectIE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tbLgvIso1bM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gnjgvQEuhyg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void G4MgvlJYlxv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void S7egvw2o6xV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hSxgvpsv7DN(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Kbjgvacv6l8(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wZfgvku4q0X()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string GetParamName(int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string GetParamValue(int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoLoadLvItemsParam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoLoadLvItemsEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string X9Dgv0Vy076(int P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoLoadLvItemsMsg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QpRgvZCwmBt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string FnQgvzrYY6R(OneStatSessionDB P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string xZxgsCqfcN8(OneStatSessionDB P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mg4gsG22O1l()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WaUgsRPP97Q()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uiTgsnT9l84(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HscgsgNiMmW(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoStaticCurrent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RRngsehm2Q1(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fMcgsPXHUyO(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yoTgsEskT4R(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YBGgsyELXNQ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mAugscFPSgV(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dblgsLoSGSL(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void W2RgsvEmC1Q()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uv2gssaFaaO(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mcJgs6Zu3jy(object P_0, ItemDragEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Uv9gshd7Yae(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RpKgs15Mcid(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pmtgsdeYtw4(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool GetBottomPanelVisible()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetControlDisplay(bool display)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nDggsWIpSSd(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WlSgs4QZfny()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static int VGAgsNjtsOf(double P_0, double P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private object bd1gsiGiyow(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private object uvVgsFWlvH3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object AyOgsbNO79U(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private object rtogsVtNE0S(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object D9OgsXnyeMs(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private object kO6gs2C8G6m(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private object lf3gsOArwZA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private object W8xgsMxIcfY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StaticticsWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		TBghRDZ8NAhb6EcrELN9();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JbIspaZe8jX9GgkmA2Tm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TksbqnZewrG6DANy7Fdu(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool x6ORatZeP0TKthi3wFrP()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StaticticsWin iiMmcIZecnXjctHFphW7()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GdbnO2Zeh4Blg2unDTMf()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CgRGVDZe4FGDbvel0Jmy(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c4jqF9ZerGsnVv4WtvPL(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void shMCFFZeDtoPYwS2nVrk(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LSJHfbZedQiSp8VuDZXR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool umeRpHZeC9gIv2jjoQWN(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zrbjIQZenZ0mxPASYP0X(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SdaGu7ZeaR9sfB5tQSiF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YwOhLfZeHGIcsVa80q3E(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HKwLslZesGbELTqWURBQ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void REGEhgZelMYYodkI0gjb(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RcKJ2mZe98XO8J0GWENa(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NetType HyfEBoZekq9cXm5tn8Z2(object P_0)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YH7gO6Ze12HYl3GSRf6e(int P_0, NetType P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BEwRhhZevMfZPNC2IgTy(object P_0, object P_1, object P_2, object P_3, int paramCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void br4tqSZeSvQxj28fMjHS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int K0pPSJZemgeITrhsCBnA(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uJ935iZeIefB5mO69UTM(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nkPMjSZeXR4dRraRRX8A(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PofcCpZeUoW4nLy4Av7I(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jjhmxqZeOjyhBbS1oQQR(object P_0, object P_1, bool forceLoadFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JrbXRUZe5r5kIcEmu1ec(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cN0TdiZeipx2yPJUZalC(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t4cNjBZezqFvvsoD0Gt0(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ProgressResult drkgE5Z0LPk1PlcQlmRo(object P_0, object P_1)
	{
		return (ProgressResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oIsICnZ0Nk0kIZKgsSoA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PHhpWvZ0YL5KvWh2CAVm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type EYL3ltZ0unCUwYhM6QVZ(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oSFZOjZ0yYmv2OBg3gQ2(object P_0, Type P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle X6RGtxZ06NmYWkxbR909(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f1ZbQPZ02pO2x77lTxFH(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J1BBHiZ0JQhd7NBPTIL5(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void whnGsPZ0M0tGpmi3TDiE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zxmQXdZ0KUtOlIfO5yPr(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cISg5wZ0ZwL6P8tkQ3ix(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NkUqpuZ0oBXswik1IB0G(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q3i1l3Z0xKt6tpigtTQ8(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lAA059Z0Av8p5TjeMOS3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NAv66HZ0t3AXWK6NtImA(object P_0, ColumnHeaderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wAPZWvZ0W6xBde19muyq(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KTKFIcZ0BChQF28ZEFk7(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zvIWLOZ0qX19TXQsv6FY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P0vk7vZ0EUtnKgUYRnbT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n9lIoBZ0Vo29Ph4OW2LP(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mSl2MeZ0TQxR4VqCKP0K(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sYwDiyZ0pOTCFSpnF5Bl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Y3wlEkZ0Q468Zh1N1kEE(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HdOrhTZ0RkZxyFRICG6i(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gvg4iPZ0GPM94Lruk3y7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nYgv2hZ03oObFT2mqlUF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lGQy3XZ0FW8CUA2RC935(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MVU0FZZ07pHXF9aMUyVT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ef9T79Z0bhWQEV5mOJr6(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MA7VbvZ0gBdqJ9lXdH2C()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ecJLpOZ0fQaDLfmK1RSc(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tx4ZQUZ0jGZoAcKs2Y4B(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KIHJSOZ0e6spFLvbJple(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rfokStZ00iOpKY1BhhG2(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid Dx1DeQZ0PpK5R6VcbVwM()
	{
		return (Guid)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yxpoe7Z0cWgsf4dB5DW9(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KUYcpEZ082uEAc9vUsj3(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int X4xkuKZ0wrfZSuVkH3Re(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void In46uwZ0hxmSTQ22JkgP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Wmao7DZ04jNpkf0xo7pa(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cNc9iUZ0rh25g2lDdSQL(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Y9j0DrZ0DksoiAd1vn1s(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lubZTeZ0dKWZ8Zy9Pulb(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XoPulwZ0Ccml4M1ahvlf(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime bY7g42Z0n0TAbFtF4ixO(object P_0, int P_1)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LGNYAHZ0aIAp1mBOwXwF(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan vT1Rk2Z0Hp1lOFidpFVJ(TimeSpan P_0, TimeSpan P_1)
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xty1BuZ0sbhENWvl8J3H(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DlNcPRZ0lPRFv3mHpOsd(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr eIBvLgZ09aSWcVYa2oGr(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ePZHb8Z0kOZnEambkVET(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double l6IjuXZ01Kl3ZunnHDI9(double P_0, double P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ocrOYXZ0vBvvLZAOlMFN(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint FFduK7Z0S0frigIFJWGB(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FfVf4yZ0m6CIM0VpGNxr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lOmbknZ0I2nN5b1n0YoN()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int adVh3WZ0XtWkw3ygw8W3(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o3emqeZ0Uhe3FruxP59b(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i8wXHDZ0OkUuBYGOuVdu(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jjLZqcZ05Rtpru1TVHqM(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G1eTrCZ0i70i5rbiNBb1(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mKt3mJZ0ztWT3eslWvOd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ubF1qeZPLcV0CINbJ8Yv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YAqiNJZPNhGd2GG4Jdit(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kNj99bZPYBhxsUWajlRM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aTKeKwZPuwbxdIfyb0Xf(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sNH0skZPylkaBGcw8jx9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g8cJFCZP6NykrLE1H81s(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ParamType HHR2OZZP2m8T0wmDtKsK(int P_0)
	{
		return (ParamType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object psPtClZPJ3HpOMxH88xA(double P_0, sbyte P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KmQCk7ZPMYrxHfHJG0JT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GvLvxkZPKhQNOM09MQEa(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yCVLpsZPZAeMF2cKdkIW(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z7VXrcZPoofO9eniNbVg(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kItY1LZPxsBwhRr5snmp(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O4ZkhgZPAV8Lq2M5N75O(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double TYGsUxZPtBCYDrZsdtc4(object P_0, int P_1, object P_2, object P_3)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BUpNi0ZPWR6VAe00XfTj(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a8KF9VZPBv6vHOKw36cr(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l1Ks8FZPqdwnWCv2NyPo(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kKmX08ZPEHoxGWMTotjJ(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G2LInLZPV8Q0TC2uB8De()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JguTirZPTOEbHS6B5tSm(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o0hwMSZPpTY8KsxrYfeR(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hP9mgoZPQiZEN6rhTl9s(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wZ94wBZPR3po7JVA3X9c(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ngg6J7ZPGd2ronsusSpB(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult cHPwJNZP3bZbZkO0xKsr(object P_0, MessageBoxButtons btns)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kx9uJCZPFpfMOQJXSP67(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ndpo0hZP7pGUtXEu5NDZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f1lgW5ZPbgi3GQJbx3I5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cAUeeeZPgtHXTV9Gd9Bx(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ocIuBpZPfFnilW4ckT7U(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YTHOl4ZPjjLy5upomfFl(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RycbmiZPel7CjtXiybNK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C2N1dSZP0qU5iS58f1cd(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bf9Iy3ZPPlV0ArUaL8hD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lxnq7qZPc8h78pytTQcw(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rCaHvsZP8PvpCkxJ8jYf(object P_0, int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bS6kMDZPw8pj2wQugvbK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eMkg5SZPhIC70UbkaOFQ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult HVZUb8ZP4uq3CMAht4Du(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int znUGIVZPrRfTRMx8BWhX(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bRLiqiZPDLvg1SYR6L4O(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DragDropEffects BRfr5nZPdyWq9KKbY60V(object P_0, object P_1, DragDropEffects P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DragDropEffects)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object apylioZPCQComTFsJ7Mx(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int e1TMTYZPnouB6KqdZVia()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double jBCg3uZPatiOZNhkVEOp(object P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L6jryDZPHcYl102PHI00(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LUiClFZPsN2eQEOq4egD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KEYrTqZPlE8mSw1UD4Sg(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oAd4vUZP9UPaeUAevTJP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MJdxjsZPkp4KfX4J5rM3(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aYGOp9ZP1x5s8RW4TT09(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qQlw3hZPvQ38mfu5mGpq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jRalmVZPSKNcRalUEOP6(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mxAw09ZPmgVaMiVCx4ji(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ImPcvFZPIhOvfyeo2ldB()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aayjQtZPXBlmAIDHyqrb(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color XxCcWdZPUDhijldeRcaF()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KH4oFqZPOHlwaY4ItN07(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XWVJSrZP5hAG9q8220am(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ltBI2jZPihary3XAVIQd()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w0EqEMZPz7aEUneD0r0M(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VgS5LqZcLM7hQs5B02ru(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WArafXZcNmIyoxO1olOn()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AfXnxdZcYohIoKo2hbnq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kir5UiZcuLlLUHu04H3d(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FufL0uZcyWfjxsWIQoRI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QaCVN4Zc67rXlo0UrW1E(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nYACvlZc2LPqBl0dBsLb(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color gbpVu1ZcJaGWrCnN5E0L(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PRbyZ1ZcMlUcLQXBYua4(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ziW1MiZcKxsJi5dDrmLi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X2NhnPZcZvORxrevc97L(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A7VEXvZcoU6fHsaqY6LW(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hsuWpyZcxXD7LT4BmvbO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kv56ilZcA4NZYiPxR9M1(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DdwYf7ZctkU3Y8WltVgx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eLeT0ZZcWbcKfdN0yOWI(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FmnCadZcBU5j9v52Aer8()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OgLyEwZcqx7hIyllpbiB(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CJQWjOZcEosIAdDGNH57()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color JLA34iZcVlNZf1Gyb5s4()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M8SkJqZcTPt65l5O0UcW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o4rkfRZcp8YpnTeqVBqx()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yKDZniZcQOqDCld5dBs8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wSW9qAZcRYeiRAvTIHF1()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gC6OOmZcGsSw5HViGsri()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QCaI6bZc3FUEvn8FsxWM()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FWD4t7ZcFpj4Ww9OaGBl()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fkVLCHZc77bI3V7BRQj7()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lwPr6VZcbXQUQN4d8XC6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MWa7caZcg7DbuweDJo7M(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vLgEZvZcfKRwrkk8Z3vH(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bLXi1tZcjApfCgygqkIK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void seZLajZceJbaoYlf09RJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vlrZJvZc0dVNWWY8Fk7R(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tTgvwSZcPSuCvC6eZZbG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fxoy1FZccAl1t0R4XkJ4(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OkKP5LZc8Te8DJudu9M7(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VpRqSqZcwKJ10COwqNWu(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MGqyinZcho5KSs3KQtCw(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YBEdDPZc4XKPdZewdPwS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cNMMO2ZcrEIQgC5hY4qB(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FkDtEeZcDr7foLxKHDbi(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uO8LbxZcd52c0vJ9WJd8(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d1fLOmZcCNXp7qdHFcBs(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T7mbluZcnLFk4qLc8TJa(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Jqj7rgZcaFnYH7rj2G5A()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rnQr5wZcHFYOCMCHGIWP()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q4ZyyUZcseAF2Qsi5Ai1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OTqy3CZclogfe7uoDeZ7(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CNeQ6SZc9lVEXj80l9XO(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color FIxVdFZck1G2jBY8BV16()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Va9PCdZc1Pra8JHYa5dM(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y0AjtFZcvrjqShJ0YTTf(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nbIx7yZcStJ78qIh45qD(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WONYTpZcmf5NlNiY1sAC(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eNeghGZcIQduDFrDd6EX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dLqyVDZcXJlGDdSLMd5R(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dlbf5EZcUDDUweRYabUM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SkIqdVZcOFNwOB0I6yNr(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xepFbcZc50F0xOUmEwW7(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bfmY1pZciDsTgWHkZlJd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A24QxOZczZuWfKq4hMjx(int P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o1SKDNZ8LYZ6EiyFXjgW(int P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TBghRDZ8NAhb6EcrELN9()
	{
	}
}
