using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class HTTPUpTestContent
{
	private ConnectionSetup nalgickKeVZ;

	private string O7mgiLuWMUe;

	[CompilerGenerated]
	private HTTPUpProtocolTypeENUM TUYgivDrQan;

	[CompilerGenerated]
	private string qT3gisRcpmT;

	[CompilerGenerated]
	private int Fiugi60rHw2;

	[CompilerGenerated]
	private FTPUploadSchema DiIgihleEWT;

	[CompilerGenerated]
	private double XsFgi1Dns1T;

	[CompilerGenerated]
	private int gBUgidC12Zd;

	[CompilerGenerated]
	private int krggiW826dD;

	[CompilerGenerated]
	private int EJrgi4Q4UEF;

	[CompilerGenerated]
	private int aovgiNslE62;

	[CompilerGenerated]
	private int q0Agiiy3cHj;

	[CompilerGenerated]
	private bool kcrgiFg21ZF;

	[CompilerGenerated]
	private DataTestMode Iu7gibxJPnb;

	[CompilerGenerated]
	private int HXtgiV24vmd;

	[CompilerGenerated]
	private int YlMgiXBoA41;

	private static HTTPUpTestContent W17mb8ZCOcUik3YsiuJF;

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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("协议类型", "Download Mode")]
	public HTTPUpProtocolTypeENUM ProtocolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HTTPUpProtocolTypeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("URL地址", "URL")]
	public string URLAddress
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

	[ReadOnly(false)]
	[MyDisplayName("连接超时(s)", "Connect Timeout(s)")]
	public int ConnectTimeout
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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("上传模式", "Upload Mode")]
	public FTPUploadSchema UploadSchema
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FTPUploadSchema)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
	[MyDisplayName("本地路径", "Upload File Path")]
	[ReadOnly(false)]
	public string FilePath
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

	[Browsable(true)]
	[MyDisplayName("上传大小(M)", "Upload Size(M)")]
	[ReadOnly(false)]
	public double FileSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
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
	[MyDisplayName("测试超时(s)", "Upload Timeout(s)")]
	[ReadOnly(false)]
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

	[MyDisplayName("线程数量", "Thread Counts")]
	[ReadOnly(false)]
	public int Thread
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

	[Browsable(false)]
	[ReadOnly(false)]
	[MyDisplayName("上传最高限速(kbps)", "Rate-Limited(kbps)")]
	public int RateLimited
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

	[MyDisplayName("是否限速上传", "Rate-Limited")]
	[ReadOnly(false)]
	public bool LimitSwitch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("测试模式", "Test type")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[MyDisplayName("TCP发送缓存(KB)", "Send Buffer Size(KB)")]
	[ReadOnly(false)]
	public int TCP_Windows_SendBufferSize
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
	[MyDisplayName("TCP接收缓存(KB)", "Receive Buffer Size(KB)")]
	public int TCP_Windows_RecvBufferSize
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HTTPUpTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HTTPUpTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		pOkbT2Znuv7Jf4FLJhsv();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WvgGnHZCztGBBi226x1m()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IcFxG0ZnL3MVlpmgHQpF(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wAVe7QZC5h23DbufDhG8()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HTTPUpTestContent NetnJBZCiyc3L4xZcI0h()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XWOy3xZnNoPLUXmhC0E4(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double L3q9h3ZnYbnpSGdb4Mhd(double P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pOkbT2Znuv7Jf4FLJhsv()
	{
	}
}
