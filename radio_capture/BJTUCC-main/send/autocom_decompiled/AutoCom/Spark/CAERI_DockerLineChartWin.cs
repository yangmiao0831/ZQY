using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibBase;
using LibCoord;
using LibUtils;
using ZedGraph;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class CAERI_DockerLineChartWin : CoordinateWin
{
	protected delegate void UpdateIntDelegate(int iValue);

	private delegate void h9Arpr93hbTyrFukM0a();

	[CompilerGenerated]
	private sealed class clcYgwk2OU9blll2HvS
	{
		public int gQNERP2RxKw;

		internal static clcYgwk2OU9blll2HvS WmVLyPq7CxmnMliZU6PJ;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public clcYgwk2OU9blll2HvS()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HPuEReGFcJe(int t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static clcYgwk2OU9blll2HvS()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			tsT0Kwq7sn1GC1urplm3();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VcI14Eq7HANiP0sD6635()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x3FCerq7nVgHkf26lgRf()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static clcYgwk2OU9blll2HvS w1WFhRq7an6sU8jPG96r()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tsT0Kwq7sn1GC1urplm3()
		{
		}
	}

	protected const int ParamCount = 6;

	private Color Ovkgf55rZiT;

	protected Timer tmrUpdateParam;

	private Pen qPVgfTV3KSm;

	protected Graphics GraphicsLabel;

	protected Brush StrBrush;

	private Color KwhgfxGVyC1;

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

	private bool WZ3gfqFVqpL;

	private Color c9DgfA7tBQh;

	private Color zHAgfYgAPhP;

	private bool BPBgfH22QQ2;

	private long cfegf3nYn1t;

	private PointF XqjgfJYlnp4;

	private IContainer PiVgfrrljwY;

	protected HScrollBar ScrollBar;

	protected FlatButton fbSelectIE;

	protected MyZedGraphControl zgcLineChart;

	private PopupMenu RgZgf9v4kZx;

	private BarButtonItem Tp1gf81wdG9;

	private BarManager G5bgfUOfumr;

	private BarDockControl tfygfKvA9qk;

	private BarDockControl xyfgft1AfLd;

	private BarDockControl PGUgfu77OJE;

	private BarDockControl gomgfoSa7NI;

	private PopupMenu etYgfjh85UP;

	protected Label lblParamValues;

	protected FlatButton fbEditRange;

	private BarSubItem K5Ogf7Edf06;

	private BarCheckItem YsLgffjhBEr;

	private BarCheckItem GdGgfDN2SJg;

	private BarCheckItem NTOgfBPryn0;

	private BarCheckItem EtagfSGPPqG;

	private BarCheckItem emfgfmogfsv;

	private BarCheckItem TaTgfIS0owS;

	private BarButtonItem UPZgfQbBO9D;

	protected FlatButton fbSaveAs;

	private BarButtonItem AYOgflOh8vn;

	private BarButtonItem mx0gfwC1CsF;

	private BarButtonItem DDjgfpurlpu;

	internal static CAERI_DockerLineChartWin eMW4SSoaocE8JlQSoblJ;

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

	public int InitParamKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private OneKeyStr Nx6gf2wLqae()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void v2RgfOes8dN(OneKeyStr value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gVsg7IgDwYl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CAERI_DockerLineChartWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected double GetParamScale(int paramCode)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oQHg7QxiUme(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void K4ag7l3jZUh(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Udlg7wsXpo2(object P_0, EventArgs P_1)
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
	private void I6Lg7pDxlXd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EHAg7alI7hx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void u87g7kQPON3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pjXg70SmDVS(object P_0, EventArgs P_1)
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
	private void JN4g7Z60GgL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QfOg7zKTr1k(PaintEventArgs P_0)
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
	private void BgsgfCQR6uJ(object P_0, ScrollEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xFFgfGhOapN(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual PointF buildPointByIndex(int index)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int JJNgfRPv1xx(PointF P_0)
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
	private void WrvgfnDJ8Ue(Graphics P_0)
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
	private void yDlgfgaLEOW(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoAfterSelectIEFromUEShowWin(List<OneKeyStr> paramList)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAfterSelectIE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HoegfetjNEJ(bool P_0 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LILgfPKtA5r(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void WaitClosingThread()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EjwgfEgXRyn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Te9gfy23Rbf()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rOygfc5WeYU(object P_0, RunWorkerCompletedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoMyFormClosing(FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HtygfLoPNCo(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xswgfvI12P8(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void n1tgfs4brPO(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JcLgf6vShSv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sQSgfhsM80m(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HdNgf1odwcb(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GTlgfdLeRZ7(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void syDgfWdMx8b(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bkLgf4Cb5sB(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetThreadRunFinish()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void H1agfNOncpC(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zK3gfiXKYX9(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RkDgfFqQLeu(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void y3Ggfb4y957(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IytgfVIViCE(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kHggfXep5Dx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CAERI_DockerLineChartWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		WFqf64o9xNUyHVLjd9tZ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l3cCyKoatbFae49vSThk(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qtMUvUoaxZXL2sdSmekN()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CAERI_DockerLineChartWin mWN5hHoaA9Df6TQO2FKf()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kEeSXuoaWE07UaaAMyk1(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j7AMMtoaBOjJbcwiMNJG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dqAcWBoaqGsPRIdWA5qE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FPBp0JoaE5HKyEdoONex(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wyowW5oaVtDLgdnPneCS()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color GQBRg6oaTRvRkbtvSPJb(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HvHXD3oapciKI8KneJO8(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XpHKyOoaQA0PWGcR9j7o()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ljc7fNoaRXPSPJ17B58R(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PJyTlcoaGJmQhxmkWJOn(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GoQQYRoa3bVTax9a5McC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xEGjf3oaFOBCj4DirhSj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mvlrbNoa7G0CmU2flrgJ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MFtLkuoabBi2eibXF0Xe(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jsBZySoagmm69So5T9fk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zk6g3voafSPUa8AlFtyl(object P_0, DashStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BPuKVuoajDg8nKuf7Bsq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GEAtBDoaeuY9U82btver(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eMDIqQoa0vPtNnFkKIAZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ew95auoaP0lY2GVUAu7g(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double PyU3Ploac3K8URvscaHl(int P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mQQVWAoa8jUrKOEsoW0K(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Keys j2YHIWoawwEQrLdnrIZR(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J0DuUDoahjoM8V0XA5Ry(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cNp1Y8oa4hGbygx7TniI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vWUZwFoar3Ke97vmQotH(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y2M3yqoaDTJSQA44MtwN(object P_0, object P_1, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FwhItwoad4JdcOdSOBiw(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zD7BvuoaCOFiXtBUIo32(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KOjQVHoanJejBdu7bsmh(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WaPtoXoaaIObd0vqms8m()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SSN26boaH9UfkwyuNuln(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CrW9pqoasi9PALJ3ZI9l(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zLnOi9oalZsdwEiwWTdk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eAMAX5oa9euCcgZgJl2Q(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object syIBYeoakMd6KpL0Lt06(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k717P2oa1wZcdYKJaGpT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Dx4jghoavK6xGq6rqfgq()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AalF2SoaSP4EmCHE3ads(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LU3fRioamyvtx3EAwNmP(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b1NvGCoaI4Y5dshmOTCd(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object saR5aVoaX8JkqbJJgC7o(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JLgxeboaUWcvpGF4Gq5b(object P_0, FillType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N79Bq0oaOSmbonw8CGob(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V6J5pmoa5BlugwNx4KP8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UyWKn5oaiMPoxuWDEhpK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vdEHqxoazOyJ85bBrNYk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EieovLoHLrDN3ALHujZR(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WlRGMMoHN4D4S2ZYYQu7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HvG55boHYNmEVIeA5IFd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UA7kPBoHuGZRJ7V0v2qL(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TY7GagoHydOXlZ8OtYbE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JZfHItoH6oZEbYkP7IAn(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QHMLD1oH2VTfdt1fLVKb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Srq8dgoHJ7Eco0R7mLSV(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ms4pO7oHMo3mkfu3UArX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y1OG9IoHKAtKY3NMDAIe(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color JavMpNoHZMqEMid171kr()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XcoZeuoHof2oeRD8UHWu(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TG9qLFoHxGD22YNac8jb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void djPaOwoHAJn4uOBsdDxs(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color EAmPIjoHttFOq5O3Vkf8()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o8b0VjoHWD3oQWB0Vht8(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JWfdkKoHBdIJiUyhj5C4(object P_0, AxisType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bkidZYoHqJJfDcfIm2QR(object P_0, DateUnit P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YHvtsooHEDOdxjnXBuLb(object P_0, DateUnit P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hAjglQoHVFs9IXRoQhyM(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jbgj1ooHT3opxVYlRn3D(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iExXy2oHpZgUgNv5vLQg(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Bug8vSoHQnpAK3yWiH9C(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void En93eToHRDhLPj3AtBcO(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YbliBgoHGKLoZbaJYfoe(object P_0, int leftPos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FeUuJroH3gKvQdn2EFTk(object P_0, int pointIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF NQWBK8oHFUoKdUIEk9wy(object P_0, int index)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UKLOiQoH77qM4qGW0QGv(object P_0, PointF point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MPTR6LoHbjULMBl2yiMY(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ljRB9MoHgmrZ6VaxsZPv(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fLsgUpoHfPUmI4NKGvhr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cBv3IuoHjTG7AAK0AlIE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oTxsfZoHeNQPckJLSvkN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hKey5voH0sNyK6M9VrrI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tgkEKroHPMgVf5BOqXCm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iRaY2doHc3b1UVJskKqU(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bDr0looH8U2v1QTCCgg3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k5tZupoHwGWy7CML6Uw5(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eZVAHIoHhUOnhStvfvUm(object P_0, AlignP P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aoaoKNoH4YeZtHvdSXvB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NPyLN1oHrt276UTcq3A4(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HuFjTsoHDIRiAxuShRh2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VlNGFsoHdykTnG8iLlfO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PvgTgkoHCgJasujuZyKo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T0df07oHnBRPm7jwg7RP(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mHAZFeoHaJlvnrsmHijh(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vI7a1SoHHVO02cShwo1X(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object svuNQPoHsb9740eAqM2N(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF pdDfa1oHl4VUsgZQ9WiM(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int p2pmBIoH97Yp1nl6EGS9(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object umsO9joHkxTp3kBTSH7m(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dE15jGoH1Q7FR6m8s3Do(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jr8FxwoHvuwmiS1Ymw5K(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tvE9OYoHS7QkSxEQJZSc(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double GynvCRoHmLoJshwmB59K(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double rU4OIyoHISGXb20DYsoB(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SgKtQXoHXWVvobhOUuGH(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VoNPLBoHU9tFyX5FpIH0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U6bUXnoHOv1uGGgefv3D(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BS4M2hoH5vfkjRSMlvqN(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oLvgOZoHicwrN8wCCyPC(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JBA2HAoHzVCyY22sRDQv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uopjQxosLr2pbK8ayF31()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VbrdgSosNtmja6jUrZuU(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr VHNATfosYdZBwO7l3B26(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long nA2OFjosubJflDwynXGJ(object P_0, long P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime tyQrsaosyRlM8OYrWaWM(long P_0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double II3uH0os6fxW7YwAU18Y(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double hSwJylos2aX8rO8T6bDt(object P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dxc4gvosJE5hQP7A4ccP(object P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Jdjc1YosMAcK41di2FPk(XDate P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I5INoNosKkYNYLYFkW2G(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yVslTHosZK0pDDCJ3G0X(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o3Lq8yosoBSyjN8uHDoc(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint fMdlE4osxZnE5DeVnDcG(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A6vW0posAmT4HtpGjC4y(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fcl2kmostMFm1Ul41Vv2(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void upnqmmosWlZUMRDeMVbe(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M0cpMlosB7HLKOTxRd8c(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int w2Me8xosqFwBLfTdkv5f(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF WqPv9wosE9WmAjRnYFuZ(Point P_0)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point Jn9uPjosVOi5xhVODtUa(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF q6iqANosT9DdH2mSIVCP(object P_0)
	{
		return (RectangleF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KoAdeRospJuCJAFAXbM3(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rya5GCosQl7ynpljqT4t(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UEbOD9osR13YQliir9YI(object P_0, PointF P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ibOU5FosG6i7GkrrwN4c(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gnPgnaos3ty1C5trF9Tl(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fftVcZosFlrQ0TXe462J(int P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cx4PASos7IyiT4AxFWDT(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mn4ewjosbondoDGv4CjL(object P_0, object P_1, float P_2, float P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long wsX9oposgwMPSAj0TCAV(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A0ch0yosf3jpYEPDjLQA(object P_0, object P_1, object P_2, object P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NetType X0yZxwosjKndhay9w388(object P_0)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AtO7KTosenhRSR91Sb79(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n3cmy9os0B9mn8JVLgYP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dKwm3dosP8F61fRCr5FS()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BNxkILoscPAxDsy1GVTC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EpaZIKos8ZcIxHu0WccL(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hR6Q16oswsEIJOvNs0K9(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JpEyXLoshpo9p8FmxhTb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C3ZDW5os4qegZBkLDV0f(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IXqF0QosrPEWuPrr0U5V(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr pqGmC6osDctn1BI2k2fM(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VeMedBosdiaKGPWnJ3YB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SxifKdosCWxppSf3s5Dy(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yS4efZosnhuuVwrulPFV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dwlR1ZosaGEjD06vdWT6(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xTwts7osHZVNdLSWeZkL(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BkIhP1ossufSLj7HKHPI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BTbaCioslqoXYSCYywiT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tk1Tj8os9ndUDCOJKLif(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vWpuKQoskU7leLmMnwaK(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oQUmT0os1e656oO0SWt4(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zSRbETosvm7Eni8U1Sp6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult ERsActosSEE6g2lnIjBI(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int X1i2nLosmBdYTGo5QAw4(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VZWTAwosIP9HZBkjQ4w5(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eQ2uWWosXMgGRRiHvK5N(object P_0, int P_1, int P_2, int P_3, bool P_4)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W64WhOosUERDqmURnS0M(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InDcVgosOCe1EVZpqcWu(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NPgu7qos5jAin1hSSTPZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wvH6xcosic6jJ0LYQaNM(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ji4CUWoszQdN06HEstkb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle zwm2I5olLyGbJilb3iQy(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type uxh639olN9KqBVdWaMoy(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int m9FKxfolYfe18M0mZ76c(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JhCbP9olu1vLfluNRMCo(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e0BamwolyUXAkWi8aqls(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yJISQ7ol6xacrSywOhCs(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult dDPtQmol2F0fgpuKi0cx(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ha7EYLolJI77x4dFc3o2(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XuCnHOolMKSFv27BEmHB(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zp0fExolKEPO2DTSxlBQ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IAXrm6olZUK2mddRkjVu(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mrfOdMoloqoKbMC3fbk3(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LFkXrGolxLchZjlMZDqT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MgLDcLolAiOfqaVDWT49(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Rdo06JoltaM7Kb4Dsfbs(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K05saxolWm5lqL7TFWyU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AlE4lKolBsf3xqBfbbNB(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xvTrcAolqlhn4CL0JgYP(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color iWtZEOolEcfv7LHVnH31()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zBxC5oolVCBBBQfLR4Xg(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WWSaLColTFeWrXGZErfn(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W7ZcP8olpbrXk8wMZaKo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rArQJyolQdiAsifmiGhP(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ew09j2olRogvaTDEPOt0(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uOgMEcolGXXNsjjXv2iD(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L14AHqol3ZtGZCmbE7Y7(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gm25HcolF8uLBHkeVRQL(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OiRYNkol7hVoRHCV4hkV(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CZDWAxolbSuPcq6ppWsX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color fVCA11olgPrvs2esDugn()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U4XGGVolfB1JIS5IZMlK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Lj8B9golj91y6pmKsFfy(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SdjJ4Coledg6uNLGa06B(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u8XA21ol0LEXyhfJFq6q(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IPkSA5olPvnShSDAncMq(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pgIdaRolceR24vvUV9y7(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h86xGUol8OmWGNd4iLGM(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FQf2vWolwxvjdjXtIfEA(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oU3ZZtolhuHF2LlWbDMU(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S8u0qFol4m4xpK75N7t8(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CyXvBlolrfyxJ78ZdHDQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hAvadOolDtRLGDXClrBK(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FHWHK1oldyWakjw39uPc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wU0yZwolCF2M7vye6PZQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object beHZdlolnSvmghWQlN6u(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WT3pE1olaeuhLGWVoeCp(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DhycxColHnGjwlbI1dOb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rgCpFeols2KQPZnHuRO8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LGg8G2ollyJGR3rE4VoD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h3rY5bol9wcRH8V8PnpT(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d6gap0olkomUtpxdX9rt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object POvGNYol1NQJU2POQknd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Sn5gNQolvip8SRVkIpPR(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wfDmXeolSNriy0gtix6S(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qMHoHMolmpJE35Kgiork(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tH2w1yolIAIAWolQYYbe(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NQodCjolX8WOnp134n5A(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ykjM0VolUAbhKCxeNHxD(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I6YdPDolOQQHmAfxku1C(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pnNFNEol5yM41XTqDGbQ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WusK3EoliOoS0LJGulCi(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jSL1I5olzigSowNUooEi(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nAtdWxo9LpJBRwHIUgPW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z6IRHEo9NqQXydFf7khK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ucIRK8o9Yys73iX0auWZ()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IxuLADo9uWtiM84Q82dF(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wMoKA0o9yvdsiDfLeLLB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d8fuBxo96FdQZan6pRXT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VXAWKUo92jLIy8ihWdFi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rP57YVo9JIqUeCvA74EN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void otoJC8o9MpulvJ9tupbL(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iV03wpo9KvulFeFCK13Y(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wH8Dmgo9ZhRiJ9Wib0UX(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sdK0Rso9oq0OIxqBdv9F(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WFqf64o9xNUyHVLjd9tZ()
	{
	}
}
