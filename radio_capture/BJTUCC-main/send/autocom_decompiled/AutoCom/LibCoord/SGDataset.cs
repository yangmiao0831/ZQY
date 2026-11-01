using System;
using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class SGDataset : SGDatasetUtils
{
	public const int UEMsgDir = 255;

	public const int SC_DeviceID_FengHuo = 268700417;

	public const int SC_DeviceID_PCTEL = 268832769;

	public const int SC_DeviceID_YingZe = 269030145;

	public const int SC_DeviceID_OPTI = 269228289;

	public const int SC_DeviceID_Transcom = 269558017;

	public const int EventParamCode = 524291;

	public const int MsgParamCode = 1245188;

	public const int LogNameParamCode = 1895825408;

	public const int EventID_CustomEventBase = 1879048192;

	public const int EventID_IntelligentEventBase = 1879113728;

	public const int EventID_PingTimeout = 1610746883;

	public const int EventID_AttachFailure = 1610809857;

	public const int EventID_AttachSuccess = 1610809858;

	public const int EventID_UEConnectionRestored = 1610679044;

	public const int EventID_CommandSend = 1610678279;

	public const int EventID_CommandResponse = 1610678280;

	public const int BinLogfile_BinPointIndex = 1912209408;

	public const int BinLogfile_BinID = 1912209409;

	public const int BinLogfile_PointIndex = 1912209413;

	public const int BinLogfile_EndPointIndex = 1912209414;

	public const int BinOrgRelation_PointIndex = 1912274944;

	public const int BinOrgRelation_BinID = 1912274946;

	public const int EventID_SAHORequest = 1610813184;

	public const int EventID_LTEHORequest = 1610811136;

	public const int EventID_EN_DCHORequest = 1610812163;

	public const int EventID_POLQAComputed = 1610678789;

	public const int TestPlanInfo_PointIndex = 196608;

	public const int TestPlanInfo_ID = 196609;

	public const int TestPlanInfo_BufferSize = 196610;

	public const int TestPlanInfo_Buffer = 196611;

	public const int UEInfo_PortID = 589826;

	public const int UEInfo_DeviceID = 589827;

	public const int UEInfo_DeviceName = 589828;

	public const int UEInfo_IMEI = 589829;

	public const int UEInfo_IMSI = 589830;

	public const int UEInfo_ChipInfo = 589831;

	public const int UEInfo_FirmwareInfo = 589832;

	public const int UEInfo_EquipmentType = 589835;

	public const int UEInfo_Model = 589839;

	public const int UEInfo_DataIP = 589843;

	public const int UEInfo_WifiIP = 589844;

	public const int UEInfo_ESN = 589845;

	public const int UEInfo_PhoneNumber = 589846;

	public const int UEInfo_Operator = 589847;

	public const int UEInfo_SystemOSType = 589848;

	public const int UEInfo_SDCardInfo = 589849;

	public const int UEInfo_RamInfo = 589850;

	public const int UEInfo_FreeSDSpace = 589851;

	public const int UEInfo_BaseBandVersion = 589852;

	public const int UEInfo_Processor = 589853;

	public const int UEInfo_MobileResolution = 589854;

	public const int UEInfo_Manufacturer = 589855;

	public const int LogFileInfo_PointIndex = 65536;

	public const int LogFileInfo_ID = 65537;

	public new const int LogFileInfo_SoftwareName = 65538;

	public new const int LogFileInfo_SoftwareVersion = 65539;

	public const int LogFileInfo_TotalSizeInByte = 65540;

	public const int LogFileInfo_LoadedSizeInByte = 65541;

	public const int LogFileInfo_LoadDropedSizeInByte = 65542;

	public const int LogFileInfo_DecodedSizeInByte = 65543;

	public const int LogFileInfo_TotalPointCount = 65544;

	public const int LogFileInfo_LoadedPointCount = 65545;

	public const int LogFileInfo_DropedPointCount = 65546;

	public const int LogFileInfo_DecodedPointCount = 65547;

	public new const int LogFileInfo_LogTotalDurationTime = 65548;

	public new const int LogFileInfo_LogBeginLogTime = 65549;

	public new const int LogFileInfo_LogEndLogTime = 65550;

	public new const int LogFileInfo_LogTimeZone = 65551;

	public new const int LogFileInfo_LogFormatType = 65552;

	public const int LogFileInfo_UserCommentsInfo = 65553;

	public const int LogFileInfo_CoordinateSystem = 65554;

	public const int LogFileInfo_Log_TotalDistance = 65555;

	public new const int LogFileInfo_ScanNetWorkSet = 65556;

	public new const int LogFileInfo_HasBIN = 65557;

	public const int LogFileInfo_HasFilter = 65558;

	public const int LogFileInfo_UeManagerVersion = 65559;

	public const int LogFileInfo_LisenseIDInfo = 65560;

	public const int LogFileInfo_TestPC_CPUInfo = 65561;

	public const int LogFileInfo_TestPC_MemInfo = 65562;

	public const int LogFileInfo_TestPC_DiskInfo = 65563;

	public const int LogFileInfo_LogFileIDInfo = 65564;

	public new const int LogFileInfo_EncryptKey = 65565;

	public new const int LogFileInfo_GPSDataSource = 65566;

	public new const int LogFileInfo_LogNormalEnd = 65567;

	public new const int LogFileInfo_LogOreinName = 65568;

	public new const int LogFileInfo_ComputerID = 65569;

	public new const int LogFileInfo_ProductionID = 65570;

	public new const int LogFileInfo_SystemModel = 65571;

	public new const int LogFileInfo_CPU = 65572;

	public new const int LogFileInfo_RAM = 65573;

	public new const int LogFileInfo_WindowVersion = 65574;

	public new const int LogFileInfo_PCUserName = 65575;

	public new const int LogFileInfo_ComputerModel = 65576;

	public const int UEInfo_RafEncryptKey = 589857;

	public const int CallManagerStateInfo_RoamPreference = 983047;

	public new const int CallManagerStateInfo_ServiceStatus = 983052;

	public new const int UENetworkStateInfo_CampedNetworkState = 1179651;

	public const int NR5gDCIFormatStatInfo_PDCCH_UL_Grant_Count = 329646087;

	public const int NR5gDCIFormatStatInfo_PDCCH_DL_Grant_Count = 329646088;

	public const int UEMeasInfoQos_PointIndex = 2359296;

	public const int UEMeasInfoQos_EndPointIndex = 2359297;

	public const int UEMeasInfoQos_SIMCount = 2359298;

	public const int UEMeasInfoQos_SIMIndex = 2359299;

	public const int UEMeasInfoQos_SIMOperator = 2359300;

	public const int UEMeasInfoQos_PhoneNumber = 2359301;

	public const int UEMeasInfoQos_NetworkType = 2359302;

	public const int UEMeasInfoQos_NetworkStatus = 2359303;

	public const int UEMeasInfoQos_NetworkName = 2359304;

	public const int UEMeasInfoQos_Roam = 2359305;

	public const int UEMeasInfoQos_ServiceStatus = 2359306;

	public const int UEMeasInfoQos_DigitalCellularStatus = 2359307;

	public const int UEMeasInfoQos_PhoneStatus = 2359308;

	public const int UEMeasInfoQos_APN = 2359309;

	public const int UEMeasInfoQos_MCC = 2359310;

	public const int UEMeasInfoQos_MNC = 2359311;

	public const int UEMeasInfoQos_InnerIPAddresses = 2359312;

	public const int UEMeasInfoQos_OutsideIPAddresses = 2359313;

	public const int UEMeasInfoQos_ARFCN = 2359314;

	public const int UEMeasInfoQos_PCI = 2359315;

	public const int UEMeasInfoQos_RSRP = 2359316;

	public const int UEMeasInfoQos_SINR = 2359317;

	public const int UEMeasInfoQos_WIFISignal = 2359318;

	public const int UEMeasInfoQos_WIFIIP = 2359319;

	public const int UEMeasInfoQos_CurrentBatteryInfo = 2359320;

	public const int UEMeasInfoQos_CurrentRAMInfo = 2359321;

	public const int UEMeasInfoQos_CurrentCPUInfo = 2359322;

	public const int UEMeasInfoQos_CurrentTemperature = 2359323;

	public const int UEMeasInfoQos_ID = 2359324;

	public const int IndoorFloorInfo_PointIndex = 1761935360;

	public const int IndoorFloorInfo_ID = 1761935361;

	public const int IndoorFloorInfo_EndPointIndex = 1761935362;

	public const int IndoorFloorInfo_FloorIndex = 1761935363;

	public const int IndoorFloorInfo_FloorName = 1761935364;

	public const int IndoorFloorInfo_FloorType = 1761935365;

	public const int IndoorFloorInfo_BuildingName = 1761935366;

	public const int IndoorFloorInfo_BuildingType = 1761935367;

	public const int IndoorFloorInfo_IndoorTestType = 1761935368;

	public const int IndoorFloorInfo_FloorNumber = 1761935369;

	public const int GPSInfo_E2_PointIndex = 3604480;

	public const int GPSInfo_E2_ID = 3604481;

	public const int GPSInfo_E2_Speed_CEP68 = 3604482;

	public const int GPSInfo_E2_Level_CEP68 = 3604483;

	public const int GPSInfo_E2_Altitude_CEP68 = 3604484;

	public const int GPSInfo_E2_Speed_CEP95 = 3604485;

	public const int GPSInfo_E2_Level_CEP95 = 3604486;

	public const int GPSInfo_E2_Altitude_CEP95 = 3604487;

	public const int GPSInfo_E2_Speed_RMS = 3604488;

	public const int GPSInfo_E2_Level_RMS = 3604489;

	public const int GPSInfo_E2_Altitude_RMS = 3604490;

	public const int GPSInfo_Reference_PointIndex = 3670016;

	public const int GPSInfo_Reference_ID = 3670017;

	public const int GPSInfo_Reference_LockState = 3670018;

	public const int GPSInfo_Reference_UTCTime = 3670019;

	public const int GPSInfo_Reference_Longitude = 3670020;

	public const int GPSInfo_Reference_Latitude = 3670021;

	public const int GPSInfo_Reference_Altitude = 3670022;

	public const int GPSInfo_Reference_Speed = 3670023;

	public const int GPSInfo_Reference_GroundDegree = 3670024;

	public const int GPSInfo_Reference_SatelliteNum = 3670025;

	public const int GPSInfo_Reference_CumulativeDistance = 3670026;

	public const int GPSInfo_Reference_InstantDistance = 3670027;

	public const int GPSInfo_Reference_GroudCourse = 3670028;

	public const int GPSInfo_Reference_FloorIndex = 3670029;

	public const int GPSInfo_Reference_IsReal = 3670030;

	public const int GPSInfo_Reference_Altitude_aPressure = 3670031;

	public const int GPSInfo_Reference_INS_State = 3670032;

	public const int GPSInfo_Reference_POS_State = 3670033;

	public const int GPSInfo_Reference_AzimuthStandardDeviation = 3670034;

	public const int SatelliteInfo_PointIndex = 1720975360;

	public const int SatelliteInfo_ID = 1720975361;

	public const int SatelliteInfo_SatelliteState = 1720975362;

	public const int SatelliteInfo_HighlevelState = 1720975363;

	public const int SatelliteInfo_LowLevelState = 1720975364;

	public const int SatelliteInfo_RSRP = 1720975365;

	public const int SatelliteInfo_SINR = 1720975366;

	public const int SatelliteInfo_BroadcastARFCN = 1720975367;

	public const int SatelliteInfo_TCHARFCN = 1720975368;

	public const int SatelliteInfo_BeamID = 1720975369;

	public const int GNSS_Source_PointIndex = 1721040896;

	public const int GNSS_Source_ID = 1721040897;

	public const int GNSS_Source_Reserved = 1721040898;

	public const int GNSS_Source_Content = 1721040899;

	public const int INS_Source_PointIndex = 1721106432;

	public const int INS_Source_ID = 1721106433;

	public const int INS_Source_Reserved = 1721106434;

	public const int INS_Source_Content = 1721106435;

	public const int GNSS_Aux_Source_PointIndex = 1721171968;

	public const int GNSS_Aux_Source_ID = 1721171969;

	public const int GNSS_Aux_Source_Reserved = 1721171970;

	public const int GNSS_Aux_Source_Content = 1721171971;

	public const int GPSInfo_Aux_PointIndex = 1721237504;

	public const int GPSInfo_Aux_ID = 1721237505;

	public const int GPSInfo_Aux_LockState = 1721237506;

	public const int GPSInfo_Aux_UTCTime = 1721237507;

	public const int GPSInfo_Aux_Longitude = 1721237508;

	public const int GPSInfo_Aux_Latitude = 1721237509;

	public const int GPSInfo_Aux_Altitude = 1721237510;

	public const int GPSInfo_Aux_Speed = 1721237511;

	public const int GPSInfo_Aux_GroundDegree = 1721237512;

	public const int GPSInfo_Aux_SatelliteNum = 1721237513;

	public const int GPSInfo_Aux_CumulativeDistance = 1721237514;

	public const int GPSInfo_Aux_InstantDistance = 1721237515;

	public const int GPSInfo_Aux_GroudCourse = 1721237516;

	public const int GPSInfo_Aux_FloorIndex = 1721237517;

	public const int GPSInfo_Aux_IsReal = 1721237518;

	public const int GPSInfo_Aux_Altitude_aPressure = 1721237519;

	public const int GPSInfo_Aux_GroundLevel = 1721237520;

	public const int GPSInfo_Aux_vertical_speed = 1721237521;

	public const int GPSInfo_Aux_rtk_quality = 1721237522;

	public const int GPSInfo_Aux_rtk_number = 1721237523;

	public const int GyroScopeInfo_Angle = 3342338;

	public const int SiteNBInfo_CellName = -1011613690;

	public const int TestManagerInfo_PointIndex = 720896;

	public const int TestManagerInfo_ID = 720897;

	public const int TestManagerInfo_TestScene = 720898;

	public const int TestManagerInfo_TestSubScene = 720899;

	public new const int TestManagerInfo_Tester = 720900;

	public const int TestManagerInfo_TestProvince = 720901;

	public new const int TestManagerInfo_TestCity = 720902;

	public const int TestManagerInfo_TestSite = 720903;

	public const int TestManagerInfo_TestNetwork = 720904;

	public const int TestManagerInfo_TestBaseStation = 720905;

	public const int TestManagerInfo_TestNobeBSector = 720906;

	public const int TestManagerInfo_TestBuilding_Longitude = 720907;

	public const int TestManagerInfo_TestBuilding_Latitude = 720908;

	public const int TestManagerInfo_TestOperatorNetwork = 720909;

	public new const int TestManagerInfo_TestCar = 720910;

	public new const int TestManagerInfo_UEType = 720911;

	public new const int TestManagerInfo_UENumber = 720912;

	public new const int TestManagerInfo_DetailCallEvent = 720913;

	public const int TestManagerInfo_TestBuildingLocation = 720914;

	public const int TestManagerInfo_TestMode = 720915;

	public const int TestManagerInfo_TestSerial = 720916;

	public new const int TestManagerInfo_TestOperatorID = 720917;

	public const int TestManagerInfo_TestServiceType = 720918;

	public const int TestManagerInfo_TestNetworkType = 720919;

	public const int TestManagerInfo_TestInfoJson = 720920;

	public const int TestManagerInfo_TestItem = 720921;

	public const int TestManagerInfo_TestBuilding = 720922;

	public const int TestManagerInfo_TestFloor = 720923;

	public const int TestManagerInfo_MOSServerInfo = 720924;

	public const int TestManagerInfo_TestProvinceCode = 720925;

	public const int TestManagerInfo_TestCityProper = 720926;

	public const int TestManagerInfoV2_PointIndex = 2555904;

	public const int TestManagerInfoV2_ID = 2555905;

	public const int TestManagerInfoV2_TestScene = 2555906;

	public const int TestManagerInfoV2_TestSubScene = 2555907;

	public const int TestManagerInfoV2_OperatorID = 2555908;

	public const int TestManagerInfoV2_Network = 2555909;

	public const int TestManagerInfoV2_TaskType = 2555910;

	public const int TestManagerInfoV2_Provice = 2555911;

	public const int TestManagerInfoV2_city = 2555912;

	public const int TestManagerInfoV2_StartLongtitude = 2555913;

	public const int TestManagerInfoV2_StartLatitude = 2555914;

	public const int TestManagerInfoV2_StartLocation = 2555915;

	public const int TestManagerInfoV2_TestConfigJson = 2555916;

	public const int NeighborParamSet = -1011613689;

	public const int EventTYpe_Spectrum_Analysis_Start = 1610743830;

	public const int EventTYpe_Spectrum_Analysis_Stop = 1610743831;

	public const int NB_RSRP_PointIndex = 589889536;

	public const int NB_RSRP = 589889540;

	public const int DownlinkMeasInfo_PCell_RSRP = 5242885;

	public const int HexDataInfo_BufferSize = 131075;

	public const int HexDataInfo_Buffer = 131076;

	public const int VoiceStatusInfo_VoiceFrameStatus = 2490370;

	public const int TestInfoSummary_PointIndex = 458752;

	public const int TestInfoSummary_TestSessionType = 458755;

	public const int TestCommonInfo_PointIndex = 1048576;

	public const int TestCommonInfo_ID = 1048577;

	public const int TestCommonInfo_CmdDirection = 1048578;

	public const int TestCommonInfo_CmdID = 1048579;

	public const int TestCommonInfo_CmdTime = 1048580;

	public const int TestCommonInfo_CmdContent = 1048582;

	public const int VoiceMosPESQTest_PointIndex = 66191360;

	public const int VoiceMosPESQTest_ID = 66191361;

	public const int VoiceMosPESQTest_Reserved = 66191362;

	public const int VoiceMosPESQTest_VoiceTestSessionIndex = 66191363;

	public const int VoiceMosPESQTest_SampleRate = 66191364;

	public const int VoiceMosPESQTest_AlgoMode = 66191365;

	public const int VoiceMosPESQTest_SourceWAVFile = 66191366;

	public const int VoiceMosPESQTest_CalculateResult = 66191367;

	public const int VoiceMosPESQTest_Reason = 66191368;

	public const int VoiceMosPESQTest_RecordWAVFile = 66191369;

	public const int VoiceMosPESQTest_Direction = 66191370;

	public const int VoiceMosPESQTest_PESQ_Score = 66191371;

	public const int VoiceMosPESQTest_PESQ_LQ = 66191372;

	public const int VoiceMosPESQTest_MeanDelay = 66191373;

	public const int VoiceMosPESQTest_MinDelay = 66191374;

	public const int VoiceMosPESQTest_MaxDelay = 66191375;

	public const int VoiceMosPOLQATest_PointIndex = 66256896;

	public const int VoiceMosPOLQATest_ID = 66256897;

	public const int VoiceMosPOLQATest_Reserved = 66256898;

	public const int VoiceMosPOLQATest_VoiceTestSessionIndex = 66256899;

	public const int VoiceMosPOLQATest_SampleRate = 66256900;

	public const int VoiceMosPOLQATest_AlgoMode = 66256901;

	public const int VoiceMosPOLQATest_SourceWAVFile = 66256902;

	public const int VoiceMosPOLQATest_CalculateResult = 66256903;

	public const int VoiceMosPOLQATest_Reason = 66256904;

	public const int VoiceMosPOLQATest_RecordWAVFile = 66256905;

	public const int VoiceMosPOLQATest_Direction = 66256906;

	public const int VoiceMosPOLQATest_SDKVersion = 66256907;

	public const int VoiceMosPOLQATest_P863Version = 66256908;

	public const int VoiceMosPOLQATest_POLQA_Score = 66256909;

	public const int VoiceMosPOLQATest_MeanDelay = 66256910;

	public const int VoiceMosPOLQATest_MinDelay = 66256911;

	public const int VoiceMosPOLQATest_MaxDelay = 66256912;

	public const int VoiceMosPOLQATest_Jitter = 66256913;

	public const int VoiceMosPOLQATest_UpdateIndex = 66256914;

	public const int VoiceMosPOLQATest_MOSCalcType = 66256915;

	public const int VoiceMosPOLQATest_FileName = 66256917;

	public const int VoiceMosPOLQATest_BufferSize = 66256919;

	public const int VoiceMosPOLQATest_Buffer = 66256920;

	public const int CTTLVMOSFrameInfo_PointIndex = 271974400;

	public const int CTTLVMOSFrameInfo_ID = 271974402;

	public const int CTTLVMOSFrameInfo_SessionType = 271974404;

	public const int CTTLVMOSFrameInfo_GUID = 271974405;

	public const int CTTLVMOSFrameInfo_ValidFrmStart = 271974406;

	public const int CTTLVMOSFrameInfo_TotalFrameLossCount = 271974407;

	public const int CTTLVMOSFrameInfo_MaxContinueLossCount = 271974408;

	public const int CTTLVMOSFrameInfo_AudioMosMale = 271974409;

	public const int CTTLVMOSFrameInfo_AudioMosFemale = 271974410;

	public const int CTTLVMOSFrameInfo_SSIMAvg = 271974411;

	public const int CTTLVMOSFrameInfo_AVSyncAvg = 271974412;

	public const int CTTLVMOSFrameInfo_TotalStall = 271974415;

	public const int CTTLVMOSFrameInfo_FileName = 271974417;

	public const int CTTLVMOSFrameInfo_ErrorNO = 271974420;

	public const int CTTLVMOSFrameInfo_BufferSize = 271974442;

	public const int CTTLVMOSFrameInfo_Buffer = 271974443;

	public const int CTTLVMOSFrameInfo_VideoMos = 271974427;

	public const int CTTLVMOSFrameInfo_StallCount = 271974413;

	public const int CTTLVMOSFrameInfo_ResolutionX = 271974422;

	public const int CTTLVMOSFrameInfo_ResolutionY = 271974423;

	public const int VoLTERTPAudioTxPacket_PointIndex = 48496640;

	public const int VoLTERTPAudioTxPacket_AMRType = 48496649;

	public const int CellChangeInfo_PointIndex = 1114112;

	public const int CellChangeInfo_EndPointIndex = 1114113;

	public const int CellChangeInfo_CellChageType = 1114117;

	public const int CellChangeInfo_TargetNetwork = 1114119;

	public const int CellChangeInfo_TargetFrequency = 1114120;

	public const int CellChangeInfo_TargetCellID = 1114121;

	public const int CellChangeInfo_SourceNetwork = 1114122;

	public const int CellChangeInfo_SourceFrequency = 1114123;

	public const int CellChangeInfo_SourceCellID = 1114124;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_PointIndex = 336527360;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_ID = 336527361;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_CumulativeSize = 336527362;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_CumulativeThr = 336527363;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_InstSize = 336527364;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_InstThr = 336527365;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_QosFlowIndex = 336527366;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_QosFlow_DDN = 336527367;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_QosFlow_5QI = 336527368;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_SDAP_QosFlow_PDUSessionIndex = 336527369;

	public const int NR5gThroughputInfo_DL_SDAP_ByQosFlow_DRBIdentity = 336527370;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_PointIndex = 336592896;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_ID = 336592897;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_CumulativeSize = 336592898;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_CumulativeThr = 336592899;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_InstSize = 336592900;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_InstThr = 336592901;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_QosFlowIndex = 336592902;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_QosFlow_DDN = 336592903;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_QosFlow_5QI = 336592904;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_SDAP_QosFlow_PDUSessionIndex = 336592905;

	public const int NR5gThroughputInfo_UL_SDAP_ByQosFlow_DRBIdentity = 336592906;

	public const int NR5gPDUEstablishSession_PointIndex = 343539712;

	public const int NR5gPDUEstablishSession_SessionIndex = 343539714;

	public const int NR5gPDUEstablishSession_SessionResult = 343539715;

	public const int NR5gPDUEstablishSession_SessionReason = 343539716;

	public const int NR5gPDUEstablishSession_PDUSessionType = 343539717;

	public const int NR5gPDUEstablishSession_Delay = 343539718;

	public const int NR5gPDUEstablishSession_ID = 343539719;

	public const int NR5gPDUEstablishSession_ServerIP = 343539720;

	public const int NR5gPDUEstablishSession_Reserved = 343539721;

	public const int NR5gPDUEstablishSession_AMBR_DL = 343539722;

	public const int NR5gPDUEstablishSession_AMBR_UL = 343539723;

	public const int NR5gPDUEstablishSession_SSCMode = 343539724;

	public const int NR5gPDUEstablishSession_DNN = 343539725;

	public const int NR5gPDUEstablishSession_PDUSessionID = 343539726;

	public const int NR5gPDUEstablishSession_PDUSessionIsNew = 343539727;

	public const int NR5gQosFlowInfo_PointIndex = 343605248;

	public const int NR5gQosFlowInfo_QFI = 343605249;

	public const int NR5gQosFlowInfo_GFBR_DL = 343605250;

	public const int NR5gQosFlowInfo_GFBR_UL = 343605251;

	public const int NR5gQosFlowInfo_MFBR_DL = 343605252;

	public const int NR5gQosFlowInfo_MFBR_UL = 343605253;

	public const int NR5gQosFlowInfo_Averagewindow = 343605254;

	public const int NR5gQosFlowInfo_5QI = 343605255;

	public const int NR5gQosFlowInfo_PDUSessionID = 343605256;

	public const int NR5gQosFlowInfo_FIndex = 343605257;

	public const int NR5gQosFlowInfo_PDUQosConfigSessionIndex = 343605258;

	public const int NR5gQosFlowInfo_ID = 343605259;

	public const int LTENSAHandoverSession_PointIndex = 56754176;

	public const int LTENSAHandoverSession_NSAHandoverMode = 56754181;

	public const int LTENSAHandoverSession_SourceFreq = 56754182;

	public const int LTENSAHandoverSession_SourcePCI = 56754183;

	public const int LTENSAHandoverSession_TargetFreq = 56754184;

	public const int LTENSAHandoverSession_TargetPCI = 56754185;

	public const int LTENSAHandoverSession_ctrlPlaneDelay = 56754186;

	public const int GSMServingCellDownlinkMeasInfo_PointIndex = 655425536;

	public const int GSMServingCellDownlinkMeasInfo_BCCH = 655425538;

	public const int GSMServingCellDownlinkMeasInfo_BSIC = 655425539;

	public const int GSMServingCellDownlinkMeasInfo_RxLev = 655425540;

	public const int GSMServingCellDownlinkMeasInfo_C2I = 655425541;

	public const int GSMServingCellDownlinkMeasInfo_Distance = 655425542;

	public const int GSMServingCellDownlinkMeasInfo_CellCategory = 655425543;

	public const int GSMServingCellDownlinkMeasInfo_ID = 655425544;

	public const int GSMServingCellDownlinkMeasInfo_SiteInfoIndex = 655425545;

	public const int GSMServingCellDownlinkMeasInfo_Angle = 655425546;

	public const int GSMServingNeighborMeasInfo_0_PointIndex = 656670720;

	public const int GSMServingNeighborMeasInfo_0_EndPointIndex = 656670721;

	public const int GSMServingNeighborMeasInfo_0_BCCH = 656670722;

	public const int GSMServingNeighborMeasInfo_0_BSIC = 656670723;

	public const int GSMServingNeighborMeasInfo_0_RxLev = 656670724;

	public const int GSMServingNeighborMeasInfo_0_Distance = 656670725;

	public const int GSMServingNeighborMeasInfo_0_CellCategory = 656670726;

	public const int GSMServingNeighborMeasInfo_0_ID = 656670727;

	public const int GSMServingNeighborMeasInfo_0_SiteInfoIndex = 656670728;

	public const int GSMServingNeighborMeasInfo_1_PointIndex = 656736256;

	public const int GSMServingNeighborMeasInfo_1_EndPointIndex = 656736257;

	public const int GSMServingNeighborMeasInfo_1_BCCH = 656736258;

	public const int GSMServingNeighborMeasInfo_1_BSIC = 656736259;

	public const int GSMServingNeighborMeasInfo_1_RxLev = 656736260;

	public const int GSMServingNeighborMeasInfo_1_Distance = 656736261;

	public const int GSMServingNeighborMeasInfo_1_CellCategory = 656736262;

	public const int GSMServingNeighborMeasInfo_1_ID = 656736263;

	public const int GSMServingNeighborMeasInfo_1_SiteInfoIndex = 656736264;

	public const int GSMServingNeighborMeasInfo_2_PointIndex = 656801792;

	public const int GSMServingNeighborMeasInfo_2_EndPointIndex = 656801793;

	public const int GSMServingNeighborMeasInfo_2_BCCH = 656801794;

	public const int GSMServingNeighborMeasInfo_2_BSIC = 656801795;

	public const int GSMServingNeighborMeasInfo_2_RxLev = 656801796;

	public const int GSMServingNeighborMeasInfo_2_Distance = 656801797;

	public const int GSMServingNeighborMeasInfo_2_CellCategory = 656801798;

	public const int GSMServingNeighborMeasInfo_2_ID = 656801799;

	public const int GSMServingNeighborMeasInfo_2_SiteInfoIndex = 656801800;

	public const int GSMServingNeighborMeasInfo_3_PointIndex = 656867328;

	public const int GSMServingNeighborMeasInfo_3_EndPointIndex = 656867329;

	public const int GSMServingNeighborMeasInfo_3_BCCH = 656867330;

	public const int GSMServingNeighborMeasInfo_3_BSIC = 656867331;

	public const int GSMServingNeighborMeasInfo_3_RxLev = 656867332;

	public const int GSMServingNeighborMeasInfo_3_Distance = 656867333;

	public const int GSMServingNeighborMeasInfo_3_CellCategory = 656867334;

	public const int GSMServingNeighborMeasInfo_3_ID = 656867335;

	public const int GSMServingNeighborMeasInfo_3_SiteInfoIndex = 656867336;

	public const int GSMServingNeighborMeasInfo_4_PointIndex = 656932864;

	public const int GSMServingNeighborMeasInfo_4_EndPointIndex = 656932865;

	public const int GSMServingNeighborMeasInfo_4_BCCH = 656932866;

	public const int GSMServingNeighborMeasInfo_4_BSIC = 656932867;

	public const int GSMServingNeighborMeasInfo_4_RxLev = 656932868;

	public const int GSMServingNeighborMeasInfo_4_Distance = 656932869;

	public const int GSMServingNeighborMeasInfo_4_CellCategory = 656932870;

	public const int GSMServingNeighborMeasInfo_4_ID = 656932871;

	public const int GSMServingNeighborMeasInfo_4_SiteInfoIndex = 656932872;

	public const int GSMServingNeighborMeasInfo_5_PointIndex = 656998400;

	public const int GSMServingNeighborMeasInfo_5_EndPointIndex = 656998401;

	public const int GSMServingNeighborMeasInfo_5_BCCH = 656998402;

	public const int GSMServingNeighborMeasInfo_5_BSIC = 656998403;

	public const int GSMServingNeighborMeasInfo_5_RxLev = 656998404;

	public const int GSMServingNeighborMeasInfo_5_Distance = 656998405;

	public const int GSMServingNeighborMeasInfo_5_CellCategory = 656998406;

	public const int GSMServingNeighborMeasInfo_5_ID = 656998407;

	public const int GSMServingNeighborMeasInfo_5_SiteInfoIndex = 656998408;

	public const int CDMAServingCellDownlinkMeasInfo_PointIndex = 1048641536;

	public const int CDMAServingCellDownlinkMeasInfo_Channel = 1048641538;

	public const int CDMAServingCellDownlinkMeasInfo_PN = 1048641539;

	public const int CDMAServingCellDownlinkMeasInfo_RxAGC = 1048641540;

	public const int CDMAServingCellDownlinkMeasInfo_RxAGC_0 = 1048641541;

	public const int CDMAServingCellDownlinkMeasInfo_RxAGC_1 = 1048641542;

	public const int CDMAServingCellDownlinkMeasInfo_RSCP = 1048641543;

	public const int CDMAServingCellDownlinkMeasInfo_EcIo = 1048641544;

	public const int CDMAServingCellDownlinkMeasInfo_Distance = 1048641545;

	public const int CDMAServingCellDownlinkMeasInfo_CellCategory = 1048641546;

	public const int CDMAServingCellDownlinkMeasInfo_ID = 1048641547;

	public const int CDMAServingCellDownlinkMeasInfo_SiteInfoIndex = 1048641548;

	public const int CDMAServingCellDownlinkMeasInfo_Angle = 1048641549;

	public const int CDMAServingCellDownlinkMeasInfo_WashCode = 1048641550;

	public const int WCDMAServingCellDownlinkMeasInfo_PointIndex = 786497536;

	public const int WCDMAServingCellDownlinkMeasInfo_UARFCN = 786497538;

	public const int WCDMAServingCellDownlinkMeasInfo_PSC = 786497539;

	public const int WCDMAServingCellDownlinkMeasInfo_RSSI = 786497540;

	public const int WCDMAServingCellDownlinkMeasInfo_EcIo = 786497541;

	public const int WCDMAServingCellDownlinkMeasInfo_Ec = 786497542;

	public const int WCDMAServingCellDownlinkMeasInfo_Distance = 786497543;

	public const int WCDMAServingCellDownlinkMeasInfo_CellCategory = 786497544;

	public const int WCDMAServingCellDownlinkMeasInfo_ID = 786497545;

	public const int WCDMAServingCellDownlinkMeasInfo_SiteInfoIndex = 786497546;

	public const int WCDMAServingCellDownlinkMeasInfo_Angle = 786497547;

	public const int WCDMAServingNeighborMeasInfo_0_PointIndex = 787742720;

	public const int WCDMAServingNeighborMeasInfo_0_UARFCN = 787742722;

	public const int WCDMAServingNeighborMeasInfo_0_PSC = 787742723;

	public const int WCDMAServingNeighborMeasInfo_1_PointIndex = 787808256;

	public const int WCDMAServingNeighborMeasInfo_1_UARFCN = 787808258;

	public const int WCDMAServingNeighborMeasInfo_1_PSC = 787808259;

	public const int WCDMAServingNeighborMeasInfo_2_PointIndex = 787873792;

	public const int WCDMAServingNeighborMeasInfo_2_UARFCN = 787873794;

	public const int WCDMAServingNeighborMeasInfo_2_PSC = 787873795;

	public const int WCDMAServingNeighborMeasInfo_3_PointIndex = 787939328;

	public const int WCDMAServingNeighborMeasInfo_3_UARFCN = 787939330;

	public const int WCDMAServingNeighborMeasInfo_3_PSC = 787939331;

	public const int WCDMAServingNeighborMeasInfo_4_PointIndex = 788004864;

	public const int WCDMAServingNeighborMeasInfo_4_UARFCN = 788004866;

	public const int WCDMAServingNeighborMeasInfo_4_PSC = 788004867;

	public const int WCDMAServingNeighborMeasInfo_5_PointIndex = 788070400;

	public const int WCDMAServingNeighborMeasInfo_5_UARFCN = 788070402;

	public const int WCDMAServingNeighborMeasInfo_5_PSC = 788070403;

	public const int WCDMAServingNeighborMeasInfo_6_PointIndex = 788135936;

	public const int WCDMAServingNeighborMeasInfo_6_UARFCN = 788135938;

	public const int WCDMAServingNeighborMeasInfo_6_PSC = 788135939;

	public const int WCDMAServingNeighborMeasInfo_7_PointIndex = 788201472;

	public const int WCDMAServingNeighborMeasInfo_7_UARFCN = 788201474;

	public const int WCDMAServingNeighborMeasInfo_7_PSC = 788201475;

	public const int WCDMAServingNeighborMeasInfo_8_PointIndex = 788267008;

	public const int WCDMAServingNeighborMeasInfo_8_UARFCN = 788267010;

	public const int WCDMAServingNeighborMeasInfo_8_PSC = 788267011;

	public const int WCDMAServingNeighborMeasInfo_9_PointIndex = 788332544;

	public const int WCDMAServingNeighborMeasInfo_9_UARFCN = 788332546;

	public const int WCDMAServingNeighborMeasInfo_9_PSC = 788332547;

	public const int WCDMAServingNeighborMeasInfo_10_PointIndex = 788398080;

	public const int WCDMAServingNeighborMeasInfo_10_UARFCN = 788398082;

	public const int WCDMAServingNeighborMeasInfo_10_PSC = 788398083;

	public const int WCDMAServingNeighborMeasInfo_11_PointIndex = 788463616;

	public const int WCDMAServingNeighborMeasInfo_11_UARFCN = 788463618;

	public const int WCDMAServingNeighborMeasInfo_11_PSC = 788463619;

	public const int VIR_NR5G_Serving_BeatBeam1_BeamID = 1560674308;

	public const int VIR_NR5G_Serving_BeatBeam1_RSRP = 1560674309;

	public const int VIR_NR5G_Serving_BeatBeam1_SINR = 1560674312;

	public const int VIR_NR5G_Serving_BeatBeam2_BeamID = 1560674316;

	public const int VIR_NR5G_Serving_BeatBeam2_RSRP = 1560674317;

	public const int VIR_NR5G_Serving_BeatBeam2_SINR = 1560674320;

	public const int VIR_NR5G_Serving_BeatBeam3_BeamID = 1560674324;

	public const int VIR_NR5G_Serving_BeatBeam3_RSRP = 1560674325;

	public const int VIR_NR5G_Serving_BeatBeam3_SINR = 1560674328;

	public const int VIR_NR5G_Serving_BeatBeam4_BeamID = 1560674332;

	public const int VIR_NR5G_Serving_BeatBeam4_RSRP = 1560674333;

	public const int VIR_NR5G_Serving_BeatBeam4_SINR = 1560674336;

	public const int VIR_NR5G_Serving_BeatBeam5_BeamID = 1560674340;

	public const int VIR_NR5G_Serving_BeatBeam5_RSRP = 1560674341;

	public const int VIR_NR5G_Serving_BeatBeam5_SINR = 1560674344;

	public const int VIR_NR5G_Serving_BeatBeam6_BeamID = 1560674348;

	public const int VIR_NR5G_Serving_BeatBeam6_RSRP = 1560674349;

	public const int VIR_NR5G_Serving_BeatBeam6_SINR = 1560674352;

	public const int VIR_NR5G_Serving_BeatBeam7_BeamID = 1560674356;

	public const int VIR_NR5G_Serving_BeatBeam7_RSRP = 1560674357;

	public const int VIR_NR5G_Serving_BeatBeam7_SINR = 1560674360;

	public const int VIR_NR5G_Serving_BeatBeam8_BeamID = 1560674364;

	public const int VIR_NR5G_Serving_BeatBeam8_RSRP = 1560674365;

	public const int VIR_NR5G_Serving_BeatBeam8_SINR = 1560674368;

	public const int eLTECell_CellType_PCell = 0;

	public const int eLTECell_CellType_SCell = 1;

	public const int eLTECell_CellType_Neighbor = 2;

	public const int eLTECell_CellType_Detected = 3;

	public const int NSANetworkStateInfo_PointIndex = 1376256;

	public const int NSANetworkStateInfo_NSA_NR5GState = 1376258;

	public const int SyncNetworkInfo_CampNetworkType = 1835011;

	public const int SyncNetworkInfo_CampNetworkState = 1835012;

	public const int NR5gThroughputInfo_DL_PHY_Carrier_1_PHY_InstThr = 400490501;

	public const int NR5G_CA_State_CA_CurCarrierCount = 426246148;

	public const int NR5gServingCellParameter_PointIndex = 327680000;

	public const int NR5gServingCellParameter_EndPointIndex = 327680001;

	public const int NR5gServingCellParameter_Band = 327680002;

	public const int NR5gServingCellParameter_MeasBW = 327680003;

	public const int NR5gServingCellParameter_EArfcnDL = 327680004;

	public const int NR5gServingCellParameter_PCI = 327680005;

	public const int NR5gServingCellParameter_MCC = 327680006;

	public const int NR5gServingCellParameter_MNC = 327680007;

	public const int NR5gServingCellParameter_Tac = 327680008;

	public const int NR5gServingCellParameter_CellID = 327680009;

	public const int NR5gServingCellParameter_ID = 327680010;

	public const int NR5gServingCellParameter_eNodebID = 327680011;

	public const int NR5gServingCellParameter_SectorID = 327680012;

	public const int NR5gServingCellParameter_FrequencyDL = 327680013;

	public const int NR5gServingCellParameter_EArfcnUL = 327680014;

	public const int NR5gServingCellParameter_FrequencyUL = 327680015;

	public const int NR5gServingCellParameter_PointAARFCN = 327680016;

	public const int NR5gServingCellParameter_PointAFrequencyDL = 327680017;

	public const int NR5gServingCellParameter_WorkModeDL = 327680020;

	public const int NR5gServingCellParameter_BandWithUL = 327680022;

	public const int NR5gServingCellParameter_NetDeployType = 327680023;

	public const int NR5gServingCellParameter_GSCN = 327680028;

	public const int NR5gServingCellParameter_CenterEArfcnDL = 327680045;

	public const int NR5gServingCellParameter_NCGI = 327680048;

	public const int NR5gServingCellDownlinkMeasInfo_PointIndex = 328335360;

	public const int NR5gServingCellDownlinkMeasInfo_EndPointIndex = 328335361;

	public const int NR5gServingCellDownlinkMeasInfo_EARFCN = 328335362;

	public const int NR5gServingCellDownlinkMeasInfo_PCI = 328335363;

	public const int NR5gServingCellDownlinkMeasInfo_RSRP = 328335364;

	public const int NR5gServingCellDownlinkMeasInfo_RSRQ = 328335365;

	public const int NR5gServingCellDownlinkMeasInfo_RSSI = 328335366;

	public const int NR5gServingCellDownlinkMeasInfo_SINR = 328335367;

	public const int NR5gServingCellDownlinkMeasInfo_Distance = 328335368;

	public const int NR5gServingCellDownlinkMeasInfo_CellCategory = 328335369;

	public const int NR5gServingCellDownlinkMeasInfo_BeamCount = 328335371;

	public const int NR5gServingCellDownlinkMeasInfo_ID = 328335373;

	public const int NR5gServingCellDownlinkMeasInfo_SSBIndex = 328335379;

	public const int NR5gServingCellDownlinkMeasInfo_TxBeamID = 328335380;

	public const int NR5gServingCellDownlinkMeasInfo_RSRP_ant0 = 328335381;

	public const int NR5gServingCellDownlinkMeasInfo_RSRP_ant1 = 328335384;

	public const int NR5gServingCellDownlinkMeasInfo_RSRP_ant2 = 328335387;

	public const int NR5gServingCellDownlinkMeasInfo_RSRP_ant3 = 328335390;

	public const int NR5gPowerInfo_PUSCHPower = 328400899;

	public const int NR5gPowerInfo_PucchPower = 328400901;

	public const int NR5gCQIStatInfo_CQIAVG = 329908243;

	public const int NR5GDetectedBeamInfoAllInOne_PointIndex = 330235904;

	public const int NR5GDetectedBeamInfoAllInOne_EndPointIndex = 330235905;

	public const int NR5GDetectedBeamInfoAllInOne_EARFCN = 330235906;

	public const int NR5GDetectedBeamInfoAllInOne_PCI = 330235907;

	public const int NR5GDetectedBeamInfoAllInOne_RSRP = 330235908;

	public const int NR5GDetectedBeamInfoAllInOne_RSRQ = 330235909;

	public const int NR5GDetectedBeamInfoAllInOne_RSSI = 330235910;

	public const int NR5GDetectedBeamInfoAllInOne_Distance = 330235911;

	public const int NR5GDetectedBeamInfoAllInOne_CellCategory = 330235912;

	public const int NR5GDetectedBeamInfoAllInOne_ID = 330235913;

	public const int NR5GDetectedBeamInfoAllInOne_SiteInfoIndex = 330235914;

	public const int NR5GDetectedBeamInfoAllInOne_SSBIndex = 330235915;

	public const int NR5GDetectedBeamInfoAllInOne_TxBeamID = 330235916;

	public const int NR5GDetectedBeamInfoAllInOne_BeamCount = 330235917;

	public const int NR5GDetectedBeamInfoAllInOne_CarrierID = 330235918;

	public const int NR5GDetectedBeamInfoAllInOne_IsServingBeam = 330235919;

	public const int NR5GDetectedBeamInfoAllInOne_SINR = 330235920;

	public const int NR5GDetectedBeamInfoAllInOne_CellRSRP = 330235922;

	public const int NR5GDetectedBeamInfoAllInOne_CellRSRQ = 330235923;

	public const int NR5GDetectedBeamInfoAllInOne_CellSINR = 330235924;

	public const int NR5gPDSCH_DMRSInfoAllInOne_PointIndex = 331612160;

	public const int NR5gPDSCH_DMRSInfoAllInOne_EndPointIndex = 331612161;

	public const int NR5gPDSCH_DMRSInfoAllInOne_RxIndex = 331612162;

	public const int NR5gPDSCH_DMRSInfoAllInOne_PortIndex = 331612163;

	public const int NR5gPDSCH_DMRSInfoAllInOne_RSRP = 331612164;

	public const int NR5gPDSCH_DMRSInfoAllInOne_SINR = 331612165;

	public const int NR5gPDCCH_DMRSInfoAllInOne_PointIndex = 331677696;

	public const int NR5gPDCCH_DMRSInfoAllInOne_EndPointIndex = 331677697;

	public const int NR5gPDCCH_DMRSInfoAllInOne_RxIndex = 331677698;

	public const int NR5gPDCCH_DMRSInfoAllInOne_PortIndex = 331677699;

	public const int NR5gPDCCH_DMRSInfoAllInOne_RSRP = 331677700;

	public const int NR5gPDCCH_DMRSInfoAllInOne_SINR = 331677701;

	public const int NR5gThroughputInfo_DL_PHY_Thr = 334233605;

	public const int NR5gThroughputInfo_UL_PHY_Thr = 334299141;

	public const int NR5gThroughputInfo_DL_PHY_PHY_InstThr_withErrorBlock = 334233609;

	public const int NR5gThroughputInfo_DL_PHY_PHY_CumulativeThr_withErrorBlock = 334233607;

	public const int NR5gThroughputInfo_UL_PHY_PHY_InstThr_withErrorBlock = 334299145;

	public const int NR5gThroughputInfo_UL_PHY_PHY_CumulativeThr_withErrorBlock = 334299143;

	public const int NR5gThroughputInfo_DL_MAC_MAC_InstThr = 334364677;

	public const int NR5gThroughputInfo_DL_MAC_MAC_CumulativeThr = 334364675;

	public const int NR5gThroughputInfo_UL_MAC_MAC_CumulativeThr = 334430211;

	public const int NR5gThroughputInfo_UL_MAC_MAC_InstThr = 334430213;

	public const int NR5gThroughputInfo_DL_Combined_PDCP_InstThr = 328990734;

	public const int NR5gThroughputInfo_DL_PDCP_PDCP_CumulativeThr = 334626819;

	public const int NR5gThroughputInfo_UL_PDCP_PDCP_CumulativeThr = 334692355;

	public const int NR5gThroughputInfo_DL_PDCP_PDCP_InstThr = 334626821;

	public const int NR5gThroughputInfo_UL_PDCP_PDCP_InstThr = 334692357;

	public const int LTEThroughputInfo_DL_Combined_PDCP_InstThr = 3932186;

	public const int LTEThroughputInfo_DL_Combined_RLC_InstThr = 3932187;

	public const int LTEThroughputInfo_DL_Combined_MAC_InstThr = 3932188;

	public const int LTEThroughputInfo_DL_Combined_PHY_InstThr = 3932189;

	public const int LTEThroughputInfo_UL_Combined_PDCP_InstThr = 52428814;

	public const int LTEThroughputInfo_UL_Combined_RLC_InstThr = 52428815;

	public const int LTEThroughputInfo_UL_Combined_MAC_InstThr = 52428816;

	public const int LTEThroughputInfo_UL_Combined_PHY_InstThr = 52428817;

	public const int LTEThroughputInfo_DL_Combined_PDCP_CumulativeThr = 3932170;

	public const int LTEThroughputInfo_DL_Combined_RLC_CumulativeThr = 3932171;

	public const int LTEThroughputInfo_DL_Combined_MAC_CumulativeThr = 3932172;

	public const int LTEThroughputInfo_DL_Combined_PHY_CumulativeThr = 3932173;

	public const int LTEThroughputInfo_UL_Combined_PDCP_CumulativeThr = 52428806;

	public const int LTEThroughputInfo_UL_Combined_RLC_CumulativeThr = 52428807;

	public const int LTEThroughputInfo_UL_Combined_MAC_CumulativeThr = 52428808;

	public const int LTEThroughputInfo_UL_Combined_PHY_CumulativeThr = 52428809;

	public const int NR5gPDSCHRBBitmapStatInfo_PointIndex = 337510400;

	public const int NR5gPDSCHRBBitmapStatInfo_NumResult = 337510405;

	public const int NR5gPDSCHRBBitmapStatInfo_BufferSize = 337510406;

	public const int NR5gPDSCHRBBitmapStatInfo_Buffer = 337510407;

	public const int NR5gPUSCHRBBitmapStatInfo_PointIndex = 337575936;

	public const int NR5gPUSCHRBBitmapStatInfo_NumResult = 337575941;

	public const int NR5gPUSCHRBBitmapStatInfo_BufferSize = 337575942;

	public const int NR5gPUSCHRBBitmapStatInfo_Buffer = 337575943;

	public const int NBIotServingCellDownlinkMeasInfo_PointIndex = 589889536;

	public const int NBIotServingCellDownlinkMeasInfo_ID = 589889549;

	public const int NBIotServingCellDownlinkMeasInfo_EARFCN = 589889538;

	public const int NBIotServingCellDownlinkMeasInfo_PCI = 589889539;

	public const int NBIotServingCellDownlinkMeasInfo_RSRP = 589889540;

	public const int NBIotServingCellDownlinkMeasInfo_RSRQ = 589889541;

	public const int NBIotServingCellDownlinkMeasInfo_RSSI = 589889542;

	public const int NBIotServingCellDownlinkMeasInfo_SINR = 589889543;

	public const int NBIotServingCellParameter_PointIndex = 589824000;

	public const int NBIotServingCellParameter_EArfcnDL = 589824005;

	public const int NBIotServingCellParameter_PCI = 589824006;

	public const int NBIotServingCellParameter_MCC = 589824007;

	public const int NBIotServingCellParameter_MNC = 589824008;

	public const int NBIotServingCellParameter_Tac = 589824009;

	public const int NBIotServingCellParameter_CellID = 589824010;

	public const int NBIotServingCellParameter_eNodebID = 589824013;

	public const int NBIotServingCellParameter_SectorID = 589824014;

	public const int NBIotServingCellParameter_FrequencyDL = 589824015;

	public const int NBIotServingCellParameter_EArfcnUL = 589824016;

	public const int NBIotServingNeighborMeasInfo_0_RSRP = 591134724;

	public const int NBIotServingNeighborMeasInfo_0_EARFCN = 591134722;

	public const int NBIotServingNeighborMeasInfo_0_PCI = 591134723;

	public const int NBIotServingNeighborMeasInfo_1_EARFCN = 591200258;

	public const int NBIotServingNeighborMeasInfo_1_PCI = 591200259;

	public const int NBIotServingNeighborMeasInfo_2_EARFCN = 591265794;

	public const int NBIotServingNeighborMeasInfo_2_PCI = 591265795;

	public const int NBIotServingNeighborMeasInfo_3_EARFCN = 591331330;

	public const int NBIotServingNeighborMeasInfo_3_PCI = 591331331;

	public const int NBIotServingNeighborMeasInfo_4_EARFCN = 591396866;

	public const int NBIotServingNeighborMeasInfo_4_PCI = 591396867;

	public const int NBIotServingNeighborMeasInfo_5_EARFCN = 591462402;

	public const int NBIotServingNeighborMeasInfo_5_PCI = 591462403;

	public const int NBIotServingNeighborMeasInfo_6_EARFCN = 591527938;

	public const int NBIotServingNeighborMeasInfo_6_PCI = 591527939;

	public const int NBIotServingNeighborMeasInfo_7_EARFCN = 591593474;

	public const int NBIotServingNeighborMeasInfo_7_PCI = 591593475;

	public const int LTEServingNeighborMeasInfoAllInOne_PointIndex = 9109504;

	public const int LTEServingNeighborMeasInfoAllInOne_EndPointIndex = 9109505;

	public const int LTEServingNeighborMeasInfoAllInOne_EARFCN = 9109506;

	public const int LTEServingNeighborMeasInfoAllInOne_PCI = 9109507;

	public const int LTEServingNeighborMeasInfoAllInOne_RSRP = 9109508;

	public const int LTEServingNeighborMeasInfoAllInOne_RSRQ = 9109509;

	public const int LTEServingNeighborMeasInfoAllInOne_RSSI = 9109510;

	public const int LTEServingNeighborMeasInfoAllInOne_Distance = 9109511;

	public const int LTEServingNeighborMeasInfoAllInOne_CellCategory = 9109512;

	public const int LTEServingNeighborMeasInfoAllInOne_ID = 9109513;

	public const int LTEServingNeighborMeasInfoAllInOne_SiteInfoIndex = 9109514;

	public const int LTEServingNeighborMeasInfoAllInOne_SINR = 9109515;

	public const int LTEServingNeighborMeasInfoAllInOne_CarrierID = 9109516;

	public const int LTEServingNeighborMeasInfoAllInOne_IsPCell = 9109517;

	public const int LTEServingNeighborMeasInfoAllInOne_CellIndex = 9109518;

	public const int LTEServingNeighborMeasInfoAllInOne_CellCount = 9109519;

	public const int LTEServingCellDownlinkMeasInfo_PCell_PointIndex = 5242880;

	public const int LTEServingCellDownlinkMeasInfo_PCell_ID = 5242907;

	public const int LTEServingCellDownlinkMeasInfo_PCell_EARFCN = 5242883;

	public const int LTEServingCellDownlinkMeasInfo_PCell_PCI = 5242884;

	public const int LTEServingCellDownlinkMeasInfo_PCell_RSRP = 5242885;

	public const int LTEServingCellDownlinkMeasInfo_PCell_RSRQ = 5242886;

	public const int LTEServingCellDownlinkMeasInfo_PCell_RSSI = 5242887;

	public const int LTEServingCellDownlinkMeasInfo_PCell_Distance = 5242888;

	public const int LTEServingCellDownlinkMeasInfo_PCell_CellCategory = 5242889;

	public const int LTEServingCellDownlinkMeasInfo_PCell_SINR = 5242890;

	public const int LTEServingCellParameter_PCell_PointIndex = 6553600;

	public const int LTEServingCellParameter_PCell_EndPointIndex = 6553601;

	public const int LTEServingCellParameter_PCell_Band = 6553603;

	public const int LTEServingCellParameter_PCell_BandwidthDL = 6553604;

	public const int LTEServingCellParameter_PCell_EArfcnDL = 6553605;

	public const int LTEServingCellParameter_PCell_PCI = 6553606;

	public const int LTEServingCellParameter_PCell_MCC = 6553607;

	public const int LTEServingCellParameter_PCell_MNC = 6553608;

	public const int LTEServingCellParameter_PCell_Tac = 6553609;

	public const int LTEServingCellParameter_PCell_CellID = 6553610;

	public const int LTEServingCellParameter_PCell_eNodebID = 6553611;

	public const int LTEServingCellParameter_PCell_SectorID = 6553612;

	public const int LTEServingCellParameter_PCell_FrequencyDL = 6553638;

	public const int LTEServingNeighborMeasInfo_0_PointIndex = 7864320;

	public const int LTEServingNeighborMeasInfo_0_EARFCN = 7864322;

	public const int LTEServingNeighborMeasInfo_0_PCI = 7864323;

	public const int LTEServingNeighborMeasInfo_0_RSRP = 7864324;

	public const int LTEServingNeighborMeasInfo_1_PointIndex = 7929856;

	public const int LTEServingNeighborMeasInfo_1_EARFCN = 7929858;

	public const int LTEServingNeighborMeasInfo_1_PCI = 7929859;

	public const int LTEServingNeighborMeasInfo_1_RSRP = 7929860;

	public const int LTEServingNeighborMeasInfo_2_PointIndex = 7995392;

	public const int LTEServingNeighborMeasInfo_2_EARFCN = 7995394;

	public const int LTEServingNeighborMeasInfo_2_PCI = 7995395;

	public const int LTEServingNeighborMeasInfo_2_RSRP = 7995396;

	public const int LTEServingNeighborMeasInfo_3_PointIndex = 8060928;

	public const int LTEServingNeighborMeasInfo_3_EARFCN = 8060930;

	public const int LTEServingNeighborMeasInfo_3_PCI = 8060931;

	public const int LTEServingNeighborMeasInfo_3_RSRP = 8060932;

	public const int LTEServingNeighborMeasInfo_4_PointIndex = 8126464;

	public const int LTEServingNeighborMeasInfo_4_EARFCN = 8126466;

	public const int LTEServingNeighborMeasInfo_4_PCI = 8126467;

	public const int LTEServingNeighborMeasInfo_4_RSRP = 8126468;

	public const int LTEServingNeighborMeasInfo_5_PointIndex = 8192000;

	public const int LTEServingNeighborMeasInfo_5_EARFCN = 8192002;

	public const int LTEServingNeighborMeasInfo_5_PCI = 8192003;

	public const int LTEServingNeighborMeasInfo_5_RSRP = 8192004;

	public const int LTEServingNeighborMeasInfo_6_PointIndex = 8257536;

	public const int LTEServingNeighborMeasInfo_6_EARFCN = 8257538;

	public const int LTEServingNeighborMeasInfo_6_PCI = 8257539;

	public const int LTEServingNeighborMeasInfo_6_RSRP = 8257540;

	public const int LTEServingNeighborMeasInfo_7_PointIndex = 8323072;

	public const int LTEServingNeighborMeasInfo_7_EARFCN = 8323074;

	public const int LTEServingNeighborMeasInfo_7_PCI = 8323075;

	public const int LTEServingNeighborMeasInfo_7_RSRP = 8323076;

	public const int LTEServingNeighborMeasInfo_8_PointIndex = 8388608;

	public const int LTEServingNeighborMeasInfo_8_EARFCN = 8388610;

	public const int LTEServingNeighborMeasInfo_8_PCI = 8388611;

	public const int LTEServingNeighborMeasInfo_8_RSRP = 8388612;

	public const int LTEServingNeighborMeasInfo_9_PointIndex = 8454144;

	public const int LTEServingNeighborMeasInfo_9_EARFCN = 8454146;

	public const int LTEServingNeighborMeasInfo_9_PCI = 8454147;

	public const int LTEServingNeighborMeasInfo_9_RSRP = 8454148;

	public const int LTEServingNeighborMeasInfo_10_PointIndex = 8519680;

	public const int LTEServingNeighborMeasInfo_10_EARFCN = 8519682;

	public const int LTEServingNeighborMeasInfo_10_PCI = 8519683;

	public const int LTEServingNeighborMeasInfo_10_RSRP = 8519684;

	public const int LTEServingNeighborMeasInfo_11_PointIndex = 8585216;

	public const int LTEServingNeighborMeasInfo_11_EARFCN = 8585218;

	public const int LTEServingNeighborMeasInfo_11_PCI = 8585219;

	public const int LTEServingNeighborMeasInfo_11_RSRP = 8585220;

	public const int LTEServingNeighborMeasInfo_12_PointIndex = 8650752;

	public const int LTEServingNeighborMeasInfo_12_EARFCN = 8650754;

	public const int LTEServingNeighborMeasInfo_12_PCI = 8650755;

	public const int LTEServingNeighborMeasInfo_12_RSRP = 8650756;

	public const int LTEServingNeighborMeasInfo_13_PointIndex = 8716288;

	public const int LTEServingNeighborMeasInfo_13_EARFCN = 8716290;

	public const int LTEServingNeighborMeasInfo_13_PCI = 8716291;

	public const int LTEServingNeighborMeasInfo_13_RSRP = 8716292;

	public const int LTEServingNeighborMeasInfo_14_PointIndex = 8781824;

	public const int LTEServingNeighborMeasInfo_14_EARFCN = 8781826;

	public const int LTEServingNeighborMeasInfo_14_PCI = 8781827;

	public const int LTEServingNeighborMeasInfo_14_RSRP = 8781828;

	public const int LTEServingNeighborMeasInfo_15_PointIndex = 8847360;

	public const int LTEServingNeighborMeasInfo_15_EARFCN = 8847362;

	public const int LTEServingNeighborMeasInfo_15_PCI = 8847363;

	public const int LTEServingNeighborMeasInfo_15_RSRP = 8847364;

	public const int LTEPDSCHRBBitmapStatInfo_PCell_PointIndex = 190054400;

	public const int LTEPDSCHRBBitmapStatInfo_PCell_NumResult = 190054405;

	public const int LTEPDSCHRBBitmapStatInfo_PCell_BufferSize = 190054406;

	public const int LTEPDSCHRBBitmapStatInfo_PCell_Buffer = 190054407;

	public const int LTEPUSCHRBBitmapStatInfo_PCell_PointIndex = 196608000;

	public const int LTEPUSCHRBBitmapStatInfo_PCell_NumResult = 196608005;

	public const int LTEPUSCHRBBitmapStatInfo_PCell_BufferSize = 196608006;

	public const int LTEPUSCHRBBitmapStatInfo_PCell_Buffer = 196608007;

	public const int ParamID_VirtualParamBase = 1946157056;

	public const int ParamID_VirtualParamDetectedBeamInfo = 1946157057;

	public const int ParamID_VIR_MIN = 1560281088;

	public const int ParamID_VIRReal_MIN = 1593835520;

	public const int ParamID_VIR_MAX = 1610612735;

	public const int DSafDataInfo_ID = 1769472;

	public const int DSafDataInfo_PCTime = 1769473;

	public const int DSafDataInfo_DataType = 1769474;

	public const int DSafDataInfo_MinPackId = 1769475;

	public const int DSafDataInfo_MaxPackId = 1769476;

	public const int DSafDataInfo_BufferSize = 1769477;

	public const int DSafDataInfo_Buffer = 1769478;

	public const int UserDefineParamInfoCodeStart = 1929379840;

	public const int UserDefineParamInfoCodeEnd = 1930428416;

	public const int UserDefineParamInfo1_PointIndex = 1929379840;

	public const int UserDefineParamInfo1_UserDefineParamValue = 1929379841;

	public const int UserDefineParamInfo1_ID = 1929379842;

	public const int UserDefineParamInfo1_UserDefineParamStringValue = 1929379843;

	public const int UserDefineParamInfo2_PointIndex = 1929445376;

	public const int UserDefineParamInfo2_UserDefineParamValue = 1929445377;

	public const int UserDefineParamInfo2_ID = 1929445378;

	public const int UserDefineParamInfo3_PointIndex = 1929510912;

	public const int UserDefineParamInfo3_UserDefineParamValue = 1929510913;

	public const int UserDefineParamInfo3_ID = 1929510914;

	public const int UserDefineParamInfo4_PointIndex = 1929576448;

	public const int UserDefineParamInfo4_UserDefineParamValue = 1929576449;

	public const int UserDefineParamInfo4_ID = 1929576450;

	public const int UserDefineParamInfo5_PointIndex = 1929641984;

	public const int UserDefineParamInfo5_UserDefineParamValue = 1929641985;

	public const int UserDefineParamInfo5_ID = 1929641986;

	public const int UserDefineParamInfo6_PointIndex = 1929707520;

	public const int UserDefineParamInfo6_UserDefineParamValue = 1929707521;

	public const int UserDefineParamInfo6_ID = 1929707522;

	public const int UserDefineParamInfo7_PointIndex = 1929773056;

	public const int UserDefineParamInfo7_UserDefineParamValue = 1929773057;

	public const int UserDefineParamInfo7_ID = 1929773058;

	public const int UserDefineParamInfo8_PointIndex = 1929838592;

	public const int UserDefineParamInfo8_UserDefineParamValue = 1929838593;

	public const int UserDefineParamInfo8_ID = 1929838594;

	public const int UserDefineParamInfo9_PointIndex = 1929904128;

	public const int UserDefineParamInfo9_UserDefineParamValue = 1929904129;

	public const int UserDefineParamInfo9_ID = 1929904130;

	public const int UserDefineParamInfo10_PointIndex = 1929969664;

	public const int UserDefineParamInfo10_UserDefineParamValue = 1929969665;

	public const int UserDefineParamInfo10_ID = 1929969666;

	public const int UserDefineParamInfo11_PointIndex = 1930035200;

	public const int UserDefineParamInfo11_UserDefineParamValue = 1930035201;

	public const int UserDefineParamInfo11_ID = 1930035202;

	public const int UserDefineParamInfo12_PointIndex = 1930100736;

	public const int UserDefineParamInfo12_UserDefineParamValue = 1930100737;

	public const int UserDefineParamInfo12_ID = 1930100738;

	public const int UserDefineParamInfo13_PointIndex = 1930166272;

	public const int UserDefineParamInfo13_UserDefineParamValue = 1930166273;

	public const int UserDefineParamInfo13_ID = 1930166274;

	public const int UserDefineParamInfo14_PointIndex = 1930231808;

	public const int UserDefineParamInfo14_UserDefineParamValue = 1930231809;

	public const int UserDefineParamInfo14_ID = 1930231810;

	public const int UserDefineParamInfo15_PointIndex = 1930297344;

	public const int UserDefineParamInfo15_UserDefineParamValue = 1930297345;

	public const int UserDefineParamInfo15_ID = 1930297346;

	public const int UserDefineParamInfo16_PointIndex = 1930362880;

	public const int UserDefineParamInfo16_UserDefineParamValue = 1930362881;

	public const int UserDefineParamInfo16_ID = 1930362882;

	public const int UserDefineParamInfo16_UserDefineBlobValue = 1930362883;

	public const int UserDefineEventnfo1_PointIndex = 1935933440;

	public const int UserDefineEventnfo1_ID = 1935933441;

	public const int UserDefineEventnfo1_EndPointIndex = 1935933442;

	public const int UserDefineEventnfo1_SessionIndex = 1935933443;

	public const int UserDefineEventnfo1_Result = 1935933444;

	public const int UserDefineEventnfo1_Delay = 1935933445;

	public const int UserDefineEventnfo1_Duration = 1935933446;

	public const int UserDefineEventnfo1_BeforeDuration = 1935933447;

	public const int UserDefineEventnfo1_AfterDuration = 1935933448;

	public const int UserDefineEventInfo2_PointIndex = 1935998976;

	public const int UserDefineEventInfo2_ID = 1935998977;

	public const int UserDefineEventInfo2_EndPointIndex = 1935998978;

	public const int UserDefineEventInfo2_SessionIndex = 1935998979;

	public const int UserDefineEventInfo2_Result = 1935998980;

	public const int UserDefineEventInfo2_Delay = 1935998981;

	public const int UserDefineEventInfo2_Duration = 1935998982;

	public const int UserDefineEventInfo2_BeforeDuration = 1935998983;

	public const int UserDefineEventInfo2_AfterDuration = 1935998984;

	public const int UserDefineEventInfo3_PointIndex = 1936064512;

	public const int UserDefineEventInfo3_ID = 1936064513;

	public const int UserDefineEventInfo3_EndPointIndex = 1936064514;

	public const int UserDefineEventInfo3_SessionIndex = 1936064515;

	public const int UserDefineEventInfo3_Result = 1936064516;

	public const int UserDefineEventInfo3_Delay = 1936064517;

	public const int UserDefineEventInfo3_Duration = 1936064518;

	public const int UserDefineEventInfo3_BeforeDuration = 1936064519;

	public const int UserDefineEventInfo3_AfterDuration = 1936064520;

	public const int UserDefineEventInfo4_PointIndex = 1936130048;

	public const int UserDefineEventInfo4_ID = 1936130049;

	public const int UserDefineEventInfo4_EndPointIndex = 1936130050;

	public const int UserDefineEventInfo4_SessionIndex = 1936130051;

	public const int UserDefineEventInfo4_Result = 1936130052;

	public const int UserDefineEventInfo4_Delay = 1936130053;

	public const int UserDefineEventInfo4_Duration = 1936130054;

	public const int UserDefineEventInfo4_BeforeDuration = 1936130055;

	public const int UserDefineEventInfo4_AfterDuration = 1936130056;

	public const int UserDefineEventInfo5_PointIndex = 1936195584;

	public const int UserDefineEventInfo5_ID = 1936195585;

	public const int UserDefineEventInfo5_EndPointIndex = 1936195586;

	public const int UserDefineEventInfo5_SessionIndex = 1936195587;

	public const int UserDefineEventInfo5_Result = 1936195588;

	public const int UserDefineEventInfo5_Delay = 1936195589;

	public const int UserDefineEventInfo5_Duration = 1936195590;

	public const int UserDefineEventInfo5_BeforeDuration = 1936195591;

	public const int UserDefineEventInfo5_AfterDuration = 1936195592;

	public const int UserDefineEventInfo6_PointIndex = 1936261120;

	public const int UserDefineEventInfo6_ID = 1936261121;

	public const int UserDefineEventInfo6_EndPointIndex = 1936261122;

	public const int UserDefineEventInfo6_SessionIndex = 1936261123;

	public const int UserDefineEventInfo6_Result = 1936261124;

	public const int UserDefineEventInfo6_Delay = 1936261125;

	public const int UserDefineEventInfo6_Duration = 1936261126;

	public const int UserDefineEventInfo6_BeforeDuration = 1936261127;

	public const int UserDefineEventInfo6_AfterDuration = 1936261128;

	public const int UserDefineEventInfo7_PointIndex = 1936326656;

	public const int UserDefineEventInfo7_ID = 1936326657;

	public const int UserDefineEventInfo7_EndPointIndex = 1936326658;

	public const int UserDefineEventInfo7_SessionIndex = 1936326659;

	public const int UserDefineEventInfo7_Result = 1936326660;

	public const int UserDefineEventInfo7_Delay = 1936326661;

	public const int UserDefineEventInfo7_Duration = 1936326662;

	public const int UserDefineEventInfo7_BeforeDuration = 1936326663;

	public const int UserDefineEventInfo7_AfterDuration = 1936326664;

	public const int UserDefineEventInfo8_PointIndex = 1936392192;

	public const int UserDefineEventInfo8_ID = 1936392193;

	public const int UserDefineEventInfo8_EndPointIndex = 1936392194;

	public const int UserDefineEventInfo8_SessionIndex = 1936392195;

	public const int UserDefineEventInfo8_Result = 1936392196;

	public const int UserDefineEventInfo8_Delay = 1936392197;

	public const int UserDefineEventInfo8_Duration = 1936392198;

	public const int UserDefineEventInfo8_BeforeDuration = 1936392199;

	public const int UserDefineEventInfo8_AfterDuration = 1936392200;

	public const int UserDefineEventInfo9_PointIndex = 1936457728;

	public const int UserDefineEventInfo9_ID = 1936457729;

	public const int UserDefineEventInfo9_EndPointIndex = 1936457730;

	public const int UserDefineEventInfo9_SessionIndex = 1936457731;

	public const int UserDefineEventInfo9_Result = 1936457732;

	public const int UserDefineEventInfo9_Delay = 1936457733;

	public const int UserDefineEventInfo9_Duration = 1936457734;

	public const int UserDefineEventInfo9_BeforeDuration = 1936457735;

	public const int UserDefineEventInfo9_AfterDuration = 1936457736;

	public const int UserDefineEventInfo10_PointIndex = 1936523264;

	public const int UserDefineEventInfo10_ID = 1936523265;

	public const int UserDefineEventInfo10_EndPointIndex = 1936523266;

	public const int UserDefineEventInfo10_SessionIndex = 1936523267;

	public const int UserDefineEventInfo10_Result = 1936523268;

	public const int UserDefineEventInfo10_Delay = 1936523269;

	public const int UserDefineEventInfo10_Duration = 1936523270;

	public const int UserDefineEventInfo10_BeforeDuration = 1936523271;

	public const int UserDefineEventInfo10_AfterDuration = 1936523272;

	public const int UserDefineEventInfo11_PointIndex = 1936588800;

	public const int UserDefineEventInfo11_ID = 1936588801;

	public const int UserDefineEventInfo11_EndPointIndex = 1936588802;

	public const int UserDefineEventInfo11_SessionIndex = 1936588803;

	public const int UserDefineEventInfo11_Result = 1936588804;

	public const int UserDefineEventInfo11_Delay = 1936588805;

	public const int UserDefineEventInfo11_Duration = 1936588806;

	public const int UserDefineEventInfo11_BeforeDuration = 1936588807;

	public const int UserDefineEventInfo11_AfterDuration = 1936588808;

	public const int UserDefineEventInfo12_PointIndex = 1936654336;

	public const int UserDefineEventInfo12_ID = 1936654337;

	public const int UserDefineEventInfo12_EndPointIndex = 1936654338;

	public const int UserDefineEventInfo12_SessionIndex = 1936654339;

	public const int UserDefineEventInfo12_Result = 1936654340;

	public const int UserDefineEventInfo12_Delay = 1936654341;

	public const int UserDefineEventInfo12_Duration = 1936654342;

	public const int UserDefineEventInfo12_BeforeDuration = 1936654343;

	public const int UserDefineEventInfo12_AfterDuration = 1936654344;

	public const int UserDefineEventInfo13_PointIndex = 1936719872;

	public const int UserDefineEventInfo13_ID = 1936719873;

	public const int UserDefineEventInfo13_EndPointIndex = 1936719874;

	public const int UserDefineEventInfo13_SessionIndex = 1936719875;

	public const int UserDefineEventInfo13_Result = 1936719876;

	public const int UserDefineEventInfo13_Delay = 1936719877;

	public const int UserDefineEventInfo13_Duration = 1936719878;

	public const int UserDefineEventInfo13_BeforeDuration = 1936719879;

	public const int UserDefineEventInfo13_AfterDuration = 1936719880;

	public const int UserDefineEventInfo14_PointIndex = 1936785408;

	public const int UserDefineEventInfo14_ID = 1936785409;

	public const int UserDefineEventInfo14_EndPointIndex = 1936785410;

	public const int UserDefineEventInfo14_SessionIndex = 1936785411;

	public const int UserDefineEventInfo14_Result = 1936785412;

	public const int UserDefineEventInfo14_Delay = 1936785413;

	public const int UserDefineEventInfo14_Duration = 1936785414;

	public const int UserDefineEventInfo14_BeforeDuration = 1936785415;

	public const int UserDefineEventInfo14_AfterDuration = 1936785416;

	public const int UserDefineEventInfo15_PointIndex = 1936850944;

	public const int UserDefineEventInfo15_ID = 1936850945;

	public const int UserDefineEventInfo15_EndPointIndex = 1936850946;

	public const int UserDefineEventInfo15_SessionIndex = 1936850947;

	public const int UserDefineEventInfo15_Result = 1936850948;

	public const int UserDefineEventInfo15_Delay = 1936850949;

	public const int UserDefineEventInfo15_Duration = 1936850950;

	public const int UserDefineEventInfo15_BeforeDuration = 1936850951;

	public const int UserDefineEventInfo15_AfterDuration = 1936850952;

	public const int UserDefineEventInfo16_PointIndex = 1936916480;

	public const int UserDefineEventInfo16_ID = 1936916481;

	public const int UserDefineEventInfo16_EndPointIndex = 1936916482;

	public const int UserDefineEventInfo16_SessionIndex = 1936916483;

	public const int UserDefineEventInfo16_Result = 1936916484;

	public const int UserDefineEventInfo16_Delay = 1936916485;

	public const int UserDefineEventInfo16_Duration = 1936916486;

	public const int UserDefineEventInfo16_BeforeDuration = 1936916487;

	public const int UserDefineEventInfo16_AfterDuration = 1936916488;

	public const int NR5GPilotInfo_MaxMinRsrp_PointIndex = 1975910400;

	public const int NR5GPilotInfo_MaxMinRsrp_ID = 1975910401;

	public const int NR5GPilotInfo_MaxMinRsrp_EARFCN = 1975910402;

	public const int NR5GPilotInfo_MaxMinRsrp_PCI = 1975910403;

	public const int NR5GPilotInfo_MaxMinRsrp_Timingoffset = 1975910404;

	public const int NR5GPilotInfo_MaxMinRsrp_bsRepeatitionPeriod = 1975910405;

	public const int NR5GPilotInfo_MaxMinRsrp_subcarrierSpacing = 1975910406;

	public const int NR5GPilotInfo_MaxMinRsrp_repetitionpattern = 1975910407;

	public const int NR5GPilotInfo_MaxMinRsrp_ssbIndex = 1975910408;

	public const int NR5GPilotInfo_MaxMinRsrp_PSS_cinr = 1975910409;

	public const int NR5GPilotInfo_MaxMinRsrp_PSS_RP = 1975910410;

	public const int NR5GPilotInfo_MaxMinRsrp_PSS_RQ = 1975910411;

	public const int NR5GPilotInfo_MaxMinRsrp_SSS_cinr = 1975910412;

	public const int NR5GPilotInfo_MaxMinRsrp_SSS_RP = 1975910413;

	public const int NR5GPilotInfo_MaxMinRsrp_SSS_RQ = 1975910414;

	public const int NR5GPilotInfo_MaxMinRsrp_pbchDMRS_cinr = 1975910415;

	public const int NR5GPilotInfo_MaxMinRsrp_pbchDMRS_RP = 1975910416;

	public const int NR5GPilotInfo_MaxMinRsrp_pbchDMRS_RQ = 1975910417;

	public const int NR5GPilotInfo_MaxMinRsrp_ssb_cinr = 1975910418;

	public const int NR5GPilotInfo_MaxMinRsrp_ssb_RP = 1975910419;

	public const int NR5GPilotInfo_MaxMinRsrp_ssb_RQ = 1975910420;

	public const int NR5GPilotInfo_MaxMinRsrp_ssb_RSSi = 1975910421;

	public const int NR5GPilotInfo_1_PointIndex = 1976631296;

	public const int NR5GPilotInfo_1_ID = 1976631297;

	public const int NR5GPilotInfo_1_EARFCN = 1976631298;

	public const int NR5GPilotInfo_1_PCI = 1976631299;

	public const int NR5GPilotInfo_1_Timingoffset = 1976631300;

	public const int NR5GPilotInfo_1_bsRepeatitionPeriod = 1976631301;

	public const int NR5GPilotInfo_1_subcarrierSpacing = 1976631302;

	public const int NR5GPilotInfo_1_repetitionpattern = 1976631303;

	public const int NR5GPilotInfo_1_beamIndex = 1976631304;

	public const int NR5GPilotInfo_1_PSS_cinr = 1976631305;

	public const int NR5GPilotInfo_1_PSS_RP = 1976631306;

	public const int NR5GPilotInfo_1_PSS_RQ = 1976631307;

	public const int NR5GPilotInfo_1_SSS_cinr = 1976631308;

	public const int NR5GPilotInfo_1_SSS_RP = 1976631309;

	public const int NR5GPilotInfo_1_SSS_RQ = 1976631310;

	public const int NR5GPilotInfo_1_pbchDMRS_cinr = 1976631311;

	public const int NR5GPilotInfo_1_pbchDMRS_RP = 1976631312;

	public const int NR5GPilotInfo_1_pbchDMRS_RQ = 1976631313;

	public const int NR5GPilotInfo_1_ssb_cinr = 1976631314;

	public const int NR5GPilotInfo_1_ssb_RP = 1976631315;

	public const int NR5GPilotInfo_1_ssb_RQ = 1976631316;

	public const int NR5GPilotInfo_1_ssb_RSSi = 1976631317;

	public const int NR5GPilotInfo_1_pSSSDelaySpread = 1976631318;

	public const int NR5GPilotInfo_1_halfFrameNumber = 1976631319;

	public const int NR5GPilotInfo_1_GSCN = 1976631320;

	public const int NR5GPilotInfo_2_PointIndex = 1976696832;

	public const int NR5GPilotInfo_2_ID = 1976696833;

	public const int NR5GPilotInfo_2_EARFCN = 1976696834;

	public const int NR5GPilotInfo_2_PCI = 1976696835;

	public const int NR5GPilotInfo_2_Timingoffset = 1976696836;

	public const int NR5GPilotInfo_2_bsRepeatitionPeriod = 1976696837;

	public const int NR5GPilotInfo_2_subcarrierSpacing = 1976696838;

	public const int NR5GPilotInfo_2_repetitionpattern = 1976696839;

	public const int NR5GPilotInfo_2_beamIndex = 1976696840;

	public const int NR5GPilotInfo_2_PSS_cinr = 1976696841;

	public const int NR5GPilotInfo_2_PSS_RP = 1976696842;

	public const int NR5GPilotInfo_2_PSS_RQ = 1976696843;

	public const int NR5GPilotInfo_2_SSS_cinr = 1976696844;

	public const int NR5GPilotInfo_2_SSS_RP = 1976696845;

	public const int NR5GPilotInfo_2_SSS_RQ = 1976696846;

	public const int NR5GPilotInfo_2_pbchDMRS_cinr = 1976696847;

	public const int NR5GPilotInfo_2_pbchDMRS_RP = 1976696848;

	public const int NR5GPilotInfo_2_pbchDMRS_RQ = 1976696849;

	public const int NR5GPilotInfo_2_ssb_cinr = 1976696850;

	public const int NR5GPilotInfo_2_ssb_RP = 1976696851;

	public const int NR5GPilotInfo_2_ssb_RQ = 1976696852;

	public const int NR5GPilotInfo_2_ssb_RSSi = 1976696853;

	public const int NR5GPilotInfo_2_pSSSDelaySpread = 1976696854;

	public const int NR5GPilotInfo_2_halfFrameNumber = 1976696855;

	public const int NR5GPilotInfo_3_PointIndex = 1976762368;

	public const int NR5GPilotInfo_3_ID = 1976762369;

	public const int NR5GPilotInfo_3_EARFCN = 1976762370;

	public const int NR5GPilotInfo_3_PCI = 1976762371;

	public const int NR5GPilotInfo_3_Timingoffset = 1976762372;

	public const int NR5GPilotInfo_3_bsRepeatitionPeriod = 1976762373;

	public const int NR5GPilotInfo_3_subcarrierSpacing = 1976762374;

	public const int NR5GPilotInfo_3_repetitionpattern = 1976762375;

	public const int NR5GPilotInfo_3_beamIndex = 1976762376;

	public const int NR5GPilotInfo_3_PSS_cinr = 1976762377;

	public const int NR5GPilotInfo_3_PSS_RP = 1976762378;

	public const int NR5GPilotInfo_3_PSS_RQ = 1976762379;

	public const int NR5GPilotInfo_3_SSS_cinr = 1976762380;

	public const int NR5GPilotInfo_3_SSS_RP = 1976762381;

	public const int NR5GPilotInfo_3_SSS_RQ = 1976762382;

	public const int NR5GPilotInfo_3_pbchDMRS_cinr = 1976762383;

	public const int NR5GPilotInfo_3_pbchDMRS_RP = 1976762384;

	public const int NR5GPilotInfo_3_pbchDMRS_RQ = 1976762385;

	public const int NR5GPilotInfo_3_ssb_cinr = 1976762386;

	public const int NR5GPilotInfo_3_ssb_RP = 1976762387;

	public const int NR5GPilotInfo_3_ssb_RQ = 1976762388;

	public const int NR5GPilotInfo_3_ssb_RSSi = 1976762389;

	public const int NR5GPilotInfo_3_pSSSDelaySpread = 1976762390;

	public const int NR5GPilotInfo_3_halfFrameNumber = 1976762391;

	public const int NR5GPilotInfo_4_PointIndex = 1976827904;

	public const int NR5GPilotInfo_4_ID = 1976827905;

	public const int NR5GPilotInfo_4_EARFCN = 1976827906;

	public const int NR5GPilotInfo_4_PCI = 1976827907;

	public const int NR5GPilotInfo_4_Timingoffset = 1976827908;

	public const int NR5GPilotInfo_4_bsRepeatitionPeriod = 1976827909;

	public const int NR5GPilotInfo_4_subcarrierSpacing = 1976827910;

	public const int NR5GPilotInfo_4_repetitionpattern = 1976827911;

	public const int NR5GPilotInfo_4_beamIndex = 1976827912;

	public const int NR5GPilotInfo_4_PSS_cinr = 1976827913;

	public const int NR5GPilotInfo_4_PSS_RP = 1976827914;

	public const int NR5GPilotInfo_4_PSS_RQ = 1976827915;

	public const int NR5GPilotInfo_4_SSS_cinr = 1976827916;

	public const int NR5GPilotInfo_4_SSS_RP = 1976827917;

	public const int NR5GPilotInfo_4_SSS_RQ = 1976827918;

	public const int NR5GPilotInfo_4_pbchDMRS_cinr = 1976827919;

	public const int NR5GPilotInfo_4_pbchDMRS_RP = 1976827920;

	public const int NR5GPilotInfo_4_pbchDMRS_RQ = 1976827921;

	public const int NR5GPilotInfo_4_ssb_cinr = 1976827922;

	public const int NR5GPilotInfo_4_ssb_RP = 1976827923;

	public const int NR5GPilotInfo_4_ssb_RQ = 1976827924;

	public const int NR5GPilotInfo_4_ssb_RSSi = 1976827925;

	public const int NR5GPilotInfo_4_pSSSDelaySpread = 1976827926;

	public const int NR5GPilotInfo_4_halfFrameNumber = 1976827927;

	public const int NR5GPilotInfo_5_PointIndex = 1976893440;

	public const int NR5GPilotInfo_5_ID = 1976893441;

	public const int NR5GPilotInfo_5_EARFCN = 1976893442;

	public const int NR5GPilotInfo_5_PCI = 1976893443;

	public const int NR5GPilotInfo_5_Timingoffset = 1976893444;

	public const int NR5GPilotInfo_5_bsRepeatitionPeriod = 1976893445;

	public const int NR5GPilotInfo_5_subcarrierSpacing = 1976893446;

	public const int NR5GPilotInfo_5_repetitionpattern = 1976893447;

	public const int NR5GPilotInfo_5_beamIndex = 1976893448;

	public const int NR5GPilotInfo_5_PSS_cinr = 1976893449;

	public const int NR5GPilotInfo_5_PSS_RP = 1976893450;

	public const int NR5GPilotInfo_5_PSS_RQ = 1976893451;

	public const int NR5GPilotInfo_5_SSS_cinr = 1976893452;

	public const int NR5GPilotInfo_5_SSS_RP = 1976893453;

	public const int NR5GPilotInfo_5_SSS_RQ = 1976893454;

	public const int NR5GPilotInfo_5_pbchDMRS_cinr = 1976893455;

	public const int NR5GPilotInfo_5_pbchDMRS_RP = 1976893456;

	public const int NR5GPilotInfo_5_pbchDMRS_RQ = 1976893457;

	public const int NR5GPilotInfo_5_ssb_cinr = 1976893458;

	public const int NR5GPilotInfo_5_ssb_RP = 1976893459;

	public const int NR5GPilotInfo_5_ssb_RQ = 1976893460;

	public const int NR5GPilotInfo_5_ssb_RSSi = 1976893461;

	public const int NR5GPilotInfo_5_pSSSDelaySpread = 1976893462;

	public const int NR5GPilotInfo_5_halfFrameNumber = 1976893463;

	public const int NR5GPilotInfo_6_PointIndex = 1976958976;

	public const int NR5GPilotInfo_6_ID = 1976958977;

	public const int NR5GPilotInfo_6_EARFCN = 1976958978;

	public const int NR5GPilotInfo_6_PCI = 1976958979;

	public const int NR5GPilotInfo_6_Timingoffset = 1976958980;

	public const int NR5GPilotInfo_6_bsRepeatitionPeriod = 1976958981;

	public const int NR5GPilotInfo_6_subcarrierSpacing = 1976958982;

	public const int NR5GPilotInfo_6_repetitionpattern = 1976958983;

	public const int NR5GPilotInfo_6_beamIndex = 1976958984;

	public const int NR5GPilotInfo_6_PSS_cinr = 1976958985;

	public const int NR5GPilotInfo_6_PSS_RP = 1976958986;

	public const int NR5GPilotInfo_6_PSS_RQ = 1976958987;

	public const int NR5GPilotInfo_6_SSS_cinr = 1976958988;

	public const int NR5GPilotInfo_6_SSS_RP = 1976958989;

	public const int NR5GPilotInfo_6_SSS_RQ = 1976958990;

	public const int NR5GPilotInfo_6_pbchDMRS_cinr = 1976958991;

	public const int NR5GPilotInfo_6_pbchDMRS_RP = 1976958992;

	public const int NR5GPilotInfo_6_pbchDMRS_RQ = 1976958993;

	public const int NR5GPilotInfo_6_ssb_cinr = 1976958994;

	public const int NR5GPilotInfo_6_ssb_RP = 1976958995;

	public const int NR5GPilotInfo_6_ssb_RQ = 1976958996;

	public const int NR5GPilotInfo_6_ssb_RSSi = 1976958997;

	public const int NR5GPilotInfo_6_pSSSDelaySpread = 1976958998;

	public const int NR5GPilotInfo_6_halfFrameNumber = 1976958999;

	public const int NR5GPilotInfo_7_PointIndex = 1977024512;

	public const int NR5GPilotInfo_7_ID = 1977024513;

	public const int NR5GPilotInfo_7_EARFCN = 1977024514;

	public const int NR5GPilotInfo_7_PCI = 1977024515;

	public const int NR5GPilotInfo_7_Timingoffset = 1977024516;

	public const int NR5GPilotInfo_7_bsRepeatitionPeriod = 1977024517;

	public const int NR5GPilotInfo_7_subcarrierSpacing = 1977024518;

	public const int NR5GPilotInfo_7_repetitionpattern = 1977024519;

	public const int NR5GPilotInfo_7_beamIndex = 1977024520;

	public const int NR5GPilotInfo_7_PSS_cinr = 1977024521;

	public const int NR5GPilotInfo_7_PSS_RP = 1977024522;

	public const int NR5GPilotInfo_7_PSS_RQ = 1977024523;

	public const int NR5GPilotInfo_7_SSS_cinr = 1977024524;

	public const int NR5GPilotInfo_7_SSS_RP = 1977024525;

	public const int NR5GPilotInfo_7_SSS_RQ = 1977024526;

	public const int NR5GPilotInfo_7_pbchDMRS_cinr = 1977024527;

	public const int NR5GPilotInfo_7_pbchDMRS_RP = 1977024528;

	public const int NR5GPilotInfo_7_pbchDMRS_RQ = 1977024529;

	public const int NR5GPilotInfo_7_ssb_cinr = 1977024530;

	public const int NR5GPilotInfo_7_ssb_RP = 1977024531;

	public const int NR5GPilotInfo_7_ssb_RQ = 1977024532;

	public const int NR5GPilotInfo_7_ssb_RSSi = 1977024533;

	public const int NR5GPilotInfo_7_pSSSDelaySpread = 1977024534;

	public const int NR5GPilotInfo_7_halfFrameNumber = 1977024535;

	public const int NR5GPilotInfo_8_PointIndex = 1977090048;

	public const int NR5GPilotInfo_8_ID = 1977090049;

	public const int NR5GPilotInfo_8_EARFCN = 1977090050;

	public const int NR5GPilotInfo_8_PCI = 1977090051;

	public const int NR5GPilotInfo_8_Timingoffset = 1977090052;

	public const int NR5GPilotInfo_8_bsRepeatitionPeriod = 1977090053;

	public const int NR5GPilotInfo_8_subcarrierSpacing = 1977090054;

	public const int NR5GPilotInfo_8_repetitionpattern = 1977090055;

	public const int NR5GPilotInfo_8_beamIndex = 1977090056;

	public const int NR5GPilotInfo_8_PSS_cinr = 1977090057;

	public const int NR5GPilotInfo_8_PSS_RP = 1977090058;

	public const int NR5GPilotInfo_8_PSS_RQ = 1977090059;

	public const int NR5GPilotInfo_8_SSS_cinr = 1977090060;

	public const int NR5GPilotInfo_8_SSS_RP = 1977090061;

	public const int NR5GPilotInfo_8_SSS_RQ = 1977090062;

	public const int NR5GPilotInfo_8_pbchDMRS_cinr = 1977090063;

	public const int NR5GPilotInfo_8_pbchDMRS_RP = 1977090064;

	public const int NR5GPilotInfo_8_pbchDMRS_RQ = 1977090065;

	public const int NR5GPilotInfo_8_ssb_cinr = 1977090066;

	public const int NR5GPilotInfo_8_ssb_RP = 1977090067;

	public const int NR5GPilotInfo_8_ssb_RQ = 1977090068;

	public const int NR5GPilotInfo_8_ssb_RSSi = 1977090069;

	public const int NR5GPilotInfo_8_pSSSDelaySpread = 1977090070;

	public const int NR5GPilotInfo_8_halfFrameNumber = 1977090071;

	public const int NR5GPilotInfo_9_PointIndex = 1977155584;

	public const int NR5GPilotInfo_9_ID = 1977155585;

	public const int NR5GPilotInfo_9_EARFCN = 1977155586;

	public const int NR5GPilotInfo_9_PCI = 1977155587;

	public const int NR5GPilotInfo_9_Timingoffset = 1977155588;

	public const int NR5GPilotInfo_9_bsRepeatitionPeriod = 1977155589;

	public const int NR5GPilotInfo_9_subcarrierSpacing = 1977155590;

	public const int NR5GPilotInfo_9_repetitionpattern = 1977155591;

	public const int NR5GPilotInfo_9_beamIndex = 1977155592;

	public const int NR5GPilotInfo_9_PSS_cinr = 1977155593;

	public const int NR5GPilotInfo_9_PSS_RP = 1977155594;

	public const int NR5GPilotInfo_9_PSS_RQ = 1977155595;

	public const int NR5GPilotInfo_9_SSS_cinr = 1977155596;

	public const int NR5GPilotInfo_9_SSS_RP = 1977155597;

	public const int NR5GPilotInfo_9_SSS_RQ = 1977155598;

	public const int NR5GPilotInfo_9_pbchDMRS_cinr = 1977155599;

	public const int NR5GPilotInfo_9_pbchDMRS_RP = 1977155600;

	public const int NR5GPilotInfo_9_pbchDMRS_RQ = 1977155601;

	public const int NR5GPilotInfo_9_ssb_cinr = 1977155602;

	public const int NR5GPilotInfo_9_ssb_RP = 1977155603;

	public const int NR5GPilotInfo_9_ssb_RQ = 1977155604;

	public const int NR5GPilotInfo_9_ssb_RSSi = 1977155605;

	public const int NR5GPilotInfo_9_pSSSDelaySpread = 1977155606;

	public const int NR5GPilotInfo_9_halfFrameNumber = 1977155607;

	public const int NR5GPilotInfo_10_PointIndex = 1977221120;

	public const int NR5GPilotInfo_10_ID = 1977221121;

	public const int NR5GPilotInfo_10_EARFCN = 1977221122;

	public const int NR5GPilotInfo_10_PCI = 1977221123;

	public const int NR5GPilotInfo_10_Timingoffset = 1977221124;

	public const int NR5GPilotInfo_10_bsRepeatitionPeriod = 1977221125;

	public const int NR5GPilotInfo_10_subcarrierSpacing = 1977221126;

	public const int NR5GPilotInfo_10_repetitionpattern = 1977221127;

	public const int NR5GPilotInfo_10_beamIndex = 1977221128;

	public const int NR5GPilotInfo_10_PSS_cinr = 1977221129;

	public const int NR5GPilotInfo_10_PSS_RP = 1977221130;

	public const int NR5GPilotInfo_10_PSS_RQ = 1977221131;

	public const int NR5GPilotInfo_10_SSS_cinr = 1977221132;

	public const int NR5GPilotInfo_10_SSS_RP = 1977221133;

	public const int NR5GPilotInfo_10_SSS_RQ = 1977221134;

	public const int NR5GPilotInfo_10_pbchDMRS_cinr = 1977221135;

	public const int NR5GPilotInfo_10_pbchDMRS_RP = 1977221136;

	public const int NR5GPilotInfo_10_pbchDMRS_RQ = 1977221137;

	public const int NR5GPilotInfo_10_ssb_cinr = 1977221138;

	public const int NR5GPilotInfo_10_ssb_RP = 1977221139;

	public const int NR5GPilotInfo_10_ssb_RQ = 1977221140;

	public const int NR5GPilotInfo_10_ssb_RSSi = 1977221141;

	public const int NR5GPilotInfo_10_pSSSDelaySpread = 1977221142;

	public const int NR5GPilotInfo_10_halfFrameNumber = 1977221143;

	public const int NR5GPilotInfo_11_PointIndex = 1977286656;

	public const int NR5GPilotInfo_11_ID = 1977286657;

	public const int NR5GPilotInfo_11_EARFCN = 1977286658;

	public const int NR5GPilotInfo_11_PCI = 1977286659;

	public const int NR5GPilotInfo_11_Timingoffset = 1977286660;

	public const int NR5GPilotInfo_11_bsRepeatitionPeriod = 1977286661;

	public const int NR5GPilotInfo_11_subcarrierSpacing = 1977286662;

	public const int NR5GPilotInfo_11_repetitionpattern = 1977286663;

	public const int NR5GPilotInfo_11_beamIndex = 1977286664;

	public const int NR5GPilotInfo_11_PSS_cinr = 1977286665;

	public const int NR5GPilotInfo_11_PSS_RP = 1977286666;

	public const int NR5GPilotInfo_11_PSS_RQ = 1977286667;

	public const int NR5GPilotInfo_11_SSS_cinr = 1977286668;

	public const int NR5GPilotInfo_11_SSS_RP = 1977286669;

	public const int NR5GPilotInfo_11_SSS_RQ = 1977286670;

	public const int NR5GPilotInfo_11_pbchDMRS_cinr = 1977286671;

	public const int NR5GPilotInfo_11_pbchDMRS_RP = 1977286672;

	public const int NR5GPilotInfo_11_pbchDMRS_RQ = 1977286673;

	public const int NR5GPilotInfo_11_ssb_cinr = 1977286674;

	public const int NR5GPilotInfo_11_ssb_RP = 1977286675;

	public const int NR5GPilotInfo_11_ssb_RQ = 1977286676;

	public const int NR5GPilotInfo_11_ssb_RSSi = 1977286677;

	public const int NR5GPilotInfo_11_pSSSDelaySpread = 1977286678;

	public const int NR5GPilotInfo_11_halfFrameNumber = 1977286679;

	public const int NR5GPilotInfo_12_PointIndex = 1977352192;

	public const int NR5GPilotInfo_12_ID = 1977352193;

	public const int NR5GPilotInfo_12_EARFCN = 1977352194;

	public const int NR5GPilotInfo_12_PCI = 1977352195;

	public const int NR5GPilotInfo_12_Timingoffset = 1977352196;

	public const int NR5GPilotInfo_12_bsRepeatitionPeriod = 1977352197;

	public const int NR5GPilotInfo_12_subcarrierSpacing = 1977352198;

	public const int NR5GPilotInfo_12_repetitionpattern = 1977352199;

	public const int NR5GPilotInfo_12_beamIndex = 1977352200;

	public const int NR5GPilotInfo_12_PSS_cinr = 1977352201;

	public const int NR5GPilotInfo_12_PSS_RP = 1977352202;

	public const int NR5GPilotInfo_12_PSS_RQ = 1977352203;

	public const int NR5GPilotInfo_12_SSS_cinr = 1977352204;

	public const int NR5GPilotInfo_12_SSS_RP = 1977352205;

	public const int NR5GPilotInfo_12_SSS_RQ = 1977352206;

	public const int NR5GPilotInfo_12_pbchDMRS_cinr = 1977352207;

	public const int NR5GPilotInfo_12_pbchDMRS_RP = 1977352208;

	public const int NR5GPilotInfo_12_pbchDMRS_RQ = 1977352209;

	public const int NR5GPilotInfo_12_ssb_cinr = 1977352210;

	public const int NR5GPilotInfo_12_ssb_RP = 1977352211;

	public const int NR5GPilotInfo_12_ssb_RQ = 1977352212;

	public const int NR5GPilotInfo_12_ssb_RSSi = 1977352213;

	public const int NR5GPilotInfo_12_pSSSDelaySpread = 1977352214;

	public const int NR5GPilotInfo_12_halfFrameNumber = 1977352215;

	public const int NR5GPilotInfo_13_PointIndex = 1977417728;

	public const int NR5GPilotInfo_13_ID = 1977417729;

	public const int NR5GPilotInfo_13_EARFCN = 1977417730;

	public const int NR5GPilotInfo_13_PCI = 1977417731;

	public const int NR5GPilotInfo_13_Timingoffset = 1977417732;

	public const int NR5GPilotInfo_13_bsRepeatitionPeriod = 1977417733;

	public const int NR5GPilotInfo_13_subcarrierSpacing = 1977417734;

	public const int NR5GPilotInfo_13_repetitionpattern = 1977417735;

	public const int NR5GPilotInfo_13_beamIndex = 1977417736;

	public const int NR5GPilotInfo_13_PSS_cinr = 1977417737;

	public const int NR5GPilotInfo_13_PSS_RP = 1977417738;

	public const int NR5GPilotInfo_13_PSS_RQ = 1977417739;

	public const int NR5GPilotInfo_13_SSS_cinr = 1977417740;

	public const int NR5GPilotInfo_13_SSS_RP = 1977417741;

	public const int NR5GPilotInfo_13_SSS_RQ = 1977417742;

	public const int NR5GPilotInfo_13_pbchDMRS_cinr = 1977417743;

	public const int NR5GPilotInfo_13_pbchDMRS_RP = 1977417744;

	public const int NR5GPilotInfo_13_pbchDMRS_RQ = 1977417745;

	public const int NR5GPilotInfo_13_ssb_cinr = 1977417746;

	public const int NR5GPilotInfo_13_ssb_RP = 1977417747;

	public const int NR5GPilotInfo_13_ssb_RQ = 1977417748;

	public const int NR5GPilotInfo_13_ssb_RSSi = 1977417749;

	public const int NR5GPilotInfo_13_pSSSDelaySpread = 1977417750;

	public const int NR5GPilotInfo_13_halfFrameNumber = 1977417751;

	public const int NR5GPilotInfo_14_PointIndex = 1977483264;

	public const int NR5GPilotInfo_14_ID = 1977483265;

	public const int NR5GPilotInfo_14_EARFCN = 1977483266;

	public const int NR5GPilotInfo_14_PCI = 1977483267;

	public const int NR5GPilotInfo_14_Timingoffset = 1977483268;

	public const int NR5GPilotInfo_14_bsRepeatitionPeriod = 1977483269;

	public const int NR5GPilotInfo_14_subcarrierSpacing = 1977483270;

	public const int NR5GPilotInfo_14_repetitionpattern = 1977483271;

	public const int NR5GPilotInfo_14_beamIndex = 1977483272;

	public const int NR5GPilotInfo_14_PSS_cinr = 1977483273;

	public const int NR5GPilotInfo_14_PSS_RP = 1977483274;

	public const int NR5GPilotInfo_14_PSS_RQ = 1977483275;

	public const int NR5GPilotInfo_14_SSS_cinr = 1977483276;

	public const int NR5GPilotInfo_14_SSS_RP = 1977483277;

	public const int NR5GPilotInfo_14_SSS_RQ = 1977483278;

	public const int NR5GPilotInfo_14_pbchDMRS_cinr = 1977483279;

	public const int NR5GPilotInfo_14_pbchDMRS_RP = 1977483280;

	public const int NR5GPilotInfo_14_pbchDMRS_RQ = 1977483281;

	public const int NR5GPilotInfo_14_ssb_cinr = 1977483282;

	public const int NR5GPilotInfo_14_ssb_RP = 1977483283;

	public const int NR5GPilotInfo_14_ssb_RQ = 1977483284;

	public const int NR5GPilotInfo_14_ssb_RSSi = 1977483285;

	public const int NR5GPilotInfo_14_pSSSDelaySpread = 1977483286;

	public const int NR5GPilotInfo_14_halfFrameNumber = 1977483287;

	public const int NR5GPilotInfo_15_PointIndex = 1977548800;

	public const int NR5GPilotInfo_15_ID = 1977548801;

	public const int NR5GPilotInfo_15_EARFCN = 1977548802;

	public const int NR5GPilotInfo_15_PCI = 1977548803;

	public const int NR5GPilotInfo_15_Timingoffset = 1977548804;

	public const int NR5GPilotInfo_15_bsRepeatitionPeriod = 1977548805;

	public const int NR5GPilotInfo_15_subcarrierSpacing = 1977548806;

	public const int NR5GPilotInfo_15_repetitionpattern = 1977548807;

	public const int NR5GPilotInfo_15_beamIndex = 1977548808;

	public const int NR5GPilotInfo_15_PSS_cinr = 1977548809;

	public const int NR5GPilotInfo_15_PSS_RP = 1977548810;

	public const int NR5GPilotInfo_15_PSS_RQ = 1977548811;

	public const int NR5GPilotInfo_15_SSS_cinr = 1977548812;

	public const int NR5GPilotInfo_15_SSS_RP = 1977548813;

	public const int NR5GPilotInfo_15_SSS_RQ = 1977548814;

	public const int NR5GPilotInfo_15_pbchDMRS_cinr = 1977548815;

	public const int NR5GPilotInfo_15_pbchDMRS_RP = 1977548816;

	public const int NR5GPilotInfo_15_pbchDMRS_RQ = 1977548817;

	public const int NR5GPilotInfo_15_ssb_cinr = 1977548818;

	public const int NR5GPilotInfo_15_ssb_RP = 1977548819;

	public const int NR5GPilotInfo_15_ssb_RQ = 1977548820;

	public const int NR5GPilotInfo_15_ssb_RSSi = 1977548821;

	public const int NR5GPilotInfo_15_pSSSDelaySpread = 1977548822;

	public const int NR5GPilotInfo_15_halfFrameNumber = 1977548823;

	public const int NR5GPilotInfo_16_PointIndex = 1977614336;

	public const int NR5GPilotInfo_16_ID = 1977614337;

	public const int NR5GPilotInfo_16_EARFCN = 1977614338;

	public const int NR5GPilotInfo_16_PCI = 1977614339;

	public const int NR5GPilotInfo_16_Timingoffset = 1977614340;

	public const int NR5GPilotInfo_16_bsRepeatitionPeriod = 1977614341;

	public const int NR5GPilotInfo_16_subcarrierSpacing = 1977614342;

	public const int NR5GPilotInfo_16_repetitionpattern = 1977614343;

	public const int NR5GPilotInfo_16_beamIndex = 1977614344;

	public const int NR5GPilotInfo_16_PSS_cinr = 1977614345;

	public const int NR5GPilotInfo_16_PSS_RP = 1977614346;

	public const int NR5GPilotInfo_16_PSS_RQ = 1977614347;

	public const int NR5GPilotInfo_16_SSS_cinr = 1977614348;

	public const int NR5GPilotInfo_16_SSS_RP = 1977614349;

	public const int NR5GPilotInfo_16_SSS_RQ = 1977614350;

	public const int NR5GPilotInfo_16_pbchDMRS_cinr = 1977614351;

	public const int NR5GPilotInfo_16_pbchDMRS_RP = 1977614352;

	public const int NR5GPilotInfo_16_pbchDMRS_RQ = 1977614353;

	public const int NR5GPilotInfo_16_ssb_cinr = 1977614354;

	public const int NR5GPilotInfo_16_ssb_RP = 1977614355;

	public const int NR5GPilotInfo_16_ssb_RQ = 1977614356;

	public const int NR5GPilotInfo_16_ssb_RSSi = 1977614357;

	public const int NR5GPilotInfo_16_pSSSDelaySpread = 1977614358;

	public const int NR5GPilotInfo_16_halfFrameNumber = 1977614359;

	public const int NR5GPilotInfo_AllInOne_PointIndex = 1979056128;

	public const int NR5GPilotInfo_AllInOne_ID = 1979056129;

	public const int NR5GPilotInfo_AllInOne_EARFCN = 1979056130;

	public const int NR5GPilotInfo_AllInOne_PCI = 1979056131;

	public const int NR5GPilotInfo_AllInOne_Timingoffset = 1979056132;

	public const int NR5GPilotInfo_AllInOne_bsRepeatitionPeriod = 1979056133;

	public const int NR5GPilotInfo_AllInOne_subcarrierSpacing = 1979056134;

	public const int NR5GPilotInfo_AllInOne_repetitionpattern = 1979056135;

	public const int NR5GPilotInfo_AllInOne_beamIndex = 1979056136;

	public const int NR5GPilotInfo_AllInOne_PSS_cinr = 1979056137;

	public const int NR5GPilotInfo_AllInOne_PSS_RP = 1979056138;

	public const int NR5GPilotInfo_AllInOne_PSS_RQ = 1979056139;

	public const int NR5GPilotInfo_AllInOne_SSS_cinr = 1979056140;

	public const int NR5GPilotInfo_AllInOne_SSS_RP = 1979056141;

	public const int NR5GPilotInfo_AllInOne_SSS_RQ = 1979056142;

	public const int NR5GPilotInfo_AllInOne_pbchDMRS_cinr = 1979056143;

	public const int NR5GPilotInfo_AllInOne_pbchDMRS_RP = 1979056144;

	public const int NR5GPilotInfo_AllInOne_pbchDMRS_RQ = 1979056145;

	public const int NR5GPilotInfo_AllInOne_ssb_cinr = 1979056146;

	public const int NR5GPilotInfo_AllInOne_ssb_RP = 1979056147;

	public const int NR5GPilotInfo_AllInOne_ssb_RQ = 1979056148;

	public const int NR5GPilotInfo_AllInOne_ssb_RSSi = 1979056149;

	public const int NR5GPilotInfo_AllInOne_pSSSDelaySpread = 1979056150;

	public const int NR5GPilotInfo_AllInOne_halfFrameNumber = 1979056151;

	public const int NR5GPilotInfo_AllInOne_GSCN = 1979056152;

	public const int NR5GPilotInfo_AllInOne_TxBeamID = 1979056153;

	public const int NR5GPilotInfo_AllInOne_PBCH_cinr = 1979056154;

	public const int NR5GPilotInfo_AllInOne_PBCH_RP = 1979056155;

	public const int NR5GPilotInfo_AllInOne_PBCH_RQ = 1979056156;

	public const int NR5GPilotInfo_AllInOne_PBCHSSS_cinr = 1979056157;

	public const int NR5GPilotInfo_AllInOne_PBCHSSS_RP = 1979056158;

	public const int NR5GPilotInfo_AllInOne_PBCHSSS_RQ = 1979056159;

	public const int NR5GPilotInfo_AllInOne_MCC1 = 1979056162;

	public const int NR5GPilotInfo_AllInOne_MNC1 = 1979056163;

	public const int NR5GPilotInfo_AllInOne_MCC2 = 1979056160;

	public const int NR5GPilotInfo_AllInOne_MNC2 = 1979056161;

	public const int NR5GPilotInfo_AllInOne_NCI = 1979056164;

	public const int NR5GPilotInfo_AllInOne_TAC = 1979056165;

	public const int NR5GPilotInfo_AllInOne_NodeBID = 1979056166;

	public const int NR5GPilotInfo_AllInOne_SectorID = 1979056167;

	public const int NR5GPilotInfo_AllInOne_BandWidth = 1979056168;

	public const int ScannerQueryUEBandInfo_UE1Band = 1973354498;

	public const int ScannerQueryUEBandInfo_UE2Band = 1973354499;

	public const int ScannerQueryUEBandInfo_UE3Band = 1973354500;

	public const int ScannerPilotTestMsg = 536979971;

	public const int NBPilotInfo_MaxMinRsrp_PointIndex = 1979187200;

	public const int NBPilotInfo_MaxMinRsrp_EARFCN = 1979187202;

	public const int NBPilotInfo_MaxMinRsrp_PCI = 1979187203;

	public const int NBPilotInfo_MaxMinRsrp_NB_RS_RP = 1979187216;

	public const int NBPilotInfo_MaxMinRsrp_NB_RS_RQ = 1979187217;

	public const int NBPilotInfo_MaxMinRsrp_NB_RS_SINR = 1979187218;

	public const int NBPilotInfo_MaxMinRsrp_NB_RS_RP_Min = 1979187219;

	public const int NBPilotInfo_MaxMinRsrp_Overlap_Level = 1979187220;

	public const int NBPilotInfo_MaxMinRsrp_SSS_RSSI = 1979187212;

	public const int NBPilotInfo_MaxMinRsrp_SSS_RP = 1979187213;

	public const int NBPilotInfo_MaxMinRsrp_Timingoffset = 1979187204;

	public const int NBPilotInfo_MaxMinRsrp_Bandwith = 1979187205;

	public const int NBPilotInfo_MaxMinRsrp_AntennaPortNumber = 1979187206;

	public const int SpectrumAnalysisInfo_PointIndex = 1972764672;

	public const int SpectrumAnalysisInfo_ID = 1972764673;

	public const int SpectrumAnalysisInfo_StartFreq = 1972764674;

	public const int SpectrumAnalysisInfo_StopFreq = 1972764675;

	public const int SpectrumAnalysisInfo_RBW = 1972764676;

	public const int SpectrumAnalysisInfo_NumResult = 1972764677;

	public const int SpectrumAnalysisInfo_BufferSize = 1972764678;

	public const int SpectrumAnalysisInfo_Buffer = 1972764679;

	public const int SpectrumAnalysisInfo_total_pwr_dBm = 1972764680;

	public const int SpectrumAnalysisInfo_allInOne_PointIndex = 1972830208;

	public const int SpectrumAnalysisInfo_allInOne_ID = 1972830209;

	public const int SpectrumAnalysisInfo_allInOne_StartFreq = 1972830210;

	public const int SpectrumAnalysisInfo_allInOne_StopFreq = 1972830211;

	public const int SpectrumAnalysisInfo_allInOne_RBW = 1972830212;

	public const int SpectrumAnalysisInfo_allInOne_NumResult = 1972830213;

	public const int SpectrumAnalysisInfo_allInOne_ResultIndex = 1972830214;

	public const int SpectrumAnalysisInfo_allInOne_ResultFreq = 1972830215;

	public const int SpectrumAnalysisInfo_allInOne_ResultPower = 1972830216;

	public const int SpectrumAnalysisInfo_MaxMinInfo_PointIndex = 1972895744;

	public const int SpectrumAnalysisInfo_MaxMinInfo_ID = 1972895745;

	public const int SpectrumAnalysisInfo_MaxMinInfo_Freq = 1972895746;

	public const int SpectrumAnalysisInfo_MaxMinInfo_MaxPower = 1972895747;

	public const int SpectrumAnalysisInfo_MaxMinInfo_MinPower = 1972895748;

	public const int NBPilotInfo_1_PointIndex = 1979252736;

	public const int NBPilotInfo_1_EARFCN = 1979252738;

	public const int NBPilotInfo_1_PCI = 1979252739;

	public const int NBPilotInfo_1_Timingoffset = 1979252740;

	public const int NBPilotInfo_1_Bandwith = 1979252741;

	public const int NBPilotInfo_1_AntennaPortNumber = 1979252742;

	public const int NBPilotInfo_1_CPType = 1979252743;

	public const int NBPilotInfo_1_CellIdentity = 1979252744;

	public const int NBPilotInfo_1_PSS_RSSI = 1979252745;

	public const int NBPilotInfo_1_PSS_RP = 1979252746;

	public const int NBPilotInfo_1_PSS_RQ = 1979252747;

	public const int NBPilotInfo_1_SSS_RSSI = 1979252748;

	public const int NBPilotInfo_1_SSS_RP = 1979252749;

	public const int NBPilotInfo_1_SSS_RQ = 1979252750;

	public const int NBPilotInfo_1_NB_RS_RSSI = 1979252751;

	public const int NBPilotInfo_1_NB_RS_RP = 1979252752;

	public const int NBPilotInfo_1_NB_RS_RQ = 1979252753;

	public const int NBPilotInfo_1_NB_RS_SINR = 1979252754;

	public const int NBPilotInfo_2_PointIndex = 1979318272;

	public const int NBPilotInfo_2_EARFCN = 1979318274;

	public const int NBPilotInfo_2_PCI = 1979318275;

	public const int NBPilotInfo_2_Timingoffset = 1979318276;

	public const int NBPilotInfo_2_Bandwith = 1979318277;

	public const int NBPilotInfo_2_AntennaPortNumber = 1979318278;

	public const int NBPilotInfo_2_CPType = 1979318279;

	public const int NBPilotInfo_2_CellIdentity = 1979318280;

	public const int NBPilotInfo_2_PSS_RSSI = 1979318281;

	public const int NBPilotInfo_2_PSS_RP = 1979318282;

	public const int NBPilotInfo_2_PSS_RQ = 1979318283;

	public const int NBPilotInfo_2_SSS_RSSI = 1979318284;

	public const int NBPilotInfo_2_SSS_RP = 1979318285;

	public const int NBPilotInfo_2_SSS_RQ = 1979318286;

	public const int NBPilotInfo_2_NB_RS_RSSI = 1979318287;

	public const int NBPilotInfo_2_NB_RS_RP = 1979318288;

	public const int NBPilotInfo_2_NB_RS_RQ = 1979318289;

	public const int NBPilotInfo_2_NB_RS_SINR = 1979318290;

	public const int NBPilotInfo_3_PointIndex = 1979383808;

	public const int NBPilotInfo_3_EARFCN = 1979383810;

	public const int NBPilotInfo_3_PCI = 1979383811;

	public const int NBPilotInfo_3_Timingoffset = 1979383812;

	public const int NBPilotInfo_3_Bandwith = 1979383813;

	public const int NBPilotInfo_3_AntennaPortNumber = 1979383814;

	public const int NBPilotInfo_3_CPType = 1979383815;

	public const int NBPilotInfo_3_CellIdentity = 1979383816;

	public const int NBPilotInfo_3_PSS_RSSI = 1979383817;

	public const int NBPilotInfo_3_PSS_RP = 1979383818;

	public const int NBPilotInfo_3_PSS_RQ = 1979383819;

	public const int NBPilotInfo_3_SSS_RSSI = 1979383820;

	public const int NBPilotInfo_3_SSS_RP = 1979383821;

	public const int NBPilotInfo_3_SSS_RQ = 1979383822;

	public const int NBPilotInfo_3_NB_RS_RSSI = 1979383823;

	public const int NBPilotInfo_3_NB_RS_RP = 1979383824;

	public const int NBPilotInfo_3_NB_RS_RQ = 1979383825;

	public const int NBPilotInfo_3_NB_RS_SINR = 1979383826;

	public const int NBPilotInfo_4_PointIndex = 1979449344;

	public const int NBPilotInfo_4_EARFCN = 1979449346;

	public const int NBPilotInfo_4_PCI = 1979449347;

	public const int NBPilotInfo_4_Timingoffset = 1979449348;

	public const int NBPilotInfo_4_Bandwith = 1979449349;

	public const int NBPilotInfo_4_AntennaPortNumber = 1979449350;

	public const int NBPilotInfo_4_CPType = 1979449351;

	public const int NBPilotInfo_4_CellIdentity = 1979449352;

	public const int NBPilotInfo_4_PSS_RSSI = 1979449353;

	public const int NBPilotInfo_4_PSS_RP = 1979449354;

	public const int NBPilotInfo_4_PSS_RQ = 1979449355;

	public const int NBPilotInfo_4_SSS_RSSI = 1979449356;

	public const int NBPilotInfo_4_SSS_RP = 1979449357;

	public const int NBPilotInfo_4_SSS_RQ = 1979449358;

	public const int NBPilotInfo_4_NB_RS_RSSI = 1979449359;

	public const int NBPilotInfo_4_NB_RS_RP = 1979449360;

	public const int NBPilotInfo_4_NB_RS_RQ = 1979449361;

	public const int NBPilotInfo_4_NB_RS_SINR = 1979449362;

	public const int NBPilotInfo_5_PointIndex = 1979514880;

	public const int NBPilotInfo_5_EARFCN = 1979514882;

	public const int NBPilotInfo_5_PCI = 1979514883;

	public const int NBPilotInfo_5_Timingoffset = 1979514884;

	public const int NBPilotInfo_5_Bandwith = 1979514885;

	public const int NBPilotInfo_5_AntennaPortNumber = 1979514886;

	public const int NBPilotInfo_5_CPType = 1979514887;

	public const int NBPilotInfo_5_CellIdentity = 1979514888;

	public const int NBPilotInfo_5_PSS_RSSI = 1979514889;

	public const int NBPilotInfo_5_PSS_RP = 1979514890;

	public const int NBPilotInfo_5_PSS_RQ = 1979514891;

	public const int NBPilotInfo_5_SSS_RSSI = 1979514892;

	public const int NBPilotInfo_5_SSS_RP = 1979514893;

	public const int NBPilotInfo_5_SSS_RQ = 1979514894;

	public const int NBPilotInfo_5_NB_RS_RSSI = 1979514895;

	public const int NBPilotInfo_5_NB_RS_RP = 1979514896;

	public const int NBPilotInfo_5_NB_RS_RQ = 1979514897;

	public const int NBPilotInfo_5_NB_RS_SINR = 1979514898;

	public const int NBPilotInfo_6_PointIndex = 1979580416;

	public const int NBPilotInfo_6_EARFCN = 1979580418;

	public const int NBPilotInfo_6_PCI = 1979580419;

	public const int NBPilotInfo_6_Timingoffset = 1979580420;

	public const int NBPilotInfo_6_Bandwith = 1979580421;

	public const int NBPilotInfo_6_AntennaPortNumber = 1979580422;

	public const int NBPilotInfo_6_CPType = 1979580423;

	public const int NBPilotInfo_6_CellIdentity = 1979580424;

	public const int NBPilotInfo_6_PSS_RSSI = 1979580425;

	public const int NBPilotInfo_6_PSS_RP = 1979580426;

	public const int NBPilotInfo_6_PSS_RQ = 1979580427;

	public const int NBPilotInfo_6_SSS_RSSI = 1979580428;

	public const int NBPilotInfo_6_SSS_RP = 1979580429;

	public const int NBPilotInfo_6_SSS_RQ = 1979580430;

	public const int NBPilotInfo_6_NB_RS_RSSI = 1979580431;

	public const int NBPilotInfo_6_NB_RS_RP = 1979580432;

	public const int NBPilotInfo_6_NB_RS_RQ = 1979580433;

	public const int NBPilotInfo_6_NB_RS_SINR = 1979580434;

	public const int NBPilotInfo_7_PointIndex = 1979645952;

	public const int NBPilotInfo_7_EARFCN = 1979645954;

	public const int NBPilotInfo_7_PCI = 1979645955;

	public const int NBPilotInfo_7_Timingoffset = 1979645956;

	public const int NBPilotInfo_7_Bandwith = 1979645957;

	public const int NBPilotInfo_7_AntennaPortNumber = 1979645958;

	public const int NBPilotInfo_7_CPType = 1979645959;

	public const int NBPilotInfo_7_CellIdentity = 1979645960;

	public const int NBPilotInfo_7_PSS_RSSI = 1979645961;

	public const int NBPilotInfo_7_PSS_RP = 1979645962;

	public const int NBPilotInfo_7_PSS_RQ = 1979645963;

	public const int NBPilotInfo_7_SSS_RSSI = 1979645964;

	public const int NBPilotInfo_7_SSS_RP = 1979645965;

	public const int NBPilotInfo_7_SSS_RQ = 1979645966;

	public const int NBPilotInfo_7_NB_RS_RSSI = 1979645967;

	public const int NBPilotInfo_7_NB_RS_RP = 1979645968;

	public const int NBPilotInfo_7_NB_RS_RQ = 1979645969;

	public const int NBPilotInfo_7_NB_RS_SINR = 1979645970;

	public const int NBPilotInfo_8_PointIndex = 1979711488;

	public const int NBPilotInfo_8_EARFCN = 1979711490;

	public const int NBPilotInfo_8_PCI = 1979711491;

	public const int NBPilotInfo_8_Timingoffset = 1979711492;

	public const int NBPilotInfo_8_Bandwith = 1979711493;

	public const int NBPilotInfo_8_AntennaPortNumber = 1979711494;

	public const int NBPilotInfo_8_CPType = 1979711495;

	public const int NBPilotInfo_8_CellIdentity = 1979711496;

	public const int NBPilotInfo_8_PSS_RSSI = 1979711497;

	public const int NBPilotInfo_8_PSS_RP = 1979711498;

	public const int NBPilotInfo_8_PSS_RQ = 1979711499;

	public const int NBPilotInfo_8_SSS_RSSI = 1979711500;

	public const int NBPilotInfo_8_SSS_RP = 1979711501;

	public const int NBPilotInfo_8_SSS_RQ = 1979711502;

	public const int NBPilotInfo_8_NB_RS_RSSI = 1979711503;

	public const int NBPilotInfo_8_NB_RS_RP = 1979711504;

	public const int NBPilotInfo_8_NB_RS_RQ = 1979711505;

	public const int NBPilotInfo_8_NB_RS_SINR = 1979711506;

	public const int NBPilotInfo_9_PointIndex = 1979777024;

	public const int NBPilotInfo_9_EARFCN = 1979777026;

	public const int NBPilotInfo_9_PCI = 1979777027;

	public const int NBPilotInfo_9_Timingoffset = 1979777028;

	public const int NBPilotInfo_9_Bandwith = 1979777029;

	public const int NBPilotInfo_9_AntennaPortNumber = 1979777030;

	public const int NBPilotInfo_9_CPType = 1979777031;

	public const int NBPilotInfo_9_CellIdentity = 1979777032;

	public const int NBPilotInfo_9_PSS_RSSI = 1979777033;

	public const int NBPilotInfo_9_PSS_RP = 1979777034;

	public const int NBPilotInfo_9_PSS_RQ = 1979777035;

	public const int NBPilotInfo_9_SSS_RSSI = 1979777036;

	public const int NBPilotInfo_9_SSS_RP = 1979777037;

	public const int NBPilotInfo_9_SSS_RQ = 1979777038;

	public const int NBPilotInfo_9_NB_RS_RSSI = 1979777039;

	public const int NBPilotInfo_9_NB_RS_RP = 1979777040;

	public const int NBPilotInfo_9_NB_RS_RQ = 1979777041;

	public const int NBPilotInfo_9_NB_RS_SINR = 1979777042;

	public const int NBPilotInfo_10_PointIndex = 1979842560;

	public const int NBPilotInfo_10_EARFCN = 1979842562;

	public const int NBPilotInfo_10_PCI = 1979842563;

	public const int NBPilotInfo_10_Timingoffset = 1979842564;

	public const int NBPilotInfo_10_Bandwith = 1979842565;

	public const int NBPilotInfo_10_AntennaPortNumber = 1979842566;

	public const int NBPilotInfo_10_CPType = 1979842567;

	public const int NBPilotInfo_10_CellIdentity = 1979842568;

	public const int NBPilotInfo_10_PSS_RSSI = 1979842569;

	public const int NBPilotInfo_10_PSS_RP = 1979842570;

	public const int NBPilotInfo_10_PSS_RQ = 1979842571;

	public const int NBPilotInfo_10_SSS_RSSI = 1979842572;

	public const int NBPilotInfo_10_SSS_RP = 1979842573;

	public const int NBPilotInfo_10_SSS_RQ = 1979842574;

	public const int NBPilotInfo_10_NB_RS_RSSI = 1979842575;

	public const int NBPilotInfo_10_NB_RS_RP = 1979842576;

	public const int NBPilotInfo_10_NB_RS_RQ = 1979842577;

	public const int NBPilotInfo_10_NB_RS_SINR = 1979842578;

	public const int NBPilotInfo_11_PointIndex = 1979908096;

	public const int NBPilotInfo_11_EARFCN = 1979908098;

	public const int NBPilotInfo_11_PCI = 1979908099;

	public const int NBPilotInfo_11_Timingoffset = 1979908100;

	public const int NBPilotInfo_11_Bandwith = 1979908101;

	public const int NBPilotInfo_11_AntennaPortNumber = 1979908102;

	public const int NBPilotInfo_11_CPType = 1979908103;

	public const int NBPilotInfo_11_CellIdentity = 1979908104;

	public const int NBPilotInfo_11_PSS_RSSI = 1979908105;

	public const int NBPilotInfo_11_PSS_RP = 1979908106;

	public const int NBPilotInfo_11_PSS_RQ = 1979908107;

	public const int NBPilotInfo_11_SSS_RSSI = 1979908108;

	public const int NBPilotInfo_11_SSS_RP = 1979908109;

	public const int NBPilotInfo_11_SSS_RQ = 1979908110;

	public const int NBPilotInfo_11_NB_RS_RSSI = 1979908111;

	public const int NBPilotInfo_11_NB_RS_RP = 1979908112;

	public const int NBPilotInfo_11_NB_RS_RQ = 1979908113;

	public const int NBPilotInfo_11_NB_RS_SINR = 1979908114;

	public const int NBPilotInfo_12_PointIndex = 1979973632;

	public const int NBPilotInfo_12_EARFCN = 1979973634;

	public const int NBPilotInfo_12_PCI = 1979973635;

	public const int NBPilotInfo_12_Timingoffset = 1979973636;

	public const int NBPilotInfo_12_Bandwith = 1979973637;

	public const int NBPilotInfo_12_AntennaPortNumber = 1979973638;

	public const int NBPilotInfo_12_CPType = 1979973639;

	public const int NBPilotInfo_12_CellIdentity = 1979973640;

	public const int NBPilotInfo_12_PSS_RSSI = 1979973641;

	public const int NBPilotInfo_12_PSS_RP = 1979973642;

	public const int NBPilotInfo_12_PSS_RQ = 1979973643;

	public const int NBPilotInfo_12_SSS_RSSI = 1979973644;

	public const int NBPilotInfo_12_SSS_RP = 1979973645;

	public const int NBPilotInfo_12_SSS_RQ = 1979973646;

	public const int NBPilotInfo_12_NB_RS_RSSI = 1979973647;

	public const int NBPilotInfo_12_NB_RS_RP = 1979973648;

	public const int NBPilotInfo_12_NB_RS_RQ = 1979973649;

	public const int NBPilotInfo_12_NB_RS_SINR = 1979973650;

	public const int NBPilotInfo_13_PointIndex = 1980039168;

	public const int NBPilotInfo_13_EARFCN = 1980039170;

	public const int NBPilotInfo_13_PCI = 1980039171;

	public const int NBPilotInfo_13_Timingoffset = 1980039172;

	public const int NBPilotInfo_13_Bandwith = 1980039173;

	public const int NBPilotInfo_13_AntennaPortNumber = 1980039174;

	public const int NBPilotInfo_13_CPType = 1980039175;

	public const int NBPilotInfo_13_CellIdentity = 1980039176;

	public const int NBPilotInfo_13_PSS_RSSI = 1980039177;

	public const int NBPilotInfo_13_PSS_RP = 1980039178;

	public const int NBPilotInfo_13_PSS_RQ = 1980039179;

	public const int NBPilotInfo_13_SSS_RSSI = 1980039180;

	public const int NBPilotInfo_13_SSS_RP = 1980039181;

	public const int NBPilotInfo_13_SSS_RQ = 1980039182;

	public const int NBPilotInfo_13_NB_RS_RSSI = 1980039183;

	public const int NBPilotInfo_13_NB_RS_RP = 1980039184;

	public const int NBPilotInfo_13_NB_RS_RQ = 1980039185;

	public const int NBPilotInfo_13_NB_RS_SINR = 1980039186;

	public const int NBPilotInfo_14_PointIndex = 1980104704;

	public const int NBPilotInfo_14_EARFCN = 1980104706;

	public const int NBPilotInfo_14_PCI = 1980104707;

	public const int NBPilotInfo_14_Timingoffset = 1980104708;

	public const int NBPilotInfo_14_Bandwith = 1980104709;

	public const int NBPilotInfo_14_AntennaPortNumber = 1980104710;

	public const int NBPilotInfo_14_CPType = 1980104711;

	public const int NBPilotInfo_14_CellIdentity = 1980104712;

	public const int NBPilotInfo_14_PSS_RSSI = 1980104713;

	public const int NBPilotInfo_14_PSS_RP = 1980104714;

	public const int NBPilotInfo_14_PSS_RQ = 1980104715;

	public const int NBPilotInfo_14_SSS_RSSI = 1980104716;

	public const int NBPilotInfo_14_SSS_RP = 1980104717;

	public const int NBPilotInfo_14_SSS_RQ = 1980104718;

	public const int NBPilotInfo_14_NB_RS_RSSI = 1980104719;

	public const int NBPilotInfo_14_NB_RS_RP = 1980104720;

	public const int NBPilotInfo_14_NB_RS_RQ = 1980104721;

	public const int NBPilotInfo_14_NB_RS_SINR = 1980104722;

	public const int NBPilotInfo_15_PointIndex = 1980170240;

	public const int NBPilotInfo_15_EARFCN = 1980170242;

	public const int NBPilotInfo_15_PCI = 1980170243;

	public const int NBPilotInfo_15_Timingoffset = 1980170244;

	public const int NBPilotInfo_15_Bandwith = 1980170245;

	public const int NBPilotInfo_15_AntennaPortNumber = 1980170246;

	public const int NBPilotInfo_15_CPType = 1980170247;

	public const int NBPilotInfo_15_CellIdentity = 1980170248;

	public const int NBPilotInfo_15_PSS_RSSI = 1980170249;

	public const int NBPilotInfo_15_PSS_RP = 1980170250;

	public const int NBPilotInfo_15_PSS_RQ = 1980170251;

	public const int NBPilotInfo_15_SSS_RSSI = 1980170252;

	public const int NBPilotInfo_15_SSS_RP = 1980170253;

	public const int NBPilotInfo_15_SSS_RQ = 1980170254;

	public const int NBPilotInfo_15_NB_RS_RSSI = 1980170255;

	public const int NBPilotInfo_15_NB_RS_RP = 1980170256;

	public const int NBPilotInfo_15_NB_RS_RQ = 1980170257;

	public const int NBPilotInfo_15_NB_RS_SINR = 1980170258;

	public const int NBPilotInfo_16_PointIndex = 1980235776;

	public const int NBPilotInfo_16_EARFCN = 1980235778;

	public const int NBPilotInfo_16_PCI = 1980235779;

	public const int NBPilotInfo_16_Timingoffset = 1980235780;

	public const int NBPilotInfo_16_Bandwith = 1980235781;

	public const int NBPilotInfo_16_AntennaPortNumber = 1980235782;

	public const int NBPilotInfo_16_CPType = 1980235783;

	public const int NBPilotInfo_16_CellIdentity = 1980235784;

	public const int NBPilotInfo_16_PSS_RSSI = 1980235785;

	public const int NBPilotInfo_16_PSS_RP = 1980235786;

	public const int NBPilotInfo_16_PSS_RQ = 1980235787;

	public const int NBPilotInfo_16_SSS_RSSI = 1980235788;

	public const int NBPilotInfo_16_SSS_RP = 1980235789;

	public const int NBPilotInfo_16_SSS_RQ = 1980235790;

	public const int NBPilotInfo_16_NB_RS_RSSI = 1980235791;

	public const int NBPilotInfo_16_NB_RS_RP = 1980235792;

	public const int NBPilotInfo_16_NB_RS_RQ = 1980235793;

	public const int NBPilotInfo_16_NB_RS_SINR = 1980235794;

	public const int LTEPilotInfo_MaxMinRsrp_PointIndex = 1985740800;

	public const int LTEPilotInfo_MaxMinRsrp_ID = 1985740801;

	public const int LTEPilotInfo_MaxMinRsrp_EARFCN = 1985740802;

	public const int LTEPilotInfo_MaxMinRsrp_PCI = 1985740803;

	public const int LTEPilotInfo_MaxMinRsrp_Timingoffset = 1985740804;

	public const int LTEPilotInfo_MaxMinRsrp_Bandwith = 1985740805;

	public const int LTEPilotInfo_MaxMinRsrp_AntennaPortNumber = 1985740806;

	public const int LTEPilotInfo_MaxMinRsrp_CPType = 1985740807;

	public const int LTEPilotInfo_MaxMinRsrp_CellIdentity = 1985740808;

	public const int LTEPilotInfo_MaxMinRsrp_PSS_RSSI = 1985740809;

	public const int LTEPilotInfo_MaxMinRsrp_PSS_RP = 1985740810;

	public const int LTEPilotInfo_MaxMinRsrp_PSS_RQ = 1985740811;

	public const int LTEPilotInfo_MaxMinRsrp_SSS_RSSI = 1985740812;

	public const int LTEPilotInfo_MaxMinRsrp_SSS_RP = 1985740813;

	public const int LTEPilotInfo_MaxMinRsrp_SSS_RQ = 1985740814;

	public const int LTEPilotInfo_MaxMinRsrp_LTE_RS_RSSI = 1985740815;

	public const int LTEPilotInfo_MaxMinRsrp_LTE_RS_RP = 1985740816;

	public const int LTEPilotInfo_MaxMinRsrp_LTE_RS_RQ = 1985740817;

	public const int LTEPilotInfo_MaxMinRsrp_LTE_RS_SINR = 1985740818;

	public const int LTEPilotInfo_MaxMinRsrp_LTE_RS_RP_Min = 1985740819;

	public const int LTEPilotInfo_MaxMinRsrp_Overlap_Level = 1985740820;

	public const int LTEPilotInfo_MaxMinRsrp_NID1 = 1985740821;

	public const int LTEPilotInfo_MaxMinRsrp_NID2 = 1985740822;

	public const int LTEPilotInfo_MaxMinRsrp_DelaySpread = 1985740823;

	public const int LTEEPS_ScanInfo_PointIndex = 1987903488;

	public const int LTEEPS_ScanInfo_ID = 1987903489;

	public const int LTEEPS_ScanInfo_EARFCN = 1987903490;

	public const int LTEEPS_ScanInfo_Band = 1987903491;

	public const int LTEEPS_ScanInfo_ScanMode = 1987903492;

	public const int LTEEPS_ScanInfo_CpType = 1987903493;

	public const int LTEEPS_ScanInfo_SA = 1987903494;

	public const int LTEEPS_ScanInfo_SSP = 1987903495;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_PointIndex = 1987969024;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_ID = 1987969025;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_EARFCN = 1987969026;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_FramePower = 1987969027;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_Reserved2 = 1987969028;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_DwPTSPower = 1987969029;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_GPPower = 1987969030;

	public const int LTEEPS_DwPTS_GP_UpPTSInfo_UpPTSPower = 1987969031;

	public const int LTEPowerAnalysis_PointIndex = 1988034560;

	public const int LTEPowerAnalysis_ID = 1988034561;

	public const int LTEPowerAnalysis_StartFreq = 1988034562;

	public const int LTEPowerAnalysis_Reserved1 = 1988034563;

	public const int LTEPowerAnalysis_Reserved2 = 1988034564;

	public const int LTEPowerAnalysis_NumResult = 1988034565;

	public const int LTEPowerAnalysis_BufferSize = 1988034566;

	public const int LTEPowerAnalysis_Buffer = 1988034567;

	public const int LTEEPS_SubframInfo_PointIndex = 1988100096;

	public const int LTEEPS_SubframInfo_ID = 1988100097;

	public const int LTEEPS_SubframInfo_EARFCN = 1988100098;

	public const int LTEEPS_SubframInfo_FramePower = 1988100099;

	public const int LTEEPS_SubframInfo_Reserved2 = 1988100100;

	public const int LTEEPS_SubframInfo_SubFrameCount = 1988100101;

	public const int LTEEPS_SubframInfo_SubFrameIndex = 1988100102;

	public const int LTEEPS_SubframInfo_SubFramePower = 1988100103;

	public const int LTEEPS_TimeSlotInfo_PointIndex = 1988165632;

	public const int LTEEPS_TimeSlotInfo_ID = 1988165633;

	public const int LTEEPS_TimeSlotInfo_EARFCN = 1988165634;

	public const int LTEEPS_TimeSlotInfo_FramePower = 1988165635;

	public const int LTEEPS_TimeSlotInfo_Reserved2 = 1988165636;

	public const int LTEEPS_TimeSlotInfo_TimeSlotCount = 1988165637;

	public const int LTEEPS_TimeSlotInfo_TimeSlotIndex = 1988165638;

	public const int LTEEPS_TimeSlotInfo_TimeSlotPower = 1988165639;

	public const int LTEEPS_REInfo_PointIndex = 1988231168;

	public const int LTEEPS_REInfo_ID = 1988231169;

	public const int LTEEPS_REInfo_EARFCN = 1988231170;

	public const int LTEEPS_REInfo_SlotIndex = 1988231171;

	public const int LTEEPS_REInfo_SubCarrierIndex = 1988231172;

	public const int LTEEPS_REInfo_RECount = 1988231173;

	public const int LTEEPS_REInfo_REIndex = 1988231174;

	public const int LTEEPS_REInfo_REPower = 1988231175;

	public const int LTEEPS_SymbolInfo_PointIndex = 1988296704;

	public const int LTEEPS_SymbolInfo_ID = 1988296705;

	public const int LTEEPS_SymbolInfo_EARFCN = 1988296706;

	public const int LTEEPS_SymbolInfo_SlotIndex = 1988296707;

	public const int LTEEPS_SymbolInfo_Reserved2 = 1988296708;

	public const int LTEEPS_SymbolInfo_SymbolCount = 1988296709;

	public const int LTEEPS_SymbolInfo_SymbolIndex = 1988296710;

	public const int LTEEPS_SymbolInfo_SymbolPower = 1988296711;

	public const int LTEPilotInfo_1_PointIndex = 1985806336;

	public const int LTEPilotInfo_1_ID = 1985806337;

	public const int LTEPilotInfo_1_EARFCN = 1985806338;

	public const int LTEPilotInfo_1_PCI = 1985806339;

	public const int LTEPilotInfo_1_Timingoffset = 1985806340;

	public const int LTEPilotInfo_1_Bandwith = 1985806341;

	public const int LTEPilotInfo_1_AntennaPortNumber = 1985806342;

	public const int LTEPilotInfo_1_CPType = 1985806343;

	public const int LTEPilotInfo_1_CellIdentity = 1985806344;

	public const int LTEPilotInfo_1_PSS_RSSI = 1985806345;

	public const int LTEPilotInfo_1_PSS_RP = 1985806346;

	public const int LTEPilotInfo_1_PSS_RQ = 1985806347;

	public const int LTEPilotInfo_1_SSS_RSSI = 1985806348;

	public const int LTEPilotInfo_1_SSS_RP = 1985806349;

	public const int LTEPilotInfo_1_SSS_RQ = 1985806350;

	public const int LTEPilotInfo_1_LTE_RS_RSSI = 1985806351;

	public const int LTEPilotInfo_1_LTE_RS_RP = 1985806352;

	public const int LTEPilotInfo_1_LTE_RS_RQ = 1985806353;

	public const int LTEPilotInfo_1_LTE_RS_SINR = 1985806354;

	public const int LTEPilotInfo_1_NID1 = 1985806355;

	public const int LTEPilotInfo_1_NID2 = 1985806356;

	public const int LTEPilotInfo_1_DelaySpread = 1985806357;

	public const int LTEPilotInfo_1_LTE_PBCH_RSSI = 1985806358;

	public const int LTEPilotInfo_1_LTE_PBCH_RP = 1985806359;

	public const int LTEPilotInfo_1_LTE_PBCH_RQ = 1985806360;

	public const int LTEPilotInfo_1_LTE_PBCH_SINR = 1985806361;

	public const int LTEPilotInfo_1_LTE_RS_RP_Ant0 = 1985806362;

	public const int LTEPilotInfo_1_LTE_RS_RQ_Ant0 = 1985806363;

	public const int LTEPilotInfo_1_LTE_RS_SINR_Ant0 = 1985806364;

	public const int LTEPilotInfo_1_LTE_RS_RP_Ant1 = 1985806365;

	public const int LTEPilotInfo_1_LTE_RS_RQ_Ant1 = 1985806366;

	public const int LTEPilotInfo_1_LTE_RS_SINR_Ant1 = 1985806367;

	public const int LTEPilotInfo_1_TAC = 1985806368;

	public const int LTEPilotInfo_1_SA = 1985806369;

	public const int LTEPilotInfo_1_SSP = 1985806370;

	public const int LTEPilotInfo_1_eNodebID = 1985806371;

	public const int LTEPilotInfo_1_SectorID = 1985806372;

	public const int LTEPilotInfo_2_PointIndex = 1985871872;

	public const int LTEPilotInfo_2_ID = 1985871873;

	public const int LTEPilotInfo_2_EARFCN = 1985871874;

	public const int LTEPilotInfo_2_PCI = 1985871875;

	public const int LTEPilotInfo_2_Timingoffset = 1985871876;

	public const int LTEPilotInfo_2_Bandwith = 1985871877;

	public const int LTEPilotInfo_2_AntennaPortNumber = 1985871878;

	public const int LTEPilotInfo_2_CPType = 1985871879;

	public const int LTEPilotInfo_2_CellIdentity = 1985871880;

	public const int LTEPilotInfo_2_PSS_RSSI = 1985871881;

	public const int LTEPilotInfo_2_PSS_RP = 1985871882;

	public const int LTEPilotInfo_2_PSS_RQ = 1985871883;

	public const int LTEPilotInfo_2_SSS_RSSI = 1985871884;

	public const int LTEPilotInfo_2_SSS_RP = 1985871885;

	public const int LTEPilotInfo_2_SSS_RQ = 1985871886;

	public const int LTEPilotInfo_2_LTE_RS_RSSI = 1985871887;

	public const int LTEPilotInfo_2_LTE_RS_RP = 1985871888;

	public const int LTEPilotInfo_2_LTE_RS_RQ = 1985871889;

	public const int LTEPilotInfo_2_LTE_RS_SINR = 1985871890;

	public const int LTEPilotInfo_3_PointIndex = 1985937408;

	public const int LTEPilotInfo_3_ID = 1985937409;

	public const int LTEPilotInfo_3_EARFCN = 1985937410;

	public const int LTEPilotInfo_3_PCI = 1985937411;

	public const int LTEPilotInfo_3_Timingoffset = 1985937412;

	public const int LTEPilotInfo_3_Bandwith = 1985937413;

	public const int LTEPilotInfo_3_AntennaPortNumber = 1985937414;

	public const int LTEPilotInfo_3_CPType = 1985937415;

	public const int LTEPilotInfo_3_CellIdentity = 1985937416;

	public const int LTEPilotInfo_3_PSS_RSSI = 1985937417;

	public const int LTEPilotInfo_3_PSS_RP = 1985937418;

	public const int LTEPilotInfo_3_PSS_RQ = 1985937419;

	public const int LTEPilotInfo_3_SSS_RSSI = 1985937420;

	public const int LTEPilotInfo_3_SSS_RP = 1985937421;

	public const int LTEPilotInfo_3_SSS_RQ = 1985937422;

	public const int LTEPilotInfo_3_LTE_RS_RSSI = 1985937423;

	public const int LTEPilotInfo_3_LTE_RS_RP = 1985937424;

	public const int LTEPilotInfo_3_LTE_RS_RQ = 1985937425;

	public const int LTEPilotInfo_3_LTE_RS_SINR = 1985937426;

	public const int LTEPilotInfo_4_PointIndex = 1986002944;

	public const int LTEPilotInfo_4_ID = 1986002945;

	public const int LTEPilotInfo_4_EARFCN = 1986002946;

	public const int LTEPilotInfo_4_PCI = 1986002947;

	public const int LTEPilotInfo_4_Timingoffset = 1986002948;

	public const int LTEPilotInfo_4_Bandwith = 1986002949;

	public const int LTEPilotInfo_4_AntennaPortNumber = 1986002950;

	public const int LTEPilotInfo_4_CPType = 1986002951;

	public const int LTEPilotInfo_4_CellIdentity = 1986002952;

	public const int LTEPilotInfo_4_PSS_RSSI = 1986002953;

	public const int LTEPilotInfo_4_PSS_RP = 1986002954;

	public const int LTEPilotInfo_4_PSS_RQ = 1986002955;

	public const int LTEPilotInfo_4_SSS_RSSI = 1986002956;

	public const int LTEPilotInfo_4_SSS_RP = 1986002957;

	public const int LTEPilotInfo_4_SSS_RQ = 1986002958;

	public const int LTEPilotInfo_4_LTE_RS_RSSI = 1986002959;

	public const int LTEPilotInfo_4_LTE_RS_RP = 1986002960;

	public const int LTEPilotInfo_4_LTE_RS_RQ = 1986002961;

	public const int LTEPilotInfo_4_LTE_RS_SINR = 1986002962;

	public const int LTEPilotInfo_5_PointIndex = 1986068480;

	public const int LTEPilotInfo_5_ID = 1986068481;

	public const int LTEPilotInfo_5_EARFCN = 1986068482;

	public const int LTEPilotInfo_5_PCI = 1986068483;

	public const int LTEPilotInfo_5_Timingoffset = 1986068484;

	public const int LTEPilotInfo_5_Bandwith = 1986068485;

	public const int LTEPilotInfo_5_AntennaPortNumber = 1986068486;

	public const int LTEPilotInfo_5_CPType = 1986068487;

	public const int LTEPilotInfo_5_CellIdentity = 1986068488;

	public const int LTEPilotInfo_5_PSS_RSSI = 1986068489;

	public const int LTEPilotInfo_5_PSS_RP = 1986068490;

	public const int LTEPilotInfo_5_PSS_RQ = 1986068491;

	public const int LTEPilotInfo_5_SSS_RSSI = 1986068492;

	public const int LTEPilotInfo_5_SSS_RP = 1986068493;

	public const int LTEPilotInfo_5_SSS_RQ = 1986068494;

	public const int LTEPilotInfo_5_LTE_RS_RSSI = 1986068495;

	public const int LTEPilotInfo_5_LTE_RS_RP = 1986068496;

	public const int LTEPilotInfo_5_LTE_RS_RQ = 1986068497;

	public const int LTEPilotInfo_5_LTE_RS_SINR = 1986068498;

	public const int LTEPilotInfo_6_PointIndex = 1986134016;

	public const int LTEPilotInfo_6_ID = 1986134017;

	public const int LTEPilotInfo_6_EARFCN = 1986134018;

	public const int LTEPilotInfo_6_PCI = 1986134019;

	public const int LTEPilotInfo_6_Timingoffset = 1986134020;

	public const int LTEPilotInfo_6_Bandwith = 1986134021;

	public const int LTEPilotInfo_6_AntennaPortNumber = 1986134022;

	public const int LTEPilotInfo_6_CPType = 1986134023;

	public const int LTEPilotInfo_6_CellIdentity = 1986134024;

	public const int LTEPilotInfo_6_PSS_RSSI = 1986134025;

	public const int LTEPilotInfo_6_PSS_RP = 1986134026;

	public const int LTEPilotInfo_6_PSS_RQ = 1986134027;

	public const int LTEPilotInfo_6_SSS_RSSI = 1986134028;

	public const int LTEPilotInfo_6_SSS_RP = 1986134029;

	public const int LTEPilotInfo_6_SSS_RQ = 1986134030;

	public const int LTEPilotInfo_6_LTE_RS_RSSI = 1986134031;

	public const int LTEPilotInfo_6_LTE_RS_RP = 1986134032;

	public const int LTEPilotInfo_6_LTE_RS_RQ = 1986134033;

	public const int LTEPilotInfo_6_LTE_RS_SINR = 1986134034;

	public const int LTEPilotInfo_7_PointIndex = 1986199552;

	public const int LTEPilotInfo_7_ID = 1986199553;

	public const int LTEPilotInfo_7_EARFCN = 1986199554;

	public const int LTEPilotInfo_7_PCI = 1986199555;

	public const int LTEPilotInfo_7_Timingoffset = 1986199556;

	public const int LTEPilotInfo_7_Bandwith = 1986199557;

	public const int LTEPilotInfo_7_AntennaPortNumber = 1986199558;

	public const int LTEPilotInfo_7_CPType = 1986199559;

	public const int LTEPilotInfo_7_CellIdentity = 1986199560;

	public const int LTEPilotInfo_7_PSS_RSSI = 1986199561;

	public const int LTEPilotInfo_7_PSS_RP = 1986199562;

	public const int LTEPilotInfo_7_PSS_RQ = 1986199563;

	public const int LTEPilotInfo_7_SSS_RSSI = 1986199564;

	public const int LTEPilotInfo_7_SSS_RP = 1986199565;

	public const int LTEPilotInfo_7_SSS_RQ = 1986199566;

	public const int LTEPilotInfo_7_LTE_RS_RSSI = 1986199567;

	public const int LTEPilotInfo_7_LTE_RS_RP = 1986199568;

	public const int LTEPilotInfo_7_LTE_RS_RQ = 1986199569;

	public const int LTEPilotInfo_7_LTE_RS_SINR = 1986199570;

	public const int LTEPilotInfo_8_PointIndex = 1986265088;

	public const int LTEPilotInfo_8_ID = 1986265089;

	public const int LTEPilotInfo_8_EARFCN = 1986265090;

	public const int LTEPilotInfo_8_PCI = 1986265091;

	public const int LTEPilotInfo_8_Timingoffset = 1986265092;

	public const int LTEPilotInfo_8_Bandwith = 1986265093;

	public const int LTEPilotInfo_8_AntennaPortNumber = 1986265094;

	public const int LTEPilotInfo_8_CPType = 1986265095;

	public const int LTEPilotInfo_8_CellIdentity = 1986265096;

	public const int LTEPilotInfo_8_PSS_RSSI = 1986265097;

	public const int LTEPilotInfo_8_PSS_RP = 1986265098;

	public const int LTEPilotInfo_8_PSS_RQ = 1986265099;

	public const int LTEPilotInfo_8_SSS_RSSI = 1986265100;

	public const int LTEPilotInfo_8_SSS_RP = 1986265101;

	public const int LTEPilotInfo_8_SSS_RQ = 1986265102;

	public const int LTEPilotInfo_8_LTE_RS_RSSI = 1986265103;

	public const int LTEPilotInfo_8_LTE_RS_RP = 1986265104;

	public const int LTEPilotInfo_8_LTE_RS_RQ = 1986265105;

	public const int LTEPilotInfo_8_LTE_RS_SINR = 1986265106;

	public const int LTEPilotInfo_9_PointIndex = 1986330624;

	public const int LTEPilotInfo_9_ID = 1986330625;

	public const int LTEPilotInfo_9_EARFCN = 1986330626;

	public const int LTEPilotInfo_9_PCI = 1986330627;

	public const int LTEPilotInfo_9_Timingoffset = 1986330628;

	public const int LTEPilotInfo_9_Bandwith = 1986330629;

	public const int LTEPilotInfo_9_AntennaPortNumber = 1986330630;

	public const int LTEPilotInfo_9_CPType = 1986330631;

	public const int LTEPilotInfo_9_CellIdentity = 1986330632;

	public const int LTEPilotInfo_9_PSS_RSSI = 1986330633;

	public const int LTEPilotInfo_9_PSS_RP = 1986330634;

	public const int LTEPilotInfo_9_PSS_RQ = 1986330635;

	public const int LTEPilotInfo_9_SSS_RSSI = 1986330636;

	public const int LTEPilotInfo_9_SSS_RP = 1986330637;

	public const int LTEPilotInfo_9_SSS_RQ = 1986330638;

	public const int LTEPilotInfo_9_LTE_RS_RSSI = 1986330639;

	public const int LTEPilotInfo_9_LTE_RS_RP = 1986330640;

	public const int LTEPilotInfo_9_LTE_RS_RQ = 1986330641;

	public const int LTEPilotInfo_9_LTE_RS_SINR = 1986330642;

	public const int LTEPilotInfo_10_PointIndex = 1986396160;

	public const int LTEPilotInfo_10_ID = 1986396161;

	public const int LTEPilotInfo_10_EARFCN = 1986396162;

	public const int LTEPilotInfo_10_PCI = 1986396163;

	public const int LTEPilotInfo_10_Timingoffset = 1986396164;

	public const int LTEPilotInfo_10_Bandwith = 1986396165;

	public const int LTEPilotInfo_10_AntennaPortNumber = 1986396166;

	public const int LTEPilotInfo_10_CPType = 1986396167;

	public const int LTEPilotInfo_10_CellIdentity = 1986396168;

	public const int LTEPilotInfo_10_PSS_RSSI = 1986396169;

	public const int LTEPilotInfo_10_PSS_RP = 1986396170;

	public const int LTEPilotInfo_10_PSS_RQ = 1986396171;

	public const int LTEPilotInfo_10_SSS_RSSI = 1986396172;

	public const int LTEPilotInfo_10_SSS_RP = 1986396173;

	public const int LTEPilotInfo_10_SSS_RQ = 1986396174;

	public const int LTEPilotInfo_10_LTE_RS_RSSI = 1986396175;

	public const int LTEPilotInfo_10_LTE_RS_RP = 1986396176;

	public const int LTEPilotInfo_10_LTE_RS_RQ = 1986396177;

	public const int LTEPilotInfo_10_LTE_RS_SINR = 1986396178;

	public const int LTEPilotInfo_11_PointIndex = 1986461696;

	public const int LTEPilotInfo_11_ID = 1986461697;

	public const int LTEPilotInfo_11_EARFCN = 1986461698;

	public const int LTEPilotInfo_11_PCI = 1986461699;

	public const int LTEPilotInfo_11_Timingoffset = 1986461700;

	public const int LTEPilotInfo_11_Bandwith = 1986461701;

	public const int LTEPilotInfo_11_AntennaPortNumber = 1986461702;

	public const int LTEPilotInfo_11_CPType = 1986461703;

	public const int LTEPilotInfo_11_CellIdentity = 1986461704;

	public const int LTEPilotInfo_11_PSS_RSSI = 1986461705;

	public const int LTEPilotInfo_11_PSS_RP = 1986461706;

	public const int LTEPilotInfo_11_PSS_RQ = 1986461707;

	public const int LTEPilotInfo_11_SSS_RSSI = 1986461708;

	public const int LTEPilotInfo_11_SSS_RP = 1986461709;

	public const int LTEPilotInfo_11_SSS_RQ = 1986461710;

	public const int LTEPilotInfo_11_LTE_RS_RSSI = 1986461711;

	public const int LTEPilotInfo_11_LTE_RS_RP = 1986461712;

	public const int LTEPilotInfo_11_LTE_RS_RQ = 1986461713;

	public const int LTEPilotInfo_11_LTE_RS_SINR = 1986461714;

	public const int LTEPilotInfo_12_PointIndex = 1986527232;

	public const int LTEPilotInfo_12_ID = 1986527233;

	public const int LTEPilotInfo_12_EARFCN = 1986527234;

	public const int LTEPilotInfo_12_PCI = 1986527235;

	public const int LTEPilotInfo_12_Timingoffset = 1986527236;

	public const int LTEPilotInfo_12_Bandwith = 1986527237;

	public const int LTEPilotInfo_12_AntennaPortNumber = 1986527238;

	public const int LTEPilotInfo_12_CPType = 1986527239;

	public const int LTEPilotInfo_12_CellIdentity = 1986527240;

	public const int LTEPilotInfo_12_PSS_RSSI = 1986527241;

	public const int LTEPilotInfo_12_PSS_RP = 1986527242;

	public const int LTEPilotInfo_12_PSS_RQ = 1986527243;

	public const int LTEPilotInfo_12_SSS_RSSI = 1986527244;

	public const int LTEPilotInfo_12_SSS_RP = 1986527245;

	public const int LTEPilotInfo_12_SSS_RQ = 1986527246;

	public const int LTEPilotInfo_12_LTE_RS_RSSI = 1986527247;

	public const int LTEPilotInfo_12_LTE_RS_RP = 1986527248;

	public const int LTEPilotInfo_12_LTE_RS_RQ = 1986527249;

	public const int LTEPilotInfo_12_LTE_RS_SINR = 1986527250;

	public const int LTEPilotInfo_13_PointIndex = 1986592768;

	public const int LTEPilotInfo_13_ID = 1986592769;

	public const int LTEPilotInfo_13_EARFCN = 1986592770;

	public const int LTEPilotInfo_13_PCI = 1986592771;

	public const int LTEPilotInfo_13_Timingoffset = 1986592772;

	public const int LTEPilotInfo_13_Bandwith = 1986592773;

	public const int LTEPilotInfo_13_AntennaPortNumber = 1986592774;

	public const int LTEPilotInfo_13_CPType = 1986592775;

	public const int LTEPilotInfo_13_CellIdentity = 1986592776;

	public const int LTEPilotInfo_13_PSS_RSSI = 1986592777;

	public const int LTEPilotInfo_13_PSS_RP = 1986592778;

	public const int LTEPilotInfo_13_PSS_RQ = 1986592779;

	public const int LTEPilotInfo_13_SSS_RSSI = 1986592780;

	public const int LTEPilotInfo_13_SSS_RP = 1986592781;

	public const int LTEPilotInfo_13_SSS_RQ = 1986592782;

	public const int LTEPilotInfo_13_LTE_RS_RSSI = 1986592783;

	public const int LTEPilotInfo_13_LTE_RS_RP = 1986592784;

	public const int LTEPilotInfo_13_LTE_RS_RQ = 1986592785;

	public const int LTEPilotInfo_13_LTE_RS_SINR = 1986592786;

	public const int LTEPilotInfo_14_PointIndex = 1986658304;

	public const int LTEPilotInfo_14_ID = 1986658305;

	public const int LTEPilotInfo_14_EARFCN = 1986658306;

	public const int LTEPilotInfo_14_PCI = 1986658307;

	public const int LTEPilotInfo_14_Timingoffset = 1986658308;

	public const int LTEPilotInfo_14_Bandwith = 1986658309;

	public const int LTEPilotInfo_14_AntennaPortNumber = 1986658310;

	public const int LTEPilotInfo_14_CPType = 1986658311;

	public const int LTEPilotInfo_14_CellIdentity = 1986658312;

	public const int LTEPilotInfo_14_PSS_RSSI = 1986658313;

	public const int LTEPilotInfo_14_PSS_RP = 1986658314;

	public const int LTEPilotInfo_14_PSS_RQ = 1986658315;

	public const int LTEPilotInfo_14_SSS_RSSI = 1986658316;

	public const int LTEPilotInfo_14_SSS_RP = 1986658317;

	public const int LTEPilotInfo_14_SSS_RQ = 1986658318;

	public const int LTEPilotInfo_14_LTE_RS_RSSI = 1986658319;

	public const int LTEPilotInfo_14_LTE_RS_RP = 1986658320;

	public const int LTEPilotInfo_14_LTE_RS_RQ = 1986658321;

	public const int LTEPilotInfo_14_LTE_RS_SINR = 1986658322;

	public const int LTEPilotInfo_15_PointIndex = 1986723840;

	public const int LTEPilotInfo_15_ID = 1986723841;

	public const int LTEPilotInfo_15_EARFCN = 1986723842;

	public const int LTEPilotInfo_15_PCI = 1986723843;

	public const int LTEPilotInfo_15_Timingoffset = 1986723844;

	public const int LTEPilotInfo_15_Bandwith = 1986723845;

	public const int LTEPilotInfo_15_AntennaPortNumber = 1986723846;

	public const int LTEPilotInfo_15_CPType = 1986723847;

	public const int LTEPilotInfo_15_CellIdentity = 1986723848;

	public const int LTEPilotInfo_15_PSS_RSSI = 1986723849;

	public const int LTEPilotInfo_15_PSS_RP = 1986723850;

	public const int LTEPilotInfo_15_PSS_RQ = 1986723851;

	public const int LTEPilotInfo_15_SSS_RSSI = 1986723852;

	public const int LTEPilotInfo_15_SSS_RP = 1986723853;

	public const int LTEPilotInfo_15_SSS_RQ = 1986723854;

	public const int LTEPilotInfo_15_LTE_RS_RSSI = 1986723855;

	public const int LTEPilotInfo_15_LTE_RS_RP = 1986723856;

	public const int LTEPilotInfo_15_LTE_RS_RQ = 1986723857;

	public const int LTEPilotInfo_15_LTE_RS_SINR = 1986723858;

	public const int LTEPilotInfo_16_PointIndex = 1986789376;

	public const int LTEPilotInfo_16_ID = 1986789377;

	public const int LTEPilotInfo_16_EARFCN = 1986789378;

	public const int LTEPilotInfo_16_PCI = 1986789379;

	public const int LTEPilotInfo_16_Timingoffset = 1986789380;

	public const int LTEPilotInfo_16_Bandwith = 1986789381;

	public const int LTEPilotInfo_16_AntennaPortNumber = 1986789382;

	public const int LTEPilotInfo_16_CPType = 1986789383;

	public const int LTEPilotInfo_16_CellIdentity = 1986789384;

	public const int LTEPilotInfo_16_PSS_RSSI = 1986789385;

	public const int LTEPilotInfo_16_PSS_RP = 1986789386;

	public const int LTEPilotInfo_16_PSS_RQ = 1986789387;

	public const int LTEPilotInfo_16_SSS_RSSI = 1986789388;

	public const int LTEPilotInfo_16_SSS_RP = 1986789389;

	public const int LTEPilotInfo_16_SSS_RQ = 1986789390;

	public const int LTEPilotInfo_16_LTE_RS_RSSI = 1986789391;

	public const int LTEPilotInfo_16_LTE_RS_RP = 1986789392;

	public const int LTEPilotInfo_16_LTE_RS_RQ = 1986789393;

	public const int LTEPilotInfo_16_LTE_RS_SINR = 1986789394;

	public const int LTEPilotInfo_AllInOne_PointIndex = 1986854912;

	public const int LTEPilotInfo_AllInOne_ID = 1986854913;

	public const int LTEPilotInfo_AllInOne_EARFCN = 1986854914;

	public const int LTEPilotInfo_AllInOne_PCI = 1986854915;

	public const int LTEPilotInfo_AllInOne_Timingoffset = 1986854916;

	public const int LTEPilotInfo_AllInOne_Bandwith = 1986854917;

	public const int LTEPilotInfo_AllInOne_AntennaPortNumber = 1986854918;

	public const int LTEPilotInfo_AllInOne_CPType = 1986854919;

	public const int LTEPilotInfo_AllInOne_CellIdentity = 1986854920;

	public const int LTEPilotInfo_AllInOne_PSS_RSSI = 1986854921;

	public const int LTEPilotInfo_AllInOne_PSS_RP = 1986854922;

	public const int LTEPilotInfo_AllInOne_PSS_RQ = 1986854923;

	public const int LTEPilotInfo_AllInOne_SSS_RSSI = 1986854924;

	public const int LTEPilotInfo_AllInOne_SSS_RP = 1986854925;

	public const int LTEPilotInfo_AllInOne_SSS_RQ = 1986854926;

	public const int LTEPilotInfo_AllInOne_LTE_RS_RSSI = 1986854927;

	public const int LTEPilotInfo_AllInOne_LTE_RS_RP = 1986854928;

	public const int LTEPilotInfo_AllInOne_LTE_RS_RQ = 1986854929;

	public const int LTEPilotInfo_AllInOne_LTE_RS_SINR = 1986854930;

	public const int LTEPilotInfo_AllInOne_NID1 = 1986854931;

	public const int LTEPilotInfo_AllInOne_NID2 = 1986854932;

	public const int LTEPilotInfo_AllInOne_DelaySpread = 1986854933;

	public const int LTEPilotInfo_AllInOne_LTE_PBCH_RSSI = 1986854934;

	public const int LTEPilotInfo_AllInOne_LTE_PBCH_RP = 1986854935;

	public const int LTEPilotInfo_AllInOne_LTE_PBCH_RQ = 1986854936;

	public const int LTEPilotInfo_AllInOne_LTE_PBCH_SINR = 1986854937;

	public const int LTEPilotInfo_AllInOne_LTE_RS_RP_Ant0 = 1986854938;

	public const int LTEPilotInfo_AllInOne_LTE_RS_RQ_Ant0 = 1986854939;

	public const int LTEPilotInfo_AllInOne_LTE_RS_SINR_Ant0 = 1986854940;

	public const int LTEPilotInfo_AllInOne_LTE_RS_RP_Ant1 = 1986854941;

	public const int LTEPilotInfo_AllInOne_LTE_RS_RQ_Ant1 = 1986854942;

	public const int LTEPilotInfo_AllInOne_LTE_RS_SINR_Ant1 = 1986854943;

	public const int LTEPilotInfo_AllInOne_TAC = 1986854944;

	public const int LTEPilotInfo_AllInOne_SA = 1986854945;

	public const int LTEPilotInfo_AllInOne_SSP = 1986854946;

	public const int LTEPilotInfo_AllInOne_eNodebID = 1986854947;

	public const int LTEPilotInfo_AllInOne_SectorID = 1986854948;

	public const int LTEPilotInfo_AllInOne_CellIndex = 1986854949;

	public const int LTEPilotInfo_AllInOne_MCC1 = 1986854952;

	public const int LTEPilotInfo_AllInOne_MNC1 = 1986854953;

	public const int LTEPilotInfo_AllInOne_MCC2 = 1986854950;

	public const int LTEPilotInfo_AllInOne_MNC2 = 1986854951;

	public const int WCDMAPilotInfo_AllInOne_PointIndex = 1992097792;

	public const int WCDMAPilotInfo_AllInOne_ID = 1992097793;

	public const int WCDMAPilotInfo_AllInOne_ARFCN = 1992097794;

	public const int WCDMAPilotInfo_AllInOne_PSC = 1992097795;

	public const int WCDMAPilotInfo_AllInOne_WCDMA_Io = 1992097796;

	public const int WCDMAPilotInfo_AllInOne_WCDMA_EC = 1992097797;

	public const int WCDMAPilotInfo_AllInOne_WCDMA_EcIo = 1992097798;

	public const int WCDMAPilotInfo_AllInOne_CellIndex = 1992097799;

	public const int WCDMAPilotInfo_MaxMinEcIO_PointIndex = 1990983680;

	public const int WCDMAPilotInfo_MaxMinEcIO_ID = 1990983681;

	public const int WCDMAPilotInfo_MaxMinEcIO_ARFCN = 1990983682;

	public const int WCDMAPilotInfo_MaxMinEcIO_PSC = 1990983683;

	public const int WCDMAPilotInfo_MaxMinEcIO_WCDMA_Io = 1990983684;

	public const int WCDMAPilotInfo_MaxMinEcIO_WCDMA_EC = 1990983685;

	public const int WCDMAPilotInfo_MaxMinEcIO_WCDMA_EcIo = 1990983686;

	public const int WCDMAPilotInfo_MaxMinEcIO_WCDMA_EcIo_Min = 1990983687;

	public const int WCDMAPilotInfo_MaxMinEcIO_Overlap_Level = 1990983688;

	public const int WCDMAPilotInfo_1_PointIndex = 1991049216;

	public const int WCDMAPilotInfo_1_ID = 1991049217;

	public const int WCDMAPilotInfo_1_ARFCN = 1991049218;

	public const int WCDMAPilotInfo_1_PSC = 1991049219;

	public const int WCDMAPilotInfo_1_WCDMA_Io = 1991049220;

	public const int WCDMAPilotInfo_1_WCDMA_EC = 1991049221;

	public const int WCDMAPilotInfo_1_WCDMA_EcIo = 1991049222;

	public const int WCDMAPilotInfo_2_PointIndex = 1991114752;

	public const int WCDMAPilotInfo_2_ID = 1991114753;

	public const int WCDMAPilotInfo_2_ARFCN = 1991114754;

	public const int WCDMAPilotInfo_2_PSC = 1991114755;

	public const int WCDMAPilotInfo_2_WCDMA_Io = 1991114756;

	public const int WCDMAPilotInfo_2_WCDMA_EC = 1991114757;

	public const int WCDMAPilotInfo_2_WCDMA_EcIo = 1991114758;

	public const int WCDMAPilotInfo_3_PointIndex = 1991180288;

	public const int WCDMAPilotInfo_3_ID = 1991180289;

	public const int WCDMAPilotInfo_3_ARFCN = 1991180290;

	public const int WCDMAPilotInfo_3_PSC = 1991180291;

	public const int WCDMAPilotInfo_3_WCDMA_Io = 1991180292;

	public const int WCDMAPilotInfo_3_WCDMA_EC = 1991180293;

	public const int WCDMAPilotInfo_3_WCDMA_EcIo = 1991180294;

	public const int WCDMAPilotInfo_4_PointIndex = 1991245824;

	public const int WCDMAPilotInfo_4_ID = 1991245825;

	public const int WCDMAPilotInfo_4_ARFCN = 1991245826;

	public const int WCDMAPilotInfo_4_PSC = 1991245827;

	public const int WCDMAPilotInfo_4_WCDMA_Io = 1991245828;

	public const int WCDMAPilotInfo_4_WCDMA_EC = 1991245829;

	public const int WCDMAPilotInfo_4_WCDMA_EcIo = 1991245830;

	public const int WCDMAPilotInfo_5_PointIndex = 1991311360;

	public const int WCDMAPilotInfo_5_ID = 1991311361;

	public const int WCDMAPilotInfo_5_ARFCN = 1991311362;

	public const int WCDMAPilotInfo_5_PSC = 1991311363;

	public const int WCDMAPilotInfo_5_WCDMA_Io = 1991311364;

	public const int WCDMAPilotInfo_5_WCDMA_EC = 1991311365;

	public const int WCDMAPilotInfo_5_WCDMA_EcIo = 1991311366;

	public const int WCDMAPilotInfo_6_PointIndex = 1991376896;

	public const int WCDMAPilotInfo_6_ID = 1991376897;

	public const int WCDMAPilotInfo_6_ARFCN = 1991376898;

	public const int WCDMAPilotInfo_6_PSC = 1991376899;

	public const int WCDMAPilotInfo_6_WCDMA_Io = 1991376900;

	public const int WCDMAPilotInfo_6_WCDMA_EC = 1991376901;

	public const int WCDMAPilotInfo_6_WCDMA_EcIo = 1991376902;

	public const int WCDMAPilotInfo_7_PointIndex = 1991442432;

	public const int WCDMAPilotInfo_7_ID = 1991442433;

	public const int WCDMAPilotInfo_7_ARFCN = 1991442434;

	public const int WCDMAPilotInfo_7_PSC = 1991442435;

	public const int WCDMAPilotInfo_7_WCDMA_Io = 1991442436;

	public const int WCDMAPilotInfo_7_WCDMA_EC = 1991442437;

	public const int WCDMAPilotInfo_7_WCDMA_EcIo = 1991442438;

	public const int WCDMAPilotInfo_8_PointIndex = 1991507968;

	public const int WCDMAPilotInfo_8_ID = 1991507969;

	public const int WCDMAPilotInfo_8_ARFCN = 1991507970;

	public const int WCDMAPilotInfo_8_PSC = 1991507971;

	public const int WCDMAPilotInfo_8_WCDMA_Io = 1991507972;

	public const int WCDMAPilotInfo_8_WCDMA_EC = 1991507973;

	public const int WCDMAPilotInfo_8_WCDMA_EcIo = 1991507974;

	public const int WCDMAPilotInfo_9_PointIndex = 1991573504;

	public const int WCDMAPilotInfo_9_ID = 1991573505;

	public const int WCDMAPilotInfo_9_ARFCN = 1991573506;

	public const int WCDMAPilotInfo_9_PSC = 1991573507;

	public const int WCDMAPilotInfo_9_WCDMA_Io = 1991573508;

	public const int WCDMAPilotInfo_9_WCDMA_EC = 1991573509;

	public const int WCDMAPilotInfo_9_WCDMA_EcIo = 1991573510;

	public const int WCDMAPilotInfo_10_PointIndex = 1991639040;

	public const int WCDMAPilotInfo_10_ID = 1991639041;

	public const int WCDMAPilotInfo_10_ARFCN = 1991639042;

	public const int WCDMAPilotInfo_10_PSC = 1991639043;

	public const int WCDMAPilotInfo_10_WCDMA_Io = 1991639044;

	public const int WCDMAPilotInfo_10_WCDMA_EC = 1991639045;

	public const int WCDMAPilotInfo_10_WCDMA_EcIo = 1991639046;

	public const int WCDMAPilotInfo_11_PointIndex = 1991704576;

	public const int WCDMAPilotInfo_11_ID = 1991704577;

	public const int WCDMAPilotInfo_11_ARFCN = 1991704578;

	public const int WCDMAPilotInfo_11_PSC = 1991704579;

	public const int WCDMAPilotInfo_11_WCDMA_Io = 1991704580;

	public const int WCDMAPilotInfo_11_WCDMA_EC = 1991704581;

	public const int WCDMAPilotInfo_11_WCDMA_EcIo = 1991704582;

	public const int WCDMAPilotInfo_12_PointIndex = 1991770112;

	public const int WCDMAPilotInfo_12_ID = 1991770113;

	public const int WCDMAPilotInfo_12_ARFCN = 1991770114;

	public const int WCDMAPilotInfo_12_PSC = 1991770115;

	public const int WCDMAPilotInfo_12_WCDMA_Io = 1991770116;

	public const int WCDMAPilotInfo_12_WCDMA_EC = 1991770117;

	public const int WCDMAPilotInfo_12_WCDMA_EcIo = 1991770118;

	public const int WCDMAPilotInfo_13_PointIndex = 1991835648;

	public const int WCDMAPilotInfo_13_ID = 1991835649;

	public const int WCDMAPilotInfo_13_ARFCN = 1991835650;

	public const int WCDMAPilotInfo_13_PSC = 1991835651;

	public const int WCDMAPilotInfo_13_WCDMA_Io = 1991835652;

	public const int WCDMAPilotInfo_13_WCDMA_EC = 1991835653;

	public const int WCDMAPilotInfo_13_WCDMA_EcIo = 1991835654;

	public const int WCDMAPilotInfo_14_PointIndex = 1991901184;

	public const int WCDMAPilotInfo_14_ID = 1991901185;

	public const int WCDMAPilotInfo_14_ARFCN = 1991901186;

	public const int WCDMAPilotInfo_14_PSC = 1991901187;

	public const int WCDMAPilotInfo_14_WCDMA_Io = 1991901188;

	public const int WCDMAPilotInfo_14_WCDMA_EC = 1991901189;

	public const int WCDMAPilotInfo_14_WCDMA_EcIo = 1991901190;

	public const int WCDMAPilotInfo_15_PointIndex = 1991966720;

	public const int WCDMAPilotInfo_15_ID = 1991966721;

	public const int WCDMAPilotInfo_15_ARFCN = 1991966722;

	public const int WCDMAPilotInfo_15_PSC = 1991966723;

	public const int WCDMAPilotInfo_15_WCDMA_Io = 1991966724;

	public const int WCDMAPilotInfo_15_WCDMA_EC = 1991966725;

	public const int WCDMAPilotInfo_15_WCDMA_EcIo = 1991966726;

	public const int WCDMAPilotInfo_16_PointIndex = 1992032256;

	public const int WCDMAPilotInfo_16_ID = 1992032257;

	public const int WCDMAPilotInfo_16_ARFCN = 1992032258;

	public const int WCDMAPilotInfo_16_PSC = 1992032259;

	public const int WCDMAPilotInfo_16_WCDMA_Io = 1992032260;

	public const int WCDMAPilotInfo_16_WCDMA_EC = 1992032261;

	public const int WCDMAPilotInfo_16_WCDMA_EcIo = 1992032262;

	public const int CDMAPilotInfo_AllInOne_PointIndex = 1992359936;

	public const int CDMAPilotInfo_AllInOne_ID = 1992359937;

	public const int CDMAPilotInfo_AllInOne_ARFCN = 1992359938;

	public const int CDMAPilotInfo_AllInOne_PN = 1992359939;

	public const int CDMAPilotInfo_AllInOne_CDMA_Io = 1992359940;

	public const int CDMAPilotInfo_AllInOne_CDMA_EC = 1992359941;

	public const int CDMAPilotInfo_AllInOne_CDMA_EcIo = 1992359942;

	public const int CDMAPilotInfo_AllInOne_CellIndex = 1992359943;

	public const int EVDOPilotInfo_AllInOne_PointIndex = 1992687616;

	public const int EVDOPilotInfo_AllInOne_ID = 1992687617;

	public const int EVDOPilotInfo_AllInOne_ARFCN = 1992687618;

	public const int EVDOPilotInfo_AllInOne_PN = 1992687619;

	public const int EVDOPilotInfo_AllInOne_EVDO_Io = 1992687620;

	public const int EVDOPilotInfo_AllInOne_EVDO_EC = 1992687621;

	public const int EVDOPilotInfo_AllInOne_EVDO_EcIo = 1992687622;

	public const int EVDOPilotInfo_AllInOne_EVDO_C2I = 1992687623;

	public const int EVDOPilotInfo_AllInOne_CellIndex = 1992687624;

	public const int GSMCellScanInfo_AllInOne_PointIndex = 1989476352;

	public const int GSMCellScanInfo_AllInOne_ID = 1989476353;

	public const int GSMCellScanInfo_AllInOne_BCCH = 1989476354;

	public const int GSMCellScanInfo_AllInOne_BSIC = 1989476355;

	public const int GSMCellScanInfo_AllInOne_GSM_RSSI = 1989476356;

	public const int GSMCellScanInfo_AllInOne_GSM_C2I = 1989476357;

	public const int GSMCellScanInfo_AllInOne_CellIndex = 1989476358;

	public const int GSMCellScanInfo_MaxMinRSSI_PointIndex = 1988362240;

	public const int GSMCellScanInfo_MaxMinRSSI_ID = 1988362241;

	public const int GSMCellScanInfo_MaxMinRSSI_BCCH = 1988362242;

	public const int GSMCellScanInfo_MaxMinRSSI_BSIC = 1988362243;

	public const int GSMCellScanInfo_MaxMinRSSI_GSM_RSSI = 1988362244;

	public const int GSMCellScanInfo_MaxMinRSSI_GSM_C2I = 1988362245;

	public const int GSMCellScanInfo_MaxMinRSSI_GSM_RSSI_Min = 1988362246;

	public const int GSMCellScanInfo_MaxMinRSSI_Overlap_Level = 1988362247;

	public const int GSMCellScanInfo_1_PointIndex = 1988427776;

	public const int GSMCellScanInfo_1_ID = 1988427777;

	public const int GSMCellScanInfo_1_BCCH = 1988427778;

	public const int GSMCellScanInfo_1_BSIC = 1988427779;

	public const int GSMCellScanInfo_1_GSM_RSSI = 1988427780;

	public const int GSMCellScanInfo_1_GSM_C2I = 1988427781;

	public const int GSMCellScanInfo_2_PointIndex = 1988493312;

	public const int GSMCellScanInfo_2_ID = 1988493313;

	public const int GSMCellScanInfo_2_BCCH = 1988493314;

	public const int GSMCellScanInfo_2_BSIC = 1988493315;

	public const int GSMCellScanInfo_2_GSM_RSSI = 1988493316;

	public const int GSMCellScanInfo_2_GSM_C2I = 1988493317;

	public const int GSMCellScanInfo_3_PointIndex = 1988558848;

	public const int GSMCellScanInfo_3_ID = 1988558849;

	public const int GSMCellScanInfo_3_BCCH = 1988558850;

	public const int GSMCellScanInfo_3_BSIC = 1988558851;

	public const int GSMCellScanInfo_3_GSM_RSSI = 1988558852;

	public const int GSMCellScanInfo_3_GSM_C2I = 1988558853;

	public const int GSMCellScanInfo_4_PointIndex = 1988624384;

	public const int GSMCellScanInfo_4_ID = 1988624385;

	public const int GSMCellScanInfo_4_BCCH = 1988624386;

	public const int GSMCellScanInfo_4_BSIC = 1988624387;

	public const int GSMCellScanInfo_4_GSM_RSSI = 1988624388;

	public const int GSMCellScanInfo_4_GSM_C2I = 1988624389;

	public const int GSMCellScanInfo_5_PointIndex = 1988689920;

	public const int GSMCellScanInfo_5_ID = 1988689921;

	public const int GSMCellScanInfo_5_BCCH = 1988689922;

	public const int GSMCellScanInfo_5_BSIC = 1988689923;

	public const int GSMCellScanInfo_5_GSM_RSSI = 1988689924;

	public const int GSMCellScanInfo_5_GSM_C2I = 1988689925;

	public const int GSMCellScanInfo_6_PointIndex = 1988755456;

	public const int GSMCellScanInfo_6_ID = 1988755457;

	public const int GSMCellScanInfo_6_BCCH = 1988755458;

	public const int GSMCellScanInfo_6_BSIC = 1988755459;

	public const int GSMCellScanInfo_6_GSM_RSSI = 1988755460;

	public const int GSMCellScanInfo_6_GSM_C2I = 1988755461;

	public const int GSMCellScanInfo_7_PointIndex = 1988820992;

	public const int GSMCellScanInfo_7_ID = 1988820993;

	public const int GSMCellScanInfo_7_BCCH = 1988820994;

	public const int GSMCellScanInfo_7_BSIC = 1988820995;

	public const int GSMCellScanInfo_7_GSM_RSSI = 1988820996;

	public const int GSMCellScanInfo_7_GSM_C2I = 1988820997;

	public const int GSMCellScanInfo_8_PointIndex = 1988886528;

	public const int GSMCellScanInfo_8_ID = 1988886529;

	public const int GSMCellScanInfo_8_BCCH = 1988886530;

	public const int GSMCellScanInfo_8_BSIC = 1988886531;

	public const int GSMCellScanInfo_8_GSM_RSSI = 1988886532;

	public const int GSMCellScanInfo_8_GSM_C2I = 1988886533;

	public const int GSMCellScanInfo_9_PointIndex = 1988952064;

	public const int GSMCellScanInfo_9_ID = 1988952065;

	public const int GSMCellScanInfo_9_BCCH = 1988952066;

	public const int GSMCellScanInfo_9_BSIC = 1988952067;

	public const int GSMCellScanInfo_9_GSM_RSSI = 1988952068;

	public const int GSMCellScanInfo_9_GSM_C2I = 1988952069;

	public const int GSMCellScanInfo_10_PointIndex = 1989017600;

	public const int GSMCellScanInfo_10_ID = 1989017601;

	public const int GSMCellScanInfo_10_BCCH = 1989017602;

	public const int GSMCellScanInfo_10_BSIC = 1989017603;

	public const int GSMCellScanInfo_10_GSM_RSSI = 1989017604;

	public const int GSMCellScanInfo_10_GSM_C2I = 1989017605;

	public const int GSMCellScanInfo_11_PointIndex = 1989083136;

	public const int GSMCellScanInfo_11_ID = 1989083137;

	public const int GSMCellScanInfo_11_BCCH = 1989083138;

	public const int GSMCellScanInfo_11_BSIC = 1989083139;

	public const int GSMCellScanInfo_11_GSM_RSSI = 1989083140;

	public const int GSMCellScanInfo_11_GSM_C2I = 1989083141;

	public const int GSMCellScanInfo_12_PointIndex = 1989148672;

	public const int GSMCellScanInfo_12_ID = 1989148673;

	public const int GSMCellScanInfo_12_BCCH = 1989148674;

	public const int GSMCellScanInfo_12_BSIC = 1989148675;

	public const int GSMCellScanInfo_12_GSM_RSSI = 1989148676;

	public const int GSMCellScanInfo_12_GSM_C2I = 1989148677;

	public const int GSMCellScanInfo_13_PointIndex = 1989214208;

	public const int GSMCellScanInfo_13_ID = 1989214209;

	public const int GSMCellScanInfo_13_BCCH = 1989214210;

	public const int GSMCellScanInfo_13_BSIC = 1989214211;

	public const int GSMCellScanInfo_13_GSM_RSSI = 1989214212;

	public const int GSMCellScanInfo_13_GSM_C2I = 1989214213;

	public const int GSMCellScanInfo_14_PointIndex = 1989279744;

	public const int GSMCellScanInfo_14_ID = 1989279745;

	public const int GSMCellScanInfo_14_BCCH = 1989279746;

	public const int GSMCellScanInfo_14_BSIC = 1989279747;

	public const int GSMCellScanInfo_14_GSM_RSSI = 1989279748;

	public const int GSMCellScanInfo_14_GSM_C2I = 1989279749;

	public const int GSMCellScanInfo_15_PointIndex = 1989345280;

	public const int GSMCellScanInfo_15_ID = 1989345281;

	public const int GSMCellScanInfo_15_BCCH = 1989345282;

	public const int GSMCellScanInfo_15_BSIC = 1989345283;

	public const int GSMCellScanInfo_15_GSM_RSSI = 1989345284;

	public const int GSMCellScanInfo_15_GSM_C2I = 1989345285;

	public const int GSMCellScanInfo_16_PointIndex = 1989410816;

	public const int GSMCellScanInfo_16_ID = 1989410817;

	public const int GSMCellScanInfo_16_BCCH = 1989410818;

	public const int GSMCellScanInfo_16_BSIC = 1989410819;

	public const int GSMCellScanInfo_16_GSM_RSSI = 1989410820;

	public const int GSMCellScanInfo_16_GSM_C2I = 1989410821;

	public const int PingTestSummary_PingPointIndex = 68157440;

	public const int PingTestSummary_PingSessionIndex = 68157443;

	public const int PingTestSummary_PingTime = 68157450;

	public const int LTEAttachSesstion_PointIndex = 183500800;

	public const int LTEAttachSesstion_SessionIndex = 183500802;

	public const int LTEAttachSesstion_AttachDelay = 183500806;

	public const int AttachTestSummary_PointIndex = 68681728;

	public const int AttachTestSummary_SessionIndex = 68681730;

	public const int AttachTestSummary_SessionResult = 68681731;

	public const int AttachTestSummary_SessionReason = 68681732;

	public const int AttachTestSummary_TaskIndex = 68681733;

	public const int AttachTestSummary_TaskInnerIndex = 68681734;

	public const int AttachTestSummary_AttachDelay = 68681735;

	public const int NBScanOverlapCoverage = 1979187220;

	public const int NBScanPCISort = 1879113728;

	public const int DifferenceParamKey = 1879113729;

	public const int CustomDelayParamKey = 1879113730;

	public const int ValidCellCountParamKey = 1879113731;

	public const int NoServingCellParamKey = 1879113732;

	public const int OverlayParamKey = 1879113733;

	public const int TooFarParamKey = 1879113734;

	public const int OverAngleParamKey = 1879113735;

	public const int CoverageRatioParamKey = 1879113736;

	public const int OverlapParamKey = 1879113737;

	public const int PilotPollutionParamKey = 1879113738;

	public const int PoorCoverageParamKey = 1879113739;

	public const int InterferenceParamKey = 1879113740;

	public const int Mod3ParamKey = 1879113741;

	public const int ScanRSRPDiffParamKey = 1879113742;

	public const int ScanPCISortParamKey = 1879113728;

	public const int ScanNeighborParamKey = 1879113743;

	public const int ScanPilotPollutionParamKey = 1879113744;

	public const int OverlayDistanceKey = 1879113746;

	public const int OverAngleAngleKey = 1879113747;

	public const int AntennaReverseParamKey = 1879113748;

	public const int ScanFrequencyClearRSSIMaxParamKey = 1879113749;

	public const int ScanFrequencyClearRSSIMidParamKey = 1879113750;

	public const int BuildOperatorParamKey = 1879113751;

	public const int LTEShareTypeParamKey = 1879113752;

	public const int NRShareTypeParamKey = 1879113753;

	public const int IndoorLeakageParamKey = 1879113754;

	public const int PoorToCompetitorBinGrid = 1979187221;

	public const int SelfNetRSRP = 1979187222;

	public const int SelfNetSINR = 1979187223;

	public const int SelfNetFTPDL = 1979187224;

	public const int SelfNetFTPUL = 1979187225;

	public const int SelfNetMACDL = 1979187226;

	public const int SelfNetMACUL = 1979187227;

	public const int CompetitorNetRSRP = 1979187228;

	public const int CompetitorNetSINR = 1979187229;

	public const int CompetitorNetFTPDL = 1979187230;

	public const int CompetitorNetFTPUL = 1979187231;

	public const int CompetitorNetMACDL = 1979187232;

	public const int CompetitorNetMACUL = 1979187233;

	public const int CustomStrParamKey_Base = 28674;

	public const int CustomStrParamKey_LogfileName = 1879179265;

	public const int CustomStrParamKey_LogfileDuration = 1879179266;

	public const int CustomStrParamKey_LogfileTotalDistance = 1879179267;

	public const int CustomStrParamKey_Operator = 1879179268;

	public const int CustomStrParamKey_ServingBeamList = 1879179269;

	public const int CustomStrParamKey_SiteNameNR = 1879179270;

	public const int CustomStrParamKey_CellNameNR = 1879179271;

	public const int CustomStrParamKey_SiteNameLTE = 1879179272;

	public const int CustomStrParamKey_CellNameLTE = 1879179273;

	public const int TagEventKey = 1610678281;

	public const int PingSummaryKey = 1610746885;

	public const int DelaySummaryULKey = 1610747658;

	public const int DelaySummaryDLKey = 1610747659;

	public const int FTPULFirstPacketKey = 1610746373;

	public const int FTPULEndKey = 1610746378;

	public const int FTPDLFirstPacketKey = 1610746117;

	public const int FTPDLEndKey = 1610746122;

	public const int TestStop = 1610678273;

	public const int EventTYpe_POLQA_Computed = 1610678789;

	public const int VideoMOSComputed = 536969259;

	public const int WeChatMOVideoSendRefStart = 536972857;

	public const int WeChatMOVideoSendRefEnd = 536972858;

	public const int WeChatMTVideoRecordRefStart = 536972859;

	public const int WeChatMTVideoRecordRefEnd = 536972860;

	public const int WeChatMOTestSummary_PointIndex = 71827456;

	public const int WeChatMOTestSummary_TestPlanID = 71827463;

	public const int WeChatMOTestSummary_CallSetupDelay = 71827467;

	public const int WeChatMTTestSummary_PointIndex = 71892992;

	public const int WeChatMTTestSummary_TestPlanID = 71892999;

	public const int WeChatMTTestSummary_CallSetupDelay = 71893003;

	public const int CloudDriveDownloadTestSummary_PointIndex = 1763180544;

	public const int CloudDriveDownloadTestSummary_TestPlanID = 1763180554;

	public const int CloudDriveDownloadTestSummary_CumulativeAverageRate = 1763180563;

	public const int CloudDriveUploadTestSummary_PointIndex = 1763246080;

	public const int CloudDriveUploadTestSummary_TestPlanID = 1763246090;

	public const int CloudDriveUploadTestSummary_CumulativeAverageRate = 1763246099;

	public const int WeChatTestSummary_PointIndex = 70778880;

	public const int WeChatTestSummary_TestPlanID = 70778891;

	public const int WeChatTestSummary_Delay = 70778893;

	public const int ShortVideoTaskEnd = 1610750215;

	public const int BWTTaskEnd = 1610747145;

	public const int SpeedTest_Task_End = 1610748167;

	public const int TestProgressInfo_PointIndex = 1572864;

	public const int TestProgressInfo_ID = 1572865;

	public const int TestProgressInfo_TestPlanID = 1572866;

	public const int TestProgressInfo_TaskType = 1572867;

	public const int TestProgressInfo_ExecuteTims = 1572868;

	public const int TestProgressInfo_TemplateTimes = 1572869;

	public const int TestProgressInfo_SuccessTimes = 1572870;

	public const int TestProgressInfo_FailureTimes = 1572871;

	public const int TestProgressInfo_DropTimes = 1572872;

	public const int TestProgressInfo_ProgressNodeType = 1572873;

	public const int TestProgressInfo_TemplateIndex = 1572874;

	public const int PingTestSummary_PointIndex = 68157440;

	public const int PingTestSummary_PingServerAddress = 68157444;

	public const int PingTestSummary_TestPlanID = 68157445;

	public const int PingTestSummary_SessionResult = 68157446;

	public const int PingTestSummary_SessionReason = 68157447;

	public const int PingTestSummary_PingDesIP = 68157448;

	public const int PingTestSummary_PingPacketSize = 68157449;

	public const int PingTestSummary_TaskInnerIndex = 68157453;

	public const int PingTestSummary_PingTTL = 68157451;

	public const int FTPDownloadTestSummary_PointIndex = 66846720;

	public const int FTPDownloadTestSummary_FTPDownFileSize = 66846732;

	public const int FTPDownloadTestSummary_TaskInnerIndex = 66846738;

	public const int FTPDownloadTestSummary_ConfigTestMode = 66846743;

	public const int FTPDownloadTestSummary_ConfigDownloadTime = 66846744;

	public const int FTPDownloadQos_PointIndex = 66912256;

	public const int FTPDownloadQos_InstantAverageRate = 66912263;

	public const int FTPDownloadQos_CumulativeTransmitSize = 66912264;

	public const int FTPDownloadQos_CumulativeTransmitTime = 66912265;

	public const int FTPDownloadQos_CumulativeAverageRate = 66912266;

	public const int FTPDownloadQos_TestPlanID = 66912267;

	public const int FTPUploadQos_PointIndex = 67239936;

	public const int FTPUploadQos_InstantAverageRate = 67239943;

	public const int FTPUploadQos_CumulativeTransmitTime = 67239945;

	public const int FTPUploadQos_CumulativeTransmitSize = 67239944;

	public const int FTPUploadQos_CumulativeAverageRate = 67239946;

	public const int FTPUploadTestSummary_PointIndex = 67174400;

	public const int FTPUploadTestSummary_FTPUpFileSize = 67174412;

	public const int FTPUploadTestSummary_TaskInnerIndex = 67174418;

	public const int FTPUploadTestSummary_ConfigTestMode = 67174423;

	public const int FTPUploadTestSummary_ConfigUploadTime = 67174424;

	public const int FTPUploadQos_TestPlanID = 67239947;

	public const int MOTestSummary_PointIndex = 65404928;

	public const int MOTestSummary_EndPointIndex = 65404929;

	public const int MOTestSummary_CallingPhoneNumber = 65404932;

	public const int MOTestSummary_CalledPhoneNumber = 65404933;

	public const int MOTestSummary_CallTimeDuration = 65404934;

	public const int MOTestSummary_TestPlanID = 65404935;

	public const int MOTestSummary_CallID = 65404937;

	public const int MOTestSummary_CallSetupDelay = 65404939;

	public const int MOTestSummary_CallEstablishDelay = 65404941;

	public const int MOTestSummary_MOSessionReason = 65404944;

	public const int MTTestSummary_PointIndex = 65470464;

	public const int MTTestSummary_EndPointIndex = 65470465;

	public const int MTTestSummary_TestPlanID = 65470471;

	public const int MTTestSummary_CallSetupDelay = 65470475;

	public const int MTTestSummary_CallEstablishDelay = 65470477;

	public const int MTTestSummary_GUID = 65470489;

	public const int HTTPGetTestSummary_PointIndex = 67829760;

	public const int cHTTPGetTestSummary_EndPointIndex = 67829761;

	public const int cHTTPGetTestSummary_HTTPMainResourceDelay = 67829770;

	public const int cHTTPGetTestSummary_TestPlanID = 67829767;

	public const int HTTPDownTestSummary_PointIndex = 67960832;

	public const int HTTPDownTestSummary_TestPlanID = 67960842;

	public const int HTTPDownTestSummary_HTTPDownloadFileSize = 67960846;

	public const int HTTPDownTestSummary_ConfigTestMode = 67960852;

	public const int HTTPDownTestSummary_ConfigDownloadTime = 67960853;

	public const int HTTPDownQos_PointIndex = 68026368;

	public const int HTTPDownQos_InstantAverageRate = 68026375;

	public const int HTTPDownQos_CumulativeTransmitSize = 68026376;

	public const int HTTPDownQos_CumulativeTransmitTime = 68026377;

	public const int HTTPUploadTestSummary_PointIndex = 70516736;

	public const int HTTPUploadTestSummary_TestPlanID = 70516744;

	public const int HTTPUploadTestSummary_HTTPUploadloadFileSize = 70516748;

	public const int HTTPUploadTestSummary_ConfigTestMode = 70516758;

	public const int HTTPUploadTestSummary_ConfigUploadTime = 70516759;

	public const int HTTPUploadQos_PointIndex = 70582272;

	public const int HTTPUploadQos_InstantAverageRate = 70582279;

	public const int HTTPUploadQos_CumulativeTransmitSize = 70582280;

	public const int HTTPUploadQos_CumulativeTransmitTime = 70582281;

	public const int VideoQos_PointIndex = 69402624;

	public const int VideoQos_InstantAverageRate = 69402634;

	public const int VideoTestSummary_PointIndex = 69337088;

	public const int VideoTestSummary_TestPlanID = 69337097;

	public const int VideoTestSummary_ConfigTestMode = 69337121;

	public const int VideoTestSummary_ConfigPlayTime = 69337122;

	public const int SMSTestSummary_PointIndex = 70320128;

	public const int SMSTestSummary_ID = 70320129;

	public const int SMSTestSummary_EndPointIndex = 70320130;

	public const int SMSTestSummary_TaskIndex = 70320131;

	public const int SMSTestSummary_TaskInnerIndex = 70320132;

	public const int SMSTestSummary_OutsideCycleIndex = 70320133;

	public const int SMSTestSummary_SessionIndex = 70320134;

	public const int SMSTestSummary_StartExecuteTime = 70320135;

	public const int SMSTestSummary_EndExecuteTime = 70320136;

	public const int SMSTestSummary_SessionResult = 70320137;

	public const int SMSTestSummary_SessionReason = 70320138;

	public const int SMSTestSummary_TestPlanID = 70320139;

	public const int SMSTestSummary_SMSMode = 70320140;

	public const int SMSTestSummary_SendDelay = 70320141;

	public const int SMSTestSummary_SendtoNotificationDelay = 70320142;

	public const int SMSTestSummary_ReceiveDelay = 70320143;

	public const int SMSTestSummary_TotalDelay = 70320144;

	public const int SMSTestSendSummary_PointIndex = 70254592;

	public const int SMSTestSendSummary_ID = 70254593;

	public const int SMSTestSendSummary_EndPointIndex = 70254594;

	public const int SMSTestSendSummary_SessionIndex = 70254595;

	public const int SMSTestSendSummary_StartExecuteTime = 70254596;

	public const int SMSTestSendSummary_EndExecuteTime = 70254597;

	public const int SMSTestSendSummary_SessionResult = 70254598;

	public const int SMSTestSendSummary_SessionReason = 70254599;

	public const int SMSTestSendSummary_CalledNumber = 70254600;

	public const int SMSTestSendSummary_CallingNumber = 70254601;

	public const int SMSTestSendSummary_SMSContent = 70254602;

	public const int SMSTestSendSummary_SMSIndex = 70254603;

	public const int SMSTestSendSummary_SMSTimeTag = 70254604;

	public const int SMSTestSendSummary_SendDelay = 70254605;

	public const int SMSTestSendSummary_SendtoNotificationDelay = 70254606;

	public const int NR5gPDSCHBLER_PointIndex = 329121792;

	public const int NR5gPDSCHBLER_BLER = 329121797;

	public const int DouYinTestSummary_PointIndex = 70844416;

	public const int DouYinTestSummary_ID = 70844417;

	public const int DouYinTestSummary_EndPointIndex = 70844418;

	public const int DouYinTestSummary_TaskIndex = 70844419;

	public const int DouYinTestSummary_TaskInnerIndex = 70844420;

	public const int DouYinTestSummary_OutsideCycleIndex = 70844421;

	public const int DouYinTestSummary_SessionIndex = 70844422;

	public const int DouYinTestSummary_StartExecuteTime = 70844423;

	public const int DouYinTestSummary_EndExecuteTime = 70844424;

	public const int DouYinTestSummary_SessionResult = 70844425;

	public const int DouYinTestSummary_SessionReason = 70844426;

	public const int DouYinTestSummary_TestPlanID = 70844427;

	public const int DouYinTestSummary_ListDelay = 70844428;

	public const int DouYinTestSummary_VideoDelay = 70844429;

	public const int DouYinTestSummary_LaunchDelay = 70844430;

	public const int DouYinTestSummary_LauchToFirstPlayVideoDelay = 70844431;

	public const int DouYinTestSummary_AppType = 70844432;

	public const int DouYinTestSummary_RefreshMask = 70844433;

	public const int DouYinVideoRefreshSummary_PointIndex = 70975488;

	public const int DouYinVideoRefreshSummary_EndPointIndex = 70975489;

	public const int DouYinVideoRefreshSummary_SessionIndex = 70975490;

	public const int DouYinVideoRefreshSummary_SessionResult = 70975491;

	public const int DouYinVideoRefreshSummary_SessionReason = 70975492;

	public const int DouYinVideoRefreshSummary_VideoInternalIndex = 70975493;

	public const int DouYinVideoRefreshSummary_Delay = 70975494;

	public const int DouYinVideoRefreshSummary_ID = 70975495;

	public const int DouYinVideoRefreshSummary_BufferCount = 70975496;

	public const int DouYinVideoRefreshSummary_BufferTime = 70975497;

	public const int DouYinVideoRefreshSummary_PlayTime = 70975498;

	public const int DouYinVideoRefreshSummary_Score = 70975499;

	public const int DouYinVideoRefreshSummary_sQuality = 70975500;

	public const int DouYinVideoRefreshSummary_sStalling = 70975501;

	public const int DouYinVideoRefreshSummary_sLoading = 70975502;

	public const int DouYinVideoRefreshSummary_InitPlayDelay = 70975503;

	public const int DouYinVideoRefreshSummary_FirstPacketDelay = 70975504;

	public const int DouYinVideoRefreshSummary_Reserved = 70975505;

	public const int DouYinVideoRefreshSummary_VideoRate = 70975506;

	public const int DouYinVideoRefreshSummary_VideoSize = 70975507;

	public const int ScannerGSMServingCellInfo_PointIndex = 1973551104;

	public const int ScannerGSMServingCellInfo_ID = 1973551105;

	public const int ScannerGSMServingCellInfo_Band = 1973551106;

	public const int ScannerGSMServingCellInfo_BCCH = 1973551107;

	public const int ScannerGSMServingCellInfo_BSIC = 1973551108;

	public const int ScannerGSMServingCellInfo_MCC = 1973551109;

	public const int ScannerGSMServingCellInfo_MNC = 1973551110;

	public const int ScannerGSMServingCellInfo_LAC = 1973551111;

	public const int ScannerGSMServingCellInfo_CellID = 1973551112;

	public const int ScannerGSMServingCellInfo_BCCHLevel = 1973551113;

	public const int ScannerGSMServingCellInfo_IsFakeBS = 1973551114;

	public const int ScannerGSMServingCellInfo_FrequencyDL = 1973551115;

	public const int ScannerCDMAServingCellInfo_PointIndex = 1973616640;

	public const int ScannerCDMAServingCellInfo_ID = 1973616641;

	public const int ScannerCDMAServingCellInfo_Band = 1973616642;

	public const int ScannerCDMAServingCellInfo_Channel = 1973616643;

	public const int ScannerCDMAServingCellInfo_PN = 1973616644;

	public const int ScannerCDMAServingCellInfo_MCC = 1973616645;

	public const int ScannerCDMAServingCellInfo_MNC = 1973616646;

	public const int ScannerCDMAServingCellInfo_NID = 1973616647;

	public const int ScannerCDMAServingCellInfo_SID = 1973616648;

	public const int ScannerCDMAServingCellInfo_RSCP = 1973616649;

	public const int ScannerCDMAServingCellInfo_IsFakeBS = 1973616650;

	public const int ScannerCDMAServingCellInfo_FrequencyDL = 1973616651;

	public const int ScannerCDMAServingCellInfo_BaseID = 1973616652;

	public const int ScannerEVDOServingCellInfo_PointIndex = 1973682176;

	public const int ScannerEVDOServingCellInfo_ID = 1973682177;

	public const int ScannerEVDOServingCellInfo_Band = 1973682178;

	public const int ScannerEVDOServingCellInfo_Channel = 1973682179;

	public const int ScannerEVDOServingCellInfo_PN = 1973682180;

	public const int ScannerEVDOServingCellInfo_MCC = 1973682181;

	public const int ScannerEVDOServingCellInfo_MNC = 1973682182;

	public const int ScannerEVDOServingCellInfo_NID = 1973682183;

	public const int ScannerEVDOServingCellInfo_SID = 1973682184;

	public const int ScannerEVDOServingCellInfo_RSCP = 1973682185;

	public const int ScannerEVDOServingCellInfo_IsFakeBS = 1973682186;

	public const int ScannerEVDOServingCellInfo_FrequencyDL = 1973682187;

	public const int ScannerEVDOServingCellInfo_SectorID = 1973682188;

	public const int ScannerWCDMAServingCellInfo_PointIndex = 1973747712;

	public const int ScannerWCDMAServingCellInfo_ID = 1973747713;

	public const int ScannerWCDMAServingCellInfo_Band = 1973747714;

	public const int ScannerWCDMAServingCellInfo_UARFCN = 1973747715;

	public const int ScannerWCDMAServingCellInfo_PSC = 1973747716;

	public const int ScannerWCDMAServingCellInfo_MCC = 1973747717;

	public const int ScannerWCDMAServingCellInfo_MNC = 1973747718;

	public const int ScannerWCDMAServingCellInfo_LAC = 1973747719;

	public const int ScannerWCDMAServingCellInfo_CellID = 1973747720;

	public const int ScannerWCDMAServingCellInfo_NodeBID = 1973747721;

	public const int ScannerWCDMAServingCellInfo_SectorID = 1973747722;

	public const int ScannerWCDMAServingCellInfo_RSCP = 1973747723;

	public const int ScannerWCDMAServingCellInfo_IsFakeBS = 1973747724;

	public const int ScannerWCDMAServingCellInfo_FrequencyDL = 1973747725;

	public const int ScannerTDSCDMAServingCellInfo_PointIndex = 1973813248;

	public const int ScannerTDSCDMAServingCellInfo_ID = 1973813249;

	public const int ScannerTDSCDMAServingCellInfo_Band = 1973813250;

	public const int ScannerTDSCDMAServingCellInfo_UARFCN = 1973813251;

	public const int ScannerTDSCDMAServingCellInfo_CPI = 1973813252;

	public const int ScannerTDSCDMAServingCellInfo_MCC = 1973813253;

	public const int ScannerTDSCDMAServingCellInfo_MNC = 1973813254;

	public const int ScannerTDSCDMAServingCellInfo_LAC = 1973813255;

	public const int ScannerTDSCDMAServingCellInfo_CellID = 1973813256;

	public const int ScannerTDSCDMAServingCellInfo_NodeBID = 1973813257;

	public const int ScannerTDSCDMAServingCellInfo_SectorID = 1973813258;

	public const int ScannerTDSCDMAServingCellInfo_RSCP = 1973813259;

	public const int ScannerTDSCDMAServingCellInfo_IsFakeBS = 1973813260;

	public const int ScannerTDSCDMAServingCellInfo_FrequencyDL = 1973813261;

	public const int ScannerLTEServingCellInfo_PointIndex = 1973878784;

	public const int ScannerLTEServingCellInfo_ID = 1973878785;

	public const int ScannerLTEServingCellInfo_DuplexMode = 1973878786;

	public const int ScannerLTEServingCellInfo_Band = 1973878787;

	public const int ScannerLTEServingCellInfo_BandwidthDL = 1973878788;

	public const int ScannerLTEServingCellInfo_EArfcnDL = 1973878789;

	public const int ScannerLTEServingCellInfo_PCI = 1973878790;

	public const int ScannerLTEServingCellInfo_MCC = 1973878791;

	public const int ScannerLTEServingCellInfo_MNC = 1973878792;

	public const int ScannerLTEServingCellInfo_Tac = 1973878793;

	public const int ScannerLTEServingCellInfo_CellID = 1973878794;

	public const int ScannerLTEServingCellInfo_eNodebID = 1973878795;

	public const int ScannerLTEServingCellInfo_SectorID = 1973878796;

	public const int ScannerLTEServingCellInfo_RSRP = 1973878797;

	public const int ScannerLTEServingCellInfo_IsFakeBS = 1973878798;

	public const int ScannerLTEServingCellInfo_FrequencyDL = 1973878799;

	public const int ScannerLTEServingCellInfo_MCC2 = 1973878800;

	public const int ScannerLTEServingCellInfo_MNC2 = 1973878801;

	public const int ScannerNR5GServingCellInfo_PointIndex = 1973944320;

	public const int ScannerNR5GServingCellInfo_ID = 1973944321;

	public const int ScannerNR5GServingCellInfo_Band = 1973944322;

	public const int ScannerNR5GServingCellInfo_BandWith = 1973944323;

	public const int ScannerNR5GServingCellInfo_EArfcnDL = 1973944324;

	public const int ScannerNR5GServingCellInfo_PCI = 1973944325;

	public const int ScannerNR5GServingCellInfo_MCC = 1973944326;

	public const int ScannerNR5GServingCellInfo_MNC = 1973944327;

	public const int ScannerNR5GServingCellInfo_Tac = 1973944328;

	public const int ScannerNR5GServingCellInfo_CellID = 1973944329;

	public const int ScannerNR5GServingCellInfo_DuplexMode = 1973944330;

	public const int ScannerNR5GServingCellInfo_eNodebID = 1973944331;

	public const int ScannerNR5GServingCellInfo_SectorID = 1973944332;

	public const int ScannerNR5GServingCellInfo_RSRP = 1973944333;

	public const int ScannerNR5GServingCellInfo_IsFakeBS = 1973944334;

	public const int ScannerNR5GServingCellInfo_FrequencyDL = 1973944335;

	public const int ScannerNR5GServingCellInfo_MCC2 = 1973944336;

	public const int ScannerNR5GServingCellInfo_MNC2 = 1973944337;

	public const int ScannerNR5GServingCellInfo_CenterFreq = 1973944338;

	public const int NPDQos_PointIndex = 68550656;

	public const int NPDQos_ID = 68550657;

	public const int NPDQos_NPDSessionIndex = 68550658;

	public const int NPDQos_NPDDirection = 68550659;

	public const int NPDQos_ExecuteTime = 68550660;

	public const int NPDQos_ULInstSendDatagrams = 68550661;

	public const int NPDQos_ULInstSendTime = 68550662;

	public const int NPDQos_ULInstSendSize = 68550663;

	public const int NPDQos_ULInstSendBandwidth = 68550664;

	public const int NPDQos_ULCumSendTime = 68550665;

	public const int NPDQos_ULCumSendSize = 68550666;

	public const int NPDQos_ULCumSendBandwidth = 68550667;

	public const int NPDQos_DLInstRCVDatagrams = 68550668;

	public const int NPDQos_DLInstRCVTime = 68550669;

	public const int NPDQos_DLInstRCVSize = 68550670;

	public const int NPDQos_DLInstRCVBandwidth = 68550671;

	public const int NPDQos_DLInstRCVLostDatagrams = 68550672;

	public const int NPDQos_DLInstRCVLostDatagramsRatio = 68550673;

	public const int NPDQos_DLInstRCVDelay = 68550674;

	public const int NPDQos_DLInstRCVJitter = 68550675;

	public const int NPDQos_DLCumRCVTime = 68550676;

	public const int NPDQos_DLCumRCVSize = 68550677;

	public const int NPDQos_DLCumRCVBandwidth = 68550678;

	public const int NPDQos_ULInstRCVDatagrams = 68550679;

	public const int NPDQos_ULInstRCVTime = 68550680;

	public const int NPDQos_ULInstRCVSize = 68550681;

	public const int NPDQos_ULInstRCVBandwidth = 68550682;

	public const int NPDQos_ULInstRCVLostDatagrams = 68550683;

	public const int NPDQos_ULInstRCVLostDatagramsRatio = 68550684;

	public const int NPDQos_ULInstRCVDelay = 68550685;

	public const int NPDQos_ULInstRCVJitter = 68550686;

	public const int NPDQos_ULCumRCVTime = 68550687;

	public const int NPDQos_ULCumRCVSize = 68550688;

	public const int NPDQos_ULCumRCVBandwidth = 68550689;

	public const int NPDTestSummary_PointIndex = 68485120;

	public const int NPDTestSummary_EndPointIndex = 68485121;

	public const int NPDTestSummary_TaskIndex = 68485122;

	public const int NPDTestSummary_TaskInnerIndex = 68485123;

	public const int NPDTestSummary_NPDSessionIndex = 68485124;

	public const int NPDTestSummary_StartExecuteTime = 68485125;

	public const int NPDTestSummary_EndExecuteTime = 68485126;

	public const int NPDTestSummary_NPDDirection = 68485127;

	public const int NPDTestSummary_Protocol = 68485128;

	public const int NPDTestSummary_ProtocolVer = 68485129;

	public const int NPDTestSummary_ServerAddress = 68485130;

	public const int NPDTestSummary_Port = 68485131;

	public const int NPDTestSummary_MeasBandwidth = 68485132;

	public const int NPDTestSummary_PacketSize = 68485133;

	public const int NPDTestSummary_SessionResult = 68485134;

	public const int NPDTestSummary_SessionReason = 68485135;

	public const int NPDTestSummary_ULSendTime = 68485136;

	public const int NPDTestSummary_ULSendDatagrams = 68485137;

	public const int NPDTestSummary_ULSendSize = 68485138;

	public const int NPDTestSummary_ULSendBandwidth = 68485139;

	public const int NPDTestSummary_ULRCVTime = 68485140;

	public const int NPDTestSummary_ULRCVDatagrams = 68485141;

	public const int NPDTestSummary_ULRCVSize = 68485142;

	public const int NPDTestSummary_ULRCVBandwidth = 68485143;

	public const int NPDTestSummary_ULRCVLostDatagrams = 68485144;

	public const int NPDTestSummary_ULRCVLostDatagramsRatio = 68485145;

	public const int NPDTestSummary_ULDelay = 68485146;

	public const int NPDTestSummary_ULJitter = 68485147;

	public const int NPDTestSummary_DLSendTime = 68485148;

	public const int NPDTestSummary_DLSendDatagrams = 68485149;

	public const int NPDTestSummary_DLSendSize = 68485150;

	public const int NPDTestSummary_DLSendBandwidth = 68485151;

	public const int NPDTestSummary_DLRCVTime = 68485152;

	public const int NPDTestSummary_DLRCVDatagrams = 68485153;

	public const int NPDTestSummary_DLRCVSize = 68485154;

	public const int NPDTestSummary_DLRCVBandwidth = 68485155;

	public const int NPDTestSummary_DLRCVLostDatagrams = 68485156;

	public const int NPDTestSummary_DLRCVLostDatagramsRatio = 68485157;

	public const int NPDTestSummary_DLDelay = 68485158;

	public const int NPDTestSummary_DLJitter = 68485159;

	public const int NPDTestSummary_OutsideCycleIndex = 68485160;

	public const int NPDTestSummary_ID = 68485161;

	public const int NPDTestSummary_ConfigTestTime = 68485162;

	public const int SpeedTestDLSummary_PointIndex = 69074944;

	public const int SpeedTestDLSummary_ID = 69074945;

	public const int SpeedTestDLSummary_EndPointIndex = 69074946;

	public const int SpeedTestDLSummary_SessionIndex = 69074947;

	public const int SpeedTestDLSummary_BandwithMode = 69074948;

	public const int SpeedTestDLSummary_BandwidthType = 69074949;

	public const int SpeedTestDLSummary_StartExecuteTime = 69074950;

	public const int SpeedTestDLSummary_EndExecuteTime = 69074951;

	public const int SpeedTestDLSummary_SessionResult = 69074952;

	public const int SpeedTestDLSummary_SessionReason = 69074953;

	public const int SpeedTestDLSummary_CumulativeTransmitSize = 69074954;

	public const int SpeedTestDLSummary_CumulativeTransmitTime = 69074955;

	public const int SpeedTestDLSummary_CumulativeAverageRate = 69074956;

	public const int SpeedTestDLSummary_FittedTransmitSize = 69074957;

	public const int SpeedTestDLSummary_FittedTransmitTime = 69074958;

	public const int SpeedTestDLSummary_FittedAverageRate = 69074959;

	public const int SpeedTestDLSummary_ConfigTestMode = 69074960;

	public const int SpeedTestDLSummary_ConfigDownloadTime = 69074961;

	public const int SpeedTestULSummary_PointIndex = 69140480;

	public const int SpeedTestULSummary_ID = 69140481;

	public const int SpeedTestULSummary_EndPointIndex = 69140482;

	public const int SpeedTestULSummary_SessionIndex = 69140483;

	public const int SpeedTestULSummary_BandwithMode = 69140484;

	public const int SpeedTestULSummary_BandwidthType = 69140485;

	public const int SpeedTestULSummary_StartExecuteTime = 69140486;

	public const int SpeedTestULSummary_EndExecuteTime = 69140487;

	public const int SpeedTestULSummary_SessionResult = 69140488;

	public const int SpeedTestULSummary_SessionReason = 69140489;

	public const int SpeedTestULSummary_CumulativeTransmitSize = 69140490;

	public const int SpeedTestULSummary_CumulativeTransmitTime = 69140491;

	public const int SpeedTestULSummary_CumulativeAverageRate = 69140492;

	public const int SpeedTestULSummary_FittedTransmitSize = 69140493;

	public const int SpeedTestULSummary_FittedTransmitTime = 69140494;

	public const int SpeedTestULSummary_FittedAverageRate = 69140495;

	public const int SpeedTestULSummary_ConfigTestMode = 69140496;

	public const int SpeedTestULSummary_ConfigUploadTime = 69140497;

	public const int SpeedTestSummary_PointIndex = 69206016;

	public const int SpeedTestSummary_ID = 69206017;

	public const int SpeedTestSummary_EndPointIndex = 69206018;

	public const int SpeedTestSummary_TaskIndex = 69206019;

	public const int SpeedTestSummary_TaskInnerIndex = 69206020;

	public const int SpeedTestSummary_OutsideCycleIndex = 69206021;

	public const int SpeedTestSummary_SessionIndex = 69206022;

	public const int SpeedTestSummary_StartExecuteTime = 69206023;

	public const int SpeedTestSummary_EndExecuteTime = 69206024;

	public const int SpeedTestSummary_SessionResult = 69206025;

	public const int SpeedTestSummary_SessionReason = 69206026;

	public const int SpeedTestSummary_TestPlanID = 69206027;

	public const int SpeedTestSummary_ServerCity = 69206028;

	public const int SpeedTestSummary_ServerOprator = 69206029;

	public const int SpeedTestSummary_ServerURL = 69206030;

	public const int SpeedTestSummary_ServerLatitude = 69206031;

	public const int SpeedTestSummary_SpeedtestMode = 69206032;

	public const int SpeedTestSummary_PingCount = 69206033;

	public const int SpeedTestSummary_PingDelayAvg = 69206034;

	public const int SpeedTestSummary_PingDelayMax = 69206035;

	public const int SpeedTestSummary_PingDelayMin = 69206036;

	public const int SpeedTestSummary_PingJitter = 69206037;

	public const int SpeedTestSummary_PingLossRatio = 69206038;

	public const int SpeedTestSummary_ServerLongitude = 69206039;

	public const int SpeedTestSummary_DownloadSpeed = 69206040;

	public const int SpeedTestSummary_UploadSpeed = 69206041;

	public const int SpeedTestSummary_ServerAdress = 69206042;

	public const int SpeedTestSummary_ServerLocation = 69206043;

	public const int SpeedTestSummary_ServerDistance = 69206044;

	public const int SpeedTestDLQos_PointIndex = 69664768;

	public const int SpeedTestDLQos_ID = 69664769;

	public const int SpeedTestDLQos_EndPointIndex = 69664770;

	public const int SpeedTestDLQos_SessionIndex = 69664771;

	public const int SpeedTestDLQos_ExecuteTime = 69664772;

	public const int SpeedTestDLQos_InstantTransmitSize = 69664773;

	public const int SpeedTestDLQos_InstantTransmitTime = 69664774;

	public const int SpeedTestDLQos_InstantAverageRate = 69664775;

	public const int SpeedTestDLQos_CumulativeTransmitSize = 69664776;

	public const int SpeedTestDLQos_CumulativeTransmitTime = 69664777;

	public const int SpeedTestDLQos_CumulativeAverageRate = 69664778;

	public const int SpeedTestDLQos_FittedTransmitSize = 69664779;

	public const int SpeedTestDLQos_FittedTransmitTime = 69664780;

	public const int SpeedTestDLQos_FittedAverageRate = 69664781;

	public const int SpeedTestULQos_PointIndex = 69730304;

	public const int SpeedTestULQos_ID = 69730305;

	public const int SpeedTestULQos_EndPointIndex = 69730306;

	public const int SpeedTestULQos_SessionIndex = 69730307;

	public const int SpeedTestULQos_ExecuteTime = 69730308;

	public const int SpeedTestULQos_InstantTransmitSize = 69730309;

	public const int SpeedTestULQos_InstantTransmitTime = 69730310;

	public const int SpeedTestULQos_InstantAverageRate = 69730311;

	public const int SpeedTestULQos_CumulativeTransmitSize = 69730312;

	public const int SpeedTestULQos_CumulativeTransmitTime = 69730313;

	public const int SpeedTestULQos_CumulativeAverageRate = 69730314;

	public const int SpeedTestULQos_FittedTransmitSize = 69730315;

	public const int SpeedTestULQos_FittedTransmitTime = 69730316;

	public const int SpeedTestULQos_FittedAverageRate = 69730317;

	public const int EmailTestSummary_PointIndex = 69992448;

	public const int EmailTestSummary_ID = 69992449;

	public const int EmailTestSummary_EndPointIndex = 69992450;

	public const int EmailTestSummary_TaskIndex = 69992451;

	public const int EmailTestSummary_TaskInnerIndex = 69992452;

	public const int EmailTestSummary_OutsideCycleIndex = 69992453;

	public const int EmailTestSummary_SessionIndex = 69992454;

	public const int EmailTestSummary_StartExecuteTime = 69992455;

	public const int EmailTestSummary_EndExecuteTime = 69992456;

	public const int EmailTestSummary_SessionResult = 69992457;

	public const int EmailTestSummary_SessionReason = 69992458;

	public const int EmailTestSummary_TestPlanID = 69992459;

	public const int EmailTestSummary_EmailMode = 69992460;

	public const int EmailTestSummary_SendDelay = 69992461;

	public const int EmailTestSummary_SendtoNotificationDelay = 69992462;

	public const int EmailTestSummary_NotificationDelay = 69992463;

	public const int EmailTestSummary_ReceiveDelay = 69992464;

	public const int EmailTestSummary_TotalDelay = 69992465;

	public static int[] GSMServingNeighborMeasInfo_PointIndexs;

	public static int[] GSMServingNeighborMeasInfo_EARFCNs;

	public static int[] GSMServingNeighborMeasInfo_PCIs;

	public static int[] GSMServingNeighborMeasInfo_RxLevs;

	public static int[] WCDMAServingNeighborMeasInfo_EARFCNs;

	public static int[] WCDMAServingNeighborMeasInfo_PCIs;

	public static int[] NBIotServingNeighborMeasInfo_EARFCNs;

	public static int[] NBIotServingNeighborMeasInfo_PCIs;

	public static int[] LTEServingNeighborMeasInfo_PointIndexs;

	public static int[] LTEServingNeighborMeasInfo_EARFCNs;

	public static int[] LTEServingNeighborMeasInfo_PCIs;

	public static int[] LTEServingNeighborMeasInfo_RSRPs;

	public static int[] NR5GPilotInfo_PointIndexList;

	public static int[] NR5GPilotInfo_EARFCNList;

	public static int[] NR5GPilotInfo_PCIList;

	public static int[] NR5GPilotInfo_beamIndexList;

	public static int[] NR5GPilotInfo_TimingoffsetList;

	public static int[] NR5GPilotInfo_PSS_cinrList;

	public static int[] NR5GPilotInfo_PSS_RPList;

	public static int[] NR5GPilotInfo_PSS_RQList;

	public static int[] NR5GPilotInfo_SSS_cinrList;

	public static int[] NR5GPilotInfo_SSS_RPList;

	public static int[] NR5GPilotInfo_SSS_RQList;

	public static int[] NR5GPilotInfo_pbchDMRS_cinrList;

	public static int[] NR5GPilotInfo_pbchDMRS_RPList;

	public static int[] NR5GPilotInfo_pbchDMRS_RQList;

	public static int[] NR5GPilotInfo_ssb_cinrList;

	public static int[] NR5GPilotInfo_ssb_RPList;

	public static int[] NR5GPilotInfo_ssb_RQList;

	public static int[] NR5GPilotInfo_ssb_RSSiList;

	public static int[] NBPilotInfo_PointIndexList;

	public static int[] NBPilotInfo_EARFCNList;

	public static int[] NBPilotInfo_PCIList;

	public static int[] NBPilotInfo_RSRPList;

	public static int[] NBPilotInfo_RSRQList;

	public static int[] NBPilotInfo_SINRList;

	public static int[] NBPilotInfo_TimingoffsetList;

	public static int[] NBPilotInfo_BandwithList;

	public static int[] NBPilotInfo_AntennaPortNumberList;

	public static int[] NBPilotInfo_SSS_RSSIList;

	public static int[] NBPilotInfo_SSS_RPList;

	public static int[] TopNCellDetailsNR5GAllInOne;

	public static int[] TopNCellDetailsNR5G;

	public static int[] TopNCellDetailsLteAllInOne;

	public static int[] TopNCellDetailsLte;

	public static int[] WCDMAPilotInfo_EARFCNList;

	public static int[] WCDMAPilotInfo_PCIList;

	public static int[] GSMPilotInfo_EARFCNList;

	public static int[] GSMPilotInfo_PCIList;

	private static SGDataset qajU56ZJxTSkXcXkjZAX;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SGDataset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SGDataset()
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
				case 4:
				{
					int[] array3 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					LTEServingNeighborMeasInfo_RSRPs = array3;
					num2 = 49;
					if (false)
					{
						num2 = 25;
					}
					continue;
				}
				case 36:
					GSMServingNeighborMeasInfo_RxLevs = new int[6] { 656670724, 656736260, 656801796, 656867332, 656932868, 656998404 };
					num2 = 43;
					continue;
				case 1:
					TopNCellDetailsNR5GAllInOne = new int[30]
					{
						1979056152, 1979056130, 1979056131, 1979056136, 1979056147, 1979056146, 1979056148, 1979056149, 1979056138, 1979056137,
						1979056139, 1979056141, 1979056140, 1979056142, 1979056144, 1979056143, 1979056145, 1979056154, 1979056155, 1979056156,
						1979056157, 1979056158, 1979056159, 1979056162, 1979056163, 1979056160, 1979056161, 1979056164, 1979056132, 1979056150
					};
					num2 = 33;
					continue;
				case 12:
				{
					int[] array13 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array13, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_TimingoffsetList = array13;
					num2 = 23;
					continue;
				}
				case 18:
				{
					int[] array7 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					GSMPilotInfo_EARFCNList = array7;
					num2 = 5;
					continue;
				}
				case 29:
				{
					int[] array45 = new int[8];
					sUPWo9ZJqHxqRwVyl5Lk(array45, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBIotServingNeighborMeasInfo_PCIs = array45;
					num2 = 27;
					if (false)
					{
						num2 = 2;
					}
					continue;
				}
				case 47:
				{
					int[] array44 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array44, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_pbchDMRS_RPList = array44;
					num2 = 20;
					continue;
				}
				case 25:
				{
					int[] array43 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array43, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_PSS_RQList = array43;
					num2 = 28;
					if (true)
					{
						continue;
					}
					break;
				}
				case 42:
				{
					int[] array42 = new int[38];
					sUPWo9ZJqHxqRwVyl5Lk(array42, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					TopNCellDetailsLteAllInOne = array42;
					num2 = 32;
					continue;
				}
				case 51:
				{
					int[] array41 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array41, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_ssb_RSSiList = array41;
					num = 50;
					break;
				}
				case 16:
				{
					int[] array40 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array40, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_TimingoffsetList = array40;
					num2 = 24;
					continue;
				}
				case 32:
				{
					int[] array39 = new int[28];
					sUPWo9ZJqHxqRwVyl5Lk(array39, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					TopNCellDetailsLte = array39;
					num2 = 6;
					continue;
				}
				case 22:
				{
					int[] array38 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array38, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_RSRQList = array38;
					num2 = 40;
					continue;
				}
				case 14:
					af0hyOZJBbUmG7BGyu9T();
					num2 = 13;
					continue;
				default:
				{
					int[] array37 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array37, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					LTEServingNeighborMeasInfo_PCIs = array37;
					num2 = 4;
					if (1 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 46:
				{
					int[] array36 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array36, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_beamIndexList = array36;
					num = 16;
					break;
				}
				case 8:
				{
					int[] array35 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array35, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					LTEServingNeighborMeasInfo_EARFCNs = array35;
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				}
				case 3:
				{
					int[] array34 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array34, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_pbchDMRS_cinrList = array34;
					num2 = 47;
					continue;
				}
				case 49:
				{
					int[] array33 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array33, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_PointIndexList = array33;
					num = 44;
					break;
				}
				case 34:
					return;
				case 39:
				{
					int[] array32 = new int[6];
					sUPWo9ZJqHxqRwVyl5Lk(array32, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					GSMServingNeighborMeasInfo_EARFCNs = array32;
					num2 = 7;
					continue;
				}
				case 41:
				{
					int[] array31 = new int[6];
					sUPWo9ZJqHxqRwVyl5Lk(array31, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					GSMServingNeighborMeasInfo_PointIndexs = array31;
					num = 39;
					break;
				}
				case 9:
				{
					int[] array30 = new int[12];
					sUPWo9ZJqHxqRwVyl5Lk(array30, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					WCDMAServingNeighborMeasInfo_PCIs = array30;
					num2 = 38;
					if (true)
					{
						continue;
					}
					break;
				}
				case 30:
				{
					int[] array29 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array29, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_EARFCNList = array29;
					num2 = 26;
					continue;
				}
				case 15:
				{
					int[] array28 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array28, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_RSRPList = array28;
					num2 = 22;
					continue;
				}
				case 31:
				{
					int[] array27 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array27, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_SSS_RPList = array27;
					num = 11;
					break;
				}
				case 7:
				{
					int[] array26 = new int[6];
					sUPWo9ZJqHxqRwVyl5Lk(array26, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					GSMServingNeighborMeasInfo_PCIs = array26;
					num = 36;
					break;
				}
				case 24:
				{
					int[] array25 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array25, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_PSS_cinrList = array25;
					num2 = 17;
					continue;
				}
				case 26:
				{
					int[] array24 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array24, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_PCIList = array24;
					num2 = 15;
					continue;
				}
				case 20:
				{
					int[] array23 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array23, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_pbchDMRS_RQList = array23;
					num2 = 45;
					continue;
				}
				case 35:
				{
					int[] array22 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_PCIList = array22;
					num2 = 46;
					continue;
				}
				case 50:
				{
					int[] array21 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_PointIndexList = array21;
					num2 = 30;
					continue;
				}
				case 37:
				{
					int[] array20 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					WCDMAPilotInfo_PCIList = array20;
					num = 18;
					break;
				}
				case 21:
				{
					int[] array19 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_AntennaPortNumberList = array19;
					num2 = 2;
					continue;
				}
				case 28:
				{
					int[] array18 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array18, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_SSS_cinrList = array18;
					num2 = 31;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				case 44:
				{
					int[] array17 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_EARFCNList = array17;
					num2 = 35;
					continue;
				}
				case 23:
				{
					int[] array16 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_BandwithList = array16;
					num2 = 21;
					continue;
				}
				case 10:
					NBPilotInfo_SSS_RPList = new int[16]
					{
						1979252749, 1979318285, 1979383821, 1979449357, 1979514893, 1979580429, 1979645965, 1979711501, 1979777037, 1979842573,
						1979908109, 1979973645, 1980039181, 1980104717, 1980170253, 1980235789
					};
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 13:
					Xc19rUZJW36hlfOWGpxi();
					num2 = 41;
					if (1 == 0)
					{
						num2 = 33;
					}
					continue;
				case 19:
				{
					int[] array15 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array15, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_ssb_RPList = array15;
					num = 48;
					break;
				}
				case 38:
				{
					int[] array14 = new int[8];
					sUPWo9ZJqHxqRwVyl5Lk(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBIotServingNeighborMeasInfo_EARFCNs = array14;
					num2 = 29;
					continue;
				}
				case 48:
				{
					int[] array12 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_ssb_RQList = array12;
					num2 = 51;
					if (false)
					{
						num2 = 26;
					}
					continue;
				}
				case 33:
				{
					int[] array11 = new int[25];
					sUPWo9ZJqHxqRwVyl5Lk(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					TopNCellDetailsNR5G = array11;
					num2 = 42;
					continue;
				}
				case 40:
				{
					int[] array10 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_SINRList = array10;
					num2 = 12;
					continue;
				}
				case 5:
				{
					int[] array9 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					GSMPilotInfo_PCIList = array9;
					num2 = 34;
					if (true)
					{
						continue;
					}
					break;
				}
				case 11:
				{
					int[] array8 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_SSS_RQList = array8;
					num2 = 3;
					continue;
				}
				case 2:
				{
					int[] array6 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NBPilotInfo_SSS_RSSIList = array6;
					num2 = 8;
					if (0 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				case 27:
				{
					int[] array5 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					LTEServingNeighborMeasInfo_PointIndexs = array5;
					num2 = 8;
					continue;
				}
				case 43:
				{
					int[] array4 = new int[12];
					sUPWo9ZJqHxqRwVyl5Lk(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					WCDMAServingNeighborMeasInfo_EARFCNs = array4;
					num2 = 9;
					continue;
				}
				case 17:
				{
					int[] array2 = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_PSS_RPList = array2;
					num2 = 17;
					if (0 == 0)
					{
						num2 = 25;
					}
					continue;
				}
				case 45:
				{
					int[] array = new int[16];
					sUPWo9ZJqHxqRwVyl5Lk(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					NR5GPilotInfo_ssb_cinrList = array;
					num2 = 19;
					continue;
				}
				case 6:
					WCDMAPilotInfo_EARFCNList = new int[16]
					{
						1991049218, 1991114754, 1991180290, 1991245826, 1991311362, 1991376898, 1991442434, 1991507970, 1991573506, 1991639042,
						1991704578, 1991770114, 1991835650, 1991901186, 1991966722, 1992032258
					};
					num2 = 37;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xc19rUZJW36hlfOWGpxi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CMrSxeZJAOUyeALcGC5f()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SGDataset PoWaIPZJtRtcZqsi5F1m()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void af0hyOZJBbUmG7BGyu9T()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sUPWo9ZJqHxqRwVyl5Lk(object P_0, RuntimeFieldHandle P_1)
	{
	}
}
