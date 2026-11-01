using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using LibCoord.ReportForms;
using LibUtils;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class Logfile : LogfileUtils
{
	[JsonIgnore]
	public bool IsRedecoding;

	[JsonIgnore]
	public LogfileAdmin Owner;

	[JsonIgnore]
	private int dRvnW2eHYlH;

	[JsonIgnore]
	private int fXinWOdrpTv;

	[JsonIgnore]
	public EQObj EQInTest;

	[JsonIgnore]
	public int PreIDTmp;

	[JsonIgnore]
	public int PreID2Tmp;

	[JsonIgnore]
	public List<OneCustomParam> CustomParamList;

	[JsonIgnore]
	public List<OneCustomEvent> CustomEventList;

	[NonSerialized]
	public OneBin CurBin;

	[NonSerialized]
	public Dictionary<OneBin, Logfile> BinFiles;

	[NonSerialized]
	public Dictionary<OneFilter, Logfile> FilterFiles;

	public int ChinaProvider;

	private int ELdnWMBHmWy;

	[JsonIgnore]
	public NetType EQNetType;

	private NetType laHnW5ZDujh;

	private NetType yRSnWTC9nHA;

	private bool VF7nWxvSH46;

	private MsgDetailUtils R6rnWqoFxJf;

	private int MkRnWAxWwK7;

	private List<OneCECumulativeStartObj> UQKnWYFZRXf;

	private IntPtr yKbnWHOWrGb;

	private InsertDataObject c8MnW3HO9Yq;

	[CompilerGenerated]
	private static Comparison<StatThresholdResult> WxdnWJ94vK8;

	[CompilerGenerated]
	private static Predicate<OneIndoorMark> u3AnWrXmLtH;

	internal static Logfile NeStLUJ8l4jX3KTy6dYw;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile(string sFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCloseDB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleWriteToReadMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsScannerLog()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLastPointIndex()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetVarValue(int paramKey, int rowIdx, int netTypePointIdx, ref int trueFlag, bool isExportScale = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetVarValueInTest(int paramKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetVarValueByValue(int paramKey, double dValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetVarValueByValueEx(int paramKey, double dValue, NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetStringUTF8Value(int paramKey, int pointIdx, ref int trueFlag)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetStringUTF8Value(int paramKey, int pointIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntPtr GetLastStringValue(int paramKey, ref int iLen)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string CNjnWRcc4Y9(int P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTagContent(int pointIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint GetMsgCode(int iPointIdx)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetModuleID()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetModuleIDHigh()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSoftwareVersion()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMNC()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEQIdx(int idx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEQIdx()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEQID()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetType GetNetType(int iPointIdx)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetType GetLastNetType()
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetLastHasNR5GActive()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetLastHasRedCap()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetType GetLogfileNetType()
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasNR5GNetwork()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckLogfileAuth()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckRafAuth()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckNR5GNetworkAuth(ref string sNet)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckAreaAuth(ref string sErr)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckSafAuth(ref string sDesc)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckDecryptKey(ref string sDesc)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetType GetCurNetTypeIncludeScanner(int iPointIdx)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetType GetLogfileNetTypeIncludeScanner()
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetType GetLogfileScannerNetType()
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLogfileDefaultParamKey(int paramKey = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool NwYnWnQxSsJ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FinishWrite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoStaticticsThreshold(int paramCode, StatParamResult ret, List<Logfile> Logfiles, bool EventBeforeAfterMeasMode = false, int EventBeforePointIdx = 0, int EventAfterPointIdx = 0, string StartTimeCondition = "", string StopTimeCondition = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile OpenBin(OneBin one, string binFileName = "", int mainKey = -16777215, bool forceDo = false, bool calcFields = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile OpenFilter(OneFilter one, bool calcFields = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile OpenFilter(string filterbuffer)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteSiteInfo(string sSiteFile, NetType netType, WriteSiteAnaType anaType = WriteSiteAnaType.atNormal)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteSiteInfoByNetType(NetType netType, WriteSiteAnaType anaType = WriteSiteAnaType.atNormal)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void x54nWglGu5R(NetType P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteSiteDistance(string sSiteFile, NetType netType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ckinWeWHnCi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteIndoorInterpolation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckLaserRadarLogfile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sIQnWPk1BWW(double P_0, double P_1, ref double P_2, ref double P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FqSnWEIKqoR(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SiynWyjalr0(string P_0, int P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSaveIndoorImage(int floorIndex, bool oldType, int curLogfileFloorCount)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCustomEventParamOK(ExpressionRow row, int pointIdx, bool nullDefValue = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitCustomEventVars()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kslnWcMgyhF(int P_0, int P_1, long P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mrEnWLX24pJ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mhpnWv4idK6(OneCustomEvent P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cXnnWs7dpi4(OneCustomEvent P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool hxynW6RdTeo(OneCustomEvent P_0, CERangeConditions P_1, long P_2, int P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool LJ4nWhMLeHu(CEParamConditions P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void v0PnW1xZDCc(OneCustomEvent P_0, int P_1 = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aolnWdMoyTj(OneCustomEvent P_0, int P_1, NetType P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oUWnWWfY21k(OneCustomEvent P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gDjnW4uPUIV(OneCustomEvent P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int EventCountBetweenPoints(int eventCode, int pointIdx1, int pointIdx2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int EventFirstPointIndexBetweenPoints(int eventCode, int pointIdx1, int pointIdx2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Eg8nWN9kB6k(OneCustomEvent P_0, int P_1 = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoBuildCustomEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void c1mnWixCFge(OneCustomParam P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dPEnWFHwS1r(OneCustomParam P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetCustomParamMsgDetailValueByPath(MsgDetailUtils msgDetailUtils, int pointIdx, string sName, MsgDetailPathSet pathSet, List<string> resultList)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCustomParamMsgDetailValue(MsgDetailUtils msgDetailUtils, int pointIdx, int msgCode, string sName, bool hasChild = false, List<OneKeyStr> layerNodes = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GR5nWbhsdYD(OneCustomParam P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoBuildCustomParam(bool clearData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuildCustomParam()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuildCustomEvent(bool isIntelligentEvent = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetStatWithScale(int paramKey, string condition, string aggType, bool useScale = true)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double GetStatisticByLogfiles(List<Logfile> logfiles, int paramKey, string conditions, string aggType, bool useScale = true)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoEARFCN(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoEARFCN_Scanner(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoPCI(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoPCI_Scanner(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoCellID(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoeNodeBID(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoSectorID(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoID(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoPointIdx(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetStaticAutoKeyMeasInfoRSRP(NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoRSRP(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoRSRP_Scanner(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetStaticAutoKeyMeasInfoSINR(NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoSINR(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoSINR_Scanner(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyServingEARFCN(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyServingPCI(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyServingTAC(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyServingPointIdx(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyServingCellID(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyServingMNC(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyNeighbor0EARFCN(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyNeighbor0PCI(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyNeighbor0RSRP(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoMAC_DLThr(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyMeasInfoMAC_ULThr(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetAutoKeyBLER(NetType netType = NetType.NullValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile GetLogfileByUEStr(string ueStr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSameNameLogfiles(ref List<string> list, bool filterSelfPort = true)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetOperatorIDByMCC_MNC(int mcc, int mnc)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLogfileOperatorID()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetLogfileOperatorID(int id)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double SqlGetDoubleValue(string sql)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetOfflineDistance()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Logfile PointFilter(List<PointRange> ranges, int type)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasTask(TaskType tt)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetTaskStr()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEventCountByRange(int eventCode, int pointIdx1, int pointIdx2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetStatByRange(int paramCode, string statType, int pointIdx1, int pointIdx2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasL1L2L3Msgs(long dt1, long dt2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetUETimeSpan(int pointIdx1, int pointIdx2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static int gLhnWVOhTGF(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static bool LbanWXSyVCe(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Logfile()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		q5tNWqJ4nrO4Mq0YVhxw();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HULn7WJ81iqmoXjBs3r0()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C045PPJ8v8BUAYb6JdwL()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SqD2m9J894DbHP0r0wC0()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Logfile J6exARJ8kp31uu5Lvvqy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jb1Mr9J8SSN95USaH8P5(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Chb2I5J8mU3fGmu6O8hO(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x8hltoJ8IBM09KIkrPP4(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ycfPuGJ8XGmpQ7HHjpyO(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OlrNYaJ8UgocbBaaoXj4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void upmdIGJ8Ol9KI96SDZmW(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ljbdqrJ85fUaJPG3F05N(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c71qYhJ8i8xqOXMK2kks(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr BxCbwdJ8zMTOHgxJ5tWt(object P_0, uint P_1)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IpGOwtJwLgsqQfik4gwn(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DjaQRvJwNbRuIjBybNQn(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AcKOPKJwYobfyRiNYOWq(object P_0, bool P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aVhWEkJwuyD1p2kFDEwA(double P_0, sbyte P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OU6LC7Jwy7bleCTwNXgu(int P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double oqhEHbJw6uor8frjnWXJ(int P_0, NetType P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CiJJwAJw2mKLaYthqSae(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IV8spyJwJQIrTIOnMWc3(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n8HsRyJwMUpJrx6Tg9Uy(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ParamType XB7rHKJwKkyyuMhas5Kh(int P_0)
	{
		return (ParamType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double UJcpTlJwZKJmFwNr42pZ(object P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static sbyte w7rwjyJwoCLSvrurFPFI(int P_0, NetType P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r8WBEUJwxdvgl4JAaeeZ(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WeZ63MJwA72BvbLn3sPv(IntPtr P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aQhcvLJwtgiFMojigYuy(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan mtmHwvJwWAqm3lgjK96V(object P_0)
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ypdBCsJwB41B0ofTCbXg(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GIltvsJwqKxPonipUFeU(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Ty9ZW0JwE94ax8dEgNDG(object P_0, int P_1, object P_2, object P_3)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BNPIPPJwV8ud7pnEiXme()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr AYjhVyJwTLPgo9DyqkM9(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double IRfxWcJwpZmdqDIm25xr(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zceWprJwQRkQJ41jVYUk(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GMK22RJwRHlND1dAP2R0(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint hj18CbJwGfrunQxjIjYK(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double c7gqNIJw3IT0D6ZKeglK(object P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int l7HnmVJwFH2XjQCMMUqx(object P_0, int P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z7bH4LJw7O9WmZm2uw3Z(object P_0, int P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint aQITyXJwbZtVV3ebKHO0(IntPtr P_0, int P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jsZcDjJwgmo3aDrO6NHe(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kPbfEQJwf36QKmBSrSiK(object P_0, int P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JDH3bjJwjegAsA1g895I(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FileInfoLogFormatType GNPENqJweQWwFDZv1MYh(object P_0)
	{
		return (FileInfoLogFormatType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YgZBCvJw0DTX7dTxVJMA()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vWLVgSJwPLsxPi9YxxWd(IntPtr P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EWNkqRJwcddpZXKxF4ux(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vv0EUCJw8r1Vx5PXhvjj(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bbRTbgJww8FHcMSg4Dct(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HlSsCoJwhq0DNqNdxhrA(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WgEDQUJw4mPAY0TSlxwF(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr xnL9bRJwrNKb64UVpm3Q(object P_0, object P_1)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FDC6xeJwDN5SaYs1BqPb(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object idhS82JwdLc6ExLx7USJ(object P_0, IntPtr P_1, int P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h64DTtJwCbZdGulhfcOd(object P_0, IntPtr P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kHg8M3JwnJJilXVOqFen(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VhB7lpJwaXUoXbAvqjB7(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wXaEDkJwHirladxK122V()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DoP4t8Jws4FDRvo3meVQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gG09VbJwlkTJM9hZB6C6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yQjpjKJw9F1vSZIh7tEs()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tJag8JJwkX849ByEIll1(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xNExBjJw1eXdkVJbT4xy()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nD5jg8JwvEgujwVkOyfX(object P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mA6muyJwS8MENSCNYAvr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KPWub4JwmGcvadRG27QT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QXS0xHJwItVRq0AyrkbR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hew76tJwXxnaT6np5LeC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VoePqaJwUC0tyHhD2p0j(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr JUGAVSJwObvDUnr7Xk7b(IntPtr P_0, int P_1, object P_2, object P_3)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V9QFG4Jw58OAPNcqF8rW(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SG5cxfJwim6kIVcCvNUb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zgumcTJwz2LjkvVppgJ6(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vm28h2JhL9dN0eWGw3O4(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OKmwIlJhNGn9HnM0hhiJ(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double k4nQLPJhYkBg4kwdcOmD(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vOL2orJhuk2yT3XAUXEK(object P_0, IntPtr P_1, int P_2, double P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double xtcSLtJhy3rflIsQj9Lg(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int crYRAnJh6weoqcWr4mk4(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MiUhoUJh2cPeKF2Tn839(object P_0, IntPtr P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int m85osAJhJZxeLT0qCdJD(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VGBofhJhMSW9N3FBOc5I(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UsPCgPJhKFcwKQAUCf4c(object P_0, IntPtr P_1, int P_2, object P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IxUe36JhZ1xiK1Qkddtr(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long SWlZN2JhogMtg4xBmu5o(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sDHhOGJhxCEHViN6c2qN(object P_0, IntPtr P_1, int P_2, long P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VL9nwAJhAcAi7LCYgoGr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double bSiQoHJhtyQlppKNXdIP(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wxCpfRJhWIFWdCghFjWK(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vFYZoUJhBgXaM3KYEyW4(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double WRkBaWJhqpriLbZFCEQ7(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double x7CyKJJhE5FY0gMdRpm0(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b8gcBZJhVxdoJ0U2oQ5A(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RWcxu1JhTi0UowCTm0jQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OXhQC4JhppVTk5Uk50Iv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tbatskJhQX6GWdBmfET1(object P_0, IntPtr P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fRu2QaJhRLjVV6GRnITf(object P_0, IntPtr P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qUL3UMJhGu8t5FiTqMlO(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N5AZFCJh3YDokmFvZJ52(NetType netType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mTaROfJhFfxiTlqS0agD(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BeCISIJh76Bace3FUBGJ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CaGmE0JhbCC1BymGiRGu(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long Qtu8XQJhgsDp1arwtwXn(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wAvO9cJhfnRPdP8ftgrV(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yggGGAJhjvrBvpv7ni1y(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size c72JKWJhekIVks3NtR86(object P_0)
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fErkGaJh05W5wx8mHkc7(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jXdsq5JhPY4QTss41FsV(object P_0, int P_1, double P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iMCTF7JhcT4qmqmEVebx(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr LsVDfwJh8offpVeJyrHh(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int a6X1coJhwpZNvANPPLBt(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e7ImExJhhtKt3lgCcbK9(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OMMEC6Jh475o4cZtKCwS(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DHt75CJhrqB86wcwti2Q(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WClS9vJhDC1e68dTBqfo(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double husjFkJhdyITaGGInB2n(IntPtr P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zyfES6JhCOqlX3r0uSl0(double P_0, int P_1, double P_2, double P_3, bool P_4)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yadAknJhnmZeVd4u2158(double P_0, int P_1, double P_2, bool P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AqWXg3JhaoWenq1iJeF1(object P_0, int eventType, int pointIdx, long lTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l8PldJJhH1NAbog8Xvxu(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mK9FKXJhsbvwhmSC5oGr(object P_0, int P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bju2sSJhlhvDLpyooNKl(object P_0, int P_1, long P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RPQiDGJh9BcyjpJYpH2l(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr e80Q5AJhkQctokZDmSYC(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KOh5WyJh1MwToM6sSAHF(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i2dXY1JhvdFyxh9pee2I(IntPtr P_0, int P_1, int P_2, IntPtr P_3, int P_4)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hXFaEyJhSCHB6pqYpmTi(IntPtr P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XZ54GNJhmky0CCqqth7a(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wQ1xoIJhI7VcqldKZjGB(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A9cZxoJhX6xesBGCDOlK(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double HvU7HdJhUlkAigy3XZ7A(double P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SmpXttJhOq1kyHwCM0HZ(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wmUrldJh5sNwNTGRkJA9(object P_0, long P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AsFSJ8JhiwD2nGCVqTFC(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o06GbvJhzTZslCnPoQxX(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int HuSAIaJ4LSu9BRLsboCI(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sYmboyJ4NG3MgvKoJvok(object P_0, IntPtr P_1, int P_2, object P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long vtEGHcJ4Y9x2GJC6Muqj(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long Li3CyDJ4uFn369EiSiIt(object P_0, int P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yvbH47J4yEKCBZZ8kwD9(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JoGd6bJ46gpmjZ4UXBUI(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aQ7gCkJ42sUG7mQM8ewA(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YDw2GqJ4JI2chOVmnv6t(object P_0, double dValue)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ExJlkQJ4MMFCuUBhR1Zd(object P_0, double dValue)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jQiQniJ4KXhIUaM2p6v4(double curDuration, CEStatusTimeSymbol symbol, double setDuration)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nVbpRLJ4ZS5WysaRU3vU(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hE4hNoJ4o5XaAnHyI23R(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr JJjMUaJ4xAKBlS4UotDO(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dnTfWPJ4Ack7i7pfKQwu(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nAhyq6J4tcsAkDm7sTQE(IntPtr P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr oICTCrJ4WnrYgy3NXasd(object P_0, int P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double JrOT8AJ4BHl18rNmTTim(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double iMymimJ4qpjQXJxdQ5xp(object P_0, int P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sMPT3xJ4EcdyKMNJGAje(object P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint NPpJMUJ4VOPd2iEbQNlB(object P_0, IntPtr P_1)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ll9X9KJ4TF4FZRFJXntM(object P_0, int P_1, float P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wjYdcAJ4pQtWQ5ujo44H(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JR5YXlJ4Q0YLVabNa8YG(object P_0, int P_1, object P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IpwyHnJ4RKdyUeb7t1Cd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zpTdFqJ4Gp2lA0BMdd8c(object P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wHHRIBJ43oX4KCsKBWoC(int P_0, NetType P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ecKLjWJ4FKWsEjD34sGB(NetType netType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ONFQ7TJ47rpAR8e1dlkn(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PomL0nJ4b88LKfUaqEnb(object P_0, object P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jUxt4hJ4gjuctixjaN3L(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bIN9bFJ4ft55Cu616HWt(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zjQUwUJ4jsYN2AAkO622(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Iql2haJ4ewFHXy7RDMA8(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xet6JIJ40fIGLtMnwQUb(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DbImVCJ4PsosYJsymx28(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int acwTT9J4c7QNbrijYX2H(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IipRMAJ48wJyCedYqpcB(object P_0, int P_1, int P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Tf3pByJ4wiFXPVneFL8A(object P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kj2e1bJ4hlsDhbRPZroa(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QhsqpbJ44kvOIV3jwFy8(TaskType tt)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vCB1C0J4rOwHKhB7421V()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xDvshcJ4DYoQ8iPnvP0b(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime plKiHHJ4dmjKjDBHuLEp(object P_0, int P_1)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan Jx5GvpJ4CsMf5IS6XGFf(DateTime P_0, DateTime P_1)
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q5tNWqJ4nrO4Mq0YVhxw()
	{
	}
}
