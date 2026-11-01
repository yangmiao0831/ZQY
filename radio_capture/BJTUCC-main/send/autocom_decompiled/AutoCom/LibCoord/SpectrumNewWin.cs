using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BrightIdeasSoftware;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using LibBase;
using LibUtils;
using ZedGraph;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class SpectrumNewWin : CoordinateWin
{
	protected delegate void UpdateControlDelegate();

	[CompilerGenerated]
	private sealed class lbD0F0xcvmNZZ7sZnFW
	{
		public uint mCsPakEJ6UR;

		public uint mSBPa0cAmyh;

		private static lbD0F0xcvmNZZ7sZnFW Jex37dqZk0RcfSVBMjbU;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public lbD0F0xcvmNZZ7sZnFW()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AhDPaaqyv7b(OneKeyValue t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static lbD0F0xcvmNZZ7sZnFW()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			NNLYbRqZmNLboxo8hFxf();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hcqiqnqZS4TkhrmFtyYU()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mcGywpqZ1XV8SPsyktGu()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static lbD0F0xcvmNZZ7sZnFW FrsGseqZvxiINb14pvMw()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NNLYbRqZmNLboxo8hFxf()
		{
		}
	}

	[CompilerGenerated]
	private sealed class WfRdadxoHdth49sgBVt
	{
		public OneKeyValue kinPazZd2ir;

		private static WfRdadxoHdth49sgBVt Ip81onqZIVsVdZUrqSve;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WfRdadxoHdth49sgBVt()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool fvcPaZy4VkU(OneKeyValue t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WfRdadxoHdth49sgBVt()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FchsCoqZXMK8lhTUGnA2()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WfRdadxoHdth49sgBVt T8cKPSqZUmLwp73uANbh()
		{
			return null;
		}
	}

	private PointPairList J5NnyUqi1Oy;

	private float KLfnyKuVI21;

	private float k6unytfrnQg;

	private float E1snyuLysKG;

	private Graphics Tf4nyo0Csuo;

	private bool Fmtnyjr4S2V;

	private uint SC8ny7BtmFt;

	private SwiftPlotDiagram XgdnyfcTlww;

	private Series xISnyDu2GrM;

	private Series wjdnyBTRlsV;

	private Series a4enySxAVSa;

	private AxisRange IrHnymdqGwT;

	private AxisRange FR9nyI1x0H7;

	private ConstantLine hMmnyQuxgB8;

	private ConstantLine nFGnylwiT6M;

	private int BnTnywHSrsl;

	private int ltxnypbpo0W;

	private Color ALtnyaQoo5H;

	private Series O6OnykJACFa;

	private Series Clsny0rUpWG;

	private ChartArea qpMnyZEN2U6;

	private double RoDnyzjPV2m;

	private double dapncCCuG2P;

	private Dictionary<double, double> a5uncGHUTC4;

	private Dictionary<double, double> PsSncRF6At2;

	private int RFXncn9oG2e;

	private bool iLEncgUL3N7;

	private Thread D1Dncevneqq;

	private bool F6cncPo37u7;

	private string Wo6ncEWKjMm;

	private Timer uXsncyFK6GH;

	private double oE6nccPcWey;

	private int qcVncLpxrN1;

	private int yoRncvKdXeF;

	private double mOWncsI0sZ1;

	private double OBOnc6AFv24;

	private bool q1YnchCPHid;

	private uint xffnc1cNWCE;

	private FastObjectListView Sq5ncdcduER;

	private List<OneKeyValue> RLhncWcTbH2;

	private List<OneKeyValue> D9nnc4kmJca;

	private IContainer j5KncNw56ph;

	private Label exrnciWGxUE;

	private Label VQuncFEAnPj;

	private FlatButton A4UncbkpZCR;

	private Label TTFncVqo7Fq;

	private SplitContainer gpCncXvEUaG;

	private RangeControl zVWnc23QJmd;

	private ChartControl P1qncO54npX;

	private Panel aaCncM1K9Rn;

	private CheckBox PGVnc5hw28a;

	private Label wLEncT894aN;

	private TextBox iwMncxFiXGF;

	private Label wFbncqBWKjH;

	private Label AkdncANu19f;

	private Label JBCncYjZc6o;

	private FlatButton kPEncHK7HXJ;

	private Chart APpnc3w6uFn;

	private FlatButton hJ3ncJHwxdx;

	private FlatButton aq9ncr01pWZ;

	private Panel Ofknc9pSAv3;

	[CompilerGenerated]
	private static AspectGetterDelegate Aaunc8fFWij;

	private static SpectrumNewWin lwa2VYJZ2GuKXTY3e094;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpectrumNewWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoMyFormClosing(FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NsknyyATgYL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dd8nycSgsl0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetBinBuff(int pointIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool V1anyLX9bn5(int P_0, bool P_1 = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void owXnyvRGoMf(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jKOnysJYPl2(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gyUny6rYclN(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RK6nyhbVJXX(Dictionary<double, double> P_0, Dictionary<double, double> P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ratny1waKHu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void updateControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mrAnydnoKFj(int P_0, bool P_1 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bDCnyWsjEHs(int P_0, bool P_1 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vd6ny42UHsH(int P_0, uint P_1, uint P_2, byte[] P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vERnyNpBmWk(PointPair P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hpRnyiWu8jy(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LWnnyF5vuhf(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KkInyba40G8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void USTnyV9uesX(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void m1hnyX43Rtg(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool ProcessDialogKey(Keys keyData)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ujVny2UexKo(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qcSnyOUaCF1(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lydnyMZPAac(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JJAny5Se1Qt(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SMenyT2EScV(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ayWnyx1ADvH(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ySZnyqkasoE(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eXJnyAbjcaN(object P_0, RangeControlRangeEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GrLnyYaX0DC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CAERI_Setting()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lMQnyH1CJTR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Lofny3CAjhj(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QKxnyJHnBMl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void U4JnyrHGOtG()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YKmny9brq72()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object SVWny8nVwA8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpectrumNewWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		O8YvcfJAsky6EHWInaN1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S6VqZmJZKyOs6Flg4UZ3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color fd2agcJZZscktvJ6JmA4(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t6UX7FJZo2E7HM5lMZZO(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BaXfr9JZxrNnNeQQHWIm(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JGIU53JZAOonfW7iQ3qp(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H8VqU3JZtcqyYiPhw34F(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CC97s6JZWrCiW3i0DGB2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XrLHOrJZBoacx5FnrbUj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U3uarqJZq20gYMTAlUOJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Pe3D24JZEWen7UWimrtc(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HbRQVJJZV1pEYV7EL0Mk(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rRF7rUJZTL5ItJWSvdRW(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lJ5kEbJZpk750BZI5XJo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point eRlDB6JZQgJdkPDGMXr1(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SShlY9JZRiSsLrPCDlkE(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PVnFNIJZJPZUjyDOa5PV()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SpectrumNewWin Gg70bxJZM2xcimd0PaXV()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pLfYSTJZGqPG2uc0VJZu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LCJpHsJZ3nVA0CIMXZ57(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mK8XMXJZFZuMugOnH1G1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d231iwJZ7TBOg1Ghy5XD(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rv9XSmJZbnEQJl78QdCY(IntPtr P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dta2APJZgXW9qHDGl5p3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QIFnemJZf9UddCd050XL(object P_0, object P_1, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Nu01uCJZjYZscFkyxXJx(object P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RKAhiUJZejZFfkTjEkd0(object P_0, int P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tqe2vkJZ0CwaO52GPpqA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m3eXHuJZP9SeVHhvWNYN(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xpJGLkJZcd5epm3521Ef(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PD8xtwJZ8dvbGAjXcxge(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IbvBgQJZwlRugNYV3FxC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yF6Ts4JZhue7GbMhArrZ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float QA26BSJZ4nEFpnbbC4ms(object P_0, int P_1)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int e7RIvuJZrLAXquqHyePQ(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double MvE9yTJZDv3yYVEDF7GJ(double P_0, double P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double I19dWMJZdrjYRxcNnwGb(double P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EYeTBxJZCDBwPxoCbrqq(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FQAXvGJZnUKKQdXawj1C(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UmjPs3JZaTO725BFELnB(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr vf0iaUJZHlaED9CeQjfk(object P_0, object P_1)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double G97NTXJZsXJfPtM8Up61(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double gI7CRfJZl3nb3nnIvQPK(double P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b4SE8TJZ9rKf9hZMdVDP(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NCoMovJZkxIgRNAvW4LZ(object P_0, IntPtr P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wthxBUJZ1CSZM0tI1JNY(object P_0, int P_1, object P_2, object P_3)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Hx6T6IJZvUZy9ktJEG4e(object P_0, int P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr LH67ykJZSyvA84bJkHkK(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double gbCB7fJZmEHeDwx5SZ5s(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fo04hcJZIbBc9pwKX668()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bdEdEJJZXAUeOJ9vl0L9(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SLDyISJZUkJfj4HGwZys(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BLne5aJZO4jGDAlsq0Qk(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int m69WWXJZ545PAFr9UFiy(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JnG2BUJZi3le8dYGjAk7(object P_0, double P_1, double P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kaI5m0JZztUPy8fXXjKX(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint w004ETJoL5SD95HLbmyf(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nF9ZclJoNWlXWvEHQd5r(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int k1egGcJoYJTwn3W98Znf(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NuH6Q3JoumEXIM383Od6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ux7HldJoydZKHeM19qs4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F5m708Jo67ZpZlo1uldK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oajoDRJo2ZiGSRva5Ggk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ga1UU6JoJ9dklWeexIGq(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WuLiIQJoMokx5AJwEEHS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object usXF8bJoKb1ZfnsvwSs0(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RnSlUiJoZuBTA9pM4Cte(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF v2J1CCJooDxjOATI2nsC(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ghON2TJoxeVJNUf34h2g(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kUa0X8JoAq0hdHh0TItW(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Cxcqw3JotAnTwr9YrCH1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XQe2TkJoWpS8TJcBmfhf(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i7N7IbJoBR2ZkdLnoTiS(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tVEMFrJoq0OYgkuWNWT5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RSqrhhJoEs1N59dnZ6P7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void reNgfVJoVdu2rJKOkiaD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NLFT7iJoTo3lgwnYE657(object P_0, DockCorner P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MiQ0ftJopNy74RNXhXF5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pip55qJoQ93rjHiq0FKw(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kLoy92JoRh546mY0BANI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u8BurjJoGrfGKdaW3vgd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IXi6p6Jo32qPKvH9jFsL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FaHGeIJoFZeCqSim5qwQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kH9YmMJo7urVnsyxpP2a(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AjGODbJobsm43Clhm9UK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object STlrgxJogsJVJeMFsPcy(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void naCfuKJofBb3mX466g1n(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XXVfCgJojlanOp3wyi46(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ew9Sd4JoeCUDEu6Tw6yt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I6juo4Jo0uQA8pim12BW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rZ2h6MJoPncffrDhxxjY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LSVDJSJocr42B9tH481R(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color QjCFbMJo85Sj1a36jHDy(int P_0, int P_1, int P_2, int P_3)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x9f5vWJowYgpsumshhCB(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uPjmarJohpaSddjjsAH7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g9WNF1Jo4iBBcuCyhFyW(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color nUEqSqJor8RwQgV6UUIt()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qdnp8oJoDRwpR105parq(object P_0, DashStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g9GbTlJodkOYvL3TiHrn(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double gS5m14JoCB4jC4lTUhlo(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vsSmr5Jon3PHYUhuUDwW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FINpukJoaQKPOh9UgqbY(object P_0, Point P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nDLVWiJoHcGSpYbWrh8T(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NCwHwsJos283ldo8WydN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EW1MgAJolLTKwXt1A19p(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y4uvGQJo9s6bnks5crIu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lMtw2IJokEoyvRcthYay(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jDl9j1Jo1QoGfKopIAf0(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lmSsIhJovg4U1jM7vofU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RWRdXqJoSdhnkUl3gD9I(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LtkDciJom49WjZTjme2x(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XUCJT7JoIg7HJ7hDTKcT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ed4keMJoXDYiys4vydjt(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A1hg0WJoUqopRvDXnBov(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EAUJIbJoOXouVJHa4W4f(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yDvRPxJo53I37dGWVUD0(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DXX0LfJoiLoDUqfYDuvo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XMJRaNJozQhN47j1OMyM(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PHC037JxLnLQkjOg11Cj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nHU8hiJxNltbXwjNfAdg(object P_0, AxisEnabled P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WbwlKVJxYuVTWW2QEkg5(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hUKKuSJxuVLifwsfGk5H(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PSJ0KpJxylB1LOAZZLym(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J8e05UJx6qdFkVvqLMZJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vdOotKJx20JRL1vQBWmC(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A1iaHDJxJx5LOta0IgJ8(object P_0, SeriesChartType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SlkUD9JxMDrDvOIpHqoS(object P_0, MarkerStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BUHlLSJxKVCZ6BJbQGpt(object P_0, AxisType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChutxEJxZsjgTFlV5hsI(object P_0, AxisType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pw7W7BJxoYrmnQQ4rZPc(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ed61mKJxx46vMOq80UGp(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qx5DR7JxANo8BK8jr22y(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bZ6NE9JxtArHdGl35UkG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mw8jtyJxWUheLJNqxZAO(object P_0, ColumnHeaderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M0P77pJxB3P5Yo2bRJ6j(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KHnkqhJxqmNHZyZTwHqd(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NK7qVpJxEgs5qHyBcbCT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vHmUPYJxVGDbhruNvykZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ecgRktJxTIa4DnlIrM1j(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f5i5COJxpSg0KMSkoA8Q(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lqmCEKJxQkDfrle1rPOF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FEJfatJxRtw7tAHZ4EwO(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j9Y9jXJxGV3bipk9Y6gJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UA0hoYJx3vtPDjYmsJc1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TJkNGGJxFqgG7ELNNbOR(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P0dhvqJx7gJvxV6dNNj0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sw3RffJxbHvhGvtY4cOD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yaDvnwJxgkMjhDwnAWZr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hHZcN6JxfFyx7SYQBBxv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PsXfJVJxjUxR0ohIEYmy(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xEPEcqJxeJSZ17aitfUq(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o58gWvJx08nBrRm2feMo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b1QNVeJxP2kqxB3o6AkB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b7MiWDJxcw5DA3fduZi1(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TB85weJx8llpgEF3ON79(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Oal545JxwtQfkaZDMoDQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cKFQM3JxhxbPFnecNBBa(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zY0PtyJx4qPgNBVm0xNp(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color zFC4LYJxrG2dL0sFsgRU()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WvKgDGJxDyh9sfvLWlFE(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WKcJcFJxdCol7jKxGXpE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lIFPelJxCyRKIZl0GS0k(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qrlvkBJxnyD6HuefwwlP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LPayqTJxad9AnhotRPRu(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ru4bnoJxHYta088U9n4A()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XKBwKsJxsAjSkMTOnVFQ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dPPWB3JxlJVAkxao01cK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color cMmj9fJx9FIIvQSBLdbO()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dgjj5AJxkLd8PYhQs42h(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qHucGRJx1qX0oALGBvIn(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JS0loSJxvbEmX2RrITwd(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ln4sZ9JxSDuiPKJ6g0AV()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JvZXhLJxmlO0Kg9m18ij(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KIx70xJxIvH8bfQjquPR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mIYFN9JxXqtyGWTvhw1b(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bsiXG7JxUNTCgQCpetDX(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J9RIWFJxOCdTVmNxTv9r(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RfWwSvJx5GCIknQwlNjQ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fMQ9RWJxiwxdpxjY81mH(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jJihUFJxzTpHjUuRiuNh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GM9prjJALOJdDwTtZLjO(object P_0, Orientation P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zJerVFJANvHop5MqJRgu(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CtQq09JAYo4tIL6nUg12(object P_0, DefaultBoolean P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object udAXcNJAuw3Iten0nsqi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m0CPBQJAy6Wnv3IShtP3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void coHq08JA6Nl4otlFVxkr(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ArkFAuJA2I7gRvyPd5Ej(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yntDlHJAJlBYZljn5yQ0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Au8PirJAM6dtZOx11T84(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xgxSdsJAKWHvvHwkK6bK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RUd7rdJAZR2kqyamAPHy(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SiNRMJJAobgSCgBjBV3N(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zvYM2jJAxF4jprhjDAnU(object P_0, ScaleType P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MnPpOyJAAyyA6JjXoE0R(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NhdhfmJAt9PVjai0c6FM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uiGipsJAWf8tPAY7FC63(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nL0wjJJABRqS3BbJR2wF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GsnfYaJAqbsvhAXEMMv3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ECrZmLJAEndwQYwNR55e(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mm8WUGJAVq4x5oTJi5XW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lPQfusJAT8cMsS0mTAl2(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AVSxKcJApidCxDgVyL5Q(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aBjNUkJAQOpCnMp8hqCR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dbNeJRJARwUb7osvud9Q(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void buGaTFJAG9VPk6TPmoNP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void enZGsLJA33IPJPpWEJF2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hx79PcJAFefRYwVpO3PB(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c6ZA23JA7VF2XZOwQiHd(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hXCRGiJAbdEVdEFsMSUm(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SoEM6QJAgtGEpdToIgPu(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ndUErtJAf2joWhS9hocj(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iKWAoxJAjLlkPCQAgXpS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GeluY9JAeCPjh7Xpmt3X(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Dr7x5WJA0qnD8m5HIV4I()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IFuBWMJAPxl5xDL793Nx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p1POhfJAcDrUysHwg191(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SNE0qRJA8ylwvB95w9yA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NaRgovJAwXGGsG9XOoxc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l3jTyDJAhOUkkxxYxHOq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OaBYOFJA46SK0wh6PJCM()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AruKJgJAr6M2Vry0K8Qd(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pyoNwcJADKefVnGhHs3l(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JvUgaFJAdNn6u1JPnPr2(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xPrv9TJACP1xGws63Vn1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oHTIjtJAnjBpWEowW1VV(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o2PmuHJAaj69iueepLvT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bSYPYmJAHL5ykZQggsah(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O8YvcfJAsky6EHWInaN1()
	{
	}
}
