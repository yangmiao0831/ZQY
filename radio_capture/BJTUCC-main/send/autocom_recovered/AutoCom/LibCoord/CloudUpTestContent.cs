using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class CloudUpTestContent
{
	private ConnectionSetup kB5gb3dGkie;

	[CompilerGenerated]
	private CloudAPPTypeEnum mqfgbJMiUic;

	[CompilerGenerated]
	private CloudUploadSchema vI2gbrdU9uH;

	[CompilerGenerated]
	private int UEYgb9KN6KP;

	[CompilerGenerated]
	private int qv4gb8mGQib;

	[CompilerGenerated]
	private int WBUgbUGBEug;

	[CompilerGenerated]
	private int nCvgbKcUxA4;

	[CompilerGenerated]
	private DataTestMode MIagbtVWFkE;

	private static CloudUpTestContent Cf5PXaZnvK9UdqpCK7Bx;

	[ReadOnly(false)]
	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
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
	[MyDisplayName("APP类型", "APP Type")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("上传模式", "Upload Mode")]
	[ReadOnly(false)]
	public CloudUploadSchema UploadSchema
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CloudUploadSchema)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("上传文件大小(MB)", "Upload File Size(MB)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int UploadSize
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
	[ReadOnly(false)]
	[MyDisplayName("上传时长(s)", "Duration(s)")]
	public int UploadTime
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
	[ReadOnly(false)]
	[MyDisplayName("上传超时(s)", "Timeout(s)")]
	public int UploadTimeout
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

	[MyDisplayName("无流量时长(s)", "No Data Timeout(s)")]
	[ReadOnly(false)]
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

	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[Browsable(true)]
	[MyDisplayName("测试模式", "Test type")]
	[ReadOnly(false)]
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
	public CloudUpTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CloudUpTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		WNKZpqZnXFTYhWmMApkx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lKSBb5ZnI4WvW2AQe71U()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IfGv6yZnSyKj1ELO8jB0()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloudUpTestContent ICqZYsZnmiiNuxb0BkR2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WNKZpqZnXFTYhWmMApkx()
	{
	}
}
