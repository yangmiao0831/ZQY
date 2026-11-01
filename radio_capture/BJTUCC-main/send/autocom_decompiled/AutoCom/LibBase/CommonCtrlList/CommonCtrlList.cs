using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LibCoord;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibBase.CommonCtrlList;

public class CommonCtrlList : UserControl
{
	private UICmbButtonGroup l9NPsmtjD8a;

	private string pnAPsIyLtf8;

	private string YwhPsQHMpbs;

	private List<string> jNAPsl9Wvqi;

	private int qT0PswbcXs7;

	private FlowLayoutPanel wgmPsp96HXB;

	private Action JhxPsapEP6U;

	private UICmbButtonGroup.ButtonClickDelegate RZOPskgyu7O;

	private UICmbButtonGroup.ButtonClickDelegate NfPPs0Ptlkh;

	private IContainer C6PPsZdxTsc;

	private BarManager vrEPszsaDXG;

	private BarDockControl KqMP6CM7Cpr;

	private BarDockControl sxSP6GZFInf;

	private BarDockControl lvtP6Rv71U1;

	private BarDockControl Yy1P6ny4iIE;

	private PopupMenu PoIP6guSnMH;

	[CompilerGenerated]
	private static Comparison<TimeRange> ANTP6eXTVaE;

	private static CommonCtrlList q8CPSZWqA3y22kEJtFcE;

	protected virtual bool DefaultAddFlowPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public int ItemHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	protected virtual FlowLayoutPanel DisplayPanel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int ChildCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	public event Action Removed
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

	public event UICmbButtonGroup.ButtonClickDelegate AddZoneMoreClick
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

	public event UICmbButtonGroup.ButtonClickDelegate AddFilterMoreClick
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
	public CommonCtrlList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddFlowPanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected FlowLayoutPanel CreateOnePanel()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UITimeEdit AddTimeEdit(string dateTimeFormat)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTimeEditWithTime()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTimeEditWithTime(DateTime startTime, DateTime endTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTimeEditWithDateTime()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTimeEditWithDateTime(DateTime startTime, DateTime endTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JnJPsUh02nu(Control P_0, Control P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICmbButtonGroup AddCmbButtonGroup(int groupItemHeight = -1, bool showRemoveButton = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddFilter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FR6PsK6iVDo(UICmbButtonGroup P_0, FlatButton P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MZVPst9nahG(object P_0, ItemClickEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dcVPsuvGiqn(object P_0, CancelEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rUpPsoZCNlL(ComboBoxEdit P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddZone()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JrKPsjlyA6n(object P_0, CustomDisplayTextEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OneFilter BuildZoneFilter(string filePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Q5IPs72vRS6(object P_0, CancelEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DisplayZoneFile> LoadZone(ComboBoxEdit cbe)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool HasChild()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<OneFilter> GetFiltersByTime(bool separately, bool dateTime, bool eliminate, string logfileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<OneFilter> rrXPsf4gnSp(bool P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<OneFilter> GetFiltersByEliminateTimes(string logfileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<OneFilter> GetFiltersByZone(bool separately, bool eliminate = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<OneFilter> GetFiltersByFilter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<TimeRange> GetTimeRanges()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetZoneNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DisplayZoneFile AddZoneFile(UICmbButtonGroup zoneItem, string fileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectZoneFile(UICmbButtonGroup zoneItem, string fileName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RBYPsD4iOY9()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static int NQnPsBDBxgR(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CommonCtrlList()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		ovikwgWEdkOA9KAmX1SG();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EH7GmIWqBaMCfPfraav1(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ftmrxSWqtVVmIiwnMfON()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CommonCtrlList d9agF1WqWa2myT1kJSHM()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pRKuKGWqqcVqtdhwvK5b(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QZdtmMWqE6rQPtlYVt1p(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cJC914WqVkRvWA08vw06(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Aor4P2WqTTRDx795yDWS(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pMIInYWqpiqFGNj8mWVP()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M1mBlyWqQPyKGCwLCn4y(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hGsNvxWqRdKCRv642PGO(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VfxNKeWqGnULv1RNPq8A(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bspsdjWq3NMsiqMj2KrS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pdtYHDWqFTHq6AGwjdGs(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jm2rJhWq7HtIFfsoPFy8(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OTQ5JZWqb8hTmfLDFk6c(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zRpDoqWqgUra6NMfYYU3(object P_0, FlowDirection P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OVfK0sWqfgdZXdFshcjW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P7DTCJWqjtDMTjYkfm9F(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O9OZrfWqeUvvevXOjgMi(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cIXMbUWq0s7ko4KbeOUC(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oo1DkiWqPYdn3n2GDaEq(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fv3yGNWqcJWKinp1KO03(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UAqp7MWq8gaAAM49ddMy(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime XDZhPiWqw2q1b4BL8oA3()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MQjqOAWqhjeZm0cuuKU3(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S38B5TWq40OScqlVypov(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NvTFgMWqr0j45wCRkj1n(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eX1hlAWqDnjfjq1yMiWm(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uU05pPWqdi1tKbHrTkxh(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WFS9mTWqCTUrUWRrDny2(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wQuQd2WqnxhaLWR8xF2I(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yWtY8PWqaXqP2QxBPl68(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gJDCrIWqH7FErrSP7yEK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bEvbb0WqsTvF5hS39ShB(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NWRB8RWqlZ2T4yZNNETj(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle IKyJQKWq9lSwGoNokt9R(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type smTxKnWqk3HmsRwb0jno(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hYf0iXWq1DfiIIHxsno0(Type P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object smWf2CWqvuoqM5UiD7gM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EgBOuAWqShEexiHAtEtF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IFr83FWqmP2LkgTEPiof(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LwKJtGWqIyd4cfrkb1AN(FilterType type, FilterType selfType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F3t1GyWqXGx978tgNVRk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uqojAZWqUNXlIkWFFxS8(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HpGtsOWqObjJZTU3hE2k(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point iXxyYOWq5SHWg18DRfdQ()
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nGvsrXWqiIfUwSaxEQ5K(object P_0, object P_1, Point P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aZa212Wqz5N6bj0Ls9tL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O0K68HWELt8EOKPK2ZwR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult QeDVBZWENkcMNSjC15W2(object P_0, object P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult QHpiwVWEYSgSTV85dUTt(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S3Qf8oWEu1tTdrlZoCwb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xcHSCvWEyHSYCyMx7EPT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I6C7FnWE6K8HBvHK6Uf1(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cpSAyAWE2RHdEEXW4S7D(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J4mvhOWEJqX0EUXpKwUQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HMBJvGWEMTRJLPROJl1m()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OK5D04WEKov1tvZwWUfp(object P_0, UpdateMainWinBoolType P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cAqTU4WEZ0qCKAlWly9E(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object veJCa8WEoZ8nGiN7E7Ks(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w92LmDWEx153AQR0OjhN(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T3V2cLWEA9YwIM4P0fsl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P6kcfiWEtv5Mwp5RVjbu(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SmHkb9WEWktw47uUV65w(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr yTFDA0WEBBMVb6kgKcir(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cPR8itWEqP4pTQMDXyOp(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gb5BAkWEEKfhpjnfgQES(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xVw857WEVgO0QE6kqhTO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oTWhlpWETZslwVeEJ7MO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ULNaSDWEpgyAMwThiXO1(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CCwTOxWEQw8HmRHqNegb(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nm81QkWEREK8qmBqKvTO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ovMDFcWEGdRlCV4Uk58h(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bL9bc2WE3eRcpvjhV2nc(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gUG43mWEFjQ6GFRtLDMQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QUOnaBWE7GogLNwOIwW5(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void plfSRiWEbZaKSvl2LcmU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mpsMJEWEgCbQ8quBQiL2(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q7cRbSWEfZGNAqku8Gyu(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j7QClcWEjhPE0PRXG8Vb(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jLLt1yWEea8BaCX8nl6e(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fwNUs7WE0Y5Sugn5ZVwb(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xsSYOnWEPiOCgyo07ufw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zTq1uVWEcAxK1pm74ZpU(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oojEBLWE8Mn7l0L5ReDn(object P_0, SizeF P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qJ7IHOWEworwMSkt6ju1(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FyXxAFWEhYoEgTws8vQm(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OfCAdLWE4tNwIrBd4Zom(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime IMOZ9GWErQjIMxwbr15B(object P_0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime ED0X67WEDqC11KVD31ib(object P_0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ovikwgWEdkOA9KAmX1SG()
	{
	}
}
