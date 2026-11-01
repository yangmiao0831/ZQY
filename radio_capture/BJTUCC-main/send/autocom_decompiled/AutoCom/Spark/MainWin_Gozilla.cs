using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LibBase;
using LibCoord;
using LibCoord.ReportForms;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class MainWin_Gozilla : BaseMainWin
{
	private delegate void gs7knK9thQsE8LT091Z(Logfile value, int eqIdx);

	private delegate void QVLvGN9sn3KQUuFmWgL(UpdateMainWinBoolType type, bool bValue);

	public DefaultLookAndFeel defaultLookAndFeel1;

	private Timer Sv7ee3dEFVS;

	private Timer wKoeeJpcF2g;

	public WinLocationAdmin winLocationAdmin;

	public TaskConfig taskConfig;

	public OpenView openView;

	public ForceConfig forceConfigNetWork;

	public ForceConfig forceConfigAT;

	public ProcessConfig processConfig;

	public GlobalDataQueryWin globalDataQueryWin;

	public MergeDivideConfig mergeDivideConfig;

	public HighSpeedRailRepair highSpeedRailRepair;

	public ReportWin reportWin;

	public ReportNewWin reportNewWin;

	public FileSynWin fileSynWin;

	private Timer omveerdAHRf;

	private ulong GVTee9CdtKi;

	private bool Ea9ee8mQfNC;

	private bool PDmeeUH0qie;

	public Logfile PreCaptionLogfile;

	private string m3xeeKLjIt1;

	private BackgroundWorker YkReet7kTMw;

	private int QlLeeuiG2Tn;

	private int tvxeeoPyE4i;

	private IContainer tF6eejGRxxs;

	protected FlatButton fbMin;

	private Panel Adwee7hMXyb;

	private Label veSeefySJfv;

	private Panel aapeeDEsw61;

	private Timer oBUeeBmaOmq;

	private PopupMenu wr0eeSeLHIC;

	private BarManager FFgeemupj8m;

	private BarDockControl f4TeeIkFFln;

	private BarDockControl MDXeeQMGWYw;

	private BarDockControl jHIeel0tAql;

	private BarDockControl eyjeewVgFOg;

	private BarButtonItem XvheepnSUkO;

	private BarButtonItem BTReeanDeOY;

	private BarButtonItem sbseekDNfRA;

	private BarButtonItem UvNee0wTCAY;

	private BarButtonItem EgLeeZqnVHu;

	private BarButtonItem i5GeezYoKcm;

	private PopupMenu gvPePCPyfoo;

	private BarButtonItem CAZePGp0WHh;

	protected FlatButton fbScreenShot;

	private BarButtonItem jNRePRlPrdV;

	private BarButtonItem u7QePnxNsNT;

	private BarButtonItem MJ5ePgXaOWk;

	private BarButtonItem zXOePeJ3glM;

	private PopupMenu gnGePPYddid;

	private BarButtonItem s4eePEgy1Ja;

	private BarButtonItem gKBePyP5O3x;

	private BarSubItem lHvePciGIpB;

	private BarButtonItem FiOePLsfMPO;

	public FlatTabControlWithAdd tcSheet;

	private BarButtonItem X7yePvhMBVs;

	private BarButtonItem YaKePs3K55t;

	private BarButtonItem uACeP6YSkjF;

	private BarButtonItem HGnePhahgpp;

	private BarButtonItem hxaeP1uN1jS;

	private BarButtonItem gHbePd4VYwc;

	private BarButtonItem wIxePWvS3sG;

	private BarButtonItem ylMeP4SG9j1;

	private BarButtonItem e0eePNccJnS;

	private BarSubItem KW2ePi5SjXj;

	private BarCheckItem ccBePFKvtwi;

	private BarCheckItem q0VePb54qe4;

	private BarButtonItem kUgePV0Bj8A;

	private BarButtonItem SqKePXjFQoj;

	private Panel hEmeP2gUlrG;

	protected FlatButton fbMenuFile;

	protected FlatButton fbMenuReplay;

	protected FlatButton fbMenuReport;

	protected FlatButton fbMenuTool;

	protected FlatButton fbMenuAnalysis;

	private BarButtonItem UWCePOFyw4D;

	private BarButtonItem Cq6ePMmInJe;

	private BarButtonItem N5yeP53jiNG;

	private BarButtonItem cYrePTk0FV7;

	protected FlatButton fbGlobalSearch;

	private Panel eNEePx7djiA;

	public Panel pnlLogo;

	private Panel RRWePqHVn3U;

	private Panel r07ePAWgwrP;

	protected FlatButton fbScreenShot2;

	protected FlatButton fbGlobalSearch2;

	private Panel zwJePY9n16a;

	public FlatButton fbForceAT;

	public FlatButton fbForceNetwork;

	private Label wCbePHQkGkm;

	private ComboBoxEdit ANTeP3p0XTa;

	private Panel v5tePJjWmmD;

	private Label IwLePriZWrw;

	public FlatButton fbSceneSaveAs;

	public FlatButton fbSceneSave;

	public ComboBoxEdit cbeScene;

	public FlatButton fbViewAnalysis;

	public FlatButton fbViewParam;

	private Panel cHYeP9q69oI;

	private Panel h3keP82Jg5c;

	public FlatButton fbFreeze;

	private Panel FT2ePU7FqJe;

	private Panel x7BePKsq4J7;

	private Panel kS1ePtBeMCR;

	public FlatButton fbLineChart;

	private FlatButton ARLePuvksHk;

	private FlatButton n4oePopX3mP;

	private FlatButton uwfePj4vn3r;

	public FlatButton fbEQConfig;

	public FlatButton fbConnect;

	public FlatButton fbLogging;

	public FlatButton fbTaskConfig;

	public FlatButton fbTest;

	private PopupMenu ahAeP7lreUY;

	private PopupMenu AHVePfNrKGi;

	private PopupMenu XLVePD3ofD1;

	private BarButtonItem dy1ePB8JQDd;

	private BarButtonItem D7sePS4qSZ1;

	private BarButtonItem sqeePmIYswY;

	private BarButtonItem lkvePImDK0K;

	private BarButtonItem ErKePQvfKpO;

	private BarButtonItem NniePlvWunc;

	private BarButtonItem mQ2ePwiOeXw;

	private BarButtonItem HJwePpwxqhQ;

	private BarButtonItem FZ7ePaybSH9;

	private BarSubItem NKgePkKtxHr;

	private BarSubItem sHheP0k9aRh;

	private Panel UXUePZg400B;

	public FlatButton fbStatParam;

	private FlatButton nxPePz6lGq6;

	private Panel dMOeECmDWW9;

	private BarButtonItem mfZeEG0sGFT;

	private BarButtonItem SS8eERn6W1I;

	private BarButtonItem TxZeEnXpoXn;

	private BarButtonItem cyFeEgKbobi;

	private BarButtonItem MHUeEemjQNI;

	private BarButtonItem z0YeEPNfpMT;

	private BarButtonItem pPQeEE0ya2O;

	private BarButtonItem jYXeEyLy8vp;

	private BarButtonItem VJLeEc5eWay;

	private BarButtonItem gwVeELhIsSY;

	private BarButtonItem FpIeEv9SvTf;

	private BarButtonItem FBCeEsoDA8w;

	private BarButtonItem OcLeE6nKPvI;

	private BarButtonItem pn4eEhirSGX;

	private BarButtonItem FrReE1tAuo4;

	private BarButtonItem fyveEdO7DXx;

	private BarButtonItem C1KeEWJMnjS;

	private BarButtonItem b7reE4FELlh;

	private BarButtonItem QWNeENTiVVB;

	private BarButtonItem tlDeEiKthqu;

	private BarButtonItem BIpeEFn0L2m;

	private BarButtonItem bDueEb4RyOO;

	private BarButtonItem U1weEV6uAS9;

	private Label pi9eEXJa8Dn;

	private BarButtonItem DQqeE2Tucul;

	private BarButtonItem hEAeEOrBWIo;

	private BarButtonItem sSreEMR5y3Z;

	internal static MainWin_Gozilla CfGauVxV10pcaOyoqgqc;

	protected override CreateParams CreateParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cHnentxjM2f()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lSnenu1kf0H()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainWin_Gozilla()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wAGenoofSYG(ComboBox P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CTHenjLVU5y(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VYpen7MFBwb()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void adEenfd647K()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TsPenDnvrdJ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dfJenBqRbQr(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tpvenSfEgRx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iRAenmo88MY()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yGBenIV4Uje()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XGJenQTAWbo(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HTCenlDmRr5(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jFUenw394Wx(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EwBenpr4a0q()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hAvenauaQcn(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QeSenkbiWLG(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClosed(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cNCen0Ew3Mk(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void h6DenZiYdqe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sAWenzNjei7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UMGegC8yIIk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pTLegGi2EYU()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cN5egR19QuU()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nXnegnGFiPG()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mBveggdnops()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveProject(string sFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenProject(string sFile, bool showTip = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cIaegeYokUY()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void N5IegPIKZ01()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sAqegEc8cAH(string P_0 = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void D8Kegya54Ud(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResize(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ftxegceovE7(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MvregLMucUn(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kWgegvxiwTN(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void U62egsYqBBa(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fk3eg6V5RdJ(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oRQeghJrSl8(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMaxClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool XrTeg1O6VGj(Logfile P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JZmegdgoWqF(Logfile P_0, int P_1)
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
	private void B3CegWnXDdC(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lyVeg4pZSJc(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eNhegN7Zf1x(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YFbegiXwoaM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gP4egFMgkIp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void W76egbXBwO6(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pe9egVoVTUU(UpdateMainWinBoolType P_0, bool P_1)
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
	private void BZJegXHAfee(Message P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rV9eg2ek3Wy(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mnnegORQgKq(object P_0, RunWorkerCompletedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void opaegMVlIpt(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbConnect_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbView_Click(NetType netType, int viewType, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zJUeg5fYH2B(bool P_0 = false)
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
	private void dpdegTKB7AW(bool P_0)
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
	public void fbForceNetwork_Click(object sender, EventArgs e, int x, int y, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbForceAT_Click(object sender, EventArgs e, int x, int y, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void go0egxcUh9t(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFreezeBtn()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void b23egqndiCx(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vkFegAJjYVk(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Li8egYyZpw9(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iq7egH1RQ6v(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void fbExport_MouseUp(int x, int y, int exportType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Dd3eg3ZxfR5(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void f0XegJSEikC(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vDuegrHv8yu(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nOSeg9nEfGg(object P_0, DragEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void A9qeg8VSvMG(object P_0, DragEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DBbegU2UlPs(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void w0cegKqXLnk(object P_0, ItemClickEventArgs P_1)
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
	private void Cg8egtDOQu5(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YfRegulXo9y(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DPaegoix81M()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void H2ZegjnFqHF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AVgeg70wPD5(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void otregf5MGfa(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CG5egDMXXdy(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yNIegBMT90Q(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void bbiHighSpeedRailRepair_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pylegSjvOqX(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YjCegmWSL9Q(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HfXegI09Eh6(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BNJegQR89lE(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PLEeglfntMo(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void g4xegwT5MXt(object P_0, EventArgs P_1)
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
	public void bbiOpenProject_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XnSegprwFRt(FlatButton P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SipegaqV0ND(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Qm2egk8sIOq(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void abKeg0nPJDN(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zwXegZU5Ar9(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void i9UegzO4Jb6(object P_0, MouseEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void i5keeC0dE17(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void l7peeGXx2cU(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IMHeeRKZ1aI(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void X2Ueenm1uk1(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KfGeegvJplS(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tyGeeePwFsm(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void o8ZeePLBFHl(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TPJeeEnqgHG(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EJYeeyPpATs(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void knteec9DnmO(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TKKeeLGU8x8(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ipMeev7Fbeb(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bdNees79DDP(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vI1ee6joZGt(object P_0, CancelEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nE6eehD5L20(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TGMee1UIUPN(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CIBeedeKlav(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void c7jeeWMcBem(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dNPee4WeNi4(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JqTeeNOcjYH(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void C7weeiNKWt4(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AQNeeFioVbU(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eCUeebKUqdC(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tFmeeVU9Kwu(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xFieeXraoSy(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MjLee2Vk4Cq(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ONqeeOMTjou(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateRedecodeInfo(int iLeft)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HkveeMCgxnP(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ke1ee5sWs4i(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AZEeeTKnioD(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoAutoTestCmd(AutoTestCmdEnum cmdEnum, int? eqIndex = null, AutoTestCmd cmd = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DoAutoTest_StartStopTest(AutoTestCmdEnum cmdEnum, int? eqIndex = null, AutoTestCmd cmd = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void noAeexxmOY6(EQObj P_0, List<string> P_1)
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
	private void ALJeeq0x0lZ()
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
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ru4eeA2Sf6p()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void fS5eeY2VGXB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void PYyeeHdZ7f8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MainWin_Gozilla()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		FqQmyvxFJ71OC5fZ3osu();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color e2HUNKxVmZIjL52FZl62(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ldIM63xVIDfopDXFB3UU()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color iejeC6xVXRu7DtP4k6qq()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iW5arWxVv1kNHQcwPTsC()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MainWin_Gozilla UhhHnUxVS11tZVttn76S()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i8BR2RxVUlGffO8SDsAt()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uH3UnnxVOjT743s7X7F2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u5qdGJxV5kpPiLaZ1RKS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gKmiT6xVi834mOGlwX9G(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FFqSrKxVznLNSlNY0B1k(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zkMTuVxTLhP1LXqNDF37()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hVKokYxTN2otRWc6NLrG(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RNDP9rxTYetBDNw3MD5t()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C8nPQtxTujy8vS1dVeNP(object P_0, Rectangle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yugdjKxTysDmFwVdwX9R()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NJwnfYxT6u64VgmFlvkX(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FVqYpuxT2ba105r4V1sp(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EUAdINxTJUEElPmRXrqP()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y0R5MxxTMSb8j45gUIOH()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle OQXxZ5xTK79ixAhYRqmG(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tg0RSPxTZ3UoytCI2iY4(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RCaQFkxTodwwu72vCkGW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D7rkdqxTxJtbleh3v4D9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zgcLycxTAHe2QZegWdi8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qVnoXgxTtobeNAp522en(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JFVRscxTWqT91pgRKkcA()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K6BVWJxTBXNLMe9Z01F2(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ucaNjpxTqF2vjO38VTIN(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UmHh3qxTEyfQLgyRbf3n(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Wgfq7HxTVmA97Oqxp9yt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hfZWU5xTTPBNA0SiAp8p(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UhCN37xTpKdqR6tmkA6T(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NtScZZxTQthmMcjE6XnG()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Deg1a1xTR39Z9x1rcfUJ(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Nst937xTGpNxKRA4RRhO()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ewFJTExT3AuBKrhLCggI(object P_0, int P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DE6vd1xTFvrQsl3b1OMn(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yxQQikxT7LwJW6vX5ZXj(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult HloijoxTbXCoTJe23qEs(object P_0, MessageBoxButtons btns)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lNQFfSxTgxjD3DHuhn85(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l7ovojxTfS98MdYlq75y(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ahEkb7xTj21PSqoum7Qo(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yax3RIxTeVCSnIqZx3kB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o5SOxaxT0hSwWiwnopua(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aCxotFxTPlmuXexKPnMb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vO6O48xTcWTLm31P0o9D(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LLNLKLxT8q3POaUsYHxY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yto5cTxTwSqMtl4thSaY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XZtfKkxThN9BdOlGQZUo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fBuGsNxT4cqT22Ey6Lwm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object grZc3kxTrMH542eJwRwP(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P79W8gxTD7OCQ4X8VMC2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VgVUofxTdGJKANlwVhep(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bw4Mg9xTC0kFOAcdp7rE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oCkbLrxTnr8Woxc3TkJk(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x0uAUJxTa60DITAfew29(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LcNg0RxTHO4EWEEFgK6J(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bf04lXxTsZSWbXWDf3Ly(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rkt3QCxTlYw95hfVfQ8Q(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vw5q37xT9uyyN3lmgALC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pE6K20xTkR5ok5ZNikv0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FmbDRbxT12tDjQI00U3c(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H0gt7ZxTvPgNcTNUdmy8(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ycxHwExTSVFcWEYSoAwV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ctDb3IxTmeqyMCWWLxtQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void omxBRexTILQMZjQNnIpV(object P_0, int selectedIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MHhiXDxTXoBrJxaFBOIN(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FXp2exxTU9Iox3Ak8RbD(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kDg1CIxTOVOQmfuEudaP(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PNlCobxT5Be9lIopINjp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hpjS8RxTiaTk56D0sEZZ(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C2xrYIxTzxDRHlVcd048(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U6tteOxpL4BocbtFIseS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bndLRPxpNKUa84lxUtFX(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g1sJnFxpYbTydVWfJwyI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ypioOvxpuAY7KdAdV0YC(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int V19qBQxpytFrfkaAVd4w(bool P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uA0Ndlxp6aFF2bWYRa9k(bool P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gQ5dGKxp2qL0YkpvD9p6(bool P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int W0r1dExpJ0OlEjelHHnC(bool P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BTwo0XxpMeKb8NU1v8eE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q26HTrxpKCjcwpYJZg3t(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult IZGTALxpZVWFETpHeC7R(object P_0, object P_1, object P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QxQi4HxpohmLRTDUfXep(ulong P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jQCS2sxpx5bxcj6CqYgN(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime S394ikxpARsxnYhndOYb()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S7Yoy8xptcSfTNEHGMPP()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MuybD1xpWHh2WroqMnXg(object P_0, UpdateMainWinBoolType P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lY1sCVxpBSdkxgxmlE6U(DateTime P_0, DateTime P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult KeHWtbxpq6nbtuXhqGVK(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JuCHtUxpElG3kD6wOFEZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NgDY6txpVw0bqZS2qsCn(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sRD9E6xpT1tbBTLKJ46P(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k35E2dxppP8Si5U1qonO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iYcnIDxpQoTsUUqlb4As(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pMTGxuxpR1NDwmpDPcSb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uHbllXxpGeAvsZXVe03l(object P_0, FormWindowState P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SKj4D2xp36r8TxnbV7FC(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PPc4NMxpFVI6jceUT5O7()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aDhqQhxp7yeno1AtJ76q()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hgFdEqxpbAqNBayw93WU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S26UvMxpgQJIvOcXV1d0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zc7y0NxpfaEwZuttQhhd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J9ZZV5xpjfZjFtCuLFiA()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a4fjOtxpeio7Mt4Wxl8x(WebServerOperateType P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void srQufuxp0JL9tnNP4vgO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void avMevoxpPm3NlGy6G9Zk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JOm6gQxpcVhnWv2D8hQ7(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kdw0BFxp8AR8hyCUtLyd(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IL3ZKfxpw25NT1UPeLRR()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U53x75xpholkmVNRsRDg(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f4ylBbxp47iIZdhcBO77(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uF7LLNxpr9mqCfJQot1g(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Eoy4f2xpDZk3Rmnv9By0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k2w6HExpdlVIAQOhs3bQ(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UfV2j4xpCZAttpPxS1xq()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vaXgCfxpnk44toi5nbi8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MROdNRxpaVDrl007YtnU(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YZJQHbxpHpGlIZOZkNbW(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr dXQ8vMxps3pwx5Qlygjm(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DJfK5bxpldevOj37Zhj5(object P_0, bool isOpenProject)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BOadIlxp9Kxo7kG9VKEf(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t03a0ExpkEiC0Fh05DwE(object P_0, object P_1, int P_2, object P_3, bool P_4, bool P_5)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void INIo6exp1Mynfm1fkPb9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int N3ZjL4xpvBNxmbtuy0Ns(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bZKPMqxpSHBngtlmVEFY(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DGh0oQxpmUBSySBt5419(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qmOxxExpIchYBi9P9mv9(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dvn7kNxpXsy0bn8CaSe3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hmve9PxpUOYkMC7rmhvL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eNaZB2xpOfpbsQcQHvoy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bpAbTFxp57HHivehVQ8i(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B70UITxpiCUy2XrG8upx(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool t11RWxxpze0hnwFHsqCF(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ILJ74DxQL6LxNNbVcv59()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YOncaWxQNpZo1g6PoKGb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gXLabjxQYuBheM6djF4H(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jEcL1QxQuMB03EQLtEDP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FormWindowState XGrGxXxQyqfrCxsOR1fK(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (FormWindowState)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KO0Zi9xQ64BVOMGkM5Hp(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dLhMyHxQ2qrVLCkAZQtw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dhc2GwxQJDsvMbgC52n0(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yxqja6xQMd2KGpr2p4JV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ubtLXqxQKWcfhQnesuuX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t55uatxQZfWsihQ7g0ln(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qPoAwexQovCeRpr4HrLd(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OHKwdqxQxXOCWRwQy1NC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aeWMr6xQAa9rb3cZlsXi(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ayxuhhxQt29vqA13mkfm(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oaCn4NxQWedwiI9TYw9B(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Skl78WxQBj4O1xC0YKDr(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b4qhWUxQqigdofNqIwHp(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MQ8y4txQEcRJ9ECna3wM(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I1F8ysxQVZPGHqpIdU29(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LHexxXxQTa8VXCU7ldNk()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KsUEAhxQp4lob6y7fdKS(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NMkfPmxQQQZs5kJ2pSDO(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nBPSDcxQRVx2lGCwLyUl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tiWOBgxQGanyNYTGJJDi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WflH4JxQ3Rvpk5O8GMGK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D5opuQxQF91l3w2Gahy2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O8j3YoxQ7YUe4LQUWbe6(object P_0, int P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RCUiDCxQbLhfXWXdMgN7(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AQMJOVxQgeWip7WY4Ssf(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rnDqZVxQfjFNGZ9UKgVk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iMLetqxQjqZd9pXvkRfs(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xSsrvoxQeHbFNiBZTYEw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PdN8BSxQ0XHJefIkIt44(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ztqPgkxQPGDh07Gkxytj(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mbd9QExQcXZPZ8JUgjZc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f4obXaxQ88rSoa7n7gu5(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BjhRQMxQwZAmQZoSPT4O()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DnUr80xQhtJy0ar0SBtx()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UrgDnCxQ4WfDu4ZieLiS()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XbjqwaxQrPLL7uBZ7rcE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void er86h3xQDv9sGMe9eX2S(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WvBe8lxQdtO87xR0uY9e(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PQWbvtxQCrHKSMfVQLL3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YHYZSGxQnWmP5GfwHaND(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w4MxMlxQaiO6OcMVAVUh(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VGnHU3xQHH5qL1qxZZQR(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JG5R81xQsgfUCmtvlXoc(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iaOiaVxQlO55xBiM4ORG(object P_0, bool enable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nptWHNxQ9YG4bybx5Pp6(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DHfojSxQk8RKZcGB7Ef6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u2hassxQ1uAv1VlHiTko(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cWK1VHxQv5aGfm11UYCP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yhrbjGxQSyBIm8GbkWMi(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WDStLXxQmGAIDslgZhEf(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SpHEy2xQII5xwVH17RYP(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point ic3k9hxQXpaply9uAeqF(object P_0, Point P_1)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wBpnFHxQULg1xPGRRskB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uVXa7axQOCMYJUiTYcCc(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle U4MlPuxQ5aY9pwjl04m6(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xiLN5oxQiUUMColErnq7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void seEGmAxQz1KGPbkuEbsW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qhr1wtxRLVGQiBhbq92w(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wPs88RxRNsrQFuO0OfHG(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h02RFWxRYZOUnejlWhU8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fmdThQxRuMTt5Isi1Avv(object P_0, bool isGPS)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xs1fU9xRysBQM7RKTTUt(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qm1vvWxR6qQtUiTYl3dX(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ybUg3yxR2Z7k2jaxM7BP(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nalKEBxRJNeKQMHMG1ZY(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mBC5DPxRMLeZVMwGwp7u(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P931AoxRKO2K6XU0hbWH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TiokCUxRZKwPCnYJarOP(object P_0, bool enabled)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MCyXY9xRo4Uv8Some8uQ(object P_0, bool bConnected)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NwaLTHxRxrkA75YnP6CP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IEHLZvxRAWfEGYWNPq6L(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B4sbEZxRt1UVqQ4e5AU2(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vd9h6nxRWP5DuoxHwMmN()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vRQ9TcxRBg3a0hX0yFVQ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N9Lv2ixRqYPDQ416NBy3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P3djHkxRECcMtNaaQBmH(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AppHNuxRVt9128ZLYTwJ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SjvNNaxRTsKiviSmWEUN(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bjMZmLxRpCajfFkEUp7H(object P_0, NetType netType, int viewType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ueU7IAxRQtiyaDiTfiuM(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ribHAJxRRNVvbeLItXfF(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x07en3xRGkH932qbsZ7y(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D3pO69xR3r7YDaexqh7f()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult JKCeJKxRFmGpUJ6x2WR3(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jo9pkAxR7E0yrTiY9hH1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RaTNuaxRb8ZuFY8PMFsG(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jRnTeuxRgfYXGybUWrW8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QRI41HxRfDeu4rZjT2Hl(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gq8P3CxRjsv3459oBphO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w4IfE6xRehGrXcC7SpHp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ogjA8QxR0l5UVoXiU4Bw(bool needAddFileID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b5NbJYxRPEaU2Va8XsLh(object P_0, AutoDivideDictStatusENUM status)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eeL73AxRcxtBvml9P9B5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lBTZ42xR8msvvu7gSbVl(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k3vwhoxRwUe8OHtUaAgn(object P_0, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool atjukrxRhG8AaKthZgAo(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rMfOwNxR4OtwrduCYksG(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K7PmdPxRrrWGGxeALTTr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PT5wrXxRDs9Tqbda5b34(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KOaGdQxRd12jQVpotBTP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uG2FrdxRCAmacOA25ds7(object P_0, DragDropEffects P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type PbdHtfxRnnaW6okvKc5S(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sZ7c5kxRaPpaNsIToCVn(object P_0, Type P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XXjBXbxRHL2qUnKxM71b(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X7hO1MxRstnSZtH2iD9j(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EZCyiUxRlhsxJukE3sW7(object P_0, ProcessConfigType processType, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HJGQuixR9JheVGFghbF3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yf8N1nxRk2WYPkBPLX6n(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FcOmcMxR19UTYhL3wGbM(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void miEVMMxRvRxfv0mukObi(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sTXphFxRSQ3Y31QeasAL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JXUUD4xRmc7aIDxNmK6c(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a9p8XHxRIUjB8H51QFHB(object P_0, object P_1, bool needSetCfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr MUD2CYxRX6241uZ5wuoD(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kJR5UHxRUM7lR2iaPoPk(IntPtr P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EVMNRpxROHW0twmTmafH(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ugOsZ7xR5Byo561SOMoi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w1cjQvxRiowydUEo70pX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tgP8gVxRzgwJvovtw21a(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vm22e3xGL1XyR591W7aw(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Cu9hrUxGN30ZVqrPwr5D(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point wGyEC3xGYm2ACqOALY4v(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point kmUsZTxGuwanQyMinOqV(object P_0, Point P_1)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K1fpy7xGyIcCDeAQayla(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yCmlZUxG6QV4aPhlJZxm(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IerfGaxG2PVnimvsLtm3(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eFLSFbxGJOVwMNQrhOqc(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nb5hkKxGMiKSnsIpdl6T(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O3NrN1xGKsfSeDRtk8Dw(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c4ucmoxGZdcheoFiNXQU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q6uF7oxGou9HlZ8UGmmI(object P_0, StaticticsType type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eQNNnhxGxxvu8CFmo4qV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int H5kjkQxGAICQWNGY6cKU(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UOy5MexGtXqx1LB8U5XN(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O0F0DxxGW49h5KjGIYRx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LTviIyxGBiTUNvy3hPlP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jY2esdxGqQQre9agGsPm()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qWN54FxGEChGl0G1Zeqy(bool bSucc)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nN4o8VxGVUAqohVhwbwk(object P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d4OaNixGTZqnVK9VkntY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RryYu6xGpkNxZ1RagbvS(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dqdGmWxGQGE5ShEyZULv(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kq7oIvxGRDK96uEeUQPN(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mNKxt5xGGHKludrLpHNg(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zm8nxmxG3vtbsTvuOx7f(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HuUayqxGFuBKvo7tyKZD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LPn6slxG7QlhEX3Dhnnt(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AEG9j7xGbGsph935XKAp(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H6yPx3xGgUqFgSH3gCpA(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zIHjswxGfgRGBsKxsqus(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JLGtRmxGjZhPluNKflIU()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ndksE6xGed6KJOhfFiJW(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DnJjBexG0WOS5oNqfsvn(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void coKtbExGPtt1YAlu66Qp(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sHQ0KExGc0AHkZe0mrP1(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color i0pBp2xG8qBkSou9RhQa()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hBrkIlxGwAyhsTomTPV2(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sTW2AVxGhfTdIlxuBMva(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CxQDvFxG48oyw8tXmq8S()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void crKjOsxGrP5iTrQG156r(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l8yE1nxGDln4Bo22ysFp(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JTB202xGdBd0ltc0W2CA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k490lSxGCgkJQd79XlLr(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color CxraWQxGnoJ41IMgQFxi()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lBE7d2xGau62ukv0rHLH(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sIUOI0xGHZ2h2L4a2XAP(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TQc4d6xGsumEpKLEujQh(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YaCR54xGllwap8ICgfpb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y5niFUxG9Rit3eXwnN9Y(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NHfIEsxGk5EQP8NAJjCh(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aiPfE6xG1S9ZEJnlPjNy(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QHeSofxGvcUKL4tCLpKc(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hrjQPPxGS4URahCRTKlR(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lJvhMyxGmthi8WWTbFm9(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pWI325xGINv1rqOhgpCe(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fQ5XhGxGXkFAOKMQths7(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hgHxWtxGUIDVkaaYENqD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void whNIiyxGOBQwlHme98Xq(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xIKMqPxG5QEOCWmEYa1A(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IDiCnxxGiiiSbo5327cg()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TlDn3hxGzIiRlSdw5gYs(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fBOKOOx3LpJrwU1O3TAD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IEL3f8x3Nxd3k1BLmIjv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JEyH9Jx3YrZ6N630RwsK(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dphBB0x3uh8UUHiCYIZB()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iyprsNx3yd4CySLaC90D()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NdlGkax36nTJWel4CD06(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d97LNpx32YjZcTvFU9ww(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n8OJIOx3JxRt4TkupXeB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ruCnRPx3MOZ5imNd3ZCc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ODbGdPx3KWYAemKwcc6Z(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dfwb5vx3Zkcn6XqdEPi1(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xKa20Jx3ogXrK0IvFm6M(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mSD56jx3xRmkvfdJLYJ3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YIIRngx3AfcrVZwM86f2(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tRfkPfx3tRqETEd8Rjbn(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LeI2qlx3WQNFEnnunGhg()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RXaGMqx3BfOU6N74hLPr(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kP2kVLx3qEt0Xev00FHN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YDHYXsx3EFbDKhvfgyrl(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oqxDypx3VqQsxj9gWMIh(object P_0, TextEditStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t3n7BGx3TH63gBt8uByt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vKVwN5x3pP6ugOljCkjw()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w4qWXDx3QSD8e3MOdh7g()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jL7tGcx3RZcL0JJK5hyZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RLih2Kx3Gm49JLE0ptBO()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ShbyoPx33vg5Y5S9HS1C()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ahLeZtx3F20VfarqwWkl(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EGu54Bx37X6TlwR3TgMZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NlbQL3x3bA2qoN99MmpV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fOQMPZx3gn5P5y5Q4ppn(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w9iuA0x3ftrAcAXbaRlq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PYbZMCx3j4f4esdmcmok(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CrNYlux3eujCrkjjFuSM(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ynivwkx305lSieCZJLNA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C1H6COx3PZQVcebx91cw(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color KUyu2mx3csjcgALrMJpZ()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bG4Ewvx38GAgnm7rGlta(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LhueZRx3wGEwvwlcQVKd(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jjo0sCx3h6hiI2171AaU(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fd1CXdx34Qb1SFub2HWV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IHNoAux3rJbvWCTegfAR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WdoUN5x3DRs8CIRCOSPT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int W148WKx3dgyxYxwvsxSA(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wVqNTGx3CXpZkDCsQnl1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pujeEux3nUr8XnlDknl8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PJ3utPx3asYSrjobg139(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sa0hmbx3HC5uc51xtoby(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M4omUPx3sUaUjulhbETF(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QXEl5Px3l2A5bUCayjDn(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zNOjmXx39xNhEnRiF96G(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WqL3irx3khkhi2apg42C(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IJuC6ax31GFPVImBlrlC(object P_0, ImageLayout P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DSKvmpx3vT29OaeNeUnC(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YV65d6x3SO2QgufRkdLd()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tpPSjcx3m2IP5MAYan0w()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iYwj9kx3IOFUKVCQ0hkv(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bGOcaDx3X51dr2HPOnsY(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LQjDCDx3UoYOrqJxVDrn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ANkpF3x3OIBDCn7jE7R4(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OxUpXmx35E9B2fEGonyC(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zp9ON0x3iONfZftRjHbQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yq9gHDx3zYNHRAt0YGek(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jc0AOBxFL04huMfhEOFE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CCBwUBxFNkI5ICeHD7MG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OYq5qjxFYtFGT2StwV9e(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SxGbMexFuSdy4QyOjDhY(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tmQPCqxFy0StvGYrAcIu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pHw2xhxF6qUyeGGfSy4V(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p4K7qJxF2pDJHhqjiCv7(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FqQmyvxFJ71OC5fZ3osu()
	{
	}
}
