using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using LibBase;
using LibCoord;
using LibCoord.ReportForms;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class MainWin : BaseMainWin
{
	private delegate void x0GCIN9DUHsm8jOFog4(Logfile value, int eqIdx);

	private delegate void LKTaff9LHIBX00QZBuZ(UpdateMainWinBoolType type, bool bValue);

	[CompilerGenerated]
	private sealed class L6y670kIoW7w71nBshM
	{
		public bool OS1ERsbnAK2;

		private static L6y670kIoW7w71nBshM UV5F5mqbwMvJdRPPIBO9;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public L6y670kIoW7w71nBshM()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void XIcERvIe8FR()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static L6y670kIoW7w71nBshM()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			SqheJmqbdfecyaI0vUBR();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void c7WMPqqbr7GWGaLouS73()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Mhpa2HqbhN37Z4rmhwYw()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static L6y670kIoW7w71nBshM S9L3mFqb4KMnkDbC9tGH()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cxSHbXqbDYN77RJyAeCI(bool P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SqheJmqbdfecyaI0vUBR()
		{
		}
	}

	[CompilerGenerated]
	private sealed class grvxw8kGO9yITw9YXfj
	{
		public string uDlERhMEhp4;

		public MainWin d3CER1lsA96;

		private static grvxw8kGO9yITw9YXfj Xyq7ixqbC2SJV1Qm9x6h;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public grvxw8kGO9yITw9YXfj()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void hUiER6rlniN()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static grvxw8kGO9yITw9YXfj()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OTE3taqbHEGVbEY0DC5l()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hlG99oqbnvNMbXnHxlv8()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static grvxw8kGO9yITw9YXfj Ny8qyxqba1wR0Em17ODL()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tMKYl1qbsxrSkKIKoOoo()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object z2o6yUqbljSCce7LuOYr(object P_0, object P_1, bool isConnecting)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kGcmFUqb9LtWcpMI6Xkl(object P_0, object P_1, int eqIdx)
		{
			return true;
		}
	}

	public const int SC_MAXIMIZE = 61488;

	public const int SC_MINIMIZE = 61472;

	public DefaultLookAndFeel defaultLookAndFeel1;

	public EventHandler BeforeProjectDisconnect;

	public EventHandler AfterProjectDisconnect;

	private Timer MESgp7Anfnd;

	private Timer mdCgpfBj5w2;

	private int l2ogpDphPQY;

	public RibTest ribTest;

	public RibReplay ribReplay;

	public RibStat ribStat;

	public RibAdvance ribAdvance;

	public WinLocationAdmin winLocationAdmin;

	public TaskConfig taskConfig;

	public OpenView openView;

	public ForceConfig forceConfigNetWork;

	private CAERI_ATToolINS eIsgpB0KRLh;

	public ProcessConfig processConfig;

	public GlobalDataQueryWin globalDataQueryWin;

	public MergeDivideConfig mergeDivideConfig;

	public HighSpeedRailRepair highSpeedRailRepair;

	public MetroTrackRepair metroTrackRepair;

	public AMTUSceneCfg amtuSceneCfg;

	public AMTUMatrixScene amtuMatrixScene;

	public AMTUControlCenter amtuControlCenter;

	public FileUploadWin ftpULWin;

	public ReportWin reportWin;

	public BaseWin reportNewWin;

	public FileSynWinByAutoTest fileSynWin;

	private Timer zh6gpStaVqh;

	private Timer mMXgpm8gc4E;

	private Point EadgpIBHgoL;

	private FormWindowState WUCgpQKfNGo;

	public static int ScreenY;

	private int iilgplQlrEv;

	private ulong DOTgpwHxoJr;

	private bool tJegppAIFTw;

	private bool NgfgpaCWtR1;

	public Logfile PreCaptionLogfile;

	private string hMtgpkTcOi9;

	private bool sFbgp01guQu;

	private bool fLvgpZihVuI;

	private bool Rv4gpzdfdeV;

	private BackgroundWorker cU4gaCFhPl1;

	private int NaegaGk8JwG;

	private int xUhgaRLfWvx;

	private string W1igan2Qrct;

	private Graphics XcMgagoSFBv;

	private ToolTip HCOgaemnlrb;

	private ToolTip YEOgaPgO4B5;

	private IContainer eWFgaEVpriK;

	protected FlatButton fbMin;

	private Panel xpWgay4tUJm;

	private Label ftWgacYo2D6;

	private Panel diegaLeruEH;

	private Timer bnRgavgwVr8;

	private PopupMenu yhMgasHX2EI;

	private BarManager hypga6uNUH2;

	private BarDockControl NTWgahLh1Md;

	private BarDockControl CsWga10cGka;

	private BarDockControl BqngadxBg22;

	private BarDockControl m3ggaWZJaXN;

	private BarButtonItem sc5ga4Mlpub;

	private BarButtonItem muDgaNTgk4a;

	private BarButtonItem hG6gaiDI5UH;

	private BarButtonItem otngaFnX9Ji;

	private BarButtonItem xQ1gabKv2an;

	private BarButtonItem sO0gaVt6Eg7;

	private PopupMenu WZGgaXFD5Q6;

	private BarButtonItem L4Oga2GeMB4;

	protected FlatButton fbScreenShot;

	private BarButtonItem D2ngaO0dqt4;

	private BarButtonItem dlCgaMftuUM;

	private BarButtonItem fjYga5NMwiy;

	private BarButtonItem IJFgaTlxIkd;

	private PopupMenu YWVgax3rktj;

	private BarButtonItem txPgaq6p79u;

	private BarButtonItem p7hgaAongOf;

	private BarSubItem PekgaYgkj3H;

	private BarButtonItem E93gaHgI3m7;

	public FlatTabControlWithAdd tcSheet;

	private BarButtonItem DKFga3IB1Bh;

	private BarButtonItem OE5gaJ38kEH;

	private BarButtonItem d9kgaricIo2;

	private BarButtonItem mciga9ZkGJ4;

	private BarButtonItem Aebga8SQfEo;

	private BarButtonItem zBrgaUooinf;

	private BarButtonItem JRSgaKL77Kq;

	private BarButtonItem uf2gatR7Aib;

	private BarButtonItem fdogauD2iJ3;

	private BarSubItem mIXgaooDFrT;

	private BarCheckItem WNggajdv9Pv;

	private BarCheckItem LgMga7gnBM9;

	private BarButtonItem nnDgafTLecD;

	private BarButtonItem aRZgaDHpyA3;

	private Panel XchgaBUuFWn;

	protected FlatButton fbMenuFile;

	protected FlatButton fbMenuReplay;

	protected FlatButton fbMenuTest;

	protected FlatButton fbMenuAdvance;

	protected FlatButton fbMenuStat;

	private BarButtonItem xghgaSuPINS;

	private BarButtonItem HiDgamw8Ydc;

	private BarButtonItem HbqgaIh4TR0;

	private BarButtonItem UGLgaQXFdoG;

	protected FlatButton fbGlobalSearch;

	private Panel IRtgalMjIDL;

	public Panel pnlLogo;

	private Panel YNsgaw76Glx;

	private Panel Vn2gapJ3bHt;

	protected FlatButton fbScreenShot2;

	protected FlatButton fbGlobalSearch2;

	private BarButtonItem ykmgaa97HDP;

	private Label Jiegaka7uG8;

	private BarButtonItem RY7ga0nwBkJ;

	private BarButtonItem S1egaZqgZEH;

	private BarButtonItem iGhgazVHYLm;

	private BarButtonItem JijgkCbiWes;

	private BarButtonItem r5kgkG2v1yY;

	private BarSubItem wRHgkRI1jbV;

	private BarButtonItem Y3Ugkn9KeLu;

	private BarButtonItem wVrgkgqNNdx;

	private BarButtonItem zEkgke9YSxO;

	private BarButtonItem fGUgkPZfVol;

	private BarButtonItem e37gkE0Wu2G;

	private BarButtonItem hBpgkyuuaVf;

	private BarButtonItem AvKgkc5Lxyh;

	private PopupMenu mD9gkLTfKmZ;

	private BarButtonItem kOdgkv0v82T;

	private NotifyIcon d5ugksmAPqU;

	private BarButtonItem xrdgk6iQMKY;

	private BarButtonItem rfKgkhx5B84;

	private PopupMenu gBygk1gXuGl;

	private BarButtonItem sJWgkdXxT9P;

	private BarButtonItem VSegkWEA4xs;

	private BarButtonItem vhugk4yOnxR;

	private BarButtonItem D2agkNcGFZl;

	private PopupMenu G2MgkiFAM3g;

	private BarButtonItem zQKgkFCnvbx;

	private BarButtonItem d7NgkbRFJ2m;

	private BarButtonItem VIwgkVx9U1E;

	private Label u3JgkXeRr02;

	private Panel sFQgk2othMQ;

	private BarButtonItem f8fgkOEbKxe;

	private FlatButton mySgkMHYgf0;

	private Panel sJ0gk5S1xI1;

	private BarButtonItem BA7gkTQGd8P;

	private BarButtonItem vOjgkxaY64t;

	private BarButtonItem qmggkqnS3A4;

	private BarButtonItem JRrgkAExBcq;

	private BarButtonItem OwIgkYB7wWu;

	private BarButtonItem QAKgkHKXHR9;

	[CompilerGenerated]
	private static Predicate<EQObj> YPVgk3IdEKj;

	[CompilerGenerated]
	private static Action nSsgkJe5eJT;

	private static MainWin IpH2MgxuCYAYHG9DGoio;

	protected override CreateParams CreateParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lR4glx4oOTX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FdQglq3noce()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kYbglAl5aXD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WinMouseDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WinMouseMove(int iX, int iY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void b8TglYRNLFM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void N7UglH0VkkY()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UU7gl3tSjGq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void a28glJaytxg(BaseWin P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScaleWin(bool isResume, BaseWin win, bool useNewSize = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kutglrWeUq7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void V2Ugl9b0sqZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Neqgl8ZkGT0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yCVglU6b7wR(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ptRglKiGVFq(string P_0, MessageBoxButtons P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LZkgltSlmk2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void J0fgluhhSa7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NJDglosBc2g()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gaUgljW34AJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XKtgl78eey7(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cDlglfWO4RM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tAQglDlyG94(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void voAglByTLtM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gH3glSHoRxp(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MLrglmhp1fO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CvQglIxogIf(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClosed(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TlPglQfy57n(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void A8LgllTvYHQ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bRgglwLf0DR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RUsglp9J8MC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oMdgla2rWQL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jhtglk1KdBC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void v2egl03vrtA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void G2oglZG88RI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kFVglzwAFwl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RbXgwC8uU8E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveProject(string sFile, bool isCloseAPP = false, bool onlyCurSheet = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenProject(string sFile, bool showTip = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FSTgwGRFXLY(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aHugwRMOuju(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void umngwngTU9g()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void t9SgwgviDow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KEVgweuJcpK(string P_0 = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PstgwPHLXIx(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void e5AgwEgchVs(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResize(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void A2mgwypbylK(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zk2gwcTg63x(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vbegwLDEcUL(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xkZgwvmVMHB(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void v7EgwsrFR4o(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void C5qgw6mybUS(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMaxClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool NbVgwhAj83v(Logfile P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Tjhgw1jJplM(Logfile P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool AddLogfileSheet(Logfile logfile, int eqIdx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateSheetLogfileCaption(Logfile logfile, bool bForceRefresh, bool winActive = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pd0gwdvYQpK(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ioygwWCjxuk(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void T2Vgw4IihEI(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LRVgwNGsOYH()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eiZgwiDM2vb()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WWqgwFgJDVK(UpdateMainWinBoolType P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateBoolValue(UpdateMainWinBoolType type, bool bValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbEQConfig_Click(object sender, EventArgs e, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbTaskConfig_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WndProc(ref Message message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void p8WgwbBbke5()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void REogwVSiT4C()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xn0gwXx1iE0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lgFgw280d9K(Message P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CD5gwOh8Gbw(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nhogwMqd4DU(object P_0, RunWorkerCompletedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ygVgw5mkIQS(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qBugwTxoa7x()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eOtgwxkRVnn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Oh8gwqlc7ep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbConnect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xpwgwAFXTY3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Cb5gwYoYZat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbView_Click(NetType netType, int viewType, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbTest_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoLoggingSwitch(bool autoLog = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rVHgwHh3bvA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAutoTestCmd(AutoTestCmdEnum cmdEnum, int? eqIndex = null, AutoTestCmd cmd = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uCbgw397qKk(AutoTestCmd P_0, AutoTestReply P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RvXgwJQvhga(AutoTestCmd P_0, AutoTestReply P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoRefreshCurTasks(int eqIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoLoggingSwitchByScript(IntPtr socketHandle, string sName, string sPath = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoPadStartLog(string sDesc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoOnlyStartLog(bool isDTLog, string sName, string sDesc, string sPath = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoOnlyStartTemp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoOnlyStopLog()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAutoTestStartOneLog(EQObj eq, string sName, string sPath = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAutoTestStopOneLog(EQObj eq)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ixEgwrnSisn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wmDgw9kXlf4()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sWBgw8SU25k(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CpsgwUs90lN()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void K8wgwKiIusN()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbLogging_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbReport_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbReportNew_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mXDgwtc1WgD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbForceNetwork_Click(object sender, EventArgs e, int x, int y, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbForceAT_Click(object sender, EventArgs e, int x, int y, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HBPgwuTwqMM(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFreezeBtn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void olUgwo0fOna(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TxCgwjEKRiw(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BDdgw7KM6HZ(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vhtgwf7HSHs(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rR7gwDF7lkM(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jMdgwBRBDVF(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbExport_MouseUp(int x, int y, int exportType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LKXgwSBbAte(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VCrgwmKZLW0(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FCQgwI3baMj(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vZDgwQbaJZR(object P_0, DragEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eRdgwlhhVBn(object P_0, DragEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SOWgwwcHLgq(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kAbgwp6GBut(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbProcess_Click(object sender, EventArgs e, ProcessConfigType processType, int x, int y, string sCaption)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiLogMergeDivide_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MMWgwaUovxL(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WD6gwk1443g(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OQJgw0lDUUI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ncjgwZ1jXHB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VpngwzYcupt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void twOgpC0JlIE(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jrtgpGlGYIw(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lAZgpRQlsWA(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UPDgpnow8AR(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiHighSpeedRailRepair_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void d5egpgWBrck(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fmsgpenMp4d(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AEtgpPxktBq(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fuwgpESBtH1(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mf5gpyQrRCN(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eIagpcs55Qc(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiNewProject_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiSaveProject_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiSaveAsProject_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiSaveProjectCurSheet_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiSaveAsProjectCurSheet_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiOpenProject_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eUhgpLc6QOW(FlatButton P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void L6GgpvjvESd(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LSugpsUweJE(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnpgp6eFovw(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateRedecodeInfo(int iLeft)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiSwordFileSyn_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xKQgphTqvPa(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ooJgp1bIOUV(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nmHgpd1HrPb(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAmtuPopupMenu(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbAMTU_Click(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbAMTUController_Click(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshTestScene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eSsgpWppLCO(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fYXgp4WZFOH(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hTsgpNqyyXv(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cyJgpi5dXoy(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbDataProcess_MouseUp(int x, int y, int exportType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpqgpF4Q8mC(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oj4gpbvmdcw(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void M3QgpVSj8nn(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateLoggingStatus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbAmtuMatrix_Click(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Point GetShowAreaLocationWithScale1()
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Size GetShowAreaSizeWithScale1()
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Point GetShowAreaLocationWithScale1_BeforeMainWinShown()
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Size GetShowAreaSizeWithScale1_BeforeMainWinShown()
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wlSgpXWWiX8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiFtpUL_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WM8gp2wEmJk(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DefWndProc(ref Message m)
	{
	}

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
	private static extern IntPtr nFRgpO3GRFU();

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hHOgpMWEbQ0(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbStatMenu_MouseUp(int x, int y, int exportType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JPTgp5o3VLe(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void elYgpTkKskI(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Pm9gpxS5nUV(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateProgress(ProgressInfo progress)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsProgressRunning()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qocgpqKxFKi(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HbigpAIWvDQ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void v0MgpYPELcL(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qrsgpHCkmRg(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IFdgp3MUJrD(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nGWgpJ5lcC6(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zqTgprdMTNA(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aKwgp9c6m3a(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void y9jgp87D2hD(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void e3ZgpUnBI0X()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void gYhgpKiUxvK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void tmLgptu8W8n()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool OgHgpug4IUw(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void JWYgpovSVXH()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static void mVGgpjiK7P1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MainWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		DN3wOdxuHA8Z86TGyeIj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DN3wOdxuHA8Z86TGyeIj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nI9LLaxusqZW6fYsTkLT()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YNya1pxulqVwcaa42cGb()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle uHjKOhxu9MmRkahejSJo(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle iMM13jxukUmqOqhllYhI(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gDA3Ujxu1cX1j5LbEDiw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HpnG8kxuvkAsBQLqjEth(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OOv5d3xuSqbe2SEBbpm0(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eaIYDXxumSxTs9yry4po()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ww2xD6xuIJk1eRlT5fmL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dCd6OtxuXl3uO5uEe52M(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hdRZJoxuUK2fHA3xE5U9()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yF220sxuO2t17Vwno6vS()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zMfFexxu555yfoMdt0XL(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DqsnpRxui5fToYviFVT0(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ToFSWIxuz5CrRrvvmcfW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aQka8exyLtg5Yhux6jQX()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g62BqhxyNRfuNnK793I1(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vMUtjGxyY2K0R3YiXQMv(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int krbn7rxyuDr6PB2hxIfg(object P_0, int P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V3RKFhxyyq3MC9JBQFfn(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult UehpdExy6cQ9m2r3T2Q8(object P_0, MessageBoxButtons btns)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ySvVNtxy22idO9nNl1aK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WSpOQNxyJ9id7e8TZTLv(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E4o6GxxyM1TpnufOLxr2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VC1lhGxyK1qMEMg46JMi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bepi6axyZYQcUdxjEKuU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C7493CxyoW5mp93XFYi9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lodhK6xyxgfx1IgFGJFj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N9faI5xyAOXTAZ1OjIXI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r380ZgxytfPK2QFBxB2s(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NH0F6NxyWgPfJG79V2BW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e8XfZBxyBdemjTAO0H7h()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zFWV37xyqEvxWolWJw4t(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ProgressResult leYrLaxyE45Gy3PRl9el(object P_0, object P_1)
	{
		return (ProgressResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dG0kgDxyVwo6fiHVbJUp(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object biIq4RxyTMaI1rUpuuHa(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NQXticxypPkAaaER4Iqs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fo23w4xyQAB5SDrQfLkt(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int HeNsJ9xyRo0ksed8fex9(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a85oL6xyGvGud2o9uxkx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h9OFtNxy3MvGEjNKu451()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DU6iIGxyFPIXN3GLHeLE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aRZQOyxy7oxFk8aGFiYP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TLdvRsxybbrMVgVYl5Su()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dBmhoBxygb6MZConGu71(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pnkvMtxyfNaxmNR9sFEo(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FJRrubxyj9EfnXTkZaLE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fO7it1xye322X4jhpOLb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VMhonExy0AK9yyOOGVTS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lrm9gexyPrjBFUpdsK9R(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VWuq2bxyc2KoHv75pWbJ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kGkYaPxy8xf7yH6r4hQG(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vFi8UTxyw6pnGRcIDgRf(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bGIYrKxyhMlkxRfNFJQT(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JA90UoxundkOZkAjykoa()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MainWin w48GVxxuaLGfSZbkP4A8()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YIgk09xy4bFBvCrcJcu2(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cu5AOsxyr9cw3CLQfyNJ(object P_0, int P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point RcrQ80xyDm9TQ6yMY8I9(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point SymE4xxydDWIOc3gM7KO(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jqfSnuxyCcYTQYcaIRD2(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size kGb9x5xyn8E4WGxCTvKF(object P_0)
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle n7CJicxyaM7XcBPZw3Lc(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ARhjVhxyHTbWujfw77Rs(object P_0, Point P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nVBWAJxyskjlSI33o01p(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SGwB81xylRGV1CSptVUH(object P_0, SizeF P_1, Point P_2, Point P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color YLSbBTxy9eVqjSmNi15s(object P_0)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hMBBYJxykXhYBPXvfi4b()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object isuDJtxy1jsS1j78tX1N()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P9SP25xyvFCIPTepSKeF(object P_0, Color P_1, Color P_2, object P_3, object P_4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WSgd1YxySA9MbGfX3HWj(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B8JDyWxym5q7e6GdZYQl(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fSWwZaxyIthgfryf4HAG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FBUZR8xyXCKbZqyvfs3W(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s779gixyULFhb45MIxO4()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tOrA44xyOfRT7eAO4inR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k4jWgpxy5lylJut47Pwb(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uRsPxRxyiF6yYixcB3Ea(bool P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BwLbDnxyz80miyv6c5hZ(bool P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B9RpaKx6LEdWwGgxkDxH(bool P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w8GITSx6NsSNi3llWeri(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HY82sOx6YKj8yU3FLSqE(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iZhLbqx6u10mASaZadfJ(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tMYNPPx6y7w4JNpTwykG(bool P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eUJCZpx66Gpd7wtZtipv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fqS6f6x62pbw14V6Q0Hm(ulong P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void akKJmux6Jm1gJInBjWY2(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eg3dJpx6M8CZfOvRg8Uo(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sTv12Sx6Km2OK9Q51dWM(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult GeFAIbx6ZPdZmWD6JGvV(object P_0, object P_1, object P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xvcdoZx6oQJJmTTb7OqN(ulong P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime M6vbB1x6xAMt1JhSCTon()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult MMyt6Lx6ADsB8yD584FG(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xWir10x6tUX0AseCinNS()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s7bRr4x6Wsk3wACHLXuq()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w1QBAmx6B2kypWXyP8uZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IehmDRx6q7DnC7I2hdfD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a8k0JWx6EFLANW03RjUZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tEEgKrx6VeuC9y06JilS(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cKCIhHx6Tc1watfiC5PY(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void faIPdux6pgYadBo1Du3e(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kGND5Cx6QS2b97kPrCKL(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fCpB5Jx6R4UbOCZC0JXX(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ntNxGrx6Ggf7wlEUqGfF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool G4e5fsx63w3WHRGD1PhB()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vrKcB2x6F45x7v1d7LPr(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tOggVZx67w0jR80uEUZY()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fRmCyxx6bO7yXdqhVYtv(WebServerOperateType P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Lkbb03x6guhRWZXFb921(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aHoZlqx6fyhI7Ol6LHvH(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EwZFUvx6jbPVYD96BQsG(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int t03nwFx6ek909eAQlnNX(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle v57IRFx60eCMX6xtAX8B(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LMSb27x6PtDhiuLYptnl(object P_0, bool visible)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type UVKRQJx6crCRdNn819Ol(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GUCl5Lx68Ff3QfKxlaUL(object P_0, NetType netType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c4ebrox6wtec5ueVqyQL(NetType P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hyVMRTx6huVfETsd4XO7(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k7bO8Jx64I7VioMvgtUn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UjgJnxx6rI9BTqM72ReK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X0fQdqx6D5iPqtAyiJrX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bDFiHpx6dFbisa62TSli(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aE5Sbnx6CBxAle4SxUE1(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RqxHW4x6nmHZiwXRXnGw(object P_0, object P_1, bool isConnecting)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dKifS6x6ap9g3qNFQZQD(object P_0, object P_1, int eqIdx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wMRbrax6H18VReup8lRh()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AVrMeox6sCcunL9vHQ8d()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wCMJF6x6l8po6HiyD1yf(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gx7DVHx696DcDdO5ZBEx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fJlGXTx6kAkPjL2mM9QJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QsMPZ2x611BNJVqGqmOM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X2d7oqx6v8y3fKamZqDI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pBpP9Cx6SKh1orqJ7Ife()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C39imEx6m8N12hedecgY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uFhsWFx6Iu5sOQ5VXvfI(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool idJmkbx6XX229NswMqN1(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ixSGebx6UNSGdSHqF15Z(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lr5JEQx6ORMwGJpYKTpL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tHoyxUx65CDfHMVQG0VI(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MBXsDox6iVFVPrsrpYWL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pXUc6Ox6zEo8KxSCJfd9(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jCvBIex2L2SQA7hmxHjf(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tyQGlmx2N6JWQ7Zeoqkx(object P_0, int hourDelta)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PYIjmXx2YhGh1gSiDvNE(object P_0, bool delABFile, int dayDelta)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IEQUl4x2ulGTiNTYKQgm(object P_0, int P_1, int P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QRooOFx2yOpAOBPSLv33(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J6g284x26n9EXroF2T3e(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FormWindowState AvoVsAx22Ob18vWCCXBk(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (FormWindowState)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HnS8psx2JZqDUR5MM1vD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int zv0wSqx2M0VQ0Nm577rr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eE7gunx2K84whBFpBCOA(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr Veq0fKx2ZeitBE8anokA(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VVOJJax2o4LqheLOtIaJ(object P_0, bool isOpenProject)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cE3Rg5x2xUFoKFk9EAjM(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VEbCgwx2AtqC3uSQLmL8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ixLSKox2t1Be7ZNB2pfu(object P_0, object P_1, int P_2, object P_3, bool P_4, bool P_5)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zk3jlyx2WbVwGkE8hbMD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kc5hGXx2BpvNqoxYF4SW(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AIq5tex2qjbAgrhTrs45(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s60ygDx2EbyEtDpuvcsW(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eCjM76x2V4YeFEARuH6P(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wq2Dh8x2TnpG0jNd6dSN(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zaRRUYx2pCD9Ro7Kb35e(bool needWait, int sleepTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fyn5L8x2Q3ZWPDuRn36l(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XclNi9x2RUf7MnbVnkKi(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pPleBFx2GNENfyWOaEZB(object P_0, bool P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mnr6OMx23ggehWhNPyei(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Lq5yKZx2FSE89NFyfSbU(object P_0, FormWindowState P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WvZ745x276r8AbuAe6ej(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VrWxEEx2bIJmkcnuCLlo(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xNfJudx2gJNXaH6q9ir2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G5gWjJx2fZZs5m86SWRN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AkHmScx2jYR4lfhPAWEI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ak3suYx2eCDFewwnf0gG(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W13YdOx20yA22aH3lYHN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dfbQdRx2PVA4CQbMgTlk(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dSTBPJx2claoeUTokCaM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ivI62Hx28p3gylmpFb04(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z70FJAx2wShLqHlZtHdA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oq9ptvx2hKlPl6h23467(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tb3L1Ux24qAmTMaDWsby(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KhWTNmx2r48RHlvf3O2u(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tnUNf2x2DDkw0kq5rbL7()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bt0r97x2dOYVqvQmFO8M(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IaLO2Sx2CmlGFwJrhBYc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S8Iah4x2nVDK2IBA5XTD(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X7tvCRx2a7nNp8hARqdh(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Va7JnWx2HIsCWlAWtCj8(object P_0, Rectangle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iIqCRnx2s75vuiwFghZK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L8Z9rqx2lvIYIes8nPKn(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YV7WCxx2911sdLhXovM1(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sQXsqux2kdygRWcGWHfg(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vHvMWRx214hW62B4u2lN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int eqCXDSx2vKgwlB1h611Y(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fERRQ8x2S82MHv9IVGH3(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rT4Q6Mx2mjNUd7dK4aF6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jjICuFx2IFa52sy5CqvV(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nte8F1x2Xm4hbGfvF40R(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I0eZS2x2UZhrnhOmvbS4(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tWIa0Qx2OkTuu21LFlBq()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UjOZqXx25F7aRp97QwOF(object P_0, UpdateMainWinBoolType P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kBvixjx2iXQKSIgZDSop(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DGMBCYx2zV8AaD4waeit()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iKZACQxJLP8wl6EfFC8P(object P_0, bool enable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YPen66xJNieJYq9e7YxV()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kEKBK9xJYG1jraERZD4X(object P_0, bool enabled)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ymV6bAxJuxupXaHJKdrm()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QVE5nqxJyst2T9J6V0kb()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SqTUnWxJ6ErDuSvvgqRP()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XUWqENxJ2AQvTBYL50xc(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AId7uGxJJNFp9Ip5eofA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p0cwadxJMu7OSnUfCMkv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a9FhrbxJKaaW1hxsH8hH(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xGfIcAxJZHi9L6rPoBuX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SZgl0vxJoZkxNQ1M0sUC(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fiBM1LxJxufMQ5kswE3i(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bMh8FHxJAIFXxmgVZ8Ep(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i1A7saxJti5sEWOopvTl(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uyX2hIxJWVIw41fMx1P1()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fOoxEdxJBg6qCDQs383y()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KUi2ftxJqJhQK3JKpjSI(object P_0, bool enable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dOxUpkxJEm0u2AoTGfyf(object P_0, bool enable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wpBpxTxJV9k3fxwIttUd(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d7cswqxJT6LQeRJQH6eC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vrAwnAxJpJEQihtLjiJ7(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LKJmGexJQBE6AyoN4u9C(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eCii8bxJRqHlMuOj6yqJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UTxfvxxJG7yegqboF5BA(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BDH5lhxJ3xgOgZ2CxyqV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EJDnr3xJFs8R7F9irwDl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MRMNStxJ7DHjGEE1veNT(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VuHgg2xJbKXCKxLM1Dy4(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zCulWexJgthwjnhvoMXu()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mgkAR5xJfSVMhmFnqoNa(object P_0, SendEventType type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NDmKMnxJj1DqqK5HnoXT()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OJieBoxJeROHBnNtpQLR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dqvGf7xJ0SmsXmpJ3LLS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mlaXCfxJPagWhfjJlDyi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hV30LvxJcfeAB8AclY4P(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kjlt7fxJ847xuY9YEONF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WaW41MxJwcftwdEUwfju()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EamFEjxJhiXk60L5mBFv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DA9pi8xJ4fxVrvAjI2PL(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YTl4n0xJrSOisKy8dV6C(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ktm97RxJDNBQY8UhvSC3(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hRkmyRxJdB3wZZaouDXr(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void krV1oFxJC95S3oK64KMA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YVZZsmxJnrqsOFwDmwRC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IL7BWfxJa3WAbXguG59K(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lmqHIRxJHTPjTuXnFXQU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool j4x4pRxJsT4WJD8hLhQf(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UmTPw7xJlRvDL2GblWl3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object diU0OfxJ97TMBf3o976o(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UtfurVxJkXmwQes5Hwl7()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zi1MY4xJ1xfZMNTQlpeL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SZ5WUCxJvg3kNxjgb8p4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kLoUTAxJSEuqv5bpWvyL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fAlvG5xJmIY6URPSMtMP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aqlV3rxJIFlo55RmAI4P(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qj9vxrxJXcPrC3rBPb1B(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CdNPqJxJUM8wbXZfQAak()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Sqy5jdxJOE0fiyusY0uJ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WlEOdmxJ5pcG6AdgWvur(object P_0, NetType netType, int viewType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GvGJBPxJibuAlugolJwB()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zsBi4SxJzOiBQ9KkvVWK()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult jtaWqUxMLhH8NtxBppWR(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tescUOxMNKn18g4QjGFB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o22BBqxMYCxIBGmWqnPd(bool needAddFileID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zkYtknxMudv2WbnSd5I0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FVOQY9xMyLAVqCQpPCIf()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xVWZmKxM6k4mDSrE0mSg(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jesh39xM2ij3JlyvW2PR(object P_0, int idx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sTLoPUxMJVI5ojaFYAyx(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vZ0S1JxMMc432oIO7Glh(object P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Q40oqyxMKGE5MxRUyD99(bool bSucc)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jcn4w3xMZUy5OsHF4H94(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zRFxYZxMo432Ya4EpeE9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jdh4IUxMx2RnPKsC0rNF(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LxhPTbxMAPXDDMS0o5Ui()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LVfbQxxMtPPtqFWgngn0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hxX2NJxMW9R0vSF2xpSr()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HXDI4fxMBRv9c25HbGyv()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool X43tgSxMq4XbpFcDxHEy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xjuvGkxMEgOjQGxUydxX(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PNk0qTxMVmLoRqm0PyDC(object P_0, object P_1, object P_2, bool isTempLog)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BMPmjlxMT54kSa2Fl994(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GpvjTWxMp90Ok1N9horv(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ICabqFxMQpOoahGFHC6J()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Pq636ZxMRLu1Rh3ui1sS(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XQUUu5xMGSwOb8Alq0wC(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kQb6uyxM30vrrjyyhBIj(DateTime P_0, bool P_1, bool P_2, bool P_3, bool P_4)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HgTUKexMFoSkvEWLCqTt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y7mHNlxM7uhlYc7pO9Jj(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gae7RXxMbZClV7AM99WM(object P_0, bool showWaitProgress)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tA19GvxMgHHJPASZ8hpL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hmRqJIxMflLCxFNsDjdb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BvpJZnxMjnKh8e8hLaNS(object P_0, AutoDivideDictStatusENUM status)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RpVI5CxMeTDOQiQsmd7N(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hc4RRPxM0CWdhVh22I9v(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int h01yKYxMPOppqABLQJCa(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point HOudHOxMcrxd6gsADDv3(object P_0, Point P_1)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wBsFCwxM8qAN2lny7YB5(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rAQyELxMwjHDRvhPXsl0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JofQPkxMhfcMmsQNLhb4(object P_0, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hFME9pxM4lYZ7j0o2Ryi(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DFYi0XxMrjjuXPhu4hHg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hWlDuuxMDFtH1uT7dLcx(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LhXelrxMdXXOFbOAMHUV(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GqyjcgxMCKqvlwLDl2KU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vWbjO6xMnhWbmKbLrlsE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rIOmypxMa6WblT4fXBdF(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UIOabpxMHOEKB5Qfkvpi(object P_0, DragDropEffects P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xyrEP4xMseFYjw2AaDbC(object P_0, Type P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HpjYhvxMl1lJiWYTcF6E(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xLsynBxM9re7NwuL0HDl(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Tf5xDixMkXiRq74Y62ky(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CJJad9xM13J3ABPAoJmy(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lJuxKXxMvDjH5kaqyywJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y8AiF4xMSK7XLR66UOXp(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BfShTfxMmw36lUVDrrdp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IO4WufxMIuS0tHIPSqUf(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object epYkmSxMXdslsU3HyB6q(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JxD0TixMU59KK2VivoHS(object P_0, object P_1, bool needSetCfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr y9xoRQxMOTP6Zqm4aBqn(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pxKhejxM5n8qYmUWVZ1Z(IntPtr P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cb7VFUxMiIvPuoJ7oWLu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jGx52exMzCgfKAMDJvsP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void knhMlgxKLy14P7tKad7s(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WlUsbnxKNKQmWlJYLUiW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rLPE0qxKY3aTSQg1ikfU(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point GMjwEkxKu1eVBFv0FXOS(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ch9ryCxKyt0KcePtcfvC(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x5H53CxK6AoVCS4I4S5v(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SAQAphxK2SFKSI9gNVua(object P_0, bool orgValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AXOGn3xKJV6IHCHtPRTb(object P_0, FormStartPosition P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wZZ2UmxKMYUOEImYRbAa()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ULJgfJxKK4TyxfNdg834(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vb9HL8xKZ8LyQpjV1L2B(object P_0, int P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jdpVJqxKoyR4CUbqt1cE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PFTb81xKx3WbZtCe8HLZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kJ6gxjxKAG1uoJK1mmkp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w61Q6bxKttN7ak6ESYyZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF Gdb7NkxKW2WO2rvjJ9eK(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nOOGYrxKBTIYQCi0bpGI(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BSA0qrxKqDWJNPIDrbOl(object P_0, object P_1, object P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hJNchoxKEsa0O6L56Bp3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UAPdhgxKVdFjmyllFiqD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NOIyvdxKTM0M8OJCuqJE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xb9OxfxKp3Kwi5u9qhoy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GLPH3CxKQnOTUKEclqNq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Djv6T3xKRirDytEV4EV5(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yY9Vv2xKGS0pr47fG72j(IntPtr P_0, Type P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oeblp6xK3NBONAKNKknC(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DcHrt8xKF7LHF0Dm2NP4(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xQab62xK7gi8kIflSAZ4(IntPtr P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PZf2PJxKbqmrnAGNSAwF()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jTvLDOxKgLrv4NQbkhAd(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kIuht1xKfntqEuZ4OZ45(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mduRKDxKjs3M7HNXZySw(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UuHftOxKeElRrt6m5Yeb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LDVQHxxK0LBAY49WJCxm(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ixp1NOxKPwXZtMxMxHC0(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zF9mb0xKcbEALHtkaYjv(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A0ZI0vxK85ZgU70g45WS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SegJqbxKwAEIrV75ikvQ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x9qA4JxKhMO2NJpMiHoQ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rCAHUKxK4gC7XT5LQJ5O(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uM3lOexKrONA6EPqEjBY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vm8ss1xKDZojoMbh3HeD(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EkIcp4xKdrJwABVaqtFA(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YIQCLexKCMmnfRcKaKVj(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ncwZ5txKnP3yi3XRRU25(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XfGyiYxKa5p2Ukh6Rdri(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color S73h7VxKHJGu9yHGQKH8()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nBRDStxKsTBBVVV1yfwh(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mQnupuxKlylRIySkrh0Z()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PjwVaLxK9nsLwCQFK2us(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FMqFguxKk9rmWtEawVe3(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vkqy80xK1hqtaO4bLagf(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color dlMMAoxKvM2UxI18RssE()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EOZK4CxKSAAmMAsuIy5t(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nENQF1xKm7QG0bJhlvxm(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vkV72HxKIPUAWfOHxZge(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HHcD0gxKX9mYktxgT40u(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p25nDmxKUT1AGlgAdMRu(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v6Ley7xKOt78pvQNVc0U(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mh0t0exK5EAxGZ73nQ1y(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color lbsl3ZxKiHnnAYvZmcSP()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mcnAojxKzsaWKUVqT5XY(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void saQ9i5xZLwE8EdeDZtBn(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KG8iwKxZN2L1ADoIt0cP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NyDmE0xZYoDOZTVWiTS5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gFbvR8xZu7gipXhGrKS8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sEDHQnxZyAjVuNbaqJ0o(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ft8FRwxZ6ZBwbC0QWfvQ(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v4JR3exZ2WYDyQYM35Pi(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DAGS5sxZJiu4xIonuwHJ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jd1IGXxZMNaHYp6VZb4u(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eyWldmxZKKMhd31uaLfE(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HFJvivxZZ6xpYGrlVvL7(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AnNeprxZoduXkDi3Td5o(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WhDJ0exZx9OHctlQWqNG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NLb0bMxZAmYwcN2O7Smc(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UFeIkHxZtLtTynptEZ93(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dRZkx0xZWtIJU9GYVnUH(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WNsL24xZBweXXYcKcmA2(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B1S0tJxZqNqZXrmeml35(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gG8OcZxZEo4idgmeyejM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rMVEWvxZVhVrn3THsXdL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lKoJkxxZT94n4UxaTCHd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NfNpmQxZprhJBqUPjOcJ(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jbj9dExZQTeqM7GGSEik(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color EqsJ8TxZRc5sOidP2Ki9()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vD066dxZGA5qVhjAAkM4(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vZVTesxZ3G0LKRePGrnO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fiulYRxZFfqRDvMHHM0B(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CvijGAxZ7PkTyjQDgOom(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sX8EQ9xZb5ROa93pA6BC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sxIiFMxZgMpL7HrNjjsn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e43eILxZfDE5hsBSxaAy(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zbCmjXxZjDxdWB2Eqt0m(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Pt2ghlxZeFTI7Ersk5SY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XTG7LAxZ0AEe9x9F4GRq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pLQrgQxZPidAhwfoluE7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int v8YvZtxZcFtYlirE6YrS(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FZdZMQxZ8MvORn4GPoCn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bwoJlnxZwcefXg4JaTOl(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NFvaJZxZhYlTfHwwAgwi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JcP8eOxZ4KvuwG4tMWDP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vrqIxZxZr0oYGqFB2yRm(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K0fyrGxZDEiwJIHCEhUi(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MU8BMixZdXUGUIgMlXK8(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qiZucOxZCPMqEWTECuyt(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dCpd4TxZn580Y707R65m(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ASeYRyxZanE7NqpsFNtU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VdtOI8xZHOPWH1NfgC1n()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XngutWxZso3nYOhFVRIp(object P_0, ImageLayout P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gkSHwbxZlH9JwcYcMXgo(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QXQeHyxZ9bo7EYiTKwt5()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dIM8hAxZkOKch0uyHaop(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rTLGotxZ1ndkg6R2STlh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color npKMr8xZvB37eSWQrPNZ()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XkjiPtxZS2ebbf4LYQxE(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GeITBuxZmTQdSiw0pvPi()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EVWWaSxZIimHiSGXkt0t(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wWU5HAxZXRxXYE9QSu1m(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mBTU3KxZU9rmUXfnVtZh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SgwojGxZOIGqTt29gdAX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AjCxpMxZ5bNWd9mJfGE6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HQG0s6xZiDUbx7RoB9o3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XDLaypxZzBtj4XxYCh55(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LFA4f2xoL8fhMYUPC2LQ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bYOuUpxoNplMDOkmGEnA(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U28QaHxoYlgoxiQqTIhu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GFA7pfxou02f38SlFosl(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fSbC7Pxoy22rmV8YEwtB(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tiheHDxo6xaPtKtWQHkq(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fBYGTBxo2atUtEwJPLrx(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BFJeAQxoJKEDOwT2wOWu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V6VYK3xoMgQ9wwwc4yQD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UgVxvBxoKUbZ1L9hmKo8(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XeNqvXxoZee5DwTtasQ7(object P_0)
	{
		return null;
	}
}
