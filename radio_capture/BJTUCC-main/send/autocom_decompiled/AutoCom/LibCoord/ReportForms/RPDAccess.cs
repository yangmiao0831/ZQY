using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord.ReportForms;

public class RPDAccess
{
	private string Kv0n9uTXPY9;

	private IntPtr Paen9o5Byw8;

	public bool HasFilter;

	internal static RPDAccess C276AaMDbSx7Fa7nPVmF;

	public IntPtr Handle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IntPtr)(object)null;
		}
	}

	public string LogName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double EventTime(int eventId, int pointIndex, int endPointIndex)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEventPointIndex(int eventId, int pointIndex, int endPointIndex)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointRange GetPointRange(int pointIndex, int durance)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetAggregate(int key, string aggTag, string condition = "", Dictionary<int, string> complexCondition = null)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPI(int key, string condition = "", Dictionary<int, string> complexCondition = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetAverage(int key, string condition = "", Dictionary<int, string> complexCondition = null)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetCount(int key, string condition = "")
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetEdge(int key, int edgeValue)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetFirstValue(int key, int pointIndex, int endPointIndex)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetMax(int key, string condition = "")
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetMin(int key, string condition = "")
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetPdf(int key, string pdfCondition, string condition = "")
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OpenFile(string fileName, int mode = 1000)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntPtr Prepare(string sql)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int PrepareIntValue(IntPtr stmt, int index)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double PrepareDoubleValue(IntPtr stmt, int index)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PrepareNext(IntPtr stmt)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string PrepareStringValue(IntPtr stmt, int index)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RangeToCondition(PointRange pointRange)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnPrepare(IntPtr stmt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetTableInfo(int key, out string strTable, out string strField)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double SQLGetValue(string sql)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SQLGetValue(string sql, out double value1, out double value2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetDurationPdf(int key, string pdfCondition, string condition = "")
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetDuration(int key, string condition)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetMileage(int key, string condition)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetMileage_1(int key, string condition)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetMileagePdf(int key, string pdfCondition, string condition = "")
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPIPdf(int key, string pdfCondition, string condition = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPIEdge(int key, int edgeValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPIDurationPdf(int key, string pdfCondition, string condition = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPIMileagePdf(int key, string pdfCondition, string condition = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPIMileage(int key, string condition)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPIDurance(int key, string condition)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddDiscreteKPI(int key, string condition = "", Dictionary<int, string> complexCondition = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPIBin(int key, int size, string condition = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPISql(string sql)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RPDAccess CreateBin(int binType, int binSize, int valueType, string binFileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetStatistic(int paramKey, string condition, string aggType)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Execute(string sql)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindDouble(IntPtr stmt, int col, double value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindInteger(IntPtr stmt, int col, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindInt64(IntPtr stmt, int col, long value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindText(IntPtr stmt, int col, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindStep(IntPtr stmt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindReset(IntPtr stmt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeginTrans()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CommitTrans()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AttachUTS(string fileName, string alias)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DetachUTS(string alias)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddKPI(DefineItem kpiDefine)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KPI AddSectionKPI(ParamCondition paramDef)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ConfigFilter(OneFilter filter)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RPDAccess()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RPDAccess()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xv0OdxMdWerdqar1ZPYw();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object muTbIpMDjKWe8HQAkrEX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReAKEfMDgS4Vbl5jNDuP()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RPDAccess j9GpdYMDfXcy4iJulooX()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nLoNM3MDexbZ7ytuGfeJ(IntPtr P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ft8UZwMD0AKDhSIWYrPr(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lpLbhqMDPwcdbVDdvIXI(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WPymlyMDcEMNJKuJ917M(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object peQQm6MD8lUY22ncxlDW(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FbV9dtMDwx8iAO191GpJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TNIphSMDh21TPLq9d61m(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BWnU6gMD4gsFR7pY9Dv7(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Mef2pHMDrd4hrax8DhxA(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BtfkNHMDDoOL32H5BELy(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr Ctvxw0MDdDtMug53whbj(object P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L7QHktMDCOeKDO68ypS3(IntPtr P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ks7YdEMDnUpRZJQemGX0(IntPtr P_0, IntPtr P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QAy8IWMDasC5tn7YpAJl(IntPtr P_0, IntPtr P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr PotVHsMDH7uZCFy8oEmJ(IntPtr P_0, IntPtr P_1, int P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w1W9Y6MDsnYeu8YHZpZJ(IntPtr P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BMFFkFMDlShlW9iETt3v(IntPtr P_0, IntPtr P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr a7oR2gMD9XxGjY3gqNIo(int P_0)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tBCtlsMDk6ItDbZJJlBO(int P_0, IntPtr P_1, IntPtr P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iF9YIuMD189EJHB1JuT7(IntPtr P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr q2qSAQMDvtVICCTKC8Mo(IntPtr P_0, IntPtr P_1)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double uLQVZ3MDSOk7rQZCOTlj(IntPtr P_0, IntPtr P_1, int P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JtwfMZMDmr8srtWl2Hsx(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nlwkhVMDIgYyZO93XhDx(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aOVdFxMDXQO0O0Lvitc6(IntPtr P_0, IntPtr P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr OviyeIMDU9jTJTFtC4J3(IntPtr P_0, int P_1, int P_2, int P_3, object P_4)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QEdicZMDO20UQdMAuYYd(IntPtr P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double XO4KaKMD557BBfLTiBeQ(double P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int B6WFpOMDiZMDjCrv7ZMD(IntPtr P_0, IntPtr P_1, int P_2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XY27lxMDzmRMrl5LicCZ(IntPtr P_0, IntPtr P_1, int P_2, double P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int k7VNblMdLMAHYB0sY3L2(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ltw4fcMdNfQyBOj6qm9i(IntPtr P_0, IntPtr P_1, int P_2, int P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long HQ08qTMdYPmhwqRXcMqJ(long P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gPdO9OMduxxfifZv8SyT(IntPtr P_0, IntPtr P_1, int P_2, long P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B5S6bVMdy8t4VFTVPS7J(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NPvifoMd6vru2fY9RB4L(IntPtr P_0, IntPtr P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T8drMXMd2YFepTbEKwQc(IntPtr P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool snM5C1MdJPOtFFiVITe9(IntPtr P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vMT1PAMdMyeZ6M2Nne8D(IntPtr P_0, object P_1, object P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool N6fRElMdKSsyG6bKGBEK(double value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FqcEWGMdZeJrnCLEn2Ho(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ySG1gcMdoAsFeCrACx34(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EaMPEUMdx0w4iQ6No5Cd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool npfU7rMdAbU7fLHof498(IntPtr P_0, bool P_1, int P_2, object P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DTKdBdMdtVaB7VFnOyco()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xv0OdxMdWerdqar1ZPYw()
	{
	}
}
