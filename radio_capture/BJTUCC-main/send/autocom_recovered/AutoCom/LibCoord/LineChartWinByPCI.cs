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
using ZedGraph;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class LineChartWinByPCI : CoordinateWin
{
	protected delegate void UpdateIntDelegate(int iValue);

	private delegate void qGYIn0l24TnDQvxT9uu();

	[CompilerGenerated]
	private sealed class qggdU2K6IgLSQcDXrnM
	{
		public int YOnPlyV1ByC;

		private static qggdU2K6IgLSQcDXrnM Ewo3ZZqN0UVY7vH5ec3i;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public qggdU2K6IgLSQcDXrnM()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SXBPlEJCImQ(int t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static qggdU2K6IgLSQcDXrnM()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gCRXhDqNP05MsKr9ceoC()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static qggdU2K6IgLSQcDXrnM HpWDhHqNcYHDOWBHV7Oy()
		{
			return null;
		}
	}

	protected const int ParamCount = 8;

	protected Timer tmrUpdateParam;

	private Pen cLxR2BYlkUx;

	protected Graphics GraphicsLabel;

	protected Brush StrBrush;

	private Dictionary<int, int> hQTR2Sb4H3T;

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

	private NetType STWR2mBgomM;

	protected int CurParamKey;

	protected bool ThreadRunFinish;

	protected bool bClosingThread;

	protected DateTime PreDateTime;

	protected long FirstOneMinCheckTimeTick;

	protected int PreOneMinCheckCount;

	protected int PreAddedCount;

	private bool nwlR2IZlBI1;

	private bool safR2QAHOVe;

	private List<OneCellListNR5GRow> tNTR2lEE2MJ;

	private long X6VR2w5FDHr;

	private PointF c7qR2prND64;

	private IContainer dqER2amAyom;

	protected HScrollBar ScrollBar;

	protected FlatButton fbSelectIE;

	protected MyZedGraphControl zgcLineChart;

	private PopupMenu J3qR2kyTEFF;

	private BarButtonItem ewZR20nksXf;

	private BarManager n7vR2ZuFdof;

	private BarDockControl nlYR2zVsDOj;

	private BarDockControl BmiROCHWUjP;

	private BarDockControl u6cROGs0Gw4;

	private BarDockControl gKTRORA2n7H;

	private PopupMenu DAvROnL3wl2;

	protected Label lblParamValues;

	private BarSubItem L8mROgvYSQW;

	private BarCheckItem SXhROegTnZD;

	private BarCheckItem yTKROPKCV5L;

	private BarCheckItem CWMROE18i0D;

	private BarCheckItem poHROyHaTF7;

	private BarCheckItem vWvROcrOJXA;

	private BarCheckItem DUtROLnJUBk;

	private BarCheckItem y21ROv3FlJc;

	private BarCheckItem c7WROsXV94F;

	private BarCheckItem VRcRO6mr2p0;

	private BarCheckItem rdVROh6AqdD;

	internal static LineChartWinByPCI TZRnv46H6YJQMZwgWapM;

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
	public LineChartWinByPCI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qriR24MKJv6(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eDZR2NcUxlf(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RHQR2iSqImG(object P_0, EventArgs P_1)
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
	private void uQlR2FaX6yK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YgXR2b4Jrwp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void W6XR2Ve3L3w()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mpGR2Xgqh28(object P_0, EventArgs P_1)
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
	private void RymR22uv8Ro()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void B09R2OHiD9p(PaintEventArgs P_0)
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
	private void MyDR2MlYG9Q(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool AddCurPointsBySyncTable(int coorIdx = 0)
	{
		return true;
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
	private void zj0R25ZnJ3s(object P_0, ScrollEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UyAR2TeNVfl(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual PointF buildPointByIndex(int index)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int eCoR2xSj5uX(PointF P_0)
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
	private void ucUR2qS2pTC(Graphics P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DrawCursorByPoint(PointF point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ahjR2AD8tIT(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAfterSelectIE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SOmR2Yvm0J3(bool P_0 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mX8R2H8KnXU(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void WaitClosingThread()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kyxR23qsTD7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void js4R2JdY0JX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void djfR2rXEcp9(object P_0, RunWorkerCompletedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoMyFormClosing(FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JmqR29oFlXk(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Q2wR28cGwY1(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uZPR2U7EIgI(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xcZR2KO7CMe(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BYbR2tW0LiR(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetThreadRunFinish()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qHZR2ubvAr1(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pb5R2oi3qxk(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xXlR2jVbcPI(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void anXR27jA9wX(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loOR2f029aS(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eIKR2DX3GWE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LineChartWinByPCI()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		uNB5TB69PLHiKGRAxTbp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OeqAew6HMlqpkcIdA0AE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BlI7mj6H2sB2V0hj8BZ3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LineChartWinByPCI u2CAg16HJ1BQuFSBvOrW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yZ381a6HKt2kguSWQUGg(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wh5YPC6HZvF4LcK7IT8v(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color mStrWR6HokW4l3k9fosJ(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vmd5x76HxR07sEB2nR3o(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tye4H76HA8wodEZhlkGA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pd0tWS6HtjG9h1Z8xEl6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oQ51MZ6HWgyHMXmgDPgQ(object P_0, DashStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QjXqBl6HBqqF7CYGM5KP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CONuNI6HqKUfVOpoQmjM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qLOVDW6HEnpBA0y0q8Vi(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aaV4cA6HVeIeHAf9OnEI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k2g6td6HT37A9fUra2Vp(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Keys M8HnNN6Hphj3BaR0gRLh(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u8reWZ6HQYpNxNkpFgbd(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Rtko256HR0f3esbsxLus(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K8djoj6HG5NCAbW7KEAJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wyunef6H3hy2QwbFSl3G(object P_0, object P_1, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a5sPXL6HF6Cm3PHswd5G()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hBxPG66H7fcORfSdoIeS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C7GyvZ6HbfWW65KQCfFC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mWcFA76HgMUmvN8SOx1e(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color C0GEIg6Hf4H22vfhhCKF()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nXZ1gY6HjZUkljo7R9m1(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BioJuW6Heo8OeWaHS8jQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KyWk5G6H00EmBgKeFw1I(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QfRYuQ6HPrpgaKbKbCgA(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TFCWSe6HcvEWFagp9aYx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color dHORvn6H8ZWgU0Ey3gLt()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NcqMN86HwkwALa2NlnmB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wB692S6Hhwjg2wD1PxxR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iN93j36H4N1auke9L9Eb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D8Q4uQ6Hr2CsCZRDxcRP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sL2bpP6HD6KItP4eKGCI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Qquepi6HdOOo9nYUtBVA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s7frAb6HCGpgn63FtrBH(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ByAwbk6HnOwMoApv8gFm(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dJve436HawNfDRLIQn3a(object P_0, AxisType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AiJvSv6HHhs1duKa8B2I(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rOUK6g6HsckOVJfyLSLv(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dfm7G56Hlvd9sY2rCIox(object P_0, DateUnit P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FP2mWm6H9oudlwhPvOJP(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ILa96l6Hk0aALR6RFLhf(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iKYqs36H1XnXdKp0lRrp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XF1nyg6HvIogoNRxYLKB(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void beHsv46HSo9aEqcOuK4o(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int piarPu6HmaPtYdaVR0dS(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r15mM46HIPUUj3UqQc25(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ie6bVk6HXcoOiWjp2FKQ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF SA8sMV6HUsOM8CELQ7wd(object P_0, int index)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AUCn7f6HOWeWsL6y0PS8(object P_0, PointF point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d9LNVi6H5pIPgohaH6nN(object P_0, int leftPos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YsF3dF6HipF0T5ElTgA1(object P_0, int pointIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PnNFY26HzMAKH9dx1GD9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double m1TyPl6sLqRemO8Y45Su(int P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IGp2y36sNL7Mi4ZQUlLt(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M2dgCi6sYUmISJHbs0gl(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p6iZQc6suHTdXZMEhur8(object P_0, LegendPos P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oXOMiA6syGogVg7RT5Z3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ekgTJu6s61FybOaM8biS(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TOLFKA6s2OGrZ6UvUO8c(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S1r0126sJdmOiOl3J0s8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JmawcD6sMCrCe0awpM1w(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gLBfbP6sK6hdiZ10dJ6M(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RmVMgr6sZG8RgwXOI9Sx(object P_0, AlignP P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CxKNmG6so97f0wi8OCRM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IvyMDN6sxS6redr25Tf3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bTrgts6sAp5OW8fZrK1h(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f0Tt0q6stODUmt1lVUCM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T3XEur6sWkyvnKWeav29(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SFyuoy6sBgHlr6gMNTdk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hjF4oW6sqxsXAkWa6fc5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lrCHCK6sExoRJGfCRCrS(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l2hJLv6sV6SZB1LMsDco(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bwD6Bq6sTSwZbcqYDvkY(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y92eJp6sp9b6lNTLyWXA(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gg1CGU6sQBZo9PGF8EOw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF LnLhen6sRHYcX43ElqR5(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rQdHAo6sGu0oYXof2Zgl(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E5ymkE6s3K9qopyUirIN(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U9rOQk6sFSfgp8bx9Gd8(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hHmEP46s7HjweVMVEdFD(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rDj9QS6sbBfQHmNFvtpl(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hyppcV6sgcjvJesD9qIx(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double g1TGtT6sf3kf6GSQmmtS(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double CNjEfh6sj5c3bJS6u3rF(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kvqvIJ6seosbVrGjcm4O(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l7IbZc6s0tf2xDMePbhk(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gQIpgd6sPtV5RmtcD2tW(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lkbsuR6sc9LUCMl60DpU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I0iBt86s8qA5oR2NMfnr(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YHvWN66swppiIexX95DZ(object P_0, int P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tf3o526shLZnBoTmIYNF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D02n9e6s4C0Xx2ldaBRn(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr qQ1kYV6sr6wULdtVNK47(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double udHgaS6sDLkKcUIig8Nd(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RP1XwL6sdbZjjREMiM5u(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QX74Tg6sCg4MeIvJuSMU(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint Jj9D5K6sng0BjNPc98hC(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T5STUU6saEmU5bVwQeCj()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime PJI9KT6sHyP70jngpD4d(long P_0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Q8rH4w6ssyHy5IqHuhfO(XDate P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vFIpSM6slIftlAsJ2k19(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xCDfxo6s9lCrgqB1aERu(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Mc1rAT6skom7HUDtnlcA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nko3SW6s1t71TgwPccdT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int IM2BCT6svBo4EXd2ghF7(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ztXnUT6sSjehqs41eOkV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PKuNQo6smZvjhNBCUMOR(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point gfPw9S6sIGnl4gf9mG0b(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF vmQqBP6sX1jnBOEnrKgq(Point P_0)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF RTEmly6sUTCxqVWD8Pqj(object P_0)
	{
		return (RectangleF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wP3Gd76sOlsIIScQwcln(object P_0, PointF P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vKOZr66s5tSuGd7SsrV5(object P_0, object P_1, float P_2, float P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vfOJI16siQP6Sy4POgaY(int P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qIr4rt6szEK06YSxTOd3(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l7JGbk6lLFkpg2VdESqb(object P_0, object P_1, float P_2, float P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n49PQj6lNfaJJYN4WHar(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rtXOfD6lYIelbRirSLS3(object P_0, object P_1, object P_2, object P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long c8sMsK6lu4V4GkVZb2ce(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point MDEYqs6lync8FrsaKwv8(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point O5nohH6l6O2yEom25y2n(object P_0, Point P_1)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int B9euDX6l20GHcfAsgAms(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m0ibZ16lJPEAqWqpJUii(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DvLPKw6lMl9i3dUNtDG8(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void enSRUw6lKIfAlWyXVC3v(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bk1yUP6lZQ9ZYoUQdY0O(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b0LXuf6loyFtJw9pOeg1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w0B9Lv6lx39lZ8uW1tHo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VgyNyg6lAFxdQ67djurJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FrYvjs6lte2RWVNKobw1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pbZj5S6lWqXx3IewbSsU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KeZhDt6lBKVbUDLlji9C(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VmxTcG6lq73eUNTKUGfo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ohtfNh6lExG3uW8tikQa(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tA4bfL6lVm1tDZKEurXv(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CUKYUm6lTtwaIu762QdJ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jgNEpL6lpn6PMW1wcNtP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WYgpDE6lQuWb90lhDJUE(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y7cDyS6lRWQqqqt2ud3B(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int G0Xhps6lGvXKR59a07UN(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f0JNiN6l3NxreEjuNvD6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e8MTwC6lFZ3nwij49CPK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tygrUp6l79ycAOj5NwgO(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hW9s486lb2lsfLEvffe8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fTN2Iv6lg8NwbDI0F9uD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TCF2SC6lffycumxR1O1u(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kZEGci6ljo533hbk9Bum(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Hd7F0B6le5eAwRiHniPJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V765sY6l0wWWbQKJk7D6(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Dn8xES6lPeaO7eXU8kOW(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B2dcWS6lcSWVS9PhB59H(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color qvGh4D6l8HY8doN4JwpE()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l08Dmp6lwPx4tw05mhbq(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dJRKGe6lhRhKOcbltS13(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ku8S8g6l4U7l5UnMocj3(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NPtClW6lrmD4t7On7Ged(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CNDwFX6lD4t0Dl54eubi(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void doK7dJ6ldqA4qGjAVcJK(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mCjXZx6lCLy7t6fN2mLv(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qnwpMM6lnQUXG48skTfe(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EkrvuP6laewuxcuVujtq(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nt7vLQ6lHNJNukn5qe0K(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ritBm06lsDfF3ylDsGGX(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color zGujJk6llWdFFx4kEYmO()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v0Q0Bh6l99cYCN5UmQjJ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UCKhFY6lkk0BVDpTjdqX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BuwLrk6l13qfWW6LJTuB(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hxOTob6lvQ4S9sLUIjgQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GgfLJM6lSrAnhcOHkrIK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color k18uKU6lmBIHfYjpHDQO()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LThwdG6lIXJGsCaFREyj(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nPyYsu6lX6aePxcii9jq()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MHfoWN6lUIHyYIp159Zx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hds1Rn6lOZQ8pl985cVg(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ayw40X6l5yAM71pH0J2I(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r8P3iC6liwqxHcbk2rwS(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KyA6U26lz8Kg30SoqADE(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S4rays69L2HyuRX8jUDE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ACcTTk69N7rQgCeEtt0c(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NQFqvs69YcHrxKQ57DsG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BGI8ew69ua9ymckUWWJO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lDBmZq69yOi4GpBJktZ0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void foQXoS696rL52DfS1haJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I41d1j692y1RKipnBVXY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tYwGkU69J6WjhuHhBri2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ohy12B69MR3LUP5tX4VX(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RwObMq69KtXiUdxBwCWi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KyKjwi69Z3Zt7mexombD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rh1n2g69oOWiPYTq5XIP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dtVMm769xq31jnWGQXJs(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void inZf0t69AZn02lsR5Txw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GscGJZ69tyJwKF0kNJ4V(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Iw16Ux69W7Q8vRpUGNva(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CBb6h169BOya9Gv9b8R2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mZu0EM69qIX5gWnr0Nni(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x6lPf369EhhouJm8cPRX(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UtNg2w69VcFHEkwEBXuy(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void giFQPC69TrkukVnEnr71(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GPmrX269p0vpx1cXwWan(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color p86SRx69Q6sJx5KUcSsm()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WpEO9G69Rc1kXkpUNvI2(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ahVixk69GFQHGlVKc0et(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a8MTFP693u22y2oVHFaF(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zxWCxC69FxBvIROpJVUx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MMfJNY697V68C8GKDcXG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GMSgXa69bC1GuRPanH1y(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D0HSxq69gbeKTRkmn1By(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g7nyrB69fIGbbCjAHY0n(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LMMiv769j2dp34WuLlZF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lZOVls69etQncIyU3bkq(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FggRdv6903pKtpQ4kMd0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uNB5TB69PLHiKGRAxTbp()
	{
	}
}
