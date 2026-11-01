using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using VeZr0GvFeaMRlEIhHS;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class SGDatasetUtils
{
	public const string StaticTypeSum = "sum";

	public const string StaticTypeAvg = "avg";

	public const string StaticTypeCount = "count";

	public const string StaticTypeMin = "min";

	public const string StaticTypeMax = "max";

	public const string StaticTypeDuration = "duration";

	public const string StaticTypeFirst = "first";

	public const string StaticTypeLast = "last";

	public const int OperatorValueChinaMobile = 1;

	public const int OperatorValueChinaUnicom = 2;

	public const int OperatorValueChinaTelecom = 3;

	public const int OperatorValueChinaBroadcasting = 4;

	public const int AppAutoTestActionEvent = 1610753027;

	public const int AppAutoTest_Config_PointIndex = 1721303040;

	public const int AppAutoTest_Config_ID = 1721303041;

	public const int AppAutoTest_Config_ConfigType = 1721303042;

	public const int AppAutoTest_Config_TaskType = 1721303043;

	public const int AppAutoTest_Config_StartEvent = 1721303044;

	public const int AppAutoTest_Config_EndEvent = 1721303045;

	public const int AppAutoTest_Event_PointIndex = 1721368576;

	public const int AppAutoTest_Event_ID = 1721368577;

	public const int AppAutoTest_Event_EventTime = 1721368578;

	public const int AppAutoTest_Event_TaskType = 1721368579;

	public const int AppAutoTest_Event_TaskIndex = 1721368580;

	public const int AppAutoTest_Event_EventName = 1721368581;

	public const int AppAutoTest_Delay_PointIndex = 1721434112;

	public const int AppAutoTest_Delay_ID = 1721434113;

	public const int AppAutoTest_Delay_TaskType = 1721434114;

	public const int AppAutoTest_Delay_TaskIndex = 1721434115;

	public const int AppAutoTest_Delay_StartEventTime = 1721434116;

	public const int AppAutoTest_Delay_StartEventName = 1721434117;

	public const int AppAutoTest_Delay_EndEventTime = 1721434118;

	public const int AppAutoTest_Delay_EndEventName = 1721434119;

	public const int AppAutoTest_Delay_Delay = 1721434120;

	public static int InheritedValueFlag;

	public static int TrueValueFlag;

	public static int TrueValue;

	public static int InheritedValue;

	public static int ServiceStatus_Service_Available;

	public static int TestManagerInfo_TestCity;

	public static int TestManagerInfo_Tester;

	public static int TestManagerInfo_TestCar;

	public static int TestManagerInfo_UEType;

	public static int TestManagerInfo_UENumber;

	public static int TestManagerInfo_DetailCallEvent;

	public static int TestManagerInfo_TestOperatorID;

	public static int CommonInfo_PointIndex;

	public static int CommonInfo_PCTime;

	public static int CommonInfo_Direction;

	public static int CommonInfo_Channel;

	public static int CommonInfo_MsgInfo;

	public static int CommonInfo_TimeStamp;

	public static int UBOreinDataInfo_ID;

	public static int UBOreinDataInfo_PCTime;

	public static int UBOreinDataInfo_DataType;

	public static int UBOreinDataInfo_BufferSize;

	public static int UBOreinDataInfo_Buffer;

	public static int UENetworkStateInfo_CampedNetwork;

	public static int UENetworkStateInfo_CampedNetworkState;

	public static int LogFileInfo_ScanNetWorkSet;

	public static int LTEStatus_EMMState;

	public static int CallManagerStateInfo_ServiceStatus;

	public static int Layer3Info_PointIndex;

	public static int Layer3Info_PCTime;

	public static int Layer3Info_Dir;

	public static int Layer3Info_Channel;

	public static int Layer3Info_MsgInfo;

	public static int Layer3Info_TimeStamp;

	public static int Layer3Info_ID;

	public static int Layer3Info_AdditionInfo;

	public static int GPSInfo_PointIndex;

	public static int GPSInfo_ID;

	public static int GPSInfo_LockState;

	public static int GPSInfo_UTCTime;

	public static int GPSInfo_Longitude;

	public static int GPSInfo_Latitude;

	public static int GPSInfo_Altiutde;

	public static int GPSInfo_Speed;

	public static int GPSInfo_SatelliteNum;

	public static int GPSInfo_CumulativeDistance;

	public static int GPSInfo_InstantDistance;

	public static int GPSInfo_GroudCourse;

	public static int GPSInfo_FloorIndex;

	public static int GPSInfo_IsReal;

	public static int GPSInfo_GroundLevel;

	public static int SyncTimerInfo_PointIndex;

	public static int SyncTimerInfo_ID;

	public static int SyncTimerInfo_PCTime;

	public static int EventInfo_PointIndex;

	public static int EventInfo_GlobalEventIndex;

	public static int EventInfo_EventType;

	public static int EventInfo_ExecuteTime;

	public static int EventInfo_TestSessionIndex;

	public static int EventInfo_TestSessionType;

	public static int IndoorLocationInfo_PointIndex;

	public static int IndoorLocationInfo_ID;

	public static int IndoorLocationInfo_xValue;

	public static int IndoorLocationInfo_yValue;

	public static int IndoorLocationInfo_LocationValid;

	public static int IndoorLocationInfo_IsORGMark;

	public static int IndoorLocationInfo_MapFileIndex;

	public static int IndoorLocationInfo_FloorIndex;

	public static int IndoorMapInfo_ID;

	public static int IndoorMapInfo_MapFileName;

	public static int IndoorMapInfo_MapType;

	public static int IndoorMapInfo_MapLength;

	public static int IndoorMapInfo_MapData;

	public static int IndoorMapInfo_FloorIndex;

	public static int IndoorMapInfo_MapFileIndex;

	public static int IndoorMapInfo_LaserX;

	public static int IndoorMapInfo_LaserY;

	public static int TagContent_PointIndex;

	public static int TagContent_TagIndex;

	public static int TagContent_TagTime;

	public static int TagContent_TagContent;

	public static int TagContent_TagType;

	public static int LogFileInfo_SoftwareName;

	public static int LogFileInfo_SoftwareVersion;

	public static int LogFileInfo_LogTotalDurationTime;

	public static int LogFileInfo_LogBeginLogTime;

	public static int LogFileInfo_LogEndLogTime;

	public static int LogFileInfo_LogTimeZone;

	public static int LogFileInfo_HasBIN;

	public static int LogFileInfo_LogFormatType;

	public static int LogFileInfo_EncryptKey;

	public static int LogFileInfo_GPSDataSource;

	public static int LogFileInfo_LogNormalEnd;

	public static int LogFileInfo_LogOreinName;

	public static int LogFileInfo_ComputerID;

	public static int LogFileInfo_ProductionID;

	public static int LogFileInfo_SystemModel;

	public static int LogFileInfo_CPU;

	public static int LogFileInfo_RAM;

	public static int LogFileInfo_WindowVersion;

	public static int LogFileInfo_PCUserName;

	public static int LogFileInfo_ComputerModel;

	public static int LogFileInfo_CallFileGUID;

	public static int LogFileInfo_LoggingFileGUID;

	internal static SGDatasetUtils VmDNoYv6Nrq9wjtAhpH;

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC002")]
	public static extern IntPtr OpenFile(string fileName, uint mode);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC004")]
	public static extern void CloseFile(IntPtr handle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC009")]
	public static extern int GetTotalCount(IntPtr handle, int paramKey);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC006")]
	private static extern double nGoL2sx6yx(IntPtr P_0, int P_1, int P_2, ref int P_3);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC024")]
	public static extern double GetLastDoubleValueOrg(IntPtr handle, int paramKey);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC025")]
	private static extern IntPtr IjSLNDo6If(IntPtr P_0, int P_1, ref int P_2);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC007")]
	public static extern int GetIntValueOrg(IntPtr handle, int paramKey, int pointIndex, ref int trueFlag);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC00701")]
	private static extern long DelLlnyMBA(IntPtr P_0, int P_1, int P_2, ref int P_3);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC008")]
	private static extern IntPtr j8bLzSProA(IntPtr P_0, int P_1, int P_2, ref int P_3, ref int P_4);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC030")]
	public static extern int GetInheritedValuePointIdx(IntPtr handle, int paramKey, int pointIndex);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int GetIntValue(IntPtr handle, int paramKey, int pointIndex, ref int trueFlag)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static long GetInt64Value(IntPtr handle, int paramKey, int pointIndex, ref int trueFlag)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static double GetDoubleValue(IntPtr handle, int paramKey, int pointIndex, ref int trueFlag)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static double GetLastDoubleValue(IntPtr handle, int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static IntPtr GetStringValue(IntPtr handle, int paramKey, int pointIndex, ref int strLen, ref int trueFlag)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static IntPtr GetLastStringValue(IntPtr handle, int paramKey, ref int size)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static IntPtr PrepareRead(IntPtr handle, int paramKey, string conditions)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static bool PrepareConfig(IntPtr handle, int key, string value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static bool PrepareNext(IntPtr handle)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static uint UnPrepareRead(IntPtr handle)
	{
		return 0u;
	}

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC010")]
	private static extern IntPtr k8Es947QG2(IntPtr P_0, int P_1, string P_2);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC011")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool NFcs7diwHN(IntPtr P_0, int P_1, string P_2);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC012")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool kHasq3i7QR(IntPtr P_0);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC013")]
	public static extern double PrepareValue(IntPtr handle, int paramKey);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC01301")]
	public static extern long PrepareInt64Value(IntPtr handle, int paramKey);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC014")]
	public static extern IntPtr PrepareTextValue(IntPtr handle, int paramKey, ref int size);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC015")]
	private static extern uint JCKsT377vp(IntPtr P_0);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC033")]
	public static extern double GetScalarDouble(IntPtr handle, int paramKey, string conditions);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC034")]
	public static extern IntPtr GetScalarString(IntPtr handle, int paramKey, string conditions, ref int size);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC016")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool WriteData(IntPtr handle, int ActionType, int TableID, IntPtr buffer, int length);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC019")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool FinishWrite(IntPtr handle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC020")]
	public static extern double GetStatistic(IntPtr handle, int paramKey, byte[] conditions, string aggType);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC035")]
	public static extern double GetDuration(IntPtr handle, int paramKey, int valType, string conditions);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC021")]
	public static extern IntPtr OpenBinHandle(IntPtr handle, int binType, int binSize, int valueType, string fileName);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC0211")]
	public static extern IntPtr OpenBinHandleEx(IntPtr handle, int binType, int binSize, int valueType, string fileName, byte[] filterBuffer);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC02102")]
	public static extern bool GetBinPointInfo(IntPtr handle, int index, ref double leftDownX, ref double leftDownY, ref double rightUpX, ref double rightUpY);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC022")]
	public static extern IntPtr OpenFilterHandle(IntPtr handle, int FilterBufferSize, byte[] Filterbuffer, string fileName);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC027")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool DivideOrgFile(IntPtr srcHandle, IntPtr dstHandle, long begTime, long endTime);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC028")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool BackupUTS(IntPtr srcHandle, IntPtr dstHandle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC029")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool SetConfig(IntPtr handle, int key, string value, int size);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC031")]
	public static extern int CaculateVirtualData(IntPtr handle, int tableID);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC032")]
	public static extern int GetRowID(IntPtr handle, int paramKey, int index);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC026")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool MergeUBFile(IntPtr srcHandle, IntPtr dstHandle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC005")]
	public static extern void GetLastErrorInfo(IntPtr handle, byte[] msg, int size);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC036")]
	public static extern int RepairFileData(IntPtr handle, string repairRule);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC102")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool SqliteExec(IntPtr handle, byte[] sql);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC103")]
	public static extern IntPtr SqlitePrepare(IntPtr handle, byte[] sql);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC106")]
	public static extern int SqliteFinalize(IntPtr handle, IntPtr stmt);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC150")]
	public static extern void CheckField(IntPtr handle, int paramKey);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC017")]
	public static extern uint WriteUtsData(IntPtr handle, IntPtr buffer, int length);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int GetPointNumber(IntPtr handle)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int GetPointNumberByParamCode(IntPtr handle, int paramCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int GetGPSPointNumber(IntPtr handle)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static int GetGPSValue(IntPtr handle, int iPointIdx, ref double dlong, ref double dlat)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static long GetUEDateTime(IntPtr handle, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static long GetDateTime(IntPtr handle, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static uint GetMsgCode(IntPtr handle, int iPointIdx)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static long GetEventTime(IntPtr handle, int iEventIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetOperatorName(int oper)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearTable(IntPtr handle, int paramKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SGDatasetUtils()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SGDatasetUtils()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 33;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					Layer3Info_AdditionInfo = 1245191;
					num2 = 55;
					continue;
				case 89:
					TagContent_TagType = 851972;
					num2 = 85;
					continue;
				case 99:
					ServiceStatus_Service_Available = 2;
					num2 = 101;
					continue;
				case 47:
					Layer3Info_Channel = 1245187;
					num2 = 5;
					continue;
				case 74:
					LogFileInfo_ScanNetWorkSet = 65556;
					num2 = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 78:
					IndoorMapInfo_MapData = 1761607685;
					num2 = 102;
					if (1 == 0)
					{
						num2 = 42;
					}
					continue;
				case 22:
					IndoorMapInfo_MapFileIndex = 1761607687;
					num2 = 88;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 10:
					Layer3Info_Dir = 1245186;
					num2 = 47;
					continue;
				case 85:
					LogFileInfo_SoftwareName = 65538;
					num2 = 35;
					continue;
				case 75:
					return;
				case 73:
					GPSInfo_SatelliteNum = 393225;
					num2 = 11;
					if (0 == 0)
					{
						num2 = 12;
					}
					continue;
				case 23:
					CommonInfo_PCTime = 1;
					num2 = 80;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 95:
					EventInfo_TestSessionIndex = 524293;
					num2 = 8;
					if (0 == 0)
					{
						num2 = 26;
					}
					continue;
				case 53:
					GPSInfo_GroudCourse = 393228;
					num2 = 91;
					continue;
				case 55:
					GPSInfo_PointIndex = 393216;
					num2 = 6;
					if (0 == 0)
					{
						num2 = 63;
					}
					continue;
				case 83:
					LogFileInfo_SystemModel = 65571;
					num2 = 16;
					if (1 == 0)
					{
						num2 = 5;
					}
					continue;
				case 84:
					GPSInfo_LockState = 393218;
					num2 = 61;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 68:
					CommonInfo_MsgInfo = 4;
					num2 = 72;
					continue;
				case 103:
					LogFileInfo_LogFormatType = 65552;
					num2 = 25;
					continue;
				case 17:
					UBOreinDataInfo_Buffer = 917508;
					num2 = 69;
					continue;
				case 56:
					IndoorLocationInfo_FloorIndex = 786439;
					num2 = 94;
					continue;
				case 100:
					GPSInfo_Longitude = 393220;
					num = 2;
					break;
				case 59:
					GPSInfo_IsReal = 393230;
					num2 = 34;
					continue;
				case 54:
					SQofOgva5W7WpQGHoqZ();
					num2 = 79;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 57:
					Layer3Info_PCTime = 1245185;
					num2 = 10;
					continue;
				case 107:
					GPSInfo_Speed = 393223;
					num2 = 63;
					if (true)
					{
						num2 = 73;
					}
					continue;
				case 69:
					UENetworkStateInfo_CampedNetwork = 1179650;
					num2 = 78;
					if (true)
					{
						num2 = 93;
					}
					continue;
				case 66:
					EventInfo_ExecuteTime = 524292;
					num = 95;
					break;
				case 101:
					TestManagerInfo_TestCity = 720902;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 30:
					EventInfo_PointIndex = 524288;
					num2 = 65;
					continue;
				case 94:
					IndoorMapInfo_ID = 1761607681;
					num2 = 96;
					continue;
				case 108:
					LogFileInfo_LogNormalEnd = 65567;
					num2 = 10;
					if (0 == 0)
					{
						num2 = 29;
					}
					continue;
				case 6:
					LTEStatus_EMMState = 10485762;
					num2 = 86;
					continue;
				case 44:
					LogFileInfo_LogEndLogTime = 65550;
					num = 41;
					break;
				case 4:
					LogFileInfo_RAM = 65573;
					num2 = 39;
					continue;
				case 104:
					IndoorLocationInfo_PointIndex = 786432;
					num2 = 48;
					continue;
				case 12:
					GPSInfo_CumulativeDistance = 393226;
					num2 = 20;
					continue;
				case 31:
					GPSInfo_Altiutde = 393222;
					num2 = 107;
					if (1 == 0)
					{
						num2 = 77;
					}
					continue;
				case 63:
					GPSInfo_ID = 393217;
					num2 = 84;
					continue;
				case 19:
					LogFileInfo_HasBIN = 65557;
					num2 = 103;
					continue;
				case 82:
					TagContent_TagIndex = 851969;
					num2 = 9;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 40:
					Layer3Info_TimeStamp = 1245189;
					num2 = 106;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 24:
					UBOreinDataInfo_DataType = 917506;
					num2 = 105;
					continue;
				case 33:
					T7q9K7vvQYyceA3q05i();
					num2 = 32;
					continue;
				case 26:
					EventInfo_TestSessionType = 524294;
					num2 = 104;
					continue;
				case 43:
					EventInfo_EventType = 524291;
					num2 = 66;
					continue;
				case 71:
					TrueValueFlag = 100;
					num2 = 90;
					if (true)
					{
						continue;
					}
					break;
				case 11:
					TestManagerInfo_TestOperatorID = 720917;
					num2 = 77;
					continue;
				case 50:
					TagContent_TagContent = 851971;
					num2 = 89;
					continue;
				case 80:
					CommonInfo_Direction = 2;
					num2 = 3;
					continue;
				case 88:
					IndoorMapInfo_LaserX = 1761607688;
					num2 = 87;
					if (true)
					{
						continue;
					}
					break;
				case 58:
					InheritedValue = 0;
					num2 = 99;
					if (true)
					{
						continue;
					}
					break;
				case 96:
					IndoorMapInfo_MapFileName = 1761607682;
					num2 = 37;
					continue;
				case 77:
					CommonInfo_PointIndex = 0;
					num2 = 23;
					continue;
				case 38:
					TagContent_PointIndex = 851968;
					num = 82;
					break;
				case 106:
					Layer3Info_ID = 1245190;
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 28:
					SyncTimerInfo_PointIndex = 1507328;
					num2 = 3;
					if (0 == 0)
					{
						num2 = 14;
					}
					continue;
				case 32:
					dFr81DvAODHXBFXe9Sb();
					num = 54;
					break;
				case 14:
					SyncTimerInfo_ID = 1507329;
					num2 = 8;
					if (true)
					{
						num2 = 27;
					}
					continue;
				case 87:
					IndoorMapInfo_LaserY = 1761607689;
					num2 = 38;
					continue;
				case 65:
					EventInfo_GlobalEventIndex = 524290;
					num2 = 43;
					continue;
				case 18:
					IndoorLocationInfo_IsORGMark = 786437;
					num2 = 13;
					continue;
				case 3:
					CommonInfo_Channel = 3;
					num2 = 68;
					continue;
				case 90:
					TrueValue = 1;
					num2 = 58;
					continue;
				case 20:
					GPSInfo_InstantDistance = 393227;
					num2 = 53;
					continue;
				case 97:
					LogFileInfo_GPSDataSource = 65566;
					num2 = 108;
					continue;
				case 51:
					TestManagerInfo_UENumber = 720912;
					num2 = 8;
					continue;
				case 79:
					uOv0OU0Kme5HKTDMBO.vljRbPazYJ79B();
					num2 = 15;
					continue;
				case 27:
					SyncTimerInfo_PCTime = 1507330;
					num2 = 30;
					continue;
				case 36:
					TestManagerInfo_UEType = 720911;
					num2 = 51;
					continue;
				case 70:
					UBOreinDataInfo_ID = 917504;
					num2 = 62;
					continue;
				case 39:
					LogFileInfo_WindowVersion = 65574;
					num2 = 21;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 13:
					IndoorLocationInfo_MapFileIndex = 786438;
					num2 = 56;
					continue;
				case 49:
					LogFileInfo_ComputerID = 65569;
					num2 = 70;
					if (true)
					{
						num2 = 81;
					}
					continue;
				case 45:
					LogFileInfo_CallFileGUID = 65577;
					num2 = 52;
					continue;
				case 105:
					UBOreinDataInfo_BufferSize = 917507;
					num2 = 17;
					continue;
				case 41:
					LogFileInfo_LogTimeZone = 65551;
					num2 = 19;
					if (true)
					{
						continue;
					}
					break;
				case 46:
					LogFileInfo_LogBeginLogTime = 65549;
					num2 = 44;
					continue;
				case 98:
					TestManagerInfo_TestCar = 720910;
					num2 = 36;
					continue;
				case 81:
					LogFileInfo_ProductionID = 65570;
					num2 = 83;
					continue;
				case 16:
					LogFileInfo_CPU = 65572;
					num2 = 4;
					if (false)
					{
						num2 = 1;
					}
					continue;
				case 5:
					Layer3Info_MsgInfo = 1245188;
					num2 = 40;
					if (true)
					{
						continue;
					}
					break;
				case 34:
					GPSInfo_GroundLevel = 393232;
					num2 = 22;
					if (true)
					{
						num2 = 28;
					}
					continue;
				case 29:
					LogFileInfo_LogOreinName = 65568;
					num2 = 49;
					continue;
				case 62:
					UBOreinDataInfo_PCTime = 917505;
					num2 = 24;
					if (false)
					{
						num2 = 5;
					}
					continue;
				case 61:
					GPSInfo_UTCTime = 393219;
					num2 = 100;
					continue;
				case 15:
					InheritedValueFlag = 0;
					num2 = 71;
					if (true)
					{
						continue;
					}
					break;
				default:
					TestManagerInfo_Tester = 720900;
					num2 = 98;
					if (false)
					{
						num2 = 73;
					}
					continue;
				case 7:
					Layer3Info_PointIndex = 1245184;
					num2 = 57;
					continue;
				case 9:
					TagContent_TagTime = 851970;
					num2 = 50;
					continue;
				case 35:
					LogFileInfo_SoftwareVersion = 65539;
					num = 67;
					break;
				case 37:
					IndoorMapInfo_MapType = 1761607683;
					num2 = 60;
					continue;
				case 86:
					CallManagerStateInfo_ServiceStatus = 983052;
					num2 = 7;
					if (false)
					{
						num2 = 7;
					}
					continue;
				case 76:
					LogFileInfo_ComputerModel = 65576;
					num2 = 45;
					if (true)
					{
						continue;
					}
					break;
				case 64:
					IndoorLocationInfo_xValue = 786434;
					num2 = 42;
					if (1 == 0)
					{
						num2 = 30;
					}
					continue;
				case 60:
					IndoorMapInfo_MapLength = 1761607684;
					num2 = 78;
					continue;
				case 72:
					CommonInfo_TimeStamp = 5;
					num2 = 70;
					continue;
				case 91:
					GPSInfo_FloorIndex = 393229;
					num2 = 32;
					if (0 == 0)
					{
						num2 = 59;
					}
					continue;
				case 42:
					IndoorLocationInfo_yValue = 786435;
					num2 = 92;
					continue;
				case 93:
					UENetworkStateInfo_CampedNetworkState = 1179651;
					num2 = 74;
					continue;
				case 48:
					IndoorLocationInfo_ID = 786433;
					num2 = 64;
					continue;
				case 25:
					LogFileInfo_EncryptKey = 65565;
					num2 = 4;
					if (true)
					{
						num2 = 97;
					}
					continue;
				case 102:
					IndoorMapInfo_FloorIndex = 1761607686;
					num2 = 22;
					continue;
				case 52:
					LogFileInfo_LoggingFileGUID = 65578;
					num2 = 75;
					continue;
				case 21:
					LogFileInfo_PCUserName = 65575;
					num = 76;
					break;
				case 67:
					LogFileInfo_LogTotalDurationTime = 65548;
					num2 = 46;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 92:
					IndoorLocationInfo_LocationValid = 786436;
					num2 = 18;
					continue;
				case 8:
					TestManagerInfo_DetailCallEvent = 720913;
					num = 11;
					break;
				case 2:
					GPSInfo_Latitude = 393221;
					num2 = 31;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BvIEQ2vkDdcBJnp66Ca()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SGDatasetUtils eQEen0vpLJOf25tFfiC()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UwxUhbv44R68i1TS7SS()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I3pf3jvTKFhGN6ZtLoM(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dFr81DvAODHXBFXe9Sb()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T7q9K7vvQYyceA3q05i()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SQofOgva5W7WpQGHoqZ()
	{
	}
}
