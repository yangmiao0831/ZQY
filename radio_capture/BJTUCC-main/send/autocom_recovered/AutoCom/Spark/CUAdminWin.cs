using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using EhWfrCHt8CgdGjRCLj3;
using LibBase;
using LibCoord;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class CUAdminWin : BaseWin
{
	[CompilerGenerated]
	private sealed class XQIOQD8aOIZTMOwpFby
	{
		public string G8pEyw4kIBN;

		internal static XQIOQD8aOIZTMOwpFby dt2tYDqaW4tBGWlNErlD;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public XQIOQD8aOIZTMOwpFby()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static XQIOQD8aOIZTMOwpFby()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			TvtAheqaVtXZaFpWdEGI();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gFhoxXqaEPmalnU4kS3b()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool orkvXeqaBxubqtwV5geD()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static XQIOQD8aOIZTMOwpFby VF4UxeqaqusA9oh0WlXL()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TvtAheqaVtXZaFpWdEGI()
		{
		}
	}

	[CompilerGenerated]
	private sealed class mR0S2y8VxUcpuycUCoW
	{
		public XQIOQD8aOIZTMOwpFby B6PEy0fWAUQ;

		public string NoqEyZq2uQr;

		internal static mR0S2y8VxUcpuycUCoW U9rt9KqaTPQ4OHNcIPvm;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public mR0S2y8VxUcpuycUCoW()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool jc9EypPgrit(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool vHDEyaWVft4(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool VnvEykmPVyq(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static mR0S2y8VxUcpuycUCoW()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			bYQV4oqaG0wx8XBeUP2X();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wnIijBqap6vCKnQXRZk2()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static mR0S2y8VxUcpuycUCoW KU4Ny7qaQ0CO5NbvQybf()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TFx1UsqaRosZHEdQeiL6(object P_0, object P_1)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bYQV4oqaG0wx8XBeUP2X()
		{
		}
	}

	public static CUAdminWin CurCUAdminWin;

	private List<ATUUploadFileInfo> VGfeDpnNh3w;

	private FastObjectListView Cf3eDaowIEN;

	private static int FyQeDkGjf2f;

	private static int UgoeD09IXo3;

	private int H5deDZqjKcn;

	public static int CICategoryUpload;

	public static int CICategoryTestScene;

	private bool S8GeDzrj5h6;

	private bool syCeBCVea8T;

	private static bool DG6eBGhB32S;

	private HighSpeedRailDB iq2eBRDIZMi;

	private List<OneRailStation> QLWeBncE0PV;

	private LogTestMode MNfeBgf9MHb;

	private IContainer ot4eBeq5L5C;

	private Panel A19eBPGiGQR;

	private Panel zaxeBEQjrTC;

	private Label fEJeByOs8IC;

	private TextBox RoeeBcR7d4c;

	private Label XjTeBLgcd3G;

	private TextBox aQ2eBvMQ6AT;

	private Label qJSeBs0ioTa;

	private TextBox uePeB6EpDVF;

	private FlatButton bfTeBhEfpsU;

	private FlatButton csAeB198cWR;

	private FlatButton ejbeBdFiOat;

	private CheckBox mnMeBWqX3Pk;

	private Timer qWoeB4yk2QV;

	private PopupMenu lsLeBNX2JC9;

	private BarButtonItem xbneBiLejA0;

	private BarButtonItem PeaeBFOYBnG;

	private BarManager O26eBbnBC8Z;

	private BarDockControl wH6eBVrNpi5;

	private BarDockControl DW5eBXLyHUa;

	private BarDockControl y5PeB2QrouP;

	private BarDockControl nISeBONNABt;

	private BarButtonItem zE7eBMp8dVt;

	private BarCheckItem kmpeB512ooF;

	private BarButtonItem IYieBT767oV;

	private BarButtonItem g1meBxdwQiY;

	private FlatButton X0EeBqQ2Dnx;

	public FlatTabControl tcCategory;

	private Panel QyKeBALUmn5;

	private SearchLookUpEdit vjaeBY4KkS5;

	private GridView Qc8eBHwJgIK;

	private ComboBoxEdit CfjeB3W0xVF;

	private Label jNweBJToNvq;

	private Label JyoeBrYDoG6;

	private ComboBoxEdit wcheB9nPL7x;

	private Label WBBeB8xQB15;

	private Panel VkueBUnRX3A;

	private ComboBoxEdit V30eBKFbZJc;

	private Label FN6eBtJF7pS;

	private Label rEBeBukaprf;

	[CompilerGenerated]
	private static Predicate<ATUUploadFileInfo> EdNeBomucAS;

	[CompilerGenerated]
	private static AspectGetterDelegate dK7eBj7ywLo;

	[CompilerGenerated]
	private static AspectGetterDelegate UoSeB7EQnc4;

	[CompilerGenerated]
	private static AspectGetterDelegate q5FeBfPlNsl;

	[CompilerGenerated]
	private static Func<OneRailStation, string> xKdeBDd3qgv;

	internal static CUAdminWin R1N4LttN3QQeCp9dhs8c;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CUAdminWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BVNeDWpTAKD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AtseD4VL2N7(object P_0, EventArgs P_1)
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
	private void qHaeDNZcmYR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bNQeDi5KqDs(object P_0, ItemCheckEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aKUeDFhtFut(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void I3aeDbUiNSx(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FnaeDVF8SC2(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SADeDX0g2l6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Config2UI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RuceD2XZjA1(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kZ9eDOu9eU0(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void I6LeDMMrxdT(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApjeD5I1OaF(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool srjeDT5bHPO(ATUUploadFileInfo P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool k9leDxEJEJh(ATUUploadFileInfo P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbUpload_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void xH7eDqWSKig()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetUploadFilesAllFinishByFileID(uint fileID)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutLogfileToUploadingList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oNDeDABlwSx(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kAYeDYS2uOW(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zjgeDHTdI91(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EVoeD35JcMk(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XAqeDJVOTS8(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MWaeDrLw7xC(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopUpload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NJPeD9Ffo5m(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VqfeD8Kro6e(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void H8GeDUXr0M6(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vRBeDKNMdtg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gCxeDtnebGs(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void w9OeDullS8l(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QY1eDoaaFav(object P_0, CancelEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HighSpeedRailDBUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nJFeDjm75t9()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void le4eD7ErmHT(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JaReDfJBk76(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IvbeDDjWXBr(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NP2eDB4IywL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oUkeDSe0Yh6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool FvFeDmvo6vA(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object THKeDIdXpuN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object hxjeDQJVLkm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object rsbeDlR2rOv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static string oR2eDwoCgob(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CUAdminWin()
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
				case 2:
					CICategoryTestScene = 2;
					num2 = 3;
					continue;
				case 1:
					FyQeDkGjf2f = Environment.TickCount;
					num2 = 7;
					continue;
				case 6:
					return;
				case 4:
					no51tBHZ35yMyaa8WrU.FTtBuvSzFjHhG();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 7:
					UgoeD09IXo3 = Environment.TickCount;
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					continue;
				case 5:
					qWWU4Ut6dKIs1ZDI6abO();
					num2 = 4;
					continue;
				default:
					CICategoryUpload = 1;
					num2 = 2;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					DG6eBGhB32S = false;
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GmMv8XtNb9a8NKBCCliW()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dQUhxctNgQt1QDrdJtDG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eKcDjRtNF2FlhQ5ni238()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CUAdminWin WGS1VftN7oJwJxP7B5UJ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SFYFP1tNfXAY6HqT4EDA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QxvEGNtNjGn4KvcAww4L()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object maKK5TtNeUDDMoBmDN2H(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uF8rKUtN0D0Hpx3Mx4QV(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T8trZ7tNPaNkKBukppSS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zvulcstNc1NsmfqExOyw(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dj76Z1tN8PTNaUGOQ07k()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BpqyDRtNwn5aqXpAnkZ6()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UHba26tNhtZAXEDvDAVm(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AGrE1FtN43Uk7bSZKUiV(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IS8avVtNrBoYmRBZgrmZ(object P_0, int P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h6OJsWtNDHQpcUwa2X3d(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YF7VSotNdgCWw9gXTgvi(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VfbF9TtNC3tsqkimEaPS(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fqeZnltNnh5RbFLA2msC(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cyZmMctNaSoygZJen7qi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XKH25TtNHSVYoOLbEkdw(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YLwaH1tNsjEmRpl6KtmR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ip7RBBtNlITDkILAxJaI(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EHbi1ftN9UePDRohOR7h(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pdkQUHtNkH0d3J1WBSpl(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HYS1LOtN1KTwi4foqKGZ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color aX3Zd1tNvtJc8itL2HLm()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GSDyL2tNStjAuItfs4M3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fwdJRZtNmxTtLqmYoHHe(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fQib37tNItieTb1390kK(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MUlbbetNXbCdLdoHHN9P(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n5dqpZtNUt53XyqxevJd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zT7P7stNOokLMCFBBVe7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i8F9O3tN5Dtph5lYrqrg(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rU1pantNirmv9JA24QFm(object P_0, CheckState P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DV6lNYtNz5y6Awc836VZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BQ43pctYLTtF82OQiBub(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NxKiqftYNaEgl5FEvhaA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason QCceHXtYYu6dKfxMTKfM(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YxOx91tYuqOE3BHRZgFK(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aveGIEtYyblMlk2xNZEP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KHtXwatY6yhKVyvpAELl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lV5SsatY2xlg8cC8Qfgp(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fqy3pttYJpXy16n1OwOX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BpE0YitYMkElDNQ8OqMI(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fl0c2StYKZfLKCNvXvcD(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tGS4WltYZvb3iyxV4KK9(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JaJWgZtYol27aOoUrIt7(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YEV7b6tYxUYVdgfa5fSJ(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AakbGttYAxry9CfIoWRJ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vEuCA2tYtcGZjcGhKY1G(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GG55g0tYWtkwBfNyAFpb(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t8G0VPtYBmq5OwxCdERE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FKaJLItYq2h3eDhYwVEl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OW66RWtYELSrbFLRYwV3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QPfaVktYVecbjtyqxfSI(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L3AGWotYTuHbl8LnTr2H(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cgX16utYp0LUlMiclUJk(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Orn0vVtYQbccjAlsAedx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mpg01QtYRfluGgnPjn8d(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r6l5EBtYG3nlgxQ8Wah9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long gvDlg8tY3TAilayuXX1a(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CHwrrEtYFbG9cpKOt7ll(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hbIAAmtY7ys5syRowhwB(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bgOuc6tYb0hcNIYBN2WL(object P_0, UpdateMainWinBoolType P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MpIdRctYgoZA13hmPpX3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vWfCLBtYfwft0XQ86VXN()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tjq3EKtYjMEvAlXjSPcW(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Pbdvd9tYeTrSiFD2ljgh(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sWSJqitY0AayrPFxiG1a(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool juOf8ktYPM0yvuf8sWmv(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hfFvyetYc3k8dfC1Ovdj(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sRNflwtY8jQWW0rh7Pj3(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EkQUPktYwjgI1r5RGTpy(object P_0, bool run)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KPj0MStYhUcdSxYvWYLf(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D0eJCEtY4TRhFqti8jkQ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ga9GaBtYr6OKmuFf3BOu(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u2QhUstYDRWu2H6fcZtv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lCDo1etYdmwn55NtMc8i(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HepxZjtYCdSbX67bhJrI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T1jxd1tYnmCvcakL88m6(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vGpoRYtYa7kqIHPoq6vv(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JyvZKktYH91pmF3T5Bsi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CfhZ6btYsrdapJkdckqX(object P_0, object P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dry8cItYld7fepYUlARy(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AeYUldtY9yia3k98mCCH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WasTMjtYkEMtue3HbKHO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aP4C7DtY1gHwWmMkOccF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int i0aGHvtYvhQUtk0eOlup(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yJrNrFtYSVUvIY8jFLix(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E0XOWVtYm0SQHTuQnGUg(object P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ejd4sctYInGvbLSBdLHg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VgeqtWtYXcHsfva3PDP3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle i1MxF0tYUVBS8inAf9ok(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type CpZDWgtYOIgrtfEQjbN4(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YxyAW1tY5dKwAx8hjEZK(Type P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lmiRS3tYig17BZfCp7nw(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool j150vStYzvADSJP3VGIX(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oN4XV1tuLnbodolYoS45(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fKTJw0tuNKBAGNsgVjwe(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jn42PJtuYho4JH1thDBe(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tm0qHWtuum6UsywMmmq6(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tfTc5Ftuy8jhuPubKmRZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z9vq1Btu6tH3OAO7LtA8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SGyygjtu2KmJ9gVag0K6(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nJBm74tuJ50dCExSB7GO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GK3LXBtuMCGyF48tUywd(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GTnRlDtuKhSPgfdxpUQA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rB9VZKtuZg0i4uP54p5o(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QTlY4ytuorT0YCtEWD1Q(object P_0, int P_1, object P_2, bool P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hRShX2tux41GWqM6jBxl(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tfH3S0tuA5rMVmPCrqoY(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pa3Hm3tutVOnnRW2tF36(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NDSkEMtuW0Q92pivwbbc(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mp8dSXtuB68ncD4jVmP5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CIqpMStuqCMpUe8ljtE0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V1AW2ktuEgFNp8eZGq0W(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y6EKhqtuVX54sEQNqyl6(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color RBaWwBtuTpK5Xs7rQDgB()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XIXYFTtupyUGiv7EMRcw(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iEQ50UtuQ6NyhVPbGifE(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color jXZxtPtuR9suaWAFWlYx()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I80SlZtuGRqYkB9XJoly(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zfr0letu39uI9vrKjrO1(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e89qIWtuFbeR8QnUquHY(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color BTtb93tu7kYMIaT4pEjn(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZqGOxtubbMWmLaVkVsL(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Yo5blUtug0356iFNMZTU(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void trR0MatufDnCnIqMrZvm(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LiwLnOtujToLjGvQ6WnH()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BeWqqOtue4xmGbeotDSR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NCbGLYtu0PdjyFA7ZUF3(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dbXUEStuPJ2bfaVu2ctn(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void epVMX0tucwQng1RQmN9F(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gb14G4tu81eWiHOj9sW8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F0YuGYtuwxqcnh52xoBe(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rurGCftuhX6Jdgp7G2ZI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zMvg5Stu4xwquo0QhlCJ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oK83woturd2CPGqOBGAG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b1GW5dtuDPJOEg53YpKk(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MXJ0yntudHRcHZALRc8k()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YDTMvWtuCrD77EuHDcjq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q5rAYjtunyidQnY3uq6T(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GUXBc8tuaAVjOAEm7CMM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HoCh6ctuHqA3nAHgu5Ea(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CDC8iHtusee9VLKrxAmC()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G5vk2AtulccMXcixhd53(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HwS1t9tu9ONsagvJILxL(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fgC9fwtukp7IQJUhgfk9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zPl2bTtu1ZCSEMCKk8DG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qR9R5EtuvWPuhUiJh3Pi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nCZCvntuSPDC7x4f8FPH(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uy3oLrtum4T980HZyqxc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JuOhiituIcioKnkvR6mt(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t2DoGAtuXjxZbmDB1gvb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J90DYGtuULFmSgJxMJ4f(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ljK19LtuOW2qRTVVdIfO(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ABL4tBtu59j3HpbaDbD3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wR8eTItuiaxoiXMQI8xa(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E1GTAxtuzwWornApvuPW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DSMFtBtyLiIm7dXwb0lY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BCZfBatyNvb8IgETXNiI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tWMf97tyYKG2MBxTrck6(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ijKWpStyuUNehgUC1S8F(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z91v2Vtyy407MlWnRWJh(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vy3Wt4ty6sxQnMZ7rQqj(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L0MIAJty2qC4wuCnLM24(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void umXDcqtyJdPUbl6jSYlK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hhON7mtyM0FROrY6YKtA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color gw4KlTtyKl94egSA4Ym9()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o4VvAHtyZDwyX6XxdfrL(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bOMfSRtyoC4pHyL3aHrK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rn3bMAtyx1t0lX3G5XCn(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rVRmi9tyA8ON7wQL5f1S(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L7Gh6Ztytc6e1E975mqF(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ilrc58tyWd3yvHVCOCqQ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cvWvsNtyBCDaVw4OgCuR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color TyK42ntyqYOnRd5BoRCy()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a0FocjtyETx1gOkZikXa(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gbHHI2tyVO76g6mAy7P1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YjqTQutyTn5i5iTxkUjc(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JyRPC4typy9pqlvwWPmP(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dh88XqtyQxVQQyUYhA93(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rvWpA0tyRe4nuUm2E8yE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C4nvK5tyGMClZfIdTUTm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object asRSDaty38v5K406akyq(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UveYv4tyF8DU0vkhshv0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rTyqmVty7OFe28WvyvIj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mvPtKvtybdU0hZ5uJn6J(object P_0, PopupBorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UDRFhMtygqJdERCARYUY(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bm4gWctyf5RpiVcb7ZYe(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lQGoyatyjJYgphZywYAU(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ITdKGDtyeIu4aQTMGSwB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PLQJxAty0mlLN9Vl9sfQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qdQd93tyPw0rFZ0BguA2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bbsc3MtyckLy0PtcKuCI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void st92R3ty8DUw4a7X63M1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object enmaQltywE1iLkLVPN9s(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object URlMYAtyhc7eEaygogoX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RlXF72ty4PGsf9YsSpyU(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K1O8cvtyrMk6cos7HXKD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AeuPADtyDJyC4LaXs2Ui(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SRZCNhtydM9RVnaso2UO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vK6wdFtyCvVgEAeCrJdh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JkrHmatynW2ewGCvSkSL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object prHmkVtyaKTxrIQHqV8i(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OCsxcxtyHmk3M1utERG7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ogX1V4tysaq73ILioVkk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e5k7CStylvgCCgW8qZt4(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pWWNQSty9rhghumuv36Y(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uGlNEntykE7ZbGpieNQG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ctsjCIty1cQVsYKxYBRe(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ojra1atyvUtxy5C0HsV3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WTappYtyS80mQl1YOrmm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JJYVGstymHSTreT7MG1l(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Il8Ch5tyI3T3lE4yNPCB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oeT5ZKtyXuvsZLjrZmSw(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YYloLRtyUMXeVGhNSaRK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F10MqttyOIARSccmhkRq(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iqBD2rty5jwV2NP8C6eB(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yxwcxltyiPbj7QO0KgLX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Km6b9mtyzwjWwDC6CUJX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UpWpfyt6LWT4Icny7wth(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wsHX12t6NPcoA2Nqv8HG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yaGTK0t6YpHLGxUkWYTF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AwMy43t6ug14bjqNiKP8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B19uNGt6yuMOYlZoRsKZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vyKgrut66obLnT3WD06m(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UKab1Lt62HFEZC6MW3ka(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uB1Zget6JiKZ4T8Ekj7N(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QaxfPAt6MlZpJ670C22d(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HOUj7Xt6KjwnBrxKRMfm(object P_0, DrawFocusRectStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uZpOett6ZMKpKFeQX7Ow(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object h2p0Ect6o2a266HVaJDt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dm2iWqt6xoyFNR6ejp4O(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SO1fMxt6Ax7EJ8P6Aqwm(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sZ6vqAt6tmSiWmaocXSr(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HorYDTt6WOUcXkesmBpT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ATpb3Dt6BKqj03tRFE7I(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ike42ft6qHcS3BSb5Xjh(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VrKmjDt6E9XUUEKc9cBd(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BJeyNIt6VFfxyPjwUlLr(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tHKXuQt6T05yRAGDsx8o(object P_0, TextEditStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MNEySQt6pY6hf5PN18iH(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color BomGIOt6QXwmCHodimvr()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nPytl1t6RK6muJ3B8MId(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qRO3HTt6GaenIth2i3Nb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ul7F2yt63GhFDQn7DDae(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xv7c8ut6FGJKufNGFbJL(object P_0, HorzAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Wy8MCWt67OFIC9gFggha(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eNOrXXt6bQsLnUjExwqZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ewWGTvt6go2RsXbrSuKo(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tOPIslt6fPAJgcMcO8hM(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mBUlJjt6jbsMSSAG9kwh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qbXRGHt6eIh8de6L1nsd(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SwYrgRt60m90J1kJGy5h(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zpaMg0t6PHD493CbhtR7(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xYfjart6cim4JMQAGIEQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vu0Fj5t68w0iHlHdY3se(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xkuot7t6w1XbsN95f4fq(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xvNUNOt6hGoI94VjX1nr(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vfj3DAt64cBvt8tN2PPm(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PUG4Q1t6r6OyBB8JX2BX(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oLRqPwt6DuTFbk3JSdsn(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qWWU4Ut6dKIs1ZDI6abO()
	{
	}
}
