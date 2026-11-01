using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPOI.SS.UserModel;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord.ReportForms;

public class ReportBase : IReport
{
	protected readonly List<RPTDataModel> dataList;

	protected string resultFile;

	protected UpdateProgressHandle _updateProgress;

	protected IWorkbook workbook;

	protected ReportDefine Define;

	private static ReportBase uthIFkMQTgofik7m3oNQ;

	public string ResultFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public UpdateProgressHandle UpdateProgressHandle
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

	protected string ResultPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool DoWriteReport()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool WriteReport(IList<RPTDataModel> datas, ReportDefine define)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateProgress(string progress)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected double Sum(params double[] values)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected IRow CopyRow(ISheet sheet, int srcRowId, int desRowId)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string O3enqumE1Yw(ICell P_0, ICell P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetCellValue(ICell cell, double value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetCellValue(ICell cell, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ICell GetCell(IRow row, int index)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DeleteRow(ISheet sheet, int rowId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReportBase()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReportBase()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AyJDVQMQRq5wB3uje0rg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime bYC3j9MQG4kBFE4U7H61()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PaQ1qrMQ3rVv9VmqFiBk(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jDgO5AMQF1bhdMpCTLa0(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CdEmn0MQpjt9VI48Vw1n()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReportBase gRGeLQMQQl2UqV0j2Kqm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wyYAZ3MQ7hsuivhwHnn8(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hSfVJSMQbdhmgbkqNwWu(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uHIPiTMQg6Vk9WjNc5Jx(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JYtOZaMQf0xLs14cFy4k(object P_0, int P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NbRSAYMQj3ktxQAN3HdZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q8VYPsMQeAAseSg3XHQE(double value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x7TjcxMQ0hDueepI7qMJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vUYoudMQPZenyp4VIF0s(object P_0, double P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TQ8y59MQcyWuHvajnjdK(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lRK7KmMQ8pltZl9sH9qY(object P_0, object P_1)
	{
	}
}
