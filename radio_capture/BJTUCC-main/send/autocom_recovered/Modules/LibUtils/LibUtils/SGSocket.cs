using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class SGSocket
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public delegate void SocketCallbackDelegate(IntPtr user, IntPtr data, int len, int type);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public delegate void SendCallbackDelegate(IntPtr user, int key, int ack);

	protected const int CIPortBase = 20679;

	protected static int UBClientPortBase;

	protected int Port;

	protected IntPtr CallBack;

	protected IntPtr User;

	public int PID;

	private bool XyTsKx6etv;

	protected object LockObj;

	public SparkSocketClient SSocketClient;

	public SparkSocketBase.SparkSocketCallbackDelegate SparkSocketClientCallbackDel;

	public SparkSocketServer SSocketServer;

	public SparkSocketBase.SparkSocketCallbackDelegate SparkSocketServerCallbackDel;

	public SocketCallbackDelegate SGCallbackDelegate;

	public UMQSocketBase UMQSocket;

	internal static SGSocket h8PO3ov0l4Y5uCpirYh;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SGSocketDebugFileName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetServerSocketPortByEQIdx(int EQIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr ub_client_open(string addr, int port, IntPtr callback, IntPtr user, bool tcp, string bindIP)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr ub_server_open(string addr, int port, IntPtr callback, IntPtr user)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr ub_server_openWithBuffSize(string addr, int port, IntPtr callback, IntPtr user, int sendsize, int recvsize)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr ub_client_openWithBuffSize(string addr, int port, IntPtr callback, IntPtr user, int sendsize, int recvsize)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UBClientOpenWiFi(string addr, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SocketSettingModeFunc(IntPtr handle, bool hasHeadMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int khVsjAeWB5(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UBClientOpen(int EQIdx, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UBClientOpenWithSparkServer(int EQIdx, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SparkSocketCallbackClient(byte[] bytes, int index, int count, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ub_client_close(IntPtr handle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ub_server_close(IntPtr handle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UBClientClose(int iWiFiMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UBServerClose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int UBClientSendInfo(string data, int len)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ub_client_send_infoUTF8(IntPtr handle, byte[] data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ub_client_send_info(IntPtr handle, string data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ub_server_send_bytes(IntPtr handle, byte[] data, int len, int type = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ub_server_send_info(IntPtr handle, IntPtr data, int len, int type = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int UBClientSendInfoUTF8(byte[] data, int len)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int UBClientSendInfoBinary(IntPtr data, int len)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UBBroadcastOpen(string localIP, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SendWithBroadCast(string sReq, int iLen)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr umq_open(string logPath, string soPath, bool isServer, string addr, int port, IntPtr callback, IntPtr user, IntPtr sendCB)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int umq_sendmsg(IntPtr handle, byte[] data, int len, int timeout_ms, int repeatIntervalMs)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void umq_close(IntPtr handle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SGSocket()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SGSocket()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				case 3:
					UBClientPortBase = 20679;
					num2 = 5;
					goto IL_0017;
				case 1:
					O1vaAba4y8Tt5f1MbTE();
					num2 = 4;
					goto IL_0017;
				case 4:
					o1EkXTaTtGdZHkN6WMX();
					num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					goto IL_0017;
				case 5:
					return;
				case 2:
					break;
				default:
					KQoDeCak3w5jXGYm1pJ();
					num2 = 3;
					goto IL_0017;
				}
				uVvXtEapKcl9jG2Nnq0();
				num2 = 1;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B6rPlXvVRmjy9Te9gfi(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SGeTefvuiRH4Gtk3BTJ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SGSocket Sbv1LpvlKURBm1vmogT()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h2SafpvXWSjwWOBF6wm(object P_0, object P_1, int port)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qGjHHAvwGAevpoJVr81(object P_0, object P_1, int port, object P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qVWSScveqMKKcu9VKAv(object P_0, int sendBuffSize, int recvBuffSize)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NK4jRBv88TQWuTyqvLW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr TdZ0HevsP31chEkPYlq(object P_0, int port, IntPtr callback, IntPtr user)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vVIvELv1ws4eY1CayBB(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KIu8yRvzuti9SpX3PEV(int pid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nkiCdEaOlUf0mP9gour(int port)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool crZxqIaJrV9wTFsJ2uk(int pid)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KQMrXFa26QYp7UTdJLT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A0ZxJway3G906O9h3Ne(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AUFcagaEteRu2BLpnNN(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int p0HLEWacucf3wM8YWv4(object P_0, object P_1, int len)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tmxLx2absRvEZNLfmsX(object P_0, object P_1, int idx, int count, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uvt6qNaQ9g8SgyUUvEg(IntPtr intPtr, int len)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vdgaOiafX22Gk2RuZeA(object P_0, IntPtr data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mAuPUaatbLXWBfrJR2U(object P_0, object P_1, int len, int timeoutms, int repeatIntervalMs)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VrfSqaa6OWBQNO5uayn(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KQoDeCak3w5jXGYm1pJ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uVvXtEapKcl9jG2Nnq0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O1vaAba4y8Tt5f1MbTE()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o1EkXTaTtGdZHkN6WMX()
	{
	}
}
