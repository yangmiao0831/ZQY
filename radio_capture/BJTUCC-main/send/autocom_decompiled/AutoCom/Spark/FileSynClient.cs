using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class FileSynClient
{
	private delegate void ThY9js9CdJr8mpKWhAq(FileSynCmd cmd);

	public const int ProtocolPort = 30998;

	public const int DataTranPort = 30997;

	public static string ServerIp;

	public static int CISucc;

	public static int CIFail;

	private static IntPtr NaOPXYTLmR5;

	private static SGSocket.SocketCallbackDelegate uNNPXHKkhK9;

	private static IntPtr tpePX34Sj1A;

	private static SGSocket.SocketCallbackDelegate hn6PXJuIgqT;

	private static FileStream VZCPXrjZH3h;

	private static FileSynFileInfo ROqPX9CYQVV;

	private static bool vnxPX8PpqDw;

	private static string xvOPXUhacTB;

	private static bool O4NPXKpQr6s;

	public static long mSendSize;

	private static FileSynClient FcFIdAWkDwEQ0K8uNsg2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CreateSocket()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CreateDataTranSocket()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetStateCode(bool bSucc)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void yLAPXXy6pJL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void yk9PX2eYdve()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DJAPXOd8t5e()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void wbPPXMiAgFl(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void slwPX5823YK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string NijPXTdyjfH()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void EjrPXxQYBa0(IntPtr P_0, IntPtr P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void QpGPXqjrXnk(IntPtr P_0, IntPtr P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SendReply(string s)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void V9nPXAnw0Qe(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetPathInfoJson(int pos, int count)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UploadClientRequest(FileSynFileInfo fileInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendStopUpload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendDeleteFiles(List<FileSynItem> fileList)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FileSynClient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FileSynClient()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					O4NPXKpQr6s = false;
					num2 = 8;
					if (false)
					{
						num2 = 0;
					}
					continue;
				case 1:
					ROqPX9CYQVV = null;
					num2 = 13;
					continue;
				case 10:
					VZCPXrjZH3h = null;
					num2 = 1;
					if (1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					njKHWnW1AwNFThGIIYVa();
					num2 = 6;
					if (false)
					{
						num2 = 0;
					}
					continue;
				case 6:
					yFLduiW1tIKiYPvN6FXo();
					num2 = 12;
					if (true)
					{
						continue;
					}
					break;
				case 8:
					mSendSize = 0L;
					num2 = 11;
					if (false)
					{
						num2 = 9;
					}
					continue;
				case 5:
					CISucc = 0;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				default:
					CIFail = -1;
					num2 = 3;
					continue;
				case 13:
					vnxPX8PpqDw = false;
					num2 = 4;
					continue;
				case 4:
					xvOPXUhacTB = "";
					num2 = 9;
					continue;
				case 12:
					ServerIp = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(546504);
					num2 = 0;
					if (true)
					{
						num2 = 5;
					}
					continue;
				case 3:
					uNNPXHKkhK9 = null;
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					hn6PXJuIgqT = null;
					num2 = 10;
					continue;
				case 11:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eWPbyqWknCpcQcKMkTQY(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h0n9wOWkaqiM8fX0UdDX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KCYIniWkH9BGae4GYCjr()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr llNURZWksuy5pXkT8cHO(object P_0, int P_1, IntPtr P_2, IntPtr P_3, bool P_4, object P_5)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ykuAhEWklGeGf6YEnpHx(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool POWVZxWkdBqdIAuHhVGO()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FileSynClient AqINNHWkCCb4DeGTYHN0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void chZRJlWk9kojvtCSFW4m(IntPtr P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tfZxYLWkkTRkuUwkZdaB(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C6LXTVWk149fJpeBOSIH(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nTlcmxWkvpto59bvna9I()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vkp35DWkSt2yy4IgO0UR(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tUnSrwWkmmhSHYkc2uXA(object P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CJMDpbWkIS4JOISkahRv(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DLON8BWkXPQ6rq9wUZv9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PZDrtdWkUe3XIJ5IWPVb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UHWgIxWkOMgclYTe5TAh(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CyrtgwWk57EebyYDCaPU(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VxumbSWki2cONOpVFtm3()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cyPuTFWkzWX8JqrecbOS(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DRhvvIW1L20Z0UlyGtSf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AddressFamily b1SBZ3W1NrFp6s8qCt77(object P_0)
	{
		return (AddressFamily)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hvpCvAW1YNgeRgZOrQaq(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H7ly2PW1uXYpqwkMANIA(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YMs4LyW1y9rmNniXyRfK(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hhlwHiW16Pnna6MvmddQ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qj8em7W12uClYrZ7hKe3(IntPtr P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Gb4eVIW1JfvyKQamlWYN(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Mxmmq8W1Mvs3AxsnSbEn()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RPEDTbW1KF234lndceaY(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LEUsrLW1ZJrWWIIVqfvr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y1dTgQW1oFaWUBxJONDE(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HAfrw6W1xpMXJSpNlsht(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void njKHWnW1AwNFThGIIYVa()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yFLduiW1tIKiYPvN6FXo()
	{
	}
}
