using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Aspose.Words;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LibBase;
using LibUtils;
using ls8teBxumHLRTdAu6YT;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord.ReportForms;

public class ReportWin : BaseWin
{
	public delegate void UpdateUIHandle(RPTObject rptObj);

	public delegate void UpdateReportItemHandle(string rptFile);

	public delegate void UpdateReportHandle(ComboBox cbReport);

	[CompilerGenerated]
	private sealed class tIiZqJx5ZZ9GetKwvhb
	{
		public int WemP0bjg90d;

		public int h4LP0Vad6Rh;

		private static tIiZqJx5ZZ9GetKwvhb a7BJuZqtbxhOX662Jqgv;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public tIiZqJx5ZZ9GetKwvhb()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool xEFP0iFxHtm(DeviceInfo a)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool w3fP0FCS2VI(PortInfo a)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static tIiZqJx5ZZ9GetKwvhb()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void G0GcK2qtjfnEVH9XXNQM()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TXoEHWqtgaLahIs9BgnO()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static tIiZqJx5ZZ9GetKwvhb UmoJxNqtf2qAGDgDiwek()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class nbljS0xjTFrgZqSQ1sJ
	{
		public string FCeP02JTp4J;

		private static nbljS0xjTFrgZqSQ1sJ jQqhULqteFeppT8mikgC;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public nbljS0xjTFrgZqSQ1sJ()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ipWP0XDQ3Dw(RPTDataModel item)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static nbljS0xjTFrgZqSQ1sJ()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			PIhpoYqtw8mKUFMMTKKI();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TPFw2DqtcQvgnab1ZdTA()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool taW4rXqt01qkKRxuHJYX()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static nbljS0xjTFrgZqSQ1sJ z43XfQqtPC9Zq5pdZID2()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IMqR78qt8E75vISskPAo(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PIhpoYqtw8mKUFMMTKKI()
		{
		}
	}

	private static readonly string Ts5nrShbtoc;

	private bool mhdnrmHI24S;

	public TestSessionType TestSession;

	private readonly ReportManager LRFnrI1452A;

	private readonly DataSelector bg5nrQ8GW3Q;

	private readonly ParamSelector BH9nrlimTKl;

	private readonly KPIsSelector yG8nrwkBruG;

	private readonly AnalysisSelector LJUnrpINpPk;

	private readonly ReportCondiSelector lbwnrax8Viv;

	private readonly DevicePortsSelector oYjnrk7IIGL;

	private readonly FilterSelectControl dAonr0wOgBN;

	private FileSystemWatcher NqAnrZ3XCPo;

	private Dictionary<NetType, bool> H1Unrz4OCwh;

	private string iDin9CW2nrN;

	private UpdateReportHandle w8fn9GONvJY;

	private IContainer twVn9RJJW8B;

	private SplitContainer j22n9njmCS2;

	private SplitContainer SM2n9gFXA1W;

	private Label GbKn9eb1s6U;

	private ComboBox eyEn9P88PFJ;

	private ContextMenuStrip PGvn9EYD8VE;

	private ToolStripMenuItem XDmn9yU8Nit;

	private ToolStripMenuItem kkAn9cOP0S3;

	private Button c0nn9LoaFMp;

	private Button hyFn9vcxtT9;

	private Button KMin9sQTU7x;

	private Button E2Un96AkGO7;

	private Panel GKtn9hsQU0p;

	public FlatButton fbAddData;

	public FlatButton fbDeleteData;

	public FlatButton fbFilteData;

	public FlatButton fbSetting;

	private Label zAOn918GZns;

	private ComboBox gNVn9dxBKB0;

	private Label MIln9WFvrrR;

	private TabControl ofDn94YknDm;

	private TabPage tUmn9N0DrLH;

	private Panel Y2On9ipMlih;

	private Panel SZUn9F2QsiW;

	private FlatButton p37n9b3Kwea;

	private FlatButton bodn9V8QGE3;

	private FlatButton zwon9X8kIVx;

	private FlatButton TAsn92Z3bLh;

	private ProgressBarControl oRen9OSIedZ;

	private FlatButton Onvn9MxWi2c;

	private FlatButton yYWn95XhIUQ;

	private FlatButton G7jn9TqWlIG;

	private FlatButton CeIn9xmRAHt;

	private FlatButton e0Bn9qIa3n9;

	[CompilerGenerated]
	private static Func<RPTDataModel, bool> rwcn9AYUmjI;

	[CompilerGenerated]
	private static Func<IList<RPTDataModel>, IEnumerable<RPTDataModel>> zvkn9Y50xuk;

	[CompilerGenerated]
	private static Func<IList<RPTDataModel>, RPTDataModel, rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel>> VS4n9HBW9s0;

	[CompilerGenerated]
	private static Func<rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel>, bool> kd7n93FCoGn;

	[CompilerGenerated]
	private static Func<rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel>, RPTDataModel> Jnjn9JdPbig;

	[CompilerGenerated]
	private static Func<IList<RPTDataModel>, IEnumerable<RPTDataModel>> aR6n9rAvRwO;

	[CompilerGenerated]
	private static Func<IList<RPTDataModel>, RPTDataModel, rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel>> c79n99MJYQH;

	[CompilerGenerated]
	private static Func<rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel>, bool> SxNn98VAAv3;

	[CompilerGenerated]
	private static Func<rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel>, RPTDataModel> uUrn9U9Hh2W;

	[CompilerGenerated]
	private static Func<FileInfo, string> MPsn9KXw4kn;

	[CompilerGenerated]
	private static Func<FileInfo, string> L97n9tyTfMR;

	private static ReportWin lFJqwlMwpqieS0IuupY5;

	public bool CanEdit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public event UpdateReportHandle ReportUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private FileSystemWatcher faUnroODjWM()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReportWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FUwnJ3LMvT1()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void O6tnJJR9Wie(object P_0, RenamedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KhZnJrQn5Tv(object P_0, FileSystemEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MWLnJ9mBFdO(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private BindingList<RPTDataModel> rn3nr7AdVR2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void xPJnJ8Y1J2m(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hHJnJUDvG7n()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool u6FnJKRdaXI(RPTObject P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RFunJtpvGwK(RptObject1 P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fxLnJu3sF56()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private RPTObject LVxnrDSHyD0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rcXnJoYnKGL(RPTObject P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Uc9nJjjPrqv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vMenJ74mAiZ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oOcnJf1WRTH()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GxgnJDsGWfE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void s48nJBwkAHP()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jG1nJShrS06(ref RPTDataModel P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void e0lnJmffQLq(string[] P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zi2nJIRbTIA(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mAgnJQqZ2BR(string P_0 = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ihMnJloydHh()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IJcnJwoJioy(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool nVonJpMoD89(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CsKnJaMZJe0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zaFnJkRhWpV(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wYKnJ0jang3(object P_0, FormClosedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XWlnJZUx0jr(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RVGnJzBI5Ku(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sJ1nrCAs5Mt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dpjnrGgd0kA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void quTnrRU1qbL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qwJnrnB1IQQ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void j70nrgbAhrO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void G0InregBjKh()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xORnrPZHPwo(RPTObject P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void r8GnrEvb6ZV(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rMJnry8tLLx(object P_0, KeyEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitUpdateReport()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void O2DnrcLkLOX(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void QtdnrLqGr5l(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void btnImportModel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void D21nrv2sVNF(string[] P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void btnExportModel_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void btnEditReport_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aNJnrsnNlNW(RptObject1 P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void re4nr6x5hvT(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void btnAddReport_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VtHnrh4X9Uv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnReportUpdate(ComboBox cbreport)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSelectedItem(int selectedIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void phjnr1wR5CY()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void q2EnrdqxPmJ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HxHnrWk6EPB(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Vwfnr4IanIY(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CjUnrNW85Y0(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kBlnris6EO1(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uIVnrFyB8MR(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void boSnrbtUfVb(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VdwnrVnRYAi(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void krbnrXfZDQY(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zNrnr2PU7Ze(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FlbnrONOoYg(object P_0, CustomDisplayTextEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitPerShow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iAQnrMGpDYd(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FZVnr5pMB78(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RudnrTlbKFV(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pvpnrxjVTq9(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VoknrqRsScT(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void b6DnrAfk3lH()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool FBcnrYv03nZ(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static IEnumerable<RPTDataModel> Q5DnrHGPDI2(IList<RPTDataModel> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel> LsLnr3d0v3D(IList<RPTDataModel> P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool vRknrJoCWlr(rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel> P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static RPTDataModel ky2nrroG73O(rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static IEnumerable<RPTDataModel> t1Xnr90EjtP(IList<RPTDataModel> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel> fW6nr8sERRL(IList<RPTDataModel> P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool HsqnrU7uqqB(rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel> P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static RPTDataModel HRNnrKfJyFv(rmGZw3xEoZ9utlwS9X3<IList<RPTDataModel>, RPTDataModel> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static string sopnrtQMjWp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static string nNNnruN6X19(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReportWin()
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
				case 2:
					xuEqSKMwgaJ2bVJF5C6p();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					return;
				default:
					Ts5nrShbtoc = (string)N1vgLkMwFm6mMmaMbF63(240938);
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					DvoajVMDRQakIGdJH6kH();
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xlQp5RMwGEwAcYst4EKp(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Am4ytvMw3xcDfLu8KVHy(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N1vgLkMwFm6mMmaMbF63(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hCVArUMwQtSEwGMtZRM3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReportWin jmYqBvMwRJme0xoKjpXh()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g4Hp64Mw7iZWL2LuhCCW(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JQw2GYMwbG9j0PfCU47O(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xuEqSKMwgaJ2bVJF5C6p()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gjxMlaMwf7n3FeOfOnnk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rVHTuEMwj41bf6ETdB4Q(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CKlsfUMwe7lmpdt0pFYj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v95opfMw0X4iT3kud5qZ(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nm8hnaMwPtuOw1S90DRk(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aSQbOrMwcIg1oJPnKaZV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lyEOwrMw8T9rqsrvT1kg(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Jj9aQbMww2M4UeounwZR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fEqP6fMwh61fAdOiZ2ih(object P_0, int P_1, int P_2, int P_3, int P_4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nwaCgtMw4KBHQLvULDoS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GXiglcMwrAvPi1Ka5IWK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tSsrxdMwDWTYxvT7FMZx(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yJWaCcMwdS4c6nioDvpi(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SXUlNmMwCSWtD76Hqnrx(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Okolg9MwneD7LpI5APKh(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object unRiJBMwaHT9ZVktAusW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oVTxrQMwHiG8PhyqNVhb(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void stNrNjMws7IYEF1qdG1h(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WuC3ffMwlSmY4R9iZkx5(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OCx7NSMw9OQCLoJx1t3X(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kg4C8gMwkMBpFZaWv6nE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uk58l1Mw1D0KGGkBkW1v(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i2sMnkMwvSpEd4FjcFja(object P_0, ProgressKind P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SgSwSHMwSshcT6foYxk4(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QWvkUpMwm91SSbniqhXd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dVZ6wAMwICkxhfkrRmVe(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SlypxeMwXrVOaUXs9sFf(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ONiKqrMwUjdopjAYaHuk(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WatcherChangeTypes amwm8PMwOKjMNWhyLICq(object P_0)
	{
		return (WatcherChangeTypes)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int oK6eo4Mw5nohZHNKjhQd(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool itpNxOMwiCZGbP0SpqLd(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LQTIwNMwz06MtxQ0Um5q(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dnWKMeMhLtQriPeL4BTX(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hTqoWUMhNaBOisiBZddD(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y8TmCjMhYnL2bLbYwxX3(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gtruQjMhurGADMDa5HdV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult IJj5yIMhyKwluvflZ10f(object P_0, MessageBoxButtons btns)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OH7KBcMh6PmO5hH2tAZJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gkKk9iMh2HidB3tSAwBu()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g9IO8FMhJW7b9eSGTMFQ(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JhAfgUMhMwcKEYfdFZ4Y(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object caakoOMhKojc7ed3IL0n(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JPPas2MhZi7vEHypSac1(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f2lRkGMhoF3XowLmegnb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tN5R8EMhxer9mHFCbocQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UofCi2MhAhIWd59nYjW3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fKE7V2MhtcsGm8V2354v(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r3nPe5MhWwMyS5NDEmNK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Aqw2oSMhBssXHwjUVyCx(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nKVNaSMhqhkdPXnqP6uO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IlQ0nwMhERyqD8yKGZkX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uIk9RIMhVqZHj9x78g6W(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uqaNo3MhTPsBb5rSf1PC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ejJmHkMhp1XSTAVOF5Yv(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lfur39MhQLjQ9v5Sdqk0(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bGJjmVMhRYbRodnHDJX4(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TAt0gfMhGy5Yggy6CmCJ(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult cIDwTEMh3hlP5PvWX0qH(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ei5QJbMhFBVuXEIWlOSx(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eaci4gMh71y307fG21wx(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LApxTGMhbORHs3SSBGka(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AQYK2NMhgEGhCgWJy2kn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uG1q8pMhf94xq405oWW9(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X455PXMhjNZrv5DbTl1N(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wY86O5MheGVBFqOa9eIe(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UXnrAyMh0ELeFPTiXGVG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HnM1KjMhP8b3atmkBIV5(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eHwnaiMhc51ftdluYUda(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cUIKjVMh88g3JVAfeiux(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CUMNVXMhwMvmfohNDFNk(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tjDau1MhhkGPwbNpacBY(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xs6g9iMh4IqAybtjtZxl(object P_0, ApartmentState P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kBweanMhrYZ50OQCLycu(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jVUv6PMhDCElo4sg6OL1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XQXR0GMhdtKf4bgFu7n1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QFV8J0MhCvtnihLSCLMH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XQPDwhMhnIWGHcxJ4NTZ(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr VUKMUEMharOjXHCxqXsw(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double qGvbkmMhHi2mMUlwNS1A(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NUves1MhsbKHIWyj5bOh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void STaxEtMhlUpnq3bEfmuN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ehJe1XMh9WL1Jqk8cS3e(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gAEVbaMhkbJbmPiPXDdS(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jjyul8Mh1kbgK1jqkijv(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint ijVcdcMhvstXn4epdMsE(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double RwNo0RMhSAtctTKCfK9J(object P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UkMNrHMhmxIwoR9HBbf9(double value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CikGKfMhIwTPjHqFt7NA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vcqhZOMhXGxjPsVnXQrt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R63KWmMhUl9TWq8lCbdG(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NO9L4WMhOuKJ9jjTqVW3(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ong8SCMh5wP4d1Ki59dr(object P_0, object P_1, SearchOption P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kZgA9bMhioANBy2TEEPn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zQU8wgMhzLVgtokBnFRs(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oRsHWPM4LTeoHg6iuxV9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EEvQynM4NDWpAK7ustl8(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Cs4EdUM4YX0nYW83nk6W(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SFS2HsM4uIZYh9VBv17X(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dYd0srM4y1pOqFCpfiSu(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kXlGrIM46OFWfDd6r94s(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BQ66BeM42NTH2yUk1dhq(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BFYhG3M4JLHBOAb8uyjf(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C3yEg1M4MsYDLhfkeB3l(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wKkbEVM4Kn1qEspHNKlP(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xJm1cBM4ZJHfyuaDmxIL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void on7UNGM4oP27OG4MyXOT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kri8WLM4xvvTXqCKiPUE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ilNGXNM4AM04Iu2yLiyW(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gcVnB3M4tx5WS2Z7gXQi(object P_0, ReportState value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U1pWDXM4WUbOvTX3TuDc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X4GppEM4B8mf7BgH6pF9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dYZIPTM4q6syiYdOeDfo(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReportState A47IefM4E287gKNhWLiF(object P_0)
	{
		return (ReportState)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OWnjEbM4VV9u2nywf8cv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EkL2cVM4TvVp3b8Nk6H4(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JnVdCkM4pKRqvcukHiT5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d6PKnuM4QTD0NPiyK6eC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PRdPPbM4Rt97fMf9coQh(object P_0, object P_1, StringComparison P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E2SfEyM4G95Ipu4uJC83(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fnRDRWM43NnEG2IToe0A(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sE1ULNM4FEcvRN8hHeaR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UQ7ZVTM47sJhBolqjvx8(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sD23GgM4bCdq36AXcAQ6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason xV6fdkM4gmudAVNimha0(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void II5imZM4fh1krPTJt5Y9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xtW63EM4jUO4a9dCQFRY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D6oJG0M4eH5CO0K6DFAj(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MN3Z2VM40W2A86h99D5V(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qRGpjRM4PvV7MpbX855p(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kt4h5dM4cYHEXOFHBjbk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fBPXgYM48Y4ZDnjBTJea(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oewQ9eM4wt73hE57xtlk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CcxsROM4hXGVUZKVvaMT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HWOjhkM44b0MaFwLLHhZ(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kWwTTIM4rnjOcfXRxZjv(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kPcFK6M4DIQdbfsp883C(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jKGd7TM4dt5oOxXQlqA3(object P_0, object P_1, SaveFormat P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IwUaqHM4CvuolZWgPMPd(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void npM2SiM4nr2xO1Ie4xYs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RPTFileHeader mFXCCwM4a1C1bxTlO5Hi(object P_0)
	{
		return (RPTFileHeader)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q6uGQlM4HWD3TO26ZOtU(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aTUQ8HM4sADfxurmp3H0(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a7L49lM4lSMATfx1d2YM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ltOBmMM49joT60Zjx0H9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pbaITVM4kojC82LiXMuL(object P_0, object P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nc2v5PM41ZSSZnH25AOg(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bJ1TYFM4vOsn0dw7Cq1o(object P_0, object P_1, StringComparison P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JOVbjyM4SfBGpShbci6C(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GpfMViM4mKFJ8ERtg5kw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KKmQWpM4In0xCJLuTbUA()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tcSIsfM4Xwc1QgHHfkno(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DRcpSFM4UpRPB6XceTr3(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v7mbAaM4Ov4HqLvEnDST(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wuTxN4M454p3abhSQGUJ(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RsyPwFM4iaLI1Hok9LiO(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jiw8ikM4zU0J5n4iorYF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XmiTonMrLv2dOPsK7oCF(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OwrT0qMrNcPG6nXfXDf0(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Keys tdQ85gMrYFD5BxqhcC7E()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Keys)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pjv7vPMru2FujT7lARwH(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bn10yNMryhjI0TdRqJLs(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vbfm9BMr6lhSSLKd3O1N(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wusBQKMr2SZwoAYDkDwr()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult oXeXWQMrJK1nQKI6rxR9(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int s8QGUvMrM9VkUqcgY4dq(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q7Q311MrKnqux7TVtF3r(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vwpC7AMrZSmUnUIldgps(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int y0Ap5uMroA4xpVYMkWsM(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Cr6SbxMrxtd1vSrCN2ir(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yG2Q0yMrAlZHWrKc20Ak()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gqVhBUMrtfwLU17PETPM(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pkvmFJMrWAHcOcskxTwY(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eyVtkcMrBfnoPf8F3F3h(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pMqB6kMrqddeEfD4o06N(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iqETs2MrEM9scOKT3DZ6(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JjEol8MrVhNgEIKqd7hw(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void orRUsDMrT54e0yeAtEiD(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hMvxvZMrpilcBRD0UITt(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GHOgrxMrQTNpMXUH0ODP(object P_0, Orientation P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gUbv0WMrR68XGbPF0KZk(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kq5QRhMrG2OwU2WwCkPT(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oIFSboMr3siuh83jypqY(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rN61Q4MrFUhslXfZyYKt(object P_0, ComboBoxStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qQEircMr7veiqw1awSuu(object P_0, FlatStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VeXq33MrbKIBHm55dfGt(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void knZVpWMrgL3tLnGbHbhf(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color g2cya8MrfQB8Hx6A9abB()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zP5KrmMrjTpwdL3MX32i(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ta65WpMre4sfYI6hIn3K(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color mUx3j7Mr0NpXjyQUX2GK()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KUeausMrP6C5BVVtTBMW(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nlSpYtMrc6LY6uquX5f7(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color F60fbfMr8JxeGVnRkEGb(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XX35u6Mrwi3fo72OV6an(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vvdL1RMrh7pbt01dUVkp(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VmgWxwMr4KGRUjgk9rj6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WgVxkTMrrctlYhdBxyII(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BGR1HjMrD2huopwIHmAc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dYW079MrdaQeqRjVZE7V(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LxUxnMMrCDaD9S21ubIp(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oDx7vtMrnf1Gidl4d2js(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oLBOIsMra4G9BcqcwZJB(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GPgeYYMrH1FUUfEJMTbj(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nCKDXtMrsVc6vAEubQSo(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void axMWsQMrlqJ7jHMhtkxy(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oXbSbhMr9ou2Tf3FR0MC(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kRgrR8MrkYmTIqEtGx09(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X85h3bMr1FVfRYLIAqCE(object P_0, ImageLayout P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GEU97QMrvOUc9Qp6P6AW(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y0uEyqMrSIobDtiAiogO()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IDLEReMrmm3d3gK6VaYU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r37kXNMrIiZqWSL25TOt()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kqvsg5MrXehu7liRvFJL(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JxDBL2MrUpfkqLVLgKDm(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NevkZcMrOq3r2a9UcIiE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SsmrBZMr5FZ5u1ULgJwg(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pjD0gRMripRDa62fOJRg(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R9Ekk6MrzX9WuHKanaeP(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VjE5D3MDLLFSei4KNL1N(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y8TWMSMDNFdqAtXglCYJ(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O3gZgIMDYpSr8Vd2XpFP(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QgpHU4MDu51FqqN65UwQ(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VO7wcvMDy1bddRgRjWG0(object P_0, BorderStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uDV6tNMD6h7RJyQoDOXZ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color PMwLr7MD2sU9nQHmhmwG()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color ELj3I9MDJE6IuIeMFSJ6()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zFyl44MDMGLNYE4iKhas(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P4SsiZMDKddoZrlqkbYf(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h65QLfMDZrrfLZPH3W6t(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uOBrIGMDo4q8cg6VccR7(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VSbTLoMDxLihDUqHNAgi(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yHr1EYMDAF60uoYSXP9R(object P_0, FormStartPosition P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fq9R5yMDtANNmHD1ejsh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XYTsvFMDWX8p6hyZAfv1(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bnr6TnMDBQnabGrp4kBb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NC5qIfMDqHgYOFJcPGR7(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NviuleMDE2MqZU2EXm4K(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UQCX6DMDVSYJvIrWI0bV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jBOQASMDTsZQ6qcVZku0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tTc25TMDpQXgVHYJr1qy(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jAq2AsMDQekHokR6QlNf(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DvoajVMDRQakIGdJH6kH()
	{
	}
}
