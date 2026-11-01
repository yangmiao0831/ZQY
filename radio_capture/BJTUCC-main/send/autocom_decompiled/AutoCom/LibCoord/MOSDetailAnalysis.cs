using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LibBase;
using LibUtils;
using ZedGraph;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class MOSDetailAnalysis : CoordinateWin
{
	[CompilerGenerated]
	private sealed class bNiq330fmYctH94wner
	{
		public double hWqP7lN7JK4;

		private static bNiq330fmYctH94wner imfW0tBsgAY4NrQq1hYD;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bNiq330fmYctH94wner()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Q6LP7IXVVbD(PointPair t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool NHMP7QtOKJc(PointPair t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static bNiq330fmYctH94wner()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			Cfu3i8BsPd1ymHpkT2gF();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HJBo8YBseHNAlsLPtx4k()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O6SwuQBsfasCJjGku6NZ()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bNiq330fmYctH94wner pmPpeiBsj6Ctaa9UvGsT()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double pFAb0pBs0I2ZA54waFff(double P_0)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Cfu3i8BsPd1ymHpkT2gF()
		{
		}
	}

	private FastObjectListView ljMQx6eYSB;

	private List<OneMOSDetailAnaFile> uBeQqiRXUo;

	private List<OneMOSDetailAnaFile> wqEQA5JRkD;

	private string OXfQYMW7dR;

	private int QImQHrOj6O;

	private bool rd1Q3evAQC;

	private WavControl ud9QJ7K76Z;

	private string RUiQrjgjjd;

	private string SHTQ9rS4i6;

	private string tViQ8jaR5N;

	private string nQiQUULRo8;

	private SoundPlayer XMmQK9EtX4;

	private Color b2BQt8d65v;

	private Color QZ0Qut6wZF;

	private Color tm9QogWhs7;

	private Color VqiQj0gX5N;

	private Pen VviQ7mboZw;

	protected Graphics GraphicsLabel;

	protected Brush StrBrush;

	private MOSPOLQACalcSetObj FP1Qf0mYJ2;

	private Dictionary<string, POLQA_DLL_RESULT_DATA> PWGQDSpc9e;

	private Dictionary<string, Logfile> D6YQBjnIuS;

	private Dictionary<Logfile, string> NOEQSc5wuH;

	private List<OneKeyStr> iUlQmaVvDV;

	private List<OneKeyStr> pWjQIO3gFD;

	private List<OneKeyStr> hjeQQIsIci;

	private PointF AqkQlQ6xD1;

	private Logfile kOAQwaxXGC;

	private long Kp3QprEhw5;

	private int munQaG5CZd;

	private List<int> EyOQk3eJwW;

	private PointPairList SLmQ05kqe2;

	private PointPairList FmeQZvJqWr;

	private string VDSQzMiao0;

	private bool hZqlCU4Rvy;

	private IContainer rPIlGmpdjh;

	private Panel L8GlR9Uofa;

	private Panel WIblnAbvfL;

	private Panel xjhlg8EROf;

	private Panel XtolebTIf8;

	private Panel tZclP4nc53;

	private Panel BXOlEvrny9;

	private Panel AAmlytRTTM;

	public DataGridView dgvParamValue;

	private PopupMenu eG2lcI31uV;

	private BarSubItem pw5lLikYKD;

	private BarManager iDTlvpxnVO;

	private BarDockControl XgWlsfyETB;

	private BarDockControl uGKl6Su0UF;

	private BarDockControl xZxlh4TXkD;

	private BarDockControl CrCl1aHrpP;

	private Panel aCsldpyLb4;

	private Panel Ge7lW9d4T6;

	private Panel Dbol4TlCi4;

	private Label lQ2lNY86p9;

	protected MyZedGraphControl zgcLineChart;

	private WavControl lmZliiud2I;

	private Splitter Fo6lFJvSlp;

	private Label PeFlbs3D2T;

	private ComboBoxEdit xtrlVZSA6H;

	private TextEdit yH1lXKU0MC;

	private FlatButton noVl25W1Fl;

	private Panel nYolOLJOra;

	private Panel XFulMT5aoP;

	private Label qjKl5UeuNR;

	private Panel uLhlT13V06;

	private DataGridViewTextBoxColumn Ir0lxSpXvF;

	private DataGridViewTextBoxColumn EhblqSx5Zl;

	private DataGridViewTextBoxColumn zkQlA1AGZU;

	private DataGridViewTextBoxColumn IMjlYa5FcY;

	private DataGridViewTextBoxColumn AUDlHHh7el;

	private DataGridViewTextBoxColumn Ftll3BL7Pq;

	private Panel jPflJpHp0O;

	private Label Y3DlrFG9kj;

	private Panel CIil9uAsCb;

	private Label WkQl8qc23l;

	private Panel C6ylUNRQPa;

	private Label KVvlKrpxk4;

	private FlatButton jwgltwZLN3;

	private ComboBoxEdit rclluKKDMV;

	private BarButtonItem uuBlopddO5;

	[CompilerGenerated]
	private static Comparison<OneMOSDetailAnaFile> nN7ljvPnb3;

	[CompilerGenerated]
	private static AspectGetterDelegate tPPl7vcOwE;

	[CompilerGenerated]
	private static AspectGetterDelegate Ka7lfkHK2u;

	[CompilerGenerated]
	private static AspectGetterDelegate GJelDg1Fsh;

	private static MOSDetailAnalysis Mb2jRfN5nn6mGkoeU3Yk;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MOSDetailAnalysis()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yMCIkA6QFc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClosed(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vrkI0vHgo0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eSfIZqshnH(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HSYIz3myEp(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Us5QCmyVQO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BX6QG4JghD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cJkQRHviEJ(PaintEventArgs P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DrawCursorByPoint(PointF point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual PointF buildPointByIndex(int index)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rbJQnQqgYh(Graphics P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qgCQgAHvoL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dpnQeVfZKc(Logfile P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FFhQPB5JBH(Logfile P_0, Logfile P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyHandover(NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyRRCReConnect(NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TC2QEThoKO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zQcQyqjUtP(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void x9vQcMeNKj(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PiRQLSTXVH(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zC3Qvv3vpA(OneMOSDetailAnaFile P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Xo6QssXIv4()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VDoQ6pvfXx(string P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AGFQhKU8Yq(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayWave(string sFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bWUQ1E6VMC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int BinarySearchMoreEqual(List<OneMOSDetailAnaFile> list, int low, int high, int findPointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void za1QdNTP03()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eiVQWSaZgp(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NyUQ4WCesn(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XexQNBlbqU(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void slJQiIPZ5Q(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OsCQFkV6hu(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AV1QbFga2f(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void s5KQVZcHO4(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pNiQXyLjFR(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zR5Q2My6VZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static int IoyQOGBewO(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object WqJQMiNAL8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object C7yQ542sfP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object z5eQTkRY3d(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MOSDetailAnalysis()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		ixaXGDYYP69UsMdaqNIK();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R9g2kiN5sSpAHnlDcR2k()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XdH67uN5laE9rh7AFx48(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GCDdxSN59H8WiKHMlheL(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color SmB5A7N5k7ojhi2l2KdH()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color d6qBadN51RRja4cioBcI(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color aaWoueN5v1jIlkuZA7HJ()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d336hmN5Shftmmmy9Scy(object P_0, DashStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YcU1scN5mmlraVVCNCvT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color L4Qsm9N5IHfhlsMG1XD7()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YTurbQN5XLt3lFxpYaNS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DPbhWsN5U5EkcSRZlwMk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool N689UvN5aJ03nW7HDpSs()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MOSDetailAnalysis ODhQciN5Hs4fRxvBU8Id()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cydyeHN5OcuB8uhbW5Id(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nAPvslN55yZuk4sY9eO2(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ImhLXsN5i5QtXCQqnEqx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bW5aRMN5zXNE70Q2glUc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cFlDB0NiLiZb6nglrnTo(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AYTk4ONiNqMAkVu0cZ3h(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ucgvUANiYPM3lFBxBx6a(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void apk27ENiunB7Q2OTBRaC(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hCuMyANiyJU6QRQudaH3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mb8ZXWNi6Mn0xdVTlkBS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QcUumaNi2olXubuuIWX0(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wpYR1MNiJJwyEGbncL3w(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fhEjGiNiMCFL0dDenNV3(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tWXW2xNiK9lypGWEa4Ra(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P1RV3nNiZ0h4atEgStZf(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qfOfpqNioZPRRyx8VDyQ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jh4VUPNixkoWeQgwhZcK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ILP5p2NiAVT5Bq5BsWAb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PZvck8NitbwMiEWc1H81(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zIrnyhNiWCglyQ5GNUcD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WijJKxNiBTZPEbUOdTRi(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dEZaMwNiqBBDhvfJ6M1k(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GNHmMjNiEtdhB8oGDBdJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HL8r0iNiVgFxF3mWiZHS()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rkYAUUNiTVpjFQ5JFj2I(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nvKW9QNipdZORuH8Gt8L(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YTj2OtNiQg8QM4iCunwt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LmlWVTNiRWcQc9xiYYjH(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PAAS7KNiGmrPjpejTV0G(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void buptfxNi3ow5KrySO10y(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E8cNn8NiFJZWsDG1epwx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WCFNSENi7B9EZ5wTmmsT(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bj86tANibuhtgEYmJyEU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WYPgsvNigSB5tYgVjSxs(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qNZoqjNifMBhi5m3DrsN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void viW3kRNij2gbnE2GmxCf(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A6ExhRNie6qrJ2ZE8P8f(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VRKCeONi06XjRs8u8pUr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yFLCEENiPNaAnnTmx1os(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bBObDlNicn99ODSUhqeX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DJjVTeNi8nTfohSx69uo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FvkpPENiwkNPg7pNvfc0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ymu9I5Nih10U10iifCiL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J2edCdNi4MAqBUEsXWTf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color O5x9OHNirUHPoK3cgoWh()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lUcgC0NiD8TuerAuQdhn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wkPXEZNidSv6FdYkLa7E(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object japvU2NiCGGQEr4dBfDS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tpa9ciNinPM3wg9f4BxW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Lfp9PwNiaOQwUe8cPYEf()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FfNEiNNiHMtIieZPlyCn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ld0nYKNisjSbuAO8Te91(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y30CLUNiltCdVXRSiJRw(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r0c5eONi9BjVEt18Z7Et(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fRQgZKNikKZ6bLuB6aM3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void srXhjdNi1jUMU5ojOGsb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FtYRZiNivlleIc0fGddJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J3u1qLNiSIwC1PxiAV3u(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xr1RVENimLSyhUwgUsmh(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hjMa6LNiIG9jOFVnlGFt(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c67q8iNiXghEFAwuvc3K(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JX8oBPNiUdHPEcSOvmdx(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j0sg1rNiOLXaEsLAyUpV(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WpAHLMNi5T4svMReEWUd(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V8r18qNiiguoqQnYCX8g(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void icj8lhNizXXKEkNWeCVH(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G2xsrhNzLZWIvhRjbnAu(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rhaRb3NzNqDKKnsC5DuT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF VkiAEhNzYUxDnTVHrvGh(object P_0)
	{
		return (RectangleF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s7N0XjNzuLpdG2nShYt8(object P_0, object P_1, float P_2, float P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hWRSLQNzyJNX2DcliZPC(double P_0, sbyte P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Pjgj7sNz6eYigrLma7F3(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double FMF6v3Nz2yKl7KGNNJnN(double P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime YHvdQANzJhtrS1TEBp67(long P_0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gs3UKnNzM3hMCwFGfqN4(object P_0, int P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g80ULnNzKZdATs62HIyh(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double CQj8mYNzZXQU54E4yCW2(object P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wgiONqNzoxsdakXcDWPU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Wx5yLyNzxjUJStjAX3tG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF sbnYsnNzAhKN1EgTTYpM(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jlvkQ1NztlpAcf6PFM1n(object P_0, object P_1, object P_2, object P_3, float P_4, float P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BPDDrJNzWu75917FhZXZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cDAPsUNzBslhx29I3Hna(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pwqsF4Nzq7GtXOEFVjBu(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uFTB32NzEXiI0SyLTM98(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WCWId0NzVGn634SUaEPZ(object P_0, float P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nioLMpNzTKCAbHGteyU7(object P_0, AlignP P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TyKFxANzpnpcnbRT7JyH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zK1X6pNzQyXuITlFkPES(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zxRN8aNzRNq4ZT1qus4E(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RGyV1dNzGlNcrZZBlJDX(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gFcv9lNz3OLROsugJdKa(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n8nMwYNzF9NPSSQWZ1HF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fCLpA3Nz7u4PD4CtawwU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long bfAbD9NzbTYEj0Z8TnPT(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double BEZ1UNNzgUAvw1Ufmnul(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zinu7ONzfcfiZi7sri2k(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint qBsjGSNzjQ2UeUVL2ksV(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int a9BsRMNzeOefQ7Bvvngu(object P_0, long P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double cR2RRuNz01wRBmN5PF29(object P_0, int P_1, object P_2, object P_3)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B9jnj0NzPsREPPVWfUSu(object P_0, int paramKey, double dValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NetType vsDweDNzc9eMeqLPxAca(object P_0, int iPointIdx)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QCtFQsNz8sKs36ix9Z4J(object P_0, int eventCode, int pointIdx1, int pointIdx2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BT8F2fNzw8PUaB6I5ajf(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FE8l1TNzhrinJ4kZuJVj(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr UIgRD0Nz4RlqxNKVIFAN(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool de08SRNzrSEq2jLQ34wn(object P_0, IntPtr P_1, int P_2, object P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long HmNSvGNzDbFDntZg9gaN(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kQ0uxjNzd3h1knqQqnmS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b4ly8bNzCDBxB2fldZv4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CaI54ZNznorIK5fWihGK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qTvURHNza8wQG7uI3GA7(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YCrO7GNzHTut7KNYTxvO(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uk1nWBNzsuiBK23bVE6B(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u0wCGgNzl2bN8cNf39FN(object P_0, double P_1, double P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q4mrvpNz9ARgHvQUY38q(object P_0, object P_1, object P_2, Color P_3, SymbolType P_4)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zHwo09NzkR02fhKGUDpp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ICZErdNz1BgRY2tdy9aQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bm2iExNzvQhJwCoqn5qF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DpU4G8NzSsOvC7btjgwD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B1wKcTNzmJZMqugEumi0(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GLXksBNzIAKZhNuFELS5(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double D37U6lNzXDdGjA2DsIxb(object P_0, int P_1, object P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FgEU5LNzUCLrCKxUE0jT(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double b3WOrZNzOHJ1jHS7doUL(double P_0, double P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jcR7lUNz5qqQ9tel3T1m(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rkSa2GNzi1LA2EBIcQ7h(object P_0, object P_1, object P_2, Color P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g9XI3NNzz4rN8vJY1HQh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B1rf2yYLLqOhL6r2PkYq(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oDFlpsYLNeG2WvJ8a1FK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zRCyIaYLYoB0X3eN6LwC(object P_0, FillType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Het2bfYLuoETvILKKVu3(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double zvxAtFYLyfbUR4UlMWVb(double P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xxdXRLYL6NRdMSRjnU3d(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ksm8OuYL299a98EfdliC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LFusO3YLJECe9VqDoZcF(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CGHqxIYLMKRGvR2jWfEG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XUQHCSYLKPbBwfoXBF6d(object P_0, ColumnHeaderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HbxGM0YLZ5sjDUCLSOkU(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RE0qqWYLoPZEP4PBg8fa(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ykBAaVYLxbDYrP1ekMCj(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rhh0nYYLAJCTZ9yy4Zct(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uqlmNtYLtoZcNNHX9m1q(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fOHJTSYLWV6sfDK71CEt(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IWI7aXYLByMly2Qxmlp9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qeud3TYLq2XdeFPEcMuj(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void av0xB7YLE5B6LhEmADnY(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hYSSVgYLVj0vSOvnr0f8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ADfUkdYLTXYYHOWpOdQI(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gh5FWhYLpLJw4kTNJoa3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void we928dYLQOYSEnpKbSBC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w0yFi5YLREyAvkwm8gL9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qc9MbJYLGQ6AHWKxYU1N(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YL83baYL3NXfP3XdcFpd(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xkPWlBYLFYPsCNNLAcrY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int HEjViuYL7Y3pm8AahBRV(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PeBSCCYLbr1KdKdvr9aI(object P_0, bool P_1, object P_2, int P_3, Color P_4, bool P_5, int P_6, bool P_7)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XEoswVYLgX9nCl6JFRaC(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ld7kR4YLfMkscun2vL8K(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QqSP8RYLjncSJKSZ11Vw(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rqIVF1YLeO1EN14UYA0O(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iYxp1oYL0l4GHtgLKMEK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g8EO9eYLPE8eUOGllSaF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QZUdsUYLc03ngJVZXkwj(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bPia1HYL8SyVPkQgMKY7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object McroL8YLw7YMG0vO4GRY(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c4ZnsDYLhFZRpAuynhgb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KWOHmAYL4WfhBG9eWyf6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cSiviMYLrPTMd4LRNIht(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rLsGj1YLDlfAb7hkEhWS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jcpiYOYLdEl1Um34fDUb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double sY88n0YLC5wKlicPOjYj(object P_0, double P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FiQrN9YLnSKPvVmnTeuo(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jMVEC3YLaJRKbRYMQj9M(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NTxH5SYLHSKgUiQF0R98(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF QV5paEYLskVQQHHbCC0l(Point P_0)
	{
		return (PointF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zTDA2PYLleki9Ute3Bl3(object P_0, PointF point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eO8WsfYL9g2lbe1reaVX(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PFAab7YLklq6pwQSoxj3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TBCW3xYL1aSCAAkxJ4ty(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jNulotYLvSDnJ6l67Lfb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bWVXSvYLSIQHq7Jj6BbS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void arHsesYLmZ4ihPL1Qg0v(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T6K38BYLIdUZ1LAbH4mL(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SFOVV1YLXCZTMW6t8PaA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iXvrk7YLUbcbsI7nFX85(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I7PTb8YLOYPfyNirZuND(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iODhRRYL53ZyyyHZdOb7(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HYlFQ5YLiFaRG3L4Dw37(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QmTRpaYLzqEfdfVW7dXf(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NO50P7YNLMe1J0RctTo6(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color rrpvniYNN4L73tfD7d69()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bJq53XYNYwfA4y5XNrY8(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FhToURYNuiRKRf7cHvqv(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HgHnHiYNyfRhkGCJuR6m(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JXlrQLYN6u1aVyfc0g5L(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aKd6NVYN2IMOcEmSiq25(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w0mmF4YNJdLB7XWU0Top(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void edOZYVYNMGfVEIVG4of4(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fL6GWDYNK08U1i9ajC9v(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GSCZAgYNZ0x7En8xYOwZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PDPWoUYNoMyM54Q0RKJg(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FR3SIZYNxXfCnLinC6Dm(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color kUWUaLYNAlyxadILK6pA()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IpT9VQYNt0KAAJbfersu(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MiTXqMYNWZuVMovErwr0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pX6vbjYNBE4gA3VgisXN(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t1SCHWYNq7kjlMNiUV58(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EpsmhmYNEsqOftIyVc7R(object P_0, TextEditStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xI35mRYNVWA9upx4SmJ2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ueRQPsYNT6CEBbwSCGun(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color mv5xFlYNpAOqtkm1dOVy()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aZRIthYNQJm2cyKIcxeJ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void se9TpbYNRqQ9nT8Hn6pl(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l5n8XrYNGAgIRgI70aqy(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PmpH5UYN3sYK7fuCwm0y(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MqGLBrYNFLeAxIKLN2QY(object P_0, DataGridViewHeaderBorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ueMPjvYN74hvPUYEHsOb(object P_0, DataGridViewColumnHeadersHeightSizeMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XPP5rrYNblIqgINs7XkS(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color zuERllYNgYiXQLwS2tXH()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bcOCK1YNfY0wYoi3v7y0(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yaTuiUYNjNWH1dFuGdGm(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kcrhYSYNe0ncT7uXxG90(object P_0, DataGridViewSelectionMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nTaf3cYN0Q5TXVaqp6Fj(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KolcOpYNP7DK7ILtmNOT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A7yJ0rYNcSvClFISCf04(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WEW2SSYN8kWGDPtvak80(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BLrBgFYNwKLyvnx9KVJ4(object P_0, DataGridViewColumnSortMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EQiJXhYNhajC6lvOeUfn(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gyRAP0YN4uJ47Pxx80Nt(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZfcNxYNrKwGMNFqpTal(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tWTOuYYND1YA4meTaeFO(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void prJ4P4YNdEdv8MnMsree(object P_0, Keys P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Dli75QYNCj6APZkBhu9o(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dpPR8dYNnqnye8W9Ut5N(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V3pP4yYNaAeyrNR2S1i0(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l9GpqnYNHeLrCgL4xs0f(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VxkuJDYNsNMYU07RmBMH(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DvAQX0YNllMZjbMJRB2Q(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YHhgCiYN9Exq1go0J3t3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WqNYIDYNk9u5f2KX8ULi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EgmQpJYN1Z9plBHw6InM(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Oh2ieoYNvpWvRQ5q5exZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y5QCUkYNSkNPLqveFTCY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FaF1hwYNmDnHMdenrmoJ(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JGmhRtYNIQkp6iGE0adN(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BmVsOjYNXuNgT1Ycb1S4()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R7LaJTYNUGuuQGkrw4JB()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TYBCWQYNORwwpXB2p01p(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r6pYa6YN5ZWIisOol3sL(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Lw9o3IYNi0Cdiv0OreCv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pqLM7hYNz8HCNUF3gGPR(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color yYQBuQYYL8Zn42LxiEHI()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color WfMhkDYYNoqxFfa7E6tT()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color bynXs0YYYg0naMtoQR0X()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color T3wKQRYYuBMG55twLv37()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YfHDwMYYyFwpiXOQZUa0(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jglnt1YY6SKowmi5EPxR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a1EYKvYY2efAxlQVbVk8(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EVWUirYYJH3Jk6cwYTl9(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bad9fUYYMjxwIk0S4htb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XT6vcIYYKmtia04ilSIR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hqa2kcYYZN1mdfSBwe7O(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hXU9SCYYoIK5b51oDDHD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s58xeTYYxt29ZeGY1YNT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xVy4D4YYAf2DggQM2wJh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D2A7gXYYtFMLKpMSMpxV(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dyC1ZuYYWfaBb3dThh4E(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x0AhljYYBWRTVM0naUHM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nHKw40YYqZTGnXImfquL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UbpLZvYYEywkcjwluhmd(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N8HvA2YYVEkhMbRe2QJx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xjyD18YYT2cqxlKVNfZs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Blx6GXYYpsk8Mf3XEFHt(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hhG6MRYYQPOeZOW0E9L9(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gRUKiAYYRaHJpjBlrKSm(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qYr64IYYGTeGK8N6Lf3S(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zN4oewYY3bXBQDdto980(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AVKjN6YYFbRrUYCSrt7G(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fNPeD2YY7bG4TvbCZrhF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kgO1ppYYbff3gaS6IwiX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hw8Fe5YYgcLmSU5kt1oI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R3QCejYYfqExhFmgw4Ae(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IeWRZuYYj7J8h0Z9C0PZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QdgCvuYYeKxro6IZMITW(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tF19U1YY0ZcOu4pJ2dy7(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ixaXGDYYP69UsMdaqNIK()
	{
	}
}
