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
public class EmailTestContent
{
	private ConnectionSetup N0QgNILZBx6;

	[CompilerGenerated]
	private EmailModeENUM bcigNQMO2vJ;

	[CompilerGenerated]
	private string k48gNlwQ7hK;

	[CompilerGenerated]
	private string DILgNwGFxj1;

	[CompilerGenerated]
	private string qe1gNprpIPF;

	[CompilerGenerated]
	private string yG4gNaTyvYM;

	[CompilerGenerated]
	private int pZrgNkuYOuK;

	[CompilerGenerated]
	private EmailUploadServerConfig E9MgN0ievOf;

	[CompilerGenerated]
	private EmailDownloadServerConfig lufgNZB69AP;

	[CompilerGenerated]
	private int FuWgNz0kTaM;

	[CompilerGenerated]
	private int shcgiCmgOp2;

	[CompilerGenerated]
	private DataTestMode R1EgiGr1BlJ;

	[CompilerGenerated]
	private int vb0giR308Ex;

	internal static EmailTestContent ppIVXpZC1BINJnhkIITD;

	[Browsable(true)]
	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
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
	[ReadOnly(false)]
	[MyDisplayName("测试方式", "Email Mode")]
	[Browsable(true)]
	public EmailModeENUM EmailMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EmailModeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("收件人邮箱", "Email To")]
	[Browsable(true)]
	public string EmailTo
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
	[Browsable(true)]
	[MyDisplayName("邮件主题", "Email Subject")]
	public string EmailSubject
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
	[MyDisplayName("邮件正文", "Email Body")]
	[Browsable(true)]
	public string EmailBody
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

	[MyDisplayName("邮件附件", "Email Attachment")]
	[ReadOnly(false)]
	[Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public string EmailAttachment
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
	[Browsable(true)]
	[MyDisplayName("接收邮件序号", "Email Receive Index")]
	public int EmailReceiveIndex
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

	[MyDisplayName("发送邮箱设置", "Send Server Config")]
	[ReadOnly(false)]
	[Browsable(true)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public EmailUploadServerConfig UploadServerConfig
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

	[MyDisplayName("接收邮箱设置", "Receive Server Config")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Browsable(true)]
	[ReadOnly(false)]
	public EmailDownloadServerConfig DownloadServerConfig
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
	[ReadOnly(false)]
	[MyDisplayName("发送超时(s)", "Send Timeout(s)")]
	public int SendTimeout
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
	[MyDisplayName("接收超时(s)", "Receive Timeout(s)")]
	[Browsable(true)]
	public int ReceiveTimeout
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
	[MyDisplayName("测试模式", "Test type")]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
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

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("暂停迟滞时长", "Pause Hysteresis")]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmailTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EmailTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ifUT8QZCvXW6psuECwxZ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EmailTestContent cEIw8rZCSeU3SyLjZTRq()
	{
		return null;
	}
}
