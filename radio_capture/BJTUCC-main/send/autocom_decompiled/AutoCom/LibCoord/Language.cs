using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class Language : LanguageUtils
{
	public static bool HasSetEnglish;

	public WinLangs WinLangs;

	public string DialogCaptionTip;

	public string TipMainWinHardDogLost;

	public string TipMainWinNoLogfile;

	public string TipMainWinCoordWinNoLogfile;

	public string TipMainWinLogfileNotExist;

	public string TipMainWinServerCrash;

	public string TipMainWinLogfileHasExist;

	public string TipMainWinConnectFail;

	public string TipMainWinConnectIsRedecoding;

	public string TipMainWinConnectFailPortOccupy;

	public string TipMainWinReCoverFail;

	public string TipMainWinEQNoPoint;

	public string TipMainWinGPSNoPoint;

	public string TipMainWinNoRSRPPoint;

	public string TipMainWinStartTestNoTask;

	public string TipMainWinOpenProjectErr;

	public string TipMainWinStartTestNotLogging;

	public string TipMainWinRestartSoft;

	public string TipMainWinRestartSoftByHighDPI;

	public string TipMainWinFilesKilled;

	public string TipMainWinNoSQLSDK;

	public string TipMainWinSheetLogfileIsConnecting;

	public string TipMainWinDriverLess10G;

	public string TipMainWinDriverLess2GBeforeLog;

	public string TipMainWinDriverLess2GCheckInTest;

	public string TipMainWinConnectRSNoSDK;

	public string TipMainWinDriverLess1GStop;

	public string TipHaisiProxyStartOvertime;

	public string TipHaisiProxyInitialFail;

	public string TipHaisiProxyLisenceInvalid;

	public string TipHaisiProxyNetworkInvalid;

	public string TipHaisiProxyLocalLisenceFileInvalid;

	public string TipHaisiVC140NotInstalled;

	public string TipEQConfigBeforeConnect;

	public string TipEQConfigHasConnect;

	public string TipExitAppIsConnecting;

	public string TipAutoEQFinish;

	public string TipAutoEQFinishNoAuth;

	public string TipAutoEQNoEQ;

	public string TipRegLicenseFail;

	public string TipUELicenseFail;

	public string TipEQConfigChangeEQTypeNotSame;

	public string TipEQConfigHasGPSAndUEGPSBaidu;

	public string TipEQConfigADBEmpty;

	public string TipForceConfigSendATNoConnet;

	public string TipForceConfigSendForceNoConnetAT;

	public string TipForceConfigSendForceNoConnetAdapter;

	public string TipForceConfigSendForceNoConnetModem;

	public string TipForceConfigSendForceNoConnet;

	public string TipForceConfigOpenATPortFail;

	public string TipForceConfigSendATNoOpen;

	public string TipForceConfigDefDesc;

	public string TipForceConfigEQLost;

	public string TipForceReasonATProcessing;

	public string TipForceReasonForceProcessing;

	public string TipForceReasonATToolUsing;

	public string TipForceReasonWiFiConnectFail;

	public string TipForceReasonDeviceTimeOut;

	public string TipForceReasonConnectDeviceFail;

	public string TipForceReasonAlreadyOpen;

	public string TipForceReasonNoPort;

	public string TipForceReasonPPPDailFail;

	public string TipForceReasonNetTimeout;

	public string TipForceReasonNetAlreadyOpen;

	public string TipForceReasonNetNotSupport;

	public string TipTestTaskMultiNeedMore2Task;

	public string TipTestTaskContentErr;

	public string TipTestTaskConnectionNoAdapter;

	public string TipTestTaskConnectionNoAT;

	public string TipTestTaskConnectionNoNDIS;

	public string TipTestTaskIPV6;

	public string TipTestTaskIPV4;

	public string TipTestTaskIPErr;

	public string TipTestTaskIPNull;

	public string TipTestTaskFTPDownSavePathNull;

	public string TipTestTaskFTPDownSavePathNotExists;

	public string TipTestTaskFTPUploadPathNull;

	public string TipTestTaskFTPUploadFilePathNull;

	public string TipTestTaskFTPUploadFilePathNotExists;

	public string TipTestTaskFTPSiteEmpty;

	public string TipTestTaskFTPSiteEmptyAnonymous;

	public string TipTestTaskFTPSiteNeedSelectFolder;

	public string TipTestTaskFTPSiteNeedSelectFile;

	public string TipTestTaskCalledUESelf;

	public string TipTestTaskVideoCallNeedUEModel;

	public string TipTestTaskMOSCloundNotSupportPOLQAV11;

	public string TipTestTaskCallSwitchTimesMoreThanTestTimes;

	public string TipTestTaskCallNumberInvalid;

	public string TipTestTaskATPingTimes255;

	public string TipTestTaskATPingOverTime60;

	public string TipTestTaskTimeFormat;

	public string TipTaskItemCfgAttachNote;

	public string TipTaskItemCfgPowerNote;

	public string TipTaskConfigAddEQFirst;

	public string TipATUIsRunningExit;

	public string TipATUBoxIDMust8Len;

	public string TipATUSafFileNotFind;

	public string TipTaskSCNoLicense;

	public string TipTaskSCParamOutOfRange;

	public string TipTaskSCBadChannelFrequency;

	public string TipTaskSCErrOther;

	public string TipExportSucc;

	public string TipExportOnlySucc;

	public string TipExportSelectParamFirst;

	public string TipExportSelectAtLeastOneParam;

	public string TipExportFailed;

	public string TipExportFail;

	public string TipImportSucc;

	public string TipImportFail;

	public string TipExportSelect2Saf;

	public string TipExportSelectSafNoMOMT;

	public string TipDownloadSucc;

	public string TipDownloadHttpError;

	public string TipDownloadCEF;

	public string TipDownloadCEFByUpdateVersion;

	public string TipDownloadFileExist;

	public string TipMOSWaveWinImportWaveAndCalcFirst;

	public string TipMOSWaveWinCalcingCloseWin;

	public string TipMapWinSaveLegendFail;

	public string TipMapWinImportSiteFirst;

	public string TipMapWinUndoMarkNoMark;

	public string TipMapWinRedoMarkNoMark;

	public string TipMapWinBuildingShouldStopLogging;

	public string TipMapWinThresholdErr;

	public string TipMapWinDeleteSelectedMarkNotMarkPoint;

	public string TipMapWinThresholdDiscreteParam;

	public string TipMapWinThresholdEditRef;

	public string TipMapWinGoogleEarthStartupFail;

	public string TipMapWinIndoorLayersSwitchFail;

	public string TipMapWinNeedLongLatDefineMark;

	public string TipMapWinModeIndoor;

	public string TipMapWinModeOutdoor;

	public string TipMapWinNeedGPSNoPoint;

	public string TipMapWinIndoorBuildingNotExist;

	public string TipMapWinIndoorFloorHasTest;

	public string TipMapWinIndoorSelectFloorFirst;

	public string TipMapWinIndoorPauseLogFirst;

	public string TipMapWinIndoorResumeLogFirst;

	public string TipMapWinIndoorUnFreezeFirst;

	public string TipMapWinDefineMarkStat;

	public string TipSiteImportFail;

	public string TipSiteImportFailByOccupy;

	public string TipSiteImportFieldErr;

	public string TipSiteImportNoKeyField;

	public string TipNameEmpty;

	public string TipNameExists;

	public string TipSameTypeAnaNameExists;

	public string TipSuccEventNameEmpty;

	public string TipFailEventNameEmpty;

	public string TipNotToSelectNodeFirst;

	public string TipNotToSelectFolderNode;

	public string TipNotToSelectBuildingFloorFirst;

	public string TipMergeFail;

	public string TipMergeSucc;

	public string TipDivideFail;

	public string TipDivideSucc;

	public string TipMergeSelectMore2Files;

	public string TipMergeSafRafMix;

	public string TipMergeNotSameChip;

	public string TipSaveNewLogfileNeed2Item;

	public string TipSaveNewLogfileNeedConnect;

	public string TipHighSpeedRailSelectFileFirst;

	public string TipHighSpeedRailSucc;

	public string TipHighSpeedRailSetFail;

	public string TipHighSpeedRailSelectSetsFirst;

	public string TipHighSpeedRailCancelNeedDisconnect;

	public string TipHighSpeedRailNotSetUseBaidu;

	public string TipMetroCalibrateSucc;

	public string TipGyroSetFail;

	public string TipSureToEndMark;

	public string GyroMetroStartMark;

	public string GyroMetroEndMark;

	public string GyroMetroUndoArrive;

	public string GyroIndoorStartMark;

	public string GyroIndoorEndMark;

	public string GyroIndoorMarkCorrect;

	public string TipMetroAutoUndoArrivalHasStart;

	public string TipMetroAutoUndoArrivalNotStart;

	public string TipMetroAutoStartHasMark;

	public string TipGyroIndoorSetFirstMarkLocation;

	public string TipGyroIndoorInitSucc;

	public string TipGyroIndoorCorrectMarkLocation;

	public string TipGyroIndoorCorrectMarkNoPoint;

	public string TipMsgDetailNotSupport;

	public string TipNowIsLoading;

	public string TipNowIsLoadingByNetwork;

	public string TipNowIsLoadingByNetworkFail;

	public string TipNowIsConnectingPlatform;

	public string TipAnalysisCurSheetLogfileNull;

	public string TipAnalysisSelectItemFirst;

	public string TipAnalysisDelResultFileFail;

	public string TipAnalysisSheetLogfileNotUE;

	public string TipAnalysisSheetLogfileNotScanner;

	public string TipAnalysisSelectedScanLogfileFirst;

	public string TipAnalysisCrosszoneSiteFileEmpty;

	public string TipGlobalDataQueryLongLatFormatErr;

	public string TipLogfileConnectingNotSupportFilter;

	public string TipLogfileConnectingNotSupportBin;

	public string TipLogfileNameWrong;

	public string TipLogfileNameWrongC2A0;

	public string TipLogfileSameNameWrong;

	public string TipMOSInitFail;

	public string TipMOSStateError;

	public string TipMOS30InitFail;

	public string TipMOS30PortLost;

	public string TipMOSMOCMTCChannelSame;

	public string TipPOLQAInitFail;

	public string TipPOLQAInitFailV30;

	public string TipMOSCalcFail;

	public string TipMOSCalcCTTLNoDongle;

	public string TipMOSMute;

	public string TipMOSMuteMOSInternal;

	public string TipMOSRecFail;

	public string TipMOS30RecFailMayNotStop;

	public string TipMOSUEADBNone;

	public string TipMOSUEADBMore;

	public string TipMOSUENoPOLQAAuth;

	public string TipMOSUEPOLQAExpire;

	public string TipMOSUEADBLinkFail;

	public string TipMOSUEWifiLinkFail;

	public string TipMOSUEAppNoReply;

	public string TipMOSChannelExchange;

	public string TipServerTimeSyncSucc;

	public string TipServerTimeSyncFail;

	public string TipServerTimeSyncFirst;

	public string TipQuectelMOSSetError;

	public string TipPOLQACalcNeedWait;

	public string TipMOSInternalRoot;

	public string TipNoNetworkAuth;

	public string TipNoAuthCommon;

	public string TipNoDecryptKey;

	public string TipAuthUESupportCount;

	public string TipMOSMultiWavLoading;

	public string TipAreaOverInLoadLogfile;

	public string TipAreaOverInTest;

	public string TipAuthDeliverForever;

	public string TipAuthQuectelMOS;

	public string TipInputToFind;

	public string TipNoRTPPacket;

	public string TipWiFiUELost;

	public string TipCommonFormatErr;

	public string TipCheckOneFirst;

	public string TipCommonMustNRLog;

	public string TipZoneFileSaveSucc;

	public string HelpFileOperatorSkill;

	public string HelpFile5GProblem;

	public string HelpFileOperatorVideo;

	public string HelpFileProductManual;

	public string TipSwordReUploadDelete;

	public string TipSwordReUploadDeleteContainUn;

	public string TipExportThresholdsEmpty;

	public string TipExportThresholds;

	public string TipImportThresholds;

	public string TipSwitchParam;

	public string TipThresholdClose;

	public string TipThresholdRefresh;

	public string TipDivideTime;

	public string TipDivideZone;

	public string TipDivideNoConditions;

	public string TipDivideFilter;

	public string TipCommon_IsConnectingNoClose;

	public string TipCommonLogfileOpenFail;

	public string TipFilterUnableFind;

	public string TipSaveSubFrameWithConnecting;

	public string TipMultiUEParamViewConfigUEList;

	public string TipFileParseFailSafOccupy;

	public string TipCUPlatformNotAllow;

	public string TipClientToolCanNotAddEQ;

	public string TipClientToolCanNotDelEQ;

	public string TipClientToolEQCountZero;

	public string TipReportWinText;

	public string TipReportWinReportSavePath;

	public string TipReportWinReportOpenLogFilter;

	public string TipReportWinReportOpenReportModelFilter;

	public string TipReportWinReportHintSelectModel;

	public string TipReportWinReportHintSelectLog;

	public string TipReportWinReportHintExportModelFailure;

	public string TipReportWinReportHintImportModelExists;

	public string TipReportWinReportHintImportModelReplace;

	public string TipReportWinReportHintImportModelFailure;

	public string TipReportWinReportHintAllReport;

	public string TipReportWinReportHintModify;

	public string TipReportWinReportCaptionLogGrid;

	public string TipReportWinReportCaptionSelectParam;

	public string TipReportWinReportCaptionSelectKPI;

	public string TipReportWinReportCaptionSelectAnalysis;

	public string TipReportWinReportRecentGroupName;

	public string TipReportWinReportCustomGroupName;

	public string TipReportWinReportReportResultGroupName;

	public string TipReportWinReportCaptionSelectCondition;

	public string TipReportWinReportHintReportProcessing;

	public string TipReportWinReportHintImportSiteSuccess;

	public string TipReportWinReportHintReportSuccess;

	public string TipReportWinReportHintReportFailure;

	public string TipReportWinReportOpenRPTFileFilter;

	public string TipReportWinReportHintExportModel;

	public string TipReportWinReportHintCopyModelFailure;

	public string TipReportWinReportHintModelHasExists;

	public string TipReportWinReportHintDeleteReport;

	public string TipReportWinReportHintOnlyCanEditCustomReport;

	public string TipReportWinDataSelectorGridLog;

	public string TipReportWinDataSelectorGridBusiness;

	public string TipReportWinDataSelectorGridTestTime;

	public string TipReportWinPortSelectorTabDevice;

	public string TipReportWinPortSelectorTabPort;

	public string TipReportWinPortSelectorTabCell;

	public string TipReportWinPortSelectorTabFilterGroup;

	public string TipReportWinPortSelectorTabMoreSet;

	public string TipReportWinPortSelectorReportByOneData;

	public string TipReportWinPortSelectorWordToPDF;

	public string TipReportWinParamSelectorLabelType;

	public string TipReportWinConditionSelectorLabelType;

	public string TipReportWinConditionSelectorLabelFilter;

	public string TipReportWinConditionSelectorLabelCompare;

	public string TipReportWinImportSite;

	public string TipReportWinImportRoad;

	public string TipReportWinImportPlace;

	public string TipReportWinImportRoadSection;

	public string TipReportWinReportName;

	public string TipReportWinNewFilter;

	public string TipRemoteReportWinCaptionModelName;

	public string TipRemoteReportWinCaptionUpdateTime;

	public string TipRemoteReportWinCaptionAlgorithmTime;

	public string TipRemoteReportWinCaptionDownloadRating;

	public string TipRemoteReportWinNewHintReportGroup;

	public string TipRemoteReportWinNewHintDownloadReport;

	public string TipRemoteReportWinHintGetReports;

	public string UIMainWin_DefaultProject;

	public string UIMainWin_Maximize;

	public string UIMainWin_Reduction;

	public string UIMainWin_NoDongle;

	public string UIMainWin_NoDongleVersion;

	public string UIMainWin_DongleExpireUpdateFail;

	public string UIMainWin_DongleNotMathRes;

	public string UIMainWin_DongleForbid;

	public string UIMainWin_DongleException;

	public string UIMainWin_DongleHardDogNoRes;

	public string UIMainWin_DongleOfflineMaxTimes;

	public string UIMainWin_OnlineCheckFail;

	public string UIMainWin_SoftwareIsOvertime;

	public string UIMainWin_SoftwareVersionTooLow;

	public string UIMainWin_DongleOfflineMaxTimesATUPlayer;

	public string UIMainWin_DongleNotExists;

	public string UIMainWin_DongleExpire;

	public string UIMainWin_DonglePCTimeError;

	public string UIMainWin_Connect;

	public string UIMainWin_DisConnect;

	public string UIMainWin_StartLogging;

	public string UIMainWin_StopLogging;

	public string UIMainWin_LoggingLaboratory;

	public string UIMainWin_StartTask;

	public string UIMainWin_StopTask;

	public string UIMainWin_StatParam;

	public string UIMainWin_StatEvent;

	public string UIAutoUpdateChecking;

	public string UIAutoUpdateHasUpdateSoftSetup;

	public string UIAutoUpdateHasUpdateSoftPack;

	public string UIAutoUpdateNoUpdate;

	public string UIAutoUpdateNoNetwork;

	public string UIAutoUpdateSucc;

	public string UIAutoUpdateDownload;

	public string UIEQConfig_Connect;

	public string UIEQConfig_DisConnect;

	public string UIEQConfig_Connected;

	public string UIEQConfig_Disconnected;

	public string UIEQConfig_TracePortName;

	public string UIEQConfig_4GTracePortName;

	public string UIEQConfig_UserUEGPS;

	public string UIEQConfig_UserSCGPS;

	public string UIEQConfig_WiFiOpenedWarn;

	public string UITaskConfig_StartSingleTask;

	public string UITaskConfig_StopSingleTask;

	public string UITaskConfig_MOSFile;

	public string UITaskConfig_CallUnionNoMTCCall;

	public string UITaskConfig_CallUnionNoMTCUE;

	public string UITaskConfig_CallUnionErr;

	public string UITaskConfig_CallOnlyMOC;

	public string TipMOSAutoCheckFail;

	public string TipCallHangupFail;

	public string TipCallBeforeStatus;

	public string UITaskItemConfig_Caption;

	public string UIOpenView_ParamView;

	public string UIOpenView_AnalysisView;

	public string UIForceConfig_CategoryForce;

	public string UIForceConfig_CategoryAT;

	public string UIForceConfig_OpenPort;

	public string UIForceConfig_ClosePort;

	public string UIReplayWinTime;

	public string UIGetADBUELogNoLog;

	public string UIGetADBUELogNoTCPCapture;

	public string UIProgressWin_Connecting;

	public string UIProgressWin_DisConnecting;

	public string UIProgressWin_StartTasking;

	public string UIProgressWin_StopTasking;

	public string UIProgressWin_StartLogging;

	public string UIProgressWin_StopLogging;

	public string UIProgressWin_Redecoding;

	public string UIProgressWin_Exporting;

	public string UIProgressWin_Merging;

	public string UIProgressWin_Dividing;

	public string UIProgressWin_HighSpeedRailRepairing;

	public string UIProgressWin_AutoCheckEQ;

	public string UIProgressWin_Downloading;

	public string UIProgressWin_MOSAutoChecking;

	public string UIProgressWin_HaisiProxyStartuping;

	public string UIProgressWin_HighSpeedRailSetting;

	public string UIProgressWin_MetroTraceCalibration;

	public string UIBinConfig_TypeTime;

	public string UIBinConfig_TypeGrid;

	public string UIBinConfig_TypeDistance;

	public string UIBinConfig_TypePoint;

	public string UIBinConfig_TimeParam;

	public string UIBinConfig_GridParam;

	public string UIBinConfig_DistanceParam;

	public string UIBinConfig_PointParam;

	public string UIBinConfig_Average;

	public string UIBinConfig_Max;

	public string UIBinConfig_Min;

	public string UIBinConfig_Middle;

	public string UIBinConfig_Worest5;

	public string UIBinConfig_PointCount;

	public string UIBinConfig_Sum;

	public string UIBinConfig_Variance;

	public string UIBinConfig_FirstPoint;

	public string UIBinConfig_LastPoint;

	public string UIBinConfig_MostRatio;

	public string UIFilterConfig_TypeSession;

	public string UIFilterConfig_TypeExpression;

	public string UIFilterConfig_TypeRange;

	public string UIFilterConfig_TypeZone;

	public string UIFilterConfig_TypeMulti;

	public string UIFilterConfig_Outside;

	public string UIFilterConfig_Inside;

	public string UIFilter_OpenFilterFail;

	public string UIFilter_SelectFilterFirst;

	public string UIBin_OpenBinFail;

	public string UIBin_OpenBinSucc;

	public string UIBin_OpenBinParam;

	public string UIStatictics_TypePie;

	public string UIStatictics_TypeColumn;

	public string UIStatictics_TypeLine;

	public string UIStatictics_TypeTrend;

	public string UIStatictics_ColName;

	public string UIStatictics_ColValue;

	public string UIStatictics_ColNo;

	public string UIStatictics_ColRange;

	public string UIStatictics_ColCount;

	public string UIStatictics_CaptionPart;

	public string UIStatictics_CaptionCompare;

	public string UIStatictics_LabelMinValue;

	public string UIStatictics_LabelMaxValue;

	public string UIStatictics_LabelAvgValue;

	public string UIStatictics_LabelCount;

	public string UIStatictics_LabelVariance;

	public string UIStatictics_LabelWorest5Per;

	public string UIStatictics_LabelMedian;

	public string UIStatictics_LabelSum;

	public string UIStatictics_ParamModuleFilter;

	public string UIStatictics_EventModuleFilter;

	public string UIStatictics_MsgModuleFilter;

	public string UIStatictics_SessionModuleFilter;

	public string UIStatictics_SessionModuleFilterEx;

	public string UIStatictics_ExecCount;

	public string UIStatictics_SuccCount;

	public string UIStatictics_DropCount;

	public string UIStatictics_FailCount;

	public string UIStatictics_SuccRatio;

	public string UIStatictics_TestProgress;

	public string UIStatictics_SpeedDelay;

	public string UIStatictics_CurrValue;

	public string UIStatictics_PacketSize;

	public string UIStatictics_Summary;

	public string UIStatictics_Group;

	public string UIStatictics_IdleTime;

	public string UIStatictics_StartTime;

	public string UIStatictics_StopTime;

	public string UIAnalysisViewStaticticsWin_Text;

	public string UIAnalysisShowOverDelayStr;

	public string UIAnalysisShowOverDelayCount;

	public string UIAnalysisShowOverDelayRatio;

	public string UIAnalysisConfigDelayMainKPIParam;

	public string UIAnalysisConfigDelayCustomDelay;

	public string UIAnalysisConfigDelayFixDelay;

	public string UIAnalysisConfigDelayMsgTime;

	public string UIAnalysisConfigDelayEventTime;

	public string UIAnalysisConditionTime;

	public string UIAnalysisConditionMileage;

	public string UIAnalysisConditionRatio;

	public string UIAnalysisTimeRatio;

	public string UIAnalysisDistanceRatio;

	public string UIAnalysisSampleRatio;

	public string UIAnalysisTimeRatio2;

	public string UIAnalysisMileageRatio2;

	public string UIAnalysisCustomEvent;

	public string UISelectEventExpressionCheck;

	public string UIAnaCategoryScanner;

	public string UIAnaPenetrationTotal;

	public string UIAnaPenetrationGridID;

	public string UIAnaPenetrationRoadID;

	public string UIAnaPenetrationRoadName;

	public string UIAnaPenetrationTotalMileage;

	public string UIAnaPenetrationPermMileage;

	public string UIAnaPenetrationNoPermMileage;

	public string UIAnaPenetrationRepeatMileage;

	public string UIAnaPenetrationPermRate;

	public string UIAnaPenetrationNoPermRate;

	public string UIAnaPenetrationRepeatMileageRate;

	public string UIAnaPenetrationRepeatRate;

	public string UIAnaPenetrationRepeatAvg;

	public string UIAnaPenetrationRepeatMax;

	public string UIAnaPenetrationRoadLevel;

	public string UIAnaPenetrationLineDistance;

	public string UIAnaPenetrationRepeatCount;

	public string UIAnaPenetrationLineID;

	public string UIAnaPenetrationLongitude;

	public string UIAnaPenetrationLatitude;

	public string UIAnaOverlayRatio;

	public string UIAnaSiteHeight;

	public string UIAnaMechanicalTilt;

	public string UIAnaElectricalTilt;

	public string UIAnaHalfPowerAngle;

	public string UIAnaScanOffFreqARFCNCount;

	public string UIAuthWinCategoryUE;

	public string UIAuthWinCategoryTask;

	public string UIAuthWinCategoryNetType;

	public string UIAuthWinCategoryReport;

	public string UIAuthWinCategoryAnalysis;

	public string UIAuthWinCategoryAutoTest;

	public string UIAuthWinCategoryHighSpeedTest;

	public string UIAuthWinCategoryMetroTest;

	public string UIAuthWinCategoryClientTool;

	public string UIAuthWinCategoryCTTLLogfile;

	public string UIAuthWinCategoryOpenCTTLLogfile;

	public string UIAuthWinHasAuth;

	public string UIAuthWinNoneAuth;

	public string RepaireLogfileWinSectorIDLength;

	public string RepaireLogfileWinSelectRuleFirst;

	public string UIMOSDetailAnaSoundAlign;

	public string UIMOSDetailAnaSoundNotAlign;

	public string UIMOSDetailAnaTimePoint;

	public string UIMOSDetailAnaTime;

	public string UIMOSDetailAnaRTPPackID;

	public string UIMOSDetailAnaLostPackCount;

	public string UIMOSDetailAnaPackDelay;

	public string UIHighSpeedRailKMLFile;

	public string UIHighSpeedRailDBVersionNotMatch;

	public string UICommon_Find;

	public string UICommon_Normal;

	public string UICommon_Abnormal;

	public string UICommonConfig_WarnColorSet;

	public string UICommonEvent;

	public string UICommonMessage;

	public string UICommonParam;

	public string UICommonPort;

	public string UICommonSheet;

	public string UICommonRule;

	public string UICommonLogfileFilter;

	public string UICommonLogfileFilterWithCPF;

	public string UICommonSafRafFilter;

	public string UICommonRafFilter;

	public string UICommonSiteFilter;

	public string UICommonZoneFilter;

	public string UICommonJsonFilter;

	public string UICommonFile;

	public string UICommonFileLog;

	public string UICommonFileOrg;

	public string UICommonFileNcf;

	public string UICommonFileQualcomm;

	public string UICommonFileDTLOG;

	public string UICommonFileECTI;

	public string UICommonFileTfi;

	public string UICommonFileCU;

	public string UICommonFileGesf;

	public string UICommonFileZd;

	public string UICommonFileMuxraw;

	public string UICommonFileHaiSi;

	public string UICommonFileASPS;

	public string UICommonFileNIO;

	public string UICommonFileText;

	public string UICommonFileCSV;

	public string UICommonModuleFile;

	public string UICommonDelete;

	public string UICommonType;

	public string UICommonVisible;

	public string UICommonLayerFile;

	public string UICommonBaiduMap;

	public string UICommonStar;

	public string UICommonCircle;

	public string UICommonSquare;

	public string UICommonDiamond;

	public string UICommonTime;

	public string UICommonName;

	public string UICommonLong;

	public string UICommonLat;

	public string UICommonAvg;

	public string UICommonMin;

	public string UICommonMax;

	public string UICommonTotal;

	public string UICommonPointCount;

	public string UICommonCount;

	public string UICommonCountEx;

	public string UICommonRange;

	public string UICommonValue;

	public string UICommonDelay;

	public string UICommonStartTime;

	public string UICommonProblemAddress;

	public string UICommonContinueDuration;

	public string UICommonContinueMileage;

	public string UICommonContinueDistance;

	public string UICommonDuration;

	public string UICommonSiteName;

	public string UICommonCellName;

	public string UICommonCellID;

	public string UICommonEARFCN;

	public string UICommonTotalTime;

	public string UICommonTotalDelay;

	public string UICommonTotalMileage;

	public string UICommonCellCount;

	public string UICommonOverlap;

	public string UICommonOverlapMax;

	public string UICommonPCIOrder;

	public string UICommonDistance;

	public string UICommonMileage;

	public string UICommonServCellDistance;

	public string UICommonNearestDistance;

	public string UICommonLineDistance;

	public string UICommonAvgDistance;

	public string UICommonMaxDistance;

	public string UICommonOrgValue;

	public string UICommonNewValue;

	public string UICommonDiffValue;

	public string UICommonValidCellCount;

	public string UICommonCoverDuration;

	public string UICommonCoverRatio;

	public string UICommonProblem;

	public string UICommonMissMatch;

	public string UICommonMeasure;

	public string UICommonSite;

	public string UICommonRow;

	public string UICommonCol;

	public string UICommonAddTemplateFirst;

	public string UICommonStopCheckFirst;

	public string UICommonStopTaskFirst;

	public string UICommonSelect;

	public string UICommon_ConnectServerFail;

	public string UICommonOpenFolder;

	public string UICommonServer;

	public string UICommonSaveNewLogfile;

	public string UICommonCity;

	public string UICommonOperator;

	public string UICommonAddress;

	public string UICommonSelectZoneFirst;

	public string UICommonSelectZoneMoreOne;

	public string UICommonCreateZoneFirst;

	public string UICommonMinRate;

	public string UICommonAllCell;

	public string UICommonServCell;

	public string UICommonNeighborCell;

	public string UICommonChinaMobile;

	public string UICommonChinaUnicom;

	public string UICommonChinaTelecom;

	public string UICommonChinaMobileName;

	public string UICommonChinaUnicomName;

	public string UICommonChinaTelecomName;

	public string UICommonChinaBroadnetName;

	public string UICommonTimeout;

	public string UICommonBeamIDFilterSet;

	public string UICommonAngle;

	public string UICommonRedecodeProgress;

	public string UICommonOriginSet;

	public string UICommonSelectLogfileFirst;

	public string UICommonCellCountDesc;

	public string UICommonAdd;

	public string UICommonEdit;

	public string UICommonBeforeTime;

	public string UICommonAfterTime;

	public string UICommonSucc;

	public string UICommonFail;

	public string UICommonSearch;

	public string UICommonMsgDetailNode;

	public string UICommonNotTip;

	public string UICommonAllNode;

	public string UICommonSelectAllNode;

	public string UICommonSelectParamMaxCount;

	public string UICommonStatEventCount;

	public string UICommonCreateDirFail;

	public string UICommonRetry;

	public string UICommonExitSoft;

	public string UICommonAddDivideConditionFirst;

	public string UICommonCurrent;

	public string UICommonSet;

	public string UICommonNoNR5GAndLTE;

	public string UICommonNoNR5G;

	public string UICommonNoLTE;

	public string UICommonResume;

	public string UICommonSelector;

	public string UICommonUpdateSucc;

	public string UICommonUpdateFail;

	public string UICommonRestartSoftNow;

	public string UICommonRestartSoftLater;

	public string UICommonStart;

	public string UICommonStop;

	public string UIQueryInfoFileName;

	public string UIQueryInfoTestDuration;

	public string UIQueryInfoTotalDistance;

	public string UIQueryInfoLayerName;

	public string UILogfileInfoSoftware;

	public string UILogfileInfoEQName;

	public string UILogfileInfoStartTime;

	public string UILogfileInfoEndTime;

	public string UILogfileInfoTestDuration;

	public string UILogfileInfoPath;

	public string UILogfileInfoTestCity;

	public string UILogfileInfoTester;

	public string UILogfileInfoTestCar;

	public string UILogfileInfoUEType;

	public string UILogfileInfoUENumber;

	public string UILogfileInfoDetailCallEvent;

	public string UIMapWin_QuitBuildingTest;

	public string UIMapWin_SiteCount;

	public string UIMapWin_CellCount;

	public string UIMapWin_Area;

	public string UIMapWin_AvgSiteDistance;

	public string UIMapWin_CoverageRadius;

	public string UIMaoWin_CloseCancel;

	public string UIMapConfig_InnerDivideMode;

	public string UIMapConfig_OuterExpandMode;

	public string UIMapConfig_ShapeSector;

	public string UIMapConfig_ShapeArrow;

	public string UIMapConfig_SiteImportCover;

	public string UIMapConfig_SiteImportAppend;

	public string UIMapConfig_LayerOffsetCaption;

	public string UIMapConfig_PointTrack;

	public string UIMapConfig_SiteLine;

	public string UIMapConfig_SiteStyle;

	public string UIMapConfig_OtherSet;

	public string UIMapConfig_MapInfoUseTabWidth;

	public string UIOpenView_CustomParam;

	public string UIOpenView_LineChart;

	public string UIOpenView_MsgDetailCustomParam;

	public string UIMergeDivideLogName;

	public string UIMergeDivideStartTime;

	public string UIMergeDivideEndTime;

	public string UIMergeDivideLogDuration;

	public string UIMergeDivideTaskName;

	public string UIGlobalQueryCurPage;

	public string UIGlobalQueryAllPages;

	public string UIGlobalQueryViewEvent;

	public string UIGlobalQueryViewMsg;

	public string UIGlobalQueryViewMsgDetail;

	public string UIGlobalQueryViewSiteInfo;

	public string UIGlobalQueryViewLongLat;

	public string UIGlobalQueryViewParam;

	public string UIGlobalQuerySheetLogfile;

	public string UIGlobalQuerySheetCellName;

	public string UIGlobalQuerySheetTime;

	public string UIGlobalQuerySheetResult;

	public string UIControlClose;

	public string UIControlSearch;

	public string UIControlSite;

	public string UIControlIndoorMap;

	public string UIControlBaiduOfflineMap;

	public string UIControlSiteRangeAnalysis;

	public string UISettingWinCategoryTest;

	public string UISettingWinCategoryCollect;

	public string UISettingWinCategoryShow;

	public string UISettingWinCategoryAdvance;

	public string UISettingWinCategoryOther;

	public string UISettingMsgOrgTiming;

	public string UISettingMsg3GPPTiming;

	public string UISettingMsgRS3GPPTiming;

	public string UISettingOperatorRuleMechanismDefault;

	public string UISettingOperatorRuleMechanismCM;

	public string UISettingOperatorRuleMechanismCU;

	public string UISettingOperatorRuleMechanismCT;

	public string UISettingOperatorRuleMechanismCB;

	public string UISettingRSFrequencyRaw;

	public string UISettingRSFrequency100Ms;

	public string UIDataImportPriority_Decode;

	public string UIDataImportPriority_View;

	public string UIExportLogfileNeighborParam;

	public string UIExportLogfileSiteInfo;

	public string UIExportLogfileLongLat;

	public string UIExportLogfileMsg;

	public string UIExportLogfileEvent;

	public string UIProcessConfigReAna;

	public string UIProcessConfigAna;

	public string UISpectrumWinSelValue;

	public string UISpectrumWinPeakValue;

	public string UISpeedWinPeakRate;

	public string UISpeedWin5GCoverRatio;

	public string UISpeedWinAvgRate;

	public string UISpeedWinHODelay;

	public string UIHTTPSetWeb;

	public string UISetFluctuation;

	public string UIColumnHeader;

	public string UISaveFileDialogFilter;

	public string UIMapCellLayerAnalysisValueColumn;

	public string UIMapCellLayerAnalysisColorColumn;

	public string UIMapCellLayerAnalysisSizeColumn;

	public string UIMapCellLayerAnalysisDisplayStyleColumn;

	public string UIMapCellLayerAnalysisDefaultSetting;

	public string UIThresholdDefaultModuleName;

	public string UIThresholdRange;

	public string UIThresholdDiscrete;

	public string UIThresholdAutoDiscrete;

	public string UIEventWinKeyEvent;

	public string TaskConfig_CaptionNormal;

	public string TaskConfig_CaptionATU;

	public string TaskConfig_ConnectionSetup;

	public string TaskConfig_ApplyToAllUECaption;

	public string TipDisconnectFirst;

	public string TipCannotChangeSceneWithConnecting;

	public string KPI;

	public string Type;

	public string Algorithm;

	public string Param;

	public string Network;

	public string Group;

	public string GroupCancel;

	public string MultiDimensionStatCancel;

	public string CustomBelongTypeCaption;

	public string CustomNetworkCaption;

	public string CustomGroupCaption;

	public string TipTipCaption;

	public string TipSelectOneFirst;

	public string TipCaptionNull;

	public string TipCaptionExists;

	public string TipParamCaptionNull;

	public string TipParamCaptionExists;

	public string TipParamFieldNull;

	public string TipParamSessionParamListNull;

	public string UIAmtuConnect;

	public string UIAmtuDisConnect;

	public string UIAmtuStart;

	public string UIAmtuStop;

	public string UIAmtuStartAll;

	public string UIAmtuStopAll;

	public string UIAmtuSubtractionProgress;

	public string UIAmtuStopScene;

	public string UIAmtuSelectNet;

	public string UIAmtuIsWorking;

	public string UIAmtuCellInitStart;

	public string UIAmtuAllCellInitStart;

	public string UIAmtuAllCellInitSuccess;

	public string UIAmtuNRInitStart;

	public string UIAmtuNRInitSuccess;

	public string UIAmtuNRUENoSignal;

	public string UIAmtuNRSceneSuccess;

	public string UIAmtuNRStopSubtraction;

	public string UIAmtuNRSubtractionEnd;

	public string UIAmtuNRSceneErrorMsg;

	public string UIAmtuNRStartErrorMsg;

	public string UIAmtuLteInitStart;

	public string UIAmtuLteInitSuccess;

	public string UIAmtuLteUENoSignal;

	public string UIAmtuLteSceneSuccess;

	public string UIAmtuLteStopSubtraction;

	public string UIAmtuLteSubtractionEnd;

	public string UIAmtuLteSceneErrorMsg;

	public string UIAmtuLteStartErrorMsg;

	public string UIAmtuCellTitle;

	public string UIAmtuButtonConnect;

	public string UIAmtuButtonConnected;

	public string UIElectricFtpUl;

	public string UIElectricFtpDl;

	public string UIElectricPing;

	public string UIMTUOpenSerialFail;

	public string UIMTUOpenSerial;

	public string UIMTUConnectState;

	public string UIMTUPowerOn;

	public string UIMTUPowerOFF;

	public string UIMTURest;

	public string UISigmaIsLoading;

	public string UISigmaDataUpload;

	public string UISigmaLogin;

	public string UISigmaLogout;

	public string UISigmaWebSocketError;

	public string UISigmaRightLoginInfo;

	public string UISigmaDisConnect;

	public string UISigmaDownloadPlan;

	public string UISigmaConfigError;

	public string UISigmaConfigHint;

	public string UISigmaPlanEmpty;

	public string UISigmaLocalPlanEmpty;

	public string UISigmaCannotChangeMode;

	public string TaskConfig_CaptionSigma;

	public string UISigmaColumnFile;

	public string UISigmaColumnStatus;

	public string UISigmaColumnProgress;

	public string UISigmaWarningNotStart;

	public string UISigmaWarningUploading;

	public string UISigmaWarningFinish;

	public string UISigmaWarningStop;

	public string UISigmaWarningUnknown;

	public string UIFrequency;

	public string UIAttenuatorDesc;

	public string UITestPeriodDesc;

	public string UITestPlanVersion;

	public string UILoadhistoryTestplan;

	public string UIGetTestplanSuccess;

	public string UIGetTestplanFail;

	public string UIGetTestplanFailNone;

	public string UIReportExportDir;

	public string UINoPortableDiskExist;

	public string UIDiskFreeSpaceNotEnough;

	public string UIAtDgvCmd;

	public string UIAtDgvRemark;

	public string UIAtDgvOrder;

	public string UIAtDgvTimeSpan;

	public string UIAtDgvTimes;

	public string UIAtDgvSend;

	public string UIParamQuadrantAnalysisTitle;

	public string UIXAxis;

	public string UIYAxis;

	public string UIParamQuadrantAnalysisCompareMultiLogHint;

	public string UIAmtuMatrixCommon;

	public string UIAmtuMatrixChannel;

	public string UIAmtuMatrixSettingChannelNum;

	public string UIAmtuMatrixSettingNetwork;

	public string UIAmtuMatrixSettingCell;

	public string UIAmtuMatrixSettingAnt;

	public string UIAmtuMatrixOperator;

	public string UIAmtuMatrixSet;

	public string UIAmtuMatrixGet;

	public string UIAmtuMatrixStart;

	public string UIAmtuMatrixChannelNotEqualsMsg;

	public string UIAmtuMatrixChannelCompensation;

	public string UIAmtuMatrixGroupStop;

	public string UIAmtuMatrixWhichGroup;

	public string UIAmtuMatrixGroupName1;

	public string UIAmtuMatrixGroupName2;

	public string UIAmtuMatrixGroupName3;

	public string UIAmtuMatrixInputTitle;

	public string UIAmtuMatrixContextMenuGroup1;

	public string UIAmtuMatrixContextMenuGroup2;

	public string UIAmtuMatrixContextMenuGroup3;

	public string UIAndroidDeviceSwitch;

	public string UIAndroidDeviceSwitchTip;

	public string UIAndroidReboot;

	public string UIAndroidVolumeUp;

	public string UIAndroidVolumeDown;

	public string UIAndroidMute;

	public string UIAndroidCellularNetOpen;

	public string UIAndroidCellularNetClose;

	public string UIAndroidScreenCut;

	public string UIAndroidBack;

	public string UIAndroidHome;

	public string UIAndroidAppSwitch;

	public string UIAndroidRebootTip;

	public string UIAndroidSwipeTip;

	public string UIUploadFileProtocol;

	public string UIUploadFileHost;

	public string UIUploadFileUserName;

	public string UIUploadFilePassword;

	public string UIUploadFilePort;

	public string UIUploadFilePath;

	public string UIUploadFileBrowseServer;

	public string UIUploadFileClearList;

	public string UIUploadFileSelectFiles;

	public string UIUploadFileStart;

	public string UIUploadFileStop;

	public string UIUploadFileSelectAll;

	public string UIUploadFileReverse;

	public string UIUploadFileCancel;

	public string UIUploadFileNoFileSelect;

	public string UIUploadFileNoFileNoImport;

	public string UIUploadFileUploadPathNoEmpty;

	public string UITitleSite;

	public string UITitleDistance;

	public string UIRestoreDefault;

	public string UIOneClickQual4GUnlock;

	public string UIOneClickQual5GUnlock;

	public string UIOneClickHaisi4GUnlock;

	public string UICommandExecute;

	public string UIMapWin_DefineRoute;

	public string UIMergeDivideExportDir;

	public string UIMergeDivideExportDirNoEmpty;

	internal static Language AofaCKJ4kebgPLWZPlu4;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Language()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Language()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		QDsFtuJ4SbQQMtZIWdUd();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool syCc5kJ41QqVOWh8PX6B()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Language qi7B8aJ4vGqU2BVY5yhb()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QDsFtuJ4SbQQMtZIWdUd()
	{
	}
}
