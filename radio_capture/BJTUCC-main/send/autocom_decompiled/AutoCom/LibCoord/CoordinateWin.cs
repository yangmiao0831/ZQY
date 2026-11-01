using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibBase;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class CoordinateWin : BaseWin
{
	[CompilerGenerated]
	private sealed class zQkIhNEgDHGLTPVuflR
	{
		public string dDWPUt91Q0b;

		internal static zQkIhNEgDHGLTPVuflR OGtS4AB8OVdsbec0ZSyK;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public zQkIhNEgDHGLTPVuflR()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PB0PUKbsoCM(Logfile t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static zQkIhNEgDHGLTPVuflR()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			wbT4jsBwNe5DiS2010m6();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vATHnWB8zdY7yNUS7L86()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EdgDgTB85CREGT9xfr9Q()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static zQkIhNEgDHGLTPVuflR HKImBGB8i7xTc1LA7yHR()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Uf2fpWBwL5RoFf6x2eUl(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wbT4jsBwNe5DiS2010m6()
		{
		}
	}

	public bool m_Showing;

	public string m_WinKeyStr;

	public int m_DefOperator;

	public int m_DefParamCode;

	public List<int> m_DefParamCodes;

	public Dictionary<int, ParamSetInfo> m_ParamSet;

	public List<OneStatSessionDB> m_DefSessions;

	public MsgWinSetInfo m_ColorCodeSet;

	public List<LayerProperty> m_Layers;

	public SiteConfigSerialSimple m_SitesSet;

	protected bool HasHideChildWin;

	protected bool HasSubLogfile;

	protected bool OnlySupportScannerLog;

	public string OrgCaption;

	public OneBin CurBin;

	public SelectIE SelectIE;

	private bool kxhcUKkT7G;

	public Sheet m_sheet;

	public Logfile Logfile;

	public Logfile SubLogfile;

	protected List<Logfile> Logfiles;

	private List<string> npfcKxTvYN;

	private Timer ol5ctxJr26;

	private IContainer Ocpcu9w2lw;

	protected FlatButton fbFreeze;

	protected FlatButton fbCloseFilterBin;

	[CompilerGenerated]
	private int gDVcovYV3B;

	internal static CoordinateWin a6adLxR3lOuJwRTj6ft;

	public bool Freeze
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

	public int EQIdx
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int LogfileCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CoordinateWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void n4ucTI0m8Y(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowSpecial()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitOnLoad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnVisibleChangedWithChildWin(bool bVisible)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnVisibleChanged(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClosed(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoMyFormClosing(FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xUlcxxaDOA(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoWinActivate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoWinDeactivate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateSheetLogfileCaption(bool winActive = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasLogfile(Logfile logfile)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile GetLogfileByNameWithoutExtension(string logName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Logfile GetSameLogfile(Logfile logfile)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddSubLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAnalysisOrgLogfile(Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DelLogfile(Logfile logfile, bool refreshUI = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadWinKeyStrFile(string sFile = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WinToSerials(WinSerial winSerial, bool saveEQIdx, bool hasShow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerialsToWin(WinSerial winSerial)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoCoordinate(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoCoordinateForAddingDataByRedecoding(Logfile logfile, int CoordIdx, int eventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void FreezeChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Cl1cqkgdFj(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Win_DragEnter(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Win_DragDrop(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TcRcAMDE0v(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void BuildPopupUEMenu(BarManager barManager1, BarSubItem bsiSelUE)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoCloseFilterBin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetlblCaptionMouseEvent(bool bSet)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void duhcYOigpn(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void x3FcHpnn0P(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PJOc3D4pmV(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cxBcJGnGpJ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FoecrK2Epn(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aaPc9ZXTGH(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lXRc8Tpiqy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CoordinateWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eCZOqZRbZ586i1Y5iSh(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y1WSVFRFgKbCrdn8HES()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CoordinateWin NJ9I0FR7mMoh8FdkxMk()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A0O07nRgO94qdm4N37k(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n414X1RfrMnocI2R2RG(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FGyorBRjcgonXDCdXQW()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JgZBFjReQLPnjZoYBgU(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wEuJbMR0o8ZxtNJImT5(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kTOSyfRPOyNTUmMMhH8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eAnSHnRcls8gK2FGkmo(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b0cfCPR8j1wc6NRUmUW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hbGqlZRwv1mmYA5AJGp(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LuHOWbRhsd1CQ3HTFef(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mX9vkhR461Gvx2uPDcT(object P_0, bool bVisible)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ifn6LHRrUtUM5MlQKgc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hoyRFvRDiEL9bmv55eT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NSmiYTRdHZpFacZjaCk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hppFRMRCi3LasIyhiZF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D6nkP5Rn1VNcJJcG93G()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object baa8oZRadrQ0ta0dWN6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WDtU0pRHM4QpHaf7Xpg(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WiyUykRsyBaMFfniCpR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dqNCUsRlttenNalmyMs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool j29Pr9R9QbmpD4Cca2L(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason f3VkYZRknJT9uLdDmAS(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void in8ZGUR11anxAQenL8o(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gCMmQ6RvM6Q4ybymhyc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GgiWSARSS0qcANiBu6G(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XjXTpxRmkGMTtGKDTk9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UmbQKSRIiHbgemRAi8D(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yxEfC1RXHhJFks8YZga(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w4dlb8RU9sxFanGke9O(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OiMOwrROrkcTCKbC6mg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GEbhsbR5BpTKnxJSBNW(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R5ZyLERib3q9yFpRO8f(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s3K39NRzEZxJRb2i9FO(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uStGSOGLl8mbqMSJlLS(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gJmOo4GNdmgsfG1LgTV(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type db4SmYGYgm4sSl0K2PK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cGQWDSGu8wHKm3g0Qja(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z7aDGeGyyBn0lvDOTgu(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Eid9wPG6vfKmGomSN5V(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dU5Rm9G2UYHFO4OAk9u(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xZvRYRGJGrDQLSuG2VG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double voVyM8GMWbdENsvWQ2N(double P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size qoUWGYGKLPMCuy972bo(object P_0)
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NceAIKGZt54jGk8oxtc(object P_0, Size value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pfLJ86Go1Ui1bAMxKfh(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int D3dA4WGxx8PG4YdXO7l(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e5dJt8GAgbWcocm75u1(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point jMM7COGtDL2VGLl4LYD(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qE4rskGWOH7wFxKSoYC(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dndDsLGBF0uesJwCM8o(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point lbJvsZGqH7ux8gWVihJ(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xrtLoVGEtHI6FxiQtJY()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kUEGIZGVTUeIv1I5TJ2(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ncvUfMGTrJqVlRU3o7G(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point pgSYfxGptetWjIc5hBO(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SM6SoEGQscmJNrUq3PB(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object raRTgtGRYU6kp9IMRRn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hmmG9uGGWv451LGh8Xs(object P_0, DragDropEffects P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle fhPGQ7G3UVdyZ4Drvcp(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Y9hPfbGFn9nnH5NHHEq(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IqsXbOG7E7YDnDEjuQ8(object P_0, Type P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eLlq4UGbhcRQFQtDefl(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jlaYjjGgJJAEBMiXM7q(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nvWrENGf3RyBQX687gi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S67AKkGjdVhfDftThCD(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MiigwLGeTGrWRuqDorT()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hZvefCG0EjKvC8ZuAGx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NvSkGLGP1dgYo6JqK4X(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f2NQnQGceho6f6wBv8R(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fDVDWMG8sLbBZtLZSuJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g46TY6GwigTaihqPr8v(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object os5McbGhBhH7EC257r1(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DlPcZEG44HZ3JZb3j0x(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b1a4HdGrQTZkAk6LlA0(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LMGxeGGDARjSWkkA2AS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lYu2GgGdjBNWqEGBquO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bcQB94GCiw60YKqSwaD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NLNcVNGnPxYJqXWuwoT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jbXeyJGaXk0Q53OgZ4H(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void irhOn6GH5kmttrAnYqE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cMHxHpGsIKMkeVINp3k(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gmoMhuGlXN6RXY53mx9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sB3CQFG9laSi6HLhww5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CmyF6UGktKKxDWjfdLS(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void juprcxG1Eku7clPCjR0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zGXPDoGvuYWJw11gD7Z(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cGHY8HGSknL5M0NNNfl(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HsD9NTGmSZVdwAsHVcI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vGx4BIGIKDVTchTocPX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void APq0rUGXNmjoMlpw5AK(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void erMLTXGU3PjsJ5WWLqH(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color m6rDfoGO0NYE8mBb7Cy()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cWg5rjG5uwMWI0y7OXQ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tp6NxCGiToKSPvVBb9V(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color gq7PL1GztooEePIRGM2()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fbxVhN3L3W3MIArYTGO(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TJPHF93N3htdRPlTTX8(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fLADvn3YfpYWSoanKEZ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color FIdZtk3uYHC2ZyqsXXp(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p4Cu1b3y908tXy5jBbk()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vVrhB236kAbB6rFLTLV()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JepSjl32p7F81P8LryA(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y3RHfc3Jyrm3yG22s6D(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nD79FU3MIKB4LZQqx7W(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FIht2U3KYPPVAoobb24(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void htbVoN3Z8mkIOM5t3eD(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O7Gml83ovXYT5JHspHf(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zQf3Dh3xqvmnuoW5W1D(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wm5vns3AgAeqVaiBX6h(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YRM4fu3trJl2MSSD7Ea(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uQKQBm3Waak3IXfaj5n(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Pj22JH3BB31gDNaycog(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SAuifl3qsY3ZgCj30wo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color wQvUyB3EWlK5hY2h1Z3()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a75UaO3VBOpqcwrGniW(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UfyZDw3TXYu9K2AGOs3(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KAho563pxrpsumb4aKc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zGb36E3QEZqTQIi4eSp(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hdsd4l3R2UjibTtbZ4b(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DmbYX93Gu2BdDkyangM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TRIqQx33fQ6uEij97aY(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eY3p3F3FvsxCbDCeTnY(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UVVlrj37GP1ryXrkLme(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PoYDDw3bJCMegKjAiMe(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cWFtlI3gTIPBaFhoJC0(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nuABFp3f66i9i7R6Dpw(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F1FgeB3jNCQt3Kk2Wa2(object P_0, bool P_1)
	{
	}
}
