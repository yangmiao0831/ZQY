using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class ConstUtils
{
	public const int NullValue = -16777215;

	public const int MapNullValue = -16777216;

	public const double ThresholdMaxValue = 999999999999.0;

	public const int IsMapParamFieldIdx = 13;

	public const int IsChartParamFieldIdx = 14;

	public const int IsExportParamFieldIdx = 15;

	public const int IsFilterParamFieldIdx = 19;

	public const int IsStatParamFieldIdx = 20;

	public const int IsParamViewWinFieldIdx = 21;

	public const int IsCellConfigParamFieldIdx = 22;

	public const int IsDelayParamFieldIdx = 24;

	public const int IsReportParaFieldIdx = 25;

	public const int IsSpeedParamFieldIdx = 30;

	public const int IsStatSessionKPIIdx = 1000;

	public const string UtsExtendOld = ".uts";

	public const string UtsExtend = ".saf";

	public const string UtsFilter = "*.saf";

	public static int IndoorIsOrgMarkCurVer;

	public static int Succ;

	public static int Fail;

	public static int CheckValue;

	public static int UnCheckValue;

	public static sbyte DigitsNullValue;

	public static int MapLegendMinValue;

	public static double FloatPrecision;

	public static int COMNullValue;

	public static string COM;

	public static string SparkVersion;

	public static string AppName;

	public static string SparkStr;

	public static Color WinCaptionColor;

	public static Color WinCaptionDeactiveColor;

	public static Color WinBorderColor;

	public static Color ValueBlueLightColor;

	public static Color HoverBlueColor;

	public static Color MouseDownBlueColor;

	public static Color CheckedBlueColor;

	public static Color HoverGreenColor;

	public static Color MouseDownGreenColor;

	public static Color CheckedGreenColor;

	public static Color GridLineColor;

	public static Color GridGrayLineColor;

	public static Color ListSelectedLightBlueColor;

	public static Color ListSelectedDarkBlueColor;

	public static Color ListSelectedLightGrayColor;

	public static Color CaptionSameLogColor;

	public static Color CaptionOtherLogColor;

	public static Color ButtonEnableBlueColor;

	public static Color ButtonDisableGrayColor;

	public static Color CellListTitleForeColor;

	public static Color CellListTitleBackColor;

	public static Color CellBackLightBlueColor;

	public static Color LineChartFillColor;

	public static Color LineChartLineColor;

	public static Color GridTitleGrayColor;

	public static string PrjExtend;

	public static string PrjFilter;

	public static string LogfileEQIdxSplitStr;

	public static string ADB;

	public static string SparkPath;

	public static string SparkAppDataPath;

	public static string CorePath;

	public static string ResPath;

	public static string OthersPath;

	public static string DebugPath;

	public static string HTTPSavePath;

	public static string EquipmentPath;

	public static string DefaultSFPath;

	public static string CoreSetPath;

	public static string SingleSiteSFPath;

	public static string SingleSiteSetFile;

	public static string RepairPath;

	public static string ResTempPath;

	public static string LibsPath;

	public static string IndoorImagePath;

	public static string SettingPath;

	public static string ModulePath;

	public static string ModulePathEn;

	public static string RecentPath;

	public static string Event16Path;

	public static string Event24Path;

	public static string SetupPath;

	public static string DatasPath;

	public static string DatasTempPath;

	public static string DataExportPath;

	public static string DataMergeDividePath;

	public static string DataHighSpeedRailRepairPath;

	public static string AnalysisResultPath;

	public static string SpecialDataPath;

	public static string DataSamplePath;

	public static string DataZonePath;

	public static string ATUDataPath;

	public static string TCPCaptureDataPath;

	public static string CaptureImagePath;

	public static string DefaultEventPath;

	public static string ParamViewPath;

	public static string AnalysisViewPath;

	public static string ParamViewSaveFile;

	public static string AnalysisViewSaveFile;

	public static int CILangNotSet;

	public static int CILangChinese;

	public static int CILangEnglish;

	public static string CSLangChinese;

	public static string CSLangEnglish;

	public static string DownloadTmpLicFile;

	public static string GlobalRecentOtherSet;

	public static string ATUUploadInfoFile;

	public static string GlobalRecentATUSetting;

	public static string GlobalRecentCUSetting;

	public static string GlobalRecentOpenPorts;

	public static string HTTPRandomListFile;

	public static string InfoFile;

	public static string WebLogFile;

	public static string GlobalRecentAutoThresholdColors;

	public static string DownloadTmpCPEPort;

	public static string HisiCPEPortFile;

	public static string GlobalRecentCPEIMEIs;

	public static string GlobalRecentADBPorts;

	public static string GlobalRecentEQADBStrOrder;

	public static string SubFrameFile;

	public static string SubFrameHisiFile;

	public static string ParamMeasureIntervalFile;

	public static string SparkServerFile;

	public static string SSSRXXPath;

	public static string SSSRXXFile;

	private static ConstUtils l9FWX7yO2iQklsCrYMo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConstUtils()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConstUtils()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 39;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					GlobalRecentOtherSet = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(6184), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 112;
					continue;
				case 48:
					EquipmentPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, (string)gS6J9ZybteaLAaeHf1m(5388), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 42;
					if (true)
					{
						continue;
					}
					break;
				case 9:
					GlobalRecentAutoThresholdColors = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, (string)gS6J9ZybteaLAaeHf1m(6434), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 59;
					if (true)
					{
						num2 = 81;
					}
					continue;
				case 90:
					GlobalRecentCUSetting = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(6290), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 101;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 85:
					GlobalRecentATUSetting = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, (string)gS6J9ZybteaLAaeHf1m(6258), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 13;
					if (0 == 0)
					{
						num2 = 90;
					}
					continue;
				case 36:
					ListSelectedLightGrayColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(248, 248, 248, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num = 83;
					break;
				case 34:
					SparkVersion = b99vLwQv4vNmPibnHM.iaWRZZUjVH(5182);
					num2 = 13;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 76:
					DataSamplePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(5894), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 87;
					continue;
				case 68:
					WinCaptionColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(11, 114, 198, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 51;
					continue;
				default:
					CSLangChinese = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, (string)gS6J9ZybteaLAaeHf1m(6092), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 73;
					continue;
				case 44:
					AnalysisViewPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResPath, (string)gS6J9ZybteaLAaeHf1m(6046), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num = 60;
					break;
				case 18:
					Event24Path = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SettingPath, (string)gS6J9ZybteaLAaeHf1m(5702), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 7;
					continue;
				case 42:
					DefaultSFPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(5404), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 80;
					continue;
				case 92:
					CheckValue = 1;
					num2 = 102;
					continue;
				case 13:
					AppName = T79J9XEJXZZwlragTfP.QnSQxwQdI(qtd2kbYKb4xO6qmTDF5.QnSQxwQdI(qtd2kbYKb4xO6qmTDF5.LR7YcPavMs), T79J9XEJXZZwlragTfP.J6gEGob5Ke);
					num2 = 110;
					continue;
				case 78:
					ParamMeasureIntervalFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResPath, (string)gS6J9ZybteaLAaeHf1m(6694), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num = 109;
					break;
				case 17:
					IndoorImagePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResTempPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(5566), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 106;
					continue;
				case 93:
					MapLegendMinValue = -1000000;
					num2 = 14;
					continue;
				case 5:
					CaptionOtherLogColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(201, 201, 201, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 64;
					continue;
				case 29:
					DefaultEventPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(Event24Path, (string)gS6J9ZybteaLAaeHf1m(5994), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 67;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 105:
					DebugPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, (string)gS6J9ZybteaLAaeHf1m(5350), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 4;
					continue;
				case 25:
					WinBorderColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(230, 230, 230, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 77;
					continue;
				case 51:
					WinCaptionDeactiveColor = oXSvvBNQA4ExkUr7ZWF.QnSQxwQdI(oXSvvBNQA4ExkUr7ZWF.NimNEv7DgZ);
					num2 = 25;
					continue;
				case 107:
					hcmu1Myy8dDKrcJI0cq();
					num2 = 59;
					continue;
				case 46:
					SparkPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(qtd2kbYKb4xO6qmTDF5.QnSQxwQdI(qtd2kbYKb4xO6qmTDF5.Jb5YoqUHBV), (string)gS6J9ZybteaLAaeHf1m(5294), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 52;
					continue;
				case 109:
					SparkServerFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkPath, (string)gS6J9ZybteaLAaeHf1m(6746), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 28;
					if (0 == 0)
					{
						num2 = 32;
					}
					continue;
				case 97:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 107;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 70:
					LogfileEQIdxSplitStr = b99vLwQv4vNmPibnHM.iaWRZZUjVH(5278);
					num = 98;
					break;
				case 96:
					CellListTitleForeColor = oXSvvBNQA4ExkUr7ZWF.QnSQxwQdI(oXSvvBNQA4ExkUr7ZWF.NimNEv7DgZ);
					num2 = 71;
					if (true)
					{
						continue;
					}
					break;
				case 84:
					InfoFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, (string)gS6J9ZybteaLAaeHf1m(6390), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num = 12;
					break;
				case 81:
					DownloadTmpCPEPort = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResTempPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(6484), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 82;
					continue;
				case 69:
					COMNullValue = -1;
					num2 = 66;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 40:
					LibsPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkPath, (string)gS6J9ZybteaLAaeHf1m(5552), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 17;
					continue;
				case 7:
					SetupPath = (string)wMGKi1yfU47fwlVWOGB(SparkPath);
					num2 = 89;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 33:
					SSSRXXFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkPath, (string)gS6J9ZybteaLAaeHf1m(6770), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 37;
					continue;
				case 14:
					FloatPrecision = 1E-06;
					num2 = 69;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 67:
					ParamViewPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(6036), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 44;
					if (1 == 0)
					{
						num2 = 2;
					}
					continue;
				case 71:
					CellListTitleBackColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(60, 124, 185, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 50;
					continue;
				case 66:
					COM = (string)gS6J9ZybteaLAaeHf1m(5172);
					num2 = 34;
					continue;
				case 23:
					HoverGreenColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(197, 197, 197, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 59;
					if (true)
					{
						num2 = 103;
					}
					continue;
				case 99:
					LineChartLineColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(191, 144, 0, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 79;
					continue;
				case 53:
					Fail = -1;
					num = 92;
					break;
				case 103:
					MouseDownGreenColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(177, 177, 177, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 35;
					continue;
				case 2:
					GridLineColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(218, 218, 238, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 10;
					continue;
				case 102:
					UnCheckValue = 0;
					num = 65;
					break;
				case 55:
					PrjFilter = (string)gS6J9ZybteaLAaeHf1m(5236);
					num2 = 70;
					continue;
				case 77:
					ValueBlueLightColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(0, 110, 190, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 11;
					continue;
				case 91:
					ModulePathEn = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SettingPath, (string)gS6J9ZybteaLAaeHf1m(5626), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 43;
					continue;
				case 45:
					DatasTempPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5540), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 28;
					continue;
				case 30:
					SingleSiteSFPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(5440), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 58;
					continue;
				case 111:
					MouseDownBlueColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(146, 192, 224, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 72;
					continue;
				case 20:
					OthersPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, (string)gS6J9ZybteaLAaeHf1m(5332), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 105;
					continue;
				case 10:
					GridGrayLineColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(242, 242, 242, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 22;
					if (true)
					{
						continue;
					}
					break;
				case 22:
					ListSelectedLightBlueColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(173, 185, 202, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 47;
					if (1 == 0)
					{
						num2 = 23;
					}
					continue;
				case 47:
					ListSelectedDarkBlueColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(138, 198, 236, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 36;
					if (0 == 0)
					{
						num2 = 36;
					}
					continue;
				case 65:
					DigitsNullValue = -1;
					num2 = 93;
					continue;
				case 63:
					CILangChinese = 0;
					num2 = 94;
					continue;
				case 57:
					SubFrameFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResPath, (string)gS6J9ZybteaLAaeHf1m(6636), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 16;
					continue;
				case 106:
					SettingPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkPath, (string)gS6J9ZybteaLAaeHf1m(5590), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 21;
					continue;
				case 21:
					ModulePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SettingPath, (string)gS6J9ZybteaLAaeHf1m(5608), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 91;
					continue;
				case 50:
					CellBackLightBlueColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(221, 235, 247, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 31;
					continue;
				case 104:
					HTTPRandomListFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, (string)gS6J9ZybteaLAaeHf1m(6350), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 52;
					if (true)
					{
						num2 = 84;
					}
					continue;
				case 98:
					ADB = b99vLwQv4vNmPibnHM.iaWRZZUjVH(5284);
					num = 46;
					break;
				case 39:
					QQtE1CyEdnEvigte12h();
					num2 = 38;
					continue;
				case 88:
					GlobalRecentADBPorts = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(6570), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 0;
					if (true)
					{
						num2 = 1;
					}
					continue;
				case 87:
					DataZonePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(5912), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 108;
					continue;
				case 1:
					GlobalRecentEQADBStrOrder = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, (string)gS6J9ZybteaLAaeHf1m(6598), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 57;
					continue;
				case 11:
					HoverBlueColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(205, 230, 247, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 111;
					continue;
				case 24:
					SpecialDataPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5866), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 76;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 16:
					SubFrameHisiFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResPath, (string)gS6J9ZybteaLAaeHf1m(6664), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 78;
					continue;
				case 31:
					LineChartFillColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(255, 192, 0, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 22;
					if (0 == 0)
					{
						num2 = 99;
					}
					continue;
				case 54:
					RepairPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CoreSetPath, (string)gS6J9ZybteaLAaeHf1m(5522), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 95;
					continue;
				case 79:
					GridTitleGrayColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(242, 242, 242, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 19;
					continue;
				case 60:
					ParamViewSaveFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ParamViewPath, (string)gS6J9ZybteaLAaeHf1m(6056), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 74;
					if (false)
					{
						num2 = 1;
					}
					continue;
				case 19:
					PrjExtend = b99vLwQv4vNmPibnHM.iaWRZZUjVH(5216);
					num2 = 55;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 83:
					CaptionSameLogColor = oXSvvBNQA4ExkUr7ZWF.QnSQxwQdI(oXSvvBNQA4ExkUr7ZWF.NimNEv7DgZ);
					num2 = 5;
					continue;
				case 62:
					CaptureImagePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5964), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 29;
					continue;
				case 64:
					ButtonEnableBlueColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(22, 155, 213, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 2;
					if (true)
					{
						num2 = 3;
					}
					continue;
				case 61:
					CILangNotSet = -1;
					num2 = 63;
					continue;
				case 52:
					SparkAppDataPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI((string)UWJ5cWyQjDg0q5gWtbc(Environment.SpecialFolder.CommonApplicationData), (string)gS6J9ZybteaLAaeHf1m(5300), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num = 26;
					break;
				case 59:
					IndoorIsOrgMarkCurVer = 2;
					num2 = 100;
					continue;
				case 95:
					ResTempPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResPath, (string)gS6J9ZybteaLAaeHf1m(5540), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num = 40;
					break;
				case 86:
					DataHighSpeedRailRepairPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5800), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 6;
					if (true)
					{
						continue;
					}
					break;
				case 112:
					ATUUploadInfoFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SettingPath, (string)gS6J9ZybteaLAaeHf1m(6212), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 85;
					continue;
				case 110:
					SparkStr = (string)gS6J9ZybteaLAaeHf1m(5206);
					num2 = 68;
					continue;
				case 94:
					CILangEnglish = 1;
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 8:
					TCPCaptureDataPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5938), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 62;
					continue;
				case 3:
					ButtonDisableGrayColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(102, 102, 102, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 96;
					if (true)
					{
						continue;
					}
					break;
				case 72:
					CheckedBlueColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(177, 214, 240, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 3;
					if (true)
					{
						num2 = 23;
					}
					continue;
				case 101:
					GlobalRecentOpenPorts = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, (string)gS6J9ZybteaLAaeHf1m(6320), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 104;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 41:
					DownloadTmpLicFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ResTempPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(6160), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 15;
					continue;
				case 38:
					ERHnaxyc5txGS7y1GbI();
					num2 = 97;
					continue;
				case 6:
					AnalysisResultPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(5832), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 24;
					continue;
				case 74:
					AnalysisViewSaveFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(AnalysisViewPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(6074), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 61;
					if (true)
					{
						continue;
					}
					break;
				case 12:
					WebLogFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, (string)gS6J9ZybteaLAaeHf1m(6410), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 9;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 37:
					return;
				case 58:
					SingleSiteSetFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SingleSiteSFPath, (string)gS6J9ZybteaLAaeHf1m(5474), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 24;
					if (0 == 0)
					{
						num2 = 54;
					}
					continue;
				case 43:
					RecentPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SettingPath, (string)gS6J9ZybteaLAaeHf1m(5648), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 75;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 100:
					Succ = 0;
					num = 53;
					break;
				case 108:
					ATUDataPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5926), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 8;
					if (false)
					{
						num2 = 2;
					}
					continue;
				case 80:
					CoreSetPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, (string)gS6J9ZybteaLAaeHf1m(5428), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 30;
					continue;
				case 27:
					ResPath = CorePath;
					num2 = 20;
					continue;
				case 89:
					DatasPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SetupPath, (string)gS6J9ZybteaLAaeHf1m(5736), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 45;
					continue;
				case 28:
					DataExportPath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5750), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 49;
					continue;
				case 56:
					GlobalRecentCPEIMEIs = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkAppDataPath, (string)gS6J9ZybteaLAaeHf1m(6542), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 88;
					continue;
				case 75:
					Event16Path = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SettingPath, (string)gS6J9ZybteaLAaeHf1m(5668), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 18;
					continue;
				case 35:
					CheckedGreenColor = NZv4cyyo59TtBRtpQut.QnSQxwQdI(197, 197, 197, NZv4cyyo59TtBRtpQut.RDEy2GyjKv);
					num2 = 2;
					continue;
				case 26:
					CorePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkPath, (string)gS6J9ZybteaLAaeHf1m(5314), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 27;
					if (false)
					{
						num2 = 26;
					}
					continue;
				case 82:
					HisiCPEPortFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI(SparkPath, (string)gS6J9ZybteaLAaeHf1m(6508), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 56;
					continue;
				case 32:
					SSSRXXPath = SparkPath;
					num2 = 33;
					if (false)
					{
						num2 = 4;
					}
					continue;
				case 73:
					CSLangEnglish = ls0JmaLsLk7suNXwaC.QnSQxwQdI(CorePath, (string)gS6J9ZybteaLAaeHf1m(6126), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 41;
					continue;
				case 49:
					DataMergeDividePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DatasPath, (string)gS6J9ZybteaLAaeHf1m(5768), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 86;
					continue;
				case 4:
					HTTPSavePath = ls0JmaLsLk7suNXwaC.QnSQxwQdI(DebugPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(5366), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 48;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hcmu1Myy8dDKrcJI0cq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g0XOxMyJK2h4KDBQbSm()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConstUtils cdV8xay2n6sGZf0svBh()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QQtE1CyEdnEvigte12h()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ERHnaxyc5txGS7y1GbI()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gS6J9ZybteaLAaeHf1m(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UWJ5cWyQjDg0q5gWtbc(Environment.SpecialFolder P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wMGKi1yfU47fwlVWOGB(object P_0)
	{
		return null;
	}
}
