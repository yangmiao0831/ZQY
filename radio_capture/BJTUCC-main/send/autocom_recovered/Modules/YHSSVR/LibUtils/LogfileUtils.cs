using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Newtonsoft.Json;
using P8RhegOFKTh50li8vF;

namespace LibUtils;

[Serializable]
public class LogfileUtils
{
	private List<string> fxfu4Aw5S;

	private List<string> OTYWIImhN;

	private List<string> kPJbQDsHP;

	private DataTable Uc8APCeYR;

	public LogfileType LogfileType;

	public LogfileUtils OwnerLogfile;

	private string daeKeBIJM;

	[JsonIgnore]
	public int CurrPointIdx;

	[NonSerialized]
	public string FileName;

	[NonSerialized]
	public bool IsConnecting;

	protected IntPtr dbHandle;

	protected bool HasSetBinParamType;

	protected uint dbOpenMode;

	private int fZacfdkmH;

	private bool EPqJpIoJV;

	private TimeSpan wjjgggfqY;

	internal static LogfileUtils S2n048oCKr97gmpPeC;

	public string FullFileName
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
	public IntPtr GetHandle()
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void OpenDB(bool forceOpen = false, bool withoutRef = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseDB(bool forceClose = false, bool withoutRef = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool i6hiIBe8S()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FinishWrite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCloseDB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReOpenDB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReOpenDB(uint openMode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint GetOpenMode()
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TimeSpan GetLogfileTimeSpan()
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeSpan(int pointIdx1, int pointIdx2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetTimeSpanSecs(int pointIdx1, int pointIdx2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLogfileTotalDistance()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetIntValue(int paramKey, int pointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetIntValue(int paramKey, int pointIdx, ref int trueFlag)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long GetInt64Value(int paramKey, int pointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long GetInt64Value(int paramKey, int pointIdx, ref int trueFlag)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetDoubleValue(int paramKey, int pointIdx)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetDoubleValue(int paramKey, int pointIdx, ref int trueFlag)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetLastDoubleValue(int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLastStringValue(int paramKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetInheritedValuePointIdx(int paramKey, int pointIndex)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntPtr GetStringValue(int paramKey, int pointIdx, ref int length)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntPtr GetStringValue(int paramKey, int pointIdx, ref int length, ref int trueFlag)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetBinBuff(int paramKey, int pointIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetAllInOneValue(int paramKey, int orderParamKey, bool trueFlag, int pointIdxKey, int pointIdx, int orderIdx, int subParamKey, params int[] subParamValues)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double[] GetAllInOneValues(int paramKey, int orderParamKey, bool trueFlag, int pointIdxKey, int pointIdx, int prePointIdx, int count, int subParamKey, params int[] subParamValues)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPointNumber()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPointNumberByParamCode(int paramCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetGPSPointNumber()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetIndoorMarkPointNumber()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetGPSValue(int iPointIdx, ref double dlong, ref double dlat)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetGPSValidRange(ref double maxLon, ref double minLon, ref double maxLat, ref double minLat)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool GetExactPointIdxByPointIdx(int pointIdxKey, int pointIdx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetNearPointIdxByPointIdx(int pointIdxKey, int pointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public virtual int GetNearPointIdxByTime(long lTime)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeZone()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual long GetDateTimeLong(int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual long GetUEDateTimeLong(int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long GetMsgTime(int paramCode, int ID)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long GetEventTime(int iEventIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime GetDateTime(int iPointIdx)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime GetUEDateTime(int iPointIdx)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDateTimeStr(int iPointIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetUEDateTimeStr(int iPointIdx, bool showDate = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDateTimeStrWithDate(int iPointIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEventTimeStr(int iEventIdx, bool showDate)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DeleteData(int paramKey)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DeleteCustomParamTable(int paramKey)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetDuration(int paramKey, int valType, string conditions)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetStatistic(int paramKey, string conditions, string aggType)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBinLogfile()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public IntPtr PrepareRead(int paramKey, string conditions)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool PrepareConfig(IntPtr handle, int key, string value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool PrepareNext(IntPtr handle)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public double PrepareValue(IntPtr handle, int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public long PrepareInt64Value(IntPtr handle, int paramKey)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public string PrepareTextValue(IntPtr handle, int paramKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public string PrepareTextUTF8Value(IntPtr handle, int paramKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public uint UnPrepareRead(IntPtr handle)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public double GetScalarDouble(int paramKey, string conditions)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public string GetScalarString(int paramKey, string conditions)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool ExecuteSQL(string sql)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void CheckField(int paramKey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public uint WriteUtsData(IntPtr buffer, int length)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public int CaculateVirtualData(int tableID)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public int GetRowID(int paramKey, int index)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void DeleteSiteTable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSiteNeighborTable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogfileUtils()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LogfileUtils()
	{
		Seo3omgfrcFXY10d00.AvviRHPjVq();
		HExfcsUN24PmHbDqqu();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F4mHOX5Mc83yR4CPYQ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LogfileUtils oYk0URdmxM8suxTcaJ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Oil1gLb08b0JFH3fU7(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iiY6w5koD3Ngt4NBnc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WQtUqkKS9Ew6yUxHcs(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double GTKNwflISQ59vHqrgx(IntPtr handle, int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z2F8W09JIHwh1BSFUL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QH9FmnOGwbDe1APoc8(object P_0, int pointIdxKey, int pointIdx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jFyJTeXLZEXbdduvOT(object P_0, int pointIdxKey, int pointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MDro71ZOA7qqX5fm3X(IntPtr handle)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int O98vV16AFRrfBKvacG(IntPtr handle, int paramCode)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long kDPeFKSVxR87bbociN(IntPtr handle, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long XgQrnk2qCuILi2K08X(IntPtr handle, int iEventIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long Ns880UjsUAZMrDoqHi(object P_0, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime uj0S6xfNdto1q4Omka(long value)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long hRB3ljaH8rXhNttA5n(object P_0, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B8ZMTiw6mdDw6GiwO8()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PTG1gFcU1aBpcjjJrN(IntPtr handle, int key, object P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PdP1sKnKRdV5hlwPmm(IntPtr handle)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E1MCOwhNMwUpICrrlQ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SLpcr8DHcDBVUnURVr()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HExfcsUN24PmHbDqqu()
	{
	}
}
