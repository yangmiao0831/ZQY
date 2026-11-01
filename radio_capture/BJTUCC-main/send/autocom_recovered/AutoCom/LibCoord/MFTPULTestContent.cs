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
public class MFTPULTestContent
{
	private ConnectionSetup clDg1uHSGoo;

	private string wMJg1oFyOfr;

	private NetworkTest ouWg1jXGQMC;

	[CompilerGenerated]
	private MFTPULServerList a3pg179or80;

	[CompilerGenerated]
	private FTPUploadSchema hd2g1fYXabr;

	[CompilerGenerated]
	private int hOBg1Dasbe0;

	[CompilerGenerated]
	private int FYTg1BQkCTk;

	[CompilerGenerated]
	private int zGUg1S3m0BQ;

	[CompilerGenerated]
	private int du8g1m4vGK5;

	[CompilerGenerated]
	private int lQxg1IMGOBE;

	[CompilerGenerated]
	private int OeIg1QQ7drS;

	[CompilerGenerated]
	private int jo1g1lEY9MF;

	[CompilerGenerated]
	private int hvxg1wU4SQK;

	[CompilerGenerated]
	private int TFog1pI5vDr;

	[CompilerGenerated]
	private bool dVwg1abIthw;

	[CompilerGenerated]
	private DataTestMode Imdg1kCe3y0;

	[CompilerGenerated]
	private int EUqg10GGC8E;

	[CompilerGenerated]
	private int Gegg1ZngY84;

	[CompilerGenerated]
	private int xtmg1z3aO3J;

	private static MFTPULTestContent YoP7tAZDu5nib0JGc2BO;

	[TypeConverter(typeof(ExpandableObjectConverter))]
	[ReadOnly(false)]
	[MyDisplayName("网络连接配置", "Network Connection Settings")]
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

	[MyDisplayName("多路服务器", "Multi Server")]
	[Editor(typeof(MFTPServerEditor), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[ReadOnly(false)]
	public MFTPULServerList ServerAry
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

	[MyDisplayName("上传模式", "Upload Mode")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
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
	[ReadOnly(false)]
	[MyDisplayName("本地路径", "Upload File Path")]
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

	[MyDisplayName("上传大小(M)", "Upload Size(M)")]
	[Browsable(true)]
	[ReadOnly(false)]
	public int FileSize
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
	[MyDisplayName("上传时长(s)", "Duration(s)")]
	[Browsable(true)]
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

	[ReadOnly(false)]
	[MyDisplayName("登录超时(s)", "Login Timeout(s)")]
	public int LoginTimeout
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
	[MyDisplayName("上传尝试次数", "Upload Attempt Counts")]
	public int FileSTORMaxCount
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
	[MyDisplayName("上传尝试超时(s)", "Upload Attempt Timeout(s)")]
	public int FileSTORTimeout
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

	[MyDisplayName("上传最高限速(kbps)", "Rate-Limited(kbps)")]
	[ReadOnly(false)]
	[Browsable(false)]
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

	[ReadOnly(false)]
	[MyDisplayName("是否限速上传", "Rate-Limited")]
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

	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int PauseHysteresis
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
	[MyDisplayName("TCP发送缓存(KB)", "Send Buffer Size(KB)")]
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

	[ReadOnly(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Browsable(false)]
	[MyDisplayName("网络联通性检测", "Network Check")]
	public NetworkTest NetworkTest
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
	public MFTPULTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MFTPULTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		swTJULZDoRuFjPgvwQNr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KJUWEjZD282VDXn1juKd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DedwQmZDJ7Sl6pdk1geJ(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool krPMm0ZDyLC4gG4XFR1W()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MFTPULTestContent QDjKjjZD6eke6uUNjQEO()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VCFa64ZDMFedapPQ91av(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long FTN6KIZDKmX99B3kdfhH(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double s0cH9xZDZ08k1CZmUVBq(double P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void swTJULZDoRuFjPgvwQNr()
	{
	}
}
