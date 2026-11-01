using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using VeZr0GvFeaMRlEIhHS;
using wDVvxYYcyxdvVsBwKm;

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

	private bool reA7HADar8;

	protected byte[] TmpIntPtrToBytes;

	internal static SparkSocketBase PinGylEAO9UUUWg1Jc4;

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
	private void cqA7PYX2dj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void N6S7pFqGYB(IAsyncResult P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qLp70vREgE(byte[] P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Eo37vrnBfV(byte[] P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool W267GsihUt(byte[] P_0, int P_1)
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
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					uOv0OU0Kme5HKTDMBO.vljRbPazYJ79B();
					num2 = 5;
					continue;
				case 2:
					ProtocolHeadBytes = fYGGQtQZys69vsH21jS.QnSQxwQdI(KGojlMQfew6RxqhU91N.QnSQxwQdI(KGojlMQfew6RxqhU91N.nV1Q3LeucL), (string)L42dawEGKMAPA2Oc6hv(9490), fYGGQtQZys69vsH21jS.qZCQPerBOK);
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					OPoEumEBRqIgLHRsx9H();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					return;
				case 4:
					XD2Gc1EZJTioJatJPTq();
					num2 = 3;
					continue;
				default:
					FQq7i4E7mMKEZYyRVWm();
					num = 6;
					break;
				case 5:
					DefEncoding = at5TI5YzjA1SX68MLfZ.QnSQxwQdI((string)L42dawEGKMAPA2Oc6hv(9474), at5TI5YzjA1SX68MLfZ.rU0sVmxp6y);
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fPmK6pEvNbFhUGPW3Oy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SparkSocketBase epdtNZEauOUbGZZaUO6()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L42dawEGKMAPA2Oc6hv(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int g3SsCOE92x4w4KakeiJ(object P_0, object P_1, int idx, int count, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nI9mTGEh5cGALpHc0dF(object P_0, object P_1, int index, int count, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OPoEumEBRqIgLHRsx9H()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j6snDRELkgDNI1Aruoj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XD2Gc1EZJTioJatJPTq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FQq7i4E7mMKEZYyRVWm()
	{
	}
}
