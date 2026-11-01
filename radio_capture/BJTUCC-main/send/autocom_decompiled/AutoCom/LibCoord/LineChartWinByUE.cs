using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibBase;
using LibUtils;
using ZedGraph;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class LineChartWinByUE : CoordinateWin
{
	[CompilerGenerated]
	private sealed class NceBg6KbfhrH0g4tFmN
	{
		public Logfile CS0PlLjBO4A;

		internal static NceBg6KbfhrH0g4tFmN TJeTLdqN8bysdNIKB3rT;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NceBg6KbfhrH0g4tFmN()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool K5cPlcBuqtW(Logfile t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static NceBg6KbfhrH0g4tFmN()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CMaH4sqN4ZBFZmNMxpUK()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool giLTRGqNwL8nt0PKO0c9()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NceBg6KbfhrH0g4tFmN QPNQZfqNhh4LGLrGorrK()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L87K4uqNrSO0mbpUCE7H(object P_0, object P_1)
		{
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class DZLlk7Km2IHt8bcgsM9
	{
		public NceBg6KbfhrH0g4tFmN dTrPlsaMYRB;

		public int c1uPl6M3A6o;

		internal static DZLlk7Km2IHt8bcgsM9 UhyUZvqNDWXnOvsbahHl;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DZLlk7Km2IHt8bcgsM9()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool UqQPlvynEUd(EQObj t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DZLlk7Km2IHt8bcgsM9()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			R8Yl2SqNnLKyrZOa3wq5();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gSgG9CqNd8jumA2PeHqM()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DZLlk7Km2IHt8bcgsM9 KU1koxqNCKSOGH0FbSQ4()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void R8Yl2SqNnLKyrZOa3wq5()
		{
		}
	}

	private Timer BqAROlfRh2a;

	private Pen R5gROwCsRVv;

	private Graphics jteROp3HyGM;

	private Brush gA6ROaIMUTY;

	private int yUjROk9DHgL;

	private double Mr9RO0ZvElH;

	private string JpwROZxjlIx;

	private double oCDROz6kDfp;

	private int[] hMKRMClHAxD;

	private int WJdRMGMdrHb;

	private long CgTRMRMjgw1;

	private Dictionary<Logfile, int> LHBRMnW7Mu2;

	private Dictionary<Logfile, long> gPlRMg1eDIj;

	private Dictionary<Logfile, DateTime> ns7RMekpMgs;

	private Dictionary<Logfile, int> rgnRMPOinks;

	private Dictionary<Logfile, int> IScRME7E381;

	private Dictionary<Logfile, long> vQHRMyy3i4G;

	private Dictionary<Logfile, List<double>> XNWRMclIQOC;

	private Dictionary<Logfile, List<double>> GmORMLYdwYh;

	private Dictionary<Logfile, List<int>> pVARMv57bIT;

	private int my9RMsxg76G;

	private int Nj1RM6RFyNK;

	private PointPairList[] KFfRMhdyAV0;

	private PointPairList EfBRM1qDqK6;

	private Color[] D2mRMdxB6Ne;

	private int W3YRMWD3J1y;

	private int C89RM49HPlp;

	private bool ymlRMNvfwRB;

	private DateTime MNWRMivCyC7;

	private long uiURMFDIY9a;

	private int sCiRMbc15TS;

	private int knWRMVQMx1S;

	private XDate MXHRMXEMqQ6;

	private bool oeyRM2jA3WD;

	private bool ynbRMOu1904;

	private bool eNNRMMGMH1l;

	private PointF sfxRM5Gkcxl;

	private DateTime FBsRMThjNw2;

	private DateTime tRdRMxnXdqV;

	private XDate DrgRMqhrDES;

	private XDate JZxRMAOAPdx;

	private SelectLogfileWin rNvRMYxJWSI;

	private IContainer bOyRMHcsgAZ;

	protected HScrollBar ScrollBar;

	protected FlatButton fbSelectIE;

	protected MyZedGraphControl zgcLineChart;

	private PopupMenu uf2RM3HfsMN;

	private BarButtonItem RVbRMJChH96;

	private BarManager wTZRMrN9g5S;

	private BarDockControl E9gRM9pJv4J;

	private BarDockControl M0ZRM89G4WW;

	private BarDockControl Q1mRMUDK8Ek;

	private BarDockControl aOYRMKy8ykx;

	protected Label lblParamValues;

	protected FlatButton fbEditRange;

	private BarCheckItem sppRMtgcW0s;

	private BarCheckItem VJRRMubQSF6;

	private BarCheckItem ERBRMoWquvt;

	private BarCheckItem HoGRMj3EAhv;

	private BarCheckItem qIKRM70WDvI;

	private BarCheckItem vfFRMfrvqCJ;

	protected FlatButton fbSelLogfile;

	private static LineChartWinByUE FMAt7u69cyfuoEUi0qPR;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineChartWinByUE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void N5qRO1yyhXM(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iVoROdkJHSQ(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UFiROW6qBEB(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xc8RO4gHnC1(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DelLogfile(Logfile logfile, bool refreshUI = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YpDRONjfN2u()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KU6ROiuIay8(PaintEventArgs P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void srJROFIxu56(Graphics P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AkNRObiYf8E(bool P_0 = true)
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
	private void w8DROVwi2eI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateAfterChangeParam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vNSROXdT8y9(Logfile P_0, int P_1 = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yvTRO2O6fUT(object P_0, ScrollEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ODKROODJBt9(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BUpROMp83KG(int P_0, Logfile P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nuPRO52dcc2(Logfile P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JV5ROTUHATG(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double ituROxprHmG(PointF P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int lSxROq4kAjL()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PointF JMGROAnTMPC()
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cLEROYdXQH9(PointF P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PQnROHJ935j(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAfterSelectIE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void t2QRO39GsSp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QOEROJQYd7D(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IjqROrIXB5S()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tnYRO9Vkvnv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void L2uRO8oPuLx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Xt8ROUSMZmN()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BKNROKmhNlm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yUsROtUpPCk(object P_0, RunWorkerCompletedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoMyFormClosing(FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wjWROuCeKDT(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gLPROoxWP22(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void b3iROj2PWL8(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void v1HRO73WFED(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KiDROfKqRch(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void LoadWinKeyStrFile(string sFile = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fobRODX61do(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessDialogKey(Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UjvROBBWjfx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void J8iROS7pfnA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void w1AROm2K0ky()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void e36ROIhQMpe(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void U8vROQ0xnwm()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LineChartWinByUE()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static XDate O95y3269hFP0dIq3HIuj(double P_0)
	{
		return (XDate)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SZW47Z694WV9viTwW9pm(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QR3ehZ69r0gNWZeBhY1t(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eaLC2q69D3FlqBtrDlZ1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color xqWEx569duTq8yF1XYpI(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TUJnTj69C2IqsfFsstc9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xpteYH69nt1bWlvPI1PM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DJx9CE69aJFNLsyqcAIy(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jyV4Wo69HibgQK316IIn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hhb4q769sSN4hlqLxmAK(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QSC8ts698jAmwvXNOpdG()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LineChartWinByUE WJo4lg69wV5Xf09NoUmq()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VGCI2h69lc0bRHoC655S(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RtXvkJ699xjcPb9l0EhZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Keys b8Tp8C69kleX27C5Jcqo(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q4sVHc691v0tXwYcH30I(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u6uY3069vJjKgyWL1CiS(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ASfHq869SbE1DvbxKueY(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g6trFh69mEMDRb6yFE5Z(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object piFYtc69IqjFr25f3S1v(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YyIMDE69XLOI21W9MCVP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cF6PN169UKMrBs4nKyy9(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zF9OnB69OmN2Xr0kgQeh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color zBKc2k695ExmkrcRadot()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GbUO2f69iKVQcqsRmCxG(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xf7CJo69zbQaK3HL43im(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color wX80fq6kLBwtASqqVgNr()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jZJGOp6kN6K7Qp8qhQ8i(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LGqJGv6kYEGt50dGEcJl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jkfoPb6ku9VcALJiunTo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DThpdX6kyiRAf1eyisWP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wvwy7r6k6xHSFvZ2Odsd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ycsC2d6k2jrOE73AYXl6(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ltq4sU6kJaR7eaMI87cT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SOilWo6kMSZyNV1Yr2gg(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gHBTDk6kKvIolGX71J3P(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M78sBx6kZgVtoeApCVVU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qqMWl36ko6dMwWr1Tovv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kqcaon6kxRspORmpVNpF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WQMRSn6kAuus2ivgqu84(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bnUJ7e6kt5csox6kZOO8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fmkoA66kWOkfReBGcEI3(object P_0, DateUnit P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CblHKS6kBWQevp83hpdN(object P_0, DateUnit P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YMBMeb6kqyC8S6CN80EC(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iGrksF6kExfUhghJ5iCg(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JASg406kVvfiyRPZgHxw(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h7XQuX6kTx83v9dp57B4(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k1hVsm6kpHq56kiqai2m(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x93F2E6kQynxpwbyIPw6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF YX87O16kRrxRM0qxiKL8(object P_0)
	{
		return (RectangleF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L8anJj6kGf765qxeaaxs(object P_0, object P_1, float P_2, float P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF DDUmPH6k3XuuvJ4skRMc(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C1iKTp6kFCHy6HtO8eQ3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cYDR1U6k77nM77RRtU5t(object P_0, object P_1, object P_2, object P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DgPGqU6kbS9G2cpvVUOZ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime XguUOk6kgoCHE9QleEQu(object P_0, int P_1)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rqjGR66kfvJUMlAkdvQO(DateTime P_0, DateTime P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vkpJwt6kjFUM9mtKt1RS(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NmjGGk6keu2Gp1TlaDj5(DateTime P_0, DateTime P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan EfAtgH6k0E1U9gnh4KcU(DateTime P_0, DateTime P_1)
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static XDate ic4PDF6kPgQCRKQgJl8F(DateTime P_0)
	{
		return (XDate)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yfEy5R6kcfInVoA8A0HM(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oxu9s66k84lpCQahvT9W(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int j93ACM6kwJCihbdawdYx(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fZOgHf6khlXu76yD9dNr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double sCjM9k6k4wDmUyIyDYtA(int P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xTQ2Bj6krAjsFMWA5brD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c9dcMD6kDmKoE0WEV2qe(object P_0, LegendPos P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IX7sgr6kdd6Rd7Zmrg9t(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eyV7Pd6kC9kBBdG0DeXE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BUL98J6knj7UggVAu0oD(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SUm5Ay6kaA2tadJvnpXf(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vpjg196kH3Ib84YkoDZH(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iYUZ1n6ksIshJgydiZIY(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dUnZuX6klYDPtrPtxCFM(object P_0, AlignP P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q7jp9Z6k9gmTqQC79HmB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UJgI3x6kklvjo4rMpXX0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fJUda66k1gLP4JmsyTYb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OFV0iL6kvHOMPcd6BjMU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yGesPN6kSfy1gw5BXNOj()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VoWUxt6kmkFPsLHrt7WL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oybAJ36kIfRS5wEPm1hl(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jY8OWB6kXFBmJEpyhEGc(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr lZtnJx6kUYHX5wBv9Uxo(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime TCJhTu6kO9ubQcA0ZYJp(long P_0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double GD8nGr6k54g3kAvDM5MJ(object P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Yi88xf6kihQjERhAm4Zi(XDate P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AiLuLB6kzeO0VBJM17hJ(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NHVfon61LHMbBN1Xxc4a(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Arhcri61NN5JtpqSJIcy(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uZ7qti61Yfl1JBi4apFB(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AGF3wc61uSNTwKVkJTIF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zdQwTm61yuL1DCUs5Ujo(DateTime P_0, DateTime P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NIRw8E616NMxLaC0iBxV(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Oj5MWI612D8DKYSeoZeY(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qO8gDP61JLubNP316TdU(object P_0, double P_1, double P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oICjRr61M3i88IYHrXHZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zhe5SQ61Khpk3lV4fPao(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HY16nH61ZFD1G9nIE0pB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mBJEKS61oyrHPDRudC8a(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MjxbnC61xnUrwnPbJghZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point kNEjpV61Avj7oPfPhpA1(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF tM7ur061tMvYIuc3lBnT(Point P_0)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PTY0Ke61WvNLxTogF8TR()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H2P7Uu61BWL8D6gSfOgM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P8rDwq61qRbNwsNmM2iP(object P_0, PointF P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NetType b6nxmQ61EDZe0Zhy2m2V(object P_0)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NdfprO61V01PjTb2voNu(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gRxYDC61T3GicWptvU5d(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lHZ2px61poD0Fjj3eYwL(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iSHMAS61QmrQGrf0nlMw(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpfAyV61R144JVmMdiq9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MNZxDv61GTYPHwWGacxV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Itxy4Y613MEoCHvnqKpM(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gKqOwl61FrbxD7FlcsTt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y2jmL3617ytX5aRZ9DFg(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cGqbYb61buIIO2xg5WTy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qgR3S661gjAWfdybZRLd(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yyIWil61fkV2FZ5cljXC(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EYYIA661joqCqo7T5VT0(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double q6cLm261eNMhWi7KNaST(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RF8Nko610t3da30g4240(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void emlS8d61P94NUbLSwjQw(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V8HZZ261cJkQFHwZTWeA(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hcg6Yd618tVtsrts3rnk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I6PMlg61wCNGlakZCwsp(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CDKeqn61hff8bCCZe6aa(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult ItLqWn614YF17tejbxNK(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wQFhlg61rFKRsVQQ1orU(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int a4QlS461Dp2EvywGWu1W(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FlOR8361drNZDMtetwuU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool d2EoyB61CRBFeGDg7HWM(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lYIUxF61n1U3mRBIeVv7(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ULhAPM61anoS4yL6OGZQ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rB89mH61H5rMcvParZim(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jh20MY61sg7UxPBnA12Q(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zFvgjC61lsw6L7sWRfD3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IHinrU619rg4utZ3FmCL(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long V0facF61kb4C1Hfux3uH(DateTime P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int v25YFb611cwUhxrftKcg(object P_0, long P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A7wyJG61vjQOUPJja0AK(object P_0, object P_1, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool d2kEAd61SvfXqgvFkIAy(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xxTG8j61mAsaiuT5ktmB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pPGNsn61I4SLTV8TbKKU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr prqXHm61XM128ZtXEh6W(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q1P4pf61UEkRVnDpIC8Z(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void waQC6E61Oinpoh49C1wu(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BmUmwK615gowJb4ykPoI(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gtCR3O61iUHhCntGtgSK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tAOVQk61zVmFfislxB0P(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rqJ8OV6vLZeAGdR20tCv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pTd83l6vNTddoYUsitkK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tIRMP06vYVw3200ORFL1(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Cr4UtH6vuolx2dUgVBMH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DwuFB86vyZo7lVI4dmta(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IO70Aw6v64wGF7CacEJ3(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void chttaK6v2fJ3FNGMIIna(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MIokWR6vJUS7KA0MU16m(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YG00Uh6vMcaO4AlGyr6r(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color u9Lg0Y6vKpUdNPKsJ5RS()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tpl26Q6vZAjCBVVpVDZ0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EjPMvw6voBMKNPwRSaxZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kr3uB06vxTF27xJew0BS(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KQHODt6vAJjjioLpXjlr(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lmeknM6vt7kb6QU1KnmT(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G1Xae06vWWI0XyDIqPun(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ARjt776vB9v3H62tQl9M(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sukjW96vqeLJjd7ZhjKD(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EyUYlE6vEiBXelrVDJE5(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dODt1C6vVnpB7HpXHSUU(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fqP4lZ6vTCFiCBqHG9OW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WSClA46vpu4XEq1n5Scv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LIsGbl6vQVudjiZlQvT5(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uydrD46vRBl5jIVO8DbF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color OXGCBe6vGSdm5Mqm52Zr()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gJpkYW6v3JPoGSDQWXq8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BNByPx6vFp7bVLRak2pb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V0uj4I6v7yBqxsxlkuEg(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ik2LIT6vb869r1QlJFfd(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kqlXIU6vgWoJeRLlc9Ev(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iRl6oG6vfS6Jx6VQij7b()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xvu9XG6vjvC58GLOXEIY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HrlSSd6veTnLXb6jeH67(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PSb7ln6v0w3s2pgAACCu(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lTdo3N6vP0xdLFSQ787v(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void byuKou6vcI3k6Tlwrn0O(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eApiNL6v83pWFFfvyZLO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object asE5XF6vwjucggXYSYZC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rJ9QCy6vhgC6K4PH34jc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NYTNiy6v4hrUPlDAEyDs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z0UyNC6vr6NVxJWvJO61(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UAkm7S6vD3I4929l57nL(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CMEFrB6vdj5rRXOK0bq2(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SYUcjx6vCCDZnX8grSl0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DqrPXR6vn952sb1DfSXW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xf7epl6vap0QWpoUbQpY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W1uxMx6vHluoMt5gOAR7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int F9Xi416vsVB7rVn9sA85(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZTDdO6vl2cyEIGIfhfw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iyRxu06v9mnNFtYj2UiY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LOaF3t6vkkpbRxcBqHFl(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QltG5j6v1kf6hfxV9Yqm(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wn5qrP6vv2o0dqXatI7q(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xD1yEh6vSN9gFvIX1iv0(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KHTaqy6vmQUPpvUHNbwp(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YXpIlt6vIAynLck3SAGW(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void axQCLJ6vXLHcnwUNRsf2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color HIffqw6vU32C28OEP8VF()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HUN3YW6vOvCuB5w9NLxD(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UVw8EH6v5N4ID256k1Mu(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JLPVJ06vij4WykT5uxgd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yuWr6u6vzVrIbXFhPtiO()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yHWNY86SLG7CPOuh2cvp(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void piuBhA6SNN2ZKl2IUs07(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vPZ0xe6SYA1vNi2kGTI0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color zmFuIo6SuOK1heHKbDa0()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bEpoRM6SyWYwnD9esjWe(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MvIDOP6S6b6omPL2Dk0U(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NEwBpD6S2eCft0WjYiT4(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dCZqSN6SJxBmYjXFevkm(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aCjYHc6SMuobMHQjVHYc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yr6nDq6SKFwwAClvG0XD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QiRQgO6SZRuRm7N6GPTs(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MrS2sw6SonV6rMhM10RZ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vxd2SY6SxUvEE29eQuuL(object P_0, bool P_1)
	{
	}
}
