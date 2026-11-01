using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using LibBase;
using LibCoord;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class ATUAdminWin : BaseWin
{
	[CompilerGenerated]
	private sealed class O7sxnVTDIBE2rDxFHSw
	{
		public string Yb8EL5eqBdy;

		internal static O7sxnVTDIBE2rDxFHSw MJ0sSxqkeJZK00MmNbcj;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public O7sxnVTDIBE2rDxFHSw()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static O7sxnVTDIBE2rDxFHSw()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			XGUkYcqk85M64Vnp2AtR();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fHqNZ4qkcIcXdIy3qMvw()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xpd1P2qk0ISbxyfQ6Csr()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static O7sxnVTDIBE2rDxFHSw qBi9EbqkP7yYbsOi5le9()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XGUkYcqk85M64Vnp2AtR()
		{
		}
	}

	[CompilerGenerated]
	private sealed class Mjr6AQTLMvcfcqZid40
	{
		public O7sxnVTDIBE2rDxFHSw EKjELA1OY9p;

		public string N4AELYVDFMM;

		private static Mjr6AQTLMvcfcqZid40 Do0mHkqkwvIUoo0etArY;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Mjr6AQTLMvcfcqZid40()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool t17ELTLO4Gt(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool T1MELxSm2DF(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RliELqPXTYg(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Mjr6AQTLMvcfcqZid40()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			hmwiMBqkdAQYTPURJd4p();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GwOCuRqkrpVthJy0uECG()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t0EgWfqkhVNxx6PEkMq7()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Mjr6AQTLMvcfcqZid40 pc3iRaqk4VCqSwkQ6A3t()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CRVxG2qkDERYw6aqWpap(object P_0, object P_1)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hmwiMBqkdAQYTPURJd4p()
		{
		}
	}

	public static ATUAdminWin CurATUAdminWin;

	private List<ATUUploadFileInfo> bCvPCu3NPYe;

	private FastObjectListView ub5PCoykkxV;

	private static int mX6PCjBFO96;

	private static int QfVPC7DdJcs;

	private int F4ePCflasUJ;

	public static int CICategoryUpload;

	public static int CICategoryTestScene;

	private bool H4pPCDeHQ0Y;

	private bool ygAPCBded6B;

	private static bool KD0PCSOqnIR;

	private HighSpeedRailDB MHNPCmb7xGV;

	private List<OneRailStation> KicPCI8Kspp;

	private LogTestMode FXiPCQE8Gcq;

	private bool BV1PClBqdou;

	private IContainer ernPCwFmlkd;

	private Panel yOfPCpF8pUT;

	private Panel k4BPCawS5Mm;

	private Label qtUPCk7VRXV;

	private TextBox cEHPC0oYT2Y;

	private Label Tq8PCZTpElu;

	private TextBox cj9PCzjeLrY;

	private Label jSYPGC5JKUa;

	private TextBox z7cPGG07i47;

	private FlatButton PGlPGR5YBGN;

	private FlatButton t1oPGnnCabe;

	private FlatButton vnjPGgCFLJn;

	private FlatButton OshPGejNdFI;

	private CheckBox oJhPGPeychA;

	private Timer DgrPGEtIof7;

	private PopupMenu fajPGyojN6R;

	private BarButtonItem VZyPGc77ASa;

	private BarButtonItem iMfPGLB6fYS;

	private BarManager kZOPGvfv8Bg;

	private BarDockControl hZpPGsNOg0Q;

	private BarDockControl GSWPG64r0H9;

	private BarDockControl dtpPGhpM1j2;

	private BarDockControl WD0PG1C9abr;

	private BarButtonItem seGPGdB9rbg;

	private BarCheckItem hIAPGWl4CAp;

	private BarButtonItem k6APG4ckh4E;

	private BarButtonItem QaqPGNwh1NA;

	private FlatButton DqhPGiud8UO;

	private FlatButton bqDPGF4BAyv;

	public FlatTabControl tcCategory;

	private Panel Gv3PGb2Ilro;

	private SearchLookUpEdit B4UPGVJsHRb;

	private GridView lVrPGXOX0SB;

	private ComboBoxEdit HJFPG2TVYvr;

	private Label ErBPGOng8yF;

	private Label w7lPGMNqgpm;

	private ComboBoxEdit oYDPG5ZJlDi;

	private Label fOUPGTasNQE;

	private Panel keVPGxxYcR7;

	private ComboBoxEdit wS8PGq8gmvo;

	private Label Dh5PGAdWlaq;

	private Label LcsPGYEmyIe;

	private FlatButton SlNPGHoSCPt;

	[CompilerGenerated]
	private static Predicate<ATUUploadFileInfo> lq4PG3VXaW0;

	[CompilerGenerated]
	private static AspectGetterDelegate IqHPGJANH9M;

	[CompilerGenerated]
	private static AspectGetterDelegate XDAPGr10Lep;

	[CompilerGenerated]
	private static AspectGetterDelegate HtePG9QYmWf;

	[CompilerGenerated]
	private static Func<OneRailStation, string> RTTPG8Z5HQO;

	internal static ATUAdminWin nxk17kt8AMTY0GSiMv7L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ATUAdminWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void x1rezzMRfXa()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jE2PCCNUHv8(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowATUWinWhenNotFinish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUploading()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTestingLogToShow(ATUUploadFileInfo info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetControlEnable(bool enable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VY2PCGOTH2n()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WSnPCREZx12(object P_0, ItemCheckEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NlAPCnRUxGv(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PEUPCggWhCl(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bR0PCecG6me(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void E8kPCP2u6j0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BMaPCEAS9kw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Config2UI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pPHPCyL5rgn(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RVBPCcjPcbg(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SGdPCLlWnHR(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void heAPCvwo67R(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool aNyPCsfhaym(ATUUploadFileInfo P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool rQCPC65kDuE(ATUUploadFileInfo P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbUpload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void GACPChGiEs1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutLogfileToUploadingList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void u1KPC1XAZ41(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KutPCdfgrmP(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Q8IPCW1DENK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UauPC4GL4MV(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hc7PCNAcARx(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nSjPCiJNlvl(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uQ7PCF9lPJD(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopUpload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tWTPCbVYL9l(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oW9PCVU5Z4P(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RwFPCXKMqcM(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IQtPC2ac36M(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JQFPCOOaZvw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lmGPCMwSXyW(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void f3tPC5A62Pq(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NI1PCTJfvki(object P_0, CancelEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HighSpeedRailDBUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bPAPCx4mPmI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void y1bPCq3JuTp(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CNTPCA02xi1(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NQHPCYcd3Gm(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aVbPCHdAWnG()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tZLPC3n0OoJ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void x2KPCJrAZQB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FDEPCrSWOdW()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool q3mPC9RykER(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object Qs0PC8wCtUi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object wWFPCUHTkwN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object bObPCKCDImv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static string sibPCtUPn2d(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ATUAdminWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					CICategoryTestScene = 2;
					num2 = 6;
					continue;
				case 6:
					KD0PCSOqnIR = false;
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					continue;
				case 7:
					QfVPC7DdJcs = SM9hoqtwctvJGGh2oJu2();
					num2 = 1;
					if (false)
					{
						num2 = 1;
					}
					continue;
				case 1:
					CICategoryUpload = 1;
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 4:
					oRW352t8B8ENmnuMac5J();
					num = 3;
					break;
				case 5:
					xxv6X8tDNq7eFEheHL0w();
					num2 = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					mX6PCjBFO96 = Environment.TickCount;
					num = 7;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oRW352t8B8ENmnuMac5J()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S82hmit8qZmQSTYX2hmm()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mjaX6Jt8Ewl0Bj1LL6gw(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yEn6xHt8Vdloc3YS4Gv6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int x3I1dQt8TtRo5c1T5GJc(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fTECvkt8pFNbTgiotiic(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void biVgpgt8Qq1ejRwbMnJV(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EjS7jTt8RhtylRsYUMIY()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SrJiGgt8GNiYS48InV5D(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AgfHGWt83MjZ6un2yI3i(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XyhX3mt8FhI2FVt2LwJp()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VNAeTdt87lmJLT6YMrNF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R0XiRHt8bGI10hHPfA1g(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mflXg1t8taUVOyna1sqj()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ATUAdminWin uEEMxKt8WJobEfvdPKNy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FqYaFVt8gkZLNRkarIUF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GhEKSDt8fl5OgkWUNlA8(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BxHuqSt8jfurTjvnbiWX(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RgjroDt8eEXriYJRB22j(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j68oBVt80IqJkCgkcj2Q(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w5vLUZt8PqyrFXaEZWMl(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oWMYCNt8cZWc8p8gEddS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c4Z5yUt88EhmfdaACGMN(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult tTeapqt8wgmYNsTxBxSI(object P_0, MessageBoxButtons btns)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F4KX6Kt8hstItpSBbyK9(object P_0, int P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rcl1XIt8476Ua3xU3X8E(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KyW6Pbt8rxZsFCETXZwG()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dKtPopt8Dm5bYsrcdS3u(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void du3HTMt8dTtOQvgIlUxK(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l6gIrit8CUFAh4CrVjMa(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pKN3gKt8nXomYJtqH4Gk(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wtW0gLt8aCmcXyoivVgQ(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gkG2Fet8HqVgKUUM9Idx(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PZ6CiOt8sDhCBYojxLg1(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LjocdWt8lpZIi5I8oTim(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YJ9s0gt89RBpjEkp0ovj(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color RmBnLut8k4vvuiwPV7hx()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c4cVX8t81ONsbmrwInJR(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vmdwSut8vGboJEtJFOS0(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hy2m5jt8Sb1WJYcsS2VU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EMpr0xt8m0TlfK7O9GaB(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rG082jt8IgKVB2gDexYp(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iKqw5Ft8XtdAsY1eSF0l(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tYq9ckt8UEqZthUPxjcS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WCCH8vt8OlVgkSSpbF9m(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MhPGTxt85DxfmI0MEoq1(object P_0, CheckState P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tqLcTxt8i9iehFsA9GUi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RNRuIot8zGpw7nXQplcM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PwpqF6twL8ALyjJgf9rv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MO1IUntwNeq6Y4goAhEf()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void obKcu7twYQGTPFRcPd1e(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason LALayQtwuuk1Vd06I2Vb(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hbIYFitwylc7Kkt3U9JL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A95smRtw6woyaZISo36G(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sMcHqotw2f7USKhnwa6C(object P_0, bool P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nY6MBftwJkk7aKRKQXSr(object P_0, UpdateMainWinBoolType P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EF8GAotwMBKG2AJgy7fI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n3L4QPtwKSC631Nr2Qv0(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wGggTetwZ3ouIZat5xcm(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zrGvNdtwoxVo8YPrB2WA(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jeQH95twx2PLbUx0MCwp(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dK6x8TtwATQhCUvMESY2(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VI9KCwtwtSYWplNtjiKe(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nFxSGZtwW5YUKP2N5uJb(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gwSfOLtwBLkZ73eymXNc(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ftIyIPtwq0GBURyL3ide(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NGXEbEtwEygVI3kwR6tS()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vHsXvHtwV1DwheDpZFlu(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mkqprRtwTCyfBpwtYITq(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object voFkcjtwpxEjOtC9vO7D(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NSnekJtwQD923HFMrxFv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m3BQvmtwREkfRi9GB2cx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gAewHCtwG5jZrdQ9cjJD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cPhAYLtw3jSY7w6te7xb(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OT6GVQtwFIGXfjRkITYB(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k1a1Aytw7jURISGBMulU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CAWu2otwb6cIDjxQnvGn(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R1hQlftwgZLM46ls6rgQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ryvdpjtwf95rN1EE4QSb(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void roOdJOtwjYv1ML9nXeRA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void maZXvltwepJOOlkZefdT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long kTV0EPtw0p9NgZ32UTRa(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ihMbsLtwPJyqlyeQ1o5s(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SM9hoqtwctvJGGh2oJu2()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OqGPbNtw8LeYjSfyILjW(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CdEqHPtwwbFNJVDE0T8G(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HCFPjqtwhOSMxfkx6PUQ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ypTG0atw4TxjE10T8nng(object P_0, bool P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ilxYJUtwrT1RoYGdLfih(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool djDWX5twDmx2HsKcR9xo(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CDW02dtwdjgJMnxWWb1S(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HI4fIOtwC95fPbSLoHfv(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void abLtoPtwn7wDdWqTT1WU(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w98mKmtwa6V8KXfr5JmV(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qd71TTtwHuV5wXt07jUl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F8ZBmmtwsHFTnhcsNGli(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aQO1Whtwlh7j7IiXWgNI(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jaerNCtw9lYXjej0M5vn(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Isbd2UtwkxIOgL2fpcmA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hU6Lnltw15LQ0hiBPCik(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XcmjKetwvn9DjsZGV6JO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jC5sEgtwSdfBwKswbUP6(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HQZ66JtwmCKiqp9yKBuE(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PXUgWjtwI2Axgyo3qIis()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hqEMmxtwXO39aNEFbmy2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gJllRXtwUcLNFIO2j9g6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xt52nJtwOlLfOAbSCgnS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ProgressResult PqQ9XCtw5s5dxV9ilUmK(object P_0, object P_1)
	{
		return (ProgressResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iWn8q9twiq3BR53CL1tV(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x3CFI3twz3HxwSFwJM9q(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object thfctOthLlbO9bnvJBsi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IA0ZUIthNJjiqj5QZUsc(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iKZRQwthYeWl7k6TDm3q(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j7MQsSthu3Awb1Vwn8B8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dych5sthyDLNX4tuK4nb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e8MAXith6u2sneyA4Z14(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qUxgJqth2fUtr6LSu1w9(object P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mr7N28thJxhkuIZx3Qgr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DQNVcothMP3tZLyN6fes(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T2u5fdthKmfauQh3GVWW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bqOQSGthZD9SLm41B06t(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle wxPas0thoZ1FvJi2t8Xg(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QjlyjjthxtZByp40WGGG(Type P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object al98tgthANyWm37h8TCA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iVLOYnthtSC3UQsKIc6S(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o5BKT6thWba1r24ZfZ5c(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g5gJK6thBOrZEXbCTWNA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MXvJgrthqjdSf87OKGBv(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CGYj6uthELdsJ80U2ip2(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VwQGRMthVIXxHwfFeGmc(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OdrVoythTi03y8UEdpIc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int F6guoWthp6HllEJFERop(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mQxcHGthQbQUDjj6BKQ4(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NTWNaSthReRlZVr3TQi7(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JEj2n6thGwrdYraxCa3X()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FW6r1pth3k2mRQ3DdOCh(object P_0, int P_1, object P_2, bool P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ApMtCRthFd5iLUowwnDc(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GWIAiSth7qJlPWkOU0Nu()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xqBWfGthbXBZmI2QvibG(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool feUee9thglGnWfkxblIZ(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y7mUF7thfyXeo7Si71FY(object P_0, UpdateTaskConfigATUWarnEnum warnEnum)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dyXndtthjRkUKpEdWn43(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DuamBOthelLuxlZmI0sO(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OlfSUKth0VnH0sLd1mhe(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ecHFsRthPPi3rQlksp3i(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HpWEZGthcw0dD385pOMu(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B0djCpth8IaN3vy2SqfL(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N69UDythwBlrxMVwsq4i(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RW7Iuuthha2v621WXKoE(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color l9EAWnth4yyP9nX84WJY()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oew2mdthrJtcdSK2L9hT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QcebONthDoI3dwHAOZaY(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MuGkyUthdLqlJM1phvvo(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lDicchthCCcotAEtHhRt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UERhDYthn87RwTvw3Z93(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U7DJ6HthaFMivNp1gC9K(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LjbvmythH1kwwKXRH1SF(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RKKpMBthsWvCUVtD6dEc(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PyX8WAthlKKB6f9JiRjE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color WtJ43Vth95cO1ifNMApP(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HMChbOthkfTGZ8eFFMDK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g2d0OKth15BK7gH6RWCD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mptZWdthvxLPluviUpBP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VGgFT9thShBRK1s1jsyr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pGT4AsthmA8jlcBogfRI(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KBgwFlthIkrMEFge6CYt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GjhVcDthXUFhTsfSFJ1y(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ABV4BdthUC0NyJeLsp4A(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RyqnwUthOSlvwHIuQ9JT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jwCa5wth5y5aEXkeSG7U(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yooOZ8thiZOBfEHaAflJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KUXqXVthzG90O2iB37L9(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gLwvmst4LhoH1DlWcJOS(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OpJ4pZt4NlQ8XrDnLZWr(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color AbqfkXt4YZoQTEApb8i7()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sdAEVqt4uW0ekDbZYwD2(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iS7bo8t4yjn7mAvwggtf()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void adyyKMt46Q759NcWRD7V(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xjuN5it42RX5PSqcurpr(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vvUMo1t4JXreCyA60eiv()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kJZqSYt4MwgVdgEkOG6m()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color gBjemUt4KgD12N8nNJ7C()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Fc6131t4ZnBy7KRxF9a6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nPmHBYt4o0htcwqJ6fHX(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void drj6wVt4xSHxNOXVXPJN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VZWXBPt4APAogfbEva8O(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m6QdY8t4ta7MeB9Jh9Zk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c4Jwwnt4WcadnSqI9VWy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EpMDedt4Bsh1WBTnDTjO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KWWxiSt4qtkSpFtrk07u(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TTfhvPt4EYZmAb1nSiCy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IEoTsMt4VeWYK2XWPC8m(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oEdffvt4Tm0wgsqePROn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XP5dLat4prsIx3afv5JG(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A7AVKTt4QND80UvLxxe5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yPb7Tnt4RrwNINne3LFT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DE5EQPt4GPLXvKbWyjEy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iBBp6Mt43g2jFHPmI5Bq(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qtAkQCt4FdfJHJxOMgG2(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E4Pi9xt47J0BwvYBXCed(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FZ6vjVt4buKBdxJwqWIQ(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MfTVVIt4g5YXpJ5LTx2n(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bBdpFbt4fRvwMMIe2bs0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FcZFF4t4jtVvNvMMJ8wS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EPcfNZt4e9FQu4wC0jBQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color EVmo5Jt40Hus4I0H5Nrt()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SUkYqpt4P57bTU4jIn38(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nOqQ2Wt4c2DkDgNSFcTT(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f8foJpt48B8vS5BgUdht(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kvSPvvt4wh2uvo9JjNT2(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CMqnyrt4hVEtk5FVRPPM(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UP5tQxt44kbd1mB3OVRH(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aNA57ft4rtemuPoM2WTW(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XeXuERt4DGSlSwZxHkte(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zWiUTKt4ddB3spelteqL(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rvij6Qt4CP8if7xvGn0H(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AK1pdkt4nrFIVgxOWtxo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object h9hU1Yt4afA2Zs7i8Y5J(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oX0oBqt4Hi2mxlbO1kuc(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bsJ29Rt4suisCHv5svkN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kM6UDZt4lJL20q7ABxBf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qemp3st494ISN4vXb79R(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sBHQrEt4kCswNjVZ6iFb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Pxp64Ct414rZZwIq3UxW(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EUMeott4vSgj0w32drc6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DLyNJht4SoPmUKM0SdSg(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xORywat4mdxNFXvAjZPY(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A8GpqAt4IsTL0TlguaAg(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gt1bJtt4XfhtiTvRtO9O(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wLicUyt4Uxou0RJLtTcJ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void otPSLkt4OKoR36inmaym(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qxNgnCt45xT5NU07xS9O(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lwcwBot4iT6B7tn8aJtE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bGFQIBt4zdlN6EgrJXd2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MdhuUdtrLsMDsW3RIjRw(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pMSWcXtrNZhd4Slxr6Yx(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n6BOmbtrYVTq95xJ5dSf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u7QMYMtrurVk9wF4FtDN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hCkfTQtryY097SffRuOR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YwJls5tr6BAm2UlpovlF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vnWkBHtr2VNb0DXcWjjS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M2YqHEtrJtxMKZCUy5Rp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XHGBbOtrMINfY1Q9wR26(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dMKESatrKWcXEdvPMUZ9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object avdUkrtrZlnfKNXT27oS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fTmpHKtrohswjq12y9CG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KmM7K7trxFv2mRR0A6GD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DLITphtrAJWuCiBW6uV9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cbiGZDtrtS4ZVFJXJ1A5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JnYH4BtrWCnuS9W7xVcO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object poq6A5trBgdxZoX40gMJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BsAHJjtrqkO6KEsGG8MX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ugpCd7trEuswecwNRWbe(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JI72AhtrVMUZb75wG2wE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HbparLtrTX9sIY0Syd3T(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nt7nvktrpZMQ0a0Nltej(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jwOxaTtrQtnbCLGUHpXl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gomtGitrRUbj0WoqhTSq(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zqvqHNtrGfIrnmEfUeLp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QY6JjKtr3XXnGVJZ9Mji(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YrNylGtrFxdLsBQqewB6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HNDqlqtr7HZIgs5g5DQp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jf3FBNtrbKF3NbwQ0RLb(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UcMMXFtrgUV9pN18Ak33(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TDcLQ1trfYBugvVVJZ91(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IKXlL3trjpOMWIxjLZbO(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gBluH0treYS74Z8fJvxa(object P_0, DrawFocusRectStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AaZ8YMtr0ZbcQ7nJYbR7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uTqiFBtrPZEHHA9JsXqe(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G85kf3trcZw5Y0eTphwj(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zmtImotr8TEPUBkGWG7p(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BYL7oGtrwe3LFvrrLR7U(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dOWc2ItrhxThq8pyZZMX(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YDxugetr4LWQNd0VgmS3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DNA7xjtrr3V33ymVL62O(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XsRW92trDs3Cr1l3N0CO(object P_0, TextEditStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color RsBNFstrd27sEyITZ6j2()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v9L3JttrCLRWkNpt15VY(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bbTVl3trnSkbsVbapTa2(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void onS1NdtragvYfkdIH45G(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u5l9fHtrHTZ0mfYqpu7D(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XOskNetrsAv1EhmmWL2J()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RoZRyptrlg3Lrhmtjwob(object P_0, SizeF P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nyEtHEtr9QkmrsIu8VeQ(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HKZZk8trktAmcxajKaJe(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QbCrjTtr1CVmZS1f3a4R(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Fs4VNYtrvYHjTwgeES42(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GXH4oZtrSsaqpDtsPKbq(object P_0, FormStartPosition P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void elFyyKtrmkGhikOks4r3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kqSoqptrI39tjr98a6Lr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KnTcnPtrXg11JjCOnKA7(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WNAgkxtrUI4md6w6iZOJ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fjNo3WtrOmC1SGNEwK0d(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void beEo3Vtr5MvIwOInfAB7(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eRkUC1triF7pJD4wXB2f(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ca8bQStrzxXqA9cPtuAC(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y5LhUktDLCS7HplxlGPl(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xxv6X8tDNq7eFEheHL0w()
	{
	}
}
