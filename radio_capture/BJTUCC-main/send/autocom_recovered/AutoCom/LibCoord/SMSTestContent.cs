using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class SMSTestContent
{
	[CompilerGenerated]
	private SMSModeENUM tDyginxLti9;

	[CompilerGenerated]
	private string pODgigw5V0I;

	[CompilerGenerated]
	private string E4SgiejkiGE;

	[CompilerGenerated]
	private string UpmgiPdkTsq;

	[CompilerGenerated]
	private int SPjgiEnSywu;

	[CompilerGenerated]
	private int q8pgiyi6Dj2;

	private static SMSTestContent TYHAyIZCmRFjRuLG8ZAw;

	[Browsable(true)]
	[MyDisplayName("测试方式", "SMS Mode")]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	public SMSModeENUM SMSMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SMSModeENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("接收号码", "Called Number")]
	[ReadOnly(false)]
	public string CalledNumber
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
	[MyDisplayName("本机号码", "Calling Number")]
	public string CallingNumber
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
	[MyDisplayName("短信内容", "SMS Content")]
	public string SMSContent
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

	[MyDisplayName("发送超时(s)", "Send Timeout(s)")]
	[ReadOnly(false)]
	[Browsable(true)]
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

	[Browsable(true)]
	[MyDisplayName("接收超时(s)", "Receive Timeout(s)")]
	[ReadOnly(false)]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SMSTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SMSTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cAbgbfZCUPfSZTSIX8Pj(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cQfM0mZCIKlbZ0dXoSaQ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SMSTestContent Qnt35fZCXUWAp5kSx9Ho()
	{
		return null;
	}
}
