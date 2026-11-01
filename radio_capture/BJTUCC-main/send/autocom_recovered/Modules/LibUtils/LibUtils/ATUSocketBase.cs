using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibBase;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class ATUSocketBase
{
	protected delegate void ReceiveBuffDelegate(byte[] bytes, int iLen);

	public const int ERRSpark_NoLicenseFile = 65281;

	public const int ERRSpark_InitFail = 65282;

	public const int ERRSpark_LicenseFileNameError = 65283;

	public const int LIB_AMTPA_SUCCESS = 0;

	public const int LIB_AMTPA_IS_WORKING = -101;

	public const int LIB_AMTPA_NO_WORKING = -102;

	public const int LIB_AMTPA_PARA_ERROR = -103;

	public const int LIB_AMTPA_OPEN_LIB_FAILED = -104;

	public const int LIB_AMTPA_VERSION_FAILED = -105;

	public const int LIB_AMTPA_TIMEOUT = -106;

	public const int LIB_AMTPA_QUEUE_EMPTY = -107;

	public const int LIB_AMTPA_MSG_IS_NULL = -108;

	public const int LIB_AMTPA_MSG_LEN_ERROR = -109;

	public const int LIB_AMTPA_SEND_PARA_ERROR = -110;

	public const int LIB_AMTPA_LICENSE_ERROR = -111;

	public const int LIB_AMTPA_MQ_SETUP_ERROR = -112;

	public const int LIB_AMTPA_UNKNOWN_MSG = -113;

	public const int LIB_AMTPA_SEND_ERROR = -114;

	public const int LIB_AMTPA_WAITFORCMD_ERROR = -115;

	public const int LIB_AMTPA_NO_INIT = -116;

	public const int ProtocolTypeLogin = 0;

	public const int ProtocolTypeUploadConfig = 1;

	public const int ProtocolTypeUploadBegin = 2;

	public const int ProtocolTypeUploadDataBuffer = 3;

	public const int ProtocolTypeUploadInfo = 4;

	public const int ProtocolTypeUploadEOF = 5;

	public const int StatusNotStart = 0;

	public const int StatusUploading = 1;

	public const int StatusFinish = 2;

	public const int StatusFailNormal = 3;

	public const int StatusFailNACOther = 4;

	public const int StatusFailNACBoxID = 5;

	public const int StatusFailNACNoResponse = 7;

	public const int StatusFailEOF = 8;

	public const int StatusFailFileNotExists = 19;

	public const int ERR_Normal = 0;

	public const int ERR_Config_Error = 1;

	public const int ERR_Invalid_Device_ID = 2;

	public const int ERR_Unauthorized = 3;

	public const int ERR_Already_Logon = 4;

	public const int ERR_Not_Logon = 5;

	public const int ERR_Unknown_Command = 6;

	public const int ERR_No_Valid_Config = 7;

	public const int ERR_Invalid_Data = 8;

	public const int ERR_Invalid_Packet = 9;

	public const int ERR_File_Open_Error = 10;

	public const int ERR_File_Close_Error = 11;

	public const int ERR_Test_Config_Error = 12;

	public const int ERR_File_Already_Eof = 13;

	public const int ERR_Server_Reject = 14;

	public const int ERR_Server_Error = 15;

	public const int ERR_Miss_Packet = 16;

	public const int ERR_MD5_Error = 17;

	public const int ERR_FileName_Error = 18;

	public const int ERR_Login_150s2Times = 19;

	public const int ERR_Api_Frequently = 20;

	public const int ERR_Unmarshal_Err = 21;

	public const int ERR_Server_Data_Err = 22;

	public const int ERR_Reupload_File = 23;

	public const int ERR_UplaodInfoFail = 500;

	public const int ERR_UploadModuleConfigFail = 501;

	public const int ERR_UploadModuleConfigNoOperator = 502;

	public const int ERR_UploadNoNetwork = 503;

	public const int ERR_WaitRetry = 504;

	public const int ERR_ParseTestplanFail = 505;

	public const int ERR_TestplanFileNone = 506;

	public const int ERR_TestplanIsNewest = 507;

	public const int StatusFailNewBase = 1000;

	public const int StatusFailNew_ERR_Config_Error = 1001;

	public const int StatusFailNew_ERR_Invalid_Device_ID = 1002;

	public const int StatusFailNew_ERR_Unauthorized = 1003;

	public const int StatusFailNew_ERR_Already_Logon = 1004;

	public const int StatusFailNew_ERR_Not_Logon = 1005;

	public const int StatusFailNew_ERR_Unknown_Command = 1006;

	public const int StatusFailNew_ERR_No_Valid_Config = 1007;

	public const int StatusFailNew_ERR_Invalid_Data = 1008;

	public const int StatusFailNew_ERR_Invalid_Packet = 1009;

	public const int StatusFailNew_ERR_File_Open_Error = 1010;

	public const int StatusFailNew_ERR_File_Close_Error = 1011;

	public const int StatusFailNew_ERR_Test_Config_Error = 1012;

	public const int StatusFailNew_ERR_File_Already_Eof = 1013;

	public const int StatusFailNew_ERR_Server_Reject = 1014;

	public const int StatusFailNew_ERR_Server_Error = 1015;

	public const int StatusFailNew_ERR_Miss_Packet = 1016;

	public const int StatusFailNew_ERR_MD5_Error = 1017;

	public const int StatusFailNew_ERR_FileName_Error = 1018;

	public const int StatusFailNew_ERR_Login_150s2Times = 1019;

	public const int StatusFailNew_ERR_Api_Frequently = 1020;

	public const int StatusFailNew_ERR_Unmarshal_Err = 1021;

	public const int StatusFailNew_ERR_Server_Data_Err = 1022;

	public const int StatusFailNew_ERR_Reupload_File = 1023;

	public const int StatusFailNew_LIB_AMTPA_TIMEOUT = 894;

	public const int StatusFailNew_UplaodInfoFail = 1500;

	public const int StatusFailNew_UploadModuleConfigFail = 1501;

	public const int StatusFailNew_UploadModuleConfigNoOperator = 1502;

	public const int StatusFailNew_UploadNoNetwork = 1503;

	public const int StatusFailNew_ERR_WaitRetry = 1504;

	public const int StatusFailNew_ERR_ParseTestplanFail = 1505;

	public const int StatusFailNew_ERR_TestplanFileNone = 1506;

	public const int StatusFailNew_ERR_TestplanIsNewest = 1507;

	public int ATUVersion;

	public static bool NeedSetIP;

	public static object ATUUtils;

	public static List<ATUUploadFileInfo> ATURecentInfoList;

	public static int NoResponseTick;

	protected static int LoginFailTick;

	public bool IsUploadLogin;

	protected bool LoginNeedWait;

	protected int PreLoginTick;

	protected byte[] RecvBuff;

	public List<ATUUploadFileInfo> UploadingInfoList;

	protected List<byte[]> DTLogDataBuffList;

	protected List<byte[]> SendBuffList;

	protected object ATUSendGPSEventObj;

	protected static int ATUSendGPSTick;

	protected static int ATUSendMOSTick;

	protected MemIniFile MemIni;

	protected IniSection Section;

	protected string SessionID;

	protected string BoxID;

	protected string TestplanVersion;

	protected bool NeedUploadModuleConfig;

	public bool UserStop;

	protected bool IsRunning;

	protected bool RecvLoginRes;

	protected bool LoginCverU;

	protected int RecvLoginNACCode;

	protected bool RecvLogoutRes;

	protected bool RecvTestplanRes;

	protected int RecvTestplanCode;

	protected int RecvOtherCode;

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

	protected BackgroundWorker bgWorkerUploadProtocol;

	protected List<ATUUploadFileInfo> UploadProtocolInfoList;

	internal static ATUSocketBase JchsQycq2cnLfwIWor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ATUDebugFileName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ATUTaskFullFileName(string boxID)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFailStrByOldATU(int iReasonCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFailStrByNewATU(int iReasonCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFailStr(int iReasonCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadRecentInfoList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveRecentInfoList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NoNeedUploadAgain(ATUUploadFileInfo info)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToRecentInfoList(ATUUploadFileInfo info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearUploadingInfoList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Logout(bool forceLogout = false, bool needCloseSocket = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool DownloadTestplan()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetAllUETestplanJson(ref int iRes)
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
	public bool HasUploadingInfoMS(ATUUploadFileInfo info)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReUploadFiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UploadATUFiles(ATUUploadFileInfo info, bool reUpload)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void UploadProtocolThread(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateUploadMark(ATUUploadFileInfo info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoUploadProtocolEOF(ATUUploadFileInfo info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoUploadProtocol(ATUUploadFileInfo info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SendGPSInfo(long lTime, double dLong, double dLat, double altitude, double speed, int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SendMOSInfo(long lTime, int eqIndex, double mos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool SocketIsOK()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool SocketReConnect(bool showErr = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UploadingTestFileFinished()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool UploadAllEQModuleConfigAfterConnect()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string GetTestPlanVersion(string fullFileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UploadGPSEventInTest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UploadMOSInTest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ATUSocketBase()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ATUSocketBase()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					ATUSendGPSTick = PInhC7qaQoEUM5YYGJ.QnSQxwQdI(PInhC7qaQoEUM5YYGJ.NbGfaBHjT);
					num2 = 6;
					continue;
				case 10:
					NeedSetIP = false;
					num2 = 19;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 6:
					ATUSendMOSTick = PInhC7qaQoEUM5YYGJ.QnSQxwQdI(PInhC7qaQoEUM5YYGJ.NbGfaBHjT);
					num2 = 22;
					continue;
				case 4:
					EA3ylnhcIPRi1lyeuQ();
					num2 = 16;
					continue;
				case 7:
					NoResponseTick = PInhC7qaQoEUM5YYGJ.QnSQxwQdI(PInhC7qaQoEUM5YYGJ.NbGfaBHjT);
					num = 18;
					break;
				case 17:
					TipBoxIDErr = (string)LcN6hQf6LKh1dxZL98(1514);
					num2 = 0;
					if (true)
					{
						num2 = 15;
					}
					continue;
				case 2:
					TipTaskParseFail = TipTaskDownFail;
					num2 = 14;
					continue;
				case 13:
					TipNoResponseWait = (string)LcN6hQf6LKh1dxZL98(1440);
					num2 = 8;
					continue;
				case 12:
					TipNoConfig = b99vLwQv4vNmPibnHM.iaWRZZUjVH(1228);
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 9:
					TipNotInTimeRange = b99vLwQv4vNmPibnHM.iaWRZZUjVH(1360);
					num2 = 13;
					continue;
				case 11:
					qXTZkY9tbMcXOLrDp5();
					num2 = 10;
					continue;
				case 14:
					TipNoUEIdx = (string)LcN6hQf6LKh1dxZL98(1308);
					num = 9;
					break;
				case 15:
					return;
				case 21:
					TipTaskDownFail = (string)LcN6hQf6LKh1dxZL98(1274);
					num = 2;
					break;
				case 18:
					LoginFailTick = PInhC7qaQoEUM5YYGJ.QnSQxwQdI(PInhC7qaQoEUM5YYGJ.NbGfaBHjT);
					num2 = 0;
					if (0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					TipLoginFail = (string)LcN6hQf6LKh1dxZL98(1164);
					num2 = 3;
					if (false)
					{
						num2 = 3;
					}
					continue;
				case 22:
					TipSocketConnectFail = (string)LcN6hQf6LKh1dxZL98(1112);
					num2 = 20;
					continue;
				case 8:
					TipIsNewestTestplan = (string)LcN6hQf6LKh1dxZL98(1474);
					num2 = 17;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					TipIsRunning = (string)LcN6hQf6LKh1dxZL98(1186);
					num2 = 7;
					if (0 == 0)
					{
						num2 = 12;
					}
					continue;
				case 5:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 16:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 11;
					continue;
				case 19:
					ATUUtils = new object();
					num = 7;
					break;
				default:
					TipTaskDownSucc = b99vLwQv4vNmPibnHM.iaWRZZUjVH(1252);
					num = 21;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LcN6hQf6LKh1dxZL98(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oQc5qxbZi5WXq4PPYB()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ATUSocketBase pPpk5qQcxRyX4aco1r()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bPIYuutLsHtbTsA0f1()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object crYNmi6ajxQUEB4OId(int iReasonCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kyCJnhkd0xvPOptSTK(int iReasonCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J2OLiVp19b1pad1vvX(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lLZ3v14S5SRfVr3Fva(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void afUEgJTu0K0nULQCFx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BsyhFIABPccx9WRdWE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y4jBeyv4Iya0KHj2pn(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bhXjApagpLRnJnYh85(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eheQCEGq7xKQ9hTevx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qXTZkY9tbMcXOLrDp5()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EA3ylnhcIPRi1lyeuQ()
	{
	}
}
