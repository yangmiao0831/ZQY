using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using EhWfrCHt8CgdGjRCLj3;
using LibBase;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class CUPlatform
{
	private delegate void BUMq5hl1Vmg0QxdfcNi(byte[] bytes, int iLen);

	[CompilerGenerated]
	private sealed class D02nqlnkrWkBYjPEhMZ
	{
		public ATUUploadFileInfo K6TPSCsU5GN;

		private static D02nqlnkrWkBYjPEhMZ DJrKAtBmpEw6M0x7uMsr;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public D02nqlnkrWkBYjPEhMZ()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool UWWPBz2R6Gx(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static D02nqlnkrWkBYjPEhMZ()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			SwICGYBm3DwxMlwFO1D4();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qfPbXsBmGsdHuLJAhdQ7()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FbDeUKBmQamqCWPwpjfd()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static D02nqlnkrWkBYjPEhMZ DvvLUuBmRodTbGfoEGMl()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SwICGYBm3DwxMlwFO1D4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class ym9JipnPVZ9K5xGZUrV
	{
		public ATUUploadFileInfo lQkPSRhsSOw;

		internal static ym9JipnPVZ9K5xGZUrV Ntr8KMBmFTI2vcXFIrGS;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ym9JipnPVZ9K5xGZUrV()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ycPPSGpU5cU(ATUUploadFileInfo t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ym9JipnPVZ9K5xGZUrV()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void e7QU8DBmgHvPgj6dcX3j()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w4Tuk6Bm7DLGiaqZVs61()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ym9JipnPVZ9K5xGZUrV kophkeBmbROYuHNiUWPn()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KrdZo1BmfaC0TUxmXnIu(object P_0, object P_1)
		{
			return true;
		}
	}

	public const int CUHeaderSize = 228;

	public const int ProtocolTypeLogin = 0;

	public const int ProtocolTypeUploadConfig = 1;

	public const int ProtocolTypeUploadBegin = 2;

	public const int ProtocolTypeUploadDataBuffer = 3;

	public const int ProtocolTypeUploadInfo = 4;

	public const int ProtocolTypeUploadEOF = 5;

	public const int StatusFailNewBase = 1000;

	public const int StatusReLogin = 1004;

	public const int StatusNotStart = 0;

	public const int StatusUploading = 1;

	public const int StatusFinish = 2;

	public const int StatusFailNormal = 3;

	public const int StatusFailNACOther = 4;

	public const int StatusFailNACBoxID = 5;

	public const int StatusFailNACNoResponse = 7;

	public const int StatusFailEOF = 8;

	public const int NoNetwork = 9;

	public const int StatusFailFileNotExists = 19;

	public static bool NeedSetIP;

	public static CUPlatform CurObj;

	public static List<ATUUploadFileInfo> ATURecentInfoList;

	public static int NoResponseTick;

	private byte[] gE0GTDp0iiE;

	public List<ATUUploadFileInfo> UploadingInfoList;

	private List<byte[]> tsLGTBSCTdQ;

	private List<byte[]> zWxGTS0JIlL;

	private Socket l4rGTmOqHZ8;

	private MemIniFile xj7GTIaXS0N;

	private IniSection ylIGTQxHYaY;

	private string rSjGTlqSR1K;

	private string QkmGTw5F4Wx;

	public bool UserStop;

	private bool la7GTpaMqCU;

	protected bool RecvLoginRes;

	public int RecvNACCode;

	private bool qu4GTagYBxY;

	private bool bl5GTkeoF4r;

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

	private static int PqbGT0IiLAD;

	protected int CurADBPortOrgPort;

	private bool G8rGTZQ93lN;

	private bool OJUGTzlVMvS;

	private BackgroundWorker nSnGxCDUu7k;

	private List<ATUUploadFileInfo> XDvGxG2Lk18;

	private object AI6GxRaXWPn;

	public bool RegisterErrHasShow;

	public bool IsUploadLogin;

	private bool gj6GxnPYelk;

	private ATUUploadFileInfo XinGxgxkbHN;

	private static string xVLGxeS555i;

	private int wsHGxPXiesY;

	private int tvsGxEonWJw;

	private static CUPlatform sTienmuaFh2LQwDF5Lmv;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CUPlatform()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DebugFileName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DebugSelf(string fileName)
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
	public void PingWeb(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SocketReConnect(bool showErr = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fvoGTXpJI7Z(IAsyncResult P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yaVGT23Ho4q()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool smkGTOMr8cx(byte[] P_0, int P_1)
	{
		return true;
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
	public static bool NoNeedUploadAgain(ATUUploadFileInfo info)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iqyGTMsCy6X(ATUUploadFileInfo P_0, int P_1 = 1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UyIGT5CScdZ(ATUUploadFileInfo P_0)
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
	private void ML5GTTA3amQ(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NIjGTxqFDLL(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool DoUploadATUInfo(ATUUploadFileInfo info)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDeviceID()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DeviceRegister()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Login(bool isStartTest = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Logout(bool forceLogout = false, bool needCloseSocket = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string APoGTqiW3T9(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string yv6GTAF2jDJ(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string PNqGTY336Pi(long P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string XISGTHURht4(long P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UploadFile_StartTest()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UploadFile_EndTest(string startTestKey = "")
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IpEGT3Z9VEi(ATUUploadFileInfo P_0, bool P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void y5oGTJ3Jj3G(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CSYGTrFpqFs(ATUUploadFileInfo P_0, string P_1, long P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool uM0GT9N6K7Y(ATUUploadFileInfo P_0, string P_1, long P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string UbLGT8PXbOw(ATUUploadFileInfo P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetKeyInfoByName(string fileName, int eqIndex, bool useCurTime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BuildStartTestKeyByName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doqGTUE5OpE(object P_0, DoWorkEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HjMGTKiwWGl(ATUUploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool dL1GTti9foE(ATUUploadFileInfo P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vW2GTu9ZHYS(byte[] P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void s5NGToFMRB3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CyiGTjHpk38(IAsyncResult P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool hknGT7WL7oR(string P_0, bool P_1 = true, string P_2 = "")
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ATUTaskFullFileName(string boxID)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string JtyGTfUrtEf(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFailStr(int iCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CUPlatform()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 14;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
					num2 = 13;
					continue;
				case 13:
					no51tBHZ35yMyaa8WrU.FTtBuvSzFjHhG();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 10:
					TipIsRunning = (string)vGRwYNua0L1ZNN5qq3dh(124352);
					num2 = 1;
					if (true)
					{
						num2 = 4;
					}
					continue;
				case 6:
					TipTaskParseFail = TipTaskDownFail;
					num2 = 3;
					continue;
				case 11:
					NoResponseTick = l8btBluafOEyWSPoJnCS();
					num2 = 15;
					if (false)
					{
						num2 = 4;
					}
					continue;
				case 8:
					TipNoResponseWait = (string)vGRwYNua0L1ZNN5qq3dh(122170);
					num2 = 12;
					if (false)
					{
						num2 = 4;
					}
					continue;
				case 2:
					TipNotInTimeRange = (string)vGRwYNua0L1ZNN5qq3dh(122090);
					num2 = 8;
					if (false)
					{
						num2 = 0;
					}
					continue;
				case 17:
					TipLoginFail = (string)vGRwYNua0L1ZNN5qq3dh(124332);
					num2 = 10;
					if (true)
					{
						continue;
					}
					break;
				case 16:
					TipBoxIDErr = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(124436);
					num2 = 9;
					continue;
				case 5:
					return;
				case 12:
					TipIsNewestTestplan = (string)vGRwYNua0L1ZNN5qq3dh(122204);
					num = 16;
					break;
				case 9:
					PqbGT0IiLAD = l8btBluafOEyWSPoJnCS();
					num2 = 5;
					if (0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					TipNoUEIdx = (string)vGRwYNua0L1ZNN5qq3dh(122038);
					num2 = 2;
					continue;
				case 7:
					TipTaskDownSucc = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(121982);
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					TipTaskDownFail = (string)vGRwYNua0L1ZNN5qq3dh(122004);
					num = 6;
					break;
				case 15:
					TipSocketConnectFail = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(121842);
					num2 = 17;
					continue;
				default:
					NeedSetIP = true;
					num2 = 11;
					continue;
				case 4:
					TipNoConfig = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(124392);
					num = 7;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l4irJBuagKwxPqT0MLUT()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int l8btBluafOEyWSPoJnCS()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VxXL5yuajtftJdoqWfua(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g6gYXVuae2Q2iRwmPhPr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NIaAPPua7kcatulmONqM()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CUPlatform kFAlLouabjN3MKAwdLKM()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vGRwYNua0L1ZNN5qq3dh(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime XLYq7XuaPBjZvjYhggyN()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O6WBNQuacho9g7M1RGDa(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UrsqdCua8hvgvwxJVNEK(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ceVTEuuawW4PQX6mxgpV(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GCBsEWuahiep3xWwRAW3(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e87On2ua4mdM9cZ6IosR(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HXkGGfuar2343tF5OqQ3()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool n6oOH3uaDSs5ghKgUbU7()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tgBdjruad4KZVxp3ZNUk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GZlL62uaC8mJj2aNubSj(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OKaJeEuan1jkq4DgKtj4(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object coEtXEuaaVvrdieMXfhY(object P_0, object P_1, int P_2, object P_3, object P_4)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bLaQ8DuaH7knLBJiV4de(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n7B2fPuasoldaQhLVp1V(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mZ1ZWcualKHWYgqdGrsy(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NvKjYWua9s76RU00x8r4(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WNJnnPuakQkSFsc0wdBq(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void np3yeaua1711MlRAtUVh(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QGVh7Zuav2tioXDAR4IW(object P_0, object P_1, int P_2, SocketFlags P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VmNYB9uaSGjrkrbu5fZg(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BhG9xFuamDQYeckShvBA(object P_0, object P_1, bool reUpload)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CYw2PPuaIfUy1aCOm7Ka()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y0gCnQuaX19H7HEmRjBp(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gCnJx1uaUHwHdNiCdVVX(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gXrClJuaODgNcrTCKC6n(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LkDq4Iua5uK1w86DgASy(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cQVDvhuaiwdsJQfEcaXn(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yKG7lFuaz1rlh71dfnoW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double eiAI2uuHLcnxKxCaIvu2(object P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tlimf9uHNnKTTYKSofMi(object P_0, object P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cnWHjFuHYRAJ8tJd9Dbh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GtvOqtuHuAVxRN7FY2bM(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S4IdguuHybXVC5EdEkG8()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eO1RA5uH6FuCcy22e00g()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rJKktZuH2h7N9ptB0fGn(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FhClSNuHJherSh8BrFnv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ev0kJPuHM98mmMo1aqmg()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nm8ZMAuHKt9D2b9LnfKH(object P_0, UpdateMainWinBoolType P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jIddvKuHZxFEP8ftbIQR(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nlct2xuHoSIJog1BiiEd(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EXoyhxuHxOMUY8UB3CLU(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long WCiuLsuHAWgecDVknhMk(DateTime P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object syHqtjuHtQnsEXo7DMeq(double P_0, sbyte P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ky6196uHWFI0g0AGRo0W()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GwI3aauHB2f3J3EcRYLT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wJwXgguHqFgWUDuZP0bR(object P_0, object P_1, float P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ayq2V7uHEGLtJXVx5bBh(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr SnFt7duHV0rhJCWxTZlc(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y3xq2GuHTLo8T77UxMoT(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kE0RGnuHpRmtf4BwCghX(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double EGnbx8uHQ9PbxnZyt7uZ(object P_0, int P_1, object P_2, object P_3)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ENRR9CuHRDF4FovcmVAm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long VfW4J3uHGE5hYyVIyOJH(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double hP84KAuH31s3TjNqxp5c(object P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long KEnf6fuHFAXwxQhIlTFN(long P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aUZLiUuH7Lx9cd5pNeDs(object P_0, long P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y4ybZkuHbkl9fvNI5I6B(object P_0, int eqIndex, bool useCurTime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b5jKi3uHgeIcOOYxbV7R(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ptiqEYuHffCRL7RmqnbQ(object P_0, object P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int v8PGqAuHjZtqF40QMEPt(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XJmCqYuHepMCTaGVAA7u(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gDCX9RuH0DigKRrDNvXk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YQ8QkTuHPeigL3mxoMKJ(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long dEKt9auHcEHMQQai1ppO(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F9IAKCuH8cZDaE6GU3fV(object P_0, long P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long TWcOn7uHwjDbw4lsJ6Pw(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JDGDY7uHhJEHDxopgKpa(object P_0, object P_1, int P_2, int P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ELTJBWuH4o8bSScoL9v5(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YWhx6cuHrRbNLvaLn2UV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint oXS7sYuHDJHpq4ySguQl(object P_0, int P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static short sPB2duuHdl7asVu2N0XP(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object moL7pQuHCsg0t5B3eVoV(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SC2PEyuHn8uEOUvdYgVo()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lNda2CuHakcVgiXHRnoD(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RBs4wQuHHdCGIjDKbr4n(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D4H99uuHsl9I8e9JxQFD(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lgZwcDuHledvDtSZFJQl(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gFCPh8uH9upnYmObBUu8(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LwfLT6uHk50img6GqAoC(object P_0, object P_1, int P_2, int P_3, SocketFlags P_4, object P_5, object P_6)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int R58oBBuH15ietELgormN(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sGcuFUuHvtxMPofgFPhC(object P_0, object P_1, int P_2, int P_3, SocketFlags P_4)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cNQjNSuHStmIBVQOpxdw(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DVKJuwuHmeVrLSYGDw2x(object P_0, object P_1)
	{
		return null;
	}
}
