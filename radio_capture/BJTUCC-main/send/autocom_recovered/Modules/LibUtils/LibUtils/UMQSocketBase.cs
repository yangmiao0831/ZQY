using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class UMQSocketBase
{
	public delegate void SENDCALLBACKDelegate(IntPtr user, int key, int ack);

	public SparkSocketBase SparkSocket;

	public bool mIsServer;

	protected bool mIsFinish;

	protected bool mSocketIsOkay;

	protected CHeartUnit mHeartUnit;

	protected object mSendLock;

	protected object mCallBackLock;

	protected object mCmdMapLock;

	protected SparkSocketBase.SparkSocketCallbackDelegate socketCallbackDelegate;

	protected SparkSocketBase.SparkSocketCallbackDelegate mRecvCB;

	protected SENDCALLBACKDelegate mSendCB;

	protected int mKey;

	protected Dictionary<int, DSendElement> mCmdMap;

	private DSendHead b3f75SnCOg;

	private byte[] iWO7tJ8ZxD;

	private static UMQSocketBase iLuDJtEgDVFZCX0FDva;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UMQSocketBase()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void WriteDebugLog(string sLog, bool forceLog = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected int ProduceKey()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReconnectServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Close()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendHeartFromClient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IntPtr eCm7dJSRIj(DSendHead P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrivateAsyncSend(string msg, int len, ECmdType type, int dataKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckBytesBufferSize(ref byte[] bytes, int newLen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrivateAsyncSend(byte[] msgBytes, int len, ECmdType type, int dataKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual int SendMsg(byte[] tmpBuf, int index, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DealLoopSend()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DealRepeatSend()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AsyncSendMsg(byte[] msg, int len, int timeoutms, int repeatIntervalMs)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DealDataCB(byte[] data, int index, int len, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InnerSendBack(IntPtr user, int key, int ack)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SocketCallback(byte[] data, int index, int len, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void Of77EIkWTe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UMQSocketBase()
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
				default:
					return;
				case 2:
					break;
				case 1:
					BglmmWEVKpDbHJv2Ukd();
					num2 = 3;
					goto IL_0017;
				case 3:
					qOMLT2EXHncxkLdAdMh();
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					goto IL_0017;
				case 0:
					return;
				}
				T1QbnZElY4bmbT1O6OC();
				num2 = 1;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dnOOU9EDPekdlV782QG()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VdquejEHbOdFHnxa72M()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UMQSocketBase L8SunvESEnxYr0IfOS8()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bHAiFhERleC5oi98m8L(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nH3nXHEm0wUShJiZB1b(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fxkpVyEUqHTw0eUqOOn(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool llDn0HE5JrIuuhhClkP(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Inc0n6ENljGEumtayZO(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mubXhhEqehdFwhTLlqd(object P_0, object P_1, int index, int len, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int p6IAYLEPNMeKOOiP46l(object P_0, object P_1, int idx, int count, int type)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CHsVRQE0nPXGomDkrNU(object P_0, object P_1, int index, int count, int type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WAKZ6FEuABTis3fjBkT(object P_0, IntPtr user, int key, int ack)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T1QbnZElY4bmbT1O6OC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BglmmWEVKpDbHJv2Ukd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qOMLT2EXHncxkLdAdMh()
	{
	}
}
