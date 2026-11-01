using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class CloudDownTestContent
{
	private ConnectionSetup cPPgbMKyiVy;

	[CompilerGenerated]
	private CloudAPPTypeEnum bf9gb5tSDDT;

	[CompilerGenerated]
	private string H7ygbTuLBu1;

	[CompilerGenerated]
	private FTPDownloadSchema Jk6gbxrKSe9;

	[CompilerGenerated]
	private int WqogbquKbcE;

	[CompilerGenerated]
	private int TYZgbAAuQFu;

	[CompilerGenerated]
	private int aO2gbYhxiW8;

	[CompilerGenerated]
	private DataTestMode HmBgbHjAF64;

	internal static CloudDownTestContent CIEQQGZnspt9qGYRoscU;

	[TypeConverter(typeof(ExpandableObjectConverter))]
	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[ReadOnly(false)]
	public ConnectionSetup ConnectionSetup
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

	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("APP类型", "APP Type")]
	[ReadOnly(false)]
	public CloudAPPTypeEnum APPType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CloudAPPTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("下载文件名", "Download File")]
	[ReadOnly(false)]
	public string DownloadFile
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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("下载模式", "Download Mode")]
	[ReadOnly(false)]
	public FTPDownloadSchema DownloadSchema
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FTPDownloadSchema)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("下载时长(s)", "Duration(s)")]
	public int DownloadTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("下载超时(s)", "Timeout(s)")]
	[ReadOnly(false)]
	public int DownloadTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("无流量时长(s)", "No Data Timeout(s)")]
	public int NoFlowTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("测试模式", "Test type")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	public DataTestMode TestMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DataTestMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CloudDownTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CloudDownTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xXCGqNZnkiopraeDPGKQ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dRMVg2Zn1G6WwInj4QmW(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pqhgniZnlSFNSPiB0vtD()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloudDownTestContent wSDnphZn9tNCJ07uj8kM()
	{
		return null;
	}
}
