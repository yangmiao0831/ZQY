using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LibBase;
using LibCoord;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class GlobalDataQueryWin : CoordinateWin
{
	public const int CIRangeCurSheet = 0;

	public const int CIRangeAllSheet = 1;

	public const int CIViewWinEvent = 0;

	public const int CIViewWinMsg = 1;

	public const int CIViewWinMsgDetail = 2;

	public const int CIViewWinSiteInfo = 3;

	public const int CIViewWinLongLat = 4;

	public const int CIViewWinParam = 5;

	private FastObjectListView HaUPOpwB6fK;

	private List<GlobalQueryOneRow> Ko1POaXEESG;

	private List<int> RK2POkjUg1A;

	private SelectIE E7ZPO0wNrjX;

	public int CurParamKey;

	private int BxkPOZby0qn;

	private Logfile JV3POzsZigQ;

	private MsgDetailUtils NdbPMCKwWou;

	private IContainer LQ1PMGdG7CL;

	private CheckBox VXpPMRAFLxv;

	private CheckBox fMlPMnPlPNO;

	private Label kMtPMgJnroS;

	private ComboBoxEdit jBLPMe99hBB;

	private Label uEIPMPGmRSR;

	private ComboBoxEdit KchPMEIAZcI;

	private Label rMQPMynA6Fv;

	private FlatButton irVPMcHI5yU;

	private Panel MJjPMLZQLcp;

	private Panel QGGPMvCAl85;

	private TextEdit G1APMsujpvs;

	private Panel He7PM6FLVfD;

	private Panel M5TPMhObrGK;

	private ComboBoxEdit EsxPM1Y5Vyw;

	private Label QvJPMd65wnN;

	private ComboBoxEdit g7dPMWA5hGb;

	private Label ADvPM41vjTr;

	private Label eE2PMNNKOV1;

	private Panel hV7PMiS3dxM;

	private Panel WvZPMFn9Z0d;

	private Panel EcHPMbDEgUE;

	private ComboBoxEdit yZkPMV3N7ua;

	private Label paYPMXvUrsS;

	private TextEdit lrTPM2hel6K;

	private FlatButton ifePMO8uqab;

	[CompilerGenerated]
	private static AspectGetterDelegate S21PMMhIkLh;

	[CompilerGenerated]
	private static AspectGetterDelegate rZWPM56q52l;

	[CompilerGenerated]
	private static AspectGetterDelegate YBAPMTowTCu;

	internal static GlobalDataQueryWin PjQhf1WmXpotjyIGPhOE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalDataQueryWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qlAPOxfRXq5()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Pq5POqmbBvK(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pW9POA7lVO6(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XYHPOYaXpK6(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WccPOH42fbR(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ugxPO3I13Xf(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zW2POJt3d80()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void b6fPOrJWbMN(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yW5PO9fFIi8(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pOpPO8qajxC(Logfile P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OHCPOU7tTQL(Logfile P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void N4NPOK0ORrY(Logfile P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wFhPOtfsF7q(Logfile P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pQyPOuidw1j(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YAiPOoGKC1y(List<SiteBase> P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void o4qPOj2YBo3(List<SiteBase> P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YcgPO79Ii3E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dFdPOfNIS3w()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xJ2PODuXXmx(object P_0, ButtonPressedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAfterSelectIE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VfoPOBJ8oXn(object P_0, ButtonPressedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void l2jPOS0MINS(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void U7ePOmtK2wS(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WuHPOIA9OXg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object VY2POQvQgpt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object vL3POlCNvXE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object iJCPOwgODG7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalDataQueryWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		u0ebvhWUxP2wV6dlUhbP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wVtt9dWm5fp7pUWTTF6O()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jFAcsZWmidLKV0epb43B(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object imfgIrWmzgPhEutNTbG2(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object boZBZWWILvwPwCfrjsho(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int eYdwmEWINQBbQmGTZ1Oi(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dW3HDSWmUvbOriaRTYKK()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GlobalDataQueryWin mHIVgPWmO5bmHOPMq240()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AUm43OWIYjXOUie8f4cS()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pDgfqLWIu2U6hAZBDBJR(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EWYhItWIyPlVnjYux9ud(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FklcpiWI6rZrIpMXK8Zv()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r0E9JZWI2WiMdHjavdsR(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l9bPY7WIJufLBaWcnvyn(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e9BT1OWIMgt4f5IQFB3J(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IE8qReWIKsVckoxTwOy3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KdHlHfWIZK2xW30Gav8x(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jwFxkLWIovlxEiLL3qVk(object P_0, ColumnHeaderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jLUnFIWIxm19AMC4dQMd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qay9vVWIABxc0yqddE9b(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color nxwmGWWItdKHLjYh9Sn3()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bknAHUWIWYNEAk2dOMjW(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OUKqPIWIB32Z6C7utHor(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gVq9R8WIqjnsuY6136ZI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YRalS8WIEPi6J3Mg1DKe(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qZQm41WIVVYqGVTVdBe2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OxmwZgWIT1mn7HJHha8S(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CXIpJrWIpq2HJ8PxS1al(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qfnM4DWIQ6pmBBUfZL5M(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nSg7IwWIRAyhWfZBQkMG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cdglwyWIGSIuwc4sUob7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WShypsWI30c8JiZscyJB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GqSfAWWIFxUxtiTgfpPS()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dnw8r4WI7hwnberfVFE8(object P_0, int cellIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WKR9KdWIbjkWVNlXtZm1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TFCjo1WIgu72YgN9YgH4(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason k4ALItWIfFjFU8RTbGur(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QDxSDQWIj8lVsJCpqdHu(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r3nCyRWIe28yGTJOQrYG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qr3EoiWI0Gq9LESZch4k(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qDYbxWWIPrISn1vFCHo3(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void diDqX5WIccdLsbeAIeSM(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xAuIkZWI8VdZpx3QMWWS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ufB9UDWIw56fYDW20Wqu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O3ApRNWIh4vvs4g17Z4d(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V0CboxWI4CXUnHDEeaRd(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U3ifrPWIrUhjolTRQRJp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kdGEssWIDSaOhKUFC21O(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int z0EZ7TWIdgDbRBTZFBCE(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jRcUQaWICwFxveflYPqP(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bAWpVIWInI7wwoovCk37(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qbQbNjWIaCnN675OnWvL(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Drij8UWIHKfutmyYcEDY(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ku8EQWWIsDgED1Z1OAUY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i5LsgqWIlKySmBAwYPBD(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr J72E54WI9DvtreNlvjd9(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double i8FSJlWIkErwrpAsF9P9(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wZ0gPUWI1Gc5A5CwnGsx(int P_0, double P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool evqq84WIvbeiM8vWqqux(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint DbwWcJWISKn0ZMTNZqqI(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AhcRsyWImr5FTx49BmTd(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g9JXgUWIID0u0BOmZB4O(int P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oNdLkRWIXbnFwKLFuvTb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ProgressResult PsgELlWIUmSi1ewv56h8(object P_0, object P_1)
	{
		return (ProgressResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gPT7OQWIOsjWG9H0lMNs(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fjmKSQWI5e75Nhe2kdNc(object P_0, int pointIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OENPtLWIiYFCsNsGgdiD(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char biL2BHWIzIr6ssiFynRj(object P_0, int P_1)
	{
		return '\0';
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pjiSDeWXLsWCLQyHnja4(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A5sAkRWXNwAJ8rwJNn23(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xOoUh1WXYKrEFDHRLmDs(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult gmSJd9WXuO2RR8pUt4AC(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GPGiqgWXynmS65XZoTli(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dCIZ8rWX6FgoSlCtICo3(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tun6B3WX2HurI36ZyUCt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OJJkDvWXJANRJwfirthu(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XVR8FwWXMvoTjaWbm2Pc(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult OBaWiAWXKUFk70XCJ7bc(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s2tiHWWXZIJSCaZyRxQI(int P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TXqYAjWXo3qGgjPQqLJk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dn0QWRWXxSYaiH82u5Fh(object P_0, object P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gD6hOCWXAhQD6BOIsEaU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uTpKT5WXtJnO9RruOwmg(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HbwDJuWXW87xVFEfcc4s(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V0djk0WXBKd6mrUb3Ypq(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s6OqrIWXqwJdfqbkH1EH(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bERQcSWXECPeBoYI4eac(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IeDvkHWXV2b0fInk8owj(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k1UhYnWXTmSphB5XhAdD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OFSgIyWXp0MjHvSK4Xw6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Uf7RnIWXQKjEy5AkqTxg(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BSKubLWXRqiHOSO33dEx(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BmSX2RWXGWROTbEM6i93(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BanNxxWX3IQde0nCEVjU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gs3CijWXFplbwLwCvYrO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zTq2mYWX7vtuSrxg2M5Y(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I51VxjWXboDxuUXcdCaH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D5bt1AWXgUvVa83gf5cj(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zy7nVRWXfnEihjErP2yl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DMKUcTWXjftRLPBLK2pR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r4iJljWXemdIWIYP6QVy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t6dp8GWX0BPms7j49NiP(object P_0, TextEditStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HNTENrWXPgHMxG7gnUoy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DE693oWXc2JY7iwSfjkD(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JUiX15WX8E76uSPc83Ue(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zB7ghLWXwnyNc5dhuhyJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sTPk9mWXh59p6bB9xUqF(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fv54v4WX4fK33fGUKknj(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FTsSi5WXrtmjAlhZOEZo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Uouig2WXD155QIVVa8fZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ObLmFoWXd1pvC5et0x5w(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TuCulSWXCKNAxntU3rAk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color WM4CEJWXnAXnDESDcdfe(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uLXQYFWXaABdkbRvLE9x(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IsIIMSWXHe74Z6OZrVs7(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LLrPdCWXsdUSXDdtAaME(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L6iB39WXlnVrJkX6P6S7(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qXIkj0WX9OLtFwibvdCl(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DT54PVWXkDMfDZgrELNQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GxLYhNWX1LhSJ6YqdCpg(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Oo6e1qWXvPFecBkPeRdf(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NkwnQwWXSAS2y31sdGFg(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S07VtSWXm2eTU4Xggpfo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WiTYtqWXI8Gn66r14aO1(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hsDmGdWXXZD0pop0JNF2(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color wnLgFeWXUSynmEdAX8Sm()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hbO0xFWXOCkDj1ltggiW(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BtwxmYWX5jRRLLUprNsU(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jYgDc7WXiTVW26dosTF9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Eiki77WXzLwCaRUTmWXO(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JnmQrcWULgsbpQMgmOWB(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HT0O7GWUNxhVsErYJ2OS(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xB4s56WUY64INydVPlDK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yMYF8vWUumXaQDIEoYjE(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cTkK6mWUy8rmftGvudCB(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qkvwVZWU6YqgXNGUFl4L(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YtNOsxWU2ajXUcpub54N(object P_0, FormStartPosition P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WW37XmWUJmPWho9Hdvda(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r2aXVsWUMhMqZXT4rX7Y(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GkTlVOWUKLDHa6doC7R4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rwDdVsWUZGvSCFJk61w0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PoqctQWUola8r8BgYdbA(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u0ebvhWUxP2wV6dlUhbP()
	{
	}
}
