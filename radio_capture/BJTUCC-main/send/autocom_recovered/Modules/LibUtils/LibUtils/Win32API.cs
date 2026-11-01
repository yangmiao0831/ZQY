using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class Win32API
{
	private delegate bool kQ3th4in7NuN2x2dOw(IntPtr hWnd, IntPtr lParam);

	public const int SB_HORZ = 0;

	public const int SB_VERT = 1;

	public const int SB_CTL = 2;

	public const int SB_BOTH = 3;

	public const int WS_EX_MDICHILD = 64;

	public const int SWP_ASYNCWINDOWPOS = 16384;

	public const int GWL_STYLE = -16;

	public const int WS_VISIBLE = 268435456;

	public const int WM_CLOSE = 16;

	public const int WS_CHILD = 1073741824;

	public const int SW_HIDE = 0;

	public const int SW_SHOWNORMAL = 1;

	public const int SW_NORMAL = 1;

	public const int SW_SHOWMINIMIZED = 2;

	public const int SW_SHOWMAXIMIZED = 3;

	public const int SW_MAXIMIZE = 3;

	public const int SW_SHOWNOACTIVATE = 4;

	public const int SW_SHOW = 5;

	public const int SW_MINIMIZE = 6;

	public const int SW_SHOWMINNOACTIVE = 7;

	public const int SW_SHOWNA = 8;

	public const int SW_RESTORE = 9;

	public const int SW_SHOWDEFAULT = 10;

	public const int SW_MAX = 10;

	public const int MOUSEEVENTF_MOVE = 1;

	public const int MOUSEEVENTF_LEFTDOWN = 2;

	public const int MOUSEEVENTF_LEFTUP = 4;

	public const int MOUSEEVENTF_RIGHTDOWN = 8;

	public const int MOUSEEVENTF_RIGHTUP = 16;

	public const int MOUSEEVENTF_MIDDLEDOWN = 32;

	public const int MOUSEEVENTF_MIDDLEUP = 64;

	public const int MOUSEEVENTF_ABSOLUTE = 32768;

	public const int MOUSEEVENTF_WHEEL = 2048;

	public const int AW_HIDE = 65536;

	public const int AW_ACTIVATE = 131072;

	public const int AW_SLIDE = 262144;

	public const int AW_BLEND = 524288;

	public static readonly IntPtr HWND_BOTTOM;

	public static readonly IntPtr HWND_NOTOPMOST;

	public static readonly IntPtr HWND_TOP;

	public static readonly IntPtr HWND_TOPMOST;

	public static readonly uint SWP_NOSIZE;

	public static readonly uint SWP_NOMOVE;

	public static readonly uint SWP_NOZORDER;

	public static readonly uint SWP_NOREDRAW;

	public static readonly uint SWP_NOACTIVATE;

	public static readonly uint SWP_FRAMECHANGED;

	public static readonly uint SWP_SHOWWINDOW;

	public static readonly uint SWP_HIDEWINDOW;

	public static readonly uint SWP_NOCOPYBITS;

	public static readonly uint SWP_NOOWNERZORDER;

	public static readonly uint SWP_NOSENDCHANGING;

	public static readonly int WM_QUIT;

	private static Win32API PreUqoLUFKxxfXNm8wB;

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern long GetWindowThreadProcessId(long hWnd, long lpdwProcessId);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	[DllImport("user32.dll", EntryPoint = "GetWindowLongA", SetLastError = true)]
	public static extern long GetWindowLong(IntPtr hwnd, int nIndex);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong)
	{
		return (IntPtr)(object)null;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLong")]
	public static extern IntPtr SetWindowLongPtr32(HandleRef hWnd, int nIndex, int dwNewLong);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLongPtr")]
	public static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, int dwNewLong);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uflags);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

	[DllImport("user32.dll", EntryPoint = "PostMessageA", SetLastError = true)]
	public static extern bool PostMessage(IntPtr hwnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	public static extern int SendMessageBySCROLLINFO(IntPtr hwnd, int wMsg, int wParam, ref SCROLLINFO lParam);

	[DllImport("user32")]
	public static extern int ShowScrollBar(IntPtr hwnd, int wBar, int bShow);

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int SetWindowText(IntPtr hwnd, string lpString);

	[DllImport("user32.dll")]
	public static extern bool GetScrollInfo(IntPtr hWnd, int fnBar, SCROLLINFO scrollInfo);

	[DllImport("user32.dll")]
	public static extern bool SetScrollInfo(IntPtr hWnd, int fnBar, ref SCROLLINFO scrollInfo, bool fRedraw);

	[DllImport("user32.dll")]
	public static extern int GetScrollPos(IntPtr hWnd, Orientation nBar);

	[DllImport("user32.dll")]
	public static extern int SetScrollPos(IntPtr hWnd, Orientation nBar, int nPos, bool bRedraw);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLastError()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLastErrorString(int errCode)
	{
		return null;
	}

	[DllImport("kernel32.dll")]
	public static extern int FormatMessage(int flag, ref IntPtr source, int msgid, int langid, ref string buf, int size, ref IntPtr args);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetParent(IntPtr hwnd);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32")]
	public static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

	[DllImport("user32")]
	public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(IntPtr hWnd, ref WINRECT lpRect);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
	public static extern bool CreateProcess(StringBuilder lpApplicationName, StringBuilder lpCommandLine, SECURITY_ATTRIBUTES lpProcessAttributes, SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, StringBuilder lpEnvironment, StringBuilder lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

	[DllImport("user32.dll", EntryPoint = "EnumWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool s8SaHN6L1w(kQ3th4in7NuN2x2dOw P_0, IntPtr P_1);

	[DllImport("user32.dll", EntryPoint = "GetWindowText", SetLastError = true)]
	private static extern int IatawYeCvF(IntPtr P_0, StringBuilder P_1, int P_2);

	[DllImport("user32.dll", EntryPoint = "GetWindowTextLength", SetLastError = true)]
	private static extern int A6Qar2ibvW(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr FindWindowPartial(string searchTerm)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Win32API()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Win32API()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					SWP_NOREDRAW = 8u;
					num2 = 14;
					continue;
				case 9:
					SWP_HIDEWINDOW = 128u;
					num2 = 20;
					if (true)
					{
						continue;
					}
					break;
				case 19:
					HWND_TOP = new IntPtr(0);
					num = 5;
					break;
				case 16:
					return;
				case 17:
					CDsW8tL0b82IFShG5IA();
					num2 = 7;
					continue;
				case 2:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 1;
					if (1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					HWND_BOTTOM = new IntPtr(1);
					num = 3;
					break;
				case 11:
					SWP_NOOWNERZORDER = 512u;
					num2 = 18;
					if (true)
					{
						continue;
					}
					break;
				case 20:
					SWP_NOCOPYBITS = 256u;
					num2 = 11;
					continue;
				case 3:
					HWND_NOTOPMOST = new IntPtr(-2);
					num2 = 19;
					continue;
				case 14:
					SWP_NOACTIVATE = 16u;
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 7:
					t6tUbnLPmpv4CdZPqt2();
					num2 = 1;
					if (true)
					{
						num2 = 15;
					}
					continue;
				case 10:
					SWP_SHOWWINDOW = 64u;
					num = 9;
					break;
				case 4:
					WM_QUIT = 18;
					num2 = 16;
					continue;
				default:
					SWP_FRAMECHANGED = 32u;
					num2 = 10;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					pDvVhLLq49xFJUUvjna();
					num2 = 17;
					continue;
				case 13:
					SWP_NOMOVE = 2u;
					num2 = 6;
					if (true)
					{
						continue;
					}
					break;
				case 18:
					SWP_NOSENDCHANGING = 1024u;
					num2 = 4;
					continue;
				case 5:
					HWND_TOPMOST = new IntPtr(-1);
					num2 = 8;
					continue;
				case 8:
					SWP_NOSIZE = 1u;
					num = 13;
					break;
				case 6:
					SWP_NOZORDER = 4u;
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qhiqp1L5vhxBApEqvJQ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Win32API SmipDNLNIWwrU1ceCbB()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pDvVhLLq49xFJUUvjna()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t6tUbnLPmpv4CdZPqt2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CDsW8tL0b82IFShG5IA()
	{
	}
}
