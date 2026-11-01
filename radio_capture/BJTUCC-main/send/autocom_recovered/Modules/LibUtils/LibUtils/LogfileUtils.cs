using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using N6SFqGFYBDLpvREgEy;
using Newtonsoft.Json;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

[Serializable]
public class LogfileUtils
{
	private List<string> CGqLIrXeJd;

	private List<string> zxnLyiTaH2;

	private List<string> OsULeqDQt5;

	private DataTable aHuLANW2qt;

	public LogfileType LogfileType;

	public LogfileUtils OwnerLogfile;

	private string l4rLPxBhmJ;

	[JsonIgnore]
	public int CurrPointIdx;

	[NonSerialized]
	public string FileName;

	[NonSerialized]
	public bool IsConnecting;

	protected IntPtr dbHandle;

	protected bool HasSetBinParamType;

	protected uint dbOpenMode;

	private int nVILpBPtiJ;

	private bool dasL0HeSmC;

	private TimeSpan UMyLvCO7jh;

	[NonSerialized]
	public bool RafDeviceNeedSetTime;

	[NonSerialized]
	public long RafDeviceTimeOffset;

	internal static LogfileUtils fnHhMGTh9JuhGvk0XSc;

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
	public double GetDoubleValueScale(int paramKey, int pointIdx)
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
	public virtual int GetNearPointIdxByLocation(double dlong, double dlat)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeZone()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long ModifyTimeOffset(long lTime)
	{
		return 0L;
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
	public string GetEventProperty(int EventCode, int EventIndex, ref bool allReaded)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasEventProperty(int EventCode, int EventIndex)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEventDetail(int EventCode, int EventIndex)
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
	public double GetStatisticScale(int paramKey, string conditions, string aggType)
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
	public bool BackupUTS(string divideFile = "")
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
	public double PrepareValueScale(IntPtr handle, int paramKey)
	{
		return 0.0;
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
	public double GetScalarDoubleByEventProperty(int paramKey, string conditions)
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
	public void BeginTrans()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void CommitTrans()
	{
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
	public IntPtr PrepareSQL(string sql)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void UnPrepareSQL(IntPtr stmt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public bool PrepareSQLNext(IntPtr stmt)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public double PrepareSQLValue(IntPtr stmt, int fieldIdx)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public string PrepareSQLStrValue(IntPtr stmt, int fieldIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void BindDouble(IntPtr stmt, int col, double value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void BindInteger(IntPtr stmt, int col, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void BindInt64(IntPtr stmt, int col, long value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void BindText(IntPtr stmt, int col, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void BindStep(IntPtr stmt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public void BindReset(IntPtr stmt)
	{
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
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					wlFNmLTPLnZAQSQ9ugR();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 1:
					kgLJMFTN6CYSIVLFENH();
					num2 = 3;
					continue;
				case 3:
					uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
					num2 = 0;
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
	internal static bool faRCSkTBG5J75c8x1kj()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LogfileUtils JrDcZbTLDOUjVOVeZac()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nJLgxDTZ5ZP8xims5Qm(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double WFje4PT7DXavu1UC2uB(int paramCode)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double V0j6skTxRrt4gxIGll0(IntPtr handle, int paramKey)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oMlAJJT30uTgwsaoVSB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Dy4YsSTFNCT6nZ0UrJa(object P_0, int pointIdxKey, int pointIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pj3o4QTIjEg9Tl0lu8P(object P_0, int pointIdxKey, int pointIdx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wywgKeTCX7utm8L9mwk(IntPtr handle)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y9Bb61TdqeId6HlnE05()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long aQbXfCTodgrgRUconJ5(IntPtr handle, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long cWe8ViTismmfx4o5OIS(IntPtr handle, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long qCkRjWTrBw9AwKTvUFg(IntPtr handle, int iEventIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long FGJTO3TKJCUUYDK8xTv(object P_0, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime sK2RR1TnTXogWbooSIX(long value)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long uKIO63TWQ07n6EsKCDQ(object P_0, int iPointIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jg167oTjqa4i5CMWbtD(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jTrf0hTMPScN7pSfSEa(double d)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VYy2mwTYGvwOCVAJ7hT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object peZqguTgeIntoUc3g1p(int Code, int OrgValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int el6779THeejy7KtZdR0(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vxKDspTSTQgyJKNYxpC(IntPtr handle, int key, object P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dyvU18TDxkInN6cgWlY(IntPtr handle)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint wh40B7TRoUd7G5XOVKo(IntPtr handle)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C1Gf2PTmsrjjBYQTc2m(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr b1kYhaTUBVvlkU99UjW(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ULpEiiT5A6xX7FTJRu6(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kgLJMFTN6CYSIVLFENH()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BfPH5bTqlqGBKpmBq14()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wlFNmLTPLnZAQSQ9ugR()
	{
	}
}
