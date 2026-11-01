using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class FlashInfoBox : BaseWinUtils
{
	private delegate void gubWMTD8Wgy1wH2u45(string sMsg, FlashInfoPosition pos, int timeout, int eqIndex = -1, int warnCode = 0, int level = 1);

	public new struct MARGINS
	{
		public int leftWidth;

		public int rightWidth;

		public int topHeight;

		public int bottomHeight;
	}

	public delegate void SendPadWarningDelegate(int eqIndex, int warnCode, int level, string sDesc);

	private bool qwJL1dCXYQ;

	private bool x2FLkv5ZI0;

	private bool bscLOvcO8m;

	public static SendPadWarningDelegate SendPadWarningAction;

	private IContainer vaYLBU5rUl;

	private Label agSL6EZfQe;

	private Timer N50LJb9xRt;

	private Timer gB8LU1xOJM;

	private static FlashInfoBox qJMtG2T26xgUJ21Cqfb;

	protected override CreateParams CreateParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlashInfoBox()
	{
	}

	[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
	private static extern IntPtr l9OLitDH2W(int P_0, int P_1, int P_2, int P_3, int P_4, int P_5);

	[DllImport("dwmapi.dll")]
	public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

	[DllImport("dwmapi.dll")]
	public new static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

	[DllImport("dwmapi.dll")]
	public new static extern int DwmIsCompositionEnabled(ref int pfEnabled);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool jLPLV105Ic()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WndProc(ref Message m)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClosed(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Show(string sMsg, FlashInfoPosition pos = FlashInfoPosition.Center, int timeout = 0, int eqIndex = -1, int warnCode = 0, int level = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void WJRLo1BU2o(object P_0, FlashInfoPosition P_1, int P_2, int P_3 = -1, int P_4 = 0, int P_5 = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowSync(string sMsg, FlashInfoPosition pos = FlashInfoPosition.Center, int timeout = 0, int eqIndex = -1, int warnCode = 0, int level = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void VVtLM5ZZKC(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowDialog(string sInfo, FlashInfoPosition position = FlashInfoPosition.Center, int timeout = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bG5LQdx2L3(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ehsLYEMQNv(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gNILbqWbNb(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jEHLuQKw2c(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void geZLcSMSeA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FlashInfoBox()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					PFWtMTT4bDLshpgCBWG();
					num2 = 3;
					continue;
				default:
					STyqf5TcSV8ZyQcIpVE();
					num2 = 2;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					EsAbEATp9ik52GgLJ85();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void STyqf5TcSV8ZyQcIpVE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JbN0qaTb2MJQZWdm3XM(int orgSize)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wUjVTTTyNx150Ptab2g()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FlashInfoBox Bn37VFTEaZjC4DliWxW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oXfme0TQFEAHodU4dwx()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sfi3flTfDEjmRa40VIs(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SmwinLTtOC5eb7EpKGB(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uXeCw9T6IXUk9Y76MYt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p8TY3ATkdFOm1F5yCB2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EsAbEATp9ik52GgLJ85()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PFWtMTT4bDLshpgCBWG()
	{
	}
}
