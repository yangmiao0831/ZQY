using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using LibBase;
using N6SFqGFYBDLpvREgEy;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class UBFunUtils
{
	public const int ConditionsExEqualIndex = 2;

	public const int ConditionsExRangeStartIndex = 6;

	public const int ConditionsExRangeEndIndex = 9;

	public static int mainThreadId;

	public static Encoding DefEncoding;

	public static Encoding UTF8WithoutBom;

	public static Encoding UnicodeEncoding;

	private static long pAQstAKDpW;

	public static DateTime PreLogfileTime;

	public static ParamDB paramDB;

	public static MyParamDB myParamDB;

	public static MsgDB msgDB;

	private static Dictionary<int, TriStateTreeView> fh3sSnbImj;

	private static Dictionary<int, TriStateTreeView> lZUs8hPJxV;

	private static Dictionary<int, TriStateTreeView> qQashIWW2e;

	public static EventDB eventDB;

	private static TriStateTreeView Atxs247Fdu;

	public static TransferDB transferDB;

	public static EQDB eqDB;

	private static string n38sNr3MI8;

	public static string[] Conditions;

	public static string[] ConditionsEx;

	public static string[] ConditionsFluctuation;

	public static string[] FluctuationSymbol;

	public static bool ForceNotCheckADBError;

	public static string CSSQLSDKFile;

	private static string AdEslv0TA7;

	[CompilerGenerated]
	private static Form AIZsztcjL0;

	private static UBFunUtils jhJ4fUhdllc5jKnVHWF;

	public static Form MainWin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool IsMainThread
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DialogResult SaveDialog(string filter, ref string savefile, string initDir = "")
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DialogResult OpenDialog(string filter, bool multiSelect, ref string[] openfile, string initDir = "")
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DialogResult OpenDialogEx(string filter, bool multiSelect, ref string[] openfile, ref int filterIdx, string initDir = "")
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DialogResult OpenFileAndFolderDialog(string filter, List<OneKeyStr> openfile, string initDir = "")
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SerializeToJson(object obj)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SerializeToJson(object obj, bool ignoreNull)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T JsonToSerialize<T>(string json)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T JsonToSerialize<T>(string json, ref string sErr)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetJsonErr(string sErr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T FileToSerialize<T>(string jsonFile, bool reMix = true)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T FileToSerializeDefEncoding<T>(string jsonFile)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeToFile(object obj, string jsonFile, bool reMix = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] SerializeToBytes(object obj, bool reMix = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeToFileDefEncoding(object obj, string jsonFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeToXMLFile(string xmlFile, object srcObj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SerializeToXMLStr(object srcObj)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object XMLFileToSerialize(string xmlFile, Type type)
	{
		return null;
	}

	[DllImport("user32.dll")]
	public static extern void LockWindowUpdate(IntPtr handle);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime LongToDateTime(long value)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LongToDateTimeStr(long value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LongToDateTimeStrWithDate(long value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DateTimeToStr(DateTime value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DateTimeToStrWithDate(DateTime value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long DateTimeToLong(DateTime time)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSameSec(long lTime1, long lTime2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T DeepClone<T>(T obj)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object MemCopy(object srcObj, object destObj)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] StructToBytes(object structure)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool StructToBytes(object structure, IntPtr buffer, byte[] bytes)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] FormatterObjectBytes(object obj)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object BytesToStruct(byte[] bytes, Type strcutType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object FormatterByteObject(byte[] buff)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PaintControlBorder(Control ctrl, Graphics graph, int leftLineWidth, int topLineWidth, int rightLineWidth, int bottomLineWidth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PaintControlBorder(Control ctrl, Graphics graph, Color color, int leftLineWidth, int topLineWidth, int rightLineWidth, int bottomLineWidth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLogfileNameWithoutIdx(DateTime dt, bool isDT, bool isTempFile, bool lastSplitChar = true, bool autoAddCQTDT = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetParamThresholdColor(int paramCode, double value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetParamName(int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckAuthOK(int paramCode, IntPtr handle = default(IntPtr), int pointIndex = -1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetParamParentID(int paramCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetParamRootFolder(int paramCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetParamExportScale(int paramCode)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetParamMapClearTimer(int paramCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ParamValueType GetParamValueType(int paramCode)
	{
		return (ParamValueType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetParamLeftClose(int paramCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetParamName(int paramCode, NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<OneThreshold> GetParamThresholds(int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<OneThreshold> GetParamThresholdsDefault(int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReloadMyIEThresholds(int paramCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ThresholdType GetParamThresholdType(int paramCode)
	{
		return (ThresholdType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ParamIsEnum(int paramCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ParamType GetParamType(int paramCode)
	{
		return (ParamType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetParamScale(int paramCode)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetParamScale(int paramCode, NetType netType)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetParaDecimalDigit(int paramCode, NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static OneCAParamRelation GetCAParamRelation(int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double CommonParaShowScale(int paramCode, NetType netType)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static sbyte CommonParaShowDigits(int paramCode, NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetMsgName(int MsgCode, bool notFindShowNull = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetMsgParentID(int msgCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool e6gsGuFNhe(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void VcJsHAZBOs(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TriStateTreeView InitMsgLayer3CategoryTree(int chipID = 0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TriStateTreeView InitMsgL1L2CategoryTree(int chipID = 0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TriStateTreeView InitMsgAllCategoryTree(int orgID = 0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadFromMsgCategoryTree(TreeView tv, int msgType = 0, int chipID = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveToMsgCategoryTree(TriStateTreeView tv, int msgType = 0, int chipID = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEventName(int EventCode, bool notFindShowNull = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetEventAbnormal(int EventCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SetEventAbnormal(int EventCode, bool value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetEventPlayVoice(int EventCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEventPlayWave(int EventCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetEventCoverWin(bool mapShow, bool linechartShow, bool eventwinShow)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetEventCoverInMap(int EventCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEventIconFileInMap(int EventCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEventIconFileInMap(int EventCode, ref int defaultIndex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetEventCoverInLineChart(int EventCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap GetEventIconInLineChart(int EventCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEventIconFileInEventWin(int EventCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetEventCoverInEventWin(int EventCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEventIconStr(int EventCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetEventAutoFilterType(int EventCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetEventConfigs(int coverWin, string icon, bool playVoice, string playWave, int EventCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool t3FswrvV0o(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void accsrn7dFj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TriStateTreeView InitEventCategoryTree()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReloadAllEvents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool JULsf2gvW5(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FixFoldCheckboxs(TriStateTreeView tv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadFromEventCategoryTree(TreeView tv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveToEventCategoryTree(TriStateTreeView tv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long GetTransferKey(int Code, int OrgValue)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetTransferName(int Code, int OrgValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static NetType GetEQMaxNetType(int eqID)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEQName(int eqID)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isDoubleEqual(double d1, double d2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isLongLatEqual(double d1, double d2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isDoubleNoDigits(double d)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DoubleToStrXDigitsOrEnum(int paramKey, double dValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DoubleToStrXDigits(double d, sbyte digits = -1, bool forceIntWhenInt = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string IntToStrHex(int i)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DoubleToStr2Digits(double d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DoubleToStr1Digits(double d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DoubleToStr6Digits(double d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void KillProcess(int pid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ProcessPIDExists(int pid)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void KillProcess(string processName, bool killMulti = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetProcessCount(string processName)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool Ky1sF2ov66(ref DateTime P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint CxismZHn2Q(ulong P_0)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetServerTime(ref DateTime dt)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetNetTime(ref DateTime res)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PingDefaultOK()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PingWebOK(string url = "")
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DoCheckDongleExpire(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DoCheckDongleOfflineTimes(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckDongleExpire()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckDongleOfflineTimes(bool noAddTimes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPropertyGridVisible(object obj, string propertyName, bool visible)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPropertyGridReadOnly(object obj, string propertyName, bool readOnly)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetLength(string str)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int BoolToInt(bool b)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IntToBool(int i)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ParamCodeToPointIdxCode(int paramCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSameTableParam(int paramCode1, int paramCode2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long TryToConvertInt64(string s, long defValue = 0L)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long TryToConvertInt64ByHexStr(string s, long defValue = 0L)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TryToConvertInt32(string s, int defValue = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint TryToConvertUInt32(string s, uint defValue = 0u)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TryToConvertInt32ByHexStr(string s, int defValue = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TryToConvertInt32Auto(string s, int defValue = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ObjectToInt(object obj, int defValue = -1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double TryToConvertDouble(string s, double defValue = 0.0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string UTF8ToString(byte[] bytes)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ToUTF8Bytes(string sSrc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ToUTF8BytesWithZero(string sSrc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string AddFolderEndSymbol(string sFolder)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DelFolderEndSymbol(string sFolder)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetUpperFolder(string sFolder)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLastLevelDir(string sPath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLastLevelDirAndName(string sPath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReMix(byte[] buffer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CheckFileExists(string sFile)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DeleteAndCheckToFileOccupy(string sFile)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetNetTypeName(NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetNetTypeNumberStr(NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetParamViewPath(NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetAnalysisViewPath(NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetModuleID()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BytesToHexStr(byte[] bytes, int iStartIdx, int len)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] HexStrToBytes(string sData)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ynPsdwZMVm(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Stream CompressStream(Stream SourceStream)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ZLibCompressBytes(byte[] SourceByte)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDescription(Enum value, bool nameInstend = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetDescription(ref object obj, string propertyName, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Enum GetEnumValue(string sDesc, Enum defValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDisplayName(Type t, string fieldName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetColumnWidth(Enum value, int defaultWidth = 60)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveFile(string sFile, string sContent, Encoding encoding)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckValueWithConditions(double dValue, int SymbolIndex, double setValue, bool nullDefValue = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckValueWithConditionsEx(double dValue, int SymbolIndex, double setValue, double setValue2, bool nullDefValue = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTimeFormat(string sTime)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsNumber(string value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsIP(string ip, bool mustBeIP = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MeasureStrWidth(Label lbl, int moreSize = 10)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateRecentStr(string sStr, List<string> list, int maxCount = 20)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TreeNode FindNodeDown(TreeNode curNode, string s, bool findParent = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TreeNode FindChildNodeDown(TreeNode curNode, string s)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindFilterNodeDown(TreeView treeView, TreeNode curNode, string s, bool findParent = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindFilterChildNodeDown(TreeView treeView, TreeNode curNode, string s)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindFilterNodeExDown(TreeList treeView, TreeListNode curNode, string s, bool findParent = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindFilterChildNodeExDown(TreeList treeView, TreeListNode curNode, string s)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindFilterNodeExUp(TreeList treeView, TreeListNode curNode, string s, bool findParent = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FindFilterChildNodeExUp(TreeList treeView, TreeListNode curNode, string s)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetRegisterIntValue(string fieldName, string pathKey, int defValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetRegisterIntValue(string fieldName, string pathKey, object newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CapturePicByForm(Form form, Point point, Size size, string sFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DoubleBufferedDataGirdView(DataGridView dgv, bool flag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetScreeenWidth()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetWinLocationLeft(int baseLeft, int baseWidth, int winWidth)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SleepAndDoEvents(int millisecondsTimeout)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static bool RunCmd(string cmdStr, int needWait, int waitTimeoutMS)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static string RunCmdList(List<string> cmdlist)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static bool RunCmdEx(string cmdExe, string cmdStr, int waitTimeoutMS)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static string RunCmdWithResult(string cmdStr, int waitTimeoutMS)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int BinarySearchLessEqual(List<int> list, int low, int high, int findPointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int BinarySearchNearEqual(List<int> list, int low, int high, int findPointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckFileNameOK(string sFile)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ChipType GetChipType(int EQID)
	{
		return (ChipType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetAPKFullFileName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ParseVersion(string ver, ref int iVer1, ref int iVer2, ref int iVer3, ref int iVer4, ref int iVer5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetAPKThirdVersion(string apkName)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CompareAllFields(object obj1, object obj2, Type type)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool OalsEiUYX1(Type P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsADBStrError(string sADB)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static string GetUEManagerGUID(string adbSerial, int valueIndex, int timeout = 1000)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int AutoMatchMTCIdx(int mocIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddFolderFilesToList(string path, string ext, List<string> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Get4SectionVersion(string s)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetThirdVer(string sVersion)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DownloadSQLSDK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DownloadHighSpeedRailDB()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsVirtualParamKey(int paramKey)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CaptureImage(IntPtr hWnd, string sFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string sizeToStr(double size)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetScaleX()
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string HexHighLowConvert(string strValue, int bitSize)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ExportCSVByListView(string exportFileName, ObjectListView lvItem)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetMD5HashString(string source)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetMD5HashFromFile(string fileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetMD5HashFromFile16(string fileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CheckModifyFileName(string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetInternetIP()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLocalIp()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> GetLocalIpList()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] IntPtrStringToBytes(IntPtr ptr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] IntPtrStringToBytes(IntPtr ptr, int size)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MinimizeAppication(string processName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public static List<string> GetADBDevicesList()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PortInUse(int port)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetEnvironmentPath(params string[] Paths)
	{
	}

	[DllImport("shell32.dll", EntryPoint = "ShellExecute")]
	private static extern IntPtr aSgs5G1sb4(IntPtr P_0, string P_1, string P_2, string P_3, string P_4, int P_5);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RunExe(string path, bool hide, string sParam = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DebugFileAddDate(string fileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DebugFileUIException()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DebugFileDeviceWinInfo()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DebugFileAutoConfigEQ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeleteFile(string sFile, bool bShowErr = true, string showErrStr = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetAfterScaleSize(int orgSize)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr BytesToIntPtr(byte[] array, int index)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] IntPtrToBytes(IntPtr intPtr, int len)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasServerPID(int pid, bool useSparkServer)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap ResizeImage(Bitmap sourceBitmap, int newWidth, int newHeight)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ResizeImage(string sourcePath, int newWidth, int newHeight, string newPath)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UBFunUtils()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UBFunUtils()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 35;
		string[] array4 = default(string[]);
		string[] array2 = default(string[]);
		DateTime maxValue = default(DateTime);
		string[] array3 = default(string[]);
		string[] array = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					array4[1] = (string)SbHIE0hK9RrlSHbVNcH(32426);
					num2 = 41;
					continue;
				case 31:
					array2[0] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(31440);
					num2 = 7;
					continue;
				case 45:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num = 11;
					break;
				case 12:
					lZUs8hPJxV = new Dictionary<int, TriStateTreeView>();
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					continue;
				case 13:
					return;
				case 37:
					pAQstAKDpW = HP5TN65OLmUM3yQ4UBu.QnSQxwQdI(ref maxValue, HP5TN65OLmUM3yQ4UBu.kXb5WKRkeT);
					num2 = 3;
					continue;
				case 39:
					array3[1] = (string)SbHIE0hK9RrlSHbVNcH(32356);
					num2 = 47;
					continue;
				case 27:
					UTF8WithoutBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
					num2 = 26;
					continue;
				case 15:
					array = new string[10];
					num2 = 44;
					continue;
				case 5:
					CSSQLSDKFile = ls0JmaLsLk7suNXwaC.QnSQxwQdI((string)g4YsXqBBrcvMk81SHmQ(ConstUtils.SparkPath), (string)SbHIE0hK9RrlSHbVNcH(31614), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 23;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					array[3] = (string)SbHIE0hK9RrlSHbVNcH(32370);
					num = 38;
					break;
				case 24:
					array[6] = (string)SbHIE0hK9RrlSHbVNcH(32386);
					num2 = 5;
					if (true)
					{
						num2 = 9;
					}
					continue;
				case 9:
					array[7] = (string)SbHIE0hK9RrlSHbVNcH(32396);
					num2 = 29;
					if (true)
					{
						continue;
					}
					break;
				case 41:
					FluctuationSymbol = array4;
					num2 = 14;
					continue;
				case 23:
					AdEslv0TA7 = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstUtils.ResTempPath, (string)SbHIE0hK9RrlSHbVNcH(20716), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 13;
					continue;
				case 7:
					array2[1] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(32356);
					num2 = 20;
					continue;
				case 29:
					array[8] = (string)SbHIE0hK9RrlSHbVNcH(32406);
					num2 = 8;
					if (false)
					{
						num2 = 0;
					}
					continue;
				case 34:
					W7xt7nB995qU2Hptcud();
					num2 = 45;
					continue;
				case 11:
					kQwS93BhCa8rwjS34Py();
					num = 17;
					break;
				case 43:
					array4 = new string[2];
					num2 = 22;
					if (true)
					{
						continue;
					}
					break;
				case 8:
					array[9] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(32416);
					num2 = 32;
					continue;
				case 28:
					Conditions = array3;
					num2 = 15;
					continue;
				case 3:
					PreLogfileTime = qR00NLEJ6oImw9nAws.QnSQxwQdI(qR00NLEJ6oImw9nAws.XJSdPlJUZ);
					num2 = 10;
					if (true)
					{
						continue;
					}
					break;
				case 22:
					array4[0] = (string)SbHIE0hK9RrlSHbVNcH(26598);
					num2 = 19;
					if (true)
					{
						continue;
					}
					break;
				case 30:
					array3 = new string[6];
					num = 40;
					break;
				case 21:
					array[1] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(32356);
					num2 = 48;
					if (true)
					{
						continue;
					}
					break;
				case 32:
					ConditionsEx = array;
					num = 6;
					break;
				case 17:
					mainThreadId = MIULgW0YS4r6G307CJa.QnSQxwQdI(fIU4hf2ICAossc0JRmU.QnSQxwQdI(fIU4hf2ICAossc0JRmU.Hxu2vKVKx7), MIULgW0YS4r6G307CJa.e5m2A2iQZK);
					num2 = 1;
					if (1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					array2[2] = (string)SbHIE0hK9RrlSHbVNcH(32370);
					num2 = 42;
					continue;
				case 10:
					fh3sSnbImj = new Dictionary<int, TriStateTreeView>();
					num2 = 12;
					continue;
				case 40:
					array3[0] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(31440);
					num2 = 39;
					continue;
				case 14:
					ForceNotCheckADBError = false;
					num2 = 5;
					continue;
				case 47:
					array3[2] = (string)SbHIE0hK9RrlSHbVNcH(32364);
					num2 = 36;
					continue;
				case 38:
					array[4] = (string)SbHIE0hK9RrlSHbVNcH(31446);
					num = 33;
					break;
				case 35:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 34;
					if (true)
					{
						continue;
					}
					break;
				case 26:
					UnicodeEncoding = new UnicodeEncoding();
					num2 = 2;
					if (true)
					{
						continue;
					}
					break;
				case 42:
					array2[3] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(31446);
					num2 = 46;
					continue;
				case 16:
					array3[4] = (string)SbHIE0hK9RrlSHbVNcH(31446);
					num2 = 25;
					continue;
				case 18:
					n38sNr3MI8 = (string)SbHIE0hK9RrlSHbVNcH(32178);
					num2 = 30;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					DefEncoding = at5TI5YzjA1SX68MLfZ.QnSQxwQdI((string)SbHIE0hK9RrlSHbVNcH(9474), at5TI5YzjA1SX68MLfZ.rU0sVmxp6y);
					num2 = 27;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 44:
					array[0] = (string)SbHIE0hK9RrlSHbVNcH(31440);
					num2 = 21;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 48:
					array[2] = (string)SbHIE0hK9RrlSHbVNcH(32364);
					num2 = 4;
					continue;
				case 36:
					array3[3] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(32370);
					num2 = 16;
					continue;
				default:
					qQashIWW2e = new Dictionary<int, TriStateTreeView>();
					num2 = 18;
					if (true)
					{
						continue;
					}
					break;
				case 25:
					array3[5] = b99vLwQv4vNmPibnHM.iaWRZZUjVH(32378);
					num2 = 28;
					if (1 == 0)
					{
						num2 = 16;
					}
					continue;
				case 46:
					ConditionsFluctuation = array2;
					num2 = 43;
					continue;
				case 6:
					array2 = new string[4];
					num2 = 31;
					continue;
				case 33:
					array[5] = (string)SbHIE0hK9RrlSHbVNcH(32378);
					num2 = 24;
					continue;
				case 2:
					maxValue = DateTime.MaxValue;
					num2 = 37;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qqj3VkhovUQlYeeH7ib()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UBFunUtils wyvrUXhiQhXemuf7mB6()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WoIpJGhrVkX86deoMVm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SbHIE0hK9RrlSHbVNcH(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CEIGt1hnQq5lTD8JXIO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime SE8hhLhWNvRJtQXOw2b(long value)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long G4BRJmhjZRS4GaKuOd7(DateTime time)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KOMmAdhMxgSBKpfMLkO(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B0xekZhY5lxJR49dbs9(object P_0, Type strcutType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N84oeKhgWb5g2uN0LKj(object P_0, object P_1, Color color, int leftLineWidth, int topLineWidth, int rightLineWidth, int bottomLineWidth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ParamType cCfiJmhH73PTPPMlxaV(int paramCode)
	{
		return (ParamType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nHCE7ZhScPjgDNPXCrK(int paramCode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fTmwkShDCYPNHCXnIDH(object P_0, int paramCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double BSYAivhR4ur6iCF1nVM(int paramCode, NetType netType)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static sbyte iAf6lQhmujH99Cg62Vt(int paramCode, NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double g8gPKkhUrilGH1i00R7(int paramCode)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mUQ7Huh50C5LKRsrl5O(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A21XEghNNq2ny6bqo6O(object P_0, int folderID)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CEykL5hqeUZMxQ0SWkA(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uBuaCrhPC4UlAmBWRRM(bool b)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pC9tE5h0DLutFGD4Abj(object P_0, int value, int EventCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GKsuRBhuBhtb1dt8LxX(object P_0, int coverWin, object P_2, bool playVoice, object P_4, int EventCode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yaoEE1hlhHXSHfPFYBR(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xrbqeuhVONDQdxQte5a()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EBvcYEhXRllKOSW4M97(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C8dJoqhwIg8RLDZY4rT()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VZbdEWhetpotPf7dX9d(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CZ7WPxh8UZsD9aovxAt(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GBJ7PPhsBowMvqwRmbI(int Code, int OrgValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Uw3TnKh1SZa9r9JB06i(double d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A3Yb2FhzpugbOslDjvZ(double d)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint O4o8MFBO9ffCUTZsodv(ulong P_0)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IyMa7KBJm54NoqRLAKt(NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PjwWMjB258H3QeeXDI6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tTQkIVByrFj8Rabjg2o(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sw6DFOBEsHIjh8MZZdj(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KWIG8RBcWQrkx1Gmj2T(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xW33qEBbXGTNDb7dCq2(object P_0, object P_1, object P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iE7HNwBQhDeimyHvFJi(object P_0, object P_1, object P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NbXTdrBfsv8vj4nOC0L(object P_0, object P_1, object P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rlsj0FBt7KJ1yRTacdp()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EYLDvcB6eous0OIX5Gt(Type P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QhZLGbBktpDcY8WTprA(object P_0, object P_1, Type type)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OTQZygBp1CmK7kMMHPg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W1J0FYB4DT8XnXL8hPg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cNXkbmBT2hP72oK46Qt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yIikJ7BA7oNt0wC7Ubu(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object riBWftBvLNRjNTVqwO6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WN8e2TBa5BwiWVMhZBE(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rFxsl5BG4MOx2wd7iq3(int pid)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W7xt7nB995qU2Hptcud()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kQwS93BhCa8rwjS34Py()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g4YsXqBBrcvMk81SHmQ(object P_0)
	{
		return null;
	}
}
