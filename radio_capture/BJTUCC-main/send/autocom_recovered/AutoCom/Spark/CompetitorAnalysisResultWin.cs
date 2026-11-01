using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using LibBase;
using LibCoord;
using LibUtils;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class CompetitorAnalysisResultWin : AnaResultWin
{
	[CompilerGenerated]
	private sealed class KV7qVdWXVXdVHc6FjLR
	{
		public long H04Povw3TYE;

		private static KV7qVdWXVXdVHc6FjLR rhQbIkBdXKNt6vdcEXJI;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KV7qVdWXVXdVHc6FjLR()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool T0mPoLEjsgb(AnalysisResultRecord t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KV7qVdWXVXdVHc6FjLR()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			tKcYOyBdiKdC0XRZFj45();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wcivGoBd5036GiLGWyBP()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rB5UeMBdUmK1SGWJn2bG()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static KV7qVdWXVXdVHc6FjLR bUxq6dBdOHGRSPIG3xQc()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tKcYOyBdiKdC0XRZFj45()
		{
		}
	}

	[CompilerGenerated]
	private sealed class QALrmTWUfCZCOIQJUMj
	{
		public AnalysisResultRecord ORVPo6DGN66;

		internal static QALrmTWUfCZCOIQJUMj VL7wjUBdzcX312O8JU5g;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public QALrmTWUfCZCOIQJUMj()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool uSTPos0uiy8(AnalysisBinCellResultRecord t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static QALrmTWUfCZCOIQJUMj()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			PPYqsrBC6b7IYnnJJIC9();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void h5PDx3BCYDwSNsGLbqh6()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cZx2EgBCLQUI9FdBon4H()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QALrmTWUfCZCOIQJUMj RoVSN7BCNfp5pbTftEbm()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long fMXEvYBCuebAoetg1k0E(object P_0)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long BSHk4DBCyeIShnXBIhVG(object P_0)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PPYqsrBC6b7IYnnJJIC9()
		{
		}
	}

	private List<AnalysisResultRecord> XE0HQam9FO;

	private List<AnalysisBinCellResultRecord> FvHHl3u3dC;

	private Color MRqHwn7nxv;

	private CompetitorCompareConditions TdcHpor1uu;

	private CompetitorAnalysisBinCellWin rQJHaHhwIj;

	private int TtYHkx8tYp;

	private bool YqjH0lSTo3;

	private Thread jtVHZUZweP;

	private Logfile UsWHzffIrk;

	private Rectangle SN13C4pKEV;

	private Rectangle JGK3G3KNku;

	private int BEV3RYCgGF;

	private Progress zUk3nB2HvX;

	private ProgressResult VhJ3g6Xevp;

	private string kQb3eGHNjj;

	private bool FhU3PAC9Re;

	private string bKu3E9vNHV;

	private IContainer FHU3yJX1gJ;

	private Panel zAU3cianrh;

	private Label gQW3LpaxgO;

	private Label rwL3vhI7ND;

	private Label Ht83sLNkcD;

	private Label YZO36170v4;

	private TableLayoutPanel PMm3hyxkbk;

	private Label AM5311fPb7;

	private Label Ivy3dodqBJ;

	private Label jAA3WiSeKK;

	private Label il134H3jNc;

	private Label k3R3N27Irq;

	private Label qF23iFOMHe;

	private Label tKN3FJqxro;

	private GridControl S5F3bfOPle;

	private AdvBandedGridView LG83VtrSbN;

	private GridBand bws3XW6yJ9;

	private Label ouh32Gbfuc;

	private Label QNC3OdEM0e;

	private Label u8k3MXJoFK;

	private FlatButton SIP35ceAtO;

	[CompilerGenerated]
	private static Predicate<AnalysisResultRecord> GSv3TkuV3J;

	[CompilerGenerated]
	private static Predicate<AnalysisBinCellResultRecord> tQq3x5RVFX;

	internal static CompetitorAnalysisResultWin JifsvFNWKlo4J9T7Gf11;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompetitorAnalysisResultWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void LoadResultFile(AnalysisType anaType, string resultFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YMXHMuwXIx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ce4H5teOSc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jCIHTvLjZt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Co0HxbpCuG(object P_0, RowIndicatorCustomDrawEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PhcHql7HKe(object P_0, FilterPopupListBoxEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void krvHATveh1(object P_0, RowCellStyleEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GNsHY3dFn2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<AnalysisResultRecord> qI7HH2X1m5()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<AnalysisBinCellResultRecord> dybH3PfYVw()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<AnalysisResultRecord> cVxHJbnOBX()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sBFHr27Kec(BandedGridView P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oyfH9mOMN1(object P_0, BandHeaderCustomDrawEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tthH8o6BUm(object P_0, ColumnHeaderCustomDrawEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void A1CHUZRd4n(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Logfile lPCHKEXMNi(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JGaHtly4YU(object P_0, FocusedRowChangedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private long WKkHuJNwmc(int P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int BinarySearchMoreEqual(List<AnalysisResultRecord> list, int low, int high, int findPointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void s6tHoXaCVl(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetResultTitle()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void h53Hjc0mt1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int pPdH7jA2Ap(ISheet P_0, IWorkbook P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cKTHfcynfM(IRow P_0, XSSFCellStyle P_1, int P_2 = 7)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<AnalysisBinCellResultRecord> UPiHDr3fh6()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iRMHBgfP5t(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aUFHSW53ws()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool heSHmEXfiR(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool BjuHIG6oBd(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CompetitorAnalysisResultWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sVFEimNWx4koZCE8OW4H()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Irsr9wNWAcqRkyRGr2Xs(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WBDOFDNWZnpsikCfFheA()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompetitorAnalysisResultWin Fa7U3sNWoodJ21RCju0f()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EBtXplNWtu2Xa7DWpG15(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CuywwSNWWN9ogx3vwWSP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b5kiXJNWB68ilxEB2jFx(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TwuG2LNWqXklWiolQet9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WVo7SwNWEp3ZMt6evTdo(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OeVxiQNWVS13b5NgeRpv(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i7eGVENWTY1c4ZhfjiG1(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int B1TLI5NWpaFkTpT7WvTT(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double FIq7MSNWQ5wYlS2CRWwd(double P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J7hQ6eNWRoSP5ZXEPfvA(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr jlwBuDNWG0imhFj1wIiW(object P_0, object P_1)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YyleemNW3Wkm7HgOJwOw(object P_0, IntPtr handle)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double WGc2bINWFb4UW0y5pqHT(object P_0, IntPtr handle, int index)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q0H6HRNW7e9acmVDxIGh(object P_0, IntPtr handle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int znEl44NWbllsdUiNC2Ft(double P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U54cSENWgpVmjFwE4uf5(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TG995rNWfAH2aUlcOYOn(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NpQaQENWjYPXcntyrhxy(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RG7RS2NWe55T6V1yTd68(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NYaqNDNW0WriRQJ5oGrO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GKhBaJNWP5vJQBtw2Uvy(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hjRuYrNWcbm3mQlNBseE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zj7bpuNW8ov6YugLbZKt(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xjw01XNWwB2mkK7AhoHy(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aHdLl9NWh7XGyUPxRmqR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ITaBtxNW4DY9kGr2m01U(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ELEBrcNWrIOEVlIBlO0W(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CSsObnNWDx53dqZLbUpK(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DJVwVaNWdRK1Wtgljp1D(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BZVOcYNWCMfMUCs06v8J(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qui50xNWnk20u3PXSWsb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q8aAKfNWanwDUNS37BpF(object P_0, ShowFilterPanelMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void evmheCNWH3tAHEEEk6Zs(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hHKX2tNWs1hEgZlHXHQn(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rWapXlNWl2CgDty6bIVI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rgC6VFNW9VgVtmr7BlAR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b9dsmONWkfN6pcEcIeH0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W5S9r2NW1rcPcJWRjSGg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wdWU0ONWvAutWfW20Kwf(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PgmFNYNWSWPAANVLDEJR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nKWJU4NWmg5i5s2YeYhF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NbsyZaNWIu4tplwslP0R(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WcmqdTNWXC49gFRg5ZlZ(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uJbUEfNWUjbpT4goYaP1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DFLPSVNWOQMqfykHp7Ps(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EW4CqtNW5nUfbc9Eceya(object P_0, HorzAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bxhkMANWiIDAe71aj33x(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DlePloNWzFKZhlXL73Ve(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EFV1qlNBL0ie0jPgwsnq(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color fcMJKGNBNE2pC9rh6ZKu()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void It90BXNBYnFuekrNSy24(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sj3O5INBu6upTkBClyjB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QRD9AyNByCoMa6vC7t8x(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m4n3vfNB6C3jYXlbVwcD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DEfUQLNB2JSeXNJZ4Lrb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pwsVMkNBJ1BLVFMto0SS(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qmxnEhNBM1qXlC10VbmX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K6Sly3NBKp9jWUM9ETTJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SjkrOWNBZ15SWmIhuBSE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RIs1TCNBoJ5ZHBocqZnF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NF5E9PNBxiwW1rgRL6BR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ywQtoeNBAUY7kERY9mcE(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G3vZqjNBtDYX2KscUvU7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DRiAhVNBWXcrl6hwwjBl(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iDTxMjNBBb5yDfj5IeB5(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PDqDj1NBqrpSgVTaMpaX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yh3KChNBE7h1beSLqVtb(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KoaZhFNBVxi1P0K8U1mF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KynWNWNBTQBlorqd9uOC(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GL6uk6NBpoIMRUkoTaLQ(object P_0, FilterPopupMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wp6uWQNBQrRAFl4SFZLA(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CmHkhENBRGU1SgjL4Vtp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color TIWsD1NBGWFfAiXaq9dn()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BF7MKENB3hdVNhDbFQtO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jjsn4rNBFUdRH5SxNmxH(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gyrcCmNB7NhvdBJyrECI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m14ta9NBbWBea75jI6aY(object P_0, FormatConditionEnum P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LjiYg7NBgYxTfYFYIVd8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LnVdkFNBfeHLYZOPkVrI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object igedXwNBj0M0Mfv1oitH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aPXyBYNBeB8LILBei8iN(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cElyeyNB0DAFa6FZ3Dr0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qJJ6tqNBPM18cyr4O7YC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pV8G5ANBcNmXvSO522WG(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C4tOr2NB8TeA1VyQSCnZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MUDiZUNBw5KC1cBAkogV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v3xh6cNBhpGkZ3urkE5a(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RRKHgCNB4ymFjQ2NsF9i(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YHPjtWNBrm9LCBZ9mP7A(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HRO13oNBDvjfIa1ssX29(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jCnC8hNBdjNV0XcoYQPb(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zXlPBkNBCTRMMN9avXMb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object egTie8NBnpJYvAAYGNOE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VhglQLNBa4g9qj1eSw0s(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TVW341NBHFghkoS6ek8a(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Tok2EcNBspnyvyUfWIod(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HmKuesNBlPmtDO6Ji8fP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NF7lXPNB9NsPhnQMJKDL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YD03ByNBkb6AOY0JRCgK(object P_0, WordWrap P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KYUu9XNB13yOxu10bweV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color PcRwE6NBvMgontf7Yqwg(object P_0)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M0T4QeNBS0aJYylJNR4H(Color P_0, Color P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eff2nJNBmAmH6ZhneImk(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle bvHXAtNBI3LIA0X5R0Dn(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M821alNBXniu4k5LDlsY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kk2RESNBUkXXhZABdoya(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ilw7tsNBOSLOZJlKfnQy(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zTMU1GNB58bkAD4eyy7v(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle kNSUMwNBi3qdaupjxU56(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AQH2uaNBzGB1yZtKviu4(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vnjtwtNqLMXIv4rMJRVf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QEW0q2NqNrr7hGbljqVm(object P_0, object P_1, object P_2, Rectangle P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q3455sNqY23tP6jFNHf9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mHf5tZNquKBSRZ367wiq(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ll60onNqycmmfESHemuV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fuN6tXNq6c0kQK0A0cqH(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xl3QllNq25rd5oXyBy6a(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bSI2e6NqJO2uPQXbcEPO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ONEUAyNqMa2ycmOax5t4(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oOlsejNqK5iC9VDaTp9s(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AaoDKRNqZJH73LNuWEqs(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HthlIXNqo9kTslhpHsd5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ammkh9NqxtXrEw0WvTJs(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color l6UVfjNqAFUXNkG2sgUJ()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wQinkwNqtfit3GeoCwCZ(object P_0, object P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JmDIpANqWv0yyMTgChnS(object P_0, object P_1, Rectangle P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X710ajNqBVff7se8JhYV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i379lxNqqZRHW6sDtRTG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fZ7ZB8NqE2Vo4ohyn3db(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KYhgjUNqVaG6LT8cksHa()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle diedrjNqT612Xrqq4prk(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type MMoj5bNqp1lOKoMqAOCx(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sYN8gKNqQTAaVyW4V6rb()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Yy0GWUNqRbNimlSmRfqV(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int li4Jj5NqGlcyjvEEgYaa(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YFee5cNq3njyyHCwDwl8(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cEmmGcNqFQKsuWnRxfvd(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b48eNbNq7fsybrI6r4xr(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OPQGVQNqb2OyBorUrKQW(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bEcQ1INqgvFpWlw10AFa(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VdAsZVNqfOwDVE27JePO(object P_0, IntPtr handle, int index)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ngL11aNqjkZUnCXWvicL(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int k9uYJTNqetobwMvem46W(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RL78ZINq0vZuMg1d9SiI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qOX9JlNqP21HCqAWOwlv(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p1OZXqNqcAjSn00dA7YU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MOQ75NNq8jEJAb5835U7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vby97SNqw8TEhb9Pprcr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hxnuuWNqhAkPQY8ELcvi(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sdEGShNq4QnUX1MCurZE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ajnh2gNqrsi8rtQ7Rx0S(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fc9dhWNqDWo2O5qR2Xx6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EG56XvNqdQwEYCw1LqMB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr I2AKKFNqCmthtQAS2ix4(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xq8HhbNqnqBMK39FcSOe(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Be6kS2NqaBtWaET6x4WD(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint pEsHxONqHBncRaHmKD6e(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tXEIjONqsIGtS2rP6sMM(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JuDwFhNqlXsW8sFvtcnx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rAmdUwNq9rFPnEiLiexJ(object P_0, bool P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A5N6bfNqkNsvgaQY7U4J()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult uBlbuMNq1SbEXCXbdn3T(object P_0, MessageBoxButtons btns)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q5QWqCNqvivsoXFtDeKV(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YuEBYBNqSRSyP9Xc93VP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YRGI0FNqmRZ01T3UVINE(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long Pe7RG8NqIUvDjfspIScd(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uWfueENqXBILfu8BKXNs(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Nw3LKsNqU9mGdokXkwW8(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dXspmKNqOPsohNtMwXls(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aJTOgrNq5ZDspyIF0s0c(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double RUcTtKNqimvdhGfSV9sM(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DeVStfNqzyeXTt5TeLFa(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T4WxsGNELGcRjCxqImsD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double FggOX4NENNNu1PZJgCSF(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double iRPsv9NEYR6Wa6cWwCSx(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KjeFsGNEuJIsb0sQImTr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object klSYUxNEynitxrofVRH1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double VM6g5YNE6LBFhkKvFTZv(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ru8JvqNE2JkD43ZxXn89(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NUED3kNEJuhOlnPLKK7L(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lZLWHgNEMASUICCAPVcb(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S4F7jtNEKD3M4rRUrr6a(object P_0, int firstRow, int lastRow, int firstColumn, int lastColumn, object P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CnJ607NEZLeu9EWggbYl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wMfUrkNEoiDxYkvOoSAr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jexIoTNExvl3GedIik2O(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nUjXHKNEAdcYKmYRKwcA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static short Mwr5wJNEtFCSfymP8Imw(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VJfPVdNEWrSTbAppVhFq(object P_0, short P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BY6IV0NEBLdxlEPtGW8G(object P_0, int P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jamkhuNEq36iAQSRkbLT(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W3ksl8NEEY4FkbE9ffmS(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lAU7K0NEVO0l7ZtypeE6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SEvOJUNETo7jkTDa1SiU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vtvWXmNEpx43LdQaWqfp(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QUVYNGNEQNnnbdB8ejhK(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CsDuGRNERxLAufgDgHET(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QIcewpNEGsRejQPW9aOt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yIMuHHNE3sD1QGZlQaRv(object P_0, FillPattern P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MhOno9NEFdQEiybeg8Qf(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IRRqiONE7icMPyKyUvh4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void huhD6HNEbRabIfgTbhdD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IIcrEONEgTP3jVupBn8i(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pxWf90NEfn470t6gOP94(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object voy5K7NEjEUtLfQhrJ6e(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hYctyNNEeG7aQ2JdJPp4(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L6boCnNE0aIcDnhjbBlB(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void caKFIJNEPMPqv6ETFZKp(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bIr59RNEcRbj4uuJIFrh(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KPDbpZNE8TONf5huLBoj(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a9qecpNEwLBLSRmO8QBs(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Wb2Q3xNEh93cLyykLROX(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sj6FWMNE4l8Wi3VL3n6R(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IIIsywNErLTwSYIjYK4I(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YgktNkNEDoABMg3INOyP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int x964KXNEdBDj1A9KYJCo(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kmZadZNECGK07gTP2TGT(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UlGPeyNEncRlF8yyqtrE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color evZorfNEaGu8a9t6xnG8()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NsIIXYNEHcjbB5KnDqnU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ADeMbsNEsChDL85T7nnU(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OJGjCENElFK1DtIbUMwP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ogtyv3NE9tsKaXsApB82(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Wt0Pm2NEkyLtvAgdIoUh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J9EvkpNE1K2HqMCH9q5X(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MBZswENEv4oyNHsnrpgK(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oY71orNESjZKRPdKOy78(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bTfHIoNEmOECrK3w8w9q(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UllqIINEItLpleQ2fekm(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TamEj2NEXaYam4wwT3MT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AfuekjNEUmAwpq4gH9UR(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JtdonQNEOAMITT9MEcnp(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qqXYRkNE53n4w1B4ikME(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GlFqXVNEilVEBJNCfVda(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O5ZtOpNEzUpksntfEAqh(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H95XutNVLxhwsktxP67Y()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q2XQJjNVNFrHQUBUqEkN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sglWDmNVYtcdgm8MKdSF(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KsiaoiNVuu8yBOqvsEvQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GZyIMWNVybaPxBK2ARRa(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kmj8iGNV67eZ7j4Fb6J3(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ESfdJGNV2lZpv2v61bL0()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rW7kMyNVJnGOMeR9VuUh(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VMMHviNVMZ7i5kGQnxRP(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wupVcUNVK0VeH5LbNEV9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aCrcQjNVZ9y3R7irFJke(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WBugPTNVof9J5BIsnI5i(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oAHILNNVxA4FCaWa2oG8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KD1hk2NVAQ8B4y2oqWfL(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JmugnoNVtHbRIYBkrkYA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aVavLiNVWHPI9mou4ArU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XcaK3WNVBAB9WP4jAULB(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ByM9ekNVqB1jdjtg6xqF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int N8sK2eNVELwbFpKRKJK0(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int avS4Z8NVVVEg2MHnGTBG(object P_0)
	{
		return 0;
	}
}
