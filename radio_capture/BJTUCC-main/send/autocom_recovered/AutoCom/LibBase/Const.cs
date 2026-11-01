using System.Drawing;
using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibBase;

public class Const : ConstUtils
{
	public const string TabFilter = "*.tab";

	public const string ShpFilter = "*.shp";

	public const string UboExtend = ".raf";

	public const string MDMExtend = ".mdm";

	public const string DlfExtend = ".dlf";

	public const string QmdlExtend = ".qmdl";

	public const string Qmdl2Extend = ".qmdl2";

	public const string TlfExtend = ".tlf";

	public const string CPFExtend = ".cpf";

	public const string BTFExtend = ".btf";

	public const string DTLogExtend = ".lte";

	public const string DTLogExtend_l5g = ".l5g";

	public const string DTLogNewExtend = ".dtlog";

	public const string DTLogNcfExtend = ".ncf";

	public const string ECTIExtend = ".ecti";

	public const string ECTIExtend_5g = ".ncti";

	public const string ECTINormalExtend = ".eCTI";

	public const string ECTINormalExtend_5g = ".nCTI";

	public const string TfiExtend = ".tfi";

	public const string CUExtend = ".cu";

	public const string CUNormalExtend = ".CU";

	public const string HaiSiExtend = ".txt";

	public const string GesfExtend = ".gesf";

	public const string ZdExtend = ".zd";

	public const string MuxrawExtend = ".muxraw";

	public const string ASPSExtend = ".csv";

	public const string ConnectionSetupDisplayName = "网络连接配置";

	public const string FTPSiteDisplayName = "FTP站点配置";

	public const string ContentDisplayName = "业务配置";

	public const string UIOpenView_CellListNB = "NB Cell Detail";

	public const string UIOpenView_CellListLTE = "LTE Cell Detail";

	public const string UIOpenView_CellListNR5G = "NR5G Beam List";

	public const string UIOpenView_CellListGSM = "GSM Cell Detail";

	public const string UIOpenView_EnvironmentCheck = "测试环境自动检测";

	public const string UIOpenView_PDSCHDMRSMeasurement = "PDSCH DMRS Measurement";

	public const string UIOpenView_PDCCHDMRSMeasurement = "PDCCH DMRS Measurement";

	public const string UIOpenView_DLRBDetailNR = "NR5G DL RB Detail";

	public const string UIOpenView_ULRBDetailNR = "NR5G UL RB Detail";

	public const string UIOpenView_DLRBDetailLTE = "LTE DL RB Detail";

	public const string UIOpenView_ULRBDetailLTE = "LTE UL RB Detail";

	public static string ReportModelPath;

	public static string ScenePath;

	public static string ScenePathNew;

	public static string ScenePathABC;

	public static string ScenePathCAERI;

	public static string ExportTemplatePath;

	public static string EnvironmentCheckTemplatePath;

	public static string StatSessionKPIPath;

	public static string StatSessionKPIDefFile;

	public static string KPISessionModuleFile;

	public static string KPISessionWinFile;

	public static string KPISessionWinFile_PhoneCall;

	public static string KPISessionWinFile_Competitor;

	public static int TabIdxChinaMobile;

	public static int TabIdxChinaUnicom;

	public static int TabIdxChinaTelecom;

	public static int TabIdxOnlyScanner;

	public static int TabIdxAnalysis;

	public static int TabIdxCompare;

	public static Color GozillaCaptionFontColor;

	public static Color AnaListviewHeaderColor;

	public static Color SiteGrayColor;

	public static string TaskExtend;

	public static string AnalysisResultFileExtend;

	public static string SceneExtend;

	public static string SceneFilter;

	public static string ParamViewWinExtend;

	public static string Server;

	public static string iPhoneProxy;

	public static string USBPcapCMD;

	public static string GoogleEarth;

	public static string POLQAVer;

	public static string CTTLMOSVer;

	public static string SceneDefaultFile;

	public static string DefaultPrjFile;

	public static string UnionPrjFile;

	public static string OnlyUEPrjFile;

	public static string OnlySCPrjFile;

	public static string SoftInfoFile;

	public static string AreaCfgFile;

	public static string SoftCfgFile;

	public static string StartUIKillName;

	public static string StartUIFile;

	public static string KillHisiProxyFile;

	public static string TCPCaptureEXE;

	public static string LastSitesFileNR5G;

	public static string LastSitesFileNB;

	public static string LastSitesFileLTE;

	public static string LastSitesFileGSM;

	public static string SpeedTestServersFile;

	public static string ScreenShot;

	public static string ScreenShotJTBAutoFile;

	public static string ServerFile;

	public static string SocketFile;

	public static string MOSCalcEXE;

	public static string DatasetFile;

	public static string WebBrowserShowFile;

	public static string FTPDLRateShowFile;

	public static string UpdatePackExe;

	public static string ForceBackupPath;

	public static string ForceFile;

	public static string SAForceSetFile;

	public static string ForceDefaultFile;

	public static string WinLocationPath;

	public static string SiteConfigFile;

	public static string GDMapConfigFile2D;

	public static string GDMapConfigFile3D;

	public static string MapParamInfoFile;

	public static string MapParamInfoHoverFile;

	public static string MsgDetailCustomParamFile;

	public static string MsgDetailCustomParamNormalFile;

	public static string SignalingDetailsParameterFile;

	public static string MapCellLayerAnalysisFile;

	public static string MapAnalysisConfigsFile;

	public static string FengHuoVersionCfgFile;

	public static string MOSVolumeCfgFile;

	public static string ParamKPIDetailShowCfgFile;

	public static string CompareStatMathCfgFile;

	public static string OneClickUnlockFile;

	public static string ColumnIndexFile;

	public static string IndoorAdminInfoFile;

	public static string RepairSectorIDFile;

	public static string RecentTasks;

	public static string RecentFirstUETasksNormal;

	public static string RecentFirstUETasksATU;

	public static string RecentATCmds;

	public static string RecentINSCmds;

	public static string RecentLoggingAddress;

	public static string RecentLoggingScene;

	public static string RecentMsgDetailColor;

	public static string RecentMsgFind;

	public static string RecentEventFind;

	public static string GlobalRecentClientToolCfgFile;

	public static string GlobalRecentAllAntObjFile;

	public static string ComHistoryFile;

	public static string SoftwareUpdatePackFile;

	public static string SoftwareUpdatePackFileInABC;

	public static string SoftwareAutoUpdateFile;

	public static string SoftwareAutoUpdateFile_UE;

	public static string SoftwareAutoUpdateFile_OTT;

	public static string BlueToothUpdateFile;

	public static string AnalysisFilterFile;

	public static string ZoneTmpFile;

	public static string WriteIndoorMapFile;

	public static string TmpPDFFile;

	public static string PDFtoPNGFile;

	public static string DefaultExportTemplateName;

	public static string GlobalRecentTasks;

	public static string GlobalRecentFTPIPs;

	public static string GlobalRecentPingIPs;

	public static string GlobalRecentIPerfIPs;

	public static string GlobalRecentHTTPVideoURLs;

	public static string GlobalRecentDelayIPs;

	public static string GlobalRecentEQInfos;

	public static string SessionPropertyResFile;

	public static string SessionPropertyResENFile;

	public static string MapCurLocationFile;

	public static string MapCurLocationFile2;

	public static string MapAntennaLocationFile;

	public static string NetMonitorPath;

	public static string NetMonitorExeQQFile;

	public static string NetMonitorExeKingSoft;

	public static string WebKitBrowserFile;

	public static string AnaReqPath;

	public static string EventSessionResFile;

	public static string AnaHandoverResFile;

	public static string IntelligentResFile;

	public static string IntelligentEventConfigFile;

	public static string PointIndexFilterFile;

	public static string LogmaskFile;

	public static string ScannerFilterFreqFile;

	public static string HTTPDownFile;

	public static string HTTPConvertFile;

	public static string POLQALicenseFile;

	public static string WSAPath;

	public static string MapWinGISBaiDuMapFile;

	public static string HisiLogPath;

	public static string CMRIMOSCalcPath;

	public static string AMTUModalPath;

	public static string CUDataPath;

	public static string less8swavPath;

	public static string SpecialSetFile;

	public static string SoftViLTEUserConfigFile;

	public static string SoftViLTEDefaultFile;

	public static string PermeabilityCityFile;

	public static string ElectricWinJsonFile;

	public static string ServerSetFile;

	public static string FGIInstructionsFile;

	public static string ADBCmdPath;

	public static string MapWinGISDB;

	public static string MapWinGISDBTmp;

	public static string PVExtend;

	public static string PVExtendFilter;

	public static string PV2Extend;

	public static string PV2ExtendFilter;

	public static string AVExtend;

	public static string AVExtendFilter;

	public static string AV2Extend;

	public static string AV2ExtendFilter;

	public static string LineChartExtend;

	public static string MosDataFilePath;

	public static string BinConfigFile;

	public static string FilterConfigFile;

	public static string AnalysisConfigFile;

	public static string StaticticsFile;

	public static string StaticticsFileEvent;

	public static string StaticticsFileMsg;

	public static string CustomParamConfigFile;

	public static string CustomEventConfigFile;

	public static string CommonSettingConfigFile;

	public static string KnowyouUploadInfoFile;

	public static string CTTLUploadInfoFile;

	public static string CUUploadInfoFile;

	public static string SigmaUploadInfoFile;

	public static string SigmaTestConfigJsonNode;

	public static string SwordDataPath;

	public static string SwordDataPathDown;

	public static string SwordShowUIFile;

	public static string HiAgent3ServerFile;

	public static string IndoorFloorPath;

	public static string DDFPXX00WaitFile;

	public static string MOSWinExportPath;

	public static string MOSLoopRecPath;

	public static string CUDebugPath;

	public static string AnalysisKpiContrastPath;

	public static string DownloadPath;

	public static string AnalysisShowConfigFile;

	public static string AnalysisCellParamConfigFile;

	public static string CompareStatParamConfigFile;

	public static string CompareStatKpiConfigFile;

	public static string AnalysisCellMeasureAndStatConfigFile;

	public static string AnalysisCellMeasureAndStatCellConfigFile;

	public static string TopNAnalysisSelectParamsConfigFile;

	public static string AnalysisPoorCoverageKpiContrastConfigFile;

	public static string UBAnalysisRequestFile;

	public static string AnalysisSiteDistanceConfigFile;

	public static string AnalysisCustomParamConfigFile;

	public static string DTLogFindSafFile;

	public static string LineChartModulePath;

	public static string ThresholdModulePath;

	public static string AMTUMatrixGroupFile;

	public static string AMTUMatrixChannelFile;

	public static string FileUploadSite;

	public static string GlobalRecentFTPULIPs;

	public static string GlobalRecentHTTPULIPs;

	public static string DownMsgKey;

	public static string UpMsgKey;

	public static string UEMsgKey;

	public static string SatisfyYesKey;

	public static string SatisfyNoKey;

	public static string SatisfyEmptyKey;

	public static string ExportLogfileDistanceField;

	public static string CustomEventDelayParamStr;

	public static string DefaultTasks;

	public static string SigmaTasks;

	public static string SigmaUser;

	public static string SigmaParameterModel;

	public static string SingleTaskAdmin;

	public static string DatasSigmaSavePath;

	public static string CIZTEAxon30UE;

	public static string ERadioTaskRecordFile;

	public static Color ColorGridViewHeaderBg;

	public static string NoContentFlag;

	public static string ArgsSafPath;

	internal static Const X718sdtDYbFG0t1EOIyp;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitModulePath()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Const()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Const()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 165;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 157:
					OneClickUnlockFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(538260));
					num2 = 86;
					if (true)
					{
						continue;
					}
					break;
				case 49:
					SwordDataPath = ConstUtils.DatasPath + (string?)um64KktD6qnOO3JjhAud(541084);
					num2 = 54;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 175:
					ScreenShot = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.LibsPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537394));
					num2 = 61;
					continue;
				case 1:
					DownloadPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.DatasPath, um64KktD6qnOO3JjhAud(541324));
					num = 91;
					break;
				case 107:
					WebKitBrowserFile = ConstUtils.OthersPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(539676);
					num2 = 148;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 141:
					TabIdxChinaUnicom = 1;
					num2 = 156;
					continue;
				case 7:
					GlobalRecentTasks = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(538414));
					num2 = 8;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 48:
					ServerFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(428532));
					num2 = 199;
					if (true)
					{
						continue;
					}
					break;
				case 145:
					SiteGrayColor = Wslkl2tDMLLHx9DAoWtR(127, 127, 127);
					num2 = 151;
					continue;
				case 41:
					HiAgent3ServerFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(541130));
					num2 = 193;
					continue;
				case 195:
					DefaultExportTemplateName = (string)um64KktD6qnOO3JjhAud(324118);
					num2 = 7;
					continue;
				case 176:
					NetMonitorPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.OthersPath, um64KktD6qnOO3JjhAud(539530));
					num2 = 102;
					continue;
				case 5:
					WebBrowserShowFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(537476));
					num = 53;
					break;
				case 13:
					CustomParamConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(540718));
					num2 = 140;
					continue;
				case 115:
					DownMsgKey = (string)um64KktD6qnOO3JjhAud(470310);
					num2 = 40;
					continue;
				case 56:
					POLQALicenseFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(540050));
					num2 = 106;
					continue;
				case 76:
					AV2Extend = (string)um64KktD6qnOO3JjhAud(540524);
					num2 = 150;
					continue;
				case 79:
					PDFtoPNGFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.IndoorImagePath, um64KktD6qnOO3JjhAud(539128));
					num2 = 195;
					continue;
				case 83:
					USBPcapCMD = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(536860);
					num2 = 25;
					continue;
				case 158:
					ElectricWinJsonFile = ConstUtils.CoreSetPath + (string?)um64KktD6qnOO3JjhAud(540366);
					num2 = 99;
					continue;
				case 55:
					DatasSigmaSavePath = ConstUtils.DatasPath + (string?)um64KktD6qnOO3JjhAud(542488);
					num2 = 87;
					continue;
				case 140:
					CustomEventConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(540752));
					num = 50;
					break;
				case 162:
					AVExtend = (string)um64KktD6qnOO3JjhAud(540502);
					num = 29;
					break;
				case 124:
					AnalysisCellParamConfigFile = ConstUtils.SettingPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541378);
					num2 = 110;
					continue;
				case 73:
					NetMonitorExeKingSoft = ConstUtils.OthersPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(539612);
					num2 = 107;
					continue;
				default:
					SpecialSetFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(540230));
					num2 = 144;
					continue;
				case 123:
					SigmaUploadInfoFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(540976));
					num2 = 35;
					if (0 == 0)
					{
						num2 = 81;
					}
					continue;
				case 18:
					ColorGridViewHeaderBg = Wslkl2tDMLLHx9DAoWtR(233, 235, 245);
					num2 = 36;
					continue;
				case 146:
					SingleTaskAdmin = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResPath, um64KktD6qnOO3JjhAud(542458));
					num2 = 55;
					continue;
				case 211:
					SessionPropertyResENFile = ConstUtils.ResPath + (string?)um64KktD6qnOO3JjhAud(539378);
					num2 = 104;
					continue;
				case 36:
					NoContentFlag = (string)um64KktD6qnOO3JjhAud(12912);
					num2 = 187;
					continue;
				case 183:
					CUDataPath = ConstUtils.DatasPath + (string?)um64KktD6qnOO3JjhAud(540196);
					num2 = 92;
					continue;
				case 102:
					NetMonitorExeQQFile = ConstUtils.OthersPath + (string?)um64KktD6qnOO3JjhAud(539556);
					num2 = 73;
					if (true)
					{
						continue;
					}
					break;
				case 122:
					AnalysisResultFileExtend = (string)um64KktD6qnOO3JjhAud(536784);
					num = 114;
					break;
				case 192:
					AnalysisCellMeasureAndStatConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541516));
					num2 = 198;
					continue;
				case 67:
					FilterConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(540584));
					num2 = 191;
					if (true)
					{
						continue;
					}
					break;
				case 164:
					Ap1LsetDJG1EW4pDn1N7();
					num2 = 20;
					continue;
				case 53:
					FTPDLRateShowFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(537500));
					num2 = 190;
					continue;
				case 128:
					OnlySCPrjFile = (string)VEvT2RtDKfCs2Aq6bKWG(ConstUtils.CorePath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537028), ConstUtils.PrjExtend);
					num2 = 161;
					if (1 == 0)
					{
						num2 = 156;
					}
					continue;
				case 119:
					RecentLoggingAddress = ConstUtils.RecentPath + (string?)um64KktD6qnOO3JjhAud(538560);
					num2 = 155;
					continue;
				case 85:
					MOSCalcEXE = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(537452));
					num2 = 62;
					if (true)
					{
						continue;
					}
					break;
				case 109:
					SoftCfgFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(537092));
					num2 = 93;
					continue;
				case 171:
					CompareStatKpiConfigFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(541470);
					num2 = 192;
					continue;
				case 137:
					AnaListviewHeaderColor = Wslkl2tDMLLHx9DAoWtR(237, 239, 247);
					num2 = 145;
					continue;
				case 193:
					IndoorFloorPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.DatasPath, um64KktD6qnOO3JjhAud(541188));
					num = 16;
					break;
				case 95:
					LogmaskFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResPath, um64KktD6qnOO3JjhAud(539940));
					num2 = 24;
					continue;
				case 131:
					KnowyouUploadInfoFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(540830);
					num2 = 80;
					continue;
				case 114:
					SceneExtend = (string)um64KktD6qnOO3JjhAud(536796);
					num2 = 212;
					continue;
				case 129:
					SatisfyYesKey = (string)um64KktD6qnOO3JjhAud(542220);
					num2 = 75;
					continue;
				case 151:
					TaskExtend = (string)um64KktD6qnOO3JjhAud(536770);
					num2 = 122;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 9:
					SpeedTestServersFile = ConstUtils.CorePath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537350);
					num2 = 175;
					continue;
				case 190:
					UpdatePackExe = ConstUtils.SparkPath + (string?)um64KktD6qnOO3JjhAud(537534);
					num2 = 95;
					if (true)
					{
						num2 = 210;
					}
					continue;
				case 104:
					MapCurLocationFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResPath, um64KktD6qnOO3JjhAud(539424));
					num = 94;
					break;
				case 15:
					HTTPConvertFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.HTTPSavePath, um64KktD6qnOO3JjhAud(540028));
					num2 = 56;
					continue;
				case 174:
					MOSWinExportPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.DatasPath, um64KktD6qnOO3JjhAud(541234));
					num2 = 170;
					continue;
				case 24:
					ScannerFilterFreqFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResPath, um64KktD6qnOO3JjhAud(539966));
					num2 = 134;
					if (false)
					{
						num2 = 56;
					}
					continue;
				case 186:
					GozillaCaptionFontColor = Wslkl2tDMLLHx9DAoWtR(31, 45, 73);
					num2 = 137;
					continue;
				case 148:
					AnaReqPath = ConstUtils.ResPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(539720);
					num2 = 43;
					continue;
				case 52:
					CUUploadInfoFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(540932));
					num2 = 123;
					if (true)
					{
						continue;
					}
					break;
				case 105:
					iPhoneProxy = (string)um64KktD6qnOO3JjhAud(536844);
					num2 = 83;
					if (1 == 0)
					{
						num2 = 60;
					}
					continue;
				case 130:
					RecentMsgDetailColor = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, um64KktD6qnOO3JjhAud(538636));
					num2 = 3;
					continue;
				case 84:
					FengHuoVersionCfgFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(538082);
					num2 = 116;
					continue;
				case 103:
					RecentATCmds = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, um64KktD6qnOO3JjhAud(538498));
					num2 = 51;
					continue;
				case 4:
					IntelligentResFile = (string)WnPhIttD2gdPjmPwc29I(AnaReqPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(539824));
					num2 = 166;
					continue;
				case 62:
					DatasetFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(428362));
					num2 = 0;
					if (0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 133:
					AnaHandoverResFile = (string)WnPhIttD2gdPjmPwc29I(AnaReqPath, um64KktD6qnOO3JjhAud(539780));
					num2 = 4;
					continue;
				case 86:
					ColumnIndexFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(538300));
					num2 = 6;
					continue;
				case 71:
					SoftwareUpdatePackFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResTempPath, um64KktD6qnOO3JjhAud(538830));
					num2 = 98;
					continue;
				case 54:
					SwordDataPathDown = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.DatasPath, um64KktD6qnOO3JjhAud(541084));
					num2 = 32;
					continue;
				case 170:
					MOSLoopRecPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.DatasPath, um64KktD6qnOO3JjhAud(541252));
					num = 181;
					break;
				case 34:
					MsgDetailCustomParamNormalFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537890));
					num2 = 189;
					continue;
				case 156:
					TabIdxChinaTelecom = 2;
					num2 = 125;
					if (true)
					{
						continue;
					}
					break;
				case 166:
					IntelligentEventConfigFile = (string)WnPhIttD2gdPjmPwc29I(AnaReqPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(539864));
					num2 = 82;
					continue;
				case 26:
					FileUploadSite = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(542114));
					num2 = 72;
					continue;
				case 112:
					LastSitesFileNR5G = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(537206));
					num2 = 138;
					continue;
				case 118:
					PVExtend = (string)um64KktD6qnOO3JjhAud(536818);
					num2 = 196;
					continue;
				case 136:
					DTLogFindSafFile = ConstUtils.SettingPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541938);
					num2 = 37;
					continue;
				case 138:
					LastSitesFileNB = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(537244));
					num2 = 60;
					if (true)
					{
						continue;
					}
					break;
				case 70:
					RecentTasks = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, um64KktD6qnOO3JjhAud(538414));
					num2 = 178;
					continue;
				case 69:
					UnionPrjFile = (string)VEvT2RtDKfCs2Aq6bKWG(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(536998), ConstUtils.PrjExtend);
					num2 = 66;
					if (true)
					{
						continue;
					}
					break;
				case 177:
					UEMsgKey = (string)um64KktD6qnOO3JjhAud(478660);
					num2 = 129;
					if (true)
					{
						continue;
					}
					break;
				case 39:
					SoftwareAutoUpdateFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResTempPath, um64KktD6qnOO3JjhAud(538850));
					num2 = 44;
					continue;
				case 184:
					CMRIMOSCalcPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResTempPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(540140));
					num2 = 14;
					if (0 == 0)
					{
						num2 = 200;
					}
					continue;
				case 207:
					GlobalRecentDelayIPs = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(539284));
					num2 = 188;
					continue;
				case 143:
					AnalysisSiteDistanceConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(541844));
					num2 = 100;
					if (false)
					{
						num2 = 54;
					}
					continue;
				case 147:
					ForceDefaultFile = ConstUtils.EquipmentPath + (string?)um64KktD6qnOO3JjhAud(537620);
					num2 = 153;
					continue;
				case 16:
					DDFPXX00WaitFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541206));
					num2 = 174;
					if (true)
					{
						continue;
					}
					break;
				case 12:
					RepairSectorIDFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RepairPath, um64KktD6qnOO3JjhAud(538376));
					num2 = 70;
					continue;
				case 51:
					RecentINSCmds = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, um64KktD6qnOO3JjhAud(538528));
					num2 = 119;
					continue;
				case 88:
					SigmaParameterModel = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(542408));
					num2 = 146;
					continue;
				case 89:
					ForceFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.EquipmentPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537568));
					num2 = 10;
					continue;
				case 43:
					EventSessionResFile = AnaReqPath + (string?)um64KktD6qnOO3JjhAud(539738);
					num2 = 133;
					if (true)
					{
						continue;
					}
					break;
				case 199:
					SocketFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(428386));
					num2 = 85;
					continue;
				case 37:
					LineChartModulePath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(541982));
					num2 = 27;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 68:
					SessionPropertyResFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResPath, um64KktD6qnOO3JjhAud(539338));
					num2 = 211;
					continue;
				case 150:
					AV2ExtendFilter = (string)um64KktD6qnOO3JjhAud(540536);
					num2 = 78;
					if (false)
					{
						num2 = 10;
					}
					continue;
				case 110:
					CompareStatParamConfigFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(541420);
					num2 = 171;
					continue;
				case 22:
					MapParamInfoHoverFile = ConstUtils.SettingPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537810);
					num2 = 63;
					continue;
				case 77:
					ParamKPIDetailShowCfgFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(538164));
					num2 = 152;
					continue;
				case 153:
					WinLocationPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(537640));
					num2 = 96;
					continue;
				case 60:
					LastSitesFileLTE = ConstUtils.CorePath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537278);
					num2 = 120;
					continue;
				case 182:
					PermeabilityCityFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CoreSetPath, um64KktD6qnOO3JjhAud(540320));
					num2 = 158;
					continue;
				case 50:
					CommonSettingConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(540786));
					num = 131;
					break;
				case 188:
					GlobalRecentEQInfos = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(539312));
					num2 = 68;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 205:
					AnalysisPoorCoverageKpiContrastConfigFile = (string)WnPhIttD2gdPjmPwc29I(AnalysisKpiContrastPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541724));
					num = 197;
					break;
				case 40:
					UpMsgKey = (string)um64KktD6qnOO3JjhAud(478772);
					num2 = 177;
					continue;
				case 201:
					BinConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(540560));
					num2 = 67;
					continue;
				case 46:
					RecentFirstUETasksATU = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, um64KktD6qnOO3JjhAud(538470));
					num = 103;
					break;
				case 97:
					DefaultPrjFile = ConstUtils.SettingPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(536978) + ConstUtils.PrjExtend;
					num2 = 69;
					if (1 == 0)
					{
						num2 = 64;
					}
					continue;
				case 32:
					SwordShowUIFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541106));
					num2 = 41;
					continue;
				case 47:
					StartUIFile = (string)VEvT2RtDKfCs2Aq6bKWG(ConstUtils.LibsPath, StartUIKillName, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537138));
					num2 = 180;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 155:
					RecentLoggingScene = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, um64KktD6qnOO3JjhAud(538600));
					num2 = 130;
					if (1 == 0)
					{
						num2 = 111;
					}
					continue;
				case 99:
					ServerSetFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CoreSetPath, um64KktD6qnOO3JjhAud(514182));
					num2 = 30;
					continue;
				case 127:
					return;
				case 194:
					POLQAVer = (string)um64KktD6qnOO3JjhAud(536910);
					num2 = 113;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 101:
					TmpPDFFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.IndoorImagePath, um64KktD6qnOO3JjhAud(539108));
					num2 = 79;
					if (true)
					{
						continue;
					}
					break;
				case 212:
					SceneFilter = (string)um64KktD6qnOO3JjhAud(536806);
					num2 = 58;
					continue;
				case 106:
					WSAPath = ConstUtils.SparkPath + (string?)um64KktD6qnOO3JjhAud(540094);
					num2 = 168;
					if (true)
					{
						continue;
					}
					break;
				case 20:
					TabIdxChinaMobile = 0;
					num2 = 141;
					continue;
				case 61:
					ScreenShotJTBAutoFile = ConstUtils.ResTempPath + (string?)um64KktD6qnOO3JjhAud(537418);
					num2 = 48;
					continue;
				case 23:
					AnalysisKpiContrastPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.AnalysisResultPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541272));
					num2 = 0;
					if (true)
					{
						num2 = 1;
					}
					continue;
				case 42:
					SceneDefaultFile = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(536958);
					num2 = 97;
					continue;
				case 152:
					CompareStatMathCfgFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(538204));
					num2 = 157;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 189:
					SignalingDetailsParameterFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CoreSetPath, um64KktD6qnOO3JjhAud(537948));
					num2 = 185;
					continue;
				case 17:
					TabIdxCompare = 5;
					num2 = 186;
					continue;
				case 58:
					ParamViewWinExtend = (string)um64KktD6qnOO3JjhAud(536818);
					num2 = 65;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 30:
					FGIInstructionsFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CoreSetPath, um64KktD6qnOO3JjhAud(540402));
					num = 45;
					break;
				case 80:
					CTTLUploadInfoFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(540884);
					num2 = 52;
					continue;
				case 134:
					HTTPDownFile = ConstUtils.HTTPSavePath + (string?)um64KktD6qnOO3JjhAud(540006);
					num2 = 15;
					continue;
				case 78:
					LineChartExtend = (string)um64KktD6qnOO3JjhAud(540550);
					num2 = 38;
					continue;
				case 28:
					DefaultTasks = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(542310));
					num2 = 21;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 27:
					ThresholdModulePath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ModulePath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(542006));
					num2 = 159;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 202:
					ExportLogfileDistanceField = (string)um64KktD6qnOO3JjhAud(137814);
					num2 = 74;
					continue;
				case 125:
					TabIdxOnlyScanner = 3;
					num2 = 58;
					if (0 == 0)
					{
						num2 = 169;
					}
					continue;
				case 165:
					xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
					num2 = 164;
					continue;
				case 117:
					HisiLogPath = ConstUtils.SparkPath + (string?)um64KktD6qnOO3JjhAud(427114);
					num2 = 122;
					if (true)
					{
						num2 = 184;
					}
					continue;
				case 161:
					SoftInfoFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537044));
					num = 154;
					break;
				case 208:
					MapAnalysisConfigsFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(538052));
					num2 = 46;
					if (true)
					{
						num2 = 84;
					}
					continue;
				case 108:
					RecentEventFind = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(538704));
					num2 = 126;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 63:
					MsgDetailCustomParamFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(537844));
					num2 = 34;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 204:
					AMTUMatrixChannelFile = ConstUtils.SettingPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(542076);
					num2 = 26;
					continue;
				case 181:
					CUDebugPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.DebugPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(540196));
					num2 = 23;
					continue;
				case 75:
					SatisfyNoKey = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(542244);
					num2 = 135;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 21:
					SigmaTasks = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(542346));
					num2 = 33;
					continue;
				case 169:
					TabIdxAnalysis = 4;
					num2 = 17;
					if (true)
					{
						continue;
					}
					break;
				case 209:
					StaticticsFileEvent = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(540650);
					num2 = 19;
					continue;
				case 29:
					AVExtendFilter = (string)um64KktD6qnOO3JjhAud(540512);
					num2 = 76;
					continue;
				case 100:
					AnalysisCustomParamConfigFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(541892);
					num2 = 136;
					continue;
				case 173:
					SoftwareAutoUpdateFile_OTT = ConstUtils.ResTempPath + (string?)um64KktD6qnOO3JjhAud(538920);
					num2 = 132;
					continue;
				case 35:
					GlobalRecentHTTPVideoURLs = ConstUtils.SparkAppDataPath + (string?)um64KktD6qnOO3JjhAud(539246);
					num2 = 207;
					continue;
				case 142:
					GDMapConfigFile2D = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(537706));
					num2 = 31;
					continue;
				case 33:
					SigmaUser = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(542378));
					num2 = 88;
					continue;
				case 200:
					AMTUModalPath = ConstUtils.SparkPath + (string?)um64KktD6qnOO3JjhAud(540168);
					num2 = 183;
					continue;
				case 168:
					MapWinGISBaiDuMapFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(540114));
					num2 = 117;
					continue;
				case 44:
					SoftwareAutoUpdateFile_UE = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResTempPath, um64KktD6qnOO3JjhAud(538882));
					num = 173;
					break;
				case 64:
					MapParamInfoFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(537782));
					num2 = 22;
					continue;
				case 149:
					ERadioTaskRecordFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(542524);
					num2 = 3;
					if (true)
					{
						num2 = 18;
					}
					continue;
				case 2:
					MapWinGISDB = ConstUtils.SparkPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(540114);
					num2 = 14;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 91:
					AnalysisShowConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(541346));
					num2 = 124;
					continue;
				case 14:
					MapWinGISDBTmp = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResTempPath, um64KktD6qnOO3JjhAud(540114));
					num2 = 118;
					continue;
				case 203:
					ZoneTmpFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResTempPath, um64KktD6qnOO3JjhAud(539052));
					num2 = 206;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 178:
					RecentFirstUETasksNormal = ConstUtils.RecentPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(538436);
					num2 = 46;
					continue;
				case 172:
					GlobalRecentHTTPULIPs = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(542186));
					num2 = 115;
					continue;
				case 139:
					TCPCaptureEXE = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(537174));
					num2 = 112;
					continue;
				case 45:
					ADBCmdPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CoreSetPath, um64KktD6qnOO3JjhAud(540446));
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 31:
					GDMapConfigFile3D = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(537744));
					num2 = 64;
					continue;
				case 210:
					ForceBackupPath = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.EquipmentPath, um64KktD6qnOO3JjhAud(537550));
					num2 = 89;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 113:
					CTTLMOSVer = (string)um64KktD6qnOO3JjhAud(536940);
					num2 = 42;
					continue;
				case 185:
					MapCellLayerAnalysisFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(538010));
					num2 = 208;
					if (true)
					{
						continue;
					}
					break;
				case 144:
					SoftViLTEUserConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(540248));
					num2 = 57;
					continue;
				case 74:
					CustomEventDelayParamStr = (string)um64KktD6qnOO3JjhAud(542294);
					num2 = 28;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 111:
					ComHistoryFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(538798));
					num2 = 71;
					continue;
				case 154:
					AreaCfgFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(537072));
					num2 = 109;
					continue;
				case 197:
					UBAnalysisRequestFile = ConstUtils.AnalysisResultPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541788);
					num2 = 143;
					continue;
				case 66:
					OnlyUEPrjFile = (string)VEvT2RtDKfCs2Aq6bKWG(ConstUtils.CorePath, um64KktD6qnOO3JjhAud(537012), ConstUtils.PrjExtend);
					num2 = 128;
					continue;
				case 159:
					AMTUMatrixGroupFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(542042));
					num2 = 204;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 8:
					GlobalRecentFTPIPs = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(539164));
					num = 11;
					break;
				case 206:
					WriteIndoorMapFile = ConstUtils.ResTempPath + (string?)um64KktD6qnOO3JjhAud(539078);
					num2 = 101;
					continue;
				case 116:
					MOSVolumeCfgFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(538128);
					num2 = 77;
					continue;
				case 132:
					BlueToothUpdateFile = (string)um64KktD6qnOO3JjhAud(538960);
					num2 = 121;
					continue;
				case 72:
					GlobalRecentFTPULIPs = ConstUtils.SparkAppDataPath + (string?)um64KktD6qnOO3JjhAud(542154);
					num2 = 172;
					continue;
				case 196:
					PVExtendFilter = xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(540464);
					num2 = 50;
					if (0 == 0)
					{
						num2 = 59;
					}
					continue;
				case 93:
					StartUIKillName = (string)um64KktD6qnOO3JjhAud(537122);
					num2 = 47;
					if (true)
					{
						continue;
					}
					break;
				case 38:
					MosDataFilePath = (string)s1fBbwtDZbVtLVPQiCHB(ConstUtils.DatasPath, um64KktD6qnOO3JjhAud(196732));
					num2 = 201;
					continue;
				case 81:
					SigmaTestConfigJsonNode = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(541026));
					num2 = 49;
					continue;
				case 11:
					GlobalRecentPingIPs = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(539192));
					num2 = 160;
					continue;
				case 90:
					MapAntennaLocationFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResPath, um64KktD6qnOO3JjhAud(539482));
					num2 = 176;
					if (true)
					{
						continue;
					}
					break;
				case 163:
					GlobalRecentAllAntObjFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(538768));
					num2 = 111;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 180:
					KillHisiProxyFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkPath, um64KktD6qnOO3JjhAud(537150));
					num2 = 139;
					continue;
				case 6:
					IndoorAdminInfoFile = ConstUtils.SettingPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(538334);
					num2 = 12;
					continue;
				case 57:
					SoftViLTEDefaultFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CoreSetPath, um64KktD6qnOO3JjhAud(540276));
					num2 = 182;
					continue;
				case 92:
					less8swavPath = ConstUtils.DatasPath + (string?)um64KktD6qnOO3JjhAud(540206);
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 198:
					AnalysisCellMeasureAndStatCellConfigFile = ConstUtils.SettingPath + (string?)um64KktD6qnOO3JjhAud(541576);
					num = 179;
					break;
				case 167:
					PV2ExtendFilter = (string)um64KktD6qnOO3JjhAud(540488);
					num2 = 162;
					if (1 == 0)
					{
						num2 = 137;
					}
					continue;
				case 96:
					SiteConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(537674));
					num2 = 142;
					continue;
				case 65:
					Server = (string)um64KktD6qnOO3JjhAud(536828);
					num2 = 105;
					if (true)
					{
						continue;
					}
					break;
				case 187:
					ArgsSafPath = string.Empty;
					num2 = 127;
					continue;
				case 94:
					MapCurLocationFile2 = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.ResPath, um64KktD6qnOO3JjhAud(539452));
					num2 = 90;
					if (true)
					{
						continue;
					}
					break;
				case 179:
					TopNAnalysisSelectParamsConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(541644));
					num2 = 205;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 126:
					GlobalRecentClientToolCfgFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(538736));
					num2 = 163;
					continue;
				case 25:
					GoogleEarth = (string)um64KktD6qnOO3JjhAud(536884);
					num2 = 194;
					continue;
				case 135:
					SatisfyEmptyKey = (string)um64KktD6qnOO3JjhAud(542266);
					num = 202;
					break;
				case 121:
					AnalysisFilterFile = ConstUtils.ResTempPath + xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(539012);
					num2 = 44;
					if (0 == 0)
					{
						num2 = 203;
					}
					continue;
				case 19:
					StaticticsFileMsg = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(540686));
					num2 = 13;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 160:
					GlobalRecentIPerfIPs = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(539218));
					num2 = 35;
					continue;
				case 87:
					CIZTEAxon30UE = (string)um64KktD6qnOO3JjhAud(542504);
					num2 = 149;
					if (true)
					{
						continue;
					}
					break;
				case 120:
					LastSitesFileGSM = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.CorePath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(537314));
					num2 = 9;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 98:
					SoftwareUpdatePackFileInABC = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SparkAppDataPath, um64KktD6qnOO3JjhAud(538830));
					num2 = 22;
					if (true)
					{
						num2 = 39;
					}
					continue;
				case 10:
					SAForceSetFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.EquipmentPath, um64KktD6qnOO3JjhAud(537586));
					num2 = 147;
					continue;
				case 213:
					StaticticsFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(540614));
					num2 = 209;
					if (true)
					{
						continue;
					}
					break;
				case 191:
					AnalysisConfigFile = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.SettingPath, um64KktD6qnOO3JjhAud(386702));
					num2 = 213;
					continue;
				case 59:
					PV2Extend = (string)um64KktD6qnOO3JjhAud(540476);
					num = 167;
					break;
				case 82:
					PointIndexFilterFile = ConstUtils.ResPath + (string?)um64KktD6qnOO3JjhAud(539904);
					num2 = 1;
					if (true)
					{
						num2 = 95;
					}
					continue;
				case 3:
					RecentMsgFind = (string)WnPhIttD2gdPjmPwc29I(ConstUtils.RecentPath, um64KktD6qnOO3JjhAud(538676));
					num2 = 108;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object um64KktD6qnOO3JjhAud(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WnPhIttD2gdPjmPwc29I(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NVYYZStDu3q1sMnlqocO()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Const vBFvGHtDyRggRnge6ZWk()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ap1LsetDJG1EW4pDn1N7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Wslkl2tDMLLHx9DAoWtR(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VEvT2RtDKfCs2Aq6bKWG(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s1fBbwtDZbVtLVPQiCHB(object P_0, object P_1)
	{
		return null;
	}
}
