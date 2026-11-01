using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class SiteConfigSerial
{
	public bool ShowSiteHoverInfo;

	public OneNetSiteConfig NR5GSiteConfig;

	public OneNetSiteConfig NBSiteConfig;

	public OneNetSiteConfig LTESiteConfig;

	public OneNetSiteConfig WCDMASiteConfig;

	public OneNetSiteConfig GSMSiteConfig;

	[NonSerialized]
	public static int[] PointShowParamKeyArray;

	[NonSerialized]
	public static string[] PointShowParamStrArray;

	public static int CIReplace;

	public static int CIAppend;

	public int SiteImportType;

	public bool ShowMapInfoLabel;

	public bool ShowMapInfoLabelIndex;

	public int MapInfoLabelIndex;

	public int MapInfoLineWidth;

	public bool MapInfoLineUseColor;

	public Color MapInfoLineColor;

	public int PointSize;

	public int PointStyle;

	public bool PointShowText;

	public bool PointShowTextChanged;

	public bool PointShowUseSelectParam;

	public bool ShowPointHoverInfo;

	private string WWegeartwFo;

	[NonSerialized]
	public List<string> PointShowParamList;

	[NonSerialized]
	public List<int> PointShowParamKeyList;

	public bool NotShowNullValue;

	private static SiteConfigSerial KuIrsPZMmmGk2cTei3JP;

	public string PointShowParam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SiteConfigSerial()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveToDefFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SiteConfigSerial()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 29;
		string[] array = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 51:
					array[44] = (string)adTvl5ZKyxLQkjTFirco(391504);
					num = 5;
					break;
				case 10:
					array[36] = (string)adTvl5ZKyxLQkjTFirco(391236);
					num = 4;
					break;
				case 55:
					array = new string[48];
					num2 = 24;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 17:
					array[28] = (string)adTvl5ZKyxLQkjTFirco(390972);
					num = 23;
					break;
				case 2:
					array[25] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(390872);
					num2 = 48;
					continue;
				case 31:
					array[39] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(391336);
					num2 = 25;
					continue;
				case 34:
					array[47] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(391604);
					num2 = 38;
					continue;
				case 26:
					array[35] = (string)adTvl5ZKyxLQkjTFirco(391204);
					num2 = 10;
					continue;
				case 43:
					return;
				case 13:
					array[31] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(391072);
					num2 = 45;
					continue;
				case 42:
					array[13] = (string)adTvl5ZKyxLQkjTFirco(390654);
					num2 = 46;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 45:
					array[32] = (string)adTvl5ZKyxLQkjTFirco(391104);
					num2 = 33;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 36:
					array[7] = (string)adTvl5ZKyxLQkjTFirco(390386);
					num2 = 19;
					if (true)
					{
						continue;
					}
					break;
				case 40:
					array[4] = (string)adTvl5ZKyxLQkjTFirco(390346);
					num2 = 9;
					continue;
				default:
					array[15] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(62728);
					num2 = 30;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 54:
					array[10] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(390518);
					num2 = 6;
					continue;
				case 4:
					array[37] = (string)adTvl5ZKyxLQkjTFirco(391272);
					num2 = 50;
					if (false)
					{
						num2 = 45;
					}
					continue;
				case 23:
					array[29] = (string)adTvl5ZKyxLQkjTFirco(391004);
					num2 = 7;
					continue;
				case 18:
					array[22] = (string)adTvl5ZKyxLQkjTFirco(390786);
					num2 = 12;
					continue;
				case 49:
					array[1] = (string)adTvl5ZKyxLQkjTFirco(390262);
					num2 = 44;
					if (true)
					{
						continue;
					}
					break;
				case 37:
					array[19] = ((Language)vGVIqiZK68IT5I1aFxad()).UICommonSiteName;
					num2 = 15;
					continue;
				case 15:
					array[20] = ((Language)vGVIqiZK68IT5I1aFxad()).UICommonCellName;
					num2 = 47;
					continue;
				case 12:
					array[23] = (string)adTvl5ZKyxLQkjTFirco(390812);
					num2 = 1;
					if (1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					array[6] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(196414);
					num2 = 36;
					if (false)
					{
						num2 = 4;
					}
					continue;
				case 7:
					array[30] = (string)adTvl5ZKyxLQkjTFirco(391036);
					num2 = 13;
					continue;
				case 11:
					array[27] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(390936);
					num2 = 12;
					if (0 == 0)
					{
						num2 = 17;
					}
					continue;
				case 5:
					array[45] = (string)adTvl5ZKyxLQkjTFirco(391536);
					num2 = 14;
					continue;
				case 24:
					array[0] = (string)adTvl5ZKyxLQkjTFirco(390242);
					num2 = 33;
					if (0 == 0)
					{
						num2 = 49;
					}
					continue;
				case 14:
					array[46] = (string)adTvl5ZKyxLQkjTFirco(391572);
					num2 = 23;
					if (true)
					{
						num2 = 34;
					}
					continue;
				case 39:
				{
					int[] array2 = new int[48];
					NmHFtsZKuc2ipunmeRo8(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					PointShowParamKeyArray = array2;
					num2 = 55;
					if (false)
					{
						num2 = 17;
					}
					continue;
				}
				case 29:
					xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
					num2 = 18;
					if (0 == 0)
					{
						num2 = 28;
					}
					continue;
				case 22:
					array[12] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(390608);
					num2 = 42;
					continue;
				case 38:
					PointShowParamStrArray = array;
					num2 = 52;
					continue;
				case 27:
					array[41] = (string)adTvl5ZKyxLQkjTFirco(391404);
					num2 = 32;
					continue;
				case 6:
					array[11] = (string)adTvl5ZKyxLQkjTFirco(390562);
					num2 = 22;
					continue;
				case 1:
					array[24] = (string)adTvl5ZKyxLQkjTFirco(390836);
					num2 = 2;
					if (1 == 0)
					{
						num2 = 2;
					}
					continue;
				case 30:
					array[16] = (string)adTvl5ZKyxLQkjTFirco(62748);
					num2 = 3;
					continue;
				case 21:
					CIAppend = 1;
					num2 = 43;
					continue;
				case 35:
					array[18] = (string)adTvl5ZKyxLQkjTFirco(390740);
					num2 = 37;
					continue;
				case 47:
					array[21] = (string)adTvl5ZKyxLQkjTFirco(128390);
					num2 = 18;
					continue;
				case 8:
					array[43] = (string)adTvl5ZKyxLQkjTFirco(391472);
					num2 = 51;
					continue;
				case 48:
					array[26] = (string)adTvl5ZKyxLQkjTFirco(390904);
					num2 = 11;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 46:
					array[14] = (string)adTvl5ZKyxLQkjTFirco(390676);
					num2 = 0;
					if (1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					kSdg5JZMUYBF6sDp58Hj();
					num2 = 39;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 32:
					array[42] = (string)adTvl5ZKyxLQkjTFirco(391436);
					num2 = 8;
					continue;
				case 33:
					array[33] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(391136);
					num2 = 41;
					continue;
				case 41:
					array[34] = (string)adTvl5ZKyxLQkjTFirco(391172);
					num2 = 26;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 25:
					array[40] = (string)adTvl5ZKyxLQkjTFirco(391372);
					num2 = 27;
					continue;
				case 19:
					array[8] = (string)adTvl5ZKyxLQkjTFirco(390430);
					num2 = 20;
					if (1 == 0)
					{
						num2 = 17;
					}
					continue;
				case 20:
					array[9] = (string)adTvl5ZKyxLQkjTFirco(390474);
					num2 = 54;
					continue;
				case 3:
					array[17] = (string)adTvl5ZKyxLQkjTFirco(390694);
					num2 = 35;
					if (true)
					{
						continue;
					}
					break;
				case 50:
					array[38] = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(391304);
					num2 = 31;
					continue;
				case 44:
					array[2] = (string)adTvl5ZKyxLQkjTFirco(390278);
					num2 = 53;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 9:
					array[5] = (string)adTvl5ZKyxLQkjTFirco(196364);
					num2 = 16;
					continue;
				case 53:
					array[3] = (string)adTvl5ZKyxLQkjTFirco(390306);
					num2 = 40;
					continue;
				case 52:
					CIReplace = 0;
					num2 = 21;
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
	internal static void kSdg5JZMUYBF6sDp58Hj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color CTZkP6ZMOpnFdBNFCFoP()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lyphuLZMIuHrGoGk0jBk()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SiteConfigSerial iKLarxZMX1inowgYtv67()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yANaIlZM5fvo1VVdCvmb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QtJP8YZMi2dyhaMjayO8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A7tw1BZMzsxL5321D9JE(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eSYpAQZKLclGajGsf8lR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BbWga5ZKN25q1qA3XB6w(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uh4JeeZKYZF1FwnvnLbd(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NmHFtsZKuc2ipunmeRo8(object P_0, RuntimeFieldHandle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object adTvl5ZKyxLQkjTFirco(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vGVIqiZK68IT5I1aFxad()
	{
		return null;
	}
}
