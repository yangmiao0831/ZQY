using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibCoord;

public class HTMOSInterface
{
	public static object RefObj;

	public static int InitRefCount;

	public static string CSConfigINI;

	public static string CSIndexINI;

	private static HTMOSInterface Q8iVYAtYueXEXdyvVGO;

	[DllImport("mos48kcfg.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "mos48kConfigBoard")]
	public static extern int Mos48kConfigBoard(string configini, string indexini);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStartWork(string lpSsmCfgFileName, string lpIndexCfgFileName);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopWork();

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetMaxUsableBoard();

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetMaxCfgBoard();

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetAccreditId(int nBId);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetMaxCh();

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetBoardModel(int nBId);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern uint Mos48KGetSerialNo(int nBId);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KCheckUsbState(int nBId);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetPlayVolume(int ch, int nVolume);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetFS(int ch, int nFS);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetBargeinStopPlay(int ch, bool bBispf);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetBargeinStopPlayFlag(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetDtmfStopPlay(int ch, bool bBispf);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetPlayFile(int ch, string pszFileName, int nFormat, uint dwStartPos, uint dwLen, int Sp_No);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopPlayFile(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStartPlay(int ch, int Sp_No);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopPlay(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetPlayedTime(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetPlayedPercentage(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetDataBytesToPlay(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetDataBytesPlayed(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KCheckPlay(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopPlayMem(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopPlayMemBlock(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetRecVolume(int ch, int nVolume);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KRecToFile(int ch, string pszFileName, int nFormat, uint dwStartPos, uint dwBytes, uint dwTime, int nMask);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopRecToFile(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KChkRecToFile(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetRecTime(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetDataBytesToRecord(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KCheckRecord(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopRecToMem(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KStopRecordMemBlock(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetNoSoundDtrmTime(int ch, uint dwIsNoSoundDtrTime);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetNoSoundDtrmTime(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetIsBargeInDtrmTime(int ch, ushort wIsBargeInDtrmTime);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetIsBargeInDtrmTime(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetBargeInSens(int ch, int nBargeInSens);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetBargeInSens(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetNoSoundTime(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KDetectBargeIn(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KDetectNoSound(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetMaxIdxSeg(int max_idx);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern void Mos48KGetLastErrMsg(ref string szErrMsgBuf);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetLastErrCode();

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetRecOffset(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KSetRecAGC(int ch, bool bEnable);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern int Mos48KGetRecAGCState(int ch);

	[DllImport("mos48kal.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	public static extern ushort Mos48KGetVersion();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HTMOSInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HTMOSInterface()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 8;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					CSConfigINI = (string)LbbSeOtRiBmvQyhwh6h(11324);
					num = 4;
					break;
				default:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 5;
					if (1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					return;
				case 5:
					Ohcgg1tDVQwd89s6xbD();
					num2 = 6;
					continue;
				case 1:
					InitRefCount = 0;
					num2 = 3;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					CSIndexINI = (string)LbbSeOtRiBmvQyhwh6h(11360);
					num2 = 2;
					continue;
				case 7:
					dTvWWntSkJKC0xnGML6();
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 8:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 7;
					continue;
				case 6:
					RefObj = new object();
					num2 = 1;
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
	internal static bool uWn4KftgmXfkZwNREjO()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HTMOSInterface Pm7XgktHPHPDNkFkbui()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dTvWWntSkJKC0xnGML6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ohcgg1tDVQwd89s6xbD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LbbSeOtRiBmvQyhwh6h(int P_0)
	{
		return null;
	}
}
