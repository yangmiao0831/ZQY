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
public class MFTPDLTestContent
{
	private ConnectionSetup DaCg1Xe5eYh;

	private NetworkTest GmXg12INd2k;

	[CompilerGenerated]
	private MFTPServerList X8pg1OBSppv;

	[CompilerGenerated]
	private FTPDownloadSchema c8ig1M4sJWx;

	[CompilerGenerated]
	private int mckg15JYwT0;

	[CompilerGenerated]
	private int wg7g1TxhL06;

	[CompilerGenerated]
	private int ayig1xkthgZ;

	[CompilerGenerated]
	private int NI7g1qlqFhy;

	[CompilerGenerated]
	private int vB7g1AbIKpD;

	[CompilerGenerated]
	private int o5Yg1YmcKY6;

	[CompilerGenerated]
	private int PhXg1HkGJQk;

	[CompilerGenerated]
	private int inZg13yjkqQ;

	[CompilerGenerated]
	private bool wQIg1JZFKE1;

	[CompilerGenerated]
	private DataTestMode xQEg1rm0Mpr;

	[CompilerGenerated]
	private int J9Zg19Os2xa;

	[CompilerGenerated]
	private int LlGg18UH6IZ;

	[CompilerGenerated]
	private int BJGg1UMM6ls;

	internal static MFTPDLTestContent scQQKCZr8LUOS0EeMuIv;

	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[ReadOnly(false)]
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

	[ReadOnly(false)]
	[Editor(typeof(MFTPServerEditor), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[MyDisplayName("多路服务器", "Multi Server")]
	public MFTPServerList ServerAry
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

	[MyDisplayName("下载模式", "Download Mode")]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("测试超时(s)", "Timeout(s)")]
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

	[ReadOnly(false)]
	[MyDisplayName("是否限速下载", "Rate-Limited")]
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

	[MyDisplayName("测试模式", "Test type")]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
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

	[ReadOnly(false)]
	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
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
	[MyDisplayName("网络联通性检测", "Network Check")]
	[Browsable(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
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
	public MFTPDLTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MFTPDLTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EhnMiEZr4Yqbfl8qAobD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gH9tyjZrrZe4RteTjJjp(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ldXMScZrw7FlOjhrp8LC()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MFTPDLTestContent cgpInrZrh9VlI1RhsHS6()
	{
		return null;
	}
}
