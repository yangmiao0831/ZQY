using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class TCPIPCaptureInTask
{
	[Browsable(false)]
	public TCPIPCaptureOn CaptureOnQualcommNR5G;

	[CompilerGenerated]
	private TCPIPCaptureOn tBug6kHBotf;

	[CompilerGenerated]
	private TCPIPCaptureConnectionType r4wg607oKAt;

	[CompilerGenerated]
	private int IiYg6Z2HbL1;

	[CompilerGenerated]
	private TCPIPCaptureDivideFile UkLg6zfj30f;

	private static TCPIPCaptureInTask BFuMDjZ402AYe1tDjC72;

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("是否开启抓包", "Capture On")]
	[TypeConverter(typeof(EnumConverter))]
	public TCPIPCaptureOn CaptureOn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TCPIPCaptureOn)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("抓包网络类型", "Connection Type")]
	[Browsable(true)]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	public TCPIPCaptureConnectionType ConnectionType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TCPIPCaptureConnectionType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[ReadOnly(false)]
	[MyDisplayName("数据包长度(B)", "Snap Length")]
	public int SnapLength
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

	[MyDisplayName("是否分割文件", "Is Divide")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	public TCPIPCaptureDivideFile IsDivide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TCPIPCaptureDivideFile)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TCPIPCaptureInTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TCPIPCaptureInTask()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QJ2mcuZ48T5BN57txesj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JjVxYLZ4PHUua46CKw4V()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TCPIPCaptureInTask zBpEB5Z4cInBVkYoOuuc()
	{
		return null;
	}
}
