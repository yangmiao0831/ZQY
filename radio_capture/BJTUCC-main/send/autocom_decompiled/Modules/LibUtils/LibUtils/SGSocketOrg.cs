using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class SGSocketOrg
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public delegate void SocketCallbackDelegate(IntPtr user, IntPtr data, int len, int type);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public delegate void SendCallbackDelegate(IntPtr user, int key, int ack);

	protected const string UBDLL = "SSSTXX.dll";

	protected const int CIPortBase = 20679;

	protected static int UBClientPortBase;

	protected IntPtr handle;

	protected int Port;

	protected IntPtr CallBack;

	protected IntPtr User;

	public int PID;

	private bool pRhsgaQMmY;

	protected object LockObj;

	private static SGSocketOrg mvNSyUvWtax1YAdmZdj;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SGSocketDebugFileName()
	{
		return null;
	}

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C04")]
	private static extern uint acisZjA9TT(int P_0, IntPtr P_1, IntPtr P_2);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C04WithPID")]
	private static extern IntPtr pFksLF40RS(int P_0, IntPtr P_1, IntPtr P_2, ref int P_3);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C04WithPID_V2")]
	private static extern IntPtr dNOssWHQ7m(int P_0, IntPtr P_1, IntPtr P_2, ref int P_3, int P_4 = 0);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C04WithPIDWithLog")]
	private static extern IntPtr n5lsaVttpm(int P_0, IntPtr P_1, IntPtr P_2, ref int P_3, string P_4);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C08")]
	private static extern IntPtr hOvs4KJFpZ(IntPtr P_0);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C06")]
	private static extern int fsZsRsLq5E(IntPtr P_0, string P_1, int P_2, int P_3);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C06")]
	private static extern int DBJsxFcghu(IntPtr P_0, byte[] P_1, int P_2, int P_3);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C06")]
	private static extern int gNCsX2bAy1(IntPtr P_0, IntPtr P_1, int P_2, int P_3);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "A01")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool judge_tcp_port_used(int port);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C01")]
	public static extern IntPtr ub_client_open(string addr, int port, IntPtr callback, IntPtr user, bool tcp, string bindIP);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C0105")]
	public static extern IntPtr ub_client_open_withLog(string addr, int port, IntPtr callback, IntPtr user, bool tcp, string bindIP, string logPath);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C0101")]
	private static extern IntPtr XuwsCd9ILI(string P_0, int P_1, IntPtr P_2, IntPtr P_3, string P_4);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C07")]
	public static extern void ub_client_close(IntPtr handle);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "S01")]
	public static extern IntPtr ub_server_open(string addr, int port, IntPtr callback, IntPtr user);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "S0105")]
	public static extern IntPtr ub_server_open_withLog(string addr, int port, IntPtr callback, IntPtr user, string logPath);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "S02")]
	public static extern IntPtr ub_server_udp_open(string serip, int port, IntPtr callback, IntPtr user);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "S03")]
	public static extern void ub_server_close(IntPtr handle);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "S04")]
	public static extern int ub_server_send_info_org(IntPtr handle, IntPtr data, int len, int type = 0);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "S04")]
	public static extern int ub_server_send_bytes_org(IntPtr handle, byte[] data, int len, int type = 0);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C05")]
	public static extern void SocketSettingModeFunc(IntPtr handle, bool hasHeadMode);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "S15")]
	public static extern IntPtr ub_server_openWithBuffSize(string addr, int port, IntPtr callback, IntPtr user, int sendsize, int recvsize);

	[DllImport("SSSTXX.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "C15")]
	public static extern IntPtr ub_client_openWithBuffSize(string addr, int port, IntPtr callback, IntPtr user, int sendsize, int recvsize);

	[DllImport("UMQ.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr umq_open(string logPath, string soPath, bool isServer, string addr, int port, IntPtr callback, IntPtr user, IntPtr sendCB);

	[DllImport("UMQ.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int umq_sendmsg(IntPtr handle, byte[] data, int len, int timeout_ms, int repeatIntervalMs);

	[DllImport("UMQ.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void umq_close(IntPtr handle);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetServerSocketPortByEQIdx(int EQIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool UBClientOpen(int EQIdx, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool UBClientOpenWithSparkServer(int EQIdx, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool UBClientReOpen(int ueIndex)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool UBBroadcastOpen(string localIP, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool UBClientOpenWiFi(string addr, IntPtr callBack, IntPtr user)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void UBClientClose(int iWiFiMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int ub_server_send_info(IntPtr handle, IntPtr data, int len, int type = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int ub_server_send_bytes(IntPtr handle, byte[] data, int len, int type = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int ub_client_send_info(IntPtr handle, string data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int ub_client_send_infoUTF8(IntPtr handle, byte[] data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int ub_client_send_info_binary(IntPtr handle, IntPtr data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public int UBClientSendInfo(string data, int len)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public int UBClientSendInfoUTF8(byte[] data, int len)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public int UBClientSendInfoBinary(IntPtr data, int len)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SGSocketOrg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SGSocketOrg()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 4;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				case 4:
					JclF7kvPUy61dfbwkCW();
					num2 = 3;
					goto IL_0017;
				case 2:
					return;
				case 1:
					UBClientPortBase = 20679;
					num2 = 2;
					goto IL_0017;
				case 5:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					goto IL_0017;
				case 3:
					MtEaOSvNWR719bOchmk();
					num2 = 5;
					goto IL_0017;
				}
				PAcPhBvqNEq8UaKCj8X();
				num2 = 1;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tED7VAvYALx0PCHPS1M(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wxFgcHvjZJNw2quR87a()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SGSocketOrg VkZrKMvM5O3VbASm8vu()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MnC2nWvg7GPq3KrnOhq(int EQIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UNa9igvHCH21Oe4cAbx(int port)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gStayWvS6WvAb2bCu4k()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XhH1nHvD0NuK4Yct45H(int pid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EOXc85vR0MG27K7o1EN(int pid, bool useSparkServer)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sd0Y7svmmsMePBUFI1H(IntPtr handle, object P_1, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int M1s08dvUpjckpYYwc1N(IntPtr handle, object P_1, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int y4P3kov5kmC0h1mUXID(IntPtr handle, IntPtr data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MtEaOSvNWR719bOchmk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PAcPhBvqNEq8UaKCj8X()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JclF7kvPUy61dfbwkCW()
	{
	}
}
