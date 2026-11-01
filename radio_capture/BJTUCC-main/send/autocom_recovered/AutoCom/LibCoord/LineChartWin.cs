using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibBase;
using LibUtils;
using Spark;
using ZedGraph;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class LineChartWin : CoordinateWin
{
	protected delegate void UpdateIntDelegate(int iValue);

	private delegate void f2Y79altPfa5KHxiNGW();

	[CompilerGenerated]
	private sealed class YNCeryK9akbACJ9KJPO
	{
		public int EtcPIgS2GtM;

		private static YNCeryK9akbACJ9KJPO hIKpoHBOIMuLvrmdDRAT;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public YNCeryK9akbACJ9KJPO()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool a1nPInnIQco(int t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static YNCeryK9akbACJ9KJPO()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vAnGRdBOO4j7an3v5XZg()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e9vnQSBOXin9JXP5yRvQ()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static YNCeryK9akbACJ9KJPO xKGRZFBOU0s046UFdCWy()
		{
			return null;
		}
	}

	protected const int ParamCount = 6;

	protected Timer tmrUpdateParam;

	private Pen VikGItoBFXw;

	protected Graphics GraphicsLabel;

	protected Brush StrBrush;

	protected int[] ParamCodes;

	protected double[] ParamScales;

	protected string[] ParamNames;

	protected double[] CurValues;

	protected int SelectedParamCount;

	protected int[] ParamMapClearTimer;

	protected long PreParammapClearCheckTime;

	protected int CurPointListIndex;

	protected int LastPointIdxInTest;

	protected List<double>[] ParamValues;

	protected List<double> TimeValues;

	protected List<int> PointIdxs;

	protected int showNum;

	protected int showInterval;

	protected int DataChangeLeftPos;

	protected PointPairList[] PairLists;

	protected PointPairList PairListBottom;

	protected Color[] CurveColors;

	protected int PreScrollIdx;

	protected int newValuePoint;

	protected int drawLinePoint;

	protected int CurParamKey;

	protected bool ThreadRunFinish;

	protected bool bClosingThread;

	protected DateTime PreDateTime;

	protected long FirstOneMinCheckTimeTick;

	protected int PreOneMinCheckCount;

	protected int PreAddedCount;

	protected double SpeedValueScale;

	private bool HSSGIuadLGA;

	private bool OEKGIo2WHGn;

	private long lY8GIjWLr6r;

	private PointF JvZGI7rVjt5;

	private IContainer vELGIf76nhd;

	protected HScrollBar ScrollBar;

	protected FlatButton fbSelectIE;

	protected MyZedGraphControl zgcLineChart;

	private PopupMenu WviGIDiKUAp;

	private BarButtonItem Ko9GIBXWLxT;

	private BarManager t7DGISPaXka;

	private BarDockControl L61GImDPfuh;

	private BarDockControl OjmGIINaXK8;

	private BarDockControl QKJGIQWHvMq;

	private BarDockControl tCuGIliClRl;

	private PopupMenu eDDGIwGpH6p;

	protected Label lblParamValues;

	protected FlatButton fbEditRange;

	private BarSubItem SEfGIpGLLr6;

	private BarCheckItem zXoGIaOEBIH;

	private BarCheckItem NEAGIk9F37l;

	private BarCheckItem qLqGI0TvFHH;

	private BarCheckItem prxGIZ9yVwf;

	private BarCheckItem uKJGIz7srOv;

	private BarCheckItem gtRGQC6IEwM;

	private BarButtonItem tejGQGZxgf8;

	protected FlatButton fbSaveAs;

	private BarButtonItem b8cGQRA52yW;

	private BarButtonItem A6YGQnQ0lwS;

	private static LineChartWin IkJIbFygOseGhB1i6QtT;

	protected bool isMultiParam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineChartWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kCJGIeeiLAA(object P_0, FormClosedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DycGIPrPPwU(object P_0, ReDecodingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected double GetParamScale(int paramCode)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void W3FGIE7EVEJ(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qUwGIyY66wB(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xf7GIcApbri(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void LoadWinKeyStrFile(string sFile = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DelLogfile(Logfile logfile, bool refreshUI = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessDialogKey(Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Qd6GILCxvKY()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gfeGIvH2KKx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FGMGIsJQ6C8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ur0GI6dguCn(Logfile P_0, int P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinateForAddingDataByRedecoding(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void denGIhPGDjw(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Win_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eC1GI1ZJppp(OneFilter P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BaseAddLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oGZGId6EqYS()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void p5vGIWvJGuj(PaintEventArgs P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateAllParamNameValue(int pointIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateParamName(int i, string name, string value, bool resizeLabel = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Scale GetScaleByeParamIdx(int paramIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateYAxisMinMax()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateAfterChangeParam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void UpdateScrollBarSync(int iValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void FreezeChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool AddCurPointsBySyncTable(int coorIdx = 0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddCurPoints(int coorIdx = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DataChange(int leftPos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoDataChange(int leftPos, PointPairList pairList, List<double> paramValues, Color curveColor, int paramIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yBNGI4mm3L5(object P_0, ScrollEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ehTGIN2wFZ1(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual PointF buildPointByIndex(int index)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int vNkGIi3JB7A(PointF P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DrawEventByPoint(Graphics g, PointF point, Bitmap bitmap)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DrawEvents(Graphics g)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bSdGIFgbE6A(Graphics P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DrawCursorByPoint(PointF point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JLPGIb34Kml(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAfterSelectIE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void beGGIVve0fe(bool P_0 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vZqGIXIwLjK(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void WaitClosingThread()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lnBGI21Yivn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OptGIO8KXpi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pFMGIMlavMH(object P_0, RunWorkerCompletedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoMyFormClosing(FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Fx8GI5r32Zd(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QNjGITfRwCB(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lsxGIx8okYe(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void M3kGIq7AP8H()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void afeGIA8Z31E(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YayGIYM9RAg(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NgRGIH5pVf0(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChartShowTimeSpan(int min)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vJ6GI3vYaWu(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WsFGIJn0kj3(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetThreadRunFinish()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nITGIrb6BG7(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void r9rGI9NAx4s(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void L71GI8Nx6dc(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lokGIU6AP6R(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WDXGIKLloBK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LineChartWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UI5rLlygznNZ2WfPNT8L(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MIt442yfLw4ppK3RYEBD(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IWHgkWyg5Y9jwPT6iCC4()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LineChartWin x4Dl6NygiFusrkbspXqg()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PTb3TMyfNBbq72aHI6VO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aNxuyeyfYeGl1iU7Hf3X()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pouI1OyfuSd5UDHx86vJ(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Fx9D6vyfyLF1yDqVcvUO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xFW4xEyf6b0e4H6JnjNa(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G7G2Cdyf2VBNfqh8ypt9()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ttOneDyfJPX2jS8jsc2C(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QnuleoyfMVWKJCfQEN1q(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dmxVEvyfKydMfLkTAIll(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WtbOCJyfZf39ZAKoMVJc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color otNtGSyfoDTF3JPta9Qm(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hOqc6EyfxnW35ygF5ktb(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UDrMWdyfAOUk65lyYsZZ(object P_0, DashStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N7amcSyftGu9WIXtMwnf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rSK1Y9yfWeMlmAR4K0sG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ikxumXyfByPqAq9xDKo4(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SEU0iIyfqHabp3iZRLuv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T8vecsyfErqIA49cOwbG(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CvdIcYyfVTDrFImim1Gd(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iITPfEyfTOKNEaRoLYSy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tCyF83yfpDmuqDkVso8y()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fiTaC6yfQl7WxgDpOGcG(int P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WqVB97yfRSV4HSWwJewR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Keys b7hvOQyfGR9PPJBgLlVt(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zS7Pjeyf3gU2AYQHWc7Y(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CShodPyfFinIlJiVNC9f(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q65AR2yf7PAXEJ1u8oQD(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xsv2SZyfbr5rrbaa4G6O(object P_0, object P_1, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fuAFPlyfgvtYhFFFKalf(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YwknUPyffWoU2dpCtFTU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vr0ChCyfjqqKYou7EAeg()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yfvU0tyfeNFTjMhcx9ZF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UYjm4hyf0RcCByBlddIk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EWkF9UyfPYYUvyZZvJ29(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cDstNfyfc3Xe33cdEHRa(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pSQWW6yf84D4Pk7DhiIL(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color yRryS6yfw6tlVIW2GP2y()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QssrFayfhydrAT3cRFDh(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dHpAn2yf47bUYopQPYmU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color PtWoOLyfrqe7pLijXMyl()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nf1ZFHyfDxj2eOMpSkQM(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vc6uayyfdjyqARtelXw5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JfpDllyfCUIp95StDQAQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XoSRsAyfnXlN6jblwcBl(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LgZx9lyfapAcJ9hQb2vo(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void otcIkCyfHo3qPlKbSEdJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object puXm8byfsGhurHgwgE6M(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ctuo9Dyflnxs3hqT9ZHq(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FupYiWyf9H6uSSkQCVGj(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Stenifyfk47UDrtxH5PH(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MYuT43yf1FXw15p2VBYe(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ASxKSAyfvCRtdHZiEixQ(object P_0, AxisType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T5NAPoyfSkZMUULGa5uo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MeaeQNyfmdJSmxfsF2tl(object P_0, DateUnit P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r7Tmn3yfIvqfJMNZwoTT(object P_0, DateUnit P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DLxoVWyfXLJJNYQ9yeJx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GrGnIZyfUPc0r4OKcgIE(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cL2J6tyfOAsV5U2SShKn(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VQQM5Wyf5s6Ir6fdeVgU(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YV37dNyfi8iN7lbYTn6v(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GysJTjyfzXCvWZk5Y717(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D4CotLyjLbFZJR1q4Miq(object P_0, int leftPos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XtMRepyjNsf5eE3QVpIc(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF fPraOjyjY4TWVXXEulxF(object P_0, int index)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sLWoNXyjuwbYE5TuQU5y(object P_0, PointF point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CaJOXuyjysOEiFxndGnR(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Fnl2RCyj640MgEmELFY4(object P_0, int pointIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Ub9nFnyj2fXM9Jjwpwch(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oJkjBOyjJqL3aZiCegoc(object P_0, Type P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AFYeRCyjMCZLBE33QyB3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bCaLUSyjKTjDeUj5KYsm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OU9oPyyjZF09tcd99mPu(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vxCNXlyjoFJTKG4hl007(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OOHsLryjx4H2VdYV5VTd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N43ALlyjAc7by8BdS6LJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kndam7yjtYUKpYWuLG23(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N1Rhy3yjWax8QyX0K0Xe(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ln0X6DyjB9PQyIfpbFwC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wvruUMyjqGRpmcixpQcN(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VAT51ByjEdtZhiamghvx(object P_0, AlignP P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CPax36yjVyL371HeZVnA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M86aJFyjTSiAoenKo0d8(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zKmloCyjpTRjYG3iqOn3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yL7YrpyjQhtvI70LZfM3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f9sxIvyjRJclW2MFYHcR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vXGjshyjG2NB5yPiJPya(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lLn458yj3cq79KLS8eG3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O8kVufyjFpKqxjc5o7mC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aVrb3uyj7w2new583jXe(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p6qUQCyjbamJvam4f0op(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R6ut18yjgq6LBXGdg3W1(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bhMRcKyjfac17asiodA8(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yx4aLvyjjECAf6mxIUGD(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tIHNkGyjeRyisbFmv1ox(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GQYDTqyj0jcVdEbjcxFn(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LffxWRyjP7Rr95OBo9W2(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yd0QdbyjcjxiVwX3lsj9(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J6QAhXyj8jElRtdXbfPn(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kXROVuyjwvgNjWFyyluJ(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ULSYrXyjhgvmxpvqxEkJ(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double BveqJDyj403tlJ2pU2CB(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KbyLBkyjrl7NeTdmUyuq(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sB9ge9yjDpYcJAZ8RoS2(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wCCrWfyjd39LWZr6Vhf4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Dw5ARvyjCRHjCqFnYUDY(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xsjd3iyjntPX55NmiqJs()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr WNbgvcyjaLecMxX0l8Na(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double DsAcxfyjH08Cs9uqIcOn(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime db7hr8yjsHsykVaxmoe6(long P_0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double kJY3c7yjl8wAQlvAxOmw(object P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ux0mM7yj9D5nJsvADUPL(XDate P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ubByu5yjkKPU1WJM9hRs(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint qF2atnyj1UYdGsNs7rB9(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ArsaGJyjvmhuZT31Cyv8(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ljbwH2yjSGbQaUZYxZkO(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double jhP3TcyjmZ1g6Vd7V4sJ(object P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DKoQQvyjIuZ4fdwuOiZB(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XvIa6DyjXV9rY46yNu0t(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ojtUQjyjUNMXyYgVXNYD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DrKTiVyjOAWUGotUSK6F(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f0RakMyj5nZg1t83kQtl(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XtoiiUyjiTIAg10hIEiU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ze7hOcyjzosccBJisJcB(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point tuHBhXyeLqlbpIuZrgND(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF xo09PPyeNlEbscDu6Xml(Point P_0)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF Pqn8ekyeYWRYacAgfU39(object P_0)
	{
		return (RectangleF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c6ymr0yeuyNX4EwxW6lF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int V79NsiyeyrtRwTQxKTr7(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v5vgBJye6HsrYqiJSEMF(object P_0, object P_1, float P_2, float P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ek9ahLye2TRZ1flsI4wU(int P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xfAXr0yeJ6Q3JMcXRvBd(object P_0, object P_1, float P_2, float P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long KvpYnlyeMDiJ06U2w5N6(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF h1D52eyeKXRduE7K67kr(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Yupp8yyeZZHF1hUjLBCF(object P_0, object P_1, object P_2, object P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NetType Nvta1SyeoXJsxxUbiQfw(object P_0)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wmFwaeyexfhMOTFfvd8t(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xGSQseyeAEhpjy292L9j(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IQ1EnQyetoSLXG8V6gWE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KX20BEyeW2L6aw1PCjAr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x3WfrGyeBZJtHDJQFAFj(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IRffcGyeq5CyyaokYXDm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LPjjkLyeE1ktbAOpFnjS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LZGa4FyeV6cM0PPRmvj0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oDR6RdyeTHyshxeETp5N(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PU3lRSyepV4qJgWHqBm0(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GbdfvqyeQvIEpH8BOKst(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr uI9DMsyeRcpaDQor261c(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CARsBfyeGX6ukoR1JgHj(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object meOgGUye32XE6AAXuJhf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OSbslTyeFXQ6JDwB24rv(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zxYtrsye7eNxb1vweamt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iwyeOfyebvyR4XMDK52X(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E6N3EiyegJa018rV9KvR(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e3i1QoyefD6eQl0Dpge2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PgUuyqyejk44WO3DYxl2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult cTgIISyeeV1mRDONU5E0(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GByQR5ye0giNrKCPf3gA(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rOu4AtyePPKNstRRSesT(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Er9aPyyecmcejr6P3wNy(object P_0, int P_1, int P_2, int P_3, bool P_4)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point L8du3xye8JKYiigNNyyP()
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NPA42SyewjrTu3y5GU1Z(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s4hcEYyehTrqQ38Dr3kc(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H96jmuye4cW9CBQrfj7x(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jOoiRRyerCqpvVeCf6rH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RVboIQyeD3coKo5XqHL6(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kLgjFQyedoeHbd1i43KV(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GaZeT8yeCGGbeXEjQpyG(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vxycNcyenC2ToiUEJbug(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d0GJ2LyeaIJTMs5FPhes(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SsukiMyeHRBFSKZBDcgO(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hRsZr9yesO9JFMa8YtjX(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OCPXJfyelN3ZVPdhDbYu(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult h3OPkXye9bOYWmA0Q874(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U7eHK3yekZaKv0U9ixAI(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nqAFqXye11dGUChO3yLK(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p0ZJLZyev9WRfYu5vGHh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void li84AyyeSyM3MZHFSuRS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void swHmgWyemvqUKsum45d1(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ad23qyyeIIBy5vU61aA6(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VasSYQyeXW781tQrfhq0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SyBmu3yeUsuRJGhMb1hx(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IRaGnqyeOnoXSPoHXibE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GZ4uuTye57Bts5BDeS0o(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dCw4u0yeiZAKhmKhug4J(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zgmXaQyezBdHbcCKuNpM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aZguU2y0LlFTwXgXhJaG(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aog5tvy0NkQdGkVYrY6h(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vsfg5Ky0Yhux7OZ7QrV7(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AGc98Vy0ugPVAN3cpBMj(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NoDodSy0y4H6uZFwqHnW(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LqcLley0672mWA1dOTmt(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p0eun6y02Llyo9i9qres(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AgtStWy0J7En3GP7Pv44(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color OOTw2Dy0MgXevRPWdpHE()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sTswyay0Kabx2M6pPPIF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HUbdmIy0ZRduyjOOjhVj(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IMHycEy0oWamm6G5jrtp(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color pKR0WAy0xI0G5aAhxW4V()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KASHTyy0AE1ncEBOWpuR(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HDgooky0tk3PFeOYZx5X(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jJPGf5y0WMTZOybHdCc8(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XXJ2moy0BNmrWffH9IuQ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KFtoEpy0qTvLHR9rvbis(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w14KYJy0EfyANHORRbiI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ElrHehy0V6FF3dGg1JiM(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ewap5Ny0TUsW9FEc2nO2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ajr35Xy0pY111gT6QhWU(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bKoGsVy0QY3tevd77Oxf(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c4kW4iy0RayGHhQOqLAn(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gFAyKgy0GeR0mmbNC4v9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ke6Hs8y03qjmg6k8wyuh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JfjQ5by0FljlMasA16Tc(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DyqTA5y07h6Sf6CBELTO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pwhvwNy0bBok2PLPBGS1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o96s1xy0gYwfMVEN17es(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X7tbLdy0fvd69Q0SgBRW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sDHq6Xy0jhnpteG9vLW3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XTsVwKy0end7PBM66Uuc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qMuZGMy00f2lKKH8jsjB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tbC5CIy0P3Tag8dfgOQY(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zkhOi1y0cC19hDYru7Mo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Iiv56Ay08gYu1VDh4AHS(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EOcKE7y0wBSQxtYvBLFc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wn8VO3y0ho7yPnMf2nU8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AlaWQNy04uSPym6e0XR1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WG63LLy0rRMsFeNyTrVj(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jscLKjy0DbFkwNn8VdUF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NQdw7My0d0biBnemr4bX(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AALK5yy0C7HsSaKRcDpe(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qPMc22y0nQeW76TNNK1d(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color N9LBjry0axvLPIpCY4On()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CcrI0ty0HwOup536nOn8(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PKYyr2y0snf6Brb120xj(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ho31kMy0lNNDfwU4cPSv(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l3WsVGy09BqyEUQCoNWd()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bRsGXQy0kUYiZQ5vjW9A(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R43JZIy01g1hwlPmVZq0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MfBcqSy0vv7KaLa6Ny70(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rv2Xmry0S4YMdcZnXox3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fPDw6Ky0m1PC0xJhl3hY(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mfxndoy0IEMp1fxh7I88(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mdyKHny0XDl8O9R5KNRN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WgaKmOy0Uiyrm558pj6f(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ieb8Nxy0OufoXh0l6J6K(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r7HVQVy0569A82IMjLEv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FIQKWby0iIH5G4ukDMPb(object P_0, bool P_1)
	{
	}
}
