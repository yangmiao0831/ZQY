using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using P8RhegOFKTh50li8vF;
using anP38G93Hn1djcqrnY;

namespace LibUtils;

public class SparkSocketBase
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public delegate void SparkSocketCallbackDelegate(byte[] bytes, int index, int count, int type);

	public static Encoding DefEncoding;

	protected Socket FSocket;

	protected int SendBufferSize;

	protected int RecvBufferSize;

	protected bool IsBroadcast;

	public static Dictionary<string, IPEndPoint> BroadcastEndPointDict;

	public static SparkSocketBase BroadcastSparkSocket;

	protected static byte[] ProtocolHeadBytes;

	protected int PacketIndex;

	protected string IP;

	protected int Port;

	public bool Connected;

	protected SparkSocketCallbackDelegate SparkSocketCallbackDel;

	protected bool IsDoingCallbackDel;

	protected object LockObj;

	protected int CurPos;

	protected int CurLength;

	protected byte[] RecvBuff;

	protected byte[] TmpSendBytes;

	private bool oCbibDBdk1;

	protected byte[] TmpIntPtrToBytes;

	internal static SparkSocketBase t4Z3PspF1FoaIZJQcCf;

	public bool HasHeadMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitHeadModeVars(bool hasHeadMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void WriteDebugLog(string sLog, bool forceLog = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBufferSize(int sendBuffSize, int recvBuffSize)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Send(string s)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SendWithBroadCast(string sReq)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Send(IntPtr data, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int Send(byte[] bytesOrg, int idx, int count, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckBytesBufferSize(ref byte[] bytes, int newLen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected byte[] IntPtrToBytes(IntPtr intPtr, int len)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool HeadEqual(byte[] bytes, int iPos)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> ParseJsonCmd(byte[] bytes, int iLen)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DoSocketReceive(Socket socket)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void poOzpTMZx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void U1Vid4q9k3(IAsyncResult P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void H7riisMnPh(byte[] P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void V1tiuDnslo(byte[] P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TATiWna6ti(byte[] P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SparkSocketBase()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SparkSocketBase()
	{
		Seo3omgfrcFXY10d00.AvviRHPjVq();
		int num = 5;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				default:
					return;
				case 2:
					DefEncoding = YU2v8FE1H0Dq1c789q7.a5rQbCd1q((string)olhtXipprVPZEtVw80R(2700), YU2v8FE1H0Dq1c789q7.mmpEjAewoc);
					num2 = 3;
					goto IL_0017;
				case 5:
					SHk3ykpHYI8oS8eVb1Z();
					num2 = 4;
					goto IL_0017;
				case 4:
					ah8dJop1cK75sny5Rbt();
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					goto IL_0017;
				case 0:
					return;
				case 3:
					ProtocolHeadBytes = BTu1EO68Pf8eBWo9Xc.a5rQbCd1q(YPSolKXGgEifKnop08.a5rQbCd1q(YPSolKXGgEifKnop08.QlrQzUDk2v), (string)olhtXipprVPZEtVw80R(2716), BTu1EO68Pf8eBWo9Xc.UtEZDsgpk);
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					goto IL_0017;
				case 1:
					break;
				}
				DqwQdc0NohRwOW45rP.WZoxn8yz6qd3R();
				num2 = 2;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c3SvScpCVNmZoTnBD6u()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SparkSocketBase LEei3qpWp0jhee128Un()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object olhtXipprVPZEtVw80R(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ednS8Hp0KGAyAmo2JwF(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vjs4xapgy6QxFx9b090(object P_0, object P_1, int idx, int count, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BwgTYWptQdxWgZDnD1f(object P_0, object P_1, int index, int count, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aphmKLpG0ltxdwsSHLO()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SHk3ykpHYI8oS8eVb1Z()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ah8dJop1cK75sny5Rbt()
	{
	}
}
