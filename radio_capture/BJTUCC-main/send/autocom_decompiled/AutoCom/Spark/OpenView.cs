using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevExpress.XtraBars;
using EhWfrCHt8CgdGjRCLj3;
using LibBase;
using LibCoord;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class OpenView : BaseWin
{
	public const string UIOpenView_CellListNB = "NB Cell Detail";

	public const string UIOpenView_CellListNR5G = "NR5G Beam List";

	public const string UIOpenView_CellListLTE = "LTE Cell Detail";

	public const string UIOpenView_CellListGSM = "GSM Cell Detail";

	public const string UIOpenView_EnvironmentCheck = "测试环境自动检测";

	public const string UIOpenView_PDSCHDMRSMeasurement = "PDSCH DMRS Measurement";

	public const string UIOpenView_PDCCHDMRSMeasurement = "PDCCH DMRS Measurement";

	public const string UIOpenView_DLRBDetailNR = "NR5G DL RB Detail";

	public const string UIOpenView_ULRBDetailNR = "NR5G UL RB Detail";

	public const string UIOpenView_DLRBDetailLTE = "LTE DL RB Detail";

	public const string UIOpenView_ULRBDetailLTE = "LTE UL RB Detail";

	public const string UIOpenView_MeasConfigReport = "Meas. Config and Report Detail";

	public const string UIOpenView_5GNRCAChart = "NR5G CA Chart";

	public const string UIOpenView_BeamInfo = "NR5G Beam Info";

	public const string UIOpenView_TCPCapture = "TCP/IP Capture";

	public const string UIOpenView_CallFlowList = "Call Flow List";

	public const string UIOpenView_QosFlowDLText = "NR5G Thr. DL By QosFlow";

	public const string UIOpenView_QosFlowULText = "NR5G Thr. UL By QosFlow";

	private Timer VJ4eLiVgrSx;

	private FastObjectListView FSWeLF6m1nI;

	private List<string> kGGeLbgeGGr;

	private List<string> krjeLVAlRw7;

	private List<string> vk4eLXiGorC;

	private MouseButtons d2UeL2RO8GU;

	private NetType ImVeLOaMj7B;

	public int CurViewType;

	public static int CIParamView;

	public static int CIAnalysisView;

	private int eWneLMK5YoJ;

	private IContainer uHbeL5APA0I;

	private FlatButton gKFeLT4NJUu;

	private FlatTabControl HOOeLxtpIfO;

	private FlatTabControl vaneLqmKwdE;

	private PopupMenu MbseLAvRWlj;

	private BarButtonItem QlLeLYEyLdU;

	private BarButtonItem sn6eLHH7SGg;

	private BarManager xGueL33q7Kb;

	private BarDockControl kLUeLJIvypE;

	private BarDockControl sNveLroCHC6;

	private BarDockControl VAkeL91VhDy;

	private BarDockControl uTNeL85l0j2;

	[CompilerGenerated]
	private static AspectGetterDelegate krjeLUllUFw;

	internal static OpenView W9SuKexgIwxLK0M3ms9R;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OpenView()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNetworkAndType(NetType netType, int viewType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNetworkVisible()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oSPecZchBTC(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mM7eczCWlSZ(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ya4eLCKqjGt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TdkeLGieS9E(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Qe2eLRG2Va0(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void e6SeLnplD8v(int P_0, List<string> P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tc9eLgR8vdY(int P_0, List<string> P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void y9EeLejRaH2(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sLheLPxhjwO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UDUeLEYhxAl(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CoordinateWin YUOeLybQIUx(Type P_0, string P_1 = "", bool P_2 = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fL9eLc2Ttc0(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oTxeLLWy2PK(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveByTimer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wRveLvneBZP(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void c3jeLsqdlMX(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScfeL6Mk8nX(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bFveLhI0U0u(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rXAeL17JWyI(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UtteLdJULek(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NcXeLWVs69F(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LpNeL4dXoPj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object i4EeLNrMRnX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OpenView()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					CIAnalysisView = 2;
					num2 = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					return;
				case 1:
					CIParamView = 1;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
					num2 = 2;
					if (1 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					no51tBHZ35yMyaa8WrU.FTtBuvSzFjHhG();
					num2 = 1;
					if (false)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Cygpq8xgOvobBg8npT3E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qs7TTyxg5tLTUjQCJLW8(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void foLv2sxgicJx1M2eStMs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R2LdQjxgzFc6n4liZHnO(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UgrIsPxgXyxQCAGXwkgj()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OpenView vwTiUfxgUNMbkXDEk9i5()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vtRBqLxfLUsY9IadLu86(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uinkiHxfNLo6dES1GGpE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XY7WKNxfYD1L6t1TGN1m(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason mAXl5BxfuablKjqIXlBj(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hXcZCLxfyaQqwoNCwlkK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ebCMwHxf69qiVYhnDEMf(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QwMhErxf2pSsUqn64emF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int W03wv7xfJQ82ODy6UJFs(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WINNgdxfMDV2QqmDQWRs(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ia6rr8xfKkQOlaslaxfZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jqrMTkxfZGkgBXg3ebMh(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RxB1bxxfoJUL3UN5rhMp(NetType P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MGYNtsxfxWLGNoiMEqZ2(NetType P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eZ01lbxfA88uCg96u7eB(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t2GgxjxftZRx9eLB4Ojf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JRegPpxfWoqsqI8L7hfY(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O7rOBwxfBCRpDfVWUkcy(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OoPAR4xfqXBBM1mHe23W(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zIFp1gxfEiYLrUWsDY01(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mZg2Y4xfV1npogOxDd7U(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fa6b7YxfTNXoJbMDZBkL(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tvwl7txfpa73Idh6KkxG(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vrVIGxxfQSf2AyZRhljD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rFvlOSxfRyok90RxElXa(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C8A8m0xfGffTo0rpi3Ds(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mntna1xf3lj4QE5OETKF(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yXhaBuxfFl5UNO0SRHGA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nYSMEOxf7peHmi2YMsRT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oIUbc8xfbaHLKG5NhpEa(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NCWbZvxfgXEcOxC6NZsO()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w30XsExff6Ic21XWXS7W(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G7toa8xfjPY1ppvDEdFd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PepSTvxfelow8Pwb1Rb1(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NbTaZQxf0eHR9UykLhr5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bvNC8XxfPonC4K9GvTFf(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vsI8LUxfcfuTay1DKQdj(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color WabBKJxf8K51mFeprNKS()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I7wrxqxfw5csC4TOKq5V(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k4kHAMxfhiET0d8neFGX(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NKEUlaxf4Lil3h7amg3n(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LkA2FCxfrtmjFkjDG1ul(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void chfQSAxfDSNZHQ3OmMb3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VfxHbKxfdw0gMtwKmD6t(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wemiJOxfCAk5gJtNxp9g(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UHHhjixfn80BjC8PmFqG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object obf1r7xfaC0bhurLPHRE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c9ajt4xfHbsA6eytAl1b()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Lp1WrfxfsBBZpQuxAaCF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lujVdcxflXns4TQLZ0SF(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle qNiENkxf9eslLpVHjq3y(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type nUTNjpxfktdXy56hnAX7(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o0lYZnxf10krg4i27QYh(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NtmwjHxfvq1OASEl8trq(object P_0, NetType netType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LKkvESxfSiXWdkwUCiIt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VfHiuWxfmwNSm2o8dVKP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nu2GaVxfIPaKrEsv0Ron(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UR2B5qxfXut2akcITw9n(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ewgF93xfUjhLttQSS3Gc(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void miJgUnxfOl374Q6tWSo0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CSOV7Wxf5Yvqn3OiBsBB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YcOst6xfiWbIGeMso65X()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eH7WQoxfzRROlfdUOY2O(object P_0, NetType network)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LXHxW4xjLFwWYKhmlj1U(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eNDyl8xjNc8CcRSarIA8(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LyjIh2xjYjBWIHCH9q75(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HsnLX0xju8GgOfqehhBT(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t2MPe7xjy7YDhr49nFkO(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oWtEZLxj6I1gXTJgv5aD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DWPU8dxj2XPgasU62xRE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qujG7CxjJR05EswZZPUo(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YIZmHrxjMryeZF6PywZ1(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o3TOpJxjKdu5M2SLyN5h(object P_0, bool P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void udIt3RxjZvvAjycxgAl9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xWcU6cxjotNPnOlSyibQ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ODIWiwxjx4tukRron5DV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QZ0AnDxjARIaVrGpk7PQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kLiHpyxjtD1tWxJlNg8P(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YP2WX5xjWcIxSu1UAulP(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o909cmxjBIRHZKD9D1eP(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JOrA5GxjqWmTD3ta6EOS(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color SPD9HwxjEysFWMHQDqCC()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vFDDvqxjVEDsbGyRJWR3(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IJnC5pxjTcNItwnETpFr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RECjLxxjpLt2xpnOZ7jc(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nhg93MxjQ13bd4jalFor(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color QHBlflxjRSnrxUuSLNnD(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bAIV7ZxjGfbdRGnx50ji(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ebgrVDxj32yHgu0gKia3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mCbFN4xjFagB668Z7N6p(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e6XL7Lxj7Bbk293OeSf9()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fJnNeIxjbh3lgC0K3q9A(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E2R8ybxjgRBYjNUbBkQ3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JBVpJkxjfMIdXd7kKyZ0(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R6mRWwxjjnUjIUxNCngW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hY2KP0xjedEvne74XUfk(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QmkdFSxj0AO301llOFef(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wgK7mPxjPlLsFcgoEZx1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color UJLcmAxjcWRxaj7jsj4g()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KxlMKlxj8wXdLD8rMiKF(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eebA2KxjwNmI6hX58U92(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color UgWiYKxjhXryPDNtZ7YG()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UStNoqxj4B89LWbKdIl5(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eyXyc3xjr1sb20Qqtavf(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LradWSxjDxJD7O3c5kuw(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pi2r67xjd4kVcKvONtt3(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wQ3qG6xjCRIbHEOn86jN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z094oexjnwRGTDwERmBs(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aX2kfOxja3mbplBIup3P(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vpx5Z1xjHkT3uUsjlD9B(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kguk9FxjsxvTggRXYU0d(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dYkJGQxjlKKFrqT2T5gU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void THEQqJxj9gneYaLAP1w8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xVbOeCxjkh3KNXeojGVi(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rP2MiCxj1kO9tdvMwxig(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BmHyYYxjvqIU0g84yAXH(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rWgSwkxjS4VZStRxQu59(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oiHeYyxjmc8awpxa9i7E(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uiA6FlxjIjW0NuGnpfPN(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VprVvRxjXvkLqj59g9g3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V41wfjxjUtNcx7IFFJye(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WW1s5sxjOeOF9FeJQG1D(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fteGesxj5wGrA7v2NNbw(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XGrCkXxjiJoGhNkKTIE3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TFLaHsxjzNEvg35GjnwC(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cbxMqhxeLSGB79GESAqA(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ItBcOjxeNC55FnSbqm2a(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z5w60SxeYGLUMjQvkrLj(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CVaVnhxeu0YSjycG6k6S(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XnFOOLxey93FI5649pKq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fgEv4Jxe6MAHcJ31rOfQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S0ypZOxe2RNaHdRtPo7n(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AZbg4GxeJtFxxBXlhS4f(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k3wIvlxeMse5UW7hggI8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CSP68XxeKPi2hyANmWwi(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i57Of5xeZhlxpSj0qkmH(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FRZ5BJxeo0bvBEg98y2c(object P_0, bool P_1)
	{
	}
}
