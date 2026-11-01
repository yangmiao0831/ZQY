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
public class FTPDLTestContent
{
	private ConnectionSetup u2oghKDfKJ1;

	private FTPSite hhjghtauaul;

	private NetworkTest vqtghusaAf6;

	[CompilerGenerated]
	private FTPDownloadSchema tDGghonFnEK;

	[CompilerGenerated]
	private int OqMghjiwElj;

	[CompilerGenerated]
	private int mNjgh7uiM5Y;

	[CompilerGenerated]
	private int EMGghf1a2kO;

	[CompilerGenerated]
	private int InvghDglqqB;

	[CompilerGenerated]
	private string YXJghBk9Vsa;

	[CompilerGenerated]
	private int AKgghSFZbkq;

	[CompilerGenerated]
	private int bKMghmmGSaG;

	[CompilerGenerated]
	private int R34ghIoWtFL;

	[CompilerGenerated]
	private int CRughQcxBCA;

	[CompilerGenerated]
	private bool ayPghlYAMra;

	[CompilerGenerated]
	private FTPAloneThreadMode ih5ghwfv3DF;

	[CompilerGenerated]
	private DataTestMode T7fghpHUXi9;

	[CompilerGenerated]
	private int rvMghaPUA3Z;

	[CompilerGenerated]
	private int KrMghk85Re9;

	[CompilerGenerated]
	private int hIQgh0iDNmB;

	private static FTPDLTestContent oDSPDlZrupLxtMJpeVa7;

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
	[MyDisplayName("下载模式", "Download Mode")]
	[TypeConverter(typeof(EnumConverter))]
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

	[MyDisplayName("下载时长(s)", "Duration(s)")]
	[Browsable(true)]
	[ReadOnly(false)]
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

	[MyDisplayName("测试超时(s)", "Timeout(s)")]
	[Browsable(true)]
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

	[MyDisplayName("FTP站点配置", "FTP Config")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[ReadOnly(false)]
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

	[MyDisplayName("文件路径", "Download Path")]
	[ReadOnly(false)]
	[Editor(typeof(FTPFileEditor), typeof(UITypeEditor))]
	public string File
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

	[MyDisplayName("登录超时(s)", "Login Timeout(s)")]
	[ReadOnly(false)]
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

	[MyDisplayName("下载尝试次数", "Download Attempt Counts")]
	[ReadOnly(false)]
	public int FileRETRMaxCount
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
	[MyDisplayName("下载尝试时长(s)", "Download Attempt Timeout(s)")]
	public int FileRETRTimeout
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
	[MyDisplayName("下载最高限速(kbps)", "Rate-Limited(kbps)")]
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

	[MyDisplayName("是否限速下载", "Rate-Limited")]
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

	[MyDisplayName("每线程独立下载", "Alone Thread Mode")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
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

	[ReadOnly(false)]
	[MyDisplayName("测试模式", "Test type")]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[Browsable(true)]
	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
	[ReadOnly(false)]
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
	public FTPDLTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FTPDLTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		HLfDg6ZrMSyJBcpswcMR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v4xDHyZr24R6T9u4gAvj(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oDc6qLZrJubf4FdonUYf(object P_0, bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M7JgCAZrykBr2klmPdF6()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FTPDLTestContent A30rjmZr6XHEtR44UcE6()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HLfDg6ZrMSyJBcpswcMR()
	{
	}
}
