using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace WebPolqaMessageWorker;

public class TestDataHeader
{
	public int Version;

	public OperateType Operate;

	public long Id;

	public string ProjectName;

	public string Province;

	public string City;

	public string DataGroup;

	public string TestUserName;

	public int DeviceType;

	public string UEID;

	public int Operator;

	public double Longitude;

	public double Latitude;

	[JsonConverter(typeof(DateFormat))]
	public DateTime StartTime;

	[JsonConverter(typeof(DateFormat))]
	public DateTime EndTime;

	public SendFileHeader DataFile;

	public AckMsg Ack;

	private static TestDataHeader RaRDRMBgqrnVBr2kDxnU;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestDataHeader()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestDataHeader()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		MHRXieBgpZdOdCPru9xf();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U32bxLBgT6S0c45XL45L()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hn3ZEpBgEt0Ti6CNcA4O()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TestDataHeader hCER7JBgVWsjIYMXK68r()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MHRXieBgpZdOdCPru9xf()
	{
	}
}
