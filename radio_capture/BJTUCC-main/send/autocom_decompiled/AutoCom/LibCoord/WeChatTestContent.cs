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
public class WeChatTestContent
{
	private ConnectionSetup BsFgi29ni7c;

	private int NvVgiO6R4NO;

	private int ClagiMh9sgB;

	private int QcXgi514rJM;

	private int S7MgiTBwW9l;

	private int TSFgixiD78c;

	private int UG1giqjcJcO;

	[CompilerGenerated]
	private string sVJgiAcNEil;

	[CompilerGenerated]
	private string l6YgiYLJDRR;

	[CompilerGenerated]
	private string vhSgiHdvgeb;

	[CompilerGenerated]
	private bool vAjgi3Jkq5K;

	[CompilerGenerated]
	private string b1egiJuTE01;

	[CompilerGenerated]
	private int uZ8girU2xfF;

	[CompilerGenerated]
	private bool yEHgi9ag2Fw;

	[CompilerGenerated]
	private IMGSourceEnum fRMgi8DNMn8;

	[CompilerGenerated]
	private bool oSkgiUNjokJ;

	[CompilerGenerated]
	private int tSUgiKjxwN4;

	[CompilerGenerated]
	private bool cjTgit8GgwA;

	[CompilerGenerated]
	private VoiceSourceEnum Su7giucoFQ2;

	[CompilerGenerated]
	private int j5wgiopWyTl;

	[CompilerGenerated]
	private int bdngij0EI52;

	[CompilerGenerated]
	private bool ztngi7gplqD;

	[CompilerGenerated]
	private VideoSourceEnum Xsugify94vl;

	[CompilerGenerated]
	private bool LHagiDnwtI8;

	[CompilerGenerated]
	private int nFJgiBSleYr;

	[CompilerGenerated]
	private bool pJ8giSnAPAI;

	[CompilerGenerated]
	private QRCodeTypeEnum dVCgim0JoLP;

	[CompilerGenerated]
	private int xCVgiIGe5M2;

	[CompilerGenerated]
	private int GaGgiQBaMCt;

	[CompilerGenerated]
	private bool YcUgilQ21mq;

	[CompilerGenerated]
	private FileSourceEnum zTDgiwRywno;

	[CompilerGenerated]
	private FileSelectList etKgipYO0yI;

	[CompilerGenerated]
	private DataTestMode LUIgiaKm0b5;

	private static WeChatTestContent tHWRQhZnyF2iG5kf5LOl;

	[ReadOnly(false)]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[Browsable(true)]
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

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("账号", "Account")]
	public string Account
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
	[MyDisplayName("密码", "Password")]
	public string Password
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
	[MyDisplayName("接收方昵称", "Recipient Name")]
	public string RCVName
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
	[MyDisplayName("消息测试", "Message Test")]
	public bool SendMSG
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
	[MyDisplayName("消息内容", "Message Content")]
	[Browsable(true)]
	public string MSGContent
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
	[MyDisplayName("消息发送超时(s)", "Message Timeout(s)")]
	[ReadOnly(false)]
	public int MSGTimeout
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
	[MyDisplayName("图片测试", "Image Test")]
	public bool SendIMG
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
	[MyDisplayName("图片来源", "Image Source")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	public IMGSourceEnum IMGSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IMGSourceEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("创建图片大小(MB)", "Create Image Size(MB)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int IMGSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MyDisplayName("是否发送原图", "Send Original Image")]
	[ReadOnly(false)]
	[Browsable(true)]
	public bool SendOrgIMG
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

	[MyDisplayName("单次图片发送数量", "Image Count")]
	[Browsable(true)]
	[ReadOnly(false)]
	public int IMGCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("图片发送超时(s)", "Image Timeout(s)")]
	[Browsable(true)]
	public int IMGTimeout
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
	[Browsable(true)]
	[MyDisplayName("语音测试", "Voice Test")]
	public bool SendVoice
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

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("语音来源", "Voice From")]
	[Browsable(true)]
	public VoiceSourceEnum VoiceSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VoiceSourceEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("单次语音发送数量", "Voice Count")]
	public int VoiceCount
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

	[MyDisplayName("语音录制时长(s)", "Voice Duration(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
	public int VoiceDuration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("语音发送超时(s)", "Voice Timeout(s)")]
	public int VoiceTimeout
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
	[MyDisplayName("视频测试", "Video File Test")]
	[Browsable(true)]
	public bool SendVideo
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

	[MyDisplayName("视频来源", "Video Source")]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[ReadOnly(false)]
	public VideoSourceEnum VideoSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VideoSourceEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[ReadOnly(false)]
	[MyDisplayName("是否发送原图", "Send Original Video")]
	public bool SendOrgVideo
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
	[MyDisplayName("创建视频大小(MB)", "Create Video Size(MB)")]
	[Browsable(false)]
	public int VideoSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("视频录制时长(s)", "Video Duration(s)")]
	[Browsable(true)]
	public int VideoDuration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("单次视频发送数量", "Quantity Sent")]
	public int VideoCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[ReadOnly(false)]
	[Browsable(true)]
	[MyDisplayName("视频发送超时(s)", "Video Timeout(s)")]
	public int VideoTimeout
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
	[MyDisplayName("扫码测试", "ScanQRCode Test")]
	public bool ScanQRCode
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

	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("扫码类型", "Scan Type")]
	[Browsable(true)]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	public QRCodeTypeEnum QRCodeType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (QRCodeTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[MyDisplayName("扫码超时(s)", "ScanQRCode Timeout(s)")]
	[ReadOnly(false)]
	public int ScanQRTimeout
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
	[MyDisplayName("单次扫码数量", "ScanCount Pertime")]
	[Browsable(false)]
	public int ScanQRCount
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
	[MyDisplayName("文件测试", "File Test")]
	[ReadOnly(false)]
	public bool SendFile
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

	[MyDisplayName("文件来源", "File Source")]
	[Browsable(true)]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	public FileSourceEnum FileSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FileSourceEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("文件列表", "FileList")]
	[Editor(typeof(FileSelectEditor), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public FileSelectList FileList
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
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	[MyDisplayName("测试模式", "Test Mode")]
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
	public WeChatTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WeChatTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		zHjEyhZnKW4uasbiPAgh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nH6j87ZnJXAM0iGtaAJb()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HHjbb9ZnMLM9PTP02la4(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eXoZ2vZn6eDABOW4LTFd()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WeChatTestContent B8Mn4hZn2ACwvg2FbdZ9()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zHjEyhZnKW4uasbiPAgh()
	{
	}
}
