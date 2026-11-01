using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class FTPULTestContent
{
	private ConnectionSetup MQHghZPBgfs;

	private string Y0vghz1v359;

	private FTPSite qdsg1Co8mq6;

	private NetworkTest G3mg1GDR86B;

	[CompilerGenerated]
	private FTPUploadSchema fqlg1R2Rat2;

	[CompilerGenerated]
	private double KLPg1n9NPsE;

	[CompilerGenerated]
	private string OWwg1ghaqLV;

	[CompilerGenerated]
	private int G30g1eXTwPB;

	[CompilerGenerated]
	private int YZng1PwuIlf;

	[CompilerGenerated]
	private int iytg1EsiB6Z;

	[CompilerGenerated]
	private int uHPg1yLgcpJ;

	[CompilerGenerated]
	private string piFg1cqfQ3d;

	[CompilerGenerated]
	private int Kb5g1LpomhF;

	[CompilerGenerated]
	private int rsag1vJRxGx;

	[CompilerGenerated]
	private int kCAg1sCg0im;

	[CompilerGenerated]
	private bool Pvjg16EI70Y;

	[CompilerGenerated]
	private bool Q03g1hHHo5W;

	[CompilerGenerated]
	private int Jfag1159dTZ;

	[CompilerGenerated]
	private bool sHqg1dA7rcs;

	[CompilerGenerated]
	private FTPAloneThreadMode Fkmg1WcFuXZ;

	[CompilerGenerated]
	private DataTestMode zSZg14VChYl;

	[CompilerGenerated]
	private int Lfwg1NuyMHG;

	[CompilerGenerated]
	private int VHSg1i6EfRN;

	[CompilerGenerated]
	private int g6vg1FrYxNc;

	private static FTPULTestContent NqdTGEZrKWMJIddTXhpO;

	[ReadOnly(false)]
	[MyDisplayName("网络连接配置", "Network Connection Settings")]
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

	[MyDisplayName("本地路径", "Upload File Path")]
	[ReadOnly(false)]
	[Editor(typeof(MultiSelectFileNameEditor), typeof(UITypeEditor))]
	[Browsable(true)]
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

	[Browsable(false)]
	[ReadOnly(false)]
	public string FileSizeArray
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

	[Browsable(true)]
	[MyDisplayName("上传时长(s)", "Duration(s)")]
	[ReadOnly(false)]
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

	[MyDisplayName("测试超时(s)", "Upload Timeout(s)")]
	[Browsable(true)]
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

	[ReadOnly(false)]
	[MyDisplayName("线程数量", "Thread Counts")]
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
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[MyDisplayName("FTP站点配置", "FTP Config")]
	public FTPSite FTPSite
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

	[Editor(typeof(FTPFileEditor), typeof(UITypeEditor))]
	[ReadOnly(false)]
	[MyDisplayName("上传路径", "Upload Path")]
	public string StorePath
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

	[MyDisplayName("删除已上传文件", "Delete Uploaded File")]
	[ReadOnly(false)]
	public bool DeleteUploadedFile
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
	[Browsable(false)]
	[MyDisplayName("校验上传文件一致性", "Verify the uploaded file")]
	public bool FileMD5Check
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

	[MyDisplayName("上传最高限速(kbps)", "Rate-Limited(kbps)")]
	[Browsable(false)]
	[ReadOnly(false)]
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("每线程独立上传", "Alone Thread Mode")]
	[ReadOnly(false)]
	public FTPAloneThreadMode AloneThreadMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FTPAloneThreadMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("测试模式", "Test type")]
	[ReadOnly(false)]
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

	[MyDisplayName("网络联通性检测", "Network Check")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[ReadOnly(false)]
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
	public FTPULTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FTPULTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		C2D9p5ZrQlM7rMIfkWD0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QrcxBqZrxBYjSakNlZrq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xl0brkZrAZcwGfOT0BF6(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AQ4gYlZrtcjJlYhuhc43(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xgnJADZrWku2qGFwSDas(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yu0mHEZrZGegIJcp6dQR()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FTPULTestContent l9AQyJZroHxtyC3y4xlc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Phfj6PZrBGganU5sFhly(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e2UjmhZrqEHZQxgYBqJM(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ByqtxNZrED26wbh2kLI2(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long YEbmiHZrV9EbDJ8nXLxj(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double DCoSL1ZrTkfHly1AKrZE(double P_0, int P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aen3U1ZrpbxhxOGLcdIo(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C2D9p5ZrQlM7rMIfkWD0()
	{
	}
}
