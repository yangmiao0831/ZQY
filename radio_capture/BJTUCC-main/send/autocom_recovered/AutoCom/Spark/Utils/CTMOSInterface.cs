using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark.Utils;

public class CTMOSInterface
{
	public const string CICompany = "wansiwei";

	public const string CIProduct = "spark";

	private static string tQke72ADZUn;

	private static string sxAe7OQo6XU;

	private static string nGse7ME4odf;

	private static string vuke75cRdSF;

	private static string fFRe7TbfCkR;

	private static string hH0e7xxapkZ;

	public static object CTMOSLockObj;

	public static int CTMOSRefCount;

	private static string Brve7qbuU7c;

	private static CTMOSDLLGetLicenseInfoObj Y5Re7Ab17sv;

	private static CTMOSGetLicenseResult BDae7Y2jKuq;

	private static CTMOSGetTokenResult mkVe7H4i8Za;

	private static string MXne73Rpx7O;

	public static bool GetLocalMOSInterrupt;

	private static bool vXQe7JdMlmd;

	private static string MHbe7rQQ5Wd;

	private static string B9oe792fhen;

	public static bool NeedReInitVars;

	private static CTMOSInterface pAM6SjAUlsrsCfFKadJJ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetLocalMOS(string filePath)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double prXe7sKUkPE(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool PYLe76ISxv0()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string bgQe7hsrY5M()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double UploadAndGetMOS(string filePath)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DoUploadWave(string filePath, PolqaEvent polqaEvent = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double DoGetMOSScore(string md5)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ReInitVars()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DoReInitVars()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool BpLe71nhKYR()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool hOUe7d10fF3()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool hnHe7Wnmk7q()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool Slre74pxvIh()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool pooe7NUu6Bf()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string WFBe7isKWfH(object P_0, object P_1, bool P_2 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool w1Fe7FEsTcw(int P_0, object P_1, object P_2)
	{
		return true;
	}

	[DllImport("MosHelper.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "CheckLicense")]
	private static extern int VBYe7bBm3DF(string P_0, string P_1, string P_2);

	[DllImport("MosHelper.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "GetLicenseApplication")]
	private static extern int QwYe7VOYYco(string P_0, string P_1, IntPtr P_2, ref int P_3);

	[DllImport("MosHelper.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "GetLicenseApplicationWithJson")]
	private static extern int aPie7XN5aWp(string P_0, string P_1, IntPtr P_2, ref int P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CTMOSInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CTMOSInterface()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 10;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					sxAe7OQo6XU = (string)rGMBPaAOFp5S0trR344G(QJtNCkAU1UG7G7bLWJQ1(512994), tQke72ADZUn);
					num2 = 6;
					if (true)
					{
						continue;
					}
					break;
				case 14:
					CTMOSRefCount = 0;
					num2 = 7;
					if (1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					GetLocalMOSInterrupt = false;
					num2 = 4;
					continue;
				case 8:
					MHbe7rQQ5Wd = (string)F7v5n8AONdNeossjbY8k(ConstUtils.ResTempPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(513402));
					num2 = 11;
					if (true)
					{
						continue;
					}
					break;
				case 6:
					nGse7ME4odf = (string)rGMBPaAOFp5S0trR344G(xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(513116), tQke72ADZUn);
					num2 = 12;
					continue;
				case 4:
					vXQe7JdMlmd = false;
					num2 = 3;
					if (true)
					{
						num2 = 8;
					}
					continue;
				case 9:
					jmnwS4AO1ZY95nqcghOb();
					num2 = 5;
					continue;
				case 11:
					return;
				case 13:
					CTMOSLockObj = new object();
					num2 = 14;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 12:
					vuke75cRdSF = (string)rGMBPaAOFp5S0trR344G(QJtNCkAU1UG7G7bLWJQ1(513234), tQke72ADZUn);
					num2 = 0;
					if (true)
					{
						num2 = 3;
					}
					continue;
				case 5:
					tQke72ADZUn = (string)QJtNCkAU1UG7G7bLWJQ1(512950);
					num2 = 0;
					if (true)
					{
						num2 = 1;
					}
					continue;
				case 7:
					MXne73Rpx7O = (string)F7v5n8AONdNeossjbY8k(ConstUtils.SparkPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(59414));
					num2 = 2;
					if (1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					fFRe7TbfCkR = string.Format(xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(513290), tQke72ADZUn);
					num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					continue;
				default:
					hH0e7xxapkZ = (string)rGMBPaAOFp5S0trR344G(QJtNCkAU1UG7G7bLWJQ1(513342), tQke72ADZUn);
					num2 = 13;
					continue;
				case 10:
					ecQaQNAOvQtdeYGHqYiU();
					num2 = 9;
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
	internal static object QJtNCkAU1UG7G7bLWJQ1(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YcfGa0AUvkWI5iWJ5rSk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BEtQ41AUSxcd76kiclvW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eTnlFsAUmIk2VMqpeMJp(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OXlL9LAUIO9KXUi836BF()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UtywmhAUXp8OaTryCnga(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Grx2JqAUUQuQDDI4xQXe(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool D591FmAU9Z9Q89NaMNnN()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CTMOSInterface ljdV0RAUkBOpHh5Qken4()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KbUrKmAUOGRWAXHkCJT7(object P_0, object P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rJ58YFAU5S90Npu0DC58(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nt9d9BAUiqD4v3KjCuPj(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pqAHBaAUzMbbR6UAjZAu(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double zJCSDLAOLMlyTDjIt2BF(object P_0, double P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F7v5n8AONdNeossjbY8k(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v1yUXkAOYNeDFBWJI707(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool P19MdYAOuvsJjdB6BLpl()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LCJ9q8AOyfZwn96RCXce()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QLenuwAO6ubRK1wWU6ML(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aguJypAO27l286RCGHJp(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aytFRqAOJKZKnogqRp21(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l1WLGRAOM9KtAr86qpQ8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yxLAp7AOKsm5CEgAqKFD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a09AZGAOZnQPYxWNWSV6(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AeF9itAOoTr1gvX6RTd5(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rh7jOKAOxUTUcdS6008e(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Thac7wAOAyrRoietvoYY(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object txQmCmAOtW8cYPikjNJG(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LU9SMTAOWBELNQX2PB0g()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q765CEAOByLQ4UNZU3tI()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LMrRD7AOqCNhrW7CrCNC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XSaNjNAOEuJ8BOS7Whqr(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rWcWTwAOVCUhnvXJ06Hr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PYCtBDAOTl4HpWo0KYqj(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr jJ5378AOp5PWSnPNgqJH(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W4iayfAOQKGYGkTLwOuB(IntPtr P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PIb5qLAORlRP8n32HZHe(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PUNJDbAOGIv5I5vXT4hj(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bUqkGTAO33wuu78Jo6pC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rGMBPaAOFp5S0trR344G(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qEJO7FAO7PW42cxJsslk()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p07RHSAObt5xqqDk4qGl(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ne0uAfAOgmMktS5Ng7Hj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GNUypsAOf0Vsb37dfuRD(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wKwtJPAOjxjdee8HxtUB(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void viVw3mAOe1iyq26Uvku3(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mP4oUxAO0Mxa0dO2ZXCR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object APWkbrAOPu69TdoAB56I(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l8aOCGAOc9QqSZSaVETD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K71lJuAO8RqqKvlIWgsD(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WBhgsIAOwUvr1kIwKOaR(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OYTV8mAOhLaC97GcHlff(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UmEBBmAO42A7i2oQRsih(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fNX3DwAOrccaVLMoRhfs(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gfcTsAAOD2wdq54io5EG(object P_0, TimeSpan P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime X7dd0gAOdW0brTp2oNEM()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r690lRAOCjxKWPJydhR3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BIiLb1AOnJZSqvFEcF5l(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pnV9M1AOaw4Fr3RcUUKq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p7BkXfAOHByBt1HKsrtg(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long VXQOc5AOsGsaM8T4sEk0(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xq1mytAOllA8Jm5l8xhZ(object P_0, object P_1, object P_2, object P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tjSaxTAO9p01n8w3xJbP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BpQOOkAOkDpZM69GOO6g(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jmnwS4AO1ZY95nqcghOb()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ecQaQNAOvQtdeYGHqYiU()
	{
	}
}
