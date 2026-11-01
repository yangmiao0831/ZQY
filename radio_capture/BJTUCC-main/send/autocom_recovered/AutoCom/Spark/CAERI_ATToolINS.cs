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
using LibBase;
using LibCoord;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class CAERI_ATToolINS : BaseWin
{
	public static CAERI_ALLAntObj AllAntObj;

	private Timer dhigrlcXrl3;

	private int w3sgrwGLvyg;

	private Logfile FhBgrpI77QN;

	private FastObjectListView tdvgraTGJnA;

	private ForceUtils UCPgrkmtnEn;

	private int c7Ngr0xcJso;

	public static int CICategoryForce;

	public static int CICategoryAT;

	private bool QvjgrZv5cRh;

	private string PmTgrzDqAWl;

	private int XKng9CgslTK;

	private string ljEg9GPIEHT;

	public static string CmdTips;

	public static Dictionary<string, string> CmdDic;

	private Dictionary<string, Control> lJHg9RtWQP2;

	private bool mGkg9nvdTij;

	public int UECount;

	private IContainer sReg9gIOgkP;

	public FlatTabControl tcUE;

	private Panel Ae0g9epLTwT;

	private Label kSlg9Pxsvro;

	private ComboBoxEdit BnTg9EUONfQ;

	private FlatButton uxig9yWyXC7;

	private Panel jbfg9cWDQyc;

	private RichTextBox Jbmg9L0b9eM;

	private FlatButton Q1vg9vqViMn;

	protected FlatButton fbFreeze;

	private BarManager fmZg9shLCrS;

	private BarDockControl L8Kg96kt1lW;

	private BarDockControl RcNg9hlMAIH;

	private BarDockControl KyRg91wjDG3;

	private BarDockControl EQug9dPftYM;

	private PopupMenu oWvg9WMiVr5;

	private BarButtonItem VOYg940splO;

	private BarButtonItem d7lg9Ndunqk;

	private PopupMenu y7ig9iVLgxr;

	private BarButtonItem ifmg9FHYd3n;

	private BarButtonItem MiQg9b78sxt;

	private BarButtonItem LoPg9VjSxmB;

	private BarButtonItem lRWg9XOFJiu;

	private Panel Csjg92Tw2NP;

	private Panel pGUg9OdrwZI;

	private Panel Swag9MiVmjW;

	private Label pXng95imgWR;

	private TextBox bNhg9TLHh2Q;

	private TableLayoutPanel qqPg9xdFmjw;

	private FlatButton tnNg9qKMIKg;

	private TextBox oIVg9AYBHwy;

	private TextBox NJvg9YYDlkI;

	private TextBox TSRg9HI09c9;

	private TextBox TbCg93SxjAU;

	private TextBox wN0g9Jhjp7Z;

	private TextBox YeEg9rmX6ql;

	private FlatButton uehg99bwbHl;

	private TableLayoutPanel CF0g98nK8su;

	private TextBox baMg9UBTAkq;

	private TextBox L6Ig9Kl3jQ1;

	private TextBox m1Kg9tUfe4G;

	private TextBox z0Yg9u9sPsq;

	private TextBox Whug9orAeov;

	private TextBox dc3g9jBuk4S;

	private FlatButton ViIg97X3N5H;

	private TableLayoutPanel xrZg9fHjlNT;

	private TextBox FD5g9DGOiNF;

	private TextBox II3g9BRXkGt;

	private TextBox bLYg9SQaGsg;

	private TextBox S4Sg9mMALg2;

	private TextBox jFLg9IFBxZx;

	private TextBox JS8g9QISO5o;

	private FlatButton FDbg9lKFQhF;

	private TextBox PKpg9wjJdUf;

	private ComboBoxEdit CKmg9p7SQkp;

	private Label bCpg9aIcmo0;

	private Label Awcg9kgf8ub;

	private Label shcg90Nynlf;

	private Label bJtg9ZY8DM4;

	private Label IjKg9zE9v1Q;

	private Label O8Zg8CZAg93;

	private Label gm1g8G4Yb7A;

	private Label pBEg8R3Vigf;

	private Label kTLg8nUynPB;

	private Label jwlg8gYydQf;

	private Label D9Zg8eM4QKS;

	private Label ICNg8PHLsKX;

	private Label NbOg8EN3vhC;

	private Label M6ng8yqFT35;

	private Label Ao1g8cbZTEK;

	private Label hgYg8L4GnBG;

	private Label mFQg8vd8ga9;

	private Label Kpqg8s7xdYO;

	private Label dGRg86Gklax;

	private Label G3Dg8hGIBiY;

	private Label JZ9g81DbQqJ;

	private Label w1Cg8dKA3qJ;

	private Label zw0g8WlhZZr;

	private Label FH6g84XoKLT;

	private Label pADg8NlXC37;

	private Label syjg8ig0153;

	private Splitter w6pg8Ftyq07;

	private Panel jBDg8bitb5T;

	private Panel Bueg8VRkCDk;

	private Label Pmlg8XYhImF;

	private Panel xdNg82s3lZl;

	private Label UGCg8OoS4JI;

	private Panel V0Zg8MTfw27;

	private Label Cmbg85eeo8S;

	private Label hrGg8TkEv4H;

	private Label cXGg8xbrlgi;

	private Label rjfg8qqDsmk;

	private Label Simg8Ai1rdA;

	private Label u8Lg8YJST9V;

	private Panel Eq1g8HWlrUF;

	private Panel JrFg83X0wKE;

	private Label cLHg8JYyDix;

	private Panel fC3g8rSXhRh;

	private Panel hjQg89FDg1s;

	private Label UvVg88ZqgMw;

	private Panel gEyg8UKe0Zp;

	private Panel jWCg8Kse2Lf;

	private Panel q6Xg8tCMFFL;

	private Panel nllg8uUQwDF;

	private Panel p0dg8o0n3wf;

	private ComboBoxEdit CAGg8jfLUrM;

	private Panel bZ9g875j3XB;

	private Label YXLg8fvQVtG;

	private Panel cxkg8DbH2sm;

	private Panel k3mg8BH7wYL;

	private Panel nEtg8S3dAIC;

	private Panel Qmfg8m4EdRH;

	private Panel xtDg8IsG0QQ;

	private Panel DAsg8QBZ6nU;

	private FlatButton noPg8legQDk;

	private Panel axkg8wvBir6;

	private FlatButton AqDg8paZsjk;

	private FlatButton Rdpg8avIqhv;

	internal static CAERI_ATToolINS ia3DZDoR7XW34QOoYm8E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CAERI_ATToolINS()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GMRgrPwDPPx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fdEgrEiZbc7(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BbggryPLZQ6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tsogrcrgwSF(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vaMgrLvybt4()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SvZgrvcAt9K()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void buZgrsFtI4C()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EQObj gQGgr6yaASv()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RAjgrhJ23eq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DoWinActivate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void krkgr1QMufT(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fRqgrd1GMIF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LpNgrWlKZoF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void R2Egr44Fhti(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCurATPort()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VYWgrNrvXaM(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MWegri26FZv(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateATPortComboBox(bool selectDefault = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void r5kgrF6q12e(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nUkgrbsI8lo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OLogrVwomLJ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool dhpgrXp8Z7b(EQObj P_0, string P_1, bool P_2 = false, bool P_3 = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BvVgr2e2Ip0(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateIsOpenedATPort()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oWDgrO14EfF(Logfile P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zP0grM5wryV(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RMigr5T9u4s(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GqJgrT8VUmg(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ej7grxQakdt(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LVQgrqKpIxV(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XQ8grACZJYV(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ydigrYCeu3I(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vmHgrHtoTbV(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DgSgr3hcBmW(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XZTgrJ587L0(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nsigrrCh0yF(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetType(int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mtxgr9c0K0X(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hIxgr8dLfed(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hpAgrUJ3Bc9(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cpRgrK1lXGT(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Fyggrt2dieL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zBTgrui4gcI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetOutCmdRightSpace()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseOutCmd(string sCmd)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void O65groAh2wM(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LLogrjU2Dow(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void D5Sgr7J3VoS(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fcugrfE7lPS(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BkxgrDSa42A(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zkmgrBdVC0v(object P_0, TableLayoutCellPaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cKggrSr32og()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void qULgrmdsrWf(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string UDcgrIK4cPD(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void VpngrQk1CKT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CAERI_ATToolINS()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 13;
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					return;
				case 2:
					dictionary.Add(xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(420100), (string)dhlllKoRjmLEQajLAUMa(420128));
					num2 = 5;
					continue;
				case 1:
					dictionary.Add((string)dhlllKoRjmLEQajLAUMa(419976), (string)dhlllKoRjmLEQajLAUMa(420010));
					num2 = 4;
					continue;
				case 5:
					dictionary.Add(xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(420148), (string)dhlllKoRjmLEQajLAUMa(420198));
					num2 = 5;
					if (0 == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					dictionary.Add(xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(420218), (string)dhlllKoRjmLEQajLAUMa(420266));
					num2 = 10;
					continue;
				case 15:
					dictionary.Add((string)dhlllKoRjmLEQajLAUMa(419898), xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(419956));
					num2 = 1;
					if (true)
					{
						num2 = 1;
					}
					continue;
				case 8:
					CmdTips = (string)dhlllKoRjmLEQajLAUMa(419882);
					num2 = 14;
					continue;
				case 10:
					dictionary.Add((string)dhlllKoRjmLEQajLAUMa(420296), (string)dhlllKoRjmLEQajLAUMa(420336));
					num2 = 6;
					continue;
				case 3:
					break;
				case 14:
					dictionary = new Dictionary<string, string>();
					num2 = 15;
					if (false)
					{
						num2 = 11;
					}
					continue;
				case 6:
					dictionary.Add((string)dhlllKoRjmLEQajLAUMa(420358), (string)dhlllKoRjmLEQajLAUMa(420394));
					num2 = 3;
					continue;
				case 12:
					nH81FdoRf3wn2KEA0bFK();
					num2 = 0;
					if (1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					CICategoryAT = 2;
					num2 = 8;
					continue;
				default:
					CICategoryForce = 1;
					num2 = 9;
					if (false)
					{
						num2 = 1;
					}
					continue;
				case 13:
					WSiqRIo7uM9ukQ6qXwHb();
					num2 = 12;
					continue;
				case 4:
					dictionary.Add(xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(420038), (string)dhlllKoRjmLEQajLAUMa(420072));
					num2 = 2;
					continue;
				}
				break;
			}
			CmdDic = dictionary;
			num = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nH81FdoRf3wn2KEA0bFK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dhlllKoRjmLEQajLAUMa(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nsb4rVoRemvhYrJxinQM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void thqf3yoR0NTWeTKuc3Jd(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ikPE3PoRPkW7kMpMOCcu(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wgDhgGoRc0RI6FqaOfaR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EySD6soR8elRvvDkhGmo(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YIW4SZoRbOmOFZ2s18jR()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CAERI_ATToolINS bVkAhloRgBPYpWcnBhrZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BdHpPdoRwMOkt2dLUSEQ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void old0Q3oRhecMx7YKInBB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OcYrwioR4byO2440R70o(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SLlOjIoRrh3OyfeElmu9(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LCExYfoRD4cUaTCJgrlG(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R7AjTQoRd4jEsJ1ZZJGJ(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MIl2fCoRCexwbDQIwqgu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xiU1pHoRnyZNxZdcB40g(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SaJ1jHoRaRm6Rp35pj1o(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF diJcRNoRHlqJvOpJiXIN(object P_0, object P_1, object P_2)
	{
		return (SizeF)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oYhFDDoRsTLlGinYrKVN(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z94bAkoRlaGaK08c3bXR(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zh5e5koR9gP6vVPkWkVp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K0Dr2yoRkAMdLFF9aQrI(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gneft4oR1DiLFXJFwXtY(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Je5m9boRvJoMnKWkGdkH(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q6xwIioRShIFHvk5DUfr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Hjg1TjoRminHBdRfLC0m(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HSp1IfoRISMoVTvuFQOh(double P_0, sbyte P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sr3vrnoRXwfQFv98w3ty(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TNMuXNoRU4jvvJ5pLCFr(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wneDpEoRO50rRbM4bUqQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void urgYDVoR5WQy656NY5RT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ryMsyeoRiSXrtphEUmJi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aNioAYoRzFBbqVmW55gt(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wQOk6YoGL03EYNeJUBP0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object McSa33oGNroZNksTZrcS(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CHbYWuoGYH7eA8GhrAqR()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HE5NGRoGu8siCSBGdVji(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j8ikmQoGyd23ToTprJCM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason MLBtUUoG6o5s1RIYYeAE(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xGO6EToG2A7KVChBtRwY(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KPB5jBoGJq79mGkr6Aee(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lGM6WooGMXPN483LjkJt(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Kf42mcoGKgr0piv0jnqD(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nXYyhZoGZhVGVNna5FDB(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cpRgdVoGo3Cb6ZjqRxyY(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime njEORxoGxCJ3bCyJ3btl()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yc3KPEoGAcTKIBaf1uu5(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CgShByoGtFtqqeWnuTcU(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gBKFX6oGW5RZMMcQU64H(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P3v734oGBK5UimJA9vep(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o3opUpoGqHSfmBDpPo73(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NIk3jWoGEZuR6IQisBQy(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YFMtOBoGVT2McIXs0D0h(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tTJvoloGT69XCmC6lwxF(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fkIkBZoGpCp1a8ZhTrMR(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ox77hCoGQGCV4mmGp40p(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void grwAjuoGRoI7k98heW6j(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int djMGQAoGGOiINXynkTtN(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void arroHCoG3Yt1NNxtJJjp(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Be135hoGF9EH5hgN4H2b(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cEId5XoG7gNWhyNEvQkw(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hZMDSLoGbLTRKKJeoLIo(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KJJY1LoGgiuxVfelR0am(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d4uvbcoGf2F3Zck1yTXn(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q4ZKePoGj1mT2BXWMMn0(object P_0, int paramKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oAa4C2oGeWThqLlCg9sk(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KjgVK2oG0kW3C4ONkhGK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dlmx9ToGPClxqM4aWU52(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VF99u6oGcOWRmNBvOpco(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AqdgCyoG8WJfhIZHVC3h(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rDA5RToGwo4buskHWdhc(object P_0, int P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dpNQKdoGhfYmgfAlxcAw(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gkXAy4oG4mJ6BkKi3AOM(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double hVFPRyoGr1UlXgpLNjVS(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SJRWV5oGDuj2onPv3b0M(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool P0Q9tjoGdVKkdnkYuRrr(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dl5I5JoGCvnw6yyHvltS(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YVgNBXoGnenlSSfRM52q(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint QI53H4oGao2Op9yOxe1W(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Keys eEPr6noGHA5h6O719Ss2(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SgCflwoGs4yy7KJisvk5(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int N8Kx6XoGlGWuDjUFeAOZ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Gr5IJooG9glpNsBPXjUm(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j3U8LooGk9WKrrU6j7A3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mgldxgoG1CPQyEcURPeS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N1DHVuoGvSnVxfy1ROno(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WFjbbCoGSeMk30WMI4vm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void otkBWQoGmCLc2eT8k89s(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WMb4bUoGIiUy5vxyQldx(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult iCykV8oGXK0X7dE9QjGx(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uXjZVaoGUZmjcPPaMBnf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QFg7mkoGODPughPvsraG(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ciEiRyoG5rve4SRqCvCC(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NcMgfHoGiar6FC62gVYD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double RLnPCUoGzAqG7AGCJsGp(object P_0, double P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Cb4sxvo3L4O1sX72pMWg(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F4hsQEo3NYG2FU2y59oS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zMQcmGo3Y1VhPr3x44ir(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int oi9mO3o3uVbNut1yWT8I(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QHDZrko3y0pMoFN8RFiv(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object puFZilo36actTMxWl8Mo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OWoqfCo32lwWl5aEY0ri(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Padding d5u0xbo3JnKRPqkigXgb(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Padding)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lAZRNJo3MGtsG24xVOHH(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QNYNhoo3KIq0MjX2ZHN3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size cxU1ero3ZJGccxiPuSip(object P_0)
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point kx0v0Jo3oBgVdsM6v1xQ(object P_0)
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n74XGvo3xZCEnpbDpr8t(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kUVJsTo3AGduglniJDE6(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fcaGopo3t5SKT2CGr4Ak(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h0hNbdo3WPjpG38IQhXA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XdIIyio3BBeVnwiLjX85()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jSLNEAo3q6w4u2mtH5Sr()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ybTsGwo3ErgcLq8qGtYm(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yoy3oxo3VUaxF6fvuMpn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vka3QJo3TnVU1dfGIcC1(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TZfglUo3pvph6IZRTdUk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color syaCsno3QtQSPmg9Px9e(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle LILDDvo3RZcXTZkAnqhX(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lgrOdco3GGX4E8kodto8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ojbtxto33YQSn8Ep1JKS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qxMLDPo3FwpiHx7o7nUi(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UibeBDo37JSd8rHdLbTH(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void maVVlno3biSY0KU14vcu(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sxdgqVo3gQP2yajgLs0b(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HnNwjso3fa8aoDRlx6HL(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KRwv8Vo3jHRH43WDMSbC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CUfQvTo3ec0na2GH7nfx(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TYGrQlo30ovy6QjtUN1C(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VBxiSFo3PCWQoiA14Nm3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F3EP6Ao3ct5lihhkrffJ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mOVrYVo382UEXYVvQoOO(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y8ugmRo3wEVYiYD3buSX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sprm9Po3hgL9BIj27oS2(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color fDvOfco34uraaoNeh3g8()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UoGQxFo3rS7rLUTDef7u(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n4FHMjo3DfGRymETxF2w(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LcGW4ko3dHUXv3mFeuhs(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NQ6OXEo3C8nOJkka8rs3(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H2RHlCo3n0dKtEwpWWUC(object P_0, ScrollBars P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f83SMYo3aGee319xJl4a(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mby31xo3HU8JN5uL2ud7(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w4Wppbo3s7Ml1nBHf8FQ(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lL3h31o3loyXBKZATqyf(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WV6v7uo39UArbiEA9eX0(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uGWOsho3kBAfGFoyQP9V(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color IrT9Xfo31WYcy7nCkIgb()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SCKMSuo3vegKTILTEbgI(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kRaPaYo3Sni27LrAvMIQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o8HyYoo3mZ5E5CEZJt8u(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void huEapwo3IKIg5R7ryYlW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I1ap5oo3XPOrt24E8D9K(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EQ7uXAo3UwWoCtXDu37B(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void igV0eEo3O6marpP7b3GE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void reb7rwo356WLa6OaPl3v(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q5GyjXo3iXYEOCaTPnW7(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JXwqxMo3zURCYwrQmcVk(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rKrXocoFLEYBtMYPuRuY(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x02wbGoFN0IprR0Vuceb(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u5953SoFYWorgbwb6gOF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fXMwLDoFuCu4shA1p3m0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IROLOQoFy7hgR4PG3mxN(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vKEOj7oF6dGyIT69gDyy(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vxav3JoF2cyMcD6TTHb7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void htbd0loFJFoFAtosjufP(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void efHL9qoFMrOxa7umFj8Z(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nan6gJoFK1pr2goyrmBF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HkN1jGoFZ3y3rvFZHsKQ(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nk1HMPoFoqhb8spbHolA(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BYfcmjoFxoH11ERSoPGm(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WCGlEfoFAYxZPhBGj30C(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TeW6etoFtKEx7qekHLVn(object P_0, TextEditStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nt8hcCoFWHHHwkVw5k8H(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mOTFOLoFB4uSavb4JmCW(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uBCSvwoFqnO3y5wd5Ghr(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tH15PfoFEUp83wLgR9pS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vPilLuoFV7QZS4YICrBW(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WkiBOVoFTVjH7RpOWal6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D4g5y1oFpVBBNuCGebLn(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iTIM1VoFQWEu3OgDZQSJ(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TryFZsoFRnIy6Khec5pi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int D72qT8oFGV2FeAFDuZxT(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tTAwdioF3AMcxhKx3kod(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iVSJHboFFPenq98QMwht(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fNv1AEoF7mSKa8EJGjky(object P_0, HorizontalAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OAQ7OAoFbxbImDpcwDi4(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color oTO4fcoFgnpbNjfUke6A()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bCElAXoFfJHXOGIROD0A(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BFfqFHoFj02fkjYBbn4U(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e564RToFewdSdVYGjLl1(object P_0, HorzAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TpT1UUoF0sfR4AhpllPs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rQHepZoFPHZHxcNv1hkV(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v1g9NxoFcsOoJ17JxaNS(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aU4kf4oF83YtafhB1SVV()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t8BK3doFwh2Jw1C2dkWa()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YgKfgKoFhrjKPPm6liHw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xjh6VboF4NYF3rrYcygx(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mcRLMZoFrR8UdpjEDnNZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ebAmUwoFDJX3SRemv5io(object P_0, BarItemVisibility P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JWkeQOoFdxDAxOkI8yLs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a7cOKjoFCfKcHXiJOjIW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XGnm7UoFnCwU6wUL5wAr(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QvqbFNoFaaVnG2Io3dtO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xn2c8toFHUhV3SbFfK4W(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e7OoKYoFsnKUr0sJ3ks4(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xXnMwhoFloqnu60J2sZI(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uYMvQCoF9yPaapgpkZ0A(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TkgKvToFkxLqfM3SAE6x(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NvpttQoF1WdSbpflmGtq(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aIiVmMoFvH78yPxNMydE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j3sVAjoFStYFBTWD407C(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jYb4troFmTKSddUQaGXs(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color WCQN4foFIPv222e943Jk()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ossTMYoFXLOnuCXC4pp1(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vB1aRPoFUrGbqtRPx2PC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uQ6dnAoFOjiD6yiW5fD6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QYeltEoF5i2dwjtbMVgj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CoJ208oFiK1WIcwGvRYI(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nors3doFzekXP0rG1AgR(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nPAH7Lo7L5mQcFfsBoQG(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rx9X7fo7NGoMo5rh1RNE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NDLfJEo7Y7TuZ1JUxEaO(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WSiqRIo7uM9ukQ6qXwHb()
	{
	}
}
