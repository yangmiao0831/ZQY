using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using LibBase;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class KnowyouPlatform
{
	private delegate void sCWswilABQvoclQdvDp(byte[] bytes, int iLen);

	[CompilerGenerated]
	private sealed class cDj2YRnTLy9Ys0KEcv5
	{
		public string neAPSPJWLpa;

		internal static cDj2YRnTLy9Ys0KEcv5 xl3o4cBmwl9lOKdhe4s8;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public cDj2YRnTLy9Ys0KEcv5()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool uHEPSe4iqVj(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static cDj2YRnTLy9Ys0KEcv5()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			bpPwLDBmDaounAxPCKT2();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool seBhZLBmhf3GKecGw5Qw()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static cDj2YRnTLy9Ys0KEcv5 Nl7gegBm44qDPduh93vq()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TxOp4iBmrGKQvbuji2Kw(object P_0, object P_1)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bpPwLDBmDaounAxPCKT2()
		{
		}
	}

	[CompilerGenerated]
	private sealed class bn6kTinwUK2s45e9rJR
	{
		public ATUUploadFileInfo n8hPSyj43fi;

		private static bn6kTinwUK2s45e9rJR SjCqg6BmdgCrKjGvBi4Q;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bn6kTinwUK2s45e9rJR()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool bE2PSEelm2h(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static bn6kTinwUK2s45e9rJR()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			oeICXsBmHZ7FRdIqctum();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oB0hZsBmadwbd5uZbXZ9()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dEifNGBmCfV6WWgbELpU()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bn6kTinwUK2s45e9rJR zsEMHkBmnI7C1p7kmao3()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oeICXsBmHZ7FRdIqctum()
		{
		}
	}

	[CompilerGenerated]
	private sealed class rKIUi4nH005GDT6MeDA
	{
		public ATUUploadFileInfo UaxPSLJwvMJ;

		private static rKIUi4nH005GDT6MeDA Op0GYGBmsTPAr9KqedBJ;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public rKIUi4nH005GDT6MeDA()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IbjPSc6Zqj9(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static rKIUi4nH005GDT6MeDA()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			gPu8HMBm1JcOMwllq3Rn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void y03DcbBmkdIqSckqmffS()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xbVn1iBmlLlBMFB6X3xV()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static rKIUi4nH005GDT6MeDA aoQIuqBm9OMDTpUgrxnG()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gPu8HMBm1JcOMwllq3Rn()
		{
		}
	}

	public const int TLFHeaderSize = 263;

	public const int ERR_UnknownError = 0;

	public const int ERR_NotInit = 1;

	public const int ERR_HasInit = 2;

	public const int ERR_ParamError = 3;

	public const int ERR_NetworkError = 4;

	public const int ERR_NetworkOvertime = 5;

	public const int ERR_DataError = 6;

	public const int ERR_NoMemory = 7;

	public const int ERR_NoAuth = 8;

	public const int ERR_EventTimeError = 9;

	public const int ERR_NetworkDisconnect = 10;

	public const int ERR_NotLogin = 11;

	public const int ERR_LogTimeError = 12;

	public const int ERR_HeadTimeError = 13;

	public const int ERR_FileSizeTooMuch = 151;

	public const int ERRSpark_NoLicenseFile = 65281;

	public const int ERRSpark_InitFail = 65282;

	public const int StatusNotStart = 0;

	public const int StatusUploading = 1;

	public const int StatusFinish = 2;

	public const int StatusFailNormal = 3;

	public const int StatusFailLogTimeError = 4;

	public const int StatusFailHeadTimeError = 8;

	public const int StatusFailNACBoxID = 5;

	public const int StatusFailNACNoResponse = 7;

	public const int StatusFailFileNotExists = 19;

	public const int StatusFailMuchTimes = 20;

	public static bool NeedSetIP;

	public static KnowyouPlatform CurObj;

	public static List<ATUUploadFileInfo> ATURecentInfoList;

	public static int NoResponseTick;

	private byte[] wJWGACCRYm6;

	public List<ATUUploadFileInfo> UploadingInfoList;

	private List<byte[]> Ii8GAGZrHiU;

	private List<byte[]> pgiGARF62gs;

	private object KFbGAnKgrnE;

	protected static int ATUSendGPSTick;

	private MemIniFile kjjGAgURhc6;

	private IniSection NPXGAelD724;

	private string CERGAP1ns12;

	private string cC7GAE6t9Qk;

	private string bJ1GAyKfFsu;

	private bool U4mGAc8tFhy;

	private bool xRMGAL4uY23;

	private bool RdbGAvQXHOw;

	private int FDSGAshKRi2;

	private bool gGqGA6qWdiN;

	private bool diuGAhHymmn;

	private static bool KtHGA1sZE37;

	public static string TipSocketConnectFail;

	public static string TipLoginFail;

	public static string TipIsRunning;

	public static string TipNoConfig;

	public static string TipTaskDownSucc;

	public static string TipTaskDownFail;

	public static string TipTaskParseFail;

	public static string TipNoUEIdx;

	public static string TipNotInTimeRange;

	public static string TipNoResponseWait;

	public static string TipIsNewestTestplan;

	public static string TipBoxIDErr;

	protected int CurADBPortOrgPort;

	private BackgroundWorker AdWGAdBEiuK;

	private List<ATUUploadFileInfo> RsTGAWYKyUa;

	private int r5tGA4dwISa;

	private object hySGANOvkvp;

	public bool IsUploadLogin;

	private StringBuilder pecGAi9RTwu;

	private int WwEGAFAwt9g;

	private static KnowyouPlatform m6O4ZOulI9YuRPWo109n;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KnowyouPlatform()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DebugFileName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFailStr(int iStatus)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadRecentInfoList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool DoMappingADBPort()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SocketIsOK()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SocketReConnect(bool showErr = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveRecentInfoList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ATUUploadFileInfo GetInfoFromRecentList(string sFile)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRunning(bool run)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetRunning()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetRunningUpload()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected int GetATUUESocketOrgPort(int eqIndex)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BPbGqfSK1NV(byte[] P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearUploadingInfoList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasUploadingInfoMS(ATUUploadFileInfo info)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReUploadFiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UploadingTestFileFinished()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DelTestplanXMLWhenFail()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTestPlanVersion()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string qGYGqDWx7ts(string P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DownloadTestplan()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public string GetAllUETestplanJson(ref int iRes)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KPrGqBWYJQ7(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToRecentInfoList(ATUUploadFileInfo info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UploadATUFiles(ATUUploadFileInfo info, bool reUpload)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kjhGqSiSWBt(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VxjGqmcMmG0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yZGGqI2GEtl(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoUploadProtocolEOF(ATUUploadFileInfo info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLoginFailStr(int code = -16777215)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Login()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Logout(bool forceLogout = false, bool needCloseSocket = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string vsaGqQrw6bV(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UploadGPSEventInTest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendGPSInfo(long lTime, double dLong, double dLat, double altitude, double speed, int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendEventInfo(long lTime, int eventCode, int eqIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	private bool PoNGql9HkGb()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	private string JvlGqwIbLmK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eFBGqpAvtYE(ATUUploadFileInfo P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dqTGqa3TqFy(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	private void kO1GqkcitVq(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool FwxGq0BvBCe(ATUUploadFileInfo P_0, int P_1, int P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	private bool WxeGqZiqsOU(ATUUploadFileInfo P_0, int P_1, int P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateTestPlanToSpark(string sFileName, ref bool recvTestplanRes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ATUTaskFullFileName(string boxID)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TJYGqzRlgcL(ATUUploadFileInfo P_0, FileStream P_1, byte[] P_2, int P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static KnowyouPlatform()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 17;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					TipNotInTimeRange = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(122090);
					num2 = 7;
					if (1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					TipNoConfig = (string)tfikM8ul5AE10KIkpJ3N(124392);
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 16:
					Hx02seukJ9SHrwuX3Lif();
					num = 12;
					break;
				case 13:
					return;
				case 2:
					TipTaskDownFail = (string)tfikM8ul5AE10KIkpJ3N(122004);
					num2 = 5;
					continue;
				case 10:
					TipNoUEIdx = (string)tfikM8ul5AE10KIkpJ3N(122038);
					num2 = 3;
					continue;
				default:
					TipTaskDownSucc = (string)tfikM8ul5AE10KIkpJ3N(121982);
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 14:
					TipIsRunning = (string)tfikM8ul5AE10KIkpJ3N(121916);
					num2 = 10;
					if (0 == 0)
					{
						num2 = 11;
					}
					continue;
				case 8:
					TipBoxIDErr = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(122244);
					num2 = 7;
					if (0 == 0)
					{
						num2 = 13;
					}
					continue;
				case 6:
					NoResponseTick = Hsv45YulOdndsd2TlcO1();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 15:
					TipIsNewestTestplan = (string)tfikM8ul5AE10KIkpJ3N(122204);
					num2 = 8;
					continue;
				case 9:
					TipLoginFail = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(124332);
					num2 = 13;
					if (0 == 0)
					{
						num2 = 14;
					}
					continue;
				case 17:
					xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
					num2 = 16;
					continue;
				case 1:
					ATUSendGPSTick = Hsv45YulOdndsd2TlcO1();
					num2 = 4;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					TipSocketConnectFail = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(121842);
					num2 = 9;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 7:
					TipNoResponseWait = (string)tfikM8ul5AE10KIkpJ3N(122170);
					num2 = 15;
					if (true)
					{
						continue;
					}
					break;
				case 5:
					TipTaskParseFail = TipTaskDownFail;
					num2 = 10;
					if (1 == 0)
					{
						num2 = 6;
					}
					continue;
				case 12:
					NeedSetIP = false;
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Hsv45YulOdndsd2TlcO1()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I1Zup2ulXk45bbKuwduk()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static KnowyouPlatform PIm7egulUNAweGH72tR5()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tfikM8ul5AE10KIkpJ3N(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime VQHT6Puli91dSqpBwkKp()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EsV0dPulzbWfXElJX0m4(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F519GJu9L852KDLiYWyK(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vx0DEJu9NbOwOErbGZGd(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VnN3YTu9YwLOc1tpEnXs(object P_0, object P_1, bool reUpload)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vKhoIru9uYmeaNpB3pJ7(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XwFdZhu9y3HVioyLhbiZ(object P_0, bool P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DByLspu96h0dRjwMbQDL(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xeh9dYu9218ZC5cpeq83(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eytPTRu9JYvAIwfQYw95(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TZaaviu9MFA4VAuQnDHS(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XTDhjdu9KmwDqtKjGQfT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DlY319u9ZpYjhZF0h302(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aSD38eu9oKEwcbIvDU4N(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wo1qCEu9xwrYEd3Qt6QV(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R6As5Iu9AXrqCoqa6LTe()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tYFMJnu9tZ7U0TDElhVw(object P_0, UpdateMainWinBoolType P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ukQHbZu9WWyKAPS0yNF9()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mR5JwKu9BoP3mRVZdK0p(object P_0, object P_1, int P_2, int P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aS9LK4u9qj2TjHDdoY3m()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EA84Cqu9Eifnx9h7WPhd(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HQaUZxu9VRTIcQlH4wcB(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fi1j5ku9T8FI4f4nCKBy(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Q2FQrKu9ppLB7gUdlZrH(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ltoIoau9QiwB2q46MmlH(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double RNg3Gwu9R2yDTFDfobJw(object P_0, SizeUnitMode sizeUnitMode)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rryvjuu9GLP3ZaO0m8Rh(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CXEuKZu93Nh5VjEfTchM()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Qbp3Tlu9FnphbvATS0gJ(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hd1Zqau9730EoiqnaTCv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rGJUjHu9bW0Nrk0hhqKm(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lFhA0Du9gMed4sSbeua9()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OmfA8ku9fmkv3vTwbfhh(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wlD6WAu9j06niWhQo4HZ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object znhdOou9eeA1siZoyhCu(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ee1NCdu90DQJBFdMIrLo(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JkBo0Zu9PEewJyIfSnRM(double P_0, sbyte P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qtU5Uuu9ck9pw6G5AdFQ(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KP4yAFu98si7JVqApZw5(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Sj6XyZu9wlBQ1T45mbnd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tbOqwQu9hC9VL4XbDHe9(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zfZY2Ku94GTmKrm13bUH(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr wiXP1Gu9rMVAGa8xJZHq(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oM2xKMu9Dx58SUtcDLHD(IntPtr P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d3ZpcXu9dfsNesp1vZgE(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bu7y4lu9CNjCSNcAwt0l(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FZZrs8u9nl2OhF4c3L3Z(IntPtr P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pW4u8vu9aiusSyBPxBbc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fj4eyau9HWV6x7wJ6k6A(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gh8JWJu9s84UiQ9ZuHhk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CLIA2Nu9lUtidgZ0q2ee(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GLfDtMu99lR37NU7dYtE(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xABXCqu9kd5q2imiljBv(object P_0, long P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W0jofou9172m3Wg4itbE()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gWSvjDu9vReiGN79COFf(object P_0, object P_1, int P_2, int P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long Wj5B8Vu9SIeE6yMvRijl(object P_0, long P_1, SeekOrigin P_2)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ailu4qu9mruLQiRxTtwJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hbXOhMu9ITLRPnoYE0c8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long a5YK8gu9XXHqYY4Om1c5(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NGt1O7u9UU2sxVs2xYfp(object P_0, int P_1, IntPtr P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UOZZPQu9OVLPLM6IOkRu()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OPBP9Uu95FQAMuUKXZBr(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K5qm4ru9it0wVgpu0FB2(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ll0Z3fu9zxhkWL9AQZn8()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WavXeGukLAAaJVVZYqFj(object P_0, object P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QnmPBGukNTvxARL8WGmb(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static short lHhgdvukYYqL4WoRSqMB(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T7jcNQukuuWHjuq90ubK(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte T3HkBdukyFOOWwEFsalf(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kvT8Kwuk6nnXZsQ7q1I2(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ebl3tYuk2oKf5BGpVptc(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hx02seukJ9SHrwuX3Lif()
	{
	}
}
