using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LibBase;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class BaseWinUtils : Form
{
	public struct MARGINS
	{
		public int leftWidth;

		public int rightWidth;

		public int topHeight;

		public int bottomHeight;
	}

	protected const uint DesignDotsPerInch = 96u;

	public const int SM_CXFIXEDFRAME = 7;

	public const int SM_CYFIXEDFRAME = 8;

	public const int SM_CXBORDER = 5;

	public const int SM_CYBORDER = 6;

	protected bool m_DrawCaptionBackColorEnabled;

	protected Color m_DrawCaptionBackColorActive;

	protected Color m_DrawCaptionBackColorDeactive;

	protected string CaptionOrg;

	protected bool m_ShowCaption;

	protected bool m_ShowMaxBtn;

	protected bool m_ShowMinBtn;

	protected bool m_ShowCloseBtn;

	protected bool m_DoubleClickToMax;

	protected bool m_WinCanMove;

	protected bool m_SetWinShadow;

	protected bool m_DrawRectBorder;

	protected bool m_CanChangedSize;

	private bool E177qNj6bZ;

	private Point cp17Ty62nn;

	private Point vZN7ZheiJZ;

	public bool CurWinActived;

	public static Timer tmrDoAppDeactive;

	public static bool AppActive;

	protected bool AutoScaleOnShown;

	protected bool AutoScaleFlatButtonImage;

	protected Dictionary<string, Rectangle> ControlDesign;

	protected float scaleFactor;

	protected DockStyle m_Dock;

	private uint WbN7LX8iie;

	protected Rectangle? BeforeZoomBounds;

	protected Rectangle? BeforeZoomScreenArea;

	protected RectangleF? BeforeZoomScreenScale;

	protected Rectangle? MinimumScreenArea;

	protected HashSet<Control> keepLocationWins;

	protected HashSet<object> unScaleWidthDgvs;

	protected HashSet<Type> unScaleInnerUserControlType;

	protected HashSet<object> unScaleInnerControls;

	protected HashSet<object> unScaleControls;

	protected int BeforeShowWidth;

	private bool QSA7smqXEP;

	private bool UnY7aRedX6;

	private IContainer mYW74v9y7I;

	protected Panel pnlCaption;

	protected Panel pnlClient;

	protected FlatButton fbClose;

	protected FlatButton fbMax;

	protected Label lblCaption;

	internal static BaseWinUtils k9puYY2vlG7wB7B1QuW;

	protected Rectangle CurrentScreenWorkingArea
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Rectangle)(object)null;
		}
	}

	public float ScaleFactor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0f;
		}
	}

	protected uint WorkerDotsPerInch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0u;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	protected override CreateParams CreateParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[DllImport("user32.dll")]
	public static extern uint GetDpiForWindow(IntPtr handle);

	[DllImport("user32.dll")]
	public static extern int GetSystemMetrics(int nIndex);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnLoad(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnShown(EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoScaleFlatButtonImage(ControlCollection controls)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDotsPerInchChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RecordBaseWinInfo(Rectangle area)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Rectangle GetScaleBoundsFromDotsPerInch(Control ctrl)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DotsPerInchScale(ControlCollection controls)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DotsPerInchScale(Control ctrl)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Rectangle OJbrycoKH(SizeF P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Rectangle jfNfFsSq5(Rectangle P_0, SizeF P_1)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MoveToLocation(Point location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ZoomBounds(SizeF scale, Point ownerLocation, Point display)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResumeBounds(Point owernLocation, bool useNewSize = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PGVFTXc67(ControlCollection P_0 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BaseWinUtils()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void a9vmLwv4v(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void XmPdibnHM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void wDVEvxYcy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jdv5VsBwK(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QlZtpWBC8()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LoadLanguage(Control fatherControl)
	{
	}

	[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
	private static extern IntPtr UPXSj71fa(int P_0, int P_1, int P_2, int P_3, int P_4, int P_5);

	[DllImport("dwmapi.dll")]
	public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

	[DllImport("dwmapi.dll")]
	public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

	[DllImport("dwmapi.dll")]
	public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Agy8ahTCI()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void WinMouseDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void pnlCaption_MouseDown(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void pnlCaption_MouseUp(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void CaptionMouseUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void WinMouseMove(int iX, int iY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void pnlCaption_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoWinActivate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoWinDeactivate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void z94hJQx8M(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LKZ2NGUGu(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void fbClose_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCloseClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void fbMax_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnMaxClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WndProc(ref Message m)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ftTNZhx2Y(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResizeCaption()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void pnlCaption_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UP0l8UR4M(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void PaintControlBorder(Control ctrl, Graphics graph, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Y59zl1PoL(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ETL79It8AH(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateBoolValue(UpdateMainWinBoolType type, bool bValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LLE770DQy6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseWinUtils()
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
				default:
					h8KMTJ2xgfcUbLmF9TZ();
					num = 4;
					break;
				case 4:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 5;
					continue;
				case 5:
					n8WpS323SC6TaTsvpwk();
					num2 = 2;
					if (0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					AppActive = false;
					num = 3;
					break;
				case 1:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Skl39M2aPj7uRonMPtQ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BaseWinUtils CnCVSo2Gb4Li29bJ0Ht()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FuQnyM29H8GA2H3Gebf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JkCqQY2hOIZJET4KNVl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qr2EVD2BJrweZNWMucZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int g3Vays2LVRSommVyiMf(int orgSize)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle FjVmQj2ZSPZBeOn7cpA(object P_0, object P_1)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void htOuiC27Zm608iVRopw(object P_0, Point location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h8KMTJ2xgfcUbLmF9TZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n8WpS323SC6TaTsvpwk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S9VBmy2FoCuOWQigHl1()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gnH0mO2Iy099FeUIDVO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y5Iy2r2C4WTotckBZai(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GOcNIb2dZ2r8aG1L1Dg(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void guULMW2oB9JiDXcIO57(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fFkloF2iYI1ZObFY5aq(object P_0, int iX, int iY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DQkUiF2rujPg2yOrU3F()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mZtLvF2KhoNrAjsZcHe(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tkZBA92ndgwYVFD9PFx(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TcmZ8d2WYdEoBL1NPvX(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object okM3bW2jebYAJZ49ubV()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ns6ynO2MpOGp5ERNlHm(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DUYrZ82YPPWRGbqL70Z()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fDyNCI2gxt5d7HkGV5L()
	{
		return null;
	}
}
